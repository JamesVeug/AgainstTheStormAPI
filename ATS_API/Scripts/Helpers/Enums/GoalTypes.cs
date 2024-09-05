using System;
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
	Deed_Fox_Population,                             // Fox Settlement - Win a game with at least 25 Foxes.
	Deed_Harpy_Population,                           // Harpy Settlement - Win a game with at least 25 Harpies.
	Deed_Reforge_Seal_Adamantine,                    // The Adamantine Seal - Reforge the Adamantine Seal.
	Deed_Reforge_Seal_Bronze,                        // The Bronze Seal - Reforge the Bronze Seal.
	Deed_Reforge_Seal_Cobalt,                        // The Cobalt Seal - Reforge the Cobalt Seal.
	Deed_Reforge_Seal_Gold,                          // The Gold Seal - Reforge the Gold Seal.
	Deed_Reforge_Seal_Lead,                          // The Lead Seal - Reforge the Lead Seal.
	Deed_Reforge_Seal_Platinum,                      // The Platinum Seal - Reforge the Platinum Seal.
	Deed_Reforge_Seal_Silver,                        // The Silver Seal - Reforge the Silver Seal.
	Deed_Reforge_Seal_Titanium,                      // The Titanium Seal - Reforge the Titanium Seal.
	Deed_Scorpion,                                   // Apprentice Archaeologist 1 - Win a game with a reconstructed Smoldering Scorpion skeleton in the Scarlet Orchard.
	Deed_Snake,                                      // Apprentice Archaeologist 2 - Win a game with a reconstructed Sea Serpent skeleton in the Scarlet Orchard.
	Deed_Spider,                                     // Apprentice Archaeologist 3 - Win a game with a reconstructed Sealed Spider skeleton in the Scarlet Orchard.
	Deed_Spider_Snake_Scorpion,                      // Master Archaeologist - Win a game with all three skeletons reconstructed in the Scarlet Orchard.
	Deed_Timed_Orders_1,                             // Rushed Delivery 1 - Complete 5 timed orders.
	Deed_Timed_Orders_2,                             // Rushed Delivery 2 - Complete 15 timed orders.
	Deed_Timed_Orders_3,                             // Rushed Delivery 3 - Complete 30 timed orders.
	Deed_Timed_Orders_4,                             // Rushed Delivery 4 - Complete 50 timed orders.
	Deed_Timed_Orders_5,                             // Rushed Delivery 5 - Complete 75 timed orders.
	Deed_Timed_Orders_6,                             // Rushed Delivery 6 - Complete 100 timed orders.
	Deed_Trade_Routes_1,                             // Export Expert 1 - Complete 10 trade routes.
	Deed_Trade_Routes_2,                             // Export Expert 2 - Complete 30 trade routes.
	Deed_Trade_Routes_3,                             // Export Expert 3 - Complete 80 trade routes.
	Deed_Trade_Routes_4,                             // Export Expert 4 - Complete 150 trade routes.
	Deed_Trade_Routes_5,                             // Export Expert 5 - Complete 250 trade routes.
	Deed_Trade_Routes_6,                             // Export Expert 6 - Complete 400 trade routes.
	Deed_Win_Coral_Impossible,                       // The Reef - Win a game in the Coral Forest biome, and on Viceroy difficulty (or higher).
	Deed_Win_Cursed_Impossible,                      // Thick Clouds - Win a game in the Cursed Royal Woodlands biome, and on Viceroy difficulty (or higher).
	Deed_Win_Game_Hard,                              // Overcoming Difficulty - Win a game on Pioneer difficulty (or higher).
	Deed_Win_Game_Impossible,                        // Against All Odds - Win a game on Viceroy difficulty (or higher).
	Deed_Win_Game_In_3_Years,                        // Homesick 2 - Win a game in 3 years or less.
	Deed_Win_Game_In_5_Years,                        // Homesick 1 - Win a game in 5 years or less.
	Deed_Win_Game_Prestige_1,                        // Prestigious Expedition  1 - Win a game on Prestige 1 difficulty (or higher).
	Deed_Win_Game_Prestige_10,                       // Prestigious Expedition 10 - Win a game on Prestige 10 difficulty (or higher).
	Deed_Win_Game_Prestige_11,                       // Prestigious Expedition 11 - Win a game on Prestige 11 difficulty (or higher).
	Deed_Win_Game_Prestige_12,                       // Prestigious Expedition 12 - Win a game on Prestige 12 difficulty (or higher).
	Deed_Win_Game_Prestige_13,                       // Prestigious Expedition 13 - Win a game on Prestige 13 difficulty (or higher).
	Deed_Win_Game_Prestige_14,                       // Prestigious Expedition 14 - Win a game on Prestige 14 difficulty (or higher).
	Deed_Win_Game_Prestige_15,                       // Prestigious Expedition 15 - Win a game on Prestige 15 difficulty (or higher).
	Deed_Win_Game_Prestige_16,                       // Prestigious Expedition 16 - Win a game on Prestige 16 difficulty (or higher).
	Deed_Win_Game_Prestige_17,                       // Prestigious Expedition 17 - Win a game on Prestige 17 difficulty (or higher).
	Deed_Win_Game_Prestige_18,                       // Prestigious Expedition 18 - Win a game on Prestige 18 difficulty (or higher).
	Deed_Win_Game_Prestige_19,                       // Prestigious Expedition 19 - Win a game on Prestige 19 difficulty (or higher).
	Deed_Win_Game_Prestige_2,                        // Prestigious Expedition  2 - Win a game on Prestige 2 difficulty (or higher).
	Deed_Win_Game_Prestige_20,                       // Prestigious Expedition 20 - Win a game on Prestige 20 difficulty (or higher).
	Deed_Win_Game_Prestige_3,                        // Prestigious Expedition  3 - Win a game on Prestige 3 difficulty (or higher).
	Deed_Win_Game_Prestige_4,                        // Prestigious Expedition  4 - Win a game on Prestige 4 difficulty (or higher).
	Deed_Win_Game_Prestige_5,                        // Prestigious Expedition  5 - Win a game on Prestige 5 difficulty (or higher).
	Deed_Win_Game_Prestige_6,                        // Prestigious Expedition  6 - Win a game on Prestige 6 difficulty (or higher).
	Deed_Win_Game_Prestige_7,                        // Prestigious Expedition  7 - Win a game on Prestige 7 difficulty (or higher).
	Deed_Win_Game_Prestige_8,                        // Prestigious Expedition  8 - Win a game on Prestige 8 difficulty (or higher).
	Deed_Win_Game_Prestige_9,                        // Prestigious Expedition  9 - Win a game on Prestige 9 difficulty (or higher).
	Deed_Win_Game_Very_Hard,                         // A Real Challenge - Win a game on Veteran difficulty (or higher).
	Deed_Win_Game_With_Glades,                       // Thorough Exploration - Win a game with 30 or more glades discovered, on Pioneer difficulty (or higher).
	Deed_Win_Game_With_Timed_Orders,                 // Like a Machine - Win a game after completing 3 timed orders.
	Deed_Win_Game_With_Trade_Routes,                 // Trade Baron - Win a game after completing 20 trade routes.
	Deed_Win_Marshlands_Impossible,                  // Deadly Spores - Win a game in the The Marshlands biome, and on Viceroy difficulty (or higher).
	Deed_Win_Queens_Hand,                            // The Queen's Hand - Complete the Queen's Hand Trial.
	Deed_Win_Scarlet_Impossible,                     // Crimson Soil - Win a game in the Scarlet Orchard biome, and on Viceroy difficulty (or higher).
	Deed_Win_With_Ale_Chain,                         // Serving Ale - Win with: 1 x Small Farm, 1 x Brewery, 1 x Tavern, on the difficulty: Veteran.
	Deed_Win_With_All_Needs,                         // Paradise - Ensure all villagers have all their needs fulfilled simultaneously.
	Deed_Win_With_Amber,                             // Trade Connections - Win a game with 400 Amber in your Warehouse.
	Deed_Win_With_Beavers,                           // Beaver Utopia - Win a game with 30 Beavers, 15 x Beaver House, 1 x Guild House
	Deed_Win_With_Caches,                            // Treasure - Win a game after opening or sending 20 Abandoned Caches to the Citadel.
	Deed_Win_With_Dead_Villagers,                    // Devil's Bargain - Win a game after 20 villagers have died.
	Deed_Win_With_Dead_Villagers_Prestige,           // High Price - Win a game after 15 villagers died, on Prestige 18 difficulty (or higher).
	Deed_Win_With_Food_Needs,                        // Feeding The People - Ensure all villagers have all their Complex Food needs fulfilled simultaneously.
	Deed_Win_With_Foxes,                             // Fox Utopia - Win a game with 30 Foxes, 15 x Fox House, 1 x Tea Doctor
	Deed_Win_With_Harpies,                           // Harpy Utopia - Win a game with 30 Harpies, 15 x Harpy House, 1 x Bath House
	Deed_Win_With_Humans,                            // Human Utopia - Win a game with 30 Humans, 15 x Human House, 1 x Temple
	Deed_Win_With_Lizards,                           // Lizard Utopia - Win a game with 30 Lizards, 15 x Lizard House, 1 x Clan Hall
	Deed_Win_With_Many_Events,                       // Efficient Explorer - Win a game after completing 25 Glade Events.
	Deed_Win_With_Metal_Chain,                       // Refinery - Win with: 1 x Mine, 1 x Smelter, 1 x Smithy, on the difficulty: Veteran.
	Deed_Win_With_No_Deaths_Impossible,              // Tempest - Win a game with no dead villagers on Viceroy difficulty (or higher).
	Deed_Win_With_Population_And_Services,           // The Marketplace - Win a game with 50 villagers, 1 x Temple, 1 x Market
	Deed_Win_With_Reputation_Prestige,               // A True Leader - Earn 18 Reputation Points through villagers’ Resolve in a single game on Prestige 1 difficulty (or higher).
	Deed_Win_With_Ruins,                             // Ruins - Win a game after taking care of 10 ruins found in glades.
	Deed_Win_With_Service_Needs,                     // Higher Needs - Ensure all villagers have all their Services needs fulfilled simultaneously.
	Deed_Win_With_Totems,                            // Totem Hunter - Win with: 1 x Converted Rain Totem, 1 x Converted Totem of Denial, on the difficulty: Veteran.
	Deed_Win_Without_Bonus_Impossible,               // Traveling Light - Win a game without taking any Embarkation Bonuses on Viceroy difficulty (or higher).
	Deed_Win_Without_Bonus_Prestige,                 // Unnecessary Burden - Win a game without taking any Embarkation Bonuses on Prestige 10 difficulty (or higher).
	Deed_Win_Without_Caches,                         // No Loot Boxes - Win a game without opening or sending any Abandoned Caches to the Citadel.
	Deed_Win_Without_Camps,                          // No Strangers - Win a game without completing any encampment events.
	Deed_Win_Without_Dangerous_Glades,               // Playing It Safe - Win a game without discovering a Dangerous or Forbidden Glade, on Pioneer difficulty (or higher).
	Deed_Win_Without_Glades,                         // Immovable Viceroy - Win a game without discovering any glades.
	Deed_Win_Without_Orders_Prestige,                // Independent Viceroy - Win a game without completing any orders on Prestige 1 difficulty (or higher).
	Deed_Year_1_Dangerous,                           // Into the Forest - Win after discovering 2 Dangerous Glades before the end of Year 1, on Pioneer difficulty.
	Deed_Year_1_Forbidden,                           // Outstanding Move - Win a game after discovering a Forbidden Glade before the end of Year 1, on Veteran difficulty (or higher).
	Deed_Year_2_Forbidden,                           // Stalking Shadows - Win a game after discovering a Forbidden Glade before the end of Year 2, on Pioneer difficulty (or higher).
	Finish_One_Game,                                 // First Steps - Finish your first game after the tutorial.
	ScalingGoal_Phase0_CompleteOrders,               // Orders From the Queen 1 - Complete 10 orders.
	ScalingGoal_Phase0_GladeDiscovery,               // Discovery 1 - Discover 10 glades.
	ScalingGoal_Phase0_TradeGoods,                   // Rolling in Wealth 1 - Trade goods worth 50 Amber.
	ScalingGoal_Phase1_CompleteOrders,               // Orders From the Queen 2 - Complete 30 orders.
	ScalingGoal_Phase1_DistanceFromCitadel,          // Deeper Into the Wilds 1 - Build a settlement at least 4 fields away from the Citadel.
	ScalingGoal_Phase1_GladeDiscovery,               // Discovery 2 - Discover 30 glades.
	ScalingGoal_Phase1_ReputationFromResolve,        // Prosperity 1 - Collect 10 Reputation Points through villager Resolve.
	ScalingGoal_Phase1_TradeGoods,                   // Rolling in Wealth 2 - Trade goods worth 200 Amber.
	ScalingGoal_Phase1_WinWithPopulation,            // Big Settlement 1 - Win a game with at least 40 villagers.
	ScalingGoal_Phase2_CompleteOrders,               // Orders From the Queen 3 - Complete 80 orders.
	ScalingGoal_Phase2_DistanceFromCitadel,          // Deeper Into the Wilds 2 - Build a settlement at least 6 fields away from the Citadel.
	ScalingGoal_Phase2_GladeDiscovery,               // Discovery 3 - Discover 80 glades.
	ScalingGoal_Phase2_ReputationFromResolve,        // Prosperity 2 - Collect 25 Reputation Points through villager Resolve.
	ScalingGoal_Phase2_TradeGoods,                   // Rolling in Wealth 3 - Trade goods worth 600 Amber.
	ScalingGoal_Phase2_WinGameWithRelic,             // Dice With Death 1 - Win a game with one Dangerous Glade Event still active.
	ScalingGoal_Phase3_CompleteOrders,               // Orders From the Queen 4 - Complete 150 orders.
	ScalingGoal_Phase3_DistanceFromCitadel,          // Deeper Into the Wilds 3 - Build a settlement at least 8 fields away from the Citadel.
	ScalingGoal_Phase3_GladeDiscovery,               // Discovery 4 - Discover 150 glades.
	ScalingGoal_Phase3_ReputationFromResolve,        // Prosperity 3 - Collect 50 Reputation Points through villager Resolve.
	ScalingGoal_Phase3_TradeGoods,                   // Rolling in Wealth 4 - Trade goods worth 1500 Amber.
	ScalingGoal_Phase3_WinGameWithRelic,             // Dice With Death 2 - Win a game with two Dangerous Glade Events still active.
	ScalingGoal_Phase3_WinWithPopulation,            // Big Settlement 2 - Win a game with at least 60 villagers
	ScalingGoal_Phase4_CompleteOrders,               // Orders From the Queen 5 - Complete 250 orders.
	ScalingGoal_Phase4_DistanceFromCitadel,          // Deeper Into the Wilds 4 - Build a settlement at least 10 fields away from the Citadel.
	ScalingGoal_Phase4_GladeDiscovery,               // Discovery 5 - Discover 250 glades.
	ScalingGoal_Phase4_ReputationFromResolve,        // Prosperity 4 - Collect 80 Reputation Points through villager Resolve.
	ScalingGoal_Phase4_TradeGoods,                   // Rolling in Wealth 5 - Trade goods worth 3000 Amber.
	ScalingGoal_Phase4_WinGameWithRelic,             // Dice With Death 3 - Win a game with three Dangerous Glade Events still active.
	ScalingGoal_Phase5_CompleteOrders,               // Orders From the Queen 6 - Complete 400 orders.
	ScalingGoal_Phase5_GladeDiscovery,               // Discovery 6 - Discover 400 glades.
	ScalingGoal_Phase5_ReputationFromResolve,        // Prosperity 5 - Collect 130 Reputation Points through villager Resolve.
	ScalingGoal_Phase5_TradeGoods,                   // Rolling in Wealth 6 - Trade goods worth 5000 Amber.
	ScalingGoal_Phase5_WinGameWithRelic,             // Dice With Death 4 - Win a game with four Dangerous Glade Events still active.
	TimedGoal_Phase2_WinGames,                       // Fast Colonization - Win 3 games in one cycle.
	TimedGoal_Phase3_ReputationFromResolve,          // Prosperous Cycle - Collect 15 Reputation Points from Resolve in one cycle.
	TimedGoal_Phase3_WinGameOnMarshlands,            // Cycle of the Fungi - Win 3 games on the Marshlands in one cycle.
	TimedGoal_Phase3_WinGamesOnMoorlands,            // Cycle of the Bloodrain - Win 3 games in the Scarlet Orchard in one cycle.
	TimedGoal_Phase4_DistanceFromCitadel,            // Establishing Borders - Win 3 games at least 6 fields away from the Citadel in one cycle.
	TimedGoal_Phase4_GladeDiscovery,                 // Cycle of Discovery - Discover 50 glades in one cycle
	TimedGoal_Phase4_TradeGoods,                     // Cycle of Wealth - Trade goods worth 400 Amber in one cycle.
	TimedGoal_Phase4_WinNearBanditCamp,              // Cycle of the Outlaw - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
	TimedGoal_Phase4_WinNearStonewood,               // Cycle of the Infestation - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
	TimedGoal_Phase5_DangeroudGladeDiscovery,        // Cycle of the Wilds - Discover 20 Dangerous Glades in one cycle.
	TimedGoal_Phase5_WinNearWeatherAnomaly,          // Cycle of the Storm - Win 2 times near different modifiers of the same type (Weather Anomaly) in one cycle.
	TimedGoal_Phase5_WinWithoutImpatience,           // Cycle of the Queen - Win 3 games in a cycle without reaching more than 4 Impatience.
	TimedGoal_Phase5_WinWithoutOrders,               // Cycle of Defiance - Win 3 games in a cycle without completing any orders.
	TimedGoal_Phase5_WinWithoutVillagerDying,        // Safe Cycle - Win 3 games in a cycle without any villagers dying.
	Tutorial_Deed_Win_First_Game,                    // First Real Expedition - Win a game in the Royal Woodlands biome, and on Settler difficulty (or higher).
	Tutorial_Deed_Win_With_Events,                   // Taking Action - Win a game after completing 5 Glade Events.
	UniqueGoal_Phase1_WinGameNearFertileMeadows,     // Fertile Meadows - Win a game near the Fertile Grounds modifier.
	UniqueGoal_Phase1_WinGameNearStonewood,          // Stonewood Infestation - Win a game near the Stonewood Infestation modifier.
	UniqueGoal_Phase1_WinGames,                      // Third Time's a Charm - Win 3 games
	UniqueGoal_Phase1_WinGameWithGrain,              // Swamp Wheat Farmer - Win a game with 150 grain in the Warehouse.
	UniqueGoal_Phase1_WinGameWithPaths,              // Basic Logistics - Win a game with 200 paths built.
	UniqueGoal_Phase1_WinWithoutImpatience,          // The Patient Queen 1 - Don't let the Queen's Impatience grow above 6 in a single game.
	UniqueGoal_Phase1_WinWithoutVillagersDying,      // No Deaths - Win a game with 0 villagers dying.
	UniqueGoal_Phase2_WinGameNearBarren,             // Barren Lands - Win a game near the Barren Lands modifier.
	UniqueGoal_Phase2_WinGameNearRuins,              // Lost Colonies - Win a game near the Ruins modifier.
	UniqueGoal_Phase2_WinGameOnFaction,              // Rivalry 1 - Win 3 games on faction markers.
	UniqueGoal_Phase2_WinGameOnMarshlands,           // The Marshlands - Win a game on the The Marshlands biome.
	UniqueGoal_Phase2_WinGameOnMoorlands,            // The Scarlet Orchard - Win a game on the Scarlet Orchard biome.
	UniqueGoal_Phase2_WinGameWithoutOrders,          // Defying the Crown - Win a game without completing any orders.
	UniqueGoal_Phase2_WInGameWithResolve,            // Victory Through Resolve - Win a game having gained at least 5 Reputation Points through Resolve.
	UniqueGoal_Phase3_WinGameNearBanditCamp,         // Bandit Camp - Win a game near the Bandit Camp modifier.
	UniqueGoal_Phase3_WinGameOnFaction,              // Rivalry 2 - Win 4 games on faction markers.
	UniqueGoal_Phase3_WinOnCursedBiome,              // Cursed Lands - Win a game on the Cursed Royal Woodlands biome.
	UniqueGoal_Phase3_WinWithBeavers,                // Beaver Settlement - Win a game with at least 25 Beavers.
	UniqueGoal_Phase3_WinWithGoods,                  // Ancient Knowledge - Win a game with at least 5 Ancient Tablets in the Warehouse.
	UniqueGoal_Phase3_WinWithHumans,                 // Human Settlement - Win a game with at least 25 Humans.
	UniqueGoal_Phase3_WinWithLizards,                // Lizard Settlement - Win a game with at least 25 Lizards.
	UniqueGoal_Phase3_WinWIthRainpunk,               // Rare Technology - Win a game with a restored Rainpunk Foundry in your settlement.
	UniqueGoal_Phase3_WinWithSmallFarms,             // Farming Specialization - Win a game with 5 Small Farms built.
	UniqueGoal_Phase4_WinNearWeatherAnomaly,         // Weather Anomaly - Win a game near the Weather Anomaly modifier.
	UniqueGoal_Phase4_WinOnCoralBiome,               // Coral Forest - Win a game on the Coral Forest biome.
	UniqueGoal_Phase4_WinOnCursedBiome,              // Cursed Lands 2 - Win 2 games on the Cursed Royal Woodlands biome.
	UniqueGoal_Phase4_WinOnFaction,                  // Rivalry 3 - Win 6 games on faction markers.
	UniqueGoal_Phase4_WinWithHearths,                // Expansion - Win a game with 4 Makeshift Hearths built.
	UniqueGoal_Phase4_WinWithMines,                  // Industry - Win a game with 5 Mines built.
	UniqueGoal_Phase4_WinWithoutImpatience,          // The Patient Queen 2 - Don't let the Queen's Impatience grow above 4 in a single game.
	UniqueGoal_Phase5_WinOnCursedBiome,              // Cursed Lands 3 - Win 3 games on the Cursed Royal Woodlands biome.
	UniqueGoal_Phase5_WinWithBlightrot,              // Blood Flower Farmer - Win a game with 3 active Blood Flower clones on the map.
	UniqueGoal_Phase5_WinWithoutImpatience,          // The Patient Queen 3 - Don't let the Queen's Impatience grow above 2 in a single game.
	UniqueGoal_Phase5_WinWithResolve,                // Victory Through Prosperity - Earn 14 Reputation Points through Resolve in a single game.
	UniqueGoal_Phase5_WinWithTools,                  // Tool Hoarder - Win a game with 20 Infused Tools in the Warehouse.
	UniqueGoal_Phase5_WinWithVaults,                 // Ancient Vaults - Win a game with 2 active Open Vaults on the map.
	WE_Deed_Complete_Trade_Routes_Of_Value_In_Years, // Commenda Contract - Win a game before year 8 ends, after completing trade routes worth 150 <sprite name="[valuable] amber"> Amber in total.
	WE_Deed_Win_With_Amber,                          // Bankrupt Trader - Win a game with 150 Amber in your Warehouse.
	WE_Deed_Win_With_Amber_In_Years,                 // Bankrupt Trader - Win a game before year 8 ends, with 250 Amber in your warehouse.
	WE_Deed_Win_With_Forbidden_Events_Solved,        // Obsidian Loremaster - Win a game after solving 2 Forbidden Events.
	WE_Deed_Win_With_Less_Than_3_Dang_Glades,        // Somber Procession - Win a game after opening no more than 1 Dangerous or Forbidden Glade.
	WE_Deed_Win_With_Villagers_Dying,                // Followers of the Forsaken Gods - Win a game before year 8 ends, after 10 villagers have died.
	WE_Deed_Win_With_Water,                          // Crashed Airship - Win a game before year 8 ends, with 300 Storm Water in your warehouse.
	WE_Deed_Win_Without_Leaving,                     // Hanged Viceroy - Win a game with no villagers leaving.
	WE_Win_With_Hubs,                                // Brass Order Engineers - Win a game before year 9 ends, while having 3 Hearths in your settlement upgraded to level: District (Level 3).
	Win_Game_With_Modifier_Abandoned_Settlement,     // Abandoned Settlement - Win a game near the Abandoned Settlement modifier.
	Win_Game_With_Modifier_Altar,                    // Fishmen Ritual Site - Win a game near the Fishmen Ritual Site modifier.
	Win_Game_With_Modifier_Armory,                   // Ruined Armory - Win a game near the Ruined Armory modifier.
	Win_Game_With_Modifier_Battleground,             // Ancient Battleground - Win a game near the Ancient Battleground modifier.
	Win_Game_With_Modifier_Crystals,                 // Sparkdew Crystals - Win a game near the Sparkdew Crystals modifier.
	Win_Game_With_Modifier_Dangerous,                // Dangerous Lands - Win a game near the Dangerous Lands modifier.
	Win_Game_With_Modifier_Forbidden,                // Forbidden Lands - Win a game near the Forbidden Lands modifier.
	Win_Game_With_Modifier_Frosts,                   // Frosts - Win a game near the Frosts modifier.
	Win_Game_With_Modifier_Gathering_Storm,          // Gathering Storm - Win a game near the Gathering Storm modifier.
	Win_Game_With_Modifier_Haunted,                  // Haunted Forest - Win a game near the Haunted Forest modifier.
	Win_Game_With_Modifier_Land_Of_Greed,            // Land of Greed - Win a game near the Land of Greed modifier.
	Win_Game_With_Modifier_Levitating,               // Levitating Monument - Win a game near the Levitating Monument modifier.
	Win_Game_With_Modifier_Mine,                     // Flooded Mines - Win a game near the Flooded Mines modifier.
	Win_Game_With_Modifier_Monastery,                // Monastery of the Holy Flame - Win a game near the Monastery of the Holy Flame modifier.
	Win_Game_With_Modifier_Ominous_Presence,         // Ominous Presence - Win a game near the Ominous Presence modifier.
	Win_Game_With_Modifier_Outpost,                  // Royal Outpost - Win a game near the Royal Outpost modifier.
	Win_Game_With_Modifier_Overgrown_Library,        // Overgrown Library - Win a game near the Overgrown Library modifier.
	Win_Game_With_Modifier_Petrified_Necropolis,     // Petrified Necropolis - Win a game near the Petrified Necropolis modifier.
	Win_Game_With_Modifier_Statue,                   // Statue of the Forefathers - Win a game near the Statue of the Forefathers modifier.
	Win_Game_With_Modifier_Temple,                   // Forsaken Gods Temple - Win a game near the Forsaken Gods Temple modifier.
	Win_Game_With_Modifier_Torrent,                  // Corrosive Torrent - Win a game near the Corrosive Torrent modifier.
	Win_Game_With_Modifier_Untamed_Wilds,            // Untamed Wilds - Win a game near the Untamed Wilds modifier.
	Win_Game_With_Modifier_Watchtower,               // Watchtower - Win a game near the Watchtower modifier.


	MAX = 207
}

