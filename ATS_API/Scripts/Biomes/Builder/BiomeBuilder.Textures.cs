using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public BiomeBuilder SetIcon(string iconImage)
    {
        SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.BiomeIcon));
        return this;
    }

    public BiomeBuilder SetIcon(Texture2D texture2D)
    {
        SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.BiomeIcon));
        return this;
    }

    public BiomeBuilder SetIcon(Sprite sprite)
    {
        newModel.icon = sprite;
        TextMeshProManager.Add(newModel.icon.texture, newModel.name);
        return this;
    }

    public BiomeBuilder SetWorldMapTexture(string worldMapImage)
    {
        SetWorldMapTexture(TextureHelper.GetImageAsTexture(worldMapImage));
        return this;
    }

    public BiomeBuilder SetWorldMapTexture(Texture2D texture2D)
    {
        newBiome.worldMapTexture = texture2D;
        TextMeshProManager.Add(newModel.icon.texture, newModel.name);
        return this;
    }
}