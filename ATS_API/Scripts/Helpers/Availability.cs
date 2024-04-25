using System.Collections.Generic;
using Eremite.Model;

namespace ATS_API.Helpers;

public class Availability
{
    // If null then available in all seasons
    public readonly List<Season> SeasonsAvailable = new List<Season>();

    public void AddAllSeasons()
    {
        SeasonsAvailable.Clear();
        SeasonsAvailable.Add(Season.Clearance);
        SeasonsAvailable.Add(Season.Drizzle);
        SeasonsAvailable.Add(Season.Storm);
    }
}