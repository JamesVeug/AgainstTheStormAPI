using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.9R
/// </summary>
public enum BuildingPerkTypes
{
	/// <summary>
	/// Placeholder for an unknown BuildingPerkTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no BuildingPerkTypes. Typically, seen if nothing is defined or failed to parse a string to a BuildingPerkTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Ancient Practices - Archaeologists have learned a lot about a long-lost culture by examining old ruins. All workers get a {0} higher chance of producing double yields for every {1} completed Dangerous and Forbidden Glade Events.
	/// </summary>
	/// <name>Arch Inst - Extra Production</name>
	Arch_Inst_Extra_Production = 1,

	/// <summary>
	/// Decryption - Effect_HostilityForTablets_Desc
	/// </summary>
	/// <name>Arch Inst - Hostility</name>
	Arch_Inst_Hostility = 2,

	/// <summary>
	/// Carved in Stone - Secret methods of dealing with threats are engraved in Ancient Tablets. Scouts work {0} faster on Glade Events for every {1} Reputation Points gained from completed Glade Events.
	/// </summary>
	/// <name>Arch Inst - Relic Working Time</name>
	Arch_Inst_Relic_Working_Time = 3,

	/// <summary>
	/// Escaping the Shadows - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
	/// </summary>
	/// <name>Arch Inst - Saving</name>
	Arch_Inst_Saving = 4,

	/// <summary>
	/// Forbidden Tools - All metal is permeated with malevolent magic from the forest. Every {1} Hostility levels grant {0}.
	/// </summary>
	/// <name>Arch Inst - Tools for Hostility</name>
	Arch_Inst_Tools_For_Hostility = 5,

	/// <summary>
	/// Ancient Strength - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>Arch Inst - Workers carry more</name>
	Arch_Inst_Workers_Carry_More = 6,

	/// <summary>
	/// Catalyst - Rain Engine production bonuses are twice as strong ({0} production speed, {1} double yield chance).
	/// </summary>
	/// <name>[Biome] Fuel Rod</name>
	Biome_Fuel_Rod = 55,

	/// <summary></summary>
	/// <name>[Biome] Fuel Rod Blight Rate</name>
	Biome_Fuel_Rod_Blight_Rate = 56,

	/// <summary>
	/// HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
	/// </summary>
	/// <name>Hauler Cart</name>
	Hauler_Cart = 7,

	/// <summary>
	/// HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
	/// </summary>
	/// <name>Hauler Cart 2</name>
	Hauler_Cart_2 = 8,

	/// <summary>
	/// Short-range Scanner - Reveals the location of the closest archaeological discovery.
	/// </summary>
	/// <name>Highlight Archeology 1</name>
	Highlight_Archeology_1 = 9,

	/// <summary>
	/// Mid-range Scanner - Reveals the location of the second closest archaeological discovery.
	/// </summary>
	/// <name>Highlight Archeology 2</name>
	Highlight_Archeology_2 = 10,

	/// <summary>
	/// Long-range Scanner - Reveals the location of the farthest archaeological discovery.
	/// </summary>
	/// <name>Highlight Archeology 3</name>
	Highlight_Archeology_3 = 11,

	/// <summary>
	/// Rainpunk Shredder - A Rainpunk Shredder will permanently occupy one workplace in every Woodcutters' Camp in the settlement. This large automaton can fell multiple trees without returning to camp. It doesn't eat, doesn't need to rest, and can't produce double yields.
	/// </summary>
	/// <name>Large Woodcutter Automaton</name>
	Large_Woodcutter_Automaton = 57,

	/// <summary></summary>
	/// <name>[PerkCrafter] Fewer Housing Spots - child</name>
	PerkCrafter_Fewer_Housing_Spots_Child = 12,

	/// <summary>
	/// Reliability - Increases the chance for extra production yields by {0}.
	/// </summary>
	/// <name>[R] Extra Production Chance</name>
	R_Extra_Production_Chance = 13,

	/// <summary>
	/// Reliability - Increases the chance for extra production yields by {0}.
	/// </summary>
	/// <name>[R] Extra Production Chance - Cathode</name>
	R_Extra_Production_Chance_Cathode = 58,

