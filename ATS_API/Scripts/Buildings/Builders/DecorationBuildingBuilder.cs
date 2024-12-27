using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using UnityEngine;


namespace ATS_API.Buildings;

public class DecorationBuildingBuilder : BuildingBuilder<DecorationModel, NewDecorationBuildingData>
{
    private readonly MetaData metaData;

    public class MetaData
    {
        public DecorationTierTypes Tier;
    }
    
    protected override NewDecorationBuildingData CreateNewData(string guid, string name)
    {
        return BuildingManager.CreateDecoration(guid, name);
    }

    protected override NewDecorationBuildingData GetNewData(DecorationModel model)
    {
        return NewDecorationBuildingData.FromModel(model);
    }

    public DecorationBuildingBuilder(DecorationModel model) : base(model)
    {
        m_newData = NewDecorationBuildingData.FromModel(model);
        metaData = new MetaData();
        
        
        m_newData.MetaData = metaData;
        m_newData.Behaviour = BuildingBehaviourTypes.Decoration;
    }
    
    public DecorationBuildingBuilder(string guid, string name, string iconPath, DecorationTierTypes tier) : base(guid, name, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        metaData = new MetaData();
        metaData.Tier = tier;
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Decorations;
        
        m_buildingModel.displayLabel = Keys.Decoration.ToLabelModel();
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