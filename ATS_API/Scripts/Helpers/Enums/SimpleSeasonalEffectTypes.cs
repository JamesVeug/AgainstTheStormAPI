using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.17R
public enum SimpleSeasonalEffectTypes
{
	Unknown = -1,
	None,
	_TO_DELETE_SSE_FuelRate,                                     // Piercing Winds - Extremely strong winds make it difficult to sustain the Holy Flame. Fuel consumption in Hearths is increased by 200%.
	_TO_DELETE_SSE_Grain_In_Harvester,                           // Soft Stems - The grain stalks have grown soft because of the air’s humidity. During drizzle season, workers in the Harvesters' Camp can gather <sprite name="[food raw] grain"> grain (<sprite name=grade2>) from grain nodes.
	_TO_DELETE_SSE_Late_Newcomers,                               // Shifting Paths - The road to the village is long and winding, so some newcomers need a bit of extra motivation. Pay 2 <sprite name="[packs] pack of crops"> Pack of Crops with each storm (multiplied by the number of years played). If you don't, the next newcomer group will arrive 50% slower.
	_TO_DELETE_SSE_Overheating,                                  // Rotten Vapors - Machinery has to be cleaned with specially prepared Drizzle Water. Otherwise, Blightrot will spread. Once this effect activates, you have to pay 5 <sprite name="[water] drizzle water"> Drizzle Water (multiplied by the number of years). If you don't, 3 Blightrot Cysts will spawn in your settlement.
	SSE_Amber_For_Trade,                                         // Royal Funding - The Queen's generosity knows no limits. Gain 2 <sprite name="[valuable] amber"> Amber every time you sell goods worth 10 Amber.
	SSE_Berries_Plus3,                                           // Berry New Year - +3 to <sprite name="[food raw] berries"> Berries production. Gain an additional <sprite name="[food raw] berries"> Berries every yield (from gathering, farming, fishing, or production).
	SSE_BIOME_Storm_Penalty,                                     // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
	SSE_BIOME_Tut_1_Storm_Penalty,                               // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
	SSE_Blightrot_Footprint_Minus50,                             // Natural Filtration - Using Rain Engines causes a lot less Blightrot contamination due to the natural filtration processes of the surrounding vegetation. Blightrot Cysts grow 50% slower when using Rain Engines.
	SSE_Building_Materials_Prod_Penalty,                         // Acid Rain - The rain dissolves some of the resources transported to your Warehouse. Recipes producing building materials yield 50% fewer goods.
	SSE_Clearance_For_Drizzle,                                   // Golden Dust - Some raindrops seem to have a golden hue. Gain 5 <sprite name="[water] clearance water"> Clearance Water for every 10 <sprite name="[water] drizzle water"> Drizzle Water gathered.
	SSE_Corruption_Favoring_Block,                               // Unyielding Corruption - The spreading corruption strikes fear into the hearts of your villagers. No amount of assurance or flattery can change that. Favoring is unavailable while the Hearth is being corrupted.
	SSE_Creeping_Shadows,                                        // Creeping Shadows - Discovering a glade during the storm will decrease Global Resolve by -10 for 3 minutes.
	SSE_Cricket_Mating_Grounds,                                  // Cricket Mating Grounds - The clearings are abuzz with the sound of crickets. Gain 30 <sprite name="[food raw] insects"> Insects for each discovered glade.
	SSE_Cysts_Generate_Impatience_In_Storm,                      // Spreading Contamination - Blightrot contaminates everything you send to the Citadel. During the storm, the Queen's Impatience grows 5% faster for every Blightrot Cyst in your settlement.
	SSE_Dang_Glades_Reduces_Resolve_In_Storm,                    // Greater Threat - During the storm, receive -2 to Global Resolve for every Dangerous (<sprite name="dangerous">) and Forbidden Glade (<sprite name="forbidden">) discovered since the beginning of the settlement. (the penalty is added retroactively)
	SSE_Death_Blightrot,                                         // Blightrot Infection - Villagers report feeling sick, especially during the storm. When a villager leaves or dies, 2 Blightrot Cysts will appear in the settlement. 
	SSE_Destroy_Nodes,                                           // Unnatural Erosion - The wind and rain in this region seem more destructive than usual. Pay 5 <sprite name="[crafting] oil"> Oil with each storm (multiplied by the number of years played). If you don't, 2 random resource nodes will be destroyed.
	SSE_Devastating_Storms,                                      // Devastating Storms - The rampaging storm stifles the spirit of all living creatures. (‑20 to Global Resolve)
	SSE_Drizzle_Water_Per_Minute,                                // Drizzle Anomaly - The rain seems to fall... slower. Gain 15 <sprite name="[water] drizzle water"> Drizzle Water per minute during the drizzle.
	SSE_Drizzle_Water_Plus3,                                     // Heavy Drops - +3 to <sprite name="[water] drizzle water"> Drizzle Water production. Gain an additional <sprite name="[water] drizzle water"> Drizzle Water every yield (from gathering, farming, fishing, or production).
	SSE_Fast_Food,                                               // Salty Breeze - The salty air makes it easier to preserve food. Food production speed is increased by 80% during drizzle season.
	SSE_Fertile_Nodes,                                           // Soil Reclamation - The soil becomes saturated with the rain's essence during drizzle season. Resource nodes depleted during the drizzle spawn fertile soil.
	SSE_Food_Consumption,                                        // Insatiable Hunger - Working in this environment requires a lot of energy. Villagers have a higher chance of consuming twice the amount of food on each break (10% for each Hostility level).
	SSE_Food_Production_Speed_Minus15,                           // Rot from the Sky - The rain smells like Blightrot... Global food production is slowed by 15% for each Hostility level.
	SSE_FuelRateHostility,                                       // Humid Climate - The humidity in this region is unbearable. Fuel consumption in Hearths is increased by 20% for each Hostility level.
	SSE_Gatherer_Production_Speed_Minus50,                       // Quaking Bog - The ground is moving and swaying from all the rainwater it’s absorbed. Gathering speed is decreased by 50%.
	SSE_Gatherer_Production_Speed_Plus50,                        // Fruitful Season - The forest's fruits are so ripe, they almost fall into the basket on their own. Gathering speed is increased by 50%.
	SSE_Gift_For_Reputation,                                     // Forgiving Crown - Gain one free cornerstone reroll for every Reputation Point gained during drizzle season.
	SSE_Gift_From_The_Woods,                                     // Gift from the Woods - These seem to be the ideal conditions in which to create Amber. Gain 5 <sprite name="[valuable] amber"> Amber every drizzle season, plus an additional 5 <sprite name="[valuable] amber"> Amber for each Hostility level reached.
	SSE_Glades_Resolve_In_Drizzle,                               // Gentle Dawn - New year, new challenges. Every small glade discovered grants +10% to planting speed during Drizzle. (the bonus is added retroactively)
	SSE_Goods_For_Solved_Relics,                                 // Forest Offerings - It seems some inhabitants of the forest are grateful for your efforts. During drizzle season, every Dangerous or Forbidden Glade Event you complete will give you 40 random raw food.
	SSE_Grim_Fate,                                               // Grim Fate - The forest will claim a villager's life during each storm (multiplied by the number of years that have passed).
	SSE_Hunger_Storm,                                            // Hunger Storm - Missing even a single meal in this harsh climate can be deadly. If villagers don't have anything to eat during a break, they will gain two stacks of the Hunger effect.
	SSE_Lightning,                                               // Devastation - The storm in this region is extremely violent. Once this effect is activated, you'll have to pay 1 <sprite name="[packs] pack of building materials"> Pack of Building Materials (multiplied by the number of years). If you don't, 3 buildings in your settlement will become ruins.
	SSE_Living_Farmfield,                                        // Rotten Rain - The rain carries a strange, rotten pollen with it. A Blood Flower will spawn somewhere in the settlement every 90 seconds.
	SSE_Longer_Break_Interval,                                   // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
	SSE_M0_60_Off_Roads_Muddy_Ground,                            // Muddy Ground - Villagers' speed off-road is decreased by 30%.
	SSE_Marrow_Mine,                                             // Marrow Growth - Small pockets of bone marrow form in the ground and on trees. Gain 5 <sprite name="[crafting] sea marrow"> Sea Marrow for every 5 <sprite name="[crafting] coal"> Coal produced during drizzle season.
	SSE_Meat_Plus3,                                              // Mating Season - +3 to <sprite name="[food raw] meat"> Meat production. Gain an additional <sprite name="[food raw] meat"> Meat every yield (from gathering, farming, fishing, or production).
	SSE_Metal_Prod_Penalty,                                      // Corrosive Rainfall - Acid rain is slowly eating away at all metal objects. Producing Copper Bars, Crystalized Dew, and all goods that use metal ingots yields 50% fewer goods.
	SSE_Mine_In_Storm,                                           // Horrors from Beneath - Strange voices call out from the depths. Villagers working in Mines get -10 to Resolve during the storm.
	SSE_More_Event_Goods,                                        // Scavenging Season - The drizzle in this region is very mild, making it the perfect season for looting. Increases the chance of doubling loot from events solved during the drizzle by 25% (this doesn't apply to perks and blueprints).
	SSE_More_Water_Consumption,                                  // Vanishing Water - Infused rainwater slowly evaporates. You lose 1 unit of a random type of water for every 2 units of water used in Rain Engines. 
	SSE_Mushroom_Plus3,                                          // Mushrooms After Rain - +3 to <sprite name="[food raw] mushrooms"> Mushrooms production. Gain an additional <sprite name="[food raw] mushrooms"> Mushrooms every yield (from gathering, farming, fishing, or production).
	SSE_No_Impatience_Reduction,                                 // No contact - Harsh weather conditions make it impossible to reach the Citadel. Gaining Reputation doesn't lower Impatience.
	SSE_Nodes_Bonuses,                                           // Untapped Wealth - Gatherers produce twice the amount of secondary resources when harvesting resource nodes.
	SSE_Productive_Farms_In_Drizzle,                             // Regrowth - Plants seem to grow exceptionally quickly after the storm. All buildings that use fertile soil produce +50% more goods during the drizzle, and all crops planted during the drizzle will yield +50% more when collected during clearance season.
	SSE_Productive_Mine,                                         // Exposed Resources - The ground is soft, and soaked with the rain's essence. Mines produce 50% more goods during drizzle season.
	SSE_RawDepositsCharges,                                      // Wild Growth - Small, energizing drops cause uncontrollable growth in certain species. All resource nodes discovered during drizzle season have more charges: +2 to small deposits, and +10 to large deposits.
	SSE_ReputationPenaltyRate_25,                                // Important Matters - Impatience grows 70% slower during drizzle season. The Queen seems to be preoccupied with more pressing matters.
	SSE_Resin_For_Wood,                                          // Bleeding Trees - A red, sticky substance is oozing out from beneath the tree bark. Gain 2 <sprite name="[mat raw] resin"> Resin every time woodcutters cut down a tree.
	SSE_Resistant_Cysts,                                         // Absorption - Blightrot Cysts consume the storm's energy and become more resilient. Burning cysts takes 5 seconds longer.
	SSE_Resolve_Fast_Drop_In_Storm,                              // Aura of Fear - The dark skies above the settlement awaken a primal fear in all villagers. During the storm, all species' Resolve drops 100% faster.
	SSE_Resolve_For_Pump_Operators,                              // Hot Springs - Rainwater Geysers produce pleasant heat in their vicinity. Geyser Pump Operators get +10 to Resolve.
	SSE_Resolve_For_Water,                                       // Saturated Air - A pleasant, earthy scent is in the air. Gain +1 to Global Resolve for every 30 units of water used in Rain Engines.
	SSE_Resolve_To_Reputation_Plus100_Warm_Welcome,              // Warm Welcome - Increases Reputation gained from Resolve by 100%.
	SSE_Rotting_Wood,                                            // Rotting Wood - The rain is causing the trees to rot and fall apart. Woodcutters fell trees 50% faster, but have a +100% chance of destroying their yield.
	SSE_Sacrifice_More_In_Storm,                                 // Faint Flame - Strong gusts of wind strike the Holy Flame. Resources you sacrifice in the Ancient Hearth burn 40% quicker.
	SSE_Service_Waste,                                           // Vanishing Goods - Some goods seem to be mysteriously disappearing. Maybe there's a thief in the settlement? Villagers have a higher chance of consuming twice the amount of goods when using services (10% for each Hostility level).
	SSE_Spawn_Blightrot_On_Death,                                // Death and Decay - This damp and rotting landscape is the perfect breeding ground for sickness. Every villager that dies during the storm instantly turns into a Blood Flower.
	SSE_Spring_Events,                                           // Aura of Peace - After each storm comes a time of peace and regrowth. Gain 0.5 Reputation Points for every Dangerous or Forbidden Glade Event completed during drizzle season.
	SSE_Spring_Routes,                                           // Finders Keepers - After each storm, caravans find countless goods scattered along their routes. Every trade route you complete during drizzle season will give you 5 random packs of goods.
	SSE_Storm_Clothes,                                           // Cloudburst - Even the hardiest villagers need some sort of cover in this weather. Once this effect activates, every villager in your settlement will ask you for 1 <sprite name="[needs] coats"> Coats. If you can't provide the goods, Global Resolve will be lowered by -6 for 2 minutes.
	SSE_Trade_Routes_Costs_More_In_Storm,                        // Flooded Roads - As a result of heavy rainfall, during the storm, the travel cost of trade routes increases by 2.
	SSE_Trader_Interval_Plus300_Clear_Skies,                     // Clear Skies - Increases the speed at which traders arrive by 300%.
	SSE_Unearthly_Element,                                       // Unearthly Element - The firekeeper's power weakens in the face of an otherworldly force. The maximum number of sacrifice stacks in the Ancient Hearth is lowered by 1.
	SSE_Vassal_Tax,                                              // Vassal Tax - Due to this region's location, the Crown requires you to pay 5 <sprite name="[valuable] amber"> Amber with each storm (multiplied by the number of years played). If you don't, you will get 1 Impatience point.
	SSE_Weakend_Ancient_Hearth,                                  // Leakage - The cover of the Ancient Hearth has been damaged due to an exceptionally strong storm. The Hearth's resistance has decreased by 300.
	SSE_Wood_For_Villagers_Payment,                              // Sacred Flame Rituals - Only the Sacred Flame can protect the settlement from the darkness surrounding it. Pay 3 <sprite name="[mat raw] wood"> Wood for every villager in your settlement. If you don't pay for all of them, 2 people will leave.
	SSE_Woodcuters_Plus10,                                       // Lightweight Wood - The evaporating rainwater has made the wood a lot lighter in this region. Woodcutters can carry 10 more goods in drizzle season.
	SSE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations, // Intensive Mutations - Living organisms in this region are mutated, and much larger than in other places. Doubles the amount of secondary resources gathered from trees.
	SSE_Yearly_Cysts,                                            // Blight from the Sky - Blightrot seems to grow uncontrollably quickly in this region. Every storm season, 1 Blightrot Cysts appear in the settlement (multiplied by the number of years that have passed).


