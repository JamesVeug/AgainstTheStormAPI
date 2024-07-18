using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum GoodsTypes
{
    Unknown = -1,
    None,
	_Meta_Artifacts,                  // Artifacts - The remnants of a long-forgotten world. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
	_Meta_Food_Stockpiles,            // Food Stockpiles - A basic currency of the realm. Earned by completing settlements. Can be used to purchase upgrades in the Smoldering City.
	_Meta_Machinery,                  // Machinery - Rainpunk technology ripped from the past. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
	Blight_Fuel,                      // Purging Fire - A unique resource used by Blight Fighters to burn down Blightrot Cysts.   <b>Produced in:</b> {0}
	Crafting_Coal,                    // Coal - Efficient fuel.   <b>Obtained in:</b> {0}
	Crafting_Flour,                   // Flour - Used for cooking.  <b>Produced in:</b> {0}
	Crafting_Oil,                     // Oil - Efficient fuel.   <b>Obtained in:</b> {0}
	Crafting_Pigment,                 // Pigment - Used for crafting.  <b>Produced in:</b> {0}
	Crafting_Sea_Marrow,              // Sea Marrow - Efficient fuel.   <b>Obtained in:</b> {0}
	Food_Processed_Biscuits,          // Biscuits - Tasty and crunchy. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Processed_Jerky,             // Jerky - Preserved, dried meat. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Processed_Pickled_Goods,     // Pickled Goods - A Beaver specialty. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Processed_Pie,               // Pie - A Human specialty. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Processed_Porridge,          // Porridge - A nutritious and warming meal. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Processed_Skewers,           // Skewers - A Lizard specialty. Liked by: {2}.  <b>Produced in:</b> {0}
	Food_Raw_Berries,                 // Berries - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Eggs,                    // Eggs - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Grain,                   // Grain - Isn't eaten raw, but can be processed.  <b>Obtained in:</b> {0}
	Food_Raw_Herbs,                   // Herbs - Isn't eaten raw, but can be processed.  <b>Obtained in:</b> {0}
	Food_Raw_Insects,                 // Insects - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Meat,                    // Meat - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Mushrooms,               // Mushrooms - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Roots,                   // Roots - Common food source.  <b>Obtained in:</b> {0}
	Food_Raw_Vegetables,              // Vegetables - Common food source.  <b>Obtained in:</b> {0}
	Hearth_Parts,                     // Wildfire Essence - A sentient flame trapped in a bottle. This rare material is used to light the Holy Flame in Hearths. Can be acquired from orders, Glade Events, or traders.
	Mat_Processed_Bricks,             // Bricks - Mostly used for construction.  <b>Produced in:</b> {0}
	Mat_Processed_Fabric,             // Fabric - Used for construction or production of clothes.  <b>Produced in:</b> {0}
	Mat_Processed_Parts,              // Parts - Rare elements used in camp construction. Difficult to produce in this harsh environment.
	Mat_Processed_Pipe,               // Pipes - Used to install Rainpunk Engines in production buildings and build Geyser Pumps.  <b>Produced in:</b> {0}
	Mat_Processed_Planks,             // Planks - Mostly used for construction.  <b>Produced in:</b> {0}
	Mat_Raw_Clay,                     // Clay - Flesh of the earth. Used mostly for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Leather,                  // Leather - Used for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Plant_Fibre,              // Plant Fiber - Used for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Reeds,                    // Reed - Used for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Resin,                    // Resin - Used for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Sparkdew,                 // Sparkdew - Charged rainwater. Extremely useful, and dangerous at the same time. Obtained by: {0}
	Mat_Raw_Stone,                    // Stone - Bones of the earth. Used mostly for crafting.  <b>Obtained in:</b> {0}
	Mat_Raw_Wood,                     // Wood - An abundant, yet crucial resource.   <b>Obtained in:</b> {0}
	Metal_Copper_Bar,                 // Copper Bars - Refined copper ore, used for crafting.  <b>Produced in:</b> {0}
	Metal_Copper_Ore,                 // Copper Ore - A soft and malleable metal.  <b>Obtained in:</b> {0}
	Metal_Crystalized_Dew,            // Crystalized Dew - Crystalized rain essence.  <b>Produced in:</b> {0}
	Needs_Ale,                        // Ale - Used for leisure at: {1}, by {2}.  <b>Produced in:</b> {0}
	Needs_Coats,                      // Coats - Used as clothing by: {2}.   <b>Produced in:</b> {0}
	Needs_Incense,                    // Incense - Used for religion at: {1}, by {2}.  <b>Produced in:</b> {0}
	Needs_Scrolls,                    // Scrolls - Used for education at: {1}, by: {2}.  <b>Produced in:</b> {0}
	Needs_Scrolls_Tutorial,           // Scrolls - Luxury goods used for Education. Unavailable in this tutorial. <u>Select the icon</u> to change to another resource.
	Needs_Tea,                        // Tea - A soothing infusion made out of rainwater, that must be kept in a metal pot. Used for treatment at: {1}, by: {2}.  <b>Produced in:</b> {0}
	Needs_Training_Gear,              // Training Gear - Used for brawling at: {1}, by: {2}.  <b>Produced in:</b> {0}
	Needs_Wine,                       // Wine - Used for luxury at: {1}, by: {2}.  <b>Produced in:</b> {0}
	Packs_Pack_Of_Building_Materials, // Pack of Building Materials - Building materials packaged for delivery, used to fulfill orders, upgrade buildings, and trade.  <b>Produced in:</b> {0}
	Packs_Pack_Of_Crops,              // Pack of Crops - Crops packaged for delivery, used to fulfill orders and trade.  <b>Produced in:</b> {0}
	Packs_Pack_Of_Luxury_Goods,       // Pack of Luxury Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.  <b>Produced in:</b> {0}
	Packs_Pack_Of_Provisions,         // Pack of Provisions - Provisions necessary for sending caravans into the wild. Used to fulfill orders, trade, and pay for trade routes.  <b>Produced in:</b> {0}
	Packs_Pack_Of_Trade_Goods,        // Pack of Trade Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.  <b>Produced in:</b> {0}
	TEMP_Meta_Exp, 
	Tools_Simple_Tools,               // Tools - Used primarily for exploration, opening caches, and completing difficult events.  <b>Produced in:</b> {0}
	Valuable_Amber,                   // Amber - A widely accepted currency in the kingdom. Crystalized tree blood... fitting.
	Valuable_Ancient_Tablet,          // Ancient Tablet - Valuable sources of knowledge, highly sought after by traders and the Queen herself. They can be found in Dangerous (<sprite name="dangerous">) or Forbidden Glades (<sprite name="forbidden">).
	Vessel_Barrels,                   // Barrels - Used for crafting.  <b>Produced in:</b> {0}
	Vessel_Pottery,                   // Pottery - Used for crafting.  <b>Produced in:</b> {0}
	Vessel_Waterskin,                 // Waterskins - Used for crafting.  <b>Produced in:</b> {0}
	Water_Clearance_Water,            // Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
	Water_Drizzle_Water,              // Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
	Water_Storm_Water,                // Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.


    MAX = 64
}

