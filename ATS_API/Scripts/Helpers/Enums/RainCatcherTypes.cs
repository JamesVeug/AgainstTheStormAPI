using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum RainCatcherTypes
{
	/// <summary>
	/// Placeholder for an unknown RainCatcherTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no RainCatcherTypes. Typically, seen if nothing is defined or failed to parse a string to a RainCatcherTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
	/// </summary>
	/// <name>Advanced Rain Catcher</name>
	Advanced_Rain_Catcher = 1,

	/// <summary>
	/// Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.
	/// </summary>
	/// <name>Rain Catcher</name>
	Rain_Catcher = 2,



	/// <summary>
	/// The total number of vanilla RainCatcherTypes in the game.
	/// </summary>
	MAX = 2
}

/// <summary>
/// Extension methods for the RainCatcherTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class RainCatcherTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded RainCatcherTypes.
	/// </summary>
	public static RainCatcherTypes[] All()
	{
		RainCatcherTypes[] all = new RainCatcherTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every RainCatcherTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return RainCatcherTypes.Advanced_Rain_Catcher in the enum and log an error.
	/// </summary>
	public static string ToName(this RainCatcherTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of RainCatcherTypes: " + type);
		return TypeToInternalName[RainCatcherTypes.Advanced_Rain_Catcher];
	}
	
	/// <summary>
	/// Returns a RainCatcherTypes associated with the given name.
	/// Every RainCatcherTypes should have a unique name as to distinguish it from others.
	/// If no RainCatcherTypes is found, it will return RainCatcherTypes.Unknown and log a warning.
	/// </summary>
	public static RainCatcherTypes ToRainCatcherTypes(this string name)
	{
		foreach (KeyValuePair<RainCatcherTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find RainCatcherTypes with name: " + name + "\n" + Environment.StackTrace);
		return RainCatcherTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a RainCatcherModel associated with the given name.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If no RainCatcherModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel ToRainCatcherModel(this string name)
	{
		Eremite.Buildings.RainCatcherModel model = SO.Settings.Buildings.Where(a=>a is RainCatcherModel).Cast<RainCatcherModel>().FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find RainCatcherModel for RainCatcherTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a RainCatcherModel associated with the given RainCatcherTypes.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If no RainCatcherModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel ToRainCatcherModel(this RainCatcherTypes types)
	{
		return types.ToName().ToRainCatcherModel();
	}
	
	/// <summary>
	/// Returns an array of RainCatcherModel associated with the given RainCatcherTypes.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel[] ToRainCatcherModelArray(this IEnumerable<RainCatcherTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RainCatcherModel[] array = new Eremite.Buildings.RainCatcherModel[count];
		int i = 0;
		foreach (RainCatcherTypes element in collection)
		{
			array[i++] = element.ToRainCatcherModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RainCatcherModel associated with the given RainCatcherTypes.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel[] ToRainCatcherModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RainCatcherModel[] array = new Eremite.Buildings.RainCatcherModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToRainCatcherModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RainCatcherModel associated with the given RainCatcherTypes.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel[] ToRainCatcherModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.RainCatcherModel>.Get(out List<Eremite.Buildings.RainCatcherModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.RainCatcherModel model = element.ToRainCatcherModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of RainCatcherModel associated with the given RainCatcherTypes.
	/// RainCatcherModel contain all the data that will be used in the game.
	/// Every RainCatcherModel should have a unique name as to distinguish it from others.
	/// If a RainCatcherModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RainCatcherModel[] ToRainCatcherModelArrayNoNulls(this IEnumerable<RainCatcherTypes> collection)
	{
		using(ListPool<Eremite.Buildings.RainCatcherModel>.Get(out List<Eremite.Buildings.RainCatcherModel> list))
		{
			foreach (RainCatcherTypes element in collection)
			{
				Eremite.Buildings.RainCatcherModel model = element.ToRainCatcherModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<RainCatcherTypes, string> TypeToInternalName = new()
	{
		{ RainCatcherTypes.Advanced_Rain_Catcher, "Advanced Rain Catcher" }, // Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
		{ RainCatcherTypes.Rain_Catcher, "Rain Catcher" },                   // Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.

	};
}
