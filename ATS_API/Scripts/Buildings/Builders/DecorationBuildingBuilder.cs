using ATS_API.Helpers;
using Eremite.Buildings;
using UnityEngine;


namespace ATS_API.Buildings;

public class DecorationBuildingBuilder : BuildingBuilder<DecorationModel>
{
    private readonly MetaData metaData;

    public class MetaData
    {
        public DecorationTierTypes Tier;
    }
    
    public DecorationBuildingBuilder(DecorationModel model) : base(model)
    {
        metaData = new MetaData();
    }
    
    public DecorationBuildingBuilder(string guid, string name, string iconPath, DecorationTierTypes tier) : base(guid, name, BuildingBehaviourTypes.Decoration, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        metaData = new MetaData();
        metaData.Tier = tier;
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Decorations;
        
        m_buildingModel.levels = [];
        m_buildingModel.forceOwnConstructionGoods = true;
        m_buildingModel.hasDecorationTier = true;
        m_buildingModel.showPanel = true;
        m_buildingModel.stackEffects = false;
        m_buildingModel.decorationScore = 4;
        m_buildingModel.activeEffects = [];
        m_buildingModel.order = 300;
    }

    public void SetDecorationScore(int score)
    {
        m_buildingModel.decorationScore = score;
    }
    
    public void SetUseCustomRequiredGoods(bool value)
    {
        m_buildingModel.forceOwnConstructionGoods = value;
    }
}