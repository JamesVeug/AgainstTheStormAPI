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
public enum CollectorTypes
{
	/// <summary>
	/// Placeholder for an unknown CollectorTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no CollectorTypes. Typically, seen if nothing is defined or failed to parse a string to a CollectorTypes.
	/// </summary>
	None = 0,
	


	/// <summary>
	/// The total number of vanilla CollectorTypes in the game.
	/// </summary>
	[Obsolete("Use CollectorTypesExtensions.Count(). CollectorTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 0
}

/// <summary>
/// Extension methods for the CollectorTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class CollectorTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in CollectorTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded CollectorTypes.
	/// </summary>
	public static CollectorTypes[] All()
	{
		CollectorTypes[] all = new CollectorTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every CollectorTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return CollectorTypes.None in the enum and log an error.
	/// </summary>
	public static string ToName(this CollectorTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of CollectorTypes: " + type);
		return TypeToInternalName[CollectorTypes.None];
	}
	
	/// <summary>
	/// Returns a CollectorTypes associated with the given name.
	/// Every CollectorTypes should have a unique name as to distinguish it from others.
	/// If no CollectorTypes is found, it will return CollectorTypes.Unknown and log a warning.
	/// </summary>
	public static CollectorTypes ToCollectorTypes(this string name)
	{
		foreach (KeyValuePair<CollectorTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find CollectorTypes with name: " + name + "\n" + Environment.StackTrace);
		return CollectorTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a CollectorModel associated with the given name.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If no CollectorModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CollectorModel ToCollectorModel(this string name)
	{
		Eremite.Buildings.CollectorModel model = SO.Settings.Buildings.Where(a=>a is CollectorModel).Cast<CollectorModel>().FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find CollectorModel for CollectorTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a CollectorModel associated with the given CollectorTypes.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If no CollectorModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CollectorModel ToCollectorModel(this CollectorTypes types)
	{
		return types.ToName().ToCollectorModel();
	}
	
	/// <summary>
	/// Returns an array of CollectorModel associated with the given CollectorTypes.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If a CollectorModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CollectorModel[] ToCollectorModelArray(this IEnumerable<CollectorTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CollectorModel[] array = new Eremite.Buildings.CollectorModel[count];
		int i = 0;
		foreach (CollectorTypes element in collection)
		{
			array[i++] = element.ToCollectorModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CollectorModel associated with the given CollectorTypes.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If a CollectorModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CollectorModel[] ToCollectorModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CollectorModel[] array = new Eremite.Buildings.CollectorModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToCollectorModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CollectorModel associated with the given CollectorTypes.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If a CollectorModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CollectorModel[] ToCollectorModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.CollectorModel>.Get(out List<Eremite.Buildings.CollectorModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.CollectorModel model = element.ToCollectorModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of CollectorModel associated with the given CollectorTypes.
	/// CollectorModel contain all the data that will be used in the game.
	/// Every CollectorModel should have a unique name as to distinguish it from others.
	/// If a CollectorModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CollectorModel[] ToCollectorModelArrayNoNulls(this IEnumerable<CollectorTypes> collection)
	{
		using(ListPool<Eremite.Buildings.CollectorModel>.Get(out List<Eremite.Buildings.CollectorModel> list))
		{
			foreach (CollectorTypes element in collection)
			{
				Eremite.Buildings.CollectorModel model = element.ToCollectorModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<CollectorTypes, string> TypeToInternalName = new()
	{

	};
}
