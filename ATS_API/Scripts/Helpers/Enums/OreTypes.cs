using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.11R
public enum OreTypes
{
	Unknown = -1,
	None,
	Coal_Ore,   // Coal Vein - An effective source of fuel.
	Copper_Ore, // Copper Vein - A soft and malleable metal, resistant to rain.


	MAX = 2
}

public static class OreTypesExtensions
{
	private static OreTypes[] s_All = null;
	public static OreTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new OreTypes[2];
			for (int i = 0; i < 2; i++)
			{
				s_All[i] = (OreTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this OreTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of OreTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[OreTypes.Coal_Ore];
	}
	
	public static OreTypes ToOreTypes(this string name)
	{
		foreach (KeyValuePair<OreTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find OreTypes with name: " + name + "\n" + Environment.StackTrace);
		return OreTypes.Unknown;
	}
	
	public static OreModel ToOreModel(this string name)
	{
		OreModel model = SO.Settings.Ore.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find OreModel for OreTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static OreModel ToOreModel(this OreTypes types)
	{
		return types.ToName().ToOreModel();
	}
	
	public static OreModel[] ToOreModelArray(this IEnumerable<OreTypes> collection)
	{
		int count = collection.Count();
		OreModel[] array = new OreModel[count];
		int i = 0;
		foreach (OreTypes element in collection)
		{
			array[i++] = element.ToOreModel();
		}

		return array;
	}
	
	public static OreModel[] ToOreModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		OreModel[] array = new OreModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToOreModel();
		}

		return array;
	}

	internal static readonly Dictionary<OreTypes, string> TypeToInternalName = new()
	{
		{ OreTypes.Coal_Ore, "Coal Ore" },     // Coal Vein - An effective source of fuel.
		{ OreTypes.Copper_Ore, "Copper Ore" }, // Copper Vein - A soft and malleable metal, resistant to rain.

	};
}
