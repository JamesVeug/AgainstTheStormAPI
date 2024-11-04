using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Meta;
using UnityEngine;

namespace ATS_API.MetaRewards;

public class EmbarkEffectMetaRewardBuilder : MetaRewardBuilder<EmbarkEffectMetaRewardModel>
{
    public EmbarkEffectMetaRewardBuilder(string guid, string name) : base(guid, name)
    {
        Model.displayName = "MetaReward_EmbarkBonus_Name".ToLocaText();
        Model.description = "MetaReward_EmbarkBonusGoods_Desc".ToLocaText();
    }

    public EmbarkEffectMetaRewardBuilder(MetaRewardModel model) : base(model)
    {
    }

    public EmbarkEffectMetaRewardBuilder SetCostRange(int minCost, int maxCost)
    {
        Model.costRange = new Vector2Int(minCost, maxCost);
        return this;
    }
    
    public EmbarkEffectMetaRewardBuilder SetEffect(EffectTypes effect)
    {
        m_newData.EffectType = effect;
        return this;
    }
    
    public EmbarkEffectMetaRewardBuilder SetEffect(string effect)
    {
        return SetEffect(effect.ToEffectTypes());
    }
    
    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        Model.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }
    
    public void SetDisplayNameKey(string key)
    {
        Model.displayName = new LocaText() { key = key };
    }

    public virtual void SetDescription(string description, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        Model.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description, systemLanguage);
    }
    
    public virtual void SetDescriptionKey(string key)
    {
        Model.description = new LocaText() { key = key };
    }
}