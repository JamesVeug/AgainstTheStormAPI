using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.9.3R
/// </summary>
public enum ResourcesDepositsTypes
{
	/// <summary>
	/// Placeholder for an unknown ResourcesDepositsTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no ResourcesDepositsTypes. Typically, seen if nothing is defined or failed to parse a string to a ResourcesDepositsTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Infinite Node Grain</name>
	Marsh_Infinite_Node_Grain = 1,

	/// <summary>
	/// Dead Leviathan - A giant, dead beast. How did it get here? Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Infinite Node Meat</name>
	Marsh_Infinite_Node_Meat = 2,

	/// <summary>
	/// Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Infinite Node Mushrooms</name>
	Marsh_Infinite_Node_Mushrooms = 3,

	/// <summary>
	/// Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Node Big Reptile Nest - Big</name>
	Marsh_Node_Big_Reptile_Nest_Big = 4,

	/// <summary>
	/// Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Marsh Node Big Reptile Nest - Small</name>
	Marsh_Node_Big_Reptile_Nest_Small = 5,

	/// <summary>
	/// Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Node Insect Nest - Big</name>
	Marsh_Node_Insect_Nest_Big = 6,

	/// <summary>
	/// Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Marsh Node Insect Nest - Small</name>
	Marsh_Node_Insect_Nest_Small = 7,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Node Mushroom Deposit - Big</name>
	Marsh_Node_Mushroom_Deposit_Big = 8,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Marsh Node Mushroom Deposit - Small</name>
	Marsh_Node_Mushroom_Deposit_Small = 9,

	/// <summary>
	/// Snake Nest (Large) - A dangerous, but rich source of food and leather. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Node Small Reptile Nest - Big</name>
	Marsh_Node_Small_Reptile_Nest_Big = 10,

	/// <summary>
	/// Snake Nest (Small) - A dangerous, but rich source of food and leather. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Marsh Node Small Reptile Nest - Small</name>
	Marsh_Node_Small_Reptile_Nest_Small = 11,

	/// <summary>
	/// Overgrown Stone Node (Large) - Stones weathered by the everlasting rain, covered with moss. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Marsh Node Stone Deposit - Big</name>
	Marsh_Node_Stone_Deposit_Big = 12,

	/// <summary>
	/// Overgrown Stone Node (Small) - Stones weathered by the everlasting rain, covered with moss. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Marsh Node Stone Deposit - Small</name>
	Marsh_Node_Stone_Deposit_Small = 13,

	/// <summary>
	/// Herb Node (Large) - A dense shrub, full of many useful plant species. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Moor Node Herbs - Big</name>
	Moor_Node_Herbs_Big = 14,

	/// <summary>
	/// Herb Node (Small) - A dense shrub, full of many useful plant species. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Moor Node Herbs - Small</name>
	Moor_Node_Herbs_Small = 15,

	/// <summary>
	/// Reed Field (Large) - A very common plant, it thrives thanks to the magical rain. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Moor Node Reed Deposit - Big</name>
	Moor_Node_Reed_Deposit_Big = 16,

	/// <summary>
	/// Reed Field (Small) - A very common plant, it thrives thanks to the magical rain. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Moor Node Reed Deposit - Small</name>
	Moor_Node_Reed_Deposit_Small = 17,

	/// <summary>
	/// Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Moor Node Swamp Wheat - Big</name>
	Moor_Node_Swamp_Wheat_Big = 18,

	/// <summary>
	/// Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Moor Node Swamp Wheat - Small</name>
	Moor_Node_Swamp_Wheat_Small = 19,

	/// <summary>
	/// Clay Node (Large) - Soil infused with the essence of the rain. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Clay Deposit - Big</name>
	Universal_Node_Clay_Deposit_Big = 20,

	/// <summary>
	/// Clay Node (Small) - Soil infused with the essence of the rain. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Clay Deposit - Small</name>
	Universal_Node_Clay_Deposit_Small = 21,

	/// <summary>
	/// Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Dewberries - Big</name>
	Universal_Node_Dewberries_Big = 22,

	/// <summary>
	/// Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Dewberries - Small</name>
	Universal_Node_Dewberries_Small = 23,

	/// <summary>
	/// Water Strider Molt (Large) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Leather - Big</name>
	Universal_Node_Leather_Big = 24,

