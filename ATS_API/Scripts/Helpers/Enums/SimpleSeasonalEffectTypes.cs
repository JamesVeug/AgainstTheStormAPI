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
public enum SimpleSeasonalEffectTypes
{
    /// <summary>
    /// Placeholder for an unknown SimpleSeasonalEffectTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no SimpleSeasonalEffectTypes. Typically, seen if nothing is defined or failed to parse a string to a SimpleSeasonalEffectTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Piercing Winds - Extremely strong winds make it difficult to sustain the Holy Flame. Fuel consumption in Hearths is increased by 200%.
	/// </summary>
	/// <name>_TO DELETE [SSE] FuelRate</name>
	_TO_DELETE_SSE_FuelRate = 1,

	/// <summary>
	/// Soft Stems - The grain stalks have grown soft because of the air’s humidity. During drizzle season, workers in the Harvesters' Camp can gather "[food raw] grain" grain (grade2) from grain nodes.
	/// </summary>
	/// <name>_TO DELETE [SSE] Grain in Harvester</name>
	_TO_DELETE_SSE_Grain_In_Harvester = 2,

	/// <summary>
	/// Shifting Paths - The road to the village is long and winding, so some newcomers need a bit of extra motivation. Pay 2 "[packs] pack of crops" Pack of Crops with each storm (multiplied by the number of years played). If you don't, the next newcomer group will arrive 50% slower.
	/// </summary>
	/// <name>_TO DELETE [SSE] Late Newcomers</name>
	_TO_DELETE_SSE_Late_Newcomers = 3,

	/// <summary>
	/// Rotten Vapors - Machinery has to be cleaned with specially prepared Drizzle Water. Otherwise, Blightrot will spread. Once this effect activates, you have to pay 5 "[water] drizzle water" Drizzle Water (multiplied by the number of years). If you don't, 3 Blightrot Cysts will spawn in your settlement.
	/// </summary>
	/// <name>_TO DELETE [SSE] Overheating</name>
	_TO_DELETE_SSE_Overheating = 4,

	/// <summary>
	/// Royal Funding - The Queen's generosity knows no limits. Gain 2 "[valuable] amber" Amber every time you sell goods worth 10 Amber.
	/// </summary>
	/// <name>[SSE] Amber for Trade</name>
	SSE_Amber_For_Trade = 5,

	/// <summary>
	/// Berry New Year - +3 to "[food raw] berries" Berries production. Gain an additional "[food raw] berries" Berries every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Berries +3</name>
	SSE_Berries_Plus3 = 6,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
	/// </summary>
	/// <name>[SSE] [BIOME] Storm Penalty</name>
	SSE_BIOME_Storm_Penalty = 7,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
	/// </summary>
	/// <name>[SSE] [BIOME] Tut 1 Storm Penalty</name>
	SSE_BIOME_Tut_1_Storm_Penalty = 8,

	/// <summary>
	/// Natural Filtration - Using Rain Engines causes a lot less Blightrot contamination due to the natural filtration processes of the surrounding vegetation. Blightrot Cysts grow 50% slower when using Rain Engines.
	/// </summary>
	/// <name>[SSE] Blightrot Footprint -50</name>
	SSE_Blightrot_Footprint_Minus50 = 9,

	/// <summary>
	/// Acid Rain - The rain dissolves some of the resources transported to your Warehouse. Recipes producing building materials yield 50% fewer goods.
	/// </summary>
	/// <name>[SSE] Building Materials Prod Penalty</name>
	SSE_Building_Materials_Prod_Penalty = 10,

	/// <summary>
	/// Golden Dust - Some raindrops seem to have a golden hue. Gain 5 "[water] clearance water" Clearance Water for every 10 "[water] drizzle water" Drizzle Water gathered.
	/// </summary>
	/// <name>[SSE] Clearance for Drizzle</name>
	SSE_Clearance_For_Drizzle = 11,

	/// <summary>
	/// Unyielding Corruption - The spreading corruption strikes fear into the hearts of your villagers. No amount of assurance or flattery can change that. Favoring is unavailable while the Hearth is being corrupted.
	/// </summary>
	/// <name>[SSE] Corruption Favoring Block</name>
	SSE_Corruption_Favoring_Block = 12,

	/// <summary>
	/// Creeping Shadows - Discovering a glade during the storm will decrease Global Resolve by -10 for 3 minutes.
	/// </summary>
	/// <name>[SSE] Creeping Shadows</name>
	SSE_Creeping_Shadows = 13,

	/// <summary>
	/// Cricket Mating Grounds - The clearings are abuzz with the sound of crickets. Gain 30 "[food raw] insects" Insects for each discovered glade.
	/// </summary>
	/// <name>[SSE] Cricket Mating Grounds</name>
	SSE_Cricket_Mating_Grounds = 14,

	/// <summary>
	/// Spreading Contamination - Blightrot contaminates everything you send to the Citadel. During the storm, the Queen's Impatience grows 5% faster for every Blightrot Cyst in your settlement.
	/// </summary>
	/// <name>[SSE] Cysts generate Impatience in Storm</name>
	SSE_Cysts_Generate_Impatience_In_Storm = 15,

	/// <summary>
	/// Greater Threat - During the storm, receive -2 to Global Resolve for every Dangerous ("dangerous") and Forbidden Glade ("forbidden") discovered since the beginning of the settlement. (the penalty is added retroactively)
	/// </summary>
	/// <name>[SSE] Dang Glades reduces resolve in Storm</name>
	SSE_Dang_Glades_Reduces_Resolve_In_Storm = 16,

	/// <summary>
	/// Blightrot Infection - Villagers report feeling sick, especially during the storm. When a villager leaves or dies, 2 Blightrot Cysts will appear in the settlement. 
	/// </summary>
	/// <name>[SSE] Death Blightrot</name>
	SSE_Death_Blightrot = 17,

	/// <summary>
	/// Unnatural Erosion - The wind and rain in this region seem more destructive than usual. Pay 5 "[crafting] oil" Oil with each storm (multiplied by the number of years played). If you don't, 2 random gathering nodes will be destroyed.
	/// </summary>
	/// <name>[SSE] Destroy Nodes</name>
	SSE_Destroy_Nodes = 18,

