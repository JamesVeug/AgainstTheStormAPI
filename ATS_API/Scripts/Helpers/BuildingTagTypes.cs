using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum BuildingTagTypes
{
    Unknown = -1,
    None,
    Alchemy,
    Animals,
    Brewing,
    Cloth,
    Farming,
    Forest,
    Hearth_Beavers,
    Hearth_Foxes,
    Hearth_Harpies,
    Hearth_Humans,
    Hearth_Lizards,
    Rainwater,
    Tech,
    Warmth,
    Wood,
}

public static class BuildingTagTypesExtensions
{
    public static string ToName(this BuildingTagTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of Building Tag type: " + type);
        return "Alchemy";
    }
    
    public static BuildingTagModel ToBuildingTagModel(this BuildingTagTypes type)
    {
        string name = type.ToName();
        BuildingTagModel model = SO.Settings.buildingsTags.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }

        Plugin.Log.LogError("Cannot find building tag model for type: " + type + " with name: " + name);
        return null;
    }

    internal static readonly Dictionary<BuildingTagTypes, string> TypeToInternalName = new()
    {
        { BuildingTagTypes.Alchemy, "Alchemy" },
        { BuildingTagTypes.Animals, "Animals" },
        { BuildingTagTypes.Brewing, "Brewing" },
        { BuildingTagTypes.Cloth, "Cloth" },
        { BuildingTagTypes.Farming, "Farming" },
        { BuildingTagTypes.Forest, "Forest" },
        { BuildingTagTypes.Hearth_Beavers, "Hearth_Beavers" },
        { BuildingTagTypes.Hearth_Foxes, "Hearth_Foxes" },
        { BuildingTagTypes.Hearth_Harpies, "Hearth_Harpies" },
        { BuildingTagTypes.Hearth_Humans, "Hearth_Humans" },
        { BuildingTagTypes.Hearth_Lizards, "Hearth_Lizards" },
        { BuildingTagTypes.Rainwater, "Rainwater" },
        { BuildingTagTypes.Tech, "Tech" },
        { BuildingTagTypes.Warmth, "Warmth" },
        { BuildingTagTypes.Wood, "Wood" }
    };
}