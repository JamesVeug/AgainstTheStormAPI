using System;
using ATS_API.Effects;
using ATS_API.Helpers;
using Eremite.Buildings;
using UnityEngine;


namespace ATS_API.Buildings;

public class HouseBuildingBuilder : BuildingBuilder<HouseModel>
{
    public HouseBuildingBuilder(string guid, string name, string iconPath) : base(guid, name, BuildingBehaviourTypes.House, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        m_buildingModel.levels = Array.Empty<BuildingLevelModel>();
        m_buildingModel.cystsAmount = 3;
        m_buildingModel.housingRaces = [];
        m_buildingModel.servedNeeds = [];
    }
}