	/// <summary>
	/// Devastating Storms - The rampaging storm stifles the spirit of all living creatures. (‑20 to Global Resolve)
	/// </summary>
	/// <name>[SSE] Devastating Storms</name>
	SSE_Devastating_Storms = 19,

	/// <summary>
	/// Drizzle Anomaly - The rain seems to fall... slower. Gain 15 "[water] drizzle water" Drizzle Water per minute during the drizzle.
	/// </summary>
	/// <name>[SSE] Drizzle Water per minute</name>
	SSE_Drizzle_Water_Per_Minute = 20,

	/// <summary>
	/// Heavy Drops - +3 to "[water] drizzle water" Drizzle Water production. Gain an additional "[water] drizzle water" Drizzle Water every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Drizzle Water +3</name>
	SSE_Drizzle_Water_Plus3 = 21,

	/// <summary>
	/// Salty Breeze - The salty air makes it easier to preserve food. Food production speed is increased by 80% during drizzle season.
	/// </summary>
	/// <name>[SSE] Fast Food</name>
	SSE_Fast_Food = 22,

	/// <summary>
	/// Soil Reclamation - The soil becomes saturated with the rain's essence during drizzle season. Gathering nodes depleted during the drizzle spawn fertile soil.
	/// </summary>
	/// <name>[SSE] Fertile Nodes</name>
	SSE_Fertile_Nodes = 23,

	/// <summary>
	/// Fish Flood - +3 to "[food raw] fish" Fish production. Gain an additional "[food raw] fish" Fish every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Fish +3</name>
	SSE_Fish_Plus3 = 24,

	/// <summary>
	/// Insatiable Hunger - Working in this environment requires a lot of energy. Villagers have a higher chance of consuming twice the amount of food on each break (10% for each Hostility level).
	/// </summary>
	/// <name>[SSE] Food Consumption</name>
	SSE_Food_Consumption = 25,

	/// <summary>
	/// Rot from the Sky - The rain smells like Blightrot... Global food production is slowed by 15% for each Hostility level.
	/// </summary>
	/// <name>[SSE] Food Production Speed -15</name>
	SSE_Food_Production_Speed_Minus15 = 26,

	/// <summary>
	/// Humid Climate - The humidity in this region is unbearable. Fuel consumption in Hearths is increased by 20% for each Hostility level.
	/// </summary>
	/// <name>[SSE] FuelRateHostility</name>
	SSE_FuelRateHostility = 27,

	/// <summary>
	/// Quaking Bog - The ground is moving and swaying from all the rainwater it’s absorbed. Gathering speed is decreased by 50%.
	/// </summary>
	/// <name>[SSE] Gatherer Production Speed -50</name>
	SSE_Gatherer_Production_Speed_Minus50 = 28,

	/// <summary>
	/// Fruitful Season - The forest's fruits are so ripe, they almost fall into the basket on their own. Gathering speed is increased by 50%.
	/// </summary>
	/// <name>[SSE] Gatherer Production Speed +50</name>
	SSE_Gatherer_Production_Speed_Plus50 = 29,

	/// <summary>
	/// Forgiving Crown - Gain one free cornerstone reroll for every Reputation Point gained during drizzle season.
	/// </summary>
	/// <name>[SSE] Gift for Reputation</name>
	SSE_Gift_For_Reputation = 30,

	/// <summary>
	/// Gift from the Woods - These seem to be the ideal conditions in which to create Amber. Gain 5 "[valuable] amber" Amber every drizzle season, plus an additional 5 "[valuable] amber" Amber for each Hostility level reached.
	/// </summary>
	/// <name>[SSE] Gift from the Woods</name>
	SSE_Gift_From_The_Woods = 31,

	/// <summary>
	/// Gentle Dawn - New year, new challenges. You gain a +10% bonus to planting speed during Drizzle season for every small glade you discover (as well as your starting glade). This effect is retroactive.
	/// </summary>
	/// <name>[SSE] Glades Resolve in Drizzle</name>
	SSE_Glades_Resolve_In_Drizzle = 32,

	/// <summary>
	/// Forest Offerings - It seems some inhabitants of the forest are grateful for your efforts. During drizzle season, every Dangerous or Forbidden Glade Event you complete will give you 40 random raw food.
	/// </summary>
	/// <name>[SSE] Goods for Solved Relics</name>
	SSE_Goods_For_Solved_Relics = 33,

	/// <summary>
	/// Grim Fate - The forest will claim a villager's life during each storm (multiplied by the number of years that have passed).
	/// </summary>
	/// <name>[SSE] Grim Fate</name>
	SSE_Grim_Fate = 34,

	/// <summary>
	/// Hunger Storm - Missing even a single meal in this harsh climate can be deadly. If villagers don't have anything to eat during a break, they will gain two stacks of the Hunger effect.
	/// </summary>
	/// <name>[SSE] Hunger Storm</name>
	SSE_Hunger_Storm = 35,

	/// <summary>
	/// Shedding Season - +3 to "[mat raw] leather" Leather production. Gain an additional "[mat raw] leather" Leather every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Leather +3</name>
	SSE_Leather_Plus3 = 36,

	/// <summary>
	/// Devastation - The storm in this region is extremely violent. Once this effect is activated, you'll have to pay 1 "[packs] pack of building materials" Pack of Building Materials (multiplied by the number of years). If you don't, 3 buildings in your settlement will become ruins.
	/// </summary>
	/// <name>[SSE] Lightning</name>
	SSE_Lightning = 37,

	/// <summary>
	/// Rotten Rain - The rain carries a strange, rotten pollen with it. A Blood Flower will spawn somewhere in the settlement every 90 seconds.
	/// </summary>
	/// <name>[SSE] Living Farmfield</name>
	SSE_Living_Farmfield = 38,

	/// <summary>
	/// Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	/// </summary>
	/// <name>[SSE] Longer Break Interval</name>
	SSE_Longer_Break_Interval = 39,

