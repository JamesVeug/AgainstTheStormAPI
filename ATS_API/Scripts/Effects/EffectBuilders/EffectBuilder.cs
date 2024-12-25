using System;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Effects;

/// <summary>
/// Base helper class used to create a new effect
/// When creating the effect using a type it will automatically be added to the effect manager
/// See helper methods to see how to acquire them in-game
/// </summary>
/// <typeparam name="T">The type you want to create</typeparam>
public partial class EffectBuilder<T> : IEffectBuilder where T : EffectModel 
{
    public string Name => m_name;
    public string GUID => m_guid;
    public T EffectModel => m_effectModel;
    public EffectModel Model => m_effectModel;
    public EffectTypes EffectType => m_newData.ID;
    
    protected readonly NewEffectData m_newData;
    protected readonly T m_effectModel;
    protected readonly string m_guid;
    protected readonly string m_name;
    
    public EffectBuilder(string guid, string name, string iconPath)
    {
        m_guid = guid;
        m_name = name;

        m_newData = EffectManager.CreateEffect<T>(guid, name);
        m_effectModel = (T)m_newData.EffectModel;
        m_effectModel.label = Placeholders.Label;
        m_effectModel.displayName = Placeholders.DisplayName;
        m_effectModel.description = Placeholders.Description;
        m_effectModel.rarity = EffectRarity.Common;
        m_effectModel.tradingBuyValue = 100;
        m_effectModel.formatDescription = false;
        m_effectModel.hasSuffix = false;
        m_effectModel.forcePerkChecks = false;
        m_effectModel.isEthereal = false;
        m_effectModel.drawLimit = 0;
        m_effectModel.forceHideOnHUD = false;
        m_effectModel.forceShowInEditorPreview = false;
        m_effectModel.forceHideInEditorPreview = false;
        m_effectModel.frameColorByPositive = false;
        m_effectModel.usabilityTags = [];
        m_effectModel.blockedBy = [];

        if (!string.IsNullOrEmpty(iconPath))
        {
            SetIcon(iconPath);
        }
    }
    
    public void SetIcon(string iconPath)
    {
        SetIcon(TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.EffectIcon));
    }
    
    public void SetIcon(Texture2D texture)
    {
        SetIcon(texture.ConvertTexture(TextureHelper.SpriteType.EffectIcon));
    }
    
    public void SetIcon(Sprite sprite)
    {
        TextMeshProManager.Add(sprite.texture, m_newData.EffectModel.name);
        m_effectModel.overrideIcon = sprite;
    }
    
    public void SetRarity(EffectRarity rarity)
    {
        m_effectModel.rarity = rarity;
    }
    
    public void SetPositive(bool positive)
    {
        m_effectModel.isPositive = positive;
    }

    public void SetLabel(string labelModel, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_effectModel.label = LocalizationManager.ToLabelModel(m_guid, m_name, "label", labelModel, systemLanguage);
    }
    
    public void SetLabelKey(string key)
    {
        m_effectModel.label = key.ToLabelModel();
    }

    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_effectModel.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }
    
    public void SetDisplayNameKey(string key)
    {
        m_effectModel.displayName = new LocaText() { key = key };
    }

    public virtual void SetDescription(string description, SystemLanguage systemLanguage=SystemLanguage.English)
    {
        m_effectModel.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description, systemLanguage);
    }
    
    public virtual void SetDescriptionKey(string key)
    {
        m_effectModel.description = new LocaText() { key = key };
    }

    public void SetObtainedAsCornerstone(int chance = 100)
    {
        APILogger.IsTrue(chance >= 1 && chance <= 100, "Cornerstone chance must be between 1 and 100!");
        m_newData.IsCornerstone = true;
        m_newData.Chance = chance;
    }

    /// <summary>
    /// Limits how many times the player can select this.
    /// 0 means infinite
    /// </summary>
    /// <param name="amount"></param>
    public void SetDrawLimit(int amount)
    {
        m_newData.EffectModel.drawLimit = amount;
    }

    public void SetAvailableInAllBiomesAndSeasons()
    {
        m_newData.Availability.AddAllSeasons();
    }
    
    public void SetTradingBuyValue(int value)
    {
        m_effectModel.tradingBuyValue = value;
    }
}