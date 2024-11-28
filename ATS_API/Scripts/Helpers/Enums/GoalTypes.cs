using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model.Goals;

namespace ATS_API.Helpers;

// Generated using Version 1.5.2R
public enum GoalTypes
{
	Unknown = -1,
	None,
	
	/// <summary>
	/// The Emberwright - Create 20 experimental cornerstones in the Ashen Thicket.
	/// </summary>
	/// <name>Deed Craft Cornerstones</name>
	Deed_Craft_Cornerstones,

	/// <summary>
	/// Feeling Lucky - Obtain the Rainpunk Foundry blueprint from an expedition in the Coastal Grove.
	/// </summary>
	/// <name>Deed Foundry in Bay</name>
	Deed_Foundry_In_Bay,

	/// <summary>
	/// Fox Settlement - Win a game with at least 25 Foxes.
	/// </summary>
	/// <name>Deed Fox Population</name>
	Deed_Fox_Population,

	/// <summary>
	/// Frog Settlement - Win a game with at least 30 Frogs.
	/// </summary>
	/// <name>Deed Frog Population</name>
	Deed_Frog_Population,

	/// <summary>
	/// Harpy Settlement - Win a game with at least 25 Harpies.
	/// </summary>
	/// <name>Deed Harpy Population</name>
	Deed_Harpy_Population,

	/// <summary>
	/// Feeling Extremely Lucky - You must have a PhD in mathematics. Awarded for obtaining the Homestead and Rainpunk Foundry blueprints from expeditions in the Coastal Grove (in one game).
	/// </summary>
	/// <name>Deed Homestead and Foundry</name>
	Deed_Homestead_And_Foundry,

	/// <summary>
	/// The Adamantine Seal - Reforge the Adamantine Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Adamantine</name>
	Deed_Reforge_Seal_Adamantine,

	/// <summary>
	/// The Bronze Seal - Reforge the Bronze Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Bronze</name>
	Deed_Reforge_Seal_Bronze,

	/// <summary>
	/// The Cobalt Seal - Reforge the Cobalt Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Cobalt</name>
	Deed_Reforge_Seal_Cobalt,

	/// <summary>
	/// The Gold Seal - Reforge the Gold Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Gold</name>
	Deed_Reforge_Seal_Gold,

	/// <summary>
	/// The Lead Seal - Reforge the Lead Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Lead</name>
	Deed_Reforge_Seal_Lead,

	/// <summary>
	/// The Platinum Seal - Reforge the Platinum Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Platinum</name>
	Deed_Reforge_Seal_Platinum,

	/// <summary>
	/// The Silver Seal - Reforge the Silver Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Silver</name>
	Deed_Reforge_Seal_Silver,

	/// <summary>
	/// The Titanium Seal - Reforge the Titanium Seal.
	/// </summary>
	/// <name>Deed Reforge Seal Titanium</name>
	Deed_Reforge_Seal_Titanium,

	/// <summary>
	/// Apprentice Archaeologist 1 - Win a game with a reconstructed Smoldering Scorpion skeleton in the Scarlet Orchard.
	/// </summary>
	/// <name>Deed Scorpion</name>
	Deed_Scorpion,

	/// <summary>
	/// Strider Rider - Send out 100 expeditions in the Coastal Grove.
	/// </summary>
	/// <name>Deed Send Expeditions</name>
	Deed_Send_Expeditions,

	/// <summary>
	/// The Search Continues - Send out 12 expeditions in one game in the Coastal Grove.
	/// </summary>
	/// <name>Deed Send Expeditions In One Game</name>
	Deed_Send_Expeditions_In_One_Game,

	/// <summary>
	/// Apprentice Archaeologist 2 - Win a game with a reconstructed Sea Serpent skeleton in the Scarlet Orchard.
	/// </summary>
	/// <name>Deed Snake</name>
	Deed_Snake,

	/// <summary>
	/// Apprentice Archaeologist 3 - Win a game with a reconstructed Sealed Spider skeleton in the Scarlet Orchard.
	/// </summary>
	/// <name>Deed Spider</name>
	Deed_Spider,

	/// <summary>
	/// Master Archaeologist - Win a game with all three skeletons reconstructed in the Scarlet Orchard.
	/// </summary>
	/// <name>Deed Spider Snake Scorpion</name>
	Deed_Spider_Snake_Scorpion,

	/// <summary>
	/// Rushed Delivery 1 - Complete 5 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 1</name>
	Deed_Timed_Orders_1,

	/// <summary>
	/// Rushed Delivery 2 - Complete 15 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 2</name>
	Deed_Timed_Orders_2,

	/// <summary>
	/// Rushed Delivery 3 - Complete 30 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 3</name>
	Deed_Timed_Orders_3,

	/// <summary>
	/// Rushed Delivery 4 - Complete 50 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 4</name>
	Deed_Timed_Orders_4,

	/// <summary>
	/// Rushed Delivery 5 - Complete 75 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 5</name>
	Deed_Timed_Orders_5,

	/// <summary>
	/// Rushed Delivery 6 - Complete 100 timed orders.
	/// </summary>
	/// <name>Deed Timed Orders 6</name>
	Deed_Timed_Orders_6,

	/// <summary>
	/// Export Expert 1 - Complete 10 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 1</name>
	Deed_Trade_Routes_1,

	/// <summary>
	/// Export Expert 2 - Complete 30 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 2</name>
	Deed_Trade_Routes_2,

	/// <summary>
	/// Export Expert 3 - Complete 80 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 3</name>
	Deed_Trade_Routes_3,

	/// <summary>
	/// Export Expert 4 - Complete 150 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 4</name>
	Deed_Trade_Routes_4,

	/// <summary>
	/// Export Expert 5 - Complete 250 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 5</name>
	Deed_Trade_Routes_5,

	/// <summary>
	/// Export Expert 6 - Complete 400 trade routes.
	/// </summary>
	/// <name>Deed Trade Routes 6</name>
	Deed_Trade_Routes_6,

	/// <summary>
	/// Frog Republic - Upgrade 12 Frog Houses to the maximum level in one game.
	/// </summary>
	/// <name>Deed Upgrade Frog Houses</name>
	Deed_Upgrade_Frog_Houses,

	/// <summary>
	/// Renovator - Upgrade any buildings in your settlements 80 times.
	/// </summary>
	/// <name>Deed Upgrades Bought</name>
	Deed_Upgrades_Bought,

	/// <summary>
	/// Taking the Bait - Use 500 ground bait in Fishing Huts.
	/// </summary>
	/// <name>Deed Use Bait</name>
	Deed_Use_Bait,

	/// <summary>
	/// The Ashen Thicket - Win a game on the Ashen Thicket biome.
	/// </summary>
	/// <name>Deed Win Ashen Thicket</name>
	Deed_Win_Ashen_Thicket,

	/// <summary>
	/// Miner's Paradise - Win a game in the Ashen Thicket biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Ashen Thicket Impossible</name>
	Deed_Win_Ashen_Thicket_Impossible,

	/// <summary>
	/// The Coastal Grove - Win a game on the Coastal Grove biome.
	/// </summary>
	/// <name>Deed Win Coastal Grove</name>
	Deed_Win_Coastal_Grove,

	/// <summary>
	/// Salty Breeze - Win a game in the Coastal Grove biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Coastal Grove Impossible</name>
	Deed_Win_Coastal_Grove_Impossible,