	/// <summary>
	/// Reliability - Increases the chance for extra production yields by {0}.
	/// </summary>
	/// <name>[R] Extra Production Chance - Rods</name>
	R_Extra_Production_Chance_Rods = 59,

	/// <summary>
	/// Efficiency - Increases production speed by {0}.
	/// </summary>
	/// <name>[R] Production Rate</name>
	R_Production_Rate = 14,

	/// <summary>
	/// Efficiency - Increases production speed by {0}.
	/// </summary>
	/// <name>[R] Production Rate Core - Cathode</name>
	R_Production_Rate_Core_Cathode = 60,

	/// <summary>
	/// Efficiency - Increases production speed by {0}.
	/// </summary>
	/// <name>[R] Production Rate Core - Rods</name>
	R_Production_Rate_Core_Rods = 61,

	/// <summary>
	/// Low Strain - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	/// </summary>
	/// <name>[R] Rainpunk Comfortable</name>
	R_Rainpunk_Comfortable = 15,

	/// <summary></summary>
	/// <name>Replace Rainpunk Extra Chance - Cathode</name>
	Replace_Rainpunk_Extra_Chance_Cathode = 62,

	/// <summary></summary>
	/// <name>Replace Rainpunk Extra Chance - Rods</name>
	Replace_Rainpunk_Extra_Chance_Rods = 63,

	/// <summary></summary>
	/// <name>Replace Rainpunk Rate 1 - Cathode</name>
	Replace_Rainpunk_Rate_1_Cathode = 64,

	/// <summary></summary>
	/// <name>Replace Rainpunk Rate 1 - Rods</name>
	Replace_Rainpunk_Rate_1_Rods = 65,

	/// <summary></summary>
	/// <name>Replace Rainpunk Rate 2 - Cathode</name>
	Replace_Rainpunk_Rate_2_Cathode = 66,

	/// <summary></summary>
	/// <name>Replace Rainpunk Rate 2 - Rods</name>
	Replace_Rainpunk_Rate_2_Rods = 67,

	/// <summary>
	/// Scouts by Nature - Each Fox scout assigned to a Glade Event reduces its working time by {0}.
	/// </summary>
	/// <name>[Spec] Relics Working Time</name>
	Spec_Relics_Working_Time = 16,

	/// <summary>
	/// Repair Station - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Bat Houses Unique Bonus</name>
	U_Bat_Houses_Unique_Bonus = 68,

	/// <summary>
	/// Writing Desk - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Beaver Houses Unique Bonus</name>
	U_Beaver_Houses_Unique_Bonus = 17,

	/// <summary>
	/// Tank Capacity Increase - Increases tank capacity for the corresponding rainwater type by {0}.
	/// </summary>
	/// <name>[U] Extractor Tank</name>
	U_Extractor_Tank = 18,

	/// <summary>
	/// Lichen - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Fox Houses Unique Bonus</name>
	U_Fox_Houses_Unique_Bonus = 19,

	/// <summary>
	/// Workbench - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Frog House Building Mat Crit</name>
	U_Frog_House_Building_Mat_Crit = 20,

	/// <summary>
	/// Drafting Table - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Frog House Building Mat Speed</name>
	U_Frog_House_Building_Mat_Speed = 21,

	/// <summary>
	/// Water Pipeline - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Frog House More Resolve For Rainpunk</name>
	U_Frog_House_More_Resolve_For_Rainpunk = 22,

	/// <summary>
	/// Atrium - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Frog House Newcomer Bonus</name>
	U_Frog_House_Newcomer_Bonus = 23,

	/// <summary>
	/// Rainwater Storage - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
	/// </summary>
	/// <name>[U] Frog House Water Tank</name>
	U_Frog_House_Water_Tank = 24,

	/// <summary>
	/// Storage Room - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Frog House Yearly Packs</name>
	U_Frog_House_Yearly_Packs = 25,

