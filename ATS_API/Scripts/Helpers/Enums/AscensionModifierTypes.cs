using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.7.3R
/// </summary>
public enum AscensionModifierTypes
{
	/// <summary>
	/// Placeholder for an unknown AscensionModifierTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no AscensionModifierTypes. Typically, seen if nothing is defined or failed to parse a string to a AscensionModifierTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// The Queen's People - For the Queen, nothing is more important than her people. Losing villagers will add 0.5 more points to her Impatience.
	/// </summary>
	/// <name>[Mod] Additional Impatience for Death</name>
	Additional_Impatience_For_Death = 1,

	/// <summary>
	/// Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
	/// </summary>
	/// <name>[Diff] Altar</name>
	Ascension_All_Altar = 2,

	/// <summary>
	/// Sinister Blight - The Blightrot's impact is stronger. Cyst generation rate is increased by +100%, the Hearth corrupts +50% quicker than normal, and all effects that spawn Blightrot now add twice as many Cysts.
	/// </summary>
	/// <name>[Mod] Blightrot Medium</name>
	Blightrot_Medium_Difficulty = 3,

	/// <summary>
	/// Blight Swarm - Large swarms of Blightrot migrate across the realm. Every third Clearance season, 5 Blightrot Cysts will appear in the settlement.
	/// </summary>
	/// <name>[Mod] Cysts Spawn</name>
	Blightrot_Spawn = 4,

	/// <summary>
	/// Land Tax - Taking advantage of the riches of this new land will cost you. You must pay 2 "[valuable] amber" Amber every time you discover a Small Glade, and 6 "[valuable] amber" Amber every time you discover a Dangerous ("dangerous") or Forbidden Glade ("forbidden") . Otherwise, 2 villagers will be recalled to the Citadel.
	/// </summary>
	/// <name>[Mod] Exploration Tax - Composite</name>
	Exploration_Tax = 5,

	/// <summary>
	/// Hearth Defect - The Ancient Hearth seems to have a defect. No matter how hard the firekeeper tries, sacrificed resources are burning 35% quicker.
	/// </summary>
	/// <name>[Mod] Faster Fuel Sacrafice</name>
	Faster_Fuel_Sacrifice = 6,

	/// <summary>
	/// Higher Standards - Villagers are less understanding than they used to be. They’re probably getting a bit spoiled by now. Villagers are 100% faster to leave if they have low Resolve.
	/// </summary>
	/// <name>[Mod] Faster Leaving</name>
	FasterLeaving = 7,

	/// <summary>
	/// Less is More - The greedy Royal Archivist sold most of the blueprints to traders and fled the Citadel. You have 2 fewer blueprint choices.
	/// </summary>
	/// <name>[Mod] Fewer Blueprints Options</name>
	Fewer_Blueprints_Options = 8,

	/// <summary>
	/// Restrictions - The Royal Envoy comes to you with bad news. The Queen has restricted your cornerstone choices by 2.
	/// </summary>
	/// <name>[Mod] Fewer Cornerstones Options</name>
	Fewer_Cornerstones_Options = 9,

	/// <summary>
	/// Budget Cuts - The Queen has visited the Obsidian Archives in person, and was dissatisfied with the amount of funding spent on expeditions. You have one fewer initial blueprint.
	/// </summary>
	/// <name>[Mod] Fewer Initial Blueprints</name>
	Fewer_Initial_Blueprints = 10,

	/// <summary>
	/// Malcontents - You took a very peculiar group of settlers with you. They seem perpetually dissatisfied. The Resolve threshold at which each species starts producing Reputation increases by 1 more point for every Reputation Point they generate.
	/// </summary>
	/// <name>[Mod] Global Reputation Treshold Increase</name>
	Global_Reputation_Treshold_Increase = 11,

	/// <summary>
	/// Hard Times - The Queen has decided to entrust you with the most difficult orders, as you are one of her most experienced viceroys.
	/// </summary>
	/// <name>[Mod] Hard Orders Only</name>
	Hard_Orders_Only = 12,

	/// <summary>
	/// Expensive Lottery - The Archivist assigned to your settlement is fiercely loyal to the Royal Court, so bribing him will be more expensive. Blueprint rerolls cost 10 Amber more.
	/// </summary>
	/// <name>[Mod] Higher Blueprints Reroll Cost</name>
	Higher_Blueprints_Reroll_Cost = 13,

	/// <summary>
	/// Consumerism - Villagers have forgotten what a modest life looks like. They want to enjoy life to the fullest. Villagers have a 50% chance to consume double the amount of luxury goods.
	/// </summary>
	/// <name>[Mod] Higher Needs Consumption Rate</name>
	Higher_Needs_Consumption_Rate = 14,

