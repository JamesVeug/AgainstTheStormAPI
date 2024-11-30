using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.5.5R
public enum TagTypes
{
	Unknown = -1,
	None,
	
	Aggregation_Tag_Caches,

	Aggregation_Tag_Camps,

	Aggregation_Tag_Dangerous_Events,

	Aggregation_Tag_Drills,

	Aggregation_Tag_Excavation,

	Aggregation_Tag_Ghosts,

	Aggregation_Tag_Haunted_Ruin_Beaver_House,

	Aggregation_Tag_Haunted_Ruin_Brewery,

	Aggregation_Tag_Haunted_Ruin_Cellar,

	Aggregation_Tag_Haunted_Ruin_Cooperage,

	Aggregation_Tag_Haunted_Ruin_Druid,

	Aggregation_Tag_Haunted_Ruin_Fox_House,

	Aggregation_Tag_Haunted_Ruin_Frog_House,

	Aggregation_Tag_Haunted_Ruin_Guild_House,

	Aggregation_Tag_Haunted_Ruin_Harpy_House,

	Aggregation_Tag_Haunted_Ruin_Herb_Garden,

	Aggregation_Tag_Haunted_Ruin_Human_House,

	Aggregation_Tag_Haunted_Ruin_Leatherworks,

	Aggregation_Tag_Haunted_Ruin_Lizard_House,

	Aggregation_Tag_Haunted_Ruin_Market,

	Aggregation_Tag_Haunted_Ruin_Rainmill,

	Aggregation_Tag_Haunted_Ruin_SmallFarm,

	Aggregation_Tag_Haunted_Ruin_Smelter,

	Aggregation_Tag_Haunted_Ruin_Temple,

	Aggregation_Tag_Hearths,

	Aggregation_Tag_Ruins,

	Aggregation_Tag_Storages,

	Building_Material_Tag,

	Complex_Food_Tag,

	Copper_Bar_And_Crystalized_Tag,

	Fabric_Tag,

	Farm_Recipe_Tag,

	Fishing_Tag,

	Food_Tag,

	Fuel_Tag,

	Gatherer_Hut_Tag,

	Gathering_Tag,

	Metal_Tag,

	N_FirstGameResultDialog,

	N_Initiation,

	N_IronmanMid,

	N_IronmanPostSeal,

	N_IronmanPreSeal,

	N_IronmanStart,

	Ore_Tag,

	Packs_Tag,

	Recipe_With_Water_Tag,

	Relic_Archeology,

	Relic_Chest,

	Tag_Beaver,

	Tag_Blight,

	Tag_Event_Send_To_Citadel_Reward,

	Tag_Fox,

	Tag_Frog,

	Tag_Harpy,

	Tag_Human,

	Tag_Lizzard,

	Tag_Metal_Bars_In_Recipe,

	Tag_Profession_Blight_Fighters,

	Tag_Profession_Firekeeper,

	Tag_Profession_Miner,

	Tag_Profession_Scout,

	Tag_Profession_Woodcutter,

	Tag_Rainpunk,

	Tag_Requires_Fertile_Soil,

	Tag_Storage_Haulers,

	Tag_Trade,



	MAX = 67
}

public static class TagTypesExtensions
{
	private static TagTypes[] s_All = null;
	public static TagTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new TagTypes[67];
			for (int i = 0; i < 67; i++)
			{
				s_All[i] = (TagTypes)(i+1);
			}
		}
		return s_All;
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

		Plugin.Log.LogError($"Cannot find name of TagTypes: " + type + "\n" + Environment.StackTrace);
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

		Plugin.Log.LogWarning("Cannot find TagTypes with name: " + name + "\n" + Environment.StackTrace);
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
	
		Plugin.Log.LogError("Cannot find ModelTag for TagTypes with name: " + name + "\n" + Environment.StackTrace);
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