	/// <summary>
	/// Indoor Pool - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	/// </summary>
	/// <name>[U] Frog Houses Bonus Resolve</name>
	U_Frog_Houses_Bonus_Resolve = 26,

	/// <summary>
	/// Canopy - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Harpy Houses Unique Bonus</name>
	U_Harpy_Houses_Unique_Bonus = 27,

	/// <summary>
	/// HaulerUpgrade_CarryCapacity_Name - HaulerUpgrade_CarryCapacity_Desc
	/// </summary>
	/// <name>[U] Hauler Extra Capacity</name>
	U_Hauler_Extra_Capacity = 28,

	/// <summary>
	/// HaulerUpgrade_Radius_Name - HaulerUpgrade_Radius_Desc
	/// </summary>
	/// <name>[U] Hauler Range</name>
	U_Hauler_Range = 29,

	/// <summary>
	/// HaulerUpgrade_Speed_Name
	/// </summary>
	/// <name>[U] Hauler Speed</name>
	U_Hauler_Speed = 30,

	/// <summary>
	/// HaulerUpgrade_BreakTime_Name
	/// </summary>
	/// <name>[U] Hauler Time Between Breaks</name>
	U_Hauler_Time_Between_Breaks = 31,

	/// <summary>
	/// Extra Room - A strategically built wall can do wonders. This house will have room for one additional villager.
	/// </summary>
	/// <name>[U] Houses Bonus Capacity</name>
	U_Houses_Bonus_Capacity = 32,

	/// <summary>
	/// Stove - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	/// </summary>
	/// <name>[U] Houses Bonus Resolve</name>
	U_Houses_Bonus_Resolve = 33,

	/// <summary>
	/// Soft Beds - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	/// </summary>
	/// <name>[U] Houses Villagers Speed Bonus</name>
	U_Houses_Villagers_Speed_Bonus = 34,

	/// <summary>
	/// Toolshed - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Human Houses Unique Bonus</name>
	U_Human_Houses_Unique_Bonus = 35,

	/// <summary>
	/// Cellar - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	/// </summary>
	/// <name>[U] Lizard Houses Unique Bonus</name>
	U_Lizard_Houses_Unique_Bonus = 36,

	/// <summary>
	/// Box Crib - Miners have found a collapsed tunnel that leads to more mining veins: {0}.
	/// </summary>
	/// <name>[U] Mine Extra Charges Unlock 1</name>
	U_Mine_Extra_Charges_Unlock_1 = 37,

	/// <summary>
	/// Box Crib - Miners have found a collapsed tunnel that leads to more mining veins: {0}.
	/// </summary>
	/// <name>[U] Mine Extra Charges Unlock 2</name>
	U_Mine_Extra_Charges_Unlock_2 = 38,

	/// <summary>
	/// Mine Dredging - A deeper mine level has revealed new mining veins: {0}.
	/// </summary>
	/// <name>[U] Mine Main Charges Unlock 1</name>
	U_Mine_Main_Charges_Unlock_1 = 39,

	/// <summary>
	/// Mine Dredging - A deeper mine level has revealed new mining veins: {0}.
	/// </summary>
	/// <name>[U] Mine Main Charges Unlock 2</name>
	U_Mine_Main_Charges_Unlock_2 = 40,

	/// <summary>
	/// Pit Pony - Where machines can't tread, a pony will be sent. Strong workhorses help the miners and increase production speed by {0}.
	/// </summary>
	/// <name>[U] Mine Production Rate</name>
	U_Mine_Production_Rate = 41,

	/// <summary>
	/// Minecart - {0} {1}
	/// </summary>
	/// <name>[U] Mine Upgrade Cart 1</name>
	U_Mine_Upgrade_Cart_1 = 42,

	/// <summary>
	/// Minecart - {0} {1}
	/// </summary>
	/// <name>[U] Mine Upgrade Cart 2</name>
	U_Mine_Upgrade_Cart_2 = 43,

	/// <summary>
	/// Pit Pony - {0} {1}
	/// </summary>
	/// <name>[U] Mine Upgrade Speed 1</name>
	U_Mine_Upgrade_Speed_1 = 44,

