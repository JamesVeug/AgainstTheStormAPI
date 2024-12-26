using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum GoodsTypes
{
    /// <summary>
    /// Placeholder for an unknown GoodsTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no GoodsTypes. Typically, seen if nothing is defined or failed to parse a string to a GoodsTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Artifacts - The remnants of a long-forgotten world. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
	/// </summary>
	/// <name>_Meta Artifacts</name>
	_Meta_Artifacts = 1,

	/// <summary>
	/// Food Stockpiles - A basic currency of the realm. Earned by completing settlements. Can be used to purchase upgrades in the Smoldering City.
	/// </summary>
	/// <name>_Meta Food Stockpiles</name>
	_Meta_Food_Stockpiles = 2,

	/// <summary>
	/// Machinery - Rainpunk technology ripped from the past. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
	/// </summary>
	/// <name>_Meta Machinery</name>
	_Meta_Machinery = 3,

	/// <summary>
	/// <p>Purging Fire - A unique resource used by Blight Fighters to burn down Blightrot Cysts.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>Blight Fuel</name>
	Blight_Fuel = 4,

	/// <summary>
	/// <p>Coal - Efficient fuel.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Coal</name>
	Crafting_Coal = 5,

	/// <summary>
	/// <p>Dye - Used for crafting.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Dye</name>
	Crafting_Dye = 6,

	/// <summary>
	/// <p>Flour - Used for cooking.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Flour</name>
	Crafting_Flour = 7,

	/// <summary>
	/// <p>Oil - Efficient fuel.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Oil</name>
	Crafting_Oil = 8,

	/// <summary>
	/// <p>Salt - A valuable and highly absorbent mineral.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Salt</name>
	Crafting_Salt = 9,

	/// <summary>
	/// <p>Sea Marrow - Efficient fuel.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Crafting] Sea Marrow</name>
	Crafting_Sea_Marrow = 10,

	/// <summary>
	/// <p>Biscuits - Tasty and crunchy. Liked by: {2}. Villagers with a satisfied need for biscuits have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Biscuits</name>
	Food_Processed_Biscuits = 11,

	/// <summary>
	/// <p>Jerky - Preserved, dried meat. Liked by: {2}. Villagers with a satisfied need for jerky have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Jerky</name>
	Food_Processed_Jerky = 12,

	/// <summary>
	/// <p>Paste - A smooth paste, no chewing required. Liked by: {2}. Villagers with a satisfied need for paste have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Paste</name>
	Food_Processed_Paste = 13,

	/// <summary>
	/// <p>Pickled Goods - A Beaver specialty. Liked by: {2}. Villagers with a satisfied need for pickled goods have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Pickled Goods</name>
	Food_Processed_Pickled_Goods = 14,

	/// <summary>
	/// <p>Pie - A savory delicacy. Liked by: {2}. Villagers with a satisfied need for pie have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Pie</name>
	Food_Processed_Pie = 15,

	/// <summary>
	/// <p>Porridge - A nutritious and warming meal. Liked by: {2}. Villagers with a satisfied need for porridge have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Porridge</name>
	Food_Processed_Porridge = 16,

	/// <summary>
	/// <p>Skewers - A Lizard specialty. Liked by: {2}. Villagers with a satisfied need for skewers have an increased chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Processed] Skewers</name>
	Food_Processed_Skewers = 17,

	/// <summary>
	/// <p>Berries - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Berries</name>
	Food_Raw_Berries = 18,

	/// <summary>
	/// <p>Eggs - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Eggs</name>
	Food_Raw_Eggs = 19,

	/// <summary>
	/// <p>Fish - Plenty of them in the sea. A common food source.</p>
	/// <p><b>Obtained at:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Fish</name>
	Food_Raw_Fish = 20,

	/// <summary>
	/// <p>Grain - Isn't eaten raw, but can be processed.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Grain</name>
	Food_Raw_Grain = 21,

	/// <summary>
	/// <p>Herbs - Isn't eaten raw, but can be processed.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Herbs</name>
	Food_Raw_Herbs = 22,

	/// <summary>
	/// <p>Insects - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Insects</name>
	Food_Raw_Insects = 23,

	/// <summary>
	/// <p>Meat - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Meat</name>
	Food_Raw_Meat = 24,

	/// <summary>
	/// <p>Mushrooms - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Mushrooms</name>
	Food_Raw_Mushrooms = 25,

	/// <summary>
	/// <p>Roots - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Roots</name>
	Food_Raw_Roots = 26,

	/// <summary>
	/// <p>Vegetables - Common food source.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Food Raw] Vegetables</name>
	Food_Raw_Vegetables = 27,

	/// <summary>
	/// Wildfire Essence - A sentient flame trapped in a bottle. This rare material is used to light the Holy Flame in Hearths. Can be acquired from orders, Glade Events, or traders.
	/// </summary>
	/// <name>Hearth Parts</name>
	Hearth_Parts = 28,

	/// <summary>
	/// <p>Bricks - Mostly used for construction.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Processed] Bricks</name>
	Mat_Processed_Bricks = 29,

	/// <summary>
	/// <p>Fabric - Used for construction or production of clothes.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Processed] Fabric</name>
	Mat_Processed_Fabric = 30,

	/// <summary>
	/// Parts - Rare items used for construction. Difficult to produce in this harsh environment.
	/// </summary>
	/// <name>[Mat Processed] Parts</name>
	Mat_Processed_Parts = 31,

	/// <summary>
	/// <p>Pipes - Used to install Rainpunk Engines in production buildings and build Geyser Pumps.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Processed] Pipe</name>
	Mat_Processed_Pipe = 32,

	/// <summary>
	/// <p>Planks - Mostly used for construction.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Processed] Planks</name>
	Mat_Processed_Planks = 33,

	/// <summary>
	/// <p>Algae - Slimy, tough fibers fished from murky waters. Used for crafting.</p>
	/// <p><b>Obtained at:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Algae</name>
	Mat_Raw_Algae = 34,

	/// <summary>
	/// <p>Clay - Flesh of the earth. Used mostly for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Clay</name>
	Mat_Raw_Clay = 35,

	/// <summary>
	/// <p>Leather - Used for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Leather</name>
	Mat_Raw_Leather = 36,

	/// <summary>
	/// <p>Plant Fiber - Used for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Plant Fibre</name>
	Mat_Raw_Plant_Fibre = 37,

	/// <summary>
	/// <p>Reed - Used for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Reeds</name>
	Mat_Raw_Reeds = 38,

	/// <summary>
	/// <p>Resin - Used for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Resin</name>
	Mat_Raw_Resin = 39,

	/// <summary>
	/// <p>Scales - Durable fish skin, richly infused with copper. Used for crafting.</p>
	/// <p><b>Obtained at:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Scales</name>
	Mat_Raw_Scales = 40,

	/// <summary>
	/// Sparkdew - Charged rainwater. Extremely useful, and dangerous at the same time. Obtained by: {0}
	/// </summary>
	/// <name>[Mat Raw] Sparkdew</name>
	Mat_Raw_Sparkdew = 41,

	/// <summary>
	/// <p>Stone - Bones of the earth. Used mostly for crafting.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Stone</name>
	Mat_Raw_Stone = 42,

	/// <summary>
	/// <p>Wood - An abundant, yet crucial resource.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Mat Raw] Wood</name>
	Mat_Raw_Wood = 43,

	/// <summary>
	/// <p>Copper Bars - Refined copper ore, used for crafting.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Metal] Copper Bar</name>
	Metal_Copper_Bar = 44,

	/// <summary>
	/// <p>Copper Ore - A soft and malleable metal.</p>
	/// <p><b>Obtained in:</b> {0}</p>
	/// </summary>
	/// <name>[Metal] Copper Ore</name>
	Metal_Copper_Ore = 45,

	/// <summary>
	/// <p>Crystalized Dew - Crystalized rain essence.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Metal] Crystalized Dew</name>
	Metal_Crystalized_Dew = 46,

	/// <summary>
	/// <p>Ale - Used for leisure at: {1}, by {2}. Villagers with a satisfied need for leisure have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Ale</name>
	Needs_Ale = 47,

	/// <summary>
	/// <p>Boots - Sturdy and waterproof. Used as clothing by: {2}. Grants a movement speed bonus to villagers wearing them.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Boots</name>
	Needs_Boots = 48,

	/// <summary>
	/// <p>Coats - Reliable protection from the rain. Used as clothing by: {2}. Grants an additional Resolve bonus during the storm.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Coats</name>
	Needs_Coats = 49,

	/// <summary>
	/// <p>Incense - Used for religion at: {1}, by {2}. Villagers with a satisfied need for religion have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Incense</name>
	Needs_Incense = 50,

	/// <summary>
	/// <p>Scrolls - Used for education at: {1}, by: {2}. Villagers with a satisfied need for education have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Scrolls</name>
	Needs_Scrolls = 51,

	/// <summary>
	/// Scrolls - Luxury goods used for Education. Unavailable in this tutorial. <u>Select the icon</u> to change to another resource.
	/// </summary>
	/// <name>[Needs] Scrolls - tutorial</name>
	Needs_Scrolls_Tutorial = 52,

	/// <summary>
	/// <p>Tea - Used for treatment at: {1}, by: {2}. Villagers with a satisfied need for treatment have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Tea</name>
	Needs_Tea = 53,

	/// <summary>
	/// <p>Training Gear - Used for brawling at: {1}, by: {2}. Villagers with a satisfied need for brawling have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Training Gear</name>
	Needs_Training_Gear = 54,

	/// <summary>
	/// <p>Wine - Used for luxury at: {1}, by: {2}. Villagers with a satisfied need for luxury have a higher chance of producing double yields.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Needs] Wine</name>
	Needs_Wine = 55,

	/// <summary>
	/// Ground Bait - Bait made from Packs of Crops. Used in fishing huts to double fishing yields.
	/// </summary>
	/// <name>[Other] Fishing Bait</name>
	Other_Fishing_Bait = 56,

	/// <summary>
	/// <p>Pack of Building Materials - Building materials packaged for delivery, used to fulfill orders, upgrade buildings, and trade.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Packs] Pack of Building Materials</name>
	Packs_Pack_Of_Building_Materials = 57,

	/// <summary>
	/// <p>Pack of Crops - Crops packaged for delivery, used to fulfill orders and trade.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Packs] Pack of Crops</name>
	Packs_Pack_Of_Crops = 58,

	/// <summary>
	/// <p>Pack of Luxury Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Packs] Pack of Luxury Goods</name>
	Packs_Pack_Of_Luxury_Goods = 59,

	/// <summary>
	/// <p>Pack of Provisions - Provisions necessary for sending caravans into the wild. Used to fulfill orders, trade, and pay for trade routes.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Packs] Pack of Provisions</name>
	Packs_Pack_Of_Provisions = 60,

	/// <summary>
	/// <p>Pack of Trade Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Packs] Pack of Trade Goods</name>
	Packs_Pack_Of_Trade_Goods = 61,

	/// <summary></summary>
	/// <name>TEMP_Meta_Exp</name>
	TEMP_Meta_Exp = 62,

	/// <summary>
	/// <p>Tools - Used primarily for exploration, opening caches, and completing difficult events.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Tools] Simple Tools</name>
	Tools_Simple_Tools = 63,

	/// <summary>
	/// Amber - A widely accepted currency in the kingdom. Crystalized tree blood... fitting.
	/// </summary>
	/// <name>[Valuable] Amber</name>
	Valuable_Amber = 64,

	/// <summary>
	/// Ancient Tablet - Valuable sources of knowledge, highly sought after by traders and the Queen herself. They can be found in Dangerous ("dangerous") or Forbidden Glades ("forbidden").
	/// </summary>
	/// <name>[Valuable] Ancient Tablet</name>
	Valuable_Ancient_Tablet = 65,

	/// <summary>
	/// Thunderblight Shard - A rare, lightning-infused crystal used in the creation of cornerstones. Obtained by mining in the Ashen Thicket.
	/// </summary>
	/// <name>[Valuable] Thunderblight Shard</name>
	Valuable_Thunderblight_Shard = 66,

	/// <summary>
	/// <p>Barrels - Used for crafting.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Vessel] Barrels</name>
	Vessel_Barrels = 67,

	/// <summary>
	/// <p>Pottery - Used for crafting.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Vessel] Pottery</name>
	Vessel_Pottery = 68,

	/// <summary>
	/// <p>Waterskins - Used for crafting.</p>
	/// <p><b>Produced in:</b> {0}</p>
	/// </summary>
	/// <name>[Vessel] Waterskin</name>
	Vessel_Waterskin = 69,

	/// <summary>
	/// Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
	/// </summary>
	/// <name>[Water] Clearance Water</name>
	Water_Clearance_Water = 70,

	/// <summary>
	/// Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
	/// </summary>
	/// <name>[Water] Drizzle Water</name>
	Water_Drizzle_Water = 71,

	/// <summary>
	/// Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.
	/// </summary>
	/// <name>[Water] Storm Water</name>
	Water_Storm_Water = 72,



    /// <summary>
    /// The total number of vanilla GoodsTypes in the game.
    /// </summary>
	MAX = 72
}

