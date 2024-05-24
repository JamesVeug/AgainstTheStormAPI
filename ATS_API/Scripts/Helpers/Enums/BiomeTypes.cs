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
	Coral_Forest,           // Coral Forest
	Cursed_Royal_Woodlands, // Cursed Royal Woodlands
	Moorlands,              // Scarlet Orchard
	Royal_Woodlands,        // Royal Woodlands
	Sealed_Biome,           // Sealed Forest
	The_Marshlands,         // The Marshlands
	Tutorial_I,             // Tutorial
	Tutorial_II,            // Tutorial
	Tutorial_III,           // Tutorial
	Tutorial_IV,            // Tutorial

    MAX = 11
}

public static class BiomeTypesExtensions
{
	public static string ToName(this BiomeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BiomeTypes: " + type);
		return TypeToInternalName[BiomeTypes.Capital];
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
		{ BiomeTypes.Coral_Forest, "Coral Forest" },                     // Coral Forest
		{ BiomeTypes.Cursed_Royal_Woodlands, "Cursed Royal Woodlands" }, // Cursed Royal Woodlands
		{ BiomeTypes.Moorlands, "Moorlands" },                           // Scarlet Orchard
		{ BiomeTypes.Royal_Woodlands, "Royal Woodlands" },               // Royal Woodlands
		{ BiomeTypes.Sealed_Biome, "Sealed Biome" },                     // Sealed Forest
		{ BiomeTypes.The_Marshlands, "The Marshlands" },                 // The Marshlands
		{ BiomeTypes.Tutorial_I, "Tutorial I" },                         // Tutorial
		{ BiomeTypes.Tutorial_II, "Tutorial II" },                       // Tutorial
		{ BiomeTypes.Tutorial_III, "Tutorial III" },                     // Tutorial
		{ BiomeTypes.Tutorial_IV, "Tutorial IV" },                       // Tutorial
	};
}
