using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum TagTypes
{
    Unknown = -1,
    None,
    AggregationTag_Caches,
    AggregationTag_Camps,
    AggregationTag_DangerousEvents,
    AggregationTag_Drills,
    AggregationTag_Excavation,
    AggregationTag_Ghosts,
    AggregationTag_HauntedRuin_BeaverHouse,
    AggregationTag_HauntedRuin_Brewery,
    AggregationTag_HauntedRuin_Cellar,
    AggregationTag_HauntedRuin_Cooperage,
    AggregationTag_HauntedRuin_Druid,
    AggregationTag_HauntedRuin_FoxHouse,
    AggregationTag_HauntedRuin_HarpyHouse,
    AggregationTag_HauntedRuin_HerbGarden,
    AggregationTag_HauntedRuin_HumanHouse,
    AggregationTag_HauntedRuin_Leatherworks,
    AggregationTag_HauntedRuin_LizardHouse,
    AggregationTag_HauntedRuin_Market,
    AggregationTag_HauntedRuin_Rainmill,
    AggregationTag_HauntedRuin_SmallFarm,
    AggregationTag_HauntedRuin_Smelter,
    AggregationTag_HauntedRuin_Temple,
    AggregationTag_Hearths,
    AggregationTag_Ruins,
    AggregationTag_Storages,
    BuildingMaterialTag,
    FabricTag,
    FarmRecipeTag,
    FoodTag,
    FuelTag,
    GathererHutTag,
    GatheringTag,
    MetalTag,
    N_FirstGameResultDialog,
    N_Initiation,
    N_IronmanMid,
    N_IronmanPostSeal,
    N_IronmanPreSeal,
    N_IronmanStart,
    OreTag,
    PacksTag,
    Relic_Archeology,
    Relic_Chest,
    Tag_Beaver,
    Tag_Blight,
    Tag_Event_SendToCitadelReward,
    Tag_Fox,
    Tag_Harpy,
    Tag_Human,
    Tag_Lizzard,
    Tag_MetalBarsInRecipe,
    Tag_Profession_Firekeeper,
    Tag_Profession_Scout,
    Tag_Profession_Woodcutter,
    Tag_Rainpunk,
    Tag_RequiresFertileSoil,
    Tag_StorageHaulers,
    Tag_Trade,
}

public static class TagTypesExtensions
{
    public static ModelTag[] ToTagArray(this List<TagTypes> tags)
    {
        ModelTag[] tagArray = new ModelTag[tags.Count];
        for (int i = 0; i < tags.Count; i++)
        {
            string tagName = tags[i].ToName();
            tagArray[i] = SO.Settings.GetTag(tagName);
        }

        return tagArray;
    }
    
    public static string ToName(this TagTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of Tag type: " + type);
        return "Fabric Tag";
    }
    
    public static ModelTag ToTagModel(this TagTypes type)
    {
        string name = type.ToName();
        ModelTag model = SO.Settings.tags.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }

