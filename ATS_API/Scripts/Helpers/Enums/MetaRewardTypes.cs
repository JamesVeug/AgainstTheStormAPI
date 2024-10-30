using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Meta;

namespace ATS_API.Helpers;

// Generated using Version 1.4.17R
public enum MetaRewardTypes
{
	Unknown = -1,
	None,
	Artifacts_10,                                              // CurrencyMetaRewardModel-Artifacts
	Artifacts_15,                                              // CurrencyMetaRewardModel-Artifacts
	Artifacts_20,                                              // CurrencyMetaRewardModel-Artifacts
	Artifacts_5,                                               // CurrencyMetaRewardModel-Artifacts
	Consumption_Control_Activation,                            // ConsumptionControlMetaRewardModel-Consumption Control
	Custom_Game_Activation,                                    // CustomGameMetaRewardModel-Training Expedition
	Essential_Big_Shelter,                                     // EssentialBuildingMetaRewardModel-Big Shelter
	Essential_Common_Hall,                                     // EssentialBuildingMetaRewardModel-Clan Hall
	Essential_Crude_Workstation,                               // EssentialBuildingMetaRewardModel-Crude Workstation
	Essential_Decor_Ancient_Arch,                              // EssentialBuildingMetaRewardModel-Ancient Arch
	Essential_Decor_Ancient_Gravestone,                        // EssentialBuildingMetaRewardModel-Ancient Tombstone
	Essential_Decor_Anvil,                                     // EssentialBuildingMetaRewardModel-Anvil
	Essential_Decor_Barrels,                                   // EssentialBuildingMetaRewardModel-Barrels
	Essential_Decor_Bonfire,                                   // EssentialBuildingMetaRewardModel-Bonfire
	Essential_Decor_Cages,                                     // EssentialBuildingMetaRewardModel-Cages
	Essential_Decor_Chest,                                     // EssentialBuildingMetaRewardModel-Chest
	Essential_Decor_Coastal_Plant,                             // EssentialBuildingMetaRewardModel-Saltwater Pitcher Plant
	Essential_Decor_Coral,                                     // EssentialBuildingMetaRewardModel-Coral Growth
	Essential_Decor_Crates,                                    // EssentialBuildingMetaRewardModel-Crates
	Essential_Decor_Fence,                                     // EssentialBuildingMetaRewardModel-Fence
	Essential_Decor_Fence_Corner,                              // EssentialBuildingMetaRewardModel-Fence Corner
	Essential_Decor_Fire_Shrine,                               // EssentialBuildingMetaRewardModel-Fire Shrine
	Essential_Decor_Fish,                                      // EssentialBuildingMetaRewardModel-Fish Mount
	Essential_Decor_Flower_Bed,                                // EssentialBuildingMetaRewardModel-Flower Bed
	Essential_Decor_Fox_Fence,                                 // EssentialBuildingMetaRewardModel-Overgrown Fence
	Essential_Decor_Fox_Fence_Corner,                          // EssentialBuildingMetaRewardModel-Overgrown Fence Corner
	Essential_Decor_Frog_Tree,                                 // EssentialBuildingMetaRewardModel-Evergreen Shrub
	Essential_Decor_Gate,                                      // EssentialBuildingMetaRewardModel-Gate
	Essential_Decor_Golden_Leaf,                               // EssentialBuildingMetaRewardModel-Golden Leaf Plant
	Essential_Decor_Lamp,                                      // EssentialBuildingMetaRewardModel-Lamp
	Essential_Decor_Lizard_Post,                               // EssentialBuildingMetaRewardModel-Lizard Post
	Essential_Decor_Marbe_Fountain,                            // EssentialBuildingMetaRewardModel-Marble Fountain
	Essential_Decor_Monument_Of_Greed,                         // EssentialBuildingMetaRewardModel-Monument of Greed
	Essential_Decor_Mushroom,                                  // EssentialBuildingMetaRewardModel-Decorative Fungus
	Essential_Decor_Nightfern,                                 // EssentialBuildingMetaRewardModel-Nightfern
	Essential_Decor_Ornate_Column,                             // EssentialBuildingMetaRewardModel-Monument of Greed
	Essential_Decor_Pipe,                                      // EssentialBuildingMetaRewardModel-Pipe
	Essential_Decor_Pipe_Cross,                                // EssentialBuildingMetaRewardModel-Pipe Cross
	Essential_Decor_Pipe_Elbow,                                // EssentialBuildingMetaRewardModel-Pipe Elbow
	Essential_Decor_Pipe_End,                                  // EssentialBuildingMetaRewardModel-Pipe Ending
	Essential_Decor_Pipe_T_Cross,                              // EssentialBuildingMetaRewardModel-Pipe T-Connector
	Essential_Decor_Pipe_Valve,                                // EssentialBuildingMetaRewardModel-Valve
	Essential_Decor_Road_Sign,                                 // EssentialBuildingMetaRewardModel-Road Sign
	Essential_Decor_Scarlet_Decor,                             // EssentialBuildingMetaRewardModel-Thorny Reed
	Essential_Decor_Side_Barrels,                              // EssentialBuildingMetaRewardModel-Rainpunk Barrels
	Essential_Decor_Signboard,                                 // EssentialBuildingMetaRewardModel-Signboard
	Essential_Decor_Stone_Fence,                               // EssentialBuildingMetaRewardModel-Stone Fence
	Essential_Decor_Stone_Fence_Corner,                        // EssentialBuildingMetaRewardModel-Stone Fence Corner
	Essential_Decor_Tower,                                     // EssentialBuildingMetaRewardModel-Wall Crossing
	Essential_Decor_Town_Board,                                // EssentialBuildingMetaRewardModel-Town Board
	Essential_Decor_Umbrella,                                  // EssentialBuildingMetaRewardModel-Umbrella
	Essential_Decor_Wall,                                      // EssentialBuildingMetaRewardModel-Wall
	Essential_Decor_Wall_Corner,                               // EssentialBuildingMetaRewardModel-Wall Corner
	Essential_Decor_Water_Barrels,                             // EssentialBuildingMetaRewardModel-Water Barrels
	Essential_Decor_Water_Shrine,                              // EssentialBuildingMetaRewardModel-Water Shrine
	Essential_Decor_Well,                                      // EssentialBuildingMetaRewardModel-Overgrown Well
	Essential_Farmfield,                                       // EssentialBuildingMetaRewardModel-Farm Field
	Essential_Harvester,                                       // EssentialBuildingMetaRewardModel-Harvesters' Camp
	Essential_Makeshift_Post,                                  // EssentialBuildingMetaRewardModel-Makeshift Post
	Essential_Mine,                                            // EssentialBuildingMetaRewardModel-Mine
	Essential_Paved_Road,                                      // EssentialBuildingMetaRewardModel-Paved Road
	Essential_Primitive_Fishing_Hut,                           // EssentialBuildingMetaRewardModel-Small Fishing Hut
	Essential_Primitive_Forager,                               // EssentialBuildingMetaRewardModel-Small Foragers' Camp
	Essential_Primitive_Herbalist,                             // EssentialBuildingMetaRewardModel-Small Herbalists' Camp
	Essential_Primitive_Trapper,                               // EssentialBuildingMetaRewardModel-Small Trappers' Camp
	Essential_Reinforced_Road,                                 // EssentialBuildingMetaRewardModel-Reinforced Road
	Essential_Shelter,                                         // EssentialBuildingMetaRewardModel-Shelter
	Essential_Small_Hearth,                                    // EssentialBuildingMetaRewardModel-Small Hearth
	Essential_Stonecutter,                                     // EssentialBuildingMetaRewardModel-Stonecutters' Camp
	Essential_Storage,                                         // EssentialBuildingMetaRewardModel-Small Warehouse
	Essential_Temporary_Hearth,                                // EssentialBuildingMetaRewardModel-Small Hearth
	Essential_Trading_Post,                                    // EssentialBuildingMetaRewardModel-Trading Post
	Essential_Woodcutters_Camp,                                // EssentialBuildingMetaRewardModel-Woodcutters' Camp
	Food_Stockpiles_10,                                        // CurrencyMetaRewardModel-Food Stockpiles
	Food_Stockpiles_15,                                        // CurrencyMetaRewardModel-Food Stockpiles
	Food_Stockpiles_20,                                        // CurrencyMetaRewardModel-Food Stockpiles
	Food_Stockpiles_25,                                        // CurrencyMetaRewardModel-Food Stockpiles
	Food_Stockpiles_30,                                        // CurrencyMetaRewardModel-Food Stockpiles
	Food_Stockpiles_5,                                         // CurrencyMetaRewardModel-Food Stockpiles
	Goals_Exp_Reward_Regular,                                  // ExpMetaRewardModel-Honor Badge
	House_Upgrades_Unlock_Beavers,                             // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Beavers
	House_Upgrades_Unlock_Foxes,                               // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Foxes
	House_Upgrades_Unlock_Frogs,                               // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Frogs
	House_Upgrades_Unlock_Harpies,                             // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Harpies
	House_Upgrades_Unlock_Humans,                              // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Humans
	House_Upgrades_Unlock_Lizards,                             // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Lizards
	Ironman_Activation,                                        // IronmanActivationMetaRewardModel-Queen's Hand Trial
	Machinery_10,                                              // CurrencyMetaRewardModel-Machinery
	Machinery_15,                                              // CurrencyMetaRewardModel-Machinery
	Machinery_20,                                              // CurrencyMetaRewardModel-Machinery
	Machinery_25,                                              // CurrencyMetaRewardModel-Machinery
	Machinery_5,                                               // CurrencyMetaRewardModel-Machinery
	Meta_Foxes_Unlock,                                         // RaceMetaRewardModel-Fox
	Meta_Frogs_Unlock,                                         // RaceMetaRewardModel-Frog
	Meta_Harpies_Unlock,                                       // RaceMetaRewardModel-Harpy
	Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse,        // EffectMetaRewardModel-Dual Carriage System
	Meta_Perk_Unlock_Accidental_Barrels,                       // EffectMetaRewardModel-Over-Diligent Woodworkers
	Meta_Perk_Unlock_Alarm_Bells,                              // EffectMetaRewardModel-Alarm Bells
	Meta_Perk_Unlock_Amber_For_Newcomers,                      // EffectMetaRewardModel-Stormwalker Tax
	Meta_Perk_Unlock_Amber_For_Trade_Routes,                   // EffectMetaRewardModel-Deep Pockets
	Meta_Perk_Unlock_Amber_For_Trader_Visit,                   // EffectMetaRewardModel-Bed and Breakfast
	Meta_Perk_Unlock_Amber_For_Water,                          // EffectMetaRewardModel-Counterfeit Amber
	Meta_Perk_Unlock_Amber_For_Wood,                           // EffectMetaRewardModel-Lumber Tax
	Meta_Perk_Unlock_Back_To_Nature,                           // EffectMetaRewardModel-Back to Nature
	Meta_Perk_Unlock_Cache_Rewards_For_Nodes,                  // EffectMetaRewardModel-Reckless Plunder
	Meta_Perk_Unlock_Coal_For_Cyst,                            // EffectMetaRewardModel-Burnt to a Crisp
	Meta_Perk_Unlock_Consumption_Control_For_Extra_Production, // EffectMetaRewardModel-Without Restrictions
	Meta_Perk_Unlock_Copper_For_Each_Tree,                     // EffectMetaRewardModel-Copper Extractor
	Meta_Perk_Unlock_Corruption_Per_Removed_Cyst_Minus50,      // EffectMetaRewardModel-Firekeeper's Armor
	Meta_Perk_Unlock_Crystaline_Water,                         // EffectMetaRewardModel-Small Distillery
	Meta_Perk_Unlock_Eggs_For_Cysts,                           // EffectMetaRewardModel-Blightrot Pruner
	Meta_Perk_Unlock_Exploring_Expedition,                     // EffectMetaRewardModel-Exploration Expedition
	Meta_Perk_Unlock_Extra_Prod_For_Consumption,               // EffectMetaRewardModel-Worker's Rations
	Meta_Perk_Unlock_Extra_Trader_Merch,                       // EffectMetaRewardModel-Guild Catalogue
	Meta_Perk_Unlock_Fedora_Hat,                               // EffectMetaRewardModel-Old Fedora Hat
	Meta_Perk_Unlock_Forge_Trip_Hammer,                        // EffectMetaRewardModel-Forge Trip Hammer
	Meta_Perk_Unlock_Frog_DLC_Borrowed_Time,                   // EffectMetaRewardModel-Borrowed Time
	Meta_Perk_Unlock_Frog_DLC_City_Of_Wonders,                 // EffectMetaRewardModel-City of Wonders
	Meta_Perk_Unlock_Frog_DLC_Frog_Clan_Support,               // EffectMetaRewardModel-Frog Clan Support
	Meta_Perk_Unlock_Frog_DLC_Frog_Friendship,                 // EffectMetaRewardModel-Frog Friendship
	Meta_Perk_Unlock_Frog_DLC_Strength_In_Numbers,             // EffectMetaRewardModel-Strength in Numbers
	Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses,           // EffectMetaRewardModel-Hauling Cart
	Meta_Perk_Unlock_Hostility_For_Relics,                     // EffectMetaRewardModel-Frequent Patrols
	Meta_Perk_Unlock_Hostility_For_Removed_Cysts,              // EffectMetaRewardModel-Baptism of Fire
	Meta_Perk_Unlock_Hostility_For_Water,                      // EffectMetaRewardModel-Calming Water
	Meta_Perk_Unlock_Houses_Global_Capacity_Plus1,             // EffectMetaRewardModel-Crowded Houses
	Meta_Perk_Unlock_HP_For_Impatience,                        // EffectMetaRewardModel-Queen's Gift
	Meta_Perk_Unlock_Hubs_For_Hostility,                       // EffectMetaRewardModel-Safe Haven
	Meta_Perk_Unlock_Insect_For_Tree,                          // EffectMetaRewardModel-Woodpecker Technique
	Meta_Perk_Unlock_LessHostilityPerWoodcutter,               // EffectMetaRewardModel-Flame Amulets
	Meta_Perk_Unlock_Lower_Hostility_For_Religion,             // EffectMetaRewardModel-Firelink Ritual
	Meta_Perk_Unlock_Mist_Piercers,                            // EffectMetaRewardModel-Mist Piercers
	Meta_Perk_Unlock_Mold_Grain,                               // EffectMetaRewardModel-Moldy Grain Seeds
	Meta_Perk_Unlock_More_Amber_From_Routes,                   // EffectMetaRewardModel-Trade Negotiations
	Meta_Perk_Unlock_More_Node_Charges,                        // EffectMetaRewardModel-Rich Glades
	Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes,           // EffectMetaRewardModel-Economic Migration
	Meta_Perk_Unlock_Overexploitation,                         // EffectMetaRewardModel-Overexploitation
	Meta_Perk_Unlock_Parts_For_Trade,                          // EffectMetaRewardModel-Free Samples
	Meta_Perk_Unlock_Porridge_Prod_For_Water,                  // EffectMetaRewardModel-Filling Dish
	Meta_Perk_Unlock_Relic_Time_Reduction,                     // EffectMetaRewardModel-Firekeeper's Prayer
	Meta_Perk_Unlock_Reputation_From_Trade,                    // EffectMetaRewardModel-Trade Hub
	Meta_Perk_Unlock_Resolve_For_Chests,                       // EffectMetaRewardModel-Prosperous Archaeology
	Meta_Perk_Unlock_Resolve_For_Consumption,                  // EffectMetaRewardModel-Generous Rations
	Meta_Perk_Unlock_Resolve_For_Impatience,                   // EffectMetaRewardModel-Rebellious Spirit
	Meta_Perk_Unlock_Resolve_For_Sales,                        // EffectMetaRewardModel-Prosperous Settlement
	Meta_Perk_Unlock_Resolve_For_Standing,                     // EffectMetaRewardModel-Friendly Relations
	Meta_Perk_Unlock_Resolve_For_Started_Route,                // EffectMetaRewardModel-Frequent Caravans
	Meta_Perk_Unlock_Route_Less_Travel_Time,                   // EffectMetaRewardModel-Stormwalker Training
	Meta_Perk_Unlock_Royal_Guard_Training,                     // EffectMetaRewardModel-Royal Guard Training
	Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience,            // EffectMetaRewardModel-Fiery Wrath
	Meta_Perk_Unlock_Tools_For_Death,                          // EffectMetaRewardModel-Bone Tools
	Meta_Perk_Unlock_Tools_For_Glade_For_Resolve,              // EffectMetaRewardModel-Improvised Tools
	Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel,                  // EffectMetaRewardModel-Tightened Belt
	Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots,           // EffectMetaRewardModel-Urban Planning
	Meta_Perk_Unlock_Trading_Packs,                            // EffectMetaRewardModel-Trade Logs
	Meta_Perk_Unlock_VillagerDeathEffectBlock,                 // EffectMetaRewardModel-Hidden from the Queen
	Meta_Perk_Unlock_Villagers_For_Corruption,                 // EffectMetaRewardModel-From the Shadows
	Meta_Perk_Unlock_Water_Crit_For_Fishing,                   // EffectMetaRewardModel-Book of Water
	Meta_Perk_Unlock_Wildcard,                                 // EffectMetaRewardModel-Smuggler's Visit
	Meta_Perk_Unlock_Wood_Plus2_For_Insects,                   // EffectMetaRewardModel-No Quality Control
	Meta_Perk_Unlock_Working_Time_For_Firekeeper,              // EffectMetaRewardModel-Prayer Book
	Meta_Reward_0_Exp,                                         // ExpMetaRewardModel-Absolutely Nothing
	Meta_Reward_Advanced_Rain_Collector,                       // BuildingMetaRewardModel-Advanced Rain Collector
	Meta_Reward_Alchemist_Hut,                                 // BuildingMetaRewardModel-Alchemist's Hut
	Meta_Reward_Apothecary,                                    // BuildingMetaRewardModel-Apothecary
	Meta_Reward_Artisan,                                       // BuildingMetaRewardModel-Artisan
	Meta_Reward_Bakery,                                        // BuildingMetaRewardModel-Bakery
	Meta_Reward_Bath_House,                                    // BuildingMetaRewardModel-Bath House
	Meta_Reward_Beanery,                                       // BuildingMetaRewardModel-Beanery
	Meta_Reward_Beaver_House,                                  // BuildingMetaRewardModel-Beaver House
	Meta_Reward_Big_Shelter,                                   // BuildingMetaRewardModel-Big Shelter
	Meta_Reward_Blight_Post_Upgrades_Unlock,                   // BlightPostUpgradesUnlockMetaRewardModel-Blight Post Upgrades
	Meta_Reward_Bonus_Villagers,                               // BonusVillagersMetaRewardModel-More Villagers
	Meta_Reward_Bonus_Yield,                                   // GlobalExtraProductionChanceMetaRewardModel-Unforeseen Riches
	Meta_Reward_Brewery,                                       // BuildingMetaRewardModel-Brewery
	Meta_Reward_Brick_Oven,                                    // BuildingMetaRewardModel-Brick Oven
	Meta_Reward_Brickyard,                                     // BuildingMetaRewardModel-Brickyard
	Meta_Reward_Building_Storage,                              // GlobalBuildingStorageMetaRewardModel-Larger Storage
	Meta_Reward_Burning_Duration,                              // FuelRateMetaRewardModel-Everlasting Flames
	Meta_Reward_Butcher,                                       // BuildingMetaRewardModel-Butcher
	Meta_Reward_Cannery,                                       // BuildingMetaRewardModel-Cannery
	Meta_Reward_Caravan_Goods,                                 // EmbarkGoodsAmountMetaRewardModel-Stocked Caravans
	Meta_Reward_Caravan_Slot,                                  // CaravanSlotMetaRewardModel-Additional Caravan Choice
	Meta_Reward_Carpenter,                                     // BuildingMetaRewardModel-Carpenter
	Meta_Reward_Cellar,                                        // BuildingMetaRewardModel-Cellar
	Meta_Reward_Citadel_Home_Unlock,                           // CapitalHomeUnlockMetaRewardModel-Viceroy's Quarters
	Meta_Reward_Clan_Hall,                                     // BuildingMetaRewardModel-Clan Hall
	Meta_Reward_Clay_Pit,                                      // BuildingMetaRewardModel-Clay Pit
	Meta_Reward_Clothier,                                      // BuildingMetaRewardModel-Clothier
	Meta_Reward_Cobbler,                                       // BuildingMetaRewardModel-Cobbler
	Meta_Reward_Cookhouse,                                     // BuildingMetaRewardModel-Cookhouse
	Meta_Reward_Cooperage,                                     // BuildingMetaRewardModel-Cooperage
	Meta_Reward_Cornerstone,                                   // SeasonRewardsAmountMetaRewardModel-Additional Cornerstone Choice
	Meta_Reward_Cornerstone_Reroll,                            // CornerstonesRerollsMetaRewardModel-Cornerstone Reroll Charge
	Meta_Reward_Crude_Workstation,                             // BuildingMetaRewardModel-Crude Workstation
	Meta_Reward_Daily_Challenge,                               // DailyChallengeMetaRewardModel-Daily Expedition
	Meta_Reward_Decor_Ancient_Arch,                            // BuildingMetaRewardModel-Ancient Arch
	Meta_Reward_Decor_Ancient_Gravestone,                      // BuildingMetaRewardModel-Ancient Tombstone
	Meta_Reward_Decor_Bank,                                    // BuildingMetaRewardModel-Bench
	Meta_Reward_Decor_Barrels,                                 // BuildingMetaRewardModel-Barrels
	Meta_Reward_Decor_Bush,                                    // BuildingMetaRewardModel-Bush
	Meta_Reward_Decor_Coral,                                   // BuildingMetaRewardModel-Coral Growth
	Meta_Reward_Decor_Crates,                                  // BuildingMetaRewardModel-Crates
	Meta_Reward_Decor_Fence,                                   // BuildingMetaRewardModel-Fence
	Meta_Reward_Decor_Fence_Corner,                            // BuildingMetaRewardModel-Fence Corner
	Meta_Reward_Decor_Fire_Shrine,                             // BuildingMetaRewardModel-Fire Shrine
	Meta_Reward_Decor_Flower_Bed,                              // BuildingMetaRewardModel-Flower Bed
	Meta_Reward_Decor_Gate,                                    // BuildingMetaRewardModel-Gate
	Meta_Reward_Decor_Golden_Leaf,                             // BuildingMetaRewardModel-Golden Leaf Plant
	Meta_Reward_Decor_Lamp,                                    // BuildingMetaRewardModel-Lamp
	Meta_Reward_Decor_Lizard_Post,                             // BuildingMetaRewardModel-Lizard Post
	Meta_Reward_Decor_Mushroom,                                // BuildingMetaRewardModel-Decorative Fungus
	Meta_Reward_Decor_Nightfern,                               // BuildingMetaRewardModel-Nightfern
	Meta_Reward_Decor_Rainpunk_Barrels,                        // BuildingMetaRewardModel-Water Barrels
	Meta_Reward_Decor_Road_Sign,                               // BuildingMetaRewardModel-Road Sign
	Meta_Reward_Decor_Side_Barrels,                            // BuildingMetaRewardModel-Rainpunk Barrels
	Meta_Reward_Decor_Signboard,                               // BuildingMetaRewardModel-Signboard
	Meta_Reward_Decor_Tower,                                   // BuildingMetaRewardModel-Wall Crossing
	Meta_Reward_Decor_Umbrella,                                // BuildingMetaRewardModel-Umbrella
	Meta_Reward_Decor_Wall,                                    // BuildingMetaRewardModel-Wall
	Meta_Reward_Distillery,                                    // BuildingMetaRewardModel-Distillery
	Meta_Reward_Druid,                                         // BuildingMetaRewardModel-Druid's Hut
	Meta_Reward_Embark_Blueprint_Fishing_Hut,                  // EmbarkEffectMetaRewardModel-Embarkation Bonus: Fishing Hut
	Meta_Reward_Embark_Blueprint_Forager,                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Foragers' Camp
	Meta_Reward_Embark_Blueprint_Herb_Garden,                  // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herb Garden
	Meta_Reward_Embark_Blueprint_Herbalist,                    // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herbalists' Camp
	Meta_Reward_Embark_Blueprint_Plantation,                   // EmbarkEffectMetaRewardModel-Embarkation Bonus: Plantation
	Meta_Reward_Embark_Blueprint_Small_Farm,                   // EmbarkEffectMetaRewardModel-Embarkation Bonus: Small Farm
	Meta_Reward_Embark_Blueprint_Trapper,                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Trappers' Camp
	Meta_Reward_Embark_Goods_Amber, 
	Meta_Reward_Embark_Goods_Bricks, 
	Meta_Reward_Embark_Goods_Clay, 
	Meta_Reward_Embark_Goods_Coal, 
	Meta_Reward_Embark_Goods_Eggs, 
	Meta_Reward_Embark_Goods_Fabric, 
	Meta_Reward_Embark_Goods_Leather, 
	Meta_Reward_Embark_Goods_Meat, 
	Meta_Reward_Embark_Goods_Oil, 
	Meta_Reward_Embark_Goods_Parts, 
	Meta_Reward_Embark_Goods_Planks, 
	Meta_Reward_Embark_Goods_Provisions, 
	Meta_Reward_Embark_Goods_Reeds, 
	Meta_Reward_Embark_Goods_Roots, 
	Meta_Reward_Embark_Goods_Stone, 
	Meta_Reward_Embark_Goods_Vegetables, 
	Meta_Reward_Embark_Goods_Wood, 
	Meta_Reward_Embark_Perk_Ale_3pm,                           // EmbarkEffectMetaRewardModel-Embarkation Bonus: Ale Delivery Line
	Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1,          // EmbarkEffectMetaRewardModel-Embarkation Bonus: Royal Permit
	Meta_Reward_Embark_Perk_Cosmetics_3pm,                     // EmbarkEffectMetaRewardModel-Embarkation Bonus: Tea Delivery Line
	Meta_Reward_Embark_Perk_Incense_3pm,                       // EmbarkEffectMetaRewardModel-Embarkation Bonus: Incense Delivery Line
	Meta_Reward_Embark_Perk_Scrolls_3pm,                       // EmbarkEffectMetaRewardModel-Embarkation Bonus: Scroll Delivery Line
	Meta_Reward_Embark_Perk_Training_Gear_3pm,                 // EmbarkEffectMetaRewardModel-Embarkation Bonus: Training Gear Delivery Line
	Meta_Reward_Embark_Perk_Wine_3pm,                          // EmbarkEffectMetaRewardModel-Embarkation Bonus: Wine Delivery Line
	Meta_Reward_Embark_Point,                                  // PreparationPointsMetaRewardModel-Embarkation Points
	Meta_Reward_Embark_Range,                                  // BonusEmbarkRangeMetaRewardModel-Greater Embarkation Range
	Meta_Reward_Embark_Villagers,                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Villagers
	Meta_Reward_Essential_Beaver_House,                        // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Beaver House
	Meta_Reward_Essential_Field_Kitchen,                       // EssentialBuildingMetaRewardModel-Essential Blueprint: Field Kitchen
	Meta_Reward_Essential_Fox_House,                           // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Fox House
	Meta_Reward_Essential_Frog_House,                          // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Frog House
	Meta_Reward_Essential_Harpy_House,                         // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Harpy House
	Meta_Reward_Essential_Human_House,                         // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Human House
	Meta_Reward_Essential_Lizard_House,                        // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Lizard House
	Meta_Reward_Essential_Rain_Collector,                      // EssentialBuildingMetaRewardModel-Rain Collector
	Meta_Reward_Explorers_Lodge,                               // BuildingMetaRewardModel-Explorers' Lodge
	Meta_Reward_Faction_Blue,                                  // FactionsActivationMetaRewardModel-Vanguard of the Stolen Keys
	Meta_Reward_Faction_Green,                                 // FactionsActivationMetaRewardModel-First Dawn Company
	Meta_Reward_Faction_Orange,                                // FactionsActivationMetaRewardModel-Brass Order
	Meta_Reward_Farm_Range,                                    // BonusFarmAreaMetaRewardModel-Farm Range Increase
	Meta_Reward_Finesmith,                                     // BuildingMetaRewardModel-Finesmith
	Meta_Reward_Fishers_Camp,                                  // BuildingMetaRewardModel-Fishing Hut
	Meta_Reward_Foragers_Camp,                                 // BuildingMetaRewardModel-Foragers' Camp
	Meta_Reward_Forum,                                         // BuildingMetaRewardModel-Forum
	Meta_Reward_Fox_House,                                     // BuildingMetaRewardModel-Fox House
	Meta_Reward_Frog_House,                                    // BuildingMetaRewardModel-Frog House
	Meta_Reward_Furnace,                                       // BuildingMetaRewardModel-Furnace
	Meta_Reward_Global_Capacity,                               // GlobalCapacityMetaRewardModel-Worker Capacity Increase
	Meta_Reward_Goals_Unlock,                                  // GoalsUnlockMetaRewardModel-Obsidian Archive
	Meta_Reward_Grace_Period,                                  // GracePeriodMetaRewardModel-Last Stand
	Meta_Reward_Granary,                                       // BuildingMetaRewardModel-Granary
	Meta_Reward_Greenhouse,                                    // BuildingMetaRewardModel-Greenhouse
	Meta_Reward_Grill,                                         // BuildingMetaRewardModel-Grill
	Meta_Reward_Grove,                                         // BuildingMetaRewardModel-Forester's Hut
	Meta_Reward_Guaranteed_Bricks, 
	Meta_Reward_Guaranteed_Fabric, 
	Meta_Reward_Guaranteed_Pipes, 
	Meta_Reward_Guaranteed_Planks, 
	Meta_Reward_Guild_House,                                   // BuildingMetaRewardModel-Guild House
	Meta_Reward_Harpy_House,                                   // BuildingMetaRewardModel-Harpy House
	Meta_Reward_Haulers_Main_Storage,                          // MainStorageHaulersMetaRewardModel-Haulers - Main Warehouse
	Meta_Reward_Haulers_Secondary_Storage,                     // SecondaryStorageHaulersMetaRewardModel-Haulers - Small Warehouse
	Meta_Reward_Hearth,                                        // BuildingMetaRewardModel-Small Hearth
	Meta_Reward_Herb_Garden,                                   // BuildingMetaRewardModel-Herb Garden
	Meta_Reward_Herbalist_Camp,                                // BuildingMetaRewardModel-Herbalists' Camp
	Meta_Reward_Home_Decor_Ancient_Artifact,                   // CapitalHomeDecorationMetaRewardModel-Ancient Artifact
	Meta_Reward_Home_Decor_Domesticated_Sea_Tiger,             // CapitalHomeDecorationMetaRewardModel-Domesticated Sea Tiger
	Meta_Reward_Home_Decor_Dueling_Umbrella,                   // CapitalHomeDecorationMetaRewardModel-Dueling Umbrella
	Meta_Reward_Home_Decor_Fishman_Skull,                      // CapitalHomeDecorationMetaRewardModel-Fishman Skull
	Meta_Reward_Home_Decor_Ibex_Rug,                           // CapitalHomeDecorationMetaRewardModel-Ibex Rug
	Meta_Reward_Home_Decor_Inscribed_Slab,                     // CapitalHomeDecorationMetaRewardModel-Inscribed Slab
	Meta_Reward_Home_Decor_Landscape_Painting,                 // CapitalHomeDecorationMetaRewardModel-Landscape Painting
	Meta_Reward_Home_Decor_Marshglow_Fungite,                  // CapitalHomeDecorationMetaRewardModel-Marshglow Fungite
	Meta_Reward_Home_Decor_Mole_Trophy,                        // CapitalHomeDecorationMetaRewardModel-Mole Trophy
	Meta_Reward_Home_Decor_Painting_Of_The_Ancient_Hearth,     // CapitalHomeDecorationMetaRewardModel-Painting of the Ancient Hearth
	Meta_Reward_Home_Decor_Plate_Of_Food,                      // CapitalHomeDecorationMetaRewardModel-Plate of Food
	Meta_Reward_Home_Decor_Reefbloom,                          // CapitalHomeDecorationMetaRewardModel-Reefbloom
	Meta_Reward_Home_Decor_Rosevine,                           // CapitalHomeDecorationMetaRewardModel-Rosevine
	Meta_Reward_Home_Decor_Sparkdew_Crystal,                   // CapitalHomeDecorationMetaRewardModel-Sparkdew Crystal
	Meta_Reward_Home_Decor_Storm_Orb,                          // CapitalHomeDecorationMetaRewardModel-Storm Orb
	Meta_Reward_Home_Decor_The_Sparkcaster,                    // CapitalHomeDecorationMetaRewardModel-The Sparkcaster
	Meta_Reward_Home_Decor_Trade_Contract,                     // CapitalHomeDecorationMetaRewardModel-Trade Contract
	Meta_Reward_Home_Decor_Uniform_0_Standard_Uniform,         // CapitalHomeDecorationMetaRewardModel-Standard Uniform
	Meta_Reward_Home_Decor_Uniform_1_Settlers_Mask,            // CapitalHomeDecorationMetaRewardModel-Settler's Mask
	Meta_Reward_Home_Decor_Uniform_2_Pioneers_Mantle,          // CapitalHomeDecorationMetaRewardModel-Pioneer's Mantle
	Meta_Reward_Home_Decor_Uniform_3_Veterans_Shoulder_Guard,  // CapitalHomeDecorationMetaRewardModel-Veteran's Shoulder Guard
	Meta_Reward_Home_Decor_Uniform_4_Viceroys_Cape,            // CapitalHomeDecorationMetaRewardModel-Viceroy's Cape
	Meta_Reward_Home_Decor_Uniform_5_Decorated_Belt,           // CapitalHomeDecorationMetaRewardModel-Decorated Belt
	Meta_Reward_Home_Decor_Uniform_6_Royal_Visage,             // CapitalHomeDecorationMetaRewardModel-Royal Visage
	Meta_Reward_Home_Decor_Uniform_7_Stormshroud_Attire,       // CapitalHomeDecorationMetaRewardModel-Stormshroud Attire
	Meta_Reward_Home_Decor_Uniform_8_Crimson_Cloak,            // CapitalHomeDecorationMetaRewardModel-Crimson Cloak
	Meta_Reward_Home_Decor_Uniform_9_Queens_Hand_Pauldron,     // CapitalHomeDecorationMetaRewardModel-Queen's Hand Pauldron
	Meta_Reward_Homestead,                                     // BuildingMetaRewardModel-Homestead
	Meta_Reward_Hub_Tier_1,                                    // HubTierMetaRewardModel-Hearth Upgrade - Neighborhood
	Meta_Reward_Hub_Tier_2,                                    // HubTierMetaRewardModel-Hearth Upgrade - District
	Meta_Reward_Human_House,                                   // BuildingMetaRewardModel-Human House
	Meta_Reward_Impatience,                                    // ReputationPenaltyRateMetaRewardModel-Queen's Patience
	Meta_Reward_Kiln,                                          // BuildingMetaRewardModel-Kiln
	Meta_Reward_Leatherworks,                                  // BuildingMetaRewardModel-Leatherworker
	Meta_Reward_Lizard_House,                                  // BuildingMetaRewardModel-Lizard House
	Meta_Reward_Lumbermill,                                    // BuildingMetaRewardModel-Lumber Mill
	Meta_Reward_Manufactory,                                   // BuildingMetaRewardModel-Manufactory
	Meta_Reward_Market,                                        // BuildingMetaRewardModel-Market
	Meta_Reward_Menu_Skin_Coral_Forest,                        // MenuSkinMetaRewardModel-Menu Skin: Coral Forest
	Meta_Reward_Menu_Skin_Cursed_Royal_Woodlands,              // MenuSkinMetaRewardModel-Menu Skin: Cursed Royal Woodlands
	Meta_Reward_Menu_Skin_Farming,                             // MenuSkinMetaRewardModel-Menu Skin: Calm Settlement
	Meta_Reward_Menu_Skin_Industry,                            // MenuSkinMetaRewardModel-Menu Skin: Industrial Town
	Meta_Reward_Menu_Skin_Marshlands,                          // MenuSkinMetaRewardModel-Menu Skin: Marshlands
	Meta_Reward_Menu_Skin_Scarlet_Orchard,                     // MenuSkinMetaRewardModel-Menu Skin: Scarlet Orchard
	Meta_Reward_Menu_Skin_Sealed_Forest,                       // MenuSkinMetaRewardModel-Menu Skin: Sealed Forest
	Meta_Reward_Meta_Resources,                                // CurrencyMultiplayerMetaRewardModel-More Citadel Resources
	Meta_Reward_Mine,                                          // BuildingMetaRewardModel-Mine
	Meta_Reward_Mine_Upgrade_Unlock,                           // MineUpgradesUnlockMetaRewardModel-Mine Upgrades
	Meta_Reward_Monastery,                                     // BuildingMetaRewardModel-Monastery
	Meta_Reward_Newcomer_Goods,                                // NewcommersGoodsRateMetaRewardModel-Newcomer Gifts
	Meta_Reward_Node_Charges,                                  // RawDepositsChargesMetaRewardModel-Gathering Technique
	Meta_Reward_Pantry,                                        // BuildingMetaRewardModel-Pantry
	Meta_Reward_Passive_Beavers,                               // RevealEffectMetaRewardModel-Starting Ability: Beavers
	Meta_Reward_Passive_Foxes,                                 // RevealEffectMetaRewardModel-Starting Ability: Foxes
	Meta_Reward_Passive_Frogs,                                 // RevealEffectMetaRewardModel-Starting Ability: Frogs
	Meta_Reward_Passive_Harpies,                               // RevealEffectMetaRewardModel-Starting Ability: Harpies
	Meta_Reward_Passive_Humans,                                // RevealEffectMetaRewardModel-Starting Ability: Humans
	Meta_Reward_Passive_Lizards,                               // RevealEffectMetaRewardModel-Starting Ability: Lizards
	Meta_Reward_Paved_Road,                                    // BuildingMetaRewardModel-Paved Road
	Meta_Reward_Plantation,                                    // BuildingMetaRewardModel-Plantation
	Meta_Reward_Press,                                         // BuildingMetaRewardModel-Press
	Meta_Reward_Prod_Speed,                                    // GlobalProductionSpeedMetaRewardModel-Production Speed Increase
	Meta_Reward_Provisioner,                                   // BuildingMetaRewardModel-Provisioner
	Meta_Reward_Rain_Mill,                                     // BuildingMetaRewardModel-Rain Mill
	Meta_Reward_Rainpunk_Activation,                           // RainpunkMetaRewardModel-Rainpunk Engines
	Meta_Reward_Rainpunk_Foundry,                              // BuildingMetaRewardModel-Rainpunk Foundry
	Meta_Reward_Ranch,                                         // BuildingMetaRewardModel-Ranch
	Meta_Reward_Reputation_Reward_Pick,                        // ReputationRewardPicksMetaRewardModel-Additional Blueprint Choice
	Meta_Reward_Reshuffle,                                     // ReputationRewardsRerollMetaRewardModel-Blueprint Reroll
	Meta_Reward_Sacrifice_Cost,                                // HearthSacraficeTimeRateMetaRewardModel-Sacrificial Flames
	Meta_Reward_Scribe,                                        // BuildingMetaRewardModel-Scribe
	Meta_Reward_Sewer,                                         // BuildingMetaRewardModel-Clothier
	Meta_Reward_Smelter,                                       // BuildingMetaRewardModel-Smelter
	Meta_Reward_Smithy,                                        // BuildingMetaRewardModel-Smithy
	Meta_Reward_Smokehouse,                                    // BuildingMetaRewardModel-Smokehouse
	Meta_Reward_Stamping_Mill,                                 // BuildingMetaRewardModel-Stamping Mill
	Meta_Reward_Storage,                                       // BuildingMetaRewardModel-Main Warehouse
	Meta_Reward_Supplier,                                      // BuildingMetaRewardModel-Supplier
	Meta_Reward_Tavern,                                        // BuildingMetaRewardModel-Tavern
	Meta_Reward_Tea_Doctor,                                    // BuildingMetaRewardModel-Tea Doctor
	Meta_Reward_Tea_House,                                     // BuildingMetaRewardModel-Teahouse
	Meta_Reward_Temple,                                        // BuildingMetaRewardModel-Temple
	Meta_Reward_Tinctury,                                      // BuildingMetaRewardModel-Tinctury
	Meta_Reward_Tinkerer,                                      // BuildingMetaRewardModel-Tinkerer
	Meta_Reward_Toolshop,                                      // BuildingMetaRewardModel-Toolshop
	Meta_Reward_Town_Vision,                                   // TownsVisionRangeMetaRewardModel-Increased Town Vision Range
	Meta_Reward_Trade_Routes_Limit,                            // TradeRoutesLimitMetaReward-More Trade Routes
	Meta_Reward_Trader_Arrival,                                // TraderIntervalMetaRewardModel-Quicker Trader Arrival
	Meta_Reward_Trader_Merch,                                  // TraderMerchAmountMetaRewardModel-Extra Merchandise
	Meta_Reward_Trader_Perk_Discount,                          // TraderMerchandisePriceReductionMetaRewardModel-Special Discount
	Meta_Reward_Villager_Speed,                                // VillagersSpeedMetaRewardModel-Villager Speed Increase
	Meta_Reward_Weaver,                                        // BuildingMetaRewardModel-Weaver
	Meta_Reward_Workshop,                                      // BuildingMetaRewardModel-Workshop
	Meta_Trader_Unlock_A,                                      // TraderMetaRewardModel-Zhorg
	Meta_Trader_Unlock_B,                                      // TraderMetaRewardModel-Old Farluf
	Meta_Trader_Unlock_C,                                      // TraderMetaRewardModel-Sothur The Ancient
	Meta_Trader_Unlock_D,                                      // TraderMetaRewardModel-Vliss Greybone
	Meta_Trader_Unlock_E,                                      // TraderMetaRewardModel-Sir Renwald Redmane
	Meta_Trader_Unlock_F,                                      // TraderMetaRewardModel-Xiadani Stormfeather
	Meta_Trader_Unlock_G,                                      // TraderMetaRewardModel-Dullahan Warlander
	Timed_Orders_Activation,                                   // TimedOrdersMetaRewardModel-Timed Orders
	Trade_Routes_Activation,                                   // TradeRoutesMetaRewardModel-Trade Routes


