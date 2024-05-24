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
	_Meta_Artifacts,                  // Artifacts
	_Meta_Food_Stockpiles,            // Food Stockpiles
	_Meta_Machinery,                  // Machinery
	API_ExampleMod_Borgor,            // Borgor
	API_ExampleMod_Cola,              // Cola
	API_ExampleMod_Diamonds,          // Diamonds
	API_ExampleMod_Fries,             // Fries
	API_ExampleMod_Kiwi_Fruit,        // Kiwi Fruit
	API_ExampleMod_LPG,               // LPG
	Blight_Fuel,                      // Purging Fire
	Crafting_Coal,                    // Coal
	Crafting_Flour,                   // Flour
	Crafting_Oil,                     // Oil
	Crafting_Pigment,                 // Pigment
	Crafting_Sea_Marrow,              // Sea Marrow
	Food_Processed_Biscuits,          // Biscuits
	Food_Processed_Jerky,             // Jerky
	Food_Processed_Pickled_Goods,     // Pickled Goods
	Food_Processed_Pie,               // Pie
	Food_Processed_Porridge,          // Porridge
	Food_Processed_Skewers,           // Skewers
	Food_Raw_Berries,                 // Berries
	Food_Raw_Eggs,                    // Eggs
	Food_Raw_Grain,                   // Grain
	Food_Raw_Herbs,                   // Herbs
	Food_Raw_Insects,                 // Insects
	Food_Raw_Meat,                    // Meat
	Food_Raw_Mushrooms,               // Mushrooms
	Food_Raw_Roots,                   // Roots
	Food_Raw_Vegetables,              // Vegetables
	Hearth_Parts,                     // Wildfire Essence
	Mat_Processed_Bricks,             // Bricks
	Mat_Processed_Fabric,             // Fabric
	Mat_Processed_Parts,              // Parts
	Mat_Processed_Pipe,               // Pipes
	Mat_Processed_Planks,             // Planks
	Mat_Raw_Clay,                     // Clay
	Mat_Raw_Leather,                  // Leather
	Mat_Raw_Plant_Fibre,              // Plant Fiber
	Mat_Raw_Reeds,                    // Reed
	Mat_Raw_Resin,                    // Resin
	Mat_Raw_Sparkdew,                 // Sparkdew
	Mat_Raw_Stone,                    // Stone
	Mat_Raw_Wood,                     // Wood
	Metal_Copper_Bar,                 // Copper Bars
	Metal_Copper_Ore,                 // Copper Ore
	Metal_Crystalized_Dew,            // Crystalized Dew
	Needs_Ale,                        // Ale
	Needs_Coats,                      // Coats
	Needs_Incense,                    // Incense
	Needs_Scrolls,                    // Scrolls
	Needs_Scrolls___Tutorial,         // Scrolls
	Needs_Tea,                        // Tea
	Needs_Training_Gear,              // Training Gear
	Needs_Wine,                       // Wine
	Packs_Pack_Of_Building_Materials, // Pack of Building Materials
	Packs_Pack_Of_Crops,              // Pack of Crops
	Packs_Pack_Of_Luxury_Goods,       // Pack of Luxury Goods
	Packs_Pack_Of_Provisions,         // Pack of Provisions
	Packs_Pack_Of_Trade_Goods,        // Pack of Trade Goods
	TEMP_Meta_Exp, 
	Tools_Simple_Tools,               // Tools
	Valuable_Amber,                   // Amber
	Valuable_Ancient_Tablet,          // Ancient Tablet
	Vessel_Barrels,                   // Barrels
	Vessel_Pottery,                   // Pottery
	Vessel_Waterskin,                 // Waterskins
	Water_Clearance_Water,            // Clearance Water
	Water_Drizzle_Water,              // Drizzle Water
	Water_Storm_Water,                // Storm Water

    MAX = 70
}

