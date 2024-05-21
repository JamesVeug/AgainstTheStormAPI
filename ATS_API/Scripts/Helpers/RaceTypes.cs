using System.Collections.Generic;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum RaceTypes
{
    Unknown = -1,
    None,
    Beaver,
    Foxes,
    Harpy,
    Human,
    Lizard,
    
    MAX
}

public static class RaceExtension
{
    internal static readonly Dictionary<RaceTypes, string> TypeToInternalName = new()
    {
        { RaceTypes.Beaver, "Beaver" },
        { RaceTypes.Foxes, "Foxes" },
        { RaceTypes.Harpy, "Harpy" },
        { RaceTypes.Human, "Human" },
        { RaceTypes.Lizard, "Lizard" },
    };

    public static string ToName(this RaceTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var value))
        {
            return value;
        }

        Plugin.Log.LogError("Cannot find name of Race type: " + type);
        return RaceTypes.Beaver.ToString();
    }
    
    public static RaceModel ToRaceModel(this RaceTypes type)
    {
        string name = type.ToName();
        if (SO.Settings.ContainsRace(name))
        {
            return SO.Settings.GetRace(name);
        }

        Plugin.Log.LogError("Cannot find race model for type: " + type + " with name: " + name);
        return null;
    }
}