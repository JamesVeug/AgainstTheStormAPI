using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.5.2R
public enum BuildingCategoriesTypes
{
	Unknown = -1,
	None,
	
	/// <summary>
	/// City Buildings
	/// </summary>
	/// <name>City Buildings</name>
	City_Buildings,

	/// <summary>
	/// Rec
	/// </summary>
	/// <name>Debug Nodes</name>
	Debug_Nodes,

	/// <summary>
	/// Decorations
	/// </summary>
	/// <name>Decorations</name>
	Decorations,

	/// <summary>
	/// Glade Event
	/// </summary>
	/// <name>Event</name>
	Event,

	/// <summary>
	/// Battlefield Spirit
	/// </summary>
	/// <name>Event Ghost</name>
	Event_Ghost,

	/// <summary>
	/// Food Production
	/// </summary>
	/// <name>Food Production</name>
	Food_Production,

	/// <summary>
	/// Housing
	/// </summary>
	/// <name>Housing</name>
	Housing,

	/// <summary>
	/// Industry
	/// </summary>
	/// <name>Industry</name>
	Industry,

	/// <summary>
	/// Lore Tablet I
	/// </summary>
	/// <name>Lore Tablet 1</name>
	Lore_Tablet_1,

	/// <summary>
	/// Lore Tablet II
	/// </summary>
	/// <name>Lore Tablet 2</name>
	Lore_Tablet_2,

	/// <summary>
	/// Lore Tablet III
	/// </summary>
	/// <name>Lore Tablet 3</name>
	Lore_Tablet_3,

	/// <summary>
	/// Lore Tablet IV
	/// </summary>
	/// <name>Lore Tablet 4</name>
	Lore_Tablet_4,

	/// <summary>
	/// Lore Tablet V
	/// </summary>
	/// <name>Lore Tablet 5</name>
	Lore_Tablet_5,

	/// <summary>
	/// Lore Tablet VI
	/// </summary>
	/// <name>Lore Tablet 6</name>
	Lore_Tablet_6,

	/// <summary>
	/// Lore Tablet VII
	/// </summary>
	/// <name>Lore Tablet 7</name>
	Lore_Tablet_7,

	/// <summary>
	/// Ancient Relic
	/// </summary>
	/// <name>Relics</name>
	Relics,

	/// <summary>
	/// Resource Gathering
	/// </summary>
	/// <name>Resource Gathering</name>
	Resource_Gathering,

	/// <summary>
	/// Roads
	/// </summary>
	/// <name>Roads</name>
	Roads,

	/// <summary>
	/// Ruin
	/// </summary>
	/// <name>Ruins</name>
	Ruins,

	/// <summary>
	/// City Buildings
	/// </summary>
	/// <name>Tutorial - invisible</name>
	Tutorial_Invisible,



	MAX = 20
}

