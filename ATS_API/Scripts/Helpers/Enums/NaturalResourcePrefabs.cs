using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;


// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.10R
/// </summary>
public enum NaturalResourcePrefabs
{
	/// <summary>
	/// Placeholder for an unknown NaturalResourcePrefabs. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no NaturalResourcePrefabs. Typically, seen if nothing is defined or failed to parse a string to a NaturalResourcePrefabs.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Bay Tree 1 - Kelpwood
	/// </summary>
	/// <name>Bay Tree 1</name>
	Bay_Tree_1 = 1,

	/// <summary>
	/// Bay Tree 2 - Kelpwood
	/// </summary>
	/// <name>Bay Tree 2</name>
	Bay_Tree_2 = 2,

	/// <summary>
	/// Bay Tree 3 - Kelpwood, Kelpwood
	/// </summary>
	/// <name>Bay Tree 3</name>
	Bay_Tree_3 = 3,

	/// <summary>
	/// Bay Tree 4 - Kelpwood
	/// </summary>
	/// <name>Bay Tree 4</name>
	Bay_Tree_4 = 4,

	/// <summary>
	/// Bay Tree 5 - Kelpwood
	/// </summary>
	/// <name>Bay Tree 5</name>
	Bay_Tree_5 = 5,

	/// <summary>
	/// Bay Tree 6 - Kelpwood, Kelpwood
	/// </summary>
	/// <name>Bay Tree 6</name>
	Bay_Tree_6 = 6,

	/// <summary>
	/// Cave Tree 1 - Basalt Tree
	/// </summary>
	/// <name>Cave Tree 1</name>
	Cave_Tree_1 = 56,

	/// <summary>
	/// Cave Tree 2 - Basalt Tree
	/// </summary>
	/// <name>Cave Tree 2</name>
	Cave_Tree_2 = 57,

	/// <summary>
	/// Cave Tree 3 - Basalt Tree
	/// </summary>
	/// <name>Cave Tree 3</name>
	Cave_Tree_3 = 58,

	/// <summary>
	/// Cave Tree 4 - Basalt Tree
	/// </summary>
	/// <name>Cave Tree 4</name>
	Cave_Tree_4 = 59,

	/// <summary>
	/// Cave Tree 5 - Basalt Tree, Basalt Tree
	/// </summary>
	/// <name>Cave Tree 5</name>
	Cave_Tree_5 = 60,

	/// <summary>
	/// Coral Forest Tree 3 - Crimsonreach Tree
	/// </summary>
	/// <name>Coral Forest Tree 3</name>
	Coral_Forest_Tree_3 = 7,

	/// <summary>
	/// Coral Forest Tree 4 - Plateleaf Tree
	/// </summary>
	/// <name>Coral Forest Tree 4</name>
	Coral_Forest_Tree_4 = 8,

	/// <summary>
	/// Coral Forest Tree 5 - Plateleaf Tree
	/// </summary>
	/// <name>Coral Forest Tree 5</name>
	Coral_Forest_Tree_5 = 9,

	/// <summary>
	/// Coral Forest Tree A1 - Musselsprout Tree
	/// </summary>
	/// <name>Coral Forest Tree A1</name>
	Coral_Forest_Tree_A1 = 10,

	/// <summary>
	/// Coral Forest Tree A2 - Musselsprout Tree
	/// </summary>
	/// <name>Coral Forest Tree A2</name>
	Coral_Forest_Tree_A2 = 11,

	/// <summary>
	/// Coral Forest Tree A3 - Musselsprout Tree
	/// </summary>
	/// <name>Coral Forest Tree A3</name>
	Coral_Forest_Tree_A3 = 12,

	/// <summary>
	/// Coral Forest Tree A4 - Musselsprout Tree
	/// </summary>
	/// <name>Coral Forest Tree A4</name>
	Coral_Forest_Tree_A4 = 13,

	/// <summary>
	/// Coral Forest Tree A5 - Musselsprout Tree
	/// </summary>
	/// <name>Coral Forest Tree A5</name>
	Coral_Forest_Tree_A5 = 14,

	/// <summary>
	/// Cursed Tree 3 - Dying Tree, Abyssal Tree
	/// </summary>
	/// <name>Cursed Tree 3</name>
	Cursed_Tree_3 = 15,

	/// <summary>
	/// Cursed Tree 6 - Dying Tree, Abyssal Tree
	/// </summary>
	/// <name>Cursed Tree 6</name>
	Cursed_Tree_6 = 16,

