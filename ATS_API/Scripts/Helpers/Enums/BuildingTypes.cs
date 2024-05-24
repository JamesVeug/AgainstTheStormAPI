using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum BuildingTypes
{
    Unknown = -1,
    None,
	Advanced_Rain_Catcher,                      // Advanced Rain Collector
	Aestherics_2x2___Garden,                    // Garden
	Aestherics_2x2___Groundwater_Extractor,     // Makeshift Extractor
	Alchemist_Hut,                              // Alchemist's Hut
	Altar,                                      // Forsaken Altar
	Ancient_Gravestone,                         // Ancient Tombstone
	AncientBurrialGrounds,                      // Ancient Burial Site
	AncientGate,                                // Dark Gate
	AncientShrine_T1,                           // Ancient Shrine
	AncientTemple,                              // Forgotten Temple of the Sun
	Angry_Ghost_1,                              // Ghost of a Blight Fighter Captain
	Angry_Ghost_10,                             // Ghost of a Suppressed Rebel
	Angry_Ghost_14,                             // Ghost of a Resentful Human
	Angry_Ghost_15,                             // Ghost of the Queen's Lickspittle
	Angry_Ghost_16,                             // Ghost of a Lizard Leader
	Angry_Ghost_17,                             // Ghost of a Tortured Harpy
	Angry_Ghost_18,                             // Ghost of a Beaver Engineer
	Angry_Ghost_19,                             // Ghost of a Poisoned Human
	Angry_Ghost_2,                              // Ghost of a Mad Alchemist
	Angry_Ghost_20,                             // Ghost of a Lizard Worker
	Angry_Ghost_21,                             // Ghost of a Starved Harpy
	Angry_Ghost_24,                             // Ghost of an Innkeeper
	Angry_Ghost_31,                             // Ghost of a Lizard Elder
	Angry_Ghost_32,                             // Ghost of a Lost Scout
	Angry_Ghost_34,                             // Ghost of a Murdered Trader
	Angry_Ghost_4,                              // Ghost of a Deranged Scout
	Angry_Ghost_5,                              // Ghost of a Furious Villager
	Angry_Ghost_6,                              // Ghost of a Scared Firekeeper
	Angry_Ghost_9,                              // Ghost of a Loyal Servant
	AngryGhostChest_T1,                         // Ghost Chest
	Anvil,                                      // Anvil
	API_ExampleMod_BurgerJoint,                 // Borgor King
	Apothecary,                                 // Apothecary
	Arch,                                       // Ancient Arch
	Archaeology_Scorpion_Positive,              // Smoldering Scorpion
	Archaeology_Snake_Positive,                 // Sea Serpent
	Archaeology_Spider_Positive,                // Sealed Spider
	Archeology_Office,                          // Archaeologist's Office
	Artisan,                                    // Artisan
	Bakery,                                     // Bakery
	Bank,                                       // Bench
	Barrels,                                    // Barrels
	Bath_House,                                 // Bath House
	Beanery,                                    // Beanery
	Beaver_House,                               // Beaver House
	BeaverBattleground_T1,                      // Fallen Beaver Traders
	Big_Shelter,                                // Big Shelter
	Black_Stag,                                 // Black Treasure Stag
	Black_Treasure_Stag,                        // Black Treasure Stag
	Blight_Post,                                // Blight Post
	Blightrot,                                  // Blood Flower
	Blightrot___Clone,                          // Blood Flower (Clone)
	Blightrot_Cauldron,                         // Blightrot Cauldron
	Bonfire,                                    // Bonfire
	Brewery,                                    // Brewery
	Brick_Oven,                                 // Brick Oven
	Brickyard,                                  // Brickyard
	Bush,                                       // Bush
	Butcher,                                    // Butcher
	Cages,                                      // Cages
	Calm_Ghost_11,                              // Ghost of a Defeated Viceroy
	Calm_Ghost_12,                              // Ghost of a Druid
	Calm_Ghost_13,                              // Ghost of a Royal Gardener
	Calm_Ghost_22,                              // Ghost of a Hooded Knight
	Calm_Ghost_23,                              // Ghost of a Fire Priest
	Calm_Ghost_25,                              // Ghost of a Treasure Hunter
	Calm_Ghost_26,                              // Ghost of a Royal Architect
	Calm_Ghost_27,                              // Ghost of a Worried Carter
	Calm_Ghost_28,                              // Ghost of a Storm Victim
	Calm_Ghost_29,                              // Ghost of a Mourning Harpy
	Calm_Ghost_3,                               // Ghost of a Terrified Woodcutter
	Calm_Ghost_30,                              // Ghost of a Lizard General
	Calm_Ghost_33,                              // Ghost of an Old Merchant
	Calm_Ghost_35,                              // Ghost of a Fox Elder
	Calm_Ghost_36,                              // Ghost of a Teadoctor
	Calm_Ghost_7,                               // Ghost of a Troublemaker
	Calm_Ghost_8,                               // Ghost of a Fallen Newcomer
	CalmGhostChest_T1,                          // Ghost Chest
	Camp_T1,                                    // Small Encampment
	Camp_T2,                                    // Large Encampment
	Caravan_T1,                                 // Small Destroyed Caravan
	Caravan_T2,                                 // Large Destroyed Caravan
	Carpenter,                                  // Carpenter
	Cellar,                                     // Cellar
	Chest,                                      // Chest
	Clan_Hall,                                  // Clan Hall
	Clay_Pit_Workshop,                          // Clay Pit
	Clothier,                                   // Clothier
	Comfort_2x2___Park,                         // Park
	Cookhouse,                                  // Cookhouse
	Cooperage,                                  // Cooperage
	Coral_Decor,                                // Coral Growth
	CornerFence,                                // Fence Corner
	Corrupted_Caravan,                          // Corrupted Caravan
	Crates,                                     // Crates
	Crude_Workstation,                          // Crude Workstation
	DebugNode_ClayBig,                          // Clay Deposit (Large)
	DebugNode_ClaySmall,                        // Clay Deposit (Small)
	DebugNode_DewberryBushBig,                  // Dewberry Bush (Large)
	DebugNode_DewberryBushSmall,                // Dewberry Bush (Small)
	DebugNode_FlaxBig,                          // Flax Field (Large)
	DebugNode_FlaxSmall,                        // Flax Field (Small)
	DebugNode_HerbsBig,                         // Herb Node (Large)
	DebugNode_HerbsSmall,                       // Herb Node (Small)
	DebugNode_LeechBroodmotherBig,              // Leech Broodmother (Large)
	DebugNode_LeechBroodmotherSmall,            // Leech Broodmother (Small)
	DebugNode_Marshlands_InfiniteGrain,         // Ancient Proto Wheat
	DebugNode_Marshlands_InfiniteMeat,          // Dead Leviathan
	DebugNode_Marshlands_InfiniteMushroom,      // Giant Proto Fungus
	DebugNode_MarshlandsMushroomBig,            // Grasscap Mushrooms (Large)
	DebugNode_MarshlandsMushroomSmall,          // Grasscap Mushrooms (Small)
	DebugNode_MossBroccoliBig,                  // Moss Broccoli Patch (Large)
	DebugNode_MossBroccoliSmall,                // Moss Broccoli Patch (Small)
	DebugNode_MushroomBig,                      // Grasscap Mushrooms (Large)
	DebugNode_MushroomSmall,                    // Grasscap Mushrooms (Small)
	DebugNode_ReedBig,                          // Reed Field (Large)
	DebugNode_ReedSmall,                        // Reed Field (Small)
	DebugNode_RootsBig,                         // Root Deposit (Large)
	DebugNode_RootsSmall,                       // Root Deposit (Small)
	DebugNode_SeaMarrowBig,                     // Sea Marrow Deposit (Large)
	DebugNode_SeaMarrowSmall,                   // Sea Marrow Deposit (Small)
	DebugNode_SnailBroodmotherBig,              // Slickshell Broodmother (Large)
	DebugNode_SnailBroodmotherSmall,            // Slickshell Broodmother (Small)
	DebugNode_SnakeNestBig,                     // Snake Nest (Large)
	DebugNode_SnakeNestSmall,                   // Snake Nest (Small)
	DebugNode_StoneBig,                         // Stone Deposit (Large)
	DebugNode_StoneSmall,                       // Stone Deposit (Small)
	DebugNode_StormbirdNestBig,                 // Drizzlewing Nest (Large)
	DebugNode_StormbirdNestSmall,               // Drizzlewing Nest (Small)
	DebugNode_SwampWheatBig,                    // Swamp Wheat Field (Large)
	DebugNode_SwampWheatSmall,                  // Swamp Wheat Field (Small)
	DebugNode_WormtongueNestBig,                // Wormtongue Nest (Large)
	DebugNode_WormtongueNestSmall,              // Wormtongue Nest (Small)
	Decay_Altar,                                // Altar of Decay
	Decay_Altar_Positive,                       // Converted Altar of Decay
	Distillery,                                 // Distillery
	Druid,                                      // Druid's Hut
	Escaped_Convicts,                           // Escaped Convicts
	Explorers_Lodge,                            // Explorers' Lodge
	Farmfield,                                  // Farm Field
	Fence,                                      // Fence
	Field_Kitchen,                              // Field Kitchen
	Finesmith,                                  // Finesmith
	Fire_Shrine,                                // Fire Shrine
	Fishmen_Cave,                               // Fishmen Cave
	Fishmen_Lighthouse,                         // Fishmen Lighthouse
	Fishmen_Lighthouse_Positive,                // Converted Fishmen Lighthouse
	Fishmen_Outpost,                            // Fishmen Outpost
	Fishmen_Soothsayer,                         // Fishman Soothsayer
	Fishmen_Totem,                              // Fishmen Totem
	Flawless_Brewery,                           // Flawless Brewery
	Flawless_Cellar,                            // Flawless Cellar
	Flawless_Cooperage,                         // Flawless Cooperage
	Flawless_Druid,                             // Flawless Druid's Hut
	Flawless_Leatherworks,                      // Flawless Leatherworker
	Flawless_Rain_Mill,                         // Flawless Rain Mill
	Flawless_Smelter,                           // Flawless Smelter
	Flower_Bed,                                 // Flower Bed
	Foragers_Camp,                              // Foragers' Camp
	ForsakenCrypt,                              // Forsaken Crypt
	Forum,                                      // Forum
	Fountain,                                   // Marble Fountain
	Fox_Fence,                                  // Overgrown Fence
	Fox_Fence_Corner,                           // Overgrown Fence Corner
	Fox_House,                                  // Fox House
	FoxBattleground_T1,                         // Fallen Fox Scouts
	Fuming_Machinery,                           // Fuming Machinery
	Furnace,                                    // Furnace
	Gate,                                       // Gate
	Giant_Stormbird,                            // Giant Stormbird's Nest
	Glade_Trader___The_Hermit,                  // Wandering Merchant - Hermit
	Glade_Trader___The_Seer,                    // Wandering Merchant - Seer
	Glade_Trader___The_Shaman,                  // Wandering Merchant - Shaman
	Gold_Stag,                                  // Golden Treasure Stag
	Gold_Treasure_Stag,                         // Golden Treasure Stag
	Golden_Leaf,                                // Golden Leaf Plant
	Granary,                                    // Granary
	Greenhouse_Workshop,                        // Greenhouse
	Grill,                                      // Grill
	Grove,                                      // Forester's Hut
	Guild_House,                                // Guild House
	Hallowed_Herb_Garden,                       // Hallowed Herb Garden
	Hallowed_SmallFarm,                         // Hallowed Small Farm
	Harmony_Spirit_Altar,                       // Harmony Spirit Altar
	Harmony_Spirit_Altar_Positive,              // Converted Harmony Spirit Altar
	Harpy_House,                                // Harpy House
	HarpyBattleground_T1,                       // Fallen Harpy Scientists
	Harvester_Camp,                             // Harvesters' Camp
	Haunted_Ruined_Beaver_House,                // Haunted Beaver House
	Haunted_Ruined_Brewery,                     // Haunted Brewery
	Haunted_Ruined_Cellar,                      // Haunted Cellar
	Haunted_Ruined_Cooperage,                   // Haunted Cooperage
	Haunted_Ruined_Druid,                       // Haunted Druid's Hut
	Haunted_Ruined_Fox_House,                   // Haunted Fox House
	Haunted_Ruined_Harpy_House,                 // Haunted Harpy House
	Haunted_Ruined_Herb_Garden,                 // Haunted Herb Garden
	Haunted_Ruined_Human_House,                 // Haunted Human House
	Haunted_Ruined_Leatherworks,                // Haunted Leatherworker
	Haunted_Ruined_Lizard_House,                // Haunted Lizard House
	Haunted_Ruined_Market,                      // Haunted Market
	Haunted_Ruined_Rainmill,                    // Haunted Rain Mill
	Haunted_Ruined_SmallFarm,                   // Haunted Small Farm
	Haunted_Ruined_Smelter,                     // Haunted Smelter
	Haunted_Ruined_Temple,                      // Haunted Temple
	Herb_Garden,                                // Herb Garden
	Herbalists_Camp,                            // Herbalists' Camp
	Holy_Market,                                // Holy Market
	Holy_Temple,                                // Holy Temple
	Homestead,                                  // Homestead
	Human_House,                                // Human House
	HumanBattleground_T1,                       // Fallen Human Explorers
	Hydrant,                                    // Hydrant
	Infected_Mole,                              // Infected Drainage Mole
	Infected_Tree,                              // Withered Tree
	Kelpie,                                     // River Kelpie
	Kiln,                                       // Kiln
	Lamp,                                       // Lamp
	Leaking_Cauldron,                           // Leaking Cauldron
	Leatherworks,                               // Leatherworker
	Lightning_Catcher,                          // Lightning Catcher
	Lizard_House,                               // Lizard House
	Lizard_Post,                                // Lizard Post
	LizardBattleground_T1,                      // Fallen Lizard Hunters
	Lore_Tablet_1,                              // Inscribed Monolith
	Lore_Tablet_2,                              // Inscribed Monolith
	Lore_Tablet_3,                              // Inscribed Monolith
	Lore_Tablet_4,                              // Inscribed Monolith
	Lore_Tablet_5,                              // Inscribed Monolith
	Lore_Tablet_6,                              // Inscribed Monolith
	Lore_Tablet_7,                              // Inscribed Monolith
	Lumbermill,                                 // Lumber Mill
	Main_Storage_not_buildable_,                // Main Warehouse
	Makeshift_Post,                             // Makeshift Post
	Manufactory,                                // Manufactory
	Market,                                     // Market
	Merchant_Ship_Wreck,                        // Merchant Shipwreck
	Mine,                                       // Mine
	Mistworm_T1,                                // Hungry Mistworm
	Mole,                                       // Drainage Mole
	Monastery,                                  // Monastery
	Monolith,                                   // Obelisk
	Monolith_Positive,                          // Obelisk
	Mushroom_Decor,                             // Decorative Fungus
	Nightfern,                                  // Nightfern
	Noxious_Machinery,                          // Noxious Machinery
	Path,                                       // Path
	Paved_Road,                                 // Paved Road
	PetrifiedTree_T1,                           // Petrified Tree
	Pipe,                                       // Pipe
	Pipe_Cross,                                 // Pipe Cross
	Pipe_Elbow,                                 // Pipe Elbow
	Pipe_End,                                   // Pipe Ending
	Pipe_T_Cross,                               // Pipe T-Connector
	Pipe_Valve,                                 // Valve
	Plantation,                                 // Plantation
	Press,                                      // Press
	Primitive_Foragers_Camp,                    // Small Foragers' Camp
	Primitive_Herbalists_Camp,                  // Small Herbalists' Camp
	Primitive_Trappers_Camp,                    // Small Trappers' Camp
	Provisioner,                                // Provisioner
	Purged_Beaver_House,                        // Purified Beaver House
	Purged_Fox_House,                           // Purified Fox House
	Purged_Harpy_House,                         // Purified Harpy House
	Purged_Human_House,                         // Purified Human House
	Purged_Lizard_House,                        // Purified Lizard House
	Rain_Catcher,                               // Rain Collector
	Rain_Mill,                                  // Rain Mill
	Rain_Totem,                                 // Rain Spirit Totem
	Rain_Totem_Positive,                        // Converted Rain Totem
	Rainpunk_Barrels,                           // Rainpunk Barrels
	Rainpunk_Drill___Coal,                      // Rainpunk Drill
	Rainpunk_Drill___Copper,                    // Rainpunk Drill
	Rainpunk_Foundry,                           // Rainpunk Foundry
	RainpunkFactory,                            // Destroyed Rainpunk Foundry
	Ranch,                                      // Ranch
	Reinforced_Road,                            // Reinforced Road
	RewardChest_T1,                             // Small Abandoned Cache
	RewardChest_T2,                             // Medium Abandoned Cache
	RewardChest_T3,                             // Large Abandoned Cache
	Road_Sign,                                  // Road Sign
	Ruined_Advanced_Rain_Catcher,               // Advanced Rain Collector
	Ruined_Advanced_Rain_Catcher_no_Reward_,    // Advanced Rain Collector
	Ruined_Alchemist,                           // Alchemist's Hut
	Ruined_Alchemist_no_Reward_,                // Alchemist's Hut
	Ruined_Apothecary,                          // Apothecary
	Ruined_Apothecary_no_Reward_,               // Apothecary
	Ruined_Artisan,                             // Artisan
	Ruined_Artisan_no_Reward_,                  // Artisan
	Ruined_Bakery,                              // Bakery
	Ruined_Bakery_no_Reward_,                   // Bakery
	Ruined_Bath_House,                          // Bath House
	Ruined_Bath_House_no_Reward_,               // Bath House
	Ruined_Beanery,                             // Beanery
	Ruined_Beanery_no_Reward_,                  // Beanery
	Ruined_Beaver_House,                        // Beaver House
	Ruined_Beaver_House_no_Reward_,             // Beaver House
	Ruined_Big_Shelter,                         // Big Shelter
	Ruined_Big_Shelter_no_Reward_,              // Big Shelter
	Ruined_Brewery,                             // Brewery
	Ruined_Brewery_no_Reward_,                  // Brewery
	Ruined_Brick_Oven,                          // Brick Oven
	Ruined_Brick_Oven_no_Reward_,               // Brick Oven
	Ruined_Brickyard,                           // Brickyard
	Ruined_Brickyard_no_Reward_,                // Brickyard
	Ruined_Butcher,                             // Butcher
	Ruined_Butcher_no_Reward_,                  // Butcher
	Ruined_Carpenter,                           // Carpenter
	Ruined_Carpenter_no_Reward_,                // Carpenter
	Ruined_Cellar,                              // Cellar
	Ruined_Cellar_no_Reward_,                   // Cellar
	Ruined_Clan_Hall,                           // Clan Hall
	Ruined_Clan_Hall_no_Reward_,                // Clan Hall
	Ruined_Clay_Pit,                            // Clay Pit
	Ruined_Clay_Pit_no_Reward_,                 // Clay Pit
	Ruined_Cookhouse,                           // Cookhouse
	Ruined_Cookhouse_no_Reward_,                // Cookhouse
	Ruined_Cooperage,                           // Cooperage
	Ruined_Cooperage_no_Reward_,                // Cooperage
	Ruined_Crude_Workstation_no_Reward_,        // Crude Workstation
	Ruined_Distillery,                          // Distillery
	Ruined_Distillery_no_Reward_,               // Distillery
	Ruined_Druid,                               // Druid's Hut
	Ruined_Druid_no_Reward_,                    // Druid's Hut
	Ruined_Explorers_Lodge,                     // Explorers' Lodge
	Ruined_Explorers_Lodge_no_Reward_,          // Explorers' Lodge
	Ruined_Farm,                                // Homestead
	Ruined_Farm_no_Reward_,                     // Homestead
	Ruined_Field_Kitchen_no_Reward_,            // Field Kitchen
	Ruined_Finesmith,                           // Finesmith
	Ruined_Finesmith_no_Reward_,                // Finesmith
	Ruined_Foragers_Camp,                       // Foragers' Camp
	Ruined_Foragers_Camp_no_Reward_,            // Foragers' Camp
	Ruined_Foragers_Camp_Primitive_no_Reward_,  // Foragers' Camp
	Ruined_Forum,                               // Forum
	Ruined_Forum_no_Reward_,                    // Forum
	Ruined_Fox_House,                           // Fox House
	Ruined_Fox_House_no_Reward_,                // Fox House
	Ruined_Furnace,                             // Furnace
	Ruined_Furnace_no_Reward_,                  // Furnace
	Ruined_Granary,                             // Granary
	Ruined_Granary_no_Reward_,                  // Granary
	Ruined_Greenhouse,                          // Greenhouse
	Ruined_Greenhouse_no_Reward_,               // Greenhouse
	Ruined_Grill,                               // Grill
	Ruined_Grill_no_Reward_,                    // Grill
	Ruined_Grove,                               // Forester's Hut
	Ruined_Grove_no_Reward_,                    // Forester's Hut
	Ruined_Guild_House,                         // Guild House
	Ruined_Guild_House_no_Reward_,              // Guild House
	Ruined_Harpy_House,                         // Harpy House
	Ruined_Harpy_House_no_Reward_,              // Harpy House
	Ruined_Harvester_Camp,                      // Harvesters' Camp
	Ruined_Harvester_Camp_no_Reward_,           // Harvesters' Camp
	Ruined_Hearth,                              // Ancient Hearth
	Ruined_Hearth_no_Reward_,                   // Ancient Hearth
	Ruined_Herb_Garden,                         // Herb Garden
	Ruined_Herb_Garden_no_Reward_,              // Herb Garden
	Ruined_Herbalist_Camp,                      // Herbalists' Camp
	Ruined_Herbalist_Camp_no_Reward_,           // Herbalists' Camp
	Ruined_Herbalist_Camp_Primitive_no_Reward_, // Herbalists' Camp
	Ruined_Human_House,                         // Human House
	Ruined_Human_House_no_Reward_,              // Human House
	Ruined_Kiln,                                // Kiln
	Ruined_Kiln_no_Reward_,                     // Kiln
	Ruined_Leatherworks,                        // Leatherworker
	Ruined_Leatherworks_no_Reward_,             // Leatherworker
	Ruined_Lizard_House,                        // Lizard House
	Ruined_Lizard_House_no_Reward_,             // Lizard House
	Ruined_Lumbermill,                          // Lumber Mill
	Ruined_Lumbermill_no_Reward_,               // Lumber Mill
	Ruined_Makeshift_Post_no_Reward_,           // Makeshift Post
	Ruined_Manufatory,                          // Manufactory
	Ruined_Manufatory_no_Reward_,               // Manufactory
	Ruined_Market,                              // Market
	Ruined_Market_no_Reward_,                   // Market
	Ruined_Mine_no_Reward_,                     // Mine
	Ruined_Monastery,                           // Monastery
	Ruined_Monastery_no_Reward_,                // Monastery
	Ruined_Plantation,                          // Plantation
	Ruined_Plantation_no_Reward_,               // Plantation
	Ruined_Press,                               // Press
	Ruined_Press_no_Reward_,                    // Press
	Ruined_Provisioner,                         // Provisioner
	Ruined_Provisioner_no_Reward_,              // Provisioner
	Ruined_Rain_Catcher_no_Reward_,             // Rain Collector
	Ruined_Rainmill,                            // Rain Mill
	Ruined_Rainmill_no_Reward_,                 // Rain Mill
	Ruined_Ranch,                               // Ranch
	Ruined_Ranch_no_Reward_,                    // Ranch
	Ruined_Scribe,                              // Scribe
	Ruined_Scribe_no_Reward_,                   // Scribe
	Ruined_Sewer,                               // Clothier
	Ruined_Sewer_no_Reward_,                    // Clothier
	Ruined_Shelter,                             // Shelter
	Ruined_Shelter_no_Reward_,                  // Shelter
	Ruined_SmallFarm,                           // Small Farm
	Ruined_SmallFarm_no_Reward_,                // Small Farm
	Ruined_Smelter,                             // Smelter
	Ruined_Smelter_no_Reward_,                  // Smelter
	Ruined_Smithy,                              // Smithy
	Ruined_Smithy_no_Reward_,                   // Smithy
	Ruined_Smokehouse,                          // Smokehouse
	Ruined_Smokehouse_no_Reward_,               // Smokehouse
	Ruined_Stamping_Mill,                       // Stamping Mill
	Ruined_Stamping_Mill_no_Reward_,            // Stamping Mill
	Ruined_Stonecutter_Camp,                    // Stonecutters' Camp
	Ruined_Stonecutter_Camp_no_Reward_,         // Stonecutters' Camp
	Ruined_Storage,                             // Small Warehouse
	Ruined_Storage_no_Reward_,                  // Small Warehouse
	Ruined_Supplier,                            // Supplier
	Ruined_Supplier_no_Reward_,                 // Supplier
	Ruined_Tavern,                              // Tavern
	Ruined_Tavern_no_Reward_,                   // Tavern
	Ruined_Tea_Doctor,                          // Tea Doctor
	Ruined_Tea_Doctor_no_Reward_,               // Tea Doctor
	Ruined_Tea_House,                           // Teahouse
	Ruined_Tea_House_no_Reward_,                // Teahouse
	Ruined_Temple,                              // Temple
	Ruined_Temple_no_Reward_,                   // Temple
	Ruined_Tinctury,                            // Tinctury
	Ruined_Tinctury_no_Reward_,                 // Tinctury
	Ruined_Tinkerer,                            // Tinkerer
	Ruined_Tinkerer_no_Reward_,                 // Tinkerer
	Ruined_Toolshop,                            // Toolshop
	Ruined_Toolshop_no_Reward_,                 // Toolshop
	Ruined_Trading_Post_no_Reward_,             // Trading Post
	Ruined_Trappers_Camp,                       // Trappers' Camp
	Ruined_Trappers_Camp_no_Reward_,            // Trappers' Camp
	Ruined_Trappers_Camp_Primitive_no_Reward_,  // Trappers' Camp
	Ruined_Weaver,                              // Weaver
	Ruined_Weaver_no_Reward_,                   // Weaver
	Ruined_Woodcutters_Camp,                    // Woodcutters' Camp
	Ruined_Woodcutters_Camp_no_Reward_,         // Woodcutters' Camp
	Ruined_Workshop,                            // Workshop
	Ruined_Workshop_no_Reward_,                 // Workshop
	Sacrifice_Totem,                            // Totem of Denial
	Sacrifice_Totem_Positive,                   // Converted Totem of Denial
	Scarlet_Decor,                              // Thorny Reed
	Scorpion_1,                                 // Archaeological Discovery
	Scorpion_2,                                 // Archaeological Excavation
	Scorpion_3,                                 // Archaeological Reconstruction
	Scribe,                                     // Scribe
	Seal,                                       // Ancient Seal
	Seal_Guidepost,                             // Guidance Stone
	Seal_Low_Diff,                              // Ancient Seal
	Sealed_Biome_Shrine,                        // Beacon Tower
	SealedTomb_T1,                              // Open Vault
	Shelter,                                    // Shelter
	Signboard,                                  // Signboard
	Small_Hearth,                               // Ancient Hearth
	SmallFarm,                                  // Small Farm
	Smelter,                                    // Smelter
	Smithy,                                     // Smithy
	Smokehouse,                                 // Smokehouse
	Snake_1,                                    // Archaeological Discovery
	Snake_2,                                    // Archaeological Excavation
	Snake_3,                                    // Archaeological Reconstruction
	Spider_1,                                   // Archaeological Discovery
	Spider_2,                                   // Archaeological Excavation
	Spider_3,                                   // Archaeological Reconstruction
	Stamping_Mill,                              // Stamping Mill
	Stonecutters_Camp,                          // Stonecutters' Camp
	Storage_buildable_,                         // Small Warehouse
	Stormbird_Positive,                         // Tamed Stormbird
	Supplier,                                   // Supplier
	Tavern,                                     // Tavern
	Tea_Doctor,                                 // Tea Doctor
	Tea_House,                                  // Teahouse
	Temple,                                     // Temple
	Temporary_Hearth_buildable_,                // Small Hearth
	Temporary_Hearth_not_buildable_,            // Small Hearth
	Termite_Burrow,                             // Stonetooth Termite Burrow
	Termite_Burrow_Positive,                    // Termite Nest
	TI_AncientShrine_T1,                        // Ancient Shrine
	Tinctury,                                   // Tinctury
	Tinkerer,                                   // Tinkerer
	Toolshop,                                   // Toolshop
	Tower,                                      // Wall Crossing
	Town_Board,                                 // Town Board
	Traders_Cemetery,                           // Hidden Trader Cemetery
	Trading_Post,                               // Trading Post
	Trappers_Camp,                              // Trappers' Camp
	Umbrella,                                   // Umbrella
	Wall,                                       // Wall
	Wall_Corner,                                // Wall Corner
	War_Beast_Cage,                             // Destroyed Cage of the Warbeast
	Water_Barrels,                              // Water Barrels
	Water_Extractor,                            // Geyser Pump
	Weaver,                                     // Weaver
	Well,                                       // Overgrown Well
	White_Stag,                                 // Royal Treasure Stag
	White_Treasure_Stag,                        // Royal Treasure Stag
	Wildfire,                                   // Wildfire
	Woodcutters_Camp,                           // Woodcutters' Camp
	Workshop,                                   // Workshop

    MAX = 495
}