	/// <summary>
	/// Water Strider Molt (Small) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Leather - Small</name>
	Universal_Node_Leather_Small = 25,

	/// <summary>
	/// Bleeding Tooth Mushroom (Large) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Mushroom Deposit - Big</name>
	Universal_Node_Mushroom_Deposit_Big = 26,

	/// <summary>
	/// Bleeding Tooth Mushroom (Small) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Mushroom Deposit - Small</name>
	Universal_Node_Mushroom_Deposit_Small = 27,

	/// <summary>
	/// Root Node (Large) - A tangled net of living vines. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Root Deposit - Big</name>
	Universal_Node_Root_Deposit_Big = 28,

	/// <summary>
	/// Root Node (Small) - A tangled net of living vines. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Root Deposit - Small</name>
	Universal_Node_Root_Deposit_Small = 29,

	/// <summary>
	/// Sea Marrow Node (Large) - Ancient fossils, rich in resources. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Sea Marrow Deposit - Big</name>
	Universal_Node_Sea_Marrow_Deposit_Big = 30,

	/// <summary>
	/// Sea Marrow Node (Small) - Ancient fossils, rich in resources. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Sea Marrow Deposit - Small</name>
	Universal_Node_Sea_Marrow_Deposit_Small = 31,

	/// <summary>
	/// Stone Node (Large) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Stone Deposit - Big</name>
	Universal_Node_Stone_Deposit_Big = 32,

	/// <summary>
	/// Stone Node (Small) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Stone Deposit - Small</name>
	Universal_Node_Stone_Deposit_Small = 33,

	/// <summary>
	/// Stone Node (Small) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Stone Deposit - Small - Petrified Necropolis</name>
	Universal_Node_Stone_Deposit_Small_Petrified_Necropolis = 34,

	/// <summary>
	/// Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Universal Node Stormbird Nest - Big</name>
	Universal_Node_Stormbird_Nest_Big = 35,

	/// <summary>
	/// Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Universal Node Stormbird Nest - Small</name>
	Universal_Node_Stormbird_Nest_Small = 36,

	/// <summary>
	/// Flax Field (Large) - Resilient plants that are perfect for cloth-making. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Wood Node Flax - Big</name>
	Wood_Node_Flax_Big = 37,

	/// <summary>
	/// Flax Field (Small) - Resilient plants that are perfect for cloth-making. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Wood Node Flax - Small</name>
	Wood_Node_Flax_Small = 38,

	/// <summary>
	/// Moss Broccoli Patch (Large) - An edible and tasty type of moss. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Wood Node Moss Broccoli - Big</name>
	Wood_Node_Moss_Broccoli_Big = 39,

	/// <summary>
	/// Moss Broccoli Patch (Small) - An edible and tasty type of moss. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Wood Node Moss Broccoli - Small</name>
	Wood_Node_Moss_Broccoli_Small = 40,

	/// <summary>
	/// Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Wood Node Snail Broodmother - Big</name>
	Wood_Node_Snail_Broodmother_Big = 41,

	/// <summary>
	/// Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Wood Node Snail Broodmother - Small</name>
	Wood_Node_Snail_Broodmother_Small = 42,

	/// <summary>
	/// Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a gathering camp with a grade2 recipe or better.
	/// </summary>
	/// <name>Wood Node Wormtongue Nest - Big</name>
	Wood_Node_Wormtongue_Nest_Big = 43,

	/// <summary>
	/// Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a gathering camp with a grade1 recipe or better.
	/// </summary>
	/// <name>Wood Node Wormtongue Nest - Small</name>
	Wood_Node_Wormtongue_Nest_Small = 44,



