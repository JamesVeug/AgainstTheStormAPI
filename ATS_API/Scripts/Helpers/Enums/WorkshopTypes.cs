using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum WorkshopTypes
{
    /// <summary>
    /// Placeholder for an unknown WorkshopTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no WorkshopTypes. Typically, seen if nothing is defined or failed to parse a string to a WorkshopTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// <p>Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Alchemist Hut</name>
	Alchemist_Hut = 1,

	/// <summary>
	/// <p>Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Apothecary</name>
	Apothecary = 2,

	/// <summary>
	/// <p>Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Artisan</name>
	Artisan = 3,

	/// <summary>
	/// <p>Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Bakery</name>
	Bakery = 4,

	/// <summary>
	/// <p>Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Beanery</name>
	Beanery = 5,

	/// <summary>
	/// <p>Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Brewery</name>
	Brewery = 6,

	/// <summary>
	/// <p>Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Brick Oven</name>
	Brick_Oven = 7,

	/// <summary>
	/// <p>Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Brickyard</name>
	Brickyard = 8,

	/// <summary>
	/// <p>Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Butcher</name>
	Butcher = 9,

	/// <summary>
	/// <p>Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cannery</name>
	Cannery = 10,

	/// <summary>
	/// <p>Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Carpenter</name>
	Carpenter = 11,

	/// <summary>
	/// <p>Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cellar</name>
	Cellar = 12,

	/// <summary>
	/// Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2)
	/// </summary>
	/// <name>Clay Pit Workshop</name>
	Clay_Pit_Workshop = 13,

	/// <summary>
	/// <p>Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Clothier</name>
	Clothier = 14,

	/// <summary>
	/// <p>Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Cobbler</name>
	Cobbler = 15,

	/// <summary>
	/// <p>Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cookhouse</name>
	Cookhouse = 16,

	/// <summary>
	/// <p>Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Cooperage</name>
	Cooperage = 17,

	/// <summary>
	/// <p>Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Crude Workstation</name>
	Crude_Workstation = 18,

	/// <summary>
	/// <p>Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Distillery</name>
	Distillery = 19,

	/// <summary>
	/// <p>Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Druid</name>
	Druid = 20,

	/// <summary>
	/// <p>Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Field Kitchen</name>
	Field_Kitchen = 21,

	/// <summary>
	/// <p>Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Finesmith</name>
	Finesmith = 22,

	/// <summary>
	/// <p>Flawless Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3). Has improved production.</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Flawless Brewery</name>
	Flawless_Brewery = 23,

	/// <summary>
	/// <p>Flawless Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3). Has improved production.</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Flawless Cellar</name>
	Flawless_Cellar = 24,

	/// <summary>
	/// <p>Flawless Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3). Has improved production.</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Cooperage</name>
	Flawless_Cooperage = 25,

	/// <summary>
	/// <p>Flawless Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3). Has improved production.</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Druid</name>
	Flawless_Druid = 26,

	/// <summary>
	/// <p>Flawless Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3). Has improved production.</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Leatherworks</name>
	Flawless_Leatherworks = 27,

	/// <summary>
	/// <p>Flawless Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3). Has improved production.</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Rain Mill</name>
	Flawless_Rain_Mill = 28,

	/// <summary>
	/// <p>Flawless Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Flawless Smelter</name>
	Flawless_Smelter = 29,

	/// <summary>
	/// <p>Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Furnace</name>
	Furnace = 30,

	/// <summary>
	/// <p>Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Granary</name>
	Granary = 31,

	/// <summary>
	/// Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
	/// </summary>
	/// <name>Greenhouse Workshop</name>
	Greenhouse_Workshop = 32,

	/// <summary>
	/// <p>Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Grill</name>
	Grill = 33,

	/// <summary>
	/// <p>Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Kiln</name>
	Kiln = 34,

	/// <summary>
	/// <p>Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Leatherworks</name>
	Leatherworks = 35,

	/// <summary>
	/// <p>Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Lumbermill</name>
	Lumbermill = 36,

	/// <summary>
	/// <p>Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Makeshift Post</name>
	Makeshift_Post = 37,

	/// <summary>
	/// <p>Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Manufactory</name>
	Manufactory = 38,

	/// <summary>
	/// <p>Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Pantry</name>
	Pantry = 39,

	/// <summary>
	/// <p>Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Press</name>
	Press = 40,

	/// <summary>
	/// <p>Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Provisioner</name>
	Provisioner = 41,

	/// <summary>
	/// <p>Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Rain Mill</name>
	Rain_Mill = 42,

	/// <summary>
	/// <p>Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Rainpunk Foundry</name>
	Rainpunk_Foundry = 43,

	/// <summary>
	/// <p>Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Ranch</name>
	Ranch = 44,

	/// <summary>
	/// <p>Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Scribe</name>
	Scribe = 45,

	/// <summary>
	/// <p>Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Smelter</name>
	Smelter = 46,

	/// <summary>
	/// <p>Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Smithy</name>
	Smithy = 47,

	/// <summary>
	/// <p>Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Smokehouse</name>
	Smokehouse = 48,

	/// <summary>
	/// <p>Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Stamping Mill</name>
	Stamping_Mill = 49,

	/// <summary>
	/// <p>Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Supplier</name>
	Supplier = 50,

	/// <summary>
	/// <p>Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Tea House</name>
	Tea_House = 51,

	/// <summary>
	/// <p>Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1).</p>
	/// <p>Can use: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Tinctury</name>
	Tinctury = 52,

	/// <summary>
	/// <p>Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Tinkerer</name>
	Tinkerer = 53,

	/// <summary>
	/// <p>Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Toolshop</name>
	Toolshop = 54,

	/// <summary>
	/// <p>Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1).</p>
	/// <p>Can use: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Weaver</name>
	Weaver = 55,

	/// <summary>
	/// <p>Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0).</p>
	/// <p>Can use: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Workshop</name>
	Workshop = 56,



    /// <summary>
    /// The total number of vanilla WorkshopTypes in the game.
    /// </summary>
	MAX = 56
}

