using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Characters.Villagers;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum VillagerPerkTypes
{
	Unknown = -1,
	None,
	Acidic_Environment,                       // Acidic Environment - Working in a loud environment is really taxing. (‑10 to Global Resolve)
	Acidic_Environment_Blightrot,             // Acidic Environment - Working in a loud environment is really taxing. (‑20 to Global Resolve)
	Blight_Death_Chance,                      // Fading - Villagers with this effect have a +5% chance of perishing every 30 seconds.
	Blight_Faster_Move,                       // Pollen - Blightrot Cysts produce strange pollen that affects the craftsmen in this building. Workers move +20% faster.
	Blight_Fighter_Speed_Speed_Increase,      // Mobile Sparkcasters - A more compact version of the famous Blight Fighter flamethrower. Blight Fighters assigned to this Blight Post move +30% faster.
	Blight_No_Production,                     // Shaky Hands - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	Blight_Production_Boost,                  // Hypnosis - The presence of Blightrot Cysts creates a strange aura within the building. Workers have a +25% chance of doubling their production.
	Charm_Status,                             // Kelpie's Charm - The villager is under the river kelpie's spell, and cannot work until the event is completed.
	cMdlt_Distracted_ColdFront,               // Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	cMdlt_Distracted_StrangeLights,           // Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	cMdlt_Energized_FreshBreeze,              // Energized - Villagers with this effect move +20% faster.
	cMdlt_Energized_InvigoratingWinds,        // Energized - Villagers with this effect move +20% faster.
	cMdlt_Fading_ColdSnap,                    // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	cMdlt_Fading_DeadlyLights,                // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	cMdlt_Fading_EerieSong,                   // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	cMdlt_Fading_Hailstorm,                   // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	cMdlt_FadingToxicRain,                    // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	cMdlt_Focused_StrangeVisions,             // Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
	cMdlt_Focused_SunFestivities,             // Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
	cMdlt_Frustrated_Melanchory,              // Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
	cMdlt_Frustrated_Swarms,                  // Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
	cMdlt_Gluttonous_ColdSnap,                // Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
	cMdlt_Gluttonous_Downpour,                // Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
	cMdlt_HomelessDeath10_RegularRain,        // Danger - Homeless villagers have a +10% chance of dying every 60 seconds during the storm.
	cMdlt_LowResolve_Cloudburst,              // Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
	cMdlt_LowResolve_HomelessInStorm,         // Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
	cMdlt_Motivated_Aurora,                   // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	cMdlt_Motivated_EuphoricVapours,          // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	cMdlt_Motivated_Swarms,                   // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	cMdlt_Slowed_BitterRain,                  // Exhausted - Villagers with this effect move –40% slower.
	cMdlt_Slowed_Fog,                         // Exhausted - Villagers with this effect move –40% slower.
	cMdlt_Stagnant_Eclipse,                   // Stagnant - Villagers with this effect take 200% longer breaks.
	cMdlt_Stagnant_Eclipse_NEW,               // Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
	cMdlt_Stagnant_NauseousSpores,            // Stagnant - Villagers with this effect take 200% longer breaks.
	cMdlt_Stagnant_NauseousSpores_NEW,        // Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
	Comfortable_Job,                          // Comfortable - This worker gains +5 to their Resolve. (+5 to Global Resolve)
	Extreme_Noise,                            // Extreme Noise - Working in a loud environment is really taxing. (‑5 to Global Resolve)
	FallenViceroyCommemoration,               // Fallen Viceroy Commemoration - Villagers with their need for species-specific housing met will get an additional +2 to Resolve. (+2 to Global Resolve)
	FarmersDiet,                              // Farmer's Diet - Farmers have a +75% chance of producing double yields when under the effect of <sprite name="[food processed] biscuits"> biscuits.
	Faster_Woocutters,                        // Lightweight Axes - Woodcutters move +20% faster.
	Forced_Improvisation,                     // Forced Improvisation - Working in a loud environment is really taxing. (‑5 to Global Resolve)
	Furniture,                                // Furniture - Adds an additional +1 to Resolve for villagers with a home. (+1 to Global Resolve)
	Global_Chance_Of_Death,                   // Overtime - Results matter more than your villagers’ health. Increases global production speed by 120, but villagers have a +1% chance of dying every 120 seconds.
	Hauler_Break_Interval_Villager_Perk,      // Travel Rations - With provisions, haulers don't have to return to the Hearth as often. Increases time between breaks for haulers by +50%.
	Hauler_Speed_Villager_Perk,               // HaulerUpgrade_Speed_Name - Specialized equipment enhanced with rainpunk technology. Haulers move +25% faster.
	Houses_Plus1_Break_Time_Child,            // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	Leisure_Worker,                           // Ballmer Peak - Villagers with the leisure need fulfilled have a +25% chance of doubling their yields.
	LessHostilityPerWoodcutter_Proficiency,   // Flame Amulets - Woodcutters have a +20% chance of producing twice the normal yield.
	MoleResolvePenalty_Hard,                  // Giant Beast - Villagers are afraid of going into the woods. (‑18 to Global Resolve)
	MoleResolvePenalty_Impossible,            // Giant Beast - Villagers are afraid of going into the woods. (‑22 to Global Resolve)
	MoleResolvePenalty_Normal,                // Giant Beast - Villagers are afraid of going into the woods. (‑16 to Global Resolve)
	MoleResolvePenalty_Very_Hard,             // Giant Beast - Villagers are afraid of going into the woods. (‑20 to Global Resolve)
	N_Need_Villagers_Speed_Bonus,             // Boots - Increases movement speed by +15%.
	Need_Complex_Food_Extra_Production,       // Full Belly - This worker has a +5% higher chance of producing double yields for each Complex Food need met.
	Need_Service_Goods_Extra_Production,      // High Motivation - This worker has a +10% higher chance of producing double yields for each Complex Food need met.
	Poisoned_Food_Instant,                    // Poisoned Food - Fishmen are small and cunning enough to sneak into a settlement and poison the food supply. Villagers have a +25% chance of death after eating.
	Proficiency,                              // Proficiency - This worker has a +10% chance of doubling their yield.
	Proficiency_Blightrot,                    // Proficiency - This worker has a +40% chance of doubling their yield.
	Rainpunk_Comfortable,                     // Low Strain - Work is much easier with Rain Engines on (+5 to Resolve).
	RottingWoodDestroyYield,                  // Rotting Wood - Villagers with this effect have a +100% chance of destroying the yield with each production cycle.
	Royal_Guard_Training_Resolve_Reward,      // Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them.  (+5 to Global Resolve)
	SE_Hot_Springs_Villager_Resolve_Effect,   // Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators. (+10 to Global Resolve)
	SE_Longer_Break_Interval_Child,           // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	SE_Mine_In_Storm_Villager_Resolve_Effect, // Horrors from Beneath - A strange chant is frightening the villagers. (‑10 to Global Resolve)
	Shaky_Hands,                              // Shaky Hands - Discovering the remains of a caravan has caused unrest in the settlement. All villagers have a +30% chance of destroying a production yield.
	Shorter_Break_NEW,                        // Drying Boards - Time between breaks is increased by +10% for villagers with the need for <sprite name="[needs] coats"> coats fulfilled.
	SickTreesDestroyYield,                    // Reward_Composite_SickTrees_Name - Villagers with this effect have a +40% chance of destroying the yield with each production cycle.
	Smart_Worker,                             // Working Hard and Smart - Has a 10% chance of producing double yields when under the effect of <sprite name="[needs] scrolls"> education.
	Spiced_Ale,                               // Spiced Ale - Additional +5 to Resolve when under the effect of <sprite name="[needs] ale"> leisure. (+5 to Global Resolve)
	U_Frog_Houses_Bonus_Resolve,              // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive. (+2 to Global Resolve)
	U_Houses_Bonus_Resolve,                   // Stove - A small reminder of the Holy Flame. (+1 to Global Resolve)
	U_Houses_Villagers_Speed_Bonus,           // Soft Beds - Villagers living in a house with this upgrade move +15% faster.
	VaultResolvePenalty_Normal,               // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑12 to Global Resolve)
	Very_Long_Breaks,                         // Drying Boards - Time between breaks is increased by 10000% for villagers with the need for <sprite name="[needs] coats"> coats fulfilled.


	MAX = 74
}

