using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum TagTypes
{
    Unknown = -1,
    None,
	Aggregation_Tag___Caches, 
	Aggregation_Tag___Camps, 
	Aggregation_Tag___Dangerous_Events, 
	Aggregation_Tag___Drills, 
	Aggregation_Tag___Excavation, 
	Aggregation_Tag___Ghosts, 
	Aggregation_Tag___Haunted_Ruin___Beaver_House, 
	Aggregation_Tag___Haunted_Ruin___Brewery, 
	Aggregation_Tag___Haunted_Ruin___Cellar, 
	Aggregation_Tag___Haunted_Ruin___Cooperage, 
	Aggregation_Tag___Haunted_Ruin___Druid, 
	Aggregation_Tag___Haunted_Ruin___Fox_House, 
	Aggregation_Tag___Haunted_Ruin___Harpy_House, 
	Aggregation_Tag___Haunted_Ruin___Herb_Garden, 
	Aggregation_Tag___Haunted_Ruin___Human_House, 
	Aggregation_Tag___Haunted_Ruin___Leatherworks, 
	Aggregation_Tag___Haunted_Ruin___Lizard_House, 
	Aggregation_Tag___Haunted_Ruin___Market, 
	Aggregation_Tag___Haunted_Ruin___Rainmill, 
	Aggregation_Tag___Haunted_Ruin___SmallFarm, 
	Aggregation_Tag___Haunted_Ruin___Smelter, 
	Aggregation_Tag___Haunted_Ruin___Temple, 
	Aggregation_Tag___Hearths, 
	Aggregation_Tag___Ruins, 
	Aggregation_Tag___Storages, 
	Building_Material_Tag, 
	Fabric_Tag, 
	Farm_Recipe_Tag, 
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
	Relic_Archeology, 
	Relic_Chest, 
	Tag_Beaver, 
	Tag_Blight, 
	Tag_Event___Send_To_Citadel_Reward, 
	Tag_Fox, 
	Tag_Harpy, 
	Tag_Human, 
	Tag_Lizzard, 
	Tag_Metal_Bars_In_Recipe, 
	Tag_Profession___Firekeeper, 
	Tag_Profession___Scout, 
	Tag_Profession___Woodcutter, 
	Tag_Rainpunk, 
	Tag_Requires_Fertile_Soil, 
	Tag_Storage_Haulers, 
	Tag_Trade, 

    MAX = 58
}

public static class TagTypesExtensions
{
	public static string ToName(this TagTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of TagTypes: " + type);
		return TypeToInternalName[TagTypes.Aggregation_Tag___Caches];
	}
	
	public static ModelTag ToModelTag(this string name)
    {
        ModelTag model = SO.Settings.tags.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find ModelTag for TagTypes with name: " + name);
        return null;
    }

	public static ModelTag ToModelTag(this TagTypes types)
	{
		return types.ToName().ToModelTag();
	}
	
	public static ModelTag[] ToModelTagArray(this IEnumerable<TagTypes> collection)
    {
        int count = collection.Count();
        ModelTag[] array = new ModelTag[count];
        int i = 0;
        foreach (TagTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.tags.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<TagTypes, string> TypeToInternalName = new()
	{
		{ TagTypes.Aggregation_Tag___Caches, "Aggregation Tag - Caches" }, 
		{ TagTypes.Aggregation_Tag___Camps, "Aggregation Tag - Camps" }, 
		{ TagTypes.Aggregation_Tag___Dangerous_Events, "Aggregation Tag - Dangerous Events" }, 
		{ TagTypes.Aggregation_Tag___Drills, "Aggregation Tag - Drills" }, 
		{ TagTypes.Aggregation_Tag___Excavation, "Aggregation Tag - Excavation" }, 
		{ TagTypes.Aggregation_Tag___Ghosts, "Aggregation Tag - Ghosts" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Beaver_House, "Aggregation Tag - Haunted Ruin - Beaver House" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Brewery, "Aggregation Tag - Haunted Ruin - Brewery" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Cellar, "Aggregation Tag - Haunted Ruin - Cellar" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Cooperage, "Aggregation Tag - Haunted Ruin - Cooperage" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Druid, "Aggregation Tag - Haunted Ruin - Druid" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Fox_House, "Aggregation Tag - Haunted Ruin - Fox House" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Harpy_House, "Aggregation Tag - Haunted Ruin - Harpy House" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Herb_Garden, "Aggregation Tag - Haunted Ruin - Herb Garden" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Human_House, "Aggregation Tag - Haunted Ruin - Human House" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Leatherworks, "Aggregation Tag - Haunted Ruin - Leatherworks" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Lizard_House, "Aggregation Tag - Haunted Ruin - Lizard House" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Market, "Aggregation Tag - Haunted Ruin - Market" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Rainmill, "Aggregation Tag - Haunted Ruin - Rainmill" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___SmallFarm, "Aggregation Tag - Haunted Ruin - SmallFarm" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Smelter, "Aggregation Tag - Haunted Ruin - Smelter" }, 
		{ TagTypes.Aggregation_Tag___Haunted_Ruin___Temple, "Aggregation Tag - Haunted Ruin - Temple" }, 
		{ TagTypes.Aggregation_Tag___Hearths, "Aggregation Tag - Hearths" }, 
		{ TagTypes.Aggregation_Tag___Ruins, "Aggregation Tag - Ruins" }, 
		{ TagTypes.Aggregation_Tag___Storages, "Aggregation Tag - Storages" }, 
		{ TagTypes.Building_Material_Tag, "Building Material Tag" }, 
		{ TagTypes.Fabric_Tag, "Fabric Tag" }, 
		{ TagTypes.Farm_Recipe_Tag, "Farm Recipe Tag" }, 
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
		{ TagTypes.Relic_Archeology, "[Relic] Archeology" }, 
		{ TagTypes.Relic_Chest, "[Relic] Chest" }, 
		{ TagTypes.Tag_Beaver, "[Tag] Beaver" }, 
		{ TagTypes.Tag_Blight, "[Tag] Blight" }, 
		{ TagTypes.Tag_Event___Send_To_Citadel_Reward, "[Tag] Event - Send To Citadel Reward" }, 
		{ TagTypes.Tag_Fox, "[Tag] Fox" }, 
		{ TagTypes.Tag_Harpy, "[Tag] Harpy" }, 
		{ TagTypes.Tag_Human, "[Tag] Human" }, 
		{ TagTypes.Tag_Lizzard, "[Tag] Lizzard" }, 
		{ TagTypes.Tag_Metal_Bars_In_Recipe, "[Tag] Metal Bars in recipe" }, 
		{ TagTypes.Tag_Profession___Firekeeper, "[Tag] Profession - Firekeeper" }, 
		{ TagTypes.Tag_Profession___Scout, "[Tag] Profession - Scout" }, 
		{ TagTypes.Tag_Profession___Woodcutter, "[Tag] Profession - Woodcutter" }, 
		{ TagTypes.Tag_Rainpunk, "[Tag] Rainpunk" }, 
		{ TagTypes.Tag_Requires_Fertile_Soil, "[Tag] Requires Fertile Soil" }, 
		{ TagTypes.Tag_Storage_Haulers, "[Tag] Storage Haulers" }, 
		{ TagTypes.Tag_Trade, "[Tag] Trade" }, 
	};
}