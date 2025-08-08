using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.10R
/// </summary>
public enum BuildingRainpunkModelTypes
{
	/// <summary>
	/// Placeholder for an unknown BuildingRainpunkModelTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no BuildingRainpunkModelTypes. Typically, seen if nothing is defined or failed to parse a string to a BuildingRainpunkModelTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Crafting Rainpunk Module</name>
	/// <water>Clearance Water</water>
	/// <buildings>Makeshift Post, Cooperage, Flawless Cooperage, Cobbler, Weaver</buildings>
	Crafting_Rainpunk_Module = 1,

	/// <summary></summary>
	/// <name>Food Rainpunk Module</name>
	/// <water>Drizzle Water</water>
	/// <buildings>Ranch, Field Kitchen, Bakery, Cookhouse, Smokehouse</buildings>
	Food_Rainpunk_Module = 2,

	/// <summary></summary>
	/// <name>Industry Rainpunk Module</name>
	/// <water>Storm Water</water>
	/// <buildings>Temporary Engineering Station, Crude Workstation, Workshop, Lumbermill, Carpenter</buildings>
	Industry_Rainpunk_Module = 3,



	/// <summary>
	/// The total number of vanilla BuildingRainpunkModelTypes in the game.
	/// </summary>
	[Obsolete("Use BuildingRainpunkModelTypesExtensions.Count(). BuildingRainpunkModelTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 4
}

/// <summary>
/// Extension methods for the BuildingRainpunkModelTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class BuildingRainpunkModelTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in BuildingRainpunkModelTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded BuildingRainpunkModelTypes.
	/// </summary>
	public static BuildingRainpunkModelTypes[] All()
	{
		BuildingRainpunkModelTypes[] all = new BuildingRainpunkModelTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BuildingRainpunkModelTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BuildingRainpunkModelTypes.Crafting_Rainpunk_Module in the enum and log an error.
	/// </summary>
	public static string ToName(this BuildingRainpunkModelTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of BuildingRainpunkModelTypes: " + type);
		return TypeToInternalName[BuildingRainpunkModelTypes.Crafting_Rainpunk_Module];
	}
	
	/// <summary>
	/// Returns a BuildingRainpunkModelTypes associated with the given name.
	/// Every BuildingRainpunkModelTypes should have a unique name as to distinguish it from others.
	/// If no BuildingRainpunkModelTypes is found, it will return BuildingRainpunkModelTypes.Unknown and log a warning.
	/// </summary>
	public static BuildingRainpunkModelTypes ToBuildingRainpunkModelTypes(this string name)
	{
		foreach (KeyValuePair<BuildingRainpunkModelTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find BuildingRainpunkModelTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingRainpunkModelTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a BuildingRainpunkModel associated with the given name.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If no BuildingRainpunkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel ToBuildingRainpunkModel(this string name)
	{
		Eremite.Buildings.BuildingRainpunkModel model = SO.Settings.Buildings.Where(a=> a is WorkshopModel w && w.rainpunk != null).Select(a=>((WorkshopModel)a).rainpunk).FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find BuildingRainpunkModel for BuildingRainpunkModelTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a BuildingRainpunkModel associated with the given BuildingRainpunkModelTypes.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If no BuildingRainpunkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel ToBuildingRainpunkModel(this BuildingRainpunkModelTypes types)
	{
		return types.ToName().ToBuildingRainpunkModel();
	}
	
	/// <summary>
	/// Returns an array of BuildingRainpunkModel associated with the given BuildingRainpunkModelTypes.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If a BuildingRainpunkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel[] ToBuildingRainpunkModelArray(this IEnumerable<BuildingRainpunkModelTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingRainpunkModel[] array = new Eremite.Buildings.BuildingRainpunkModel[count];
		int i = 0;
		foreach (BuildingRainpunkModelTypes element in collection)
		{
			array[i++] = element.ToBuildingRainpunkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingRainpunkModel associated with the given BuildingRainpunkModelTypes.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If a BuildingRainpunkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel[] ToBuildingRainpunkModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingRainpunkModel[] array = new Eremite.Buildings.BuildingRainpunkModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingRainpunkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingRainpunkModel associated with the given BuildingRainpunkModelTypes.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If a BuildingRainpunkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel[] ToBuildingRainpunkModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingRainpunkModel>.Get(out List<Eremite.Buildings.BuildingRainpunkModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.BuildingRainpunkModel model = element.ToBuildingRainpunkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BuildingRainpunkModel associated with the given BuildingRainpunkModelTypes.
	/// BuildingRainpunkModel contain all the data that will be used in the game.
	/// Every BuildingRainpunkModel should have a unique name as to distinguish it from others.
	/// If a BuildingRainpunkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingRainpunkModel[] ToBuildingRainpunkModelArrayNoNulls(this IEnumerable<BuildingRainpunkModelTypes> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingRainpunkModel>.Get(out List<Eremite.Buildings.BuildingRainpunkModel> list))
		{
			foreach (BuildingRainpunkModelTypes element in collection)
			{
				Eremite.Buildings.BuildingRainpunkModel model = element.ToBuildingRainpunkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BuildingRainpunkModelTypes, string> TypeToInternalName = new()
	{
		{ BuildingRainpunkModelTypes.Crafting_Rainpunk_Module, "Crafting Rainpunk Module" }, 
		{ BuildingRainpunkModelTypes.Food_Rainpunk_Module, "Food Rainpunk Module" }, 
		{ BuildingRainpunkModelTypes.Industry_Rainpunk_Module, "Industry Rainpunk Module" }, 

	};
}
