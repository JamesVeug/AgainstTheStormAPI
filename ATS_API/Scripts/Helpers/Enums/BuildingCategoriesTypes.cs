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
	City_Buildings,     // City Buildings
	Debug_Nodes,        // Rec
	Decorations,        // Decorations
	Event,              // Glade Event
	Event_Ghost,        // Battlefield Spirit
	Food_Production,    // Food Production
	Housing,            // Housing
	Industry,           // Industry
	Lore_Tablet_1,      // Lore Tablet I
	Lore_Tablet_2,      // Lore Tablet II
	Lore_Tablet_3,      // Lore Tablet III
	Lore_Tablet_4,      // Lore Tablet IV
	Lore_Tablet_5,      // Lore Tablet V
	Lore_Tablet_6,      // Lore Tablet VI
	Lore_Tablet_7,      // Lore Tablet VII
	Relics,             // Ancient Relic
	Resource_Gathering, // Camps
	Roads,              // Roads
	Ruins,              // Ruin
	Tutorial_Invisible, // City Buildings


    MAX = 20
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
		return TypeToInternalName[BuildingCategoriesTypes.City_Buildings];
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
		{ BuildingCategoriesTypes.City_Buildings, "City Buildings" },           // City Buildings
		{ BuildingCategoriesTypes.Debug_Nodes, "Debug Nodes" },                 // Rec
		{ BuildingCategoriesTypes.Decorations, "Decorations" },                 // Decorations
		{ BuildingCategoriesTypes.Event, "Event" },                             // Glade Event
		{ BuildingCategoriesTypes.Event_Ghost, "Event Ghost" },                 // Battlefield Spirit
		{ BuildingCategoriesTypes.Food_Production, "Food Production" },         // Food Production
		{ BuildingCategoriesTypes.Housing, "Housing" },                         // Housing
		{ BuildingCategoriesTypes.Industry, "Industry" },                       // Industry
		{ BuildingCategoriesTypes.Lore_Tablet_1, "Lore Tablet 1" },             // Lore Tablet I
		{ BuildingCategoriesTypes.Lore_Tablet_2, "Lore Tablet 2" },             // Lore Tablet II
		{ BuildingCategoriesTypes.Lore_Tablet_3, "Lore Tablet 3" },             // Lore Tablet III
		{ BuildingCategoriesTypes.Lore_Tablet_4, "Lore Tablet 4" },             // Lore Tablet IV
		{ BuildingCategoriesTypes.Lore_Tablet_5, "Lore Tablet 5" },             // Lore Tablet V
		{ BuildingCategoriesTypes.Lore_Tablet_6, "Lore Tablet 6" },             // Lore Tablet VI
		{ BuildingCategoriesTypes.Lore_Tablet_7, "Lore Tablet 7" },             // Lore Tablet VII
		{ BuildingCategoriesTypes.Relics, "Relics" },                           // Ancient Relic
		{ BuildingCategoriesTypes.Resource_Gathering, "Resource Gathering" },   // Camps
		{ BuildingCategoriesTypes.Roads, "Roads" },                             // Roads
		{ BuildingCategoriesTypes.Ruins, "Ruins" },                             // Ruin
		{ BuildingCategoriesTypes.Tutorial_Invisible, "Tutorial - invisible" }, // City Buildings

	};
}
