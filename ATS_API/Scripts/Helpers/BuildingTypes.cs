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
	AdvancedRainCatcher,                   // Advanced Rain Collector
	Aestherics2x2_Garden,                  // Garden
	Aestherics2x2_GroundwaterExtractor,    // Makeshift Extractor
	AlchemistHut,                          // Alchemist's Hut
	Altar,                                 // Forsaken Altar
	AncientBurrialGrounds,                 // Ancient Burial Site
	AncientGate,                           // Dark Gate
	AncientGravestone,                     // Ancient Tombstone
	AncientShrine_T1,                      // Ancient Shrine
	AncientTemple,                         // Forgotten Temple of the Sun
	AngryGhost1,                           // Ghost of a Blight Fighter Captain
	AngryGhost10,                          // Ghost of a Suppressed Rebel
	AngryGhost14,                          // Ghost of a Resentful Human
	AngryGhost15,                          // Ghost of the Queen's Lickspittle
	AngryGhost16,                          // Ghost of a Lizard Leader
	AngryGhost17,                          // Ghost of a Tortured Harpy
	AngryGhost18,                          // Ghost of a Beaver Engineer
	AngryGhost19,                          // Ghost of a Poisoned Human
	AngryGhost2,                           // Ghost of a Mad Alchemist
	AngryGhost20,                          // Ghost of a Lizard Worker
	AngryGhost21,                          // Ghost of a Starved Harpy
	AngryGhost24,                          // Ghost of an Innkeeper
	AngryGhost31,                          // Ghost of a Lizard Elder
	AngryGhost32,                          // Ghost of a Lost Scout
	AngryGhost34,                          // Ghost of a Murdered Trader
	AngryGhost4,                           // Ghost of a Deranged Scout
	AngryGhost5,                           // Ghost of a Furious Villager
	AngryGhost6,                           // Ghost of a Scared Firekeeper
	AngryGhost9,                           // Ghost of a Loyal Servant
	AngryGhostChest_T1,                    // Ghost Chest
	Anvil,                                 // Anvil
	API_ExampleMod_BurgerJoint,            // Borgor King
	Apothecary,                            // Apothecary
	Arch,                                  // Ancient Arch
	ArchaeologyScorpionPositive,           // Smoldering Scorpion
	ArchaeologySnakePositive,              // Sea Serpent
	ArchaeologySpiderPositive,             // Sealed Spider
	ArcheologyOffice,                      // Archaeologist's Office
	Artisan,                               // Artisan
	Bakery,                                // Bakery
	Bank,                                  // Bench
	Barrels,                               // Barrels
	BathHouse,                             // Bath House
	Beanery,                               // Beanery
	BeaverBattleground_T1,                 // Fallen Beaver Traders
	BeaverHouse,                           // Beaver House
	BigShelter,                            // Big Shelter
	BlackStag,                             // Black Treasure Stag
	BlackTreasureStag,                     // Black Treasure Stag
	BlightPost,                            // Blight Post
	Blightrot,                             // Blood Flower
	Blightrot_Clone,                       // Blood Flower (Clone)
	BlightrotCauldron,                     // Blightrot Cauldron
	Bonfire,                               // Bonfire
	Brewery,                               // Brewery
	BrickOven,                             // Brick Oven
	Brickyard,                             // Brickyard
	Bush,                                  // Bush
	Butcher,                               // Butcher
	Cages,                                 // Cages
	CalmGhost11,                           // Ghost of a Defeated Viceroy
	CalmGhost12,                           // Ghost of a Druid
	CalmGhost13,                           // Ghost of a Royal Gardener
	CalmGhost22,                           // Ghost of a Hooded Knight
	CalmGhost23,                           // Ghost of a Fire Priest
	CalmGhost25,                           // Ghost of a Treasure Hunter
	CalmGhost26,                           // Ghost of a Royal Architect
	CalmGhost27,                           // Ghost of a Worried Carter
	CalmGhost28,                           // Ghost of a Storm Victim
	CalmGhost29,                           // Ghost of a Mourning Harpy
	CalmGhost3,                            // Ghost of a Terrified Woodcutter
	CalmGhost30,                           // Ghost of a Lizard General
	CalmGhost33,                           // Ghost of an Old Merchant
	CalmGhost35,                           // Ghost of a Fox Elder
	CalmGhost36,                           // Ghost of a Teadoctor
	CalmGhost7,                            // Ghost of a Troublemaker
	CalmGhost8,                            // Ghost of a Fallen Newcomer
	CalmGhostChest_T1,                     // Ghost Chest
	Camp_T1,                               // Small Encampment
	Camp_T2,                               // Large Encampment
	Caravan_T1,                            // Small Destroyed Caravan
	Caravan_T2,                            // Large Destroyed Caravan
	Carpenter,                             // Carpenter
	Cellar,                                // Cellar
	Chest,                                 // Chest
	ClanHall,                              // Clan Hall
	ClayPitWorkshop,                       // Clay Pit
	Clothier,                              // Clothier
	Comfort2x2_Park,                       // Park
	Cookhouse,                             // Cookhouse
	Cooperage,                             // Cooperage
	CoralDecor,                            // Coral Growth
	CornerFence,                           // Fence Corner
	CorruptedCaravan,                      // Corrupted Caravan
	Crates,                                // Crates
	CrudeWorkstation,                      // Crude Workstation
	DebugNode_ClayBig,                     // Clay Deposit (Large)
	DebugNode_ClaySmall,                   // Clay Deposit (Small)
	DebugNode_DewberryBushBig,             // Dewberry Bush (Large)
	DebugNode_DewberryBushSmall,           // Dewberry Bush (Small)
	DebugNode_FlaxBig,                     // Flax Field (Large)
	DebugNode_FlaxSmall,                   // Flax Field (Small)
	DebugNode_HerbsBig,                    // Herb Node (Large)
	DebugNode_HerbsSmall,                  // Herb Node (Small)
	DebugNode_LeechBroodmotherBig,         // Leech Broodmother (Large)
	DebugNode_LeechBroodmotherSmall,       // Leech Broodmother (Small)
	DebugNode_Marshlands_InfiniteGrain,    // Ancient Proto Wheat
	DebugNode_Marshlands_InfiniteMeat,     // Dead Leviathan
	DebugNode_Marshlands_InfiniteMushroom, // Giant Proto Fungus
	DebugNode_MarshlandsMushroomBig,       // Grasscap Mushrooms (Large)
	DebugNode_MarshlandsMushroomSmall,     // Grasscap Mushrooms (Small)
	DebugNode_MossBroccoliBig,             // Moss Broccoli Patch (Large)
	DebugNode_MossBroccoliSmall,           // Moss Broccoli Patch (Small)
	DebugNode_MushroomBig,                 // Grasscap Mushrooms (Large)
	DebugNode_MushroomSmall,               // Grasscap Mushrooms (Small)
	DebugNode_ReedBig,                     // Reed Field (Large)
	DebugNode_ReedSmall,                   // Reed Field (Small)
	DebugNode_RootsBig,                    // Root Deposit (Large)
	DebugNode_RootsSmall,                  // Root Deposit (Small)
	DebugNode_SeaMarrowBig,                // Sea Marrow Deposit (Large)
	DebugNode_SeaMarrowSmall,              // Sea Marrow Deposit (Small)
	DebugNode_SnailBroodmotherBig,         // Slickshell Broodmother (Large)
	DebugNode_SnailBroodmotherSmall,       // Slickshell Broodmother (Small)
	DebugNode_SnakeNestBig,                // Snake Nest (Large)
	DebugNode_SnakeNestSmall,              // Snake Nest (Small)
	DebugNode_StoneBig,                    // Stone Deposit (Large)
	DebugNode_StoneSmall,                  // Stone Deposit (Small)
	DebugNode_StormbirdNestBig,            // Drizzlewing Nest (Large)
	DebugNode_StormbirdNestSmall,          // Drizzlewing Nest (Small)
	DebugNode_SwampWheatBig,               // Swamp Wheat Field (Large)
	DebugNode_SwampWheatSmall,             // Swamp Wheat Field (Small)
	DebugNode_WormtongueNestBig,           // Wormtongue Nest (Large)
	DebugNode_WormtongueNestSmall,         // Wormtongue Nest (Small)
	DecayAltar,                            // Altar of Decay
	DecayAltarPositive,                    // Converted Altar of Decay
	Distillery,                            // Distillery
	Druid,                                 // Druid's Hut
	EscapedConvicts,                       // Escaped Convicts
	ExplorersLodge,                        // Explorers' Lodge
	Farmfield,                             // Farm Field
	Fence,                                 // Fence
	FieldKitchen,                          // Field Kitchen
	Finesmith,                             // Finesmith
	FireShrine,                            // Fire Shrine
	FishmenCave,                           // Fishmen Cave
	FishmenLighthouse,                     // Fishmen Lighthouse
	FishmenLighthousePositive,             // Converted Fishmen Lighthouse
	FishmenOutpost,                        // Fishmen Outpost
	FishmenSoothsayer,                     // Fishman Soothsayer
	FishmenTotem,                          // Fishmen Totem
	FlawlessBrewery,                       // Flawless Brewery
	FlawlessCellar,                        // Flawless Cellar
	FlawlessCooperage,                     // Flawless Cooperage
	FlawlessDruid,                         // Flawless Druid's Hut
	FlawlessLeatherworks,                  // Flawless Leatherworker
	FlawlessRainMill,                      // Flawless Rain Mill
	FlawlessSmelter,                       // Flawless Smelter
	FlowerBed,                             // Flower Bed
	ForagersCamp,                          // Foragers' Camp
	ForsakenCrypt,                         // Forsaken Crypt
	Forum,                                 // Forum
	Fountain,                              // Marble Fountain
	FoxBattleground_T1,                    // Fallen Fox Scouts
	FoxFence,                              // Overgrown Fence
	FoxFenceCorner,                        // Overgrown Fence Corner
	FoxHouse,                              // Fox House
	FumingMachinery,                       // Fuming Machinery
	Furnace,                               // Furnace
	Gate,                                  // Gate
	GiantStormbird,                        // Giant Stormbird's Nest
	GladeTrader_TheHermit,                 // Wandering Merchant - Hermit
	GladeTrader_TheSeer,                   // Wandering Merchant - Seer
	GladeTrader_TheShaman,                 // Wandering Merchant - Shaman
	GoldenLeaf,                            // Golden Leaf Plant
	GoldStag,                              // Golden Treasure Stag
	GoldTreasureStag,                      // Golden Treasure Stag
	Granary,                               // Granary
	GreenhouseWorkshop,                    // Greenhouse
	Grill,                                 // Grill
	Grove,                                 // Forester's Hut
	GuildHouse,                            // Guild House
	HallowedHerbGarden,                    // Hallowed Herb Garden
	HallowedSmallFarm,                     // Hallowed Small Farm
	HarmonySpiritAltar,                    // Harmony Spirit Altar
	HarmonySpiritAltarPositive,            // Converted Harmony Spirit Altar
	HarpyBattleground_T1,                  // Fallen Harpy Scientists
	HarpyHouse,                            // Harpy House
	HarvesterCamp,                         // Harvesters' Camp
	HauntedRuinedBeaverHouse,              // Haunted Beaver House
	HauntedRuinedBrewery,                  // Haunted Brewery
	HauntedRuinedCellar,                   // Haunted Cellar
	HauntedRuinedCooperage,                // Haunted Cooperage
	HauntedRuinedDruid,                    // Haunted Druid's Hut
	HauntedRuinedFoxHouse,                 // Haunted Fox House
	HauntedRuinedHarpyHouse,               // Haunted Harpy House
	HauntedRuinedHerbGarden,               // Haunted Herb Garden
	HauntedRuinedHumanHouse,               // Haunted Human House
	HauntedRuinedLeatherworks,             // Haunted Leatherworker
	HauntedRuinedLizardHouse,              // Haunted Lizard House
	HauntedRuinedMarket,                   // Haunted Market
	HauntedRuinedRainmill,                 // Haunted Rain Mill
	HauntedRuinedSmallFarm,                // Haunted Small Farm
	HauntedRuinedSmelter,                  // Haunted Smelter
	HauntedRuinedTemple,                   // Haunted Temple
	HerbalistsCamp,                        // Herbalists' Camp
	HerbGarden,                            // Herb Garden
	HolyMarket,                            // Holy Market
	HolyTemple,                            // Holy Temple
	Homestead,                             // Homestead
	HumanBattleground_T1,                  // Fallen Human Explorers
	HumanHouse,                            // Human House
	Hydrant,                               // Hydrant
	InfectedMole,                          // Infected Drainage Mole
	InfectedTree,                          // Withered Tree
	Kelpie,                                // River Kelpie
	Kiln,                                  // Kiln
	Lamp,                                  // Lamp
	LeakingCauldron,                       // Leaking Cauldron
	Leatherworks,                          // Leatherworker
	LightningCatcher,                      // Lightning Catcher
	LizardBattleground_T1,                 // Fallen Lizard Hunters
	LizardHouse,                           // Lizard House
	LizardPost,                            // Lizard Post
	LoreTablet1,                           // Inscribed Monolith
	LoreTablet2,                           // Inscribed Monolith
	LoreTablet3,                           // Inscribed Monolith
	LoreTablet4,                           // Inscribed Monolith
	LoreTablet5,                           // Inscribed Monolith
	LoreTablet6,                           // Inscribed Monolith
	LoreTablet7,                           // Inscribed Monolith
	Lumbermill,                            // Lumber Mill
	MainStoragenot_buildable_,             // Main Warehouse
	MakeshiftPost,                         // Makeshift Post
	Manufactory,                           // Manufactory
	Market,                                // Market
	MerchantShipWreck,                     // Merchant Shipwreck
	Mine,                                  // Mine
	Mistworm_T1,                           // Hungry Mistworm
	Mole,                                  // Drainage Mole
	Monastery,                             // Monastery
	Monolith,                              // Obelisk
	MonolithPositive,                      // Obelisk
	MushroomDecor,                         // Decorative Fungus
	Nightfern,                             // Nightfern
	NoxiousMachinery,                      // Noxious Machinery
	Path,                                  // Path
	PavedRoad,                             // Paved Road
	PetrifiedTree_T1,                      // Petrified Tree
	Pipe,                                  // Pipe
	PipeCross,                             // Pipe Cross
	PipeElbow,                             // Pipe Elbow
	PipeEnd,                               // Pipe Ending
	PipeTCross,                            // Pipe T-Connector
	PipeValve,                             // Valve
	Plantation,                            // Plantation
	Press,                                 // Press
	PrimitiveForagersCamp,                 // Small Foragers' Camp
	PrimitiveHerbalistsCamp,               // Small Herbalists' Camp
	PrimitiveTrappersCamp,                 // Small Trappers' Camp
	Provisioner,                           // Provisioner
	PurgedBeaverHouse,                     // Purified Beaver House
	PurgedFoxHouse,                        // Purified Fox House
	PurgedHarpyHouse,                      // Purified Harpy House
	PurgedHumanHouse,                      // Purified Human House
	PurgedLizardHouse,                     // Purified Lizard House
	RainCatcher,                           // Rain Collector
	RainMill,                              // Rain Mill
	RainpunkBarrels,                       // Rainpunk Barrels
	RainpunkDrill_Coal,                    // Rainpunk Drill
	RainpunkDrill_Copper,                  // Rainpunk Drill
	RainpunkFactory,                       // Destroyed Rainpunk Foundry
	RainpunkFoundry,                       // Rainpunk Foundry
	RainTotem,                             // Rain Spirit Totem
	RainTotemPositive,                     // Converted Rain Totem
	Ranch,                                 // Ranch
	ReinforcedRoad,                        // Reinforced Road
	RewardChest_T1,                        // Small Abandoned Cache
	RewardChest_T2,                        // Medium Abandoned Cache
	RewardChest_T3,                        // Large Abandoned Cache
	RoadSign,                              // Road Sign
	RuinedAdvancedRainCatcher,             // Advanced Rain Collector
	RuinedAdvancedRainCatchernoReward_,    // Advanced Rain Collector
	RuinedAlchemist,                       // Alchemist's Hut
	RuinedAlchemistnoReward_,              // Alchemist's Hut
	RuinedApothecary,                      // Apothecary
	RuinedApothecarynoReward_,             // Apothecary
	RuinedArtisan,                         // Artisan
	RuinedArtisannoReward_,                // Artisan
	RuinedBakery,                          // Bakery
	RuinedBakerynoReward_,                 // Bakery
	RuinedBathHouse,                       // Bath House
	RuinedBathHousenoReward_,              // Bath House
	RuinedBeanery,                         // Beanery
	RuinedBeanerynoReward_,                // Beanery
	RuinedBeaverHouse,                     // Beaver House
	RuinedBeaverHousenoReward_,            // Beaver House
	RuinedBigShelter,                      // Big Shelter
	RuinedBigShelternoReward_,             // Big Shelter
	RuinedBrewery,                         // Brewery
	RuinedBrewerynoReward_,                // Brewery
	RuinedBrickOven,                       // Brick Oven
	RuinedBrickOvennoReward_,              // Brick Oven
	RuinedBrickyard,                       // Brickyard
	RuinedBrickyardnoReward_,              // Brickyard
	RuinedButcher,                         // Butcher
	RuinedButchernoReward_,                // Butcher
	RuinedCarpenter,                       // Carpenter
	RuinedCarpenternoReward_,              // Carpenter
	RuinedCellar,                          // Cellar
	RuinedCellarnoReward_,                 // Cellar
	RuinedClanHall,                        // Clan Hall
	RuinedClanHallnoReward_,               // Clan Hall
	RuinedClayPit,                         // Clay Pit
	RuinedClayPitnoReward_,                // Clay Pit
	RuinedCookhouse,                       // Cookhouse
	RuinedCookhousenoReward_,              // Cookhouse
	RuinedCooperage,                       // Cooperage
	RuinedCooperagenoReward_,              // Cooperage
	RuinedCrudeWorkstationnoReward_,       // Crude Workstation
	RuinedDistillery,                      // Distillery
	RuinedDistillerynoReward_,             // Distillery
	RuinedDruid,                           // Druid's Hut
	RuinedDruidnoReward_,                  // Druid's Hut
	RuinedExplorersLodge,                  // Explorers' Lodge
	RuinedExplorersLodgenoReward_,         // Explorers' Lodge
	RuinedFarm,                            // Homestead
	RuinedFarmnoReward_,                   // Homestead
	RuinedFieldKitchennoReward_,           // Field Kitchen
	RuinedFinesmith,                       // Finesmith
	RuinedFinesmithnoReward_,              // Finesmith
	RuinedForagersCamp,                    // Foragers' Camp
	RuinedForagersCampnoReward_,           // Foragers' Camp
	RuinedForagersCampPrimitivenoReward_,  // Foragers' Camp
	RuinedForum,                           // Forum
	RuinedForumnoReward_,                  // Forum
	RuinedFoxHouse,                        // Fox House
	RuinedFoxHousenoReward_,               // Fox House
	RuinedFurnace,                         // Furnace
	RuinedFurnacenoReward_,                // Furnace
	RuinedGranary,                         // Granary
	RuinedGranarynoReward_,                // Granary
	RuinedGreenhouse,                      // Greenhouse
	RuinedGreenhousenoReward_,             // Greenhouse
	RuinedGrill,                           // Grill
	RuinedGrillnoReward_,                  // Grill
	RuinedGrove,                           // Forester's Hut
	RuinedGrovenoReward_,                  // Forester's Hut
	RuinedGuildHouse,                      // Guild House
	RuinedGuildHousenoReward_,             // Guild House
	RuinedHarpyHouse,                      // Harpy House
	RuinedHarpyHousenoReward_,             // Harpy House
	RuinedHarvesterCamp,                   // Harvesters' Camp
	RuinedHarvesterCampnoReward_,          // Harvesters' Camp
	RuinedHearth,                          // Ancient Hearth
	RuinedHearthnoReward_,                 // Ancient Hearth
	RuinedHerbalistCamp,                   // Herbalists' Camp
	RuinedHerbalistCampnoReward_,          // Herbalists' Camp
	RuinedHerbalistCampPrimitivenoReward_, // Herbalists' Camp
	RuinedHerbGarden,                      // Herb Garden
	RuinedHerbGardennoReward_,             // Herb Garden
	RuinedHumanHouse,                      // Human House
	RuinedHumanHousenoReward_,             // Human House
	RuinedKiln,                            // Kiln
	RuinedKilnnoReward_,                   // Kiln
	RuinedLeatherworks,                    // Leatherworker
	RuinedLeatherworksnoReward_,           // Leatherworker
	RuinedLizardHouse,                     // Lizard House
	RuinedLizardHousenoReward_,            // Lizard House
	RuinedLumbermill,                      // Lumber Mill
	RuinedLumbermillnoReward_,             // Lumber Mill
	RuinedMakeshiftPostnoReward_,          // Makeshift Post
	RuinedManufatory,                      // Manufactory
	RuinedManufatorynoReward_,             // Manufactory
	RuinedMarket,                          // Market
	RuinedMarketnoReward_,                 // Market
	RuinedMinenoReward_,                   // Mine
	RuinedMonastery,                       // Monastery
	RuinedMonasterynoReward_,              // Monastery
	RuinedPlantation,                      // Plantation
	RuinedPlantationnoReward_,             // Plantation
	RuinedPress,                           // Press
	RuinedPressnoReward_,                  // Press
	RuinedProvisioner,                     // Provisioner
	RuinedProvisionernoReward_,            // Provisioner
	RuinedRainCatchernoReward_,            // Rain Collector
	RuinedRainmill,                        // Rain Mill
	RuinedRainmillnoReward_,               // Rain Mill
	RuinedRanch,                           // Ranch
	RuinedRanchnoReward_,                  // Ranch
	RuinedScribe,                          // Scribe
	RuinedScribenoReward_,                 // Scribe
	RuinedSewer,                           // Clothier
	RuinedSewernoReward_,                  // Clothier
	RuinedShelter,                         // Shelter
	RuinedShelternoReward_,                // Shelter
	RuinedSmallFarm,                       // Small Farm
	RuinedSmallFarmnoReward_,              // Small Farm
	RuinedSmelter,                         // Smelter
	RuinedSmelternoReward_,                // Smelter
	RuinedSmithy,                          // Smithy
	RuinedSmithynoReward_,                 // Smithy
	RuinedSmokehouse,                      // Smokehouse
	RuinedSmokehousenoReward_,             // Smokehouse
	RuinedStampingMill,                    // Stamping Mill
	RuinedStampingMillnoReward_,           // Stamping Mill
	RuinedStonecutterCamp,                 // Stonecutters' Camp
	RuinedStonecutterCampnoReward_,        // Stonecutters' Camp
	RuinedStorage,                         // Small Warehouse
	RuinedStoragenoReward_,                // Small Warehouse
	RuinedSupplier,                        // Supplier
	RuinedSuppliernoReward_,               // Supplier
	RuinedTavern,                          // Tavern
	RuinedTavernnoReward_,                 // Tavern
	RuinedTeaDoctor,                       // Tea Doctor
	RuinedTeaDoctornoReward_,              // Tea Doctor
	RuinedTeaHouse,                        // Teahouse
	RuinedTeaHousenoReward_,               // Teahouse
	RuinedTemple,                          // Temple
	RuinedTemplenoReward_,                 // Temple
	RuinedTinctury,                        // Tinctury
	RuinedTincturynoReward_,               // Tinctury
	RuinedTinkerer,                        // Tinkerer
	RuinedTinkerernoReward_,               // Tinkerer
	RuinedToolshop,                        // Toolshop
	RuinedToolshopnoReward_,               // Toolshop
	RuinedTradingPostnoReward_,            // Trading Post
	RuinedTrappersCamp,                    // Trappers' Camp
	RuinedTrappersCampnoReward_,           // Trappers' Camp
	RuinedTrappersCampPrimitivenoReward_,  // Trappers' Camp
	RuinedWeaver,                          // Weaver
	RuinedWeavernoReward_,                 // Weaver
	RuinedWoodcuttersCamp,                 // Woodcutters' Camp
	RuinedWoodcuttersCampnoReward_,        // Woodcutters' Camp
	RuinedWorkshop,                        // Workshop
	RuinedWorkshopnoReward_,               // Workshop
	SacrificeTotem,                        // Totem of Denial
	SacrificeTotemPositive,                // Converted Totem of Denial
	ScarletDecor,                          // Thorny Reed
	Scorpion1,                             // Archaeological Discovery
	Scorpion2,                             // Archaeological Excavation
	Scorpion3,                             // Archaeological Reconstruction
	Scribe,                                // Scribe
	Seal,                                  // Ancient Seal
	SealedBiomeShrine,                     // Beacon Tower
	SealedTomb_T1,                         // Open Vault
	SealGuidepost,                         // Guidance Stone
	SealLowDiff,                           // Ancient Seal
	Shelter,                               // Shelter
	Signboard,                             // Signboard
	SmallFarm,                             // Small Farm
	SmallHearth,                           // Ancient Hearth
	Smelter,                               // Smelter
	Smithy,                                // Smithy
	Smokehouse,                            // Smokehouse
	Snake1,                                // Archaeological Discovery
	Snake2,                                // Archaeological Excavation
	Snake3,                                // Archaeological Reconstruction
	Spider1,                               // Archaeological Discovery
	Spider2,                               // Archaeological Excavation
	Spider3,                               // Archaeological Reconstruction
	StampingMill,                          // Stamping Mill
	StonecuttersCamp,                      // Stonecutters' Camp
	Storagebuildable_,                     // Small Warehouse
	StormbirdPositive,                     // Tamed Stormbird
	Supplier,                              // Supplier
	Tavern,                                // Tavern
	TeaDoctor,                             // Tea Doctor
	TeaHouse,                              // Teahouse
	Temple,                                // Temple
	TemporaryHearthbuildable_,             // Small Hearth
	TemporaryHearthnot_buildable_,         // Small Hearth
	TermiteBurrow,                         // Stonetooth Termite Burrow
	TermiteBurrowPositive,                 // Termite Nest
	TIAncientShrine_T1,                    // Ancient Shrine
	Tinctury,                              // Tinctury
	Tinkerer,                              // Tinkerer
	Toolshop,                              // Toolshop
	Tower,                                 // Wall Crossing
	TownBoard,                             // Town Board
	TradersCemetery,                       // Hidden Trader Cemetery
	TradingPost,                           // Trading Post
	TrappersCamp,                          // Trappers' Camp
	Umbrella,                              // Umbrella
	Wall,                                  // Wall
	WallCorner,                            // Wall Corner
	WarBeastCage,                          // Destroyed Cage of the Warbeast
	WaterBarrels,                          // Water Barrels
	WaterExtractor,                        // Geyser Pump
	Weaver,                                // Weaver
	Well,                                  // Overgrown Well
	WhiteStag,                             // Royal Treasure Stag
	WhiteTreasureStag,                     // Royal Treasure Stag
	Wildfire,                              // Wildfire
	WoodcuttersCamp,                       // Woodcutters' Camp
	Workshop,                              // Workshop

    MAX
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
		return TypeToInternalName[BuildingTypes.AdvancedRainCatcher];
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
		{ BuildingTypes.AdvancedRainCatcher, "Advanced Rain Catcher" },                                         // Advanced Rain Collector
		{ BuildingTypes.Aestherics2x2_Garden, "Aestherics 2x2 - Garden" },                                      // Garden
		{ BuildingTypes.Aestherics2x2_GroundwaterExtractor, "Aestherics 2x2 - Groundwater Extractor" },         // Makeshift Extractor
		{ BuildingTypes.AlchemistHut, "Alchemist Hut" },                                                        // Alchemist's Hut
		{ BuildingTypes.Altar, "Altar" },                                                                       // Forsaken Altar
		{ BuildingTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                       // Ancient Burial Site
		{ BuildingTypes.AncientGate, "AncientGate" },                                                           // Dark Gate
		{ BuildingTypes.AncientGravestone, "Ancient Gravestone" },                                              // Ancient Tombstone
		{ BuildingTypes.AncientShrine_T1, "AncientShrine_T1" },                                                 // Ancient Shrine
		{ BuildingTypes.AncientTemple, "AncientTemple" },                                                       // Forgotten Temple of the Sun
		{ BuildingTypes.AngryGhost1, "Angry Ghost 1" },                                                         // Ghost of a Blight Fighter Captain
		{ BuildingTypes.AngryGhost10, "Angry Ghost 10" },                                                       // Ghost of a Suppressed Rebel
		{ BuildingTypes.AngryGhost14, "Angry Ghost 14" },                                                       // Ghost of a Resentful Human
		{ BuildingTypes.AngryGhost15, "Angry Ghost 15" },                                                       // Ghost of the Queen's Lickspittle
		{ BuildingTypes.AngryGhost16, "Angry Ghost 16" },                                                       // Ghost of a Lizard Leader
		{ BuildingTypes.AngryGhost17, "Angry Ghost 17" },                                                       // Ghost of a Tortured Harpy
		{ BuildingTypes.AngryGhost18, "Angry Ghost 18" },                                                       // Ghost of a Beaver Engineer
		{ BuildingTypes.AngryGhost19, "Angry Ghost 19" },                                                       // Ghost of a Poisoned Human
		{ BuildingTypes.AngryGhost2, "Angry Ghost 2" },                                                         // Ghost of a Mad Alchemist
		{ BuildingTypes.AngryGhost20, "Angry Ghost 20" },                                                       // Ghost of a Lizard Worker
		{ BuildingTypes.AngryGhost21, "Angry Ghost 21" },                                                       // Ghost of a Starved Harpy
		{ BuildingTypes.AngryGhost24, "Angry Ghost 24" },                                                       // Ghost of an Innkeeper
		{ BuildingTypes.AngryGhost31, "Angry Ghost 31" },                                                       // Ghost of a Lizard Elder
		{ BuildingTypes.AngryGhost32, "Angry Ghost 32" },                                                       // Ghost of a Lost Scout
		{ BuildingTypes.AngryGhost34, "Angry Ghost 34" },                                                       // Ghost of a Murdered Trader
		{ BuildingTypes.AngryGhost4, "Angry Ghost 4" },                                                         // Ghost of a Deranged Scout
		{ BuildingTypes.AngryGhost5, "Angry Ghost 5" },                                                         // Ghost of a Furious Villager
		{ BuildingTypes.AngryGhost6, "Angry Ghost 6" },                                                         // Ghost of a Scared Firekeeper
		{ BuildingTypes.AngryGhost9, "Angry Ghost 9" },                                                         // Ghost of a Loyal Servant
		{ BuildingTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                             // Ghost Chest
		{ BuildingTypes.Anvil, "Anvil" },                                                                       // Anvil
		{ BuildingTypes.API_ExampleMod_BurgerJoint, "API_ExampleMod_BurgerJoint" },                             // Borgor King
		{ BuildingTypes.Apothecary, "Apothecary" },                                                             // Apothecary
		{ BuildingTypes.Arch, "Arch" },                                                                         // Ancient Arch
		{ BuildingTypes.ArchaeologyScorpionPositive, "Archaeology Scorpion Positive" },                         // Smoldering Scorpion
		{ BuildingTypes.ArchaeologySnakePositive, "Archaeology Snake Positive" },                               // Sea Serpent
		{ BuildingTypes.ArchaeologySpiderPositive, "Archaeology Spider Positive" },                             // Sealed Spider
		{ BuildingTypes.ArcheologyOffice, "Archeology office" },                                                // Archaeologist's Office
		{ BuildingTypes.Artisan, "Artisan" },                                                                   // Artisan
		{ BuildingTypes.Bakery, "Bakery" },                                                                     // Bakery
		{ BuildingTypes.Bank, "Bank" },                                                                         // Bench
		{ BuildingTypes.Barrels, "Barrels" },                                                                   // Barrels
		{ BuildingTypes.BathHouse, "Bath House" },                                                              // Bath House
		{ BuildingTypes.Beanery, "Beanery" },                                                                   // Beanery
		{ BuildingTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                       // Fallen Beaver Traders
		{ BuildingTypes.BeaverHouse, "Beaver House" },                                                          // Beaver House
		{ BuildingTypes.BigShelter, "Big Shelter" },                                                            // Big Shelter
		{ BuildingTypes.BlackStag, "Black Stag" },                                                              // Black Treasure Stag
		{ BuildingTypes.BlackTreasureStag, "Black Treasure Stag" },                                             // Black Treasure Stag
		{ BuildingTypes.BlightPost, "Blight Post" },                                                            // Blight Post
		{ BuildingTypes.Blightrot, "Blightrot" },                                                               // Blood Flower
		{ BuildingTypes.Blightrot_Clone, "Blightrot - Clone" },                                                 // Blood Flower (Clone)
		{ BuildingTypes.BlightrotCauldron, "Blightrot Cauldron" },                                              // Blightrot Cauldron
		{ BuildingTypes.Bonfire, "Bonfire" },                                                                   // Bonfire
		{ BuildingTypes.Brewery, "Brewery" },                                                                   // Brewery
		{ BuildingTypes.BrickOven, "Brick Oven" },                                                              // Brick Oven
		{ BuildingTypes.Brickyard, "Brickyard" },                                                               // Brickyard
		{ BuildingTypes.Bush, "Bush" },                                                                         // Bush
		{ BuildingTypes.Butcher, "Butcher" },                                                                   // Butcher
		{ BuildingTypes.Cages, "Cages" },                                                                       // Cages
		{ BuildingTypes.CalmGhost11, "Calm Ghost 11" },                                                         // Ghost of a Defeated Viceroy
		{ BuildingTypes.CalmGhost12, "Calm Ghost 12" },                                                         // Ghost of a Druid
		{ BuildingTypes.CalmGhost13, "Calm Ghost 13" },                                                         // Ghost of a Royal Gardener
		{ BuildingTypes.CalmGhost22, "Calm Ghost 22" },                                                         // Ghost of a Hooded Knight
		{ BuildingTypes.CalmGhost23, "Calm Ghost 23" },                                                         // Ghost of a Fire Priest
		{ BuildingTypes.CalmGhost25, "Calm Ghost 25" },                                                         // Ghost of a Treasure Hunter
		{ BuildingTypes.CalmGhost26, "Calm Ghost 26" },                                                         // Ghost of a Royal Architect
		{ BuildingTypes.CalmGhost27, "Calm Ghost 27" },                                                         // Ghost of a Worried Carter
		{ BuildingTypes.CalmGhost28, "Calm Ghost 28" },                                                         // Ghost of a Storm Victim
		{ BuildingTypes.CalmGhost29, "Calm Ghost 29" },                                                         // Ghost of a Mourning Harpy
		{ BuildingTypes.CalmGhost3, "Calm Ghost 3" },                                                           // Ghost of a Terrified Woodcutter
		{ BuildingTypes.CalmGhost30, "Calm Ghost 30" },                                                         // Ghost of a Lizard General
		{ BuildingTypes.CalmGhost33, "Calm Ghost 33" },                                                         // Ghost of an Old Merchant
		{ BuildingTypes.CalmGhost35, "Calm Ghost 35" },                                                         // Ghost of a Fox Elder
		{ BuildingTypes.CalmGhost36, "Calm Ghost 36" },                                                         // Ghost of a Teadoctor
		{ BuildingTypes.CalmGhost7, "Calm Ghost 7" },                                                           // Ghost of a Troublemaker
		{ BuildingTypes.CalmGhost8, "Calm Ghost 8" },                                                           // Ghost of a Fallen Newcomer
		{ BuildingTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                               // Ghost Chest
		{ BuildingTypes.Camp_T1, "Camp_T1" },                                                                   // Small Encampment
		{ BuildingTypes.Camp_T2, "Camp_T2" },                                                                   // Large Encampment
		{ BuildingTypes.Caravan_T1, "Caravan_T1" },                                                             // Small Destroyed Caravan
		{ BuildingTypes.Caravan_T2, "Caravan_T2" },                                                             // Large Destroyed Caravan
		{ BuildingTypes.Carpenter, "Carpenter" },                                                               // Carpenter
		{ BuildingTypes.Cellar, "Cellar" },                                                                     // Cellar
		{ BuildingTypes.Chest, "Chest" },                                                                       // Chest
		{ BuildingTypes.ClanHall, "Clan Hall" },                                                                // Clan Hall
		{ BuildingTypes.ClayPitWorkshop, "Clay Pit Workshop" },                                                 // Clay Pit
		{ BuildingTypes.Clothier, "Clothier" },                                                                 // Clothier
		{ BuildingTypes.Comfort2x2_Park, "Comfort 2x2 - Park" },                                                // Park
		{ BuildingTypes.Cookhouse, "Cookhouse" },                                                               // Cookhouse
		{ BuildingTypes.Cooperage, "Cooperage" },                                                               // Cooperage
		{ BuildingTypes.CoralDecor, "Coral Decor" },                                                            // Coral Growth
		{ BuildingTypes.CornerFence, "CornerFence" },                                                           // Fence Corner
		{ BuildingTypes.CorruptedCaravan, "Corrupted Caravan" },                                                // Corrupted Caravan
		{ BuildingTypes.Crates, "Crates" },                                                                     // Crates
		{ BuildingTypes.CrudeWorkstation, "Crude Workstation" },                                                // Crude Workstation
		{ BuildingTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                               // Clay Deposit (Large)
		{ BuildingTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                           // Clay Deposit (Small)
		{ BuildingTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                               // Dewberry Bush (Large)
		{ BuildingTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                           // Dewberry Bush (Small)
		{ BuildingTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                               // Flax Field (Large)
		{ BuildingTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                           // Flax Field (Small)
		{ BuildingTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                             // Herb Node (Large)
		{ BuildingTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                         // Herb Node (Small)
		{ BuildingTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                       // Leech Broodmother (Large)
		{ BuildingTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                   // Leech Broodmother (Small)
		{ BuildingTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },             // Ancient Proto Wheat
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },               // Dead Leviathan
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },       // Giant Proto Fungus
		{ BuildingTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                   // Grasscap Mushrooms (Large)
		{ BuildingTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },               // Grasscap Mushrooms (Small)
		{ BuildingTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                               // Moss Broccoli Patch (Large)
		{ BuildingTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                           // Moss Broccoli Patch (Small)
		{ BuildingTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                       // Grasscap Mushrooms (Large)
		{ BuildingTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                   // Grasscap Mushrooms (Small)
		{ BuildingTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                               // Reed Field (Large)
		{ BuildingTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                           // Reed Field (Small)
		{ BuildingTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                             // Root Deposit (Large)
		{ BuildingTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                         // Root Deposit (Small)
		{ BuildingTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                     // Sea Marrow Deposit (Large)
		{ BuildingTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                 // Sea Marrow Deposit (Small)
		{ BuildingTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                       // Slickshell Broodmother (Large)
		{ BuildingTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                   // Slickshell Broodmother (Small)
		{ BuildingTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                     // Snake Nest (Large)
		{ BuildingTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                 // Snake Nest (Small)
		{ BuildingTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                             // Stone Deposit (Large)
		{ BuildingTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                         // Stone Deposit (Small)
		{ BuildingTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                             // Drizzlewing Nest (Large)
		{ BuildingTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                         // Drizzlewing Nest (Small)
		{ BuildingTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                   // Swamp Wheat Field (Large)
		{ BuildingTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                               // Swamp Wheat Field (Small)
		{ BuildingTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                           // Wormtongue Nest (Large)
		{ BuildingTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                       // Wormtongue Nest (Small)
		{ BuildingTypes.DecayAltar, "Decay Altar" },                                                            // Altar of Decay
		{ BuildingTypes.DecayAltarPositive, "Decay Altar Positive" },                                           // Converted Altar of Decay
		{ BuildingTypes.Distillery, "Distillery" },                                                             // Distillery
		{ BuildingTypes.Druid, "Druid" },                                                                       // Druid's Hut
		{ BuildingTypes.EscapedConvicts, "Escaped Convicts" },                                                  // Escaped Convicts
		{ BuildingTypes.ExplorersLodge, "Explorers Lodge" },                                                    // Explorers' Lodge
		{ BuildingTypes.Farmfield, "Farmfield" },                                                               // Farm Field
		{ BuildingTypes.Fence, "Fence" },                                                                       // Fence
		{ BuildingTypes.FieldKitchen, "Field Kitchen" },                                                        // Field Kitchen
		{ BuildingTypes.Finesmith, "Finesmith" },                                                               // Finesmith
		{ BuildingTypes.FireShrine, "Fire Shrine" },                                                            // Fire Shrine
		{ BuildingTypes.FishmenCave, "Fishmen Cave" },                                                          // Fishmen Cave
		{ BuildingTypes.FishmenLighthouse, "Fishmen Lighthouse" },                                              // Fishmen Lighthouse
		{ BuildingTypes.FishmenLighthousePositive, "Fishmen Lighthouse Positive" },                             // Converted Fishmen Lighthouse
		{ BuildingTypes.FishmenOutpost, "Fishmen Outpost" },                                                    // Fishmen Outpost
		{ BuildingTypes.FishmenSoothsayer, "Fishmen Soothsayer" },                                              // Fishman Soothsayer
		{ BuildingTypes.FishmenTotem, "Fishmen Totem" },                                                        // Fishmen Totem
		{ BuildingTypes.FlawlessBrewery, "Flawless Brewery" },                                                  // Flawless Brewery
		{ BuildingTypes.FlawlessCellar, "Flawless Cellar" },                                                    // Flawless Cellar
		{ BuildingTypes.FlawlessCooperage, "Flawless Cooperage" },                                              // Flawless Cooperage
		{ BuildingTypes.FlawlessDruid, "Flawless Druid" },                                                      // Flawless Druid's Hut
		{ BuildingTypes.FlawlessLeatherworks, "Flawless Leatherworks" },                                        // Flawless Leatherworker
		{ BuildingTypes.FlawlessRainMill, "Flawless Rain Mill" },                                               // Flawless Rain Mill
		{ BuildingTypes.FlawlessSmelter, "Flawless Smelter" },                                                  // Flawless Smelter
		{ BuildingTypes.FlowerBed, "Flower Bed" },                                                              // Flower Bed
		{ BuildingTypes.ForagersCamp, "Forager's Camp" },                                                       // Foragers' Camp
		{ BuildingTypes.ForsakenCrypt, "ForsakenCrypt" },                                                       // Forsaken Crypt
		{ BuildingTypes.Forum, "Forum" },                                                                       // Forum
		{ BuildingTypes.Fountain, "Fountain" },                                                                 // Marble Fountain
		{ BuildingTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                             // Fallen Fox Scouts
		{ BuildingTypes.FoxFence, "Fox Fence" },                                                                // Overgrown Fence
		{ BuildingTypes.FoxFenceCorner, "Fox Fence Corner" },                                                   // Overgrown Fence Corner
		{ BuildingTypes.FoxHouse, "Fox House" },                                                                // Fox House
		{ BuildingTypes.FumingMachinery, "Fuming Machinery" },                                                  // Fuming Machinery
		{ BuildingTypes.Furnace, "Furnace" },                                                                   // Furnace
		{ BuildingTypes.Gate, "Gate" },                                                                         // Gate
		{ BuildingTypes.GiantStormbird, "Giant Stormbird" },                                                    // Giant Stormbird's Nest
		{ BuildingTypes.GladeTrader_TheHermit, "Glade Trader - The Hermit" },                                   // Wandering Merchant - Hermit
		{ BuildingTypes.GladeTrader_TheSeer, "Glade Trader - The Seer" },                                       // Wandering Merchant - Seer
		{ BuildingTypes.GladeTrader_TheShaman, "Glade Trader - The Shaman" },                                   // Wandering Merchant - Shaman
		{ BuildingTypes.GoldenLeaf, "Golden Leaf" },                                                            // Golden Leaf Plant
		{ BuildingTypes.GoldStag, "Gold Stag" },                                                                // Golden Treasure Stag
		{ BuildingTypes.GoldTreasureStag, "Gold Treasure Stag" },                                               // Golden Treasure Stag
		{ BuildingTypes.Granary, "Granary" },                                                                   // Granary
		{ BuildingTypes.GreenhouseWorkshop, "Greenhouse Workshop" },                                            // Greenhouse
		{ BuildingTypes.Grill, "Grill" },                                                                       // Grill
		{ BuildingTypes.Grove, "Grove" },                                                                       // Forester's Hut
		{ BuildingTypes.GuildHouse, "Guild House" },                                                            // Guild House
		{ BuildingTypes.HallowedHerbGarden, "Hallowed Herb Garden" },                                           // Hallowed Herb Garden
		{ BuildingTypes.HallowedSmallFarm, "Hallowed SmallFarm" },                                              // Hallowed Small Farm
		{ BuildingTypes.HarmonySpiritAltar, "Harmony Spirit Altar" },                                           // Harmony Spirit Altar
		{ BuildingTypes.HarmonySpiritAltarPositive, "Harmony Spirit Altar Positive" },                          // Converted Harmony Spirit Altar
		{ BuildingTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                         // Fallen Harpy Scientists
		{ BuildingTypes.HarpyHouse, "Harpy House" },                                                            // Harpy House
		{ BuildingTypes.HarvesterCamp, "Harvester Camp" },                                                      // Harvesters' Camp
		{ BuildingTypes.HauntedRuinedBeaverHouse, "Haunted Ruined Beaver House" },                              // Haunted Beaver House
		{ BuildingTypes.HauntedRuinedBrewery, "Haunted Ruined Brewery" },                                       // Haunted Brewery
		{ BuildingTypes.HauntedRuinedCellar, "Haunted Ruined Cellar" },                                         // Haunted Cellar
		{ BuildingTypes.HauntedRuinedCooperage, "Haunted Ruined Cooperage" },                                   // Haunted Cooperage
		{ BuildingTypes.HauntedRuinedDruid, "Haunted Ruined Druid" },                                           // Haunted Druid's Hut
		{ BuildingTypes.HauntedRuinedFoxHouse, "Haunted Ruined Fox House" },                                    // Haunted Fox House
		{ BuildingTypes.HauntedRuinedHarpyHouse, "Haunted Ruined Harpy House" },                                // Haunted Harpy House
		{ BuildingTypes.HauntedRuinedHerbGarden, "Haunted Ruined Herb Garden" },                                // Haunted Herb Garden
		{ BuildingTypes.HauntedRuinedHumanHouse, "Haunted Ruined Human House" },                                // Haunted Human House
		{ BuildingTypes.HauntedRuinedLeatherworks, "Haunted Ruined Leatherworks" },                             // Haunted Leatherworker
		{ BuildingTypes.HauntedRuinedLizardHouse, "Haunted Ruined Lizard House" },                              // Haunted Lizard House
		{ BuildingTypes.HauntedRuinedMarket, "Haunted Ruined Market" },                                         // Haunted Market
		{ BuildingTypes.HauntedRuinedRainmill, "Haunted Ruined Rainmill" },                                     // Haunted Rain Mill
		{ BuildingTypes.HauntedRuinedSmallFarm, "Haunted Ruined SmallFarm" },                                   // Haunted Small Farm
		{ BuildingTypes.HauntedRuinedSmelter, "Haunted Ruined Smelter" },                                       // Haunted Smelter
		{ BuildingTypes.HauntedRuinedTemple, "Haunted Ruined Temple" },                                         // Haunted Temple
		{ BuildingTypes.HerbalistsCamp, "Herbalist's Camp" },                                                   // Herbalists' Camp
		{ BuildingTypes.HerbGarden, "Herb Garden" },                                                            // Herb Garden
		{ BuildingTypes.HolyMarket, "Holy Market" },                                                            // Holy Market
		{ BuildingTypes.HolyTemple, "Holy Temple" },                                                            // Holy Temple
		{ BuildingTypes.Homestead, "Homestead" },                                                               // Homestead
		{ BuildingTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                         // Fallen Human Explorers
		{ BuildingTypes.HumanHouse, "Human House" },                                                            // Human House
		{ BuildingTypes.Hydrant, "Hydrant" },                                                                   // Hydrant
		{ BuildingTypes.InfectedMole, "Infected Mole" },                                                        // Infected Drainage Mole
		{ BuildingTypes.InfectedTree, "Infected Tree" },                                                        // Withered Tree
		{ BuildingTypes.Kelpie, "Kelpie" },                                                                     // River Kelpie
		{ BuildingTypes.Kiln, "Kiln" },                                                                         // Kiln
		{ BuildingTypes.Lamp, "Lamp" },                                                                         // Lamp
		{ BuildingTypes.LeakingCauldron, "Leaking Cauldron" },                                                  // Leaking Cauldron
		{ BuildingTypes.Leatherworks, "Leatherworks" },                                                         // Leatherworker
		{ BuildingTypes.LightningCatcher, "Lightning Catcher" },                                                // Lightning Catcher
		{ BuildingTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                       // Fallen Lizard Hunters
		{ BuildingTypes.LizardHouse, "Lizard House" },                                                          // Lizard House
		{ BuildingTypes.LizardPost, "Lizard Post" },                                                            // Lizard Post
		{ BuildingTypes.LoreTablet1, "Lore Tablet 1" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet2, "Lore Tablet 2" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet3, "Lore Tablet 3" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet4, "Lore Tablet 4" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet5, "Lore Tablet 5" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet6, "Lore Tablet 6" },                                                         // Inscribed Monolith
		{ BuildingTypes.LoreTablet7, "Lore Tablet 7" },                                                         // Inscribed Monolith
		{ BuildingTypes.Lumbermill, "Lumbermill" },                                                             // Lumber Mill
		{ BuildingTypes.MainStoragenot_buildable_, "Main Storage (not-buildable)" },                            // Main Warehouse
		{ BuildingTypes.MakeshiftPost, "Makeshift Post" },                                                      // Makeshift Post
		{ BuildingTypes.Manufactory, "Manufactory" },                                                           // Manufactory
		{ BuildingTypes.Market, "Market" },                                                                     // Market
		{ BuildingTypes.MerchantShipWreck, "Merchant Ship Wreck" },                                             // Merchant Shipwreck
		{ BuildingTypes.Mine, "Mine" },                                                                         // Mine
		{ BuildingTypes.Mistworm_T1, "Mistworm_T1" },                                                           // Hungry Mistworm
		{ BuildingTypes.Mole, "Mole" },                                                                         // Drainage Mole
		{ BuildingTypes.Monastery, "Monastery" },                                                               // Monastery
		{ BuildingTypes.Monolith, "Monolith" },                                                                 // Obelisk
		{ BuildingTypes.MonolithPositive, "Monolith Positive" },                                                // Obelisk
		{ BuildingTypes.MushroomDecor, "Mushroom Decor" },                                                      // Decorative Fungus
		{ BuildingTypes.Nightfern, "Nightfern" },                                                               // Nightfern
		{ BuildingTypes.NoxiousMachinery, "Noxious Machinery" },                                                // Noxious Machinery
		{ BuildingTypes.Path, "Path" },                                                                         // Path
		{ BuildingTypes.PavedRoad, "Paved Road" },                                                              // Paved Road
		{ BuildingTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                 // Petrified Tree
		{ BuildingTypes.Pipe, "Pipe" },                                                                         // Pipe
		{ BuildingTypes.PipeCross, "Pipe Cross" },                                                              // Pipe Cross
		{ BuildingTypes.PipeElbow, "Pipe Elbow" },                                                              // Pipe Elbow
		{ BuildingTypes.PipeEnd, "Pipe End" },                                                                  // Pipe Ending
		{ BuildingTypes.PipeTCross, "Pipe T Cross" },                                                           // Pipe T-Connector
		{ BuildingTypes.PipeValve, "Pipe Valve" },                                                              // Valve
		{ BuildingTypes.Plantation, "Plantation" },                                                             // Plantation
		{ BuildingTypes.Press, "Press" },                                                                       // Press
		{ BuildingTypes.PrimitiveForagersCamp, "Primitive Forager's Camp" },                                    // Small Foragers' Camp
		{ BuildingTypes.PrimitiveHerbalistsCamp, "Primitive Herbalist's Camp" },                                // Small Herbalists' Camp
		{ BuildingTypes.PrimitiveTrappersCamp, "Primitive Trapper's Camp" },                                    // Small Trappers' Camp
		{ BuildingTypes.Provisioner, "Provisioner" },                                                           // Provisioner
		{ BuildingTypes.PurgedBeaverHouse, "Purged Beaver House" },                                             // Purified Beaver House
		{ BuildingTypes.PurgedFoxHouse, "Purged Fox House" },                                                   // Purified Fox House
		{ BuildingTypes.PurgedHarpyHouse, "Purged Harpy House" },                                               // Purified Harpy House
		{ BuildingTypes.PurgedHumanHouse, "Purged Human House" },                                               // Purified Human House
		{ BuildingTypes.PurgedLizardHouse, "Purged Lizard House" },                                             // Purified Lizard House
		{ BuildingTypes.RainCatcher, "Rain Catcher" },                                                          // Rain Collector
		{ BuildingTypes.RainMill, "Rain Mill" },                                                                // Rain Mill
		{ BuildingTypes.RainpunkBarrels, "Rainpunk Barrels" },                                                  // Rainpunk Barrels
		{ BuildingTypes.RainpunkDrill_Coal, "Rainpunk Drill - Coal" },                                          // Rainpunk Drill
		{ BuildingTypes.RainpunkDrill_Copper, "Rainpunk Drill - Copper" },                                      // Rainpunk Drill
		{ BuildingTypes.RainpunkFactory, "RainpunkFactory" },                                                   // Destroyed Rainpunk Foundry
		{ BuildingTypes.RainpunkFoundry, "Rainpunk Foundry" },                                                  // Rainpunk Foundry
		{ BuildingTypes.RainTotem, "Rain Totem" },                                                              // Rain Spirit Totem
		{ BuildingTypes.RainTotemPositive, "Rain Totem Positive" },                                             // Converted Rain Totem
		{ BuildingTypes.Ranch, "Ranch" },                                                                       // Ranch
		{ BuildingTypes.ReinforcedRoad, "Reinforced Road" },                                                    // Reinforced Road
		{ BuildingTypes.RewardChest_T1, "RewardChest_T1" },                                                     // Small Abandoned Cache
		{ BuildingTypes.RewardChest_T2, "RewardChest_T2" },                                                     // Medium Abandoned Cache
		{ BuildingTypes.RewardChest_T3, "RewardChest_T3" },                                                     // Large Abandoned Cache
		{ BuildingTypes.RoadSign, "Road Sign" },                                                                // Road Sign
		{ BuildingTypes.RuinedAdvancedRainCatcher, "Ruined Advanced Rain Catcher" },                            // Advanced Rain Collector
		{ BuildingTypes.RuinedAdvancedRainCatchernoReward_, "Ruined Advanced Rain Catcher (no reward)" },       // Advanced Rain Collector
		{ BuildingTypes.RuinedAlchemist, "Ruined Alchemist" },                                                  // Alchemist's Hut
		{ BuildingTypes.RuinedAlchemistnoReward_, "Ruined Alchemist (no reward)" },                             // Alchemist's Hut
		{ BuildingTypes.RuinedApothecary, "Ruined Apothecary" },                                                // Apothecary
		{ BuildingTypes.RuinedApothecarynoReward_, "Ruined Apothecary (no reward)" },                           // Apothecary
		{ BuildingTypes.RuinedArtisan, "Ruined Artisan" },                                                      // Artisan
		{ BuildingTypes.RuinedArtisannoReward_, "Ruined Artisan (no reward)" },                                 // Artisan
		{ BuildingTypes.RuinedBakery, "Ruined Bakery" },                                                        // Bakery
		{ BuildingTypes.RuinedBakerynoReward_, "Ruined Bakery (no reward)" },                                   // Bakery
		{ BuildingTypes.RuinedBathHouse, "Ruined Bath House" },                                                 // Bath House
		{ BuildingTypes.RuinedBathHousenoReward_, "Ruined Bath House (no reward)" },                            // Bath House
		{ BuildingTypes.RuinedBeanery, "Ruined Beanery" },                                                      // Beanery
		{ BuildingTypes.RuinedBeanerynoReward_, "Ruined Beanery (no reward)" },                                 // Beanery
		{ BuildingTypes.RuinedBeaverHouse, "Ruined Beaver House" },                                             // Beaver House
		{ BuildingTypes.RuinedBeaverHousenoReward_, "Ruined Beaver House (no reward)" },                        // Beaver House
		{ BuildingTypes.RuinedBigShelter, "Ruined Big Shelter" },                                               // Big Shelter
		{ BuildingTypes.RuinedBigShelternoReward_, "Ruined Big Shelter (no reward)" },                          // Big Shelter
		{ BuildingTypes.RuinedBrewery, "Ruined Brewery" },                                                      // Brewery
		{ BuildingTypes.RuinedBrewerynoReward_, "Ruined Brewery (no reward)" },                                 // Brewery
		{ BuildingTypes.RuinedBrickOven, "Ruined Brick Oven" },                                                 // Brick Oven
		{ BuildingTypes.RuinedBrickOvennoReward_, "Ruined Brick Oven (no reward)" },                            // Brick Oven
		{ BuildingTypes.RuinedBrickyard, "Ruined Brickyard" },                                                  // Brickyard
		{ BuildingTypes.RuinedBrickyardnoReward_, "Ruined Brickyard (no reward)" },                             // Brickyard
		{ BuildingTypes.RuinedButcher, "Ruined Butcher" },                                                      // Butcher
		{ BuildingTypes.RuinedButchernoReward_, "Ruined Butcher (no reward)" },                                 // Butcher
		{ BuildingTypes.RuinedCarpenter, "Ruined Carpenter" },                                                  // Carpenter
		{ BuildingTypes.RuinedCarpenternoReward_, "Ruined Carpenter (no reward)" },                             // Carpenter
		{ BuildingTypes.RuinedCellar, "Ruined Cellar" },                                                        // Cellar
		{ BuildingTypes.RuinedCellarnoReward_, "Ruined Cellar (no reward)" },                                   // Cellar
		{ BuildingTypes.RuinedClanHall, "Ruined Clan Hall" },                                                   // Clan Hall
		{ BuildingTypes.RuinedClanHallnoReward_, "Ruined Clan Hall (no reward)" },                              // Clan Hall
		{ BuildingTypes.RuinedClayPit, "Ruined Clay Pit" },                                                     // Clay Pit
		{ BuildingTypes.RuinedClayPitnoReward_, "Ruined Clay Pit (no reward)" },                                // Clay Pit
		{ BuildingTypes.RuinedCookhouse, "Ruined Cookhouse" },                                                  // Cookhouse
		{ BuildingTypes.RuinedCookhousenoReward_, "Ruined Cookhouse (no reward)" },                             // Cookhouse
		{ BuildingTypes.RuinedCooperage, "Ruined Cooperage" },                                                  // Cooperage
		{ BuildingTypes.RuinedCooperagenoReward_, "Ruined Cooperage (no reward)" },                             // Cooperage
		{ BuildingTypes.RuinedCrudeWorkstationnoReward_, "Ruined Crude Workstation (no reward)" },              // Crude Workstation
		{ BuildingTypes.RuinedDistillery, "Ruined Distillery" },                                                // Distillery
		{ BuildingTypes.RuinedDistillerynoReward_, "Ruined Distillery (no reward)" },                           // Distillery
		{ BuildingTypes.RuinedDruid, "Ruined Druid" },                                                          // Druid's Hut
		{ BuildingTypes.RuinedDruidnoReward_, "Ruined Druid (no reward)" },                                     // Druid's Hut
		{ BuildingTypes.RuinedExplorersLodge, "Ruined Explorers Lodge" },                                       // Explorers' Lodge
		{ BuildingTypes.RuinedExplorersLodgenoReward_, "Ruined Explorers Lodge (no reward)" },                  // Explorers' Lodge
		{ BuildingTypes.RuinedFarm, "Ruined Farm" },                                                            // Homestead
		{ BuildingTypes.RuinedFarmnoReward_, "Ruined Farm (no reward)" },                                       // Homestead
		{ BuildingTypes.RuinedFieldKitchennoReward_, "Ruined Field Kitchen (no reward)" },                      // Field Kitchen
		{ BuildingTypes.RuinedFinesmith, "Ruined Finesmith" },                                                  // Finesmith
		{ BuildingTypes.RuinedFinesmithnoReward_, "Ruined Finesmith (no reward)" },                             // Finesmith
		{ BuildingTypes.RuinedForagersCamp, "Ruined Foragers Camp" },                                           // Foragers' Camp
		{ BuildingTypes.RuinedForagersCampnoReward_, "Ruined Foragers Camp (no reward)" },                      // Foragers' Camp
		{ BuildingTypes.RuinedForagersCampPrimitivenoReward_, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp
		{ BuildingTypes.RuinedForum, "Ruined Forum" },                                                          // Forum
		{ BuildingTypes.RuinedForumnoReward_, "Ruined Forum (no reward)" },                                     // Forum
		{ BuildingTypes.RuinedFoxHouse, "Ruined Fox House" },                                                   // Fox House
		{ BuildingTypes.RuinedFoxHousenoReward_, "Ruined Fox House (no reward)" },                              // Fox House
		{ BuildingTypes.RuinedFurnace, "Ruined Furnace" },                                                      // Furnace
		{ BuildingTypes.RuinedFurnacenoReward_, "Ruined Furnace (no reward)" },                                 // Furnace
		{ BuildingTypes.RuinedGranary, "Ruined Granary" },                                                      // Granary
		{ BuildingTypes.RuinedGranarynoReward_, "Ruined Granary (no reward)" },                                 // Granary
		{ BuildingTypes.RuinedGreenhouse, "Ruined Greenhouse" },                                                // Greenhouse
		{ BuildingTypes.RuinedGreenhousenoReward_, "Ruined Greenhouse (no reward)" },                           // Greenhouse
		{ BuildingTypes.RuinedGrill, "Ruined Grill" },                                                          // Grill
		{ BuildingTypes.RuinedGrillnoReward_, "Ruined Grill (no reward)" },                                     // Grill
		{ BuildingTypes.RuinedGrove, "Ruined Grove" },                                                          // Forester's Hut
		{ BuildingTypes.RuinedGrovenoReward_, "Ruined Grove (no reward)" },                                     // Forester's Hut
		{ BuildingTypes.RuinedGuildHouse, "Ruined Guild House" },                                               // Guild House
		{ BuildingTypes.RuinedGuildHousenoReward_, "Ruined Guild House (no reward)" },                          // Guild House
		{ BuildingTypes.RuinedHarpyHouse, "Ruined Harpy House" },                                               // Harpy House
		{ BuildingTypes.RuinedHarpyHousenoReward_, "Ruined Harpy House (no reward)" },                          // Harpy House
		{ BuildingTypes.RuinedHarvesterCamp, "Ruined Harvester Camp" },                                         // Harvesters' Camp
		{ BuildingTypes.RuinedHarvesterCampnoReward_, "Ruined Harvester Camp (no reward)" },                    // Harvesters' Camp
		{ BuildingTypes.RuinedHearth, "Ruined Hearth" },                                                        // Ancient Hearth
		{ BuildingTypes.RuinedHearthnoReward_, "Ruined Hearth (no reward)" },                                   // Ancient Hearth
		{ BuildingTypes.RuinedHerbalistCamp, "Ruined Herbalist Camp" },                                         // Herbalists' Camp
		{ BuildingTypes.RuinedHerbalistCampnoReward_, "Ruined Herbalist Camp (no reward)" },                    // Herbalists' Camp
		{ BuildingTypes.RuinedHerbalistCampPrimitivenoReward_, "Ruined Herbalist Camp primitive (no reward)" }, // Herbalists' Camp
		{ BuildingTypes.RuinedHerbGarden, "Ruined Herb Garden" },                                               // Herb Garden
		{ BuildingTypes.RuinedHerbGardennoReward_, "Ruined Herb Garden (no reward)" },                          // Herb Garden
		{ BuildingTypes.RuinedHumanHouse, "Ruined Human House" },                                               // Human House
		{ BuildingTypes.RuinedHumanHousenoReward_, "Ruined Human House (no reward)" },                          // Human House
		{ BuildingTypes.RuinedKiln, "Ruined Kiln" },                                                            // Kiln
		{ BuildingTypes.RuinedKilnnoReward_, "Ruined Kiln (no reward)" },                                       // Kiln
		{ BuildingTypes.RuinedLeatherworks, "Ruined Leatherworks" },                                            // Leatherworker
		{ BuildingTypes.RuinedLeatherworksnoReward_, "Ruined Leatherworks (no reward)" },                       // Leatherworker
		{ BuildingTypes.RuinedLizardHouse, "Ruined Lizard House" },                                             // Lizard House
		{ BuildingTypes.RuinedLizardHousenoReward_, "Ruined Lizard House (no reward)" },                        // Lizard House
		{ BuildingTypes.RuinedLumbermill, "Ruined Lumbermill" },                                                // Lumber Mill
		{ BuildingTypes.RuinedLumbermillnoReward_, "Ruined Lumbermill (no reward)" },                           // Lumber Mill
		{ BuildingTypes.RuinedMakeshiftPostnoReward_, "Ruined Makeshift Post (no reward)" },                    // Makeshift Post
		{ BuildingTypes.RuinedManufatory, "Ruined Manufatory" },                                                // Manufactory
		{ BuildingTypes.RuinedManufatorynoReward_, "Ruined Manufatory (no reward)" },                           // Manufactory
		{ BuildingTypes.RuinedMarket, "Ruined Market" },                                                        // Market
		{ BuildingTypes.RuinedMarketnoReward_, "Ruined Market (no reward)" },                                   // Market
		{ BuildingTypes.RuinedMinenoReward_, "Ruined Mine (no reward)" },                                       // Mine
		{ BuildingTypes.RuinedMonastery, "Ruined Monastery" },                                                  // Monastery
		{ BuildingTypes.RuinedMonasterynoReward_, "Ruined Monastery (no reward)" },                             // Monastery
		{ BuildingTypes.RuinedPlantation, "Ruined Plantation" },                                                // Plantation
		{ BuildingTypes.RuinedPlantationnoReward_, "Ruined Plantation (no reward)" },                           // Plantation
		{ BuildingTypes.RuinedPress, "Ruined Press" },                                                          // Press
		{ BuildingTypes.RuinedPressnoReward_, "Ruined Press (no reward)" },                                     // Press
		{ BuildingTypes.RuinedProvisioner, "Ruined Provisioner" },                                              // Provisioner
		{ BuildingTypes.RuinedProvisionernoReward_, "Ruined Provisioner (no reward)" },                         // Provisioner
		{ BuildingTypes.RuinedRainCatchernoReward_, "Ruined Rain Catcher (no reward)" },                        // Rain Collector
		{ BuildingTypes.RuinedRainmill, "Ruined Rainmill" },                                                    // Rain Mill
		{ BuildingTypes.RuinedRainmillnoReward_, "Ruined Rainmill (no reward)" },                               // Rain Mill
		{ BuildingTypes.RuinedRanch, "Ruined Ranch" },                                                          // Ranch
		{ BuildingTypes.RuinedRanchnoReward_, "Ruined Ranch (no reward)" },                                     // Ranch
		{ BuildingTypes.RuinedScribe, "Ruined Scribe" },                                                        // Scribe
		{ BuildingTypes.RuinedScribenoReward_, "Ruined Scribe (no reward)" },                                   // Scribe
		{ BuildingTypes.RuinedSewer, "Ruined Sewer" },                                                          // Clothier
		{ BuildingTypes.RuinedSewernoReward_, "Ruined Sewer (no reward)" },                                     // Clothier
		{ BuildingTypes.RuinedShelter, "Ruined Shelter" },                                                      // Shelter
		{ BuildingTypes.RuinedShelternoReward_, "Ruined Shelter (no reward)" },                                 // Shelter
		{ BuildingTypes.RuinedSmallFarm, "Ruined SmallFarm" },                                                  // Small Farm
		{ BuildingTypes.RuinedSmallFarmnoReward_, "Ruined SmallFarm (no reward)" },                             // Small Farm
		{ BuildingTypes.RuinedSmelter, "Ruined Smelter" },                                                      // Smelter
		{ BuildingTypes.RuinedSmelternoReward_, "Ruined Smelter (no reward)" },                                 // Smelter
		{ BuildingTypes.RuinedSmithy, "Ruined Smithy" },                                                        // Smithy
		{ BuildingTypes.RuinedSmithynoReward_, "Ruined Smithy (no reward)" },                                   // Smithy
		{ BuildingTypes.RuinedSmokehouse, "Ruined Smokehouse" },                                                // Smokehouse
		{ BuildingTypes.RuinedSmokehousenoReward_, "Ruined Smokehouse (no reward)" },                           // Smokehouse
		{ BuildingTypes.RuinedStampingMill, "Ruined Stamping Mill" },                                           // Stamping Mill
		{ BuildingTypes.RuinedStampingMillnoReward_, "Ruined Stamping Mill (no reward)" },                      // Stamping Mill
		{ BuildingTypes.RuinedStonecutterCamp, "Ruined Stonecutter Camp" },                                     // Stonecutters' Camp
		{ BuildingTypes.RuinedStonecutterCampnoReward_, "Ruined Stonecutter Camp (no reward)" },                // Stonecutters' Camp
		{ BuildingTypes.RuinedStorage, "Ruined Storage" },                                                      // Small Warehouse
		{ BuildingTypes.RuinedStoragenoReward_, "Ruined Storage (no reward)" },                                 // Small Warehouse
		{ BuildingTypes.RuinedSupplier, "Ruined Supplier" },                                                    // Supplier
		{ BuildingTypes.RuinedSuppliernoReward_, "Ruined Supplier (no reward)" },                               // Supplier
		{ BuildingTypes.RuinedTavern, "Ruined Tavern" },                                                        // Tavern
		{ BuildingTypes.RuinedTavernnoReward_, "Ruined Tavern (no reward)" },                                   // Tavern
		{ BuildingTypes.RuinedTeaDoctor, "Ruined Tea Doctor" },                                                 // Tea Doctor
		{ BuildingTypes.RuinedTeaDoctornoReward_, "Ruined Tea Doctor (no reward)" },                            // Tea Doctor
		{ BuildingTypes.RuinedTeaHouse, "Ruined Tea House" },                                                   // Teahouse
		{ BuildingTypes.RuinedTeaHousenoReward_, "Ruined Tea House (no reward)" },                              // Teahouse
		{ BuildingTypes.RuinedTemple, "Ruined Temple" },                                                        // Temple
		{ BuildingTypes.RuinedTemplenoReward_, "Ruined Temple (no reward)" },                                   // Temple
		{ BuildingTypes.RuinedTinctury, "Ruined Tinctury" },                                                    // Tinctury
		{ BuildingTypes.RuinedTincturynoReward_, "Ruined Tinctury (no reward)" },                               // Tinctury
		{ BuildingTypes.RuinedTinkerer, "Ruined Tinkerer" },                                                    // Tinkerer
		{ BuildingTypes.RuinedTinkerernoReward_, "Ruined Tinkerer (no reward)" },                               // Tinkerer
		{ BuildingTypes.RuinedToolshop, "Ruined Toolshop" },                                                    // Toolshop
		{ BuildingTypes.RuinedToolshopnoReward_, "Ruined Toolshop (no reward)" },                               // Toolshop
		{ BuildingTypes.RuinedTradingPostnoReward_, "Ruined Trading Post (no reward)" },                        // Trading Post
		{ BuildingTypes.RuinedTrappersCamp, "Ruined Trappers Camp" },                                           // Trappers' Camp
		{ BuildingTypes.RuinedTrappersCampnoReward_, "Ruined Trappers Camp (no reward)" },                      // Trappers' Camp
		{ BuildingTypes.RuinedTrappersCampPrimitivenoReward_, "Ruined Trappers Camp Primitive (no reward)" },   // Trappers' Camp
		{ BuildingTypes.RuinedWeaver, "Ruined Weaver" },                                                        // Weaver
		{ BuildingTypes.RuinedWeavernoReward_, "Ruined Weaver (no reward)" },                                   // Weaver
		{ BuildingTypes.RuinedWoodcuttersCamp, "Ruined Woodcutters Camp" },                                     // Woodcutters' Camp
		{ BuildingTypes.RuinedWoodcuttersCampnoReward_, "Ruined Woodcutters Camp (no reward)" },                // Woodcutters' Camp
		{ BuildingTypes.RuinedWorkshop, "Ruined Workshop" },                                                    // Workshop
		{ BuildingTypes.RuinedWorkshopnoReward_, "Ruined Workshop (no reward)" },                               // Workshop
		{ BuildingTypes.SacrificeTotem, "Sacrifice Totem" },                                                    // Totem of Denial
		{ BuildingTypes.SacrificeTotemPositive, "Sacrifice Totem Positive" },                                   // Converted Totem of Denial
		{ BuildingTypes.ScarletDecor, "Scarlet Decor" },                                                        // Thorny Reed
		{ BuildingTypes.Scorpion1, "Scorpion 1" },                                                              // Archaeological Discovery
		{ BuildingTypes.Scorpion2, "Scorpion 2" },                                                              // Archaeological Excavation
		{ BuildingTypes.Scorpion3, "Scorpion 3" },                                                              // Archaeological Reconstruction
		{ BuildingTypes.Scribe, "Scribe" },                                                                     // Scribe
		{ BuildingTypes.Seal, "Seal" },                                                                         // Ancient Seal
		{ BuildingTypes.SealedBiomeShrine, "Sealed Biome Shrine" },                                             // Beacon Tower
		{ BuildingTypes.SealedTomb_T1, "SealedTomb_T1" },                                                       // Open Vault
		{ BuildingTypes.SealGuidepost, "Seal Guidepost" },                                                      // Guidance Stone
		{ BuildingTypes.SealLowDiff, "Seal Low Diff" },                                                         // Ancient Seal
		{ BuildingTypes.Shelter, "Shelter" },                                                                   // Shelter
		{ BuildingTypes.Signboard, "Signboard" },                                                               // Signboard
		{ BuildingTypes.SmallFarm, "SmallFarm" },                                                               // Small Farm
		{ BuildingTypes.SmallHearth, "Small Hearth" },                                                          // Ancient Hearth
		{ BuildingTypes.Smelter, "Smelter" },                                                                   // Smelter
		{ BuildingTypes.Smithy, "Smithy" },                                                                     // Smithy
		{ BuildingTypes.Smokehouse, "Smokehouse" },                                                             // Smokehouse
		{ BuildingTypes.Snake1, "Snake 1" },                                                                    // Archaeological Discovery
		{ BuildingTypes.Snake2, "Snake 2" },                                                                    // Archaeological Excavation
		{ BuildingTypes.Snake3, "Snake 3" },                                                                    // Archaeological Reconstruction
		{ BuildingTypes.Spider1, "Spider 1" },                                                                  // Archaeological Discovery
		{ BuildingTypes.Spider2, "Spider 2" },                                                                  // Archaeological Excavation
		{ BuildingTypes.Spider3, "Spider 3" },                                                                  // Archaeological Reconstruction
		{ BuildingTypes.StampingMill, "Stamping Mill" },                                                        // Stamping Mill
		{ BuildingTypes.StonecuttersCamp, "Stonecutter's Camp" },                                               // Stonecutters' Camp
		{ BuildingTypes.Storagebuildable_, "Storage (buildable)" },                                             // Small Warehouse
		{ BuildingTypes.StormbirdPositive, "Stormbird Positive" },                                              // Tamed Stormbird
		{ BuildingTypes.Supplier, "Supplier" },                                                                 // Supplier
		{ BuildingTypes.Tavern, "Tavern" },                                                                     // Tavern
		{ BuildingTypes.TeaDoctor, "Tea Doctor" },                                                              // Tea Doctor
		{ BuildingTypes.TeaHouse, "Tea House" },                                                                // Teahouse
		{ BuildingTypes.Temple, "Temple" },                                                                     // Temple
		{ BuildingTypes.TemporaryHearthbuildable_, "Temporary Hearth (buildable)" },                            // Small Hearth
		{ BuildingTypes.TemporaryHearthnot_buildable_, "Temporary Hearth (not-buildable)" },                    // Small Hearth
		{ BuildingTypes.TermiteBurrow, "Termite Burrow" },                                                      // Stonetooth Termite Burrow
		{ BuildingTypes.TermiteBurrowPositive, "Termite Burrow Positive" },                                     // Termite Nest
		{ BuildingTypes.TIAncientShrine_T1, "TI AncientShrine_T1" },                                            // Ancient Shrine
		{ BuildingTypes.Tinctury, "Tinctury" },                                                                 // Tinctury
		{ BuildingTypes.Tinkerer, "Tinkerer" },                                                                 // Tinkerer
		{ BuildingTypes.Toolshop, "Toolshop" },                                                                 // Toolshop
		{ BuildingTypes.Tower, "Tower" },                                                                       // Wall Crossing
		{ BuildingTypes.TownBoard, "Town Board" },                                                              // Town Board
		{ BuildingTypes.TradersCemetery, "Traders Cemetery" },                                                  // Hidden Trader Cemetery
		{ BuildingTypes.TradingPost, "Trading Post" },                                                          // Trading Post
		{ BuildingTypes.TrappersCamp, "Trapper's Camp" },                                                       // Trappers' Camp
		{ BuildingTypes.Umbrella, "Umbrella" },                                                                 // Umbrella
		{ BuildingTypes.Wall, "Wall" },                                                                         // Wall
		{ BuildingTypes.WallCorner, "Wall Corner" },                                                            // Wall Corner
		{ BuildingTypes.WarBeastCage, "War Beast Cage" },                                                       // Destroyed Cage of the Warbeast
		{ BuildingTypes.WaterBarrels, "Water Barrels" },                                                        // Water Barrels
		{ BuildingTypes.WaterExtractor, "Water Extractor" },                                                    // Geyser Pump
		{ BuildingTypes.Weaver, "Weaver" },                                                                     // Weaver
		{ BuildingTypes.Well, "Well" },                                                                         // Overgrown Well
		{ BuildingTypes.WhiteStag, "White Stag" },                                                              // Royal Treasure Stag
		{ BuildingTypes.WhiteTreasureStag, "White Treasure Stag" },                                             // Royal Treasure Stag
		{ BuildingTypes.Wildfire, "Wildfire" },                                                                 // Wildfire
		{ BuildingTypes.WoodcuttersCamp, "Woodcutters Camp" },                                                  // Woodcutters' Camp
		{ BuildingTypes.Workshop, "Workshop" },                                                                 // Workshop
	};
}