	/// <summary>
	/// The Reef - Win a game in the Coral Forest biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Coral Impossible</name>
	Deed_Win_Coral_Impossible,

	/// <summary>
	/// Thick Clouds - Win a game in the Cursed Royal Woodlands biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Cursed Impossible</name>
	Deed_Win_Cursed_Impossible,

	/// <summary>
	/// Overcoming Difficulty - Win a game on Pioneer difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Hard</name>
	Deed_Win_Game_Hard,

	/// <summary>
	/// Against All Odds - Win a game on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Impossible</name>
	Deed_Win_Game_Impossible,

	/// <summary>
	/// Homesick 2 - Win a game in 3 years or less.
	/// </summary>
	/// <name>Deed Win Game In 3 Years</name>
	Deed_Win_Game_In_3_Years,

	/// <summary>
	/// Homesick 1 - Win a game in 5 years or less.
	/// </summary>
	/// <name>Deed Win Game In 5 Years</name>
	Deed_Win_Game_In_5_Years,

	/// <summary>
	/// Prestigious Expedition  1 - Win a game on Prestige 1 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 1</name>
	Deed_Win_Game_Prestige_1,

	/// <summary>
	/// Prestigious Expedition 10 - Win a game on Prestige 10 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 10</name>
	Deed_Win_Game_Prestige_10,

	/// <summary>
	/// Prestigious Expedition 11 - Win a game on Prestige 11 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 11</name>
	Deed_Win_Game_Prestige_11,

	/// <summary>
	/// Prestigious Expedition 12 - Win a game on Prestige 12 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 12</name>
	Deed_Win_Game_Prestige_12,

	/// <summary>
	/// Prestigious Expedition 13 - Win a game on Prestige 13 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 13</name>
	Deed_Win_Game_Prestige_13,

	/// <summary>
	/// Prestigious Expedition 14 - Win a game on Prestige 14 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 14</name>
	Deed_Win_Game_Prestige_14,

	/// <summary>
	/// Prestigious Expedition 15 - Win a game on Prestige 15 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 15</name>
	Deed_Win_Game_Prestige_15,

	/// <summary>
	/// Prestigious Expedition 16 - Win a game on Prestige 16 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 16</name>
	Deed_Win_Game_Prestige_16,

	/// <summary>
	/// Prestigious Expedition 17 - Win a game on Prestige 17 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 17</name>
	Deed_Win_Game_Prestige_17,

	/// <summary>
	/// Prestigious Expedition 18 - Win a game on Prestige 18 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 18</name>
	Deed_Win_Game_Prestige_18,

	/// <summary>
	/// Prestigious Expedition 19 - Win a game on Prestige 19 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 19</name>
	Deed_Win_Game_Prestige_19,

	/// <summary>
	/// Prestigious Expedition  2 - Win a game on Prestige 2 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 2</name>
	Deed_Win_Game_Prestige_2,

	/// <summary>
	/// Prestigious Expedition 20 - Win a game on Prestige 20 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 20</name>
	Deed_Win_Game_Prestige_20,

	/// <summary>
	/// Prestigious Expedition  3 - Win a game on Prestige 3 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 3</name>
	Deed_Win_Game_Prestige_3,

	/// <summary>
	/// Prestigious Expedition  4 - Win a game on Prestige 4 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 4</name>
	Deed_Win_Game_Prestige_4,

	/// <summary>
	/// Prestigious Expedition  5 - Win a game on Prestige 5 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 5</name>
	Deed_Win_Game_Prestige_5,

	/// <summary>
	/// Prestigious Expedition  6 - Win a game on Prestige 6 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 6</name>
	Deed_Win_Game_Prestige_6,

	/// <summary>
	/// Prestigious Expedition  7 - Win a game on Prestige 7 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 7</name>
	Deed_Win_Game_Prestige_7,

	/// <summary>
	/// Prestigious Expedition  8 - Win a game on Prestige 8 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 8</name>
	Deed_Win_Game_Prestige_8,

	/// <summary>
	/// Prestigious Expedition  9 - Win a game on Prestige 9 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Prestige 9</name>
	Deed_Win_Game_Prestige_9,

	/// <summary>
	/// A Real Challenge - Win a game on Veteran difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game Very Hard</name>
	Deed_Win_Game_Very_Hard,

	/// <summary>
	/// Thorough Exploration - Win a game with 30 or more glades discovered, on Pioneer difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Game With Glades</name>
	Deed_Win_Game_With_Glades,

	/// <summary>
	/// Like a Machine - Win a game after completing 3 timed orders.
	/// </summary>
	/// <name>Deed Win Game With Timed Orders</name>
	Deed_Win_Game_With_Timed_Orders,

	/// <summary>
	/// Trade Baron - Win a game after completing 20 trade routes.
	/// </summary>
	/// <name>Deed Win Game With Trade Routes</name>
	Deed_Win_Game_With_Trade_Routes,

	/// <summary>
	/// Deadly Spores - Win a game in the Marshlands biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Marshlands Impossible</name>
	Deed_Win_Marshlands_Impossible,

	/// <summary>
	/// It's Wednesday - Win a game with Frogs on a Wednesday.
	/// </summary>
	/// <name>Deed Win on Wednesday</name>
	Deed_Win_On_Wednesday,

	/// <summary>
	/// The Queen's Hand - Complete the Queen's Hand Trial.
	/// </summary>
	/// <name>Deed Win Queens Hand</name>
	Deed_Win_Queens_Hand,

	/// <summary>
	/// Crimson Soil - Win a game in the Scarlet Orchard biome, and on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Scarlet Impossible</name>
	Deed_Win_Scarlet_Impossible,

	/// <summary>
	/// Serving Ale - Win with: 1 x Small Farm, 1 x Brewery, 1 x Tavern, on the difficulty: Veteran.
	/// </summary>
	/// <name>Deed Win With Ale Chain</name>
	Deed_Win_With_Ale_Chain,

	/// <summary>
	/// Paradise - Ensure all villagers have all their needs fulfilled simultaneously.
	/// </summary>
	/// <name>Deed Win With All Needs</name>
	Deed_Win_With_All_Needs,

	/// <summary>
	/// Trade Connections - Win a game with 400 Amber in your Warehouse.
	/// </summary>
	/// <name>Deed Win With Amber</name>
	Deed_Win_With_Amber,

	/// <summary>
	/// Beaver Utopia - Win a game with 30 Beavers, 15 x Beaver House, 1 x Guild House
	/// </summary>
	/// <name>Deed Win With Beavers</name>
	Deed_Win_With_Beavers,

	/// <summary>
	/// Treasure - Win a game after opening or sending 20 Abandoned Caches to the Citadel.
	/// </summary>
	/// <name>Deed Win With Caches</name>
	Deed_Win_With_Caches,

	/// <summary>
	/// Devil's Bargain - Win a game after 20 villagers have died.
	/// </summary>
	/// <name>Deed Win With Dead Villagers</name>
	Deed_Win_With_Dead_Villagers,

	/// <summary>
	/// High Price - Win a game after 15 villagers died, on Prestige 18 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win With Dead Villagers Prestige</name>
	Deed_Win_With_Dead_Villagers_Prestige,

	/// <summary>
	/// Feeding The People - Ensure all villagers have all their Complex Food needs fulfilled simultaneously.
	/// </summary>
	/// <name>Deed Win With Food Needs</name>
	Deed_Win_With_Food_Needs,