	/// <summary>
	/// The total number of vanilla ResourcesDepositsTypes in the game.
	/// </summary>
	[Obsolete("Use ResourcesDepositsTypesExtensions.Count(). ResourcesDepositsTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 45
}

/// <summary>
/// Extension methods for the ResourcesDepositsTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class ResourcesDepositsTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in ResourcesDepositsTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded ResourcesDepositsTypes.
	/// </summary>
	public static ResourcesDepositsTypes[] All()
	{
		ResourcesDepositsTypes[] all = new ResourcesDepositsTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every ResourcesDepositsTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return ResourcesDepositsTypes.Marsh_Infinite_Node_Grain in the enum and log an error.
	/// </summary>
	public static string ToName(this ResourcesDepositsTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of ResourcesDepositsTypes: " + type);
		return TypeToInternalName[ResourcesDepositsTypes.Marsh_Infinite_Node_Grain];
	}
	
	/// <summary>
	/// Returns a ResourcesDepositsTypes associated with the given name.
	/// Every ResourcesDepositsTypes should have a unique name as to distinguish it from others.
	/// If no ResourcesDepositsTypes is found, it will return ResourcesDepositsTypes.Unknown and log a warning.
	/// </summary>
	public static ResourcesDepositsTypes ToResourcesDepositsTypes(this string name)
	{
		foreach (KeyValuePair<ResourcesDepositsTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find ResourcesDepositsTypes with name: " + name + "\n" + Environment.StackTrace);
		return ResourcesDepositsTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a ResourceDepositModel associated with the given name.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If no ResourceDepositModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel ToResourceDepositModel(this string name)
	{
		Eremite.Model.ResourceDepositModel model = SO.Settings.ResourcesDeposits.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find ResourceDepositModel for ResourcesDepositsTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a ResourceDepositModel associated with the given ResourcesDepositsTypes.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If no ResourceDepositModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel ToResourceDepositModel(this ResourcesDepositsTypes types)
	{
		return types.ToName().ToResourceDepositModel();
	}
	
	/// <summary>
	/// Returns an array of ResourceDepositModel associated with the given ResourcesDepositsTypes.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If a ResourceDepositModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel[] ToResourceDepositModelArray(this IEnumerable<ResourcesDepositsTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.ResourceDepositModel[] array = new Eremite.Model.ResourceDepositModel[count];
		int i = 0;
		foreach (ResourcesDepositsTypes element in collection)
		{
			array[i++] = element.ToResourceDepositModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ResourceDepositModel associated with the given ResourcesDepositsTypes.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If a ResourceDepositModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel[] ToResourceDepositModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.ResourceDepositModel[] array = new Eremite.Model.ResourceDepositModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToResourceDepositModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ResourceDepositModel associated with the given ResourcesDepositsTypes.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If a ResourceDepositModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel[] ToResourceDepositModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.ResourceDepositModel>.Get(out List<Eremite.Model.ResourceDepositModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.ResourceDepositModel model = element.ToResourceDepositModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of ResourceDepositModel associated with the given ResourcesDepositsTypes.
	/// ResourceDepositModel contain all the data that will be used in the game.
	/// Every ResourceDepositModel should have a unique name as to distinguish it from others.
	/// If a ResourceDepositModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ResourceDepositModel[] ToResourceDepositModelArrayNoNulls(this IEnumerable<ResourcesDepositsTypes> collection)
	{
		using(ListPool<Eremite.Model.ResourceDepositModel>.Get(out List<Eremite.Model.ResourceDepositModel> list))
		{
			foreach (ResourcesDepositsTypes element in collection)
			{
				Eremite.Model.ResourceDepositModel model = element.ToResourceDepositModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<ResourcesDepositsTypes, string> TypeToInternalName = new()
	{
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Grain, "Marsh Infinite Node Grain" },                                                                 // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Meat, "Marsh Infinite Node Meat" },                                                                   // Dead Leviathan - A giant, dead beast. How did it get here? Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Mushrooms, "Marsh Infinite Node Mushrooms" },                                                         // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Big_Reptile_Nest_Big, "Marsh Node Big Reptile Nest - Big" },                                                   // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Big_Reptile_Nest_Small, "Marsh Node Big Reptile Nest - Small" },                                               // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Insect_Nest_Big, "Marsh Node Insect Nest - Big" },                                                             // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Insect_Nest_Small, "Marsh Node Insect Nest - Small" },                                                         // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Mushroom_Deposit_Big, "Marsh Node Mushroom Deposit - Big" },                                                   // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Mushroom_Deposit_Small, "Marsh Node Mushroom Deposit - Small" },                                               // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Small_Reptile_Nest_Big, "Marsh Node Small Reptile Nest - Big" },                                               // Snake Nest (Large) - A dangerous, but rich source of food and leather. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Small_Reptile_Nest_Small, "Marsh Node Small Reptile Nest - Small" },                                           // Snake Nest (Small) - A dangerous, but rich source of food and leather. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Stone_Deposit_Big, "Marsh Node Stone Deposit - Big" },                                                         // Overgrown Stone Node (Large) - Stones weathered by the everlasting rain, covered with moss. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Stone_Deposit_Small, "Marsh Node Stone Deposit - Small" },                                                     // Overgrown Stone Node (Small) - Stones weathered by the everlasting rain, covered with moss. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Herbs_Big, "Moor Node Herbs - Big" },                                                                           // Herb Node (Large) - A dense shrub, full of many useful plant species. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Herbs_Small, "Moor Node Herbs - Small" },                                                                       // Herb Node (Small) - A dense shrub, full of many useful plant species. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Reed_Deposit_Big, "Moor Node Reed Deposit - Big" },                                                             // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Reed_Deposit_Small, "Moor Node Reed Deposit - Small" },                                                         // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Swamp_Wheat_Big, "Moor Node Swamp Wheat - Big" },                                                               // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Swamp_Wheat_Small, "Moor Node Swamp Wheat - Small" },                                                           // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Clay_Deposit_Big, "Universal Node Clay Deposit - Big" },                                                   // Clay Node (Large) - Soil infused with the essence of the rain. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Clay_Deposit_Small, "Universal Node Clay Deposit - Small" },                                               // Clay Node (Small) - Soil infused with the essence of the rain. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Dewberries_Big, "Universal Node Dewberries - Big" },                                                       // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Dewberries_Small, "Universal Node Dewberries - Small" },                                                   // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Leather_Big, "Universal Node Leather - Big" },                                                             // Water Strider Molt (Large) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Leather_Small, "Universal Node Leather - Small" },                                                         // Water Strider Molt (Small) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Mushroom_Deposit_Big, "Universal Node Mushroom Deposit - Big" },                                           // Bleeding Tooth Mushroom (Large) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Mushroom_Deposit_Small, "Universal Node Mushroom Deposit - Small" },                                       // Bleeding Tooth Mushroom (Small) - A resilient species that grows on marshy soil. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Root_Deposit_Big, "Universal Node Root Deposit - Big" },                                                   // Root Node (Large) - A tangled net of living vines. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Root_Deposit_Small, "Universal Node Root Deposit - Small" },                                               // Root Node (Small) - A tangled net of living vines. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Sea_Marrow_Deposit_Big, "Universal Node Sea Marrow Deposit - Big" },                                       // Sea Marrow Node (Large) - Ancient fossils, rich in resources. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Sea_Marrow_Deposit_Small, "Universal Node Sea Marrow Deposit - Small" },                                   // Sea Marrow Node (Small) - Ancient fossils, rich in resources. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Big, "Universal Node Stone Deposit - Big" },                                                 // Stone Node (Large) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Small, "Universal Node Stone Deposit - Small" },                                             // Stone Node (Small) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Small_Petrified_Necropolis, "Universal Node Stone Deposit - Small - Petrified Necropolis" }, // Stone Node (Small) - Stones, weathered by the everlasting rain. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stormbird_Nest_Big, "Universal Node Stormbird Nest - Big" },                                               // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stormbird_Nest_Small, "Universal Node Stormbird Nest - Small" },                                           // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Flax_Big, "Wood Node Flax - Big" },                                                                             // Flax Field (Large) - Resilient plants that are perfect for cloth-making. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Flax_Small, "Wood Node Flax - Small" },                                                                         // Flax Field (Small) - Resilient plants that are perfect for cloth-making. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Moss_Broccoli_Big, "Wood Node Moss Broccoli - Big" },                                                           // Moss Broccoli Patch (Large) - An edible and tasty type of moss. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Moss_Broccoli_Small, "Wood Node Moss Broccoli - Small" },                                                       // Moss Broccoli Patch (Small) - An edible and tasty type of moss. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Snail_Broodmother_Big, "Wood Node Snail Broodmother - Big" },                                                   // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Snail_Broodmother_Small, "Wood Node Snail Broodmother - Small" },                                               // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a gathering camp with a grade1 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Wormtongue_Nest_Big, "Wood Node Wormtongue Nest - Big" },                                                       // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a gathering camp with a grade2 recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Wormtongue_Nest_Small, "Wood Node Wormtongue Nest - Small" },                                                   // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a gathering camp with a grade1 recipe or better.

	};
}
