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

public class NewHouseBuildingData : GenericBuildingData<HouseModel>
{
    public NewHouseBuildingData(string guid, string name, BuildingTypes id, HouseModel model, BuildingBehaviourTypes behaviour) : base(guid, name, id, model, behaviour)
    {
    }

    public override void PostSync()
    {
        APILogger.LogDebug($"PostSync for building {BuildingModel.name}");
        HouseBuildingBuilder.MetaData metaData = (HouseBuildingBuilder.MetaData) MetaData;
        BuildingModel.housingRaces = metaData.HousingRaces.ToRaceModelArray();
        BuildingModel.servedNeeds = metaData.ServedNeeds.ToNeedModelArray();
    }
    
    public static NewHouseBuildingData FromModel<T>(T model) where T : HouseModel
    {
        NewHouseBuildingData buildingData = BuildingManager.NewHouses.FirstOrDefault(a => a.BuildingModel == model);
        if (buildingData != null)
        {
            return buildingData;
        }
        
        buildingData = new NewHouseBuildingData("", model.name, model.name.ToBuildingTypes(), model, BuildingBehaviourTypes.House);
        return buildingData;
    }
}