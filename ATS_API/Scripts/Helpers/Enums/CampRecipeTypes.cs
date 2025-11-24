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
public enum CampRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown CampRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no CampRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a CampRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Wood</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Wood</producedGood>
	Wood = 1,



	/// <summary>
	/// The total number of vanilla CampRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use CampRecipeTypesExtensions.Count(). CampRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 2
}

/// <summary>
/// Extension methods for the CampRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class CampRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in CampRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded CampRecipeTypes.
	/// </summary>
	public static CampRecipeTypes[] All()
	{
		CampRecipeTypes[] all = new CampRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every CampRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return CampRecipeTypes.Wood in the enum and log an error.
	/// </summary>
	public static string ToName(this CampRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of CampRecipeTypes: " + type);
		return TypeToInternalName[CampRecipeTypes.Wood];
	}
	
	/// <summary>
	/// Returns a CampRecipeTypes associated with the given name.
	/// Every CampRecipeTypes should have a unique name as to distinguish it from others.
	/// If no CampRecipeTypes is found, it will return CampRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static CampRecipeTypes ToCampRecipeTypes(this string name)
	{
		foreach (KeyValuePair<CampRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find CampRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return CampRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a CampRecipeModel associated with the given name.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If no CampRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel ToCampRecipeModel(this string name)
	{
		Eremite.Buildings.CampRecipeModel model = SO.Settings.campsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find CampRecipeModel for CampRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a CampRecipeModel associated with the given CampRecipeTypes.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If no CampRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel ToCampRecipeModel(this CampRecipeTypes types)
	{
		return types.ToName().ToCampRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of CampRecipeModel associated with the given CampRecipeTypes.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If a CampRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel[] ToCampRecipeModelArray(this IEnumerable<CampRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CampRecipeModel[] array = new Eremite.Buildings.CampRecipeModel[count];
		int i = 0;
		foreach (CampRecipeTypes element in collection)
		{
			array[i++] = element.ToCampRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CampRecipeModel associated with the given CampRecipeTypes.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If a CampRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel[] ToCampRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CampRecipeModel[] array = new Eremite.Buildings.CampRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToCampRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CampRecipeModel associated with the given CampRecipeTypes.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If a CampRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel[] ToCampRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.CampRecipeModel>.Get(out List<Eremite.Buildings.CampRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.CampRecipeModel model = element.ToCampRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of CampRecipeModel associated with the given CampRecipeTypes.
	/// CampRecipeModel contain all the data that will be used in the game.
	/// Every CampRecipeModel should have a unique name as to distinguish it from others.
	/// If a CampRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CampRecipeModel[] ToCampRecipeModelArrayNoNulls(this IEnumerable<CampRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.CampRecipeModel>.Get(out List<Eremite.Buildings.CampRecipeModel> list))
		{
			foreach (CampRecipeTypes element in collection)
			{
				Eremite.Buildings.CampRecipeModel model = element.ToCampRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<CampRecipeTypes, string> TypeToInternalName = new()
	{
		{ CampRecipeTypes.Wood, "Wood" }, 

	};
}
