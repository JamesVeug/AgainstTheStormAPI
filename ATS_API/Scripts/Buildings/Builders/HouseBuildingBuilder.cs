using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;


namespace ATS_API.Buildings;

public class HouseBuildingBuilder : BuildingBuilder<HouseModel>
{
    private readonly MetaData metaData;

    public class MetaData
    {
        public List<RaceTypes> HousingRaces = new List<RaceTypes>();
        public List<NeedTypes> ServedNeeds = new List<NeedTypes>();
    }
    
    public HouseBuildingBuilder(string guid, string name, string iconPath, int housingPlaces) : base(guid, name, BuildingBehaviourTypes.House, iconPath)
    {
        // Set Category to Housing
        // Set label to Housing
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Housing;
        
        m_buildingModel.housingPlaces = housingPlaces;
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
        m_buildingModel.housingRaces = [];
        m_buildingModel.servedNeeds = [];
    }

    public HouseBuildingBuilder AddHousingRaces(params RaceTypes[] types)
    {
        metaData.HousingRaces.Clear();
        metaData.HousingRaces.AddRange(types);
        return this;
    }

    public HouseBuildingBuilder SetHousingRaces(params RaceTypes[] types)
    {
        metaData.HousingRaces.AddRange(types);
        return this;
    }
    
    public HouseBuildingBuilder SetAllHousingRaces()
    {
        metaData.HousingRaces.AddRange(RaceTypesExtensions.All());
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