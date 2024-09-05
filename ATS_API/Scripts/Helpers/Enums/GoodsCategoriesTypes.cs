using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum GoodsCategoriesTypes
{
	Unknown = -1,
	None,
	Building_Materials, // Building Materials - {0} to expand category
	Consumable_Items,   // Consumable Items - {0} to expand category
	Crafting,           // Crafting Resources - {0} to expand category
	Food,               // Food - {0} to expand category
	Fuel,               // Fuel & Exploration - {0} to expand category
	Others,             // Others - {0} to expand category
	Trade_Goods,        // Trade Goods - {0} to expand category


	MAX = 7
}

public static class GoodsCategoriesTypesExtensions
{
	private static GoodsCategoriesTypes[] s_All = null;
	public static GoodsCategoriesTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new GoodsCategoriesTypes[7];
			for (int i = 0; i < 7; i++)
			{
				s_All[i] = (GoodsCategoriesTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this GoodsCategoriesTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of GoodsCategoriesTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[GoodsCategoriesTypes.Building_Materials];
	}
	
	public static GoodsCategoriesTypes ToGoodsCategoriesTypes(this string name)
	{
		foreach (KeyValuePair<GoodsCategoriesTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find GoodsCategoriesTypes with name: " + name + "\n" + Environment.StackTrace);
		return GoodsCategoriesTypes.Unknown;
	}
	
	public static GoodCategoryModel ToGoodCategoryModel(this string name)
	{
		GoodCategoryModel model = SO.Settings.GoodsCategories.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find GoodCategoryModel for GoodsCategoriesTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static GoodCategoryModel ToGoodCategoryModel(this GoodsCategoriesTypes types)
	{
		return types.ToName().ToGoodCategoryModel();
	}
	
	public static GoodCategoryModel[] ToGoodCategoryModelArray(this IEnumerable<GoodsCategoriesTypes> collection)
	{
		int count = collection.Count();
		GoodCategoryModel[] array = new GoodCategoryModel[count];
		int i = 0;
		foreach (GoodsCategoriesTypes element in collection)
		{
			array[i++] = element.ToGoodCategoryModel();
		}

		return array;
	}
	
	public static GoodCategoryModel[] ToGoodCategoryModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		GoodCategoryModel[] array = new GoodCategoryModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGoodCategoryModel();
		}

		return array;
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
