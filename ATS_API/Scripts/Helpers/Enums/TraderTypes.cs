using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model.Trade;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.9.3R
/// </summary>
public enum TraderTypes
{
	/// <summary>
	/// Placeholder for an unknown TraderTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no TraderTypes. Typically, seen if nothing is defined or failed to parse a string to a TraderTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Sahilda - She might have raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
	/// </summary>
	/// <name>Trader 0 - General</name>
	Trader_0_General = 1,

	/// <summary>
	/// Zhorg - He might have cooked and raw food, pottery, and tools, along with perks and blueprints tied to agriculture for sale. He is willing to buy packs of goods, raw food, building materials and some crafting materials.
	/// </summary>
	/// <name>Trader 1 - First Dawn Company</name>
	Trader_1_First_Dawn_Company = 2,

	/// <summary>
	/// Old Farluf - He might have metal, fuel, tools, building materials, and a number of blueprints and perks for sale. He is willing to buy packs of goods, resources, advanced building materials, metal, and some crafting materials.
	/// </summary>
	/// <name>Trader 2 - Brass Order</name>
	Trader_2_Brass_Order = 3,

	/// <summary>
	/// Sothur The Ancient - He might have service goods, crafting materials, blueprints for alchemical buildings, and perks for sale. He is willing to buy packs of goods, fuel, cooked food, and service goods.
	/// </summary>
	/// <name>Trader 3 - Ancient</name>
	Trader_3_Ancient = 4,

	/// <summary>
	/// Vliss Greybone - She might have tools, service goods, building materials, and perks for sale. She is willing to buy packs of goods, cooked food, metal, building materials, fuel, and tools.
	/// </summary>
	/// <name>Trader 4 - Vanguard of the Stolen Keys</name>
	Trader_4_Vanguard_Of_The_Stolen_Keys = 5,

	/// <summary>
	/// Sir Renwald Redmane - He might have cooked food, building materials, tools, parts, advanced blueprints, and perks for sale. He is willing to buy packs of goods, fuel, building materials, service goods, tools, and metal.
	/// </summary>
	/// <name>Trader 5 - Royal Trading Company</name>
	Trader_5_Royal_Trading_Company = 6,

	/// <summary>
	/// Xiadani Stormfeather - She might have clothing, cooked food, raw materials, fuel, ancient tablets, parts, wildfire essence, blueprints, and perks for sale. She is willing to buy packs of goods, raw food, basic resources, metal, and some building materials.
	/// </summary>
	/// <name>Trader 6 - Wandering Merchant</name>
	Trader_6_Wandering_Merchant = 7,

	/// <summary>
	/// Dullahan Warlander - Dullahan might have metal, fabrics, crafting materials, and packs of goods for sale. He also sells mystery boxes. He is willing to buy packs of goods, service goods, crafting materials, cooked food, and some raw resources.
	/// </summary>
	/// <name>Trader 7 - Trickster</name>
	Trader_7_Trickster = 8,

	/// <summary>
	/// Vael - He might have clothing, cooked food, service goods, fuel, containers, metal, wildfire essence, blueprints, and perks for sale. He is willing to buy packs of goods, raw food, basic resources, metal, and some building materials.
	/// </summary>
	/// <name>Trader 8 - Syndicate</name>
	Trader_8_Syndicate = 12,

	/// <summary>
	/// Alune Soulgazer
	/// </summary>
	/// <name>Trader - Glade 01</name>
	Trader_Glade_01 = 9,

	/// <summary>
	/// Gex Runescale
	/// </summary>
	/// <name>Trader - Glade 02</name>
	Trader_Glade_02 = 10,

	/// <summary>
	/// Ruenhar Blightclaw
	/// </summary>
	/// <name>Trader - Glade 03</name>
	Trader_Glade_03 = 11,



