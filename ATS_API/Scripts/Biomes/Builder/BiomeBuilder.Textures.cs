using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public void SetIcon(string iconImage)
    {
        SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.BiomeIcon));
    }

    public void SetIcon(Texture2D texture2D)
    {
        SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.BiomeIcon));
    }

    public void SetIcon(Sprite sprite)
    {
        newModel.icon = sprite;
        TextMeshProManager.Add(newModel.icon.texture, newModel.name);
    }

    public void SetWorldMapTexture(string worldMapImage)
    {
        SetWorldMapTexture(TextureHelper.GetImageAsTexture(worldMapImage));
    }

    public void SetWorldMapTexture(Texture2D texture2D)
    {
        newBiome.worldMapTexture = texture2D;
        TextMeshProManager.Add(newModel.icon.texture, newModel.name);
    }

    public void SetTerrainSeabedTexture(string seabedTexture, int uvWidth = 100, int uvHeight = 100)
    {
        newBiome.terrainSeaBedTexture = TextureHelper.GetImageAsTexture(seabedTexture);
        newBiome.terrainSeaBedTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainBlendTexture(string blendTexture, int uvWidth = 100, int uvHeight = 100)
    {
        newBiome.terrainBlendTexture = TextureHelper.GetImageAsTexture(blendTexture);
        // No uvs for blend texture atm
    }
    
    public void SetTerrainBaseTexture(string baseTexture, int uvWidth = 100, int uvHeight = 100)
    {
        newBiome.terrainBaseTexture = TextureHelper.GetImageAsTexture(baseTexture);
        newBiome.terrainBaseTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainOverlayTexture(string overlayTexture, int uvWidth = 100, int uvHeight = 100)
    {
        newBiome.terrainOverlayTexture = TextureHelper.GetImageAsTexture(overlayTexture);
        newBiome.terrainOverlayTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainCliffTexture(string cliffsTexture, int uvWidth = 100, int uvHeight = 100)
    {
        newBiome.terrainCliffsTexture = TextureHelper.GetImageAsTexture(cliffsTexture);
        newBiome.terrainCliffsTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetWaterTexture(string waterTexture)
    {
        newBiome.waterTexture = TextureHelper.GetImageAsTexture(waterTexture);
    }
}