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
	Ascension_I,             // Prestige 1 - More Reputation required and harder Orders.
	Ascension_II,            // Prestige 2 - The storm lasts longer.
	Ascension_III,           // Prestige 3 - Blightrot appears every third Clearance season.
	Ascension_IV,            // Prestige 4 - Blueprint rerolls cost more.
	Ascension_IX,            // Prestige 9 - Villagers work slower on Events.
	Ascension_V,             // Prestige 5 - Villagers with low Resolve leave faster.
	Ascension_VI,            // Prestige 6 - Buildings cost more.
	Ascension_VII,           // Prestige 7 - Higher food consumption.
	Ascension_VIII,          // Prestige 8 - Villagers consume more luxury goods.
	Ascension_X,             // Prestige 10 - Goods are worth less to traders.
	Ascension_XI,            // Prestige 11 - Blightrot has a stronger impact.
	Ascension_XII,           // Prestige 12 - Fewer blueprints to choose from.
	Ascension_XIII,          // Prestige 13 - Fewer cornerstone choices.
	Ascension_XIV,           // Prestige 14 - Impatience falls less on gaining Reputation.
	Ascension_XIX,           // Prestige 19 - Fee for each discovered glade.
	Ascension_XV,            // Prestige 15 - More Resolve needed to gain Reputation.
	Ascension_XVI,           // Prestige 16 - One fewer blueprint to begin with.
	Ascension_XVII,          // Prestige 17 - Stronger hunger penalty.
	Ascension_XVIII,         // Prestige 18 - Sacrifices in the Hearth cost more.
	Ascension_XX,            // Prestige 20 - Higher penalty for losing villagers.
	Hard,                    // Pioneer - More Reputation required to win.
	Impossible,              // Viceroy - Blightrot & Corruption
	Normal,                  // Settler - Villagers eat less food.
	Tutorial_I_Difficulty,   // Tutorial - No additional modifiers
	Tutorial_II_Difficulty,  // Tutorial - No additional modifiers
	Tutorial_III_Difficulty, // Tutorial - Villagers eat less food.
	Tutorial_IV_Difficulty,  // Tutorial - Blightrot & Corruption
	Very_Hard,               // Veteran - Blightrot & Corruption


	MAX = 28
}

public static class DifficultyTypesExtensions
{
	private static DifficultyTypes[] s_All = null;
	public static DifficultyTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new DifficultyTypes[28];
			for (int i = 0; i < 28; i++)
			{
				s_All[i] = (DifficultyTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this DifficultyTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of DifficultyTypes: " + type);
		return TypeToInternalName[DifficultyTypes.Ascension_I];
	}
	
	public static DifficultyTypes ToDifficultyTypes(this string name)
	{
		foreach (KeyValuePair<DifficultyTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find DifficultyTypes with name: " + name);
		return DifficultyTypes.Unknown;
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
		{ DifficultyTypes.Ascension_I, "4 Ascension I" },                       // Prestige 1 - More Reputation required and harder Orders.
		{ DifficultyTypes.Ascension_II, "5 Ascension II" },                     // Prestige 2 - The storm lasts longer.
		{ DifficultyTypes.Ascension_III, "6 Ascension III" },                   // Prestige 3 - Blightrot appears every third Clearance season.
		{ DifficultyTypes.Ascension_IV, "7 Ascension IV" },                     // Prestige 4 - Blueprint rerolls cost more.
		{ DifficultyTypes.Ascension_IX, "12 Ascension IX" },                    // Prestige 9 - Villagers work slower on Events.
		{ DifficultyTypes.Ascension_V, "8 Ascension V" },                       // Prestige 5 - Villagers with low Resolve leave faster.
		{ DifficultyTypes.Ascension_VI, "9 Ascension VI" },                     // Prestige 6 - Buildings cost more.
		{ DifficultyTypes.Ascension_VII, "10 Ascension VII" },                  // Prestige 7 - Higher food consumption.
		{ DifficultyTypes.Ascension_VIII, "11 Ascension VIII" },                // Prestige 8 - Villagers consume more luxury goods.
		{ DifficultyTypes.Ascension_X, "13 Ascension X" },                      // Prestige 10 - Goods are worth less to traders.
		{ DifficultyTypes.Ascension_XI, "14 Ascension XI" },                    // Prestige 11 - Blightrot has a stronger impact.
		{ DifficultyTypes.Ascension_XII, "15 Ascension XII" },                  // Prestige 12 - Fewer blueprints to choose from.
		{ DifficultyTypes.Ascension_XIII, "16 Ascension XIII" },                // Prestige 13 - Fewer cornerstone choices.
		{ DifficultyTypes.Ascension_XIV, "17 Ascension XIV" },                  // Prestige 14 - Impatience falls less on gaining Reputation.
		{ DifficultyTypes.Ascension_XIX, "22 Ascension XIX" },                  // Prestige 19 - Fee for each discovered glade.
		{ DifficultyTypes.Ascension_XV, "18 Ascension XV" },                    // Prestige 15 - More Resolve needed to gain Reputation.
		{ DifficultyTypes.Ascension_XVI, "19 Ascension XVI" },                  // Prestige 16 - One fewer blueprint to begin with.
		{ DifficultyTypes.Ascension_XVII, "20 Ascension XVII" },                // Prestige 17 - Stronger hunger penalty.
		{ DifficultyTypes.Ascension_XVIII, "21 Ascension XVIII" },              // Prestige 18 - Sacrifices in the Hearth cost more.
		{ DifficultyTypes.Ascension_XX, "23 Ascension XX" },                    // Prestige 20 - Higher penalty for losing villagers.
		{ DifficultyTypes.Hard, "1 Hard" },                                     // Pioneer - More Reputation required to win.
		{ DifficultyTypes.Impossible, "3 Impossible" },                         // Viceroy - Blightrot & Corruption
		{ DifficultyTypes.Normal, "0 Normal" },                                 // Settler - Villagers eat less food.
		{ DifficultyTypes.Tutorial_I_Difficulty, "Tutorial I Difficulty" },     // Tutorial - No additional modifiers
		{ DifficultyTypes.Tutorial_II_Difficulty, "Tutorial II Difficulty" },   // Tutorial - No additional modifiers
		{ DifficultyTypes.Tutorial_III_Difficulty, "Tutorial III Difficulty" }, // Tutorial - Villagers eat less food.
		{ DifficultyTypes.Tutorial_IV_Difficulty, "Tutorial IV Difficulty" },   // Tutorial - Blightrot & Corruption
		{ DifficultyTypes.Very_Hard, "2 Very Hard" },                           // Veteran - Blightrot & Corruption

	};
}
