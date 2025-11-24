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
public enum FishingHutRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown FishingHutRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no FishingHutRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a FishingHutRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Algae T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Algae</producedGood>
	Algae_T1 = 1,

	/// <summary></summary>
	/// <name>Algae T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Algae</producedGood>
	Algae_T2 = 2,

	/// <summary></summary>
	/// <name>Fish T1</name>
	/// <tags>Food Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Fish</producedGood>
	Fish_T1 = 3,

	/// <summary></summary>
	/// <name>Fish T2</name>
	/// <tags>Food Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Fish</producedGood>
	Fish_T2 = 4,

	/// <summary></summary>
	/// <name>Scales T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Scales</producedGood>
	Scales_T1 = 5,

	/// <summary></summary>
	/// <name>Scales T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Scales</producedGood>
	Scales_T2 = 6,



	/// <summary>
	/// The total number of vanilla FishingHutRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use FishingHutRecipeTypesExtensions.Count(). FishingHutRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 7
}

/// <summary>
/// Extension methods for the FishingHutRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class FishingHutRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in FishingHutRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded FishingHutRecipeTypes.
	/// </summary>
	public static FishingHutRecipeTypes[] All()
	{
		FishingHutRecipeTypes[] all = new FishingHutRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every FishingHutRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return FishingHutRecipeTypes.Algae_T1 in the enum and log an error.
	/// </summary>
	public static string ToName(this FishingHutRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of FishingHutRecipeTypes: " + type);
		return TypeToInternalName[FishingHutRecipeTypes.Algae_T1];
	}
	
	/// <summary>
	/// Returns a FishingHutRecipeTypes associated with the given name.
	/// Every FishingHutRecipeTypes should have a unique name as to distinguish it from others.
	/// If no FishingHutRecipeTypes is found, it will return FishingHutRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static FishingHutRecipeTypes ToFishingHutRecipeTypes(this string name)
	{
		foreach (KeyValuePair<FishingHutRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find FishingHutRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return FishingHutRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a FishingHutRecipeModel associated with the given name.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If no FishingHutRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel ToFishingHutRecipeModel(this string name)
	{
		Eremite.Buildings.FishingHutRecipeModel model = SO.Settings.fishingHutsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find FishingHutRecipeModel for FishingHutRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a FishingHutRecipeModel associated with the given FishingHutRecipeTypes.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If no FishingHutRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel ToFishingHutRecipeModel(this FishingHutRecipeTypes types)
	{
		return types.ToName().ToFishingHutRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of FishingHutRecipeModel associated with the given FishingHutRecipeTypes.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a FishingHutRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel[] ToFishingHutRecipeModelArray(this IEnumerable<FishingHutRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FishingHutRecipeModel[] array = new Eremite.Buildings.FishingHutRecipeModel[count];
		int i = 0;
		foreach (FishingHutRecipeTypes element in collection)
		{
			array[i++] = element.ToFishingHutRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FishingHutRecipeModel associated with the given FishingHutRecipeTypes.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a FishingHutRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel[] ToFishingHutRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FishingHutRecipeModel[] array = new Eremite.Buildings.FishingHutRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToFishingHutRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FishingHutRecipeModel associated with the given FishingHutRecipeTypes.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a FishingHutRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel[] ToFishingHutRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.FishingHutRecipeModel>.Get(out List<Eremite.Buildings.FishingHutRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.FishingHutRecipeModel model = element.ToFishingHutRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of FishingHutRecipeModel associated with the given FishingHutRecipeTypes.
	/// FishingHutRecipeModel contain all the data that will be used in the game.
	/// Every FishingHutRecipeModel should have a unique name as to distinguish it from others.
	/// If a FishingHutRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FishingHutRecipeModel[] ToFishingHutRecipeModelArrayNoNulls(this IEnumerable<FishingHutRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.FishingHutRecipeModel>.Get(out List<Eremite.Buildings.FishingHutRecipeModel> list))
		{
			foreach (FishingHutRecipeTypes element in collection)
			{
				Eremite.Buildings.FishingHutRecipeModel model = element.ToFishingHutRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<FishingHutRecipeTypes, string> TypeToInternalName = new()
	{
		{ FishingHutRecipeTypes.Algae_T1, "Algae T1" }, 
		{ FishingHutRecipeTypes.Algae_T2, "Algae T2" }, 
		{ FishingHutRecipeTypes.Fish_T1, "Fish T1" }, 
		{ FishingHutRecipeTypes.Fish_T2, "Fish T2" }, 
		{ FishingHutRecipeTypes.Scales_T1, "Scales T1" }, 
		{ FishingHutRecipeTypes.Scales_T2, "Scales T2" }, 

	};
}
