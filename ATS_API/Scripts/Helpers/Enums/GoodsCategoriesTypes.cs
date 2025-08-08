using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum GoodsCategoriesTypes
{
	/// <summary>
	/// Placeholder for an unknown GoodsCategoriesTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no GoodsCategoriesTypes. Typically, seen if nothing is defined or failed to parse a string to a GoodsCategoriesTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Building Materials - {0} to expand category
	/// </summary>
	/// <name>Building Materials</name>
	Building_Materials = 1,

	/// <summary>
	/// Consumable Items - {0} to expand category
	/// </summary>
	/// <name>Consumable Items</name>
	Consumable_Items = 2,

	/// <summary>
	/// Crafting Resources - {0} to expand category
	/// </summary>
	/// <name>Crafting</name>
	Crafting = 3,

	/// <summary>
	/// Food - {0} to expand category
	/// </summary>
	/// <name>Food</name>
	Food = 4,

	/// <summary>
	/// Fuel & Exploration - {0} to expand category
	/// </summary>
	/// <name>Fuel</name>
	Fuel = 5,

	/// <summary>
	/// Others - {0} to expand category
	/// </summary>
	/// <name>Others</name>
	Others = 6,

	/// <summary>
	/// Trade Goods - {0} to expand category
	/// </summary>
	/// <name>Trade Goods</name>
	Trade_Goods = 7,



	/// <summary>
	/// The total number of vanilla GoodsCategoriesTypes in the game.
	/// </summary>
	[Obsolete("Use GoodsCategoriesTypesExtensions.Count(). GoodsCategoriesTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 7
}

/// <summary>
/// Extension methods for the GoodsCategoriesTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class GoodsCategoriesTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in GoodsCategoriesTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded GoodsCategoriesTypes.
	/// </summary>
	public static GoodsCategoriesTypes[] All()
	{
		GoodsCategoriesTypes[] all = new GoodsCategoriesTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every GoodsCategoriesTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return GoodsCategoriesTypes.Building_Materials in the enum and log an error.
	/// </summary>
	public static string ToName(this GoodsCategoriesTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of GoodsCategoriesTypes: " + type);
		return TypeToInternalName[GoodsCategoriesTypes.Building_Materials];
	}
	
	/// <summary>
	/// Returns a GoodsCategoriesTypes associated with the given name.
	/// Every GoodsCategoriesTypes should have a unique name as to distinguish it from others.
	/// If no GoodsCategoriesTypes is found, it will return GoodsCategoriesTypes.Unknown and log a warning.
	/// </summary>
	public static GoodsCategoriesTypes ToGoodsCategoriesTypes(this string name)
	{
		foreach (KeyValuePair<GoodsCategoriesTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find GoodsCategoriesTypes with name: " + name + "\n" + Environment.StackTrace);
		return GoodsCategoriesTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a GoodCategoryModel associated with the given name.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If no GoodCategoryModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel ToGoodCategoryModel(this string name)
	{
		Eremite.Model.GoodCategoryModel model = SO.Settings.GoodsCategories.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find GoodCategoryModel for GoodsCategoriesTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a GoodCategoryModel associated with the given GoodsCategoriesTypes.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If no GoodCategoryModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel ToGoodCategoryModel(this GoodsCategoriesTypes types)
	{
		return types.ToName().ToGoodCategoryModel();
	}
	
	/// <summary>
	/// Returns an array of GoodCategoryModel associated with the given GoodsCategoriesTypes.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If a GoodCategoryModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel[] ToGoodCategoryModelArray(this IEnumerable<GoodsCategoriesTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.GoodCategoryModel[] array = new Eremite.Model.GoodCategoryModel[count];
		int i = 0;
		foreach (GoodsCategoriesTypes element in collection)
		{
			array[i++] = element.ToGoodCategoryModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoodCategoryModel associated with the given GoodsCategoriesTypes.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If a GoodCategoryModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel[] ToGoodCategoryModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.GoodCategoryModel[] array = new Eremite.Model.GoodCategoryModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGoodCategoryModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoodCategoryModel associated with the given GoodsCategoriesTypes.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If a GoodCategoryModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel[] ToGoodCategoryModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.GoodCategoryModel>.Get(out List<Eremite.Model.GoodCategoryModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.GoodCategoryModel model = element.ToGoodCategoryModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of GoodCategoryModel associated with the given GoodsCategoriesTypes.
	/// GoodCategoryModel contain all the data that will be used in the game.
	/// Every GoodCategoryModel should have a unique name as to distinguish it from others.
	/// If a GoodCategoryModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.GoodCategoryModel[] ToGoodCategoryModelArrayNoNulls(this IEnumerable<GoodsCategoriesTypes> collection)
	{
		using(ListPool<Eremite.Model.GoodCategoryModel>.Get(out List<Eremite.Model.GoodCategoryModel> list))
		{
			foreach (GoodsCategoriesTypes element in collection)
			{
				Eremite.Model.GoodCategoryModel model = element.ToGoodCategoryModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<GoodsCategoriesTypes, string> TypeToInternalName = new()
	{
		{ GoodsCategoriesTypes.Building_Materials, "Building Materials" }, // Building Materials - {0} to expand category
		{ GoodsCategoriesTypes.Consumable_Items, "Consumable Items" },     // Consumable Items - {0} to expand category
		{ GoodsCategoriesTypes.Crafting, "Crafting" },                     // Crafting Resources - {0} to expand category
		{ GoodsCategoriesTypes.Food, "Food" },                             // Food - {0} to expand category
		{ GoodsCategoriesTypes.Fuel, "Fuel" },                             // Fuel & Exploration - {0} to expand category
		{ GoodsCategoriesTypes.Others, "Others" },                         // Others - {0} to expand category
		{ GoodsCategoriesTypes.Trade_Goods, "Trade Goods" },               // Trade Goods - {0} to expand category

	};
}
