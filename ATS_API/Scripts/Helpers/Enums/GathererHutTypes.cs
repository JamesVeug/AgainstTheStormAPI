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
public enum GathererHutTypes
{
	/// <summary>
	/// Placeholder for an unknown GathererHutTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no GathererHutTypes. Typically, seen if nothing is defined or failed to parse a string to a GathererHutTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
	/// </summary>
	/// <name>Forager's Camp</name>
	Foragers_Camp = 1,

	/// <summary>
	/// Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
	/// </summary>
	/// <name>Harvester Camp</name>
	Harvester_Camp = 2,

	/// <summary>
	/// Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Herbalist's Camp</name>
	Herbalists_Camp = 3,

	/// <summary>
	/// Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
	/// </summary>
	/// <name>Primitive Forager's Camp</name>
	Primitive_Foragers_Camp = 4,

	/// <summary>
	/// Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
	/// </summary>
	/// <name>Primitive Herbalist's Camp</name>
	Primitive_Herbalists_Camp = 5,

	/// <summary>
	/// Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
	/// </summary>
	/// <name>Primitive Trapper's Camp</name>
	Primitive_Trappers_Camp = 6,

	/// <summary>
	/// Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
	/// </summary>
	/// <name>Stonecutter's Camp</name>
	Stonecutters_Camp = 7,

	/// <summary>
	/// Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).
	/// </summary>
	/// <name>Trapper's Camp</name>
	Trappers_Camp = 8,



	/// <summary>
	/// The total number of vanilla GathererHutTypes in the game.
	/// </summary>
	[Obsolete("Use GathererHutTypesExtensions.Count(). GathererHutTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 9
}

/// <summary>
/// Extension methods for the GathererHutTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class GathererHutTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in GathererHutTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded GathererHutTypes.
	/// </summary>
	public static GathererHutTypes[] All()
	{
		GathererHutTypes[] all = new GathererHutTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every GathererHutTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return GathererHutTypes.Foragers_Camp in the enum and log an error.
	/// </summary>
	public static string ToName(this GathererHutTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of GathererHutTypes: " + type);
		return TypeToInternalName[GathererHutTypes.Foragers_Camp];
	}
	
	/// <summary>
	/// Returns a GathererHutTypes associated with the given name.
	/// Every GathererHutTypes should have a unique name as to distinguish it from others.
	/// If no GathererHutTypes is found, it will return GathererHutTypes.Unknown and log a warning.
	/// </summary>
	public static GathererHutTypes ToGathererHutTypes(this string name)
	{
		foreach (KeyValuePair<GathererHutTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find GathererHutTypes with name: " + name + "\n" + Environment.StackTrace);
		return GathererHutTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a GathererHutModel associated with the given name.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If no GathererHutModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel ToGathererHutModel(this string name)
	{
		Eremite.Buildings.GathererHutModel model = SO.Settings.Buildings.Where(a=>a is GathererHutModel).Cast<GathererHutModel>().FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find GathererHutModel for GathererHutTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a GathererHutModel associated with the given GathererHutTypes.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If no GathererHutModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel ToGathererHutModel(this GathererHutTypes types)
	{
		return types.ToName().ToGathererHutModel();
	}
	
	/// <summary>
	/// Returns an array of GathererHutModel associated with the given GathererHutTypes.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If a GathererHutModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel[] ToGathererHutModelArray(this IEnumerable<GathererHutTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.GathererHutModel[] array = new Eremite.Buildings.GathererHutModel[count];
		int i = 0;
		foreach (GathererHutTypes element in collection)
		{
			array[i++] = element.ToGathererHutModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GathererHutModel associated with the given GathererHutTypes.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If a GathererHutModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel[] ToGathererHutModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.GathererHutModel[] array = new Eremite.Buildings.GathererHutModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGathererHutModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GathererHutModel associated with the given GathererHutTypes.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If a GathererHutModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel[] ToGathererHutModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.GathererHutModel>.Get(out List<Eremite.Buildings.GathererHutModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.GathererHutModel model = element.ToGathererHutModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of GathererHutModel associated with the given GathererHutTypes.
	/// GathererHutModel contain all the data that will be used in the game.
	/// Every GathererHutModel should have a unique name as to distinguish it from others.
	/// If a GathererHutModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.GathererHutModel[] ToGathererHutModelArrayNoNulls(this IEnumerable<GathererHutTypes> collection)
	{
		using(ListPool<Eremite.Buildings.GathererHutModel>.Get(out List<Eremite.Buildings.GathererHutModel> list))
		{
			foreach (GathererHutTypes element in collection)
			{
				Eremite.Buildings.GathererHutModel model = element.ToGathererHutModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<GathererHutTypes, string> TypeToInternalName = new()
	{
		{ GathererHutTypes.Foragers_Camp, "Forager's Camp" },                         // Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
		{ GathererHutTypes.Harvester_Camp, "Harvester Camp" },                        // Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
		{ GathererHutTypes.Herbalists_Camp, "Herbalist's Camp" },                     // Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ GathererHutTypes.Primitive_Foragers_Camp, "Primitive Forager's Camp" },     // Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
		{ GathererHutTypes.Primitive_Herbalists_Camp, "Primitive Herbalist's Camp" }, // Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
		{ GathererHutTypes.Primitive_Trappers_Camp, "Primitive Trapper's Camp" },     // Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
		{ GathererHutTypes.Stonecutters_Camp, "Stonecutter's Camp" },                 // Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
		{ GathererHutTypes.Trappers_Camp, "Trapper's Camp" },                         // Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).

	};
}
