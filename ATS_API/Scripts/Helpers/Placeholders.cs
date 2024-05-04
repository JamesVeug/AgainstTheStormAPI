using ATS_API;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

public static class Placeholders
{
    // Reuse the same key. This is a property in case we decide not to cache the sprite in the future
    public static Sprite EffectIcon => EffectIconCache;
    private static Sprite EffectIconCache = TextureHelper.GetWhiteTexture(TextureHelper.SpriteType.EffectIcon).ConvertTexture(TextureHelper.SpriteType.EffectIcon);
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText DisplayName => DisplayKey.ToLocaText();
    public static readonly string DisplayKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "displayName", "Missing DisplayName");
    
    // Create new object but not new key in case someone tries changing it
    public static LocaText Description => DescriptionKey.ToLocaText();
    public static readonly string DescriptionKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "description", "Missing Description");
    
    // Create new object but not new key in case someone tries changing it
    public static LabelModel Label => LocalizationManager.ToLabelModel(LabelKey);
    public static readonly string LabelKey = LocalizationManager.NewString(PluginInfo.PLUGIN_GUID, "placeHolders", "label", "Missing Label");
    
}