using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.WorldMap;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum BiomeTypes
{
    /// <summary>
    /// Placeholder for an unknown BiomeTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no BiomeTypes. Typically, seen if nothing is defined or failed to parse a string to a BiomeTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Coastal Grove - These lands have been underwater for centuries, allowing a dense forest of algae to flourish. The surrounding seawater has almost completely cut off the area from the rest of the kingdom, leaving the nearby marshes almost untouched and full of the remains of ancient settlements.
	/// </summary>
	/// <name>Bay</name>
	Bay = 1,

	/// <summary>
	/// Citadel
	/// </summary>
	/// <name>Capital</name>
	Capital = 2,

	/// <summary>
	/// Coral Forest - The true source of the coral’s growth is unknown. Contrary to common belief, it doesn't usually appear in flooded regions. The unique influence of the coral mutates trees into distinctive strands that offer various resources.
	/// </summary>
	/// <name>Coral Forest</name>
	Coral_Forest = 3,

	/// <summary>
	/// Cursed Royal Woodlands - A cursed area of the Royal Woodlands that is haunted by the lost souls of warriors fallen in the Great Civil War. The storm here is especially dangerous, and the forest more hostile than anywhere else. The Queen will handsomely reward any viceroy brave enough to settle this part of the world.
	/// </summary>
	/// <name>Cursed Royal Woodlands</name>
	Cursed_Royal_Woodlands = 4,

	/// <summary>
	/// Scarlet Orchard - A beautiful yet dangerous land that is colored a strange shade of crimson. It's called the Herb Garden of the Kingdom due to its abundance of herbs, berries, and roots.
	/// </summary>
	/// <name>Moorlands</name>
	Moorlands = 5,

	/// <summary>
	/// Royal Woodlands - The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.
	/// </summary>
	/// <name>Royal Woodlands</name>
	Royal_Woodlands = 6,

	/// <summary>
	/// Sealed Forest - Somewhere in this thick and dark forest, an ancient seal is hidden. Even the Ancients, in all their might and glory, couldn't defeat the creatures slumbering below - so they just imprisoned them. Over millennia, their sinister power gradually seeped to the surface, infecting the fauna and flora of this region. Viceroys don't embark here to establish settlements or gain reputation - their main goal is simply to find and close the seal.
	/// </summary>
	/// <name>Sealed Biome</name>
	Sealed_Biome = 7,

	/// <summary>
	/// Marshlands - A harsh and cold land that has been claimed by many different, and extremely resilient species of fungi. The ground here is extremely hard and rocky, making it difficult to farm. This region is most famous for the giant organisms that can be found in its forests.
	/// </summary>
	/// <name>The Marshlands</name>
	The_Marshlands = 8,

	/// <summary>
	/// Tutorial - Tutorial
	/// </summary>
	/// <name>Tutorial I</name>
	Tutorial_I = 9,

	/// <summary>
	/// Tutorial - Tutorial
	/// </summary>
	/// <name>Tutorial II</name>
	Tutorial_II = 10,

	/// <summary>
	/// Tutorial - Tutorial
	/// </summary>
	/// <name>Tutorial III</name>
	Tutorial_III = 11,

	/// <summary>
	/// Tutorial - Tutorial
	/// </summary>
	/// <name>Tutorial IV</name>
	Tutorial_IV = 12,

	/// <summary>
	/// Ashen Thicket - Once a thriving forest of giant ashen trees, this land has been ravaged by relentless industrial exploitation and heavy mining, all driven by the lure of Thunderblight Shards - magically charged amber crystals used to craft cornerstones.
	/// </summary>
	/// <name>Wasteland</name>
	Wasteland = 13,



    /// <summary>
    /// The total number of vanilla BiomeTypes in the game.
    /// </summary>
	MAX = 13
}

