using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.9.3R
/// </summary>
public enum TagTypes
{
	/// <summary>
	/// Placeholder for an unknown TagTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no TagTypes. Typically, seen if nothing is defined or failed to parse a string to a TagTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Aggregation Tag - Caches</name>
	Aggregation_Tag_Caches = 1,

	/// <summary></summary>
	/// <name>Aggregation Tag - Camps</name>
	Aggregation_Tag_Camps = 2,

	/// <summary></summary>
	/// <name>Aggregation Tag - Dangerous Events</name>
	Aggregation_Tag_Dangerous_Events = 3,

	/// <summary></summary>
	/// <name>Aggregation Tag - Drills</name>
	Aggregation_Tag_Drills = 4,

	/// <summary></summary>
	/// <name>Aggregation Tag - Excavation</name>
	Aggregation_Tag_Excavation = 5,

	/// <summary></summary>
	/// <name>Aggregation Tag - Ghosts</name>
	Aggregation_Tag_Ghosts = 6,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Bat House</name>
	Aggregation_Tag_Haunted_Ruin_Bat_House = 69,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Beaver House</name>
	Aggregation_Tag_Haunted_Ruin_Beaver_House = 7,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Brewery</name>
	Aggregation_Tag_Haunted_Ruin_Brewery = 8,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Cellar</name>
	Aggregation_Tag_Haunted_Ruin_Cellar = 9,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Cooperage</name>
	Aggregation_Tag_Haunted_Ruin_Cooperage = 10,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Druid</name>
	Aggregation_Tag_Haunted_Ruin_Druid = 11,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Fox House</name>
	Aggregation_Tag_Haunted_Ruin_Fox_House = 12,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Frog House</name>
	Aggregation_Tag_Haunted_Ruin_Frog_House = 13,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Guild House</name>
	Aggregation_Tag_Haunted_Ruin_Guild_House = 14,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Harpy House</name>
	Aggregation_Tag_Haunted_Ruin_Harpy_House = 15,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Herb Garden</name>
	Aggregation_Tag_Haunted_Ruin_Herb_Garden = 16,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Human House</name>
	Aggregation_Tag_Haunted_Ruin_Human_House = 17,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Leatherworks</name>
	Aggregation_Tag_Haunted_Ruin_Leatherworks = 18,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Lizard House</name>
	Aggregation_Tag_Haunted_Ruin_Lizard_House = 19,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Market</name>
	Aggregation_Tag_Haunted_Ruin_Market = 20,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Rainmill</name>
	Aggregation_Tag_Haunted_Ruin_Rainmill = 21,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - SmallFarm</name>
	Aggregation_Tag_Haunted_Ruin_SmallFarm = 22,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Smelter</name>
	Aggregation_Tag_Haunted_Ruin_Smelter = 23,

	/// <summary></summary>
	/// <name>Aggregation Tag - Haunted Ruin - Temple</name>
	Aggregation_Tag_Haunted_Ruin_Temple = 24,

	/// <summary></summary>
	/// <name>Aggregation Tag - Hearths</name>
	Aggregation_Tag_Hearths = 25,

	/// <summary></summary>
	/// <name>Aggregation Tag - Ruins</name>
	Aggregation_Tag_Ruins = 26,

	/// <summary></summary>
	/// <name>Aggregation Tag - Storages</name>
	Aggregation_Tag_Storages = 27,

	/// <summary></summary>
	/// <name>Building Material Tag</name>
	Building_Material_Tag = 28,

	/// <summary></summary>
	/// <name>Complex Food Tag</name>
	Complex_Food_Tag = 29,

	/// <summary></summary>
	/// <name>Copper Bar and Crystalized Tag</name>
	Copper_Bar_And_Crystalized_Tag = 30,

	/// <summary></summary>
	/// <name>Fabric Tag</name>
	Fabric_Tag = 31,

	/// <summary></summary>
	/// <name>Farm Recipe Tag</name>
	Farm_Recipe_Tag = 32,

	/// <summary></summary>
	/// <name>Fishing Tag</name>
	Fishing_Tag = 33,

	/// <summary></summary>
	/// <name>Food Tag</name>
	Food_Tag = 34,

	/// <summary></summary>
	/// <name>Fuel Tag</name>
	Fuel_Tag = 35,

	/// <summary></summary>
	/// <name>Gatherer Hut Tag</name>
	Gatherer_Hut_Tag = 36,

