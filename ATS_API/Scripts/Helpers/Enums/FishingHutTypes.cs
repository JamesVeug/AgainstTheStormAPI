using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum FishingHutTypes
{
	/// <summary>
	/// Placeholder for an unknown FishingHutTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no FishingHutTypes. Typically, seen if nothing is defined or failed to parse a string to a FishingHutTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
	/// </summary>
	/// <name>Fishing Hut</name>
	Fishing_Hut = 1,

	/// <summary>
	/// Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).
	/// </summary>
	/// <name>Primitive Fishing Hut</name>
	Primitive_Fishing_Hut = 2,



	/// <summary>
	/// The total number of vanilla FishingHutTypes in the game.
	/// </summary>
	[Obsolete("Use FishingHutTypesExtensions.Count(). FishingHutTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 2
}

/// <summary>
/// Extension methods for the FishingHutTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class FishingHutTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in FishingHutTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded FishingHutTypes.
	/// </summary>
	public static FishingHutTypes[] All()
	{
		FishingHutTypes[] all = new FishingHutTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every FishingHutTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return FishingHutTypes.Fishing_Hut in the enum and log an error.
	/// </summary>
	public static string ToName(this FishingHutTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of FishingHutTypes: " + type);
		return TypeToInternalName[FishingHutTypes.Fishing_Hut];
	}
	
	/// <summary>
	/// Returns a FishingHutTypes associated with the given name.
	/// Every FishingHutTypes should have a unique name as to distinguish it from others.
	/// If no FishingHutTypes is found, it will return FishingHutTypes.Unknown and log a warning.
	/// </summary>
	public static FishingHutTypes ToFishingHutTypes(this string name)
	{
		foreach (KeyValuePair<FishingHutTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find FishingHutTypes with name: " + name + "\n" + Environment.StackTrace);
		return FishingHutTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a FishingHutModel associated with the given name.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If no FishingHutModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel ToFishingHutModel(this string name)
	{
		Eremite.Buildings.FishingHutModel model = SO.Settings.Buildings.Where(a=>a is FishingHutModel).Cast<FishingHutModel>().FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find FishingHutModel for FishingHutTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a FishingHutModel associated with the given FishingHutTypes.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If no FishingHutModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel ToFishingHutModel(this FishingHutTypes types)
	{
		return types.ToName().ToFishingHutModel();
	}
	
	/// <summary>
	/// Returns an array of FishingHutModel associated with the given FishingHutTypes.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If a FishingHutModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel[] ToFishingHutModelArray(this IEnumerable<FishingHutTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FishingHutModel[] array = new Eremite.Buildings.FishingHutModel[count];
		int i = 0;
		foreach (FishingHutTypes element in collection)
		{
			array[i++] = element.ToFishingHutModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FishingHutModel associated with the given FishingHutTypes.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If a FishingHutModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel[] ToFishingHutModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.FishingHutModel[] array = new Eremite.Buildings.FishingHutModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToFishingHutModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of FishingHutModel associated with the given FishingHutTypes.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If a FishingHutModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel[] ToFishingHutModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.FishingHutModel>.Get(out List<Eremite.Buildings.FishingHutModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.FishingHutModel model = element.ToFishingHutModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of FishingHutModel associated with the given FishingHutTypes.
	/// FishingHutModel contain all the data that will be used in the game.
	/// Every FishingHutModel should have a unique name as to distinguish it from others.
	/// If a FishingHutModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.FishingHutModel[] ToFishingHutModelArrayNoNulls(this IEnumerable<FishingHutTypes> collection)
	{
		using(ListPool<Eremite.Buildings.FishingHutModel>.Get(out List<Eremite.Buildings.FishingHutModel> list))
		{
			foreach (FishingHutTypes element in collection)
			{
				Eremite.Buildings.FishingHutModel model = element.ToFishingHutModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<FishingHutTypes, string> TypeToInternalName = new()
	{
		{ FishingHutTypes.Fishing_Hut, "Fishing Hut" },                     // Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
		{ FishingHutTypes.Primitive_Fishing_Hut, "Primitive Fishing Hut" }, // Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).

	};
}
