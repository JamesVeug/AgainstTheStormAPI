using System;
using ATS_API.Localization;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public enum SoilGrade
    {
        None,
        Small,
        Medium,
    }

    public BiomeBuilder SetSoilText(SoilGrade grade)
    {
        string key = "";
        switch (grade)
        {
            case SoilGrade.Small:
                key = "Biome_SoilGrade_Small";
                break;
            case SoilGrade.Medium:
                key = "Biome_SoilGrade_Medium";
                break;
        }

        newModel.soilGrade = key.ToLocaText();
        return this;
    }

    public BiomeBuilder SetSoilTextKey(string key)
    {
        newModel.soilGrade = key.ToLocaText();
        return this;
    }

    public BiomeBuilder SetSoilText(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.soilGrade.key;
        if (string.IsNullOrEmpty(key))
        {
            // Create a new key for this field
            return SetDisplayName(LocalizationManager.ToLocaText(guid, name, "soilGrade", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }
    
    /// <summary>
    /// 0 = None, 1 = Maximum
    /// </summary>
    public BiomeBuilder SetSoilAmount(float amount)
    {
        newBiome.soilAmount = Mathf.Clamp01(amount);
        return this;
    }
}