	/// <summary>
	/// Guild of Traders, or Thieves? - Traders gossip about you doing pretty well lately. All your goods are worth 50% less to traders.
	/// </summary>
	/// <name>[Mod] Higher Traders Prices</name>
	Higher_Traders_Prices = 15,

	/// <summary>
	/// Famine Outbreaks - Famine outbreaks in your previous settlements have made the villagers particularly sensitive to food shortages. Every time villagers have nothing to eat during a break, they will gain two stacks of the Hunger effect instead of one.
	/// </summary>
	/// <name>[Diff] Hunger Multiplier</name>
	Hunger_Multiplier_Effects = 16,

	/// <summary>
	/// Procrastination - Villagers are reluctant to venture into Dangerous Glades. Scouts work 33% slower on Glade Events.
	/// </summary>
	/// <name>[Mod] Longer Relics Working Time</name>
	Longer_Relics_Working_Time = 17,

	/// <summary>
	/// Crumbling Seal - One of the seals is loosening its grip, leaking darkness upon this land. Storm season lasts 100% longer.
	/// </summary>
	/// <name>[Mod] Longer Storm</name>
	Longer_Storm = 18,

	/// <summary>
	/// Settler's Luck - Villagers have a 35% chance of not consuming food during a break.
	/// </summary>
	/// <name>[Diff] Lower Food Consumption</name>
	Low_Difficulty_Chance_For_No_Consumption = 19,

	/// <summary>
	/// Higher Expectations - The Queen expects a lot from a viceroy of your rank. Impatience falls by 0.5 points less for every Reputation Point you gain.
	/// </summary>
	/// <name>[Mod] Lower Impatience Reduction</name>
	Lower_Impatience_Reduction = 20,

	/// <summary>
	/// Parasites - One of the villagers was sick, and infected the rest of the settlement with a parasite. All villagers have a 50% chance of eating twice as much during their break.
	/// </summary>
	/// <name>[Mod] Parasites</name>
	Parasites = 21,

	/// <summary>
	/// Blightrot & Corruption - Pollution from industrial production feeds the growth of Blightrot Cysts. Deploy Blight Fighters to prevent your Hearths from becoming corrupted during the storm.
	/// </summary>
	/// <name>[Diff] Blightrot</name>
	Pre_Ascension_All_Blight = 22,

	/// <summary></summary>
	/// <name>[Diff] No Blightrot</name>
	Pre_Ascension_Normal_And_Hard_No_Blight = 23,

	/// <summary>
	/// Prestigious Expedition - Only the best viceroys can embark on a Prestigious Expedition. You'll need to earn 4 additional Reputation Points to win. Reputation rewards are distributed differently, and Orders are harder.
	/// </summary>
	/// <name>[Mod] Reputation Changes</name>
	Reputation_Changes = 24,

	/// <summary>
	/// Prestigious Expedition - Only the best viceroys can embark on a Prestigious Expedition. You'll need to earn 4 additional Reputation Points to win. Reputation rewards are distributed differently, and Orders are harder.
	/// </summary>
	/// <name>[Mod] Reputation Changes</name>
	Reputation_Changes_Hard = 25,

	/// <summary>
	/// Wet Soil - It's particularly hard to build anything in this region. Buildings require 50% more materials.
	/// </summary>
	/// <name>[Mod] Wet Soil</name>
	Wet_Soil = 26,



	/// <summary>
	/// The total number of vanilla AscensionModifierTypes in the game.
	/// </summary>
	MAX = 26
}

