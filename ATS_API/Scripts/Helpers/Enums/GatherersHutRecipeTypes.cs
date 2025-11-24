using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.9.3R
/// </summary>
public enum GatherersHutRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown GatherersHutRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no GatherersHutRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a GatherersHutRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Berries</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries = 1,

	/// <summary></summary>
	/// <name>Berries T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries_T0 = 2,

	/// <summary></summary>
	/// <name>Clay</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay = 3,

	/// <summary></summary>
	/// <name>Eggs</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Eggs = 4,

	/// <summary></summary>
	/// <name>Eggs T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Eggs_T0 = 5,

	/// <summary></summary>
	/// <name>Grain</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain = 6,

	/// <summary></summary>
	/// <name>Grain T0</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_T0 = 7,

	/// <summary></summary>
	/// <name>Herbs</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs = 8,

	/// <summary></summary>
	/// <name>Herbs T0</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_T0 = 9,

	/// <summary></summary>
	/// <name>Insects</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects = 10,

	/// <summary></summary>
	/// <name>Insects T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects_T0 = 11,

	/// <summary></summary>
	/// <name>Leather</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather = 12,

	/// <summary></summary>
	/// <name>Meat</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat = 13,

	/// <summary></summary>
	/// <name>Meat T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_T0 = 14,

	/// <summary></summary>
	/// <name>Mushrooms</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms = 15,

	/// <summary></summary>
	/// <name>Mushrooms T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_T0 = 16,

	/// <summary></summary>
	/// <name>Plant Fibre</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Plant_Fibre = 17,

	/// <summary></summary>
	/// <name>Reeds</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Reeds = 18,

	/// <summary></summary>
	/// <name>Roots</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots = 19,

	/// <summary></summary>
	/// <name>Roots T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_T0 = 20,

	/// <summary></summary>
	/// <name>Sea Marrow</name>
	/// <tags>Gathering Tag, Fuel Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Sea Marrow</producedGood>
	Sea_Marrow = 21,

	/// <summary></summary>
	/// <name>Stone</name>
	/// <tags>Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Stone = 22,

	/// <summary></summary>
	/// <name>Vegetables</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetables = 23,

	/// <summary></summary>
	/// <name>Vegetables T0</name>
	/// <tags>Food Tag, Gathering Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetables_T0 = 24,



	/// <summary>
	/// The total number of vanilla GatherersHutRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use GatherersHutRecipeTypesExtensions.Count(). GatherersHutRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 25
}

/// <summary>
/// Extension methods for the GatherersHutRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class GatherersHutRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in GatherersHutRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded GatherersHutRecipeTypes.
	/// </summary>
	public static GatherersHutRecipeTypes[] All()
	{
		GatherersHutRecipeTypes[] all = new GatherersHutRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every GatherersHutRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return GatherersHutRecipeTypes.Berries in the enum and log an error.
	/// </summary>
	public static string ToName(this GatherersHutRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of GatherersHutRecipeTypes: " + type);
		return TypeToInternalName[GatherersHutRecipeTypes.Berries];
	}
	
	/// <summary>
	/// Returns a GatherersHutRecipeTypes associated with the given name.
	/// Every GatherersHutRecipeTypes should have a unique name as to distinguish it from others.
	/// If no GatherersHutRecipeTypes is found, it will return GatherersHutRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static GatherersHutRecipeTypes ToGatherersHutRecipeTypes(this string name)
	{
		foreach (KeyValuePair<GatherersHutRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find GatherersHutRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return GatherersHutRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a GathererHutRecipeModel associated with the given name.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If no GathererHutRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel ToGathererHutRecipeModel(this string name)
	{
		Eremite.Buildings.GathererHutRecipeModel model = SO.Settings.gatherersHutsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find GathererHutRecipeModel for GatherersHutRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a GathererHutRecipeModel associated with the given GatherersHutRecipeTypes.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If no GathererHutRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel ToGathererHutRecipeModel(this GatherersHutRecipeTypes types)
	{
		return types.ToName().ToGathererHutRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of GathererHutRecipeModel associated with the given GatherersHutRecipeTypes.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a GathererHutRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel[] ToGathererHutRecipeModelArray(this IEnumerable<GatherersHutRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.GathererHutRecipeModel[] array = new Eremite.Buildings.GathererHutRecipeModel[count];
		int i = 0;
		foreach (GatherersHutRecipeTypes element in collection)
		{
			array[i++] = element.ToGathererHutRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GathererHutRecipeModel associated with the given GatherersHutRecipeTypes.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a GathererHutRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel[] ToGathererHutRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.GathererHutRecipeModel[] array = new Eremite.Buildings.GathererHutRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGathererHutRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GathererHutRecipeModel associated with the given GatherersHutRecipeTypes.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a GathererHutRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel[] ToGathererHutRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.GathererHutRecipeModel>.Get(out List<Eremite.Buildings.GathererHutRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.GathererHutRecipeModel model = element.ToGathererHutRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of GathererHutRecipeModel associated with the given GatherersHutRecipeTypes.
	/// GathererHutRecipeModel contain all the data that will be used in the game.
	/// Every GathererHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a GathererHutRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.GathererHutRecipeModel[] ToGathererHutRecipeModelArrayNoNulls(this IEnumerable<GatherersHutRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.GathererHutRecipeModel>.Get(out List<Eremite.Buildings.GathererHutRecipeModel> list))
		{
			foreach (GatherersHutRecipeTypes element in collection)
			{
				Eremite.Buildings.GathererHutRecipeModel model = element.ToGathererHutRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<GatherersHutRecipeTypes, string> TypeToInternalName = new()
	{
		{ GatherersHutRecipeTypes.Berries, "Berries" }, 
		{ GatherersHutRecipeTypes.Berries_T0, "Berries T0" }, 
		{ GatherersHutRecipeTypes.Clay, "Clay" }, 
		{ GatherersHutRecipeTypes.Eggs, "Eggs" }, 
		{ GatherersHutRecipeTypes.Eggs_T0, "Eggs T0" }, 
		{ GatherersHutRecipeTypes.Grain, "Grain" }, 
		{ GatherersHutRecipeTypes.Grain_T0, "Grain T0" }, 
		{ GatherersHutRecipeTypes.Herbs, "Herbs" }, 
		{ GatherersHutRecipeTypes.Herbs_T0, "Herbs T0" }, 
		{ GatherersHutRecipeTypes.Insects, "Insects" }, 
		{ GatherersHutRecipeTypes.Insects_T0, "Insects T0" }, 
		{ GatherersHutRecipeTypes.Leather, "Leather" }, 
		{ GatherersHutRecipeTypes.Meat, "Meat" }, 
		{ GatherersHutRecipeTypes.Meat_T0, "Meat T0" }, 
		{ GatherersHutRecipeTypes.Mushrooms, "Mushrooms" }, 
		{ GatherersHutRecipeTypes.Mushrooms_T0, "Mushrooms T0" }, 
		{ GatherersHutRecipeTypes.Plant_Fibre, "Plant Fibre" }, 
		{ GatherersHutRecipeTypes.Reeds, "Reeds" }, 
		{ GatherersHutRecipeTypes.Roots, "Roots" }, 
		{ GatherersHutRecipeTypes.Roots_T0, "Roots T0" }, 
		{ GatherersHutRecipeTypes.Sea_Marrow, "Sea Marrow" }, 
		{ GatherersHutRecipeTypes.Stone, "Stone" }, 
		{ GatherersHutRecipeTypes.Vegetables, "Vegetables" }, 
		{ GatherersHutRecipeTypes.Vegetables_T0, "Vegetables T0" }, 

	};
}