	/// <summary>
	/// The total number of vanilla TraderTypes in the game.
	/// </summary>
	[Obsolete("Use TraderTypesExtensions.Count(). TraderTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 13
}

/// <summary>
/// Extension methods for the TraderTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class TraderTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in TraderTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded TraderTypes.
	/// </summary>
	public static TraderTypes[] All()
	{
		TraderTypes[] all = new TraderTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every TraderTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return TraderTypes.Trader_0_General in the enum and log an error.
	/// </summary>
	public static string ToName(this TraderTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of TraderTypes: " + type);
		return TypeToInternalName[TraderTypes.Trader_0_General];
	}
	
	/// <summary>
	/// Returns a TraderTypes associated with the given name.
	/// Every TraderTypes should have a unique name as to distinguish it from others.
	/// If no TraderTypes is found, it will return TraderTypes.Unknown and log a warning.
	/// </summary>
	public static TraderTypes ToTraderTypes(this string name)
	{
		foreach (KeyValuePair<TraderTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find TraderTypes with name: " + name + "\n" + Environment.StackTrace);
		return TraderTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a TraderModel associated with the given name.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If no TraderModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel ToTraderModel(this string name)
	{
		Eremite.Model.Trade.TraderModel model = SO.Settings.traders.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find TraderModel for TraderTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a TraderModel associated with the given TraderTypes.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If no TraderModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel ToTraderModel(this TraderTypes types)
	{
		return types.ToName().ToTraderModel();
	}
	
	/// <summary>
	/// Returns an array of TraderModel associated with the given TraderTypes.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If a TraderModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel[] ToTraderModelArray(this IEnumerable<TraderTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.Trade.TraderModel[] array = new Eremite.Model.Trade.TraderModel[count];
		int i = 0;
		foreach (TraderTypes element in collection)
		{
			array[i++] = element.ToTraderModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of TraderModel associated with the given TraderTypes.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If a TraderModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel[] ToTraderModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.Trade.TraderModel[] array = new Eremite.Model.Trade.TraderModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToTraderModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of TraderModel associated with the given TraderTypes.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If a TraderModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel[] ToTraderModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.Trade.TraderModel>.Get(out List<Eremite.Model.Trade.TraderModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.Trade.TraderModel model = element.ToTraderModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of TraderModel associated with the given TraderTypes.
	/// TraderModel contain all the data that will be used in the game.
	/// Every TraderModel should have a unique name as to distinguish it from others.
	/// If a TraderModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Trade.TraderModel[] ToTraderModelArrayNoNulls(this IEnumerable<TraderTypes> collection)
	{
		using(ListPool<Eremite.Model.Trade.TraderModel>.Get(out List<Eremite.Model.Trade.TraderModel> list))
		{
			foreach (TraderTypes element in collection)
			{
				Eremite.Model.Trade.TraderModel model = element.ToTraderModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<TraderTypes, string> TypeToInternalName = new()
	{
		{ TraderTypes.Trader_0_General, "Trader 0 - General" },                                         // Sahilda - She might have raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
		{ TraderTypes.Trader_1_First_Dawn_Company, "Trader 1 - First Dawn Company" },                   // Zhorg - He might have cooked and raw food, pottery, and tools, along with perks and blueprints tied to agriculture for sale. He is willing to buy packs of goods, raw food, building materials and some crafting materials.
		{ TraderTypes.Trader_2_Brass_Order, "Trader 2 - Brass Order" },                                 // Old Farluf - He might have metal, fuel, tools, building materials, and a number of blueprints and perks for sale. He is willing to buy packs of goods, resources, advanced building materials, metal, and some crafting materials.
		{ TraderTypes.Trader_3_Ancient, "Trader 3 - Ancient" },                                         // Sothur The Ancient - He might have service goods, crafting materials, blueprints for alchemical buildings, and perks for sale. He is willing to buy packs of goods, fuel, cooked food, and service goods.
		{ TraderTypes.Trader_4_Vanguard_Of_The_Stolen_Keys, "Trader 4 - Vanguard of the Stolen Keys" }, // Vliss Greybone - She might have tools, service goods, building materials, and perks for sale. She is willing to buy packs of goods, cooked food, metal, building materials, fuel, and tools.
		{ TraderTypes.Trader_5_Royal_Trading_Company, "Trader 5 - Royal Trading Company" },             // Sir Renwald Redmane - He might have cooked food, building materials, tools, parts, advanced blueprints, and perks for sale. He is willing to buy packs of goods, fuel, building materials, service goods, tools, and metal.
		{ TraderTypes.Trader_6_Wandering_Merchant, "Trader 6 - Wandering Merchant" },                   // Xiadani Stormfeather - She might have clothing, cooked food, raw materials, fuel, ancient tablets, parts, wildfire essence, blueprints, and perks for sale. She is willing to buy packs of goods, raw food, basic resources, metal, and some building materials.
		{ TraderTypes.Trader_7_Trickster, "Trader 7 - Trickster" },                                     // Dullahan Warlander - Dullahan might have metal, fabrics, crafting materials, and packs of goods for sale. He also sells mystery boxes. He is willing to buy packs of goods, service goods, crafting materials, cooked food, and some raw resources.
		{ TraderTypes.Trader_8_Syndicate, "Trader 8 - Syndicate" },                                     // Vael - He might have clothing, cooked food, service goods, fuel, containers, metal, wildfire essence, blueprints, and perks for sale. He is willing to buy packs of goods, raw food, basic resources, metal, and some building materials.
		{ TraderTypes.Trader_Glade_01, "Trader - Glade 01" },                                           // Alune Soulgazer
		{ TraderTypes.Trader_Glade_02, "Trader - Glade 02" },                                           // Gex Runescale
		{ TraderTypes.Trader_Glade_03, "Trader - Glade 03" },                                           // Ruenhar Blightclaw

	};
}
