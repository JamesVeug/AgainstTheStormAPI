using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum BuildingPerkTypes
{
	Unknown = -1,
	None,
	Arch_Inst_Extra_Production,                 // Ancient Practices - Archaeologists have learned a lot about a long-lost culture by examining old ruins. All workers get a {0} higher chance of producing double yields for every {1} completed Dangerous and Forbidden Glade Events.
	Arch_Inst_Hostility,                        // Decryption - Effect_HostilityForTablets_Desc
	Arch_Inst_Relic_Working_Time,               // Carved in Stone - Secret methods of dealing with threats are engraved in Ancient Tablets. Scouts work {0} faster on Glade Events for every {1} Reputation Points gained from completed Glade Events.
	Arch_Inst_Saving,                           // Escaping the Shadows - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
	Arch_Inst_Tools_For_Hostility,              // Forbidden Tools - All metal is permeated with malevolent magic from the forest. Every {1} Hostility levels grant {0}.
	Arch_Inst_Workers_Carry_More,               // Ancient Strength - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	Hauler_Cart,                                // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
	Hauler_Cart_2,                              // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
	Highlight_Archeology_1,                     // Short-range Scanner - Reveals the location of the closest archaeological discovery.
	Highlight_Archeology_2,                     // Mid-range Scanner - Reveals the location of the second closest archaeological discovery.
	Highlight_Archeology_3,                     // Long-range Scanner - Reveals the location of the farthest archaeological discovery.
	R_Extra_Production_Chance,                  // Reliability - Increases the chance for extra production yields by {0}.
	R_Production_Rate,                          // Efficiency - Increases production speed by {0}.
	R_Rainpunk_Comfortable,                     // Low Strain - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	Spec_Relics_Working_Time,                   // Scouts by Nature - Each Fox scout assigned to a Glade Event reduces its working time by {0}.
	U_Beaver_Houses_Unique_Bonus,               // Writing Desk - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Extractor_Tank,                           // Tank Capacity Increase - Increases tank capacity for the corresponding rainwater type by {0}.
	U_Fox_Houses_Unique_Bonus,                  // Lichen - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_House_Building_Mat_Crit,             // Workbench - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_House_Building_Mat_Speed,            // Drafting Table - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_House_More_Resolve_For_Rainpunk,     // Water Pipeline - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_House_Newcomer_Bonus,                // Atrium - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_House_Water_Tank,                    // Rainwater Storage - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
	U_Frog_House_Yearly_Packs,                  // Storage Room - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Frog_Houses_Bonus_Resolve,                // Indoor Pool - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	U_Harpy_Houses_Unique_Bonus,                // Canopy - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Hauler_Extra_Capacity,                    // HaulerUpgrade_CarryCapacity_Name - HaulerUpgrade_CarryCapacity_Desc
	U_Hauler_Range,                             // HaulerUpgrade_Radius_Name - HaulerUpgrade_Radius_Desc
	U_Hauler_Speed,                             // HaulerUpgrade_Speed_Name
	U_Hauler_Time_Between_Breaks,               // HaulerUpgrade_BreakTime_Name
	U_Houses_Bonus_Capacity,                    // Extra Room - A strategically built wall can do wonders. This house will have room for one additional villager.
	U_Houses_Bonus_Resolve,                     // Stove - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	U_Houses_Villagers_Speed_Bonus,             // Soft Beds - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
	U_Human_Houses_Unique_Bonus,                // Toolshed - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Lizard_Houses_Unique_Bonus,               // Cellar - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
	U_Mine_Extra_Charges_Unlock_1,              // Box Crib - Miners have found a collapsed tunnel that leads to more ore veins: {0}.
	U_Mine_Extra_Charges_Unlock_2,              // Box Crib - Miners have found a collapsed tunnel that leads to more ore veins: {0}.
	U_Mine_Main_Charges_Unlock_1,               // Mine Dredging - A deeper mine level has revealed new ore veins: {0}.
	U_Mine_Main_Charges_Unlock_2,               // Mine Dredging - A deeper mine level has revealed new ore veins: {0}.
	U_Mine_Production_Rate,                     // Pit Pony - Where machines can't tread, a pony will be sent. Strong workhorses help the miners and increase production speed by {0}.
	U_Mine_Upgrade_Cart_1,                      // Minecart - {0} {1}
	U_Mine_Upgrade_Cart_2,                      // Minecart - {0} {1}
	U_Mine_Upgrade_Speed_1,                     // Pit Pony - {0} {1}
	U_Mine_Upgrade_Speed_2,                     // Pit Pony - {0} {1}
	U_Pump_Automaton,                           // Automaton - A rainpunk automaton will permanently occupy one workplace. It doesn't eat, and it doesn't need rest. Its sole purpose is to work. Automatons have no chance of producing double yields.
	U_Storage_Automaton,                        // Minecart - An automated minecart will help miners transport resources from the Mine to the Warehouse.
	UBP_Blight_Fighter_Automaton,               // Blight Automaton - A rainpunk automaton will help Blight Fighters burn Blightrot Cysts during the storm. It doesn't eat and doesn't need to rest. Blight Automatons can't produce <sprite name="blight fuel"> Purging Fire.
	UBP_Blight_Fighter_Speed,                   // Mobile Sparkcasters
	UBP_Blight_Post_Production_Rate,            // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of <sprite name="blight fuel"> Purging Fire.
	UBP_Extra_Production_Chance,                // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of <sprite name="blight fuel"> Purging Fire.
	UBP_Faster_Cysts_Burning,                   // Triple Ignition System - An innovative improvement to the flamethrower ignition system. Blight Fighters and Blight Automatons at this Blight Post need {0} seconds less to burn a Blightrot Cyst.
	UBP_Global_Background_Cyst_Generation_Rate, // Manned Lookout
	UBP_Global_Cyst_Generation_Rate,            // Manned Lookout


	MAX = 53
}

