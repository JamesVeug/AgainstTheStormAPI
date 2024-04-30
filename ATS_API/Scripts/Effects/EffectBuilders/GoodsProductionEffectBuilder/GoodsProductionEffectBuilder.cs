using System;
using ATS_API.Effects;
using ATS_API.Traders;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

public class GoodsProductionEffectBuilder : EffectBuilder<GoodsRawProductionEffectModel>
{
    public class GoodProductionEffectBuildMetaData
    {
        public NameToAmount Good;
    }
    
    public GoodProductionEffectBuildMetaData MetaData => m_metaData;
    
    private GoodProductionEffectBuildMetaData m_metaData;
    
    public GoodsProductionEffectBuilder(string guid, string name) : base(guid, name, null)
    {
        m_metaData = new GoodProductionEffectBuildMetaData();
        m_newData.MetaData = m_metaData;
        m_effectModel.description = new LocaText() { key = "Reward_Generic_GoodsRawProduction_Description" };
    }
    
    public void SetGoodsPerYield(int amount, string goodName)
    {
        m_metaData.Good = new NameToAmount(amount, goodName);
    }
}