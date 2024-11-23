using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.17R
public enum ResourcesDepositsTypes
{
	Unknown = -1,
	None,
	Marsh_Infinite_Node_Grain,                               // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Infinite_Node_Meat,                                // Dead Leviathan - A giant, dead beast. How did it get here? Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Infinite_Node_Mushrooms,                           // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Big_Reptile_Nest_Big,                         // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Big_Reptile_Nest_Small,                       // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a camp with a <sprite name=grade1> recipe or better.
	Marsh_Node_Insect_Nest_Big,                              // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Insect_Nest_Small,                            // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade1> recipe or better.
	Marsh_Node_Mushroom_Deposit_Big,                         // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Mushroom_Deposit_Small,                       // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade1> recipe or better.
	Marsh_Node_Small_Reptile_Nest_Big,                       // Snake Nest (Large) - A dangerous, but rich source of food and leather. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Small_Reptile_Nest_Small,                     // Snake Nest (Small) - A dangerous, but rich source of food and leather. Requires a camp with a <sprite name=grade1> recipe or better.
	Marsh_Node_Stone_Deposit_Big,                            // Overgrown Stone Deposit (Large) - Stones weathered by the everlasting rain, covered with moss. Requires a camp with a <sprite name=grade2> recipe or better.
	Marsh_Node_Stone_Deposit_Small,                          // Overgrown Stone Deposit (Small) - Stones weathered by the everlasting rain, covered with moss. Requires a camp with a <sprite name=grade1> recipe or better.
	Moor_Node_Herbs_Big,                                     // Herb Node (Large) - A dense shrub, full of many useful plant species. Requires a camp with a <sprite name=grade2> recipe or better.
	Moor_Node_Herbs_Small,                                   // Herb Node (Small) - A dense shrub, full of many useful plant species. Requires a camp with a <sprite name=grade1> recipe or better.
	Moor_Node_Reed_Deposit_Big,                              // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain. Requires a camp with a <sprite name=grade2> recipe or better.
	Moor_Node_Reed_Deposit_Small,                            // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain. Requires a camp with a <sprite name=grade1> recipe or better.
	Moor_Node_Swamp_Wheat_Big,                               // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp. Requires a camp with a <sprite name=grade2> recipe or better.
	Moor_Node_Swamp_Wheat_Small,                             // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Clay_Deposit_Big,                         // Clay Deposit (Large) - Soil infused with the essence of the rain. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Clay_Deposit_Small,                       // Clay Deposit (Small) - Soil infused with the essence of the rain. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Dewberries_Big,                           // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Dewberries_Small,                         // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Leather_Big,                              // Water Strider Molt (Large) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Leather_Small,                            // Water Strider Molt (Small) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Mushroom_Deposit_Big,                     // Bleeding Tooth Mushroom (Large) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Mushroom_Deposit_Small,                   // Bleeding Tooth Mushroom (Small) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Root_Deposit_Big,                         // Root Deposit (Large) - A tangled net of living vines. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Root_Deposit_Small,                       // Root Deposit (Small) - A tangled net of living vines. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Sea_Marrow_Deposit_Big,                   // Sea Marrow Deposit (Large) - Ancient fossils, rich in resources. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Sea_Marrow_Deposit_Small,                 // Sea Marrow Deposit (Small) - Ancient fossils, rich in resources. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Stone_Deposit_Big,                        // Stone Deposit (Large) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Stone_Deposit_Small,                      // Stone Deposit (Small) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Stone_Deposit_Small_Petrified_Necropolis, // Stone Deposit (Small) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade1> recipe or better.
	Universal_Node_Stormbird_Nest_Big,                       // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a camp with a <sprite name=grade2> recipe or better.
	Universal_Node_Stormbird_Nest_Small,                     // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a camp with a <sprite name=grade1> recipe or better.
	Wood_Node_Flax_Big,                                      // Flax Field (Large) - Resilient plants that are perfect for cloth-making. Requires a camp with a <sprite name=grade2> recipe or better.
	Wood_Node_Flax_Small,                                    // Flax Field (Small) - Resilient plants that are perfect for cloth-making. Requires a camp with a <sprite name=grade1> recipe or better.
	Wood_Node_Moss_Broccoli_Big,                             // Moss Broccoli Patch (Large) - An edible and tasty type of moss. Requires a camp with a <sprite name=grade2> recipe or better.
	Wood_Node_Moss_Broccoli_Small,                           // Moss Broccoli Patch (Small) - An edible and tasty type of moss. Requires a camp with a <sprite name=grade1> recipe or better.
	Wood_Node_Snail_Broodmother_Big,                         // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a camp with a <sprite name=grade2> recipe or better.
	Wood_Node_Snail_Broodmother_Small,                       // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a camp with a <sprite name=grade1> recipe or better.
	Wood_Node_Wormtongue_Nest_Big,                           // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade2> recipe or better.
	Wood_Node_Wormtongue_Nest_Small,                         // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade1> recipe or better.


