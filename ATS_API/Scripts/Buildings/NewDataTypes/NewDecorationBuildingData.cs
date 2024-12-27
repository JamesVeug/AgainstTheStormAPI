using System;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.Model;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API.Buildings;

public class NewDecorationBuildingData : GenericBuildingData<DecorationModel>
{
    public NewDecorationBuildingData(string guid, string name, BuildingTypes id, DecorationModel model, BuildingBehaviourTypes behaviour) : base(guid, name, id, model, behaviour)
    {
    }

    public override void PostSync()
    {
        APILogger.LogDebug($"PostSync for building {BuildingModel.name}");
        
        DecorationBuildingBuilder.MetaData metaData = (DecorationBuildingBuilder.MetaData) MetaData;
        BuildingModel.tier = metaData.Tier.ToDecorationTier();
            
        if ((BuildingModel.description == null || BuildingModel.description.key == Placeholders.DescriptionKey) 
            && BuildingModel.tier != null)
        {
            if (BuildingModel.tier.name.ToDecorationTierTypes() == DecorationTierTypes.Comfort)
            {
                BuildingModel.description = "Building_Decoration_Comfort_Desc".ToLocaText();
            }
            else if (BuildingModel.tier.name.ToDecorationTierTypes() == DecorationTierTypes.Aesthetics)
            {
                BuildingModel.description = "Building_Decoration_Aesthetics_Desc".ToLocaText();
            }
            else if (BuildingModel.tier.name.ToDecorationTierTypes() == DecorationTierTypes.Harmony)
            {
                BuildingModel.description = "Building_Decoration_Harmony_Desc".ToLocaText();
            }
        }
    }
    
    public static NewDecorationBuildingData FromModel<T>(T model) where T : DecorationModel
    {
        NewDecorationBuildingData buildingData = BuildingManager.NewDecorations.FirstOrDefault(a => a.BuildingModel == model);
        if (buildingData != null)
        {
            return buildingData;
        }
        
        buildingData = new NewDecorationBuildingData("", model.name, model.name.ToBuildingTypes(), model, BuildingBehaviourTypes.Decoration);
        return buildingData;
    }
}