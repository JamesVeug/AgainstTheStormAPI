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
	Beaver, // Beaver - Beavers are hardworking and honest, but also quite demanding. They are gifted woodworkers (<sprite name="wood">) and enjoy engineering (<sprite name="tech">). Beavers are also known for their innate talent for salesmanship.
	Foxes,  // Fox - Majestic and mysterious creatures, deeply connected to the forest. They have developed a symbiosis with Blightrot through their long exposure to rainwater. Foxes are skilled scouts (<sprite name="foxforest">) and feel comfortable working with rainwater (<sprite name="rainwater">). They are highly susceptible to starvation and immune to Hostility.
	Harpy,  // Harpy - Harpies are a noble and fragile species, with a primal, aggressive side to them. They have lost their ability to fly due to centuries of exposure to the rain. They excel at alchemy (<sprite name="alchemy">) and love to work with cloth (<sprite name="cloth">).
	Human,  // Human - Humans are a very adaptable species, but they are also very susceptible to the rain. They rely heavily on special clothing, such as their famous rain shells, to keep them dry. Humans are adept at farming (<sprite name="farming">) and really enjoy brewing (<sprite name="brewing">).
	Lizard, // Lizard - Lizards are a very resilient species, but their cold-blooded nature makes them more dependent on fire than any other species. They are very distrustful and religiously believe that true bonds are only forged in battle. They are very good with animals and meat production (<sprite name="meat">), and prefer to work in warm environments (<sprite name="fire">).


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
		{ RaceTypes.Beaver, "Beaver" }, // Beaver - Beavers are hardworking and honest, but also quite demanding. They are gifted woodworkers (<sprite name="wood">) and enjoy engineering (<sprite name="tech">). Beavers are also known for their innate talent for salesmanship.
		{ RaceTypes.Foxes, "Foxes" },   // Fox - Majestic and mysterious creatures, deeply connected to the forest. They have developed a symbiosis with Blightrot through their long exposure to rainwater. Foxes are skilled scouts (<sprite name="foxforest">) and feel comfortable working with rainwater (<sprite name="rainwater">). They are highly susceptible to starvation and immune to Hostility.
		{ RaceTypes.Harpy, "Harpy" },   // Harpy - Harpies are a noble and fragile species, with a primal, aggressive side to them. They have lost their ability to fly due to centuries of exposure to the rain. They excel at alchemy (<sprite name="alchemy">) and love to work with cloth (<sprite name="cloth">).
		{ RaceTypes.Human, "Human" },   // Human - Humans are a very adaptable species, but they are also very susceptible to the rain. They rely heavily on special clothing, such as their famous rain shells, to keep them dry. Humans are adept at farming (<sprite name="farming">) and really enjoy brewing (<sprite name="brewing">).
		{ RaceTypes.Lizard, "Lizard" }, // Lizard - Lizards are a very resilient species, but their cold-blooded nature makes them more dependent on fire than any other species. They are very distrustful and religiously believe that true bonds are only forged in battle. They are very good with animals and meat production (<sprite name="meat">), and prefer to work in warm environments (<sprite name="fire">).

	};
}