public static class BuildingTypesExtensions
{
	public static string ToName(this BuildingTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of BuildingTypes: " + type);
		return TypeToInternalName[BuildingTypes.Advanced_Rain_Catcher];
	}
	
	public static BuildingModel ToBuildingModel(this string name)
    {
        BuildingModel model = SO.Settings.Buildings.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find BuildingModel for BuildingTypes with name: " + name);
        return null;
    }

	public static BuildingModel ToBuildingModel(this BuildingTypes types)
	{
		return types.ToName().ToBuildingModel();
	}
	
	public static BuildingModel[] ToBuildingModelArray(this IEnumerable<BuildingTypes> collection)
    {
        int count = collection.Count();
        BuildingModel[] array = new BuildingModel[count];
        int i = 0;
        foreach (BuildingTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.Buildings.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<BuildingTypes, string> TypeToInternalName = new()
	{
		{ BuildingTypes.Advanced_Rain_Catcher, "Advanced Rain Catcher" },                                            // Advanced Rain Collector
		{ BuildingTypes.Aestherics_2x2___Garden, "Aestherics 2x2 - Garden" },                                        // Garden
		{ BuildingTypes.Aestherics_2x2___Groundwater_Extractor, "Aestherics 2x2 - Groundwater Extractor" },          // Makeshift Extractor
		{ BuildingTypes.Alchemist_Hut, "Alchemist Hut" },                                                            // Alchemist's Hut
		{ BuildingTypes.Altar, "Altar" },                                                                            // Forsaken Altar
		{ BuildingTypes.Ancient_Gravestone, "Ancient Gravestone" },                                                  // Ancient Tombstone
		{ BuildingTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                            // Ancient Burial Site
		{ BuildingTypes.AncientGate, "AncientGate" },                                                                // Dark Gate
		{ BuildingTypes.AncientShrine_T1, "AncientShrine_T1" },                                                      // Ancient Shrine
		{ BuildingTypes.AncientTemple, "AncientTemple" },                                                            // Forgotten Temple of the Sun
		{ BuildingTypes.Angry_Ghost_1, "Angry Ghost 1" },                                                            // Ghost of a Blight Fighter Captain
		{ BuildingTypes.Angry_Ghost_10, "Angry Ghost 10" },                                                          // Ghost of a Suppressed Rebel
		{ BuildingTypes.Angry_Ghost_14, "Angry Ghost 14" },                                                          // Ghost of a Resentful Human
		{ BuildingTypes.Angry_Ghost_15, "Angry Ghost 15" },                                                          // Ghost of the Queen's Lickspittle
		{ BuildingTypes.Angry_Ghost_16, "Angry Ghost 16" },                                                          // Ghost of a Lizard Leader
		{ BuildingTypes.Angry_Ghost_17, "Angry Ghost 17" },                                                          // Ghost of a Tortured Harpy
		{ BuildingTypes.Angry_Ghost_18, "Angry Ghost 18" },                                                          // Ghost of a Beaver Engineer
		{ BuildingTypes.Angry_Ghost_19, "Angry Ghost 19" },                                                          // Ghost of a Poisoned Human
		{ BuildingTypes.Angry_Ghost_2, "Angry Ghost 2" },                                                            // Ghost of a Mad Alchemist
		{ BuildingTypes.Angry_Ghost_20, "Angry Ghost 20" },                                                          // Ghost of a Lizard Worker
		{ BuildingTypes.Angry_Ghost_21, "Angry Ghost 21" },                                                          // Ghost of a Starved Harpy
		{ BuildingTypes.Angry_Ghost_24, "Angry Ghost 24" },                                                          // Ghost of an Innkeeper
		{ BuildingTypes.Angry_Ghost_31, "Angry Ghost 31" },                                                          // Ghost of a Lizard Elder
		{ BuildingTypes.Angry_Ghost_32, "Angry Ghost 32" },                                                          // Ghost of a Lost Scout
		{ BuildingTypes.Angry_Ghost_34, "Angry Ghost 34" },                                                          // Ghost of a Murdered Trader
		{ BuildingTypes.Angry_Ghost_4, "Angry Ghost 4" },                                                            // Ghost of a Deranged Scout
		{ BuildingTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                            // Ghost of a Furious Villager
		{ BuildingTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                            // Ghost of a Scared Firekeeper
		{ BuildingTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                            // Ghost of a Loyal Servant
		{ BuildingTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                  // Ghost Chest
		{ BuildingTypes.Anvil, "Anvil" },                                                                            // Anvil
		{ BuildingTypes.API_ExampleMod_BurgerJoint, "API_ExampleMod_BurgerJoint" },                                  // Borgor King
		{ BuildingTypes.Apothecary, "Apothecary" },                                                                  // Apothecary
		{ BuildingTypes.Arch, "Arch" },                                                                              // Ancient Arch
		{ BuildingTypes.Archaeology_Scorpion_Positive, "Archaeology Scorpion Positive" },                            // Smoldering Scorpion
		{ BuildingTypes.Archaeology_Snake_Positive, "Archaeology Snake Positive" },                                  // Sea Serpent
		{ BuildingTypes.Archaeology_Spider_Positive, "Archaeology Spider Positive" },                                // Sealed Spider
		{ BuildingTypes.Archeology_Office, "Archeology office" },                                                    // Archaeologist's Office
		{ BuildingTypes.Artisan, "Artisan" },                                                                        // Artisan
		{ BuildingTypes.Bakery, "Bakery" },                                                                          // Bakery
		{ BuildingTypes.Bank, "Bank" },                                                                              // Bench
		{ BuildingTypes.Barrels, "Barrels" },                                                                        // Barrels
		{ BuildingTypes.Bath_House, "Bath House" },                                                                  // Bath House
		{ BuildingTypes.Beanery, "Beanery" },                                                                        // Beanery
		{ BuildingTypes.Beaver_House, "Beaver House" },                                                              // Beaver House
		{ BuildingTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                            // Fallen Beaver Traders
		{ BuildingTypes.Big_Shelter, "Big Shelter" },                                                                // Big Shelter
		{ BuildingTypes.Black_Stag, "Black Stag" },                                                                  // Black Treasure Stag
		{ BuildingTypes.Black_Treasure_Stag, "Black Treasure Stag" },                                                // Black Treasure Stag
		{ BuildingTypes.Blight_Post, "Blight Post" },                                                                // Blight Post
		{ BuildingTypes.Blightrot, "Blightrot" },                                                                    // Blood Flower
		{ BuildingTypes.Blightrot___Clone, "Blightrot - Clone" },                                                    // Blood Flower (Clone)
		{ BuildingTypes.Blightrot_Cauldron, "Blightrot Cauldron" },                                                  // Blightrot Cauldron
		{ BuildingTypes.Bonfire, "Bonfire" },                                                                        // Bonfire
		{ BuildingTypes.Brewery, "Brewery" },                                                                        // Brewery
		{ BuildingTypes.Brick_Oven, "Brick Oven" },                                                                  // Brick Oven
		{ BuildingTypes.Brickyard, "Brickyard" },                                                                    // Brickyard
		{ BuildingTypes.Bush, "Bush" },                                                                              // Bush
		{ BuildingTypes.Butcher, "Butcher" },                                                                        // Butcher
		{ BuildingTypes.Cages, "Cages" },                                                                            // Cages
		{ BuildingTypes.Calm_Ghost_11, "Calm Ghost 11" },                                                            // Ghost of a Defeated Viceroy
		{ BuildingTypes.Calm_Ghost_12, "Calm Ghost 12" },                                                            // Ghost of a Druid
		{ BuildingTypes.Calm_Ghost_13, "Calm Ghost 13" },                                                            // Ghost of a Royal Gardener
		{ BuildingTypes.Calm_Ghost_22, "Calm Ghost 22" },                                                            // Ghost of a Hooded Knight
		{ BuildingTypes.Calm_Ghost_23, "Calm Ghost 23" },                                                            // Ghost of a Fire Priest
		{ BuildingTypes.Calm_Ghost_25, "Calm Ghost 25" },                                                            // Ghost of a Treasure Hunter
		{ BuildingTypes.Calm_Ghost_26, "Calm Ghost 26" },                                                            // Ghost of a Royal Architect
		{ BuildingTypes.Calm_Ghost_27, "Calm Ghost 27" },                                                            // Ghost of a Worried Carter
		{ BuildingTypes.Calm_Ghost_28, "Calm Ghost 28" },                                                            // Ghost of a Storm Victim
		{ BuildingTypes.Calm_Ghost_29, "Calm Ghost 29" },                                                            // Ghost of a Mourning Harpy
		{ BuildingTypes.Calm_Ghost_3, "Calm Ghost 3" },                                                              // Ghost of a Terrified Woodcutter
		{ BuildingTypes.Calm_Ghost_30, "Calm Ghost 30" },                                                            // Ghost of a Lizard General
		{ BuildingTypes.Calm_Ghost_33, "Calm Ghost 33" },                                                            // Ghost of an Old Merchant
		{ BuildingTypes.Calm_Ghost_35, "Calm Ghost 35" },                                                            // Ghost of a Fox Elder
		{ BuildingTypes.Calm_Ghost_36, "Calm Ghost 36" },                                                            // Ghost of a Teadoctor
		{ BuildingTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                              // Ghost of a Troublemaker
		{ BuildingTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                              // Ghost of a Fallen Newcomer
		{ BuildingTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                    // Ghost Chest
		{ BuildingTypes.Camp_T1, "Camp_T1" },                                                                        // Small Encampment
		{ BuildingTypes.Camp_T2, "Camp_T2" },                                                                        // Large Encampment
		{ BuildingTypes.Caravan_T1, "Caravan_T1" },                                                                  // Small Destroyed Caravan
		{ BuildingTypes.Caravan_T2, "Caravan_T2" },                                                                  // Large Destroyed Caravan
		{ BuildingTypes.Carpenter, "Carpenter" },                                                                    // Carpenter
		{ BuildingTypes.Cellar, "Cellar" },                                                                          // Cellar
		{ BuildingTypes.Chest, "Chest" },                                                                            // Chest
		{ BuildingTypes.Clan_Hall, "Clan Hall" },                                                                    // Clan Hall
		{ BuildingTypes.Clay_Pit_Workshop, "Clay Pit Workshop" },                                                    // Clay Pit
		{ BuildingTypes.Clothier, "Clothier" },                                                                      // Clothier
		{ BuildingTypes.Comfort_2x2___Park, "Comfort 2x2 - Park" },                                                  // Park
		{ BuildingTypes.Cookhouse, "Cookhouse" },                                                                    // Cookhouse
		{ BuildingTypes.Cooperage, "Cooperage" },                                                                    // Cooperage
		{ BuildingTypes.Coral_Decor, "Coral Decor" },                                                                // Coral Growth
		{ BuildingTypes.CornerFence, "CornerFence" },                                                                // Fence Corner
		{ BuildingTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                    // Corrupted Caravan
		{ BuildingTypes.Crates, "Crates" },                                                                          // Crates
		{ BuildingTypes.Crude_Workstation, "Crude Workstation" },                                                    // Crude Workstation
		{ BuildingTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                    // Clay Deposit (Large)
		{ BuildingTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                                // Clay Deposit (Small)
		{ BuildingTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                                    // Dewberry Bush (Large)
		{ BuildingTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                                // Dewberry Bush (Small)
		{ BuildingTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                                    // Flax Field (Large)
		{ BuildingTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                                // Flax Field (Small)
		{ BuildingTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                                  // Herb Node (Large)
		{ BuildingTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                              // Herb Node (Small)
		{ BuildingTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                            // Leech Broodmother (Large)
		{ BuildingTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                        // Leech Broodmother (Small)
		{ BuildingTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },                  // Ancient Proto Wheat
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },                    // Dead Leviathan
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },            // Giant Proto Fungus
		{ BuildingTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                        // Grasscap Mushrooms (Large)
		{ BuildingTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },                    // Grasscap Mushrooms (Small)
		{ BuildingTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                                    // Moss Broccoli Patch (Large)
		{ BuildingTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                                // Moss Broccoli Patch (Small)
		{ BuildingTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                            // Grasscap Mushrooms (Large)
		{ BuildingTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                        // Grasscap Mushrooms (Small)
		{ BuildingTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                                    // Reed Field (Large)
		{ BuildingTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                                // Reed Field (Small)
		{ BuildingTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                  // Root Deposit (Large)
		{ BuildingTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                              // Root Deposit (Small)
		{ BuildingTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                          // Sea Marrow Deposit (Large)
		{ BuildingTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                      // Sea Marrow Deposit (Small)
		{ BuildingTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                            // Slickshell Broodmother (Large)
		{ BuildingTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                        // Slickshell Broodmother (Small)
		{ BuildingTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                          // Snake Nest (Large)
		{ BuildingTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                      // Snake Nest (Small)
		{ BuildingTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                  // Stone Deposit (Large)
		{ BuildingTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                              // Stone Deposit (Small)
		{ BuildingTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                                  // Drizzlewing Nest (Large)
		{ BuildingTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                              // Drizzlewing Nest (Small)
		{ BuildingTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                        // Swamp Wheat Field (Large)
		{ BuildingTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                                    // Swamp Wheat Field (Small)
		{ BuildingTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                                // Wormtongue Nest (Large)
		{ BuildingTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                            // Wormtongue Nest (Small)
		{ BuildingTypes.Decay_Altar, "Decay Altar" },                                                                // Altar of Decay
		{ BuildingTypes.Decay_Altar_Positive, "Decay Altar Positive" },                                              // Converted Altar of Decay
		{ BuildingTypes.Distillery, "Distillery" },                                                                  // Distillery
		{ BuildingTypes.Druid, "Druid" },                                                                            // Druid's Hut
		{ BuildingTypes.Escaped_Convicts, "Escaped Convicts" },                                                      // Escaped Convicts
		{ BuildingTypes.Explorers_Lodge, "Explorers Lodge" },                                                        // Explorers' Lodge
		{ BuildingTypes.Farmfield, "Farmfield" },                                                                    // Farm Field
		{ BuildingTypes.Fence, "Fence" },                                                                            // Fence
		{ BuildingTypes.Field_Kitchen, "Field Kitchen" },                                                            // Field Kitchen
		{ BuildingTypes.Finesmith, "Finesmith" },                                                                    // Finesmith
		{ BuildingTypes.Fire_Shrine, "Fire Shrine" },                                                                // Fire Shrine
		{ BuildingTypes.Fishmen_Cave, "Fishmen Cave" },                                                              // Fishmen Cave
		{ BuildingTypes.Fishmen_Lighthouse, "Fishmen Lighthouse" },                                                  // Fishmen Lighthouse
		{ BuildingTypes.Fishmen_Lighthouse_Positive, "Fishmen Lighthouse Positive" },                                // Converted Fishmen Lighthouse
		{ BuildingTypes.Fishmen_Outpost, "Fishmen Outpost" },                                                        // Fishmen Outpost
		{ BuildingTypes.Fishmen_Soothsayer, "Fishmen Soothsayer" },                                                  // Fishman Soothsayer
		{ BuildingTypes.Fishmen_Totem, "Fishmen Totem" },                                                            // Fishmen Totem
		{ BuildingTypes.Flawless_Brewery, "Flawless Brewery" },                                                      // Flawless Brewery
		{ BuildingTypes.Flawless_Cellar, "Flawless Cellar" },                                                        // Flawless Cellar
		{ BuildingTypes.Flawless_Cooperage, "Flawless Cooperage" },                                                  // Flawless Cooperage
		{ BuildingTypes.Flawless_Druid, "Flawless Druid" },                                                          // Flawless Druid's Hut
		{ BuildingTypes.Flawless_Leatherworks, "Flawless Leatherworks" },                                            // Flawless Leatherworker
		{ BuildingTypes.Flawless_Rain_Mill, "Flawless Rain Mill" },                                                  // Flawless Rain Mill
		{ BuildingTypes.Flawless_Smelter, "Flawless Smelter" },                                                      // Flawless Smelter
		{ BuildingTypes.Flower_Bed, "Flower Bed" },                                                                  // Flower Bed
		{ BuildingTypes.Foragers_Camp, "Forager's Camp" },                                                           // Foragers' Camp
		{ BuildingTypes.ForsakenCrypt, "ForsakenCrypt" },                                                            // Forsaken Crypt
		{ BuildingTypes.Forum, "Forum" },                                                                            // Forum
		{ BuildingTypes.Fountain, "Fountain" },                                                                      // Marble Fountain
		{ BuildingTypes.Fox_Fence, "Fox Fence" },                                                                    // Overgrown Fence
		{ BuildingTypes.Fox_Fence_Corner, "Fox Fence Corner" },                                                      // Overgrown Fence Corner
		{ BuildingTypes.Fox_House, "Fox House" },                                                                    // Fox House
		{ BuildingTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                                  // Fallen Fox Scouts
		{ BuildingTypes.Fuming_Machinery, "Fuming Machinery" },                                                      // Fuming Machinery
		{ BuildingTypes.Furnace, "Furnace" },                                                                        // Furnace
		{ BuildingTypes.Gate, "Gate" },                                                                              // Gate
		{ BuildingTypes.Giant_Stormbird, "Giant Stormbird" },                                                        // Giant Stormbird's Nest
		{ BuildingTypes.Glade_Trader___The_Hermit, "Glade Trader - The Hermit" },                                    // Wandering Merchant - Hermit
		{ BuildingTypes.Glade_Trader___The_Seer, "Glade Trader - The Seer" },                                        // Wandering Merchant - Seer
		{ BuildingTypes.Glade_Trader___The_Shaman, "Glade Trader - The Shaman" },                                    // Wandering Merchant - Shaman
		{ BuildingTypes.Gold_Stag, "Gold Stag" },                                                                    // Golden Treasure Stag
		{ BuildingTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                  // Golden Treasure Stag
		{ BuildingTypes.Golden_Leaf, "Golden Leaf" },                                                                // Golden Leaf Plant
		{ BuildingTypes.Granary, "Granary" },                                                                        // Granary
		{ BuildingTypes.Greenhouse_Workshop, "Greenhouse Workshop" },                                                // Greenhouse
		{ BuildingTypes.Grill, "Grill" },                                                                            // Grill
		{ BuildingTypes.Grove, "Grove" },                                                                            // Forester's Hut
		{ BuildingTypes.Guild_House, "Guild House" },                                                                // Guild House
		{ BuildingTypes.Hallowed_Herb_Garden, "Hallowed Herb Garden" },                                              // Hallowed Herb Garden
		{ BuildingTypes.Hallowed_SmallFarm, "Hallowed SmallFarm" },                                                  // Hallowed Small Farm
		{ BuildingTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                              // Harmony Spirit Altar
		{ BuildingTypes.Harmony_Spirit_Altar_Positive, "Harmony Spirit Altar Positive" },                            // Converted Harmony Spirit Altar
		{ BuildingTypes.Harpy_House, "Harpy House" },                                                                // Harpy House
		{ BuildingTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                              // Fallen Harpy Scientists
		{ BuildingTypes.Harvester_Camp, "Harvester Camp" },                                                          // Harvesters' Camp
		{ BuildingTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                                // Haunted Beaver House
		{ BuildingTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                          // Haunted Brewery
		{ BuildingTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                            // Haunted Cellar
		{ BuildingTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                      // Haunted Cooperage
		{ BuildingTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                              // Haunted Druid's Hut
		{ BuildingTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                      // Haunted Fox House
		{ BuildingTypes.Haunted_Ruined_Harpy_House, "Haunted Ruined Harpy House" },                                  // Haunted Harpy House
		{ BuildingTypes.Haunted_Ruined_Herb_Garden, "Haunted Ruined Herb Garden" },                                  // Haunted Herb Garden
		{ BuildingTypes.Haunted_Ruined_Human_House, "Haunted Ruined Human House" },                                  // Haunted Human House
		{ BuildingTypes.Haunted_Ruined_Leatherworks, "Haunted Ruined Leatherworks" },                                // Haunted Leatherworker
		{ BuildingTypes.Haunted_Ruined_Lizard_House, "Haunted Ruined Lizard House" },                                // Haunted Lizard House
		{ BuildingTypes.Haunted_Ruined_Market, "Haunted Ruined Market" },                                            // Haunted Market
		{ BuildingTypes.Haunted_Ruined_Rainmill, "Haunted Ruined Rainmill" },                                        // Haunted Rain Mill
		{ BuildingTypes.Haunted_Ruined_SmallFarm, "Haunted Ruined SmallFarm" },                                      // Haunted Small Farm
		{ BuildingTypes.Haunted_Ruined_Smelter, "Haunted Ruined Smelter" },                                          // Haunted Smelter
		{ BuildingTypes.Haunted_Ruined_Temple, "Haunted Ruined Temple" },                                            // Haunted Temple
		{ BuildingTypes.Herb_Garden, "Herb Garden" },                                                                // Herb Garden
		{ BuildingTypes.Herbalists_Camp, "Herbalist's Camp" },                                                       // Herbalists' Camp
		{ BuildingTypes.Holy_Market, "Holy Market" },                                                                // Holy Market
		{ BuildingTypes.Holy_Temple, "Holy Temple" },                                                                // Holy Temple
		{ BuildingTypes.Homestead, "Homestead" },                                                                    // Homestead
		{ BuildingTypes.Human_House, "Human House" },                                                                // Human House
		{ BuildingTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                              // Fallen Human Explorers
		{ BuildingTypes.Hydrant, "Hydrant" },                                                                        // Hydrant
		{ BuildingTypes.Infected_Mole, "Infected Mole" },                                                            // Infected Drainage Mole
		{ BuildingTypes.Infected_Tree, "Infected Tree" },                                                            // Withered Tree
		{ BuildingTypes.Kelpie, "Kelpie" },                                                                          // River Kelpie
		{ BuildingTypes.Kiln, "Kiln" },                                                                              // Kiln
		{ BuildingTypes.Lamp, "Lamp" },                                                                              // Lamp
		{ BuildingTypes.Leaking_Cauldron, "Leaking Cauldron" },                                                      // Leaking Cauldron
		{ BuildingTypes.Leatherworks, "Leatherworks" },                                                              // Leatherworker
		{ BuildingTypes.Lightning_Catcher, "Lightning Catcher" },                                                    // Lightning Catcher
		{ BuildingTypes.Lizard_House, "Lizard House" },                                                              // Lizard House
		{ BuildingTypes.Lizard_Post, "Lizard Post" },                                                                // Lizard Post
		{ BuildingTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                            // Fallen Lizard Hunters
		{ BuildingTypes.Lore_Tablet_1, "Lore Tablet 1" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_2, "Lore Tablet 2" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_3, "Lore Tablet 3" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_4, "Lore Tablet 4" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_5, "Lore Tablet 5" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_6, "Lore Tablet 6" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lore_Tablet_7, "Lore Tablet 7" },                                                            // Inscribed Monolith
		{ BuildingTypes.Lumbermill, "Lumbermill" },                                                                  // Lumber Mill
		{ BuildingTypes.Main_Storage_not_buildable_, "Main Storage (not-buildable)" },                               // Main Warehouse
		{ BuildingTypes.Makeshift_Post, "Makeshift Post" },                                                          // Makeshift Post
		{ BuildingTypes.Manufactory, "Manufactory" },                                                                // Manufactory
		{ BuildingTypes.Market, "Market" },                                                                          // Market
		{ BuildingTypes.Merchant_Ship_Wreck, "Merchant Ship Wreck" },                                                // Merchant Shipwreck
		{ BuildingTypes.Mine, "Mine" },                                                                              // Mine
		{ BuildingTypes.Mistworm_T1, "Mistworm_T1" },                                                                // Hungry Mistworm
		{ BuildingTypes.Mole, "Mole" },                                                                              // Drainage Mole
		{ BuildingTypes.Monastery, "Monastery" },                                                                    // Monastery
		{ BuildingTypes.Monolith, "Monolith" },                                                                      // Obelisk
		{ BuildingTypes.Monolith_Positive, "Monolith Positive" },                                                    // Obelisk
		{ BuildingTypes.Mushroom_Decor, "Mushroom Decor" },                                                          // Decorative Fungus
		{ BuildingTypes.Nightfern, "Nightfern" },                                                                    // Nightfern
		{ BuildingTypes.Noxious_Machinery, "Noxious Machinery" },                                                    // Noxious Machinery
		{ BuildingTypes.Path, "Path" },                                                                              // Path
		{ BuildingTypes.Paved_Road, "Paved Road" },                                                                  // Paved Road
		{ BuildingTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                      // Petrified Tree
		{ BuildingTypes.Pipe, "Pipe" },                                                                              // Pipe
		{ BuildingTypes.Pipe_Cross, "Pipe Cross" },                                                                  // Pipe Cross
		{ BuildingTypes.Pipe_Elbow, "Pipe Elbow" },                                                                  // Pipe Elbow
		{ BuildingTypes.Pipe_End, "Pipe End" },                                                                      // Pipe Ending
		{ BuildingTypes.Pipe_T_Cross, "Pipe T Cross" },                                                              // Pipe T-Connector
		{ BuildingTypes.Pipe_Valve, "Pipe Valve" },                                                                  // Valve
		{ BuildingTypes.Plantation, "Plantation" },                                                                  // Plantation
		{ BuildingTypes.Press, "Press" },                                                                            // Press
		{ BuildingTypes.Primitive_Foragers_Camp, "Primitive Forager's Camp" },                                       // Small Foragers' Camp
		{ BuildingTypes.Primitive_Herbalists_Camp, "Primitive Herbalist's Camp" },                                   // Small Herbalists' Camp
		{ BuildingTypes.Primitive_Trappers_Camp, "Primitive Trapper's Camp" },                                       // Small Trappers' Camp
		{ BuildingTypes.Provisioner, "Provisioner" },                                                                // Provisioner
		{ BuildingTypes.Purged_Beaver_House, "Purged Beaver House" },                                                // Purified Beaver House
		{ BuildingTypes.Purged_Fox_House, "Purged Fox House" },                                                      // Purified Fox House
		{ BuildingTypes.Purged_Harpy_House, "Purged Harpy House" },                                                  // Purified Harpy House
		{ BuildingTypes.Purged_Human_House, "Purged Human House" },                                                  // Purified Human House
		{ BuildingTypes.Purged_Lizard_House, "Purged Lizard House" },                                                // Purified Lizard House
		{ BuildingTypes.Rain_Catcher, "Rain Catcher" },                                                              // Rain Collector
		{ BuildingTypes.Rain_Mill, "Rain Mill" },                                                                    // Rain Mill
		{ BuildingTypes.Rain_Totem, "Rain Totem" },                                                                  // Rain Spirit Totem
		{ BuildingTypes.Rain_Totem_Positive, "Rain Totem Positive" },                                                // Converted Rain Totem
		{ BuildingTypes.Rainpunk_Barrels, "Rainpunk Barrels" },                                                      // Rainpunk Barrels
		{ BuildingTypes.Rainpunk_Drill___Coal, "Rainpunk Drill - Coal" },                                            // Rainpunk Drill
		{ BuildingTypes.Rainpunk_Drill___Copper, "Rainpunk Drill - Copper" },                                        // Rainpunk Drill
		{ BuildingTypes.Rainpunk_Foundry, "Rainpunk Foundry" },                                                      // Rainpunk Foundry
		{ BuildingTypes.RainpunkFactory, "RainpunkFactory" },                                                        // Destroyed Rainpunk Foundry
		{ BuildingTypes.Ranch, "Ranch" },                                                                            // Ranch
		{ BuildingTypes.Reinforced_Road, "Reinforced Road" },                                                        // Reinforced Road
		{ BuildingTypes.RewardChest_T1, "RewardChest_T1" },                                                          // Small Abandoned Cache
		{ BuildingTypes.RewardChest_T2, "RewardChest_T2" },                                                          // Medium Abandoned Cache
		{ BuildingTypes.RewardChest_T3, "RewardChest_T3" },                                                          // Large Abandoned Cache
		{ BuildingTypes.Road_Sign, "Road Sign" },                                                                    // Road Sign
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher, "Ruined Advanced Rain Catcher" },                              // Advanced Rain Collector
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher_no_Reward_, "Ruined Advanced Rain Catcher (no reward)" },       // Advanced Rain Collector
		{ BuildingTypes.Ruined_Alchemist, "Ruined Alchemist" },                                                      // Alchemist's Hut
		{ BuildingTypes.Ruined_Alchemist_no_Reward_, "Ruined Alchemist (no reward)" },                               // Alchemist's Hut
		{ BuildingTypes.Ruined_Apothecary, "Ruined Apothecary" },                                                    // Apothecary
		{ BuildingTypes.Ruined_Apothecary_no_Reward_, "Ruined Apothecary (no reward)" },                             // Apothecary
		{ BuildingTypes.Ruined_Artisan, "Ruined Artisan" },                                                          // Artisan
		{ BuildingTypes.Ruined_Artisan_no_Reward_, "Ruined Artisan (no reward)" },                                   // Artisan
		{ BuildingTypes.Ruined_Bakery, "Ruined Bakery" },                                                            // Bakery
		{ BuildingTypes.Ruined_Bakery_no_Reward_, "Ruined Bakery (no reward)" },                                     // Bakery
		{ BuildingTypes.Ruined_Bath_House, "Ruined Bath House" },                                                    // Bath House
		{ BuildingTypes.Ruined_Bath_House_no_Reward_, "Ruined Bath House (no reward)" },                             // Bath House
		{ BuildingTypes.Ruined_Beanery, "Ruined Beanery" },                                                          // Beanery
		{ BuildingTypes.Ruined_Beanery_no_Reward_, "Ruined Beanery (no reward)" },                                   // Beanery
		{ BuildingTypes.Ruined_Beaver_House, "Ruined Beaver House" },                                                // Beaver House
		{ BuildingTypes.Ruined_Beaver_House_no_Reward_, "Ruined Beaver House (no reward)" },                         // Beaver House
		{ BuildingTypes.Ruined_Big_Shelter, "Ruined Big Shelter" },                                                  // Big Shelter
		{ BuildingTypes.Ruined_Big_Shelter_no_Reward_, "Ruined Big Shelter (no reward)" },                           // Big Shelter
		{ BuildingTypes.Ruined_Brewery, "Ruined Brewery" },                                                          // Brewery
		{ BuildingTypes.Ruined_Brewery_no_Reward_, "Ruined Brewery (no reward)" },                                   // Brewery
		{ BuildingTypes.Ruined_Brick_Oven, "Ruined Brick Oven" },                                                    // Brick Oven
		{ BuildingTypes.Ruined_Brick_Oven_no_Reward_, "Ruined Brick Oven (no reward)" },                             // Brick Oven
		{ BuildingTypes.Ruined_Brickyard, "Ruined Brickyard" },                                                      // Brickyard
		{ BuildingTypes.Ruined_Brickyard_no_Reward_, "Ruined Brickyard (no reward)" },                               // Brickyard
		{ BuildingTypes.Ruined_Butcher, "Ruined Butcher" },                                                          // Butcher
		{ BuildingTypes.Ruined_Butcher_no_Reward_, "Ruined Butcher (no reward)" },                                   // Butcher
		{ BuildingTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                      // Carpenter
		{ BuildingTypes.Ruined_Carpenter_no_Reward_, "Ruined Carpenter (no reward)" },                               // Carpenter
		{ BuildingTypes.Ruined_Cellar, "Ruined Cellar" },                                                            // Cellar
		{ BuildingTypes.Ruined_Cellar_no_Reward_, "Ruined Cellar (no reward)" },                                     // Cellar
		{ BuildingTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                      // Clan Hall
		{ BuildingTypes.Ruined_Clan_Hall_no_Reward_, "Ruined Clan Hall (no reward)" },                               // Clan Hall
		{ BuildingTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                        // Clay Pit
		{ BuildingTypes.Ruined_Clay_Pit_no_Reward_, "Ruined Clay Pit (no reward)" },                                 // Clay Pit
		{ BuildingTypes.Ruined_Cookhouse, "Ruined Cookhouse" },                                                      // Cookhouse
		{ BuildingTypes.Ruined_Cookhouse_no_Reward_, "Ruined Cookhouse (no reward)" },                               // Cookhouse
		{ BuildingTypes.Ruined_Cooperage, "Ruined Cooperage" },                                                      // Cooperage
		{ BuildingTypes.Ruined_Cooperage_no_Reward_, "Ruined Cooperage (no reward)" },                               // Cooperage
		{ BuildingTypes.Ruined_Crude_Workstation_no_Reward_, "Ruined Crude Workstation (no reward)" },               // Crude Workstation
		{ BuildingTypes.Ruined_Distillery, "Ruined Distillery" },                                                    // Distillery
		{ BuildingTypes.Ruined_Distillery_no_Reward_, "Ruined Distillery (no reward)" },                             // Distillery
		{ BuildingTypes.Ruined_Druid, "Ruined Druid" },                                                              // Druid's Hut
		{ BuildingTypes.Ruined_Druid_no_Reward_, "Ruined Druid (no reward)" },                                       // Druid's Hut
		{ BuildingTypes.Ruined_Explorers_Lodge, "Ruined Explorers Lodge" },                                          // Explorers' Lodge
		{ BuildingTypes.Ruined_Explorers_Lodge_no_Reward_, "Ruined Explorers Lodge (no reward)" },                   // Explorers' Lodge
		{ BuildingTypes.Ruined_Farm, "Ruined Farm" },                                                                // Homestead
		{ BuildingTypes.Ruined_Farm_no_Reward_, "Ruined Farm (no reward)" },                                         // Homestead
		{ BuildingTypes.Ruined_Field_Kitchen_no_Reward_, "Ruined Field Kitchen (no reward)" },                       // Field Kitchen
		{ BuildingTypes.Ruined_Finesmith, "Ruined Finesmith" },                                                      // Finesmith
		{ BuildingTypes.Ruined_Finesmith_no_Reward_, "Ruined Finesmith (no reward)" },                               // Finesmith
		{ BuildingTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                              // Foragers' Camp
		{ BuildingTypes.Ruined_Foragers_Camp_no_Reward_, "Ruined Foragers Camp (no reward)" },                       // Foragers' Camp
		{ BuildingTypes.Ruined_Foragers_Camp_Primitive_no_Reward_, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp
		{ BuildingTypes.Ruined_Forum, "Ruined Forum" },                                                              // Forum
		{ BuildingTypes.Ruined_Forum_no_Reward_, "Ruined Forum (no reward)" },                                       // Forum
		{ BuildingTypes.Ruined_Fox_House, "Ruined Fox House" },                                                      // Fox House
		{ BuildingTypes.Ruined_Fox_House_no_Reward_, "Ruined Fox House (no reward)" },                               // Fox House
		{ BuildingTypes.Ruined_Furnace, "Ruined Furnace" },                                                          // Furnace
		{ BuildingTypes.Ruined_Furnace_no_Reward_, "Ruined Furnace (no reward)" },                                   // Furnace
		{ BuildingTypes.Ruined_Granary, "Ruined Granary" },                                                          // Granary
		{ BuildingTypes.Ruined_Granary_no_Reward_, "Ruined Granary (no reward)" },                                   // Granary
		{ BuildingTypes.Ruined_Greenhouse, "Ruined Greenhouse" },                                                    // Greenhouse
		{ BuildingTypes.Ruined_Greenhouse_no_Reward_, "Ruined Greenhouse (no reward)" },                             // Greenhouse
		{ BuildingTypes.Ruined_Grill, "Ruined Grill" },                                                              // Grill
		{ BuildingTypes.Ruined_Grill_no_Reward_, "Ruined Grill (no reward)" },                                       // Grill
		{ BuildingTypes.Ruined_Grove, "Ruined Grove" },                                                              // Forester's Hut
		{ BuildingTypes.Ruined_Grove_no_Reward_, "Ruined Grove (no reward)" },                                       // Forester's Hut
		{ BuildingTypes.Ruined_Guild_House, "Ruined Guild House" },                                                  // Guild House
		{ BuildingTypes.Ruined_Guild_House_no_Reward_, "Ruined Guild House (no reward)" },                           // Guild House
		{ BuildingTypes.Ruined_Harpy_House, "Ruined Harpy House" },                                                  // Harpy House
		{ BuildingTypes.Ruined_Harpy_House_no_Reward_, "Ruined Harpy House (no reward)" },                           // Harpy House
		{ BuildingTypes.Ruined_Harvester_Camp, "Ruined Harvester Camp" },                                            // Harvesters' Camp
		{ BuildingTypes.Ruined_Harvester_Camp_no_Reward_, "Ruined Harvester Camp (no reward)" },                     // Harvesters' Camp
		{ BuildingTypes.Ruined_Hearth, "Ruined Hearth" },                                                            // Ancient Hearth
		{ BuildingTypes.Ruined_Hearth_no_Reward_, "Ruined Hearth (no reward)" },                                     // Ancient Hearth
		{ BuildingTypes.Ruined_Herb_Garden, "Ruined Herb Garden" },                                                  // Herb Garden
		{ BuildingTypes.Ruined_Herb_Garden_no_Reward_, "Ruined Herb Garden (no reward)" },                           // Herb Garden
		{ BuildingTypes.Ruined_Herbalist_Camp, "Ruined Herbalist Camp" },                                            // Herbalists' Camp
		{ BuildingTypes.Ruined_Herbalist_Camp_no_Reward_, "Ruined Herbalist Camp (no reward)" },                     // Herbalists' Camp
		{ BuildingTypes.Ruined_Herbalist_Camp_Primitive_no_Reward_, "Ruined Herbalist Camp primitive (no reward)" }, // Herbalists' Camp
		{ BuildingTypes.Ruined_Human_House, "Ruined Human House" },                                                  // Human House
		{ BuildingTypes.Ruined_Human_House_no_Reward_, "Ruined Human House (no reward)" },                           // Human House
		{ BuildingTypes.Ruined_Kiln, "Ruined Kiln" },                                                                // Kiln
		{ BuildingTypes.Ruined_Kiln_no_Reward_, "Ruined Kiln (no reward)" },                                         // Kiln
		{ BuildingTypes.Ruined_Leatherworks, "Ruined Leatherworks" },                                                // Leatherworker
		{ BuildingTypes.Ruined_Leatherworks_no_Reward_, "Ruined Leatherworks (no reward)" },                         // Leatherworker
		{ BuildingTypes.Ruined_Lizard_House, "Ruined Lizard House" },                                                // Lizard House
		{ BuildingTypes.Ruined_Lizard_House_no_Reward_, "Ruined Lizard House (no reward)" },                         // Lizard House
		{ BuildingTypes.Ruined_Lumbermill, "Ruined Lumbermill" },                                                    // Lumber Mill
		{ BuildingTypes.Ruined_Lumbermill_no_Reward_, "Ruined Lumbermill (no reward)" },                             // Lumber Mill
		{ BuildingTypes.Ruined_Makeshift_Post_no_Reward_, "Ruined Makeshift Post (no reward)" },                     // Makeshift Post
		{ BuildingTypes.Ruined_Manufatory, "Ruined Manufatory" },                                                    // Manufactory
		{ BuildingTypes.Ruined_Manufatory_no_Reward_, "Ruined Manufatory (no reward)" },                             // Manufactory
		{ BuildingTypes.Ruined_Market, "Ruined Market" },                                                            // Market
		{ BuildingTypes.Ruined_Market_no_Reward_, "Ruined Market (no reward)" },                                     // Market
		{ BuildingTypes.Ruined_Mine_no_Reward_, "Ruined Mine (no reward)" },                                         // Mine
		{ BuildingTypes.Ruined_Monastery, "Ruined Monastery" },                                                      // Monastery
		{ BuildingTypes.Ruined_Monastery_no_Reward_, "Ruined Monastery (no reward)" },                               // Monastery
		{ BuildingTypes.Ruined_Plantation, "Ruined Plantation" },                                                    // Plantation
		{ BuildingTypes.Ruined_Plantation_no_Reward_, "Ruined Plantation (no reward)" },                             // Plantation
		{ BuildingTypes.Ruined_Press, "Ruined Press" },                                                              // Press
		{ BuildingTypes.Ruined_Press_no_Reward_, "Ruined Press (no reward)" },                                       // Press
		{ BuildingTypes.Ruined_Provisioner, "Ruined Provisioner" },                                                  // Provisioner
		{ BuildingTypes.Ruined_Provisioner_no_Reward_, "Ruined Provisioner (no reward)" },                           // Provisioner
		{ BuildingTypes.Ruined_Rain_Catcher_no_Reward_, "Ruined Rain Catcher (no reward)" },                         // Rain Collector
		{ BuildingTypes.Ruined_Rainmill, "Ruined Rainmill" },                                                        // Rain Mill
		{ BuildingTypes.Ruined_Rainmill_no_Reward_, "Ruined Rainmill (no reward)" },                                 // Rain Mill
		{ BuildingTypes.Ruined_Ranch, "Ruined Ranch" },                                                              // Ranch
		{ BuildingTypes.Ruined_Ranch_no_Reward_, "Ruined Ranch (no reward)" },                                       // Ranch
		{ BuildingTypes.Ruined_Scribe, "Ruined Scribe" },                                                            // Scribe
		{ BuildingTypes.Ruined_Scribe_no_Reward_, "Ruined Scribe (no reward)" },                                     // Scribe
		{ BuildingTypes.Ruined_Sewer, "Ruined Sewer" },                                                              // Clothier
		{ BuildingTypes.Ruined_Sewer_no_Reward_, "Ruined Sewer (no reward)" },                                       // Clothier
		{ BuildingTypes.Ruined_Shelter, "Ruined Shelter" },                                                          // Shelter
		{ BuildingTypes.Ruined_Shelter_no_Reward_, "Ruined Shelter (no reward)" },                                   // Shelter
		{ BuildingTypes.Ruined_SmallFarm, "Ruined SmallFarm" },                                                      // Small Farm
		{ BuildingTypes.Ruined_SmallFarm_no_Reward_, "Ruined SmallFarm (no reward)" },                               // Small Farm
		{ BuildingTypes.Ruined_Smelter, "Ruined Smelter" },                                                          // Smelter
		{ BuildingTypes.Ruined_Smelter_no_Reward_, "Ruined Smelter (no reward)" },                                   // Smelter
		{ BuildingTypes.Ruined_Smithy, "Ruined Smithy" },                                                            // Smithy
		{ BuildingTypes.Ruined_Smithy_no_Reward_, "Ruined Smithy (no reward)" },                                     // Smithy
		{ BuildingTypes.Ruined_Smokehouse, "Ruined Smokehouse" },                                                    // Smokehouse
		{ BuildingTypes.Ruined_Smokehouse_no_Reward_, "Ruined Smokehouse (no reward)" },                             // Smokehouse
		{ BuildingTypes.Ruined_Stamping_Mill, "Ruined Stamping Mill" },                                              // Stamping Mill
		{ BuildingTypes.Ruined_Stamping_Mill_no_Reward_, "Ruined Stamping Mill (no reward)" },                       // Stamping Mill
		{ BuildingTypes.Ruined_Stonecutter_Camp, "Ruined Stonecutter Camp" },                                        // Stonecutters' Camp
		{ BuildingTypes.Ruined_Stonecutter_Camp_no_Reward_, "Ruined Stonecutter Camp (no reward)" },                 // Stonecutters' Camp
		{ BuildingTypes.Ruined_Storage, "Ruined Storage" },                                                          // Small Warehouse
		{ BuildingTypes.Ruined_Storage_no_Reward_, "Ruined Storage (no reward)" },                                   // Small Warehouse
		{ BuildingTypes.Ruined_Supplier, "Ruined Supplier" },                                                        // Supplier
		{ BuildingTypes.Ruined_Supplier_no_Reward_, "Ruined Supplier (no reward)" },                                 // Supplier
		{ BuildingTypes.Ruined_Tavern, "Ruined Tavern" },                                                            // Tavern
		{ BuildingTypes.Ruined_Tavern_no_Reward_, "Ruined Tavern (no reward)" },                                     // Tavern
		{ BuildingTypes.Ruined_Tea_Doctor, "Ruined Tea Doctor" },                                                    // Tea Doctor
		{ BuildingTypes.Ruined_Tea_Doctor_no_Reward_, "Ruined Tea Doctor (no reward)" },                             // Tea Doctor
		{ BuildingTypes.Ruined_Tea_House, "Ruined Tea House" },                                                      // Teahouse
		{ BuildingTypes.Ruined_Tea_House_no_Reward_, "Ruined Tea House (no reward)" },                               // Teahouse
		{ BuildingTypes.Ruined_Temple, "Ruined Temple" },                                                            // Temple
		{ BuildingTypes.Ruined_Temple_no_Reward_, "Ruined Temple (no reward)" },                                     // Temple
		{ BuildingTypes.Ruined_Tinctury, "Ruined Tinctury" },                                                        // Tinctury
		{ BuildingTypes.Ruined_Tinctury_no_Reward_, "Ruined Tinctury (no reward)" },                                 // Tinctury
		{ BuildingTypes.Ruined_Tinkerer, "Ruined Tinkerer" },                                                        // Tinkerer
		{ BuildingTypes.Ruined_Tinkerer_no_Reward_, "Ruined Tinkerer (no reward)" },                                 // Tinkerer
		{ BuildingTypes.Ruined_Toolshop, "Ruined Toolshop" },                                                        // Toolshop
		{ BuildingTypes.Ruined_Toolshop_no_Reward_, "Ruined Toolshop (no reward)" },                                 // Toolshop
		{ BuildingTypes.Ruined_Trading_Post_no_Reward_, "Ruined Trading Post (no reward)" },                         // Trading Post
		{ BuildingTypes.Ruined_Trappers_Camp, "Ruined Trappers Camp" },                                              // Trappers' Camp
		{ BuildingTypes.Ruined_Trappers_Camp_no_Reward_, "Ruined Trappers Camp (no reward)" },                       // Trappers' Camp
		{ BuildingTypes.Ruined_Trappers_Camp_Primitive_no_Reward_, "Ruined Trappers Camp Primitive (no reward)" },   // Trappers' Camp
		{ BuildingTypes.Ruined_Weaver, "Ruined Weaver" },                                                            // Weaver
		{ BuildingTypes.Ruined_Weaver_no_Reward_, "Ruined Weaver (no reward)" },                                     // Weaver
		{ BuildingTypes.Ruined_Woodcutters_Camp, "Ruined Woodcutters Camp" },                                        // Woodcutters' Camp
		{ BuildingTypes.Ruined_Woodcutters_Camp_no_Reward_, "Ruined Woodcutters Camp (no reward)" },                 // Woodcutters' Camp
		{ BuildingTypes.Ruined_Workshop, "Ruined Workshop" },                                                        // Workshop
		{ BuildingTypes.Ruined_Workshop_no_Reward_, "Ruined Workshop (no reward)" },                                 // Workshop
		{ BuildingTypes.Sacrifice_Totem, "Sacrifice Totem" },                                                        // Totem of Denial
		{ BuildingTypes.Sacrifice_Totem_Positive, "Sacrifice Totem Positive" },                                      // Converted Totem of Denial
		{ BuildingTypes.Scarlet_Decor, "Scarlet Decor" },                                                            // Thorny Reed
		{ BuildingTypes.Scorpion_1, "Scorpion 1" },                                                                  // Archaeological Discovery
		{ BuildingTypes.Scorpion_2, "Scorpion 2" },                                                                  // Archaeological Excavation
		{ BuildingTypes.Scorpion_3, "Scorpion 3" },                                                                  // Archaeological Reconstruction
		{ BuildingTypes.Scribe, "Scribe" },                                                                          // Scribe
		{ BuildingTypes.Seal, "Seal" },                                                                              // Ancient Seal
		{ BuildingTypes.Seal_Guidepost, "Seal Guidepost" },                                                          // Guidance Stone
		{ BuildingTypes.Seal_Low_Diff, "Seal Low Diff" },                                                            // Ancient Seal
		{ BuildingTypes.Sealed_Biome_Shrine, "Sealed Biome Shrine" },                                                // Beacon Tower
		{ BuildingTypes.SealedTomb_T1, "SealedTomb_T1" },                                                            // Open Vault
		{ BuildingTypes.Shelter, "Shelter" },                                                                        // Shelter
		{ BuildingTypes.Signboard, "Signboard" },                                                                    // Signboard
		{ BuildingTypes.Small_Hearth, "Small Hearth" },                                                              // Ancient Hearth
		{ BuildingTypes.SmallFarm, "SmallFarm" },                                                                    // Small Farm
		{ BuildingTypes.Smelter, "Smelter" },                                                                        // Smelter
		{ BuildingTypes.Smithy, "Smithy" },                                                                          // Smithy
		{ BuildingTypes.Smokehouse, "Smokehouse" },                                                                  // Smokehouse
		{ BuildingTypes.Snake_1, "Snake 1" },                                                                        // Archaeological Discovery
		{ BuildingTypes.Snake_2, "Snake 2" },                                                                        // Archaeological Excavation
		{ BuildingTypes.Snake_3, "Snake 3" },                                                                        // Archaeological Reconstruction
		{ BuildingTypes.Spider_1, "Spider 1" },                                                                      // Archaeological Discovery
		{ BuildingTypes.Spider_2, "Spider 2" },                                                                      // Archaeological Excavation
		{ BuildingTypes.Spider_3, "Spider 3" },                                                                      // Archaeological Reconstruction
		{ BuildingTypes.Stamping_Mill, "Stamping Mill" },                                                            // Stamping Mill
		{ BuildingTypes.Stonecutters_Camp, "Stonecutter's Camp" },                                                   // Stonecutters' Camp
		{ BuildingTypes.Storage_buildable_, "Storage (buildable)" },                                                 // Small Warehouse
		{ BuildingTypes.Stormbird_Positive, "Stormbird Positive" },                                                  // Tamed Stormbird
		{ BuildingTypes.Supplier, "Supplier" },                                                                      // Supplier
		{ BuildingTypes.Tavern, "Tavern" },                                                                          // Tavern
		{ BuildingTypes.Tea_Doctor, "Tea Doctor" },                                                                  // Tea Doctor
		{ BuildingTypes.Tea_House, "Tea House" },                                                                    // Teahouse
		{ BuildingTypes.Temple, "Temple" },                                                                          // Temple
		{ BuildingTypes.Temporary_Hearth_buildable_, "Temporary Hearth (buildable)" },                               // Small Hearth
		{ BuildingTypes.Temporary_Hearth_not_buildable_, "Temporary Hearth (not-buildable)" },                       // Small Hearth
		{ BuildingTypes.Termite_Burrow, "Termite Burrow" },                                                          // Stonetooth Termite Burrow
		{ BuildingTypes.Termite_Burrow_Positive, "Termite Burrow Positive" },                                        // Termite Nest
		{ BuildingTypes.TI_AncientShrine_T1, "TI AncientShrine_T1" },                                                // Ancient Shrine
		{ BuildingTypes.Tinctury, "Tinctury" },                                                                      // Tinctury
		{ BuildingTypes.Tinkerer, "Tinkerer" },                                                                      // Tinkerer
		{ BuildingTypes.Toolshop, "Toolshop" },                                                                      // Toolshop
		{ BuildingTypes.Tower, "Tower" },                                                                            // Wall Crossing
		{ BuildingTypes.Town_Board, "Town Board" },                                                                  // Town Board
		{ BuildingTypes.Traders_Cemetery, "Traders Cemetery" },                                                      // Hidden Trader Cemetery
		{ BuildingTypes.Trading_Post, "Trading Post" },                                                              // Trading Post
		{ BuildingTypes.Trappers_Camp, "Trapper's Camp" },                                                           // Trappers' Camp
		{ BuildingTypes.Umbrella, "Umbrella" },                                                                      // Umbrella
		{ BuildingTypes.Wall, "Wall" },                                                                              // Wall
		{ BuildingTypes.Wall_Corner, "Wall Corner" },                                                                // Wall Corner
		{ BuildingTypes.War_Beast_Cage, "War Beast Cage" },                                                          // Destroyed Cage of the Warbeast
		{ BuildingTypes.Water_Barrels, "Water Barrels" },                                                            // Water Barrels
		{ BuildingTypes.Water_Extractor, "Water Extractor" },                                                        // Geyser Pump
		{ BuildingTypes.Weaver, "Weaver" },                                                                          // Weaver
		{ BuildingTypes.Well, "Well" },                                                                              // Overgrown Well
		{ BuildingTypes.White_Stag, "White Stag" },                                                                  // Royal Treasure Stag
		{ BuildingTypes.White_Treasure_Stag, "White Treasure Stag" },                                                // Royal Treasure Stag
		{ BuildingTypes.Wildfire, "Wildfire" },                                                                      // Wildfire
		{ BuildingTypes.Woodcutters_Camp, "Woodcutters Camp" },                                                      // Woodcutters' Camp
		{ BuildingTypes.Workshop, "Workshop" },                                                                      // Workshop
	};
}
