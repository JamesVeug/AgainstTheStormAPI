using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
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
	
	Aggregation_Tag_Caches = 1,

	Aggregation_Tag_Camps = 2,

	Aggregation_Tag_Dangerous_Events = 3,

	Aggregation_Tag_Drills = 4,

	Aggregation_Tag_Excavation = 5,

	Aggregation_Tag_Ghosts = 6,

	Aggregation_Tag_Haunted_Ruin_Beaver_House = 7,

	Aggregation_Tag_Haunted_Ruin_Brewery = 8,

	Aggregation_Tag_Haunted_Ruin_Cellar = 9,

	Aggregation_Tag_Haunted_Ruin_Cooperage = 10,

	Aggregation_Tag_Haunted_Ruin_Druid = 11,

	Aggregation_Tag_Haunted_Ruin_Fox_House = 12,

	Aggregation_Tag_Haunted_Ruin_Frog_House = 13,

	Aggregation_Tag_Haunted_Ruin_Guild_House = 14,

	Aggregation_Tag_Haunted_Ruin_Harpy_House = 15,

	Aggregation_Tag_Haunted_Ruin_Herb_Garden = 16,

	Aggregation_Tag_Haunted_Ruin_Human_House = 17,

	Aggregation_Tag_Haunted_Ruin_Leatherworks = 18,

	Aggregation_Tag_Haunted_Ruin_Lizard_House = 19,

	Aggregation_Tag_Haunted_Ruin_Market = 20,

	Aggregation_Tag_Haunted_Ruin_Rainmill = 21,

	Aggregation_Tag_Haunted_Ruin_SmallFarm = 22,

	Aggregation_Tag_Haunted_Ruin_Smelter = 23,

	Aggregation_Tag_Haunted_Ruin_Temple = 24,

	Aggregation_Tag_Hearths = 25,

	Aggregation_Tag_Ruins = 26,

	Aggregation_Tag_Storages = 27,

	Building_Material_Tag = 28,

	Complex_Food_Tag = 29,

	Copper_Bar_And_Crystalized_Tag = 30,

	Fabric_Tag = 31,

	Farm_Recipe_Tag = 32,

	Fishing_Tag = 33,

	Food_Tag = 34,

	Fuel_Tag = 35,

	Gatherer_Hut_Tag = 36,

	Gathering_Tag = 37,

	Metal_Tag = 38,

	N_FirstGameResultDialog = 39,

	N_Initiation = 40,

	N_IronmanMid = 41,

	N_IronmanPostSeal = 42,

	N_IronmanPreSeal = 43,

	N_IronmanStart = 44,

	Ore_Tag = 45,

	Packs_Tag = 46,

	Recipe_With_Water_Tag = 47,

	Relic_Archeology = 48,

	Relic_Chest = 49,

	Tag_Beaver = 50,

	Tag_Blight = 51,

	Tag_Event_Send_To_Citadel_Reward = 52,

	Tag_Fox = 53,

	Tag_Frog = 54,

	Tag_Harpy = 55,

	Tag_Human = 56,

	Tag_Lizzard = 57,

	Tag_Metal_Bars_In_Recipe = 58,

	Tag_Profession_Blight_Fighters = 59,

	Tag_Profession_Firekeeper = 60,

	Tag_Profession_Miner = 61,

	Tag_Profession_Scout = 62,

	Tag_Profession_Woodcutter = 63,

	Tag_Rainpunk = 64,

	Tag_Requires_Fertile_Soil = 65,

	Tag_Storage_Haulers = 66,

	Tag_Trade = 67,



    /// <summary>
    /// The total number of vanilla TagTypes in the game.
    /// </summary>
	MAX = 67
}

/// <summary>
/// Extension methods for the TagTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class TagTypesExtensions
{
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

		APILogger.LogError($"Cannot find name of TagTypes: " + type + "\n" + Environment.StackTrace);
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
	
		APILogger.LogError("Cannot find ModelTag for TagTypes with name: " + name + "\n" + Environment.StackTrace);
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
