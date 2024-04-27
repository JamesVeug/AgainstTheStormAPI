using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Traders;
using Eremite.Model;
using Eremite.Model.Trade;
using UnityEngine;

namespace ATS_API.Effects;


public class TraderBuilder
{
    public TraderModel TraderModel => m_traderModel;
    
    private readonly TraderModel m_traderModel;
    private readonly CustomTrader m_newData;
    private readonly string m_guid;
    private readonly string m_name;
    
    public TraderBuilder(string guid, string name, string iconPath, string newsIconPath)
    {
        m_guid = guid;
        m_name = name;

        m_newData = TraderManager.New(guid, name);
        m_newData.GuaranteedOfferedGoods.AddRange(TraderHelpers.DefaultGuaranteedOfferedGoods);
        m_newData.DesiredGoods.AddRange(TraderHelpers.DefaultDesiredGoods);
        m_newData.OfferedGoods.AddRange(TraderHelpers.DefaultOfferedGoods);
        m_newData.Merchandise.AddRange(TraderHelpers.DefaultMerchandise);
        
        m_traderModel = m_newData.TraderModel;
        m_traderModel.label =  LocalizationManager.ToLabelModel(guid, name, "label", "Modded");
        m_traderModel.icon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.TraderIconLarge);
        m_traderModel.newsIcon = TextureHelper.GetImageAsSprite(newsIconPath, TextureHelper.SpriteType.TraderIconSmall);
        m_traderModel.isActive = true;
        m_traderModel.isInWiki = true;
        m_traderModel.assaultEffects = Array.Empty<EffectModel>();
    }

    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_traderModel.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }

    public void SetDescription(string description)
    {
        m_traderModel.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description);
    }

    public void SetDialogue(string description)
    {
        m_traderModel.dialogue = LocalizationManager.ToLocaText(m_guid, m_name, "dialogue", description);
    }
    
    public void SetLabel(string label)
    {
        m_traderModel.label = LocalizationManager.ToLabelModel(m_guid, m_name, "label", label);
    }

    public void SetStayingTime(float time)
    {
        m_traderModel.stayingTime = time;
    }

    public void SetArrivalTime(float time)
    {
        m_traderModel.arrivalTime = time;
    }

    /// <summary>
    /// Optional
    /// </summary>
    /// <param name="description"></param>
    public void SetAssaultLockedText(string description)
    {
        m_traderModel.assaultLockedTooltipText = LocalizationManager.ToLocaText(m_guid, m_name, "assaultLockedTooltipText", description);
    }

    public void SetAssaultData(int minVillagersKilled=3, int maxVillagersKilled=5, float percentageOfStolenGoods=0.25f, float percentageOfStolenEffects=0.25f, bool canAssault=true)
    {
        m_traderModel.villagersKilledInAssault = new Vector2Int(minVillagersKilled, maxVillagersKilled);
        m_traderModel.percentageOfStolenGoods = percentageOfStolenGoods;
        m_traderModel.percentageOfStolenEffects = percentageOfStolenEffects;
        m_traderModel.canAssault = canAssault;
    }
    
    public void SetAssaultEffects(params EffectModel[] effects)
    {
        m_traderModel.assaultEffects = effects;
    }
    
    public void SetGuaranteedOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.GuaranteedOfferedGoods = new List<NameToAmount>(goods);
    }
    
    public void AddGuaranteedOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.GuaranteedOfferedGoods.AddRange(goods);
    }
    
    public void SetOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.OfferedGoods = new List<NameToAmount>(goods);
    }
    
    public void AddOfferedGoods(params NameToAmount[] goods)
    {
        m_newData.OfferedGoods.AddRange(goods);
    }
    
    public void SetDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods = new List<string>(goods);
    }
    
    public void AddDesiredGoods(params string[] goods)
    {
        m_newData.DesiredGoods.AddRange(goods);
    }
    
    public void SetMerchandise(params EffectDrop[] names)
    {
        m_traderModel.merchandise = names;
    }
    
    public void SetAmountOfGoods(int minAmount, int maxAmount)
    {
        m_traderModel.goodsAmount = new Vector2Int(minAmount, maxAmount);
    }

    public void SetAvailableInAllBiomes()
    {
        // NOTE: All biomes use the same TraderConfig which has all the Traders in it... so that's nothing unique
        // m_newData.Availability.AddAllSeasons();
    }
}