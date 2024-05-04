using Eremite.Model;

public enum Seasons
{
    None,
    All,
    Drizzle,
    Clearance,
    Storm
}

public static class SeasonsExtensions
{
    public static Season ToSeason(this Seasons season)
    {
        return season switch
        {
            Seasons.Drizzle => Season.Drizzle,
            Seasons.Clearance => Season.Clearance,
            Seasons.Storm => Season.Storm,
            _ => Season.Drizzle
        };
    }
}