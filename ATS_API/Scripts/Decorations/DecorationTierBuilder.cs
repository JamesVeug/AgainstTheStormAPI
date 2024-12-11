using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Decorations;

public class DecorationTierBuilder
{
    private readonly NewDecorationTier newTier;
    private readonly string guid;
    private readonly string rawName;

    public DecorationTierBuilder(string guid, string name)
    {
        newTier = DecorationManager.NewDecorationTier(guid, name);
        newTier.Model.order = 99;
        newTier.Model.color = Color.white;
        newTier.Model.displayName = Placeholders.DisplayName;
        rawName = name;
        this.guid = guid;
    }
    
    public DecorationTierBuilder SetIcon(string iconImage)
    {
        return SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.DecorationTierIcon));
    }

    public DecorationTierBuilder SetIcon(Texture2D texture2D)
    {
        return SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.DecorationTierIcon));
    }
    
    public DecorationTierBuilder SetIcon(Sprite sprite)
    {
        newTier.Model.icon = sprite;
        TextMeshProManager.Add(sprite.texture, newTier.Model.name);
        return this;
    }
    
    public DecorationTierBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newTier.Model.displayName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.DisplayName.key)
        {
            // Create a new key for this field
            return SetDisplayName(LocalizationManager.ToLocaText(guid, rawName, "displayName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }

    public DecorationTierBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }

    public DecorationTierBuilder SetDisplayName(LocaText text)
    {
        newTier.Model.displayName = text;
        return this;
    }
    
    public DecorationTierBuilder SetColor(Color color)
    {
        newTier.Model.color = color;
        return this;
    }
    
    public DecorationTierBuilder SetOrder(int order)
    {
        newTier.Model.order = order;
        return this;
    }
    
    public DecorationTierBuilder AddReferenceCost(NameToAmount resource)
    {
        newTier.RequiredResources ??= new List<NameToAmount>();
        newTier.RequiredResources.Add(resource);
        return this;
    }
}