	/// <summary>
	/// Pit Pony - {0} {1}
	/// </summary>
	/// <name>[U] Mine Upgrade Speed 2</name>
	U_Mine_Upgrade_Speed_2 = 45,

	/// <summary>
	/// Automaton - A rainpunk automaton will permanently occupy one workplace. It doesn't eat, and it doesn't need rest. Its sole purpose is to work. Automatons have no chance of producing double yields.
	/// </summary>
	/// <name>[U] Pump Automaton</name>
	U_Pump_Automaton = 46,

	/// <summary>
	/// Minecart - An automated minecart will help miners transport resources from the Mine to the Warehouse.
	/// </summary>
	/// <name>[U] Storage Automaton</name>
	U_Storage_Automaton = 47,

	/// <summary>
	/// HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
	/// </summary>
	/// <name>[U] Woodcutter Hauling Cart</name>
	U_Woodcutter_Hauling_Cart = 69,

	/// <summary>
	/// Blight Automaton - A rainpunk automaton will help Blight Fighters burn Blightrot Cysts during the storm. It doesn't eat and doesn't need to rest. Blight Automatons can't produce "blight fuel" Purging Fire.
	/// </summary>
	/// <name>[U][BP] Blight Fighter Automaton</name>
	UBP_Blight_Fighter_Automaton = 48,

	/// <summary>
	/// Mobile Sparkcasters
	/// </summary>
	/// <name>[U][BP] Blight Fighter Speed</name>
	UBP_Blight_Fighter_Speed = 49,

	/// <summary>
	/// Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of "blight fuel" Purging Fire.
	/// </summary>
	/// <name>[U][BP] Blight Post Production Rate</name>
	UBP_Blight_Post_Production_Rate = 50,

	/// <summary>
	/// Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of "blight fuel" Purging Fire.
	/// </summary>
	/// <name>[U][BP] Extra Production Chance</name>
	UBP_Extra_Production_Chance = 51,

	/// <summary>
	/// Triple Ignition System - An innovative improvement to the flamethrower ignition system. Blight Fighters and Blight Automatons at this Blight Post need {0} seconds less to burn a Blightrot Cyst.
	/// </summary>
	/// <name>[U][BP] Faster Cysts Burning</name>
	UBP_Faster_Cysts_Burning = 52,

	/// <summary>
	/// Manned Lookout
	/// </summary>
	/// <name>[U][BP] Global Background - Cyst Generation Rate</name>
	UBP_Global_Background_Cyst_Generation_Rate = 53,

	/// <summary>
	/// Manned Lookout
	/// </summary>
	/// <name>[U][BP] Global - Cyst Generation Rate</name>
	UBP_Global_Cyst_Generation_Rate = 54,

	/// <summary>
	/// Clear-cutting - No tree or stump goes to waste. Woodcutters in this camp have a {0} higher chance of producing double yields.
	/// </summary>
	/// <name>[U][W] Extra Production Chance</name>
	UW_Extra_Production_Chance = 70,

	/// <summary>
	/// Pack Frame - A special wooden frame that makes transporting resources a lot easier. Woodcutters working in a camp with this upgrade can carry {0} more items of the same type.
	/// </summary>
	/// <name>[U][W] Woodcutter Capacity</name>
	UW_Woodcutter_Capacity = 71,

	/// <summary>
	/// Logging Boots
	/// </summary>
	/// <name>[U][W] Woodcutter Speed</name>
	UW_Woodcutter_Speed = 72,

	/// <summary>
	/// Lumber Cart - An automated hauling cart will help woodcutters transport resources from the Woodcutters' Camp to the Warehouse.
	/// </summary>
	/// <name>[U][W] Woodcutting Storage Automaton</name>
	UW_Woodcutting_Storage_Automaton = 73,