public static class BuildingCategoriesTypesExtensions
{
	private static BuildingCategoriesTypes[] s_All = null;
	public static BuildingCategoriesTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new BuildingCategoriesTypes[20];
			for (int i = 0; i < 20; i++)
			{
				s_All[i] = (BuildingCategoriesTypes)(i+1);
			}
		}
		return s_All;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BuildingCategoriesTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BuildingCategoriesTypes.City_Buildings in the enum and log an error.
	/// </summary>
	public static string ToName(this BuildingCategoriesTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingCategoriesTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[BuildingCategoriesTypes.City_Buildings];
	}
	
	/// <summary>
	/// Returns a BuildingCategoriesTypes associated with the given name.
	/// Every BuildingCategoriesTypes should have a unique name as to distinguish it from others.
	/// If no BuildingCategoriesTypes is found, it will return BuildingCategoriesTypes.Unknown and log a warning.
	/// </summary>
	public static BuildingCategoriesTypes ToBuildingCategoriesTypes(this string name)
	{
		foreach (KeyValuePair<BuildingCategoriesTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find BuildingCategoriesTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingCategoriesTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a BuildingCategoryModel associated with the given name.
	/// BuildingCategoryModel contain all the data that will be used in the game.
	/// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
	/// If no BuildingCategoryModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingCategoryModel ToBuildingCategoryModel(this string name)
	{
		Eremite.Buildings.BuildingCategoryModel model = SO.Settings.BuildingCategories.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find BuildingCategoryModel for BuildingCategoriesTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a BuildingCategoryModel associated with the given BuildingCategoriesTypes.
    /// BuildingCategoryModel contain all the data that will be used in the game.
    /// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
    /// If no BuildingCategoryModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Buildings.BuildingCategoryModel ToBuildingCategoryModel(this BuildingCategoriesTypes types)
	{
		return types.ToName().ToBuildingCategoryModel();
	}
	
	/// <summary>
	/// Returns an array of BuildingCategoryModel associated with the given BuildingCategoriesTypes.
	/// BuildingCategoryModel contain all the data that will be used in the game.
	/// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
	/// If a BuildingCategoryModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingCategoryModel[] ToBuildingCategoryModelArray(this IEnumerable<BuildingCategoriesTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingCategoryModel[] array = new Eremite.Buildings.BuildingCategoryModel[count];
		int i = 0;
		foreach (BuildingCategoriesTypes element in collection)
		{
			array[i++] = element.ToBuildingCategoryModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingCategoryModel associated with the given BuildingCategoriesTypes.
	/// BuildingCategoryModel contain all the data that will be used in the game.
	/// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
	/// If a BuildingCategoryModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingCategoryModel[] ToBuildingCategoryModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingCategoryModel[] array = new Eremite.Buildings.BuildingCategoryModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingCategoryModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingCategoryModel associated with the given BuildingCategoriesTypes.
	/// BuildingCategoryModel contain all the data that will be used in the game.
	/// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
	/// If a BuildingCategoryModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingCategoryModel[] ToBuildingCategoryModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingCategoryModel>.Get(out List<Eremite.Buildings.BuildingCategoryModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.BuildingCategoryModel model = element.ToBuildingCategoryModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BuildingCategoryModel associated with the given BuildingCategoriesTypes.
	/// BuildingCategoryModel contain all the data that will be used in the game.
	/// Every BuildingCategoryModel should have a unique name as to distinguish it from others.
	/// If a BuildingCategoryModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingCategoryModel[] ToBuildingCategoryModelArrayNoNulls(this IEnumerable<BuildingCategoriesTypes> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingCategoryModel>.Get(out List<Eremite.Buildings.BuildingCategoryModel> list))
		{
			foreach (BuildingCategoriesTypes element in collection)
			{
				Eremite.Buildings.BuildingCategoryModel model = element.ToBuildingCategoryModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BuildingCategoriesTypes, string> TypeToInternalName = new()
	{
		{ BuildingCategoriesTypes.City_Buildings, "City Buildings" },           // City Buildings
		{ BuildingCategoriesTypes.Debug_Nodes, "Debug Nodes" },                 // Rec
		{ BuildingCategoriesTypes.Decorations, "Decorations" },                 // Decorations
		{ BuildingCategoriesTypes.Event, "Event" },                             // Glade Event
		{ BuildingCategoriesTypes.Event_Ghost, "Event Ghost" },                 // Battlefield Spirit
		{ BuildingCategoriesTypes.Food_Production, "Food Production" },         // Food Production
		{ BuildingCategoriesTypes.Housing, "Housing" },                         // Housing
		{ BuildingCategoriesTypes.Industry, "Industry" },                       // Industry
		{ BuildingCategoriesTypes.Lore_Tablet_1, "Lore Tablet 1" },             // Lore Tablet I
		{ BuildingCategoriesTypes.Lore_Tablet_2, "Lore Tablet 2" },             // Lore Tablet II
		{ BuildingCategoriesTypes.Lore_Tablet_3, "Lore Tablet 3" },             // Lore Tablet III
		{ BuildingCategoriesTypes.Lore_Tablet_4, "Lore Tablet 4" },             // Lore Tablet IV
		{ BuildingCategoriesTypes.Lore_Tablet_5, "Lore Tablet 5" },             // Lore Tablet V
		{ BuildingCategoriesTypes.Lore_Tablet_6, "Lore Tablet 6" },             // Lore Tablet VI
		{ BuildingCategoriesTypes.Lore_Tablet_7, "Lore Tablet 7" },             // Lore Tablet VII
		{ BuildingCategoriesTypes.Relics, "Relics" },                           // Ancient Relic
		{ BuildingCategoriesTypes.Resource_Gathering, "Resource Gathering" },   // Resource Gathering
		{ BuildingCategoriesTypes.Roads, "Roads" },                             // Roads
		{ BuildingCategoriesTypes.Ruins, "Ruins" },                             // Ruin
		{ BuildingCategoriesTypes.Tutorial_Invisible, "Tutorial - invisible" }, // City Buildings

	};
}