	/// <summary>
	/// Muddy Ground - Villagers' speed off-road is decreased by 30%.
	/// </summary>
	/// <name>[SSE] M0_60 Off Roads [Muddy Ground]</name>
	SSE_M0_60_Off_Roads_Muddy_Ground = 40,

	/// <summary>
	/// Marrow Growth - Small pockets of bone marrow form in the ground and on trees. Gain 5 "[crafting] sea marrow" Sea Marrow for every 5 "[crafting] coal" Coal produced during drizzle season.
	/// </summary>
	/// <name>[SSE] Marrow Mine</name>
	SSE_Marrow_Mine = 41,

	/// <summary>
	/// Mating Season - +3 to "[food raw] meat" Meat production. Gain an additional "[food raw] meat" Meat every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Meat +3</name>
	SSE_Meat_Plus3 = 42,

	/// <summary>
	/// Corrosive Rainfall - Acid rain is slowly eating away at all metal objects. Producing Copper Bars, Crystalized Dew, and all goods that use metal ingots yields 50% fewer goods.
	/// </summary>
	/// <name>[SSE] Metal Prod Penalty</name>
	SSE_Metal_Prod_Penalty = 43,

	/// <summary>
	/// Horrors from Beneath - Strange voices call out from the depths. Villagers working in Mines get -10 to Resolve during the storm.
	/// </summary>
	/// <name>[SSE] Mine in Storm</name>
	SSE_Mine_In_Storm = 44,

	/// <summary>
	/// Scavenging Season - The drizzle in this region is very mild, making it the perfect season for looting. Increases the chance of doubling loot from events solved during the drizzle by 25% (this doesn't apply to perks and blueprints).
	/// </summary>
	/// <name>[SSE] More event goods</name>
	SSE_More_Event_Goods = 45,

	/// <summary>
	/// Vanishing Water - Infused rainwater slowly evaporates. You lose 1 unit of a random type of water for every 2 units of water used in Rain Engines. 
	/// </summary>
	/// <name>[SSE] More Water Consumption</name>
	SSE_More_Water_Consumption = 46,

	/// <summary>
	/// Mushrooms After Rain - +3 to "[food raw] mushrooms" Mushrooms production. Gain an additional "[food raw] mushrooms" Mushrooms every yield (from gathering, farming, fishing, or production).
	/// </summary>
	/// <name>[SSE] Mushroom +3</name>
	SSE_Mushroom_Plus3 = 47,

	/// <summary>
	/// No contact - Harsh weather conditions make it impossible to reach the Citadel. Gaining Reputation doesn't lower Impatience.
	/// </summary>
	/// <name>[SSE] No Impatience Reduction</name>
	SSE_No_Impatience_Reduction = 48,

	/// <summary>
	/// Untapped Wealth - Gatherers bring back twice the amount of secondary resources when collecting from gathering nodes.
	/// </summary>
	/// <name>[SSE] Nodes Bonuses</name>
	SSE_Nodes_Bonuses = 49,

	/// <summary>
	/// Regrowth - Plants seem to grow exceptionally quickly after the storm. All buildings that use fertile soil produce +50% more goods during the drizzle, and all crops planted during the drizzle will yield +50% more when collected during clearance season.
	/// </summary>
	/// <name>[SSE] Productive Farms in Drizzle</name>
	SSE_Productive_Farms_In_Drizzle = 50,

	/// <summary>
	/// Exposed Resources - The ground is soft, and soaked with the rain's essence. Mines produce 50% more goods during drizzle season.
	/// </summary>
	/// <name>[SSE] Productive Mine</name>
	SSE_Productive_Mine = 51,

	/// <summary>
	/// Wild Growth - Small, energizing drops cause uncontrollable growth in certain species. All gathering nodes discovered during drizzle season have more charges: +2 to small ones, and +10 to large ones.
	/// </summary>
	/// <name>[SSE] RawDepositsCharges</name>
	SSE_RawDepositsCharges = 52,

	/// <summary>
	/// Important Matters - Impatience grows 70% slower during drizzle season. The Queen seems to be preoccupied with more pressing matters.
	/// </summary>
	/// <name>[SSE] ReputationPenaltyRate 25</name>
	SSE_ReputationPenaltyRate_25 = 53,

	/// <summary>
	/// Bleeding Trees - A red, sticky substance is oozing out from beneath the tree bark. Gain 2 "[mat raw] resin" Resin every time woodcutters cut down a tree.
	/// </summary>
	/// <name>[SSE] Resin For Wood</name>
	SSE_Resin_For_Wood = 54,

	/// <summary>
	/// Absorption - Blightrot Cysts consume the storm's energy and become more resilient. Burning cysts takes 5 seconds longer.
	/// </summary>
	/// <name>[SSE] Resistant Cysts</name>
	SSE_Resistant_Cysts = 55,

	/// <summary>
	/// Aura of Fear - The dark skies above the settlement awaken a primal fear in all villagers. During the storm, all species' Resolve drops 100% faster.
	/// </summary>
	/// <name>[SSE] Resolve Fast Drop in Storm</name>
	SSE_Resolve_Fast_Drop_In_Storm = 56,

	/// <summary>
	/// Hot Springs - Rainwater Geysers produce pleasant heat in their vicinity. Geyser Pump Operators get +10 to Resolve.
	/// </summary>
	/// <name>[SSE] Resolve for Pump Operators</name>
	SSE_Resolve_For_Pump_Operators = 57,

	/// <summary>
	/// Saturated Air - A pleasant, earthy scent is in the air. Gain +1 to Global Resolve for every 30 units of water used in Rain Engines.
	/// </summary>
	/// <name>[SSE] Resolve for Water</name>
	SSE_Resolve_For_Water = 58,

	/// <summary>
	/// Warm Welcome - Increases Reputation gained from Resolve by 100%.
	/// </summary>
	/// <name>[SSE] Resolve To Reputation +100 [Warm Welcome]</name>
	SSE_Resolve_To_Reputation_Plus100_Warm_Welcome = 59,

