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
public enum FarmRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown FarmRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no FarmRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a FarmRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Berries Plantation</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries_Plantation = 1,

	/// <summary></summary>
	/// <name>Crystalized Dew Grove</name>
	/// <tags>Metal Tag, Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_Grove = 2,

	/// <summary></summary>
	/// <name>Fibre Plantation</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Fibre_Plantation = 3,

	/// <summary></summary>
	/// <name>Grain Big Farm</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_Big_Farm = 4,

	/// <summary></summary>
	/// <name>Grain Small Farm</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_Small_Farm = 5,

	/// <summary></summary>
	/// <name>Herbs Herb Garden</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_Herb_Garden = 6,

	/// <summary></summary>
	/// <name>Insects Brineworks</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects_Brineworks = 7,

	/// <summary></summary>
	/// <name>More Berries Plantation</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	More_Berries_Plantation = 8,

	/// <summary></summary>
	/// <name>More Crystalized Dew Grove</name>
	/// <tags>Metal Tag, Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	More_Crystalized_Dew_Grove = 9,

	/// <summary></summary>
	/// <name>More Fibre Small Farm</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	More_Fibre_Small_Farm = 10,

	/// <summary></summary>
	/// <name>More Grain Small Farm</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	More_Grain_Small_Farm = 11,

	/// <summary></summary>
	/// <name>More Herbs Herb Garden</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	More_Herbs_Herb_Garden = 12,

	/// <summary></summary>
	/// <name>More Roots Herb Garden</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	More_Roots_Herb_Garden = 13,

	/// <summary></summary>
	/// <name>More Vegetable Small Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	More_Vegetable_Small_Farm = 14,

	/// <summary></summary>
	/// <name>Mushrooms Big Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Big_Farm = 15,

	/// <summary></summary>
	/// <name>Mushrooms Small Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Small_Farm = 16,

	/// <summary></summary>
	/// <name>Mushrooms Small Farm - Altar</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Small_Farm_Altar = 17,

	/// <summary></summary>
	/// <name>Plant Fibre Big Farm</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Plant_Fibre_Big_Farm = 18,

	/// <summary></summary>
	/// <name>Resin Grove</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Resin</producedGood>
	Resin_Grove = 19,

	/// <summary></summary>
	/// <name>Roots Herb Garden</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Herb_Garden = 20,

	/// <summary></summary>
	/// <name>Roots Small Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Small_Farm = 21,

	/// <summary></summary>
	/// <name>Salt Brineworks</name>
	/// <tags>Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Salt</producedGood>
	Salt_Brineworks = 22,

	/// <summary></summary>
	/// <name>Vegetable Big Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetable_Big_Farm = 23,

	/// <summary></summary>
	/// <name>Vegetable Small Farm</name>
	/// <tags>Food Tag, Farm Recipe Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetable_Small_Farm = 24,



	/// <summary>
	/// The total number of vanilla FarmRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use FarmRecipeTypesExtensions.Count(). FarmRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 25
}

