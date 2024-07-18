using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.WorldMap;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum BiomeTypes
{
	Unknown = -1,
	None,
	Capital,                // Citadel
	Coral_Forest,           // Coral Forest - The true source of the coral’s growth is unknown. Contrary to common belief, it doesn't usually appear in flooded regions. The unique influence of the coral mutates trees into distinctive strands that offer various resources.
	Cursed_Royal_Woodlands, // Cursed Royal Woodlands - A cursed area of the Royal Woodlands that is haunted by the lost souls of warriors fallen in the Great Civil War. The storm here is especially dangerous, and the forest more hostile than anywhere else. The Queen will handsomely reward any viceroy brave enough to settle this part of the world.
	Moorlands,              // Scarlet Orchard - A beautiful yet dangerous land that is colored a strange shade of crimson. It's called the Herb Garden of the Kingdom due to its abundance of herbs, berries, and roots.
	Royal_Woodlands,        // Royal Woodlands - The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.
	Sealed_Biome,           // Sealed Forest - Somewhere in this thick and dark forest, an ancient seal is hidden. Even the Ancients, in all their might and glory, couldn't defeat the creatures slumbering below - so they just imprisoned them. Over millennia, their sinister power gradually seeped to the surface, infecting the fauna and flora of this region. Viceroys don't embark here to establish settlements or gain reputation - their main goal is simply to find and close the seal.
	The_Marshlands,         // The Marshlands - A harsh and cold land that has been claimed by many different, and extremely resilient species of fungi. The ground here is extremely hard and rocky, making it difficult to farm. This region is most famous for the giant organisms that can be found in its forests.
	Tutorial_I,             // Tutorial - Tutorial
	Tutorial_II,            // Tutorial - Tutorial
	Tutorial_III,           // Tutorial - Tutorial
	Tutorial_IV,            // Tutorial - Tutorial


	MAX = 11
}

public static class BiomeTypesExtensions
{
	private static BiomeTypes[] s_All = null;
	public static BiomeTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new BiomeTypes[11];
			for (int i = 0; i < 11; i++)
			{
				s_All[i] = (BiomeTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this BiomeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BiomeTypes: " + type);
		return TypeToInternalName[BiomeTypes.Capital];
	}
	
	public static BiomeTypes ToBiomeTypes(this string name)
	{
		foreach (KeyValuePair<BiomeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find BiomeTypes with name: " + name);
		return BiomeTypes.Unknown;
	}
	
	public static BiomeModel ToBiomeModel(this string name)
	{
		BiomeModel model = SO.Settings.biomes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find BiomeModel for BiomeTypes with name: " + name);
		return null;
	}

	public static BiomeModel ToBiomeModel(this BiomeTypes types)
	{
		return types.ToName().ToBiomeModel();
	}
	
	public static BiomeModel[] ToBiomeModelArray(this IEnumerable<BiomeTypes> collection)
	{
		int count = collection.Count();
		BiomeModel[] array = new BiomeModel[count];
		int i = 0;
		foreach (BiomeTypes element in collection)
		{
			string elementName = element.ToName();
			array[i++] = SO.Settings.biomes.FirstOrDefault(a=>a.name == elementName);
		}

		return array;
	}

	internal static readonly Dictionary<BiomeTypes, string> TypeToInternalName = new()
	{
		{ BiomeTypes.Capital, "Capital" },                               // Citadel
		{ BiomeTypes.Coral_Forest, "Coral Forest" },                     // Coral Forest - The true source of the coral’s growth is unknown. Contrary to common belief, it doesn't usually appear in flooded regions. The unique influence of the coral mutates trees into distinctive strands that offer various resources.
		{ BiomeTypes.Cursed_Royal_Woodlands, "Cursed Royal Woodlands" }, // Cursed Royal Woodlands - A cursed area of the Royal Woodlands that is haunted by the lost souls of warriors fallen in the Great Civil War. The storm here is especially dangerous, and the forest more hostile than anywhere else. The Queen will handsomely reward any viceroy brave enough to settle this part of the world.
		{ BiomeTypes.Moorlands, "Moorlands" },                           // Scarlet Orchard - A beautiful yet dangerous land that is colored a strange shade of crimson. It's called the Herb Garden of the Kingdom due to its abundance of herbs, berries, and roots.
		{ BiomeTypes.Royal_Woodlands, "Royal Woodlands" },               // Royal Woodlands - The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.
		{ BiomeTypes.Sealed_Biome, "Sealed Biome" },                     // Sealed Forest - Somewhere in this thick and dark forest, an ancient seal is hidden. Even the Ancients, in all their might and glory, couldn't defeat the creatures slumbering below - so they just imprisoned them. Over millennia, their sinister power gradually seeped to the surface, infecting the fauna and flora of this region. Viceroys don't embark here to establish settlements or gain reputation - their main goal is simply to find and close the seal.
		{ BiomeTypes.The_Marshlands, "The Marshlands" },                 // The Marshlands - A harsh and cold land that has been claimed by many different, and extremely resilient species of fungi. The ground here is extremely hard and rocky, making it difficult to farm. This region is most famous for the giant organisms that can be found in its forests.
		{ BiomeTypes.Tutorial_I, "Tutorial I" },                         // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_II, "Tutorial II" },                       // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_III, "Tutorial III" },                     // Tutorial - Tutorial
		{ BiomeTypes.Tutorial_IV, "Tutorial IV" },                       // Tutorial - Tutorial

	};
}