	MAX = 44
}

public static class ResourcesDepositsTypesExtensions
{
	private static ResourcesDepositsTypes[] s_All = null;
	public static ResourcesDepositsTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new ResourcesDepositsTypes[44];
			for (int i = 0; i < 44; i++)
			{
				s_All[i] = (ResourcesDepositsTypes)(i+1);
			}
		}
		return s_All;
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

		Plugin.Log.LogError($"Cannot find name of ResourcesDepositsTypes: " + type + "\n" + Environment.StackTrace);
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

		Plugin.Log.LogWarning("Cannot find ResourcesDepositsTypes with name: " + name + "\n" + Environment.StackTrace);
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
	
		Plugin.Log.LogError("Cannot find ResourceDepositModel for ResourcesDepositsTypes with name: " + name + "\n" + Environment.StackTrace);
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
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Grain, "Marsh Infinite Node Grain" },                                                                 // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Meat, "Marsh Infinite Node Meat" },                                                                   // Dead Leviathan - A giant, dead beast. How did it get here? Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Infinite_Node_Mushrooms, "Marsh Infinite Node Mushrooms" },                                                         // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Big_Reptile_Nest_Big, "Marsh Node Big Reptile Nest - Big" },                                                   // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Big_Reptile_Nest_Small, "Marsh Node Big Reptile Nest - Small" },                                               // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Insect_Nest_Big, "Marsh Node Insect Nest - Big" },                                                             // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Insect_Nest_Small, "Marsh Node Insect Nest - Small" },                                                         // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Mushroom_Deposit_Big, "Marsh Node Mushroom Deposit - Big" },                                                   // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Mushroom_Deposit_Small, "Marsh Node Mushroom Deposit - Small" },                                               // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Small_Reptile_Nest_Big, "Marsh Node Small Reptile Nest - Big" },                                               // Snake Nest (Large) - A dangerous, but rich source of food and leather. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Small_Reptile_Nest_Small, "Marsh Node Small Reptile Nest - Small" },                                           // Snake Nest (Small) - A dangerous, but rich source of food and leather. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Stone_Deposit_Big, "Marsh Node Stone Deposit - Big" },                                                         // Overgrown Stone Deposit (Large) - Stones weathered by the everlasting rain, covered with moss. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Marsh_Node_Stone_Deposit_Small, "Marsh Node Stone Deposit - Small" },                                                     // Overgrown Stone Deposit (Small) - Stones weathered by the everlasting rain, covered with moss. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Herbs_Big, "Moor Node Herbs - Big" },                                                                           // Herb Node (Large) - A dense shrub, full of many useful plant species. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Herbs_Small, "Moor Node Herbs - Small" },                                                                       // Herb Node (Small) - A dense shrub, full of many useful plant species. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Reed_Deposit_Big, "Moor Node Reed Deposit - Big" },                                                             // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Reed_Deposit_Small, "Moor Node Reed Deposit - Small" },                                                         // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Swamp_Wheat_Big, "Moor Node Swamp Wheat - Big" },                                                               // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Moor_Node_Swamp_Wheat_Small, "Moor Node Swamp Wheat - Small" },                                                           // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Clay_Deposit_Big, "Universal Node Clay Deposit - Big" },                                                   // Clay Deposit (Large) - Soil infused with the essence of the rain. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Clay_Deposit_Small, "Universal Node Clay Deposit - Small" },                                               // Clay Deposit (Small) - Soil infused with the essence of the rain. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Dewberries_Big, "Universal Node Dewberries - Big" },                                                       // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Dewberries_Small, "Universal Node Dewberries - Small" },                                                   // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Leather_Big, "Universal Node Leather - Big" },                                                             // Water Strider Molt (Large) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Leather_Small, "Universal Node Leather - Small" },                                                         // Water Strider Molt (Small) - A leathery exoskeleton left behind by a juvenile water strider. It's better to collect the skin this way than to come across a live, wild specimen. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Mushroom_Deposit_Big, "Universal Node Mushroom Deposit - Big" },                                           // Bleeding Tooth Mushroom (Large) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Mushroom_Deposit_Small, "Universal Node Mushroom Deposit - Small" },                                       // Bleeding Tooth Mushroom (Small) - A resilient species that grows on marshy soil. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Root_Deposit_Big, "Universal Node Root Deposit - Big" },                                                   // Root Deposit (Large) - A tangled net of living vines. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Root_Deposit_Small, "Universal Node Root Deposit - Small" },                                               // Root Deposit (Small) - A tangled net of living vines. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Sea_Marrow_Deposit_Big, "Universal Node Sea Marrow Deposit - Big" },                                       // Sea Marrow Deposit (Large) - Ancient fossils, rich in resources. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Sea_Marrow_Deposit_Small, "Universal Node Sea Marrow Deposit - Small" },                                   // Sea Marrow Deposit (Small) - Ancient fossils, rich in resources. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Big, "Universal Node Stone Deposit - Big" },                                                 // Stone Deposit (Large) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Small, "Universal Node Stone Deposit - Small" },                                             // Stone Deposit (Small) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stone_Deposit_Small_Petrified_Necropolis, "Universal Node Stone Deposit - Small - Petrified Necropolis" }, // Stone Deposit (Small) - Stones, weathered by the everlasting rain. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stormbird_Nest_Big, "Universal Node Stormbird Nest - Big" },                                               // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Universal_Node_Stormbird_Nest_Small, "Universal Node Stormbird Nest - Small" },                                           // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Flax_Big, "Wood Node Flax - Big" },                                                                             // Flax Field (Large) - Resilient plants that are perfect for cloth-making. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Flax_Small, "Wood Node Flax - Small" },                                                                         // Flax Field (Small) - Resilient plants that are perfect for cloth-making. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Moss_Broccoli_Big, "Wood Node Moss Broccoli - Big" },                                                           // Moss Broccoli Patch (Large) - An edible and tasty type of moss. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Moss_Broccoli_Small, "Wood Node Moss Broccoli - Small" },                                                       // Moss Broccoli Patch (Small) - An edible and tasty type of moss. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Snail_Broodmother_Big, "Wood Node Snail Broodmother - Big" },                                                   // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Snail_Broodmother_Small, "Wood Node Snail Broodmother - Small" },                                               // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them. Requires a camp with a <sprite name=grade1> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Wormtongue_Nest_Big, "Wood Node Wormtongue Nest - Big" },                                                       // Wormtongue Nest (Large) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade2> recipe or better.
		{ ResourcesDepositsTypes.Wood_Node_Wormtongue_Nest_Small, "Wood Node Wormtongue Nest - Small" },                                                   // Wormtongue Nest (Small) - A nest full of tasty wormtongues. Requires a camp with a <sprite name=grade1> recipe or better.

	};
}