/// <summary>
/// Extension methods for the BiomeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class BiomeTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded BiomeTypes.
	/// </summary>
	public static BiomeTypes[] All()
	{
		BiomeTypes[] all = new BiomeTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BiomeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BiomeTypes.Bay in the enum and log an error.
	/// </summary>
	public static string ToName(this BiomeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of BiomeTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[BiomeTypes.Bay];
	}
	
	/// <summary>
	/// Returns a BiomeTypes associated with the given name.
	/// Every BiomeTypes should have a unique name as to distinguish it from others.
	/// If no BiomeTypes is found, it will return BiomeTypes.Unknown and log a warning.
	/// </summary>
	public static BiomeTypes ToBiomeTypes(this string name)
	{
		foreach (KeyValuePair<BiomeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find BiomeTypes with name: " + name + "\n" + Environment.StackTrace);
		return BiomeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a BiomeModel associated with the given name.
	/// BiomeModel contain all the data that will be used in the game.
	/// Every BiomeModel should have a unique name as to distinguish it from others.
	/// If no BiomeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.WorldMap.BiomeModel ToBiomeModel(this string name)
	{
		Eremite.WorldMap.BiomeModel model = SO.Settings.biomes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find BiomeModel for BiomeTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a BiomeModel associated with the given BiomeTypes.
    /// BiomeModel contain all the data that will be used in the game.
    /// Every BiomeModel should have a unique name as to distinguish it from others.
    /// If no BiomeModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.WorldMap.BiomeModel ToBiomeModel(this BiomeTypes types)
	{
		return types.ToName().ToBiomeModel();
	}
	
	/// <summary>
	/// Returns an array of BiomeModel associated with the given BiomeTypes.
	/// BiomeModel contain all the data that will be used in the game.
	/// Every BiomeModel should have a unique name as to distinguish it from others.
	/// If a BiomeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.WorldMap.BiomeModel[] ToBiomeModelArray(this IEnumerable<BiomeTypes> collection)
	{
		int count = collection.Count();
		Eremite.WorldMap.BiomeModel[] array = new Eremite.WorldMap.BiomeModel[count];
		int i = 0;
		foreach (BiomeTypes element in collection)
		{
			array[i++] = element.ToBiomeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BiomeModel associated with the given BiomeTypes.
	/// BiomeModel contain all the data that will be used in the game.
	/// Every BiomeModel should have a unique name as to distinguish it from others.
	/// If a BiomeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.WorldMap.BiomeModel[] ToBiomeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.WorldMap.BiomeModel[] array = new Eremite.WorldMap.BiomeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBiomeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BiomeModel associated with the given BiomeTypes.
	/// BiomeModel contain all the data that will be used in the game.
	/// Every BiomeModel should have a unique name as to distinguish it from others.
	/// If a BiomeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.WorldMap.BiomeModel[] ToBiomeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.WorldMap.BiomeModel>.Get(out List<Eremite.WorldMap.BiomeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.WorldMap.BiomeModel model = element.ToBiomeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BiomeModel associated with the given BiomeTypes.
	/// BiomeModel contain all the data that will be used in the game.
	/// Every BiomeModel should have a unique name as to distinguish it from others.
	/// If a BiomeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.WorldMap.BiomeModel[] ToBiomeModelArrayNoNulls(this IEnumerable<BiomeTypes> collection)
	{
		using(ListPool<Eremite.WorldMap.BiomeModel>.Get(out List<Eremite.WorldMap.BiomeModel> list))
		{
			foreach (BiomeTypes element in collection)
			{
				Eremite.WorldMap.BiomeModel model = element.ToBiomeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BiomeTypes, string> TypeToInternalName = new()
	{
		{ BiomeTypes.Bay, "Bay" },                                       // Coastal Grove - These lands have been underwater for centuries, allowing a dense forest of algae to flourish. The surrounding seawater has almost completely cut off the area from the rest of the kingdom, leaving the nearby marshes almost untouched and full of the remains of ancient settlements.
		{ BiomeTypes.Capital, "Capital" },                               // Citadel
		{ BiomeTypes.Coral_Forest, "Coral Forest" },                     // Coral Forest - The true source of the coral’s growth is unknown. Contrary to common belief, it doesn't usually appear in flooded regions. The unique influence of the coral mutates trees into distinctive strands that offer various resources.
		{ BiomeTypes.Cursed_Royal_Woodlands, "Cursed Royal Woodlands" }, // Cursed Royal Woodlands - A cursed area of the Royal Woodlands that is haunted by the lost souls of warriors fallen in the Great Civil War. The storm here is especially dangerous, and the forest more hostile than anywhere else. The Queen will handsomely reward any viceroy brave enough to settle this part of the world.
		{ BiomeTypes.Moorlands, "Moorlands" },                           // Scarlet Orchard - A beautiful yet dangerous land that is colored a strange shade of crimson. It's called the Herb Garden of the Kingdom due to its abundance of herbs, berries, and roots.
		{ BiomeTypes.Royal_Woodlands, "Royal Woodlands" },               // Royal Woodlands - The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.
		{ BiomeTypes.Sealed_Biome, "Sealed Biome" },                     // Sealed Forest - Somewhere in this thick and dark forest, an ancient seal is hidden. Even the Ancients, in all their might and glory, couldn't defeat the creatures slumbering below - so they just imprisoned them. Over millennia, their sinister power gradually seeped to the surface, infecting the fauna and flora of this region. Viceroys don't embark here to establish settlements or gain reputation - their main goal is simply to find and close the seal.
		{ BiomeTypes.The_Marshlands, "The Marshlands" },                 // Marshlands - A harsh and cold land that has been claimed by many different, and extremely resilient species of fungi. The ground here is extremely hard and rocky, making it difficult to farm. This region is most famous for the giant organisms that can be found in its forests.
		{ BiomeTypes.Tutorial_I, "Tutorial I" },                         // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_II, "Tutorial II" },                       // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_III, "Tutorial III" },                     // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_IV, "Tutorial IV" },                       // Tutorial - Tutorial
		{ BiomeTypes.Wasteland, "Wasteland" },                           // Ashen Thicket - Once a thriving forest of giant ashen trees, this land has been ravaged by relentless industrial exploitation and heavy mining, all driven by the lure of Thunderblight Shards - magically charged amber crystals used to craft cornerstones.

	};
}