	/// <summary>
	/// The total number of vanilla BuildingPerkTypes in the game.
	/// </summary>
	[Obsolete("Use BuildingPerkTypesExtensions.Count(). BuildingPerkTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 74
}

/// <summary>
/// Extension methods for the BuildingPerkTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class BuildingPerkTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in BuildingPerkTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded BuildingPerkTypes.
	/// </summary>
	public static BuildingPerkTypes[] All()
	{
		BuildingPerkTypes[] all = new BuildingPerkTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BuildingPerkTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BuildingPerkTypes.Arch_Inst_Extra_Production in the enum and log an error.
	/// </summary>
	public static string ToName(this BuildingPerkTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of BuildingPerkTypes: " + type);
		return TypeToInternalName[BuildingPerkTypes.Arch_Inst_Extra_Production];
	}
	
	/// <summary>
	/// Returns a BuildingPerkTypes associated with the given name.
	/// Every BuildingPerkTypes should have a unique name as to distinguish it from others.
	/// If no BuildingPerkTypes is found, it will return BuildingPerkTypes.Unknown and log a warning.
	/// </summary>
	public static BuildingPerkTypes ToBuildingPerkTypes(this string name)
	{
		foreach (KeyValuePair<BuildingPerkTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find BuildingPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingPerkTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a BuildingPerkModel associated with the given name.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If no BuildingPerkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel ToBuildingPerkModel(this string name)
	{
		Eremite.Model.BuildingPerkModel model = SO.Settings.buildingsPerks.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find BuildingPerkModel for BuildingPerkTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a BuildingPerkModel associated with the given BuildingPerkTypes.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If no BuildingPerkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel ToBuildingPerkModel(this BuildingPerkTypes types)
	{
		return types.ToName().ToBuildingPerkModel();
	}
	
	/// <summary>
	/// Returns an array of BuildingPerkModel associated with the given BuildingPerkTypes.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If a BuildingPerkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel[] ToBuildingPerkModelArray(this IEnumerable<BuildingPerkTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.BuildingPerkModel[] array = new Eremite.Model.BuildingPerkModel[count];
		int i = 0;
		foreach (BuildingPerkTypes element in collection)
		{
			array[i++] = element.ToBuildingPerkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingPerkModel associated with the given BuildingPerkTypes.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If a BuildingPerkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel[] ToBuildingPerkModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.BuildingPerkModel[] array = new Eremite.Model.BuildingPerkModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingPerkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingPerkModel associated with the given BuildingPerkTypes.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If a BuildingPerkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel[] ToBuildingPerkModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.BuildingPerkModel>.Get(out List<Eremite.Model.BuildingPerkModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.BuildingPerkModel model = element.ToBuildingPerkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BuildingPerkModel associated with the given BuildingPerkTypes.
	/// BuildingPerkModel contain all the data that will be used in the game.
	/// Every BuildingPerkModel should have a unique name as to distinguish it from others.
	/// If a BuildingPerkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.BuildingPerkModel[] ToBuildingPerkModelArrayNoNulls(this IEnumerable<BuildingPerkTypes> collection)
	{
		using(ListPool<Eremite.Model.BuildingPerkModel>.Get(out List<Eremite.Model.BuildingPerkModel> list))
		{
			foreach (BuildingPerkTypes element in collection)
			{
				Eremite.Model.BuildingPerkModel model = element.ToBuildingPerkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BuildingPerkTypes, string> TypeToInternalName = new()
	{
		{ BuildingPerkTypes.Arch_Inst_Extra_Production, "Arch Inst - Extra Production" },                                     // Ancient Practices - Archaeologists have learned a lot about a long-lost culture by examining old ruins. All workers get a {0} higher chance of producing double yields for every {1} completed Dangerous and Forbidden Glade Events.
		{ BuildingPerkTypes.Arch_Inst_Hostility, "Arch Inst - Hostility" },                                                   // Decryption - Effect_HostilityForTablets_Desc
		{ BuildingPerkTypes.Arch_Inst_Relic_Working_Time, "Arch Inst - Relic Working Time" },                                 // Carved in Stone - Secret methods of dealing with threats are engraved in Ancient Tablets. Scouts work {0} faster on Glade Events for every {1} Reputation Points gained from completed Glade Events.
		{ BuildingPerkTypes.Arch_Inst_Saving, "Arch Inst - Saving" },                                                         // Escaping the Shadows - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
		{ BuildingPerkTypes.Arch_Inst_Tools_For_Hostility, "Arch Inst - Tools for Hostility" },                               // Forbidden Tools - All metal is permeated with malevolent magic from the forest. Every {1} Hostility levels grant {0}.
		{ BuildingPerkTypes.Arch_Inst_Workers_Carry_More, "Arch Inst - Workers carry more" },                                 // Ancient Strength - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.Biome_Fuel_Rod, "[Biome] Fuel Rod" },                                                             // Catalyst - Rain Engine production bonuses are twice as strong ({0} production speed, {1} double yield chance).
		{ BuildingPerkTypes.Biome_Fuel_Rod_Blight_Rate, "[Biome] Fuel Rod Blight Rate" }, 
		{ BuildingPerkTypes.Hauler_Cart, "Hauler Cart" },                                                                     // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
		{ BuildingPerkTypes.Hauler_Cart_2, "Hauler Cart 2" },                                                                 // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
		{ BuildingPerkTypes.Highlight_Archeology_1, "Highlight Archeology 1" },                                               // Short-range Scanner - Reveals the location of the closest archaeological discovery.
		{ BuildingPerkTypes.Highlight_Archeology_2, "Highlight Archeology 2" },                                               // Mid-range Scanner - Reveals the location of the second closest archaeological discovery.
		{ BuildingPerkTypes.Highlight_Archeology_3, "Highlight Archeology 3" },                                               // Long-range Scanner - Reveals the location of the farthest archaeological discovery.
		{ BuildingPerkTypes.Large_Woodcutter_Automaton, "Large Woodcutter Automaton" },                                       // Rainpunk Shredder - A Rainpunk Shredder will permanently occupy one workplace in every Woodcutters' Camp in the settlement. This large automaton can fell multiple trees without returning to camp. It doesn't eat, doesn't need to rest, and can't produce double yields.
		{ BuildingPerkTypes.PerkCrafter_Fewer_Housing_Spots_Child, "[PerkCrafter] Fewer Housing Spots - child" }, 
		{ BuildingPerkTypes.R_Extra_Production_Chance, "[R] Extra Production Chance" },                                       // Reliability - Increases the chance for extra production yields by {0}.
		{ BuildingPerkTypes.R_Extra_Production_Chance_Cathode, "[R] Extra Production Chance - Cathode" },                     // Reliability - Increases the chance for extra production yields by {0}.
		{ BuildingPerkTypes.R_Extra_Production_Chance_Rods, "[R] Extra Production Chance - Rods" },                           // Reliability - Increases the chance for extra production yields by {0}.
		{ BuildingPerkTypes.R_Production_Rate, "[R] Production Rate" },                                                       // Efficiency - Increases production speed by {0}.
		{ BuildingPerkTypes.R_Production_Rate_Core_Cathode, "[R] Production Rate Core - Cathode" },                           // Efficiency - Increases production speed by {0}.
		{ BuildingPerkTypes.R_Production_Rate_Core_Rods, "[R] Production Rate Core - Rods" },                                 // Efficiency - Increases production speed by {0}.
		{ BuildingPerkTypes.R_Rainpunk_Comfortable, "[R] Rainpunk Comfortable" },                                             // Low Strain - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
		{ BuildingPerkTypes.Replace_Rainpunk_Extra_Chance_Cathode, "Replace Rainpunk Extra Chance - Cathode" }, 
		{ BuildingPerkTypes.Replace_Rainpunk_Extra_Chance_Rods, "Replace Rainpunk Extra Chance - Rods" }, 
		{ BuildingPerkTypes.Replace_Rainpunk_Rate_1_Cathode, "Replace Rainpunk Rate 1 - Cathode" }, 
		{ BuildingPerkTypes.Replace_Rainpunk_Rate_1_Rods, "Replace Rainpunk Rate 1 - Rods" }, 
		{ BuildingPerkTypes.Replace_Rainpunk_Rate_2_Cathode, "Replace Rainpunk Rate 2 - Cathode" }, 
		{ BuildingPerkTypes.Replace_Rainpunk_Rate_2_Rods, "Replace Rainpunk Rate 2 - Rods" }, 
		{ BuildingPerkTypes.Spec_Relics_Working_Time, "[Spec] Relics Working Time" },                                         // Scouts by Nature - Each Fox scout assigned to a Glade Event reduces its working time by {0}.
		{ BuildingPerkTypes.U_Bat_Houses_Unique_Bonus, "[U] Bat Houses Unique Bonus" },                                       // Repair Station - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Beaver_Houses_Unique_Bonus, "[U] Beaver Houses Unique Bonus" },                                 // Writing Desk - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Extractor_Tank, "[U] Extractor Tank" },                                                         // Tank Capacity Increase - Increases tank capacity for the corresponding rainwater type by {0}.
		{ BuildingPerkTypes.U_Fox_Houses_Unique_Bonus, "[U] Fox Houses Unique Bonus" },                                       // Lichen - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_House_Building_Mat_Crit, "[U] Frog House Building Mat Crit" },                             // Workbench - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_House_Building_Mat_Speed, "[U] Frog House Building Mat Speed" },                           // Drafting Table - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_House_More_Resolve_For_Rainpunk, "[U] Frog House More Resolve For Rainpunk" },             // Water Pipeline - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_House_Newcomer_Bonus, "[U] Frog House Newcomer Bonus" },                                   // Atrium - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_House_Water_Tank, "[U] Frog House Water Tank" },                                           // Rainwater Storage - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
		{ BuildingPerkTypes.U_Frog_House_Yearly_Packs, "[U] Frog House Yearly Packs" },                                       // Storage Room - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Frog_Houses_Bonus_Resolve, "[U] Frog Houses Bonus Resolve" },                                   // Indoor Pool - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
		{ BuildingPerkTypes.U_Harpy_Houses_Unique_Bonus, "[U] Harpy Houses Unique Bonus" },                                   // Canopy - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Hauler_Extra_Capacity, "[U] Hauler Extra Capacity" },                                           // HaulerUpgrade_CarryCapacity_Name - HaulerUpgrade_CarryCapacity_Desc
		{ BuildingPerkTypes.U_Hauler_Range, "[U] Hauler Range" },                                                             // HaulerUpgrade_Radius_Name - HaulerUpgrade_Radius_Desc
		{ BuildingPerkTypes.U_Hauler_Speed, "[U] Hauler Speed" },                                                             // HaulerUpgrade_Speed_Name
		{ BuildingPerkTypes.U_Hauler_Time_Between_Breaks, "[U] Hauler Time Between Breaks" },                                 // HaulerUpgrade_BreakTime_Name
		{ BuildingPerkTypes.U_Houses_Bonus_Capacity, "[U] Houses Bonus Capacity" },                                           // Extra Room - A strategically built wall can do wonders. This house will have room for one additional villager.
		{ BuildingPerkTypes.U_Houses_Bonus_Resolve, "[U] Houses Bonus Resolve" },                                             // Stove - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
		{ BuildingPerkTypes.U_Houses_Villagers_Speed_Bonus, "[U] Houses Villagers Speed Bonus" },                             // Soft Beds - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
		{ BuildingPerkTypes.U_Human_Houses_Unique_Bonus, "[U] Human Houses Unique Bonus" },                                   // Toolshed - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Lizard_Houses_Unique_Bonus, "[U] Lizard Houses Unique Bonus" },                                 // Cellar - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.U_Mine_Extra_Charges_Unlock_1, "[U] Mine Extra Charges Unlock 1" },                               // Box Crib - Miners have found a collapsed tunnel that leads to more mining veins: {0}.
		{ BuildingPerkTypes.U_Mine_Extra_Charges_Unlock_2, "[U] Mine Extra Charges Unlock 2" },                               // Box Crib - Miners have found a collapsed tunnel that leads to more mining veins: {0}.
		{ BuildingPerkTypes.U_Mine_Main_Charges_Unlock_1, "[U] Mine Main Charges Unlock 1" },                                 // Mine Dredging - A deeper mine level has revealed new mining veins: {0}.
		{ BuildingPerkTypes.U_Mine_Main_Charges_Unlock_2, "[U] Mine Main Charges Unlock 2" },                                 // Mine Dredging - A deeper mine level has revealed new mining veins: {0}.
		{ BuildingPerkTypes.U_Mine_Production_Rate, "[U] Mine Production Rate" },                                             // Pit Pony - Where machines can't tread, a pony will be sent. Strong workhorses help the miners and increase production speed by {0}.
		{ BuildingPerkTypes.U_Mine_Upgrade_Cart_1, "[U] Mine Upgrade Cart 1" },                                               // Minecart - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Cart_2, "[U] Mine Upgrade Cart 2" },                                               // Minecart - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Speed_1, "[U] Mine Upgrade Speed 1" },                                             // Pit Pony - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Speed_2, "[U] Mine Upgrade Speed 2" },                                             // Pit Pony - {0} {1}
		{ BuildingPerkTypes.U_Pump_Automaton, "[U] Pump Automaton" },                                                         // Automaton - A rainpunk automaton will permanently occupy one workplace. It doesn't eat, and it doesn't need rest. Its sole purpose is to work. Automatons have no chance of producing double yields.
		{ BuildingPerkTypes.U_Storage_Automaton, "[U] Storage Automaton" },                                                   // Minecart - An automated minecart will help miners transport resources from the Mine to the Warehouse.
		{ BuildingPerkTypes.U_Woodcutter_Hauling_Cart, "[U] Woodcutter Hauling Cart" },                                       // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
		{ BuildingPerkTypes.UBP_Blight_Fighter_Automaton, "[U][BP] Blight Fighter Automaton" },                               // Blight Automaton - A rainpunk automaton will help Blight Fighters burn Blightrot Cysts during the storm. It doesn't eat and doesn't need to rest. Blight Automatons can't produce "blight fuel" Purging Fire.
		{ BuildingPerkTypes.UBP_Blight_Fighter_Speed, "[U][BP] Blight Fighter Speed" },                                       // Mobile Sparkcasters
		{ BuildingPerkTypes.UBP_Blight_Post_Production_Rate, "[U][BP] Blight Post Production Rate" },                         // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of "blight fuel" Purging Fire.
		{ BuildingPerkTypes.UBP_Extra_Production_Chance, "[U][BP] Extra Production Chance" },                                 // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of "blight fuel" Purging Fire.
		{ BuildingPerkTypes.UBP_Faster_Cysts_Burning, "[U][BP] Faster Cysts Burning" },                                       // Triple Ignition System - An innovative improvement to the flamethrower ignition system. Blight Fighters and Blight Automatons at this Blight Post need {0} seconds less to burn a Blightrot Cyst.
		{ BuildingPerkTypes.UBP_Global_Background_Cyst_Generation_Rate, "[U][BP] Global Background - Cyst Generation Rate" }, // Manned Lookout
		{ BuildingPerkTypes.UBP_Global_Cyst_Generation_Rate, "[U][BP] Global - Cyst Generation Rate" },                       // Manned Lookout
		{ BuildingPerkTypes.UW_Extra_Production_Chance, "[U][W] Extra Production Chance" },                                   // Clear-cutting - No tree or stump goes to waste. Woodcutters in this camp have a {0} higher chance of producing double yields.
		{ BuildingPerkTypes.UW_Woodcutter_Capacity, "[U][W] Woodcutter Capacity" },                                           // Pack Frame - A special wooden frame that makes transporting resources a lot easier. Woodcutters working in a camp with this upgrade can carry {0} more items of the same type.
		{ BuildingPerkTypes.UW_Woodcutter_Speed, "[U][W] Woodcutter Speed" },                                                 // Logging Boots
		{ BuildingPerkTypes.UW_Woodcutting_Storage_Automaton, "[U][W] Woodcutting Storage Automaton" },                       // Lumber Cart - An automated hauling cart will help woodcutters transport resources from the Woodcutters' Camp to the Warehouse.

	};
}