	MAX = 396
}

public static class MetaRewardTypesExtensions
{
	private static MetaRewardTypes[] s_All = null;
	public static MetaRewardTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new MetaRewardTypes[396];
			for (int i = 0; i < 396; i++)
			{
				s_All[i] = (MetaRewardTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this MetaRewardTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of MetaRewardTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[MetaRewardTypes.Artifacts_10];
	}
	
	public static MetaRewardTypes ToMetaRewardTypes(this string name)
	{
		foreach (KeyValuePair<MetaRewardTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find MetaRewardTypes with name: " + name + "\n" + Environment.StackTrace);
		return MetaRewardTypes.Unknown;
	}
	
	public static MetaRewardModel ToMetaRewardModel(this string name)
	{
		MetaRewardModel model = SO.Settings.metaRewards.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find MetaRewardModel for MetaRewardTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static MetaRewardModel ToMetaRewardModel(this MetaRewardTypes types)
	{
		return types.ToName().ToMetaRewardModel();
	}
	
	public static MetaRewardModel[] ToMetaRewardModelArray(this IEnumerable<MetaRewardTypes> collection)
	{
		int count = collection.Count();
		MetaRewardModel[] array = new MetaRewardModel[count];
		int i = 0;
		foreach (MetaRewardTypes element in collection)
		{
			array[i++] = element.ToMetaRewardModel();
		}

		return array;
	}
	
	public static MetaRewardModel[] ToMetaRewardModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		MetaRewardModel[] array = new MetaRewardModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToMetaRewardModel();
		}

		return array;
	}

	internal static readonly Dictionary<MetaRewardTypes, string> TypeToInternalName = new()
	{
		{ MetaRewardTypes.Artifacts_10, "Artifacts 10" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_15, "Artifacts 15" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_20, "Artifacts 20" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_5, "Artifacts 5" },                                                                                                // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Consumption_Control_Activation, "Consumption Control Activation" },                                                          // ConsumptionControlMetaRewardModel-Consumption Control
		{ MetaRewardTypes.Custom_Game_Activation, "Custom Game Activation" },                                                                          // CustomGameMetaRewardModel-Training Expedition
		{ MetaRewardTypes.Essential_Big_Shelter, "Essential Big Shelter" },                                                                            // EssentialBuildingMetaRewardModel-Big Shelter
		{ MetaRewardTypes.Essential_Common_Hall, "Essential Common Hall" },                                                                            // EssentialBuildingMetaRewardModel-Clan Hall
		{ MetaRewardTypes.Essential_Crude_Workstation, "Essential Crude Workstation" },                                                                // EssentialBuildingMetaRewardModel-Crude Workstation
		{ MetaRewardTypes.Essential_Decor_Ancient_Arch, "Essential Decor Ancient Arch" },                                                              // EssentialBuildingMetaRewardModel-Ancient Arch
		{ MetaRewardTypes.Essential_Decor_Ancient_Gravestone, "Essential Decor Ancient Gravestone" },                                                  // EssentialBuildingMetaRewardModel-Ancient Tombstone
		{ MetaRewardTypes.Essential_Decor_Anvil, "Essential Decor Anvil" },                                                                            // EssentialBuildingMetaRewardModel-Anvil
		{ MetaRewardTypes.Essential_Decor_Barrels, "Essential Decor Barrels" },                                                                        // EssentialBuildingMetaRewardModel-Barrels
		{ MetaRewardTypes.Essential_Decor_Bonfire, "Essential Decor Bonfire" },                                                                        // EssentialBuildingMetaRewardModel-Bonfire
		{ MetaRewardTypes.Essential_Decor_Cages, "Essential Decor Cages" },                                                                            // EssentialBuildingMetaRewardModel-Cages
		{ MetaRewardTypes.Essential_Decor_Chest, "Essential Decor Chest" },                                                                            // EssentialBuildingMetaRewardModel-Chest
		{ MetaRewardTypes.Essential_Decor_Coastal_Plant, "Essential Decor Coastal Plant" },                                                            // EssentialBuildingMetaRewardModel-Saltwater Pitcher Plant
		{ MetaRewardTypes.Essential_Decor_Coral, "Essential Decor Coral" },                                                                            // EssentialBuildingMetaRewardModel-Coral Growth
		{ MetaRewardTypes.Essential_Decor_Crates, "Essential Decor Crates" },                                                                          // EssentialBuildingMetaRewardModel-Crates
		{ MetaRewardTypes.Essential_Decor_Fence, "Essential Decor Fence" },                                                                            // EssentialBuildingMetaRewardModel-Fence
		{ MetaRewardTypes.Essential_Decor_Fence_Corner, "Essential Decor Fence Corner" },                                                              // EssentialBuildingMetaRewardModel-Fence Corner
		{ MetaRewardTypes.Essential_Decor_Fire_Shrine, "Essential Decor Fire Shrine" },                                                                // EssentialBuildingMetaRewardModel-Fire Shrine
		{ MetaRewardTypes.Essential_Decor_Fish, "Essential Decor Fish" },                                                                              // EssentialBuildingMetaRewardModel-Fish Mount
		{ MetaRewardTypes.Essential_Decor_Flower_Bed, "Essential Decor Flower Bed" },                                                                  // EssentialBuildingMetaRewardModel-Flower Bed
		{ MetaRewardTypes.Essential_Decor_Fox_Fence, "Essential Decor Fox Fence" },                                                                    // EssentialBuildingMetaRewardModel-Overgrown Fence
		{ MetaRewardTypes.Essential_Decor_Fox_Fence_Corner, "Essential Decor Fox Fence Corner" },                                                      // EssentialBuildingMetaRewardModel-Overgrown Fence Corner
		{ MetaRewardTypes.Essential_Decor_Frog_Tree, "Essential Decor Frog Tree" },                                                                    // EssentialBuildingMetaRewardModel-Evergreen Shrub
		{ MetaRewardTypes.Essential_Decor_Gate, "Essential Decor Gate" },                                                                              // EssentialBuildingMetaRewardModel-Gate
		{ MetaRewardTypes.Essential_Decor_Golden_Leaf, "Essential Decor Golden Leaf" },                                                                // EssentialBuildingMetaRewardModel-Golden Leaf Plant
		{ MetaRewardTypes.Essential_Decor_Lamp, "Essential Decor Lamp" },                                                                              // EssentialBuildingMetaRewardModel-Lamp
		{ MetaRewardTypes.Essential_Decor_Lizard_Post, "Essential Decor Lizard Post" },                                                                // EssentialBuildingMetaRewardModel-Lizard Post
		{ MetaRewardTypes.Essential_Decor_Marbe_Fountain, "Essential Decor Marbe Fountain" },                                                          // EssentialBuildingMetaRewardModel-Marble Fountain
		{ MetaRewardTypes.Essential_Decor_Monument_Of_Greed, "Essential Decor Monument of Greed" },                                                    // EssentialBuildingMetaRewardModel-Monument of Greed
		{ MetaRewardTypes.Essential_Decor_Mushroom, "Essential Decor Mushroom" },                                                                      // EssentialBuildingMetaRewardModel-Decorative Fungus
		{ MetaRewardTypes.Essential_Decor_Nightfern, "Essential Decor Nightfern" },                                                                    // EssentialBuildingMetaRewardModel-Nightfern
		{ MetaRewardTypes.Essential_Decor_Ornate_Column, "Essential Decor Ornate Column" },                                                            // EssentialBuildingMetaRewardModel-Monument of Greed
		{ MetaRewardTypes.Essential_Decor_Pipe, "Essential Decor Pipe" },                                                                              // EssentialBuildingMetaRewardModel-Pipe
		{ MetaRewardTypes.Essential_Decor_Pipe_Cross, "Essential Decor Pipe Cross" },                                                                  // EssentialBuildingMetaRewardModel-Pipe Cross
		{ MetaRewardTypes.Essential_Decor_Pipe_Elbow, "Essential Decor Pipe Elbow" },                                                                  // EssentialBuildingMetaRewardModel-Pipe Elbow
		{ MetaRewardTypes.Essential_Decor_Pipe_End, "Essential Decor Pipe End" },                                                                      // EssentialBuildingMetaRewardModel-Pipe Ending
		{ MetaRewardTypes.Essential_Decor_Pipe_T_Cross, "Essential Decor Pipe T Cross" },                                                              // EssentialBuildingMetaRewardModel-Pipe T-Connector
		{ MetaRewardTypes.Essential_Decor_Pipe_Valve, "Essential Decor Pipe Valve" },                                                                  // EssentialBuildingMetaRewardModel-Valve
		{ MetaRewardTypes.Essential_Decor_Road_Sign, "Essential Decor Road Sign" },                                                                    // EssentialBuildingMetaRewardModel-Road Sign
		{ MetaRewardTypes.Essential_Decor_Scarlet_Decor, "Essential Decor Scarlet Decor" },                                                            // EssentialBuildingMetaRewardModel-Thorny Reed
		{ MetaRewardTypes.Essential_Decor_Side_Barrels, "Essential Decor Side Barrels" },                                                              // EssentialBuildingMetaRewardModel-Rainpunk Barrels
		{ MetaRewardTypes.Essential_Decor_Signboard, "Essential Decor Signboard" },                                                                    // EssentialBuildingMetaRewardModel-Signboard
		{ MetaRewardTypes.Essential_Decor_Stone_Fence, "Essential Decor Stone Fence" },                                                                // EssentialBuildingMetaRewardModel-Stone Fence
		{ MetaRewardTypes.Essential_Decor_Stone_Fence_Corner, "Essential Decor Stone Fence Corner" },                                                  // EssentialBuildingMetaRewardModel-Stone Fence Corner
		{ MetaRewardTypes.Essential_Decor_Tower, "Essential Decor Tower" },                                                                            // EssentialBuildingMetaRewardModel-Wall Crossing
		{ MetaRewardTypes.Essential_Decor_Town_Board, "Essential Decor Town Board" },                                                                  // EssentialBuildingMetaRewardModel-Town Board
		{ MetaRewardTypes.Essential_Decor_Umbrella, "Essential Decor Umbrella" },                                                                      // EssentialBuildingMetaRewardModel-Umbrella
		{ MetaRewardTypes.Essential_Decor_Wall, "Essential Decor Wall" },                                                                              // EssentialBuildingMetaRewardModel-Wall
		{ MetaRewardTypes.Essential_Decor_Wall_Corner, "Essential Decor Wall Corner" },                                                                // EssentialBuildingMetaRewardModel-Wall Corner
		{ MetaRewardTypes.Essential_Decor_Water_Barrels, "Essential Decor Water Barrels" },                                                            // EssentialBuildingMetaRewardModel-Water Barrels
		{ MetaRewardTypes.Essential_Decor_Water_Shrine, "Essential Decor Water Shrine" },                                                              // EssentialBuildingMetaRewardModel-Water Shrine
		{ MetaRewardTypes.Essential_Decor_Well, "Essential Decor Well" },                                                                              // EssentialBuildingMetaRewardModel-Overgrown Well
		{ MetaRewardTypes.Essential_Farmfield, "Essential Farmfield" },                                                                                // EssentialBuildingMetaRewardModel-Farm Field
		{ MetaRewardTypes.Essential_Harvester, "Essential Harvester" },                                                                                // EssentialBuildingMetaRewardModel-Harvesters' Camp
		{ MetaRewardTypes.Essential_Makeshift_Post, "Essential Makeshift Post" },                                                                      // EssentialBuildingMetaRewardModel-Makeshift Post
		{ MetaRewardTypes.Essential_Mine, "Essential Mine" },                                                                                          // EssentialBuildingMetaRewardModel-Mine
		{ MetaRewardTypes.Essential_Paved_Road, "Essential Paved Road" },                                                                              // EssentialBuildingMetaRewardModel-Paved Road
		{ MetaRewardTypes.Essential_Primitive_Fishing_Hut, "Essential Primitive Fishing Hut" },                                                        // EssentialBuildingMetaRewardModel-Small Fishing Hut
		{ MetaRewardTypes.Essential_Primitive_Forager, "Essential Primitive Forager" },                                                                // EssentialBuildingMetaRewardModel-Small Foragers' Camp
		{ MetaRewardTypes.Essential_Primitive_Herbalist, "Essential Primitive Herbalist" },                                                            // EssentialBuildingMetaRewardModel-Small Herbalists' Camp
		{ MetaRewardTypes.Essential_Primitive_Trapper, "Essential Primitive Trapper" },                                                                // EssentialBuildingMetaRewardModel-Small Trappers' Camp
		{ MetaRewardTypes.Essential_Reinforced_Road, "Essential Reinforced Road" },                                                                    // EssentialBuildingMetaRewardModel-Reinforced Road
		{ MetaRewardTypes.Essential_Shelter, "Essential Shelter" },                                                                                    // EssentialBuildingMetaRewardModel-Shelter
		{ MetaRewardTypes.Essential_Small_Hearth, "Essential Small Hearth" },                                                                          // EssentialBuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Essential_Stonecutter, "Essential Stonecutter" },                                                                            // EssentialBuildingMetaRewardModel-Stonecutters' Camp
		{ MetaRewardTypes.Essential_Storage, "Essential Storage" },                                                                                    // EssentialBuildingMetaRewardModel-Small Warehouse
		{ MetaRewardTypes.Essential_Temporary_Hearth, "Essential Temporary Hearth" },                                                                  // EssentialBuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Essential_Trading_Post, "Essential Trading Post" },                                                                          // EssentialBuildingMetaRewardModel-Trading Post
		{ MetaRewardTypes.Essential_Woodcutters_Camp, "Essential Woodcutters Camp" },                                                                  // EssentialBuildingMetaRewardModel-Woodcutters' Camp
		{ MetaRewardTypes.Food_Stockpiles_10, "Food Stockpiles 10" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_15, "Food Stockpiles 15" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_20, "Food Stockpiles 20" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_25, "Food Stockpiles 25" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_30, "Food Stockpiles 30" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_5, "Food Stockpiles 5" },                                                                                    // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Goals_Exp_Reward_Regular, "Goals Exp Reward - Regular" },                                                                    // ExpMetaRewardModel-Honor Badge
		{ MetaRewardTypes.House_Upgrades_Unlock_Beavers, "House Upgrades Unlock - Beavers" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Beavers
		{ MetaRewardTypes.House_Upgrades_Unlock_Foxes, "House Upgrades Unlock - Foxes" },                                                              // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Foxes
		{ MetaRewardTypes.House_Upgrades_Unlock_Frogs, "House Upgrades Unlock - Frogs" },                                                              // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Frogs
		{ MetaRewardTypes.House_Upgrades_Unlock_Harpies, "House Upgrades Unlock - Harpies" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Harpies
		{ MetaRewardTypes.House_Upgrades_Unlock_Humans, "House Upgrades Unlock - Humans" },                                                            // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Humans
		{ MetaRewardTypes.House_Upgrades_Unlock_Lizards, "House Upgrades Unlock - Lizards" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Lizards
		{ MetaRewardTypes.Ironman_Activation, "Ironman Activation" },                                                                                  // IronmanActivationMetaRewardModel-Queen's Hand Trial
		{ MetaRewardTypes.Machinery_10, "Machinery 10" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_15, "Machinery 15" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_20, "Machinery 20" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_25, "Machinery 25" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_5, "Machinery 5" },                                                                                                // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Meta_Foxes_Unlock, "Meta Foxes Unlock" },                                                                                    // RaceMetaRewardModel-Fox
		{ MetaRewardTypes.Meta_Frogs_Unlock, "Meta Frogs Unlock" },                                                                                    // RaceMetaRewardModel-Frog
		{ MetaRewardTypes.Meta_Harpies_Unlock, "Meta Harpies Unlock" },                                                                                // RaceMetaRewardModel-Harpy
		{ MetaRewardTypes.Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse, "Meta Perk Unlock 2 Hauling Carts in Main Warehouse" },                  // EffectMetaRewardModel-Dual Carriage System
		{ MetaRewardTypes.Meta_Perk_Unlock_Accidental_Barrels, "Meta Perk Unlock Accidental Barrels" },                                                // EffectMetaRewardModel-Over-Diligent Woodworkers
		{ MetaRewardTypes.Meta_Perk_Unlock_Alarm_Bells, "Meta Perk Unlock Alarm Bells" },                                                              // EffectMetaRewardModel-Alarm Bells
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Newcomers, "Meta Perk Unlock Amber for Newcomers" },                                              // EffectMetaRewardModel-Stormwalker Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trade_Routes, "Meta Perk Unlock Amber for Trade Routes" },                                        // EffectMetaRewardModel-Deep Pockets
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trader_Visit, "Meta Perk Unlock Amber for Trader Visit" },                                        // EffectMetaRewardModel-Bed and Breakfast
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Water, "Meta Perk Unlock Amber for Water" },                                                      // EffectMetaRewardModel-Counterfeit Amber
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Wood, "Meta Perk Unlock Amber for Wood" },                                                        // EffectMetaRewardModel-Lumber Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Back_To_Nature, "Meta Perk Unlock Back to Nature" },                                                        // EffectMetaRewardModel-Back to Nature
		{ MetaRewardTypes.Meta_Perk_Unlock_Cache_Rewards_For_Nodes, "Meta Perk Unlock Cache Rewards for Nodes" },                                      // EffectMetaRewardModel-Reckless Plunder
		{ MetaRewardTypes.Meta_Perk_Unlock_Coal_For_Cyst, "Meta Perk Unlock Coal for Cyst" },                                                          // EffectMetaRewardModel-Burnt to a Crisp
		{ MetaRewardTypes.Meta_Perk_Unlock_Consumption_Control_For_Extra_Production, "Meta Perk Unlock Consumption Control for Extra Production" },    // EffectMetaRewardModel-Without Restrictions
		{ MetaRewardTypes.Meta_Perk_Unlock_Copper_For_Each_Tree, "Meta Perk Unlock Copper for each tree" },                                            // EffectMetaRewardModel-Copper Extractor
		{ MetaRewardTypes.Meta_Perk_Unlock_Corruption_Per_Removed_Cyst_Minus50, "Meta Perk Unlock Corruption Per Removed Cyst -50" },                  // EffectMetaRewardModel-Firekeeper's Armor
		{ MetaRewardTypes.Meta_Perk_Unlock_Crystaline_Water, "Meta Perk Unlock Crystaline Water" },                                                    // EffectMetaRewardModel-Small Distillery
		{ MetaRewardTypes.Meta_Perk_Unlock_Eggs_For_Cysts, "Meta Perk Unlock Eggs For Cysts" },                                                        // EffectMetaRewardModel-Blightrot Pruner
		{ MetaRewardTypes.Meta_Perk_Unlock_Exploring_Expedition, "Meta Perk Unlock Exploring Expedition" },                                            // EffectMetaRewardModel-Exploration Expedition
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Prod_For_Consumption, "Meta Perk Unlock Extra Prod for consumption" },                                // EffectMetaRewardModel-Worker's Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Trader_Merch, "Meta Perk Unlock Extra Trader Merch" },                                                // EffectMetaRewardModel-Guild Catalogue
		{ MetaRewardTypes.Meta_Perk_Unlock_Fedora_Hat, "Meta Perk Unlock Fedora Hat" },                                                                // EffectMetaRewardModel-Old Fedora Hat
		{ MetaRewardTypes.Meta_Perk_Unlock_Forge_Trip_Hammer, "Meta Perk Unlock Forge Trip Hammer" },                                                  // EffectMetaRewardModel-Forge Trip Hammer
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Borrowed_Time, "Meta Perk Unlock Frog DLC - Borrowed Time" },                                      // EffectMetaRewardModel-Borrowed Time
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_City_Of_Wonders, "Meta Perk Unlock Frog DLC - City of Wonders" },                                  // EffectMetaRewardModel-City of Wonders
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Frog_Clan_Support, "Meta Perk Unlock Frog DLC - Frog Clan Support" },                              // EffectMetaRewardModel-Frog Clan Support
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Frog_Friendship, "Meta Perk Unlock Frog DLC - Frog Friendship" },                                  // EffectMetaRewardModel-Frog Friendship
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Strength_In_Numbers, "Meta Perk Unlock Frog DLC - Strength in Numbers" },                          // EffectMetaRewardModel-Strength in Numbers
		{ MetaRewardTypes.Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses, "Meta Perk Unlock Hauling Cart in All Warehouses" },                        // EffectMetaRewardModel-Hauling Cart
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Relics, "Meta Perk Unlock Hostility for Relics" },                                            // EffectMetaRewardModel-Frequent Patrols
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Removed_Cysts, "Meta Perk Unlock Hostility for Removed Cysts" },                              // EffectMetaRewardModel-Baptism of Fire
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Water, "Meta Perk Unlock Hostility for Water" },                                              // EffectMetaRewardModel-Calming Water
		{ MetaRewardTypes.Meta_Perk_Unlock_Houses_Global_Capacity_Plus1, "Meta Perk Unlock Houses Global Capacity +1" },                               // EffectMetaRewardModel-Crowded Houses
		{ MetaRewardTypes.Meta_Perk_Unlock_HP_For_Impatience, "Meta Perk Unlock HP for Impatience" },                                                  // EffectMetaRewardModel-Queen's Gift
		{ MetaRewardTypes.Meta_Perk_Unlock_Hubs_For_Hostility, "Meta Perk Unlock Hubs for hostility" },                                                // EffectMetaRewardModel-Safe Haven
		{ MetaRewardTypes.Meta_Perk_Unlock_Insect_For_Tree, "Meta Perk Unlock Insect for tree" },                                                      // EffectMetaRewardModel-Woodpecker Technique
		{ MetaRewardTypes.Meta_Perk_Unlock_LessHostilityPerWoodcutter, "Meta Perk Unlock LessHostilityPerWoodcutter" },                                // EffectMetaRewardModel-Flame Amulets
		{ MetaRewardTypes.Meta_Perk_Unlock_Lower_Hostility_For_Religion, "Meta Perk Unlock Lower Hostility For Religion" },                            // EffectMetaRewardModel-Firelink Ritual
		{ MetaRewardTypes.Meta_Perk_Unlock_Mist_Piercers, "Meta Perk Unlock Mist Piercers" },                                                          // EffectMetaRewardModel-Mist Piercers
		{ MetaRewardTypes.Meta_Perk_Unlock_Mold_Grain, "Meta Perk Unlock Mold Grain" },                                                                // EffectMetaRewardModel-Moldy Grain Seeds
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Amber_From_Routes, "Meta Perk Unlock More Amber from Routes" },                                        // EffectMetaRewardModel-Trade Negotiations
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Node_Charges, "Meta Perk Unlock More Node Charges" },                                                  // EffectMetaRewardModel-Rich Glades
		{ MetaRewardTypes.Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes, "Meta Perk Unlock Newcomer Rate for Trade Routes" },                        // EffectMetaRewardModel-Economic Migration
		{ MetaRewardTypes.Meta_Perk_Unlock_Overexploitation, "Meta Perk Unlock Overexploitation" },                                                    // EffectMetaRewardModel-Overexploitation
		{ MetaRewardTypes.Meta_Perk_Unlock_Parts_For_Trade, "Meta Perk Unlock Parts for Trade" },                                                      // EffectMetaRewardModel-Free Samples
		{ MetaRewardTypes.Meta_Perk_Unlock_Porridge_Prod_For_Water, "Meta Perk Unlock Porridge Prod for water" },                                      // EffectMetaRewardModel-Filling Dish
		{ MetaRewardTypes.Meta_Perk_Unlock_Relic_Time_Reduction, "Meta Perk Unlock Relic time reduction" },                                            // EffectMetaRewardModel-Firekeeper's Prayer
		{ MetaRewardTypes.Meta_Perk_Unlock_Reputation_From_Trade, "Meta Perk Unlock Reputation from Trade" },                                          // EffectMetaRewardModel-Trade Hub
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Chests, "Meta Perk Unlock Resolve for Chests" },                                                // EffectMetaRewardModel-Prosperous Archaeology
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Consumption, "Meta Perk Unlock Resolve for consumption" },                                      // EffectMetaRewardModel-Generous Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Impatience, "Meta Perk Unlock Resolve for Impatience" },                                        // EffectMetaRewardModel-Rebellious Spirit
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Sales, "Meta Perk Unlock Resolve for Sales" },                                                  // EffectMetaRewardModel-Prosperous Settlement
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Standing, "Meta Perk Unlock Resolve for Standing" },                                            // EffectMetaRewardModel-Friendly Relations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Started_Route, "Meta Perk Unlock Resolve for started Route" },                                  // EffectMetaRewardModel-Frequent Caravans
		{ MetaRewardTypes.Meta_Perk_Unlock_Route_Less_Travel_Time, "Meta Perk Unlock Route Less Travel Time" },                                        // EffectMetaRewardModel-Stormwalker Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Royal_Guard_Training, "Meta Perk Unlock Royal Guard Training" },                                            // EffectMetaRewardModel-Royal Guard Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience, "Meta Perk Unlock Sacrifice Cost for Impatience" },                          // EffectMetaRewardModel-Fiery Wrath
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Death, "Meta Perk Unlock Tools for death" },                                                      // EffectMetaRewardModel-Bone Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Glade_For_Resolve, "Meta Perk Unlock Tools for Glade for Resolve" },                              // EffectMetaRewardModel-Improvised Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel, "Meta Perk Unlock Trade Routes Bonus Fuel" },                                      // EffectMetaRewardModel-Tightened Belt
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots, "Meta Perk Unlock Trade routes for housing spots" },                        // EffectMetaRewardModel-Urban Planning
		{ MetaRewardTypes.Meta_Perk_Unlock_Trading_Packs, "Meta Perk Unlock Trading Packs" },                                                          // EffectMetaRewardModel-Trade Logs
		{ MetaRewardTypes.Meta_Perk_Unlock_VillagerDeathEffectBlock, "Meta Perk Unlock VillagerDeathEffectBlock" },                                    // EffectMetaRewardModel-Hidden from the Queen
		{ MetaRewardTypes.Meta_Perk_Unlock_Villagers_For_Corruption, "Meta Perk Unlock Villagers For Corruption" },                                    // EffectMetaRewardModel-From the Shadows
		{ MetaRewardTypes.Meta_Perk_Unlock_Water_Crit_For_Fishing, "Meta Perk Unlock Water Crit For Fishing" },                                        // EffectMetaRewardModel-Book of Water
		{ MetaRewardTypes.Meta_Perk_Unlock_Wildcard, "Meta Perk Unlock Wildcard" },                                                                    // EffectMetaRewardModel-Smuggler's Visit
		{ MetaRewardTypes.Meta_Perk_Unlock_Wood_Plus2_For_Insects, "Meta Perk Unlock Wood +2 for insects" },                                           // EffectMetaRewardModel-No Quality Control
		{ MetaRewardTypes.Meta_Perk_Unlock_Working_Time_For_Firekeeper, "Meta Perk Unlock Working time for firekeeper" },                              // EffectMetaRewardModel-Prayer Book
		{ MetaRewardTypes.Meta_Reward_0_Exp, "Meta Reward 0 Exp" },                                                                                    // ExpMetaRewardModel-Absolutely Nothing
		{ MetaRewardTypes.Meta_Reward_Advanced_Rain_Collector, "Meta Reward Advanced Rain Collector" },                                                // BuildingMetaRewardModel-Advanced Rain Collector
		{ MetaRewardTypes.Meta_Reward_Alchemist_Hut, "Meta Reward Alchemist Hut" },                                                                    // BuildingMetaRewardModel-Alchemist's Hut
		{ MetaRewardTypes.Meta_Reward_Apothecary, "Meta Reward Apothecary" },                                                                          // BuildingMetaRewardModel-Apothecary
		{ MetaRewardTypes.Meta_Reward_Artisan, "Meta Reward Artisan" },                                                                                // BuildingMetaRewardModel-Artisan
		{ MetaRewardTypes.Meta_Reward_Bakery, "Meta Reward Bakery" },                                                                                  // BuildingMetaRewardModel-Bakery
		{ MetaRewardTypes.Meta_Reward_Bath_House, "Meta Reward Bath House" },                                                                          // BuildingMetaRewardModel-Bath House
		{ MetaRewardTypes.Meta_Reward_Beanery, "Meta Reward Beanery" },                                                                                // BuildingMetaRewardModel-Beanery
		{ MetaRewardTypes.Meta_Reward_Beaver_House, "Meta Reward Beaver House" },                                                                      // BuildingMetaRewardModel-Beaver House
		{ MetaRewardTypes.Meta_Reward_Big_Shelter, "Meta Reward Big Shelter" },                                                                        // BuildingMetaRewardModel-Big Shelter
		{ MetaRewardTypes.Meta_Reward_Blight_Post_Upgrades_Unlock, "Meta Reward Blight Post Upgrades Unlock" },                                        // BlightPostUpgradesUnlockMetaRewardModel-Blight Post Upgrades
		{ MetaRewardTypes.Meta_Reward_Bonus_Villagers, "Meta Reward Bonus Villagers" },                                                                // BonusVillagersMetaRewardModel-More Villagers
		{ MetaRewardTypes.Meta_Reward_Bonus_Yield, "Meta Reward Bonus Yield" },                                                                        // GlobalExtraProductionChanceMetaRewardModel-Unforeseen Riches
		{ MetaRewardTypes.Meta_Reward_Brewery, "Meta Reward Brewery" },                                                                                // BuildingMetaRewardModel-Brewery
		{ MetaRewardTypes.Meta_Reward_Brick_Oven, "Meta Reward Brick Oven" },                                                                          // BuildingMetaRewardModel-Brick Oven
		{ MetaRewardTypes.Meta_Reward_Brickyard, "Meta Reward Brickyard" },                                                                            // BuildingMetaRewardModel-Brickyard
		{ MetaRewardTypes.Meta_Reward_Building_Storage, "Meta Reward Building Storage" },                                                              // GlobalBuildingStorageMetaRewardModel-Larger Storage
		{ MetaRewardTypes.Meta_Reward_Burning_Duration, "Meta Reward Burning Duration" },                                                              // FuelRateMetaRewardModel-Everlasting Flames
		{ MetaRewardTypes.Meta_Reward_Butcher, "Meta Reward Butcher" },                                                                                // BuildingMetaRewardModel-Butcher
		{ MetaRewardTypes.Meta_Reward_Cannery, "Meta Reward Cannery" },                                                                                // BuildingMetaRewardModel-Cannery
		{ MetaRewardTypes.Meta_Reward_Caravan_Goods, "Meta Reward Caravan Goods" },                                                                    // EmbarkGoodsAmountMetaRewardModel-Stocked Caravans
		{ MetaRewardTypes.Meta_Reward_Caravan_Slot, "Meta Reward Caravan Slot" },                                                                      // CaravanSlotMetaRewardModel-Additional Caravan Choice
		{ MetaRewardTypes.Meta_Reward_Carpenter, "Meta Reward Carpenter" },                                                                            // BuildingMetaRewardModel-Carpenter
		{ MetaRewardTypes.Meta_Reward_Cellar, "Meta Reward Cellar" },                                                                                  // BuildingMetaRewardModel-Cellar
		{ MetaRewardTypes.Meta_Reward_Citadel_Home_Unlock, "Meta Reward Citadel Home Unlock" },                                                        // CapitalHomeUnlockMetaRewardModel-Viceroy's Quarters
		{ MetaRewardTypes.Meta_Reward_Clan_Hall, "Meta Reward Clan Hall" },                                                                            // BuildingMetaRewardModel-Clan Hall
		{ MetaRewardTypes.Meta_Reward_Clay_Pit, "Meta Reward Clay Pit" },                                                                              // BuildingMetaRewardModel-Clay Pit
		{ MetaRewardTypes.Meta_Reward_Clothier, "Meta Reward Clothier" },                                                                              // BuildingMetaRewardModel-Clothier
		{ MetaRewardTypes.Meta_Reward_Cobbler, "Meta Reward Cobbler" },                                                                                // BuildingMetaRewardModel-Cobbler
		{ MetaRewardTypes.Meta_Reward_Cookhouse, "Meta Reward Cookhouse" },                                                                            // BuildingMetaRewardModel-Cookhouse
		{ MetaRewardTypes.Meta_Reward_Cooperage, "Meta Reward Cooperage" },                                                                            // BuildingMetaRewardModel-Cooperage
		{ MetaRewardTypes.Meta_Reward_Cornerstone, "Meta Reward Cornerstone" },                                                                        // SeasonRewardsAmountMetaRewardModel-Additional Cornerstone Choice
		{ MetaRewardTypes.Meta_Reward_Cornerstone_Reroll, "Meta Reward Cornerstone Reroll" },                                                          // CornerstonesRerollsMetaRewardModel-Cornerstone Reroll Charge
		{ MetaRewardTypes.Meta_Reward_Crude_Workstation, "Meta Reward Crude Workstation" },                                                            // BuildingMetaRewardModel-Crude Workstation
		{ MetaRewardTypes.Meta_Reward_Daily_Challenge, "Meta Reward Daily Challenge" },                                                                // DailyChallengeMetaRewardModel-Daily Expedition
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Arch, "Meta Reward Decor Ancient Arch" },                                                          // BuildingMetaRewardModel-Ancient Arch
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Gravestone, "Meta Reward Decor Ancient Gravestone" },                                              // BuildingMetaRewardModel-Ancient Tombstone
		{ MetaRewardTypes.Meta_Reward_Decor_Bank, "Meta Reward Decor Bank" },                                                                          // BuildingMetaRewardModel-Bench
		{ MetaRewardTypes.Meta_Reward_Decor_Barrels, "Meta Reward Decor Barrels" },                                                                    // BuildingMetaRewardModel-Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Bush, "Meta Reward Decor Bush" },                                                                          // BuildingMetaRewardModel-Bush
		{ MetaRewardTypes.Meta_Reward_Decor_Coral, "Meta Reward Decor Coral" },                                                                        // BuildingMetaRewardModel-Coral Growth
		{ MetaRewardTypes.Meta_Reward_Decor_Crates, "Meta Reward Decor Crates" },                                                                      // BuildingMetaRewardModel-Crates
		{ MetaRewardTypes.Meta_Reward_Decor_Fence, "Meta Reward Decor Fence" },                                                                        // BuildingMetaRewardModel-Fence
		{ MetaRewardTypes.Meta_Reward_Decor_Fence_Corner, "Meta Reward Decor Fence Corner" },                                                          // BuildingMetaRewardModel-Fence Corner
		{ MetaRewardTypes.Meta_Reward_Decor_Fire_Shrine, "Meta Reward Decor Fire Shrine" },                                                            // BuildingMetaRewardModel-Fire Shrine
		{ MetaRewardTypes.Meta_Reward_Decor_Flower_Bed, "Meta Reward Decor Flower Bed" },                                                              // BuildingMetaRewardModel-Flower Bed
		{ MetaRewardTypes.Meta_Reward_Decor_Gate, "Meta Reward Decor Gate" },                                                                          // BuildingMetaRewardModel-Gate
		{ MetaRewardTypes.Meta_Reward_Decor_Golden_Leaf, "Meta Reward Decor Golden Leaf" },                                                            // BuildingMetaRewardModel-Golden Leaf Plant
		{ MetaRewardTypes.Meta_Reward_Decor_Lamp, "Meta Reward Decor Lamp" },                                                                          // BuildingMetaRewardModel-Lamp
		{ MetaRewardTypes.Meta_Reward_Decor_Lizard_Post, "Meta Reward Decor Lizard Post" },                                                            // BuildingMetaRewardModel-Lizard Post
		{ MetaRewardTypes.Meta_Reward_Decor_Mushroom, "Meta Reward Decor Mushroom" },                                                                  // BuildingMetaRewardModel-Decorative Fungus
		{ MetaRewardTypes.Meta_Reward_Decor_Nightfern, "Meta Reward Decor Nightfern" },                                                                // BuildingMetaRewardModel-Nightfern
		{ MetaRewardTypes.Meta_Reward_Decor_Rainpunk_Barrels, "Meta Reward Decor Rainpunk Barrels" },                                                  // BuildingMetaRewardModel-Water Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Road_Sign, "Meta Reward Decor Road Sign" },                                                                // BuildingMetaRewardModel-Road Sign
		{ MetaRewardTypes.Meta_Reward_Decor_Side_Barrels, "Meta Reward Decor Side Barrels" },                                                          // BuildingMetaRewardModel-Rainpunk Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Signboard, "Meta Reward Decor Signboard" },                                                                // BuildingMetaRewardModel-Signboard
		{ MetaRewardTypes.Meta_Reward_Decor_Tower, "Meta Reward Decor Tower" },                                                                        // BuildingMetaRewardModel-Wall Crossing
		{ MetaRewardTypes.Meta_Reward_Decor_Umbrella, "Meta Reward Decor Umbrella" },                                                                  // BuildingMetaRewardModel-Umbrella
		{ MetaRewardTypes.Meta_Reward_Decor_Wall, "Meta Reward Decor Wall" },                                                                          // BuildingMetaRewardModel-Wall
		{ MetaRewardTypes.Meta_Reward_Distillery, "Meta Reward Distillery" },                                                                          // BuildingMetaRewardModel-Distillery
		{ MetaRewardTypes.Meta_Reward_Druid, "Meta Reward Druid" },                                                                                    // BuildingMetaRewardModel-Druid's Hut
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Fishing_Hut, "Meta Reward Embark Blueprint Fishing Hut" },                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Fishing Hut
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Forager, "Meta Reward Embark Blueprint Forager" },                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herb_Garden, "Meta Reward Embark Blueprint Herb Garden" },                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herb Garden
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herbalist, "Meta Reward Embark Blueprint Herbalist" },                                          // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Plantation, "Meta Reward Embark Blueprint Plantation" },                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Plantation
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Small_Farm, "Meta Reward Embark Blueprint Small Farm" },                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Small Farm
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Trapper, "Meta Reward Embark Blueprint Trapper" },                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Trappers' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Amber, "Meta Reward Embark Goods Amber" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Bricks, "Meta Reward Embark Goods Bricks" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Clay, "Meta Reward Embark Goods Clay" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Coal, "Meta Reward Embark Goods Coal" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Eggs, "Meta Reward Embark Goods Eggs" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Fabric, "Meta Reward Embark Goods Fabric" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Leather, "Meta Reward Embark Goods Leather" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Meat, "Meta Reward Embark Goods Meat" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Oil, "Meta Reward Embark Goods Oil" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Parts, "Meta Reward Embark Goods Parts" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Planks, "Meta Reward Embark Goods Planks" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Provisions, "Meta Reward Embark Goods Provisions" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Reeds, "Meta Reward Embark Goods Reeds" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Roots, "Meta Reward Embark Goods Roots" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Stone, "Meta Reward Embark Goods Stone" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Vegetables, "Meta Reward Embark Goods Vegetables" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Wood, "Meta Reward Embark Goods Wood" }, 
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Ale_3pm, "Meta Reward Embark Perk Ale 3pm" },                                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Ale Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1, "Meta Reward Embark Perk Cornerstone Reroll +1" },                         // EmbarkEffectMetaRewardModel-Embarkation Bonus: Royal Permit
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cosmetics_3pm, "Meta Reward Embark Perk Cosmetics 3pm" },                                            // EmbarkEffectMetaRewardModel-Embarkation Bonus: Tea Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Incense_3pm, "Meta Reward Embark Perk Incense 3pm" },                                                // EmbarkEffectMetaRewardModel-Embarkation Bonus: Incense Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Scrolls_3pm, "Meta Reward Embark Perk Scrolls 3pm" },                                                // EmbarkEffectMetaRewardModel-Embarkation Bonus: Scroll Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Training_Gear_3pm, "Meta Reward Embark Perk Training Gear 3pm" },                                    // EmbarkEffectMetaRewardModel-Embarkation Bonus: Training Gear Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Wine_3pm, "Meta Reward Embark Perk Wine 3pm" },                                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Wine Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Point, "Meta Reward Embark Point" },                                                                      // PreparationPointsMetaRewardModel-Embarkation Points
		{ MetaRewardTypes.Meta_Reward_Embark_Range, "Meta Reward Embark Range" },                                                                      // BonusEmbarkRangeMetaRewardModel-Greater Embarkation Range
		{ MetaRewardTypes.Meta_Reward_Embark_Villagers, "Meta Reward Embark Villagers" },                                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Villagers
		{ MetaRewardTypes.Meta_Reward_Essential_Beaver_House, "Meta Reward Essential Beaver House" },                                                  // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Beaver House
		{ MetaRewardTypes.Meta_Reward_Essential_Field_Kitchen, "Meta Reward Essential Field Kitchen" },                                                // EssentialBuildingMetaRewardModel-Essential Blueprint: Field Kitchen
		{ MetaRewardTypes.Meta_Reward_Essential_Fox_House, "Meta Reward Essential Fox House" },                                                        // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Fox House
		{ MetaRewardTypes.Meta_Reward_Essential_Frog_House, "Meta Reward Essential Frog House" },                                                      // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Frog House
		{ MetaRewardTypes.Meta_Reward_Essential_Harpy_House, "Meta Reward Essential Harpy House" },                                                    // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Harpy House
		{ MetaRewardTypes.Meta_Reward_Essential_Human_House, "Meta Reward Essential Human House" },                                                    // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Human House
		{ MetaRewardTypes.Meta_Reward_Essential_Lizard_House, "Meta Reward Essential Lizard House" },                                                  // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Lizard House
		{ MetaRewardTypes.Meta_Reward_Essential_Rain_Collector, "Meta Reward Essential Rain Collector" },                                              // EssentialBuildingMetaRewardModel-Rain Collector
		{ MetaRewardTypes.Meta_Reward_Explorers_Lodge, "Meta Reward Explorers Lodge" },                                                                // BuildingMetaRewardModel-Explorers' Lodge
		{ MetaRewardTypes.Meta_Reward_Faction_Blue, "Meta Reward Faction Blue" },                                                                      // FactionsActivationMetaRewardModel-Vanguard of the Stolen Keys
		{ MetaRewardTypes.Meta_Reward_Faction_Green, "Meta Reward Faction Green" },                                                                    // FactionsActivationMetaRewardModel-First Dawn Company
		{ MetaRewardTypes.Meta_Reward_Faction_Orange, "Meta Reward Faction Orange" },                                                                  // FactionsActivationMetaRewardModel-Brass Order
		{ MetaRewardTypes.Meta_Reward_Farm_Range, "Meta Reward Farm Range" },                                                                          // BonusFarmAreaMetaRewardModel-Farm Range Increase
		{ MetaRewardTypes.Meta_Reward_Finesmith, "Meta Reward Finesmith" },                                                                            // BuildingMetaRewardModel-Finesmith
		{ MetaRewardTypes.Meta_Reward_Fishers_Camp, "Meta Reward Fishers Camp" },                                                                      // BuildingMetaRewardModel-Fishing Hut
		{ MetaRewardTypes.Meta_Reward_Foragers_Camp, "Meta Reward Forager's Camp" },                                                                   // BuildingMetaRewardModel-Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Forum, "Meta Reward Forum" },                                                                                    // BuildingMetaRewardModel-Forum
		{ MetaRewardTypes.Meta_Reward_Fox_House, "Meta Reward Fox House" },                                                                            // BuildingMetaRewardModel-Fox House
		{ MetaRewardTypes.Meta_Reward_Frog_House, "Meta Reward Frog House" },                                                                          // BuildingMetaRewardModel-Frog House
		{ MetaRewardTypes.Meta_Reward_Furnace, "Meta Reward Furnace" },                                                                                // BuildingMetaRewardModel-Furnace
		{ MetaRewardTypes.Meta_Reward_Global_Capacity, "Meta Reward Global Capacity" },                                                                // GlobalCapacityMetaRewardModel-Worker Capacity Increase
		{ MetaRewardTypes.Meta_Reward_Goals_Unlock, "Meta Reward Goals Unlock" },                                                                      // GoalsUnlockMetaRewardModel-Obsidian Archive
		{ MetaRewardTypes.Meta_Reward_Grace_Period, "Meta Reward Grace Period" },                                                                      // GracePeriodMetaRewardModel-Last Stand
		{ MetaRewardTypes.Meta_Reward_Granary, "Meta Reward Granary" },                                                                                // BuildingMetaRewardModel-Granary
		{ MetaRewardTypes.Meta_Reward_Greenhouse, "Meta Reward Greenhouse" },                                                                          // BuildingMetaRewardModel-Greenhouse
		{ MetaRewardTypes.Meta_Reward_Grill, "Meta Reward Grill" },                                                                                    // BuildingMetaRewardModel-Grill
		{ MetaRewardTypes.Meta_Reward_Grove, "Meta Reward Grove" },                                                                                    // BuildingMetaRewardModel-Forester's Hut
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Bricks, "Meta Reward Guaranteed Bricks" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Fabric, "Meta Reward Guaranteed Fabric" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Pipes, "Meta Reward Guaranteed Pipes" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Planks, "Meta Reward Guaranteed Planks" }, 
		{ MetaRewardTypes.Meta_Reward_Guild_House, "Meta Reward Guild House" },                                                                        // BuildingMetaRewardModel-Guild House
		{ MetaRewardTypes.Meta_Reward_Harpy_House, "Meta Reward Harpy House" },                                                                        // BuildingMetaRewardModel-Harpy House
		{ MetaRewardTypes.Meta_Reward_Haulers_Main_Storage, "Meta Reward Haulers - Main Storage" },                                                    // MainStorageHaulersMetaRewardModel-Haulers - Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Haulers_Secondary_Storage, "Meta Reward Haulers - Secondary Storage" },                                          // SecondaryStorageHaulersMetaRewardModel-Haulers - Small Warehouse
		{ MetaRewardTypes.Meta_Reward_Hearth, "Meta Reward Hearth" },                                                                                  // BuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Meta_Reward_Herb_Garden, "Meta Reward Herb Garden" },                                                                        // BuildingMetaRewardModel-Herb Garden
		{ MetaRewardTypes.Meta_Reward_Herbalist_Camp, "Meta Reward Herbalist Camp" },                                                                  // BuildingMetaRewardModel-Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Ancient_Artifact, "Meta Reward Home Decor - Ancient Artifact" },                                      // CapitalHomeDecorationMetaRewardModel-Ancient Artifact
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Domesticated_Sea_Tiger, "Meta Reward Home Decor - Domesticated Sea Tiger" },                          // CapitalHomeDecorationMetaRewardModel-Domesticated Sea Tiger
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Dueling_Umbrella, "Meta Reward Home Decor - Dueling Umbrella" },                                      // CapitalHomeDecorationMetaRewardModel-Dueling Umbrella
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Fishman_Skull, "Meta Reward Home Decor - Fishman Skull" },                                            // CapitalHomeDecorationMetaRewardModel-Fishman Skull
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Ibex_Rug, "Meta Reward Home Decor - Ibex Rug" },                                                      // CapitalHomeDecorationMetaRewardModel-Ibex Rug
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Inscribed_Slab, "Meta Reward Home Decor - Inscribed Slab" },                                          // CapitalHomeDecorationMetaRewardModel-Inscribed Slab
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Landscape_Painting, "Meta Reward Home Decor - Landscape Painting" },                                  // CapitalHomeDecorationMetaRewardModel-Landscape Painting
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Marshglow_Fungite, "Meta Reward Home Decor - Marshglow Fungite" },                                    // CapitalHomeDecorationMetaRewardModel-Marshglow Fungite
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Mole_Trophy, "Meta Reward Home Decor - Mole Trophy" },                                                // CapitalHomeDecorationMetaRewardModel-Mole Trophy
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Painting_Of_The_Ancient_Hearth, "Meta Reward Home Decor - Painting of the Ancient Hearth" },          // CapitalHomeDecorationMetaRewardModel-Painting of the Ancient Hearth
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Plate_Of_Food, "Meta Reward Home Decor - Plate of Food" },                                            // CapitalHomeDecorationMetaRewardModel-Plate of Food
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Reefbloom, "Meta Reward Home Decor - Reefbloom" },                                                    // CapitalHomeDecorationMetaRewardModel-Reefbloom
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Rosevine, "Meta Reward Home Decor - Rosevine" },                                                      // CapitalHomeDecorationMetaRewardModel-Rosevine
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Sparkdew_Crystal, "Meta Reward Home Decor - Sparkdew Crystal" },                                      // CapitalHomeDecorationMetaRewardModel-Sparkdew Crystal
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Storm_Orb, "Meta Reward Home Decor - Storm Orb" },                                                    // CapitalHomeDecorationMetaRewardModel-Storm Orb
		{ MetaRewardTypes.Meta_Reward_Home_Decor_The_Sparkcaster, "Meta Reward Home Decor - The Sparkcaster" },                                        // CapitalHomeDecorationMetaRewardModel-The Sparkcaster
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Trade_Contract, "Meta Reward Home Decor - Trade Contract" },                                          // CapitalHomeDecorationMetaRewardModel-Trade Contract
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_0_Standard_Uniform, "Meta Reward Home Decor - Uniform 0 - Standard Uniform" },                // CapitalHomeDecorationMetaRewardModel-Standard Uniform
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_1_Settlers_Mask, "Meta Reward Home Decor - Uniform 1 - Settler's Mask" },                     // CapitalHomeDecorationMetaRewardModel-Settler's Mask
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_2_Pioneers_Mantle, "Meta Reward Home Decor - Uniform 2 - Pioneer's Mantle" },                 // CapitalHomeDecorationMetaRewardModel-Pioneer's Mantle
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_3_Veterans_Shoulder_Guard, "Meta Reward Home Decor - Uniform 3 - Veteran's Shoulder Guard" }, // CapitalHomeDecorationMetaRewardModel-Veteran's Shoulder Guard
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_4_Viceroys_Cape, "Meta Reward Home Decor - Uniform 4 - Viceroy's Cape" },                     // CapitalHomeDecorationMetaRewardModel-Viceroy's Cape
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_5_Decorated_Belt, "Meta Reward Home Decor - Uniform 5 - Decorated Belt" },                    // CapitalHomeDecorationMetaRewardModel-Decorated Belt
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_6_Royal_Visage, "Meta Reward Home Decor - Uniform 6 - Royal Visage" },                        // CapitalHomeDecorationMetaRewardModel-Royal Visage
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_7_Stormshroud_Attire, "Meta Reward Home Decor - Uniform 7 - Stormshroud Attire" },            // CapitalHomeDecorationMetaRewardModel-Stormshroud Attire
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_8_Crimson_Cloak, "Meta Reward Home Decor - Uniform 8 - Crimson Cloak" },                      // CapitalHomeDecorationMetaRewardModel-Crimson Cloak
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_9_Queens_Hand_Pauldron, "Meta Reward Home Decor - Uniform 9 - Queen's Hand Pauldron" },       // CapitalHomeDecorationMetaRewardModel-Queen's Hand Pauldron
		{ MetaRewardTypes.Meta_Reward_Homestead, "Meta Reward Homestead" },                                                                            // BuildingMetaRewardModel-Homestead
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_1, "Meta Reward Hub Tier 1" },                                                                          // HubTierMetaRewardModel-Hearth Upgrade - Neighborhood
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_2, "Meta Reward Hub Tier 2" },                                                                          // HubTierMetaRewardModel-Hearth Upgrade - District
		{ MetaRewardTypes.Meta_Reward_Human_House, "Meta Reward Human House" },                                                                        // BuildingMetaRewardModel-Human House
		{ MetaRewardTypes.Meta_Reward_Impatience, "Meta Reward Impatience" },                                                                          // ReputationPenaltyRateMetaRewardModel-Queen's Patience
		{ MetaRewardTypes.Meta_Reward_Kiln, "Meta Reward Kiln" },                                                                                      // BuildingMetaRewardModel-Kiln
		{ MetaRewardTypes.Meta_Reward_Leatherworks, "Meta Reward Leatherworks" },                                                                      // BuildingMetaRewardModel-Leatherworker
		{ MetaRewardTypes.Meta_Reward_Lizard_House, "Meta Reward Lizard House" },                                                                      // BuildingMetaRewardModel-Lizard House
		{ MetaRewardTypes.Meta_Reward_Lumbermill, "Meta Reward Lumbermill" },                                                                          // BuildingMetaRewardModel-Lumber Mill
		{ MetaRewardTypes.Meta_Reward_Manufactory, "Meta Reward Manufactory" },                                                                        // BuildingMetaRewardModel-Manufactory
		{ MetaRewardTypes.Meta_Reward_Market, "Meta Reward Market" },                                                                                  // BuildingMetaRewardModel-Market
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Coral_Forest, "Meta Reward Menu Skin - Coral Forest" },                                                // MenuSkinMetaRewardModel-Menu Skin: Coral Forest
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Cursed_Royal_Woodlands, "Meta Reward Menu Skin - Cursed Royal Woodlands" },                            // MenuSkinMetaRewardModel-Menu Skin: Cursed Royal Woodlands
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Farming, "Meta Reward Menu Skin - Farming" },                                                          // MenuSkinMetaRewardModel-Menu Skin: Calm Settlement
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Industry, "Meta Reward Menu Skin - Industry" },                                                        // MenuSkinMetaRewardModel-Menu Skin: Industrial Town
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Marshlands, "Meta Reward Menu Skin - Marshlands" },                                                    // MenuSkinMetaRewardModel-Menu Skin: Marshlands
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Scarlet_Orchard, "Meta Reward Menu Skin - Scarlet Orchard" },                                          // MenuSkinMetaRewardModel-Menu Skin: Scarlet Orchard
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Sealed_Forest, "Meta Reward Menu Skin - Sealed Forest" },                                              // MenuSkinMetaRewardModel-Menu Skin: Sealed Forest
		{ MetaRewardTypes.Meta_Reward_Meta_Resources, "Meta Reward Meta Resources" },                                                                  // CurrencyMultiplayerMetaRewardModel-More Citadel Resources
		{ MetaRewardTypes.Meta_Reward_Mine, "Meta Reward Mine" },                                                                                      // BuildingMetaRewardModel-Mine
		{ MetaRewardTypes.Meta_Reward_Mine_Upgrade_Unlock, "Meta Reward Mine Upgrade Unlock" },                                                        // MineUpgradesUnlockMetaRewardModel-Mine Upgrades
		{ MetaRewardTypes.Meta_Reward_Monastery, "Meta Reward Monastery" },                                                                            // BuildingMetaRewardModel-Monastery
		{ MetaRewardTypes.Meta_Reward_Newcomer_Goods, "Meta Reward Newcomer Goods" },                                                                  // NewcommersGoodsRateMetaRewardModel-Newcomer Gifts
		{ MetaRewardTypes.Meta_Reward_Node_Charges, "Meta Reward Node Charges" },                                                                      // RawDepositsChargesMetaRewardModel-Gathering Technique
		{ MetaRewardTypes.Meta_Reward_Pantry, "Meta Reward Pantry" },                                                                                  // BuildingMetaRewardModel-Pantry
		{ MetaRewardTypes.Meta_Reward_Passive_Beavers, "Meta Reward Passive Beavers" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Beavers
		{ MetaRewardTypes.Meta_Reward_Passive_Foxes, "Meta Reward Passive Foxes" },                                                                    // RevealEffectMetaRewardModel-Starting Ability: Foxes
		{ MetaRewardTypes.Meta_Reward_Passive_Frogs, "Meta Reward Passive Frogs" },                                                                    // RevealEffectMetaRewardModel-Starting Ability: Frogs
		{ MetaRewardTypes.Meta_Reward_Passive_Harpies, "Meta Reward Passive Harpies" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Harpies
		{ MetaRewardTypes.Meta_Reward_Passive_Humans, "Meta Reward Passive Humans" },                                                                  // RevealEffectMetaRewardModel-Starting Ability: Humans
		{ MetaRewardTypes.Meta_Reward_Passive_Lizards, "Meta Reward Passive Lizards" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Lizards
		{ MetaRewardTypes.Meta_Reward_Paved_Road, "Meta Reward Paved Road" },                                                                          // BuildingMetaRewardModel-Paved Road
		{ MetaRewardTypes.Meta_Reward_Plantation, "Meta Reward Plantation" },                                                                          // BuildingMetaRewardModel-Plantation
		{ MetaRewardTypes.Meta_Reward_Press, "Meta Reward Press" },                                                                                    // BuildingMetaRewardModel-Press
		{ MetaRewardTypes.Meta_Reward_Prod_Speed, "Meta Reward Prod Speed" },                                                                          // GlobalProductionSpeedMetaRewardModel-Production Speed Increase
		{ MetaRewardTypes.Meta_Reward_Provisioner, "Meta Reward Provisioner" },                                                                        // BuildingMetaRewardModel-Provisioner
		{ MetaRewardTypes.Meta_Reward_Rain_Mill, "Meta Reward Rain Mill" },                                                                            // BuildingMetaRewardModel-Rain Mill
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Activation, "Meta Reward Rainpunk Activation" },                                                        // RainpunkMetaRewardModel-Rainpunk Engines
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Foundry, "Meta Reward Rainpunk Foundry" },                                                              // BuildingMetaRewardModel-Rainpunk Foundry
		{ MetaRewardTypes.Meta_Reward_Ranch, "Meta Reward Ranch" },                                                                                    // BuildingMetaRewardModel-Ranch
		{ MetaRewardTypes.Meta_Reward_Reputation_Reward_Pick, "Meta Reward Reputation Reward Pick" },                                                  // ReputationRewardPicksMetaRewardModel-Additional Blueprint Choice
		{ MetaRewardTypes.Meta_Reward_Reshuffle, "Meta Reward Reshuffle" },                                                                            // ReputationRewardsRerollMetaRewardModel-Blueprint Reroll
		{ MetaRewardTypes.Meta_Reward_Sacrifice_Cost, "Meta Reward Sacrifice Cost" },                                                                  // HearthSacraficeTimeRateMetaRewardModel-Sacrificial Flames
		{ MetaRewardTypes.Meta_Reward_Scribe, "Meta Reward Scribe" },                                                                                  // BuildingMetaRewardModel-Scribe
		{ MetaRewardTypes.Meta_Reward_Sewer, "Meta Reward Sewer" },                                                                                    // BuildingMetaRewardModel-Clothier
		{ MetaRewardTypes.Meta_Reward_Smelter, "Meta Reward Smelter" },                                                                                // BuildingMetaRewardModel-Smelter
		{ MetaRewardTypes.Meta_Reward_Smithy, "Meta Reward Smithy" },                                                                                  // BuildingMetaRewardModel-Smithy
		{ MetaRewardTypes.Meta_Reward_Smokehouse, "Meta Reward Smokehouse" },                                                                          // BuildingMetaRewardModel-Smokehouse
		{ MetaRewardTypes.Meta_Reward_Stamping_Mill, "Meta Reward Stamping Mill" },                                                                    // BuildingMetaRewardModel-Stamping Mill
		{ MetaRewardTypes.Meta_Reward_Storage, "Meta Reward Storage" },                                                                                // BuildingMetaRewardModel-Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Supplier, "Meta Reward Supplier" },                                                                              // BuildingMetaRewardModel-Supplier
		{ MetaRewardTypes.Meta_Reward_Tavern, "Meta Reward Tavern" },                                                                                  // BuildingMetaRewardModel-Tavern
		{ MetaRewardTypes.Meta_Reward_Tea_Doctor, "Meta Reward Tea Doctor" },                                                                          // BuildingMetaRewardModel-Tea Doctor
		{ MetaRewardTypes.Meta_Reward_Tea_House, "Meta Reward Tea House" },                                                                            // BuildingMetaRewardModel-Teahouse
		{ MetaRewardTypes.Meta_Reward_Temple, "Meta Reward Temple" },                                                                                  // BuildingMetaRewardModel-Temple
		{ MetaRewardTypes.Meta_Reward_Tinctury, "Meta Reward Tinctury" },                                                                              // BuildingMetaRewardModel-Tinctury
		{ MetaRewardTypes.Meta_Reward_Tinkerer, "Meta Reward Tinkerer" },                                                                              // BuildingMetaRewardModel-Tinkerer
		{ MetaRewardTypes.Meta_Reward_Toolshop, "Meta Reward Toolshop" },                                                                              // BuildingMetaRewardModel-Toolshop
		{ MetaRewardTypes.Meta_Reward_Town_Vision, "Meta Reward Town Vision" },                                                                        // TownsVisionRangeMetaRewardModel-Increased Town Vision Range
		{ MetaRewardTypes.Meta_Reward_Trade_Routes_Limit, "Meta Reward Trade Routes Limit" },                                                          // TradeRoutesLimitMetaReward-More Trade Routes
		{ MetaRewardTypes.Meta_Reward_Trader_Arrival, "Meta Reward Trader Arrival" },                                                                  // TraderIntervalMetaRewardModel-Quicker Trader Arrival
		{ MetaRewardTypes.Meta_Reward_Trader_Merch, "Meta Reward Trader Merch" },                                                                      // TraderMerchAmountMetaRewardModel-Extra Merchandise
		{ MetaRewardTypes.Meta_Reward_Trader_Perk_Discount, "Meta Reward Trader Perk Discount" },                                                      // TraderMerchandisePriceReductionMetaRewardModel-Special Discount
		{ MetaRewardTypes.Meta_Reward_Villager_Speed, "Meta Reward Villager Speed" },                                                                  // VillagersSpeedMetaRewardModel-Villager Speed Increase
		{ MetaRewardTypes.Meta_Reward_Weaver, "Meta Reward Weaver" },                                                                                  // BuildingMetaRewardModel-Weaver
		{ MetaRewardTypes.Meta_Reward_Workshop, "Meta Reward Workshop" },                                                                              // BuildingMetaRewardModel-Workshop
		{ MetaRewardTypes.Meta_Trader_Unlock_A, "Meta Trader Unlock A" },                                                                              // TraderMetaRewardModel-Zhorg
		{ MetaRewardTypes.Meta_Trader_Unlock_B, "Meta Trader Unlock B" },                                                                              // TraderMetaRewardModel-Old Farluf
		{ MetaRewardTypes.Meta_Trader_Unlock_C, "Meta Trader Unlock C" },                                                                              // TraderMetaRewardModel-Sothur The Ancient
		{ MetaRewardTypes.Meta_Trader_Unlock_D, "Meta Trader Unlock D" },                                                                              // TraderMetaRewardModel-Vliss Greybone
		{ MetaRewardTypes.Meta_Trader_Unlock_E, "Meta Trader Unlock E" },                                                                              // TraderMetaRewardModel-Sir Renwald Redmane
		{ MetaRewardTypes.Meta_Trader_Unlock_F, "Meta Trader Unlock F" },                                                                              // TraderMetaRewardModel-Xiadani Stormfeather
		{ MetaRewardTypes.Meta_Trader_Unlock_G, "Meta Trader Unlock G" },                                                                              // TraderMetaRewardModel-Dullahan Warlander
		{ MetaRewardTypes.Timed_Orders_Activation, "Timed Orders Activation" },                                                                        // TimedOrdersMetaRewardModel-Timed Orders
		{ MetaRewardTypes.Trade_Routes_Activation, "Trade Routes Activation" },                                                                        // TradeRoutesMetaRewardModel-Trade Routes

	};
}
