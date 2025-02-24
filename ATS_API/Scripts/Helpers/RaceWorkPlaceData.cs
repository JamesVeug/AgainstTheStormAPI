using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API;

public class RaceWorkPlaceData
{
    public List<RaceTypes> races = null;
    public bool addAllRaces;

    public WorkplaceModel ToWorkplaceModel()
    {
        WorkplaceModel workplace = new WorkplaceModel();
        if (addAllRaces)
        {
            workplace.allowedRaces = RaceTypesExtensions.All().ToRaceModelArrayNoNulls();
        }
        else
        {
            workplace.allowedRaces = new RaceModel[races.Count];
            for (int j = 0; j < races.Count; j++)
            {
                workplace.allowedRaces[j] = races[j].ToRaceModel();
            }
        }
        
        return workplace;
    }
}