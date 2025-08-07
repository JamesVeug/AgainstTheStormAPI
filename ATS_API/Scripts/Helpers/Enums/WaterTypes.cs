using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.9R
/// </summary>
public enum WaterTypes
{
	/// <summary>
	/// Placeholder for an unknown WaterTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no WaterTypes. Typically, seen if nothing is defined or failed to parse a string to a WaterTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
	/// </summary>
	/// <name>Clearance Water</name>
	Clearance_Water = 1,

	/// <summary>
	/// Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
	/// </summary>
	/// <name>Drizzle Water</name>
	Drizzle_Water = 2,

	/// <summary>
	/// Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.
	/// </summary>
	/// <name>Storm Water</name>
	Storm_Water = 3,



	/// <summary>
	/// The total number of vanilla WaterTypes in the game.
	/// </summary>
	[Obsolete("Use WaterTypesExtensions.Count(). WaterTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 4
}

/// <summary>
/// Extension methods for the WaterTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class WaterTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in WaterTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded WaterTypes.
	/// </summary>
	public static WaterTypes[] All()
	{
		WaterTypes[] all = new WaterTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every WaterTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return WaterTypes.Clearance_Water in the enum and log an error.
	/// </summary>
	public static string ToName(this WaterTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of WaterTypes: " + type);
		return TypeToInternalName[WaterTypes.Clearance_Water];
	}
	
	/// <summary>
	/// Returns a WaterTypes associated with the given name.
	/// Every WaterTypes should have a unique name as to distinguish it from others.
	/// If no WaterTypes is found, it will return WaterTypes.Unknown and log a warning.
	/// </summary>
	public static WaterTypes ToWaterTypes(this string name)
	{
		foreach (KeyValuePair<WaterTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find WaterTypes with name: " + name + "\n" + Environment.StackTrace);
		return WaterTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a WaterModel associated with the given name.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If no WaterModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.WaterModel ToWaterModel(this string name)
	{
		Eremite.Model.WaterModel model = SO.Settings.Waters.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find WaterModel for WaterTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a WaterModel associated with the given WaterTypes.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If no WaterModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.WaterModel ToWaterModel(this WaterTypes types)
	{
		return types.ToName().ToWaterModel();
	}
	
	/// <summary>
	/// Returns an array of WaterModel associated with the given WaterTypes.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If a WaterModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.WaterModel[] ToWaterModelArray(this IEnumerable<WaterTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.WaterModel[] array = new Eremite.Model.WaterModel[count];
		int i = 0;
		foreach (WaterTypes element in collection)
		{
			array[i++] = element.ToWaterModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WaterModel associated with the given WaterTypes.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If a WaterModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.WaterModel[] ToWaterModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.WaterModel[] array = new Eremite.Model.WaterModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToWaterModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WaterModel associated with the given WaterTypes.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If a WaterModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.WaterModel[] ToWaterModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.WaterModel>.Get(out List<Eremite.Model.WaterModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.WaterModel model = element.ToWaterModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of WaterModel associated with the given WaterTypes.
	/// WaterModel contain all the data that will be used in the game.
	/// Every WaterModel should have a unique name as to distinguish it from others.
	/// If a WaterModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.WaterModel[] ToWaterModelArrayNoNulls(this IEnumerable<WaterTypes> collection)
	{
		using(ListPool<Eremite.Model.WaterModel>.Get(out List<Eremite.Model.WaterModel> list))
		{
			foreach (WaterTypes element in collection)
			{
				Eremite.Model.WaterModel model = element.ToWaterModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<WaterTypes, string> TypeToInternalName = new()
	{
		{ WaterTypes.Clearance_Water, "Clearance Water" }, // Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
		{ WaterTypes.Drizzle_Water, "Drizzle Water" },     // Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
		{ WaterTypes.Storm_Water, "Storm Water" },         // Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.

	};
}
