using System;
using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Traders;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

namespace ATS_API.Effects;

/// <summary>
/// Give/Remove goods from the player
/// </summary>
public class GoodsEffectBuilder : EffectBuilder<GoodsEffectModel>
{
    public class GoodEffectBuildMetaData
    {
        public NameToAmount GoodsToGive;
    }
    
    public GoodEffectBuildMetaData MetaData => m_metaData;
    
    private GoodEffectBuildMetaData m_metaData;
    
    public GoodsEffectBuilder(string guid, string name) : base(guid, name, null)
    {
        m_metaData = new GoodEffectBuildMetaData();
        m_newData.MetaData = m_metaData;
    }
    
    public void SetGood(int amount, string goodName)
    {
        m_metaData.GoodsToGive = new NameToAmount(amount, goodName);
    }
}