/// <summary>
/// Extension methods for the WorkshopTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class WorkshopTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded WorkshopTypes.
	/// </summary>
	public static WorkshopTypes[] All()
	{
		WorkshopTypes[] all = new WorkshopTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every WorkshopTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return WorkshopTypes.Alchemist_Hut in the enum and log an error.
	/// </summary>
	public static string ToName(this WorkshopTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of WorkshopTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[WorkshopTypes.Alchemist_Hut];
	}
	
	/// <summary>
	/// Returns a WorkshopTypes associated with the given name.
	/// Every WorkshopTypes should have a unique name as to distinguish it from others.
	/// If no WorkshopTypes is found, it will return WorkshopTypes.Unknown and log a warning.
	/// </summary>
	public static WorkshopTypes ToWorkshopTypes(this string name)
	{
		foreach (KeyValuePair<WorkshopTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find WorkshopTypes with name: " + name + "\n" + Environment.StackTrace);
		return WorkshopTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a WorkshopModel associated with the given name.
	/// WorkshopModel contain all the data that will be used in the game.
	/// Every WorkshopModel should have a unique name as to distinguish it from others.
	/// If no WorkshopModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.WorkshopModel ToWorkshopModel(this string name)
	{
		Eremite.Buildings.WorkshopModel model = SO.Settings.workshops.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find WorkshopModel for WorkshopTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a WorkshopModel associated with the given WorkshopTypes.
    /// WorkshopModel contain all the data that will be used in the game.
    /// Every WorkshopModel should have a unique name as to distinguish it from others.
    /// If no WorkshopModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Buildings.WorkshopModel ToWorkshopModel(this WorkshopTypes types)
	{
		return types.ToName().ToWorkshopModel();
	}
	
	/// <summary>
	/// Returns an array of WorkshopModel associated with the given WorkshopTypes.
	/// WorkshopModel contain all the data that will be used in the game.
	/// Every WorkshopModel should have a unique name as to distinguish it from others.
	/// If a WorkshopModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.WorkshopModel[] ToWorkshopModelArray(this IEnumerable<WorkshopTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.WorkshopModel[] array = new Eremite.Buildings.WorkshopModel[count];
		int i = 0;
		foreach (WorkshopTypes element in collection)
		{
			array[i++] = element.ToWorkshopModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WorkshopModel associated with the given WorkshopTypes.
	/// WorkshopModel contain all the data that will be used in the game.
	/// Every WorkshopModel should have a unique name as to distinguish it from others.
	/// If a WorkshopModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.WorkshopModel[] ToWorkshopModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.WorkshopModel[] array = new Eremite.Buildings.WorkshopModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToWorkshopModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of WorkshopModel associated with the given WorkshopTypes.
	/// WorkshopModel contain all the data that will be used in the game.
	/// Every WorkshopModel should have a unique name as to distinguish it from others.
	/// If a WorkshopModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.WorkshopModel[] ToWorkshopModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.WorkshopModel>.Get(out List<Eremite.Buildings.WorkshopModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.WorkshopModel model = element.ToWorkshopModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of WorkshopModel associated with the given WorkshopTypes.
	/// WorkshopModel contain all the data that will be used in the game.
	/// Every WorkshopModel should have a unique name as to distinguish it from others.
	/// If a WorkshopModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.WorkshopModel[] ToWorkshopModelArrayNoNulls(this IEnumerable<WorkshopTypes> collection)
	{
		using(ListPool<Eremite.Buildings.WorkshopModel>.Get(out List<Eremite.Buildings.WorkshopModel> list))
		{
			foreach (WorkshopTypes element in collection)
			{
				Eremite.Buildings.WorkshopModel model = element.ToWorkshopModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<WorkshopTypes, string> TypeToInternalName = new()
	{
		{ WorkshopTypes.Alchemist_Hut, "Alchemist Hut" },                 // Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Apothecary, "Apothecary" },                       // Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Artisan, "Artisan" },                             // Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Bakery, "Bakery" },                               // Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Beanery, "Beanery" },                             // Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Brewery, "Brewery" },                             // Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Brick_Oven, "Brick Oven" },                       // Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Brickyard, "Brickyard" },                         // Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Butcher, "Butcher" },                             // Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Cannery, "Cannery" },                             // Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Carpenter, "Carpenter" },                         // Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Cellar, "Cellar" },                               // Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Clay_Pit_Workshop, "Clay Pit Workshop" },         // Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2)
		{ WorkshopTypes.Clothier, "Clothier" },                           // Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Cobbler, "Cobbler" },                             // Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Cookhouse, "Cookhouse" },                         // Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Cooperage, "Cooperage" },                         // Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Crude_Workstation, "Crude Workstation" },         // Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Distillery, "Distillery" },                       // Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Druid, "Druid" },                                 // Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Field_Kitchen, "Field Kitchen" },                 // Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Finesmith, "Finesmith" },                         // Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Flawless_Brewery, "Flawless Brewery" },           // Flawless Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3). Has improved production. Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Flawless_Cellar, "Flawless Cellar" },             // Flawless Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3). Has improved production. Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Flawless_Cooperage, "Flawless Cooperage" },       // Flawless Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3). Has improved production. Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Flawless_Druid, "Flawless Druid" },               // Flawless Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3). Has improved production. Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Flawless_Leatherworks, "Flawless Leatherworks" }, // Flawless Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3). Has improved production. Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Flawless_Rain_Mill, "Flawless Rain Mill" },       // Flawless Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3). Has improved production. Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Flawless_Smelter, "Flawless Smelter" },           // Flawless Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Furnace, "Furnace" },                             // Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Granary, "Granary" },                             // Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Greenhouse_Workshop, "Greenhouse Workshop" },     // Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
		{ WorkshopTypes.Grill, "Grill" },                                 // Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Kiln, "Kiln" },                                   // Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Leatherworks, "Leatherworks" },                   // Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Lumbermill, "Lumbermill" },                       // Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Makeshift_Post, "Makeshift Post" },               // Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Manufactory, "Manufactory" },                     // Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Pantry, "Pantry" },                               // Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Press, "Press" },                                 // Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Provisioner, "Provisioner" },                     // Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Rain_Mill, "Rain Mill" },                         // Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Rainpunk_Foundry, "Rainpunk Foundry" },           // Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Ranch, "Ranch" },                                 // Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Scribe, "Scribe" },                               // Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Smelter, "Smelter" },                             // Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Smithy, "Smithy" },                               // Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Smokehouse, "Smokehouse" },                       // Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Stamping_Mill, "Stamping Mill" },                 // Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Supplier, "Supplier" },                           // Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Tea_House, "Tea House" },                         // Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Tinctury, "Tinctury" },                           // Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1).  Can use: "[water] drizzle water" Drizzle Water.
		{ WorkshopTypes.Tinkerer, "Tinkerer" },                           // Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Toolshop, "Toolshop" },                           // Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2).  Can use: "[water] storm water" Storm Water.
		{ WorkshopTypes.Weaver, "Weaver" },                               // Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1).  Can use: "[water] clearance water" Clearance Water.
		{ WorkshopTypes.Workshop, "Workshop" },                           // Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0).  Can use: "[water] storm water" Storm Water.

	};
}
