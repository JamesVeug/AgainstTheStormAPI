using System.Collections.Generic;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum GoodsTypes
{
    Unknown = -1,
    None,
    All,
    Ale,
    Amber,
    AncientTablet,
    Artifacts,
    Barrels,
    Berries,
    Biscuits,
    BlightFuel,
    Bricks,
    Clay,
    ClearanceWater,
    Coal,
    Coats,
    CopperBar,
    CopperOre,
    CrystalizedDew,
    DrizzleWater,
    Eggs,
    Fabric,
    Flour,
    FoodStockpiles,
    Grain,
    HearthParts,
    Herbs,
    Incense,
    Insects,
    Jerky,
    Leather,
    Machinery,
    Meat,
    Mushrooms,
    Oil,
    PackOfBuildingMaterials,
    PackOfCrops,
    PackOfProvisions,
    PackOfTradeGoods,
    PackOfLuxuryGoods,
    Parts,
    PickledGoods,
    Pie,
    Pigment,
    Pipe,
    Planks,
    PlantFibre,
    Porridge,
    Pottery,
    Reeds,
    Resin,
    Roots,
    Scrolls,
    ScrollsTutorial,
    SeaMarrow,
    SimpleTools,
    Skewers,
    SparkDew,
    Stone,
    StormWater,
    Tea,
    TEMP_Meta_Exp,
    TrainingGear,
    Vegetables,
    WaterSkin,
    Wine,
    Wood
}

public static class GoodsTypesExtensions
{
    public static string ToName(this GoodsTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }
        
        Plugin.Log.LogError($"Cannot find name of good type: " + type);
        return GoodsTypes.Coats.ToString();
    }
    
    public static GoodModel ToGoodsModel(this string goodName)
    {
        if (SO.Settings.ContainsGood(goodName))
        {
            return SO.Settings.GetGood(goodName);
        }
        
        Plugin.Log.LogError($"Cannot find name of good: " + goodName);
        return null;
    }

    internal static readonly Dictionary<GoodsTypes, string> TypeToInternalName = new Dictionary<GoodsTypes, string>()
    {
        {GoodsTypes.Ale, "[Needs] Ale"},
        {GoodsTypes.Amber, "[Valuable] Amber"},
        {GoodsTypes.AncientTablet, "[Valuable] Ancient Tablet"},
        {GoodsTypes.Artifacts, "_Meta Artifacts"},
        {GoodsTypes.Barrels, "[Vessel] Barrels"},
        {GoodsTypes.Berries, "[Food Raw] Berries"},
        {GoodsTypes.Biscuits, "[Food Processed] Biscuits"},
        {GoodsTypes.BlightFuel, "Blight Fuel"},
        {GoodsTypes.Bricks, "[Mat Processed] Bricks"},
        {GoodsTypes.Clay, "[Mat Raw] Clay"},
        {GoodsTypes.ClearanceWater, "[Water] Clearance Water"},
        {GoodsTypes.Coal, "[Crafting] Coal"},
        {GoodsTypes.Coats, "[Needs] Coats"},
        {GoodsTypes.CopperBar, "[Metal] Copper Bar"},
        {GoodsTypes.CopperOre, "[Metal] Copper Ore"},
        {GoodsTypes.CrystalizedDew, "[Metal] Crystalized Dew"},
        {GoodsTypes.DrizzleWater, "[Water] Drizzle Water"},
        {GoodsTypes.Eggs, "[Food Raw] Eggs"},
        {GoodsTypes.Fabric, "[Mat Processed] Fabric"},
        {GoodsTypes.Flour, "[Crafting] Flour"},
        {GoodsTypes.FoodStockpiles, "_Meta Food Stockpiles"},
        {GoodsTypes.Grain, "[Food Raw] Grain"},
        {GoodsTypes.HearthParts, "Hearth Parts"},
        {GoodsTypes.Herbs, "[Food Raw] Herbs"},
        {GoodsTypes.Incense, "[Needs] Incense"},
        {GoodsTypes.Insects, "[Food Raw] Insects"},
        {GoodsTypes.Jerky, "[Food Processed] Jerky"},
        {GoodsTypes.Leather, "[Mat Raw] Leather"},
        {GoodsTypes.Machinery, "_Meta Machinery"},
        {GoodsTypes.Meat, "[Food Raw] Meat"},
        {GoodsTypes.Mushrooms, "[Food Raw] Mushrooms"},
        {GoodsTypes.Oil, "[Crafting] Oil"},
        {GoodsTypes.PackOfBuildingMaterials, "[Packs] Pack of Building Materials"},
        {GoodsTypes.PackOfCrops, "[Packs] Pack of Crops"},
        {GoodsTypes.PackOfProvisions, "[Packs] Pack of Provisions"},
        {GoodsTypes.PackOfTradeGoods, "[Packs] Pack of Trade Goods"},
        {GoodsTypes.PackOfLuxuryGoods, "[Packs] Pack of Luxury Goods"},
        {GoodsTypes.Parts, "[Mat Processed] Parts"},
        {GoodsTypes.PickledGoods, "[Food Processed] Pickled Goods"},
        {GoodsTypes.Pie, "[Food Processed] Pie"},
        {GoodsTypes.Pigment, "[Crafting] Pigment"},
        {GoodsTypes.Pipe, "[Mat Processed] Pipe"},
        {GoodsTypes.Planks, "[Mat Processed] Planks"},
        {GoodsTypes.PlantFibre, "[Mat Raw] Plant Fibre"},
        {GoodsTypes.Porridge, "[Food Processed] Porridge"},
        {GoodsTypes.Pottery, "[Vessel] Pottery"},
        {GoodsTypes.Reeds, "[Mat Raw] Reeds"},
        {GoodsTypes.Resin, "[Mat Raw] Resin"},
        {GoodsTypes.Roots, "[Food Raw] Roots"},
        {GoodsTypes.Scrolls, "[Needs] Scrolls"},
        {GoodsTypes.ScrollsTutorial, "[Needs] Scrolls - tutorial"},
        {GoodsTypes.SeaMarrow, "[Crafting] Sea Marrow"},
        {GoodsTypes.SimpleTools, "[Tools] Simple Tools"},
        {GoodsTypes.Skewers, "[Food Processed] Skewers"},
        {GoodsTypes.SparkDew, "[Mat Raw] Sparkdew"},
        {GoodsTypes.Stone, "[Mat Raw] Stone"},
        {GoodsTypes.StormWater, "[Water] Storm Water"},
        {GoodsTypes.Tea, "[Needs] Tea"},
        {GoodsTypes.TEMP_Meta_Exp, "TEMP_Meta_Exp"},
        {GoodsTypes.TrainingGear, "[Needs] Training Gear"},
        {GoodsTypes.Vegetables, "[Food Raw] Vegetables"},
        {GoodsTypes.WaterSkin, "[Vessel] Waterskin"},
        {GoodsTypes.Wine, "[Needs] Wine"},
        {GoodsTypes.Wood, "[Mat Raw] Wood"},
    };
}