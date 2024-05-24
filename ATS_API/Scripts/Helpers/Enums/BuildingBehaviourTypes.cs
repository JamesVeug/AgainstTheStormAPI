using System;
using System.Collections.Generic;

namespace ATS_API.Helpers;

public enum BuildingBehaviourTypes
{
    Unknown = -1,
    None,
    Alter,
    BlightPost,
    Camp,
    Collector,
    Decoration,
    Extractor,
    Farm,
    FarmField,
    GathererHut,
    Hearth,
    House,
    Hydrant,
    Institution,
    Mine,
    RainCatcher,
    Relic,
    Road,
    Seal,
    Shrine,
    Storage,
    TradingPost,
    Workshop
}

public static class BuildingBehaviourTypesExtensions
{
    public static Type ToEremiteType(this BuildingBehaviourTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of BuildingBehaviour Eremite type: " + type);
        return typeof(Eremite.Buildings.Altar);
    }
    
    public static string ToEremitePrefabName(this BuildingBehaviourTypes type)
    {
        if (TypeToPrefabName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of BuildingBehaviour Eremite type: " + type);
        return "Altar";
    }
    
    public static string ToAssetBundlePrefabName(this BuildingBehaviourTypes type)
    {
        if (TypeToAssetBundlePrefabName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find prefab name for type: " + type);
        return "CustomBuilding";
    }

    internal static readonly Dictionary<BuildingBehaviourTypes, Type> TypeToInternalName = new()
    {
        { BuildingBehaviourTypes.Alter, typeof(Eremite.Buildings.Altar) },
        { BuildingBehaviourTypes.FarmField, typeof(Eremite.Buildings.Farmfield) },
        { BuildingBehaviourTypes.Hydrant, typeof(Eremite.Buildings.Hydrant) },
        { BuildingBehaviourTypes.Road, typeof(Eremite.Buildings.Road) },
        { BuildingBehaviourTypes.Seal, typeof(Eremite.Buildings.Seal) },
        { BuildingBehaviourTypes.Shrine, typeof(Eremite.Buildings.Shrine) },
        { BuildingBehaviourTypes.TradingPost, typeof(Eremite.Buildings.TradingPost) },
        { BuildingBehaviourTypes.BlightPost, typeof(Eremite.Buildings.BlightPost) },
        { BuildingBehaviourTypes.Camp, typeof(Eremite.Buildings.Camp) },
        { BuildingBehaviourTypes.Collector, typeof(Eremite.Buildings.Collector) },
        { BuildingBehaviourTypes.Decoration, typeof(Eremite.Buildings.Decoration) },
        { BuildingBehaviourTypes.Extractor, typeof(Eremite.Buildings.Extractor) },
        { BuildingBehaviourTypes.Farm, typeof(Eremite.Buildings.Farm) },
        { BuildingBehaviourTypes.GathererHut, typeof(Eremite.Buildings.GathererHut) },
        { BuildingBehaviourTypes.Hearth, typeof(Eremite.Buildings.Hearth) },
        { BuildingBehaviourTypes.House, typeof(Eremite.Buildings.House) },
        { BuildingBehaviourTypes.Institution, typeof(Eremite.Buildings.Institution) },
        { BuildingBehaviourTypes.Mine, typeof(Eremite.Buildings.Mine) },
        { BuildingBehaviourTypes.RainCatcher, typeof(Eremite.Buildings.RainCatcher) },
        { BuildingBehaviourTypes.Relic, typeof(Eremite.Buildings.Relic) },
        { BuildingBehaviourTypes.Storage, typeof(Eremite.Buildings.Storage) },
        { BuildingBehaviourTypes.Workshop, typeof(Eremite.Buildings.Workshop) },
    };
    
    internal static readonly Dictionary<BuildingBehaviourTypes, string> TypeToPrefabName = new()
    {
        { BuildingBehaviourTypes.Alter, "Altar" },
        { BuildingBehaviourTypes.FarmField, "Farmfield" },
        { BuildingBehaviourTypes.Hydrant, "Hydrant" },
        { BuildingBehaviourTypes.Road, "Path" },
        { BuildingBehaviourTypes.Seal, "Seal" },
        { BuildingBehaviourTypes.Shrine, "Sealed Biome Shrine" },
        { BuildingBehaviourTypes.TradingPost, "Trading Post" },
        { BuildingBehaviourTypes.BlightPost, "Blight Post" },
        { BuildingBehaviourTypes.Camp, "Woodcutters Camp" },
        // { BuildingBehaviourTypes.Collector, null }, // Deprecated????
        { BuildingBehaviourTypes.Decoration, "Ancient Gravestone" },
        { BuildingBehaviourTypes.Extractor, "Water Extractor" },
        { BuildingBehaviourTypes.Farm, "SmallFarm" },
        { BuildingBehaviourTypes.GathererHut, "Stonecutter's Camp" },
        { BuildingBehaviourTypes.Hearth, "Small Hearth" },
        { BuildingBehaviourTypes.House, "Beaver House" },
        { BuildingBehaviourTypes.Institution, "Bath House" },
        { BuildingBehaviourTypes.Mine, "Mine" },
        { BuildingBehaviourTypes.RainCatcher, "Rain Catcher" },
        { BuildingBehaviourTypes.Relic, "RewardChest_T1" },
        { BuildingBehaviourTypes.Storage, "Storage (buildable)" },
        { BuildingBehaviourTypes.Workshop, "Tinctury" },
    };
    
    internal static readonly Dictionary<BuildingBehaviourTypes, string> TypeToAssetBundlePrefabName = new()
    {
        { BuildingBehaviourTypes.Alter, "CustomBuilding" },
        { BuildingBehaviourTypes.FarmField, "CustomBuilding" },
        { BuildingBehaviourTypes.Hydrant, "CustomBuilding" },
        { BuildingBehaviourTypes.Road, "CustomBuilding" },
        { BuildingBehaviourTypes.Seal, "CustomBuilding" },
        { BuildingBehaviourTypes.Shrine, "CustomBuilding" },
        { BuildingBehaviourTypes.TradingPost, "CustomBuilding" },
        { BuildingBehaviourTypes.BlightPost, "CustomBuilding" },
        { BuildingBehaviourTypes.Camp, "CustomBuilding" },
        // { BuildingBehaviourTypes.Collector, "CustomBuilding" },
        { BuildingBehaviourTypes.Decoration, "CustomBuilding" },
        { BuildingBehaviourTypes.Extractor, "CustomBuilding" },
        { BuildingBehaviourTypes.Farm, "CustomBuilding" },
        { BuildingBehaviourTypes.GathererHut, "CustomBuilding" },
        { BuildingBehaviourTypes.Hearth, "CustomBuilding" },
        { BuildingBehaviourTypes.House, "CustomBuilding" },
        { BuildingBehaviourTypes.Institution, "CustomBuilding" },
        { BuildingBehaviourTypes.Mine, "CustomBuilding" },
        { BuildingBehaviourTypes.RainCatcher, "CustomBuilding" },
        { BuildingBehaviourTypes.Relic, "CustomBuilding" },
        { BuildingBehaviourTypes.Storage, "CustomBuilding" },
        { BuildingBehaviourTypes.Workshop, "CustomBuilding" },
    };
}