	/// <summary>
	/// Fox Utopia - Win a game with 30 Foxes, 15 x Fox House, 1 x Tea Doctor
	/// </summary>
	/// <name>Deed Win With Foxes</name>
	Deed_Win_With_Foxes,

	/// <summary>
	/// Frog Utopia - Win a game with 40 Frogs, 20 x Frog House, 1 x Forum
	/// </summary>
	/// <name>Deed Win With Frogs</name>
	Deed_Win_With_Frogs,

	/// <summary>
	/// Harpy Utopia - Win a game with 30 Harpies, 15 x Harpy House, 1 x Bath House
	/// </summary>
	/// <name>Deed Win With Harpies</name>
	Deed_Win_With_Harpies,

	/// <summary>
	/// Human Utopia - Win a game with 30 Humans, 15 x Human House, 1 x Temple
	/// </summary>
	/// <name>Deed Win With Humans</name>
	Deed_Win_With_Humans,

	/// <summary>
	/// Lizard Utopia - Win a game with 30 Lizards, 15 x Lizard House, 1 x Clan Hall
	/// </summary>
	/// <name>Deed Win With Lizards</name>
	Deed_Win_With_Lizards,

	/// <summary>
	/// Efficient Explorer - Win a game after completing 25 Glade Events.
	/// </summary>
	/// <name>Deed Win With Many Events</name>
	Deed_Win_With_Many_Events,

	/// <summary>
	/// Refinery - Win with: 1 x Mine, 1 x Smelter, 1 x Smithy, on the difficulty: Veteran.
	/// </summary>
	/// <name>Deed Win With Metal Chain</name>
	Deed_Win_With_Metal_Chain,

	/// <summary>
	/// Tempest - Win a game with no dead villagers on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win With No Deaths Impossible</name>
	Deed_Win_With_No_Deaths_Impossible,

	/// <summary>
	/// The Marketplace - Win a game with 50 villagers, 1 x Temple, 1 x Market
	/// </summary>
	/// <name>Deed Win With Population And Services</name>
	Deed_Win_With_Population_And_Services,

	/// <summary>
	/// A True Leader - Earn 18 Reputation Points through villagers’ Resolve in a single game on Prestige 1 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win With Reputation Prestige</name>
	Deed_Win_With_Reputation_Prestige,

	/// <summary>
	/// Ruins - Win a game after taking care of 10 ruins found in glades.
	/// </summary>
	/// <name>Deed Win With Ruins</name>
	Deed_Win_With_Ruins,

	/// <summary>
	/// Higher Needs - Ensure all villagers have all their Services needs fulfilled simultaneously.
	/// </summary>
	/// <name>Deed Win With Service Needs</name>
	Deed_Win_With_Service_Needs,

	/// <summary>
	/// Totem Hunter - Win with: 1 x Converted Rain Totem, 1 x Converted Totem of Denial, on the difficulty: Veteran.
	/// </summary>
	/// <name>Deed Win With Totems</name>
	Deed_Win_With_Totems,

	/// <summary>
	/// Traveling Light - Win a game without taking any Embarkation Bonuses on Viceroy difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Without Bonus Impossible</name>
	Deed_Win_Without_Bonus_Impossible,

	/// <summary>
	/// Unnecessary Burden - Win a game without taking any Embarkation Bonuses on Prestige 10 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Without Bonus Prestige</name>
	Deed_Win_Without_Bonus_Prestige,

	/// <summary>
	/// No Loot Boxes - Win a game without opening or sending any Abandoned Caches to the Citadel.
	/// </summary>
	/// <name>Deed Win Without Caches</name>
	Deed_Win_Without_Caches,

	/// <summary>
	/// No Strangers - Win a game without completing any encampment events.
	/// </summary>
	/// <name>Deed Win Without Camps</name>
	Deed_Win_Without_Camps,

	/// <summary>
	/// Playing It Safe - Win a game without discovering a Dangerous or Forbidden Glade, on Pioneer difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Without Dangerous Glades</name>
	Deed_Win_Without_Dangerous_Glades,

	/// <summary>
	/// Immovable Viceroy - Win a game without discovering any glades.
	/// </summary>
	/// <name>Deed Win Without Glades</name>
	Deed_Win_Without_Glades,

	/// <summary>
	/// Independent Viceroy - Win a game without completing any orders on Prestige 1 difficulty (or higher).
	/// </summary>
	/// <name>Deed Win Without Orders Prestige</name>
	Deed_Win_Without_Orders_Prestige,

	/// <summary>
	/// Into the Forest - Win after discovering 2 Dangerous Glades before the end of Year 1, on Pioneer difficulty.
	/// </summary>
	/// <name>Deed Year 1 Dangerous</name>
	Deed_Year_1_Dangerous,

	/// <summary>
	/// Outstanding Move - Win a game after discovering a Forbidden Glade before the end of Year 1, on Veteran difficulty (or higher).
	/// </summary>
	/// <name>Deed Year 1 Forbidden</name>
	Deed_Year_1_Forbidden,

	/// <summary>
	/// Stalking Shadows - Win a game after discovering a Forbidden Glade before the end of Year 2, on Pioneer difficulty (or higher).
	/// </summary>
	/// <name>Deed Year 2 Forbidden</name>
	Deed_Year_2_Forbidden,

	/// <summary>
	/// First Steps - Finish your first game after the tutorial.
	/// </summary>
	/// <name>Finish One Game</name>
	Finish_One_Game,

	/// <summary>
	/// The Fool - Attack him yourself next time and rid us of your stupidity. Awarded for attacking Sir Renwald Redmane.
	/// </summary>
	/// <name>[H] Assault Royal Trader</name>
	H_Assault_Royal_Trader,

	/// <summary>
	/// Red Chase - <i>One day, the world will be theirs again.</i> Awarded for completing any Archaeological Discovery in the Scarlet Orchard in less than 25 minutes on Prestige 20 difficulty.
	/// </summary>
	/// <name>[H] Complete Skeleton In Time</name>
	H_Complete_Skeleton_In_Time,

	/// <summary>
	/// Jinxed - Ever thought of buying a lottery ticket? Awarded for stumbling upon 2 Forbidden Glades in a row at the beginning of a game in the Cursed Royal Woodlands.
	/// </summary>
	/// <name>[H] Discover First Forbidden Glades</name>
	H_Discover_First_Forbidden_Glades,

	/// <summary>
	/// Chants from the Deep - <i>The moment the world remembers, it will unravel into nothingness.</i> Awarded for losing 10 villagers in a single game to the Forbidden Ritual effect.
	/// </summary>
	/// <name>[H] Kill Villagers With Ritual</name>
	H_Kill_Villagers_With_Ritual,

	/// <summary>
	/// The Appetizer - You just had to try it, didn't you? Awarded for "naturally" depleting a Dead Leviathan gathering node.
	/// </summary>
	/// <name>[H] Marhs Meat Depleted</name>
	H_Marhs_Meat_Depleted,

	/// <summary>
	/// The Rebel - Seek adversity, and the rest will follow. Awarded for completing 6 Forbidden Events in a single game.
	/// </summary>
	/// <name>[H] Win Game With Many Forbidden Events Solved</name>
	H_Win_Game_With_Many_Forbidden_Events_Solved,

	/// <summary>
	/// Arckmage's Challenge - <i>No more cutting! That's it!</i> Awarded for completing a settlement on Prestige 20 difficulty without cutting down a single tree.
	/// </summary>
	/// <name>[H] Win Game Without Cutting Trees</name>
	H_Win_Game_Without_Cutting_Trees,

