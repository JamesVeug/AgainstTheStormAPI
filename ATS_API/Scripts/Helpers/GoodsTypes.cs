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
	_MetaArtifacts,                // Artifacts
	_MetaFoodStockpiles,           // Food Stockpiles
	_MetaMachinery,                // Machinery
	BlightFuel,                    // Purging Fire
	Crafting_Coal,                 // Coal
	Crafting_Flour,                // Flour
	Crafting_Oil,                  // Oil
	Crafting_Pigment,              // Pigment
	Crafting_SeaMarrow,            // Sea Marrow
	FoodProcessed_Biscuits,        // Biscuits
	FoodProcessed_Jerky,           // Jerky
	FoodProcessed_PickledGoods,    // Pickled Goods
	FoodProcessed_Pie,             // Pie
	FoodProcessed_Porridge,        // Porridge
	FoodProcessed_Skewers,         // Skewers
	FoodRaw_Berries,               // Berries
	FoodRaw_Eggs,                  // Eggs
	FoodRaw_Grain,                 // Grain
	FoodRaw_Herbs,                 // Herbs
	FoodRaw_Insects,               // Insects
	FoodRaw_Meat,                  // Meat
	FoodRaw_Mushrooms,             // Mushrooms
	FoodRaw_Roots,                 // Roots
	FoodRaw_Vegetables,            // Vegetables
	HearthParts,                   // Wildfire Essence
	MatProcessed_Bricks,           // Bricks
	MatProcessed_Fabric,           // Fabric
	MatProcessed_Parts,            // Parts
	MatProcessed_Pipe,             // Pipes
	MatProcessed_Planks,           // Planks
	MatRaw_Clay,                   // Clay
	MatRaw_Leather,                // Leather
	MatRaw_PlantFibre,             // Plant Fiber
	MatRaw_Reeds,                  // Reed
	MatRaw_Resin,                  // Resin
	MatRaw_Sparkdew,               // Sparkdew
	MatRaw_Stone,                  // Stone
	MatRaw_Wood,                   // Wood
	Metal_CopperBar,               // Copper Bars
	Metal_CopperOre,               // Copper Ore
	Metal_CrystalizedDew,          // Crystalized Dew
	Needs_Ale,                     // Ale
	Needs_Coats,                   // Coats
	Needs_Incense,                 // Incense
	Needs_Scrolls,                 // Scrolls
	Needs_Scrolls_Tutorial,        // Scrolls
	Needs_Tea,                     // Tea
	Needs_TrainingGear,            // Training Gear
	Needs_Wine,                    // Wine
	Packs_PackOfBuildingMaterials, // Pack of Building Materials
	Packs_PackOfCrops,             // Pack of Crops
	Packs_PackOfLuxuryGoods,       // Pack of Luxury Goods
	Packs_PackOfProvisions,        // Pack of Provisions
	Packs_PackOfTradeGoods,        // Pack of Trade Goods
	TEMP_Meta_Exp,                 // >Missing key<
	Tools_SimpleTools,             // Tools
	Valuable_Amber,                // Amber
	Valuable_AncientTablet,        // Ancient Tablet
	Vessel_Barrels,                // Barrels
	Vessel_Pottery,                // Pottery
	Vessel_Waterskin,              // Waterskins
	Water_ClearanceWater,          // Clearance Water
	Water_DrizzleWater,            // Drizzle Water
	Water_StormWater,              // Storm Water

    MAX
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
		return TypeToInternalName[GoodsTypes._MetaArtifacts];
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
		{ GoodsTypes._MetaArtifacts, "_Meta Artifacts" },                                   // Artifacts
		{ GoodsTypes._MetaFoodStockpiles, "_Meta Food Stockpiles" },                        // Food Stockpiles
		{ GoodsTypes._MetaMachinery, "_Meta Machinery" },                                   // Machinery
		{ GoodsTypes.BlightFuel, "Blight Fuel" },                                           // Purging Fire
		{ GoodsTypes.Crafting_Coal, "[Crafting] Coal" },                                    // Coal
		{ GoodsTypes.Crafting_Flour, "[Crafting] Flour" },                                  // Flour
		{ GoodsTypes.Crafting_Oil, "[Crafting] Oil" },                                      // Oil
		{ GoodsTypes.Crafting_Pigment, "[Crafting] Pigment" },                              // Pigment
		{ GoodsTypes.Crafting_SeaMarrow, "[Crafting] Sea Marrow" },                         // Sea Marrow
		{ GoodsTypes.FoodProcessed_Biscuits, "[Food Processed] Biscuits" },                 // Biscuits
		{ GoodsTypes.FoodProcessed_Jerky, "[Food Processed] Jerky" },                       // Jerky
		{ GoodsTypes.FoodProcessed_PickledGoods, "[Food Processed] Pickled Goods" },        // Pickled Goods
		{ GoodsTypes.FoodProcessed_Pie, "[Food Processed] Pie" },                           // Pie
		{ GoodsTypes.FoodProcessed_Porridge, "[Food Processed] Porridge" },                 // Porridge
		{ GoodsTypes.FoodProcessed_Skewers, "[Food Processed] Skewers" },                   // Skewers
		{ GoodsTypes.FoodRaw_Berries, "[Food Raw] Berries" },                               // Berries
		{ GoodsTypes.FoodRaw_Eggs, "[Food Raw] Eggs" },                                     // Eggs
		{ GoodsTypes.FoodRaw_Grain, "[Food Raw] Grain" },                                   // Grain
		{ GoodsTypes.FoodRaw_Herbs, "[Food Raw] Herbs" },                                   // Herbs
		{ GoodsTypes.FoodRaw_Insects, "[Food Raw] Insects" },                               // Insects
		{ GoodsTypes.FoodRaw_Meat, "[Food Raw] Meat" },                                     // Meat
		{ GoodsTypes.FoodRaw_Mushrooms, "[Food Raw] Mushrooms" },                           // Mushrooms
		{ GoodsTypes.FoodRaw_Roots, "[Food Raw] Roots" },                                   // Roots
		{ GoodsTypes.FoodRaw_Vegetables, "[Food Raw] Vegetables" },                         // Vegetables
		{ GoodsTypes.HearthParts, "Hearth Parts" },                                         // Wildfire Essence
		{ GoodsTypes.MatProcessed_Bricks, "[Mat Processed] Bricks" },                       // Bricks
		{ GoodsTypes.MatProcessed_Fabric, "[Mat Processed] Fabric" },                       // Fabric
		{ GoodsTypes.MatProcessed_Parts, "[Mat Processed] Parts" },                         // Parts
		{ GoodsTypes.MatProcessed_Pipe, "[Mat Processed] Pipe" },                           // Pipes
		{ GoodsTypes.MatProcessed_Planks, "[Mat Processed] Planks" },                       // Planks
		{ GoodsTypes.MatRaw_Clay, "[Mat Raw] Clay" },                                       // Clay
		{ GoodsTypes.MatRaw_Leather, "[Mat Raw] Leather" },                                 // Leather
		{ GoodsTypes.MatRaw_PlantFibre, "[Mat Raw] Plant Fibre" },                          // Plant Fiber
		{ GoodsTypes.MatRaw_Reeds, "[Mat Raw] Reeds" },                                     // Reed
		{ GoodsTypes.MatRaw_Resin, "[Mat Raw] Resin" },                                     // Resin
		{ GoodsTypes.MatRaw_Sparkdew, "[Mat Raw] Sparkdew" },                               // Sparkdew
		{ GoodsTypes.MatRaw_Stone, "[Mat Raw] Stone" },                                     // Stone
		{ GoodsTypes.MatRaw_Wood, "[Mat Raw] Wood" },                                       // Wood
		{ GoodsTypes.Metal_CopperBar, "[Metal] Copper Bar" },                               // Copper Bars
		{ GoodsTypes.Metal_CopperOre, "[Metal] Copper Ore" },                               // Copper Ore
		{ GoodsTypes.Metal_CrystalizedDew, "[Metal] Crystalized Dew" },                     // Crystalized Dew
		{ GoodsTypes.Needs_Ale, "[Needs] Ale" },                                            // Ale
		{ GoodsTypes.Needs_Coats, "[Needs] Coats" },                                        // Coats
		{ GoodsTypes.Needs_Incense, "[Needs] Incense" },                                    // Incense
		{ GoodsTypes.Needs_Scrolls, "[Needs] Scrolls" },                                    // Scrolls
		{ GoodsTypes.Needs_Scrolls_Tutorial, "[Needs] Scrolls - tutorial" },                // Scrolls
		{ GoodsTypes.Needs_Tea, "[Needs] Tea" },                                            // Tea
		{ GoodsTypes.Needs_TrainingGear, "[Needs] Training Gear" },                         // Training Gear
		{ GoodsTypes.Needs_Wine, "[Needs] Wine" },                                          // Wine
		{ GoodsTypes.Packs_PackOfBuildingMaterials, "[Packs] Pack of Building Materials" }, // Pack of Building Materials
		{ GoodsTypes.Packs_PackOfCrops, "[Packs] Pack of Crops" },                          // Pack of Crops
		{ GoodsTypes.Packs_PackOfLuxuryGoods, "[Packs] Pack of Luxury Goods" },             // Pack of Luxury Goods
		{ GoodsTypes.Packs_PackOfProvisions, "[Packs] Pack of Provisions" },                // Pack of Provisions
		{ GoodsTypes.Packs_PackOfTradeGoods, "[Packs] Pack of Trade Goods" },               // Pack of Trade Goods
		{ GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp" },                                      // >Missing key<
		{ GoodsTypes.Tools_SimpleTools, "[Tools] Simple Tools" },                           // Tools
		{ GoodsTypes.Valuable_Amber, "[Valuable] Amber" },                                  // Amber
		{ GoodsTypes.Valuable_AncientTablet, "[Valuable] Ancient Tablet" },                 // Ancient Tablet
		{ GoodsTypes.Vessel_Barrels, "[Vessel] Barrels" },                                  // Barrels
		{ GoodsTypes.Vessel_Pottery, "[Vessel] Pottery" },                                  // Pottery
		{ GoodsTypes.Vessel_Waterskin, "[Vessel] Waterskin" },                              // Waterskins
		{ GoodsTypes.Water_ClearanceWater, "[Water] Clearance Water" },                     // Clearance Water
		{ GoodsTypes.Water_DrizzleWater, "[Water] Drizzle Water" },                         // Drizzle Water
		{ GoodsTypes.Water_StormWater, "[Water] Storm Water" },                             // Storm Water
	};
}
