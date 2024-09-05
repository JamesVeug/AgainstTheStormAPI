using System.Collections.Generic;
using Eremite.Buildings;

namespace ATS_API.Helpers;

public class Availability
{
    // If null then available in all seasons
    public readonly List<SeasonTypes> SeasonsAvailable = new List<SeasonTypes>();
    public readonly List<string> WorkPlaces = new List<string>();

    public void AddAllSeasons()
    {
        SeasonsAvailable.Clear();
        SeasonsAvailable.Add(SeasonTypes.All);
    }
    
    public void AddAllWorkPlaces()
    {
        WorkPlaces.Clear();
        WorkPlaces.Add("All");
    }
    
    public void AddWorkPlace(string workPlace)
    {
        WorkPlaces.Add(workPlace);
    }
    
    public void AddWorkPlace(BuildingModel buildingModel)
    {
        WorkPlaces.Add(buildingModel.name);
    }

    public bool HasWorkPlace(string buildingModelName)
    {
        return WorkPlaces.Contains(buildingModelName) || WorkPlaces.Contains("All");
    }
}
