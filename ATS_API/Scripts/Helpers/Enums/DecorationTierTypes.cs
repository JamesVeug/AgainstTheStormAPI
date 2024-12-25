using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum DecorationTierTypes
{
    /// <summary>
    /// Placeholder for an unknown DecorationTierTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no DecorationTierTypes. Typically, seen if nothing is defined or failed to parse a string to a DecorationTierTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Aesthetics
	/// </summary>
	/// <name>DecorationTier 2</name>
	Aesthetics = 1,

	/// <summary>
	/// Comfort
	/// </summary>
	/// <name>DecorationTier 1</name>
	Comfort = 2,

	/// <summary>
	/// Harmony
	/// </summary>
	/// <name>DecorationTier 3</name>
	Harmony = 3,



    /// <summary>
    /// The total number of vanilla DecorationTierTypes in the game.
    /// </summary>
	MAX = 3
}

/// <summary>
/// Extension methods for the DecorationTierTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class DecorationTierTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded DecorationTierTypes.
	/// </summary>
	public static DecorationTierTypes[] All()
	{
		DecorationTierTypes[] all = new DecorationTierTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every DecorationTierTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return DecorationTierTypes.Aesthetics in the enum and log an error.
	/// </summary>
	public static string ToName(this DecorationTierTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of DecorationTierTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[DecorationTierTypes.Aesthetics];
	}
	
	/// <summary>
	/// Returns a DecorationTierTypes associated with the given name.
	/// Every DecorationTierTypes should have a unique name as to distinguish it from others.
	/// If no DecorationTierTypes is found, it will return DecorationTierTypes.Unknown and log a warning.
	/// </summary>
	public static DecorationTierTypes ToDecorationTierTypes(this string name)
	{
		foreach (KeyValuePair<DecorationTierTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find DecorationTierTypes with name: " + name + "\n" + Environment.StackTrace);
		return DecorationTierTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a DecorationTier associated with the given name.
	/// DecorationTier contain all the data that will be used in the game.
	/// Every DecorationTier should have a unique name as to distinguish it from others.
	/// If no DecorationTier is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.DecorationTier ToDecorationTier(this string name)
	{
		Eremite.Buildings.DecorationTier model = SO.Settings.decorationsTiers.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find DecorationTier for DecorationTierTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a DecorationTier associated with the given DecorationTierTypes.
    /// DecorationTier contain all the data that will be used in the game.
    /// Every DecorationTier should have a unique name as to distinguish it from others.
    /// If no DecorationTier is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Buildings.DecorationTier ToDecorationTier(this DecorationTierTypes types)
	{
		return types.ToName().ToDecorationTier();
	}
	
	/// <summary>
	/// Returns an array of DecorationTier associated with the given DecorationTierTypes.
	/// DecorationTier contain all the data that will be used in the game.
	/// Every DecorationTier should have a unique name as to distinguish it from others.
	/// If a DecorationTier is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.DecorationTier[] ToDecorationTierArray(this IEnumerable<DecorationTierTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.DecorationTier[] array = new Eremite.Buildings.DecorationTier[count];
		int i = 0;
		foreach (DecorationTierTypes element in collection)
		{
			array[i++] = element.ToDecorationTier();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of DecorationTier associated with the given DecorationTierTypes.
	/// DecorationTier contain all the data that will be used in the game.
	/// Every DecorationTier should have a unique name as to distinguish it from others.
	/// If a DecorationTier is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.DecorationTier[] ToDecorationTierArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.DecorationTier[] array = new Eremite.Buildings.DecorationTier[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToDecorationTier();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of DecorationTier associated with the given DecorationTierTypes.
	/// DecorationTier contain all the data that will be used in the game.
	/// Every DecorationTier should have a unique name as to distinguish it from others.
	/// If a DecorationTier is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.DecorationTier[] ToDecorationTierArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.DecorationTier>.Get(out List<Eremite.Buildings.DecorationTier> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.DecorationTier model = element.ToDecorationTier();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of DecorationTier associated with the given DecorationTierTypes.
	/// DecorationTier contain all the data that will be used in the game.
	/// Every DecorationTier should have a unique name as to distinguish it from others.
	/// If a DecorationTier is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.DecorationTier[] ToDecorationTierArrayNoNulls(this IEnumerable<DecorationTierTypes> collection)
	{
		using(ListPool<Eremite.Buildings.DecorationTier>.Get(out List<Eremite.Buildings.DecorationTier> list))
		{
			foreach (DecorationTierTypes element in collection)
			{
				Eremite.Buildings.DecorationTier model = element.ToDecorationTier();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<DecorationTierTypes, string> TypeToInternalName = new()
	{
		{ DecorationTierTypes.Aesthetics, "DecorationTier 2" }, // Aesthetics
		{ DecorationTierTypes.Comfort, "DecorationTier 1" },    // Comfort
		{ DecorationTierTypes.Harmony, "DecorationTier 3" },    // Harmony

	};
}
