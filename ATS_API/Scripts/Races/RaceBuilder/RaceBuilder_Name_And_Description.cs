using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    public RaceBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newRaceData.RaceModel.displayName.key;
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

    public RaceBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }

    public RaceBuilder SetDisplayName(LocaText text)
    {
        newRaceData.RaceModel.displayName = text;
        return this;
    }
    
    public RaceBuilder SetPluralDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newRaceData.RaceModel.pluralName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.PluralDisplayName.key)
        {
            // Create a new key for this field
            return SetPluralDisplayName(LocalizationManager.ToLocaText(guid, name, "pluralDisplayName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }

    public RaceBuilder SetPluralDisplayNameKey(string key)
    {
        return SetPluralDisplayName(key.ToLocaText());
    }

    public RaceBuilder SetPluralDisplayName(LocaText text)
    {
        newRaceData.RaceModel.pluralName = text;
        return this;
    }

    public RaceBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newRaceData.RaceModel.description.key;
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

    public RaceBuilder SetDescriptionKey(LocaText locaText)
    {
        newRaceData.RaceModel.description = locaText;
        if (newRaceData.RaceModel.shortDescription == null ||
            newRaceData.RaceModel.shortDescription.key == Placeholders.Description.key)
        {
            newRaceData.RaceModel.shortDescription = newRaceData.RaceModel.description;
        }

        return this;
    }

    public RaceBuilder SetDescriptionKey(string key)
    {
        return SetDescriptionKey(key.ToLocaText());
    }

    public RaceBuilder SetShortDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newRaceData.RaceModel.shortDescription.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Description.key)
        {
            // Create a new key for this field
            return SetShortDescription(LocalizationManager.ToLocaText(guid, name, "shortDescription", description,
                language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }

    public RaceBuilder SetShortDescriptionKey(string key)
    {
        return SetShortDescription(key.ToLocaText());
    }

    public RaceBuilder SetShortDescription(LocaText locaText)
    {
        newRaceData.RaceModel.shortDescription = locaText;
        if (newRaceData.RaceModel.description == null ||
            newRaceData.RaceModel.description.key == Placeholders.Description.key)
        {
            newRaceData.RaceModel.description = newRaceData.RaceModel.shortDescription;
        }

        return this;
    }
}