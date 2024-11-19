using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.NaturalResource;

public partial class NaturalResourceBuilder
{
    public NaturalResourceBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.Model.displayName.key;
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

    public NaturalResourceBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }

    public NaturalResourceBuilder SetDisplayName(LocaText text)
    {
        newModel.Model.displayName = text;
        return this;
    }

    public NaturalResourceBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.Model.description.key;
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

    public NaturalResourceBuilder SetDescriptionKey(LocaText locaText)
    {
        newModel.Model.description = locaText;
        return this;
    }

    public NaturalResourceBuilder SetDescriptionKey(string key)
    {
        return SetDescriptionKey(key.ToLocaText());
    }
}