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
}