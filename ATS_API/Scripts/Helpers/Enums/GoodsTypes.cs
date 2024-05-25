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
	_Meta_Artifacts, 
	_Meta_Food_Stockpiles, 
	_Meta_Machinery, 
	Blight_Fuel, 
	Crafting_Coal, 
	Crafting_Flour, 
	Crafting_Oil, 
	Crafting_Pigment, 
	Crafting_Sea_Marrow, 
	Food_Processed_Biscuits, 
	Food_Processed_Jerky, 
	Food_Processed_Pickled_Goods, 
	Food_Processed_Pie, 
	Food_Processed_Porridge, 
	Food_Processed_Skewers, 
	Food_Raw_Berries, 
	Food_Raw_Eggs, 
	Food_Raw_Grain, 
	Food_Raw_Herbs, 
	Food_Raw_Insects, 
	Food_Raw_Meat, 
	Food_Raw_Mushrooms, 
	Food_Raw_Roots, 
	Food_Raw_Vegetables, 
	Hearth_Parts, 
	Mat_Processed_Bricks, 
	Mat_Processed_Fabric, 
	Mat_Processed_Parts, 
	Mat_Processed_Pipe, 
	Mat_Processed_Planks, 
	Mat_Raw_Clay, 
	Mat_Raw_Leather, 
	Mat_Raw_Plant_Fibre, 
	Mat_Raw_Reeds, 
	Mat_Raw_Resin, 
	Mat_Raw_Sparkdew, 
	Mat_Raw_Stone, 
	Mat_Raw_Wood, 
	Metal_Copper_Bar, 
	Metal_Copper_Ore, 
	Metal_Crystalized_Dew, 
	Needs_Ale, 
	Needs_Coats, 
	Needs_Incense, 
	Needs_Scrolls, 
	Needs_Scrolls_Tutorial, 
	Needs_Tea, 
	Needs_Training_Gear, 
	Needs_Wine, 
	Packs_Pack_Of_Building_Materials, 
	Packs_Pack_Of_Crops, 
	Packs_Pack_Of_Luxury_Goods, 
	Packs_Pack_Of_Provisions, 
	Packs_Pack_Of_Trade_Goods, 
	TEMP_Meta_Exp, 
	Tools_Simple_Tools, 
	Valuable_Amber, 
	Valuable_Ancient_Tablet, 
	Vessel_Barrels, 
	Vessel_Pottery, 
	Vessel_Waterskin, 
	Water_Clearance_Water, 
	Water_Drizzle_Water, 
	Water_Storm_Water, 


    MAX = 64
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
		{ GoodsTypes._Meta_Artifacts, "_Meta Artifacts" }, 
		{ GoodsTypes._Meta_Food_Stockpiles, "_Meta Food Stockpiles" }, 
		{ GoodsTypes._Meta_Machinery, "_Meta Machinery" }, 
		{ GoodsTypes.Blight_Fuel, "Blight Fuel" }, 
		{ GoodsTypes.Crafting_Coal, "[Crafting] Coal" }, 
		{ GoodsTypes.Crafting_Flour, "[Crafting] Flour" }, 
		{ GoodsTypes.Crafting_Oil, "[Crafting] Oil" }, 
		{ GoodsTypes.Crafting_Pigment, "[Crafting] Pigment" }, 
		{ GoodsTypes.Crafting_Sea_Marrow, "[Crafting] Sea Marrow" }, 
		{ GoodsTypes.Food_Processed_Biscuits, "[Food Processed] Biscuits" }, 
		{ GoodsTypes.Food_Processed_Jerky, "[Food Processed] Jerky" }, 
		{ GoodsTypes.Food_Processed_Pickled_Goods, "[Food Processed] Pickled Goods" }, 
		{ GoodsTypes.Food_Processed_Pie, "[Food Processed] Pie" }, 
		{ GoodsTypes.Food_Processed_Porridge, "[Food Processed] Porridge" }, 
		{ GoodsTypes.Food_Processed_Skewers, "[Food Processed] Skewers" }, 
		{ GoodsTypes.Food_Raw_Berries, "[Food Raw] Berries" }, 
		{ GoodsTypes.Food_Raw_Eggs, "[Food Raw] Eggs" }, 
		{ GoodsTypes.Food_Raw_Grain, "[Food Raw] Grain" }, 
		{ GoodsTypes.Food_Raw_Herbs, "[Food Raw] Herbs" }, 
		{ GoodsTypes.Food_Raw_Insects, "[Food Raw] Insects" }, 
		{ GoodsTypes.Food_Raw_Meat, "[Food Raw] Meat" }, 
		{ GoodsTypes.Food_Raw_Mushrooms, "[Food Raw] Mushrooms" }, 
		{ GoodsTypes.Food_Raw_Roots, "[Food Raw] Roots" }, 
		{ GoodsTypes.Food_Raw_Vegetables, "[Food Raw] Vegetables" }, 
		{ GoodsTypes.Hearth_Parts, "Hearth Parts" }, 
		{ GoodsTypes.Mat_Processed_Bricks, "[Mat Processed] Bricks" }, 
		{ GoodsTypes.Mat_Processed_Fabric, "[Mat Processed] Fabric" }, 
		{ GoodsTypes.Mat_Processed_Parts, "[Mat Processed] Parts" }, 
		{ GoodsTypes.Mat_Processed_Pipe, "[Mat Processed] Pipe" }, 
		{ GoodsTypes.Mat_Processed_Planks, "[Mat Processed] Planks" }, 
		{ GoodsTypes.Mat_Raw_Clay, "[Mat Raw] Clay" }, 
		{ GoodsTypes.Mat_Raw_Leather, "[Mat Raw] Leather" }, 
		{ GoodsTypes.Mat_Raw_Plant_Fibre, "[Mat Raw] Plant Fibre" }, 
		{ GoodsTypes.Mat_Raw_Reeds, "[Mat Raw] Reeds" }, 
		{ GoodsTypes.Mat_Raw_Resin, "[Mat Raw] Resin" }, 
		{ GoodsTypes.Mat_Raw_Sparkdew, "[Mat Raw] Sparkdew" }, 
		{ GoodsTypes.Mat_Raw_Stone, "[Mat Raw] Stone" }, 
		{ GoodsTypes.Mat_Raw_Wood, "[Mat Raw] Wood" }, 
		{ GoodsTypes.Metal_Copper_Bar, "[Metal] Copper Bar" }, 
		{ GoodsTypes.Metal_Copper_Ore, "[Metal] Copper Ore" }, 
		{ GoodsTypes.Metal_Crystalized_Dew, "[Metal] Crystalized Dew" }, 
		{ GoodsTypes.Needs_Ale, "[Needs] Ale" }, 
		{ GoodsTypes.Needs_Coats, "[Needs] Coats" }, 
		{ GoodsTypes.Needs_Incense, "[Needs] Incense" }, 
		{ GoodsTypes.Needs_Scrolls, "[Needs] Scrolls" }, 
		{ GoodsTypes.Needs_Scrolls_Tutorial, "[Needs] Scrolls - tutorial" }, 
		{ GoodsTypes.Needs_Tea, "[Needs] Tea" }, 
		{ GoodsTypes.Needs_Training_Gear, "[Needs] Training Gear" }, 
		{ GoodsTypes.Needs_Wine, "[Needs] Wine" }, 
		{ GoodsTypes.Packs_Pack_Of_Building_Materials, "[Packs] Pack of Building Materials" }, 
		{ GoodsTypes.Packs_Pack_Of_Crops, "[Packs] Pack of Crops" }, 
		{ GoodsTypes.Packs_Pack_Of_Luxury_Goods, "[Packs] Pack of Luxury Goods" }, 
		{ GoodsTypes.Packs_Pack_Of_Provisions, "[Packs] Pack of Provisions" }, 
		{ GoodsTypes.Packs_Pack_Of_Trade_Goods, "[Packs] Pack of Trade Goods" }, 
		{ GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp" }, 
		{ GoodsTypes.Tools_Simple_Tools, "[Tools] Simple Tools" }, 
		{ GoodsTypes.Valuable_Amber, "[Valuable] Amber" }, 
		{ GoodsTypes.Valuable_Ancient_Tablet, "[Valuable] Ancient Tablet" }, 
		{ GoodsTypes.Vessel_Barrels, "[Vessel] Barrels" }, 
		{ GoodsTypes.Vessel_Pottery, "[Vessel] Pottery" }, 
		{ GoodsTypes.Vessel_Waterskin, "[Vessel] Waterskin" }, 
		{ GoodsTypes.Water_Clearance_Water, "[Water] Clearance Water" }, 
		{ GoodsTypes.Water_Drizzle_Water, "[Water] Drizzle Water" }, 
		{ GoodsTypes.Water_Storm_Water, "[Water] Storm Water" }, 

	};
}
