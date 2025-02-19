using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum FarmTypes
{
	/// <summary>
	/// Placeholder for an unknown FarmTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no FarmTypes. Typically, seen if nothing is defined or failed to parse a string to a FarmTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
	/// </summary>
	/// <name>Grove</name>
	Grove = 1,

	/// <summary>
	/// Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed Herb Garden</name>
	Hallowed_Herb_Garden = 2,

	/// <summary>
	/// Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed SmallFarm</name>
	Hallowed_SmallFarm = 3,

	/// <summary>
	/// Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
	/// </summary>
	/// <name>Herb Garden</name>
	Herb_Garden = 4,

	/// <summary>
	/// Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Homestead</name>
	Homestead = 5,

	/// <summary>
	/// Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
	/// </summary>
	/// <name>Plantation</name>
	Plantation = 6,

	/// <summary>
	/// Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).
	/// </summary>
	/// <name>SmallFarm</name>
	SmallFarm = 7,



	/// <summary>
	/// The total number of vanilla FarmTypes in the game.
	/// </summary>
	MAX = 7
}

/// <summary>
/// Extension methods for the FarmTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class FarmTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded FarmTypes.
	/// </summary>
	public static FarmTypes[] All()
	{
		FarmTypes[] all = new FarmTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every FarmTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return FarmTypes.Grove in the enum and log an error.
	/// </summary>
	public static string ToName(this FarmTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of FarmTypes: " + type);
		return TypeToInternalName[FarmTypes.Grove];
	}
	
	/// <summary>
	/// Returns a FarmTypes associated with the given name.
	/// Every FarmTypes should have a unique name as to distinguish it from others.
	/// If no FarmTypes is found, it will return FarmTypes.Unknown and log a warning.
	/// </summary>
	public static FarmTypes ToFarmTypes(this string name)
	{
		foreach (KeyValuePair<FarmTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find FarmTypes with name: " + name + "\n" + Environment.StackTrace);
		return FarmTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a FarmModel associated with the given name.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If no FarmModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FarmModel ToFarmModel(this string name)
	{
		Eremite.Buildings.FarmModel model = SO.Settings.Buildings.Where(a=>a is FarmModel).Cast<FarmModel>().FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find FarmModel for FarmTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a FarmModel associated with the given FarmTypes.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If no FarmModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FarmModel ToFarmModel(this FarmTypes types)
	{
		return types.ToName().ToFarmModel();
	}
	
	/// <summary>
	/// Returns an array of FarmModel associated with the given FarmTypes.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If a FarmModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FarmModel[] ToFarmModelArray(this IEnumerable<FarmTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FarmModel[] array = new Eremite.Buildings.FarmModel[count];
		int i = 0;
		foreach (FarmTypes element in collection)
		{
			array[i++] = element.ToFarmModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FarmModel associated with the given FarmTypes.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If a FarmModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FarmModel[] ToFarmModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FarmModel[] array = new Eremite.Buildings.FarmModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToFarmModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FarmModel associated with the given FarmTypes.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If a FarmModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FarmModel[] ToFarmModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.FarmModel>.Get(out List<Eremite.Buildings.FarmModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.FarmModel model = element.ToFarmModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of FarmModel associated with the given FarmTypes.
	/// FarmModel contain all the data that will be used in the game.
	/// Every FarmModel should have a unique name as to distinguish it from others.
	/// If a FarmModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FarmModel[] ToFarmModelArrayNoNulls(this IEnumerable<FarmTypes> collection)
	{
		using(ListPool<Eremite.Buildings.FarmModel>.Get(out List<Eremite.Buildings.FarmModel> list))
		{
			foreach (FarmTypes element in collection)
			{
				Eremite.Buildings.FarmModel model = element.ToFarmModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<FarmTypes, string> TypeToInternalName = new()
	{
		{ FarmTypes.Grove, "Grove" },                               // Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
		{ FarmTypes.Hallowed_Herb_Garden, "Hallowed Herb Garden" }, // Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
		{ FarmTypes.Hallowed_SmallFarm, "Hallowed SmallFarm" },     // Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
		{ FarmTypes.Herb_Garden, "Herb Garden" },                   // Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
		{ FarmTypes.Homestead, "Homestead" },                       // Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ FarmTypes.Plantation, "Plantation" },                     // Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
		{ FarmTypes.SmallFarm, "SmallFarm" },                       // Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).

	};
}