public static class GoodsTypesExtensions
{
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
		{ GoodsTypes._Meta_Artifacts, "_Meta Artifacts" },                                     // Artifacts
		{ GoodsTypes._Meta_Food_Stockpiles, "_Meta Food Stockpiles" },                         // Food Stockpiles
		{ GoodsTypes._Meta_Machinery, "_Meta Machinery" },                                     // Machinery
		{ GoodsTypes.API_ExampleMod_Borgor, "API_ExampleMod_Borgor" },                         // Borgor
		{ GoodsTypes.API_ExampleMod_Cola, "API_ExampleMod_Cola" },                             // Cola
		{ GoodsTypes.API_ExampleMod_Diamonds, "API_ExampleMod_Diamonds" },                     // Diamonds
		{ GoodsTypes.API_ExampleMod_Fries, "API_ExampleMod_Fries" },                           // Fries
		{ GoodsTypes.API_ExampleMod_Kiwi_Fruit, "API_ExampleMod_Kiwi Fruit" },                 // Kiwi Fruit
		{ GoodsTypes.API_ExampleMod_LPG, "API_ExampleMod_LPG" },                               // LPG
		{ GoodsTypes.Blight_Fuel, "Blight Fuel" },                                             // Purging Fire
		{ GoodsTypes.Crafting_Coal, "[Crafting] Coal" },                                       // Coal
		{ GoodsTypes.Crafting_Flour, "[Crafting] Flour" },                                     // Flour
		{ GoodsTypes.Crafting_Oil, "[Crafting] Oil" },                                         // Oil
		{ GoodsTypes.Crafting_Pigment, "[Crafting] Pigment" },                                 // Pigment
		{ GoodsTypes.Crafting_Sea_Marrow, "[Crafting] Sea Marrow" },                           // Sea Marrow
		{ GoodsTypes.Food_Processed_Biscuits, "[Food Processed] Biscuits" },                   // Biscuits
		{ GoodsTypes.Food_Processed_Jerky, "[Food Processed] Jerky" },                         // Jerky
		{ GoodsTypes.Food_Processed_Pickled_Goods, "[Food Processed] Pickled Goods" },         // Pickled Goods
		{ GoodsTypes.Food_Processed_Pie, "[Food Processed] Pie" },                             // Pie
		{ GoodsTypes.Food_Processed_Porridge, "[Food Processed] Porridge" },                   // Porridge
		{ GoodsTypes.Food_Processed_Skewers, "[Food Processed] Skewers" },                     // Skewers
		{ GoodsTypes.Food_Raw_Berries, "[Food Raw] Berries" },                                 // Berries
		{ GoodsTypes.Food_Raw_Eggs, "[Food Raw] Eggs" },                                       // Eggs
		{ GoodsTypes.Food_Raw_Grain, "[Food Raw] Grain" },                                     // Grain
		{ GoodsTypes.Food_Raw_Herbs, "[Food Raw] Herbs" },                                     // Herbs
		{ GoodsTypes.Food_Raw_Insects, "[Food Raw] Insects" },                                 // Insects
		{ GoodsTypes.Food_Raw_Meat, "[Food Raw] Meat" },                                       // Meat
		{ GoodsTypes.Food_Raw_Mushrooms, "[Food Raw] Mushrooms" },                             // Mushrooms
		{ GoodsTypes.Food_Raw_Roots, "[Food Raw] Roots" },                                     // Roots
		{ GoodsTypes.Food_Raw_Vegetables, "[Food Raw] Vegetables" },                           // Vegetables
		{ GoodsTypes.Hearth_Parts, "Hearth Parts" },                                           // Wildfire Essence
		{ GoodsTypes.Mat_Processed_Bricks, "[Mat Processed] Bricks" },                         // Bricks
		{ GoodsTypes.Mat_Processed_Fabric, "[Mat Processed] Fabric" },                         // Fabric
		{ GoodsTypes.Mat_Processed_Parts, "[Mat Processed] Parts" },                           // Parts
		{ GoodsTypes.Mat_Processed_Pipe, "[Mat Processed] Pipe" },                             // Pipes
		{ GoodsTypes.Mat_Processed_Planks, "[Mat Processed] Planks" },                         // Planks
		{ GoodsTypes.Mat_Raw_Clay, "[Mat Raw] Clay" },                                         // Clay
		{ GoodsTypes.Mat_Raw_Leather, "[Mat Raw] Leather" },                                   // Leather
		{ GoodsTypes.Mat_Raw_Plant_Fibre, "[Mat Raw] Plant Fibre" },                           // Plant Fiber
		{ GoodsTypes.Mat_Raw_Reeds, "[Mat Raw] Reeds" },                                       // Reed
		{ GoodsTypes.Mat_Raw_Resin, "[Mat Raw] Resin" },                                       // Resin
		{ GoodsTypes.Mat_Raw_Sparkdew, "[Mat Raw] Sparkdew" },                                 // Sparkdew
		{ GoodsTypes.Mat_Raw_Stone, "[Mat Raw] Stone" },                                       // Stone
		{ GoodsTypes.Mat_Raw_Wood, "[Mat Raw] Wood" },                                         // Wood
		{ GoodsTypes.Metal_Copper_Bar, "[Metal] Copper Bar" },                                 // Copper Bars
		{ GoodsTypes.Metal_Copper_Ore, "[Metal] Copper Ore" },                                 // Copper Ore
		{ GoodsTypes.Metal_Crystalized_Dew, "[Metal] Crystalized Dew" },                       // Crystalized Dew
		{ GoodsTypes.Needs_Ale, "[Needs] Ale" },                                               // Ale
		{ GoodsTypes.Needs_Coats, "[Needs] Coats" },                                           // Coats
		{ GoodsTypes.Needs_Incense, "[Needs] Incense" },                                       // Incense
		{ GoodsTypes.Needs_Scrolls, "[Needs] Scrolls" },                                       // Scrolls
		{ GoodsTypes.Needs_Scrolls___Tutorial, "[Needs] Scrolls - tutorial" },                 // Scrolls
		{ GoodsTypes.Needs_Tea, "[Needs] Tea" },                                               // Tea
		{ GoodsTypes.Needs_Training_Gear, "[Needs] Training Gear" },                           // Training Gear
		{ GoodsTypes.Needs_Wine, "[Needs] Wine" },                                             // Wine
		{ GoodsTypes.Packs_Pack_Of_Building_Materials, "[Packs] Pack of Building Materials" }, // Pack of Building Materials
		{ GoodsTypes.Packs_Pack_Of_Crops, "[Packs] Pack of Crops" },                           // Pack of Crops
		{ GoodsTypes.Packs_Pack_Of_Luxury_Goods, "[Packs] Pack of Luxury Goods" },             // Pack of Luxury Goods
		{ GoodsTypes.Packs_Pack_Of_Provisions, "[Packs] Pack of Provisions" },                 // Pack of Provisions
		{ GoodsTypes.Packs_Pack_Of_Trade_Goods, "[Packs] Pack of Trade Goods" },               // Pack of Trade Goods
		{ GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp" }, 
		{ GoodsTypes.Tools_Simple_Tools, "[Tools] Simple Tools" },                             // Tools
		{ GoodsTypes.Valuable_Amber, "[Valuable] Amber" },                                     // Amber
		{ GoodsTypes.Valuable_Ancient_Tablet, "[Valuable] Ancient Tablet" },                   // Ancient Tablet
		{ GoodsTypes.Vessel_Barrels, "[Vessel] Barrels" },                                     // Barrels
		{ GoodsTypes.Vessel_Pottery, "[Vessel] Pottery" },                                     // Pottery
		{ GoodsTypes.Vessel_Waterskin, "[Vessel] Waterskin" },                                 // Waterskins
		{ GoodsTypes.Water_Clearance_Water, "[Water] Clearance Water" },                       // Clearance Water
		{ GoodsTypes.Water_Drizzle_Water, "[Water] Drizzle Water" },                           // Drizzle Water
		{ GoodsTypes.Water_Storm_Water, "[Water] Storm Water" },                               // Storm Water
	};
}
