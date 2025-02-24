using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum NaturalResourceTypes
{
	/// <summary>
	/// Placeholder for an unknown NaturalResourceTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no NaturalResourceTypes. Typically, seen if nothing is defined or failed to parse a string to a NaturalResourceTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
	/// </summary>
	/// <name>Bay Tree 1</name>
	Bay_Tree_1 = 1,

	/// <summary>
	/// Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
	/// </summary>
	/// <name>Bay Tree 2</name>
	Bay_Tree_2 = 2,

	/// <summary>
	/// Crimsonreach Tree - A mineralized coral tree.
	/// </summary>
	/// <name>CoralForest_Crimsonreach</name>
	CoralForest_Crimsonreach = 3,

	/// <summary>
	/// Musselsprout Tree - The unusually hard bark conceals soft, fleshy tissue.
	/// </summary>
	/// <name>CoralForest_Musselsprout</name>
	CoralForest_Musselsprout = 4,

	/// <summary>
	/// Plateleaf Tree - A species of plant rarely seen above water.
	/// </summary>
	/// <name>CoralForest_Plateleaf</name>
	CoralForest_Plateleaf = 5,

	/// <summary>
	/// Dying Tree - A bare, rotting tree infested with grubs.
	/// </summary>
	/// <name>Cursed Tree</name>
	Cursed_Tree = 6,

	/// <summary>
	/// Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	/// </summary>
	/// <name>Last Biome 1</name>
	Last_Biome_1 = 7,

	/// <summary>
	/// Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	/// </summary>
	/// <name>Last Biome 2</name>
	Last_Biome_2 = 8,

	/// <summary>
	/// Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	/// </summary>
	/// <name>Last Biome 3</name>
	Last_Biome_3 = 9,

	/// <summary>
	/// Overgrown Abyssal Tree - A giant, bizarre growth... it's bigger than the other trees in the area.
	/// </summary>
	/// <name>Last Biome 4</name>
	Last_Biome_4 = 10,

	/// <summary>
	/// Coppervein Tree - A scarlet tree covered in enormous thorns.
	/// </summary>
	/// <name>Moorlands Tree</name>
	Moorlands_Tree = 11,

	/// <summary>
	/// Coppervein Tree - A scarlet tree covered in enormous thorns.
	/// </summary>
	/// <name>Moorlands Tree 2</name>
	Moorlands_Tree_2 = 12,

	/// <summary>
	/// Mushwood - A giant fungal tree covered in a leathery bark.
	/// </summary>
	/// <name>Mushroom Tree Bugs</name>
	Mushroom_Tree_Bugs = 13,

	/// <summary>
	/// Mushwood - A giant fungal tree covered in a leathery bark.
	/// </summary>
	/// <name>Mushroom Tree Classic</name>
	Mushroom_Tree_Classic = 14,

	/// <summary>
	/// Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	/// </summary>
	/// <name>Sealed Tree</name>
	Sealed_Tree = 15,

	/// <summary>
	/// Ashen Tree - A diminished remnant of the legendary giant spruce that once inhabited this region.
	/// </summary>
	/// <name>Wasteland Tree 1</name>
	Wasteland_Tree_1 = 16,

	/// <summary>
	/// Ashen Tree - A diminished remnant of the legendary giant spruce that once inhabited this region.
	/// </summary>
	/// <name>Wasteland Tree 2</name>
	Wasteland_Tree_2 = 17,

	/// <summary>
	/// Lush Tree - A perfect source of wood.
	/// </summary>
	/// <name>Woodlands Tree</name>
	Woodlands_Tree = 18,



	/// <summary>
	/// The total number of vanilla NaturalResourceTypes in the game.
	/// </summary>
	[Obsolete("Use NaturalResourceTypesExtensions.Count(). NaturalResourceTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 18
}

/// <summary>
/// Extension methods for the NaturalResourceTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class NaturalResourceTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in NaturalResourceTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded NaturalResourceTypes.
	/// </summary>
	public static NaturalResourceTypes[] All()
	{
		NaturalResourceTypes[] all = new NaturalResourceTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every NaturalResourceTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return NaturalResourceTypes.Bay_Tree_1 in the enum and log an error.
	/// </summary>
	public static string ToName(this NaturalResourceTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of NaturalResourceTypes: " + type);
		return TypeToInternalName[NaturalResourceTypes.Bay_Tree_1];
	}
	
	/// <summary>
	/// Returns a NaturalResourceTypes associated with the given name.
	/// Every NaturalResourceTypes should have a unique name as to distinguish it from others.
	/// If no NaturalResourceTypes is found, it will return NaturalResourceTypes.Unknown and log a warning.
	/// </summary>
	public static NaturalResourceTypes ToNaturalResourceTypes(this string name)
	{
		foreach (KeyValuePair<NaturalResourceTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find NaturalResourceTypes with name: " + name + "\n" + Environment.StackTrace);
		return NaturalResourceTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a NaturalResourceModel associated with the given name.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If no NaturalResourceModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel ToNaturalResourceModel(this string name)
	{
		Eremite.Model.NaturalResourceModel model = SO.Settings.NaturalResources.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find NaturalResourceModel for NaturalResourceTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If no NaturalResourceModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel ToNaturalResourceModel(this NaturalResourceTypes types)
	{
		return types.ToName().ToNaturalResourceModel();
	}
	
	/// <summary>
	/// Returns an array of NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If a NaturalResourceModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel[] ToNaturalResourceModelArray(this IEnumerable<NaturalResourceTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.NaturalResourceModel[] array = new Eremite.Model.NaturalResourceModel[count];
		int i = 0;
		foreach (NaturalResourceTypes element in collection)
		{
			array[i++] = element.ToNaturalResourceModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If a NaturalResourceModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel[] ToNaturalResourceModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.NaturalResourceModel[] array = new Eremite.Model.NaturalResourceModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToNaturalResourceModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If a NaturalResourceModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel[] ToNaturalResourceModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.NaturalResourceModel>.Get(out List<Eremite.Model.NaturalResourceModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.NaturalResourceModel model = element.ToNaturalResourceModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If a NaturalResourceModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.NaturalResourceModel[] ToNaturalResourceModelArrayNoNulls(this IEnumerable<NaturalResourceTypes> collection)
	{
		using(ListPool<Eremite.Model.NaturalResourceModel>.Get(out List<Eremite.Model.NaturalResourceModel> list))
		{
			foreach (NaturalResourceTypes element in collection)
			{
				Eremite.Model.NaturalResourceModel model = element.ToNaturalResourceModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<NaturalResourceTypes, string> TypeToInternalName = new()
	{
		{ NaturalResourceTypes.Bay_Tree_1, "Bay Tree 1" },                             // Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
		{ NaturalResourceTypes.Bay_Tree_2, "Bay Tree 2" },                             // Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
		{ NaturalResourceTypes.CoralForest_Crimsonreach, "CoralForest_Crimsonreach" }, // Crimsonreach Tree - A mineralized coral tree.
		{ NaturalResourceTypes.CoralForest_Musselsprout, "CoralForest_Musselsprout" }, // Musselsprout Tree - The unusually hard bark conceals soft, fleshy tissue.
		{ NaturalResourceTypes.CoralForest_Plateleaf, "CoralForest_Plateleaf" },       // Plateleaf Tree - A species of plant rarely seen above water.
		{ NaturalResourceTypes.Cursed_Tree, "Cursed Tree" },                           // Dying Tree - A bare, rotting tree infested with grubs.
		{ NaturalResourceTypes.Last_Biome_1, "Last Biome 1" },                         // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
		{ NaturalResourceTypes.Last_Biome_2, "Last Biome 2" },                         // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
		{ NaturalResourceTypes.Last_Biome_3, "Last Biome 3" },                         // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
		{ NaturalResourceTypes.Last_Biome_4, "Last Biome 4" },                         // Overgrown Abyssal Tree - A giant, bizarre growth... it's bigger than the other trees in the area.
		{ NaturalResourceTypes.Moorlands_Tree, "Moorlands Tree" },                     // Coppervein Tree - A scarlet tree covered in enormous thorns.
		{ NaturalResourceTypes.Moorlands_Tree_2, "Moorlands Tree 2" },                 // Coppervein Tree - A scarlet tree covered in enormous thorns.
		{ NaturalResourceTypes.Mushroom_Tree_Bugs, "Mushroom Tree Bugs" },             // Mushwood - A giant fungal tree covered in a leathery bark.
		{ NaturalResourceTypes.Mushroom_Tree_Classic, "Mushroom Tree Classic" },       // Mushwood - A giant fungal tree covered in a leathery bark.
		{ NaturalResourceTypes.Sealed_Tree, "Sealed Tree" },                           // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
		{ NaturalResourceTypes.Wasteland_Tree_1, "Wasteland Tree 1" },                 // Ashen Tree - A diminished remnant of the legendary giant spruce that once inhabited this region.
		{ NaturalResourceTypes.Wasteland_Tree_2, "Wasteland Tree 2" },                 // Ashen Tree - A diminished remnant of the legendary giant spruce that once inhabited this region.
		{ NaturalResourceTypes.Woodlands_Tree, "Woodlands Tree" },                     // Lush Tree - A perfect source of wood.

	};
}
