using System;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public BiomeBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.displayName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.DisplayName.key)
        {
            // Create a new key for this field
            return SetDisplayName(LocalizationManager.ToLocaText(guid, name, "displayName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }

    public BiomeBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }

    public BiomeBuilder SetDisplayName(LocaText text)
    {
        newModel.displayName = text;
        return this;
    }

    public BiomeBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.description.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Description.key)
        {
            // Create a new key for this field
            return SetDescriptionKey(LocalizationManager.ToLocaText(guid, name, "description", description, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }

    public BiomeBuilder SetDescriptionKey(LocaText locaText)
    {
        newModel.description = locaText;
        return this;
    }

    public BiomeBuilder SetDescriptionKey(string key)
    {
        return SetDescriptionKey(key.ToLocaText());
    }

    public BiomeBuilder SetTownName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.townName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.TownName.key)
        {
            // Create a new key for this field
            return SetTownName(LocalizationManager.ToLocaText(guid, name, "TownName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }

    public BiomeBuilder SetTownName(LocaText text)
    {
        newModel.townName = text;
        return this;
    }

    public BiomeBuilder SetTownNameKey(string key)
    {
        return SetTownName(key.ToLocaText());
    }

    public BiomeBuilder SetTownDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.townDescription.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.TownDescription.key)
        {
            // Create a new key for this field
            return SetTownDescriptionKey(LocalizationManager.ToLocaText(guid, name, "townDescription", description,
                language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }

    public BiomeBuilder SetTownDescriptionKey(LocaText locaText)
    {
        newModel.townDescription = locaText;
        Plugin.Log.LogInfo("townDescription set to " + newModel.townDescription.key + "\n" + Environment.StackTrace);
        return this;
    }

    public BiomeBuilder SetTownDescriptionKey(string key)
    {
        return SetTownDescriptionKey(key.ToLocaText());
    }
}