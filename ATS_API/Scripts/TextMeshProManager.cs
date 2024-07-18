using System.Collections.Generic;
using ATS_API.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

namespace ATS_API
{
    public static partial class TextMeshProManager
    {
        private class TexturesToReplace
        {
            public Texture2D texture;
            public string imageName;
        }
        
        private static List<Texture2D> customImages = new List<Texture2D>();

        private static HashSet<string> m_scenesProcessed = new HashSet<string>();
        private static List<TexturesToReplace> texturesToReplace = new List<TexturesToReplace>();
        private static bool s_instantiated = false;
        private static bool s_dirty = false;
        private static int customImagesStartingIndex = 0;


        public static void Add(Texture2D texture, string imageName)
        {
            s_dirty = true;
            texture.name = imageName;
            customImages.Add(texture);
        }

        private static void ReplaceAll()
        {
            HashSet<Texture2D> dirtyTextures = new HashSet<Texture2D>();
            foreach (TexturesToReplace replacement in texturesToReplace)
            {
                TMP_SpriteAsset asset = TMP_Settings.defaultSpriteAsset;
                foreach (TMP_SpriteCharacter sprite in asset.spriteCharacterTable)
                {
                    if (sprite.name != replacement.imageName)
                    {
                        continue;
                    }

                    Texture2D assetSpriteSheet = (Texture2D)asset.spriteSheet;
                    if (!assetSpriteSheet.isReadable)
                    {
                        var readableTexture = TextureHelper.GetReadableTexture(assetSpriteSheet);
                        readableTexture.name = assetSpriteSheet.name;
                        assetSpriteSheet = readableTexture;
                        asset.spriteSheet = assetSpriteSheet;
                        asset.material.SetTexture("_MainTex", readableTexture);
                        TMP_Settings.defaultSpriteAsset = asset;
                    }

                    Glyph glyph = sprite.glyph;
                    int x = glyph.glyphRect.x;
                    int y = glyph.glyphRect.y;
                    int width = glyph.glyphRect.width;
                    int height = glyph.glyphRect.height;

                    // Resize sourceTexture so it has the same width and height as the glyph
                    Texture2D sourceTextureResized = null;
                    if (replacement.texture.width == width && replacement.texture.height == height)
                    {
                        sourceTextureResized = replacement.texture;
                    }
                    else
                    {
                        Plugin.Log.LogInfo($"Resizing {replacement.imageName} from {replacement.texture.width}x{replacement.texture.height} to {width}x{height}");
                        sourceTextureResized = TextureHelper.ResizeTexture(replacement.texture, width, height);
                    }


                    // Apply texture2D to the sprite sheet accounting for change in size
                    assetSpriteSheet.SetPixels(x, y, width, height, sourceTextureResized.GetPixels());
                    dirtyTextures.Add(assetSpriteSheet);
                }
            }

            foreach (Texture2D dirtyTexture in dirtyTextures)
            {
                // make the whole texture
                dirtyTexture.Apply();


                
                TMP_Settings.defaultSpriteAsset.spriteSheet = dirtyTexture;
                TextureHelper.ExportTextureToAssets((Texture2D)TMP_Settings.defaultSpriteAsset.spriteSheet, Application.persistentDataPath + "/" + dirtyTexture.name + ".png");
            }
            
            texturesToReplace.Clear();
        }

        public static void Replace(Texture2D sourceTexture, string imageName)
        {
            Plugin.Log.LogInfo($"Replacing {imageName} in TMP");
            
            // Did not find a replacement so queue it until it appears in the game
            texturesToReplace.Add(new TexturesToReplace()
            {
                texture = sourceTexture,
                imageName = imageName.ToLower()
            });

            s_dirty = true;
        }

        public static void Instantiate()
        {
            s_instantiated = true;
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

            TMP_SpriteAsset existingAsset = TMP_Settings.defaultSpriteAsset;
            if (existingAsset == null)
            {
                Plugin.Log.LogInfo($"No ATS asset found for defaultSpriteAsset!");
                return;
            }
            
            List<Texture2D> newFiles = customImages.GetRange(customImagesStartingIndex,
                customImages.Count - customImagesStartingIndex);
            TMP_SpriteAsset asset = TMPHelpers.CreateSpriteAsset(newFiles);
            Plugin.Log.LogInfo($"Syncing {newFiles.Count} new images to TMP");
            existingAsset.fallbackSpriteAssets.Add(asset);

            customImagesStartingIndex = customImages.Count;

            ReplaceAll();
            s_dirty = false;
        }
    }
}