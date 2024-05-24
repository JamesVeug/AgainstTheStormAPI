using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Goals;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum GoalTypes
{
    Unknown = -1,
    None,
	Deed_Fox_Population,                             // Fox Settlement
	Deed_Harpy_Population,                           // Harpy Settlement
	Deed_Reforge_Seal_Adamantine,                    // The Adamantine Seal
	Deed_Reforge_Seal_Bronze,                        // The Bronze Seal
	Deed_Reforge_Seal_Cobalt,                        // The Cobalt Seal
	Deed_Reforge_Seal_Gold,                          // The Gold Seal
	Deed_Reforge_Seal_Lead,                          // The Lead Seal
	Deed_Reforge_Seal_Platinum,                      // The Platinum Seal
	Deed_Reforge_Seal_Silver,                        // The Silver Seal
	Deed_Reforge_Seal_Titanium,                      // The Titanium Seal
	Deed_Scorpion,                                   // Apprentice Archaeologist 1
	Deed_Snake,                                      // Apprentice Archaeologist 2
	Deed_Spider,                                     // Apprentice Archaeologist 3
	Deed_Spider_Snake_Scorpion,                      // Master Archaeologist
	Deed_Timed_Orders_1,                             // Rushed Delivery 1
	Deed_Timed_Orders_2,                             // Rushed Delivery 2
	Deed_Timed_Orders_3,                             // Rushed Delivery 3
	Deed_Timed_Orders_4,                             // Rushed Delivery 4
	Deed_Timed_Orders_5,                             // Rushed Delivery 5
	Deed_Timed_Orders_6,                             // Rushed Delivery 6
	Deed_Trade_Routes_1,                             // Export Expert 1
	Deed_Trade_Routes_2,                             // Export Expert 2
	Deed_Trade_Routes_3,                             // Export Expert 3
	Deed_Trade_Routes_4,                             // Export Expert 4
	Deed_Trade_Routes_5,                             // Export Expert 5
	Deed_Trade_Routes_6,                             // Export Expert 6
	Deed_Win_Coral_Impossible,                       // The Reef
	Deed_Win_Cursed_Impossible,                      // Thick Clouds
	Deed_Win_Game_Hard,                              // Overcoming Difficulty
	Deed_Win_Game_Impossible,                        // Against All Odds
	Deed_Win_Game_In_3_Years,                        // Homesick 2
	Deed_Win_Game_In_5_Years,                        // Homesick 1
	Deed_Win_Game_Prestige_1,                        // Prestigious Expedition  1
	Deed_Win_Game_Prestige_10,                       // Prestigious Expedition 10
	Deed_Win_Game_Prestige_11,                       // Prestigious Expedition 11
	Deed_Win_Game_Prestige_12,                       // Prestigious Expedition 12
	Deed_Win_Game_Prestige_13,                       // Prestigious Expedition 13
	Deed_Win_Game_Prestige_14,                       // Prestigious Expedition 14
	Deed_Win_Game_Prestige_15,                       // Prestigious Expedition 15
	Deed_Win_Game_Prestige_16,                       // Prestigious Expedition 16
	Deed_Win_Game_Prestige_17,                       // Prestigious Expedition 17
	Deed_Win_Game_Prestige_18,                       // Prestigious Expedition 18
	Deed_Win_Game_Prestige_19,                       // Prestigious Expedition 19
	Deed_Win_Game_Prestige_2,                        // Prestigious Expedition  2
	Deed_Win_Game_Prestige_20,                       // Prestigious Expedition 20
	Deed_Win_Game_Prestige_3,                        // Prestigious Expedition  3
	Deed_Win_Game_Prestige_4,                        // Prestigious Expedition  4
	Deed_Win_Game_Prestige_5,                        // Prestigious Expedition  5
	Deed_Win_Game_Prestige_6,                        // Prestigious Expedition  6
	Deed_Win_Game_Prestige_7,                        // Prestigious Expedition  7
	Deed_Win_Game_Prestige_8,                        // Prestigious Expedition  8
	Deed_Win_Game_Prestige_9,                        // Prestigious Expedition  9
	Deed_Win_Game_Very_Hard,                         // A Real Challenge
	Deed_Win_Game_With_Glades,                       // Thorough Exploration
	Deed_Win_Game_With_Timed_Orders,                 // Like a Machine
	Deed_Win_Game_With_Trade_Routes,                 // Trade Baron
	Deed_Win_Marshlands_Impossible,                  // Deadly Spores
	Deed_Win_Queens_Hand,                            // The Queen's Hand
	Deed_Win_Scarlet_Impossible,                     // Crimson Soil
	Deed_Win_With_Ale_Chain,                         // Serving Ale
	Deed_Win_With_All_Needs,                         // Paradise
	Deed_Win_With_Amber,                             // Trade Connections
	Deed_Win_With_Beavers,                           // Beaver Utopia
	Deed_Win_With_Caches,                            // Treasure
	Deed_Win_With_Dead_Villagers,                    // Devil's Bargain
	Deed_Win_With_Dead_Villagers_Prestige,           // High Price
	Deed_Win_With_Food_Needs,                        // Feeding The People
	Deed_Win_With_Foxes,                             // Fox Utopia
	Deed_Win_With_Harpies,                           // Harpy Utopia
	Deed_Win_With_Humans,                            // Human Utopia
	Deed_Win_With_Lizards,                           // Lizard Utopia
	Deed_Win_With_Many_Events,                       // Efficient Explorer
	Deed_Win_With_Metal_Chain,                       // Refinery
	Deed_Win_With_No_Deaths_Impossible,              // Tempest
	Deed_Win_With_Population_And_Services,           // The Marketplace
	Deed_Win_With_Reputation_Prestige,               // A True Leader
	Deed_Win_With_Ruins,                             // Ruins
	Deed_Win_With_Service_Needs,                     // Higher Needs
	Deed_Win_With_Totems,                            // Totem Hunter
	Deed_Win_Without_Bonus_Impossible,               // Traveling Light
	Deed_Win_Without_Bonus_Prestige,                 // Unnecessary Burden
	Deed_Win_Without_Caches,                         // No Loot Boxes
	Deed_Win_Without_Camps,                          // No Strangers
	Deed_Win_Without_Dangerous_Glades,               // Playing It Safe
	Deed_Win_Without_Glades,                         // Immovable Viceroy
	Deed_Win_Without_Orders_Prestige,                // Independent Viceroy
	Deed_Year_1_Dangerous,                           // Into the Forest
	Deed_Year_1_Forbidden,                           // Outstanding Move
	Deed_Year_2_Forbidden,                           // Stalking Shadows
	Finish_One_Game,                                 // First Steps
	ScalingGoal_Phase0_CompleteOrders,               // Orders From the Queen 1
	ScalingGoal_Phase0_GladeDiscovery,               // Discovery 1
	ScalingGoal_Phase0_TradeGoods,                   // Rolling in Wealth 1
	ScalingGoal_Phase1_CompleteOrders,               // Orders From the Queen 2
	ScalingGoal_Phase1_DistanceFromCitadel,          // Deeper Into the Wilds 1
	ScalingGoal_Phase1_GladeDiscovery,               // Discovery 2
	ScalingGoal_Phase1_ReputationFromResolve,        // Prosperity 1
	ScalingGoal_Phase1_TradeGoods,                   // Rolling in Wealth 2
	ScalingGoal_Phase1_WinWithPopulation,            // Big Settlement 1
	ScalingGoal_Phase2_CompleteOrders,               // Orders From the Queen 3
	ScalingGoal_Phase2_DistanceFromCitadel,          // Deeper Into the Wilds 2
	ScalingGoal_Phase2_GladeDiscovery,               // Discovery 3
	ScalingGoal_Phase2_ReputationFromResolve,        // Prosperity 2
	ScalingGoal_Phase2_TradeGoods,                   // Rolling in Wealth 3
	ScalingGoal_Phase2_WinGameWithRelic,             // Dice With Death 1
	ScalingGoal_Phase3_CompleteOrders,               // Orders From the Queen 4
	ScalingGoal_Phase3_DistanceFromCitadel,          // Deeper Into the Wilds 3
	ScalingGoal_Phase3_GladeDiscovery,               // Discovery 4
	ScalingGoal_Phase3_ReputationFromResolve,        // Prosperity 3
	ScalingGoal_Phase3_TradeGoods,                   // Rolling in Wealth 4
	ScalingGoal_Phase3_WinGameWithRelic,             // Dice With Death 2
	ScalingGoal_Phase3_WinWithPopulation,            // Big Settlement 2
	ScalingGoal_Phase4_CompleteOrders,               // Orders From the Queen 5
	ScalingGoal_Phase4_DistanceFromCitadel,          // Deeper Into the Wilds 4
	ScalingGoal_Phase4_GladeDiscovery,               // Discovery 5
	ScalingGoal_Phase4_ReputationFromResolve,        // Prosperity 4
	ScalingGoal_Phase4_TradeGoods,                   // Rolling in Wealth 5
	ScalingGoal_Phase4_WinGameWithRelic,             // Dice With Death 3
	ScalingGoal_Phase5_CompleteOrders,               // Orders From the Queen 6
	ScalingGoal_Phase5_GladeDiscovery,               // Discovery 6
	ScalingGoal_Phase5_ReputationFromResolve,        // Prosperity 5
	ScalingGoal_Phase5_TradeGoods,                   // Rolling in Wealth 6
	ScalingGoal_Phase5_WinGameWithRelic,             // Dice With Death 4
	TimedGoal_Phase2_WinGames,                       // Fast Colonization
	TimedGoal_Phase3_ReputationFromResolve,          // Prosperous Cycle
	TimedGoal_Phase3_WinGameOnMarshlands,            // Cycle of the Fungi
	TimedGoal_Phase3_WinGamesOnMoorlands,            // Cycle of the Bloodrain
	TimedGoal_Phase4_DistanceFromCitadel,            // Establishing Borders
	TimedGoal_Phase4_GladeDiscovery,                 // Cycle of Discovery
	TimedGoal_Phase4_TradeGoods,                     // Cycle of Wealth
	TimedGoal_Phase4_WinNearBanditCamp,              // Cycle of the Outlaw
	TimedGoal_Phase4_WinNearStonewood,               // Cycle of the Infestation
	TimedGoal_Phase5_DangeroudGladeDiscovery,        // Cycle of the Wilds
	TimedGoal_Phase5_WinNearWeatherAnomaly,          // Cycle of the Storm
	TimedGoal_Phase5_WinWithoutImpatience,           // Cycle of the Queen
	TimedGoal_Phase5_WinWithoutOrders,               // Cycle of Defiance
	TimedGoal_Phase5_WinWithoutVillagerDying,        // Safe Cycle
	Tutorial_Deed_Win_First_Game,                    // First Real Expedition
	Tutorial_Deed_Win_With_Events,                   // Taking Action
	UniqueGoal_Phase1_WinGameNearFertileMeadows,     // Fertile Meadows
	UniqueGoal_Phase1_WinGameNearStonewood,          // Stonewood Infestation
	UniqueGoal_Phase1_WinGames,                      // Third Time's a Charm
	UniqueGoal_Phase1_WinGameWithGrain,              // Swamp Wheat Farmer
	UniqueGoal_Phase1_WinGameWithPaths,              // Basic Logistics
	UniqueGoal_Phase1_WinWithoutImpatience,          // The Patient Queen 1
	UniqueGoal_Phase1_WinWithoutVillagersDying,      // No Deaths
	UniqueGoal_Phase2_WinGameNearBarren,             // Barren Lands
	UniqueGoal_Phase2_WinGameNearRuins,              // Lost Colonies
	UniqueGoal_Phase2_WinGameOnFaction,              // Rivalry 1
	UniqueGoal_Phase2_WinGameOnMarshlands,           // The Marshlands
	UniqueGoal_Phase2_WinGameOnMoorlands,            // The Scarlet Orchard
	UniqueGoal_Phase2_WinGameWithoutOrders,          // Defying the Crown
	UniqueGoal_Phase2_WInGameWithResolve,            // Victory Through Resolve
	UniqueGoal_Phase3_WinGameNearBanditCamp,         // Bandit Camp
	UniqueGoal_Phase3_WinGameOnFaction,              // Rivalry 2
	UniqueGoal_Phase3_WinOnCursedBiome,              // Cursed Lands
	UniqueGoal_Phase3_WinWithBeavers,                // Beaver Settlement
	UniqueGoal_Phase3_WinWithGoods,                  // Ancient Knowledge
	UniqueGoal_Phase3_WinWithHumans,                 // Human Settlement
	UniqueGoal_Phase3_WinWithLizards,                // Lizard Settlement
	UniqueGoal_Phase3_WinWIthRainpunk,               // Rare Technology
	UniqueGoal_Phase3_WinWithSmallFarms,             // Farming Specialization
	UniqueGoal_Phase4_WinNearWeatherAnomaly,         // Weather Anomaly
	UniqueGoal_Phase4_WinOnCoralBiome,               // Coral Forest
	UniqueGoal_Phase4_WinOnCursedBiome,              // Cursed Lands 2
	UniqueGoal_Phase4_WinOnFaction,                  // Rivalry 3
	UniqueGoal_Phase4_WinWithHearths,                // Expansion
	UniqueGoal_Phase4_WinWithMines,                  // Industry
	UniqueGoal_Phase4_WinWithoutImpatience,          // The Patient Queen 2
	UniqueGoal_Phase5_WinOnCursedBiome,              // Cursed Lands 3
	UniqueGoal_Phase5_WinWithBlightrot,              // Blood Flower Farmer
	UniqueGoal_Phase5_WinWithoutImpatience,          // The Patient Queen 3
	UniqueGoal_Phase5_WinWithResolve,                // Victory Through Prosperity
	UniqueGoal_Phase5_WinWithTools,                  // Tool Hoarder
	UniqueGoal_Phase5_WinWithVaults,                 // Ancient Vaults
	WE_Deed_Complete_Trade_Routes_Of_Value_In_Years, // Commenda Contract
	WE_Deed_Win_With_Amber,                          // Bankrupt Trader
	WE_Deed_Win_With_Amber_In_Years,                 // Bankrupt Trader
	WE_Deed_Win_With_Forbidden_Events_Solved,        // Obsidian Loremaster
	WE_Deed_Win_With_Less_Than_3_Dang_Glades,        // Somber Procession
	WE_Deed_Win_With_Villagers_Dying,                // Followers of the Forsaken Gods
	WE_Deed_Win_With_Water,                          // Crashed Airship
	WE_Deed_Win_Without_Leaving,                     // Hanged Viceroy
	WE_Win_With_Hubs,                                // Brass Order Engineers
	Win_Game_With_Modifier___Abandoned_Settlement,   // Abandoned Settlement
	Win_Game_With_Modifier___Altar,                  // Fishmen Ritual Site
	Win_Game_With_Modifier___Armory,                 // Ruined Armory
	Win_Game_With_Modifier___Battleground,           // Ancient Battleground
	Win_Game_With_Modifier___Crystals,               // Sparkdew Crystals
	Win_Game_With_Modifier___Dangerous,              // Dangerous Lands
	Win_Game_With_Modifier___Forbidden,              // Forbidden Lands
	Win_Game_With_Modifier___Frosts,                 // Frosts
	Win_Game_With_Modifier___Gathering_Storm,        // Gathering Storm
	Win_Game_With_Modifier___Haunted,                // Haunted Forest
	Win_Game_With_Modifier___Land_Of_Greed,          // Land of Greed
	Win_Game_With_Modifier___Levitating,             // Levitating Monument
	Win_Game_With_Modifier___Mine,                   // Flooded Mines
	Win_Game_With_Modifier___Monastery,              // Monastery of the Holy Flame
	Win_Game_With_Modifier___Ominous_Presence,       // Ominous Presence
	Win_Game_With_Modifier___Outpost,                // Royal Outpost
	Win_Game_With_Modifier___Overgrown_Library,      // Overgrown Library
	Win_Game_With_Modifier___Petrified_Necropolis,   // Petrified Necropolis
	Win_Game_With_Modifier___Statue,                 // Statue of the Forefathers
	Win_Game_With_Modifier___Temple,                 // Forsaken Gods Temple
	Win_Game_With_Modifier___Torrent,                // Corrosive Torrent
	Win_Game_With_Modifier___Untamed_Wilds,          // Untamed Wilds
	Win_Game_With_Modifier___Watchtower,             // Watchtower

    MAX = 207
}

