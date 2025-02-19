using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum MineTypes
{
	/// <summary>
	/// Placeholder for an unknown MineTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no MineTypes. Typically, seen if nothing is defined or failed to parse a string to a MineTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).
	/// </summary>
	/// <name>Mine</name>
	Mine = 1,



	/// <summary>
	/// The total number of vanilla MineTypes in the game.
	/// </summary>
	[Obsolete("Use MineTypesExtensions.Count(). MineTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 1
}

/// <summary>
/// Extension methods for the MineTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class MineTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in MineTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded MineTypes.
	/// </summary>
	public static MineTypes[] All()
	{
		MineTypes[] all = new MineTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every MineTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return MineTypes.Mine in the enum and log an error.
	/// </summary>
	public static string ToName(this MineTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of MineTypes: " + type);
		return TypeToInternalName[MineTypes.Mine];
	}
	
	/// <summary>
	/// Returns a MineTypes associated with the given name.
	/// Every MineTypes should have a unique name as to distinguish it from others.
	/// If no MineTypes is found, it will return MineTypes.Unknown and log a warning.
	/// </summary>
	public static MineTypes ToMineTypes(this string name)
	{
		foreach (KeyValuePair<MineTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find MineTypes with name: " + name + "\n" + Environment.StackTrace);
		return MineTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a MineModel associated with the given name.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If no MineModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.MineModel ToMineModel(this string name)
	{
		Eremite.Buildings.MineModel model = SO.Settings.mines.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find MineModel for MineTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a MineModel associated with the given MineTypes.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If no MineModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.MineModel ToMineModel(this MineTypes types)
	{
		return types.ToName().ToMineModel();
	}
	
	/// <summary>
	/// Returns an array of MineModel associated with the given MineTypes.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If a MineModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.MineModel[] ToMineModelArray(this IEnumerable<MineTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.MineModel[] array = new Eremite.Buildings.MineModel[count];
		int i = 0;
		foreach (MineTypes element in collection)
		{
			array[i++] = element.ToMineModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MineModel associated with the given MineTypes.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If a MineModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.MineModel[] ToMineModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.MineModel[] array = new Eremite.Buildings.MineModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToMineModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MineModel associated with the given MineTypes.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If a MineModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.MineModel[] ToMineModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.MineModel>.Get(out List<Eremite.Buildings.MineModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.MineModel model = element.ToMineModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of MineModel associated with the given MineTypes.
	/// MineModel contain all the data that will be used in the game.
	/// Every MineModel should have a unique name as to distinguish it from others.
	/// If a MineModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.MineModel[] ToMineModelArrayNoNulls(this IEnumerable<MineTypes> collection)
	{
		using(ListPool<Eremite.Buildings.MineModel>.Get(out List<Eremite.Buildings.MineModel> list))
		{
			foreach (MineTypes element in collection)
			{
				Eremite.Buildings.MineModel model = element.ToMineModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<MineTypes, string> TypeToInternalName = new()
	{
		{ MineTypes.Mine, "Mine" }, // Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).

	};
}
