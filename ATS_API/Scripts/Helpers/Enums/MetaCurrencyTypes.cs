using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.11R
public enum MetaCurrencyTypes
{
	Unknown = -1,
	None,
	Artifacts,       // Artifacts
	Food_Stockpiles, // Food Stockpiles
	Machinery,       // Machinery


	MAX = 3
}

public static class MetaCurrencyTypesExtensions
{
	private static MetaCurrencyTypes[] s_All = null;
	public static MetaCurrencyTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new MetaCurrencyTypes[3];
			for (int i = 0; i < 3; i++)
			{
				s_All[i] = (MetaCurrencyTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this MetaCurrencyTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of MetaCurrencyTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[MetaCurrencyTypes.Artifacts];
	}
	
	public static MetaCurrencyTypes ToMetaCurrencyTypes(this string name)
	{
		foreach (KeyValuePair<MetaCurrencyTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find MetaCurrencyTypes with name: " + name + "\n" + Environment.StackTrace);
		return MetaCurrencyTypes.Unknown;
	}
	
	public static MetaCurrencyModel ToMetaCurrencyModel(this string name)
	{
		MetaCurrencyModel model = SO.Settings.metaCurrencies.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find MetaCurrencyModel for MetaCurrencyTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static MetaCurrencyModel ToMetaCurrencyModel(this MetaCurrencyTypes types)
	{
		return types.ToName().ToMetaCurrencyModel();
	}
	
	public static MetaCurrencyModel[] ToMetaCurrencyModelArray(this IEnumerable<MetaCurrencyTypes> collection)
	{
		int count = collection.Count();
		MetaCurrencyModel[] array = new MetaCurrencyModel[count];
		int i = 0;
		foreach (MetaCurrencyTypes element in collection)
		{
			array[i++] = element.ToMetaCurrencyModel();
		}

		return array;
	}
	
	public static MetaCurrencyModel[] ToMetaCurrencyModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		MetaCurrencyModel[] array = new MetaCurrencyModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToMetaCurrencyModel();
		}

		return array;
	}

	internal static readonly Dictionary<MetaCurrencyTypes, string> TypeToInternalName = new()
	{
		{ MetaCurrencyTypes.Artifacts, "Artifacts" },             // Artifacts
		{ MetaCurrencyTypes.Food_Stockpiles, "Food Stockpiles" }, // Food Stockpiles
		{ MetaCurrencyTypes.Machinery, "Machinery" },             // Machinery

	};
}
