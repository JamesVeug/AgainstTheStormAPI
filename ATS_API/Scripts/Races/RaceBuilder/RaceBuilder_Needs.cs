using System.Linq;
using ATS_API.Helpers;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    public RaceBuilder SetHousingNeed(string housingNeed)
    {
        newRaceData.racialHousingNeed = housingNeed;
        return this;
    }
    
    public RaceBuilder SetHousingNeed(NeedTypes housingNeed)
    {
        newRaceData.racialHousingNeed = housingNeed.ToName();
        return this;
    }

    public RaceBuilder SetNeeds(params string[] needs)
    {
        newRaceData.needs.Clear();
        newRaceData.needs.AddRange(needs);
        return this;
    }
    
    public RaceBuilder SetNeeds(params NeedTypes[] needs)
    {
        newRaceData.needs.Clear();
        newRaceData.needs.AddRange(needs.Select(a=>a.ToName()));
        return this;
    }
    
    public RaceBuilder AddNeeds(params string[] needs)
    {
        newRaceData.needs.AddRange(needs);
        return this;
    }
    
    public RaceBuilder AddNeeds(params NeedTypes[] needs)
    {
        newRaceData.needs.AddRange(needs.Select(a=>a.ToName()));
        return this;
    }

    public RaceBuilder AddNeed(string need)
    {
        newRaceData.needs.Add(need);
        return this;
    }
    
    public RaceBuilder AddNeed(NeedTypes need)
    {
        newRaceData.needs.Add(need.ToName());
        return this;
    }
}