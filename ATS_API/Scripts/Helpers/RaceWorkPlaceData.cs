using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;

namespace ATS_API;

public class RaceWorkPlaceData
{
    [Obsolete("Removed in v1.8.x")] public List<RaceTypes> races = null;
    [Obsolete("Removed in v1.8.x")] public bool addAllRaces;
    public bool onlyForAutomatons = false;

    public WorkplaceModel ToWorkplaceModel()
    {
        WorkplaceModel workplace = new WorkplaceModel();
        workplace.onlyForAutomatons = onlyForAutomatons;
        
        return workplace;
    }
}