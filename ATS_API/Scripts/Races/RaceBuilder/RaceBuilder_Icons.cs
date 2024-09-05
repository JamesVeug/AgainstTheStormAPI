using ATS_API;
using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    public RaceBuilder SetIcon(string iconImage)
    {
        return SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.RaceIcon));
    }

    public RaceBuilder SetIcon(Texture2D texture2D)
    {
        return SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.RaceIcon));
    }

    public RaceBuilder SetIcon(Sprite sprite)
    {
        newRaceData.RaceModel.icon = sprite;
        newRaceData.RaceModel.lowResolveNewsIcon = sprite;
        newRaceData.RaceModel.raceResolveIcon = sprite;
        TextMeshProManager.Add(sprite.texture, newRaceData.RaceModel.name);
        return this;
    }

    public RaceBuilder SetRoundIcon(string iconImage)
    {
        return SetRoundIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.RaceIcon));
    }

    public RaceBuilder SetRoundIcon(Texture2D texture2D)
    {
        return SetRoundIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.RaceIcon));
    }

    public RaceBuilder SetRoundIcon(Sprite sprite)
    {
        newRaceData.RaceModel.roundIcon = sprite;
        TextMeshProManager.Add(newRaceData.RaceModel.roundIcon.texture, newRaceData.RaceModel.name);
        return this;
    }

    public RaceBuilder SetWideIcon(string iconImage)
    {
        return SetWideIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.RaceIconWide));
    }

    public RaceBuilder SetWideIcon(Texture2D texture2D)
    {
        return SetWideIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.RaceIconWide));
    }

    public RaceBuilder SetWideIcon(Sprite sprite)
    {
        newRaceData.RaceModel.widePortrait = sprite;
        TextMeshProManager.Add(newRaceData.RaceModel.widePortrait.texture, newRaceData.RaceModel.name);
        return this;
    }
}