public static class BuildingPerkTypesExtensions
{
	private static BuildingPerkTypes[] s_All = null;
	public static BuildingPerkTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new BuildingPerkTypes[53];
			for (int i = 0; i < 53; i++)
			{
				s_All[i] = (BuildingPerkTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this BuildingPerkTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingPerkTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[BuildingPerkTypes.Arch_Inst_Extra_Production];
	}
	
	public static BuildingPerkTypes ToBuildingPerkTypes(this string name)
	{
		foreach (KeyValuePair<BuildingPerkTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find BuildingPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingPerkTypes.Unknown;
	}
	
	public static BuildingPerkModel ToBuildingPerkModel(this string name)
	{
		BuildingPerkModel model = SO.Settings.buildingsPerks.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find BuildingPerkModel for BuildingPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static BuildingPerkModel ToBuildingPerkModel(this BuildingPerkTypes types)
	{
		return types.ToName().ToBuildingPerkModel();
	}
	
	public static BuildingPerkModel[] ToBuildingPerkModelArray(this IEnumerable<BuildingPerkTypes> collection)
	{
		int count = collection.Count();
		BuildingPerkModel[] array = new BuildingPerkModel[count];
		int i = 0;
		foreach (BuildingPerkTypes element in collection)
		{
			array[i++] = element.ToBuildingPerkModel();
		}

		return array;
	}
	
	public static BuildingPerkModel[] ToBuildingPerkModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		BuildingPerkModel[] array = new BuildingPerkModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingPerkModel();
		}

		return array;
	}

	internal static readonly Dictionary<BuildingPerkTypes, string> TypeToInternalName = new()
	{
		{ BuildingPerkTypes.Arch_Inst_Extra_Production, "Arch Inst - Extra Production" },                                     // Ancient Practices - Archaeologists have learned a lot about a long-lost culture by examining old ruins. All workers get a {0} higher chance of producing double yields for every {1} completed Dangerous and Forbidden Glade Events.
		{ BuildingPerkTypes.Arch_Inst_Hostility, "Arch Inst - Hostility" },                                                   // Decryption - Effect_HostilityForTablets_Desc
		{ BuildingPerkTypes.Arch_Inst_Relic_Working_Time, "Arch Inst - Relic Working Time" },                                 // Carved in Stone - Secret methods of dealing with threats are engraved in Ancient Tablets. Scouts work {0} faster on Glade Events for every {1} Reputation Points gained from completed Glade Events.
		{ BuildingPerkTypes.Arch_Inst_Saving, "Arch Inst - Saving" },                                                         // Escaping the Shadows - Your archaeologists have learned much from the ancients, but this knowledge has its price. Any villager loss will be prevented at the expense of: {1} {0}.
		{ BuildingPerkTypes.Arch_Inst_Tools_For_Hostility, "Arch Inst - Tools for Hostility" },                               // Forbidden Tools - All metal is permeated with malevolent magic from the forest. Every {1} Hostility levels grant {0}.
		{ BuildingPerkTypes.Arch_Inst_Workers_Carry_More, "Arch Inst - Workers carry more" },                                 // Ancient Strength - Stone tablets reveal the secrets of the ancients' strength. Scouts can carry {0} additional items and move {3} faster for every {1} {2} in the settlement's Warehouses.
		{ BuildingPerkTypes.Hauler_Cart, "Hauler Cart" },                                                                     // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
		{ BuildingPerkTypes.Hauler_Cart_2, "Hauler Cart 2" },                                                                 // HaulerUpgrade_Cart_Name - HaulerUpgrade_Cart_Desc
		{ BuildingPerkTypes.Highlight_Archeology_1, "Highlight Archeology 1" },                                               // Short-range Scanner - Reveals the location of the closest archaeological discovery.
		{ BuildingPerkTypes.Highlight_Archeology_2, "Highlight Archeology 2" },                                               // Mid-range Scanner - Reveals the location of the second closest archaeological discovery.
		{ BuildingPerkTypes.Highlight_Archeology_3, "Highlight Archeology 3" },                                               // Long-range Scanner - Reveals the location of the farthest archaeological discovery.
		{ BuildingPerkTypes.R_Extra_Production_Chance, "[R] Extra Production Chance" },                                       // Reliability - Increases the chance for extra production yields by {0}.
		{ BuildingPerkTypes.R_Production_Rate, "[R] Production Rate" },                                                       // Efficiency - Increases production speed by {0}.
		{ BuildingPerkTypes.R_Rainpunk_Comfortable, "[R] Rainpunk Comfortable" },                                             // Low Strain - Work is much easier with Rain Engines on. Workers gain +5 to Resolve.
		{ BuildingPerkTypes.Spec_Relics_Working_Time, "[Spec] Relics Working Time" },                                         // Scouts by Nature - Each Fox scout assigned to a Glade Event reduces its working time by {0}.
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
		{ BuildingPerkTypes.U_Mine_Extra_Charges_Unlock_1, "[U] Mine Extra Charges Unlock 1" },                               // Box Crib - Miners have found a collapsed tunnel that leads to more ore veins: {0}.
		{ BuildingPerkTypes.U_Mine_Extra_Charges_Unlock_2, "[U] Mine Extra Charges Unlock 2" },                               // Box Crib - Miners have found a collapsed tunnel that leads to more ore veins: {0}.
		{ BuildingPerkTypes.U_Mine_Main_Charges_Unlock_1, "[U] Mine Main Charges Unlock 1" },                                 // Mine Dredging - A deeper mine level has revealed new ore veins: {0}.
		{ BuildingPerkTypes.U_Mine_Main_Charges_Unlock_2, "[U] Mine Main Charges Unlock 2" },                                 // Mine Dredging - A deeper mine level has revealed new ore veins: {0}.
		{ BuildingPerkTypes.U_Mine_Production_Rate, "[U] Mine Production Rate" },                                             // Pit Pony - Where machines can't tread, a pony will be sent. Strong workhorses help the miners and increase production speed by {0}.
		{ BuildingPerkTypes.U_Mine_Upgrade_Cart_1, "[U] Mine Upgrade Cart 1" },                                               // Minecart - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Cart_2, "[U] Mine Upgrade Cart 2" },                                               // Minecart - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Speed_1, "[U] Mine Upgrade Speed 1" },                                             // Pit Pony - {0} {1}
		{ BuildingPerkTypes.U_Mine_Upgrade_Speed_2, "[U] Mine Upgrade Speed 2" },                                             // Pit Pony - {0} {1}
		{ BuildingPerkTypes.U_Pump_Automaton, "[U] Pump Automaton" },                                                         // Automaton - A rainpunk automaton will permanently occupy one workplace. It doesn't eat, and it doesn't need rest. Its sole purpose is to work. Automatons have no chance of producing double yields.
		{ BuildingPerkTypes.U_Storage_Automaton, "[U] Storage Automaton" },                                                   // Minecart - An automated minecart will help miners transport resources from the Mine to the Warehouse.
		{ BuildingPerkTypes.UBP_Blight_Fighter_Automaton, "[U][BP] Blight Fighter Automaton" },                               // Blight Automaton - A rainpunk automaton will help Blight Fighters burn Blightrot Cysts during the storm. It doesn't eat and doesn't need to rest. Blight Automatons can't produce <sprite name="blight fuel"> Purging Fire.
		{ BuildingPerkTypes.UBP_Blight_Fighter_Speed, "[U][BP] Blight Fighter Speed" },                                       // Mobile Sparkcasters
		{ BuildingPerkTypes.UBP_Blight_Post_Production_Rate, "[U][BP] Blight Post Production Rate" },                         // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of <sprite name="blight fuel"> Purging Fire.
		{ BuildingPerkTypes.UBP_Extra_Production_Chance, "[U][BP] Extra Production Chance" },                                 // Alchemical Forge - Only the most experienced Blight Fighters can operate this machine. Workers at this Blight Post have a {0} higher chance of producing twice the amount of <sprite name="blight fuel"> Purging Fire.
		{ BuildingPerkTypes.UBP_Faster_Cysts_Burning, "[U][BP] Faster Cysts Burning" },                                       // Triple Ignition System - An innovative improvement to the flamethrower ignition system. Blight Fighters and Blight Automatons at this Blight Post need {0} seconds less to burn a Blightrot Cyst.
		{ BuildingPerkTypes.UBP_Global_Background_Cyst_Generation_Rate, "[U][BP] Global Background - Cyst Generation Rate" }, // Manned Lookout
		{ BuildingPerkTypes.UBP_Global_Cyst_Generation_Rate, "[U][BP] Global - Cyst Generation Rate" },                       // Manned Lookout

	};
}