public static class GoalTypesExtensions
{
	private static GoalTypes[] s_All = null;
	public static GoalTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new GoalTypes[207];
			for (int i = 0; i < 207; i++)
			{
				s_All[i] = (GoalTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this GoalTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of GoalTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[GoalTypes.Deed_Fox_Population];
	}
	
	public static GoalTypes ToGoalTypes(this string name)
	{
		foreach (KeyValuePair<GoalTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find GoalTypes with name: " + name + "\n" + Environment.StackTrace);
		return GoalTypes.Unknown;
	}
	
	public static GoalModel ToGoalModel(this string name)
	{
		GoalModel model = SO.Settings.goals.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find GoalModel for GoalTypes with name: " + name + "\n" + Environment.StackTrace);
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
			array[i++] = element.ToGoalModel();
		}

		return array;
	}
	
	public static GoalModel[] ToGoalModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		GoalModel[] array = new GoalModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGoalModel();
		}

		return array;
	}

	internal static readonly Dictionary<GoalTypes, string> TypeToInternalName = new()
	{
		{ GoalTypes.Deed_Fox_Population, "Deed Fox Population" },                                                           // Fox Settlement - Win a game with at least 25 Foxes.
		{ GoalTypes.Deed_Harpy_Population, "Deed Harpy Population" },                                                       // Harpy Settlement - Win a game with at least 25 Harpies.
		{ GoalTypes.Deed_Reforge_Seal_Adamantine, "Deed Reforge Seal Adamantine" },                                         // The Adamantine Seal - Reforge the Adamantine Seal.
		{ GoalTypes.Deed_Reforge_Seal_Bronze, "Deed Reforge Seal Bronze" },                                                 // The Bronze Seal - Reforge the Bronze Seal.
		{ GoalTypes.Deed_Reforge_Seal_Cobalt, "Deed Reforge Seal Cobalt" },                                                 // The Cobalt Seal - Reforge the Cobalt Seal.
		{ GoalTypes.Deed_Reforge_Seal_Gold, "Deed Reforge Seal Gold" },                                                     // The Gold Seal - Reforge the Gold Seal.
		{ GoalTypes.Deed_Reforge_Seal_Lead, "Deed Reforge Seal Lead" },                                                     // The Lead Seal - Reforge the Lead Seal.
		{ GoalTypes.Deed_Reforge_Seal_Platinum, "Deed Reforge Seal Platinum" },                                             // The Platinum Seal - Reforge the Platinum Seal.
		{ GoalTypes.Deed_Reforge_Seal_Silver, "Deed Reforge Seal Silver" },                                                 // The Silver Seal - Reforge the Silver Seal.
		{ GoalTypes.Deed_Reforge_Seal_Titanium, "Deed Reforge Seal Titanium" },                                             // The Titanium Seal - Reforge the Titanium Seal.
		{ GoalTypes.Deed_Scorpion, "Deed Scorpion" },                                                                       // Apprentice Archaeologist 1 - Win a game with a reconstructed Smoldering Scorpion skeleton in the Scarlet Orchard.
		{ GoalTypes.Deed_Snake, "Deed Snake" },                                                                             // Apprentice Archaeologist 2 - Win a game with a reconstructed Sea Serpent skeleton in the Scarlet Orchard.
		{ GoalTypes.Deed_Spider, "Deed Spider" },                                                                           // Apprentice Archaeologist 3 - Win a game with a reconstructed Sealed Spider skeleton in the Scarlet Orchard.
		{ GoalTypes.Deed_Spider_Snake_Scorpion, "Deed Spider Snake Scorpion" },                                             // Master Archaeologist - Win a game with all three skeletons reconstructed in the Scarlet Orchard.
		{ GoalTypes.Deed_Timed_Orders_1, "Deed Timed Orders 1" },                                                           // Rushed Delivery 1 - Complete 5 timed orders.
		{ GoalTypes.Deed_Timed_Orders_2, "Deed Timed Orders 2" },                                                           // Rushed Delivery 2 - Complete 15 timed orders.
		{ GoalTypes.Deed_Timed_Orders_3, "Deed Timed Orders 3" },                                                           // Rushed Delivery 3 - Complete 30 timed orders.
		{ GoalTypes.Deed_Timed_Orders_4, "Deed Timed Orders 4" },                                                           // Rushed Delivery 4 - Complete 50 timed orders.
		{ GoalTypes.Deed_Timed_Orders_5, "Deed Timed Orders 5" },                                                           // Rushed Delivery 5 - Complete 75 timed orders.
		{ GoalTypes.Deed_Timed_Orders_6, "Deed Timed Orders 6" },                                                           // Rushed Delivery 6 - Complete 100 timed orders.
		{ GoalTypes.Deed_Trade_Routes_1, "Deed Trade Routes 1" },                                                           // Export Expert 1 - Complete 10 trade routes.
		{ GoalTypes.Deed_Trade_Routes_2, "Deed Trade Routes 2" },                                                           // Export Expert 2 - Complete 30 trade routes.
		{ GoalTypes.Deed_Trade_Routes_3, "Deed Trade Routes 3" },                                                           // Export Expert 3 - Complete 80 trade routes.
		{ GoalTypes.Deed_Trade_Routes_4, "Deed Trade Routes 4" },                                                           // Export Expert 4 - Complete 150 trade routes.
		{ GoalTypes.Deed_Trade_Routes_5, "Deed Trade Routes 5" },                                                           // Export Expert 5 - Complete 250 trade routes.
		{ GoalTypes.Deed_Trade_Routes_6, "Deed Trade Routes 6" },                                                           // Export Expert 6 - Complete 400 trade routes.
		{ GoalTypes.Deed_Win_Coral_Impossible, "Deed Win Coral Impossible" },                                               // The Reef - Win a game in the Coral Forest biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Cursed_Impossible, "Deed Win Cursed Impossible" },                                             // Thick Clouds - Win a game in the Cursed Royal Woodlands biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Hard, "Deed Win Game Hard" },                                                             // Overcoming Difficulty - Win a game on Pioneer difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Impossible, "Deed Win Game Impossible" },                                                 // Against All Odds - Win a game on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_In_3_Years, "Deed Win Game In 3 Years" },                                                 // Homesick 2 - Win a game in 3 years or less.
		{ GoalTypes.Deed_Win_Game_In_5_Years, "Deed Win Game In 5 Years" },                                                 // Homesick 1 - Win a game in 5 years or less.
		{ GoalTypes.Deed_Win_Game_Prestige_1, "Deed Win Game Prestige 1" },                                                 // Prestigious Expedition  1 - Win a game on Prestige 1 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_10, "Deed Win Game Prestige 10" },                                               // Prestigious Expedition 10 - Win a game on Prestige 10 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_11, "Deed Win Game Prestige 11" },                                               // Prestigious Expedition 11 - Win a game on Prestige 11 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_12, "Deed Win Game Prestige 12" },                                               // Prestigious Expedition 12 - Win a game on Prestige 12 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_13, "Deed Win Game Prestige 13" },                                               // Prestigious Expedition 13 - Win a game on Prestige 13 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_14, "Deed Win Game Prestige 14" },                                               // Prestigious Expedition 14 - Win a game on Prestige 14 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_15, "Deed Win Game Prestige 15" },                                               // Prestigious Expedition 15 - Win a game on Prestige 15 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_16, "Deed Win Game Prestige 16" },                                               // Prestigious Expedition 16 - Win a game on Prestige 16 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_17, "Deed Win Game Prestige 17" },                                               // Prestigious Expedition 17 - Win a game on Prestige 17 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_18, "Deed Win Game Prestige 18" },                                               // Prestigious Expedition 18 - Win a game on Prestige 18 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_19, "Deed Win Game Prestige 19" },                                               // Prestigious Expedition 19 - Win a game on Prestige 19 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_2, "Deed Win Game Prestige 2" },                                                 // Prestigious Expedition  2 - Win a game on Prestige 2 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_20, "Deed Win Game Prestige 20" },                                               // Prestigious Expedition 20 - Win a game on Prestige 20 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_3, "Deed Win Game Prestige 3" },                                                 // Prestigious Expedition  3 - Win a game on Prestige 3 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_4, "Deed Win Game Prestige 4" },                                                 // Prestigious Expedition  4 - Win a game on Prestige 4 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_5, "Deed Win Game Prestige 5" },                                                 // Prestigious Expedition  5 - Win a game on Prestige 5 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_6, "Deed Win Game Prestige 6" },                                                 // Prestigious Expedition  6 - Win a game on Prestige 6 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_7, "Deed Win Game Prestige 7" },                                                 // Prestigious Expedition  7 - Win a game on Prestige 7 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_8, "Deed Win Game Prestige 8" },                                                 // Prestigious Expedition  8 - Win a game on Prestige 8 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Prestige_9, "Deed Win Game Prestige 9" },                                                 // Prestigious Expedition  9 - Win a game on Prestige 9 difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_Very_Hard, "Deed Win Game Very Hard" },                                                   // A Real Challenge - Win a game on Veteran difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_With_Glades, "Deed Win Game With Glades" },                                               // Thorough Exploration - Win a game with 30 or more glades discovered, on Pioneer difficulty (or higher).
		{ GoalTypes.Deed_Win_Game_With_Timed_Orders, "Deed Win Game With Timed Orders" },                                   // Like a Machine - Win a game after completing 3 timed orders.
		{ GoalTypes.Deed_Win_Game_With_Trade_Routes, "Deed Win Game With Trade Routes" },                                   // Trade Baron - Win a game after completing 20 trade routes.
		{ GoalTypes.Deed_Win_Marshlands_Impossible, "Deed Win Marshlands Impossible" },                                     // Deadly Spores - Win a game in the The Marshlands biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Queens_Hand, "Deed Win Queens Hand" },                                                         // The Queen's Hand - Complete the Queen's Hand Trial.
		{ GoalTypes.Deed_Win_Scarlet_Impossible, "Deed Win Scarlet Impossible" },                                           // Crimson Soil - Win a game in the Scarlet Orchard biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_With_Ale_Chain, "Deed Win With Ale Chain" },                                                   // Serving Ale - Win with: 1 x Small Farm, 1 x Brewery, 1 x Tavern, on the difficulty: Veteran.
		{ GoalTypes.Deed_Win_With_All_Needs, "Deed Win With All Needs" },                                                   // Paradise - Ensure all villagers have all their needs fulfilled simultaneously.
		{ GoalTypes.Deed_Win_With_Amber, "Deed Win With Amber" },                                                           // Trade Connections - Win a game with 400 Amber in your Warehouse.
		{ GoalTypes.Deed_Win_With_Beavers, "Deed Win With Beavers" },                                                       // Beaver Utopia - Win a game with 30 Beavers, 15 x Beaver House, 1 x Guild House
		{ GoalTypes.Deed_Win_With_Caches, "Deed Win With Caches" },                                                         // Treasure - Win a game after opening or sending 20 Abandoned Caches to the Citadel.
		{ GoalTypes.Deed_Win_With_Dead_Villagers, "Deed Win With Dead Villagers" },                                         // Devil's Bargain - Win a game after 20 villagers have died.
		{ GoalTypes.Deed_Win_With_Dead_Villagers_Prestige, "Deed Win With Dead Villagers Prestige" },                       // High Price - Win a game after 15 villagers died, on Prestige 18 difficulty (or higher).
		{ GoalTypes.Deed_Win_With_Food_Needs, "Deed Win With Food Needs" },                                                 // Feeding The People - Ensure all villagers have all their Complex Food needs fulfilled simultaneously.
		{ GoalTypes.Deed_Win_With_Foxes, "Deed Win With Foxes" },                                                           // Fox Utopia - Win a game with 30 Foxes, 15 x Fox House, 1 x Tea Doctor
		{ GoalTypes.Deed_Win_With_Harpies, "Deed Win With Harpies" },                                                       // Harpy Utopia - Win a game with 30 Harpies, 15 x Harpy House, 1 x Bath House
		{ GoalTypes.Deed_Win_With_Humans, "Deed Win With Humans" },                                                         // Human Utopia - Win a game with 30 Humans, 15 x Human House, 1 x Temple
		{ GoalTypes.Deed_Win_With_Lizards, "Deed Win With Lizards" },                                                       // Lizard Utopia - Win a game with 30 Lizards, 15 x Lizard House, 1 x Clan Hall
		{ GoalTypes.Deed_Win_With_Many_Events, "Deed Win With Many Events" },                                               // Efficient Explorer - Win a game after completing 25 Glade Events.
		{ GoalTypes.Deed_Win_With_Metal_Chain, "Deed Win With Metal Chain" },                                               // Refinery - Win with: 1 x Mine, 1 x Smelter, 1 x Smithy, on the difficulty: Veteran.
		{ GoalTypes.Deed_Win_With_No_Deaths_Impossible, "Deed Win With No Deaths Impossible" },                             // Tempest - Win a game with no dead villagers on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_With_Population_And_Services, "Deed Win With Population And Services" },                       // The Marketplace - Win a game with 50 villagers, 1 x Temple, 1 x Market
		{ GoalTypes.Deed_Win_With_Reputation_Prestige, "Deed Win With Reputation Prestige" },                               // A True Leader - Earn 18 Reputation Points through villagers’ Resolve in a single game on Prestige 1 difficulty (or higher).
		{ GoalTypes.Deed_Win_With_Ruins, "Deed Win With Ruins" },                                                           // Ruins - Win a game after taking care of 10 ruins found in glades.
		{ GoalTypes.Deed_Win_With_Service_Needs, "Deed Win With Service Needs" },                                           // Higher Needs - Ensure all villagers have all their Services needs fulfilled simultaneously.
		{ GoalTypes.Deed_Win_With_Totems, "Deed Win With Totems" },                                                         // Totem Hunter - Win with: 1 x Converted Rain Totem, 1 x Converted Totem of Denial, on the difficulty: Veteran.
		{ GoalTypes.Deed_Win_Without_Bonus_Impossible, "Deed Win Without Bonus Impossible" },                               // Traveling Light - Win a game without taking any Embarkation Bonuses on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Without_Bonus_Prestige, "Deed Win Without Bonus Prestige" },                                   // Unnecessary Burden - Win a game without taking any Embarkation Bonuses on Prestige 10 difficulty (or higher).
		{ GoalTypes.Deed_Win_Without_Caches, "Deed Win Without Caches" },                                                   // No Loot Boxes - Win a game without opening or sending any Abandoned Caches to the Citadel.
		{ GoalTypes.Deed_Win_Without_Camps, "Deed Win Without Camps" },                                                     // No Strangers - Win a game without completing any encampment events.
		{ GoalTypes.Deed_Win_Without_Dangerous_Glades, "Deed Win Without Dangerous Glades" },                               // Playing It Safe - Win a game without discovering a Dangerous or Forbidden Glade, on Pioneer difficulty (or higher).
		{ GoalTypes.Deed_Win_Without_Glades, "Deed Win Without Glades" },                                                   // Immovable Viceroy - Win a game without discovering any glades.
		{ GoalTypes.Deed_Win_Without_Orders_Prestige, "Deed Win Without Orders Prestige" },                                 // Independent Viceroy - Win a game without completing any orders on Prestige 1 difficulty (or higher).
		{ GoalTypes.Deed_Year_1_Dangerous, "Deed Year 1 Dangerous" },                                                       // Into the Forest - Win after discovering 2 Dangerous Glades before the end of Year 1, on Pioneer difficulty.
		{ GoalTypes.Deed_Year_1_Forbidden, "Deed Year 1 Forbidden" },                                                       // Outstanding Move - Win a game after discovering a Forbidden Glade before the end of Year 1, on Veteran difficulty (or higher).
		{ GoalTypes.Deed_Year_2_Forbidden, "Deed Year 2 Forbidden" },                                                       // Stalking Shadows - Win a game after discovering a Forbidden Glade before the end of Year 2, on Pioneer difficulty (or higher).
		{ GoalTypes.Finish_One_Game, "Finish One Game" },                                                                   // First Steps - Finish your first game after the tutorial.
		{ GoalTypes.ScalingGoal_Phase0_CompleteOrders, "ScalingGoal_Phase0_CompleteOrders" },                               // Orders From the Queen 1 - Complete 10 orders.
		{ GoalTypes.ScalingGoal_Phase0_GladeDiscovery, "ScalingGoal_Phase0_GladeDiscovery" },                               // Discovery 1 - Discover 10 glades.
		{ GoalTypes.ScalingGoal_Phase0_TradeGoods, "ScalingGoal_Phase0_TradeGoods" },                                       // Rolling in Wealth 1 - Trade goods worth 50 Amber.
		{ GoalTypes.ScalingGoal_Phase1_CompleteOrders, "ScalingGoal_Phase1_CompleteOrders" },                               // Orders From the Queen 2 - Complete 30 orders.
		{ GoalTypes.ScalingGoal_Phase1_DistanceFromCitadel, "ScalingGoal_Phase1_DistanceFromCitadel" },                     // Deeper Into the Wilds 1 - Build a settlement at least 4 fields away from the Citadel.
		{ GoalTypes.ScalingGoal_Phase1_GladeDiscovery, "ScalingGoal_Phase1_GladeDiscovery" },                               // Discovery 2 - Discover 30 glades.
		{ GoalTypes.ScalingGoal_Phase1_ReputationFromResolve, "ScalingGoal_Phase1_ReputationFromResolve" },                 // Prosperity 1 - Collect 10 Reputation Points through villager Resolve.
		{ GoalTypes.ScalingGoal_Phase1_TradeGoods, "ScalingGoal_Phase1_TradeGoods" },                                       // Rolling in Wealth 2 - Trade goods worth 200 Amber.
		{ GoalTypes.ScalingGoal_Phase1_WinWithPopulation, "ScalingGoal_Phase1_WinWithPopulation" },                         // Big Settlement 1 - Win a game with at least 40 villagers.
		{ GoalTypes.ScalingGoal_Phase2_CompleteOrders, "ScalingGoal_Phase2_CompleteOrders" },                               // Orders From the Queen 3 - Complete 80 orders.
		{ GoalTypes.ScalingGoal_Phase2_DistanceFromCitadel, "ScalingGoal_Phase2_DistanceFromCitadel" },                     // Deeper Into the Wilds 2 - Build a settlement at least 6 fields away from the Citadel.
		{ GoalTypes.ScalingGoal_Phase2_GladeDiscovery, "ScalingGoal_Phase2_GladeDiscovery" },                               // Discovery 3 - Discover 80 glades.
		{ GoalTypes.ScalingGoal_Phase2_ReputationFromResolve, "ScalingGoal_Phase2_ReputationFromResolve" },                 // Prosperity 2 - Collect 25 Reputation Points through villager Resolve.
		{ GoalTypes.ScalingGoal_Phase2_TradeGoods, "ScalingGoal_Phase2_TradeGoods" },                                       // Rolling in Wealth 3 - Trade goods worth 600 Amber.
		{ GoalTypes.ScalingGoal_Phase2_WinGameWithRelic, "ScalingGoal_Phase2_WinGameWithRelic" },                           // Dice With Death 1 - Win a game with one Dangerous Glade Event still active.
		{ GoalTypes.ScalingGoal_Phase3_CompleteOrders, "ScalingGoal_Phase3_CompleteOrders" },                               // Orders From the Queen 4 - Complete 150 orders.
		{ GoalTypes.ScalingGoal_Phase3_DistanceFromCitadel, "ScalingGoal_Phase3_DistanceFromCitadel" },                     // Deeper Into the Wilds 3 - Build a settlement at least 8 fields away from the Citadel.
		{ GoalTypes.ScalingGoal_Phase3_GladeDiscovery, "ScalingGoal_Phase3_GladeDiscovery" },                               // Discovery 4 - Discover 150 glades.
		{ GoalTypes.ScalingGoal_Phase3_ReputationFromResolve, "ScalingGoal_Phase3_ReputationFromResolve" },                 // Prosperity 3 - Collect 50 Reputation Points through villager Resolve.
		{ GoalTypes.ScalingGoal_Phase3_TradeGoods, "ScalingGoal_Phase3_TradeGoods" },                                       // Rolling in Wealth 4 - Trade goods worth 1500 Amber.
		{ GoalTypes.ScalingGoal_Phase3_WinGameWithRelic, "ScalingGoal_Phase3_WinGameWithRelic" },                           // Dice With Death 2 - Win a game with two Dangerous Glade Events still active.
		{ GoalTypes.ScalingGoal_Phase3_WinWithPopulation, "ScalingGoal_Phase3_WinWithPopulation" },                         // Big Settlement 2 - Win a game with at least 60 villagers
		{ GoalTypes.ScalingGoal_Phase4_CompleteOrders, "ScalingGoal_Phase4_CompleteOrders" },                               // Orders From the Queen 5 - Complete 250 orders.
		{ GoalTypes.ScalingGoal_Phase4_DistanceFromCitadel, "ScalingGoal_Phase4_DistanceFromCitadel" },                     // Deeper Into the Wilds 4 - Build a settlement at least 10 fields away from the Citadel.
		{ GoalTypes.ScalingGoal_Phase4_GladeDiscovery, "ScalingGoal_Phase4_GladeDiscovery" },                               // Discovery 5 - Discover 250 glades.
		{ GoalTypes.ScalingGoal_Phase4_ReputationFromResolve, "ScalingGoal_Phase4_ReputationFromResolve" },                 // Prosperity 4 - Collect 80 Reputation Points through villager Resolve.
		{ GoalTypes.ScalingGoal_Phase4_TradeGoods, "ScalingGoal_Phase4_TradeGoods" },                                       // Rolling in Wealth 5 - Trade goods worth 3000 Amber.
		{ GoalTypes.ScalingGoal_Phase4_WinGameWithRelic, "ScalingGoal_Phase4_WinGameWithRelic" },                           // Dice With Death 3 - Win a game with three Dangerous Glade Events still active.
		{ GoalTypes.ScalingGoal_Phase5_CompleteOrders, "ScalingGoal_Phase5_CompleteOrders" },                               // Orders From the Queen 6 - Complete 400 orders.
		{ GoalTypes.ScalingGoal_Phase5_GladeDiscovery, "ScalingGoal_Phase5_GladeDiscovery" },                               // Discovery 6 - Discover 400 glades.
		{ GoalTypes.ScalingGoal_Phase5_ReputationFromResolve, "ScalingGoal_Phase5_ReputationFromResolve" },                 // Prosperity 5 - Collect 130 Reputation Points through villager Resolve.
		{ GoalTypes.ScalingGoal_Phase5_TradeGoods, "ScalingGoal_Phase5_TradeGoods" },                                       // Rolling in Wealth 6 - Trade goods worth 5000 Amber.
		{ GoalTypes.ScalingGoal_Phase5_WinGameWithRelic, "ScalingGoal_Phase5_WinGameWithRelic" },                           // Dice With Death 4 - Win a game with four Dangerous Glade Events still active.
		{ GoalTypes.TimedGoal_Phase2_WinGames, "TimedGoal_Phase2_WinGames" },                                               // Fast Colonization - Win 3 games in one cycle.
		{ GoalTypes.TimedGoal_Phase3_ReputationFromResolve, "TimedGoal_Phase3_ReputationFromResolve" },                     // Prosperous Cycle - Collect 15 Reputation Points from Resolve in one cycle.
		{ GoalTypes.TimedGoal_Phase3_WinGameOnMarshlands, "TimedGoal_Phase3_WinGameOnMarshlands" },                         // Cycle of the Fungi - Win 3 games on the Marshlands in one cycle.
		{ GoalTypes.TimedGoal_Phase3_WinGamesOnMoorlands, "TimedGoal_Phase3_WinGamesOnMoorlands" },                         // Cycle of the Bloodrain - Win 3 games in the Scarlet Orchard in one cycle.
		{ GoalTypes.TimedGoal_Phase4_DistanceFromCitadel, "TimedGoal_Phase4_DistanceFromCitadel" },                         // Establishing Borders - Win 3 games at least 6 fields away from the Citadel in one cycle.
		{ GoalTypes.TimedGoal_Phase4_GladeDiscovery, "TimedGoal_Phase4_GladeDiscovery" },                                   // Cycle of Discovery - Discover 50 glades in one cycle
		{ GoalTypes.TimedGoal_Phase4_TradeGoods, "TimedGoal_Phase4_TradeGoods" },                                           // Cycle of Wealth - Trade goods worth 400 Amber in one cycle.
		{ GoalTypes.TimedGoal_Phase4_WinNearBanditCamp, "TimedGoal_Phase4_WinNearBanditCamp" },                             // Cycle of the Outlaw - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
		{ GoalTypes.TimedGoal_Phase4_WinNearStonewood, "TimedGoal_Phase4_WinNearStonewood" },                               // Cycle of the Infestation - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
		{ GoalTypes.TimedGoal_Phase5_DangeroudGladeDiscovery, "TimedGoal_Phase5_DangeroudGladeDiscovery" },                 // Cycle of the Wilds - Discover 20 Dangerous Glades in one cycle.
		{ GoalTypes.TimedGoal_Phase5_WinNearWeatherAnomaly, "TimedGoal_Phase5_WinNearWeatherAnomaly" },                     // Cycle of the Storm - Win 2 times near different modifiers of the same type (Weather Anomaly) in one cycle.
		{ GoalTypes.TimedGoal_Phase5_WinWithoutImpatience, "TimedGoal_Phase5_WinWithoutImpatience" },                       // Cycle of the Queen - Win 3 games in a cycle without reaching more than 4 Impatience.
		{ GoalTypes.TimedGoal_Phase5_WinWithoutOrders, "TimedGoal_Phase5_WinWithoutOrders" },                               // Cycle of Defiance - Win 3 games in a cycle without completing any orders.
		{ GoalTypes.TimedGoal_Phase5_WinWithoutVillagerDying, "TimedGoal_Phase5_WinWithoutVillagerDying" },                 // Safe Cycle - Win 3 games in a cycle without any villagers dying.
		{ GoalTypes.Tutorial_Deed_Win_First_Game, "Tutorial Deed Win First Game" },                                         // First Real Expedition - Win a game in the Royal Woodlands biome, and on Settler difficulty (or higher).
		{ GoalTypes.Tutorial_Deed_Win_With_Events, "Tutorial Deed Win With Events" },                                       // Taking Action - Win a game after completing 5 Glade Events.
		{ GoalTypes.UniqueGoal_Phase1_WinGameNearFertileMeadows, "UniqueGoal_Phase1_WinGameNearFertileMeadows" },           // Fertile Meadows - Win a game near the Fertile Grounds modifier.
		{ GoalTypes.UniqueGoal_Phase1_WinGameNearStonewood, "UniqueGoal_Phase1_WinGameNearStonewood" },                     // Stonewood Infestation - Win a game near the Stonewood Infestation modifier.
		{ GoalTypes.UniqueGoal_Phase1_WinGames, "UniqueGoal_Phase1_WinGames" },                                             // Third Time's a Charm - Win 3 games
		{ GoalTypes.UniqueGoal_Phase1_WinGameWithGrain, "UniqueGoal_Phase1_WinGameWithGrain" },                             // Swamp Wheat Farmer - Win a game with 150 grain in the Warehouse.
		{ GoalTypes.UniqueGoal_Phase1_WinGameWithPaths, "UniqueGoal_Phase1_WinGameWithPaths" },                             // Basic Logistics - Win a game with 200 paths built.
		{ GoalTypes.UniqueGoal_Phase1_WinWithoutImpatience, "UniqueGoal_Phase1_WinWithoutImpatience" },                     // The Patient Queen 1 - Don't let the Queen's Impatience grow above 6 in a single game.
		{ GoalTypes.UniqueGoal_Phase1_WinWithoutVillagersDying, "UniqueGoal_Phase1_WinWithoutVillagersDying" },             // No Deaths - Win a game with 0 villagers dying.
		{ GoalTypes.UniqueGoal_Phase2_WinGameNearBarren, "UniqueGoal_Phase2_WinGameNearBarren" },                           // Barren Lands - Win a game near the Barren Lands modifier.
		{ GoalTypes.UniqueGoal_Phase2_WinGameNearRuins, "UniqueGoal_Phase2_WinGameNearRuins" },                             // Lost Colonies - Win a game near the Ruins modifier.
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnFaction, "UniqueGoal_Phase2_WinGameOnFaction" },                             // Rivalry 1 - Win 3 games on faction markers.
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnMarshlands, "UniqueGoal_Phase2_WinGameOnMarshlands" },                       // The Marshlands - Win a game on the The Marshlands biome.
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnMoorlands, "UniqueGoal_Phase2_WinGameOnMoorlands" },                         // The Scarlet Orchard - Win a game on the Scarlet Orchard biome.
		{ GoalTypes.UniqueGoal_Phase2_WinGameWithoutOrders, "UniqueGoal_Phase2_WinGameWithoutOrders" },                     // Defying the Crown - Win a game without completing any orders.
		{ GoalTypes.UniqueGoal_Phase2_WInGameWithResolve, "UniqueGoal_Phase2_WInGameWithResolve" },                         // Victory Through Resolve - Win a game having gained at least 5 Reputation Points through Resolve.
		{ GoalTypes.UniqueGoal_Phase3_WinGameNearBanditCamp, "UniqueGoal_Phase3_WinGameNearBanditCamp" },                   // Bandit Camp - Win a game near the Bandit Camp modifier.
		{ GoalTypes.UniqueGoal_Phase3_WinGameOnFaction, "UniqueGoal_Phase3_WinGameOnFaction" },                             // Rivalry 2 - Win 4 games on faction markers.
		{ GoalTypes.UniqueGoal_Phase3_WinOnCursedBiome, "UniqueGoal_Phase3_WinOnCursedBiome" },                             // Cursed Lands - Win a game on the Cursed Royal Woodlands biome.
		{ GoalTypes.UniqueGoal_Phase3_WinWithBeavers, "UniqueGoal_Phase3_WinWithBeavers" },                                 // Beaver Settlement - Win a game with at least 25 Beavers.
		{ GoalTypes.UniqueGoal_Phase3_WinWithGoods, "UniqueGoal_Phase3_WinWithGoods" },                                     // Ancient Knowledge - Win a game with at least 5 Ancient Tablets in the Warehouse.
		{ GoalTypes.UniqueGoal_Phase3_WinWithHumans, "UniqueGoal_Phase3_WinWithHumans" },                                   // Human Settlement - Win a game with at least 25 Humans.
		{ GoalTypes.UniqueGoal_Phase3_WinWithLizards, "UniqueGoal_Phase3_WinWithLizards" },                                 // Lizard Settlement - Win a game with at least 25 Lizards.
		{ GoalTypes.UniqueGoal_Phase3_WinWIthRainpunk, "UniqueGoal_Phase3_WinWIthRainpunk" },                               // Rare Technology - Win a game with a restored Rainpunk Foundry in your settlement.
		{ GoalTypes.UniqueGoal_Phase3_WinWithSmallFarms, "UniqueGoal_Phase3_WinWithSmallFarms" },                           // Farming Specialization - Win a game with 5 Small Farms built.
		{ GoalTypes.UniqueGoal_Phase4_WinNearWeatherAnomaly, "UniqueGoal_Phase4_WinNearWeatherAnomaly" },                   // Weather Anomaly - Win a game near the Weather Anomaly modifier.
		{ GoalTypes.UniqueGoal_Phase4_WinOnCoralBiome, "UniqueGoal_Phase4_WinOnCoralBiome" },                               // Coral Forest - Win a game on the Coral Forest biome.
		{ GoalTypes.UniqueGoal_Phase4_WinOnCursedBiome, "UniqueGoal_Phase4_WinOnCursedBiome" },                             // Cursed Lands 2 - Win 2 games on the Cursed Royal Woodlands biome.
		{ GoalTypes.UniqueGoal_Phase4_WinOnFaction, "UniqueGoal_Phase4_WinOnFaction" },                                     // Rivalry 3 - Win 6 games on faction markers.
		{ GoalTypes.UniqueGoal_Phase4_WinWithHearths, "UniqueGoal_Phase4_WinWithHearths" },                                 // Expansion - Win a game with 4 Makeshift Hearths built.
		{ GoalTypes.UniqueGoal_Phase4_WinWithMines, "UniqueGoal_Phase4_WinWithMines" },                                     // Industry - Win a game with 5 Mines built.
		{ GoalTypes.UniqueGoal_Phase4_WinWithoutImpatience, "UniqueGoal_Phase4_WinWithoutImpatience" },                     // The Patient Queen 2 - Don't let the Queen's Impatience grow above 4 in a single game.
		{ GoalTypes.UniqueGoal_Phase5_WinOnCursedBiome, "UniqueGoal_Phase5_WinOnCursedBiome" },                             // Cursed Lands 3 - Win 3 games on the Cursed Royal Woodlands biome.
		{ GoalTypes.UniqueGoal_Phase5_WinWithBlightrot, "UniqueGoal_Phase5_WinWithBlightrot" },                             // Blood Flower Farmer - Win a game with 3 active Blood Flower clones on the map.
		{ GoalTypes.UniqueGoal_Phase5_WinWithoutImpatience, "UniqueGoal_Phase5_WinWithoutImpatience" },                     // The Patient Queen 3 - Don't let the Queen's Impatience grow above 2 in a single game.
		{ GoalTypes.UniqueGoal_Phase5_WinWithResolve, "UniqueGoal_Phase5_WinWithResolve" },                                 // Victory Through Prosperity - Earn 14 Reputation Points through Resolve in a single game.
		{ GoalTypes.UniqueGoal_Phase5_WinWithTools, "UniqueGoal_Phase5_WinWithTools" },                                     // Tool Hoarder - Win a game with 20 Infused Tools in the Warehouse.
		{ GoalTypes.UniqueGoal_Phase5_WinWithVaults, "UniqueGoal_Phase5_WinWithVaults" },                                   // Ancient Vaults - Win a game with 2 active Open Vaults on the map.
		{ GoalTypes.WE_Deed_Complete_Trade_Routes_Of_Value_In_Years, "[WE] Deed Complete Trade Routes Of Value In Years" }, // Commenda Contract - Win a game before year 8 ends, after completing trade routes worth 150 <sprite name="[valuable] amber"> Amber in total.
		{ GoalTypes.WE_Deed_Win_With_Amber, "[WE] Deed Win With Amber" },                                                   // Bankrupt Trader - Win a game with 150 Amber in your Warehouse.
		{ GoalTypes.WE_Deed_Win_With_Amber_In_Years, "[WE] Deed Win With Amber In Years" },                                 // Bankrupt Trader - Win a game before year 8 ends, with 250 Amber in your warehouse.
		{ GoalTypes.WE_Deed_Win_With_Forbidden_Events_Solved, "[WE] Deed Win With Forbidden Events Solved" },               // Obsidian Loremaster - Win a game after solving 2 Forbidden Events.
		{ GoalTypes.WE_Deed_Win_With_Less_Than_3_Dang_Glades, "[WE] Deed Win With Less Than 3 Dang Glades" },               // Somber Procession - Win a game after opening no more than 1 Dangerous or Forbidden Glade.
		{ GoalTypes.WE_Deed_Win_With_Villagers_Dying, "[WE] Deed Win With Villagers Dying" },                               // Followers of the Forsaken Gods - Win a game before year 8 ends, after 10 villagers have died.
		{ GoalTypes.WE_Deed_Win_With_Water, "[WE] Deed Win With Water" },                                                   // Crashed Airship - Win a game before year 8 ends, with 300 Storm Water in your warehouse.
		{ GoalTypes.WE_Deed_Win_Without_Leaving, "[WE] Deed Win Without Leaving" },                                         // Hanged Viceroy - Win a game with no villagers leaving.
		{ GoalTypes.WE_Win_With_Hubs, "[WE] Win With Hubs" },                                                               // Brass Order Engineers - Win a game before year 9 ends, while having 3 Hearths in your settlement upgraded to level: District (Level 3).
		{ GoalTypes.Win_Game_With_Modifier_Abandoned_Settlement, "Win Game With Modifier - Abandoned Settlement" },         // Abandoned Settlement - Win a game near the Abandoned Settlement modifier.
		{ GoalTypes.Win_Game_With_Modifier_Altar, "Win Game With Modifier - Altar" },                                       // Fishmen Ritual Site - Win a game near the Fishmen Ritual Site modifier.
		{ GoalTypes.Win_Game_With_Modifier_Armory, "Win Game With Modifier - Armory" },                                     // Ruined Armory - Win a game near the Ruined Armory modifier.
		{ GoalTypes.Win_Game_With_Modifier_Battleground, "Win Game With Modifier - Battleground" },                         // Ancient Battleground - Win a game near the Ancient Battleground modifier.
		{ GoalTypes.Win_Game_With_Modifier_Crystals, "Win Game With Modifier - Crystals" },                                 // Sparkdew Crystals - Win a game near the Sparkdew Crystals modifier.
		{ GoalTypes.Win_Game_With_Modifier_Dangerous, "Win Game With Modifier - Dangerous" },                               // Dangerous Lands - Win a game near the Dangerous Lands modifier.
		{ GoalTypes.Win_Game_With_Modifier_Forbidden, "Win Game With Modifier - Forbidden" },                               // Forbidden Lands - Win a game near the Forbidden Lands modifier.
		{ GoalTypes.Win_Game_With_Modifier_Frosts, "Win Game With Modifier - Frosts" },                                     // Frosts - Win a game near the Frosts modifier.
		{ GoalTypes.Win_Game_With_Modifier_Gathering_Storm, "Win Game With Modifier - Gathering Storm" },                   // Gathering Storm - Win a game near the Gathering Storm modifier.
		{ GoalTypes.Win_Game_With_Modifier_Haunted, "Win Game With Modifier - Haunted" },                                   // Haunted Forest - Win a game near the Haunted Forest modifier.
		{ GoalTypes.Win_Game_With_Modifier_Land_Of_Greed, "Win Game With Modifier - Land Of Greed" },                       // Land of Greed - Win a game near the Land of Greed modifier.
		{ GoalTypes.Win_Game_With_Modifier_Levitating, "Win Game With Modifier - Levitating" },                             // Levitating Monument - Win a game near the Levitating Monument modifier.
		{ GoalTypes.Win_Game_With_Modifier_Mine, "Win Game With Modifier - Mine" },                                         // Flooded Mines - Win a game near the Flooded Mines modifier.
		{ GoalTypes.Win_Game_With_Modifier_Monastery, "Win Game With Modifier - Monastery" },                               // Monastery of the Holy Flame - Win a game near the Monastery of the Holy Flame modifier.
		{ GoalTypes.Win_Game_With_Modifier_Ominous_Presence, "Win Game With Modifier - Ominous Presence" },                 // Ominous Presence - Win a game near the Ominous Presence modifier.
		{ GoalTypes.Win_Game_With_Modifier_Outpost, "Win Game With Modifier - Outpost" },                                   // Royal Outpost - Win a game near the Royal Outpost modifier.
		{ GoalTypes.Win_Game_With_Modifier_Overgrown_Library, "Win Game With Modifier - Overgrown Library" },               // Overgrown Library - Win a game near the Overgrown Library modifier.
		{ GoalTypes.Win_Game_With_Modifier_Petrified_Necropolis, "Win Game With Modifier - Petrified Necropolis" },         // Petrified Necropolis - Win a game near the Petrified Necropolis modifier.
		{ GoalTypes.Win_Game_With_Modifier_Statue, "Win Game With Modifier - Statue" },                                     // Statue of the Forefathers - Win a game near the Statue of the Forefathers modifier.
		{ GoalTypes.Win_Game_With_Modifier_Temple, "Win Game With Modifier - Temple" },                                     // Forsaken Gods Temple - Win a game near the Forsaken Gods Temple modifier.
		{ GoalTypes.Win_Game_With_Modifier_Torrent, "Win Game With Modifier - Torrent" },                                   // Corrosive Torrent - Win a game near the Corrosive Torrent modifier.
		{ GoalTypes.Win_Game_With_Modifier_Untamed_Wilds, "Win Game With Modifier - Untamed Wilds" },                       // Untamed Wilds - Win a game near the Untamed Wilds modifier.
		{ GoalTypes.Win_Game_With_Modifier_Watchtower, "Win Game With Modifier - Watchtower" },                             // Watchtower - Win a game near the Watchtower modifier.

	};
}