/// <summary>
/// Extension methods for the GoodsTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class GoodsTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded GoodsTypes.
	/// </summary>
	public static GoodsTypes[] All()
	{
		GoodsTypes[] all = new GoodsTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every GoodsTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return GoodsTypes._Meta_Artifacts in the enum and log an error.
	/// </summary>
	public static string ToName(this GoodsTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of GoodsTypes: " + type);
		return TypeToInternalName[GoodsTypes._Meta_Artifacts];
	}
	
	/// <summary>
	/// Returns a GoodsTypes associated with the given name.
	/// Every GoodsTypes should have a unique name as to distinguish it from others.
	/// If no GoodsTypes is found, it will return GoodsTypes.Unknown and log a warning.
	/// </summary>
	public static GoodsTypes ToGoodsTypes(this string name)
	{
		foreach (KeyValuePair<GoodsTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find GoodsTypes with name: " + name + "\n" + Environment.StackTrace);
		return GoodsTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a GoodModel associated with the given name.
	/// GoodModel contain all the data that will be used in the game.
	/// Every GoodModel should have a unique name as to distinguish it from others.
	/// If no GoodModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.GoodModel ToGoodModel(this string name)
	{
		Eremite.Model.GoodModel model = SO.Settings.Goods.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find GoodModel for GoodsTypes with name: " + name);
		return null;
	}

    /// <summary>
    /// Returns a GoodModel associated with the given GoodsTypes.
    /// GoodModel contain all the data that will be used in the game.
    /// Every GoodModel should have a unique name as to distinguish it from others.
    /// If no GoodModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.GoodModel ToGoodModel(this GoodsTypes types)
	{
		return types.ToName().ToGoodModel();
	}
	
	/// <summary>
	/// Returns an array of GoodModel associated with the given GoodsTypes.
	/// GoodModel contain all the data that will be used in the game.
	/// Every GoodModel should have a unique name as to distinguish it from others.
	/// If a GoodModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.GoodModel[] ToGoodModelArray(this IEnumerable<GoodsTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.GoodModel[] array = new Eremite.Model.GoodModel[count];
		int i = 0;
		foreach (GoodsTypes element in collection)
		{
			array[i++] = element.ToGoodModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoodModel associated with the given GoodsTypes.
	/// GoodModel contain all the data that will be used in the game.
	/// Every GoodModel should have a unique name as to distinguish it from others.
	/// If a GoodModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.GoodModel[] ToGoodModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.GoodModel[] array = new Eremite.Model.GoodModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGoodModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoodModel associated with the given GoodsTypes.
	/// GoodModel contain all the data that will be used in the game.
	/// Every GoodModel should have a unique name as to distinguish it from others.
	/// If a GoodModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.GoodModel[] ToGoodModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.GoodModel>.Get(out List<Eremite.Model.GoodModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.GoodModel model = element.ToGoodModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of GoodModel associated with the given GoodsTypes.
	/// GoodModel contain all the data that will be used in the game.
	/// Every GoodModel should have a unique name as to distinguish it from others.
	/// If a GoodModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.GoodModel[] ToGoodModelArrayNoNulls(this IEnumerable<GoodsTypes> collection)
	{
		using(ListPool<Eremite.Model.GoodModel>.Get(out List<Eremite.Model.GoodModel> list))
		{
			foreach (GoodsTypes element in collection)
			{
				Eremite.Model.GoodModel model = element.ToGoodModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<GoodsTypes, string> TypeToInternalName = new()
	{
		{ GoodsTypes._Meta_Artifacts, "_Meta Artifacts" },                                     // Artifacts - The remnants of a long-forgotten world. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes._Meta_Food_Stockpiles, "_Meta Food Stockpiles" },                         // Food Stockpiles - A basic currency of the realm. Earned by completing settlements. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes._Meta_Machinery, "_Meta Machinery" },                                     // Machinery - Rainpunk technology ripped from the past. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes.Blight_Fuel, "Blight Fuel" },                                             // Purging Fire - A unique resource used by Blight Fighters to burn down Blightrot Cysts.     <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Coal, "[Crafting] Coal" },                                       // Coal - Efficient fuel.     <b>Obtained in:</b> {0}
		{ GoodsTypes.Crafting_Dye, "[Crafting] Dye" },                                         // Dye - Used for crafting.    <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Flour, "[Crafting] Flour" },                                     // Flour - Used for cooking.    <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Oil, "[Crafting] Oil" },                                         // Oil - Efficient fuel.     <b>Obtained in:</b> {0}
		{ GoodsTypes.Crafting_Salt, "[Crafting] Salt" },                                       // Salt - A valuable and highly absorbent mineral.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Crafting_Sea_Marrow, "[Crafting] Sea Marrow" },                           // Sea Marrow - Efficient fuel.     <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Processed_Biscuits, "[Food Processed] Biscuits" },                   // Biscuits - Tasty and crunchy. Liked by: {2}. Villagers with a satisfied need for biscuits have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Jerky, "[Food Processed] Jerky" },                         // Jerky - Preserved, dried meat. Liked by: {2}. Villagers with a satisfied need for jerky have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Paste, "[Food Processed] Paste" },                         // Paste - A smooth paste, no chewing required. Liked by: {2}. Villagers with a satisfied need for paste have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Pickled_Goods, "[Food Processed] Pickled Goods" },         // Pickled Goods - A Beaver specialty. Liked by: {2}. Villagers with a satisfied need for pickled goods have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Pie, "[Food Processed] Pie" },                             // Pie - A savory delicacy. Liked by: {2}. Villagers with a satisfied need for pie have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Porridge, "[Food Processed] Porridge" },                   // Porridge - A nutritious and warming meal. Liked by: {2}. Villagers with a satisfied need for porridge have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Skewers, "[Food Processed] Skewers" },                     // Skewers - A Lizard specialty. Liked by: {2}. Villagers with a satisfied need for skewers have an increased chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Raw_Berries, "[Food Raw] Berries" },                                 // Berries - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Eggs, "[Food Raw] Eggs" },                                       // Eggs - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Fish, "[Food Raw] Fish" },                                       // Fish - Plenty of them in the sea. A common food source.  <b>Obtained at:</b> {0}
		{ GoodsTypes.Food_Raw_Grain, "[Food Raw] Grain" },                                     // Grain - Isn't eaten raw, but can be processed.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Herbs, "[Food Raw] Herbs" },                                     // Herbs - Isn't eaten raw, but can be processed.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Insects, "[Food Raw] Insects" },                                 // Insects - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Meat, "[Food Raw] Meat" },                                       // Meat - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Mushrooms, "[Food Raw] Mushrooms" },                             // Mushrooms - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Roots, "[Food Raw] Roots" },                                     // Roots - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Vegetables, "[Food Raw] Vegetables" },                           // Vegetables - Common food source.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Hearth_Parts, "Hearth Parts" },                                           // Wildfire Essence - A sentient flame trapped in a bottle. This rare material is used to light the Holy Flame in Hearths. Can be acquired from orders, Glade Events, or traders.
		{ GoodsTypes.Mat_Processed_Bricks, "[Mat Processed] Bricks" },                         // Bricks - Mostly used for construction.    <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Fabric, "[Mat Processed] Fabric" },                         // Fabric - Used for construction or production of clothes.    <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Parts, "[Mat Processed] Parts" },                           // Parts - Rare items used for construction. Difficult to produce in this harsh environment.
		{ GoodsTypes.Mat_Processed_Pipe, "[Mat Processed] Pipe" },                             // Pipes - Used to install Rainpunk Engines in production buildings and build Geyser Pumps.    <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Planks, "[Mat Processed] Planks" },                         // Planks - Mostly used for construction.    <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Raw_Algae, "[Mat Raw] Algae" },                                       // Algae - Slimy, tough fibers fished from murky waters. Used for crafting.  <b>Obtained at:</b> {0}
		{ GoodsTypes.Mat_Raw_Clay, "[Mat Raw] Clay" },                                         // Clay - Flesh of the earth. Used mostly for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Leather, "[Mat Raw] Leather" },                                   // Leather - Used for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Plant_Fibre, "[Mat Raw] Plant Fibre" },                           // Plant Fiber - Used for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Reeds, "[Mat Raw] Reeds" },                                       // Reed - Used for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Resin, "[Mat Raw] Resin" },                                       // Resin - Used for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Scales, "[Mat Raw] Scales" },                                     // Scales - Durable fish skin, richly infused with copper. Used for crafting.  <b>Obtained at:</b> {0}
		{ GoodsTypes.Mat_Raw_Sparkdew, "[Mat Raw] Sparkdew" },                                 // Sparkdew - Charged rainwater. Extremely useful, and dangerous at the same time. Obtained by: {0}
		{ GoodsTypes.Mat_Raw_Stone, "[Mat Raw] Stone" },                                       // Stone - Bones of the earth. Used mostly for crafting.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Wood, "[Mat Raw] Wood" },                                         // Wood - An abundant, yet crucial resource.     <b>Obtained in:</b> {0}
		{ GoodsTypes.Metal_Copper_Bar, "[Metal] Copper Bar" },                                 // Copper Bars - Refined copper ore, used for crafting.    <b>Produced in:</b> {0}
		{ GoodsTypes.Metal_Copper_Ore, "[Metal] Copper Ore" },                                 // Copper Ore - A soft and malleable metal.    <b>Obtained in:</b> {0}
		{ GoodsTypes.Metal_Crystalized_Dew, "[Metal] Crystalized Dew" },                       // Crystalized Dew - Crystalized rain essence.    <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Ale, "[Needs] Ale" },                                               // Ale - Used for leisure at: {1}, by {2}. Villagers with a satisfied need for leisure have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Boots, "[Needs] Boots" },                                           // Boots - Sturdy and waterproof. Used as clothing by: {2}. Grants a movement speed bonus to villagers wearing them.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Coats, "[Needs] Coats" },                                           // Coats - Reliable protection from the rain. Used as clothing by: {2}. Grants an additional Resolve bonus during the storm.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Incense, "[Needs] Incense" },                                       // Incense - Used for religion at: {1}, by {2}. Villagers with a satisfied need for religion have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Scrolls, "[Needs] Scrolls" },                                       // Scrolls - Used for education at: {1}, by: {2}. Villagers with a satisfied need for education have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Scrolls_Tutorial, "[Needs] Scrolls - tutorial" },                   // Scrolls - Luxury goods used for Education. Unavailable in this tutorial. <u>Select the icon</u> to change to another resource.
		{ GoodsTypes.Needs_Tea, "[Needs] Tea" },                                               // Tea - Used for treatment at: {1}, by: {2}. Villagers with a satisfied need for treatment have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Training_Gear, "[Needs] Training Gear" },                           // Training Gear - Used for brawling at: {1}, by: {2}. Villagers with a satisfied need for brawling have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Wine, "[Needs] Wine" },                                             // Wine - Used for luxury at: {1}, by: {2}. Villagers with a satisfied need for luxury have a higher chance of producing double yields.  <b>Produced in:</b> {0}
		{ GoodsTypes.Other_Fishing_Bait, "[Other] Fishing Bait" },                             // Ground Bait - Bait made from Packs of Crops. Used in fishing huts to double fishing yields.
		{ GoodsTypes.Packs_Pack_Of_Building_Materials, "[Packs] Pack of Building Materials" }, // Pack of Building Materials - Building materials packaged for delivery, used to fulfill orders, upgrade buildings, and trade.    <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Crops, "[Packs] Pack of Crops" },                           // Pack of Crops - Crops packaged for delivery, used to fulfill orders and trade.    <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Luxury_Goods, "[Packs] Pack of Luxury Goods" },             // Pack of Luxury Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.    <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Provisions, "[Packs] Pack of Provisions" },                 // Pack of Provisions - Provisions necessary for sending caravans into the wild. Used to fulfill orders, trade, and pay for trade routes.    <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Trade_Goods, "[Packs] Pack of Trade Goods" },               // Pack of Trade Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.    <b>Produced in:</b> {0}
		{ GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp" }, 
		{ GoodsTypes.Tools_Simple_Tools, "[Tools] Simple Tools" },                             // Tools - Used primarily for exploration, opening caches, and completing difficult events.    <b>Produced in:</b> {0}
		{ GoodsTypes.Valuable_Amber, "[Valuable] Amber" },                                     // Amber - A widely accepted currency in the kingdom. Crystalized tree blood... fitting.
		{ GoodsTypes.Valuable_Ancient_Tablet, "[Valuable] Ancient Tablet" },                   // Ancient Tablet - Valuable sources of knowledge, highly sought after by traders and the Queen herself. They can be found in Dangerous ("dangerous") or Forbidden Glades ("forbidden").
		{ GoodsTypes.Valuable_Thunderblight_Shard, "[Valuable] Thunderblight Shard" },         // Thunderblight Shard - A rare, lightning-infused crystal used in the creation of cornerstones. Obtained by mining in the Ashen Thicket.
		{ GoodsTypes.Vessel_Barrels, "[Vessel] Barrels" },                                     // Barrels - Used for crafting.    <b>Produced in:</b> {0}
		{ GoodsTypes.Vessel_Pottery, "[Vessel] Pottery" },                                     // Pottery - Used for crafting.    <b>Produced in:</b> {0}
		{ GoodsTypes.Vessel_Waterskin, "[Vessel] Waterskin" },                                 // Waterskins - Used for crafting.    <b>Produced in:</b> {0}
		{ GoodsTypes.Water_Clearance_Water, "[Water] Clearance Water" },                       // Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
		{ GoodsTypes.Water_Drizzle_Water, "[Water] Drizzle Water" },                           // Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
		{ GoodsTypes.Water_Storm_Water, "[Water] Storm Water" },                               // Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.

	};
}
