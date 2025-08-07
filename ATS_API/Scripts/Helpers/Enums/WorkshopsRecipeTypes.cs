using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.9R
/// </summary>
public enum WorkshopsRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown WorkshopsRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no WorkshopsRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a WorkshopsRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>- todelete - Pack of Luxury Goods</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	_Todelete_Pack_Of_Luxury_Goods = 1,

	/// <summary></summary>
	/// <name>API_ExampleMod_BurgerJoint_API_ExampleMod_Borgor</name>
	API_ExampleMod_BurgerJoint_API_ExampleMod_Borgor = 156,

	/// <summary></summary>
	/// <name>API_ExampleMod_BurgerJoint_API_ExampleMod_Cola</name>
	API_ExampleMod_BurgerJoint_API_ExampleMod_Cola = 157,

	/// <summary></summary>
	/// <name>API_ExampleMod_BurgerJoint_API_ExampleMod_Fries</name>
	API_ExampleMod_BurgerJoint_API_ExampleMod_Fries = 158,

	/// <summary></summary>
	/// <name>[Biome] Fuel Rod T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Other] Fuel Rod</producedGood>
	Biome_Fuel_Rod_T3 = 159,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T0 = 2,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T1 = 3,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T2 = 4,

	/// <summary></summary>
	/// <name>[Building Material] Bricks T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Bricks</producedGood>
	Building_Material_Bricks_T3 = 5,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T0 = 6,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T1 = 7,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T2 = 8,

	/// <summary></summary>
	/// <name>[Building Material] Fabric T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Fabric</producedGood>
	Building_Material_Fabric_T3 = 9,

	/// <summary></summary>
	/// <name>[Building Material] Planks T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T0 = 10,

	/// <summary></summary>
	/// <name>[Building Material] Planks T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T1 = 11,

	/// <summary></summary>
	/// <name>[Building Material] Planks T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T2 = 12,

	/// <summary></summary>
	/// <name>[Building Material] Planks T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Planks</producedGood>
	Building_Material_Planks_T3 = 13,

	/// <summary></summary>
	/// <name>[Clay Pit] Clay T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Clay</producedGood>
	Clay_Pit_Clay_T2 = 14,

	/// <summary></summary>
	/// <name>[Clay Pit] Reeds T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Reeds</producedGood>
	Clay_Pit_Reeds_T2 = 15,

	/// <summary></summary>
	/// <name>[Clay Pit] Resin T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Resin</producedGood>
	Clay_Pit_Resin_T2 = 16,

	/// <summary></summary>
	/// <name>[Clay Pit] Stone T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Raw] Stone</producedGood>
	Clay_Pit_Stone_T2 = 17,

	/// <summary></summary>
	/// <name>Coal T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T0 = 18,

	/// <summary></summary>
	/// <name>Coal T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T1 = 19,

	/// <summary></summary>
	/// <name>Coal T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T2 = 20,

	/// <summary></summary>
	/// <name>Coal T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Coal</producedGood>
	Coal_T3 = 21,

	/// <summary></summary>
	/// <name>Copper Bar T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T0 = 22,

	/// <summary></summary>
	/// <name>Copper Bar T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T1 = 23,

	/// <summary></summary>
	/// <name>Copper Bar T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T2 = 24,

	/// <summary></summary>
	/// <name>Copper Bar T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Copper Bar</producedGood>
	Copper_Bar_T3 = 25,

	/// <summary></summary>
	/// <name>Crystalized Dew T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T0 = 26,

	/// <summary></summary>
	/// <name>Crystalized Dew T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T1 = 27,

	/// <summary></summary>
	/// <name>Crystalized Dew T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T2 = 28,

	/// <summary></summary>
	/// <name>Crystalized Dew T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Metal] Crystalized Dew</producedGood>
	Crystalized_Dew_T3 = 29,

	/// <summary></summary>
	/// <name>Dye T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T0 = 30,

	/// <summary></summary>
	/// <name>Dye T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T1 = 31,

	/// <summary></summary>
	/// <name>Dye T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T2 = 32,

	/// <summary></summary>
	/// <name>Dye T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Dye</producedGood>
	Dye_T3 = 33,

	/// <summary></summary>
	/// <name>Flour T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T0 = 34,

	/// <summary></summary>
	/// <name>Flour T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T1 = 35,

	/// <summary></summary>
	/// <name>Flour T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T2 = 36,

	/// <summary></summary>
	/// <name>Flour T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Flour</producedGood>
	Flour_T3 = 37,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T0 = 38,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T1 = 39,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T2 = 40,

	/// <summary></summary>
	/// <name>[Food Processed] Biscuits T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Biscuits</producedGood>
	Food_Processed_Biscuits_T3 = 41,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T0 = 42,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T1 = 43,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T2 = 44,

	/// <summary></summary>
	/// <name>[Food Processed] Jerky T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Jerky</producedGood>
	Food_Processed_Jerky_T3 = 45,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T0 = 46,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T1 = 47,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T2 = 48,

	/// <summary></summary>
	/// <name>[Food Processed] Paste T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Paste</producedGood>
	Food_Processed_Paste_T3 = 49,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T0 = 50,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T1 = 51,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T2 = 52,

	/// <summary></summary>
	/// <name>[Food Processed] Pickled Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Food_Processed_Pickled_Goods_T3 = 53,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T0 = 54,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T1 = 55,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T2 = 56,

	/// <summary></summary>
	/// <name>[Food Processed] Pie T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pie</producedGood>
	Food_Processed_Pie_T3 = 57,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T0 = 58,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T1 = 59,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T2 = 60,

	/// <summary></summary>
	/// <name>[Food Processed] Porridge T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Porridge</producedGood>
	Food_Processed_Porridge_T3 = 61,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T0 = 62,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T1 = 63,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T2 = 64,

	/// <summary></summary>
	/// <name>[Food Processed] Skewers T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Skewers</producedGood>
	Food_Processed_Skewers_T3 = 65,

	/// <summary></summary>
	/// <name>[Greenhouse] Herbs T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Herbs</producedGood>
	Greenhouse_Herbs_T2 = 66,

	/// <summary></summary>
	/// <name>[Greenhouse] Mushrooms T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Mushrooms</producedGood>
	Greenhouse_Mushrooms_T2 = 67,

	/// <summary></summary>
	/// <name>[Greenhouse] Vegetables T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Food Raw] Vegetables</producedGood>
	Greenhouse_Vegetables_T2 = 68,

	/// <summary></summary>
	/// <name>Hearth Parts T3</name>
	/// <grade>3</grade>
	/// <producedGood>Hearth Parts</producedGood>
	Hearth_Parts_T3 = 69,

	/// <summary></summary>
	/// <name>Leather (workshop) T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Leather</producedGood>
	Leather_workshop_T1 = 70,

	/// <summary></summary>
	/// <name>Meat (workshop) T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Meat</producedGood>
	Meat_workshop_T1 = 71,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T0 = 72,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T1 = 73,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T2 = 74,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Ale T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Needs_Fullfilment_Ale_T3 = 75,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T1 = 76,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T2 = 77,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Boots T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Boots</producedGood>
	Needs_Fullfilment_Boots_T3 = 78,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T0 = 79,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T1 = 80,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T2 = 81,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Coats T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Coats</producedGood>
	Needs_Fullfilment_Coats_T3 = 82,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T0 = 83,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T1 = 84,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T2 = 85,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Incense T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Incense</producedGood>
	Needs_Fullfilment_Incense_T3 = 86,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T0 = 87,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T1 = 88,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T2 = 89,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Scrolls T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Scrolls</producedGood>
	Needs_Fullfilment_Scrolls_T3 = 90,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T0 = 91,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T1 = 92,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T2 = 93,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Tea T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Tea</producedGood>
	Needs_Fullfilment_Tea_T3 = 94,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T0 = 95,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T1 = 96,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T2 = 97,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Training Gear T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Training Gear</producedGood>
	Needs_Fullfilment_Training_Gear_T3 = 98,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T0 = 99,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T1 = 100,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T2 = 101,

	/// <summary></summary>
	/// <name>[Needs Fullfilment] Wine T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Wine</producedGood>
	Needs_Fullfilment_Wine_T3 = 102,

	/// <summary></summary>
	/// <name>Oil T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T0 = 103,

	/// <summary></summary>
	/// <name>Oil T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T1 = 104,

	/// <summary></summary>
	/// <name>Oil T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T2 = 105,

	/// <summary></summary>
	/// <name>Oil T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Crafting] Oil</producedGood>
	Oil_T3 = 106,

	/// <summary></summary>
	/// <name>Pack of Building Materials T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T0 = 107,

	/// <summary></summary>
	/// <name>Pack of Building Materials T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T1 = 108,

	/// <summary></summary>
	/// <name>Pack of Building Materials T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T2 = 109,

	/// <summary></summary>
	/// <name>Pack of Building Materials T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Building Materials</producedGood>
	Pack_Of_Building_Materials_T3 = 110,

	/// <summary></summary>
	/// <name>Pack of Crops T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T0 = 111,

	/// <summary></summary>
	/// <name>Pack of Crops T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T1 = 112,

	/// <summary></summary>
	/// <name>Pack of Crops T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T2 = 113,

	/// <summary></summary>
	/// <name>Pack of Crops T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Pack_Of_Crops_T3 = 114,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T0 = 115,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T1 = 116,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T2 = 117,

	/// <summary></summary>
	/// <name>Pack of Luxury Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Luxury Goods</producedGood>
	Pack_Of_Luxury_Goods_T3 = 118,

	/// <summary></summary>
	/// <name>Pack of Provisions T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T0 = 119,

	/// <summary></summary>
	/// <name>Pack of Provisions T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T1 = 120,

	/// <summary></summary>
	/// <name>Pack of Provisions T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T2 = 121,

	/// <summary></summary>
	/// <name>Pack of Provisions T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Provisions</producedGood>
	Pack_Of_Provisions_T3 = 122,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T0 = 123,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T1 = 124,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T2 = 125,

	/// <summary></summary>
	/// <name>Pack of Trade Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Trade Goods</producedGood>
	Pack_Of_Trade_Goods_T3 = 126,

	/// <summary></summary>
	/// <name>Pipe T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T0 = 127,

	/// <summary></summary>
	/// <name>Pipe T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T1 = 128,

	/// <summary></summary>
	/// <name>Pipe T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T2 = 129,

	/// <summary></summary>
	/// <name>Pipe T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Pipe</producedGood>
	Pipe_T3 = 130,

	/// <summary></summary>
	/// <name>[R] Amber</name>
	/// <grade>3</grade>
	/// <producedGood>[Valuable] Amber</producedGood>
	R_Amber = 131,

	/// <summary></summary>
	/// <name>[R] Parts</name>
	/// <grade>3</grade>
	/// <producedGood>[Mat Processed] Parts</producedGood>
	R_Parts = 132,

	/// <summary></summary>
	/// <name>Ruins [Food Processed] Pickled Goods T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Food Processed] Pickled Goods</producedGood>
	Ruins_Food_Processed_Pickled_Goods_T3 = 133,

	/// <summary></summary>
	/// <name>Ruins [Needs Fullfilment] Ale T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Needs] Ale</producedGood>
	Ruins_Needs_Fullfilment_Ale_T3 = 134,

	/// <summary></summary>
	/// <name>Ruins Pack of Crops T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Packs] Pack of Crops</producedGood>
	Ruins_Pack_Of_Crops_T3 = 135,

	/// <summary></summary>
	/// <name>Sparkdew</name>
	/// <grade>1</grade>
	/// <producedGood>[Mat Raw] Sparkdew</producedGood>
	Sparkdew = 136,

	/// <summary></summary>
	/// <name>T1 Blight Fuel</name>
	/// <grade>3</grade>
	/// <producedGood>Blight Fuel</producedGood>
	T1_Blight_Fuel = 137,

	/// <summary></summary>
	/// <name>[TES] Fuel Core</name>
	/// <grade>1</grade>
	/// <producedGood>[WE] Fuel Core</producedGood>
	TES_Fuel_Core = 138,

	/// <summary></summary>
	/// <name>Tools Simple T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T0 = 139,

	/// <summary></summary>
	/// <name>Tools Simple T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T1 = 140,

	/// <summary></summary>
	/// <name>Tools Simple T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T2 = 141,

	/// <summary></summary>
	/// <name>Tools Simple T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Tools] Simple Tools</producedGood>
	Tools_Simple_T3 = 142,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T0 = 143,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T1 = 144,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T2 = 145,

	/// <summary></summary>
	/// <name>[Vessel] Barrels T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Barrels</producedGood>
	Vessel_Barrels_T3 = 146,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T0 = 147,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T1 = 148,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T2 = 149,

	/// <summary></summary>
	/// <name>[Vessel] Pottery T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Pottery</producedGood>
	Vessel_Pottery_T3 = 150,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T0</name>
	/// <grade>0</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T0 = 151,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T1 = 152,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T2</name>
	/// <grade>2</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T2 = 153,

	/// <summary></summary>
	/// <name>[Vessel] Waterskin T3</name>
	/// <grade>3</grade>
	/// <producedGood>[Vessel] Waterskin</producedGood>
	Vessel_Waterskin_T3 = 154,

	/// <summary></summary>
	/// <name>Workshop Eggs T1</name>
	/// <grade>1</grade>
	/// <producedGood>[Food Raw] Eggs</producedGood>
	Workshop_Eggs_T1 = 155,



	/// <summary>
	/// The total number of vanilla WorkshopsRecipeTypes in the game.
	/// </summary>
	[Obsolete("Use WorkshopsRecipeTypesExtensions.Count(). WorkshopsRecipeTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 160
}

/// <summary>
/// Extension methods for the WorkshopsRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class WorkshopsRecipeTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in WorkshopsRecipeTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded WorkshopsRecipeTypes.
	/// </summary>
	public static WorkshopsRecipeTypes[] All()
	{
		WorkshopsRecipeTypes[] all = new WorkshopsRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every WorkshopsRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return WorkshopsRecipeTypes._Todelete_Pack_Of_Luxury_Goods in the enum and log an error.
	/// </summary>
	public static string ToName(this WorkshopsRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of WorkshopsRecipeTypes: " + type);
		return TypeToInternalName[WorkshopsRecipeTypes._Todelete_Pack_Of_Luxury_Goods];
	}
	
	/// <summary>
	/// Returns a WorkshopsRecipeTypes associated with the given name.
	/// Every WorkshopsRecipeTypes should have a unique name as to distinguish it from others.
	/// If no WorkshopsRecipeTypes is found, it will return WorkshopsRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static WorkshopsRecipeTypes ToWorkshopsRecipeTypes(this string name)
	{
		foreach (KeyValuePair<WorkshopsRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find WorkshopsRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return WorkshopsRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a WorkshopRecipeModel associated with the given name.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If no WorkshopRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel ToWorkshopRecipeModel(this string name)
	{
		Eremite.Buildings.WorkshopRecipeModel model = SO.Settings.workshopsRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find WorkshopRecipeModel for WorkshopsRecipeTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a WorkshopRecipeModel associated with the given WorkshopsRecipeTypes.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If no WorkshopRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel ToWorkshopRecipeModel(this WorkshopsRecipeTypes types)
	{
		return types.ToName().ToWorkshopRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of WorkshopRecipeModel associated with the given WorkshopsRecipeTypes.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If a WorkshopRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel[] ToWorkshopRecipeModelArray(this IEnumerable<WorkshopsRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.WorkshopRecipeModel[] array = new Eremite.Buildings.WorkshopRecipeModel[count];
		int i = 0;
		foreach (WorkshopsRecipeTypes element in collection)
		{
			array[i++] = element.ToWorkshopRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WorkshopRecipeModel associated with the given WorkshopsRecipeTypes.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If a WorkshopRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel[] ToWorkshopRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.WorkshopRecipeModel[] array = new Eremite.Buildings.WorkshopRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToWorkshopRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WorkshopRecipeModel associated with the given WorkshopsRecipeTypes.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If a WorkshopRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel[] ToWorkshopRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.WorkshopRecipeModel>.Get(out List<Eremite.Buildings.WorkshopRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.WorkshopRecipeModel model = element.ToWorkshopRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of WorkshopRecipeModel associated with the given WorkshopsRecipeTypes.
	/// WorkshopRecipeModel contain all the data that will be used in the game.
	/// Every WorkshopRecipeModel should have a unique name as to distinguish it from others.
	/// If a WorkshopRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.WorkshopRecipeModel[] ToWorkshopRecipeModelArrayNoNulls(this IEnumerable<WorkshopsRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.WorkshopRecipeModel>.Get(out List<Eremite.Buildings.WorkshopRecipeModel> list))
		{
			foreach (WorkshopsRecipeTypes element in collection)
			{
				Eremite.Buildings.WorkshopRecipeModel model = element.ToWorkshopRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<WorkshopsRecipeTypes, string> TypeToInternalName = new()
	{
		{ WorkshopsRecipeTypes._Todelete_Pack_Of_Luxury_Goods, "- todelete - Pack of Luxury Goods" }, 
		{ WorkshopsRecipeTypes.API_ExampleMod_BurgerJoint_API_ExampleMod_Borgor, "API_ExampleMod_BurgerJoint_API_ExampleMod_Borgor" }, 
		{ WorkshopsRecipeTypes.API_ExampleMod_BurgerJoint_API_ExampleMod_Cola, "API_ExampleMod_BurgerJoint_API_ExampleMod_Cola" }, 
		{ WorkshopsRecipeTypes.API_ExampleMod_BurgerJoint_API_ExampleMod_Fries, "API_ExampleMod_BurgerJoint_API_ExampleMod_Fries" }, 
		{ WorkshopsRecipeTypes.Biome_Fuel_Rod_T3, "[Biome] Fuel Rod T3" }, 
		{ WorkshopsRecipeTypes.Building_Material_Bricks_T0, "[Building Material] Bricks T0" }, 
		{ WorkshopsRecipeTypes.Building_Material_Bricks_T1, "[Building Material] Bricks T1" }, 
		{ WorkshopsRecipeTypes.Building_Material_Bricks_T2, "[Building Material] Bricks T2" }, 
		{ WorkshopsRecipeTypes.Building_Material_Bricks_T3, "[Building Material] Bricks T3" }, 
		{ WorkshopsRecipeTypes.Building_Material_Fabric_T0, "[Building Material] Fabric T0" }, 
		{ WorkshopsRecipeTypes.Building_Material_Fabric_T1, "[Building Material] Fabric T1" }, 
		{ WorkshopsRecipeTypes.Building_Material_Fabric_T2, "[Building Material] Fabric T2" }, 
		{ WorkshopsRecipeTypes.Building_Material_Fabric_T3, "[Building Material] Fabric T3" }, 
		{ WorkshopsRecipeTypes.Building_Material_Planks_T0, "[Building Material] Planks T0" }, 
		{ WorkshopsRecipeTypes.Building_Material_Planks_T1, "[Building Material] Planks T1" }, 
		{ WorkshopsRecipeTypes.Building_Material_Planks_T2, "[Building Material] Planks T2" }, 
		{ WorkshopsRecipeTypes.Building_Material_Planks_T3, "[Building Material] Planks T3" }, 
		{ WorkshopsRecipeTypes.Clay_Pit_Clay_T2, "[Clay Pit] Clay T2" }, 
		{ WorkshopsRecipeTypes.Clay_Pit_Reeds_T2, "[Clay Pit] Reeds T2" }, 
		{ WorkshopsRecipeTypes.Clay_Pit_Resin_T2, "[Clay Pit] Resin T2" }, 
		{ WorkshopsRecipeTypes.Clay_Pit_Stone_T2, "[Clay Pit] Stone T2" }, 
		{ WorkshopsRecipeTypes.Coal_T0, "Coal T0" }, 
		{ WorkshopsRecipeTypes.Coal_T1, "Coal T1" }, 
		{ WorkshopsRecipeTypes.Coal_T2, "Coal T2" }, 
		{ WorkshopsRecipeTypes.Coal_T3, "Coal T3" }, 
		{ WorkshopsRecipeTypes.Copper_Bar_T0, "Copper Bar T0" }, 
		{ WorkshopsRecipeTypes.Copper_Bar_T1, "Copper Bar T1" }, 
		{ WorkshopsRecipeTypes.Copper_Bar_T2, "Copper Bar T2" }, 
		{ WorkshopsRecipeTypes.Copper_Bar_T3, "Copper Bar T3" }, 
		{ WorkshopsRecipeTypes.Crystalized_Dew_T0, "Crystalized Dew T0" }, 
		{ WorkshopsRecipeTypes.Crystalized_Dew_T1, "Crystalized Dew T1" }, 
		{ WorkshopsRecipeTypes.Crystalized_Dew_T2, "Crystalized Dew T2" }, 
		{ WorkshopsRecipeTypes.Crystalized_Dew_T3, "Crystalized Dew T3" }, 
		{ WorkshopsRecipeTypes.Dye_T0, "Dye T0" }, 
		{ WorkshopsRecipeTypes.Dye_T1, "Dye T1" }, 
		{ WorkshopsRecipeTypes.Dye_T2, "Dye T2" }, 
		{ WorkshopsRecipeTypes.Dye_T3, "Dye T3" }, 
		{ WorkshopsRecipeTypes.Flour_T0, "Flour T0" }, 
		{ WorkshopsRecipeTypes.Flour_T1, "Flour T1" }, 
		{ WorkshopsRecipeTypes.Flour_T2, "Flour T2" }, 
		{ WorkshopsRecipeTypes.Flour_T3, "Flour T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Biscuits_T0, "[Food Processed] Biscuits T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Biscuits_T1, "[Food Processed] Biscuits T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Biscuits_T2, "[Food Processed] Biscuits T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Biscuits_T3, "[Food Processed] Biscuits T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Jerky_T0, "[Food Processed] Jerky T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Jerky_T1, "[Food Processed] Jerky T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Jerky_T2, "[Food Processed] Jerky T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Jerky_T3, "[Food Processed] Jerky T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Paste_T0, "[Food Processed] Paste T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Paste_T1, "[Food Processed] Paste T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Paste_T2, "[Food Processed] Paste T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Paste_T3, "[Food Processed] Paste T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pickled_Goods_T0, "[Food Processed] Pickled Goods T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pickled_Goods_T1, "[Food Processed] Pickled Goods T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pickled_Goods_T2, "[Food Processed] Pickled Goods T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pickled_Goods_T3, "[Food Processed] Pickled Goods T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pie_T0, "[Food Processed] Pie T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pie_T1, "[Food Processed] Pie T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pie_T2, "[Food Processed] Pie T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Pie_T3, "[Food Processed] Pie T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Porridge_T0, "[Food Processed] Porridge T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Porridge_T1, "[Food Processed] Porridge T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Porridge_T2, "[Food Processed] Porridge T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Porridge_T3, "[Food Processed] Porridge T3" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Skewers_T0, "[Food Processed] Skewers T0" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Skewers_T1, "[Food Processed] Skewers T1" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Skewers_T2, "[Food Processed] Skewers T2" }, 
		{ WorkshopsRecipeTypes.Food_Processed_Skewers_T3, "[Food Processed] Skewers T3" }, 
		{ WorkshopsRecipeTypes.Greenhouse_Herbs_T2, "[Greenhouse] Herbs T2" }, 
		{ WorkshopsRecipeTypes.Greenhouse_Mushrooms_T2, "[Greenhouse] Mushrooms T2" }, 
		{ WorkshopsRecipeTypes.Greenhouse_Vegetables_T2, "[Greenhouse] Vegetables T2" }, 
		{ WorkshopsRecipeTypes.Hearth_Parts_T3, "Hearth Parts T3" }, 
		{ WorkshopsRecipeTypes.Leather_workshop_T1, "Leather (workshop) T1" }, 
		{ WorkshopsRecipeTypes.Meat_workshop_T1, "Meat (workshop) T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Ale_T0, "[Needs Fullfilment] Ale T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Ale_T1, "[Needs Fullfilment] Ale T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Ale_T2, "[Needs Fullfilment] Ale T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Ale_T3, "[Needs Fullfilment] Ale T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Boots_T1, "[Needs Fullfilment] Boots T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Boots_T2, "[Needs Fullfilment] Boots T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Boots_T3, "[Needs Fullfilment] Boots T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Coats_T0, "[Needs Fullfilment] Coats T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Coats_T1, "[Needs Fullfilment] Coats T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Coats_T2, "[Needs Fullfilment] Coats T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Coats_T3, "[Needs Fullfilment] Coats T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Incense_T0, "[Needs Fullfilment] Incense T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Incense_T1, "[Needs Fullfilment] Incense T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Incense_T2, "[Needs Fullfilment] Incense T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Incense_T3, "[Needs Fullfilment] Incense T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Scrolls_T0, "[Needs Fullfilment] Scrolls T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Scrolls_T1, "[Needs Fullfilment] Scrolls T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Scrolls_T2, "[Needs Fullfilment] Scrolls T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Scrolls_T3, "[Needs Fullfilment] Scrolls T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Tea_T0, "[Needs Fullfilment] Tea T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Tea_T1, "[Needs Fullfilment] Tea T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Tea_T2, "[Needs Fullfilment] Tea T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Tea_T3, "[Needs Fullfilment] Tea T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Training_Gear_T0, "[Needs Fullfilment] Training Gear T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Training_Gear_T1, "[Needs Fullfilment] Training Gear T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Training_Gear_T2, "[Needs Fullfilment] Training Gear T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Training_Gear_T3, "[Needs Fullfilment] Training Gear T3" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Wine_T0, "[Needs Fullfilment] Wine T0" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Wine_T1, "[Needs Fullfilment] Wine T1" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Wine_T2, "[Needs Fullfilment] Wine T2" }, 
		{ WorkshopsRecipeTypes.Needs_Fullfilment_Wine_T3, "[Needs Fullfilment] Wine T3" }, 
		{ WorkshopsRecipeTypes.Oil_T0, "Oil T0" }, 
		{ WorkshopsRecipeTypes.Oil_T1, "Oil T1" }, 
		{ WorkshopsRecipeTypes.Oil_T2, "Oil T2" }, 
		{ WorkshopsRecipeTypes.Oil_T3, "Oil T3" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Building_Materials_T0, "Pack of Building Materials T0" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Building_Materials_T1, "Pack of Building Materials T1" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Building_Materials_T2, "Pack of Building Materials T2" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Building_Materials_T3, "Pack of Building Materials T3" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Crops_T0, "Pack of Crops T0" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Crops_T1, "Pack of Crops T1" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Crops_T2, "Pack of Crops T2" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Crops_T3, "Pack of Crops T3" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Luxury_Goods_T0, "Pack of Luxury Goods T0" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Luxury_Goods_T1, "Pack of Luxury Goods T1" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Luxury_Goods_T2, "Pack of Luxury Goods T2" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Luxury_Goods_T3, "Pack of Luxury Goods T3" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Provisions_T0, "Pack of Provisions T0" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Provisions_T1, "Pack of Provisions T1" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Provisions_T2, "Pack of Provisions T2" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Provisions_T3, "Pack of Provisions T3" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Trade_Goods_T0, "Pack of Trade Goods T0" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Trade_Goods_T1, "Pack of Trade Goods T1" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Trade_Goods_T2, "Pack of Trade Goods T2" }, 
		{ WorkshopsRecipeTypes.Pack_Of_Trade_Goods_T3, "Pack of Trade Goods T3" }, 
		{ WorkshopsRecipeTypes.Pipe_T0, "Pipe T0" }, 
		{ WorkshopsRecipeTypes.Pipe_T1, "Pipe T1" }, 
		{ WorkshopsRecipeTypes.Pipe_T2, "Pipe T2" }, 
		{ WorkshopsRecipeTypes.Pipe_T3, "Pipe T3" }, 
		{ WorkshopsRecipeTypes.R_Amber, "[R] Amber" }, 
		{ WorkshopsRecipeTypes.R_Parts, "[R] Parts" }, 
		{ WorkshopsRecipeTypes.Ruins_Food_Processed_Pickled_Goods_T3, "Ruins [Food Processed] Pickled Goods T3" }, 
		{ WorkshopsRecipeTypes.Ruins_Needs_Fullfilment_Ale_T3, "Ruins [Needs Fullfilment] Ale T3" }, 
		{ WorkshopsRecipeTypes.Ruins_Pack_Of_Crops_T3, "Ruins Pack of Crops T3" }, 
		{ WorkshopsRecipeTypes.Sparkdew, "Sparkdew" }, 
		{ WorkshopsRecipeTypes.T1_Blight_Fuel, "T1 Blight Fuel" }, 
		{ WorkshopsRecipeTypes.TES_Fuel_Core, "[TES] Fuel Core" }, 
		{ WorkshopsRecipeTypes.Tools_Simple_T0, "Tools Simple T0" }, 
		{ WorkshopsRecipeTypes.Tools_Simple_T1, "Tools Simple T1" }, 
		{ WorkshopsRecipeTypes.Tools_Simple_T2, "Tools Simple T2" }, 
		{ WorkshopsRecipeTypes.Tools_Simple_T3, "Tools Simple T3" }, 
		{ WorkshopsRecipeTypes.Vessel_Barrels_T0, "[Vessel] Barrels T0" }, 
		{ WorkshopsRecipeTypes.Vessel_Barrels_T1, "[Vessel] Barrels T1" }, 
		{ WorkshopsRecipeTypes.Vessel_Barrels_T2, "[Vessel] Barrels T2" }, 
		{ WorkshopsRecipeTypes.Vessel_Barrels_T3, "[Vessel] Barrels T3" }, 
		{ WorkshopsRecipeTypes.Vessel_Pottery_T0, "[Vessel] Pottery T0" }, 
		{ WorkshopsRecipeTypes.Vessel_Pottery_T1, "[Vessel] Pottery T1" }, 
		{ WorkshopsRecipeTypes.Vessel_Pottery_T2, "[Vessel] Pottery T2" }, 
		{ WorkshopsRecipeTypes.Vessel_Pottery_T3, "[Vessel] Pottery T3" }, 
		{ WorkshopsRecipeTypes.Vessel_Waterskin_T0, "[Vessel] Waterskin T0" }, 
		{ WorkshopsRecipeTypes.Vessel_Waterskin_T1, "[Vessel] Waterskin T1" }, 
		{ WorkshopsRecipeTypes.Vessel_Waterskin_T2, "[Vessel] Waterskin T2" }, 
		{ WorkshopsRecipeTypes.Vessel_Waterskin_T3, "[Vessel] Waterskin T3" }, 
		{ WorkshopsRecipeTypes.Workshop_Eggs_T1, "Workshop Eggs T1" }, 

	};
}