	/// <summary>
	/// Rotting Wood - The rain is causing the trees to rot and fall apart. Woodcutters fell trees 50% faster, but have a +100% chance of destroying their yield.
	/// </summary>
	/// <name>[SSE] Rotting Wood</name>
	SSE_Rotting_Wood = 60,

	/// <summary>
	/// Faint Flame - Strong gusts of wind strike the Holy Flame. Resources you sacrifice in the Ancient Hearth burn 40% quicker.
	/// </summary>
	/// <name>[SSE] Sacrifice more in Storm</name>
	SSE_Sacrifice_More_In_Storm = 61,

	/// <summary>
	/// Vanishing Goods - Some goods seem to be mysteriously disappearing. Maybe there's a thief in the settlement? Villagers have a higher chance of consuming twice the amount of goods when using services (10% for each Hostility level).
	/// </summary>
	/// <name>[SSE] Service Waste</name>
	SSE_Service_Waste = 62,

	/// <summary>
	/// Death and Decay - This damp and rotting landscape is the perfect breeding ground for sickness. Every villager that dies during the storm instantly turns into a Blood Flower.
	/// </summary>
	/// <name>[SSE] Spawn Blightrot on Death</name>
	SSE_Spawn_Blightrot_On_Death = 63,

	/// <summary>
	/// Aura of Peace - After each storm comes a time of peace and regrowth. Gain 0.5 Reputation Points for every Dangerous or Forbidden Glade Event completed during drizzle season.
	/// </summary>
	/// <name>[SSE] Spring Events</name>
	SSE_Spring_Events = 64,

	/// <summary>
	/// Finders Keepers - After each storm, caravans find countless goods scattered along their routes. Every trade route you complete during drizzle season will give you 5 random packs of goods.
	/// </summary>
	/// <name>[SSE] Spring Routes</name>
	SSE_Spring_Routes = 65,

	/// <summary>
	/// Cloudburst - Even the hardiest villagers need some sort of cover in this weather. Once this effect activates, every villager in your settlement will ask you for 1 "[needs] coats" Coats. If you can't provide the goods, Global Resolve will be lowered by -6 for 2 minutes.
	/// </summary>
	/// <name>[SSE] Storm Clothes</name>
	SSE_Storm_Clothes = 66,

	/// <summary>
	/// Flooded Roads - As a result of heavy rainfall, during the storm, the travel cost of trade routes increases by 2.
	/// </summary>
	/// <name>[SSE] Trade Routes Costs More in Storm</name>
	SSE_Trade_Routes_Costs_More_In_Storm = 67,

	/// <summary>
	/// Clear Skies - Increases the speed at which traders arrive by 300%.
	/// </summary>
	/// <name>[SSE] Trader Interval +300 [Clear Skies]</name>
	SSE_Trader_Interval_Plus300_Clear_Skies = 68,

	/// <summary>
	/// Unearthly Element - The firekeeper's power weakens in the face of an otherworldly force. The maximum number of sacrifice stacks in the Ancient Hearth is lowered by 1.
	/// </summary>
	/// <name>[SSE] Unearthly Element</name>
	SSE_Unearthly_Element = 69,

	/// <summary>
	/// Vassal Tax - Due to this region's location, the Crown requires you to pay 5 "[valuable] amber" Amber with each storm (multiplied by the number of years played). If you don't, you will get 1 Impatience point.
	/// </summary>
	/// <name>[SSE] Vassal Tax</name>
	SSE_Vassal_Tax = 70,

	/// <summary>
	/// Leakage - The cover of the Ancient Hearth has been damaged due to an exceptionally strong storm. The Hearth's resistance has decreased by 300.
	/// </summary>
	/// <name>[SSE] Weakend Ancient Hearth</name>
	SSE_Weakend_Ancient_Hearth = 71,

	/// <summary>
	/// Sacred Flame Rituals - Only the Sacred Flame can protect the settlement from the darkness surrounding it. Pay 3 "[mat raw] wood" Wood for every villager in your settlement. If you don't pay for all of them, 2 people will leave.
	/// </summary>
	/// <name>[SSE] Wood for Villagers - Payment</name>
	SSE_Wood_For_Villagers_Payment = 72,

	/// <summary>
	/// Lightweight Wood - The evaporating rainwater has made the wood a lot lighter in this region. Woodcutters can carry 10 more goods in drizzle season.
	/// </summary>
	/// <name>[SSE] Woodcuters +10</name>
	SSE_Woodcuters_Plus10 = 73,

	/// <summary>
	/// Intensive Mutations - Living organisms in this region are mutated, and much larger than in other places. Doubles the amount of secondary resources gathered from trees.
	/// </summary>
	/// <name>[SSE] Woodcutters Camp Extra Only +100 [Intensive Mutations]</name>
	SSE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations = 74,

	/// <summary>
	/// Blight from the Sky - Blightrot seems to grow uncontrollably quickly in this region. Every storm season, 1 Blightrot Cysts appear in the settlement (multiplied by the number of years that have passed).
	/// </summary>
	/// <name>[SSE] Yearly Cysts</name>
	SSE_Yearly_Cysts = 75,



    /// <summary>
    /// The total number of vanilla SimpleSeasonalEffectTypes in the game.
    /// </summary>
	MAX = 75
}

