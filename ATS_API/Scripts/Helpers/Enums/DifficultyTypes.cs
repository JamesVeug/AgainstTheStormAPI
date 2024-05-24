using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum DifficultyTypes
{
    Unknown = -1,
    None,
	_0_Normal,               // Settler
	_1_Hard,                 // Pioneer
	_10_Ascension_VII,       // Prestige
	_11_Ascension_VIII,      // Prestige
	_12_Ascension_IX,        // Prestige
	_13_Ascension_X,         // Prestige
	_14_Ascension_XI,        // Prestige
	_15_Ascension_XII,       // Prestige
	_16_Ascension_XIII,      // Prestige
	_17_Ascension_XIV,       // Prestige
	_18_Ascension_XV,        // Prestige
	_19_Ascension_XVI,       // Prestige
	_2_Very_Hard,            // Veteran
	_20_Ascension_XVII,      // Prestige
	_21_Ascension_XVIII,     // Prestige
	_22_Ascension_XIX,       // Prestige
	_23_Ascension_XX,        // Prestige
	_3_Impossible,           // Viceroy
	_4_Ascension_I,          // Prestige
	_5_Ascension_II,         // Prestige
	_6_Ascension_III,        // Prestige
	_7_Ascension_IV,         // Prestige
	_8_Ascension_V,          // Prestige
	_9_Ascension_VI,         // Prestige
	Tutorial_I_Difficulty,   // Tutorial
	Tutorial_II_Difficulty,  // Tutorial
	Tutorial_III_Difficulty, // Tutorial
	Tutorial_IV_Difficulty,  // Tutorial

    MAX = 28
}

public static class DifficultyTypesExtensions
{
	public static string ToName(this DifficultyTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of DifficultyTypes: " + type);
		return TypeToInternalName[DifficultyTypes._0_Normal];
	}
	
	public static DifficultyModel ToDifficultyModel(this string name)
    {
        DifficultyModel model = SO.Settings.difficulties.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find DifficultyModel for DifficultyTypes with name: " + name);
        return null;
    }

	public static DifficultyModel ToDifficultyModel(this DifficultyTypes types)
	{
		return types.ToName().ToDifficultyModel();
	}
	
	public static DifficultyModel[] ToDifficultyModelArray(this IEnumerable<DifficultyTypes> collection)
    {
        int count = collection.Count();
        DifficultyModel[] array = new DifficultyModel[count];
        int i = 0;
        foreach (DifficultyTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.difficulties.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<DifficultyTypes, string> TypeToInternalName = new()
	{
		{ DifficultyTypes._0_Normal, "0 Normal" },                              // Settler
		{ DifficultyTypes._1_Hard, "1 Hard" },                                  // Pioneer
		{ DifficultyTypes._10_Ascension_VII, "10 Ascension VII" },              // Prestige
		{ DifficultyTypes._11_Ascension_VIII, "11 Ascension VIII" },            // Prestige
		{ DifficultyTypes._12_Ascension_IX, "12 Ascension IX" },                // Prestige
		{ DifficultyTypes._13_Ascension_X, "13 Ascension X" },                  // Prestige
		{ DifficultyTypes._14_Ascension_XI, "14 Ascension XI" },                // Prestige
		{ DifficultyTypes._15_Ascension_XII, "15 Ascension XII" },              // Prestige
		{ DifficultyTypes._16_Ascension_XIII, "16 Ascension XIII" },            // Prestige
		{ DifficultyTypes._17_Ascension_XIV, "17 Ascension XIV" },              // Prestige
		{ DifficultyTypes._18_Ascension_XV, "18 Ascension XV" },                // Prestige
		{ DifficultyTypes._19_Ascension_XVI, "19 Ascension XVI" },              // Prestige
		{ DifficultyTypes._2_Very_Hard, "2 Very Hard" },                        // Veteran
		{ DifficultyTypes._20_Ascension_XVII, "20 Ascension XVII" },            // Prestige
		{ DifficultyTypes._21_Ascension_XVIII, "21 Ascension XVIII" },          // Prestige
		{ DifficultyTypes._22_Ascension_XIX, "22 Ascension XIX" },              // Prestige
		{ DifficultyTypes._23_Ascension_XX, "23 Ascension XX" },                // Prestige
		{ DifficultyTypes._3_Impossible, "3 Impossible" },                      // Viceroy
		{ DifficultyTypes._4_Ascension_I, "4 Ascension I" },                    // Prestige
		{ DifficultyTypes._5_Ascension_II, "5 Ascension II" },                  // Prestige
		{ DifficultyTypes._6_Ascension_III, "6 Ascension III" },                // Prestige
		{ DifficultyTypes._7_Ascension_IV, "7 Ascension IV" },                  // Prestige
		{ DifficultyTypes._8_Ascension_V, "8 Ascension V" },                    // Prestige
		{ DifficultyTypes._9_Ascension_VI, "9 Ascension VI" },                  // Prestige
		{ DifficultyTypes.Tutorial_I_Difficulty, "Tutorial I Difficulty" },     // Tutorial
		{ DifficultyTypes.Tutorial_II_Difficulty, "Tutorial II Difficulty" },   // Tutorial
		{ DifficultyTypes.Tutorial_III_Difficulty, "Tutorial III Difficulty" }, // Tutorial
		{ DifficultyTypes.Tutorial_IV_Difficulty, "Tutorial IV Difficulty" },   // Tutorial
	};
}