public static class GoalTypesExtensions
{
	public static string ToName(this GoalTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of GoalTypes: " + type);
		return TypeToInternalName[GoalTypes.Deed_Fox_Population];
	}
	
	public static GoalModel ToGoalModel(this string name)
    {
        GoalModel model = SO.Settings.goals.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find GoalModel for GoalTypes with name: " + name);
        return null;
    }

	public static GoalModel ToGoalModel(this GoalTypes types)
	{
		return types.ToName().ToGoalModel();
	}
	
	public static GoalModel[] ToGoalModelArray(this IEnumerable<GoalTypes> collection)
    {
        int count = collection.Count();
        GoalModel[] array = new GoalModel[count];
        int i = 0;
        foreach (GoalTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.goals.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<GoalTypes, string> TypeToInternalName = new()
	{
		{ GoalTypes.Deed_Fox_Population, "Deed Fox Population" },                                                           // Fox Settlement
		{ GoalTypes.Deed_Harpy_Population, "Deed Harpy Population" },                                                       // Harpy Settlement
		{ GoalTypes.Deed_Reforge_Seal_Adamantine, "Deed Reforge Seal Adamantine" },                                         // The Adamantine Seal
		{ GoalTypes.Deed_Reforge_Seal_Bronze, "Deed Reforge Seal Bronze" },                                                 // The Bronze Seal
		{ GoalTypes.Deed_Reforge_Seal_Cobalt, "Deed Reforge Seal Cobalt" },                                                 // The Cobalt Seal
		{ GoalTypes.Deed_Reforge_Seal_Gold, "Deed Reforge Seal Gold" },                                                     // The Gold Seal
		{ GoalTypes.Deed_Reforge_Seal_Lead, "Deed Reforge Seal Lead" },                                                     // The Lead Seal
		{ GoalTypes.Deed_Reforge_Seal_Platinum, "Deed Reforge Seal Platinum" },                                             // The Platinum Seal
		{ GoalTypes.Deed_Reforge_Seal_Silver, "Deed Reforge Seal Silver" },                                                 // The Silver Seal
		{ GoalTypes.Deed_Reforge_Seal_Titanium, "Deed Reforge Seal Titanium" },                                             // The Titanium Seal
		{ GoalTypes.Deed_Scorpion, "Deed Scorpion" },                                                                       // Apprentice Archaeologist 1
		{ GoalTypes.Deed_Snake, "Deed Snake" },                                                                             // Apprentice Archaeologist 2
		{ GoalTypes.Deed_Spider, "Deed Spider" },                                                                           // Apprentice Archaeologist 3
		{ GoalTypes.Deed_Spider_Snake_Scorpion, "Deed Spider Snake Scorpion" },                                             // Master Archaeologist
		{ GoalTypes.Deed_Timed_Orders_1, "Deed Timed Orders 1" },                                                           // Rushed Delivery 1
		{ GoalTypes.Deed_Timed_Orders_2, "Deed Timed Orders 2" },                                                           // Rushed Delivery 2
		{ GoalTypes.Deed_Timed_Orders_3, "Deed Timed Orders 3" },                                                           // Rushed Delivery 3
		{ GoalTypes.Deed_Timed_Orders_4, "Deed Timed Orders 4" },                                                           // Rushed Delivery 4
		{ GoalTypes.Deed_Timed_Orders_5, "Deed Timed Orders 5" },                                                           // Rushed Delivery 5
		{ GoalTypes.Deed_Timed_Orders_6, "Deed Timed Orders 6" },                                                           // Rushed Delivery 6
		{ GoalTypes.Deed_Trade_Routes_1, "Deed Trade Routes 1" },                                                           // Export Expert 1
		{ GoalTypes.Deed_Trade_Routes_2, "Deed Trade Routes 2" },                                                           // Export Expert 2
		{ GoalTypes.Deed_Trade_Routes_3, "Deed Trade Routes 3" },                                                           // Export Expert 3
		{ GoalTypes.Deed_Trade_Routes_4, "Deed Trade Routes 4" },                                                           // Export Expert 4
		{ GoalTypes.Deed_Trade_Routes_5, "Deed Trade Routes 5" },                                                           // Export Expert 5
		{ GoalTypes.Deed_Trade_Routes_6, "Deed Trade Routes 6" },                                                           // Export Expert 6
		{ GoalTypes.Deed_Win_Coral_Impossible, "Deed Win Coral Impossible" },                                               // The Reef
		{ GoalTypes.Deed_Win_Cursed_Impossible, "Deed Win Cursed Impossible" },                                             // Thick Clouds
		{ GoalTypes.Deed_Win_Game_Hard, "Deed Win Game Hard" },                                                             // Overcoming Difficulty
		{ GoalTypes.Deed_Win_Game_Impossible, "Deed Win Game Impossible" },                                                 // Against All Odds
		{ GoalTypes.Deed_Win_Game_In_3_Years, "Deed Win Game In 3 Years" },                                                 // Homesick 2
		{ GoalTypes.Deed_Win_Game_In_5_Years, "Deed Win Game In 5 Years" },                                                 // Homesick 1
		{ GoalTypes.Deed_Win_Game_Prestige_1, "Deed Win Game Prestige 1" },                                                 // Prestigious Expedition  1
		{ GoalTypes.Deed_Win_Game_Prestige_10, "Deed Win Game Prestige 10" },                                               // Prestigious Expedition 10
		{ GoalTypes.Deed_Win_Game_Prestige_11, "Deed Win Game Prestige 11" },                                               // Prestigious Expedition 11
		{ GoalTypes.Deed_Win_Game_Prestige_12, "Deed Win Game Prestige 12" },                                               // Prestigious Expedition 12
		{ GoalTypes.Deed_Win_Game_Prestige_13, "Deed Win Game Prestige 13" },                                               // Prestigious Expedition 13
		{ GoalTypes.Deed_Win_Game_Prestige_14, "Deed Win Game Prestige 14" },                                               // Prestigious Expedition 14
		{ GoalTypes.Deed_Win_Game_Prestige_15, "Deed Win Game Prestige 15" },                                               // Prestigious Expedition 15
		{ GoalTypes.Deed_Win_Game_Prestige_16, "Deed Win Game Prestige 16" },                                               // Prestigious Expedition 16
		{ GoalTypes.Deed_Win_Game_Prestige_17, "Deed Win Game Prestige 17" },                                               // Prestigious Expedition 17
		{ GoalTypes.Deed_Win_Game_Prestige_18, "Deed Win Game Prestige 18" },                                               // Prestigious Expedition 18
		{ GoalTypes.Deed_Win_Game_Prestige_19, "Deed Win Game Prestige 19" },                                               // Prestigious Expedition 19
		{ GoalTypes.Deed_Win_Game_Prestige_2, "Deed Win Game Prestige 2" },                                                 // Prestigious Expedition  2
		{ GoalTypes.Deed_Win_Game_Prestige_20, "Deed Win Game Prestige 20" },                                               // Prestigious Expedition 20
		{ GoalTypes.Deed_Win_Game_Prestige_3, "Deed Win Game Prestige 3" },                                                 // Prestigious Expedition  3
		{ GoalTypes.Deed_Win_Game_Prestige_4, "Deed Win Game Prestige 4" },                                                 // Prestigious Expedition  4
		{ GoalTypes.Deed_Win_Game_Prestige_5, "Deed Win Game Prestige 5" },                                                 // Prestigious Expedition  5
		{ GoalTypes.Deed_Win_Game_Prestige_6, "Deed Win Game Prestige 6" },                                                 // Prestigious Expedition  6
		{ GoalTypes.Deed_Win_Game_Prestige_7, "Deed Win Game Prestige 7" },                                                 // Prestigious Expedition  7
		{ GoalTypes.Deed_Win_Game_Prestige_8, "Deed Win Game Prestige 8" },                                                 // Prestigious Expedition  8
		{ GoalTypes.Deed_Win_Game_Prestige_9, "Deed Win Game Prestige 9" },                                                 // Prestigious Expedition  9
		{ GoalTypes.Deed_Win_Game_Very_Hard, "Deed Win Game Very Hard" },                                                   // A Real Challenge
		{ GoalTypes.Deed_Win_Game_With_Glades, "Deed Win Game With Glades" },                                               // Thorough Exploration
		{ GoalTypes.Deed_Win_Game_With_Timed_Orders, "Deed Win Game With Timed Orders" },                                   // Like a Machine
		{ GoalTypes.Deed_Win_Game_With_Trade_Routes, "Deed Win Game With Trade Routes" },                                   // Trade Baron
		{ GoalTypes.Deed_Win_Marshlands_Impossible, "Deed Win Marshlands Impossible" },                                     // Deadly Spores
		{ GoalTypes.Deed_Win_Queens_Hand, "Deed Win Queens Hand" },                                                         // The Queen's Hand
		{ GoalTypes.Deed_Win_Scarlet_Impossible, "Deed Win Scarlet Impossible" },                                           // Crimson Soil
		{ GoalTypes.Deed_Win_With_Ale_Chain, "Deed Win With Ale Chain" },                                                   // Serving Ale
		{ GoalTypes.Deed_Win_With_All_Needs, "Deed Win With All Needs" },                                                   // Paradise
		{ GoalTypes.Deed_Win_With_Amber, "Deed Win With Amber" },                                                           // Trade Connections
		{ GoalTypes.Deed_Win_With_Beavers, "Deed Win With Beavers" },                                                       // Beaver Utopia
		{ GoalTypes.Deed_Win_With_Caches, "Deed Win With Caches" },                                                         // Treasure
		{ GoalTypes.Deed_Win_With_Dead_Villagers, "Deed Win With Dead Villagers" },                                         // Devil's Bargain
		{ GoalTypes.Deed_Win_With_Dead_Villagers_Prestige, "Deed Win With Dead Villagers Prestige" },                       // High Price
		{ GoalTypes.Deed_Win_With_Food_Needs, "Deed Win With Food Needs" },                                                 // Feeding The People
		{ GoalTypes.Deed_Win_With_Foxes, "Deed Win With Foxes" },                                                           // Fox Utopia
		{ GoalTypes.Deed_Win_With_Harpies, "Deed Win With Harpies" },                                                       // Harpy Utopia
		{ GoalTypes.Deed_Win_With_Humans, "Deed Win With Humans" },                                                         // Human Utopia
		{ GoalTypes.Deed_Win_With_Lizards, "Deed Win With Lizards" },                                                       // Lizard Utopia
		{ GoalTypes.Deed_Win_With_Many_Events, "Deed Win With Many Events" },                                               // Efficient Explorer
		{ GoalTypes.Deed_Win_With_Metal_Chain, "Deed Win With Metal Chain" },                                               // Refinery
		{ GoalTypes.Deed_Win_With_No_Deaths_Impossible, "Deed Win With No Deaths Impossible" },                             // Tempest
		{ GoalTypes.Deed_Win_With_Population_And_Services, "Deed Win With Population And Services" },                       // The Marketplace
		{ GoalTypes.Deed_Win_With_Reputation_Prestige, "Deed Win With Reputation Prestige" },                               // A True Leader
		{ GoalTypes.Deed_Win_With_Ruins, "Deed Win With Ruins" },                                                           // Ruins
		{ GoalTypes.Deed_Win_With_Service_Needs, "Deed Win With Service Needs" },                                           // Higher Needs
		{ GoalTypes.Deed_Win_With_Totems, "Deed Win With Totems" },                                                         // Totem Hunter
		{ GoalTypes.Deed_Win_Without_Bonus_Impossible, "Deed Win Without Bonus Impossible" },                               // Traveling Light
		{ GoalTypes.Deed_Win_Without_Bonus_Prestige, "Deed Win Without Bonus Prestige" },                                   // Unnecessary Burden
		{ GoalTypes.Deed_Win_Without_Caches, "Deed Win Without Caches" },                                                   // No Loot Boxes
		{ GoalTypes.Deed_Win_Without_Camps, "Deed Win Without Camps" },                                                     // No Strangers
		{ GoalTypes.Deed_Win_Without_Dangerous_Glades, "Deed Win Without Dangerous Glades" },                               // Playing It Safe
		{ GoalTypes.Deed_Win_Without_Glades, "Deed Win Without Glades" },                                                   // Immovable Viceroy
		{ GoalTypes.Deed_Win_Without_Orders_Prestige, "Deed Win Without Orders Prestige" },                                 // Independent Viceroy
		{ GoalTypes.Deed_Year_1_Dangerous, "Deed Year 1 Dangerous" },                                                       // Into the Forest
		{ GoalTypes.Deed_Year_1_Forbidden, "Deed Year 1 Forbidden" },                                                       // Outstanding Move
		{ GoalTypes.Deed_Year_2_Forbidden, "Deed Year 2 Forbidden" },                                                       // Stalking Shadows
		{ GoalTypes.Finish_One_Game, "Finish One Game" },                                                                   // First Steps
		{ GoalTypes.ScalingGoal_Phase0_CompleteOrders, "ScalingGoal_Phase0_CompleteOrders" },                               // Orders From the Queen 1
		{ GoalTypes.ScalingGoal_Phase0_GladeDiscovery, "ScalingGoal_Phase0_GladeDiscovery" },                               // Discovery 1
		{ GoalTypes.ScalingGoal_Phase0_TradeGoods, "ScalingGoal_Phase0_TradeGoods" },                                       // Rolling in Wealth 1
		{ GoalTypes.ScalingGoal_Phase1_CompleteOrders, "ScalingGoal_Phase1_CompleteOrders" },                               // Orders From the Queen 2
		{ GoalTypes.ScalingGoal_Phase1_DistanceFromCitadel, "ScalingGoal_Phase1_DistanceFromCitadel" },                     // Deeper Into the Wilds 1
		{ GoalTypes.ScalingGoal_Phase1_GladeDiscovery, "ScalingGoal_Phase1_GladeDiscovery" },                               // Discovery 2
		{ GoalTypes.ScalingGoal_Phase1_ReputationFromResolve, "ScalingGoal_Phase1_ReputationFromResolve" },                 // Prosperity 1
		{ GoalTypes.ScalingGoal_Phase1_TradeGoods, "ScalingGoal_Phase1_TradeGoods" },                                       // Rolling in Wealth 2
		{ GoalTypes.ScalingGoal_Phase1_WinWithPopulation, "ScalingGoal_Phase1_WinWithPopulation" },                         // Big Settlement 1
		{ GoalTypes.ScalingGoal_Phase2_CompleteOrders, "ScalingGoal_Phase2_CompleteOrders" },                               // Orders From the Queen 3
		{ GoalTypes.ScalingGoal_Phase2_DistanceFromCitadel, "ScalingGoal_Phase2_DistanceFromCitadel" },                     // Deeper Into the Wilds 2
		{ GoalTypes.ScalingGoal_Phase2_GladeDiscovery, "ScalingGoal_Phase2_GladeDiscovery" },                               // Discovery 3
		{ GoalTypes.ScalingGoal_Phase2_ReputationFromResolve, "ScalingGoal_Phase2_ReputationFromResolve" },                 // Prosperity 2
		{ GoalTypes.ScalingGoal_Phase2_TradeGoods, "ScalingGoal_Phase2_TradeGoods" },                                       // Rolling in Wealth 3
		{ GoalTypes.ScalingGoal_Phase2_WinGameWithRelic, "ScalingGoal_Phase2_WinGameWithRelic" },                           // Dice With Death 1
		{ GoalTypes.ScalingGoal_Phase3_CompleteOrders, "ScalingGoal_Phase3_CompleteOrders" },                               // Orders From the Queen 4
		{ GoalTypes.ScalingGoal_Phase3_DistanceFromCitadel, "ScalingGoal_Phase3_DistanceFromCitadel" },                     // Deeper Into the Wilds 3
		{ GoalTypes.ScalingGoal_Phase3_GladeDiscovery, "ScalingGoal_Phase3_GladeDiscovery" },                               // Discovery 4
		{ GoalTypes.ScalingGoal_Phase3_ReputationFromResolve, "ScalingGoal_Phase3_ReputationFromResolve" },                 // Prosperity 3
		{ GoalTypes.ScalingGoal_Phase3_TradeGoods, "ScalingGoal_Phase3_TradeGoods" },                                       // Rolling in Wealth 4
		{ GoalTypes.ScalingGoal_Phase3_WinGameWithRelic, "ScalingGoal_Phase3_WinGameWithRelic" },                           // Dice With Death 2
		{ GoalTypes.ScalingGoal_Phase3_WinWithPopulation, "ScalingGoal_Phase3_WinWithPopulation" },                         // Big Settlement 2
		{ GoalTypes.ScalingGoal_Phase4_CompleteOrders, "ScalingGoal_Phase4_CompleteOrders" },                               // Orders From the Queen 5
		{ GoalTypes.ScalingGoal_Phase4_DistanceFromCitadel, "ScalingGoal_Phase4_DistanceFromCitadel" },                     // Deeper Into the Wilds 4
		{ GoalTypes.ScalingGoal_Phase4_GladeDiscovery, "ScalingGoal_Phase4_GladeDiscovery" },                               // Discovery 5
		{ GoalTypes.ScalingGoal_Phase4_ReputationFromResolve, "ScalingGoal_Phase4_ReputationFromResolve" },                 // Prosperity 4
		{ GoalTypes.ScalingGoal_Phase4_TradeGoods, "ScalingGoal_Phase4_TradeGoods" },                                       // Rolling in Wealth 5
		{ GoalTypes.ScalingGoal_Phase4_WinGameWithRelic, "ScalingGoal_Phase4_WinGameWithRelic" },                           // Dice With Death 3
		{ GoalTypes.ScalingGoal_Phase5_CompleteOrders, "ScalingGoal_Phase5_CompleteOrders" },                               // Orders From the Queen 6
		{ GoalTypes.ScalingGoal_Phase5_GladeDiscovery, "ScalingGoal_Phase5_GladeDiscovery" },                               // Discovery 6
		{ GoalTypes.ScalingGoal_Phase5_ReputationFromResolve, "ScalingGoal_Phase5_ReputationFromResolve" },                 // Prosperity 5
		{ GoalTypes.ScalingGoal_Phase5_TradeGoods, "ScalingGoal_Phase5_TradeGoods" },                                       // Rolling in Wealth 6
		{ GoalTypes.ScalingGoal_Phase5_WinGameWithRelic, "ScalingGoal_Phase5_WinGameWithRelic" },                           // Dice With Death 4
		{ GoalTypes.TimedGoal_Phase2_WinGames, "TimedGoal_Phase2_WinGames" },                                               // Fast Colonization
		{ GoalTypes.TimedGoal_Phase3_ReputationFromResolve, "TimedGoal_Phase3_ReputationFromResolve" },                     // Prosperous Cycle
		{ GoalTypes.TimedGoal_Phase3_WinGameOnMarshlands, "TimedGoal_Phase3_WinGameOnMarshlands" },                         // Cycle of the Fungi
		{ GoalTypes.TimedGoal_Phase3_WinGamesOnMoorlands, "TimedGoal_Phase3_WinGamesOnMoorlands" },                         // Cycle of the Bloodrain
		{ GoalTypes.TimedGoal_Phase4_DistanceFromCitadel, "TimedGoal_Phase4_DistanceFromCitadel" },                         // Establishing Borders
		{ GoalTypes.TimedGoal_Phase4_GladeDiscovery, "TimedGoal_Phase4_GladeDiscovery" },                                   // Cycle of Discovery
		{ GoalTypes.TimedGoal_Phase4_TradeGoods, "TimedGoal_Phase4_TradeGoods" },                                           // Cycle of Wealth
		{ GoalTypes.TimedGoal_Phase4_WinNearBanditCamp, "TimedGoal_Phase4_WinNearBanditCamp" },                             // Cycle of the Outlaw
		{ GoalTypes.TimedGoal_Phase4_WinNearStonewood, "TimedGoal_Phase4_WinNearStonewood" },                               // Cycle of the Infestation
		{ GoalTypes.TimedGoal_Phase5_DangeroudGladeDiscovery, "TimedGoal_Phase5_DangeroudGladeDiscovery" },                 // Cycle of the Wilds
		{ GoalTypes.TimedGoal_Phase5_WinNearWeatherAnomaly, "TimedGoal_Phase5_WinNearWeatherAnomaly" },                     // Cycle of the Storm
		{ GoalTypes.TimedGoal_Phase5_WinWithoutImpatience, "TimedGoal_Phase5_WinWithoutImpatience" },                       // Cycle of the Queen
		{ GoalTypes.TimedGoal_Phase5_WinWithoutOrders, "TimedGoal_Phase5_WinWithoutOrders" },                               // Cycle of Defiance
		{ GoalTypes.TimedGoal_Phase5_WinWithoutVillagerDying, "TimedGoal_Phase5_WinWithoutVillagerDying" },                 // Safe Cycle
		{ GoalTypes.Tutorial_Deed_Win_First_Game, "Tutorial Deed Win First Game" },                                         // First Real Expedition
		{ GoalTypes.Tutorial_Deed_Win_With_Events, "Tutorial Deed Win With Events" },                                       // Taking Action
		{ GoalTypes.UniqueGoal_Phase1_WinGameNearFertileMeadows, "UniqueGoal_Phase1_WinGameNearFertileMeadows" },           // Fertile Meadows
		{ GoalTypes.UniqueGoal_Phase1_WinGameNearStonewood, "UniqueGoal_Phase1_WinGameNearStonewood" },                     // Stonewood Infestation
		{ GoalTypes.UniqueGoal_Phase1_WinGames, "UniqueGoal_Phase1_WinGames" },                                             // Third Time's a Charm
		{ GoalTypes.UniqueGoal_Phase1_WinGameWithGrain, "UniqueGoal_Phase1_WinGameWithGrain" },                             // Swamp Wheat Farmer
		{ GoalTypes.UniqueGoal_Phase1_WinGameWithPaths, "UniqueGoal_Phase1_WinGameWithPaths" },                             // Basic Logistics
		{ GoalTypes.UniqueGoal_Phase1_WinWithoutImpatience, "UniqueGoal_Phase1_WinWithoutImpatience" },                     // The Patient Queen 1
		{ GoalTypes.UniqueGoal_Phase1_WinWithoutVillagersDying, "UniqueGoal_Phase1_WinWithoutVillagersDying" },             // No Deaths
		{ GoalTypes.UniqueGoal_Phase2_WinGameNearBarren, "UniqueGoal_Phase2_WinGameNearBarren" },                           // Barren Lands
		{ GoalTypes.UniqueGoal_Phase2_WinGameNearRuins, "UniqueGoal_Phase2_WinGameNearRuins" },                             // Lost Colonies
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnFaction, "UniqueGoal_Phase2_WinGameOnFaction" },                             // Rivalry 1
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnMarshlands, "UniqueGoal_Phase2_WinGameOnMarshlands" },                       // The Marshlands
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnMoorlands, "UniqueGoal_Phase2_WinGameOnMoorlands" },                         // The Scarlet Orchard
		{ GoalTypes.UniqueGoal_Phase2_WinGameWithoutOrders, "UniqueGoal_Phase2_WinGameWithoutOrders" },                     // Defying the Crown
		{ GoalTypes.UniqueGoal_Phase2_WInGameWithResolve, "UniqueGoal_Phase2_WInGameWithResolve" },                         // Victory Through Resolve
		{ GoalTypes.UniqueGoal_Phase3_WinGameNearBanditCamp, "UniqueGoal_Phase3_WinGameNearBanditCamp" },                   // Bandit Camp
		{ GoalTypes.UniqueGoal_Phase3_WinGameOnFaction, "UniqueGoal_Phase3_WinGameOnFaction" },                             // Rivalry 2
		{ GoalTypes.UniqueGoal_Phase3_WinOnCursedBiome, "UniqueGoal_Phase3_WinOnCursedBiome" },                             // Cursed Lands
		{ GoalTypes.UniqueGoal_Phase3_WinWithBeavers, "UniqueGoal_Phase3_WinWithBeavers" },                                 // Beaver Settlement
		{ GoalTypes.UniqueGoal_Phase3_WinWithGoods, "UniqueGoal_Phase3_WinWithGoods" },                                     // Ancient Knowledge
		{ GoalTypes.UniqueGoal_Phase3_WinWithHumans, "UniqueGoal_Phase3_WinWithHumans" },                                   // Human Settlement
		{ GoalTypes.UniqueGoal_Phase3_WinWithLizards, "UniqueGoal_Phase3_WinWithLizards" },                                 // Lizard Settlement
		{ GoalTypes.UniqueGoal_Phase3_WinWIthRainpunk, "UniqueGoal_Phase3_WinWIthRainpunk" },                               // Rare Technology
		{ GoalTypes.UniqueGoal_Phase3_WinWithSmallFarms, "UniqueGoal_Phase3_WinWithSmallFarms" },                           // Farming Specialization
		{ GoalTypes.UniqueGoal_Phase4_WinNearWeatherAnomaly, "UniqueGoal_Phase4_WinNearWeatherAnomaly" },                   // Weather Anomaly
		{ GoalTypes.UniqueGoal_Phase4_WinOnCoralBiome, "UniqueGoal_Phase4_WinOnCoralBiome" },                               // Coral Forest
		{ GoalTypes.UniqueGoal_Phase4_WinOnCursedBiome, "UniqueGoal_Phase4_WinOnCursedBiome" },                             // Cursed Lands 2
		{ GoalTypes.UniqueGoal_Phase4_WinOnFaction, "UniqueGoal_Phase4_WinOnFaction" },                                     // Rivalry 3
		{ GoalTypes.UniqueGoal_Phase4_WinWithHearths, "UniqueGoal_Phase4_WinWithHearths" },                                 // Expansion
		{ GoalTypes.UniqueGoal_Phase4_WinWithMines, "UniqueGoal_Phase4_WinWithMines" },                                     // Industry
		{ GoalTypes.UniqueGoal_Phase4_WinWithoutImpatience, "UniqueGoal_Phase4_WinWithoutImpatience" },                     // The Patient Queen 2
		{ GoalTypes.UniqueGoal_Phase5_WinOnCursedBiome, "UniqueGoal_Phase5_WinOnCursedBiome" },                             // Cursed Lands 3
		{ GoalTypes.UniqueGoal_Phase5_WinWithBlightrot, "UniqueGoal_Phase5_WinWithBlightrot" },                             // Blood Flower Farmer
		{ GoalTypes.UniqueGoal_Phase5_WinWithoutImpatience, "UniqueGoal_Phase5_WinWithoutImpatience" },                     // The Patient Queen 3
		{ GoalTypes.UniqueGoal_Phase5_WinWithResolve, "UniqueGoal_Phase5_WinWithResolve" },                                 // Victory Through Prosperity
		{ GoalTypes.UniqueGoal_Phase5_WinWithTools, "UniqueGoal_Phase5_WinWithTools" },                                     // Tool Hoarder
		{ GoalTypes.UniqueGoal_Phase5_WinWithVaults, "UniqueGoal_Phase5_WinWithVaults" },                                   // Ancient Vaults
		{ GoalTypes.WE_Deed_Complete_Trade_Routes_Of_Value_In_Years, "[WE] Deed Complete Trade Routes Of Value In Years" }, // Commenda Contract
		{ GoalTypes.WE_Deed_Win_With_Amber, "[WE] Deed Win With Amber" },                                                   // Bankrupt Trader
		{ GoalTypes.WE_Deed_Win_With_Amber_In_Years, "[WE] Deed Win With Amber In Years" },                                 // Bankrupt Trader
		{ GoalTypes.WE_Deed_Win_With_Forbidden_Events_Solved, "[WE] Deed Win With Forbidden Events Solved" },               // Obsidian Loremaster
		{ GoalTypes.WE_Deed_Win_With_Less_Than_3_Dang_Glades, "[WE] Deed Win With Less Than 3 Dang Glades" },               // Somber Procession
		{ GoalTypes.WE_Deed_Win_With_Villagers_Dying, "[WE] Deed Win With Villagers Dying" },                               // Followers of the Forsaken Gods
		{ GoalTypes.WE_Deed_Win_With_Water, "[WE] Deed Win With Water" },                                                   // Crashed Airship
		{ GoalTypes.WE_Deed_Win_Without_Leaving, "[WE] Deed Win Without Leaving" },                                         // Hanged Viceroy
		{ GoalTypes.WE_Win_With_Hubs, "[WE] Win With Hubs" },                                                               // Brass Order Engineers
		{ GoalTypes.Win_Game_With_Modifier___Abandoned_Settlement, "Win Game With Modifier - Abandoned Settlement" },       // Abandoned Settlement
		{ GoalTypes.Win_Game_With_Modifier___Altar, "Win Game With Modifier - Altar" },                                     // Fishmen Ritual Site
		{ GoalTypes.Win_Game_With_Modifier___Armory, "Win Game With Modifier - Armory" },                                   // Ruined Armory
		{ GoalTypes.Win_Game_With_Modifier___Battleground, "Win Game With Modifier - Battleground" },                       // Ancient Battleground
		{ GoalTypes.Win_Game_With_Modifier___Crystals, "Win Game With Modifier - Crystals" },                               // Sparkdew Crystals
		{ GoalTypes.Win_Game_With_Modifier___Dangerous, "Win Game With Modifier - Dangerous" },                             // Dangerous Lands
		{ GoalTypes.Win_Game_With_Modifier___Forbidden, "Win Game With Modifier - Forbidden" },                             // Forbidden Lands
		{ GoalTypes.Win_Game_With_Modifier___Frosts, "Win Game With Modifier - Frosts" },                                   // Frosts
		{ GoalTypes.Win_Game_With_Modifier___Gathering_Storm, "Win Game With Modifier - Gathering Storm" },                 // Gathering Storm
		{ GoalTypes.Win_Game_With_Modifier___Haunted, "Win Game With Modifier - Haunted" },                                 // Haunted Forest
		{ GoalTypes.Win_Game_With_Modifier___Land_Of_Greed, "Win Game With Modifier - Land Of Greed" },                     // Land of Greed
		{ GoalTypes.Win_Game_With_Modifier___Levitating, "Win Game With Modifier - Levitating" },                           // Levitating Monument
		{ GoalTypes.Win_Game_With_Modifier___Mine, "Win Game With Modifier - Mine" },                                       // Flooded Mines
		{ GoalTypes.Win_Game_With_Modifier___Monastery, "Win Game With Modifier - Monastery" },                             // Monastery of the Holy Flame
		{ GoalTypes.Win_Game_With_Modifier___Ominous_Presence, "Win Game With Modifier - Ominous Presence" },               // Ominous Presence
		{ GoalTypes.Win_Game_With_Modifier___Outpost, "Win Game With Modifier - Outpost" },                                 // Royal Outpost
		{ GoalTypes.Win_Game_With_Modifier___Overgrown_Library, "Win Game With Modifier - Overgrown Library" },             // Overgrown Library
		{ GoalTypes.Win_Game_With_Modifier___Petrified_Necropolis, "Win Game With Modifier - Petrified Necropolis" },       // Petrified Necropolis
		{ GoalTypes.Win_Game_With_Modifier___Statue, "Win Game With Modifier - Statue" },                                   // Statue of the Forefathers
		{ GoalTypes.Win_Game_With_Modifier___Temple, "Win Game With Modifier - Temple" },                                   // Forsaken Gods Temple
		{ GoalTypes.Win_Game_With_Modifier___Torrent, "Win Game With Modifier - Torrent" },                                 // Corrosive Torrent
		{ GoalTypes.Win_Game_With_Modifier___Untamed_Wilds, "Win Game With Modifier - Untamed Wilds" },                     // Untamed Wilds
		{ GoalTypes.Win_Game_With_Modifier___Watchtower, "Win Game With Modifier - Watchtower" },                           // Watchtower
	};
}