	/// <summary>
	/// Crimson Farmer - It ain't much, but it's honest work. Awarded for completing a settlement after removing 20 Blood Flowers.
	/// </summary>
	/// <name>[H] Win Games With Blood Flowers Farmed</name>
	H_Win_Games_With_Blood_Flowers_Farmed,

	/// <summary>
	/// Speedrun - Why even bother balancing this game? Awarded for completing a settlement in 3 years (or less), on Prestige 20 difficulty.
	/// </summary>
	/// <name>[H] Win Highest Difficulty Fast</name>
	H_Win_Highest_Difficulty_Fast,

	/// <summary>
	/// Not On My Watch - That was actually quite impressive! Awarded for completing the Storm Ant Column world event on Prestige 20 difficulty without any villagers suffering the hunger effect.
	/// </summary>
	/// <name>[H] Win Storm Ants Without Hunger</name>
	H_Win_Storm_Ants_Without_Hunger,

	/// <summary>
	/// Orders From the Queen 1 - Complete 10 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase0_CompleteOrders</name>
	ScalingGoal_Phase0_CompleteOrders,

	/// <summary>
	/// Discovery 1 - Discover 10 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase0_GladeDiscovery</name>
	ScalingGoal_Phase0_GladeDiscovery,

	/// <summary>
	/// Rolling in Wealth 1 - Trade goods worth 50 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase0_TradeGoods</name>
	ScalingGoal_Phase0_TradeGoods,

	/// <summary>
	/// Orders From the Queen 2 - Complete 30 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase1_CompleteOrders</name>
	ScalingGoal_Phase1_CompleteOrders,

	/// <summary>
	/// Deeper Into the Wilds 1 - Build a settlement at least 4 fields away from the Citadel.
	/// </summary>
	/// <name>ScalingGoal_Phase1_DistanceFromCitadel</name>
	ScalingGoal_Phase1_DistanceFromCitadel,

	/// <summary>
	/// Discovery 2 - Discover 30 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase1_GladeDiscovery</name>
	ScalingGoal_Phase1_GladeDiscovery,

	/// <summary>
	/// Prosperity 1 - Collect 10 Reputation Points through villager Resolve.
	/// </summary>
	/// <name>ScalingGoal_Phase1_ReputationFromResolve</name>
	ScalingGoal_Phase1_ReputationFromResolve,

	/// <summary>
	/// Rolling in Wealth 2 - Trade goods worth 200 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase1_TradeGoods</name>
	ScalingGoal_Phase1_TradeGoods,

	/// <summary>
	/// Big Settlement 1 - Win a game with at least 40 villagers.
	/// </summary>
	/// <name>ScalingGoal_Phase1_WinWithPopulation</name>
	ScalingGoal_Phase1_WinWithPopulation,

	/// <summary>
	/// Orders From the Queen 3 - Complete 80 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase2_CompleteOrders</name>
	ScalingGoal_Phase2_CompleteOrders,

	/// <summary>
	/// Deeper Into the Wilds 2 - Build a settlement at least 6 fields away from the Citadel.
	/// </summary>
	/// <name>ScalingGoal_Phase2_DistanceFromCitadel</name>
	ScalingGoal_Phase2_DistanceFromCitadel,

	/// <summary>
	/// Discovery 3 - Discover 80 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase2_GladeDiscovery</name>
	ScalingGoal_Phase2_GladeDiscovery,

	/// <summary>
	/// Prosperity 2 - Collect 25 Reputation Points through villager Resolve.
	/// </summary>
	/// <name>ScalingGoal_Phase2_ReputationFromResolve</name>
	ScalingGoal_Phase2_ReputationFromResolve,

	/// <summary>
	/// Rolling in Wealth 3 - Trade goods worth 600 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase2_TradeGoods</name>
	ScalingGoal_Phase2_TradeGoods,

	/// <summary>
	/// Dice With Death 1 - Win a game with one Dangerous Glade Event still active.
	/// </summary>
	/// <name>ScalingGoal_Phase2_WinGameWithRelic</name>
	ScalingGoal_Phase2_WinGameWithRelic,

	/// <summary>
	/// Orders From the Queen 4 - Complete 150 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase3_CompleteOrders</name>
	ScalingGoal_Phase3_CompleteOrders,

	/// <summary>
	/// Deeper Into the Wilds 3 - Build a settlement at least 8 fields away from the Citadel.
	/// </summary>
	/// <name>ScalingGoal_Phase3_DistanceFromCitadel</name>
	ScalingGoal_Phase3_DistanceFromCitadel,

	/// <summary>
	/// Discovery 4 - Discover 150 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase3_GladeDiscovery</name>
	ScalingGoal_Phase3_GladeDiscovery,

	/// <summary>
	/// Prosperity 3 - Collect 50 Reputation Points through villager Resolve.
	/// </summary>
	/// <name>ScalingGoal_Phase3_ReputationFromResolve</name>
	ScalingGoal_Phase3_ReputationFromResolve,

	/// <summary>
	/// Rolling in Wealth 4 - Trade goods worth 1500 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase3_TradeGoods</name>
	ScalingGoal_Phase3_TradeGoods,

	/// <summary>
	/// Dice With Death 2 - Win a game with two Dangerous Glade Events still active.
	/// </summary>
	/// <name>ScalingGoal_Phase3_WinGameWithRelic</name>
	ScalingGoal_Phase3_WinGameWithRelic,

	/// <summary>
	/// Big Settlement 2 - Win a game with at least 60 villagers
	/// </summary>
	/// <name>ScalingGoal_Phase3_WinWithPopulation</name>
	ScalingGoal_Phase3_WinWithPopulation,

	/// <summary>
	/// Orders From the Queen 5 - Complete 250 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase4_CompleteOrders</name>
	ScalingGoal_Phase4_CompleteOrders,

	/// <summary>
	/// Deeper Into the Wilds 4 - Build a settlement at least 10 fields away from the Citadel.
	/// </summary>
	/// <name>ScalingGoal_Phase4_DistanceFromCitadel</name>
	ScalingGoal_Phase4_DistanceFromCitadel,

	/// <summary>
	/// Discovery 5 - Discover 250 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase4_GladeDiscovery</name>
	ScalingGoal_Phase4_GladeDiscovery,

	/// <summary>
	/// Prosperity 4 - Collect 80 Reputation Points through villager Resolve.
	/// </summary>
	/// <name>ScalingGoal_Phase4_ReputationFromResolve</name>
	ScalingGoal_Phase4_ReputationFromResolve,

	/// <summary>
	/// Rolling in Wealth 5 - Trade goods worth 3000 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase4_TradeGoods</name>
	ScalingGoal_Phase4_TradeGoods,

	/// <summary>
	/// Dice With Death 3 - Win a game with three Dangerous Glade Events still active.
	/// </summary>
	/// <name>ScalingGoal_Phase4_WinGameWithRelic</name>
	ScalingGoal_Phase4_WinGameWithRelic,

	/// <summary>
	/// Orders From the Queen 6 - Complete 400 orders.
	/// </summary>
	/// <name>ScalingGoal_Phase5_CompleteOrders</name>
	ScalingGoal_Phase5_CompleteOrders,

