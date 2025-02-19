using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum DifficultyTypes
{
	/// <summary>
	/// Placeholder for an unknown DifficultyTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no DifficultyTypes. Typically, seen if nothing is defined or failed to parse a string to a DifficultyTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Tutorial - Blightrot & Corruption
	/// </summary>
	/// <name>Tutorial IV Difficulty</name>
	Tutorial_IV_Difficulty = 1,

	/// <summary>
	/// Tutorial - Villagers eat less food.
	/// </summary>
	/// <name>Tutorial III Difficulty</name>
	Tutorial_III_Difficulty = 2,

	/// <summary>
	/// Tutorial - No additional modifiers
	/// </summary>
	/// <name>Tutorial II Difficulty</name>
	Tutorial_II_Difficulty = 3,

	/// <summary>
	/// Tutorial - No additional modifiers
	/// </summary>
	/// <name>Tutorial I Difficulty</name>
	Tutorial_I_Difficulty = 4,

	/// <summary>
	/// Settler - Villagers eat less food.
	/// </summary>
	/// <name>0 Normal</name>
	Normal = 5,

	/// <summary>
	/// Pioneer - More Reputation required to win.
	/// </summary>
	/// <name>1 Hard</name>
	Hard = 6,

	/// <summary>
	/// Veteran - Blightrot & Corruption
	/// </summary>
	/// <name>2 Very Hard</name>
	Very_Hard = 7,

	/// <summary>
	/// Viceroy - Blightrot & Corruption
	/// </summary>
	/// <name>3 Impossible</name>
	Impossible = 8,

	/// <summary>
	/// Prestige 1 - More Reputation required and harder Orders.
	/// </summary>
	/// <name>4 Ascension I</name>
	Ascension_I = 9,

	/// <summary>
	/// Prestige 2 - The storm lasts longer.
	/// </summary>
	/// <name>5 Ascension II</name>
	Ascension_II = 10,

	/// <summary>
	/// Prestige 3 - Blightrot appears every third Clearance season.
	/// </summary>
	/// <name>6 Ascension III</name>
	Ascension_III = 11,

	/// <summary>
	/// Prestige 4 - Blueprint rerolls cost more.
	/// </summary>
	/// <name>7 Ascension IV</name>
	Ascension_IV = 12,

	/// <summary>
	/// Prestige 5 - Villagers with low Resolve leave faster.
	/// </summary>
	/// <name>8 Ascension V</name>
	Ascension_V = 13,

	/// <summary>
	/// Prestige 6 - Buildings cost more.
	/// </summary>
	/// <name>9 Ascension VI</name>
	Ascension_VI = 14,

	/// <summary>
	/// Prestige 7 - Higher food consumption.
	/// </summary>
	/// <name>10 Ascension VII</name>
	Ascension_VII = 15,

	/// <summary>
	/// Prestige 8 - Villagers consume more luxury goods.
	/// </summary>
	/// <name>11 Ascension VIII</name>
	Ascension_VIII = 16,

	/// <summary>
	/// Prestige 9 - Villagers work slower on Events.
	/// </summary>
	/// <name>12 Ascension IX</name>
	Ascension_IX = 17,

	/// <summary>
	/// Prestige 10 - Goods are worth less to traders.
	/// </summary>
	/// <name>13 Ascension X</name>
	Ascension_X = 18,

	/// <summary>
	/// Prestige 11 - Blightrot has a stronger impact.
	/// </summary>
	/// <name>14 Ascension XI</name>
	Ascension_XI = 19,

	/// <summary>
	/// Prestige 12 - Fewer blueprints to choose from.
	/// </summary>
	/// <name>15 Ascension XII</name>
	Ascension_XII = 20,

	/// <summary>
	/// Prestige 13 - Fewer cornerstone choices.
	/// </summary>
	/// <name>16 Ascension XIII</name>
	Ascension_XIII = 21,

	/// <summary>
	/// Prestige 14 - Impatience falls less on gaining Reputation.
	/// </summary>
	/// <name>17 Ascension XIV</name>
	Ascension_XIV = 22,

	/// <summary>
	/// Prestige 15 - More Resolve needed to gain Reputation.
	/// </summary>
	/// <name>18 Ascension XV</name>
	Ascension_XV = 23,

	/// <summary>
	/// Prestige 16 - One fewer blueprint to begin with.
	/// </summary>
	/// <name>19 Ascension XVI</name>
	Ascension_XVI = 24,

	/// <summary>
	/// Prestige 17 - Stronger hunger penalty.
	/// </summary>
	/// <name>20 Ascension XVII</name>
	Ascension_XVII = 25,

	/// <summary>
	/// Prestige 18 - Sacrifices in the Hearth cost more.
	/// </summary>
	/// <name>21 Ascension XVIII</name>
	Ascension_XVIII = 26,

	/// <summary>
	/// Prestige 19 - Fee for each discovered glade.
	/// </summary>
	/// <name>22 Ascension XIX</name>
	Ascension_XIX = 27,

	/// <summary>
	/// Prestige 20 - Higher penalty for losing villagers.
	/// </summary>
	/// <name>23 Ascension XX</name>
	Ascension_XX = 28,



	/// <summary>
	/// The total number of vanilla DifficultyTypes in the game.
	/// </summary>
	[Obsolete("Use DifficultyTypesExtensions.Count(). DifficultyTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 28
}

/// <summary>
/// Extension methods for the DifficultyTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class DifficultyTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in DifficultyTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded DifficultyTypes.
	/// </summary>
	public static DifficultyTypes[] All()
	{
		DifficultyTypes[] all = new DifficultyTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every DifficultyTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return DifficultyTypes.Tutorial_IV_Difficulty in the enum and log an error.
	/// </summary>
	public static string ToName(this DifficultyTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of DifficultyTypes: " + type);
		return TypeToInternalName[DifficultyTypes.Tutorial_IV_Difficulty];
	}
	
	/// <summary>
	/// Returns a DifficultyTypes associated with the given name.
	/// Every DifficultyTypes should have a unique name as to distinguish it from others.
	/// If no DifficultyTypes is found, it will return DifficultyTypes.Unknown and log a warning.
	/// </summary>
	public static DifficultyTypes ToDifficultyTypes(this string name)
	{
		foreach (KeyValuePair<DifficultyTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find DifficultyTypes with name: " + name + "\n" + Environment.StackTrace);
		return DifficultyTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a DifficultyModel associated with the given name.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If no DifficultyModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.DifficultyModel ToDifficultyModel(this string name)
	{
		Eremite.Model.DifficultyModel model = SO.Settings.difficulties.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find DifficultyModel for DifficultyTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a DifficultyModel associated with the given DifficultyTypes.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If no DifficultyModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.DifficultyModel ToDifficultyModel(this DifficultyTypes types)
	{
		return types.ToName().ToDifficultyModel();
	}
	
	/// <summary>
	/// Returns an array of DifficultyModel associated with the given DifficultyTypes.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If a DifficultyModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.DifficultyModel[] ToDifficultyModelArray(this IEnumerable<DifficultyTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.DifficultyModel[] array = new Eremite.Model.DifficultyModel[count];
		int i = 0;
		foreach (DifficultyTypes element in collection)
		{
			array[i++] = element.ToDifficultyModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of DifficultyModel associated with the given DifficultyTypes.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If a DifficultyModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.DifficultyModel[] ToDifficultyModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.DifficultyModel[] array = new Eremite.Model.DifficultyModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToDifficultyModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of DifficultyModel associated with the given DifficultyTypes.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If a DifficultyModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.DifficultyModel[] ToDifficultyModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.DifficultyModel>.Get(out List<Eremite.Model.DifficultyModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.DifficultyModel model = element.ToDifficultyModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of DifficultyModel associated with the given DifficultyTypes.
	/// DifficultyModel contain all the data that will be used in the game.
	/// Every DifficultyModel should have a unique name as to distinguish it from others.
	/// If a DifficultyModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.DifficultyModel[] ToDifficultyModelArrayNoNulls(this IEnumerable<DifficultyTypes> collection)
	{
		using(ListPool<Eremite.Model.DifficultyModel>.Get(out List<Eremite.Model.DifficultyModel> list))
		{
			foreach (DifficultyTypes element in collection)
			{
				Eremite.Model.DifficultyModel model = element.ToDifficultyModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<DifficultyTypes, string> TypeToInternalName = new()
	{
		{ DifficultyTypes.Tutorial_IV_Difficulty, "Tutorial IV Difficulty" },   // Tutorial - Blightrot & Corruption
		{ DifficultyTypes.Tutorial_III_Difficulty, "Tutorial III Difficulty" }, // Tutorial - Villagers eat less food.
		{ DifficultyTypes.Tutorial_II_Difficulty, "Tutorial II Difficulty" },   // Tutorial - No additional modifiers
		{ DifficultyTypes.Tutorial_I_Difficulty, "Tutorial I Difficulty" },     // Tutorial - No additional modifiers
		{ DifficultyTypes.Normal, "0 Normal" },                                 // Settler - Villagers eat less food.
		{ DifficultyTypes.Hard, "1 Hard" },                                     // Pioneer - More Reputation required to win.
		{ DifficultyTypes.Very_Hard, "2 Very Hard" },                           // Veteran - Blightrot & Corruption
		{ DifficultyTypes.Impossible, "3 Impossible" },                         // Viceroy - Blightrot & Corruption
		{ DifficultyTypes.Ascension_I, "4 Ascension I" },                       // Prestige 1 - More Reputation required and harder Orders.
		{ DifficultyTypes.Ascension_II, "5 Ascension II" },                     // Prestige 2 - The storm lasts longer.
		{ DifficultyTypes.Ascension_III, "6 Ascension III" },                   // Prestige 3 - Blightrot appears every third Clearance season.
		{ DifficultyTypes.Ascension_IV, "7 Ascension IV" },                     // Prestige 4 - Blueprint rerolls cost more.
		{ DifficultyTypes.Ascension_V, "8 Ascension V" },                       // Prestige 5 - Villagers with low Resolve leave faster.
		{ DifficultyTypes.Ascension_VI, "9 Ascension VI" },                     // Prestige 6 - Buildings cost more.
		{ DifficultyTypes.Ascension_VII, "10 Ascension VII" },                  // Prestige 7 - Higher food consumption.
		{ DifficultyTypes.Ascension_VIII, "11 Ascension VIII" },                // Prestige 8 - Villagers consume more luxury goods.
		{ DifficultyTypes.Ascension_IX, "12 Ascension IX" },                    // Prestige 9 - Villagers work slower on Events.
		{ DifficultyTypes.Ascension_X, "13 Ascension X" },                      // Prestige 10 - Goods are worth less to traders.
		{ DifficultyTypes.Ascension_XI, "14 Ascension XI" },                    // Prestige 11 - Blightrot has a stronger impact.
		{ DifficultyTypes.Ascension_XII, "15 Ascension XII" },                  // Prestige 12 - Fewer blueprints to choose from.
		{ DifficultyTypes.Ascension_XIII, "16 Ascension XIII" },                // Prestige 13 - Fewer cornerstone choices.
		{ DifficultyTypes.Ascension_XIV, "17 Ascension XIV" },                  // Prestige 14 - Impatience falls less on gaining Reputation.
		{ DifficultyTypes.Ascension_XV, "18 Ascension XV" },                    // Prestige 15 - More Resolve needed to gain Reputation.
		{ DifficultyTypes.Ascension_XVI, "19 Ascension XVI" },                  // Prestige 16 - One fewer blueprint to begin with.
		{ DifficultyTypes.Ascension_XVII, "20 Ascension XVII" },                // Prestige 17 - Stronger hunger penalty.
		{ DifficultyTypes.Ascension_XVIII, "21 Ascension XVIII" },              // Prestige 18 - Sacrifices in the Hearth cost more.
		{ DifficultyTypes.Ascension_XIX, "22 Ascension XIX" },                  // Prestige 19 - Fee for each discovered glade.
		{ DifficultyTypes.Ascension_XX, "23 Ascension XX" },                    // Prestige 20 - Higher penalty for losing villagers.

	};
}
