using System.Collections.Generic;
using Eremite.Model;

namespace ATS_API.Helpers;

public class Availability
{
    // If null then available in all seasons
    public readonly List<SeasonTypes> SeasonsAvailable = new List<SeasonTypes>();

    public void AddAllSeasons()
    {
        SeasonsAvailable.Clear();
        SeasonsAvailable.Add(SeasonTypes.All);
    }
}