using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.4.11R
public enum BuildingTagTypes
{
	Unknown = -1,
	None,
	Alchemy,        // Alchemy (<sprite name="alchemy">)
	Animals,        // Meat production (<sprite name="meat">)
	Brewing,        // Brewing (<sprite name="brewing">)
	Cloth,          // Tailoring (<sprite name="cloth">)
	Cysts,          // Blightrot (<sprite name="cysts">)
	Farming,        // Farming (<sprite name="farming">)
	Forest,         // Forest (<sprite name="foxforest">)
	Hearth_Beavers, 
	Hearth_Foxes, 
	Hearth_Frogs, 
	Hearth_Harpies, 
	Hearth_Humans, 
	Hearth_Lizards, 
	Rainwater,      // Rainwater (<sprite name="rainwater">)
	Stone,          // Masonry (<sprite name="stone">)
	Tech,           // Engineering (<sprite name="tech">)
	Warmth,         // Warmth (<sprite name="fire">)
	Wood,           // Woodworking (<sprite name="wood">)


	MAX = 18
}

public static class BuildingTagTypesExtensions
{
	private static BuildingTagTypes[] s_All = null;
	public static BuildingTagTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new BuildingTagTypes[18];
			for (int i = 0; i < 18; i++)
			{
				s_All[i] = (BuildingTagTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this BuildingTagTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingTagTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[BuildingTagTypes.Alchemy];
	}
	
	public static BuildingTagTypes ToBuildingTagTypes(this string name)
	{
		foreach (KeyValuePair<BuildingTagTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find BuildingTagTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingTagTypes.Unknown;
	}
	
	public static BuildingTagModel ToBuildingTagModel(this string name)
	{
		BuildingTagModel model = SO.Settings.buildingsTags.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find BuildingTagModel for BuildingTagTypes with name: " + name + "\n" + Environment.StackTrace);
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
			array[i++] = element.ToBuildingTagModel();
		}

		return array;
	}
	
	public static BuildingTagModel[] ToBuildingTagModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		BuildingTagModel[] array = new BuildingTagModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingTagModel();
		}

		return array;
	}

	internal static readonly Dictionary<BuildingTagTypes, string> TypeToInternalName = new()
	{
		{ BuildingTagTypes.Alchemy, "Alchemy" },               // Alchemy (<sprite name="alchemy">)
		{ BuildingTagTypes.Animals, "Animals" },               // Meat production (<sprite name="meat">)
		{ BuildingTagTypes.Brewing, "Brewing" },               // Brewing (<sprite name="brewing">)
		{ BuildingTagTypes.Cloth, "Cloth" },                   // Tailoring (<sprite name="cloth">)
		{ BuildingTagTypes.Cysts, "Cysts" },                   // Blightrot (<sprite name="cysts">)
		{ BuildingTagTypes.Farming, "Farming" },               // Farming (<sprite name="farming">)
		{ BuildingTagTypes.Forest, "Forest" },                 // Forest (<sprite name="foxforest">)
		{ BuildingTagTypes.Hearth_Beavers, "Hearth_Beavers" }, 
		{ BuildingTagTypes.Hearth_Foxes, "Hearth_Foxes" }, 
		{ BuildingTagTypes.Hearth_Frogs, "Hearth_Frogs" }, 
		{ BuildingTagTypes.Hearth_Harpies, "Hearth_Harpies" }, 
		{ BuildingTagTypes.Hearth_Humans, "Hearth_Humans" }, 
		{ BuildingTagTypes.Hearth_Lizards, "Hearth_Lizards" }, 
		{ BuildingTagTypes.Rainwater, "Rainwater" },           // Rainwater (<sprite name="rainwater">)
		{ BuildingTagTypes.Stone, "Stone" },                   // Masonry (<sprite name="stone">)
		{ BuildingTagTypes.Tech, "Tech" },                     // Engineering (<sprite name="tech">)
		{ BuildingTagTypes.Warmth, "Warmth" },                 // Warmth (<sprite name="fire">)
		{ BuildingTagTypes.Wood, "Wood" },                     // Woodworking (<sprite name="wood">)

	};
}
