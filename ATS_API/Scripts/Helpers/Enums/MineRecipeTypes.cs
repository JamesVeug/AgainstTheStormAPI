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
public enum MineRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown MineRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no MineRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a MineRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Coal</name>
	/// <tags>Fuel Tag, Ore Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal = 1,

	/// <summary></summary>
	/// <name>Copper</name>
	/// <tags>Metal Tag, Ore Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Copper Ore</producedGood>
	Copper = 2,

	/// <summary></summary>
	/// <name>Salt</name>
	/// <tags>Ore Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Salt</producedGood>
	Salt = 3,



	/// <summary>
	/// The total number of vanilla MineRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use MineRecipeTypesExtensions.Count(). MineRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 4
}

/// <summary>
/// Extension methods for the MineRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class MineRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in MineRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded MineRecipeTypes.
	/// </summary>
	public static MineRecipeTypes[] All()
	{
		MineRecipeTypes[] all = new MineRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every MineRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return MineRecipeTypes.Coal in the enum and log an error.
	/// </summary>
	public static string ToName(this MineRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of MineRecipeTypes: " + type);
		return TypeToInternalName[MineRecipeTypes.Coal];
	}
	
	/// <summary>
	/// Returns a MineRecipeTypes associated with the given name.
	/// Every MineRecipeTypes should have a unique name as to distinguish it from others.
	/// If no MineRecipeTypes is found, it will return MineRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static MineRecipeTypes ToMineRecipeTypes(this string name)
	{
		foreach (KeyValuePair<MineRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find MineRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return MineRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a MineRecipeModel associated with the given name.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If no MineRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel ToMineRecipeModel(this string name)
	{
		Eremite.Buildings.MineRecipeModel model = SO.Settings.minesRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find MineRecipeModel for MineRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a MineRecipeModel associated with the given MineRecipeTypes.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If no MineRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel ToMineRecipeModel(this MineRecipeTypes types)
	{
		return types.ToName().ToMineRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of MineRecipeModel associated with the given MineRecipeTypes.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If a MineRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel[] ToMineRecipeModelArray(this IEnumerable<MineRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.MineRecipeModel[] array = new Eremite.Buildings.MineRecipeModel[count];
		int i = 0;
		foreach (MineRecipeTypes element in collection)
		{
			array[i++] = element.ToMineRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MineRecipeModel associated with the given MineRecipeTypes.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If a MineRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel[] ToMineRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.MineRecipeModel[] array = new Eremite.Buildings.MineRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToMineRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MineRecipeModel associated with the given MineRecipeTypes.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If a MineRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel[] ToMineRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.MineRecipeModel>.Get(out List<Eremite.Buildings.MineRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.MineRecipeModel model = element.ToMineRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of MineRecipeModel associated with the given MineRecipeTypes.
	/// MineRecipeModel contain all the data that will be used in the game.
	/// Every MineRecipeModel should have a unique name as to distinguish it from others.
	/// If a MineRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.MineRecipeModel[] ToMineRecipeModelArrayNoNulls(this IEnumerable<MineRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.MineRecipeModel>.Get(out List<Eremite.Buildings.MineRecipeModel> list))
		{
			foreach (MineRecipeTypes element in collection)
			{
				Eremite.Buildings.MineRecipeModel model = element.ToMineRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<MineRecipeTypes, string> TypeToInternalName = new()
	{
		{ MineRecipeTypes.Coal, "Coal" }, 
		{ MineRecipeTypes.Copper, "Copper" }, 
		{ MineRecipeTypes.Salt, "Salt" }, 

	};
}