        Plugin.Log.LogError("Cannot find tag model for type: " + type + " with name: " + name);
        return null;
    }

    internal static readonly Dictionary<TagTypes, string> TypeToInternalName = new()
    {
        { TagTypes.AggregationTag_Caches, "Aggregation Tag - Caches" },
        { TagTypes.AggregationTag_Camps, "Aggregation Tag - Camps" },
        { TagTypes.AggregationTag_DangerousEvents, "Aggregation Tag - Dangerous Events" },
        { TagTypes.AggregationTag_Drills, "Aggregation Tag - Drills" },
        { TagTypes.AggregationTag_Excavation, "Aggregation Tag - Excavation" },
        { TagTypes.AggregationTag_Ghosts, "Aggregation Tag - Ghosts" },
        { TagTypes.AggregationTag_HauntedRuin_BeaverHouse, "Aggregation Tag - Haunted Ruin - Beaver House" },
        { TagTypes.AggregationTag_HauntedRuin_Brewery, "Aggregation Tag - Haunted Ruin - Brewery" },
        { TagTypes.AggregationTag_HauntedRuin_Cellar, "Aggregation Tag - Haunted Ruin - Cellar" },
        { TagTypes.AggregationTag_HauntedRuin_Cooperage, "Aggregation Tag - Haunted Ruin - Cooperage" },
        { TagTypes.AggregationTag_HauntedRuin_Druid, "Aggregation Tag - Haunted Ruin - Druid" },
        { TagTypes.AggregationTag_HauntedRuin_FoxHouse, "Aggregation Tag - Haunted Ruin - Fox House" },
        { TagTypes.AggregationTag_HauntedRuin_HarpyHouse, "Aggregation Tag - Haunted Ruin - Harpy House" },
        { TagTypes.AggregationTag_HauntedRuin_HerbGarden, "Aggregation Tag - Haunted Ruin - Herb Garden" },
        { TagTypes.AggregationTag_HauntedRuin_HumanHouse, "Aggregation Tag - Haunted Ruin - Human House" },
        { TagTypes.AggregationTag_HauntedRuin_Leatherworks, "Aggregation Tag - Haunted Ruin - Leatherworks" },
        { TagTypes.AggregationTag_HauntedRuin_LizardHouse, "Aggregation Tag - Haunted Ruin - Lizard House" },
        { TagTypes.AggregationTag_HauntedRuin_Market, "Aggregation Tag - Haunted Ruin - Market" },
        { TagTypes.AggregationTag_HauntedRuin_Rainmill, "Aggregation Tag - Haunted Ruin - Rainmill" },
        { TagTypes.AggregationTag_HauntedRuin_SmallFarm, "Aggregation Tag - Haunted Ruin - SmallFarm" },
        { TagTypes.AggregationTag_HauntedRuin_Smelter, "Aggregation Tag - Haunted Ruin - Smelter" },
        { TagTypes.AggregationTag_HauntedRuin_Temple, "Aggregation Tag - Haunted Ruin - Temple" },
        { TagTypes.AggregationTag_Hearths, "Aggregation Tag - Hearths" },
        { TagTypes.AggregationTag_Ruins, "Aggregation Tag - Ruins" },
        { TagTypes.AggregationTag_Storages, "Aggregation Tag - Storages" },
        { TagTypes.BuildingMaterialTag, "Building Material Tag" },
        { TagTypes.FabricTag, "Fabric Tag" },
        { TagTypes.FarmRecipeTag, "Farm Recipe Tag" },
        { TagTypes.FoodTag, "Food Tag" },
        { TagTypes.FuelTag, "Fuel Tag" },
        { TagTypes.GathererHutTag, "Gatherer Hut Tag" },
        { TagTypes.GatheringTag, "Gathering Tag" },
        { TagTypes.MetalTag, "Metal Tag" },
        { TagTypes.N_FirstGameResultDialog, "[N] FirstGameResultDialog" },
        { TagTypes.N_Initiation, "[N] Initiation" },
        { TagTypes.N_IronmanMid, "[N] IronmanMid" },
        { TagTypes.N_IronmanPostSeal, "[N] IronmanPostSeal" },
        { TagTypes.N_IronmanPreSeal, "[N] IronmanPreSeal" },
        { TagTypes.N_IronmanStart, "[N] IronmanStart" },
        { TagTypes.OreTag, "Ore Tag" },
        { TagTypes.PacksTag, "Packs Tag" },
        { TagTypes.Relic_Archeology, "[Relic] Archeology" },
        { TagTypes.Relic_Chest, "[Relic] Chest" },
        { TagTypes.Tag_Beaver, "[Tag] Beaver" },
        { TagTypes.Tag_Blight, "[Tag] Blight" },
        { TagTypes.Tag_Event_SendToCitadelReward, "[Tag] Event - Send To Citadel Reward" },
        { TagTypes.Tag_Fox, "[Tag] Fox" },
        { TagTypes.Tag_Harpy, "[Tag] Harpy" },
        { TagTypes.Tag_Human, "[Tag] Human" },
        { TagTypes.Tag_Lizzard, "[Tag] Lizzard" },
        { TagTypes.Tag_MetalBarsInRecipe, "[Tag] Metal Bars in recipe" },
        { TagTypes.Tag_Profession_Firekeeper, "[Tag] Profession - Firekeeper" },
        { TagTypes.Tag_Profession_Scout, "[Tag] Profession - Scout" },
        { TagTypes.Tag_Profession_Woodcutter, "[Tag] Profession - Woodcutter" },
        { TagTypes.Tag_Rainpunk, "[Tag] Rainpunk" },
        { TagTypes.Tag_RequiresFertileSoil, "[Tag] Requires Fertile Soil" },
        { TagTypes.Tag_StorageHaulers, "[Tag] Storage Haulers" },
        { TagTypes.Tag_Trade, "[Tag] Trade" }
    };
}