	/// <summary>
	/// Discovery 6 - Discover 400 glades.
	/// </summary>
	/// <name>ScalingGoal_Phase5_GladeDiscovery</name>
	ScalingGoal_Phase5_GladeDiscovery,

	/// <summary>
	/// Prosperity 5 - Collect 130 Reputation Points through villager Resolve.
	/// </summary>
	/// <name>ScalingGoal_Phase5_ReputationFromResolve</name>
	ScalingGoal_Phase5_ReputationFromResolve,

	/// <summary>
	/// Rolling in Wealth 6 - Trade goods worth 5000 Amber.
	/// </summary>
	/// <name>ScalingGoal_Phase5_TradeGoods</name>
	ScalingGoal_Phase5_TradeGoods,

	/// <summary>
	/// Dice With Death 4 - Win a game with four Dangerous Glade Events still active.
	/// </summary>
	/// <name>ScalingGoal_Phase5_WinGameWithRelic</name>
	ScalingGoal_Phase5_WinGameWithRelic,

	/// <summary>
	/// Fast Colonization - Win 3 games in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase2_WinGames</name>
	TimedGoal_Phase2_WinGames,

	/// <summary>
	/// Prosperous Cycle - Collect 15 Reputation Points from Resolve in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase3_ReputationFromResolve</name>
	TimedGoal_Phase3_ReputationFromResolve,

	/// <summary>
	/// Cycle of the Fungi - Win 3 games on the Marshlands in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase3_WinGameOnMarshlands</name>
	TimedGoal_Phase3_WinGameOnMarshlands,

	/// <summary>
	/// Cycle of the Bloodrain - Win 3 games in the Scarlet Orchard in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase3_WinGamesOnMoorlands</name>
	TimedGoal_Phase3_WinGamesOnMoorlands,

	/// <summary>
	/// Establishing Borders - Win 3 games at least 6 fields away from the Citadel in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase4_DistanceFromCitadel</name>
	TimedGoal_Phase4_DistanceFromCitadel,

	/// <summary>
	/// Cycle of Discovery - Discover 50 glades in one cycle
	/// </summary>
	/// <name>TimedGoal_Phase4_GladeDiscovery</name>
	TimedGoal_Phase4_GladeDiscovery,

	/// <summary>
	/// Cycle of Wealth - Trade goods worth 400 Amber in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase4_TradeGoods</name>
	TimedGoal_Phase4_TradeGoods,

	/// <summary>
	/// Cycle of the Outlaw - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase4_WinNearBanditCamp</name>
	TimedGoal_Phase4_WinNearBanditCamp,

	/// <summary>
	/// Cycle of the Infestation - Win 2 times near different modifiers of the same type (Bandit Camp) in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase4_WinNearStonewood</name>
	TimedGoal_Phase4_WinNearStonewood,

	/// <summary>
	/// Cycle of the Wilds - Discover 20 Dangerous Glades in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase5_DangeroudGladeDiscovery</name>
	TimedGoal_Phase5_DangeroudGladeDiscovery,

	/// <summary>
	/// Cycle of the Storm - Win 2 times near different modifiers of the same type (Weather Anomaly) in one cycle.
	/// </summary>
	/// <name>TimedGoal_Phase5_WinNearWeatherAnomaly</name>
	TimedGoal_Phase5_WinNearWeatherAnomaly,

	/// <summary>
	/// Cycle of the Queen - Win 3 games in a cycle without reaching more than 4 Impatience.
	/// </summary>
	/// <name>TimedGoal_Phase5_WinWithoutImpatience</name>
	TimedGoal_Phase5_WinWithoutImpatience,

	/// <summary>
	/// Cycle of Defiance - Win 3 games in a cycle without completing any orders.
	/// </summary>
	/// <name>TimedGoal_Phase5_WinWithoutOrders</name>
	TimedGoal_Phase5_WinWithoutOrders,

	/// <summary>
	/// Safe Cycle - Win 3 games in a cycle without any villagers dying.
	/// </summary>
	/// <name>TimedGoal_Phase5_WinWithoutVillagerDying</name>
	TimedGoal_Phase5_WinWithoutVillagerDying,

	/// <summary>
	/// First Real Expedition - Win a game in the Royal Woodlands biome, and on Settler difficulty (or higher).
	/// </summary>
	/// <name>Tutorial Deed Win First Game</name>
	Tutorial_Deed_Win_First_Game,

	/// <summary>
	/// Taking Action - Win a game after completing 5 Glade Events.
	/// </summary>
	/// <name>Tutorial Deed Win With Events</name>
	Tutorial_Deed_Win_With_Events,

	/// <summary>
	/// Fertile Meadows - Win a game near the Fertile Grounds modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinGameNearFertileMeadows</name>
	UniqueGoal_Phase1_WinGameNearFertileMeadows,

	/// <summary>
	/// Stonewood Infestation - Win a game near the Stonewood Infestation modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinGameNearStonewood</name>
	UniqueGoal_Phase1_WinGameNearStonewood,

	/// <summary>
	/// Third Time's a Charm - Win 3 games
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinGames</name>
	UniqueGoal_Phase1_WinGames,

	/// <summary>
	/// Swamp Wheat Farmer - Win a game with 150 grain in the Warehouse.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinGameWithGrain</name>
	UniqueGoal_Phase1_WinGameWithGrain,

	/// <summary>
	/// Basic Logistics - Win a game with 200 paths built.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinGameWithPaths</name>
	UniqueGoal_Phase1_WinGameWithPaths,

	/// <summary>
	/// The Patient Queen 1 - Don't let the Queen's Impatience grow above 6 in a single game.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinWithoutImpatience</name>
	UniqueGoal_Phase1_WinWithoutImpatience,

	/// <summary>
	/// No Deaths - Win a game with 0 villagers dying.
	/// </summary>
	/// <name>UniqueGoal_Phase1_WinWithoutVillagersDying</name>
	UniqueGoal_Phase1_WinWithoutVillagersDying,

	/// <summary>
	/// Barren Lands - Win a game near the Barren Lands modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameNearBarren</name>
	UniqueGoal_Phase2_WinGameNearBarren,

	/// <summary>
	/// Lost Colonies - Win a game near the Ruins modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameNearRuins</name>
	UniqueGoal_Phase2_WinGameNearRuins,

	/// <summary>
	/// Rivalry 1 - Win 3 games on faction markers.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameOnFaction</name>
	UniqueGoal_Phase2_WinGameOnFaction,

	/// <summary>
	/// The Marshlands - Win a game on the Marshlands biome.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameOnMarshlands</name>
	UniqueGoal_Phase2_WinGameOnMarshlands,

	/// <summary>
	/// The Scarlet Orchard - Win a game on the Scarlet Orchard biome.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameOnMoorlands</name>
	UniqueGoal_Phase2_WinGameOnMoorlands,

	/// <summary>
	/// Defying the Crown - Win a game without completing any orders.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WinGameWithoutOrders</name>
	UniqueGoal_Phase2_WinGameWithoutOrders,

	/// <summary>
	/// Victory Through Resolve - Win a game having gained at least 5 Reputation Points through Resolve.
	/// </summary>
	/// <name>UniqueGoal_Phase2_WInGameWithResolve</name>
	UniqueGoal_Phase2_WInGameWithResolve,

	/// <summary>
	/// Bandit Camp - Win a game near the Bandit Camp modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinGameNearBanditCamp</name>
	UniqueGoal_Phase3_WinGameNearBanditCamp,

