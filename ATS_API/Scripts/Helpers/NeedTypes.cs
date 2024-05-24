using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum NeedTypes
{
    Unknown = -1,
    None,
	AnyHousing,    // Basic Housing
	BeaverHousing, // Beaver Housing
	Biscuits,      // Biscuits
	Bloodthirst,   // Brawling
	Clothes,       // Clothing
	Education,     // Education
	FoxHousing,    // Fox Housing
	HarpyHousing,  // Harpy Housing
	HumanHousing,  // Human Housing
	Jerky,         // Jerky
	Leasiure,      // Leisure
	LizardHousing, // Lizard Housing
	Luxury,        // Luxury
	PickledGoods,  // Pickled Goods
	Pie,           // Pie
	Porridge,      // Porridge
	Religion,      // Religion
	Skewer,        // Skewers
	Treatment,     // Treatment

    MAX
}

public static class NeedTypesExtensions
{
	public static string ToName(this NeedTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of NeedTypes: " + type);
		return TypeToInternalName[NeedTypes.AnyHousing];
	}
	
	public static NeedModel ToNeedModel(this string name)
    {
        NeedModel model = SO.Settings.Needs.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find NeedModel for NeedTypes with name: " + name);
        return null;
    }

	public static NeedModel ToNeedModel(this NeedTypes types)
	{
		return types.ToName().ToNeedModel();
	}
	
	public static NeedModel[] ToNeedModelArray(this IEnumerable<NeedTypes> collection)
    {
        int count = collection.Count();
        NeedModel[] array = new NeedModel[count];
        int i = 0;
        foreach (NeedTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.Needs.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<NeedTypes, string> TypeToInternalName = new()
	{
		{ NeedTypes.AnyHousing, "Any Housing" },       // Basic Housing
		{ NeedTypes.BeaverHousing, "Beaver Housing" }, // Beaver Housing
		{ NeedTypes.Biscuits, "Biscuits" },            // Biscuits
		{ NeedTypes.Bloodthirst, "Bloodthirst" },      // Brawling
		{ NeedTypes.Clothes, "Clothes" },              // Clothing
		{ NeedTypes.Education, "Education" },          // Education
		{ NeedTypes.FoxHousing, "Fox Housing" },       // Fox Housing
		{ NeedTypes.HarpyHousing, "Harpy Housing" },   // Harpy Housing
		{ NeedTypes.HumanHousing, "Human Housing" },   // Human Housing
		{ NeedTypes.Jerky, "Jerky" },                  // Jerky
		{ NeedTypes.Leasiure, "Leasiure" },            // Leisure
		{ NeedTypes.LizardHousing, "Lizard Housing" }, // Lizard Housing
		{ NeedTypes.Luxury, "Luxury" },                // Luxury
		{ NeedTypes.PickledGoods, "Pickled Goods" },   // Pickled Goods
		{ NeedTypes.Pie, "Pie" },                      // Pie
		{ NeedTypes.Porridge, "Porridge" },            // Porridge
		{ NeedTypes.Religion, "Religion" },            // Religion
		{ NeedTypes.Skewer, "Skewer" },                // Skewers
		{ NeedTypes.Treatment, "Treatment" },          // Treatment
	};
}