/// <summary>
/// Extension methods for the AscensionModifierTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class AscensionModifierTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded AscensionModifierTypes.
	/// </summary>
	public static AscensionModifierTypes[] All()
	{
		AscensionModifierTypes[] all = new AscensionModifierTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every AscensionModifierTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return AscensionModifierTypes.Additional_Impatience_For_Death in the enum and log an error.
	/// </summary>
	public static string ToName(this AscensionModifierTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of AscensionModifierTypes: " + type);
		return TypeToInternalName[AscensionModifierTypes.Additional_Impatience_For_Death];
	}
	
	/// <summary>
	/// Returns a AscensionModifierTypes associated with the given name.
	/// Every AscensionModifierTypes should have a unique name as to distinguish it from others.
	/// If no AscensionModifierTypes is found, it will return AscensionModifierTypes.Unknown and log a warning.
	/// </summary>
	public static AscensionModifierTypes ToAscensionModifierTypes(this string name)
	{
		foreach (KeyValuePair<AscensionModifierTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find AscensionModifierTypes with name: " + name + "\n" + Environment.StackTrace);
		return AscensionModifierTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a AscensionModifierModel associated with the given name.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If no AscensionModifierModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel ToAscensionModifierModel(this string name)
	{
		Eremite.Model.AscensionModifierModel model = SO.Settings.ascensionModifiers.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find AscensionModifierModel for AscensionModifierTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a AscensionModifierModel associated with the given AscensionModifierTypes.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If no AscensionModifierModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel ToAscensionModifierModel(this AscensionModifierTypes types)
	{
		return types.ToName().ToAscensionModifierModel();
	}
	
	/// <summary>
	/// Returns an array of AscensionModifierModel associated with the given AscensionModifierTypes.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If a AscensionModifierModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel[] ToAscensionModifierModelArray(this IEnumerable<AscensionModifierTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.AscensionModifierModel[] array = new Eremite.Model.AscensionModifierModel[count];
		int i = 0;
		foreach (AscensionModifierTypes element in collection)
		{
			array[i++] = element.ToAscensionModifierModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of AscensionModifierModel associated with the given AscensionModifierTypes.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If a AscensionModifierModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel[] ToAscensionModifierModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.AscensionModifierModel[] array = new Eremite.Model.AscensionModifierModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToAscensionModifierModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of AscensionModifierModel associated with the given AscensionModifierTypes.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If a AscensionModifierModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel[] ToAscensionModifierModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.AscensionModifierModel>.Get(out List<Eremite.Model.AscensionModifierModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.AscensionModifierModel model = element.ToAscensionModifierModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of AscensionModifierModel associated with the given AscensionModifierTypes.
	/// AscensionModifierModel contain all the data that will be used in the game.
	/// Every AscensionModifierModel should have a unique name as to distinguish it from others.
	/// If a AscensionModifierModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.AscensionModifierModel[] ToAscensionModifierModelArrayNoNulls(this IEnumerable<AscensionModifierTypes> collection)
	{
		using(ListPool<Eremite.Model.AscensionModifierModel>.Get(out List<Eremite.Model.AscensionModifierModel> list))
		{
			foreach (AscensionModifierTypes element in collection)
			{
				Eremite.Model.AscensionModifierModel model = element.ToAscensionModifierModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<AscensionModifierTypes, string> TypeToInternalName = new()
	{
		{ AscensionModifierTypes.Additional_Impatience_For_Death, "Additional Impatience for Death" },                     // The Queen's People - For the Queen, nothing is more important than her people. Losing villagers will add 0.5 more points to her Impatience.
		{ AscensionModifierTypes.Ascension_All_Altar, "Ascension All - Altar" },                                           // Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
		{ AscensionModifierTypes.Blightrot_Medium_Difficulty, "Blightrot medium difficulty" },                             // Sinister Blight - The Blightrot's impact is stronger. Cyst generation rate is increased by +100%, the Hearth corrupts +50% quicker than normal, and all effects that spawn Blightrot now add twice as many Cysts.
		{ AscensionModifierTypes.Blightrot_Spawn, "Blightrot Spawn" },                                                     // Blight Swarm - Large swarms of Blightrot migrate across the realm. Every third Clearance season, 5 Blightrot Cysts will appear in the settlement.
		{ AscensionModifierTypes.Exploration_Tax, "Exploration Tax" },                                                     // Land Tax - Taking advantage of the riches of this new land will cost you. You must pay 2 "[valuable] amber" Amber every time you discover a Small Glade, and 6 "[valuable] amber" Amber every time you discover a Dangerous ("dangerous") or Forbidden Glade ("forbidden") . Otherwise, 2 villagers will be recalled to the Citadel.
		{ AscensionModifierTypes.Faster_Fuel_Sacrifice, "Faster Fuel Sacrifice" },                                         // Hearth Defect - The Ancient Hearth seems to have a defect. No matter how hard the firekeeper tries, sacrificed resources are burning 35% quicker.
		{ AscensionModifierTypes.FasterLeaving, "FasterLeaving" },                                                         // Higher Standards - Villagers are less understanding than they used to be. They’re probably getting a bit spoiled by now. Villagers are 100% faster to leave if they have low Resolve.
		{ AscensionModifierTypes.Fewer_Blueprints_Options, "Fewer Blueprints Options" },                                   // Less is More - The greedy Royal Archivist sold most of the blueprints to traders and fled the Citadel. You have 2 fewer blueprint choices.
		{ AscensionModifierTypes.Fewer_Cornerstones_Options, "Fewer Cornerstones Options" },                               // Restrictions - The Royal Envoy comes to you with bad news. The Queen has restricted your cornerstone choices by 2.
		{ AscensionModifierTypes.Fewer_Initial_Blueprints, "Fewer Initial Blueprints" },                                   // Budget Cuts - The Queen has visited the Obsidian Archives in person, and was dissatisfied with the amount of funding spent on expeditions. You have one fewer initial blueprint.
		{ AscensionModifierTypes.Global_Reputation_Treshold_Increase, "Global Reputation Treshold Increase" },             // Malcontents - You took a very peculiar group of settlers with you. They seem perpetually dissatisfied. The Resolve threshold at which each species starts producing Reputation increases by 1 more point for every Reputation Point they generate.
		{ AscensionModifierTypes.Hard_Orders_Only, "Hard Orders Only" },                                                   // Hard Times - The Queen has decided to entrust you with the most difficult orders, as you are one of her most experienced viceroys.
		{ AscensionModifierTypes.Higher_Blueprints_Reroll_Cost, "Higher Blueprints Reroll Cost" },                         // Expensive Lottery - The Archivist assigned to your settlement is fiercely loyal to the Royal Court, so bribing him will be more expensive. Blueprint rerolls cost 10 Amber more.
		{ AscensionModifierTypes.Higher_Needs_Consumption_Rate, "Higher Needs Consumption Rate" },                         // Consumerism - Villagers have forgotten what a modest life looks like. They want to enjoy life to the fullest. Villagers have a 50% chance to consume double the amount of luxury goods.
		{ AscensionModifierTypes.Higher_Traders_Prices, "Higher Traders Prices" },                                         // Guild of Traders, or Thieves? - Traders gossip about you doing pretty well lately. All your goods are worth 50% less to traders.
		{ AscensionModifierTypes.Hunger_Multiplier_Effects, "Hunger Multiplier Effects" },                                 // Famine Outbreaks - Famine outbreaks in your previous settlements have made the villagers particularly sensitive to food shortages. Every time villagers have nothing to eat during a break, they will gain two stacks of the Hunger effect instead of one.
		{ AscensionModifierTypes.Longer_Relics_Working_Time, "Longer Relics Working Time" },                               // Procrastination - Villagers are reluctant to venture into Dangerous Glades. Scouts work 33% slower on Glade Events.
		{ AscensionModifierTypes.Longer_Storm, "Longer Storm" },                                                           // Crumbling Seal - One of the seals is loosening its grip, leaking darkness upon this land. Storm season lasts 100% longer.
		{ AscensionModifierTypes.Low_Difficulty_Chance_For_No_Consumption, "Low Difficulty Chance For No Consumption" },   // Settler's Luck - Villagers have a 35% chance of not consuming food during a break.
		{ AscensionModifierTypes.Lower_Impatience_Reduction, "Lower Impatience Reduction" },                               // Higher Expectations - The Queen expects a lot from a viceroy of your rank. Impatience falls by 0.5 points less for every Reputation Point you gain.
		{ AscensionModifierTypes.Parasites, "Parasites" },                                                                 // Parasites - One of the villagers was sick, and infected the rest of the settlement with a parasite. All villagers have a 50% chance of eating twice as much during their break.
		{ AscensionModifierTypes.Pre_Ascension_All_Blight, "Pre Ascension All - Blight" },                                 // Blightrot & Corruption - Pollution from industrial production feeds the growth of Blightrot Cysts. Deploy Blight Fighters to prevent your Hearths from becoming corrupted during the storm.
		{ AscensionModifierTypes.Pre_Ascension_Normal_And_Hard_No_Blight, "Pre Ascension - Normal and Hard - No Blight" }, 
		{ AscensionModifierTypes.Reputation_Changes, "Reputation Changes" },                                               // Prestigious Expedition - Only the best viceroys can embark on a Prestigious Expedition. You'll need to earn 4 additional Reputation Points to win. Reputation rewards are distributed differently, and Orders are harder.
		{ AscensionModifierTypes.Reputation_Changes_Hard, "Reputation Changes - Hard" },                                   // Prestigious Expedition - Only the best viceroys can embark on a Prestigious Expedition. You'll need to earn 4 additional Reputation Points to win. Reputation rewards are distributed differently, and Orders are harder.
		{ AscensionModifierTypes.Wet_Soil, "Wet Soil" },                                                                   // Wet Soil - It's particularly hard to build anything in this region. Buildings require 50% more materials.

	};
}