	/// <summary></summary>
	/// <name>Gathering Tag</name>
	Gathering_Tag = 37,

	/// <summary></summary>
	/// <name>Metal Tag</name>
	Metal_Tag = 38,

	/// <summary></summary>
	/// <name>[N] FirstGameResultDialog</name>
	N_FirstGameResultDialog = 39,

	/// <summary></summary>
	/// <name>[N] Initiation</name>
	N_Initiation = 40,

	/// <summary></summary>
	/// <name>[N] IronmanMid</name>
	N_IronmanMid = 41,

	/// <summary></summary>
	/// <name>[N] IronmanPostSeal</name>
	N_IronmanPostSeal = 42,

	/// <summary></summary>
	/// <name>[N] IronmanPreSeal</name>
	N_IronmanPreSeal = 43,

	/// <summary></summary>
	/// <name>[N] IronmanStart</name>
	N_IronmanStart = 44,

	/// <summary></summary>
	/// <name>Ore Tag</name>
	Ore_Tag = 45,

	/// <summary></summary>
	/// <name>Packs Tag</name>
	Packs_Tag = 46,

	/// <summary></summary>
	/// <name>Recipe With Water Tag</name>
	Recipe_With_Water_Tag = 47,

	/// <summary></summary>
	/// <name>[Relic] Archeology</name>
	Relic_Archeology = 48,

	/// <summary></summary>
	/// <name>[Relic] Chest</name>
	Relic_Chest = 49,

	/// <summary></summary>
	/// <name>[Relic] Funeral</name>
	Relic_Funeral = 68,

	/// <summary></summary>
	/// <name>[Tag] Bat</name>
	Tag_Bat = 70,

	/// <summary></summary>
	/// <name>[Tag] Beaver</name>
	Tag_Beaver = 50,

	/// <summary></summary>
	/// <name>[Tag] Blight</name>
	Tag_Blight = 51,

	/// <summary></summary>
	/// <name>[Tag] Event - Send To Citadel Reward</name>
	Tag_Event_Send_To_Citadel_Reward = 52,

	/// <summary></summary>
	/// <name>[Tag] Fox</name>
	Tag_Fox = 53,

	/// <summary></summary>
	/// <name>[Tag] Frog</name>
	Tag_Frog = 54,

	/// <summary></summary>
	/// <name>[Tag] Harpy</name>
	Tag_Harpy = 55,

	/// <summary></summary>
	/// <name>[Tag] Human</name>
	Tag_Human = 56,

	/// <summary></summary>
	/// <name>[Tag] Lizzard</name>
	Tag_Lizzard = 57,

	/// <summary></summary>
	/// <name>[Tag] Metal Bars in recipe</name>
	Tag_Metal_Bars_In_Recipe = 58,

	/// <summary></summary>
	/// <name>[Tag] Profession - Blight Fighters</name>
	Tag_Profession_Blight_Fighters = 59,

	/// <summary></summary>
	/// <name>[Tag] Profession - Firekeeper</name>
	Tag_Profession_Firekeeper = 60,

	/// <summary></summary>
	/// <name>[Tag] Profession - Miner</name>
	Tag_Profession_Miner = 61,

	/// <summary></summary>
	/// <name>[Tag] Profession - Scout</name>
	Tag_Profession_Scout = 62,

	/// <summary></summary>
	/// <name>[Tag] Profession - Woodcutter</name>
	Tag_Profession_Woodcutter = 63,

	/// <summary></summary>
	/// <name>[Tag] Rainpunk</name>
	Tag_Rainpunk = 64,

	/// <summary></summary>
	/// <name>[Tag] Requires Fertile Soil</name>
	Tag_Requires_Fertile_Soil = 65,

	/// <summary></summary>
	/// <name>[Tag] Storage Haulers</name>
	Tag_Storage_Haulers = 66,

	/// <summary></summary>
	/// <name>[Tag] Trade</name>
	Tag_Trade = 67,



