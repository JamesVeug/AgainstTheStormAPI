using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum NeedTypes
{
	Unknown = -1,
	None,
	Any_Housing,                                            // Basic Housing
	API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed, // API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_displayName
	API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed, 
	Beaver_Housing,                                         // Beaver Housing
	Biscuits,                                               // Biscuits
	Bloodthirst,                                            // Brawling
	Boots,                                                  // Boots
	Clothes,                                                // Coats
	Education,                                              // Education
	Fox_Housing,                                            // Fox Housing
	Frog_Housing,                                           // Frog Housing
	Harpy_Housing,                                          // Harpy Housing
	Human_Housing,                                          // Human Housing
	Jerky,                                                  // Jerky
	Leasiure,                                               // Leisure
	Lizard_Housing,                                         // Lizard Housing
	Luxury,                                                 // Luxury
	Paste,                                                  // Paste
	Pickled_Goods,                                          // Pickled Goods
	Pie,                                                    // Pie
	Porridge,                                               // Porridge
	Religion,                                               // Religion
	Skewer,                                                 // Skewers
	Treatment,                                              // Treatment


	MAX = 24
}

public static class NeedTypesExtensions
{
	private static NeedTypes[] s_All = null;
	public static NeedTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new NeedTypes[24];
			for (int i = 0; i < 24; i++)
			{
				s_All[i] = (NeedTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this NeedTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of NeedTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[NeedTypes.Any_Housing];
	}
	
	public static NeedTypes ToNeedTypes(this string name)
	{
		foreach (KeyValuePair<NeedTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find NeedTypes with name: " + name + "\n" + Environment.StackTrace);
		return NeedTypes.Unknown;
	}
	
	public static NeedModel ToNeedModel(this string name)
	{
		NeedModel model = SO.Settings.Needs.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find NeedModel for NeedTypes with name: " + name + "\n" + Environment.StackTrace);
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
			array[i++] = element.ToNeedModel();
		}

		return array;
	}
	
	public static NeedModel[] ToNeedModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		NeedModel[] array = new NeedModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToNeedModel();
		}

		return array;
	}

	internal static readonly Dictionary<NeedTypes, string> TypeToInternalName = new()
	{
		{ NeedTypes.Any_Housing, "Any Housing" },                                                                                       // Basic Housing
		{ NeedTypes.API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed, "API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed" }, // API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_displayName
		{ NeedTypes.API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed, "API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed" }, 
		{ NeedTypes.Beaver_Housing, "Beaver Housing" },                                                                                 // Beaver Housing
		{ NeedTypes.Biscuits, "Biscuits" },                                                                                             // Biscuits
		{ NeedTypes.Bloodthirst, "Bloodthirst" },                                                                                       // Brawling
		{ NeedTypes.Boots, "Boots" },                                                                                                   // Boots
		{ NeedTypes.Clothes, "Clothes" },                                                                                               // Coats
		{ NeedTypes.Education, "Education" },                                                                                           // Education
		{ NeedTypes.Fox_Housing, "Fox Housing" },                                                                                       // Fox Housing
		{ NeedTypes.Frog_Housing, "Frog Housing" },                                                                                     // Frog Housing
		{ NeedTypes.Harpy_Housing, "Harpy Housing" },                                                                                   // Harpy Housing
		{ NeedTypes.Human_Housing, "Human Housing" },                                                                                   // Human Housing
		{ NeedTypes.Jerky, "Jerky" },                                                                                                   // Jerky
		{ NeedTypes.Leasiure, "Leasiure" },                                                                                             // Leisure
		{ NeedTypes.Lizard_Housing, "Lizard Housing" },                                                                                 // Lizard Housing
		{ NeedTypes.Luxury, "Luxury" },                                                                                                 // Luxury
		{ NeedTypes.Paste, "Paste" },                                                                                                   // Paste
		{ NeedTypes.Pickled_Goods, "Pickled Goods" },                                                                                   // Pickled Goods
		{ NeedTypes.Pie, "Pie" },                                                                                                       // Pie
		{ NeedTypes.Porridge, "Porridge" },                                                                                             // Porridge
		{ NeedTypes.Religion, "Religion" },                                                                                             // Religion
		{ NeedTypes.Skewer, "Skewer" },                                                                                                 // Skewers
		{ NeedTypes.Treatment, "Treatment" },                                                                                           // Treatment

	};
}
