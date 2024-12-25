using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum OreTypes
{
    /// <summary>
    /// Placeholder for an unknown OreTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no OreTypes. Typically, seen if nothing is defined or failed to parse a string to a OreTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Coal Vein - An effective source of fuel.
	/// </summary>
	/// <name>Coal Ore</name>
	Coal_Ore = 1,

	/// <summary>
	/// Copper Vein - A soft and malleable metal, resistant to rain.
	/// </summary>
	/// <name>Copper Ore</name>
	Copper_Ore = 2,

	/// <summary>
	/// Salt Vein - A valuable and highly absorbent mineral.
	/// </summary>
	/// <name>Salt Ore</name>
	Salt_Ore = 3,



    /// <summary>
    /// The total number of vanilla OreTypes in the game.
    /// </summary>
	MAX = 3
}

/// <summary>
/// Extension methods for the OreTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class OreTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded OreTypes.
	/// </summary>
	public static OreTypes[] All()
	{
		OreTypes[] all = new OreTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every OreTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return OreTypes.Coal_Ore in the enum and log an error.
	/// </summary>
	public static string ToName(this OreTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of OreTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[OreTypes.Coal_Ore];
	}
	
	/// <summary>
	/// Returns a OreTypes associated with the given name.
	/// Every OreTypes should have a unique name as to distinguish it from others.
	/// If no OreTypes is found, it will return OreTypes.Unknown and log a warning.
	/// </summary>
	public static OreTypes ToOreTypes(this string name)
	{
		foreach (KeyValuePair<OreTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find OreTypes with name: " + name + "\n" + Environment.StackTrace);
		return OreTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a OreModel associated with the given name.
	/// OreModel contain all the data that will be used in the game.
	/// Every OreModel should have a unique name as to distinguish it from others.
	/// If no OreModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.OreModel ToOreModel(this string name)
	{
		Eremite.Model.OreModel model = SO.Settings.Ore.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find OreModel for OreTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a OreModel associated with the given OreTypes.
    /// OreModel contain all the data that will be used in the game.
    /// Every OreModel should have a unique name as to distinguish it from others.
    /// If no OreModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.OreModel ToOreModel(this OreTypes types)
	{
		return types.ToName().ToOreModel();
	}
	
	/// <summary>
	/// Returns an array of OreModel associated with the given OreTypes.
	/// OreModel contain all the data that will be used in the game.
	/// Every OreModel should have a unique name as to distinguish it from others.
	/// If a OreModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.OreModel[] ToOreModelArray(this IEnumerable<OreTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.OreModel[] array = new Eremite.Model.OreModel[count];
		int i = 0;
		foreach (OreTypes element in collection)
		{
			array[i++] = element.ToOreModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of OreModel associated with the given OreTypes.
	/// OreModel contain all the data that will be used in the game.
	/// Every OreModel should have a unique name as to distinguish it from others.
	/// If a OreModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.OreModel[] ToOreModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.OreModel[] array = new Eremite.Model.OreModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToOreModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of OreModel associated with the given OreTypes.
	/// OreModel contain all the data that will be used in the game.
	/// Every OreModel should have a unique name as to distinguish it from others.
	/// If a OreModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.OreModel[] ToOreModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.OreModel>.Get(out List<Eremite.Model.OreModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.OreModel model = element.ToOreModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of OreModel associated with the given OreTypes.
	/// OreModel contain all the data that will be used in the game.
	/// Every OreModel should have a unique name as to distinguish it from others.
	/// If a OreModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.OreModel[] ToOreModelArrayNoNulls(this IEnumerable<OreTypes> collection)
	{
		using(ListPool<Eremite.Model.OreModel>.Get(out List<Eremite.Model.OreModel> list))
		{
			foreach (OreTypes element in collection)
			{
				Eremite.Model.OreModel model = element.ToOreModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<OreTypes, string> TypeToInternalName = new()
	{
		{ OreTypes.Coal_Ore, "Coal Ore" },     // Coal Vein - An effective source of fuel.
		{ OreTypes.Copper_Ore, "Copper Ore" }, // Copper Vein - A soft and malleable metal, resistant to rain.
		{ OreTypes.Salt_Ore, "Salt Ore" },     // Salt Vein - A valuable and highly absorbent mineral.

	};
}
