using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum RecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown RecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no RecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a RecipeTypes.
	/// </summary>
	None = 0,
	

	//
	// CampRecipeModel
	//

	/// <summary></summary>
	/// <name>Wood</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Wood</producedGood>
	Wood = 1,


	//
	// CollectorRecipeModel
	//

	/// <summary></summary>
	/// <name>Clay (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay_Collector = 2,

	/// <summary></summary>
	/// <name>Crystalized Dew [ancient]</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_ancient = 3,

	/// <summary></summary>
	/// <name>Crystalized Dew T0 (Collector)</name>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T0_Collector = 4,

	/// <summary></summary>
	/// <name>Herbs (Collector)</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_Collector = 5,

	/// <summary></summary>
	/// <name>Ink T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Ink_T1_Collector = 6,

	/// <summary></summary>
	/// <name>Insects (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects_Collector = 7,

	/// <summary></summary>
	/// <name>Leather (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather_Collector = 8,

	/// <summary></summary>
	/// <name>Meat (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_Collector = 9,

	/// <summary></summary>
	/// <name>Mushrooms (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Collector = 10,

	/// <summary></summary>
	/// <name>Reeds (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Reeds_Collector = 11,

	/// <summary></summary>
	/// <name>Roots (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Collector = 12,

	/// <summary></summary>
	/// <name>Sparkdew T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Sparkdew</producedGood>
	Sparkdew_T1_Collector = 13,

	/// <summary></summary>
	/// <name>Stone [ancient]</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Stone_ancient = 14,

	/// <summary></summary>
	/// <name>Wine T1 (Collector)</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Wine_T1_Collector = 15,


	//
	// FarmRecipeModel
	//

	/// <summary></summary>
	/// <name>Berries Plantation</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries_Plantation = 16,

	/// <summary></summary>
	/// <name>Crystalized Dew Grove</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_Grove = 17,

	/// <summary></summary>
	/// <name>Fibre Plantation</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Fibre_Plantation = 18,

	/// <summary></summary>
	/// <name>Grain Big Farm</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_Big_Farm = 19,

	/// <summary></summary>
	/// <name>Grain Small Farm</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_Small_Farm = 20,

	/// <summary></summary>
	/// <name>Herbs Herb Garden</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_Herb_Garden = 21,

	/// <summary></summary>
	/// <name>More Berries Plantation</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	More_Berries_Plantation = 22,

	/// <summary></summary>
	/// <name>More Crystalized Dew Grove</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	More_Crystalized_Dew_Grove = 23,

	/// <summary></summary>
	/// <name>More Fibre Small Farm</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	More_Fibre_Small_Farm = 24,

	/// <summary></summary>
	/// <name>More Grain Small Farm</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	More_Grain_Small_Farm = 25,

	/// <summary></summary>
	/// <name>More Herbs Herb Garden</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	More_Herbs_Herb_Garden = 26,

	/// <summary></summary>
	/// <name>More Roots Herb Garden</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	More_Roots_Herb_Garden = 27,

	/// <summary></summary>
	/// <name>More Vegetable Small Farm</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	More_Vegetable_Small_Farm = 28,

	/// <summary></summary>
	/// <name>Mushrooms Big Farm</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Big_Farm = 29,

	/// <summary></summary>
	/// <name>Mushrooms Small Farm</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Small_Farm = 30,

	/// <summary></summary>
	/// <name>Mushrooms Small Farm - Altar</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_Small_Farm_Altar = 31,

	/// <summary></summary>
	/// <name>Plant Fibre Big Farm</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Plant_Fibre_Big_Farm = 32,

	/// <summary></summary>
	/// <name>Resin Grove</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Resin</producedGood>
	Resin_Grove = 33,

	/// <summary></summary>
	/// <name>Roots Herb Garden</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Herb_Garden = 34,

	/// <summary></summary>
	/// <name>Roots Small Farm</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_Small_Farm = 35,

	/// <summary></summary>
	/// <name>Vegetable Big Farm</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetable_Big_Farm = 36,

	/// <summary></summary>
	/// <name>Vegetable Small Farm</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetable_Small_Farm = 37,


	//
	// FishingHutRecipeModel
	//

	/// <summary></summary>
	/// <name>Algae T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Algae</producedGood>
	Algae_T1 = 38,

	/// <summary></summary>
	/// <name>Algae T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Algae</producedGood>
	Algae_T2 = 39,

	/// <summary></summary>
	/// <name>Fish T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Fish</producedGood>
	Fish_T1 = 40,

	/// <summary></summary>
	/// <name>Fish T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Fish</producedGood>
	Fish_T2 = 41,

	/// <summary></summary>
	/// <name>Scales T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Scales</producedGood>
	Scales_T1 = 42,

	/// <summary></summary>
	/// <name>Scales T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Scales</producedGood>
	Scales_T2 = 43,


	//
	// GathererHutRecipeModel
	//

	/// <summary></summary>
	/// <name>Berries</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries = 44,

	/// <summary></summary>
	/// <name>Berries T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Berries</producedGood>
	Berries_T0 = 45,

	/// <summary></summary>
	/// <name>Clay</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay = 46,

	/// <summary></summary>
	/// <name>Eggs</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Eggs = 47,

	/// <summary></summary>
	/// <name>Eggs T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Eggs_T0 = 48,

	/// <summary></summary>
	/// <name>Grain</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain = 49,

	/// <summary></summary>
	/// <name>Grain T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Grain</producedGood>
	Grain_T0 = 50,

	/// <summary></summary>
	/// <name>Herbs</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs = 51,

	/// <summary></summary>
	/// <name>Herbs T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Herbs_T0 = 52,

	/// <summary></summary>
	/// <name>Insects</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects = 53,

	/// <summary></summary>
	/// <name>Insects T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Insects</producedGood>
	Insects_T0 = 54,

	/// <summary></summary>
	/// <name>Leather</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather = 55,

	/// <summary></summary>
	/// <name>Meat</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat = 56,

	/// <summary></summary>
	/// <name>Meat T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_T0 = 57,

	/// <summary></summary>
	/// <name>Mushrooms</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms = 58,

	/// <summary></summary>
	/// <name>Mushrooms T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Mushrooms_T0 = 59,

	/// <summary></summary>
	/// <name>Plant Fibre</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Plant Fibre</producedGood>
	Plant_Fibre = 60,

	/// <summary></summary>
	/// <name>Reeds</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Reeds = 61,

	/// <summary></summary>
	/// <name>Roots</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots = 62,

	/// <summary></summary>
	/// <name>Roots T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Roots</producedGood>
	Roots_T0 = 63,

	/// <summary></summary>
	/// <name>Sea Marrow</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Sea Marrow</producedGood>
	Sea_Marrow = 64,

	/// <summary></summary>
	/// <name>Stone</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Stone = 65,

	/// <summary></summary>
	/// <name>Vegetables</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetables = 66,

	/// <summary></summary>
	/// <name>Vegetables T0</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Vegetables_T0 = 67,


	//
	// InstitutionRecipeModel
	//

	/// <summary></summary>
	/// <name>Bloodthirst</name>
	/// <grade>1</grade>
	/// <servedNeed>Bloodthirst</servedNeed>
	Bloodthirst = 68,

	/// <summary></summary>
	/// <name>Brotherhood_Free</name>
	/// <grade>1</grade>
	/// <servedNeed>Bloodthirst</servedNeed>
	Brotherhood_Free = 69,

	/// <summary></summary>
	/// <name>Education</name>
	/// <grade>1</grade>
	/// <servedNeed>Education</servedNeed>
	Education = 70,

	/// <summary></summary>
	/// <name>Education_Free</name>
	/// <grade>1</grade>
	/// <servedNeed>Education</servedNeed>
	Education_Free = 71,

	/// <summary></summary>
	/// <name>Leasiure</name>
	/// <grade>1</grade>
	/// <servedNeed>Leasiure</servedNeed>
	Leasiure = 72,

	/// <summary></summary>
	/// <name>Luxury</name>
	/// <grade>1</grade>
	/// <servedNeed>Luxury</servedNeed>
	Luxury = 73,

	/// <summary></summary>
	/// <name>Luxury_Free</name>
	/// <grade>1</grade>
	/// <servedNeed>Luxury</servedNeed>
	Luxury_Free = 74,

	/// <summary></summary>
	/// <name>Religion</name>
	/// <grade>1</grade>
	/// <servedNeed>Religion</servedNeed>
	Religion = 75,

	/// <summary></summary>
	/// <name>Treatment</name>
	/// <grade>1</grade>
	/// <servedNeed>Treatment</servedNeed>
	Treatment = 76,


	//
	// MineRecipeModel
	//

	/// <summary></summary>
	/// <name>Coal</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal = 77,

	/// <summary></summary>
	/// <name>Copper</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Copper Ore</producedGood>
	Copper = 78,

	/// <summary></summary>
	/// <name>Salt</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Salt</producedGood>
	Salt = 79,


	//
	// RainCatcherRecipeModel
	//

	/// <summary></summary>
	/// <name>Clearance Rain Catcher (T0)</name>
	/// <grade>1</grade>
	/// <producedGood>[Water] Clearance Water</producedGood>
	Clearance_Rain_Catcher_T0 = 80,

	/// <summary></summary>
	/// <name>Clearance Rain Catcher (T1)</name>
	/// <grade>2</grade>
	/// <producedGood>[Water] Clearance Water</producedGood>
	Clearance_Rain_Catcher_T1 = 81,

	/// <summary></summary>
	/// <name>Drizzle Rain Catcher (T0)</name>
	/// <grade>1</grade>
	/// <producedGood>[Water] Drizzle Water</producedGood>
	Drizzle_Rain_Catcher_T0 = 82,

	/// <summary></summary>
	/// <name>Drizzle Rain Catcher (T1)</name>
	/// <grade>2</grade>
	/// <producedGood>[Water] Drizzle Water</producedGood>
	Drizzle_Rain_Catcher_T1 = 83,

	/// <summary></summary>
	/// <name>Storm Rain Catcher (T0)</name>
	/// <grade>1</grade>
	/// <producedGood>[Water] Storm Water</producedGood>
	Storm_Rain_Catcher_T0 = 84,

	/// <summary></summary>
	/// <name>Storm Rain Catcher (T1)</name>
	/// <grade>2</grade>
	/// <producedGood>[Water] Storm Water</producedGood>
	Storm_Rain_Catcher_T1 = 85,


	//
	// WorkshopRecipeModel
	//

	/// <summary></summary>
	/// <name>- todelete - Pack of Luxury Goods</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	_Todelete_Pack_Of_Luxury_Goods = 86,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T0 = 87,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T1 = 88,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T2 = 89,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T3 = 90,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T0 = 91,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T1 = 92,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T2 = 93,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T3 = 94,

	/// <summary></summary>
	/// <name>[Building Material] Planks T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T0 = 95,

	/// <summary></summary>
	/// <name>[Building Material] Planks T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T1 = 96,

	/// <summary></summary>
	/// <name>[Building Material] Planks T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T2 = 97,

	/// <summary></summary>
	/// <name>[Building Material] Planks T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T3 = 98,

	/// <summary></summary>
	/// <name>[Clay Pit] Clay T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay_Pit_Clay_T2 = 99,

	/// <summary></summary>
	/// <name>[Clay Pit] Reeds T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Clay_Pit_Reeds_T2 = 100,

	/// <summary></summary>
	/// <name>[Clay Pit] Resin T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Resin</producedGood>
	Clay_Pit_Resin_T2 = 101,

	/// <summary></summary>
	/// <name>[Clay Pit] Stone T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Clay_Pit_Stone_T2 = 102,

	/// <summary></summary>
	/// <name>Coal T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T0 = 103,

	/// <summary></summary>
	/// <name>Coal T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T1 = 104,

	/// <summary></summary>
	/// <name>Coal T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T2 = 105,

	/// <summary></summary>
	/// <name>Coal T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T3 = 106,

	/// <summary></summary>
	/// <name>Copper Bar T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T0 = 107,

	/// <summary></summary>
	/// <name>Copper Bar T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T1 = 108,

	/// <summary></summary>
	/// <name>Copper Bar T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T2 = 109,

	/// <summary></summary>
	/// <name>Copper Bar T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T3 = 110,

	/// <summary></summary>
	/// <name>Crystalized Dew T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T0 = 111,

	/// <summary></summary>
	/// <name>Crystalized Dew T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T1 = 112,

	/// <summary></summary>
	/// <name>Crystalized Dew T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T2 = 113,

	/// <summary></summary>
	/// <name>Crystalized Dew T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T3 = 114,

	/// <summary></summary>
	/// <name>Dye T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T0 = 115,

	/// <summary></summary>
	/// <name>Dye T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T1 = 116,

	/// <summary></summary>
	/// <name>Dye T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T2 = 117,

	/// <summary></summary>
	/// <name>Dye T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T3 = 118,

	/// <summary></summary>
	/// <name>Flour T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T0 = 119,

	/// <summary></summary>
	/// <name>Flour T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T1 = 120,

	/// <summary></summary>
	/// <name>Flour T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T2 = 121,

	/// <summary></summary>
	/// <name>Flour T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T3 = 122,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T0 = 123,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T1 = 124,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T2 = 125,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T3 = 126,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T0 = 127,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T1 = 128,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T2 = 129,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T3 = 130,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T0 = 131,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T1 = 132,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T2 = 133,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T3 = 134,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T0 = 135,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T1 = 136,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T2 = 137,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T3 = 138,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T0 = 139,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T1 = 140,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T2 = 141,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T3 = 142,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T0 = 143,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T1 = 144,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T2 = 145,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T3 = 146,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T0 = 147,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T1 = 148,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T2 = 149,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T3 = 150,

	/// <summary></summary>
	/// <name>[Greenhouse] Herbs T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Greenhouse_Herbs_T2 = 151,

	/// <summary></summary>
	/// <name>[Greenhouse] Mushrooms T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Greenhouse_Mushrooms_T2 = 152,

	/// <summary></summary>
	/// <name>[Greenhouse] Vegetables T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Greenhouse_Vegetables_T2 = 153,

	/// <summary></summary>
	/// <name>Hearth Parts T3</name>
	/// <grade>3</grade>
	/// <producedGood>Hearth Parts</producedGood>
	Hearth_Parts_T3 = 154,

	/// <summary></summary>
	/// <name>Leather (workshop) T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather_workshop_T1 = 155,

	/// <summary></summary>
	/// <name>Meat (workshop) T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_workshop_T1 = 156,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T0 = 157,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T1 = 158,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T2 = 159,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T3 = 160,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T1 = 161,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T2 = 162,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T3 = 163,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T0 = 164,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T1 = 165,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T2 = 166,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T3 = 167,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T0 = 168,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T1 = 169,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T2 = 170,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T3 = 171,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T0 = 172,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T1 = 173,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T2 = 174,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T3 = 175,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T0 = 176,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T1 = 177,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T2 = 178,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T3 = 179,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T0 = 180,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T1 = 181,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T2 = 182,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T3 = 183,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T0 = 184,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T1 = 185,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T2 = 186,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T3 = 187,

	/// <summary></summary>
	/// <name>Oil T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T0 = 188,

	/// <summary></summary>
	/// <name>Oil T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T1 = 189,

	/// <summary></summary>
	/// <name>Oil T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T2 = 190,

	/// <summary></summary>
	/// <name>Oil T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T3 = 191,

	/// <summary></summary>
	/// <name>Pack of Building Materials T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T0 = 192,

	/// <summary></summary>
	/// <name>Pack of Building Materials T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T1 = 193,

	/// <summary></summary>
	/// <name>Pack of Building Materials T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T2 = 194,

	/// <summary></summary>
	/// <name>Pack of Building Materials T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T3 = 195,

	/// <summary></summary>
	/// <name>Pack of Crops T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T0 = 196,

	/// <summary></summary>
	/// <name>Pack of Crops T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T1 = 197,

	/// <summary></summary>
	/// <name>Pack of Crops T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T2 = 198,

	/// <summary></summary>
	/// <name>Pack of Crops T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T3 = 199,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T0 = 200,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T1 = 201,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T2 = 202,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T3 = 203,

	/// <summary></summary>
	/// <name>Pack of Provisions T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T0 = 204,

	/// <summary></summary>
	/// <name>Pack of Provisions T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T1 = 205,

	/// <summary></summary>
	/// <name>Pack of Provisions T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T2 = 206,

	/// <summary></summary>
	/// <name>Pack of Provisions T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T3 = 207,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T0 = 208,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T1 = 209,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T2 = 210,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T3 = 211,

	/// <summary></summary>
	/// <name>Pipe T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T0 = 212,

	/// <summary></summary>
	/// <name>Pipe T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T1 = 213,

	/// <summary></summary>
	/// <name>Pipe T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T2 = 214,

	/// <summary></summary>
	/// <name>Pipe T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T3 = 215,

	/// <summary></summary>
	/// <name>[R] Amber</name>
	/// <grade>3</grade>
	/// <producedGood>[Valuable] Amber</producedGood>
	R_Amber = 216,

	/// <summary></summary>
	/// <name>[R] Parts</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Parts</producedGood>
	R_Parts = 217,

	/// <summary></summary>
	/// <name>Ruins [Food Processed] Pickled Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Ruins_Food_Processed_Pickled_Goods_T3 = 218,

	/// <summary></summary>
	/// <name>Ruins [Needs Fullfilment] Ale T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Ruins_Needs_Fullfilment_Ale_T3 = 219,

	/// <summary></summary>
	/// <name>Ruins Pack of Crops T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Ruins_Pack_Of_Crops_T3 = 220,

	/// <summary></summary>
	/// <name>Sparkdew</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Sparkdew</producedGood>
	Sparkdew = 221,

	/// <summary></summary>
	/// <name>T1 Blight Fuel</name>
	/// <grade>3</grade>
	/// <producedGood>Blight Fuel</producedGood>
	T1_Blight_Fuel = 222,

	/// <summary></summary>
	/// <name>[TES] Fuel Core</name>
	/// <grade>1</grade>
	/// <producedGood>[WE] Fuel Core</producedGood>
	TES_Fuel_Core = 223,

	/// <summary></summary>
	/// <name>Tools Simple T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T0 = 224,

	/// <summary></summary>
	/// <name>Tools Simple T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T1 = 225,

	/// <summary></summary>
	/// <name>Tools Simple T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T2 = 226,

	/// <summary></summary>
	/// <name>Tools Simple T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T3 = 227,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T0 = 228,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T1 = 229,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T2 = 230,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T3 = 231,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T0 = 232,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T1 = 233,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T2 = 234,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T3 = 235,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T0 = 236,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T1 = 237,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T2 = 238,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T3 = 239,

	/// <summary></summary>
	/// <name>Workshop Eggs T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Workshop_Eggs_T1 = 240,



	/// <summary>
	/// The total number of vanilla RecipeTypes in the game.
	/// </summary>
	[Obsolete("Use RecipeTypesExtensions.Count(). RecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 240
}

/// <summary>
/// Extension methods for the RecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class RecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in RecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded RecipeTypes.
	/// </summary>
	public static RecipeTypes[] All()
	{
		RecipeTypes[] all = new RecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every RecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return RecipeTypes.Wood in the enum and log an error.
	/// </summary>
	public static string ToName(this RecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of RecipeTypes: " + type);
		return TypeToInternalName[RecipeTypes.Wood];
	}
	
	/// <summary>
	/// Returns a RecipeTypes associated with the given name.
	/// Every RecipeTypes should have a unique name as to distinguish it from others.
	/// If no RecipeTypes is found, it will return RecipeTypes.Unknown and log a warning.
	/// </summary>
	public static RecipeTypes ToRecipeTypes(this string name)
	{
		foreach (KeyValuePair<RecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find RecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return RecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a RecipeModel associated with the given name.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If no RecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RecipeModel ToRecipeModel(this string name)
	{
		Eremite.Buildings.RecipeModel model = SO.Settings.recipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find RecipeModel for RecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a RecipeModel associated with the given RecipeTypes.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If no RecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RecipeModel ToRecipeModel(this RecipeTypes types)
	{
		return types.ToName().ToRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of RecipeModel associated with the given RecipeTypes.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If a RecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RecipeModel[] ToRecipeModelArray(this IEnumerable<RecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RecipeModel[] array = new Eremite.Buildings.RecipeModel[count];
		int i = 0;
		foreach (RecipeTypes element in collection)
		{
			array[i++] = element.ToRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RecipeModel associated with the given RecipeTypes.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If a RecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RecipeModel[] ToRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RecipeModel[] array = new Eremite.Buildings.RecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RecipeModel associated with the given RecipeTypes.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If a RecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RecipeModel[] ToRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.RecipeModel>.Get(out List<Eremite.Buildings.RecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.RecipeModel model = element.ToRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of RecipeModel associated with the given RecipeTypes.
	/// RecipeModel contain all the data that will be used in the game.
	/// Every RecipeModel should have a unique name as to distinguish it from others.
	/// If a RecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RecipeModel[] ToRecipeModelArrayNoNulls(this IEnumerable<RecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.RecipeModel>.Get(out List<Eremite.Buildings.RecipeModel> list))
		{
			foreach (RecipeTypes element in collection)
			{
				Eremite.Buildings.RecipeModel model = element.ToRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<RecipeTypes, string> TypeToInternalName = new()
	{

		// CampRecipeModel
		{ RecipeTypes.Wood, "Wood" }, 

		// CollectorRecipeModel
		{ RecipeTypes.Clay_Collector, "Clay (Collector)" }, 
		{ RecipeTypes.Crystalized_Dew_ancient, "Crystalized Dew [ancient]" }, 
		{ RecipeTypes.Crystalized_Dew_T0_Collector, "Crystalized Dew T0 (Collector)" }, 
		{ RecipeTypes.Herbs_Collector, "Herbs (Collector)" }, 
		{ RecipeTypes.Ink_T1_Collector, "Ink T1 (Collector)" }, 
		{ RecipeTypes.Insects_Collector, "Insects (Collector)" }, 
		{ RecipeTypes.Leather_Collector, "Leather (Collector)" }, 
		{ RecipeTypes.Meat_Collector, "Meat (Collector)" }, 
		{ RecipeTypes.Mushrooms_Collector, "Mushrooms (Collector)" }, 
		{ RecipeTypes.Reeds_Collector, "Reeds (Collector)" }, 
		{ RecipeTypes.Roots_Collector, "Roots (Collector)" }, 
		{ RecipeTypes.Sparkdew_T1_Collector, "Sparkdew T1 (Collector)" }, 
		{ RecipeTypes.Stone_ancient, "Stone [ancient]" }, 
		{ RecipeTypes.Wine_T1_Collector, "Wine T1 (Collector)" }, 

		// FarmRecipeModel
		{ RecipeTypes.Berries_Plantation, "Berries Plantation" }, 
		{ RecipeTypes.Crystalized_Dew_Grove, "Crystalized Dew Grove" }, 
		{ RecipeTypes.Fibre_Plantation, "Fibre Plantation" }, 
		{ RecipeTypes.Grain_Big_Farm, "Grain Big Farm" }, 
		{ RecipeTypes.Grain_Small_Farm, "Grain Small Farm" }, 
		{ RecipeTypes.Herbs_Herb_Garden, "Herbs Herb Garden" }, 
		{ RecipeTypes.More_Berries_Plantation, "More Berries Plantation" }, 
		{ RecipeTypes.More_Crystalized_Dew_Grove, "More Crystalized Dew Grove" }, 
		{ RecipeTypes.More_Fibre_Small_Farm, "More Fibre Small Farm" }, 
		{ RecipeTypes.More_Grain_Small_Farm, "More Grain Small Farm" }, 
		{ RecipeTypes.More_Herbs_Herb_Garden, "More Herbs Herb Garden" }, 
		{ RecipeTypes.More_Roots_Herb_Garden, "More Roots Herb Garden" }, 
		{ RecipeTypes.More_Vegetable_Small_Farm, "More Vegetable Small Farm" }, 
		{ RecipeTypes.Mushrooms_Big_Farm, "Mushrooms Big Farm" }, 
		{ RecipeTypes.Mushrooms_Small_Farm, "Mushrooms Small Farm" }, 
		{ RecipeTypes.Mushrooms_Small_Farm_Altar, "Mushrooms Small Farm - Altar" }, 
		{ RecipeTypes.Plant_Fibre_Big_Farm, "Plant Fibre Big Farm" }, 
		{ RecipeTypes.Resin_Grove, "Resin Grove" }, 
		{ RecipeTypes.Roots_Herb_Garden, "Roots Herb Garden" }, 
		{ RecipeTypes.Roots_Small_Farm, "Roots Small Farm" }, 
		{ RecipeTypes.Vegetable_Big_Farm, "Vegetable Big Farm" }, 
		{ RecipeTypes.Vegetable_Small_Farm, "Vegetable Small Farm" }, 

		// FishingHutRecipeModel
		{ RecipeTypes.Algae_T1, "Algae T1" }, 
		{ RecipeTypes.Algae_T2, "Algae T2" }, 
		{ RecipeTypes.Fish_T1, "Fish T1" }, 
		{ RecipeTypes.Fish_T2, "Fish T2" }, 
		{ RecipeTypes.Scales_T1, "Scales T1" }, 
		{ RecipeTypes.Scales_T2, "Scales T2" }, 

		// GathererHutRecipeModel
		{ RecipeTypes.Berries, "Berries" }, 
		{ RecipeTypes.Berries_T0, "Berries T0" }, 
		{ RecipeTypes.Clay, "Clay" }, 
		{ RecipeTypes.Eggs, "Eggs" }, 
		{ RecipeTypes.Eggs_T0, "Eggs T0" }, 
		{ RecipeTypes.Grain, "Grain" }, 
		{ RecipeTypes.Grain_T0, "Grain T0" }, 
		{ RecipeTypes.Herbs, "Herbs" }, 
		{ RecipeTypes.Herbs_T0, "Herbs T0" }, 
		{ RecipeTypes.Insects, "Insects" }, 
		{ RecipeTypes.Insects_T0, "Insects T0" }, 
		{ RecipeTypes.Leather, "Leather" }, 
		{ RecipeTypes.Meat, "Meat" }, 
		{ RecipeTypes.Meat_T0, "Meat T0" }, 
		{ RecipeTypes.Mushrooms, "Mushrooms" }, 
		{ RecipeTypes.Mushrooms_T0, "Mushrooms T0" }, 
		{ RecipeTypes.Plant_Fibre, "Plant Fibre" }, 
		{ RecipeTypes.Reeds, "Reeds" }, 
		{ RecipeTypes.Roots, "Roots" }, 
		{ RecipeTypes.Roots_T0, "Roots T0" }, 
		{ RecipeTypes.Sea_Marrow, "Sea Marrow" }, 
		{ RecipeTypes.Stone, "Stone" }, 
		{ RecipeTypes.Vegetables, "Vegetables" }, 
		{ RecipeTypes.Vegetables_T0, "Vegetables T0" }, 

		// InstitutionRecipeModel
		{ RecipeTypes.Bloodthirst, "Bloodthirst" }, 
		{ RecipeTypes.Brotherhood_Free, "Brotherhood_Free" }, 
		{ RecipeTypes.Education, "Education" }, 
		{ RecipeTypes.Education_Free, "Education_Free" }, 
		{ RecipeTypes.Leasiure, "Leasiure" }, 
		{ RecipeTypes.Luxury, "Luxury" }, 
		{ RecipeTypes.Luxury_Free, "Luxury_Free" }, 
		{ RecipeTypes.Religion, "Religion" }, 
		{ RecipeTypes.Treatment, "Treatment" }, 

		// MineRecipeModel
		{ RecipeTypes.Coal, "Coal" }, 
		{ RecipeTypes.Copper, "Copper" }, 
		{ RecipeTypes.Salt, "Salt" }, 

		// RainCatcherRecipeModel
		{ RecipeTypes.Clearance_Rain_Catcher_T0, "Clearance Rain Catcher (T0)" }, 
		{ RecipeTypes.Clearance_Rain_Catcher_T1, "Clearance Rain Catcher (T1)" }, 
		{ RecipeTypes.Drizzle_Rain_Catcher_T0, "Drizzle Rain Catcher (T0)" }, 
		{ RecipeTypes.Drizzle_Rain_Catcher_T1, "Drizzle Rain Catcher (T1)" }, 
		{ RecipeTypes.Storm_Rain_Catcher_T0, "Storm Rain Catcher (T0)" }, 
		{ RecipeTypes.Storm_Rain_Catcher_T1, "Storm Rain Catcher (T1)" }, 

		// WorkshopRecipeModel
		{ RecipeTypes._Todelete_Pack_Of_Luxury_Goods, "- todelete - Pack of Luxury Goods" }, 
		{ RecipeTypes.Building_Material_Bricks_T0, "[Building Material] Bricks T0" }, 
		{ RecipeTypes.Building_Material_Bricks_T1, "[Building Material] Bricks T1" }, 
		{ RecipeTypes.Building_Material_Bricks_T2, "[Building Material] Bricks T2" }, 
		{ RecipeTypes.Building_Material_Bricks_T3, "[Building Material] Bricks T3" }, 
		{ RecipeTypes.Building_Material_Fabric_T0, "[Building Material] Fabric T0" }, 
		{ RecipeTypes.Building_Material_Fabric_T1, "[Building Material] Fabric T1" }, 
		{ RecipeTypes.Building_Material_Fabric_T2, "[Building Material] Fabric T2" }, 
		{ RecipeTypes.Building_Material_Fabric_T3, "[Building Material] Fabric T3" }, 
		{ RecipeTypes.Building_Material_Planks_T0, "[Building Material] Planks T0" }, 
		{ RecipeTypes.Building_Material_Planks_T1, "[Building Material] Planks T1" }, 
		{ RecipeTypes.Building_Material_Planks_T2, "[Building Material] Planks T2" }, 
		{ RecipeTypes.Building_Material_Planks_T3, "[Building Material] Planks T3" }, 
		{ RecipeTypes.Clay_Pit_Clay_T2, "[Clay Pit] Clay T2" }, 
		{ RecipeTypes.Clay_Pit_Reeds_T2, "[Clay Pit] Reeds T2" }, 
		{ RecipeTypes.Clay_Pit_Resin_T2, "[Clay Pit] Resin T2" }, 
		{ RecipeTypes.Clay_Pit_Stone_T2, "[Clay Pit] Stone T2" }, 
		{ RecipeTypes.Coal_T0, "Coal T0" }, 
		{ RecipeTypes.Coal_T1, "Coal T1" }, 
		{ RecipeTypes.Coal_T2, "Coal T2" }, 
		{ RecipeTypes.Coal_T3, "Coal T3" }, 
		{ RecipeTypes.Copper_Bar_T0, "Copper Bar T0" }, 
		{ RecipeTypes.Copper_Bar_T1, "Copper Bar T1" }, 
		{ RecipeTypes.Copper_Bar_T2, "Copper Bar T2" }, 
		{ RecipeTypes.Copper_Bar_T3, "Copper Bar T3" }, 
		{ RecipeTypes.Crystalized_Dew_T0, "Crystalized Dew T0" }, 
		{ RecipeTypes.Crystalized_Dew_T1, "Crystalized Dew T1" }, 
		{ RecipeTypes.Crystalized_Dew_T2, "Crystalized Dew T2" }, 
		{ RecipeTypes.Crystalized_Dew_T3, "Crystalized Dew T3" }, 
		{ RecipeTypes.Dye_T0, "Dye T0" }, 
		{ RecipeTypes.Dye_T1, "Dye T1" }, 
		{ RecipeTypes.Dye_T2, "Dye T2" }, 
		{ RecipeTypes.Dye_T3, "Dye T3" }, 
		{ RecipeTypes.Flour_T0, "Flour T0" }, 
		{ RecipeTypes.Flour_T1, "Flour T1" }, 
		{ RecipeTypes.Flour_T2, "Flour T2" }, 
		{ RecipeTypes.Flour_T3, "Flour T3" }, 
		{ RecipeTypes.Food_Processed_Biscuits_T0, "[Food Processed] Biscuits T0" }, 
		{ RecipeTypes.Food_Processed_Biscuits_T1, "[Food Processed] Biscuits T1" }, 
		{ RecipeTypes.Food_Processed_Biscuits_T2, "[Food Processed] Biscuits T2" }, 
		{ RecipeTypes.Food_Processed_Biscuits_T3, "[Food Processed] Biscuits T3" }, 
		{ RecipeTypes.Food_Processed_Jerky_T0, "[Food Processed] Jerky T0" }, 
		{ RecipeTypes.Food_Processed_Jerky_T1, "[Food Processed] Jerky T1" }, 
		{ RecipeTypes.Food_Processed_Jerky_T2, "[Food Processed] Jerky T2" }, 
		{ RecipeTypes.Food_Processed_Jerky_T3, "[Food Processed] Jerky T3" }, 
		{ RecipeTypes.Food_Processed_Paste_T0, "[Food Processed] Paste T0" }, 
		{ RecipeTypes.Food_Processed_Paste_T1, "[Food Processed] Paste T1" }, 
		{ RecipeTypes.Food_Processed_Paste_T2, "[Food Processed] Paste T2" }, 
		{ RecipeTypes.Food_Processed_Paste_T3, "[Food Processed] Paste T3" }, 
		{ RecipeTypes.Food_Processed_Pickled_Goods_T0, "[Food Processed] Pickled Goods T0" }, 
		{ RecipeTypes.Food_Processed_Pickled_Goods_T1, "[Food Processed] Pickled Goods T1" }, 
		{ RecipeTypes.Food_Processed_Pickled_Goods_T2, "[Food Processed] Pickled Goods T2" }, 
		{ RecipeTypes.Food_Processed_Pickled_Goods_T3, "[Food Processed] Pickled Goods T3" }, 
		{ RecipeTypes.Food_Processed_Pie_T0, "[Food Processed] Pie T0" }, 
		{ RecipeTypes.Food_Processed_Pie_T1, "[Food Processed] Pie T1" }, 
		{ RecipeTypes.Food_Processed_Pie_T2, "[Food Processed] Pie T2" }, 
		{ RecipeTypes.Food_Processed_Pie_T3, "[Food Processed] Pie T3" }, 
		{ RecipeTypes.Food_Processed_Porridge_T0, "[Food Processed] Porridge T0" }, 
		{ RecipeTypes.Food_Processed_Porridge_T1, "[Food Processed] Porridge T1" }, 
		{ RecipeTypes.Food_Processed_Porridge_T2, "[Food Processed] Porridge T2" }, 
		{ RecipeTypes.Food_Processed_Porridge_T3, "[Food Processed] Porridge T3" }, 
		{ RecipeTypes.Food_Processed_Skewers_T0, "[Food Processed] Skewers T0" }, 
		{ RecipeTypes.Food_Processed_Skewers_T1, "[Food Processed] Skewers T1" }, 
		{ RecipeTypes.Food_Processed_Skewers_T2, "[Food Processed] Skewers T2" }, 
		{ RecipeTypes.Food_Processed_Skewers_T3, "[Food Processed] Skewers T3" }, 
		{ RecipeTypes.Greenhouse_Herbs_T2, "[Greenhouse] Herbs T2" }, 
		{ RecipeTypes.Greenhouse_Mushrooms_T2, "[Greenhouse] Mushrooms T2" }, 
		{ RecipeTypes.Greenhouse_Vegetables_T2, "[Greenhouse] Vegetables T2" }, 
		{ RecipeTypes.Hearth_Parts_T3, "Hearth Parts T3" }, 
		{ RecipeTypes.Leather_workshop_T1, "Leather (workshop) T1" }, 
		{ RecipeTypes.Meat_workshop_T1, "Meat (workshop) T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Ale_T0, "[Needs Fullfilment] Ale T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Ale_T1, "[Needs Fullfilment] Ale T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Ale_T2, "[Needs Fullfilment] Ale T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Ale_T3, "[Needs Fullfilment] Ale T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Boots_T1, "[Needs Fullfilment] Boots T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Boots_T2, "[Needs Fullfilment] Boots T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Boots_T3, "[Needs Fullfilment] Boots T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Coats_T0, "[Needs Fullfilment] Coats T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Coats_T1, "[Needs Fullfilment] Coats T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Coats_T2, "[Needs Fullfilment] Coats T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Coats_T3, "[Needs Fullfilment] Coats T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Incense_T0, "[Needs Fullfilment] Incense T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Incense_T1, "[Needs Fullfilment] Incense T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Incense_T2, "[Needs Fullfilment] Incense T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Incense_T3, "[Needs Fullfilment] Incense T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Scrolls_T0, "[Needs Fullfilment] Scrolls T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Scrolls_T1, "[Needs Fullfilment] Scrolls T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Scrolls_T2, "[Needs Fullfilment] Scrolls T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Scrolls_T3, "[Needs Fullfilment] Scrolls T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Tea_T0, "[Needs Fullfilment] Tea T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Tea_T1, "[Needs Fullfilment] Tea T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Tea_T2, "[Needs Fullfilment] Tea T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Tea_T3, "[Needs Fullfilment] Tea T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Training_Gear_T0, "[Needs Fullfilment] Training Gear T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Training_Gear_T1, "[Needs Fullfilment] Training Gear T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Training_Gear_T2, "[Needs Fullfilment] Training Gear T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Training_Gear_T3, "[Needs Fullfilment] Training Gear T3" }, 
		{ RecipeTypes.Needs_Fullfilment_Wine_T0, "[Needs Fullfilment] Wine T0" }, 
		{ RecipeTypes.Needs_Fullfilment_Wine_T1, "[Needs Fullfilment] Wine T1" }, 
		{ RecipeTypes.Needs_Fullfilment_Wine_T2, "[Needs Fullfilment] Wine T2" }, 
		{ RecipeTypes.Needs_Fullfilment_Wine_T3, "[Needs Fullfilment] Wine T3" }, 
		{ RecipeTypes.Oil_T0, "Oil T0" }, 
		{ RecipeTypes.Oil_T1, "Oil T1" }, 
		{ RecipeTypes.Oil_T2, "Oil T2" }, 
		{ RecipeTypes.Oil_T3, "Oil T3" }, 
		{ RecipeTypes.Pack_Of_Building_Materials_T0, "Pack of Building Materials T0" }, 
		{ RecipeTypes.Pack_Of_Building_Materials_T1, "Pack of Building Materials T1" }, 
		{ RecipeTypes.Pack_Of_Building_Materials_T2, "Pack of Building Materials T2" }, 
		{ RecipeTypes.Pack_Of_Building_Materials_T3, "Pack of Building Materials T3" }, 
		{ RecipeTypes.Pack_Of_Crops_T0, "Pack of Crops T0" }, 
		{ RecipeTypes.Pack_Of_Crops_T1, "Pack of Crops T1" }, 
		{ RecipeTypes.Pack_Of_Crops_T2, "Pack of Crops T2" }, 
		{ RecipeTypes.Pack_Of_Crops_T3, "Pack of Crops T3" }, 
		{ RecipeTypes.Pack_Of_Luxury_Goods_T0, "Pack of Luxury Goods T0" }, 
		{ RecipeTypes.Pack_Of_Luxury_Goods_T1, "Pack of Luxury Goods T1" }, 
		{ RecipeTypes.Pack_Of_Luxury_Goods_T2, "Pack of Luxury Goods T2" }, 
		{ RecipeTypes.Pack_Of_Luxury_Goods_T3, "Pack of Luxury Goods T3" }, 
		{ RecipeTypes.Pack_Of_Provisions_T0, "Pack of Provisions T0" }, 
		{ RecipeTypes.Pack_Of_Provisions_T1, "Pack of Provisions T1" }, 
		{ RecipeTypes.Pack_Of_Provisions_T2, "Pack of Provisions T2" }, 
		{ RecipeTypes.Pack_Of_Provisions_T3, "Pack of Provisions T3" }, 
		{ RecipeTypes.Pack_Of_Trade_Goods_T0, "Pack of Trade Goods T0" }, 
		{ RecipeTypes.Pack_Of_Trade_Goods_T1, "Pack of Trade Goods T1" }, 
		{ RecipeTypes.Pack_Of_Trade_Goods_T2, "Pack of Trade Goods T2" }, 
		{ RecipeTypes.Pack_Of_Trade_Goods_T3, "Pack of Trade Goods T3" }, 
		{ RecipeTypes.Pipe_T0, "Pipe T0" }, 
		{ RecipeTypes.Pipe_T1, "Pipe T1" }, 
		{ RecipeTypes.Pipe_T2, "Pipe T2" }, 
		{ RecipeTypes.Pipe_T3, "Pipe T3" }, 
		{ RecipeTypes.R_Amber, "[R] Amber" }, 
		{ RecipeTypes.R_Parts, "[R] Parts" }, 
		{ RecipeTypes.Ruins_Food_Processed_Pickled_Goods_T3, "Ruins [Food Processed] Pickled Goods T3" }, 
		{ RecipeTypes.Ruins_Needs_Fullfilment_Ale_T3, "Ruins [Needs Fullfilment] Ale T3" }, 
		{ RecipeTypes.Ruins_Pack_Of_Crops_T3, "Ruins Pack of Crops T3" }, 
		{ RecipeTypes.Sparkdew, "Sparkdew" }, 
		{ RecipeTypes.T1_Blight_Fuel, "T1 Blight Fuel" }, 
		{ RecipeTypes.TES_Fuel_Core, "[TES] Fuel Core" }, 
		{ RecipeTypes.Tools_Simple_T0, "Tools Simple T0" }, 
		{ RecipeTypes.Tools_Simple_T1, "Tools Simple T1" }, 
		{ RecipeTypes.Tools_Simple_T2, "Tools Simple T2" }, 
		{ RecipeTypes.Tools_Simple_T3, "Tools Simple T3" }, 
		{ RecipeTypes.Vessel_Barrels_T0, "[Vessel] Barrels T0" }, 
		{ RecipeTypes.Vessel_Barrels_T1, "[Vessel] Barrels T1" }, 
		{ RecipeTypes.Vessel_Barrels_T2, "[Vessel] Barrels T2" }, 
		{ RecipeTypes.Vessel_Barrels_T3, "[Vessel] Barrels T3" }, 
		{ RecipeTypes.Vessel_Pottery_T0, "[Vessel] Pottery T0" }, 
		{ RecipeTypes.Vessel_Pottery_T1, "[Vessel] Pottery T1" }, 
		{ RecipeTypes.Vessel_Pottery_T2, "[Vessel] Pottery T2" }, 
		{ RecipeTypes.Vessel_Pottery_T3, "[Vessel] Pottery T3" }, 
		{ RecipeTypes.Vessel_Waterskin_T0, "[Vessel] Waterskin T0" }, 
		{ RecipeTypes.Vessel_Waterskin_T1, "[Vessel] Waterskin T1" }, 
		{ RecipeTypes.Vessel_Waterskin_T2, "[Vessel] Waterskin T2" }, 
		{ RecipeTypes.Vessel_Waterskin_T3, "[Vessel] Waterskin T3" }, 
		{ RecipeTypes.Workshop_Eggs_T1, "Workshop Eggs T1" }, 

	};
}
