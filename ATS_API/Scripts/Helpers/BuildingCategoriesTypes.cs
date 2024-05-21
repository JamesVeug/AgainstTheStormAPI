using System;
using System.Collections.Generic;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum BuildingCategoriesTypes
{
    Unknown = -1,
    None,
    DebugNodes,
    EventGhost,
    Event,
    Relics,
    Roads,
    Ruins,
    ResourceGathering,
    FoodProduction,
    Housing,
    Industry,
    CityBuildings,
    Decorations,
    TutorialInvisible,
    LoreTablet1,
    LoreTablet2,
    LoreTablet3,
    LoreTablet4,
    LoreTablet5,
    LoreTablet6,
    LoreTablet7,
}

public static class BuildingCategoriesTypesExtensions
{
    public static string ToName(this BuildingCategoriesTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }
        
        Plugin.Log.LogError($"Cannot find name of good type: " + type);
        return BuildingCategoriesTypes.Industry.ToString();
    }
    
    public static BuildingCategoryModel ToBuildingCategoryModel(this BuildingCategoriesTypes types)
    {
        return types.ToName().ToBuildingCategoryModel();
    }
    
    public static BuildingCategoryModel ToBuildingCategoryModel(this string name)
    {
        BuildingCategoryModel categoryModel = Array.Find(SO.Settings.BuildingCategories, a=>a.Name == name);
        if (categoryModel == null)
        {
            Plugin.Log.LogError($"Cannot find name of building category: " + name);
        }
        
        return categoryModel;
    }

    internal static readonly Dictionary<BuildingCategoriesTypes, string> TypeToInternalName = new Dictionary<BuildingCategoriesTypes, string>()
    {
        {BuildingCategoriesTypes.DebugNodes,"Debug Nodes"},
        {BuildingCategoriesTypes.EventGhost,"Event Ghost"},
        {BuildingCategoriesTypes.Event,"Event"},
        {BuildingCategoriesTypes.Relics,"Relics"},
        {BuildingCategoriesTypes.Roads,"Roads"},
        {BuildingCategoriesTypes.Ruins,"Ruins"},
        {BuildingCategoriesTypes.ResourceGathering,"Resource Gathering"},
        {BuildingCategoriesTypes.FoodProduction,"Food Production"},
        {BuildingCategoriesTypes.Housing,"Housing"},
        {BuildingCategoriesTypes.Industry,"Industry"},
        {BuildingCategoriesTypes.CityBuildings,"City Buildings"},
        {BuildingCategoriesTypes.Decorations,"Decorations"},
        {BuildingCategoriesTypes.TutorialInvisible,"Tutorial - invisible"},
        {BuildingCategoriesTypes.LoreTablet1,"Lore Tablet 1"},
        {BuildingCategoriesTypes.LoreTablet2,"Lore Tablet 2"},
        {BuildingCategoriesTypes.LoreTablet3,"Lore Tablet 3"},
        {BuildingCategoriesTypes.LoreTablet4,"Lore Tablet 4"},
        {BuildingCategoriesTypes.LoreTablet5,"Lore Tablet 5"},
        {BuildingCategoriesTypes.LoreTablet6,"Lore Tablet 6"},
        {BuildingCategoriesTypes.LoreTablet7,"Lore Tablet 7"},
    };
}