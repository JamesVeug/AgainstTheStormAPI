using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.5.2R
public enum BuildingTagTypes
{
	Unknown = -1,
	None,
	
	/// <summary>
	/// Alchemy ("alchemy")
	/// </summary>
	/// <name>Alchemy</name>
	Alchemy,

	/// <summary>
	/// Meat production ("meat")
	/// </summary>
	/// <name>Animals</name>
	Animals,

	/// <summary>
	/// Brewing ("brewing")
	/// </summary>
	/// <name>Brewing</name>
	Brewing,

	/// <summary>
	/// Tailoring ("cloth")
	/// </summary>
	/// <name>Cloth</name>
	Cloth,

	/// <summary>
	/// Blightrot ("cysts")
	/// </summary>
	/// <name>Cysts</name>
	Cysts,

	/// <summary>
	/// Farming ("farming")
	/// </summary>
	/// <name>Farming</name>
	Farming,

	/// <summary>
	/// Forest ("foxforest")
	/// </summary>
	/// <name>Forest</name>
	Forest,

	/// <summary></summary>
	/// <name>Hearth_Beavers</name>
	Hearth_Beavers,

	/// <summary></summary>
	/// <name>Hearth_Foxes</name>
	Hearth_Foxes,

	/// <summary></summary>
	/// <name>Hearth_Frogs</name>
	Hearth_Frogs,

	/// <summary></summary>
	/// <name>Hearth_Harpies</name>
	Hearth_Harpies,

	/// <summary></summary>
	/// <name>Hearth_Humans</name>
	Hearth_Humans,

	/// <summary></summary>
	/// <name>Hearth_Lizards</name>
	Hearth_Lizards,

	/// <summary>
	/// Rainwater ("rainwater")
	/// </summary>
	/// <name>Rainwater</name>
	Rainwater,

	/// <summary>
	/// Masonry ("stone")
	/// </summary>
	/// <name>Stone</name>
	Stone,

	/// <summary>
	/// Engineering ("tech")
	/// </summary>
	/// <name>Tech</name>
	Tech,

	/// <summary>
	/// Warmth ("fire")
	/// </summary>
	/// <name>Warmth</name>
	Warmth,

	/// <summary>
	/// Woodworking ("wood")
	/// </summary>
	/// <name>Wood</name>
	Wood,



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
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BuildingTagTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BuildingTagTypes.Alchemy in the enum and log an error.
	/// </summary>
	public static string ToName(this BuildingTagTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingTagTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[BuildingTagTypes.Alchemy];
	}
	
	/// <summary>
	/// Returns a BuildingTagTypes associated with the given name.
	/// Every BuildingTagTypes should have a unique name as to distinguish it from others.
	/// If no BuildingTagTypes is found, it will return BuildingTagTypes.Unknown and log a warning.
	/// </summary>
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
	
	/// <summary>
	/// Returns a BuildingTagModel associated with the given name.
	/// BuildingTagModel contain all the data that will be used in the game.
	/// Every BuildingTagModel should have a unique name as to distinguish it from others.
	/// If no BuildingTagModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingTagModel ToBuildingTagModel(this string name)
	{
		Eremite.Buildings.BuildingTagModel model = SO.Settings.buildingsTags.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find BuildingTagModel for BuildingTagTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a BuildingTagModel associated with the given BuildingTagTypes.
    /// BuildingTagModel contain all the data that will be used in the game.
    /// Every BuildingTagModel should have a unique name as to distinguish it from others.
    /// If no BuildingTagModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Buildings.BuildingTagModel ToBuildingTagModel(this BuildingTagTypes types)
	{
		return types.ToName().ToBuildingTagModel();
	}
	
	/// <summary>
	/// Returns an array of BuildingTagModel associated with the given BuildingTagTypes.
	/// BuildingTagModel contain all the data that will be used in the game.
	/// Every BuildingTagModel should have a unique name as to distinguish it from others.
	/// If a BuildingTagModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingTagModel[] ToBuildingTagModelArray(this IEnumerable<BuildingTagTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingTagModel[] array = new Eremite.Buildings.BuildingTagModel[count];
		int i = 0;
		foreach (BuildingTagTypes element in collection)
		{
			array[i++] = element.ToBuildingTagModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingTagModel associated with the given BuildingTagTypes.
	/// BuildingTagModel contain all the data that will be used in the game.
	/// Every BuildingTagModel should have a unique name as to distinguish it from others.
	/// If a BuildingTagModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingTagModel[] ToBuildingTagModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingTagModel[] array = new Eremite.Buildings.BuildingTagModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingTagModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingTagModel associated with the given BuildingTagTypes.
	/// BuildingTagModel contain all the data that will be used in the game.
	/// Every BuildingTagModel should have a unique name as to distinguish it from others.
	/// If a BuildingTagModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingTagModel[] ToBuildingTagModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingTagModel>.Get(out List<Eremite.Buildings.BuildingTagModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.BuildingTagModel model = element.ToBuildingTagModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BuildingTagModel associated with the given BuildingTagTypes.
	/// BuildingTagModel contain all the data that will be used in the game.
	/// Every BuildingTagModel should have a unique name as to distinguish it from others.
	/// If a BuildingTagModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingTagModel[] ToBuildingTagModelArrayNoNulls(this IEnumerable<BuildingTagTypes> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingTagModel>.Get(out List<Eremite.Buildings.BuildingTagModel> list))
		{
			foreach (BuildingTagTypes element in collection)
			{
				Eremite.Buildings.BuildingTagModel model = element.ToBuildingTagModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BuildingTagTypes, string> TypeToInternalName = new()
	{
		{ BuildingTagTypes.Alchemy, "Alchemy" },               // Alchemy ("alchemy")
		{ BuildingTagTypes.Animals, "Animals" },               // Meat production ("meat")
		{ BuildingTagTypes.Brewing, "Brewing" },               // Brewing ("brewing")
		{ BuildingTagTypes.Cloth, "Cloth" },                   // Tailoring ("cloth")
		{ BuildingTagTypes.Cysts, "Cysts" },                   // Blightrot ("cysts")
		{ BuildingTagTypes.Farming, "Farming" },               // Farming ("farming")
		{ BuildingTagTypes.Forest, "Forest" },                 // Forest ("foxforest")
		{ BuildingTagTypes.Hearth_Beavers, "Hearth_Beavers" }, 
		{ BuildingTagTypes.Hearth_Foxes, "Hearth_Foxes" }, 
		{ BuildingTagTypes.Hearth_Frogs, "Hearth_Frogs" }, 
		{ BuildingTagTypes.Hearth_Harpies, "Hearth_Harpies" }, 
		{ BuildingTagTypes.Hearth_Humans, "Hearth_Humans" }, 
		{ BuildingTagTypes.Hearth_Lizards, "Hearth_Lizards" }, 
		{ BuildingTagTypes.Rainwater, "Rainwater" },           // Rainwater ("rainwater")
		{ BuildingTagTypes.Stone, "Stone" },                   // Masonry ("stone")
		{ BuildingTagTypes.Tech, "Tech" },                     // Engineering ("tech")
		{ BuildingTagTypes.Warmth, "Warmth" },                 // Warmth ("fire")
		{ BuildingTagTypes.Wood, "Wood" },                     // Woodworking ("wood")

	};
}
