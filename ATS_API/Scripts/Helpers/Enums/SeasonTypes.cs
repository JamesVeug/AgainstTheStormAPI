using System.Collections.Generic;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum SeasonTypes
{
    None,
    All,
    Drizzle,
    Clearance,
    Storm
}

public static class SeasonsExtensions
{
    public static Season ToSeason(this SeasonTypes seasonType)
    {
        return seasonType switch
        {
            SeasonTypes.Drizzle => Season.Drizzle,
            SeasonTypes.Clearance => Season.Clearance,
            SeasonTypes.Storm => Season.Storm,
            _ => Season.Drizzle
        };
    }

    public static SeasonTypes ToSeasonType(this Season season)
    {
        return season switch
        {
            Season.Drizzle => SeasonTypes.Drizzle,
            Season.Clearance => SeasonTypes.Clearance,
            Season.Storm => SeasonTypes.Storm,
            _ => SeasonTypes.Drizzle
        };
    }
    
    public static bool ContainsSeason(this List<SeasonTypes> seasons, Season season)
    {
        if (seasons == null)
            return false;

        if (seasons.Contains(SeasonTypes.All))
            return true;
        
        return seasons.Contains(season.ToSeasonType());
    }
}