using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

namespace ATS_API
{
    public static partial class TextMeshProManager
    {
        private static List<Texture2D> m_pendingSpriteAssets = new List<Texture2D>();
        private static List<TMP_SpriteAsset> m_spriteAssetLooking = new List<TMP_SpriteAsset>();
        private static bool s_instantiated = false;
        private static bool s_dirty = false;


        public static void Add(Texture2D texture, string imageName)
        {
            s_dirty = true;
            texture.name = imageName.ToLower();
            m_pendingSpriteAssets.Add(texture);
            // Plugin.Log.LogInfo($"Adding {imageName} to TMP\n" + Environment.StackTrace);
        }

        public static void Replace(Texture2D texture, string imageName)
        {
            s_dirty = true;
            texture.name = imageName.ToLower();
            m_pendingSpriteAssets.Add(texture);
            // Plugin.Log.LogInfo($"Replacing {imageName} in TMP\n" + Environment.StackTrace);
        }

        public static void Instantiate()
        {
            s_instantiated = true;
            m_spriteAssetLooking.Add(TMP_Settings.defaultSpriteAsset);
        }

        public static void Tick()
        {
            if (s_dirty)
            {
                Sync();
            }
        }

        public static void Sync()
        {
            if (!s_instantiated)
            {
                return;
            }
            Plugin.Log.LogInfo("Syncing TMP " + m_pendingSpriteAssets.Count);
            
            
            // check if the asset exists in m_spriteAssets
            // if it is then replace the existing asset and apply the changes at the end
            // otherwise add the new asset to the fallback asset
            HashSet<Texture2D> texturesPendingApply = new HashSet<Texture2D>();
            List<Texture2D> texturesToAdd = new List<Texture2D>();

            foreach (Texture2D texture in m_pendingSpriteAssets)
            {
                bool replacedExistingAsset = false;
                foreach (TMP_SpriteAsset asset in m_spriteAssetLooking)
                {
                    if (ReplaceAsset(asset, texture.name, texture))
                    {
                        replacedExistingAsset = true;
                        texturesPendingApply.Add((Texture2D)asset.spriteSheet);
                        break;
                    }
                }
                
                if (!replacedExistingAsset)
                {
                    texturesToAdd.Add(texture);
                }
            }

            foreach (Texture2D texture2D in texturesPendingApply)
            {
                texture2D.Apply();
            }

            // Create a new TMP_SpriteAsset and add it to the fallback sprite assets
            if (texturesToAdd.Count > 0)
            {
                TMP_SpriteAsset newAsset = TMPHelpers.CreateSpriteAsset(texturesToAdd);
                newAsset.name = "FallbackSpriteAsset_" + m_spriteAssetLooking.Count;
                TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(newAsset);
                m_spriteAssetLooking.Add(newAsset);
            }


            // Uncomment to export the sprite sheet to disk. Great for debugging
            // foreach (TMP_SpriteAsset asset in m_spriteAssetLooking)
            // {
            //     if (!asset.spriteSheet.isReadable)
            //     {
            //         var newSpriteSheet = TextureHelper.GetReadableTexture((Texture2D)asset.spriteSheet);
            //         newSpriteSheet.name = asset.spriteSheet.name;
            //         asset.spriteSheet = newSpriteSheet;
            //         asset.material.SetTexture("_MainTex", asset.spriteSheet);
            //     }
            //     TextureHelper.ExportTextureToAssets((Texture2D)asset.spriteSheet, Application.persistentDataPath + "/" + asset.name + ".png");
            // }
            
            m_pendingSpriteAssets.Clear();
            s_dirty = false;
        }

        private static bool ReplaceAsset(TMP_SpriteAsset asset, string spriteName, Texture2D texture2D)
        {
            foreach (TMP_SpriteCharacter sprite in asset.spriteCharacterTable)
            {
                if (sprite.name != spriteName)
                {
                    continue;
                }

                // Plugin.Log.LogInfo($"Replacing {spriteName} in Sprite Asset {asset.name}");
                Texture2D assetSpriteSheet = (Texture2D)asset.spriteSheet;
                if (!assetSpriteSheet.isReadable)
                {
                    var readableTexture = TextureHelper.GetReadableTexture(assetSpriteSheet);
                    readableTexture.name = assetSpriteSheet.name;
                    assetSpriteSheet = readableTexture;
                    asset.spriteSheet = assetSpriteSheet;
                    asset.material.SetTexture("_MainTex", readableTexture);
                }

                Glyph glyph = sprite.glyph;
                int x = glyph.glyphRect.x;
                int y = glyph.glyphRect.y;
                int width = glyph.glyphRect.width;
                int height = glyph.glyphRect.height;

                // Resize sourceTexture so it has the same width and height as the glyph
                Texture2D sourceTextureResized = null;
                if (texture2D.width == width && texture2D.height == height)
                {
                    sourceTextureResized = texture2D;
                }
                else
                {
                    sourceTextureResized = TextureHelper.ResizeTexture(texture2D, width, height);
                }


                // Apply texture2D to the sprite sheet accounting for change in size
                assetSpriteSheet.SetPixels(x, y, width, height, sourceTextureResized.GetPixels());
                return true;
            }

            return false;
        }
    }
}