	/// <summary>
	/// Rivalry 2 - Win 4 games on faction markers.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinGameOnFaction</name>
	UniqueGoal_Phase3_WinGameOnFaction,

	/// <summary>
	/// Cursed Lands - Win a game on the Cursed Royal Woodlands biome.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinOnCursedBiome</name>
	UniqueGoal_Phase3_WinOnCursedBiome,

	/// <summary>
	/// Beaver Settlement - Win a game with at least 25 Beavers.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWithBeavers</name>
	UniqueGoal_Phase3_WinWithBeavers,

	/// <summary>
	/// Ancient Knowledge - Win a game with at least 5 Ancient Tablets in the Warehouse.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWithGoods</name>
	UniqueGoal_Phase3_WinWithGoods,

	/// <summary>
	/// Human Settlement - Win a game with at least 25 Humans.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWithHumans</name>
	UniqueGoal_Phase3_WinWithHumans,

	/// <summary>
	/// Lizard Settlement - Win a game with at least 25 Lizards.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWithLizards</name>
	UniqueGoal_Phase3_WinWithLizards,

	/// <summary>
	/// Rare Technology - Win a game with a restored Rainpunk Foundry in your settlement.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWIthRainpunk</name>
	UniqueGoal_Phase3_WinWIthRainpunk,

	/// <summary>
	/// Farming Specialization - Win a game with 5 Small Farms built.
	/// </summary>
	/// <name>UniqueGoal_Phase3_WinWithSmallFarms</name>
	UniqueGoal_Phase3_WinWithSmallFarms,

	/// <summary>
	/// Weather Anomaly - Win a game near the Weather Anomaly modifier.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinNearWeatherAnomaly</name>
	UniqueGoal_Phase4_WinNearWeatherAnomaly,

	/// <summary>
	/// Coral Forest - Win a game on the Coral Forest biome.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinOnCoralBiome</name>
	UniqueGoal_Phase4_WinOnCoralBiome,

	/// <summary>
	/// Cursed Lands 2 - Win 2 games on the Cursed Royal Woodlands biome.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinOnCursedBiome</name>
	UniqueGoal_Phase4_WinOnCursedBiome,

	/// <summary>
	/// Rivalry 3 - Win 6 games on faction markers.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinOnFaction</name>
	UniqueGoal_Phase4_WinOnFaction,

	/// <summary>
	/// Expansion - Win a game with 4 Makeshift Hearths built.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinWithHearths</name>
	UniqueGoal_Phase4_WinWithHearths,

	/// <summary>
	/// Industry - Win a game with 5 Mines built.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinWithMines</name>
	UniqueGoal_Phase4_WinWithMines,

	/// <summary>
	/// The Patient Queen 2 - Don't let the Queen's Impatience grow above 4 in a single game.
	/// </summary>
	/// <name>UniqueGoal_Phase4_WinWithoutImpatience</name>
	UniqueGoal_Phase4_WinWithoutImpatience,

	/// <summary>
	/// Cursed Lands 3 - Win 3 games on the Cursed Royal Woodlands biome.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinOnCursedBiome</name>
	UniqueGoal_Phase5_WinOnCursedBiome,

	/// <summary>
	/// Blood Flower Farmer - Win a game with 3 active Blood Flower clones on the map.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinWithBlightrot</name>
	UniqueGoal_Phase5_WinWithBlightrot,

	/// <summary>
	/// The Patient Queen 3 - Don't let the Queen's Impatience grow above 2 in a single game.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinWithoutImpatience</name>
	UniqueGoal_Phase5_WinWithoutImpatience,

	/// <summary>
	/// Victory Through Prosperity - Earn 14 Reputation Points through Resolve in a single game.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinWithResolve</name>
	UniqueGoal_Phase5_WinWithResolve,

	/// <summary>
	/// Tool Hoarder - Win a game with 20 Infused Tools in the Warehouse.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinWithTools</name>
	UniqueGoal_Phase5_WinWithTools,

	/// <summary>
	/// Ancient Vaults - Win a game with 2 active Open Vaults on the map.
	/// </summary>
	/// <name>UniqueGoal_Phase5_WinWithVaults</name>
	UniqueGoal_Phase5_WinWithVaults,

	/// <summary>
	/// Commenda Contract - Win a game before year 8 ends, after completing trade routes worth 150 "[valuable] amber" Amber in total.
	/// </summary>
	/// <name>[WE] Deed Complete Trade Routes Of Value In Years</name>
	WE_Deed_Complete_Trade_Routes_Of_Value_In_Years,

	/// <summary>
	/// Bankrupt Trader - Win a game with 150 Amber in your Warehouse.
	/// </summary>
	/// <name>[WE] Deed Win With Amber</name>
	WE_Deed_Win_With_Amber,

	/// <summary>
	/// Bankrupt Trader - Win a game before year 8 ends, with 250 Amber in your warehouse.
	/// </summary>
	/// <name>[WE] Deed Win With Amber In Years</name>
	WE_Deed_Win_With_Amber_In_Years,

	/// <summary>
	/// Obsidian Loremaster - Win a game after solving 2 Forbidden Events.
	/// </summary>
	/// <name>[WE] Deed Win With Forbidden Events Solved</name>
	WE_Deed_Win_With_Forbidden_Events_Solved,

	/// <summary>
	/// Somber Procession - Win a game after opening no more than 1 Dangerous or Forbidden Glade.
	/// </summary>
	/// <name>[WE] Deed Win With Less Than 3 Dang Glades</name>
	WE_Deed_Win_With_Less_Than_3_Dang_Glades,

	/// <summary>
	/// Followers of the Forsaken Gods - Win a game before year 8 ends, after 10 villagers have died.
	/// </summary>
	/// <name>[WE] Deed Win With Villagers Dying</name>
	WE_Deed_Win_With_Villagers_Dying,

	/// <summary>
	/// Crashed Airship - Win a game before year 8 ends, with 300 Storm Water in your warehouse.
	/// </summary>
	/// <name>[WE] Deed Win With Water</name>
	WE_Deed_Win_With_Water,

	/// <summary>
	/// Hanged Viceroy - Win a game with no villagers leaving.
	/// </summary>
	/// <name>[WE] Deed Win Without Leaving</name>
	WE_Deed_Win_Without_Leaving,

	/// <summary>
	/// Brass Order Engineers - Win a game before year 9 ends, while having 3 Hearths in your settlement upgraded to level: District (Level 3).
	/// </summary>
	/// <name>[WE] Win With Hubs</name>
	WE_Win_With_Hubs,

	/// <summary>
	/// Abandoned Settlement - Win a game near the Abandoned Settlement modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Abandoned Settlement</name>
	Win_Game_With_Modifier_Abandoned_Settlement,

	/// <summary>
	/// Fishmen Ritual Site - Win a game near the Fishmen Ritual Site modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Altar</name>
	Win_Game_With_Modifier_Altar,

	/// <summary>
	/// Ruined Armory - Win a game near the Ruined Armory modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Armory</name>
	Win_Game_With_Modifier_Armory,

	/// <summary>
	/// Ancient Battleground - Win a game near the Ancient Battleground modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Battleground</name>
	Win_Game_With_Modifier_Battleground,

	/// <summary>
	/// Sparkdew Crystals - Win a game near the Sparkdew Crystals modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Crystals</name>
	Win_Game_With_Modifier_Crystals,