/// <summary>
/// Extension methods for the FarmRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class FarmRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in FarmRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded FarmRecipeTypes.
	/// </summary>
	public static FarmRecipeTypes[] All()
	{
		FarmRecipeTypes[] all = new FarmRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every FarmRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return FarmRecipeTypes.Berries_Plantation in the enum and log an error.
	/// </summary>
	public static string ToName(this FarmRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of FarmRecipeTypes: " + type);
		return TypeToInternalName[FarmRecipeTypes.Berries_Plantation];
	}
	
	/// <summary>
	/// Returns a FarmRecipeTypes associated with the given name.
	/// Every FarmRecipeTypes should have a unique name as to distinguish it from others.
	/// If no FarmRecipeTypes is found, it will return FarmRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static FarmRecipeTypes ToFarmRecipeTypes(this string name)
	{
		foreach (KeyValuePair<FarmRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find FarmRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return FarmRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a FarmRecipeModel associated with the given name.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If no FarmRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel ToFarmRecipeModel(this string name)
	{
		Eremite.Buildings.FarmRecipeModel model = SO.Settings.farmsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find FarmRecipeModel for FarmRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a FarmRecipeModel associated with the given FarmRecipeTypes.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If no FarmRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel ToFarmRecipeModel(this FarmRecipeTypes types)
	{
		return types.ToName().ToFarmRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of FarmRecipeModel associated with the given FarmRecipeTypes.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If a FarmRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel[] ToFarmRecipeModelArray(this IEnumerable<FarmRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FarmRecipeModel[] array = new Eremite.Buildings.FarmRecipeModel[count];
		int i = 0;
		foreach (FarmRecipeTypes element in collection)
		{
			array[i++] = element.ToFarmRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FarmRecipeModel associated with the given FarmRecipeTypes.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If a FarmRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel[] ToFarmRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FarmRecipeModel[] array = new Eremite.Buildings.FarmRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToFarmRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FarmRecipeModel associated with the given FarmRecipeTypes.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If a FarmRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel[] ToFarmRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.FarmRecipeModel>.Get(out List<Eremite.Buildings.FarmRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.FarmRecipeModel model = element.ToFarmRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of FarmRecipeModel associated with the given FarmRecipeTypes.
	/// FarmRecipeModel contain all the data that will be used in the game.
	/// Every FarmRecipeModel should have a unique name as to distinguish it from others.
	/// If a FarmRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FarmRecipeModel[] ToFarmRecipeModelArrayNoNulls(this IEnumerable<FarmRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.FarmRecipeModel>.Get(out List<Eremite.Buildings.FarmRecipeModel> list))
		{
			foreach (FarmRecipeTypes element in collection)
			{
				Eremite.Buildings.FarmRecipeModel model = element.ToFarmRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<FarmRecipeTypes, string> TypeToInternalName = new()
	{
		{ FarmRecipeTypes.Berries_Plantation, "Berries Plantation" }, 
		{ FarmRecipeTypes.Crystalized_Dew_Grove, "Crystalized Dew Grove" }, 
		{ FarmRecipeTypes.Fibre_Plantation, "Fibre Plantation" }, 
		{ FarmRecipeTypes.Grain_Big_Farm, "Grain Big Farm" }, 
		{ FarmRecipeTypes.Grain_Small_Farm, "Grain Small Farm" }, 
		{ FarmRecipeTypes.Herbs_Herb_Garden, "Herbs Herb Garden" }, 
		{ FarmRecipeTypes.Insects_Brineworks, "Insects Brineworks" }, 
		{ FarmRecipeTypes.More_Berries_Plantation, "More Berries Plantation" }, 
		{ FarmRecipeTypes.More_Crystalized_Dew_Grove, "More Crystalized Dew Grove" }, 
		{ FarmRecipeTypes.More_Fibre_Small_Farm, "More Fibre Small Farm" }, 
		{ FarmRecipeTypes.More_Grain_Small_Farm, "More Grain Small Farm" }, 
		{ FarmRecipeTypes.More_Herbs_Herb_Garden, "More Herbs Herb Garden" }, 
		{ FarmRecipeTypes.More_Roots_Herb_Garden, "More Roots Herb Garden" }, 
		{ FarmRecipeTypes.More_Vegetable_Small_Farm, "More Vegetable Small Farm" }, 
		{ FarmRecipeTypes.Mushrooms_Big_Farm, "Mushrooms Big Farm" }, 
		{ FarmRecipeTypes.Mushrooms_Small_Farm, "Mushrooms Small Farm" }, 
		{ FarmRecipeTypes.Mushrooms_Small_Farm_Altar, "Mushrooms Small Farm - Altar" }, 
		{ FarmRecipeTypes.Plant_Fibre_Big_Farm, "Plant Fibre Big Farm" }, 
		{ FarmRecipeTypes.Resin_Grove, "Resin Grove" }, 
		{ FarmRecipeTypes.Roots_Herb_Garden, "Roots Herb Garden" }, 
		{ FarmRecipeTypes.Roots_Small_Farm, "Roots Small Farm" }, 
		{ FarmRecipeTypes.Salt_Brineworks, "Salt Brineworks" }, 
		{ FarmRecipeTypes.Vegetable_Big_Farm, "Vegetable Big Farm" }, 
		{ FarmRecipeTypes.Vegetable_Small_Farm, "Vegetable Small Farm" }, 

	};
}
