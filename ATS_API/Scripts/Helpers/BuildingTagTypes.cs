using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum BuildingTagTypes
{
    Unknown = -1,
    None,
	Alchemy,        // Alchemy (<sprite name="alchemy">)
	Animals,        // Meat production (<sprite name="meat">)
	Brewing,        // Brewing (<sprite name="brewing">)
	Cloth,          // Tailoring (<sprite name="cloth">)
	Farming,        // Farming (<sprite name="farming">)
	Forest,         // Forest (<sprite name="foxforest">)
	Hearth_Beavers, // >Missing key<
	Hearth_Foxes,   // >Missing key<
	Hearth_Harpies, // >Missing key<
	Hearth_Humans,  // >Missing key<
	Hearth_Lizards, // >Missing key<
	Rainwater,      // Rainwater (<sprite name="rainwater">)
	Tech,           // Engineering (<sprite name="tech">)
	Warmth,         // Warmth (<sprite name="fire">)
	Wood,           // Woodworking (<sprite name="wood">)

    MAX
}

public static class BuildingTagTypesExtensions
{
	public static string ToName(this BuildingTagTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingTagTypes: " + type);
		return TypeToInternalName[BuildingTagTypes.Alchemy];
	}
	
	public static BuildingTagModel ToBuildingTagModel(this string name)
    {
        BuildingTagModel model = SO.Settings.buildingsTags.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find BuildingTagModel for BuildingTagTypes with name: " + name);
        return null;
    }

	public static BuildingTagModel ToBuildingTagModel(this BuildingTagTypes types)
	{
		return types.ToName().ToBuildingTagModel();
	}
	
	public static BuildingTagModel[] ToBuildingTagModelArray(this IEnumerable<BuildingTagTypes> collection)
    {
        int count = collection.Count();
        BuildingTagModel[] array = new BuildingTagModel[count];
        int i = 0;
        foreach (BuildingTagTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.buildingsTags.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<BuildingTagTypes, string> TypeToInternalName = new()
	{
		{ BuildingTagTypes.Alchemy, "Alchemy" },               // Alchemy (<sprite name="alchemy">)
		{ BuildingTagTypes.Animals, "Animals" },               // Meat production (<sprite name="meat">)
		{ BuildingTagTypes.Brewing, "Brewing" },               // Brewing (<sprite name="brewing">)
		{ BuildingTagTypes.Cloth, "Cloth" },                   // Tailoring (<sprite name="cloth">)
		{ BuildingTagTypes.Farming, "Farming" },               // Farming (<sprite name="farming">)
		{ BuildingTagTypes.Forest, "Forest" },                 // Forest (<sprite name="foxforest">)
		{ BuildingTagTypes.Hearth_Beavers, "Hearth_Beavers" }, // >Missing key<
		{ BuildingTagTypes.Hearth_Foxes, "Hearth_Foxes" },     // >Missing key<
		{ BuildingTagTypes.Hearth_Harpies, "Hearth_Harpies" }, // >Missing key<
		{ BuildingTagTypes.Hearth_Humans, "Hearth_Humans" },   // >Missing key<
		{ BuildingTagTypes.Hearth_Lizards, "Hearth_Lizards" }, // >Missing key<
		{ BuildingTagTypes.Rainwater, "Rainwater" },           // Rainwater (<sprite name="rainwater">)
		{ BuildingTagTypes.Tech, "Tech" },                     // Engineering (<sprite name="tech">)
		{ BuildingTagTypes.Warmth, "Warmth" },                 // Warmth (<sprite name="fire">)
		{ BuildingTagTypes.Wood, "Wood" },                     // Woodworking (<sprite name="wood">)
	};
}