	/// <summary>
	/// Dangerous Lands - Win a game near the Dangerous Lands modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Dangerous</name>
	Win_Game_With_Modifier_Dangerous,

	/// <summary>
	/// Forbidden Lands - Win a game near the Forbidden Lands modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Forbidden</name>
	Win_Game_With_Modifier_Forbidden,

	/// <summary>
	/// Frosts - Win a game near the Frosts modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Frosts</name>
	Win_Game_With_Modifier_Frosts,

	/// <summary>
	/// Gathering Storm - Win a game near the Gathering Storm modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Gathering Storm</name>
	Win_Game_With_Modifier_Gathering_Storm,

	/// <summary>
	/// Haunted Forest - Win a game near the Haunted Forest modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Haunted</name>
	Win_Game_With_Modifier_Haunted,

	/// <summary>
	/// Land of Greed - Win a game near the Land of Greed modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Land Of Greed</name>
	Win_Game_With_Modifier_Land_Of_Greed,

	/// <summary>
	/// Levitating Monument - Win a game near the Levitating Monument modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Levitating</name>
	Win_Game_With_Modifier_Levitating,

	/// <summary>
	/// Flooded Mines - Win a game near the Flooded Mines modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Mine</name>
	Win_Game_With_Modifier_Mine,

	/// <summary>
	/// Monastery of the Holy Flame - Win a game near the Monastery of the Holy Flame modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Monastery</name>
	Win_Game_With_Modifier_Monastery,

	/// <summary>
	/// Ominous Presence - Win a game near the Ominous Presence modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Ominous Presence</name>
	Win_Game_With_Modifier_Ominous_Presence,

	/// <summary>
	/// Royal Outpost - Win a game near the Royal Outpost modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Outpost</name>
	Win_Game_With_Modifier_Outpost,

	/// <summary>
	/// Overgrown Library - Win a game near the Overgrown Library modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Overgrown Library</name>
	Win_Game_With_Modifier_Overgrown_Library,

	/// <summary>
	/// Petrified Necropolis - Win a game near the Petrified Necropolis modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Petrified Necropolis</name>
	Win_Game_With_Modifier_Petrified_Necropolis,

	/// <summary>
	/// Statue of the Forefathers - Win a game near the Statue of the Forefathers modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Statue</name>
	Win_Game_With_Modifier_Statue,

	/// <summary>
	/// Forsaken Gods Temple - Win a game near the Forsaken Gods Temple modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Temple</name>
	Win_Game_With_Modifier_Temple,

	/// <summary>
	/// Corrosive Torrent - Win a game near the Corrosive Torrent modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Torrent</name>
	Win_Game_With_Modifier_Torrent,

	/// <summary>
	/// Untamed Wilds - Win a game near the Untamed Wilds modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Untamed Wilds</name>
	Win_Game_With_Modifier_Untamed_Wilds,

	/// <summary>
	/// Watchtower - Win a game near the Watchtower modifier.
	/// </summary>
	/// <name>Win Game With Modifier - Watchtower</name>
	Win_Game_With_Modifier_Watchtower,



	MAX = 232
}

