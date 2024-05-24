using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum BuildingCategoriesTypes
{
    Unknown = -1,
    None,
	CityBuildings,      // City Buildings
	DebugNodes,         // Rec
	Decorations,        // Decorations
	Event,              // Glade Event
	EventGhost,         // Battlefield Spirit
	FoodProduction,     // Food Production
	Housing,            // Housing
	Industry,           // Industry
	LoreTablet1,        // Lore Tablet I
	LoreTablet2,        // Lore Tablet II
	LoreTablet3,        // Lore Tablet III
	LoreTablet4,        // Lore Tablet IV
	LoreTablet5,        // Lore Tablet V
	LoreTablet6,        // Lore Tablet VI
	LoreTablet7,        // Lore Tablet VII
	Relics,             // Ancient Relic
	ResourceGathering,  // Camps
	Roads,              // Roads
	Ruins,              // Ruin
	Tutorial_Invisible, // City Buildings

    MAX
}

public static class BuildingCategoriesTypesExtensions
{
	public static string ToName(this BuildingCategoriesTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingCategoriesTypes: " + type);
		return TypeToInternalName[BuildingCategoriesTypes.CityBuildings];
	}
	
	public static BuildingCategoryModel ToBuildingCategoryModel(this string name)
    {
        BuildingCategoryModel model = SO.Settings.BuildingCategories.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find BuildingCategoryModel for BuildingCategoriesTypes with name: " + name);
        return null;
    }

	public static BuildingCategoryModel ToBuildingCategoryModel(this BuildingCategoriesTypes types)
	{
		return types.ToName().ToBuildingCategoryModel();
	}
	
	public static BuildingCategoryModel[] ToBuildingCategoryModelArray(this IEnumerable<BuildingCategoriesTypes> collection)
    {
        int count = collection.Count();
        BuildingCategoryModel[] array = new BuildingCategoryModel[count];
        int i = 0;
        foreach (BuildingCategoriesTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.BuildingCategories.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<BuildingCategoriesTypes, string> TypeToInternalName = new()
	{
		{ BuildingCategoriesTypes.CityBuildings, "City Buildings" },            // City Buildings
		{ BuildingCategoriesTypes.DebugNodes, "Debug Nodes" },                  // Rec
		{ BuildingCategoriesTypes.Decorations, "Decorations" },                 // Decorations
		{ BuildingCategoriesTypes.Event, "Event" },                             // Glade Event
		{ BuildingCategoriesTypes.EventGhost, "Event Ghost" },                  // Battlefield Spirit
		{ BuildingCategoriesTypes.FoodProduction, "Food Production" },          // Food Production
		{ BuildingCategoriesTypes.Housing, "Housing" },                         // Housing
		{ BuildingCategoriesTypes.Industry, "Industry" },                       // Industry
		{ BuildingCategoriesTypes.LoreTablet1, "Lore Tablet 1" },               // Lore Tablet I
		{ BuildingCategoriesTypes.LoreTablet2, "Lore Tablet 2" },               // Lore Tablet II
		{ BuildingCategoriesTypes.LoreTablet3, "Lore Tablet 3" },               // Lore Tablet III
		{ BuildingCategoriesTypes.LoreTablet4, "Lore Tablet 4" },               // Lore Tablet IV
		{ BuildingCategoriesTypes.LoreTablet5, "Lore Tablet 5" },               // Lore Tablet V
		{ BuildingCategoriesTypes.LoreTablet6, "Lore Tablet 6" },               // Lore Tablet VI
		{ BuildingCategoriesTypes.LoreTablet7, "Lore Tablet 7" },               // Lore Tablet VII
		{ BuildingCategoriesTypes.Relics, "Relics" },                           // Ancient Relic
		{ BuildingCategoriesTypes.ResourceGathering, "Resource Gathering" },    // Camps
		{ BuildingCategoriesTypes.Roads, "Roads" },                             // Roads
		{ BuildingCategoriesTypes.Ruins, "Ruins" },                             // Ruin
		{ BuildingCategoriesTypes.Tutorial_Invisible, "Tutorial - invisible" }, // City Buildings
	};
}
