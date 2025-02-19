using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum InstitutionTypes
{
	/// <summary>
	/// Placeholder for an unknown InstitutionTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no InstitutionTypes. Typically, seen if nothing is defined or failed to parse a string to a InstitutionTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
	/// </summary>
	/// <name>Bath House</name>
	Bath_House = 1,

	/// <summary>
	/// Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
	/// </summary>
	/// <name>Clan Hall</name>
	Clan_Hall = 2,

	/// <summary>
	/// Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
	/// </summary>
	/// <name>Explorers Lodge</name>
	Explorers_Lodge = 3,

	/// <summary>
	/// Feast Hall - A place where villagers can fulfill their need for: Treatment,  Brawling. Passive effects: Festive Mood.
	/// </summary>
	/// <name>Feast Hall</name>
	Feast_Hall = 4,

	/// <summary>
	/// Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
	/// </summary>
	/// <name>Forum</name>
	Forum = 5,

	/// <summary>
	/// Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
	/// </summary>
	/// <name>Guild House</name>
	Guild_House = 6,

	/// <summary>
	/// Holy Guild House - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Luxury,  Education. Passive effects: Guild House, The Guild's Welfare.
	/// </summary>
	/// <name>Holy Guild House</name>
	Holy_Guild_House = 7,

	/// <summary>
	/// Holy Market - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Leisure,  Treatment. Passive effects: Ale and Hearty, Market Carts.
	/// </summary>
	/// <name>Holy Market</name>
	Holy_Market = 8,

	/// <summary>
	/// Holy Temple - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Religion,  Education. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
	/// </summary>
	/// <name>Holy Temple</name>
	Holy_Temple = 9,

	/// <summary>
	/// Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
	/// </summary>
	/// <name>Market</name>
	Market = 10,

	/// <summary>
	/// Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
	/// </summary>
	/// <name>Monastery</name>
	Monastery = 11,

	/// <summary>
	/// Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
	/// </summary>
	/// <name>Tavern</name>
	Tavern = 12,

	/// <summary>
	/// Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
	/// </summary>
	/// <name>Tea Doctor</name>
	Tea_Doctor = 13,

	/// <summary>
	/// Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.
	/// </summary>
	/// <name>Temple</name>
	Temple = 14,



	/// <summary>
	/// The total number of vanilla InstitutionTypes in the game.
	/// </summary>
	MAX = 14
}

/// <summary>
/// Extension methods for the InstitutionTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class InstitutionTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded InstitutionTypes.
	/// </summary>
	public static InstitutionTypes[] All()
	{
		InstitutionTypes[] all = new InstitutionTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every InstitutionTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return InstitutionTypes.Bath_House in the enum and log an error.
	/// </summary>
	public static string ToName(this InstitutionTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of InstitutionTypes: " + type);
		return TypeToInternalName[InstitutionTypes.Bath_House];
	}
	
	/// <summary>
	/// Returns a InstitutionTypes associated with the given name.
	/// Every InstitutionTypes should have a unique name as to distinguish it from others.
	/// If no InstitutionTypes is found, it will return InstitutionTypes.Unknown and log a warning.
	/// </summary>
	public static InstitutionTypes ToInstitutionTypes(this string name)
	{
		foreach (KeyValuePair<InstitutionTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find InstitutionTypes with name: " + name + "\n" + Environment.StackTrace);
		return InstitutionTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a InstitutionModel associated with the given name.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If no InstitutionModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel ToInstitutionModel(this string name)
	{
		Eremite.Buildings.InstitutionModel model = SO.Settings.Institutions.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find InstitutionModel for InstitutionTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a InstitutionModel associated with the given InstitutionTypes.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If no InstitutionModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel ToInstitutionModel(this InstitutionTypes types)
	{
		return types.ToName().ToInstitutionModel();
	}
	
	/// <summary>
	/// Returns an array of InstitutionModel associated with the given InstitutionTypes.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If a InstitutionModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel[] ToInstitutionModelArray(this IEnumerable<InstitutionTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.InstitutionModel[] array = new Eremite.Buildings.InstitutionModel[count];
		int i = 0;
		foreach (InstitutionTypes element in collection)
		{
			array[i++] = element.ToInstitutionModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of InstitutionModel associated with the given InstitutionTypes.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If a InstitutionModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel[] ToInstitutionModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.InstitutionModel[] array = new Eremite.Buildings.InstitutionModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToInstitutionModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of InstitutionModel associated with the given InstitutionTypes.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If a InstitutionModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel[] ToInstitutionModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.InstitutionModel>.Get(out List<Eremite.Buildings.InstitutionModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.InstitutionModel model = element.ToInstitutionModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of InstitutionModel associated with the given InstitutionTypes.
	/// InstitutionModel contain all the data that will be used in the game.
	/// Every InstitutionModel should have a unique name as to distinguish it from others.
	/// If a InstitutionModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.InstitutionModel[] ToInstitutionModelArrayNoNulls(this IEnumerable<InstitutionTypes> collection)
	{
		using(ListPool<Eremite.Buildings.InstitutionModel>.Get(out List<Eremite.Buildings.InstitutionModel> list))
		{
			foreach (InstitutionTypes element in collection)
			{
				Eremite.Buildings.InstitutionModel model = element.ToInstitutionModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<InstitutionTypes, string> TypeToInternalName = new()
	{
		{ InstitutionTypes.Bath_House, "Bath House" },             // Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
		{ InstitutionTypes.Clan_Hall, "Clan Hall" },               // Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
		{ InstitutionTypes.Explorers_Lodge, "Explorers Lodge" },   // Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
		{ InstitutionTypes.Feast_Hall, "Feast Hall" },             // Feast Hall - A place where villagers can fulfill their need for: Treatment,  Brawling. Passive effects: Festive Mood.
		{ InstitutionTypes.Forum, "Forum" },                       // Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
		{ InstitutionTypes.Guild_House, "Guild House" },           // Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
		{ InstitutionTypes.Holy_Guild_House, "Holy Guild House" }, // Holy Guild House - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Luxury,  Education. Passive effects: Guild House, The Guild's Welfare.
		{ InstitutionTypes.Holy_Market, "Holy Market" },           // Holy Market - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Leisure,  Treatment. Passive effects: Ale and Hearty, Market Carts.
		{ InstitutionTypes.Holy_Temple, "Holy Temple" },           // Holy Temple - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Religion,  Education. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
		{ InstitutionTypes.Market, "Market" },                     // Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
		{ InstitutionTypes.Monastery, "Monastery" },               // Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
		{ InstitutionTypes.Tavern, "Tavern" },                     // Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
		{ InstitutionTypes.Tea_Doctor, "Tea Doctor" },             // Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
		{ InstitutionTypes.Temple, "Temple" },                     // Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.

	};
}
