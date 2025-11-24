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
public enum CollectorRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown CollectorRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no CollectorRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a CollectorRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Clay (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay_Collector = 1,

	/// <summary></summary>
	/// <name>Crystalized Dew [ancient]</name>
	/// <tags>Metal Tag</tags>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_ancient = 2,

	/// <summary></summary>
	/// <name>Crystalized Dew T0 (Collector)</name>
	/// <tags>Metal Tag</tags>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T0_Collector = 3,

	/// <summary></summary>
	/// <name>Herbs (Collector)</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_Collector = 4,

	/// <summary></summary>
	/// <name>Ink T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Ink_T1_Collector = 5,

	/// <summary></summary>
	/// <name>Insects (Collector)</name>
	/// <tags>Food Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects_Collector = 6,

	/// <summary></summary>
	/// <name>Leather (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather_Collector = 7,

	/// <summary></summary>
	/// <name>Meat (Collector)</name>
	/// <tags>Food Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_Collector = 8,

	/// <summary></summary>
	/// <name>Mushrooms (Collector)</name>
	/// <tags>Food Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Collector = 9,

	/// <summary></summary>
	/// <name>Reeds (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Reeds_Collector = 10,

	/// <summary></summary>
	/// <name>Roots (Collector)</name>
	/// <tags>Food Tag</tags>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Collector = 11,

	/// <summary></summary>
	/// <name>Sparkdew T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Sparkdew</producedGood>
	Sparkdew_T1_Collector = 12,

	/// <summary></summary>
	/// <name>Stone [ancient]</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Stone_ancient = 13,

	/// <summary></summary>
	/// <name>Wine T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Wine_T1_Collector = 14,



	/// <summary>
	/// The total number of vanilla CollectorRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use CollectorRecipeTypesExtensions.Count(). CollectorRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 15
}

/// <summary>
/// Extension methods for the CollectorRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class CollectorRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in CollectorRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded CollectorRecipeTypes.
	/// </summary>
	public static CollectorRecipeTypes[] All()
	{
		CollectorRecipeTypes[] all = new CollectorRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every CollectorRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return CollectorRecipeTypes.Clay_Collector in the enum and log an error.
	/// </summary>
	public static string ToName(this CollectorRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of CollectorRecipeTypes: " + type);
		return TypeToInternalName[CollectorRecipeTypes.Clay_Collector];
	}
	
	/// <summary>
	/// Returns a CollectorRecipeTypes associated with the given name.
	/// Every CollectorRecipeTypes should have a unique name as to distinguish it from others.
	/// If no CollectorRecipeTypes is found, it will return CollectorRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static CollectorRecipeTypes ToCollectorRecipeTypes(this string name)
	{
		foreach (KeyValuePair<CollectorRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find CollectorRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return CollectorRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a CollectorRecipeModel associated with the given name.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If no CollectorRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel ToCollectorRecipeModel(this string name)
	{
		Eremite.Buildings.CollectorRecipeModel model = SO.Settings.collectorsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find CollectorRecipeModel for CollectorRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a CollectorRecipeModel associated with the given CollectorRecipeTypes.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If no CollectorRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel ToCollectorRecipeModel(this CollectorRecipeTypes types)
	{
		return types.ToName().ToCollectorRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of CollectorRecipeModel associated with the given CollectorRecipeTypes.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If a CollectorRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel[] ToCollectorRecipeModelArray(this IEnumerable<CollectorRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CollectorRecipeModel[] array = new Eremite.Buildings.CollectorRecipeModel[count];
		int i = 0;
		foreach (CollectorRecipeTypes element in collection)
		{
			array[i++] = element.ToCollectorRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CollectorRecipeModel associated with the given CollectorRecipeTypes.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If a CollectorRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel[] ToCollectorRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.CollectorRecipeModel[] array = new Eremite.Buildings.CollectorRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToCollectorRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of CollectorRecipeModel associated with the given CollectorRecipeTypes.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If a CollectorRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel[] ToCollectorRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.CollectorRecipeModel>.Get(out List<Eremite.Buildings.CollectorRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.CollectorRecipeModel model = element.ToCollectorRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of CollectorRecipeModel associated with the given CollectorRecipeTypes.
	/// CollectorRecipeModel contain all the data that will be used in the game.
	/// Every CollectorRecipeModel should have a unique name as to distinguish it from others.
	/// If a CollectorRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.CollectorRecipeModel[] ToCollectorRecipeModelArrayNoNulls(this IEnumerable<CollectorRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.CollectorRecipeModel>.Get(out List<Eremite.Buildings.CollectorRecipeModel> list))
		{
			foreach (CollectorRecipeTypes element in collection)
			{
				Eremite.Buildings.CollectorRecipeModel model = element.ToCollectorRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<CollectorRecipeTypes, string> TypeToInternalName = new()
	{
		{ CollectorRecipeTypes.Clay_Collector, "Clay (Collector)" }, 
		{ CollectorRecipeTypes.Crystalized_Dew_ancient, "Crystalized Dew [ancient]" }, 
		{ CollectorRecipeTypes.Crystalized_Dew_T0_Collector, "Crystalized Dew T0 (Collector)" }, 
		{ CollectorRecipeTypes.Herbs_Collector, "Herbs (Collector)" }, 
		{ CollectorRecipeTypes.Ink_T1_Collector, "Ink T1 (Collector)" }, 
		{ CollectorRecipeTypes.Insects_Collector, "Insects (Collector)" }, 
		{ CollectorRecipeTypes.Leather_Collector, "Leather (Collector)" }, 
		{ CollectorRecipeTypes.Meat_Collector, "Meat (Collector)" }, 
		{ CollectorRecipeTypes.Mushrooms_Collector, "Mushrooms (Collector)" }, 
		{ CollectorRecipeTypes.Reeds_Collector, "Reeds (Collector)" }, 
		{ CollectorRecipeTypes.Roots_Collector, "Roots (Collector)" }, 
		{ CollectorRecipeTypes.Sparkdew_T1_Collector, "Sparkdew T1 (Collector)" }, 
		{ CollectorRecipeTypes.Stone_ancient, "Stone [ancient]" }, 
		{ CollectorRecipeTypes.Wine_T1_Collector, "Wine T1 (Collector)" }, 

	};
}
