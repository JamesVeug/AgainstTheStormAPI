using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.9R
/// </summary>
public enum BuildingTagTypes
{
	/// <summary>
	/// Placeholder for an unknown BuildingTagTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no BuildingTagTypes. Typically, seen if nothing is defined or failed to parse a string to a BuildingTagTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Alchemy ("alchemy")
	/// </summary>
	/// <name>Alchemy</name>
	Alchemy = 1,

	/// <summary>
	/// Meat production ("meat")
	/// </summary>
	/// <name>Animals</name>
	Animals = 2,

	/// <summary>
	/// Brewing ("brewing")
	/// </summary>
	/// <name>Brewing</name>
	Brewing = 3,

	/// <summary>
	/// Tailoring ("cloth")
	/// </summary>
	/// <name>Cloth</name>
	Cloth = 4,

	/// <summary>
	/// Farming ("farming")
	/// </summary>
	/// <name>Farming</name>
	Farming = 6,

	/// <summary>
	/// Forest ("foxforest")
	/// </summary>
	/// <name>Forest</name>
	Forest = 7,

	/// <summary>
	/// Cooperation ("cooperation")
	/// </summary>
	/// <name>FoxesCooperation</name>
	FoxesCooperation = 19,

	/// <summary></summary>
	/// <name>Hearth_Bats</name>
	Hearth_Bats = 20,

	/// <summary></summary>
	/// <name>Hearth_Beavers</name>
	Hearth_Beavers = 8,

	/// <summary></summary>
	/// <name>Hearth_Foxes</name>
	Hearth_Foxes = 9,

	/// <summary></summary>
	/// <name>Hearth_Frogs</name>
	Hearth_Frogs = 10,

	/// <summary></summary>
	/// <name>Hearth_Harpies</name>
	Hearth_Harpies = 11,

	/// <summary></summary>
	/// <name>Hearth_Humans</name>
	Hearth_Humans = 12,

	/// <summary></summary>
	/// <name>Hearth_Lizards</name>
	Hearth_Lizards = 13,

	/// <summary>
	/// Metallurgy ("metallurgy")
	/// </summary>
	/// <name>Metallurgy</name>
	Metallurgy = 21,

	/// <summary>
	/// Rainwater ("rainwater")
	/// </summary>
	/// <name>Rainwater</name>
	Rainwater = 14,

	/// <summary>
	/// Masonry ("stone")
	/// </summary>
	/// <name>Stone</name>
	Stone = 15,

	/// <summary>
	/// Engineering ("tech")
	/// </summary>
	/// <name>Tech</name>
	Tech = 16,

	/// <summary>
	/// Warmth ("fire")
	/// </summary>
	/// <name>Warmth</name>
	Warmth = 17,

	/// <summary>
	/// Woodworking ("wood")
	/// </summary>
	/// <name>Wood</name>
	Wood = 18,



	/// <summary>
	/// The total number of vanilla BuildingTagTypes in the game.
	/// </summary>
	[Obsolete("Use BuildingTagTypesExtensions.Count(). BuildingTagTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 22
}

/// <summary>
/// Extension methods for the BuildingTagTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class BuildingTagTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in BuildingTagTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded BuildingTagTypes.
	/// </summary>
	public static BuildingTagTypes[] All()
	{
		BuildingTagTypes[] all = new BuildingTagTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
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

		APILogger.LogError($"Cannot find name of BuildingTagTypes: " + type);
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

		APILogger.LogWarning("Cannot find BuildingTagTypes with name: " + name + "\n" + Environment.StackTrace);
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
	
		APILogger.LogError("Cannot find BuildingTagModel for BuildingTagTypes with name: " + name);
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
		{ BuildingTagTypes.Alchemy, "Alchemy" },                   // Alchemy ("alchemy")
		{ BuildingTagTypes.Animals, "Animals" },                   // Meat production ("meat")
		{ BuildingTagTypes.Brewing, "Brewing" },                   // Brewing ("brewing")
		{ BuildingTagTypes.Cloth, "Cloth" },                       // Tailoring ("cloth")
		{ BuildingTagTypes.Farming, "Farming" },                   // Farming ("farming")
		{ BuildingTagTypes.Forest, "Forest" },                     // Forest ("foxforest")
		{ BuildingTagTypes.FoxesCooperation, "FoxesCooperation" }, // Cooperation ("cooperation")
		{ BuildingTagTypes.Hearth_Bats, "Hearth_Bats" }, 
		{ BuildingTagTypes.Hearth_Beavers, "Hearth_Beavers" }, 
		{ BuildingTagTypes.Hearth_Foxes, "Hearth_Foxes" }, 
		{ BuildingTagTypes.Hearth_Frogs, "Hearth_Frogs" }, 
		{ BuildingTagTypes.Hearth_Harpies, "Hearth_Harpies" }, 
		{ BuildingTagTypes.Hearth_Humans, "Hearth_Humans" }, 
		{ BuildingTagTypes.Hearth_Lizards, "Hearth_Lizards" }, 
		{ BuildingTagTypes.Metallurgy, "Metallurgy" },             // Metallurgy ("metallurgy")
		{ BuildingTagTypes.Rainwater, "Rainwater" },               // Rainwater ("rainwater")
		{ BuildingTagTypes.Stone, "Stone" },                       // Masonry ("stone")
		{ BuildingTagTypes.Tech, "Tech" },                         // Engineering ("tech")
		{ BuildingTagTypes.Warmth, "Warmth" },                     // Warmth ("fire")
		{ BuildingTagTypes.Wood, "Wood" },                         // Woodworking ("wood")

	};
}
