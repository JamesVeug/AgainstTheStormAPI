using ATS_API;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Sound;
using UnityEngine;

public static class Placeholders
{
    // Reuse the same key. This is a property in case we decide not to cache the sprite in the future
    public static Sprite EffectIcon => EffectIconCache;
    private static Sprite EffectIconCache = TextureHelper.GetWhiteTexture(TextureHelper.SpriteType.EffectIcon).ConvertTexture(TextureHelper.SpriteType.EffectIcon);
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText DisplayName => DisplayNameKey.ToLocaText();
    public static readonly string DisplayNameKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "displayName", "Missing DisplayName");
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText PluralDisplayName => PluralDisplayNameKey.ToLocaText();
    public static readonly string PluralDisplayNameKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "pluralDisplayName", "Missing PluralDisplayName");
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText Description => DescriptionKey.ToLocaText();
    public static readonly string DescriptionKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "description", "Missing Description");
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText LabelLocaText => LabelKey.ToLocaText();
    public static LabelModel Label => LocalizationManager.ToLabelModel(LabelKey);
    public static readonly string LabelKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "label", "Missing Label");
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText PassiveEffectDesc => PassiveEffectDescKey.ToLocaText();
    public static readonly string PassiveEffectDescKey = "Common_None_NoDash";
    
    
    public static RacialSound RacialSound(RaceModel model)
    {
        var sound = ScriptableObject.CreateInstance<RacialSound>();
        sound.name = "RacialSound Placeholder";
        sound.race = model;
        sound.negativeSound = SoundRef;
        sound.positiveSound = SoundRef;
        sound.neutralSound = SoundRef;
        return sound;
    }

    public static SoundRef SoundRef
    {
        get
        {
            var sound = ScriptableObject.CreateInstance<SoundRef>();
            sound.name = "SoundRef Placeholder";
            sound.sounds = [];
            sound.indexes = [];
            return sound;
        }
    }
}