	/// <summary>
	/// Last Biome Tree 1 - Abyssal Tree, Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 1</name>
	Last_Biome_Tree_1 = 17,

	/// <summary>
	/// Last Biome Tree 2 - Abyssal Tree, Abyssal Tree, Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 2</name>
	Last_Biome_Tree_2 = 18,

	/// <summary>
	/// Last Biome Tree 3 - Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 3</name>
	Last_Biome_Tree_3 = 19,

	/// <summary>
	/// Last Biome Tree 4 - Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 4</name>
	Last_Biome_Tree_4 = 20,

	/// <summary>
	/// Last Biome Tree 5 - Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 5</name>
	Last_Biome_Tree_5 = 21,

	/// <summary>
	/// Last Biome Tree 6 - Overgrown Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 6</name>
	Last_Biome_Tree_6 = 22,

	/// <summary>
	/// Last Biome Tree 7 - Overgrown Abyssal Tree
	/// </summary>
	/// <name>Last Biome Tree 7</name>
	Last_Biome_Tree_7 = 23,

	/// <summary>
	/// Marshlands_Tree_01 - Mushwood, Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_01</name>
	Marshlands_Tree_01 = 24,

	/// <summary>
	/// Marshlands_Tree_02 - Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_02</name>
	Marshlands_Tree_02 = 25,

	/// <summary>
	/// Marshlands_Tree_03 - Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_03</name>
	Marshlands_Tree_03 = 26,

	/// <summary>
	/// Marshlands_Tree_04 - Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_04</name>
	Marshlands_Tree_04 = 27,

	/// <summary>
	/// Marshlands_Tree_05 - Mushwood, Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_05</name>
	Marshlands_Tree_05 = 28,

	/// <summary>
	/// Marshlands_Tree_06 - Mushwood, Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_06</name>
	Marshlands_Tree_06 = 29,

	/// <summary>
	/// Marshlands_Tree_07 - Mushwood, Mushwood
	/// </summary>
	/// <name>Marshlands_Tree_07</name>
	Marshlands_Tree_07 = 30,

	/// <summary>
	/// Moorlands Tree 1 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 1</name>
	Moorlands_Tree_1 = 31,

	/// <summary>
	/// Moorlands Tree 2 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 2</name>
	Moorlands_Tree_2 = 32,

	/// <summary>
	/// Moorlands Tree 3 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 3</name>
	Moorlands_Tree_3 = 33,

	/// <summary>
	/// Moorlands Tree 4 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 4</name>
	Moorlands_Tree_4 = 34,

	/// <summary>
	/// Moorlands Tree 5 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 5</name>
	Moorlands_Tree_5 = 35,

	/// <summary>
	/// Moorlands Tree 6 - Coppervein Tree
	/// </summary>
	/// <name>Moorlands Tree 6</name>
	Moorlands_Tree_6 = 36,

	/// <summary>
	/// Poro Biome Tree 1 - Tearsap Bamboo, Tearsap Bamboo
	/// </summary>
	/// <name>Poro Biome Tree 1</name>
	Poro_Biome_Tree_1 = 61,

	/// <summary>
	/// Poro Biome Tree 2 - Tearsap Bamboo, Tearsap Bamboo
	/// </summary>
	/// <name>Poro Biome Tree 2</name>
	Poro_Biome_Tree_2 = 62,

	/// <summary>
	/// Poro Biome Tree 3 - Tearsap Bamboo, Tearsap Bamboo
	/// </summary>
	/// <name>Poro Biome Tree 3</name>
	Poro_Biome_Tree_3 = 63,

	/// <summary>
	/// Tree 1 - Lush Tree
	/// </summary>
	/// <name>Tree 1</name>
	Tree_1 = 37,

	/// <summary>
	/// Tree 2 - Lush Tree
	/// </summary>
	/// <name>Tree 2</name>
	Tree_2 = 38,

	/// <summary>
	/// Tree 3 - Lush Tree
	/// </summary>
	/// <name>Tree 3</name>
	Tree_3 = 39,

	/// <summary>
	/// Tree 4 - Lush Tree
	/// </summary>
	/// <name>Tree 4</name>
	Tree_4 = 40,

	/// <summary>
	/// Tree 5 - Lush Tree
	/// </summary>
	/// <name>Tree 5</name>
	Tree_5 = 41,

	/// <summary>
	/// Tree 6 - Lush Tree
	/// </summary>
	/// <name>Tree 6</name>
	Tree_6 = 42,

	/// <summary>
	/// Tree 7 - Lush Tree
	/// </summary>
	/// <name>Tree 7</name>
	Tree_7 = 43,