public static class GoodsTypesExtensions
{
    private static GoodsTypes[] s_All = null;
	public static GoodsTypes[] All()
	{
		if (s_All == null)
        {
            s_All = new GoodsTypes[64];
            for (int i = 0; i < 64; i++)
            {
                s_All[i] = (GoodsTypes)(i+1);
            }
        }
        return s_All;
	}
	
	public static string ToName(this GoodsTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of GoodsTypes: " + type);
		return TypeToInternalName[GoodsTypes._Meta_Artifacts];
	}
	
	public static GoodModel ToGoodModel(this string name)
    {
        GoodModel model = SO.Settings.Goods.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find GoodModel for GoodsTypes with name: " + name);
        return null;
    }
	
	public static GoodsTypes ToGoodsTypes(this string name)
	{
		foreach (KeyValuePair<GoodsTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		return GoodsTypes.Unknown;
	}

	public static GoodModel ToGoodModel(this GoodsTypes types)
	{
		return types.ToName().ToGoodModel();
	}
	
	public static GoodModel[] ToGoodModelArray(this IEnumerable<GoodsTypes> collection)
    {
        int count = collection.Count();
        GoodModel[] array = new GoodModel[count];
        int i = 0;
        foreach (GoodsTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.Goods.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<GoodsTypes, string> TypeToInternalName = new()
	{
		{ GoodsTypes._Meta_Artifacts, "_Meta Artifacts" },                                     // Artifacts - The remnants of a long-forgotten world. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes._Meta_Food_Stockpiles, "_Meta Food Stockpiles" },                         // Food Stockpiles - A basic currency of the realm. Earned by completing settlements. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes._Meta_Machinery, "_Meta Machinery" },                                     // Machinery - Rainpunk technology ripped from the past. Earned by completing world events, modifiers, seals, and daily expeditions. Can be used to purchase upgrades in the Smoldering City.
		{ GoodsTypes.Blight_Fuel, "Blight Fuel" },                                             // Purging Fire - A unique resource used by Blight Fighters to burn down Blightrot Cysts.   <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Coal, "[Crafting] Coal" },                                       // Coal - Efficient fuel.   <b>Obtained in:</b> {0}
		{ GoodsTypes.Crafting_Flour, "[Crafting] Flour" },                                     // Flour - Used for cooking.  <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Oil, "[Crafting] Oil" },                                         // Oil - Efficient fuel.   <b>Obtained in:</b> {0}
		{ GoodsTypes.Crafting_Pigment, "[Crafting] Pigment" },                                 // Pigment - Used for crafting.  <b>Produced in:</b> {0}
		{ GoodsTypes.Crafting_Sea_Marrow, "[Crafting] Sea Marrow" },                           // Sea Marrow - Efficient fuel.   <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Processed_Biscuits, "[Food Processed] Biscuits" },                   // Biscuits - Tasty and crunchy. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Jerky, "[Food Processed] Jerky" },                         // Jerky - Preserved, dried meat. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Pickled_Goods, "[Food Processed] Pickled Goods" },         // Pickled Goods - A Beaver specialty. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Pie, "[Food Processed] Pie" },                             // Pie - A Human specialty. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Porridge, "[Food Processed] Porridge" },                   // Porridge - A nutritious and warming meal. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Processed_Skewers, "[Food Processed] Skewers" },                     // Skewers - A Lizard specialty. Liked by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Food_Raw_Berries, "[Food Raw] Berries" },                                 // Berries - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Eggs, "[Food Raw] Eggs" },                                       // Eggs - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Grain, "[Food Raw] Grain" },                                     // Grain - Isn't eaten raw, but can be processed.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Herbs, "[Food Raw] Herbs" },                                     // Herbs - Isn't eaten raw, but can be processed.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Insects, "[Food Raw] Insects" },                                 // Insects - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Meat, "[Food Raw] Meat" },                                       // Meat - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Mushrooms, "[Food Raw] Mushrooms" },                             // Mushrooms - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Roots, "[Food Raw] Roots" },                                     // Roots - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Food_Raw_Vegetables, "[Food Raw] Vegetables" },                           // Vegetables - Common food source.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Hearth_Parts, "Hearth Parts" },                                           // Wildfire Essence - A sentient flame trapped in a bottle. This rare material is used to light the Holy Flame in Hearths. Can be acquired from orders, Glade Events, or traders.
		{ GoodsTypes.Mat_Processed_Bricks, "[Mat Processed] Bricks" },                         // Bricks - Mostly used for construction.  <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Fabric, "[Mat Processed] Fabric" },                         // Fabric - Used for construction or production of clothes.  <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Parts, "[Mat Processed] Parts" },                           // Parts - Rare elements used in camp construction. Difficult to produce in this harsh environment.
		{ GoodsTypes.Mat_Processed_Pipe, "[Mat Processed] Pipe" },                             // Pipes - Used to install Rainpunk Engines in production buildings and build Geyser Pumps.  <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Processed_Planks, "[Mat Processed] Planks" },                         // Planks - Mostly used for construction.  <b>Produced in:</b> {0}
		{ GoodsTypes.Mat_Raw_Clay, "[Mat Raw] Clay" },                                         // Clay - Flesh of the earth. Used mostly for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Leather, "[Mat Raw] Leather" },                                   // Leather - Used for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Plant_Fibre, "[Mat Raw] Plant Fibre" },                           // Plant Fiber - Used for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Reeds, "[Mat Raw] Reeds" },                                       // Reed - Used for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Resin, "[Mat Raw] Resin" },                                       // Resin - Used for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Sparkdew, "[Mat Raw] Sparkdew" },                                 // Sparkdew - Charged rainwater. Extremely useful, and dangerous at the same time. Obtained by: {0}
		{ GoodsTypes.Mat_Raw_Stone, "[Mat Raw] Stone" },                                       // Stone - Bones of the earth. Used mostly for crafting.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Mat_Raw_Wood, "[Mat Raw] Wood" },                                         // Wood - An abundant, yet crucial resource.   <b>Obtained in:</b> {0}
		{ GoodsTypes.Metal_Copper_Bar, "[Metal] Copper Bar" },                                 // Copper Bars - Refined copper ore, used for crafting.  <b>Produced in:</b> {0}
		{ GoodsTypes.Metal_Copper_Ore, "[Metal] Copper Ore" },                                 // Copper Ore - A soft and malleable metal.  <b>Obtained in:</b> {0}
		{ GoodsTypes.Metal_Crystalized_Dew, "[Metal] Crystalized Dew" },                       // Crystalized Dew - Crystalized rain essence.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Ale, "[Needs] Ale" },                                               // Ale - Used for leisure at: {1}, by {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Coats, "[Needs] Coats" },                                           // Coats - Used as clothing by: {2}.   <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Incense, "[Needs] Incense" },                                       // Incense - Used for religion at: {1}, by {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Scrolls, "[Needs] Scrolls" },                                       // Scrolls - Used for education at: {1}, by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Scrolls_Tutorial, "[Needs] Scrolls - tutorial" },                   // Scrolls - Luxury goods used for Education. Unavailable in this tutorial. <u>Select the icon</u> to change to another resource.
		{ GoodsTypes.Needs_Tea, "[Needs] Tea" },                                               // Tea - A soothing infusion made out of rainwater, that must be kept in a metal pot. Used for treatment at: {1}, by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Training_Gear, "[Needs] Training Gear" },                           // Training Gear - Used for brawling at: {1}, by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Needs_Wine, "[Needs] Wine" },                                             // Wine - Used for luxury at: {1}, by: {2}.  <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Building_Materials, "[Packs] Pack of Building Materials" }, // Pack of Building Materials - Building materials packaged for delivery, used to fulfill orders, upgrade buildings, and trade.  <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Crops, "[Packs] Pack of Crops" },                           // Pack of Crops - Crops packaged for delivery, used to fulfill orders and trade.  <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Luxury_Goods, "[Packs] Pack of Luxury Goods" },             // Pack of Luxury Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.  <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Provisions, "[Packs] Pack of Provisions" },                 // Pack of Provisions - Provisions necessary for sending caravans into the wild. Used to fulfill orders, trade, and pay for trade routes.  <b>Produced in:</b> {0}
		{ GoodsTypes.Packs_Pack_Of_Trade_Goods, "[Packs] Pack of Trade Goods" },               // Pack of Trade Goods - Goods highly sought after by traders. Can be used to fulfill orders, or sold for a large profit.  <b>Produced in:</b> {0}
		{ GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp" }, 
		{ GoodsTypes.Tools_Simple_Tools, "[Tools] Simple Tools" },                             // Tools - Used primarily for exploration, opening caches, and completing difficult events.  <b>Produced in:</b> {0}
		{ GoodsTypes.Valuable_Amber, "[Valuable] Amber" },                                     // Amber - A widely accepted currency in the kingdom. Crystalized tree blood... fitting.
		{ GoodsTypes.Valuable_Ancient_Tablet, "[Valuable] Ancient Tablet" },                   // Ancient Tablet - Valuable sources of knowledge, highly sought after by traders and the Queen herself. They can be found in Dangerous (<sprite name="dangerous">) or Forbidden Glades (<sprite name="forbidden">).
		{ GoodsTypes.Vessel_Barrels, "[Vessel] Barrels" },                                     // Barrels - Used for crafting.  <b>Produced in:</b> {0}
		{ GoodsTypes.Vessel_Pottery, "[Vessel] Pottery" },                                     // Pottery - Used for crafting.  <b>Produced in:</b> {0}
		{ GoodsTypes.Vessel_Waterskin, "[Vessel] Waterskin" },                                 // Waterskins - Used for crafting.  <b>Produced in:</b> {0}
		{ GoodsTypes.Water_Clearance_Water, "[Water] Clearance Water" },                       // Clearance Water - Highly concentrated yellow clearance rainwater. Used to power Rain Engines in crafting-oriented buildings.
		{ GoodsTypes.Water_Drizzle_Water, "[Water] Drizzle Water" },                           // Drizzle Water - Highly concentrated green drizzle rainwater. Used to power Rain Engines in food-oriented buildings.
		{ GoodsTypes.Water_Storm_Water, "[Water] Storm Water" },                               // Storm Water - Highly concentrated blue storm rainwater. Used to power Rain Engines in industry-oriented buildings.

	};
}