	MAX = 73
}

public static class SimpleSeasonalEffectTypesExtensions
{
	private static SimpleSeasonalEffectTypes[] s_All = null;
	public static SimpleSeasonalEffectTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new SimpleSeasonalEffectTypes[73];
			for (int i = 0; i < 73; i++)
			{
				s_All[i] = (SimpleSeasonalEffectTypes)(i+1);
			}
		}
		return s_All;
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
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Grain_In_Harvester, "_TO DELETE [SSE] Grain in Harvester" },                                                    // Soft Stems - The grain stalks have grown soft because of the air’s humidity. During drizzle season, workers in the Harvesters' Camp can gather <sprite name="[food raw] grain"> grain (<sprite name=grade2>) from grain nodes.
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Late_Newcomers, "_TO DELETE [SSE] Late Newcomers" },                                                            // Shifting Paths - The road to the village is long and winding, so some newcomers need a bit of extra motivation. Pay 2 <sprite name="[packs] pack of crops"> Pack of Crops with each storm (multiplied by the number of years played). If you don't, the next newcomer group will arrive 50% slower.
		{ SimpleSeasonalEffectTypes._TO_DELETE_SSE_Overheating, "_TO DELETE [SSE] Overheating" },                                                                  // Rotten Vapors - Machinery has to be cleaned with specially prepared Drizzle Water. Otherwise, Blightrot will spread. Once this effect activates, you have to pay 5 <sprite name="[water] drizzle water"> Drizzle Water (multiplied by the number of years). If you don't, 3 Blightrot Cysts will spawn in your settlement.
		{ SimpleSeasonalEffectTypes.SSE_Amber_For_Trade, "[SSE] Amber for Trade" },                                                                                // Royal Funding - The Queen's generosity knows no limits. Gain 2 <sprite name="[valuable] amber"> Amber every time you sell goods worth 10 Amber.
		{ SimpleSeasonalEffectTypes.SSE_Berries_Plus3, "[SSE] Berries +3" },                                                                                       // Berry New Year - +3 to <sprite name="[food raw] berries"> Berries production. Gain an additional <sprite name="[food raw] berries"> Berries every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_BIOME_Storm_Penalty, "[SSE] [BIOME] Storm Penalty" },                                                                      // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_BIOME_Tut_1_Storm_Penalty, "[SSE] [BIOME] Tut 1 Storm Penalty" },                                                          // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level. (‑4 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_Blightrot_Footprint_Minus50, "[SSE] Blightrot Footprint -50" },                                                            // Natural Filtration - Using Rain Engines causes a lot less Blightrot contamination due to the natural filtration processes of the surrounding vegetation. Blightrot Cysts grow 50% slower when using Rain Engines.
		{ SimpleSeasonalEffectTypes.SSE_Building_Materials_Prod_Penalty, "[SSE] Building Materials Prod Penalty" },                                                // Acid Rain - The rain dissolves some of the resources transported to your Warehouse. Recipes producing building materials yield 50% fewer goods.
		{ SimpleSeasonalEffectTypes.SSE_Clearance_For_Drizzle, "[SSE] Clearance for Drizzle" },                                                                    // Golden Dust - Some raindrops seem to have a golden hue. Gain 5 <sprite name="[water] clearance water"> Clearance Water for every 10 <sprite name="[water] drizzle water"> Drizzle Water gathered.
		{ SimpleSeasonalEffectTypes.SSE_Corruption_Favoring_Block, "[SSE] Corruption Favoring Block" },                                                            // Unyielding Corruption - The spreading corruption strikes fear into the hearts of your villagers. No amount of assurance or flattery can change that. Favoring is unavailable while the Hearth is being corrupted.
		{ SimpleSeasonalEffectTypes.SSE_Creeping_Shadows, "[SSE] Creeping Shadows" },                                                                              // Creeping Shadows - Discovering a glade during the storm will decrease Global Resolve by -10 for 3 minutes.
		{ SimpleSeasonalEffectTypes.SSE_Cricket_Mating_Grounds, "[SSE] Cricket Mating Grounds" },                                                                  // Cricket Mating Grounds - The clearings are abuzz with the sound of crickets. Gain 30 <sprite name="[food raw] insects"> Insects for each discovered glade.
		{ SimpleSeasonalEffectTypes.SSE_Cysts_Generate_Impatience_In_Storm, "[SSE] Cysts generate Impatience in Storm" },                                          // Spreading Contamination - Blightrot contaminates everything you send to the Citadel. During the storm, the Queen's Impatience grows 5% faster for every Blightrot Cyst in your settlement.
		{ SimpleSeasonalEffectTypes.SSE_Dang_Glades_Reduces_Resolve_In_Storm, "[SSE] Dang Glades reduces resolve in Storm" },                                      // Greater Threat - During the storm, receive -2 to Global Resolve for every Dangerous (<sprite name="dangerous">) and Forbidden Glade (<sprite name="forbidden">) discovered since the beginning of the settlement. (the penalty is added retroactively)
		{ SimpleSeasonalEffectTypes.SSE_Death_Blightrot, "[SSE] Death Blightrot" },                                                                                // Blightrot Infection - Villagers report feeling sick, especially during the storm. When a villager leaves or dies, 2 Blightrot Cysts will appear in the settlement. 
		{ SimpleSeasonalEffectTypes.SSE_Destroy_Nodes, "[SSE] Destroy Nodes" },                                                                                    // Unnatural Erosion - The wind and rain in this region seem more destructive than usual. Pay 5 <sprite name="[crafting] oil"> Oil with each storm (multiplied by the number of years played). If you don't, 2 random resource nodes will be destroyed.
		{ SimpleSeasonalEffectTypes.SSE_Devastating_Storms, "[SSE] Devastating Storms" },                                                                          // Devastating Storms - The rampaging storm stifles the spirit of all living creatures. (‑20 to Global Resolve)
		{ SimpleSeasonalEffectTypes.SSE_Drizzle_Water_Per_Minute, "[SSE] Drizzle Water per minute" },                                                              // Drizzle Anomaly - The rain seems to fall... slower. Gain 15 <sprite name="[water] drizzle water"> Drizzle Water per minute during the drizzle.
		{ SimpleSeasonalEffectTypes.SSE_Drizzle_Water_Plus3, "[SSE] Drizzle Water +3" },                                                                           // Heavy Drops - +3 to <sprite name="[water] drizzle water"> Drizzle Water production. Gain an additional <sprite name="[water] drizzle water"> Drizzle Water every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Fast_Food, "[SSE] Fast Food" },                                                                                            // Salty Breeze - The salty air makes it easier to preserve food. Food production speed is increased by 80% during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Fertile_Nodes, "[SSE] Fertile Nodes" },                                                                                    // Soil Reclamation - The soil becomes saturated with the rain's essence during drizzle season. Resource nodes depleted during the drizzle spawn fertile soil.
		{ SimpleSeasonalEffectTypes.SSE_Food_Consumption, "[SSE] Food Consumption" },                                                                              // Insatiable Hunger - Working in this environment requires a lot of energy. Villagers have a higher chance of consuming twice the amount of food on each break (10% for each Hostility level).
		{ SimpleSeasonalEffectTypes.SSE_Food_Production_Speed_Minus15, "[SSE] Food Production Speed -15" },                                                        // Rot from the Sky - The rain smells like Blightrot... Global food production is slowed by 15% for each Hostility level.
		{ SimpleSeasonalEffectTypes.SSE_FuelRateHostility, "[SSE] FuelRateHostility" },                                                                            // Humid Climate - The humidity in this region is unbearable. Fuel consumption in Hearths is increased by 20% for each Hostility level.
		{ SimpleSeasonalEffectTypes.SSE_Gatherer_Production_Speed_Minus50, "[SSE] Gatherer Production Speed -50" },                                                // Quaking Bog - The ground is moving and swaying from all the rainwater it’s absorbed. Gathering speed is decreased by 50%.
		{ SimpleSeasonalEffectTypes.SSE_Gatherer_Production_Speed_Plus50, "[SSE] Gatherer Production Speed +50" },                                                 // Fruitful Season - The forest's fruits are so ripe, they almost fall into the basket on their own. Gathering speed is increased by 50%.
		{ SimpleSeasonalEffectTypes.SSE_Gift_For_Reputation, "[SSE] Gift for Reputation" },                                                                        // Forgiving Crown - Gain one free cornerstone reroll for every Reputation Point gained during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Gift_From_The_Woods, "[SSE] Gift from the Woods" },                                                                        // Gift from the Woods - These seem to be the ideal conditions in which to create Amber. Gain 5 <sprite name="[valuable] amber"> Amber every drizzle season, plus an additional 5 <sprite name="[valuable] amber"> Amber for each Hostility level reached.
		{ SimpleSeasonalEffectTypes.SSE_Glades_Resolve_In_Drizzle, "[SSE] Glades Resolve in Drizzle" },                                                            // Gentle Dawn - New year, new challenges. Every small glade discovered grants +10% to planting speed during Drizzle. (the bonus is added retroactively)
		{ SimpleSeasonalEffectTypes.SSE_Goods_For_Solved_Relics, "[SSE] Goods for Solved Relics" },                                                                // Forest Offerings - It seems some inhabitants of the forest are grateful for your efforts. During drizzle season, every Dangerous or Forbidden Glade Event you complete will give you 40 random raw food.
		{ SimpleSeasonalEffectTypes.SSE_Grim_Fate, "[SSE] Grim Fate" },                                                                                            // Grim Fate - The forest will claim a villager's life during each storm (multiplied by the number of years that have passed).
		{ SimpleSeasonalEffectTypes.SSE_Hunger_Storm, "[SSE] Hunger Storm" },                                                                                      // Hunger Storm - Missing even a single meal in this harsh climate can be deadly. If villagers don't have anything to eat during a break, they will gain two stacks of the Hunger effect.
		{ SimpleSeasonalEffectTypes.SSE_Lightning, "[SSE] Lightning" },                                                                                            // Devastation - The storm in this region is extremely violent. Once this effect is activated, you'll have to pay 1 <sprite name="[packs] pack of building materials"> Pack of Building Materials (multiplied by the number of years). If you don't, 3 buildings in your settlement will become ruins.
		{ SimpleSeasonalEffectTypes.SSE_Living_Farmfield, "[SSE] Living Farmfield" },                                                                              // Rotten Rain - The rain carries a strange, rotten pollen with it. A Blood Flower will spawn somewhere in the settlement every 90 seconds.
		{ SimpleSeasonalEffectTypes.SSE_Longer_Break_Interval, "[SSE] Longer Break Interval" },                                                                    // Inspiring View - The astonishingly beautiful view motivates villagers to work. The time interval between breaks is increased by +25%.
		{ SimpleSeasonalEffectTypes.SSE_M0_60_Off_Roads_Muddy_Ground, "[SSE] M0_60 Off Roads [Muddy Ground]" },                                                    // Muddy Ground - Villagers' speed off-road is decreased by 30%.
		{ SimpleSeasonalEffectTypes.SSE_Marrow_Mine, "[SSE] Marrow Mine" },                                                                                        // Marrow Growth - Small pockets of bone marrow form in the ground and on trees. Gain 5 <sprite name="[crafting] sea marrow"> Sea Marrow for every 5 <sprite name="[crafting] coal"> Coal produced during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Meat_Plus3, "[SSE] Meat +3" },                                                                                             // Mating Season - +3 to <sprite name="[food raw] meat"> Meat production. Gain an additional <sprite name="[food raw] meat"> Meat every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_Metal_Prod_Penalty, "[SSE] Metal Prod Penalty" },                                                                          // Corrosive Rainfall - Acid rain is slowly eating away at all metal objects. Producing Copper Bars, Crystalized Dew, and all goods that use metal ingots yields 50% fewer goods.
		{ SimpleSeasonalEffectTypes.SSE_Mine_In_Storm, "[SSE] Mine in Storm" },                                                                                    // Horrors from Beneath - Strange voices call out from the depths. Villagers working in Mines get -10 to Resolve during the storm.
		{ SimpleSeasonalEffectTypes.SSE_More_Event_Goods, "[SSE] More event goods" },                                                                              // Scavenging Season - The drizzle in this region is very mild, making it the perfect season for looting. Increases the chance of doubling loot from events solved during the drizzle by 25% (this doesn't apply to perks and blueprints).
		{ SimpleSeasonalEffectTypes.SSE_More_Water_Consumption, "[SSE] More Water Consumption" },                                                                  // Vanishing Water - Infused rainwater slowly evaporates. You lose 1 unit of a random type of water for every 2 units of water used in Rain Engines. 
		{ SimpleSeasonalEffectTypes.SSE_Mushroom_Plus3, "[SSE] Mushroom +3" },                                                                                     // Mushrooms After Rain - +3 to <sprite name="[food raw] mushrooms"> Mushrooms production. Gain an additional <sprite name="[food raw] mushrooms"> Mushrooms every yield (from gathering, farming, fishing, or production).
		{ SimpleSeasonalEffectTypes.SSE_No_Impatience_Reduction, "[SSE] No Impatience Reduction" },                                                                // No contact - Harsh weather conditions make it impossible to reach the Citadel. Gaining Reputation doesn't lower Impatience.
		{ SimpleSeasonalEffectTypes.SSE_Nodes_Bonuses, "[SSE] Nodes Bonuses" },                                                                                    // Untapped Wealth - Gatherers produce twice the amount of secondary resources when harvesting resource nodes.
		{ SimpleSeasonalEffectTypes.SSE_Productive_Farms_In_Drizzle, "[SSE] Productive Farms in Drizzle" },                                                        // Regrowth - Plants seem to grow exceptionally quickly after the storm. All buildings that use fertile soil produce +50% more goods during the drizzle, and all crops planted during the drizzle will yield +50% more when collected during clearance season.
		{ SimpleSeasonalEffectTypes.SSE_Productive_Mine, "[SSE] Productive Mine" },                                                                                // Exposed Resources - The ground is soft, and soaked with the rain's essence. Mines produce 50% more goods during drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_RawDepositsCharges, "[SSE] RawDepositsCharges" },                                                                          // Wild Growth - Small, energizing drops cause uncontrollable growth in certain species. All resource nodes discovered during drizzle season have more charges: +2 to small deposits, and +10 to large deposits.
		{ SimpleSeasonalEffectTypes.SSE_ReputationPenaltyRate_25, "[SSE] ReputationPenaltyRate 25" },                                                              // Important Matters - Impatience grows 70% slower during drizzle season. The Queen seems to be preoccupied with more pressing matters.
		{ SimpleSeasonalEffectTypes.SSE_Resin_For_Wood, "[SSE] Resin For Wood" },                                                                                  // Bleeding Trees - A red, sticky substance is oozing out from beneath the tree bark. Gain 2 <sprite name="[mat raw] resin"> Resin every time woodcutters cut down a tree.
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
		{ SimpleSeasonalEffectTypes.SSE_Storm_Clothes, "[SSE] Storm Clothes" },                                                                                    // Cloudburst - Even the hardiest villagers need some sort of cover in this weather. Once this effect activates, every villager in your settlement will ask you for 1 <sprite name="[needs] coats"> Coats. If you can't provide the goods, Global Resolve will be lowered by -6 for 2 minutes.
		{ SimpleSeasonalEffectTypes.SSE_Trade_Routes_Costs_More_In_Storm, "[SSE] Trade Routes Costs More in Storm" },                                              // Flooded Roads - As a result of heavy rainfall, during the storm, the travel cost of trade routes increases by 2.
		{ SimpleSeasonalEffectTypes.SSE_Trader_Interval_Plus300_Clear_Skies, "[SSE] Trader Interval +300 [Clear Skies]" },                                         // Clear Skies - Increases the speed at which traders arrive by 300%.
		{ SimpleSeasonalEffectTypes.SSE_Unearthly_Element, "[SSE] Unearthly Element" },                                                                            // Unearthly Element - The firekeeper's power weakens in the face of an otherworldly force. The maximum number of sacrifice stacks in the Ancient Hearth is lowered by 1.
		{ SimpleSeasonalEffectTypes.SSE_Vassal_Tax, "[SSE] Vassal Tax" },                                                                                          // Vassal Tax - Due to this region's location, the Crown requires you to pay 5 <sprite name="[valuable] amber"> Amber with each storm (multiplied by the number of years played). If you don't, you will get 1 Impatience point.
		{ SimpleSeasonalEffectTypes.SSE_Weakend_Ancient_Hearth, "[SSE] Weakend Ancient Hearth" },                                                                  // Leakage - The cover of the Ancient Hearth has been damaged due to an exceptionally strong storm. The Hearth's resistance has decreased by 300.
		{ SimpleSeasonalEffectTypes.SSE_Wood_For_Villagers_Payment, "[SSE] Wood for Villagers - Payment" },                                                        // Sacred Flame Rituals - Only the Sacred Flame can protect the settlement from the darkness surrounding it. Pay 3 <sprite name="[mat raw] wood"> Wood for every villager in your settlement. If you don't pay for all of them, 2 people will leave.
		{ SimpleSeasonalEffectTypes.SSE_Woodcuters_Plus10, "[SSE] Woodcuters +10" },                                                                               // Lightweight Wood - The evaporating rainwater has made the wood a lot lighter in this region. Woodcutters can carry 10 more goods in drizzle season.
		{ SimpleSeasonalEffectTypes.SSE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations, "[SSE] Woodcutters Camp Extra Only +100 [Intensive Mutations]" }, // Intensive Mutations - Living organisms in this region are mutated, and much larger than in other places. Doubles the amount of secondary resources gathered from trees.
		{ SimpleSeasonalEffectTypes.SSE_Yearly_Cysts, "[SSE] Yearly Cysts" },                                                                                      // Blight from the Sky - Blightrot seems to grow uncontrollably quickly in this region. Every storm season, 1 Blightrot Cysts appear in the settlement (multiplied by the number of years that have passed).

	};
}
