using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace ATS_API.Helpers;

public static class TMPHelpers
{
    public static TMP_SpriteAsset CreateSpriteAsset(List<Texture2D> textures)
    {
        Texture2D spriteSheet = CombineTexturesIntoPower2(textures, out List<TMP_Sprite> sprites);
            
        // Write spriteSheet to disk
        // byte[] bytes = spriteSheet.EncodeToPNG();
        // File.WriteAllBytes(Application.dataPath + "/spriteSheetTest.png", bytes);
        
        //Create new Sprite Asset
        TMP_SpriteAsset spriteAsset = ScriptableObject.CreateInstance<TMP_SpriteAsset>();

        //Set Sprite Sheet
        spriteAsset.spriteSheet = spriteSheet;

        // Assign new sprite to spriteAsset's spriteList
        spriteAsset.spriteInfoList = sprites;

        Shader shader = Shader.Find("TextMeshPro/Sprite");
        Material material = new Material(shader);
        
        material.SetTexture(ShaderUtilities.ID_MainTex, spriteSheet);
        spriteAsset.material = material;
        spriteAsset.UpdateLookupTables();
        for (var i = 0; i < spriteAsset.spriteCharacterTable.Count; i++)
        {
            var character = spriteAsset.spriteCharacterTable[i];
            character.glyphIndex = (uint)i;
        }
        spriteAsset.UpdateLookupTables();

        return spriteAsset;
    }
    
    private static Texture2D CombineTexturesIntoPower2(List<Texture2D> textures, out List<TMP_Sprite> sprites)
    {
        sprites = new List<TMP_Sprite>();
        var sortedTextures = textures.OrderByDescending(tex => tex.height).ToList();

        int totalSize = Mathf.NextPowerOfTwo((int)Mathf.Sqrt(sortedTextures.Sum(t => t.width * t.height)));

        Texture2D combinedTexture = new Texture2D(totalSize, totalSize);

        int shelfHeight = 0;
        int shelfWidth = 0;
        int totalHeight = 0;
        for (var i = 0; i < sortedTextures.Count; i++)
        {
            Texture2D texture2D = sortedTextures[i];
            int width = texture2D.width;
            int height = texture2D.height;
            
            // new shelf
            if (shelfWidth + texture2D.width > totalSize)
            {
                totalHeight += shelfHeight;
                shelfWidth = 0;
                shelfHeight = texture2D.height;
            }
            
            combinedTexture.SetPixels(shelfWidth, totalHeight, texture2D.width, texture2D.height, texture2D.GetPixels());
            Sprite sprite1 = Sprite.Create(combinedTexture, new Rect(0, 0, width, height), Vector2.zero, 100, 0, SpriteMeshType.Tight);
            TMP_Sprite sprite = new TMP_Sprite
            {
                id = i,
                name = $"{texture2D.name}",
                x = shelfWidth,
                y = totalHeight,
                width = width,
                height = height,
                pivot = new Vector2(0.5f, 0.5f),
                xAdvance = width, // width of icon in TMP
                yOffset = height,
                scale = 1,
                sprite=sprite1
            };
            
            shelfWidth += texture2D.width;
            shelfHeight = Mathf.Max(shelfHeight, texture2D.height);
            sprites.Add(sprite);
        }

        combinedTexture.Apply();

        return combinedTexture;
    }
}