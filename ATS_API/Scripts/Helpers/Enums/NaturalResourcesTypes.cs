using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.17R
public enum NaturalResourceTypes
{
	Unknown = -1,
	None,
	Bay_Tree_1,               // Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
	Bay_Tree_2,               // Kelpwood - A very flexible, yet extremely hardy plant. It moves in the wind as if moved by sea waves.
	CoralForest_Crimsonreach, // Crimsonreach Tree - A mineralized coral tree.
	CoralForest_Musselsprout, // Musselsprout Tree - The unusually hard bark conceals soft, fleshy tissue.
	CoralForest_Plateleaf,    // Plateleaf Tree - A species of plant rarely seen above water.
	Cursed_Tree,              // Dying Tree - A bare, rotting tree infested with grubs.
	Last_Biome_1,             // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	Last_Biome_2,             // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	Last_Biome_3,             // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	Last_Biome_4,             // Overgrown Abyssal Tree - A giant, bizarre growth... it's bigger than the other trees in the area.
	Moorlands_Tree,           // Coppervein Tree - A scarlet tree covered in enormous thorns.
	Moorlands_Tree_2,         // Coppervein Tree - A scarlet tree covered in enormous thorns.
	Mushroom_Tree_Bugs,       // Mushwood - A giant fungal tree covered in a leathery bark.
	Mushroom_Tree_Classic,    // Mushwood - A giant fungal tree covered in a leathery bark.
	Sealed_Tree,              // Abyssal Tree - A bizarre, writhing growth... is this even really a tree?
	Woodlands_Tree,           // Lush Tree - A perfect source of wood.


	MAX = 16
}

public static class NaturalResourceTypesExtensions
{
	private static NaturalResourceTypes[] s_All = null;
	public static NaturalResourceTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new NaturalResourceTypes[16];
			for (int i = 0; i < 16; i++)
			{
				s_All[i] = (NaturalResourceTypes)(i+1);
			}
		}
		return s_All;
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

		Plugin.Log.LogError($"Cannot find name of NaturalResourceTypes: " + type + "\n" + Environment.StackTrace);
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

		Plugin.Log.LogWarning("Cannot find NaturalResourceTypes with name: " + name + "\n" + Environment.StackTrace);
		return NaturalResourceTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a NaturalResourceModel associated with the given name.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If no NaturalResourceModel is found, it will return null and log an error.
	/// </summary>
	public static NaturalResourceModel ToNaturalResourceModel(this string name)
	{
		NaturalResourceModel model = SO.Settings.NaturalResources.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find NaturalResourceModel for NaturalResourceTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a NaturalResourceModel associated with the given NaturalResourceTypes.
    /// NaturalResourceModel contain all the data that will be used in the game.
    /// Every NaturalResourceModel should have a unique name as to distinguish it from others.
    /// If no NaturalResourceModel is found, it will return null and log an error.
    /// </summary>
	public static NaturalResourceModel ToNaturalResourceModel(this NaturalResourceTypes types)
	{
		return types.ToName().ToNaturalResourceModel();
	}
	
	/// <summary>
	/// Returns an array of NaturalResourceModel associated with the given NaturalResourceTypes.
	/// NaturalResourceModel contain all the data that will be used in the game.
	/// Every NaturalResourceModel should have a unique name as to distinguish it from others.
	/// If a NaturalResourceModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static NaturalResourceModel[] ToNaturalResourceModelArray(this IEnumerable<NaturalResourceTypes> collection)
	{
		int count = collection.Count();
		NaturalResourceModel[] array = new NaturalResourceModel[count];
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
	public static NaturalResourceModel[] ToNaturalResourceModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		NaturalResourceModel[] array = new NaturalResourceModel[count];
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
	public static NaturalResourceModel[] ToNaturalResourceModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<NaturalResourceModel>.Get(out List<NaturalResourceModel> list))
		{
			foreach (string element in collection)
			{
				NaturalResourceModel model = element.ToNaturalResourceModel();
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
	public static NaturalResourceModel[] ToNaturalResourceModelArrayNoNulls(this IEnumerable<NaturalResourceTypes> collection)
	{
		using(ListPool<NaturalResourceModel>.Get(out List<NaturalResourceModel> list))
		{
			foreach (NaturalResourceTypes element in collection)
			{
				NaturalResourceModel model = element.ToNaturalResourceModel();
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
		{ NaturalResourceTypes.Woodlands_Tree, "Woodlands Tree" },                     // Lush Tree - A perfect source of wood.

	};
}
