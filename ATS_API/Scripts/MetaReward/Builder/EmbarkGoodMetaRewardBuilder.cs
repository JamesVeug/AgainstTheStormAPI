using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Meta;
using UnityEngine;

namespace ATS_API.MetaRewards;

public class EmbarkGoodMetaRewardBuilder : MetaRewardBuilder<EmbarkGoodMetaRewardModel>
{
    public EmbarkGoodMetaRewardBuilder(string guid, string name) : base(guid, name)
    {
        m_model.displayName = Placeholders.DisplayName;
        m_model.description = Placeholders.Description;
    }

    public EmbarkGoodMetaRewardBuilder SetCostRange(int minCost, int maxCost)
    {
        m_model.costRange = new Vector2Int(minCost, maxCost);
        return this;
    }
    
    public EmbarkGoodMetaRewardBuilder SetGood(GoodsTypes good, int amount)
    {
        m_newData.GoodsTypes = good;
        m_model.good = new GoodRef()
        {
            good = null, // Add this in post sync
            amount = amount,
        };
        return this;
    }
    
    public EmbarkGoodMetaRewardBuilder SetGood(string good, int amount)
    {
        return SetGood(good.ToGoodsTypes(), amount);
    }
    
    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_model.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }
    
    public void SetDisplayNameKey(string key)
    {
        m_model.displayName = new LocaText() { key = key };
    }

    public virtual void SetDescription(string description, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_model.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description, systemLanguage);
    }
    
    public virtual void SetDescriptionKey(string key)
    {
        m_model.description = new LocaText() { key = key };
    }
}