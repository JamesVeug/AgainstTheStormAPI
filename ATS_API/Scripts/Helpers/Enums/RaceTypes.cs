using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum RaceTypes
{
    /// <summary>
    /// Placeholder for an unknown RaceTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no RaceTypes. Typically, seen if nothing is defined or failed to parse a string to a RaceTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Beaver - Beavers are hardworking and honest, but also quite demanding. They are gifted woodworkers ("wood") and enjoy engineering ("tech"). Beavers are also known for their innate talent for salesmanship.
	/// </summary>
	/// <name>Beaver</name>
	Beaver = 1,

	/// <summary>
	/// Fox - Majestic and mysterious creatures, deeply connected to the forest. They have developed a symbiosis with Blightrot through their long exposure to rainwater. Foxes are skilled scouts ("foxforest") and feel comfortable working in buildings infested with Blightrot ("cysts"). They are highly susceptible to starvation, yet are immune to Hostility.
	/// </summary>
	/// <name>Foxes</name>
	Foxes = 2,

	/// <summary>
	/// Frog - A dignified and proud people with a unique affinity for wealth, renowned for their exceptional skills in architecture and their love of water. Shelters do not satisfy them - they require pools of water to feel truly at home. Frogs are skilled masons ("stone") and love working with rainwater ("rainwater").
	/// </summary>
	/// <name>Frog</name>
	Frog = 3,

	/// <summary>
	/// Harpy - Harpies are a noble and fragile species, with a primal, aggressive side to them. They have lost their ability to fly due to centuries of exposure to the rain. They excel at alchemy ("alchemy") and love to work with cloth ("cloth").
	/// </summary>
	/// <name>Harpy</name>
	Harpy = 4,

	/// <summary>
	/// Human - Humans are a very adaptable species, but they are also very susceptible to the rain. They rely heavily on special clothing, such as their famous rain shells, to keep them dry. Humans are adept at farming ("farming") and really enjoy brewing ("brewing").
	/// </summary>
	/// <name>Human</name>
	Human = 5,

	/// <summary>
	/// Lizard - Lizards are a very resilient species, but their cold-blooded nature makes them more dependent on fire than any other species. They are very distrustful and religiously believe that true bonds are only forged in battle. They are very good with animals and meat production ("meat"), and prefer to work in warm environments ("fire").
	/// </summary>
	/// <name>Lizard</name>
	Lizard = 6,



    /// <summary>
    /// The total number of vanilla RaceTypes in the game.
    /// </summary>
	MAX = 6
}

/// <summary>
/// Extension methods for the RaceTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class RaceTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded RaceTypes.
	/// </summary>
	public static RaceTypes[] All()
	{
		RaceTypes[] all = new RaceTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every RaceTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return RaceTypes.Beaver in the enum and log an error.
	/// </summary>
	public static string ToName(this RaceTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of RaceTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[RaceTypes.Beaver];
	}
	
	/// <summary>
	/// Returns a RaceTypes associated with the given name.
	/// Every RaceTypes should have a unique name as to distinguish it from others.
	/// If no RaceTypes is found, it will return RaceTypes.Unknown and log a warning.
	/// </summary>
	public static RaceTypes ToRaceTypes(this string name)
	{
		foreach (KeyValuePair<RaceTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find RaceTypes with name: " + name + "\n" + Environment.StackTrace);
		return RaceTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a RaceModel associated with the given name.
	/// RaceModel contain all the data that will be used in the game.
	/// Every RaceModel should have a unique name as to distinguish it from others.
	/// If no RaceModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.RaceModel ToRaceModel(this string name)
	{
		Eremite.Model.RaceModel model = SO.Settings.Races.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find RaceModel for RaceTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a RaceModel associated with the given RaceTypes.
    /// RaceModel contain all the data that will be used in the game.
    /// Every RaceModel should have a unique name as to distinguish it from others.
    /// If no RaceModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.RaceModel ToRaceModel(this RaceTypes types)
	{
		return types.ToName().ToRaceModel();
	}
	
	/// <summary>
	/// Returns an array of RaceModel associated with the given RaceTypes.
	/// RaceModel contain all the data that will be used in the game.
	/// Every RaceModel should have a unique name as to distinguish it from others.
	/// If a RaceModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.RaceModel[] ToRaceModelArray(this IEnumerable<RaceTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.RaceModel[] array = new Eremite.Model.RaceModel[count];
		int i = 0;
		foreach (RaceTypes element in collection)
		{
			array[i++] = element.ToRaceModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RaceModel associated with the given RaceTypes.
	/// RaceModel contain all the data that will be used in the game.
	/// Every RaceModel should have a unique name as to distinguish it from others.
	/// If a RaceModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.RaceModel[] ToRaceModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.RaceModel[] array = new Eremite.Model.RaceModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToRaceModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RaceModel associated with the given RaceTypes.
	/// RaceModel contain all the data that will be used in the game.
	/// Every RaceModel should have a unique name as to distinguish it from others.
	/// If a RaceModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.RaceModel[] ToRaceModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.RaceModel>.Get(out List<Eremite.Model.RaceModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.RaceModel model = element.ToRaceModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of RaceModel associated with the given RaceTypes.
	/// RaceModel contain all the data that will be used in the game.
	/// Every RaceModel should have a unique name as to distinguish it from others.
	/// If a RaceModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.RaceModel[] ToRaceModelArrayNoNulls(this IEnumerable<RaceTypes> collection)
	{
		using(ListPool<Eremite.Model.RaceModel>.Get(out List<Eremite.Model.RaceModel> list))
		{
			foreach (RaceTypes element in collection)
			{
				Eremite.Model.RaceModel model = element.ToRaceModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<RaceTypes, string> TypeToInternalName = new()
	{
		{ RaceTypes.Beaver, "Beaver" }, // Beaver - Beavers are hardworking and honest, but also quite demanding. They are gifted woodworkers ("wood") and enjoy engineering ("tech"). Beavers are also known for their innate talent for salesmanship.
		{ RaceTypes.Foxes, "Foxes" },   // Fox - Majestic and mysterious creatures, deeply connected to the forest. They have developed a symbiosis with Blightrot through their long exposure to rainwater. Foxes are skilled scouts ("foxforest") and feel comfortable working in buildings infested with Blightrot ("cysts"). They are highly susceptible to starvation, yet are immune to Hostility.
		{ RaceTypes.Frog, "Frog" },     // Frog - A dignified and proud people with a unique affinity for wealth, renowned for their exceptional skills in architecture and their love of water. Shelters do not satisfy them - they require pools of water to feel truly at home. Frogs are skilled masons ("stone") and love working with rainwater ("rainwater").
		{ RaceTypes.Harpy, "Harpy" },   // Harpy - Harpies are a noble and fragile species, with a primal, aggressive side to them. They have lost their ability to fly due to centuries of exposure to the rain. They excel at alchemy ("alchemy") and love to work with cloth ("cloth").
		{ RaceTypes.Human, "Human" },   // Human - Humans are a very adaptable species, but they are also very susceptible to the rain. They rely heavily on special clothing, such as their famous rain shells, to keep them dry. Humans are adept at farming ("farming") and really enjoy brewing ("brewing").
		{ RaceTypes.Lizard, "Lizard" }, // Lizard - Lizards are a very resilient species, but their cold-blooded nature makes them more dependent on fire than any other species. They are very distrustful and religiously believe that true bonds are only forged in battle. They are very good with animals and meat production ("meat"), and prefer to work in warm environments ("fire").

	};
}