	/// <summary>
	/// The total number of vanilla TagTypes in the game.
	/// </summary>
	[Obsolete("Use TagTypesExtensions.Count(). TagTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 71
}

/// <summary>
/// Extension methods for the TagTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class TagTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in TagTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded TagTypes.
	/// </summary>
	public static TagTypes[] All()
	{
		TagTypes[] all = new TagTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every TagTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return TagTypes.Aggregation_Tag_Caches in the enum and log an error.
	/// </summary>
	public static string ToName(this TagTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of TagTypes: " + type);
		return TypeToInternalName[TagTypes.Aggregation_Tag_Caches];
	}
	
	/// <summary>
	/// Returns a TagTypes associated with the given name.
	/// Every TagTypes should have a unique name as to distinguish it from others.
	/// If no TagTypes is found, it will return TagTypes.Unknown and log a warning.
	/// </summary>
	public static TagTypes ToTagTypes(this string name)
	{
		foreach (KeyValuePair<TagTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find TagTypes with name: " + name + "\n" + Environment.StackTrace);
		return TagTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a ModelTag associated with the given name.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If no ModelTag is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ModelTag ToModelTag(this string name)
	{
		Eremite.Model.ModelTag model = SO.Settings.tags.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find ModelTag for TagTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a ModelTag associated with the given TagTypes.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If no ModelTag is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ModelTag ToModelTag(this TagTypes types)
	{
		return types.ToName().ToModelTag();
	}
	
	/// <summary>
	/// Returns an array of ModelTag associated with the given TagTypes.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If a ModelTag is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ModelTag[] ToModelTagArray(this IEnumerable<TagTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.ModelTag[] array = new Eremite.Model.ModelTag[count];
		int i = 0;
		foreach (TagTypes element in collection)
		{
			array[i++] = element.ToModelTag();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ModelTag associated with the given TagTypes.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If a ModelTag is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ModelTag[] ToModelTagArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.ModelTag[] array = new Eremite.Model.ModelTag[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToModelTag();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ModelTag associated with the given TagTypes.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If a ModelTag is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ModelTag[] ToModelTagArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.ModelTag>.Get(out List<Eremite.Model.ModelTag> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.ModelTag model = element.ToModelTag();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of ModelTag associated with the given TagTypes.
	/// ModelTag contain all the data that will be used in the game.
	/// Every ModelTag should have a unique name as to distinguish it from others.
	/// If a ModelTag is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ModelTag[] ToModelTagArrayNoNulls(this IEnumerable<TagTypes> collection)
	{
		using(ListPool<Eremite.Model.ModelTag>.Get(out List<Eremite.Model.ModelTag> list))
		{
			foreach (TagTypes element in collection)
			{
				Eremite.Model.ModelTag model = element.ToModelTag();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<TagTypes, string> TypeToInternalName = new()
	{
		{ TagTypes.Aggregation_Tag_Caches, "Aggregation Tag - Caches" }, 
		{ TagTypes.Aggregation_Tag_Camps, "Aggregation Tag - Camps" }, 
		{ TagTypes.Aggregation_Tag_Dangerous_Events, "Aggregation Tag - Dangerous Events" }, 
		{ TagTypes.Aggregation_Tag_Drills, "Aggregation Tag - Drills" }, 
		{ TagTypes.Aggregation_Tag_Excavation, "Aggregation Tag - Excavation" }, 
		{ TagTypes.Aggregation_Tag_Ghosts, "Aggregation Tag - Ghosts" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Bat_House, "Aggregation Tag - Haunted Ruin - Bat House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Beaver_House, "Aggregation Tag - Haunted Ruin - Beaver House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Brewery, "Aggregation Tag - Haunted Ruin - Brewery" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Cellar, "Aggregation Tag - Haunted Ruin - Cellar" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Cooperage, "Aggregation Tag - Haunted Ruin - Cooperage" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Druid, "Aggregation Tag - Haunted Ruin - Druid" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Fox_House, "Aggregation Tag - Haunted Ruin - Fox House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Frog_House, "Aggregation Tag - Haunted Ruin - Frog House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Guild_House, "Aggregation Tag - Haunted Ruin - Guild House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Harpy_House, "Aggregation Tag - Haunted Ruin - Harpy House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Herb_Garden, "Aggregation Tag - Haunted Ruin - Herb Garden" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Human_House, "Aggregation Tag - Haunted Ruin - Human House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Leatherworks, "Aggregation Tag - Haunted Ruin - Leatherworks" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Lizard_House, "Aggregation Tag - Haunted Ruin - Lizard House" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Market, "Aggregation Tag - Haunted Ruin - Market" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Rainmill, "Aggregation Tag - Haunted Ruin - Rainmill" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_SmallFarm, "Aggregation Tag - Haunted Ruin - SmallFarm" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Smelter, "Aggregation Tag - Haunted Ruin - Smelter" }, 
		{ TagTypes.Aggregation_Tag_Haunted_Ruin_Temple, "Aggregation Tag - Haunted Ruin - Temple" }, 
		{ TagTypes.Aggregation_Tag_Hearths, "Aggregation Tag - Hearths" }, 
		{ TagTypes.Aggregation_Tag_Ruins, "Aggregation Tag - Ruins" }, 
		{ TagTypes.Aggregation_Tag_Storages, "Aggregation Tag - Storages" }, 
		{ TagTypes.Building_Material_Tag, "Building Material Tag" }, 
		{ TagTypes.Complex_Food_Tag, "Complex Food Tag" }, 
		{ TagTypes.Copper_Bar_And_Crystalized_Tag, "Copper Bar and Crystalized Tag" }, 
		{ TagTypes.Fabric_Tag, "Fabric Tag" }, 
		{ TagTypes.Farm_Recipe_Tag, "Farm Recipe Tag" }, 
		{ TagTypes.Fishing_Tag, "Fishing Tag" }, 
		{ TagTypes.Food_Tag, "Food Tag" }, 
		{ TagTypes.Fuel_Tag, "Fuel Tag" }, 
		{ TagTypes.Gatherer_Hut_Tag, "Gatherer Hut Tag" }, 
		{ TagTypes.Gathering_Tag, "Gathering Tag" }, 
		{ TagTypes.Metal_Tag, "Metal Tag" }, 
		{ TagTypes.N_FirstGameResultDialog, "[N] FirstGameResultDialog" }, 
		{ TagTypes.N_Initiation, "[N] Initiation" }, 
		{ TagTypes.N_IronmanMid, "[N] IronmanMid" }, 
		{ TagTypes.N_IronmanPostSeal, "[N] IronmanPostSeal" }, 
		{ TagTypes.N_IronmanPreSeal, "[N] IronmanPreSeal" }, 
		{ TagTypes.N_IronmanStart, "[N] IronmanStart" }, 
		{ TagTypes.Ore_Tag, "Ore Tag" }, 
		{ TagTypes.Packs_Tag, "Packs Tag" }, 
		{ TagTypes.Recipe_With_Water_Tag, "Recipe With Water Tag" }, 
		{ TagTypes.Relic_Archeology, "[Relic] Archeology" }, 
		{ TagTypes.Relic_Chest, "[Relic] Chest" }, 
		{ TagTypes.Relic_Funeral, "[Relic] Funeral" }, 
		{ TagTypes.Tag_Bat, "[Tag] Bat" }, 
		{ TagTypes.Tag_Beaver, "[Tag] Beaver" }, 
		{ TagTypes.Tag_Blight, "[Tag] Blight" }, 
		{ TagTypes.Tag_Event_Send_To_Citadel_Reward, "[Tag] Event - Send To Citadel Reward" }, 
		{ TagTypes.Tag_Fox, "[Tag] Fox" }, 
		{ TagTypes.Tag_Frog, "[Tag] Frog" }, 
		{ TagTypes.Tag_Harpy, "[Tag] Harpy" }, 
		{ TagTypes.Tag_Human, "[Tag] Human" }, 
		{ TagTypes.Tag_Lizzard, "[Tag] Lizzard" }, 
		{ TagTypes.Tag_Metal_Bars_In_Recipe, "[Tag] Metal Bars in recipe" }, 
		{ TagTypes.Tag_Profession_Blight_Fighters, "[Tag] Profession - Blight Fighters" }, 
		{ TagTypes.Tag_Profession_Firekeeper, "[Tag] Profession - Firekeeper" }, 
		{ TagTypes.Tag_Profession_Miner, "[Tag] Profession - Miner" }, 
		{ TagTypes.Tag_Profession_Scout, "[Tag] Profession - Scout" }, 
		{ TagTypes.Tag_Profession_Woodcutter, "[Tag] Profession - Woodcutter" }, 
		{ TagTypes.Tag_Rainpunk, "[Tag] Rainpunk" }, 
		{ TagTypes.Tag_Requires_Fertile_Soil, "[Tag] Requires Fertile Soil" }, 
		{ TagTypes.Tag_Storage_Haulers, "[Tag] Storage Haulers" }, 
		{ TagTypes.Tag_Trade, "[Tag] Trade" }, 

	};
}
