using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Trade;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum TraderTypes
{
	Unknown = -1,
	None,
	Trader_0_General,                     // Sahilda - She might have <color=#e0e09f>raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks</color> for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
	Trader_1_First_Dawn_Company,          // Zhorg - He might have <color=#e0e09f>cooked and raw food, pottery, and tools, along with perks and blueprints tied to agriculture</color> for sale. He is willing to buy packs of goods, raw food, building materials and some crafting materials.
	Trader_2_Brass_Order,                 // Old Farluf - He might have <color=#e0e09f>metal, fuel, tools, building materials, and a number of blueprints and perks</color> for sale. He is willing to buy packs of goods, resources, advanced building materials, metal, and some crafting materials.
	Trader_3_Ancient,                     // Sothur The Ancient - He might have <color=#e0e09f>luxury items, crafting materials, blueprints for alchemical buildings, and perks</color> for sale. He is willing to buy packs of goods, fuel, cooked food, and luxury goods.
	Trader_4_Vanguard_Of_The_Stolen_Keys, // Vliss Greybone - She might have <color=#e0e09f>tools, luxury items, building materials, and perks</color> for sale. She is willing to buy packs of goods, cooked food, metal, building materials, fuel, and tools.
	Trader_5_Royal_Trading_Company,       // Sir Renwald Redmane - He might have <color=#e0e09f>cooked food, building materials, tools, parts, advanced blueprints, and perks</color> for sale. He is willing to buy packs of goods, fuel, building materials, luxury items, tools, and metal.
	Trader_6_Wandering_Merchant,          // Xiadani Stormfeather - She might have <color=#e0e09f>raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks</color> for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
	Trader_7_Trickster,                   // Dullahan Warlander - Dullahan might have <color=#e0e09f>metal, fabrics, crafting materials, and packs of goods</color> for sale. He also sells <color=#e0e09f>mystery boxes</color>. He is willing to buy packs of goods, luxury items, crafting materials, cooked food, and some raw resources.
	Trader_Glade_01,                      // Alune Soulgazer
	Trader_Glade_02,                      // Gex Runescale
	Trader_Glade_03,                      // Ruenhar Blightclaw


	MAX = 11
}

public static class TraderTypesExtensions
{
	private static TraderTypes[] s_All = null;
	public static TraderTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new TraderTypes[11];
			for (int i = 0; i < 11; i++)
			{
				s_All[i] = (TraderTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this TraderTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of TraderTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[TraderTypes.Trader_0_General];
	}
	
	public static TraderTypes ToTraderTypes(this string name)
	{
		foreach (KeyValuePair<TraderTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find TraderTypes with name: " + name + "\n" + Environment.StackTrace);
		return TraderTypes.Unknown;
	}
	
	public static TraderModel ToTraderModel(this string name)
	{
		TraderModel model = SO.Settings.traders.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find TraderModel for TraderTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static TraderModel ToTraderModel(this TraderTypes types)
	{
		return types.ToName().ToTraderModel();
	}
	
	public static TraderModel[] ToTraderModelArray(this IEnumerable<TraderTypes> collection)
	{
		int count = collection.Count();
		TraderModel[] array = new TraderModel[count];
		int i = 0;
		foreach (TraderTypes element in collection)
		{
			array[i++] = element.ToTraderModel();
		}

		return array;
	}
	
	public static TraderModel[] ToTraderModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		TraderModel[] array = new TraderModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToTraderModel();
		}

		return array;
	}

	internal static readonly Dictionary<TraderTypes, string> TypeToInternalName = new()
	{
		{ TraderTypes.Trader_0_General, "Trader 0 - General" },                                         // Sahilda - She might have <color=#e0e09f>raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks</color> for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
		{ TraderTypes.Trader_1_First_Dawn_Company, "Trader 1 - First Dawn Company" },                   // Zhorg - He might have <color=#e0e09f>cooked and raw food, pottery, and tools, along with perks and blueprints tied to agriculture</color> for sale. He is willing to buy packs of goods, raw food, building materials and some crafting materials.
		{ TraderTypes.Trader_2_Brass_Order, "Trader 2 - Brass Order" },                                 // Old Farluf - He might have <color=#e0e09f>metal, fuel, tools, building materials, and a number of blueprints and perks</color> for sale. He is willing to buy packs of goods, resources, advanced building materials, metal, and some crafting materials.
		{ TraderTypes.Trader_3_Ancient, "Trader 3 - Ancient" },                                         // Sothur The Ancient - He might have <color=#e0e09f>luxury items, crafting materials, blueprints for alchemical buildings, and perks</color> for sale. He is willing to buy packs of goods, fuel, cooked food, and luxury goods.
		{ TraderTypes.Trader_4_Vanguard_Of_The_Stolen_Keys, "Trader 4 - Vanguard of the Stolen Keys" }, // Vliss Greybone - She might have <color=#e0e09f>tools, luxury items, building materials, and perks</color> for sale. She is willing to buy packs of goods, cooked food, metal, building materials, fuel, and tools.
		{ TraderTypes.Trader_5_Royal_Trading_Company, "Trader 5 - Royal Trading Company" },             // Sir Renwald Redmane - He might have <color=#e0e09f>cooked food, building materials, tools, parts, advanced blueprints, and perks</color> for sale. He is willing to buy packs of goods, fuel, building materials, luxury items, tools, and metal.
		{ TraderTypes.Trader_6_Wandering_Merchant, "Trader 6 - Wandering Merchant" },                   // Xiadani Stormfeather - She might have <color=#e0e09f>raw food, basic resources, building materials, some crafting materials, and a small number of basic blueprints and perks</color> for sale. She is willing to buy packs of goods, raw food, basic resources, and some building materials.
		{ TraderTypes.Trader_7_Trickster, "Trader 7 - Trickster" },                                     // Dullahan Warlander - Dullahan might have <color=#e0e09f>metal, fabrics, crafting materials, and packs of goods</color> for sale. He also sells <color=#e0e09f>mystery boxes</color>. He is willing to buy packs of goods, luxury items, crafting materials, cooked food, and some raw resources.
		{ TraderTypes.Trader_Glade_01, "Trader - Glade 01" },                                           // Alune Soulgazer
		{ TraderTypes.Trader_Glade_02, "Trader - Glade 02" },                                           // Gex Runescale
		{ TraderTypes.Trader_Glade_03, "Trader - Glade 03" },                                           // Ruenhar Blightclaw

	};
}
