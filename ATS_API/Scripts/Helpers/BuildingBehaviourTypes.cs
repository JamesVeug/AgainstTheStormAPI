using System;
using System.Collections.Generic;

namespace ATS_API.Helpers;

public enum BuildingBehaviourTypes
{
    Unknown = -1,
    None,
    Alter,
    FarmField,
    Hydrant,
    Road,
    Seal,
    Shrine,
    TradingPost,
    BlightPost,
    Camp,
    Collector,
    Decoration,
    Extractor,
    Farm,
    GathererHut,
    Hearth,
    House,
    Institution,
    Mine,
    RainCatcher,
    Relic,
    Storage,
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
}