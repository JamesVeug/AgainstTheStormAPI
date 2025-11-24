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
public enum RainCatcherRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown RainCatcherRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no RainCatcherRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a RainCatcherRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Clearance Rain Catcher (T0)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Water] Clearance Water</producedGood>
	Clearance_Rain_Catcher_T0 = 1,

	/// <summary></summary>
	/// <name>Clearance Rain Catcher (T1)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Water] Clearance Water</producedGood>
	Clearance_Rain_Catcher_T1 = 2,

	/// <summary></summary>
	/// <name>Drizzle Rain Catcher (T0)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Water] Drizzle Water</producedGood>
	Drizzle_Rain_Catcher_T0 = 3,

	/// <summary></summary>
	/// <name>Drizzle Rain Catcher (T1)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Water] Drizzle Water</producedGood>
	Drizzle_Rain_Catcher_T1 = 4,

	/// <summary></summary>
	/// <name>Storm Rain Catcher (T0)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Water] Storm Water</producedGood>
	Storm_Rain_Catcher_T0 = 5,

	/// <summary></summary>
	/// <name>Storm Rain Catcher (T1)</name>
	/// <tags>[Tag] Rainpunk, Recipe With Water Tag</tags>
	/// <grade>2</grade>
	/// <producedGood>[Water] Storm Water</producedGood>
	Storm_Rain_Catcher_T1 = 6,



	/// <summary>
	/// The total number of vanilla RainCatcherRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use RainCatcherRecipeTypesExtensions.Count(). RainCatcherRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 7
}

/// <summary>
/// Extension methods for the RainCatcherRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class RainCatcherRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in RainCatcherRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded RainCatcherRecipeTypes.
	/// </summary>
	public static RainCatcherRecipeTypes[] All()
	{
		RainCatcherRecipeTypes[] all = new RainCatcherRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every RainCatcherRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return RainCatcherRecipeTypes.Clearance_Rain_Catcher_T0 in the enum and log an error.
	/// </summary>
	public static string ToName(this RainCatcherRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of RainCatcherRecipeTypes: " + type);
		return TypeToInternalName[RainCatcherRecipeTypes.Clearance_Rain_Catcher_T0];
	}
	
	/// <summary>
	/// Returns a RainCatcherRecipeTypes associated with the given name.
	/// Every RainCatcherRecipeTypes should have a unique name as to distinguish it from others.
	/// If no RainCatcherRecipeTypes is found, it will return RainCatcherRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static RainCatcherRecipeTypes ToRainCatcherRecipeTypes(this string name)
	{
		foreach (KeyValuePair<RainCatcherRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find RainCatcherRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return RainCatcherRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a RainCatcherRecipeModel associated with the given name.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If no RainCatcherRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel ToRainCatcherRecipeModel(this string name)
	{
		Eremite.Buildings.RainCatcherRecipeModel model = SO.Settings.rainCatchersRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find RainCatcherRecipeModel for RainCatcherRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a RainCatcherRecipeModel associated with the given RainCatcherRecipeTypes.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If no RainCatcherRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel ToRainCatcherRecipeModel(this RainCatcherRecipeTypes types)
	{
		return types.ToName().ToRainCatcherRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of RainCatcherRecipeModel associated with the given RainCatcherRecipeTypes.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel[] ToRainCatcherRecipeModelArray(this IEnumerable<RainCatcherRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RainCatcherRecipeModel[] array = new Eremite.Buildings.RainCatcherRecipeModel[count];
		int i = 0;
		foreach (RainCatcherRecipeTypes element in collection)
		{
			array[i++] = element.ToRainCatcherRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RainCatcherRecipeModel associated with the given RainCatcherRecipeTypes.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel[] ToRainCatcherRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RainCatcherRecipeModel[] array = new Eremite.Buildings.RainCatcherRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToRainCatcherRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RainCatcherRecipeModel associated with the given RainCatcherRecipeTypes.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel[] ToRainCatcherRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.RainCatcherRecipeModel>.Get(out List<Eremite.Buildings.RainCatcherRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.RainCatcherRecipeModel model = element.ToRainCatcherRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of RainCatcherRecipeModel associated with the given RainCatcherRecipeTypes.
	/// RainCatcherRecipeModel contain all the data that will be used in the game.
	/// Every RainCatcherRecipeModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RainCatcherRecipeModel[] ToRainCatcherRecipeModelArrayNoNulls(this IEnumerable<RainCatcherRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.RainCatcherRecipeModel>.Get(out List<Eremite.Buildings.RainCatcherRecipeModel> list))
		{
			foreach (RainCatcherRecipeTypes element in collection)
			{
				Eremite.Buildings.RainCatcherRecipeModel model = element.ToRainCatcherRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<RainCatcherRecipeTypes, string> TypeToInternalName = new()
	{
		{ RainCatcherRecipeTypes.Clearance_Rain_Catcher_T0, "Clearance Rain Catcher (T0)" }, 
		{ RainCatcherRecipeTypes.Clearance_Rain_Catcher_T1, "Clearance Rain Catcher (T1)" }, 
		{ RainCatcherRecipeTypes.Drizzle_Rain_Catcher_T0, "Drizzle Rain Catcher (T0)" }, 
		{ RainCatcherRecipeTypes.Drizzle_Rain_Catcher_T1, "Drizzle Rain Catcher (T1)" }, 
		{ RainCatcherRecipeTypes.Storm_Rain_Catcher_T0, "Storm Rain Catcher (T0)" }, 
		{ RainCatcherRecipeTypes.Storm_Rain_Catcher_T1, "Storm Rain Catcher (T1)" }, 

	};
}
