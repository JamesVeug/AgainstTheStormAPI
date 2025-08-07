﻿using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Buildings;

public abstract partial class BuildingBuilder<T, Y> : IBuildingBuilder 
    where T : BuildingModel
    where Y : GenericBuildingData<T>
{
    public string Name => m_name;
    public string GUID => m_guid;
    public T BuildingModel => m_buildingModel;
    public BuildingModel Model => m_buildingModel;
    public Y NewData => m_newData;
    public BuildingTagModel BuildingTagModel => m_buildingTagModel;
    
    private BuildingTagModel m_buildingTagModel;
    protected Y m_newData;
    protected readonly T m_buildingModel;
    protected readonly string m_guid;
    protected readonly string m_name;
    
    public BuildingBuilder(T model)
    {
        m_newData = GetNewData(model);
        m_buildingModel = model;
        m_guid = m_newData.Guid;
        m_name = model.name;
    }

    protected abstract Y GetNewData(T model);

    protected abstract Y CreateNewData(string guid, string name);
    
    public BuildingBuilder(string guid, string name, string iconPath)
    {
        m_guid = guid;
        m_name = name;

        m_newData = CreateNewData(guid, name);
        m_buildingModel = (T)m_newData.BuildingModel;
        m_buildingModel.displayName = Placeholders.DisplayName;
        m_buildingModel.description = Placeholders.Description;
        m_buildingModel.displayLabel = Placeholders.Label;
        m_buildingModel.icon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.BuildingIcon);
        m_buildingModel.tags = [];


        m_buildingModel.sourcePreviewMode = GoodSourcePreviewMode.Always;
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
        m_buildingModel.repeatable = false;
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
        m_buildingModel.prefabHeight = 0.6f;
        m_buildingModel.iconXOffset = -0.05f;
        m_buildingModel.iconSizeOffset = 0.4f;
        m_buildingModel.waitFramesForIcon = 0;
        m_buildingModel.useFootprintGraphic = false;
        m_buildingModel.showPlacedEffect = true;
        m_buildingModel.showFinishedEffect = true;
        m_buildingModel.skipOnExport = false;
        m_buildingModel.skipIconGeneration = false;
        
        m_buildingModel.usabilityTags = [];
        m_buildingModel.initiallyEssential = true;
        m_buildingModel.canBePicked = true;
        m_buildingModel.costRange = new Vector2Int(1, 2);
    }

    public void SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_buildingModel.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
    }
    
    public void SetDisplayNameKey(string key)
    {
        m_buildingModel.displayName = new LocaText() { key = key };
    }

    public virtual void SetDescription(string description, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_buildingModel.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description, systemLanguage);
    }
    
    public virtual void SetDescriptionKey(string key)
    {
        m_buildingModel.description = new LocaText() { key = key };
    }
    
    public void SetLabel(string label, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_buildingModel.displayLabel = LocalizationManager.ToLabelModel(m_guid, m_name, "displayLabel", label, systemLanguage);
    }

    /// <summary>
    /// 512x512
    /// </summary>
    public void SetDefaultVisualIcon(string spritePath)
    {
        BuildingVisualData visualData = new BuildingVisualData();
        visualData.Icon = TextureHelper.GetImageAsSprite(spritePath, TextureHelper.SpriteType.BuildingDefaultModelDisplayIcon);
        
        m_newData.VisualData = visualData;
    }

    public void SetCustomModel(GameObject loadAsset)
    {
        if(loadAsset == null)
        {
            APILogger.LogError($"Custom prefab for building {m_buildingModel.name} is null!");
            return;
        }
        
        m_newData.VisualData = new BuildingVisualData();
        m_newData.CustomPrefab = loadAsset;
    }
    
    public void SetRequiredGoods(params NameToAmount [] goods)
    {
        m_newData.RequiredGoods = new List<NameToAmount>(goods);
    }
    
    public void SetRequiredGoods(List<NameToAmount> goods)
    {
        m_newData.RequiredGoods = goods;
    }
    
    public void AddRequiredGoods(params NameToAmount[] goods)
    {
        m_newData.RequiredGoods.AddRange(goods);
    }
    
    public void AddRequiredGoods(List<NameToAmount> goods)
    {
        m_newData.RequiredGoods.AddRange(goods);
    }
    
    public void SetMoveCost(int amount, GoodsTypes good)
    {
        m_newData.MoveCost = new NameToAmount(amount, good.ToName());
    }
    
    public virtual void SetCategory(BuildingCategoriesTypes category)
    {
        m_newData.Category = category;
    }
    
    /// <summary>
    /// Filters for how this building is selected in various parts of the game such as orders, map generation... etc 
    /// </summary>
    public void AddUsabilityTags(params TagTypes[] tag)
    {
        m_newData.UsabilityTags.AddRange(tag);
    }
    
    /// <summary>
    /// Filters for how this building is selected in various parts of the game such as orders, map generation... etc 
    /// </summary>
    public void SetUsabilityTags(params TagTypes[] tag)
    {
        m_newData.UsabilityTags.Clear();
        m_newData.UsabilityTags.AddRange(tag);
    }
    
    /// <summary>
    /// Tags for the building that add benefits.
    /// Eg: Adding the Animal tags buffs Lizards when they are in the building 
    /// </summary>
    public void AddTags(params BuildingTagTypes[] tag)
    {
        m_newData.Tags.AddRange(tag);
    }
    
    /// <summary>
    /// Tags for the building that add benefits.
    /// Eg: Adding the Animal tags buffs Lizards when they are in the building 
    /// </summary>
    public void SetTags(params BuildingTagTypes[] tag)
    {
        m_newData.Tags.Clear();
        m_newData.Tags.AddRange(tag);
    }
    
    public void SetFootPrint(int width, int height, FieldType field = FieldType.Sand)
    {
        m_buildingModel.footprintMap.width = width;
        m_buildingModel.footprintMap.height = height;
        m_buildingModel.size = new Vector2Int(width, height);
        
        var fields = new FieldType[width * height];
        for (int i = 0; i < fields.Length; i++)
        {
            fields[i] = field;
        }
        m_buildingModel.footprintMap.fields = fields;
    }
    
    public void SetScaffoldingData(BuildingConstructionAnimationData data)
    {
        m_newData.BuildingConstructionAnimationData = data;
    }
    
    public void SetOrder(int order)
    {
        Model.order = order;
    }
}













