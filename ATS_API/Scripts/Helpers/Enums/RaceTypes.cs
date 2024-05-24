using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum RaceTypes
{
    Unknown = -1,
    None,
	Beaver, // Beaver
	Foxes,  // Fox
	Harpy,  // Harpy
	Human,  // Human
	Lizard, // Lizard

    MAX = 5
}

public static class RaceTypesExtensions
{
	public static string ToName(this RaceTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of RaceTypes: " + type);
		return TypeToInternalName[RaceTypes.Beaver];
	}
	
	public static RaceModel ToRaceModel(this string name)
    {
        RaceModel model = SO.Settings.Races.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find RaceModel for RaceTypes with name: " + name);
        return null;
    }

	public static RaceModel ToRaceModel(this RaceTypes types)
	{
		return types.ToName().ToRaceModel();
	}
	
	public static RaceModel[] ToRaceModelArray(this IEnumerable<RaceTypes> collection)
    {
        int count = collection.Count();
        RaceModel[] array = new RaceModel[count];
        int i = 0;
        foreach (RaceTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.Races.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<RaceTypes, string> TypeToInternalName = new()
	{
		{ RaceTypes.Beaver, "Beaver" }, // Beaver
		{ RaceTypes.Foxes, "Foxes" },   // Fox
		{ RaceTypes.Harpy, "Harpy" },   // Harpy
		{ RaceTypes.Human, "Human" },   // Human
		{ RaceTypes.Lizard, "Lizard" }, // Lizard
	};
}