	/// <summary>
	/// Wasteland Tree 1 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 1</name>
	Wasteland_Tree_1 = 44,

	/// <summary>
	/// Wasteland Tree 10 - Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 10</name>
	Wasteland_Tree_10 = 45,

	/// <summary>
	/// Wasteland Tree 11 - Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 11</name>
	Wasteland_Tree_11 = 46,

	/// <summary>
	/// Wasteland Tree 12 - Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 12</name>
	Wasteland_Tree_12 = 47,

	/// <summary>
	/// Wasteland Tree 2 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 2</name>
	Wasteland_Tree_2 = 48,

	/// <summary>
	/// Wasteland Tree 3 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 3</name>
	Wasteland_Tree_3 = 49,

	/// <summary>
	/// Wasteland Tree 4 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 4</name>
	Wasteland_Tree_4 = 50,

	/// <summary>
	/// Wasteland Tree 5 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 5</name>
	Wasteland_Tree_5 = 51,

	/// <summary>
	/// Wasteland Tree 6 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 6</name>
	Wasteland_Tree_6 = 52,

	/// <summary>
	/// Wasteland Tree 7 - Ashen Tree, Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 7</name>
	Wasteland_Tree_7 = 53,

	/// <summary>
	/// Wasteland Tree 8 - Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 8</name>
	Wasteland_Tree_8 = 54,

	/// <summary>
	/// Wasteland Tree 9 - Ashen Tree
	/// </summary>
	/// <name>Wasteland Tree 9</name>
	Wasteland_Tree_9 = 55,



