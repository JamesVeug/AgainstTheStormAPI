using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Characters.Villagers;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum VillagerPerkTypes
{
	/// <summary>
	/// Placeholder for an unknown VillagerPerkTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no VillagerPerkTypes. Typically, seen if nothing is defined or failed to parse a string to a VillagerPerkTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Acidic Environment - Working in a loud environment is really taxing. (‑10 to Global Resolve)
	/// </summary>
	/// <name>Acidic Environment</name>
	Acidic_Environment = 1,

	/// <summary>
	/// Acidic Environment - Working in a loud environment is really taxing. (‑20 to Global Resolve)
	/// </summary>
	/// <name>Acidic Environment Blightrot</name>
	Acidic_Environment_Blightrot = 2,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 30 seconds.
	/// </summary>
	/// <name>Blight Death Chance</name>
	Blight_Death_Chance = 3,

	/// <summary>
	/// Pollen - Blightrot Cysts produce strange pollen that affects the craftsmen in this building. Workers move +20% faster.
	/// </summary>
	/// <name>Blight_Faster_Move</name>
	Blight_Faster_Move = 4,

	/// <summary>
	/// Mobile Sparkcasters - A more compact version of the famous Blight Fighter flamethrower. Blight Fighters assigned to this Blight Post move +30% faster.
	/// </summary>
	/// <name>Blight Fighter Speed - Speed Increase</name>
	Blight_Fighter_Speed_Speed_Increase = 5,

	/// <summary>
	/// Shaky Hands - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	/// </summary>
	/// <name>Blight No Production</name>
	Blight_No_Production = 6,

	/// <summary>
	/// Hypnosis - The presence of Blightrot Cysts creates a strange aura within the building. Workers have a +25% chance of doubling their production.
	/// </summary>
	/// <name>Blight_Production_Boost</name>
	Blight_Production_Boost = 7,

	/// <summary>
	/// Kelpie's Charm - The villager is under the river kelpie's spell, and cannot work until the event is completed.
	/// </summary>
	/// <name>Charm Status</name>
	Charm_Status = 8,

	/// <summary>
	/// Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	/// </summary>
	/// <name>cMdlt_Distracted_ColdFront</name>
	cMdlt_Distracted_ColdFront = 9,

	/// <summary>
	/// Distracted - Villagers with this effect have a +20% chance of destroying the yield with each production cycle.
	/// </summary>
	/// <name>cMdlt_Distracted_StrangeLights</name>
	cMdlt_Distracted_StrangeLights = 10,

	/// <summary>
	/// Energized - Villagers with this effect move +20% faster.
	/// </summary>
	/// <name>cMdlt_Energized_FreshBreeze</name>
	cMdlt_Energized_FreshBreeze = 11,

	/// <summary>
	/// Energized - Villagers with this effect move +20% faster.
	/// </summary>
	/// <name>cMdlt_Energized_InvigoratingWinds</name>
	cMdlt_Energized_InvigoratingWinds = 12,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	/// </summary>
	/// <name>cMdlt_Fading_ColdSnap</name>
	cMdlt_Fading_ColdSnap = 13,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	/// </summary>
	/// <name>cMdlt_Fading_DeadlyLights</name>
	cMdlt_Fading_DeadlyLights = 14,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	/// </summary>
	/// <name>cMdlt_Fading_EerieSong</name>
	cMdlt_Fading_EerieSong = 15,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	/// </summary>
	/// <name>cMdlt_Fading_Hailstorm</name>
	cMdlt_Fading_Hailstorm = 16,

	/// <summary>
	/// Fading - Villagers with this effect have a +5% chance of perishing every 15 seconds.
	/// </summary>
	/// <name>cMdlt_FadingToxicRain</name>
	cMdlt_FadingToxicRain = 17,

	/// <summary>
	/// Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
	/// </summary>
	/// <name>cMdlt_Focused_StrangeVisions</name>
	cMdlt_Focused_StrangeVisions = 18,

	/// <summary>
	/// Focused - Villagers with this effect have a +20% chance of doubling the yield with each production cycle.
	/// </summary>
	/// <name>cMdlt_Focused_SunFestivities</name>
	cMdlt_Focused_SunFestivities = 19,

	/// <summary>
	/// Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
	/// </summary>
	/// <name>cMdlt_Frustrated_Melanchory</name>
	cMdlt_Frustrated_Melanchory = 20,

	/// <summary>
	/// Frustrated - Villagers with this effect have a -2 penalty to their Resolve. (A stack of this effect is added every 60 seconds)
	/// </summary>
	/// <name>cMdlt_Frustrated_Swarms</name>
	cMdlt_Frustrated_Swarms = 21,

	/// <summary>
	/// Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
	/// </summary>
	/// <name>cMdlt_Gluttonous_ColdSnap</name>
	cMdlt_Gluttonous_ColdSnap = 22,

	/// <summary>
	/// Gluttonous - Villagers with this effect have a +50% chance of consuming double the amount of food during a break.
	/// </summary>
	/// <name>cMdlt_Gluttonous_Downpour</name>
	cMdlt_Gluttonous_Downpour = 23,

	/// <summary>
	/// Danger - Homeless villagers have a +10% chance of dying every 60 seconds during the storm.
	/// </summary>
	/// <name>cMdlt_HomelessDeath10_RegularRain</name>
	cMdlt_HomelessDeath10_RegularRain = 24,

	/// <summary>
	/// Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
	/// </summary>
	/// <name>cMdlt_LowResolve_Cloudburst</name>
	cMdlt_LowResolve_Cloudburst = 25,

	/// <summary>
	/// Drenched - Villagers with this effect have a -5 penalty to their Resolve. (‑5 to Global Resolve)
	/// </summary>
	/// <name>cMdlt_LowResolve_HomelessInStorm</name>
	cMdlt_LowResolve_HomelessInStorm = 26,

	/// <summary>
	/// Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	/// </summary>
	/// <name>cMdlt_Motivated_Aurora</name>
	cMdlt_Motivated_Aurora = 27,

	/// <summary>
	/// Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	/// </summary>
	/// <name>cMdlt_Motivated_EuphoricVapours</name>
	cMdlt_Motivated_EuphoricVapours = 28,

	/// <summary>
	/// Motivated - Villagers with this effect have a +1 boost to their Resolve. (A stack of this effect is added every 60 seconds)
	/// </summary>
	/// <name>cMdlt_Motivated_Swarms</name>
	cMdlt_Motivated_Swarms = 29,

	/// <summary>
	/// Exhausted - Villagers with this effect move –40% slower.
	/// </summary>
	/// <name>cMdlt_Slowed_BitterRain</name>
	cMdlt_Slowed_BitterRain = 30,

	/// <summary>
	/// Exhausted - Villagers with this effect move –40% slower.
	/// </summary>
	/// <name>cMdlt_Slowed_Fog</name>
	cMdlt_Slowed_Fog = 31,

	/// <summary>
	/// Stagnant - Villagers with this effect take 200% longer breaks.
	/// </summary>
	/// <name>cMdlt_Stagnant_Eclipse</name>
	cMdlt_Stagnant_Eclipse = 32,

	/// <summary>
	/// Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
	/// </summary>
	/// <name>cMdlt_Stagnant_Eclipse_NEW</name>
	cMdlt_Stagnant_Eclipse_NEW = 33,

	/// <summary>
	/// Stagnant - Villagers with this effect take 200% longer breaks.
	/// </summary>
	/// <name>cMdlt_Stagnant_NauseousSpores</name>
	cMdlt_Stagnant_NauseousSpores = 34,

	/// <summary>
	/// Stagnant - Time between breaks is reduced by –33% for villagers with this effect.
	/// </summary>
	/// <name>cMdlt_Stagnant_NauseousSpores_NEW</name>
	cMdlt_Stagnant_NauseousSpores_NEW = 35,

	/// <summary>
	/// Comfortable - This worker gains +5 to their Resolve. (+5 to Global Resolve)
	/// </summary>
	/// <name>Comfortable Job</name>
	Comfortable_Job = 36,

	/// <summary>
	/// Extreme Noise - Working in a loud environment is really taxing. (‑5 to Global Resolve)
	/// </summary>
	/// <name>Extreme Noise</name>
	Extreme_Noise = 37,

	/// <summary>
	/// Farmer's Diet - Farmers have a +100% chance of producing double yields when under the effect of "[food processed] biscuits" biscuits.
	/// </summary>
	/// <name>FarmersDiet</name>
	FarmersDiet = 39,

	/// <summary>
	/// Lightweight Axes - Woodcutters move +20% faster.
	/// </summary>
	/// <name>Faster Woocutters</name>
	Faster_Woocutters = 40,

	/// <summary>
	/// Forced Improvisation - Working in a loud environment is really taxing. (‑5 to Global Resolve)
	/// </summary>
	/// <name>Forced Improvisation</name>
	Forced_Improvisation = 41,

	/// <summary>
	/// Furniture - Adds an additional +1 to Resolve for villagers with a home. (+1 to Global Resolve)
	/// </summary>
	/// <name>Furniture</name>
	Furniture = 42,

	/// <summary>
	/// Overtime - Results matter more than your villagers’ health. Increases global production speed by 120, but villagers have a +1% chance of dying every 120 seconds.
	/// </summary>
	/// <name>Global Chance of Death</name>
	Global_Chance_Of_Death = 43,

	/// <summary>
	/// Travel Rations - With provisions, haulers don't have to return to the hearth as often. Increases the time between breaks for haulers by +50% and their carrying capacity by 5
	/// </summary>
	/// <name>Hauler Break Interval - villager perk</name>
	Hauler_Break_Interval_Villager_Perk = 44,

	/// <summary>
	/// HaulerUpgrade_Speed_Name - Specialized equipment enhanced with rainpunk technology. Haulers move +25% faster.
	/// </summary>
	/// <name>Hauler Speed - villager perk</name>
	Hauler_Speed_Villager_Perk = 45,

	/// <summary>
	/// Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	/// </summary>
	/// <name>Houses +1 - break time - child</name>
	Houses_Plus1_Break_Time_Child = 46,

	/// <summary>
	/// Ballmer Peak - Villagers with the leisure need fulfilled have a +25% chance of doubling their yields.
	/// </summary>
	/// <name>Leisure Worker</name>
	Leisure_Worker = 47,

	/// <summary>
	/// Flame Amulets - Woodcutters have a +20% chance of producing twice the normal yield.
	/// </summary>
	/// <name>LessHostilityPerWoodcutter - Proficiency</name>
	LessHostilityPerWoodcutter_Proficiency = 48,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods. (‑18 to Global Resolve)
	/// </summary>
	/// <name>MoleResolvePenalty - hard</name>
	MoleResolvePenalty_Hard = 49,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods. (‑22 to Global Resolve)
	/// </summary>
	/// <name>MoleResolvePenalty - impossible</name>
	MoleResolvePenalty_Impossible = 50,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods. (‑16 to Global Resolve)
	/// </summary>
	/// <name>MoleResolvePenalty - normal</name>
	MoleResolvePenalty_Normal = 51,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods. (‑20 to Global Resolve)
	/// </summary>
	/// <name>MoleResolvePenalty - very hard</name>
	MoleResolvePenalty_Very_Hard = 52,

	/// <summary>
	/// Boots - Increases movement speed by +15%.
	/// </summary>
	/// <name>[N] Need Villagers Speed Bonus</name>
	N_Need_Villagers_Speed_Bonus = 53,

	/// <summary>
	/// Full Belly - This worker has a +5% higher chance of producing double yields for each Complex Food need met.
	/// </summary>
	/// <name>Need Complex Food Extra Production</name>
	Need_Complex_Food_Extra_Production = 54,

	/// <summary>
	/// High Motivation - This worker has a +10% higher chance of producing double yields for each Complex Food need met.
	/// </summary>
	/// <name>Need Service Goods Extra Production</name>
	Need_Service_Goods_Extra_Production = 55,

	/// <summary>
	/// Good Sleep - The time interval between breaks is increased by +10%.
	/// </summary>
	/// <name>[PerkCrafter] Break Interval - child - 10</name>
	PerkCrafter_Break_Interval_Child_10 = 56,

	/// <summary>
	/// Good Sleep - The time interval between breaks is increased by +12%.
	/// </summary>
	/// <name>[PerkCrafter] Break Interval - child - 12</name>
	PerkCrafter_Break_Interval_Child_12 = 57,

	/// <summary>
	/// Good Sleep - The time interval between breaks is increased by +4%.
	/// </summary>
	/// <name>[PerkCrafter] Break Interval - child - 4</name>
	PerkCrafter_Break_Interval_Child_4 = 58,

	/// <summary>
	/// Good Sleep - The time interval between breaks is increased by +7%.
	/// </summary>
	/// <name>[PerkCrafter] Break Interval - child - 7</name>
	PerkCrafter_Break_Interval_Child_7 = 59,

	/// <summary>
	/// Poisoned Food - Fishmen are small and cunning enough to sneak into a settlement and poison the food supply. Villagers have a +25% chance of death after eating.
	/// </summary>
	/// <name>Poisoned Food Instant</name>
	Poisoned_Food_Instant = 60,

	/// <summary>
	/// Proficiency - This worker has a +10% chance of doubling their yield.
	/// </summary>
	/// <name>Proficiency</name>
	Proficiency = 61,

	/// <summary>
	/// Proficiency - This worker has a +40% chance of doubling their yield.
	/// </summary>
	/// <name>Proficiency Blightrot</name>
	Proficiency_Blightrot = 62,

	/// <summary>
	/// Low Strain - Work is much easier with Rain Engines on (+5 to Resolve).
	/// </summary>
	/// <name>Rainpunk Comfortable</name>
	Rainpunk_Comfortable = 63,

	/// <summary>
	/// Rotting Wood - Villagers with this effect have a +100% chance of destroying the yield with each production cycle.
	/// </summary>
	/// <name>RottingWoodDestroyYield</name>
	RottingWoodDestroyYield = 64,

	/// <summary>
	/// Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them.  (+5 to Global Resolve)
	/// </summary>
	/// <name>Royal Guard Training - Resolve Reward</name>
	Royal_Guard_Training_Resolve_Reward = 65,

	/// <summary>
	/// Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators. (+10 to Global Resolve)
	/// </summary>
	/// <name>SE Hot Springs (Villager Resolve Effect)</name>
	SE_Hot_Springs_Villager_Resolve_Effect = 66,

	/// <summary>
	/// Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	/// </summary>
	/// <name>SE Longer Break Interval - child</name>
	SE_Longer_Break_Interval_Child = 67,

	/// <summary>
	/// Horrors from Beneath - A strange chant is frightening the villagers. (‑10 to Global Resolve)
	/// </summary>
	/// <name>SE Mine in Storm (Villager Resolve Effect)</name>
	SE_Mine_In_Storm_Villager_Resolve_Effect = 68,

	/// <summary>
	/// Shaky Hands - Discovering the remains of a caravan has caused unrest in the settlement. All villagers have a +30% chance of destroying a production yield.
	/// </summary>
	/// <name>Shaky Hands</name>
	Shaky_Hands = 69,

	/// <summary>
	/// Drying Boards - Time between breaks is increased by +10% for villagers with the need for "[needs] coats" coats fulfilled.
	/// </summary>
	/// <name>Shorter Break NEW</name>
	Shorter_Break_NEW = 70,

	/// <summary>
	/// Reward_Composite_SickTrees_Name - Villagers with this effect have a +40% chance of destroying the yield with each production cycle.
	/// </summary>
	/// <name>SickTreesDestroyYield</name>
	SickTreesDestroyYield = 71,

	/// <summary>
	/// Working Hard and Smart - Has a 10% chance of producing double yields when under the effect of "[needs] scrolls" education.
	/// </summary>
	/// <name>Smart Worker</name>
	Smart_Worker = 72,

	/// <summary>
	/// Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure. (+5 to Global Resolve)
	/// </summary>
	/// <name>Spiced Ale</name>
	Spiced_Ale = 73,

	/// <summary>
	/// Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive. (+2 to Global Resolve)
	/// </summary>
	/// <name>[U] Frog Houses Bonus Resolve</name>
	U_Frog_Houses_Bonus_Resolve = 74,

	/// <summary>
	/// Stove - A small reminder of the Holy Flame. (+1 to Global Resolve)
	/// </summary>
	/// <name>[U] Houses Bonus Resolve</name>
	U_Houses_Bonus_Resolve = 75,

	/// <summary>
	/// Soft Beds - Villagers living in a house with this upgrade move +15% faster.
	/// </summary>
	/// <name>[U] Houses Villagers Speed Bonus</name>
	U_Houses_Villagers_Speed_Bonus = 76,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑12 to Global Resolve)
	/// </summary>
	/// <name>VaultResolvePenalty - hard</name>
	VaultResolvePenalty_Hard = 79,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑16 to Global Resolve)
	/// </summary>
	/// <name>VaultResolvePenalty - impossible</name>
	VaultResolvePenalty_Impossible = 80,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑10 to Global Resolve)
	/// </summary>
	/// <name>VaultResolvePenalty - normal</name>
	VaultResolvePenalty_Normal = 77,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑14 to Global Resolve)
	/// </summary>
	/// <name>VaultResolvePenalty - very hard</name>
	VaultResolvePenalty_Very_Hard = 81,

	/// <summary>
	/// Drying Boards - Time between breaks is increased by 10000% for villagers with the need for "[needs] coats" coats fulfilled.
	/// </summary>
	/// <name>Very Long Breaks</name>
	Very_Long_Breaks = 78,



	/// <summary>
	/// The total number of vanilla VillagerPerkTypes in the game.
	/// </summary>
	[Obsolete("Use VillagerPerkTypesExtensions.Count(). VillagerPerkTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 80
}

/// <summary>
/// Extension methods for the VillagerPerkTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class VillagerPerkTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in VillagerPerkTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded VillagerPerkTypes.
	/// </summary>
	public static VillagerPerkTypes[] All()
	{
		VillagerPerkTypes[] all = new VillagerPerkTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every VillagerPerkTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return VillagerPerkTypes.Acidic_Environment in the enum and log an error.
	/// </summary>
	public static string ToName(this VillagerPerkTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of VillagerPerkTypes: " + type);
		return TypeToInternalName[VillagerPerkTypes.Acidic_Environment];
	}
	
	/// <summary>
	/// Returns a VillagerPerkTypes associated with the given name.
	/// Every VillagerPerkTypes should have a unique name as to distinguish it from others.
	/// If no VillagerPerkTypes is found, it will return VillagerPerkTypes.Unknown and log a warning.
	/// </summary>
	public static VillagerPerkTypes ToVillagerPerkTypes(this string name)
	{
		foreach (KeyValuePair<VillagerPerkTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find VillagerPerkTypes with name: " + name + "\n" + Environment.StackTrace);
		return VillagerPerkTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a VillagerPerkModel associated with the given name.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If no VillagerPerkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel ToVillagerPerkModel(this string name)
	{
		Eremite.Characters.Villagers.VillagerPerkModel model = SO.Settings.villagersPerks.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find VillagerPerkModel for VillagerPerkTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a VillagerPerkModel associated with the given VillagerPerkTypes.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If no VillagerPerkModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel ToVillagerPerkModel(this VillagerPerkTypes types)
	{
		return types.ToName().ToVillagerPerkModel();
	}
	
	/// <summary>
	/// Returns an array of VillagerPerkModel associated with the given VillagerPerkTypes.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If a VillagerPerkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel[] ToVillagerPerkModelArray(this IEnumerable<VillagerPerkTypes> collection)
	{
		int count = collection.Count();
		Eremite.Characters.Villagers.VillagerPerkModel[] array = new Eremite.Characters.Villagers.VillagerPerkModel[count];
		int i = 0;
		foreach (VillagerPerkTypes element in collection)
		{
			array[i++] = element.ToVillagerPerkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of VillagerPerkModel associated with the given VillagerPerkTypes.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If a VillagerPerkModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel[] ToVillagerPerkModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Characters.Villagers.VillagerPerkModel[] array = new Eremite.Characters.Villagers.VillagerPerkModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToVillagerPerkModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of VillagerPerkModel associated with the given VillagerPerkTypes.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If a VillagerPerkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel[] ToVillagerPerkModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Characters.Villagers.VillagerPerkModel>.Get(out List<Eremite.Characters.Villagers.VillagerPerkModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Characters.Villagers.VillagerPerkModel model = element.ToVillagerPerkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of VillagerPerkModel associated with the given VillagerPerkTypes.
	/// VillagerPerkModel contain all the data that will be used in the game.
	/// Every VillagerPerkModel should have a unique name as to distinguish it from others.
	/// If a VillagerPerkModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Characters.Villagers.VillagerPerkModel[] ToVillagerPerkModelArrayNoNulls(this IEnumerable<VillagerPerkTypes> collection)
	{
		using(ListPool<Eremite.Characters.Villagers.VillagerPerkModel>.Get(out List<Eremite.Characters.Villagers.VillagerPerkModel> list))
		{
			foreach (VillagerPerkTypes element in collection)
			{
				Eremite.Characters.Villagers.VillagerPerkModel model = element.ToVillagerPerkModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
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
		{ VillagerPerkTypes.FarmersDiet, "FarmersDiet" },                                                             // Farmer's Diet - Farmers have a +100% chance of producing double yields when under the effect of "[food processed] biscuits" biscuits.
		{ VillagerPerkTypes.Faster_Woocutters, "Faster Woocutters" },                                                 // Lightweight Axes - Woodcutters move +20% faster.
		{ VillagerPerkTypes.Forced_Improvisation, "Forced Improvisation" },                                           // Forced Improvisation - Working in a loud environment is really taxing. (‑5 to Global Resolve)
		{ VillagerPerkTypes.Furniture, "Furniture" },                                                                 // Furniture - Adds an additional +1 to Resolve for villagers with a home. (+1 to Global Resolve)
		{ VillagerPerkTypes.Global_Chance_Of_Death, "Global Chance of Death" },                                       // Overtime - Results matter more than your villagers’ health. Increases global production speed by 120, but villagers have a +1% chance of dying every 120 seconds.
		{ VillagerPerkTypes.Hauler_Break_Interval_Villager_Perk, "Hauler Break Interval - villager perk" },           // Travel Rations - With provisions, haulers don't have to return to the hearth as often. Increases the time between breaks for haulers by +50% and their carrying capacity by 5
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
		{ VillagerPerkTypes.PerkCrafter_Break_Interval_Child_10, "[PerkCrafter] Break Interval - child - 10" },       // Good Sleep - The time interval between breaks is increased by +10%.
		{ VillagerPerkTypes.PerkCrafter_Break_Interval_Child_12, "[PerkCrafter] Break Interval - child - 12" },       // Good Sleep - The time interval between breaks is increased by +12%.
		{ VillagerPerkTypes.PerkCrafter_Break_Interval_Child_4, "[PerkCrafter] Break Interval - child - 4" },         // Good Sleep - The time interval between breaks is increased by +4%.
		{ VillagerPerkTypes.PerkCrafter_Break_Interval_Child_7, "[PerkCrafter] Break Interval - child - 7" },         // Good Sleep - The time interval between breaks is increased by +7%.
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
		{ VillagerPerkTypes.Shorter_Break_NEW, "Shorter Break NEW" },                                                 // Drying Boards - Time between breaks is increased by +10% for villagers with the need for "[needs] coats" coats fulfilled.
		{ VillagerPerkTypes.SickTreesDestroyYield, "SickTreesDestroyYield" },                                         // Reward_Composite_SickTrees_Name - Villagers with this effect have a +40% chance of destroying the yield with each production cycle.
		{ VillagerPerkTypes.Smart_Worker, "Smart Worker" },                                                           // Working Hard and Smart - Has a 10% chance of producing double yields when under the effect of "[needs] scrolls" education.
		{ VillagerPerkTypes.Spiced_Ale, "Spiced Ale" },                                                               // Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure. (+5 to Global Resolve)
		{ VillagerPerkTypes.U_Frog_Houses_Bonus_Resolve, "[U] Frog Houses Bonus Resolve" },                           // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive. (+2 to Global Resolve)
		{ VillagerPerkTypes.U_Houses_Bonus_Resolve, "[U] Houses Bonus Resolve" },                                     // Stove - A small reminder of the Holy Flame. (+1 to Global Resolve)
		{ VillagerPerkTypes.U_Houses_Villagers_Speed_Bonus, "[U] Houses Villagers Speed Bonus" },                     // Soft Beds - Villagers living in a house with this upgrade move +15% faster.
		{ VillagerPerkTypes.VaultResolvePenalty_Hard, "VaultResolvePenalty - hard" },                                 // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑12 to Global Resolve)
		{ VillagerPerkTypes.VaultResolvePenalty_Impossible, "VaultResolvePenalty - impossible" },                     // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑16 to Global Resolve)
		{ VillagerPerkTypes.VaultResolvePenalty_Normal, "VaultResolvePenalty - normal" },                             // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑10 to Global Resolve)
		{ VillagerPerkTypes.VaultResolvePenalty_Very_Hard, "VaultResolvePenalty - very hard" },                       // Ominous Whispers - Strange voices can be heard coming from the sealed vault. (‑14 to Global Resolve)
		{ VillagerPerkTypes.Very_Long_Breaks, "Very Long Breaks" },                                                   // Drying Boards - Time between breaks is increased by 10000% for villagers with the need for "[needs] coats" coats fulfilled.

	};
}
