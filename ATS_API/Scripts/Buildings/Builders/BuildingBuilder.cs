using System.Collections.Generic;
using ATS_API.Buildings;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Buildings;

public class BuildingBuilder<T> : IBuildingBuilder where T : BuildingModel
{
    public string Name => m_name;
    public string GUID => m_guid;
    public T BuildingModel => m_buildingModel;
    public BuildingModel Model => m_buildingModel;
    
    protected readonly NewBuildingData m_newData;
    protected readonly T m_buildingModel;
    protected readonly string m_guid;
    protected readonly string m_name;
    
    public BuildingBuilder(string guid, string name, BuildingBehaviourTypes behaviour)
    {
        m_guid = guid;
        m_name = name;

        m_newData = BuildingManager.CreateBuilding<T>(guid, name, behaviour);
        m_buildingModel = (T)m_newData.BuildingModel;
        m_buildingModel.displayName = Placeholders.DisplayName;
        m_buildingModel.description = Placeholders.Description;
        m_buildingModel.displayLabel = Placeholders.Label;


        m_buildingModel.category = null; // TODO:
        m_buildingModel.requiresConstruction = true;
        m_buildingModel.refundMaterials = true;
        m_buildingModel.baseRefundRate = 1;
        m_buildingModel.maxBuilders = 2;
        m_buildingModel.hasCustomPlacingSound = false;
        m_buildingModel.isInShop = true;
        m_buildingModel.maxAmount = 0;
        m_buildingModel.order = 5;
        m_buildingModel.allowedTerrains = new FieldType[2]
        {
            FieldType.Sand,
            FieldType.Grass
        };
        m_buildingModel.blockRequiredGoodsScaling = false;
        m_buildingModel.requiredGoods = new GoodRef[0];
        m_buildingModel.size = new Vector2Int(2, 2);
        m_buildingModel.footprintMap = new FootprintMap();
        m_buildingModel.footprintMap.width = 2;
        m_buildingModel.footprintMap.height = 2;
        m_buildingModel.footprintMap.fields = new FieldType[]
        {
            FieldType.Sand,
            FieldType.Sand,
            FieldType.Sand,
            FieldType.Sand,
        };
        m_buildingModel.isActive = true;
        m_buildingModel.showDebugName = false;
        m_buildingModel.aggregationTag = ScriptableObject.CreateInstance<DecisionTag>();
        m_buildingModel.aggregationTag.name = m_buildingModel.name + "_AggregationTag";
        m_buildingModel.replaces = null;
        m_buildingModel.progressScore = 3;
        m_buildingModel.canRotate = true;
        m_buildingModel.traversable = false;
        m_buildingModel.repeatable = true;
        m_buildingModel.destroyable = true;
        m_buildingModel.showPopupToDestroy = true;
        m_buildingModel.destroyableByEffects = true;
        m_buildingModel.canBeRuined = false;
        m_buildingModel.ruin = null;
        m_buildingModel.movable = true;
        m_buildingModel.movableWithEffects = true;
        m_buildingModel.movingCost = null;
        m_buildingModel.canBeMovedBetween = true;
        m_buildingModel.canHaveShortcut = true;
        m_buildingModel.hideAsSource = false;
        m_buildingModel.prefabHeight = 0.6f;
        m_buildingModel.iconXOffset = -0.05f;
        m_buildingModel.iconSizeOffset = 0.4f;
        m_buildingModel.waitFramesForIcon = 0;
        m_buildingModel.useFootprintGraphic = false;
        m_buildingModel.showPlacedEffect = true;
        m_buildingModel.showFinishedEffect = true;
        m_buildingModel.skipOnExport = false;
        m_buildingModel.skipIconGeneration = false;
        m_buildingModel.tags = [];
        m_buildingModel.usabilityTags = [];
        m_buildingModel.initiallyEssential = false;
        m_buildingModel.canBePicked = false;
        m_buildingModel.costRange = new Vector2Int(1, 2);
        // m_buildingModel.Levels = new Vector2Int(1, 2);
        // m_buildingModel.cysts = new Vector2Int(1, 2);
        // m_buildingModel.housingRaces = new Vector2Int(1, 2);
        // m_buildingModel.servedNeeds = new Vector2Int(1, 2);
        // m_buildingModel.Prefab = new Vector2Int(1, 2);
        
        // if (!string.IsNullOrEmpty(iconPath))
        // {
        //     Texture2D texture = TextureHelper.GetImageAsTexture(iconPath);
        //     TextMeshProManager.Add(texture, m_newData.BuildingModel.name);
        //     m_buildingModel.icon = texture.ConvertTexture(TextureHelper.SpriteType.EffectIcon);
        // }
    }

    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_buildingModel.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }
    
    public void SetDisplayNameKey(string key)
    {
        m_buildingModel.displayName = new LocaText() { key = key };
    }

    public virtual void SetDescription(string description)
    {
        m_buildingModel.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description);
    }
    
    public virtual void SetDescriptionKey(string key)
    {
        m_buildingModel.description = new LocaText() { key = key };
    }

    public void SetDefaultVisualIcon(Sprite sprite)
    {
        m_newData.Icon = sprite;
    }
}