public static class VillagerPerkTypesExtensions
{
	private static VillagerPerkTypes[] s_All = null;
	public static VillagerPerkTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new VillagerPerkTypes[74];
			for (int i = 0; i < 74; i++)
			{
				s_All[i] = (VillagerPerkTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this VillagerPerkTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of VillagerPerkTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[VillagerPerkTypes.Acidic_Environment];
	}
	
	public static VillagerPerkTypes ToVillagerPerkTypes(this string name)
	{
		foreach (KeyValuePair<VillagerPerkTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find VillagerPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return VillagerPerkTypes.Unknown;
	}
	
	public static VillagerPerkModel ToVillagerPerkModel(this string name)
	{
		VillagerPerkModel model = SO.Settings.villagersPerks.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find VillagerPerkModel for VillagerPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static VillagerPerkModel ToVillagerPerkModel(this VillagerPerkTypes types)
	{
		return types.ToName().ToVillagerPerkModel();
	}
	
	public static VillagerPerkModel[] ToVillagerPerkModelArray(this IEnumerable<VillagerPerkTypes> collection)
	{
		int count = collection.Count();
		VillagerPerkModel[] array = new VillagerPerkModel[count];
		int i = 0;
		foreach (VillagerPerkTypes element in collection)
		{
			array[i++] = element.ToVillagerPerkModel();
		}

		return array;
	}
	
	public static VillagerPerkModel[] ToVillagerPerkModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		VillagerPerkModel[] array = new VillagerPerkModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToVillagerPerkModel();
		}

		return array;
	}

	internal static readonly Dictionary<VillagerPerkTypes, string> TypeToInternalName = new()
	{
		{ VillagerPerkTypes.Acidic_Environment, "Acidic Environment" },                                               // Acidic Environment - Working in a loud environment is really taxing. (‑10 to Global Resolve)
		{ VillagerPerkTypes.Acidic_Environment_Blightrot, "Acidic Environment Blightrot" },                           // Acidic Environment - Working in a loud environment is really taxing. (‑20 to Global Resolve)
		{ VillagerPerkTypes.Blight_Death_Chance, "Blight Death Chance" },                                             // Fading - Villagers with this effect have a +5% chance of perishing every 30 seconds.
		{ VillagerPerkTypes.Blight_Faster_Move, "Blight_Faster_Move" },                                               // Pollen - Blightrot Cysts produce strange pollen that affects the craftsmen in this building. Workers move +20% faster.
		{ VillagerPerkTypes.Blight_Fighter_Speed_Speed_Increase, "Blight Fighter Speed - Speed Increase" },           // Mobile Sparkcasters - A more compact version of the famous Blight Fighter flamethrower. Blight Fighters assigned to this Blight Post move +30% faster.
		{ VillagerPerkTypes.Blight_No_Production, "Blight No Production" },                                           // Shaky Hands - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.Blight_Production_Boost, "Blight_Production_Boost" },                                     // Hypnosis - The presence of Blightrot Cysts creates a strange aura within the building. Workers have a +25% chance of doubling their production.
		{ VillagerPerkTypes.Charm_Status, "Charm Status" },                                                           // Kelpie's Charm - The villager is under the river kelpie's spell, and cannot work until the event is completed.
		{ VillagerPerkTypes.cMdlt_Distracted_ColdFront, "cMdlt_Distracted_ColdFront" },                               // Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.cMdlt_Distracted_StrangeLights, "cMdlt_Distracted_StrangeLights" },                       // Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.cMdlt_Energized_FreshBreeze, "cMdlt_Energized_FreshBreeze" },                             // Energized - Villagers with this effect move +20% faster.
		{ VillagerPerkTypes.cMdlt_Energized_InvigoratingWinds, "cMdlt_Energized_InvigoratingWinds" },                 // Energized - Villagers with this effect move +20% faster.
		{ VillagerPerkTypes.cMdlt_Fading_ColdSnap, "cMdlt_Fading_ColdSnap" },                                         // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
		{ VillagerPerkTypes.cMdlt_Fading_DeadlyLights, "cMdlt_Fading_DeadlyLights" },                                 // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
		{ VillagerPerkTypes.cMdlt_Fading_EerieSong, "cMdlt_Fading_EerieSong" },                                       // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
		{ VillagerPerkTypes.cMdlt_Fading_Hailstorm, "cMdlt_Fading_Hailstorm" },                                       // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
		{ VillagerPerkTypes.cMdlt_FadingToxicRain, "cMdlt_FadingToxicRain" },                                         // Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
		{ VillagerPerkTypes.cMdlt_Focused_StrangeVisions, "cMdlt_Focused_StrangeVisions" },                           // Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
		{ VillagerPerkTypes.cMdlt_Focused_SunFestivities, "cMdlt_Focused_SunFestivities" },                           // Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
		{ VillagerPerkTypes.cMdlt_Frustrated_Melanchory, "cMdlt_Frustrated_Melanchory" },                             // Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
		{ VillagerPerkTypes.cMdlt_Frustrated_Swarms, "cMdlt_Frustrated_Swarms" },                                     // Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
		{ VillagerPerkTypes.cMdlt_Gluttonous_ColdSnap, "cMdlt_Gluttonous_ColdSnap" },                                 // Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
		{ VillagerPerkTypes.cMdlt_Gluttonous_Downpour, "cMdlt_Gluttonous_Downpour" },                                 // Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
		{ VillagerPerkTypes.cMdlt_HomelessDeath10_RegularRain, "cMdlt_HomelessDeath10_RegularRain" },                 // Danger - Homeless villagers have a +10% chance of dying every 60 seconds during the storm.
		{ VillagerPerkTypes.cMdlt_LowResolve_Cloudburst, "cMdlt_LowResolve_Cloudburst" },                             // Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
		{ VillagerPerkTypes.cMdlt_LowResolve_HomelessInStorm, "cMdlt_LowResolve_HomelessInStorm" },                   // Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
		{ VillagerPerkTypes.cMdlt_Motivated_Aurora, "cMdlt_Motivated_Aurora" },                                       // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
		{ VillagerPerkTypes.cMdlt_Motivated_EuphoricVapours, "cMdlt_Motivated_EuphoricVapours" },                     // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
		{ VillagerPerkTypes.cMdlt_Motivated_Swarms, "cMdlt_Motivated_Swarms" },                                       // Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
		{ VillagerPerkTypes.cMdlt_Slowed_BitterRain, "cMdlt_Slowed_BitterRain" },                                     // Exhausted - Villagers with this effect move –40% slower.
		{ VillagerPerkTypes.cMdlt_Slowed_Fog, "cMdlt_Slowed_Fog" },                                                   // Exhausted - Villagers with this effect move –40% slower.
		{ VillagerPerkTypes.cMdlt_Stagnant_Eclipse, "cMdlt_Stagnant_Eclipse" },                                       // Stagnant - Villagers with this effect take 200% longer breaks.
		{ VillagerPerkTypes.cMdlt_Stagnant_Eclipse_NEW, "cMdlt_Stagnant_Eclipse_NEW" },                               // Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
		{ VillagerPerkTypes.cMdlt_Stagnant_NauseousSpores, "cMdlt_Stagnant_NauseousSpores" },                         // Stagnant - Villagers with this effect take 200% longer breaks.
		{ VillagerPerkTypes.cMdlt_Stagnant_NauseousSpores_NEW, "cMdlt_Stagnant_NauseousSpores_NEW" },                 // Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
		{ VillagerPerkTypes.Comfortable_Job, "Comfortable Job" },                                                     // Comfortable - This worker gains +5 to their Resolve. (+5 to Global Resolve)
		{ VillagerPerkTypes.Extreme_Noise, "Extreme Noise" },                                                         // Extreme Noise - Working in a loud environment is really taxing. (‑5 to Global Resolve)
		{ VillagerPerkTypes.FallenViceroyCommemoration, "FallenViceroyCommemoration" },                               // Fallen Viceroy Commemoration - Villagers with their need for species-specific housing met will get an additional +2 to Resolve. (+2 to Global Resolve)
		{ VillagerPerkTypes.FarmersDiet, "FarmersDiet" },                                                             // Farmer's Diet - Farmers have a +75% chance of producing double yields when under the effect of <sprite name="[food processed] biscuits"> biscuits.
		{ VillagerPerkTypes.Faster_Woocutters, "Faster Woocutters" },                                                 // Lightweight Axes - Woodcutters move +20% faster.
		{ VillagerPerkTypes.Forced_Improvisation, "Forced Improvisation" },                                           // Forced Improvisation - Working in a loud environment is really taxing. (‑5 to Global Resolve)
		{ VillagerPerkTypes.Furniture, "Furniture" },                                                                 // Furniture - Adds an additional +1 to Resolve for villagers with a home. (+1 to Global Resolve)
		{ VillagerPerkTypes.Global_Chance_Of_Death, "Global Chance of Death" },                                       // Overtime - Results matter more than your villagers’ health. Increases global production speed by 120, but villagers have a +1% chance of dying every 120 seconds.
		{ VillagerPerkTypes.Hauler_Break_Interval_Villager_Perk, "Hauler Break Interval - villager perk" },           // Travel Rations - With provisions, haulers don't have to return to the Hearth as often. Increases time between breaks for haulers by +50%.
		{ VillagerPerkTypes.Hauler_Speed_Villager_Perk, "Hauler Speed - villager perk" },                             // HaulerUpgrade_Speed_Name - Specialized equipment enhanced with rainpunk technology. Haulers move +25% faster.
		{ VillagerPerkTypes.Houses_Plus1_Break_Time_Child, "Houses +1 - break time - child" },                        // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
		{ VillagerPerkTypes.Leisure_Worker, "Leisure Worker" },                                                       // Ballmer Peak - Villagers with the leisure need fulfilled have a +25% chance of doubling their yields.
		{ VillagerPerkTypes.LessHostilityPerWoodcutter_Proficiency, "LessHostilityPerWoodcutter - Proficiency" },     // Flame Amulets - Woodcutters have a +20% chance of producing twice the normal yield.
		{ VillagerPerkTypes.MoleResolvePenalty_Hard, "MoleResolvePenalty - hard" },                                   // Giant Beast - Villagers are afraid of going into the woods. (‑18 to Global Resolve)
		{ VillagerPerkTypes.MoleResolvePenalty_Impossible, "MoleResolvePenalty - impossible" },                       // Giant Beast - Villagers are afraid of going into the woods. (‑22 to Global Resolve)
		{ VillagerPerkTypes.MoleResolvePenalty_Normal, "MoleResolvePenalty - normal" },                               // Giant Beast - Villagers are afraid of going into the woods. (‑16 to Global Resolve)
		{ VillagerPerkTypes.MoleResolvePenalty_Very_Hard, "MoleResolvePenalty - very hard" },                         // Giant Beast - Villagers are afraid of going into the woods. (‑20 to Global Resolve)
		{ VillagerPerkTypes.N_Need_Villagers_Speed_Bonus, "[N] Need Villagers Speed Bonus" },                         // Boots - Increases movement speed by +15%.
		{ VillagerPerkTypes.Need_Complex_Food_Extra_Production, "Need Complex Food Extra Production" },               // Full Belly - This worker has a +5% higher chance of producing double yields for each Complex Food need met.
		{ VillagerPerkTypes.Need_Service_Goods_Extra_Production, "Need Service Goods Extra Production" },             // High Motivation - This worker has a +10% higher chance of producing double yields for each Complex Food need met.
		{ VillagerPerkTypes.Poisoned_Food_Instant, "Poisoned Food Instant" },                                         // Poisoned Food - Fishmen are small and cunning enough to sneak into a settlement and poison the food supply. Villagers have a +25% chance of death after eating.
		{ VillagerPerkTypes.Proficiency, "Proficiency" },                                                             // Proficiency - This worker has a +10% chance of doubling their yield.
		{ VillagerPerkTypes.Proficiency_Blightrot, "Proficiency Blightrot" },                                         // Proficiency - This worker has a +40% chance of doubling their yield.
		{ VillagerPerkTypes.Rainpunk_Comfortable, "Rainpunk Comfortable" },                                           // Low Strain - Work is much easier with Rain Engines on (+5 to Resolve).
		{ VillagerPerkTypes.RottingWoodDestroyYield, "RottingWoodDestroyYield" },                                     // Rotting Wood - Villagers with this effect have a +100% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.Royal_Guard_Training_Resolve_Reward, "Royal Guard Training - Resolve Reward" },           // Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them.  (+5 to Global Resolve)
		{ VillagerPerkTypes.SE_Hot_Springs_Villager_Resolve_Effect, "SE Hot Springs (Villager Resolve Effect)" },     // Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators. (+10 to Global Resolve)
		{ VillagerPerkTypes.SE_Longer_Break_Interval_Child, "SE Longer Break Interval - child" },                     // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
		{ VillagerPerkTypes.SE_Mine_In_Storm_Villager_Resolve_Effect, "SE Mine in Storm (Villager Resolve Effect)" }, // Horrors from Beneath - A strange chant is frightening the villagers. (‑10 to Global Resolve)
		{ VillagerPerkTypes.Shaky_Hands, "Shaky Hands" },                                                             // Shaky Hands - Discovering the remains of a caravan has caused unrest in the settlement. All villagers have a +30% chance of destroying a production yield.
		{ VillagerPerkTypes.Shorter_Break_NEW, "Shorter Break NEW" },                                                 // Drying Boards - Time between breaks is increased by +10% for villagers with the need for <sprite name="[needs] coats"> coats fulfilled.
		{ VillagerPerkTypes.SickTreesDestroyYield, "SickTreesDestroyYield" },                                         // Reward_Composite_SickTrees_Name - Villagers with this effect have a +40% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.Smart_Worker, "Smart Worker" },                                                           // Working Hard and Smart - Has a 10% chance of producing double yields when under the effect of <sprite name="[needs] scrolls"> education.
		{ VillagerPerkTypes.Spiced_Ale, "Spiced Ale" },                                                               // Spiced Ale - Additional +5 to Resolve when under the effect of <sprite name="[needs] ale"> leisure. (+5 to Global Resolve)
		{ VillagerPerkTypes.U_Frog_Houses_Bonus_Resolve, "[U] Frog Houses Bonus Resolve" },                           // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive. (+2 to Global Resolve)
		{ VillagerPerkTypes.U_Houses_Bonus_Resolve, "[U] Houses Bonus Resolve" },                                     // Stove - A small reminder of the Holy Flame. (+1 to Global Resolve)
		{ VillagerPerkTypes.U_Houses_Villagers_Speed_Bonus, "[U] Houses Villagers Speed Bonus" },                     // Soft Beds - Villagers living in a house with this upgrade move +15% faster.
		{ VillagerPerkTypes.VaultResolvePenalty_Normal, "VaultResolvePenalty - normal" },                             // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑12 to Global Resolve)
		{ VillagerPerkTypes.Very_Long_Breaks, "Very Long Breaks" },                                                   // Drying Boards - Time between breaks is increased by 10000% for villagers with the need for <sprite name="[needs] coats"> coats fulfilled.

	};
}
