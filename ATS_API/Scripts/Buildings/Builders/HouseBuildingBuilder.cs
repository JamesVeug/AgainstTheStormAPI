using System;
using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Helpers;
using Eremite.Buildings;
using UnityEngine;


namespace ATS_API.Buildings;

public class HouseBuildingBuilder : BuildingBuilder<HouseModel>
{
    private readonly MetaData metaData;

    public class MetaData
    {
        public int HousingCapacity;
        public List<RaceTypes> HousingRaces = new List<RaceTypes>();
        public BuildingTagTypes[] ServedNeeds;
    }
    
    public HouseBuildingBuilder(string guid, string name, string iconPath, int housingPlaces) : base(guid, name, BuildingBehaviourTypes.House, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        metaData = new MetaData();
        
        m_buildingModel.housingPlaces = housingPlaces;
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
        m_buildingModel.housingRaces = [];
        m_buildingModel.servedNeeds = [];
    }
}