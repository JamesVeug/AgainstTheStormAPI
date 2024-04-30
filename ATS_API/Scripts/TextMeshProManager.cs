using System.Collections.Generic;
using System.Linq;
using ATS_API;
using ATS_API.Helpers;
using TMPro;
using UnityEngine;

public static partial class TextMeshProManager
{
    private static List<Texture2D> customImages = new List<Texture2D>();
    
    // private Dictionary<string, int> m_imageLookup = new Dictionary<string, int>();
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    private static int customImagesStartingIndex = 0;
    
    
    public static void Add(Texture2D texture, string imageName)
    {
        s_dirty = true;
        texture.name = imageName;
        customImages.Add(texture);
        // Plugin.Log.LogInfo($"Adding {imageName} images to TMP");
    }

    public static void Instantiate()
    {
        s_instantiated = true;
    }
    
    public static void Tick()
    {
        if(s_dirty)
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
        
        List<Texture2D> newFiles = customImages.GetRange(customImagesStartingIndex, customImages.Count - customImagesStartingIndex);
        TMP_SpriteAsset asset = TMPHelpers.CreateSpriteAsset(newFiles);
        Plugin.Log.LogInfo($"Syncing {newFiles.Count} new images to TMP");
        existingAsset.fallbackSpriteAssets.Add(asset);
        
        customImagesStartingIndex = customImages.Count;
        s_dirty = false;
    }

    /// <summary>
    /// Unused for now but tried getting TMP_SpriteAssets. Turns out the project settings is only where they are defined
    /// </summary>
    /// <returns></returns>
    private static TMP_SpriteAsset GetATSAsset()
    {
        // find all TMP_Texts on GameObjects
        TMP_Text[] texts = Object.FindObjectsOfType<TMP_Text>(true);
        TMP_SpriteAsset[] spriteAssets = texts
            .Where(a=>a != null && a.spriteAsset != null)
            .Select(a => a.spriteAsset)
            .ToArray();
        
        if (spriteAssets.Length == 0)
        {
            // Plugin.Log.LogInfo("No TMP assets found!!!!!!!");
            return null;
        }

        Plugin.Log.LogInfo($"spriteAssets {spriteAssets.Length}");
        foreach (TMP_SpriteAsset asset in spriteAssets)
        {
            Plugin.Log.LogInfo($"SpriteAsset: {asset.name}");
        }

        return spriteAssets[0];
    }
}