	/// <summary>
	/// The total number of vanilla NaturalResourcePrefabs in the game.
	/// </summary>
	[Obsolete("Use NaturalResourcePrefabsExtensions.Count(). NaturalResourcePrefabs.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 64
}

/// <summary>
/// Extension methods for the NaturalResourcePrefabs enum to simplify getting and converting data to various types.
/// </summary>
public static class NaturalResourcePrefabsExtensions
{
	/// <summary>
	/// Returns how many enum values are in NaturalResourcePrefabs.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded NaturalResourcePrefabs.
	/// </summary>
	public static NaturalResourcePrefabs[] All()
	{
		NaturalResourcePrefabs[] all = new NaturalResourcePrefabs[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every NaturalResourcePrefabs should have a unique name as to distinguish it from others.
	/// If no name is found, it will return NaturalResourcePrefabs.Bay_Tree_1 in the enum and log an error.
	/// </summary>
	public static string ToName(this NaturalResourcePrefabs type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of NaturalResourcePrefabs: " + type);
		return TypeToInternalName[NaturalResourcePrefabs.Bay_Tree_1];
	}
	
	/// <summary>
	/// Returns a NaturalResourcePrefabs associated with the given name.
	/// Every NaturalResourcePrefabs should have a unique name as to distinguish it from others.
	/// If no NaturalResourcePrefabs is found, it will return NaturalResourcePrefabs.Unknown and log a warning.
	/// </summary>
	public static NaturalResourcePrefabs ToNaturalResourcePrefabs(this string name)
	{
		foreach (KeyValuePair<NaturalResourcePrefabs,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find NaturalResourcePrefabs with name: " + name + "\n" + Environment.StackTrace);
		return NaturalResourcePrefabs.Unknown;
	}
	
	/// <summary>
	/// Returns a NaturalResource associated with the given name.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If no NaturalResource is found, it will return null and log an error.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource ToNaturalResource(this string name)
	{
		Eremite.MapObjects.NaturalResource model = SO.Settings.NaturalResources.Select(a=>a.prefabs).SelectMany(a=>a).FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find NaturalResource for NaturalResourcePrefabs with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a NaturalResource associated with the given NaturalResourcePrefabs.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If no NaturalResource is found, it will return null and log an error.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource ToNaturalResource(this NaturalResourcePrefabs types)
	{
		return types.ToName().ToNaturalResource();
	}
	
	/// <summary>
	/// Returns an array of NaturalResource associated with the given NaturalResourcePrefabs.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If a NaturalResource is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource[] ToNaturalResourceArray(this IEnumerable<NaturalResourcePrefabs> collection)
	{
		int count = collection.Count();
		Eremite.MapObjects.NaturalResource[] array = new Eremite.MapObjects.NaturalResource[count];
		int i = 0;
		foreach (NaturalResourcePrefabs element in collection)
		{
			array[i++] = element.ToNaturalResource();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NaturalResource associated with the given NaturalResourcePrefabs.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If a NaturalResource is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource[] ToNaturalResourceArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.MapObjects.NaturalResource[] array = new Eremite.MapObjects.NaturalResource[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToNaturalResource();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NaturalResource associated with the given NaturalResourcePrefabs.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If a NaturalResource is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource[] ToNaturalResourceArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.MapObjects.NaturalResource>.Get(out List<Eremite.MapObjects.NaturalResource> list))
		{
			foreach (string element in collection)
			{
				Eremite.MapObjects.NaturalResource model = element.ToNaturalResource();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of NaturalResource associated with the given NaturalResourcePrefabs.
	/// NaturalResource contain all the data that will be used in the game.
	/// Every NaturalResource should have a unique name as to distinguish it from others.
	/// If a NaturalResource is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.MapObjects.NaturalResource[] ToNaturalResourceArrayNoNulls(this IEnumerable<NaturalResourcePrefabs> collection)
	{
		using(ListPool<Eremite.MapObjects.NaturalResource>.Get(out List<Eremite.MapObjects.NaturalResource> list))
		{
			foreach (NaturalResourcePrefabs element in collection)
			{
				Eremite.MapObjects.NaturalResource model = element.ToNaturalResource();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<NaturalResourcePrefabs, string> TypeToInternalName = new()
	{
		{ NaturalResourcePrefabs.Bay_Tree_1, "Bay Tree 1" },                     // Bay Tree 1 - Kelpwood
		{ NaturalResourcePrefabs.Bay_Tree_2, "Bay Tree 2" },                     // Bay Tree 2 - Kelpwood
		{ NaturalResourcePrefabs.Bay_Tree_3, "Bay Tree 3" },                     // Bay Tree 3 - Kelpwood, Kelpwood
		{ NaturalResourcePrefabs.Bay_Tree_4, "Bay Tree 4" },                     // Bay Tree 4 - Kelpwood
		{ NaturalResourcePrefabs.Bay_Tree_5, "Bay Tree 5" },                     // Bay Tree 5 - Kelpwood
		{ NaturalResourcePrefabs.Bay_Tree_6, "Bay Tree 6" },                     // Bay Tree 6 - Kelpwood, Kelpwood
		{ NaturalResourcePrefabs.Cave_Tree_1, "Cave Tree 1" },                   // Cave Tree 1 - Basalt Tree
		{ NaturalResourcePrefabs.Cave_Tree_2, "Cave Tree 2" },                   // Cave Tree 2 - Basalt Tree
		{ NaturalResourcePrefabs.Cave_Tree_3, "Cave Tree 3" },                   // Cave Tree 3 - Basalt Tree
		{ NaturalResourcePrefabs.Cave_Tree_4, "Cave Tree 4" },                   // Cave Tree 4 - Basalt Tree
		{ NaturalResourcePrefabs.Cave_Tree_5, "Cave Tree 5" },                   // Cave Tree 5 - Basalt Tree, Basalt Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_3, "Coral Forest Tree 3" },   // Coral Forest Tree 3 - Crimsonreach Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_4, "Coral Forest Tree 4" },   // Coral Forest Tree 4 - Plateleaf Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_5, "Coral Forest Tree 5" },   // Coral Forest Tree 5 - Plateleaf Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_A1, "Coral Forest Tree A1" }, // Coral Forest Tree A1 - Musselsprout Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_A2, "Coral Forest Tree A2" }, // Coral Forest Tree A2 - Musselsprout Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_A3, "Coral Forest Tree A3" }, // Coral Forest Tree A3 - Musselsprout Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_A4, "Coral Forest Tree A4" }, // Coral Forest Tree A4 - Musselsprout Tree
		{ NaturalResourcePrefabs.Coral_Forest_Tree_A5, "Coral Forest Tree A5" }, // Coral Forest Tree A5 - Musselsprout Tree
		{ NaturalResourcePrefabs.Cursed_Tree_3, "Cursed Tree 3" },               // Cursed Tree 3 - Dying Tree, Abyssal Tree
		{ NaturalResourcePrefabs.Cursed_Tree_6, "Cursed Tree 6" },               // Cursed Tree 6 - Dying Tree, Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_1, "Last Biome Tree 1" },       // Last Biome Tree 1 - Abyssal Tree, Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_2, "Last Biome Tree 2" },       // Last Biome Tree 2 - Abyssal Tree, Abyssal Tree, Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_3, "Last Biome Tree 3" },       // Last Biome Tree 3 - Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_4, "Last Biome Tree 4" },       // Last Biome Tree 4 - Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_5, "Last Biome Tree 5" },       // Last Biome Tree 5 - Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_6, "Last Biome Tree 6" },       // Last Biome Tree 6 - Overgrown Abyssal Tree
		{ NaturalResourcePrefabs.Last_Biome_Tree_7, "Last Biome Tree 7" },       // Last Biome Tree 7 - Overgrown Abyssal Tree
		{ NaturalResourcePrefabs.Marshlands_Tree_01, "Marshlands_Tree_01" },     // Marshlands_Tree_01 - Mushwood, Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_02, "Marshlands_Tree_02" },     // Marshlands_Tree_02 - Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_03, "Marshlands_Tree_03" },     // Marshlands_Tree_03 - Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_04, "Marshlands_Tree_04" },     // Marshlands_Tree_04 - Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_05, "Marshlands_Tree_05" },     // Marshlands_Tree_05 - Mushwood, Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_06, "Marshlands_Tree_06" },     // Marshlands_Tree_06 - Mushwood, Mushwood
		{ NaturalResourcePrefabs.Marshlands_Tree_07, "Marshlands_Tree_07" },     // Marshlands_Tree_07 - Mushwood, Mushwood
		{ NaturalResourcePrefabs.Moorlands_Tree_1, "Moorlands Tree 1" },         // Moorlands Tree 1 - Coppervein Tree
		{ NaturalResourcePrefabs.Moorlands_Tree_2, "Moorlands Tree 2" },         // Moorlands Tree 2 - Coppervein Tree
		{ NaturalResourcePrefabs.Moorlands_Tree_3, "Moorlands Tree 3" },         // Moorlands Tree 3 - Coppervein Tree
		{ NaturalResourcePrefabs.Moorlands_Tree_4, "Moorlands Tree 4" },         // Moorlands Tree 4 - Coppervein Tree
		{ NaturalResourcePrefabs.Moorlands_Tree_5, "Moorlands Tree 5" },         // Moorlands Tree 5 - Coppervein Tree
		{ NaturalResourcePrefabs.Moorlands_Tree_6, "Moorlands Tree 6" },         // Moorlands Tree 6 - Coppervein Tree
		{ NaturalResourcePrefabs.Poro_Biome_Tree_1, "Poro Biome Tree 1" },       // Poro Biome Tree 1 - Tearsap Bamboo, Tearsap Bamboo
		{ NaturalResourcePrefabs.Poro_Biome_Tree_2, "Poro Biome Tree 2" },       // Poro Biome Tree 2 - Tearsap Bamboo, Tearsap Bamboo
		{ NaturalResourcePrefabs.Poro_Biome_Tree_3, "Poro Biome Tree 3" },       // Poro Biome Tree 3 - Tearsap Bamboo, Tearsap Bamboo
		{ NaturalResourcePrefabs.Tree_1, "Tree 1" },                             // Tree 1 - Lush Tree
		{ NaturalResourcePrefabs.Tree_2, "Tree 2" },                             // Tree 2 - Lush Tree
		{ NaturalResourcePrefabs.Tree_3, "Tree 3" },                             // Tree 3 - Lush Tree
		{ NaturalResourcePrefabs.Tree_4, "Tree 4" },                             // Tree 4 - Lush Tree
		{ NaturalResourcePrefabs.Tree_5, "Tree 5" },                             // Tree 5 - Lush Tree
		{ NaturalResourcePrefabs.Tree_6, "Tree 6" },                             // Tree 6 - Lush Tree
		{ NaturalResourcePrefabs.Tree_7, "Tree 7" },                             // Tree 7 - Lush Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_1, "Wasteland Tree 1" },         // Wasteland Tree 1 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_10, "Wasteland Tree 10" },       // Wasteland Tree 10 - Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_11, "Wasteland Tree 11" },       // Wasteland Tree 11 - Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_12, "Wasteland Tree 12" },       // Wasteland Tree 12 - Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_2, "Wasteland Tree 2" },         // Wasteland Tree 2 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_3, "Wasteland Tree 3" },         // Wasteland Tree 3 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_4, "Wasteland Tree 4" },         // Wasteland Tree 4 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_5, "Wasteland Tree 5" },         // Wasteland Tree 5 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_6, "Wasteland Tree 6" },         // Wasteland Tree 6 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_7, "Wasteland Tree 7" },         // Wasteland Tree 7 - Ashen Tree, Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_8, "Wasteland Tree 8" },         // Wasteland Tree 8 - Ashen Tree
		{ NaturalResourcePrefabs.Wasteland_Tree_9, "Wasteland Tree 9" },         // Wasteland Tree 9 - Ashen Tree

	};
}