/// <summary>
/// Extension methods for the SimpleSeasonalEffectTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class SimpleSeasonalEffectTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded SimpleSeasonalEffectTypes.
	/// </summary>
	public static SimpleSeasonalEffectTypes[] All()
	{
		SimpleSeasonalEffectTypes[] all = new SimpleSeasonalEffectTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every SimpleSeasonalEffectTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return SimpleSeasonalEffectTypes._TO_DELETE_SSE_FuelRate in the enum and log an error.
	/// </summary>
	public static string ToName(this SimpleSeasonalEffectTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of SimpleSeasonalEffectTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[SimpleSeasonalEffectTypes._TO_DELETE_SSE_FuelRate];
	}
	
	/// <summary>
	/// Returns a SimpleSeasonalEffectTypes associated with the given name.
	/// Every SimpleSeasonalEffectTypes should have a unique name as to distinguish it from others.
	/// If no SimpleSeasonalEffectTypes is found, it will return SimpleSeasonalEffectTypes.Unknown and log a warning.
	/// </summary>
	public static SimpleSeasonalEffectTypes ToSimpleSeasonalEffectTypes(this string name)
	{
		foreach (KeyValuePair<SimpleSeasonalEffectTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find SimpleSeasonalEffectTypes with name: " + name + "\n" + Environment.StackTrace);
		return SimpleSeasonalEffectTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a SimpleSeasonalEffectModel associated with the given name.
	/// SimpleSeasonalEffectModel contain all the data that will be used in the game.
	/// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
	/// If no SimpleSeasonalEffectModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel ToSimpleSeasonalEffectModel(this string name)
	{
		Eremite.Model.SimpleSeasonalEffectModel model = SO.Settings.simpleSeasonalEffects.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find SimpleSeasonalEffectModel for SimpleSeasonalEffectTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a SimpleSeasonalEffectModel associated with the given SimpleSeasonalEffectTypes.
    /// SimpleSeasonalEffectModel contain all the data that will be used in the game.
    /// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
    /// If no SimpleSeasonalEffectModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel ToSimpleSeasonalEffectModel(this SimpleSeasonalEffectTypes types)
	{
		return types.ToName().ToSimpleSeasonalEffectModel();
	}
	
	/// <summary>
	/// Returns an array of SimpleSeasonalEffectModel associated with the given SimpleSeasonalEffectTypes.
	/// SimpleSeasonalEffectModel contain all the data that will be used in the game.
	/// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
	/// If a SimpleSeasonalEffectModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel[] ToSimpleSeasonalEffectModelArray(this IEnumerable<SimpleSeasonalEffectTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.SimpleSeasonalEffectModel[] array = new Eremite.Model.SimpleSeasonalEffectModel[count];
		int i = 0;
		foreach (SimpleSeasonalEffectTypes element in collection)
		{
			array[i++] = element.ToSimpleSeasonalEffectModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of SimpleSeasonalEffectModel associated with the given SimpleSeasonalEffectTypes.
	/// SimpleSeasonalEffectModel contain all the data that will be used in the game.
	/// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
	/// If a SimpleSeasonalEffectModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel[] ToSimpleSeasonalEffectModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.SimpleSeasonalEffectModel[] array = new Eremite.Model.SimpleSeasonalEffectModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToSimpleSeasonalEffectModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of SimpleSeasonalEffectModel associated with the given SimpleSeasonalEffectTypes.
	/// SimpleSeasonalEffectModel contain all the data that will be used in the game.
	/// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
	/// If a SimpleSeasonalEffectModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel[] ToSimpleSeasonalEffectModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.SimpleSeasonalEffectModel>.Get(out List<Eremite.Model.SimpleSeasonalEffectModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.SimpleSeasonalEffectModel model = element.ToSimpleSeasonalEffectModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of SimpleSeasonalEffectModel associated with the given SimpleSeasonalEffectTypes.
	/// SimpleSeasonalEffectModel contain all the data that will be used in the game.
	/// Every SimpleSeasonalEffectModel should have a unique name as to distinguish it from others.
	/// If a SimpleSeasonalEffectModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.SimpleSeasonalEffectModel[] ToSimpleSeasonalEffectModelArrayNoNulls(this IEnumerable<SimpleSeasonalEffectTypes> collection)
	{
		using(ListPool<Eremite.Model.SimpleSeasonalEffectModel>.Get(out List<Eremite.Model.SimpleSeasonalEffectModel> list))
		{
			foreach (SimpleSeasonalEffectTypes element in collection)
			{
				Eremite.Model.SimpleSeasonalEffectModel model = element.ToSimpleSeasonalEffectModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<SimpleSeasonalEffectTypes, string> TypeToInternalName = new()
	{
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_FuelRate, "_TO DELETE [SSE] FuelRate" },                                                                        // Piercing Winds - Extremely strong winds make it difficult to sustain the Holy Flame. Fuel consumption in Hearths is increased by 200%.
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Grain_In_Harvester, "_TO DELETE [SSE] Grain in Harvester" },                                                    // Soft Stems - The grain stalks have grown soft because of the air’s humidity. During drizzle season, workers in the Harvesters' Camp can gather "[food raw] grain" grain (grade2) from grain nodes.
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Late_Newcomers, "_TO DELETE [SSE] Late Newcomers" },                                                            // Shifting Paths - The road to the village is long and winding, so some newcomers need a bit of extra motivation. Pay 2 "[packs] pack of crops" Pack of Crops with each storm (multiplied by the number of years played). If you don't, the next newcomer group will arrive 50% slower.
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Overheating, "_TO DELETE [SSE] Overheating" },                                                                  // Rotten Vapors - Machinery has to be cleaned with specially prepared Drizzle Water. Otherwise, Blightrot will spread. Once this effect activates, you have to pay 5 "[water] drizzle water" Drizzle Water (multiplied by the number of years). If you don't, 3 Blightrot Cysts will spawn in your settlement.
		{ SimpleSeasonalEffectTypes.SSE_Amber_For_Trade, "[SSE] Amber for Trade" },                                                                                // Royal Funding - The Queen's generosity knows no limits. Gain 2 "[valuable] amber" Amber every time you sell goods worth 10 Amber.
		{ SimpleSeasonalEffectTypes.SSE_Berries_Plus3, "[SSE] Berries +3" },                                                                                       // Berry New Year - +3 to "[food raw] berries" Berries production. Gain an additional "[food raw] berries" Berries every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_BIOME_Storm_Penalty, "[SSE] [BIOME] Storm Penalty" },                                                                      // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_BIOME_Tut_1_Storm_Penalty, "[SSE] [BIOME] Tut 1 Storm Penalty" },                                                          // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_Blightrot_Footprint_Minus50, "[SSE] Blightrot Footprint -50" },                                                            // Natural Filtration - Using Rain Engines causes a lot less Blightrot contamination due to the natural filtration processes of the surrounding vegetation. Blightrot Cysts grow 50% slower when using Rain Engines.
		{ SimpleSeasonalEffectTypes.SSE_Building_Materials_Prod_Penalty, "[SSE] Building Materials Prod Penalty" },                                                // Acid Rain - The rain dissolves some of the resources transported to your Warehouse. Recipes producing building materials yield 50% fewer goods.
		{ SimpleSeasonalEffectTypes.SSE_Clearance_For_Drizzle, "[SSE] Clearance for Drizzle" },                                                                    // Golden Dust - Some raindrops seem to have a golden hue. Gain 5 "[water] clearance water" Clearance Water for every 10 "[water] drizzle water" Drizzle Water gathered.
		{ SimpleSeasonalEffectTypes.SSE_Corruption_Favoring_Block, "[SSE] Corruption Favoring Block" },                                                            // Unyielding Corruption - The spreading corruption strikes fear into the hearts of your villagers. No amount of assurance or flattery can change that. Favoring is unavailable while the Hearth is being corrupted.
		{ SimpleSeasonalEffectTypes.SSE_Creeping_Shadows, "[SSE] Creeping Shadows" },                                                                              // Creeping Shadows - Discovering a glade during the storm will decrease Global Resolve by -10 for 3 minutes.
		{ SimpleSeasonalEffectTypes.SSE_Cricket_Mating_Grounds, "[SSE] Cricket Mating Grounds" },                                                                  // Cricket Mating Grounds - The clearings are abuzz with the sound of crickets. Gain 30 "[food raw] insects" Insects for each discovered glade.
		{ SimpleSeasonalEffectTypes.SSE_Cysts_Generate_Impatience_In_Storm, "[SSE] Cysts generate Impatience in Storm" },                                          // Spreading Contamination - Blightrot contaminates everything you send to the Citadel. During the storm, the Queen's Impatience grows 5% faster for every Blightrot Cyst in your settlement.
		{ SimpleSeasonalEffectTypes.SSE_Dang_Glades_Reduces_Resolve_In_Storm, "[SSE] Dang Glades reduces resolve in Storm" },                                      // Greater Threat - During the storm, receive -2 to Global Resolve for every Dangerous ("dangerous") and Forbidden Glade ("forbidden") discovered since the beginning of the settlement. (the penalty is added retroactively)
		{ SimpleSeasonalEffectTypes.SSE_Death_Blightrot, "[SSE] Death Blightrot" },                                                                                // Blightrot Infection - Villagers report feeling sick, especially during the storm. When a villager leaves or dies, 2 Blightrot Cysts will appear in the settlement. 
		{ SimpleSeasonalEffectTypes.SSE_Destroy_Nodes, "[SSE] Destroy Nodes" },                                                                                    // Unnatural Erosion - The wind and rain in this region seem more destructive than usual. Pay 5 "[crafting] oil" Oil with each storm (multiplied by the number of years played). If you don't, 2 random gathering nodes will be destroyed.
		{ SimpleSeasonalEffectTypes.SSE_Devastating_Storms, "[SSE] Devastating Storms" },                                                                          // Devastating Storms - The rampaging storm stifles the spirit of all living creatures. (‑20 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_Drizzle_Water_Per_Minute, "[SSE] Drizzle Water per minute" },                                                              // Drizzle Anomaly - The rain seems to fall... slower. Gain 15 "[water] drizzle water" Drizzle Water per minute during the drizzle.
		{ SimpleSeasonalEffectTypes.SSE_Drizzle_Water_Plus3, "[SSE] Drizzle Water +3" },                                                                           // Heavy Drops - +3 to "[water] drizzle water" Drizzle Water production. Gain an additional "[water] drizzle water" Drizzle Water every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Fast_Food, "[SSE] Fast Food" },                                                                                            // Salty Breeze - The salty air makes it easier to preserve food. Food production speed is increased by 80% during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Fertile_Nodes, "[SSE] Fertile Nodes" },                                                                                    // Soil Reclamation - The soil becomes saturated with the rain's essence during drizzle season. Gathering nodes depleted during the drizzle spawn fertile soil.
		{ SimpleSeasonalEffectTypes.SSE_Fish_Plus3, "[SSE] Fish +3" },                                                                                             // Fish Flood - +3 to "[food raw] fish" Fish production. Gain an additional "[food raw] fish" Fish every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Food_Consumption, "[SSE] Food Consumption" },                                                                              // Insatiable Hunger - Working in this environment requires a lot of energy. Villagers have a higher chance of consuming twice the amount of food on each break (10% for each Hostility level).
		{ SimpleSeasonalEffectTypes.SSE_Food_Production_Speed_Minus15, "[SSE] Food Production Speed -15" },                                                        // Rot from the Sky - The rain smells like Blightrot... Global food production is slowed by 15% for each Hostility level.
		{ SimpleSeasonalEffectTypes.SSE_FuelRateHostility, "[SSE] FuelRateHostility" },                                                                            // Humid Climate - The humidity in this region is unbearable. Fuel consumption in Hearths is increased by 20% for each Hostility level.
		{ SimpleSeasonalEffectTypes.SSE_Gatherer_Production_Speed_Minus50, "[SSE] Gatherer Production Speed -50" },                                                // Quaking Bog - The ground is moving and swaying from all the rainwater it’s absorbed. Gathering speed is decreased by 50%.
		{ SimpleSeasonalEffectTypes.SSE_Gatherer_Production_Speed_Plus50, "[SSE] Gatherer Production Speed +50" },                                                 // Fruitful Season - The forest's fruits are so ripe, they almost fall into the basket on their own. Gathering speed is increased by 50%.
		{ SimpleSeasonalEffectTypes.SSE_Gift_For_Reputation, "[SSE] Gift for Reputation" },                                                                        // Forgiving Crown - Gain one free cornerstone reroll for every Reputation Point gained during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Gift_From_The_Woods, "[SSE] Gift from the Woods" },                                                                        // Gift from the Woods - These seem to be the ideal conditions in which to create Amber. Gain 5 "[valuable] amber" Amber every drizzle season, plus an additional 5 "[valuable] amber" Amber for each Hostility level reached.
		{ SimpleSeasonalEffectTypes.SSE_Glades_Resolve_In_Drizzle, "[SSE] Glades Resolve in Drizzle" },                                                            // Gentle Dawn - New year, new challenges. You gain a +10% bonus to planting speed during Drizzle season for every small glade you discover (as well as your starting glade). This effect is retroactive.
		{ SimpleSeasonalEffectTypes.SSE_Goods_For_Solved_Relics, "[SSE] Goods for Solved Relics" },                                                                // Forest Offerings - It seems some inhabitants of the forest are grateful for your efforts. During drizzle season, every Dangerous or Forbidden Glade Event you complete will give you 40 random raw food.
		{ SimpleSeasonalEffectTypes.SSE_Grim_Fate, "[SSE] Grim Fate" },                                                                                            // Grim Fate - The forest will claim a villager's life during each storm (multiplied by the number of years that have passed).
		{ SimpleSeasonalEffectTypes.SSE_Hunger_Storm, "[SSE] Hunger Storm" },                                                                                      // Hunger Storm - Missing even a single meal in this harsh climate can be deadly. If villagers don't have anything to eat during a break, they will gain two stacks of the Hunger effect.
		{ SimpleSeasonalEffectTypes.SSE_Leather_Plus3, "[SSE] Leather +3" },                                                                                       // Shedding Season - +3 to "[mat raw] leather" Leather production. Gain an additional "[mat raw] leather" Leather every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Lightning, "[SSE] Lightning" },                                                                                            // Devastation - The storm in this region is extremely violent. Once this effect is activated, you'll have to pay 1 "[packs] pack of building materials" Pack of Building Materials (multiplied by the number of years). If you don't, 3 buildings in your settlement will become ruins.
		{ SimpleSeasonalEffectTypes.SSE_Living_Farmfield, "[SSE] Living Farmfield" },                                                                              // Rotten Rain - The rain carries a strange, rotten pollen with it. A Blood Flower will spawn somewhere in the settlement every 90 seconds.
		{ SimpleSeasonalEffectTypes.SSE_Longer_Break_Interval, "[SSE] Longer Break Interval" },                                                                    // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
		{ SimpleSeasonalEffectTypes.SSE_M0_60_Off_Roads_Muddy_Ground, "[SSE] M0_60 Off Roads [Muddy Ground]" },                                                    // Muddy Ground - Villagers' speed off-road is decreased by 30%.
		{ SimpleSeasonalEffectTypes.SSE_Marrow_Mine, "[SSE] Marrow Mine" },                                                                                        // Marrow Growth - Small pockets of bone marrow form in the ground and on trees. Gain 5 "[crafting] sea marrow" Sea Marrow for every 5 "[crafting] coal" Coal produced during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Meat_Plus3, "[SSE] Meat +3" },                                                                                             // Mating Season - +3 to "[food raw] meat" Meat production. Gain an additional "[food raw] meat" Meat every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Metal_Prod_Penalty, "[SSE] Metal Prod Penalty" },                                                                          // Corrosive Rainfall - Acid rain is slowly eating away at all metal objects. Producing Copper Bars, Crystalized Dew, and all goods that use metal ingots yields 50% fewer goods.
		{ SimpleSeasonalEffectTypes.SSE_Mine_In_Storm, "[SSE] Mine in Storm" },                                                                                    // Horrors from Beneath - Strange voices call out from the depths. Villagers working in Mines get -10 to Resolve during the storm.
		{ SimpleSeasonalEffectTypes.SSE_More_Event_Goods, "[SSE] More event goods" },                                                                              // Scavenging Season - The drizzle in this region is very mild, making it the perfect season for looting. Increases the chance of doubling loot from events solved during the drizzle by 25% (this doesn't apply to perks and blueprints).
		{ SimpleSeasonalEffectTypes.SSE_More_Water_Consumption, "[SSE] More Water Consumption" },                                                                  // Vanishing Water - Infused rainwater slowly evaporates. You lose 1 unit of a random type of water for every 2 units of water used in Rain Engines. 
		{ SimpleSeasonalEffectTypes.SSE_Mushroom_Plus3, "[SSE] Mushroom +3" },                                                                                     // Mushrooms After Rain - +3 to "[food raw] mushrooms" Mushrooms production. Gain an additional "[food raw] mushrooms" Mushrooms every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_No_Impatience_Reduction, "[SSE] No Impatience Reduction" },                                                                // No contact - Harsh weather conditions make it impossible to reach the Citadel. Gaining Reputation doesn't lower Impatience.
		{ SimpleSeasonalEffectTypes.SSE_Nodes_Bonuses, "[SSE] Nodes Bonuses" },                                                                                    // Untapped Wealth - Gatherers bring back twice the amount of secondary resources when collecting from gathering nodes.
		{ SimpleSeasonalEffectTypes.SSE_Productive_Farms_In_Drizzle, "[SSE] Productive Farms in Drizzle" },                                                        // Regrowth - Plants seem to grow exceptionally quickly after the storm. All buildings that use fertile soil produce +50% more goods during the drizzle, and all crops planted during the drizzle will yield +50% more when collected during clearance season.
		{ SimpleSeasonalEffectTypes.SSE_Productive_Mine, "[SSE] Productive Mine" },                                                                                // Exposed Resources - The ground is soft, and soaked with the rain's essence. Mines produce 50% more goods during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_RawDepositsCharges, "[SSE] RawDepositsCharges" },                                                                          // Wild Growth - Small, energizing drops cause uncontrollable growth in certain species. All gathering nodes discovered during drizzle season have more charges: +2 to small ones, and +10 to large ones.
		{ SimpleSeasonalEffectTypes.SSE_ReputationPenaltyRate_25, "[SSE] ReputationPenaltyRate 25" },                                                              // Important Matters - Impatience grows 70% slower during drizzle season. The Queen seems to be preoccupied with more pressing matters.
		{ SimpleSeasonalEffectTypes.SSE_Resin_For_Wood, "[SSE] Resin For Wood" },                                                                                  // Bleeding Trees - A red, sticky substance is oozing out from beneath the tree bark. Gain 2 "[mat raw] resin" Resin every time woodcutters cut down a tree.
		{ SimpleSeasonalEffectTypes.SSE_Resistant_Cysts, "[SSE] Resistant Cysts" },                                                                                // Absorption - Blightrot Cysts consume the storm's energy and become more resilient. Burning cysts takes 5 seconds longer.
		{ SimpleSeasonalEffectTypes.SSE_Resolve_Fast_Drop_In_Storm, "[SSE] Resolve Fast Drop in Storm" },                                                          // Aura of Fear - The dark skies above the settlement awaken a primal fear in all villagers. During the storm, all species' Resolve drops 100% faster.
		{ SimpleSeasonalEffectTypes.SSE_Resolve_For_Pump_Operators, "[SSE] Resolve for Pump Operators" },                                                          // Hot Springs - Rainwater Geysers produce pleasant heat in their vicinity. Geyser Pump Operators get +10 to Resolve.
		{ SimpleSeasonalEffectTypes.SSE_Resolve_For_Water, "[SSE] Resolve for Water" },                                                                            // Saturated Air - A pleasant, earthy scent is in the air. Gain +1 to Global Resolve for every 30 units of water used in Rain Engines.
		{ SimpleSeasonalEffectTypes.SSE_Resolve_To_Reputation_Plus100_Warm_Welcome, "[SSE] Resolve To Reputation +100 [Warm Welcome]" },                           // Warm Welcome - Increases Reputation gained from Resolve by 100%.
		{ SimpleSeasonalEffectTypes.SSE_Rotting_Wood, "[SSE] Rotting Wood" },                                                                                      // Rotting Wood - The rain is causing the trees to rot and fall apart. Woodcutters fell trees 50% faster, but have a +100% chance of destroying their yield.
		{ SimpleSeasonalEffectTypes.SSE_Sacrifice_More_In_Storm, "[SSE] Sacrifice more in Storm" },                                                                // Faint Flame - Strong gusts of wind strike the Holy Flame. Resources you sacrifice in the Ancient Hearth burn 40% quicker.
		{ SimpleSeasonalEffectTypes.SSE_Service_Waste, "[SSE] Service Waste" },                                                                                    // Vanishing Goods - Some goods seem to be mysteriously disappearing. Maybe there's a thief in the settlement? Villagers have a higher chance of consuming twice the amount of goods when using services (10% for each Hostility level).
		{ SimpleSeasonalEffectTypes.SSE_Spawn_Blightrot_On_Death, "[SSE] Spawn Blightrot on Death" },                                                              // Death and Decay - This damp and rotting landscape is the perfect breeding ground for sickness. Every villager that dies during the storm instantly turns into a Blood Flower.
		{ SimpleSeasonalEffectTypes.SSE_Spring_Events, "[SSE] Spring Events" },                                                                                    // Aura of Peace - After each storm comes a time of peace and regrowth. Gain 0.5 Reputation Points for every Dangerous or Forbidden Glade Event completed during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Spring_Routes, "[SSE] Spring Routes" },                                                                                    // Finders Keepers - After each storm, caravans find countless goods scattered along their routes. Every trade route you complete during drizzle season will give you 5 random packs of goods.
		{ SimpleSeasonalEffectTypes.SSE_Storm_Clothes, "[SSE] Storm Clothes" },                                                                                    // Cloudburst - Even the hardiest villagers need some sort of cover in this weather. Once this effect activates, every villager in your settlement will ask you for 1 "[needs] coats" Coats. If you can't provide the goods, Global Resolve will be lowered by -6 for 2 minutes.
		{ SimpleSeasonalEffectTypes.SSE_Trade_Routes_Costs_More_In_Storm, "[SSE] Trade Routes Costs More in Storm" },                                              // Flooded Roads - As a result of heavy rainfall, during the storm, the travel cost of trade routes increases by 2.
		{ SimpleSeasonalEffectTypes.SSE_Trader_Interval_Plus300_Clear_Skies, "[SSE] Trader Interval +300 [Clear Skies]" },                                         // Clear Skies - Increases the speed at which traders arrive by 300%.
		{ SimpleSeasonalEffectTypes.SSE_Unearthly_Element, "[SSE] Unearthly Element" },                                                                            // Unearthly Element - The firekeeper's power weakens in the face of an otherworldly force. The maximum number of sacrifice stacks in the Ancient Hearth is lowered by 1.
		{ SimpleSeasonalEffectTypes.SSE_Vassal_Tax, "[SSE] Vassal Tax" },                                                                                          // Vassal Tax - Due to this region's location, the Crown requires you to pay 5 "[valuable] amber" Amber with each storm (multiplied by the number of years played). If you don't, you will get 1 Impatience point.
		{ SimpleSeasonalEffectTypes.SSE_Weakend_Ancient_Hearth, "[SSE] Weakend Ancient Hearth" },                                                                  // Leakage - The cover of the Ancient Hearth has been damaged due to an exceptionally strong storm. The Hearth's resistance has decreased by 300.
		{ SimpleSeasonalEffectTypes.SSE_Wood_For_Villagers_Payment, "[SSE] Wood for Villagers - Payment" },                                                        // Sacred Flame Rituals - Only the Sacred Flame can protect the settlement from the darkness surrounding it. Pay 3 "[mat raw] wood" Wood for every villager in your settlement. If you don't pay for all of them, 2 people will leave.
		{ SimpleSeasonalEffectTypes.SSE_Woodcuters_Plus10, "[SSE] Woodcuters +10" },                                                                               // Lightweight Wood - The evaporating rainwater has made the wood a lot lighter in this region. Woodcutters can carry 10 more goods in drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations, "[SSE] Woodcutters Camp Extra Only +100 [Intensive Mutations]" }, // Intensive Mutations - Living organisms in this region are mutated, and much larger than in other places. Doubles the amount of secondary resources gathered from trees.
		{ SimpleSeasonalEffectTypes.SSE_Yearly_Cysts, "[SSE] Yearly Cysts" },                                                                                      // Blight from the Sky - Blightrot seems to grow uncontrollably quickly in this region. Every storm season, 1 Blightrot Cysts appear in the settlement (multiplied by the number of years that have passed).

	};
}