public static class GoalTypesExtensions
{
	private static GoalTypes[] s_All = null;
	public static GoalTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new GoalTypes[232];
			for (int i = 0; i < 232; i++)
			{
				s_All[i] = (GoalTypes)(i+1);
			}
		}
		return s_All;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every GoalTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return GoalTypes.Deed_Craft_Cornerstones in the enum and log an error.
	/// </summary>
	public static string ToName(this GoalTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of GoalTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[GoalTypes.Deed_Craft_Cornerstones];
	}
	
	/// <summary>
	/// Returns a GoalTypes associated with the given name.
	/// Every GoalTypes should have a unique name as to distinguish it from others.
	/// If no GoalTypes is found, it will return GoalTypes.Unknown and log a warning.
	/// </summary>
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
	
	/// <summary>
	/// Returns a GoalModel associated with the given name.
	/// GoalModel contain all the data that will be used in the game.
	/// Every GoalModel should have a unique name as to distinguish it from others.
	/// If no GoalModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Goals.GoalModel ToGoalModel(this string name)
	{
		Eremite.Model.Goals.GoalModel model = SO.Settings.goals.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find GoalModel for GoalTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a GoalModel associated with the given GoalTypes.
    /// GoalModel contain all the data that will be used in the game.
    /// Every GoalModel should have a unique name as to distinguish it from others.
    /// If no GoalModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.Goals.GoalModel ToGoalModel(this GoalTypes types)
	{
		return types.ToName().ToGoalModel();
	}
	
	/// <summary>
	/// Returns an array of GoalModel associated with the given GoalTypes.
	/// GoalModel contain all the data that will be used in the game.
	/// Every GoalModel should have a unique name as to distinguish it from others.
	/// If a GoalModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Goals.GoalModel[] ToGoalModelArray(this IEnumerable<GoalTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.Goals.GoalModel[] array = new Eremite.Model.Goals.GoalModel[count];
		int i = 0;
		foreach (GoalTypes element in collection)
		{
			array[i++] = element.ToGoalModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoalModel associated with the given GoalTypes.
	/// GoalModel contain all the data that will be used in the game.
	/// Every GoalModel should have a unique name as to distinguish it from others.
	/// If a GoalModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Goals.GoalModel[] ToGoalModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.Goals.GoalModel[] array = new Eremite.Model.Goals.GoalModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToGoalModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of GoalModel associated with the given GoalTypes.
	/// GoalModel contain all the data that will be used in the game.
	/// Every GoalModel should have a unique name as to distinguish it from others.
	/// If a GoalModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Goals.GoalModel[] ToGoalModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.Goals.GoalModel>.Get(out List<Eremite.Model.Goals.GoalModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.Goals.GoalModel model = element.ToGoalModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of GoalModel associated with the given GoalTypes.
	/// GoalModel contain all the data that will be used in the game.
	/// Every GoalModel should have a unique name as to distinguish it from others.
	/// If a GoalModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Goals.GoalModel[] ToGoalModelArrayNoNulls(this IEnumerable<GoalTypes> collection)
	{
		using(ListPool<Eremite.Model.Goals.GoalModel>.Get(out List<Eremite.Model.Goals.GoalModel> list))
		{
			foreach (GoalTypes element in collection)
			{
				Eremite.Model.Goals.GoalModel model = element.ToGoalModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<GoalTypes, string> TypeToInternalName = new()
	{
		{ GoalTypes.Deed_Craft_Cornerstones, "Deed Craft Cornerstones" },                                                   // The Emberwright - Create 20 experimental cornerstones in the Ashen Thicket.
		{ GoalTypes.Deed_Foundry_In_Bay, "Deed Foundry in Bay" },                                                           // Feeling Lucky - Obtain the Rainpunk Foundry blueprint from an expedition in the Coastal Grove.
		{ GoalTypes.Deed_Fox_Population, "Deed Fox Population" },                                                           // Fox Settlement - Win a game with at least 25 Foxes.
		{ GoalTypes.Deed_Frog_Population, "Deed Frog Population" },                                                         // Frog Settlement - Win a game with at least 30 Frogs.
		{ GoalTypes.Deed_Harpy_Population, "Deed Harpy Population" },                                                       // Harpy Settlement - Win a game with at least 25 Harpies.
		{ GoalTypes.Deed_Homestead_And_Foundry, "Deed Homestead and Foundry" },                                             // Feeling Extremely Lucky - You must have a PhD in mathematics. Awarded for obtaining the Homestead and Rainpunk Foundry blueprints from expeditions in the Coastal Grove (in one game).
		{ GoalTypes.Deed_Reforge_Seal_Adamantine, "Deed Reforge Seal Adamantine" },                                         // The Adamantine Seal - Reforge the Adamantine Seal.
		{ GoalTypes.Deed_Reforge_Seal_Bronze, "Deed Reforge Seal Bronze" },                                                 // The Bronze Seal - Reforge the Bronze Seal.
		{ GoalTypes.Deed_Reforge_Seal_Cobalt, "Deed Reforge Seal Cobalt" },                                                 // The Cobalt Seal - Reforge the Cobalt Seal.
		{ GoalTypes.Deed_Reforge_Seal_Gold, "Deed Reforge Seal Gold" },                                                     // The Gold Seal - Reforge the Gold Seal.
		{ GoalTypes.Deed_Reforge_Seal_Lead, "Deed Reforge Seal Lead" },                                                     // The Lead Seal - Reforge the Lead Seal.
		{ GoalTypes.Deed_Reforge_Seal_Platinum, "Deed Reforge Seal Platinum" },                                             // The Platinum Seal - Reforge the Platinum Seal.
		{ GoalTypes.Deed_Reforge_Seal_Silver, "Deed Reforge Seal Silver" },                                                 // The Silver Seal - Reforge the Silver Seal.
		{ GoalTypes.Deed_Reforge_Seal_Titanium, "Deed Reforge Seal Titanium" },                                             // The Titanium Seal - Reforge the Titanium Seal.
		{ GoalTypes.Deed_Scorpion, "Deed Scorpion" },                                                                       // Apprentice Archaeologist 1 - Win a game with a reconstructed Smoldering Scorpion skeleton in the Scarlet Orchard.
		{ GoalTypes.Deed_Send_Expeditions, "Deed Send Expeditions" },                                                       // Strider Rider - Send out 100 expeditions in the Coastal Grove.
		{ GoalTypes.Deed_Send_Expeditions_In_One_Game, "Deed Send Expeditions In One Game" },                               // The Search Continues - Send out 12 expeditions in one game in the Coastal Grove.
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
		{ GoalTypes.Deed_Upgrade_Frog_Houses, "Deed Upgrade Frog Houses" },                                                 // Frog Republic - Upgrade 12 Frog Houses to the maximum level in one game.
		{ GoalTypes.Deed_Upgrades_Bought, "Deed Upgrades Bought" },                                                         // Renovator - Upgrade any buildings in your settlements 80 times.
		{ GoalTypes.Deed_Use_Bait, "Deed Use Bait" },                                                                       // Taking the Bait - Use 500 ground bait in Fishing Huts.
		{ GoalTypes.Deed_Win_Ashen_Thicket, "Deed Win Ashen Thicket" },                                                     // The Ashen Thicket - Win a game on the Ashen Thicket biome.
		{ GoalTypes.Deed_Win_Ashen_Thicket_Impossible, "Deed Win Ashen Thicket Impossible" },                               // Miner's Paradise - Win a game in the Ashen Thicket biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_Coastal_Grove, "Deed Win Coastal Grove" },                                                     // The Coastal Grove - Win a game on the Coastal Grove biome.
		{ GoalTypes.Deed_Win_Coastal_Grove_Impossible, "Deed Win Coastal Grove Impossible" },                               // Salty Breeze - Win a game in the Coastal Grove biome, and on Viceroy difficulty (or higher).
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
		{ GoalTypes.Deed_Win_Marshlands_Impossible, "Deed Win Marshlands Impossible" },                                     // Deadly Spores - Win a game in the Marshlands biome, and on Viceroy difficulty (or higher).
		{ GoalTypes.Deed_Win_On_Wednesday, "Deed Win on Wednesday" },                                                       // It's Wednesday - Win a game with Frogs on a Wednesday.
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
		{ GoalTypes.Deed_Win_With_Frogs, "Deed Win With Frogs" },                                                           // Frog Utopia - Win a game with 40 Frogs, 20 x Frog House, 1 x Forum
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
		{ GoalTypes.H_Assault_Royal_Trader, "[H] Assault Royal Trader" },                                                   // The Fool - Attack him yourself next time and rid us of your stupidity. Awarded for attacking Sir Renwald Redmane.
		{ GoalTypes.H_Complete_Skeleton_In_Time, "[H] Complete Skeleton In Time" },                                         // Red Chase - <i>One day, the world will be theirs again.</i> Awarded for completing any Archaeological Discovery in the Scarlet Orchard in less than 25 minutes on Prestige 20 difficulty.
		{ GoalTypes.H_Discover_First_Forbidden_Glades, "[H] Discover First Forbidden Glades" },                             // Jinxed - Ever thought of buying a lottery ticket? Awarded for stumbling upon 2 Forbidden Glades in a row at the beginning of a game in the Cursed Royal Woodlands.
		{ GoalTypes.H_Kill_Villagers_With_Ritual, "[H] Kill Villagers With Ritual" },                                       // Chants from the Deep - <i>The moment the world remembers, it will unravel into nothingness.</i> Awarded for losing 10 villagers in a single game to the Forbidden Ritual effect.
		{ GoalTypes.H_Marhs_Meat_Depleted, "[H] Marhs Meat Depleted" },                                                     // The Appetizer - You just had to try it, didn't you? Awarded for "naturally" depleting a Dead Leviathan gathering node.
		{ GoalTypes.H_Win_Game_With_Many_Forbidden_Events_Solved, "[H] Win Game With Many Forbidden Events Solved" },       // The Rebel - Seek adversity, and the rest will follow. Awarded for completing 6 Forbidden Events in a single game.
		{ GoalTypes.H_Win_Game_Without_Cutting_Trees, "[H] Win Game Without Cutting Trees" },                               // Arckmage's Challenge - <i>No more cutting! That's it!</i> Awarded for completing a settlement on Prestige 20 difficulty without cutting down a single tree.
		{ GoalTypes.H_Win_Games_With_Blood_Flowers_Farmed, "[H] Win Games With Blood Flowers Farmed" },                     // Crimson Farmer - It ain't much, but it's honest work. Awarded for completing a settlement after removing 20 Blood Flowers.
		{ GoalTypes.H_Win_Highest_Difficulty_Fast, "[H] Win Highest Difficulty Fast" },                                     // Speedrun - Why even bother balancing this game? Awarded for completing a settlement in 3 years (or less), on Prestige 20 difficulty.
		{ GoalTypes.H_Win_Storm_Ants_Without_Hunger, "[H] Win Storm Ants Without Hunger" },                                 // Not On My Watch - That was actually quite impressive! Awarded for completing the Storm Ant Column world event on Prestige 20 difficulty without any villagers suffering the hunger effect.
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
		{ GoalTypes.UniqueGoal_Phase2_WinGameOnMarshlands, "UniqueGoal_Phase2_WinGameOnMarshlands" },                       // The Marshlands - Win a game on the Marshlands biome.
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
		{ GoalTypes.WE_Deed_Complete_Trade_Routes_Of_Value_In_Years, "[WE] Deed Complete Trade Routes Of Value In Years" }, // Commenda Contract - Win a game before year 8 ends, after completing trade routes worth 150 "[valuable] amber" Amber in total.
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
