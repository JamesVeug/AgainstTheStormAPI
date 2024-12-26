using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.6.2R
/// </summary>
public enum InstitutionRecipeTypes
{
	/// <summary>
	/// Placeholder for an unknown InstitutionRecipeTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no InstitutionRecipeTypes. Typically, seen if nothing is defined or failed to parse a string to a InstitutionRecipeTypes.
	/// </summary>
	None = 0,
	
	/// <summary></summary>
	/// <name>Bloodthirst</name>
	Bloodthirst = 1,

	/// <summary></summary>
	/// <name>Brotherhood_Free</name>
	Brotherhood_Free = 2,

	/// <summary></summary>
	/// <name>Education</name>
	Education = 3,

	/// <summary></summary>
	/// <name>Education_Free</name>
	Education_Free = 4,

	/// <summary></summary>
	/// <name>Leasiure</name>
	Leasiure = 5,

	/// <summary></summary>
	/// <name>Luxury</name>
	Luxury = 6,

	/// <summary></summary>
	/// <name>Luxury_Free</name>
	Luxury_Free = 7,

	/// <summary></summary>
	/// <name>Religion</name>
	Religion = 8,

	/// <summary></summary>
	/// <name>Treatment</name>
	Treatment = 9,



	/// <summary>
	/// The total number of vanilla InstitutionRecipeTypes in the game.
	/// </summary>
	MAX = 9
}

/// <summary>
/// Extension methods for the InstitutionRecipeTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class InstitutionRecipeTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded InstitutionRecipeTypes.
	/// </summary>
	public static InstitutionRecipeTypes[] All()
	{
		InstitutionRecipeTypes[] all = new InstitutionRecipeTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every InstitutionRecipeTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return InstitutionRecipeTypes.Bloodthirst in the enum and log an error.
	/// </summary>
	public static string ToName(this InstitutionRecipeTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of InstitutionRecipeTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[InstitutionRecipeTypes.Bloodthirst];
	}
	
	/// <summary>
	/// Returns a InstitutionRecipeTypes associated with the given name.
	/// Every InstitutionRecipeTypes should have a unique name as to distinguish it from others.
	/// If no InstitutionRecipeTypes is found, it will return InstitutionRecipeTypes.Unknown and log a warning.
	/// </summary>
	public static InstitutionRecipeTypes ToInstitutionRecipeTypes(this string name)
	{
		foreach (KeyValuePair<InstitutionRecipeTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find InstitutionRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return InstitutionRecipeTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a InstitutionRecipeModel associated with the given name.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If no InstitutionRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel ToInstitutionRecipeModel(this string name)
	{
		Eremite.Buildings.InstitutionRecipeModel model = SO.Settings.institutionRecipes.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find InstitutionRecipeModel for InstitutionRecipeTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	/// <summary>
	/// Returns a InstitutionRecipeModel associated with the given InstitutionRecipeTypes.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If no InstitutionRecipeModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel ToInstitutionRecipeModel(this InstitutionRecipeTypes types)
	{
		return types.ToName().ToInstitutionRecipeModel();
	}
	
	/// <summary>
	/// Returns an array of InstitutionRecipeModel associated with the given InstitutionRecipeTypes.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If a InstitutionRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel[] ToInstitutionRecipeModelArray(this IEnumerable<InstitutionRecipeTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.InstitutionRecipeModel[] array = new Eremite.Buildings.InstitutionRecipeModel[count];
		int i = 0;
		foreach (InstitutionRecipeTypes element in collection)
		{
			array[i++] = element.ToInstitutionRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of InstitutionRecipeModel associated with the given InstitutionRecipeTypes.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If a InstitutionRecipeModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel[] ToInstitutionRecipeModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.InstitutionRecipeModel[] array = new Eremite.Buildings.InstitutionRecipeModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToInstitutionRecipeModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of InstitutionRecipeModel associated with the given InstitutionRecipeTypes.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If a InstitutionRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel[] ToInstitutionRecipeModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.InstitutionRecipeModel>.Get(out List<Eremite.Buildings.InstitutionRecipeModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.InstitutionRecipeModel model = element.ToInstitutionRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of InstitutionRecipeModel associated with the given InstitutionRecipeTypes.
	/// InstitutionRecipeModel contain all the data that will be used in the game.
	/// Every InstitutionRecipeModel should have a unique name as to distinguish it from others.
	/// If a InstitutionRecipeModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.InstitutionRecipeModel[] ToInstitutionRecipeModelArrayNoNulls(this IEnumerable<InstitutionRecipeTypes> collection)
	{
		using(ListPool<Eremite.Buildings.InstitutionRecipeModel>.Get(out List<Eremite.Buildings.InstitutionRecipeModel> list))
		{
			foreach (InstitutionRecipeTypes element in collection)
			{
				Eremite.Buildings.InstitutionRecipeModel model = element.ToInstitutionRecipeModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<InstitutionRecipeTypes, string> TypeToInternalName = new()
	{
		{ InstitutionRecipeTypes.Bloodthirst, "Bloodthirst" }, 
		{ InstitutionRecipeTypes.Brotherhood_Free, "Brotherhood_Free" }, 
		{ InstitutionRecipeTypes.Education, "Education" }, 
		{ InstitutionRecipeTypes.Education_Free, "Education_Free" }, 
		{ InstitutionRecipeTypes.Leasiure, "Leasiure" }, 
		{ InstitutionRecipeTypes.Luxury, "Luxury" }, 
		{ InstitutionRecipeTypes.Luxury_Free, "Luxury_Free" }, 
		{ InstitutionRecipeTypes.Religion, "Religion" }, 
		{ InstitutionRecipeTypes.Treatment, "Treatment" }, 

	};
}