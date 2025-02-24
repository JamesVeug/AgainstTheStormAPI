using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum NeedTypes
{
	/// <summary>
	/// Placeholder for an unknown NeedTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no NeedTypes. Typically, seen if nothing is defined or failed to parse a string to a NeedTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
	/// </summary>
	/// <name>Any Housing</name>
	Any_Housing = 1,

	/// <summary>
	/// Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
	/// </summary>
	/// <name>Beaver Housing</name>
	Beaver_Housing = 2,

	/// <summary>
	/// Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Biscuits</name>
	Biscuits = 3,

	/// <summary>
	/// Brawling - This need is fulfilled in: Clan Hall, Forum, Explorers' Lodge. Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Bloodthirst</name>
	Bloodthirst = 4,

	/// <summary>
	/// Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
	/// </summary>
	/// <name>Boots</name>
	Boots = 5,

	/// <summary>
	/// Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
	/// </summary>
	/// <name>Clothes</name>
	Clothes = 6,

	/// <summary>
	/// Education - This need is fulfilled in: Temple, Holy Guild House, Guild House, Explorers' Lodge. It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Education</name>
	Education = 7,

	/// <summary>
	/// Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
	/// </summary>
	/// <name>Fox Housing</name>
	Fox_Housing = 8,

	/// <summary>
	/// Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
	/// </summary>
	/// <name>Frog Housing</name>
	Frog_Housing = 9,

	/// <summary>
	/// Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
	/// </summary>
	/// <name>Harpy Housing</name>
	Harpy_Housing = 10,

	/// <summary>
	/// Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
	/// </summary>
	/// <name>Human Housing</name>
	Human_Housing = 11,

	/// <summary>
	/// Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Jerky</name>
	Jerky = 12,

	/// <summary>
	/// Leisure - This need is fulfilled in: Tavern, Monastery, Market. It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Leasiure</name>
	Leasiure = 13,

	/// <summary>
	/// Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
	/// </summary>
	/// <name>Lizard Housing</name>
	Lizard_Housing = 14,

	/// <summary>
	/// Luxury - This need is fulfilled in: Tavern, Holy Guild House, Forum, Guild House. It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Luxury</name>
	Luxury = 15,

	/// <summary>
	/// Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Paste</name>
	Paste = 16,

	/// <summary>
	/// Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Pickled Goods</name>
	Pickled_Goods = 17,

	/// <summary>
	/// Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Pie</name>
	Pie = 18,

	/// <summary>
	/// Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Porridge</name>
	Porridge = 19,

	/// <summary>
	/// Religion - This need is fulfilled in: Temple, Monastery, Tea Doctor. It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Religion</name>
	Religion = 20,

	/// <summary>
	/// Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Skewer</name>
	Skewer = 21,

	/// <summary>
	/// Treatment - This need is fulfilled in: Market, Tea Doctor, Bath House. It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Treatment</name>
	Treatment = 22,



	/// <summary>
	/// The total number of vanilla NeedTypes in the game.
	/// </summary>
	[Obsolete("Use NeedTypesExtensions.Count(). NeedTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 22
}

/// <summary>
/// Extension methods for the NeedTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class NeedTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in NeedTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded NeedTypes.
	/// </summary>
	public static NeedTypes[] All()
	{
		NeedTypes[] all = new NeedTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every NeedTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return NeedTypes.Any_Housing in the enum and log an error.
	/// </summary>
	public static string ToName(this NeedTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of NeedTypes: " + type);
		return TypeToInternalName[NeedTypes.Any_Housing];
	}
	
	/// <summary>
	/// Returns a NeedTypes associated with the given name.
	/// Every NeedTypes should have a unique name as to distinguish it from others.
	/// If no NeedTypes is found, it will return NeedTypes.Unknown and log a warning.
	/// </summary>
	public static NeedTypes ToNeedTypes(this string name)
	{
		foreach (KeyValuePair<NeedTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find NeedTypes with name: " + name + "\n" + Environment.StackTrace);
		return NeedTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a NeedModel associated with the given name.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If no NeedModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.NeedModel ToNeedModel(this string name)
	{
		Eremite.Model.NeedModel model = SO.Settings.Needs.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find NeedModel for NeedTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a NeedModel associated with the given NeedTypes.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If no NeedModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.NeedModel ToNeedModel(this NeedTypes types)
	{
		return types.ToName().ToNeedModel();
	}
	
	/// <summary>
	/// Returns an array of NeedModel associated with the given NeedTypes.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If a NeedModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.NeedModel[] ToNeedModelArray(this IEnumerable<NeedTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.NeedModel[] array = new Eremite.Model.NeedModel[count];
		int i = 0;
		foreach (NeedTypes element in collection)
		{
			array[i++] = element.ToNeedModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NeedModel associated with the given NeedTypes.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If a NeedModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.NeedModel[] ToNeedModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.NeedModel[] array = new Eremite.Model.NeedModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToNeedModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of NeedModel associated with the given NeedTypes.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If a NeedModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.NeedModel[] ToNeedModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.NeedModel>.Get(out List<Eremite.Model.NeedModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.NeedModel model = element.ToNeedModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of NeedModel associated with the given NeedTypes.
	/// NeedModel contain all the data that will be used in the game.
	/// Every NeedModel should have a unique name as to distinguish it from others.
	/// If a NeedModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.NeedModel[] ToNeedModelArrayNoNulls(this IEnumerable<NeedTypes> collection)
	{
		using(ListPool<Eremite.Model.NeedModel>.Get(out List<Eremite.Model.NeedModel> list))
		{
			foreach (NeedTypes element in collection)
			{
				Eremite.Model.NeedModel model = element.ToNeedModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<NeedTypes, string> TypeToInternalName = new()
	{
		{ NeedTypes.Any_Housing, "Any Housing" },       // Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
		{ NeedTypes.Beaver_Housing, "Beaver Housing" }, // Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
		{ NeedTypes.Biscuits, "Biscuits" },             // Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Bloodthirst, "Bloodthirst" },       // Brawling - This need is fulfilled in: Clan Hall, Forum, Explorers' Lodge. Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Boots, "Boots" },                   // Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
		{ NeedTypes.Clothes, "Clothes" },               // Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
		{ NeedTypes.Education, "Education" },           // Education - This need is fulfilled in: Temple, Holy Guild House, Guild House, Explorers' Lodge. It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Fox_Housing, "Fox Housing" },       // Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
		{ NeedTypes.Frog_Housing, "Frog Housing" },     // Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
		{ NeedTypes.Harpy_Housing, "Harpy Housing" },   // Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
		{ NeedTypes.Human_Housing, "Human Housing" },   // Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
		{ NeedTypes.Jerky, "Jerky" },                   // Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Leasiure, "Leasiure" },             // Leisure - This need is fulfilled in: Tavern, Monastery, Market. It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Lizard_Housing, "Lizard Housing" }, // Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
		{ NeedTypes.Luxury, "Luxury" },                 // Luxury - This need is fulfilled in: Tavern, Holy Guild House, Forum, Guild House. It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Paste, "Paste" },                   // Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Pickled_Goods, "Pickled Goods" },   // Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Pie, "Pie" },                       // Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Porridge, "Porridge" },             // Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Religion, "Religion" },             // Religion - This need is fulfilled in: Temple, Monastery, Tea Doctor. It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Skewer, "Skewer" },                 // Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
		{ NeedTypes.Treatment, "Treatment" },           // Treatment - This need is fulfilled in: Market, Tea Doctor, Bath House. It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.

	};
}
