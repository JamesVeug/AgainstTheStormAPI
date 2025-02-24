﻿using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;


namespace ATS_API.Buildings;

public class HouseBuildingBuilder : BuildingBuilder<HouseModel, NewHouseBuildingData>
{
    private readonly MetaData metaData;

    public class MetaData
    {
        public List<RaceTypes> HousingRaces = new List<RaceTypes>();
        public bool HouseAllRaces = false;
        public List<NeedTypes> ServedNeeds = new List<NeedTypes>();
    }
    
    protected override NewHouseBuildingData CreateNewData(string guid, string name)
    {
        return BuildingManager.CreateHouse(guid, name);
    }

    protected override NewHouseBuildingData GetNewData(HouseModel model)
    {
        return NewHouseBuildingData.FromModel(model);
    }

    public HouseBuildingBuilder(HouseModel model) : base(model)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Behaviour = BuildingBehaviourTypes.House;
    }
    
    public HouseBuildingBuilder(string guid, string name, string iconPath, int housingPlaces) : base(guid, name, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        metaData = new MetaData();
        
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Housing;
        
        m_buildingModel.displayLabel = Keys.House.ToLabelModel();
        m_buildingModel.housingPlaces = housingPlaces;
        m_buildingModel.level = 2;
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
        m_buildingModel.housingRaces = [];
        m_buildingModel.servedNeeds = [];
    }
    
    public HouseBuildingBuilder AddHousingRace(RaceTypes race)
    {
        metaData.HousingRaces.Add(race);
        return this;
    }

    public HouseBuildingBuilder AddHousingRaces(params RaceTypes[] types)
    {
        metaData.HousingRaces.AddRange(types);
        return this;
    }

    public HouseBuildingBuilder SetHousingRaces(params RaceTypes[] types)
    {
        metaData.HousingRaces.Clear();
        metaData.HousingRaces.AddRange(types);
        return this;
    }
    
    public HouseBuildingBuilder SetAllHousingRaces()
    {
        metaData.HouseAllRaces = true;
        return this;
    }
    
    public HouseBuildingBuilder AddServedNeed(NeedTypes need)
    {
        metaData.ServedNeeds.Add(need);
        return this;
    }
    
    public HouseBuildingBuilder AddServedNeeds(params NeedTypes[] types)
    {
        metaData.ServedNeeds.AddRange(types);
        return this;
    }
    
    public HouseBuildingBuilder SetServedNeeds(params NeedTypes[] types)
    {
        metaData.ServedNeeds.Clear();
        metaData.ServedNeeds.AddRange(types);
        return this;
    }
}