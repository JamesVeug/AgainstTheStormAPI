using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum RelicTypes
{
    Unknown = -1,
    None,
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
	BeaverBattleground_T1,                      // Fallen Beaver Traders
	Black_Stag,                                 // Black Treasure Stag
	Black_Treasure_Stag,                        // Black Treasure Stag
	Blightrot,                                  // Blood Flower
	Blightrot___Clone,                          // Blood Flower (Clone)
	Blightrot_Cauldron,                         // Blightrot Cauldron
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
	Corrupted_Caravan,                          // Corrupted Caravan
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
	Escaped_Convicts,                           // Escaped Convicts
	Fishmen_Cave,                               // Fishmen Cave
	Fishmen_Lighthouse,                         // Fishmen Lighthouse
	Fishmen_Outpost,                            // Fishmen Outpost
	Fishmen_Soothsayer,                         // Fishman Soothsayer
	Fishmen_Totem,                              // Fishmen Totem
	ForsakenCrypt,                              // Forsaken Crypt
	FoxBattleground_T1,                         // Fallen Fox Scouts
	Fuming_Machinery,                           // Fuming Machinery
	Giant_Stormbird,                            // Giant Stormbird's Nest
	Glade_Trader___The_Hermit,                  // Wandering Merchant - Hermit
	Glade_Trader___The_Seer,                    // Wandering Merchant - Seer
	Glade_Trader___The_Shaman,                  // Wandering Merchant - Shaman
	Gold_Stag,                                  // Golden Treasure Stag
	Gold_Treasure_Stag,                         // Golden Treasure Stag
	Harmony_Spirit_Altar,                       // Harmony Spirit Altar
	HarpyBattleground_T1,                       // Fallen Harpy Scientists
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
	HumanBattleground_T1,                       // Fallen Human Explorers
	Infected_Mole,                              // Infected Drainage Mole
	Infected_Tree,                              // Withered Tree
	Kelpie,                                     // River Kelpie
	Leaking_Cauldron,                           // Leaking Cauldron
	Lightning_Catcher,                          // Lightning Catcher
	LizardBattleground_T1,                      // Fallen Lizard Hunters
	Merchant_Ship_Wreck,                        // Merchant Shipwreck
	Mistworm_T1,                                // Hungry Mistworm
	Mole,                                       // Drainage Mole
	Monolith,                                   // Obelisk
	Noxious_Machinery,                          // Noxious Machinery
	PetrifiedTree_T1,                           // Petrified Tree
	Rain_Totem,                                 // Rain Spirit Totem
	Rainpunk_Drill___Coal,                      // Rainpunk Drill
	Rainpunk_Drill___Copper,                    // Rainpunk Drill
	RainpunkFactory,                            // Destroyed Rainpunk Foundry
	RewardChest_T1,                             // Small Abandoned Cache
	RewardChest_T2,                             // Medium Abandoned Cache
	RewardChest_T3,                             // Large Abandoned Cache
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
	Scorpion_1,                                 // Archaeological Discovery
	Scorpion_2,                                 // Archaeological Excavation
	Scorpion_3,                                 // Archaeological Reconstruction
	SealedTomb_T1,                              // Open Vault
	Snake_1,                                    // Archaeological Discovery
	Snake_2,                                    // Archaeological Excavation
	Snake_3,                                    // Archaeological Reconstruction
	Spider_1,                                   // Archaeological Discovery
	Spider_2,                                   // Archaeological Excavation
	Spider_3,                                   // Archaeological Reconstruction
	Termite_Burrow,                             // Stonetooth Termite Burrow
	TI_AncientShrine_T1,                        // Ancient Shrine
	Traders_Cemetery,                           // Hidden Trader Cemetery
	War_Beast_Cage,                             // Destroyed Cage of the Warbeast
	White_Stag,                                 // Royal Treasure Stag
	White_Treasure_Stag,                        // Royal Treasure Stag
	Wildfire,                                   // Wildfire

    MAX = 317
}

public static class RelicTypesExtensions
{
	public static string ToName(this RelicTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of RelicTypes: " + type);
		return TypeToInternalName[RelicTypes.AncientBurrialGrounds];
	}
	
	public static RelicModel ToRelicModel(this string name)
    {
        RelicModel model = SO.Settings.Relics.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find RelicModel for RelicTypes with name: " + name);
        return null;
    }

	public static RelicModel ToRelicModel(this RelicTypes types)
	{
		return types.ToName().ToRelicModel();
	}
	
	public static RelicModel[] ToRelicModelArray(this IEnumerable<RelicTypes> collection)
    {
        int count = collection.Count();
        RelicModel[] array = new RelicModel[count];
        int i = 0;
        foreach (RelicTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.Relics.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<RelicTypes, string> TypeToInternalName = new()
	{
		{ RelicTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                            // Ancient Burial Site
		{ RelicTypes.AncientGate, "AncientGate" },                                                                // Dark Gate
		{ RelicTypes.AncientShrine_T1, "AncientShrine_T1" },                                                      // Ancient Shrine
		{ RelicTypes.AncientTemple, "AncientTemple" },                                                            // Forgotten Temple of the Sun
		{ RelicTypes.Angry_Ghost_1, "Angry Ghost 1" },                                                            // Ghost of a Blight Fighter Captain
		{ RelicTypes.Angry_Ghost_10, "Angry Ghost 10" },                                                          // Ghost of a Suppressed Rebel
		{ RelicTypes.Angry_Ghost_14, "Angry Ghost 14" },                                                          // Ghost of a Resentful Human
		{ RelicTypes.Angry_Ghost_15, "Angry Ghost 15" },                                                          // Ghost of the Queen's Lickspittle
		{ RelicTypes.Angry_Ghost_16, "Angry Ghost 16" },                                                          // Ghost of a Lizard Leader
		{ RelicTypes.Angry_Ghost_17, "Angry Ghost 17" },                                                          // Ghost of a Tortured Harpy
		{ RelicTypes.Angry_Ghost_18, "Angry Ghost 18" },                                                          // Ghost of a Beaver Engineer
		{ RelicTypes.Angry_Ghost_19, "Angry Ghost 19" },                                                          // Ghost of a Poisoned Human
		{ RelicTypes.Angry_Ghost_2, "Angry Ghost 2" },                                                            // Ghost of a Mad Alchemist
		{ RelicTypes.Angry_Ghost_20, "Angry Ghost 20" },                                                          // Ghost of a Lizard Worker
		{ RelicTypes.Angry_Ghost_21, "Angry Ghost 21" },                                                          // Ghost of a Starved Harpy
		{ RelicTypes.Angry_Ghost_24, "Angry Ghost 24" },                                                          // Ghost of an Innkeeper
		{ RelicTypes.Angry_Ghost_31, "Angry Ghost 31" },                                                          // Ghost of a Lizard Elder
		{ RelicTypes.Angry_Ghost_32, "Angry Ghost 32" },                                                          // Ghost of a Lost Scout
		{ RelicTypes.Angry_Ghost_34, "Angry Ghost 34" },                                                          // Ghost of a Murdered Trader
		{ RelicTypes.Angry_Ghost_4, "Angry Ghost 4" },                                                            // Ghost of a Deranged Scout
		{ RelicTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                            // Ghost of a Furious Villager
		{ RelicTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                            // Ghost of a Scared Firekeeper
		{ RelicTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                            // Ghost of a Loyal Servant
		{ RelicTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                  // Ghost Chest
		{ RelicTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                            // Fallen Beaver Traders
		{ RelicTypes.Black_Stag, "Black Stag" },                                                                  // Black Treasure Stag
		{ RelicTypes.Black_Treasure_Stag, "Black Treasure Stag" },                                                // Black Treasure Stag
		{ RelicTypes.Blightrot, "Blightrot" },                                                                    // Blood Flower
		{ RelicTypes.Blightrot___Clone, "Blightrot - Clone" },                                                    // Blood Flower (Clone)
		{ RelicTypes.Blightrot_Cauldron, "Blightrot Cauldron" },                                                  // Blightrot Cauldron
		{ RelicTypes.Calm_Ghost_11, "Calm Ghost 11" },                                                            // Ghost of a Defeated Viceroy
		{ RelicTypes.Calm_Ghost_12, "Calm Ghost 12" },                                                            // Ghost of a Druid
		{ RelicTypes.Calm_Ghost_13, "Calm Ghost 13" },                                                            // Ghost of a Royal Gardener
		{ RelicTypes.Calm_Ghost_22, "Calm Ghost 22" },                                                            // Ghost of a Hooded Knight
		{ RelicTypes.Calm_Ghost_23, "Calm Ghost 23" },                                                            // Ghost of a Fire Priest
		{ RelicTypes.Calm_Ghost_25, "Calm Ghost 25" },                                                            // Ghost of a Treasure Hunter
		{ RelicTypes.Calm_Ghost_26, "Calm Ghost 26" },                                                            // Ghost of a Royal Architect
		{ RelicTypes.Calm_Ghost_27, "Calm Ghost 27" },                                                            // Ghost of a Worried Carter
		{ RelicTypes.Calm_Ghost_28, "Calm Ghost 28" },                                                            // Ghost of a Storm Victim
		{ RelicTypes.Calm_Ghost_29, "Calm Ghost 29" },                                                            // Ghost of a Mourning Harpy
		{ RelicTypes.Calm_Ghost_3, "Calm Ghost 3" },                                                              // Ghost of a Terrified Woodcutter
		{ RelicTypes.Calm_Ghost_30, "Calm Ghost 30" },                                                            // Ghost of a Lizard General
		{ RelicTypes.Calm_Ghost_33, "Calm Ghost 33" },                                                            // Ghost of an Old Merchant
		{ RelicTypes.Calm_Ghost_35, "Calm Ghost 35" },                                                            // Ghost of a Fox Elder
		{ RelicTypes.Calm_Ghost_36, "Calm Ghost 36" },                                                            // Ghost of a Teadoctor
		{ RelicTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                              // Ghost of a Troublemaker
		{ RelicTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                              // Ghost of a Fallen Newcomer
		{ RelicTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                    // Ghost Chest
		{ RelicTypes.Camp_T1, "Camp_T1" },                                                                        // Small Encampment
		{ RelicTypes.Camp_T2, "Camp_T2" },                                                                        // Large Encampment
		{ RelicTypes.Caravan_T1, "Caravan_T1" },                                                                  // Small Destroyed Caravan
		{ RelicTypes.Caravan_T2, "Caravan_T2" },                                                                  // Large Destroyed Caravan
		{ RelicTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                    // Corrupted Caravan
		{ RelicTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                    // Clay Deposit (Large)
		{ RelicTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                                // Clay Deposit (Small)
		{ RelicTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                                    // Dewberry Bush (Large)
		{ RelicTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                                // Dewberry Bush (Small)
		{ RelicTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                                    // Flax Field (Large)
		{ RelicTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                                // Flax Field (Small)
		{ RelicTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                                  // Herb Node (Large)
		{ RelicTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                              // Herb Node (Small)
		{ RelicTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                            // Leech Broodmother (Large)
		{ RelicTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                        // Leech Broodmother (Small)
		{ RelicTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },                  // Ancient Proto Wheat
		{ RelicTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },                    // Dead Leviathan
		{ RelicTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },            // Giant Proto Fungus
		{ RelicTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                        // Grasscap Mushrooms (Large)
		{ RelicTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },                    // Grasscap Mushrooms (Small)
		{ RelicTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                                    // Moss Broccoli Patch (Large)
		{ RelicTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                                // Moss Broccoli Patch (Small)
		{ RelicTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                            // Grasscap Mushrooms (Large)
		{ RelicTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                        // Grasscap Mushrooms (Small)
		{ RelicTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                                    // Reed Field (Large)
		{ RelicTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                                // Reed Field (Small)
		{ RelicTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                  // Root Deposit (Large)
		{ RelicTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                              // Root Deposit (Small)
		{ RelicTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                          // Sea Marrow Deposit (Large)
		{ RelicTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                      // Sea Marrow Deposit (Small)
		{ RelicTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                            // Slickshell Broodmother (Large)
		{ RelicTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                        // Slickshell Broodmother (Small)
		{ RelicTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                          // Snake Nest (Large)
		{ RelicTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                      // Snake Nest (Small)
		{ RelicTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                  // Stone Deposit (Large)
		{ RelicTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                              // Stone Deposit (Small)
		{ RelicTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                                  // Drizzlewing Nest (Large)
		{ RelicTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                              // Drizzlewing Nest (Small)
		{ RelicTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                        // Swamp Wheat Field (Large)
		{ RelicTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                                    // Swamp Wheat Field (Small)
		{ RelicTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                                // Wormtongue Nest (Large)
		{ RelicTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                            // Wormtongue Nest (Small)
		{ RelicTypes.Decay_Altar, "Decay Altar" },                                                                // Altar of Decay
		{ RelicTypes.Escaped_Convicts, "Escaped Convicts" },                                                      // Escaped Convicts
		{ RelicTypes.Fishmen_Cave, "Fishmen Cave" },                                                              // Fishmen Cave
		{ RelicTypes.Fishmen_Lighthouse, "Fishmen Lighthouse" },                                                  // Fishmen Lighthouse
		{ RelicTypes.Fishmen_Outpost, "Fishmen Outpost" },                                                        // Fishmen Outpost
		{ RelicTypes.Fishmen_Soothsayer, "Fishmen Soothsayer" },                                                  // Fishman Soothsayer
		{ RelicTypes.Fishmen_Totem, "Fishmen Totem" },                                                            // Fishmen Totem
		{ RelicTypes.ForsakenCrypt, "ForsakenCrypt" },                                                            // Forsaken Crypt
		{ RelicTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                                  // Fallen Fox Scouts
		{ RelicTypes.Fuming_Machinery, "Fuming Machinery" },                                                      // Fuming Machinery
		{ RelicTypes.Giant_Stormbird, "Giant Stormbird" },                                                        // Giant Stormbird's Nest
		{ RelicTypes.Glade_Trader___The_Hermit, "Glade Trader - The Hermit" },                                    // Wandering Merchant - Hermit
		{ RelicTypes.Glade_Trader___The_Seer, "Glade Trader - The Seer" },                                        // Wandering Merchant - Seer
		{ RelicTypes.Glade_Trader___The_Shaman, "Glade Trader - The Shaman" },                                    // Wandering Merchant - Shaman
		{ RelicTypes.Gold_Stag, "Gold Stag" },                                                                    // Golden Treasure Stag
		{ RelicTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                  // Golden Treasure Stag
		{ RelicTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                              // Harmony Spirit Altar
		{ RelicTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                              // Fallen Harpy Scientists
		{ RelicTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                                // Haunted Beaver House
		{ RelicTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                          // Haunted Brewery
		{ RelicTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                            // Haunted Cellar
		{ RelicTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                      // Haunted Cooperage
		{ RelicTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                              // Haunted Druid's Hut
		{ RelicTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                      // Haunted Fox House
		{ RelicTypes.Haunted_Ruined_Harpy_House, "Haunted Ruined Harpy House" },                                  // Haunted Harpy House
		{ RelicTypes.Haunted_Ruined_Herb_Garden, "Haunted Ruined Herb Garden" },                                  // Haunted Herb Garden
		{ RelicTypes.Haunted_Ruined_Human_House, "Haunted Ruined Human House" },                                  // Haunted Human House
		{ RelicTypes.Haunted_Ruined_Leatherworks, "Haunted Ruined Leatherworks" },                                // Haunted Leatherworker
		{ RelicTypes.Haunted_Ruined_Lizard_House, "Haunted Ruined Lizard House" },                                // Haunted Lizard House
		{ RelicTypes.Haunted_Ruined_Market, "Haunted Ruined Market" },                                            // Haunted Market
		{ RelicTypes.Haunted_Ruined_Rainmill, "Haunted Ruined Rainmill" },                                        // Haunted Rain Mill
		{ RelicTypes.Haunted_Ruined_SmallFarm, "Haunted Ruined SmallFarm" },                                      // Haunted Small Farm
		{ RelicTypes.Haunted_Ruined_Smelter, "Haunted Ruined Smelter" },                                          // Haunted Smelter
		{ RelicTypes.Haunted_Ruined_Temple, "Haunted Ruined Temple" },                                            // Haunted Temple
		{ RelicTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                              // Fallen Human Explorers
		{ RelicTypes.Infected_Mole, "Infected Mole" },                                                            // Infected Drainage Mole
		{ RelicTypes.Infected_Tree, "Infected Tree" },                                                            // Withered Tree
		{ RelicTypes.Kelpie, "Kelpie" },                                                                          // River Kelpie
		{ RelicTypes.Leaking_Cauldron, "Leaking Cauldron" },                                                      // Leaking Cauldron
		{ RelicTypes.Lightning_Catcher, "Lightning Catcher" },                                                    // Lightning Catcher
		{ RelicTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                            // Fallen Lizard Hunters
		{ RelicTypes.Merchant_Ship_Wreck, "Merchant Ship Wreck" },                                                // Merchant Shipwreck
		{ RelicTypes.Mistworm_T1, "Mistworm_T1" },                                                                // Hungry Mistworm
		{ RelicTypes.Mole, "Mole" },                                                                              // Drainage Mole
		{ RelicTypes.Monolith, "Monolith" },                                                                      // Obelisk
		{ RelicTypes.Noxious_Machinery, "Noxious Machinery" },                                                    // Noxious Machinery
		{ RelicTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                      // Petrified Tree
		{ RelicTypes.Rain_Totem, "Rain Totem" },                                                                  // Rain Spirit Totem
		{ RelicTypes.Rainpunk_Drill___Coal, "Rainpunk Drill - Coal" },                                            // Rainpunk Drill
		{ RelicTypes.Rainpunk_Drill___Copper, "Rainpunk Drill - Copper" },                                        // Rainpunk Drill
		{ RelicTypes.RainpunkFactory, "RainpunkFactory" },                                                        // Destroyed Rainpunk Foundry
		{ RelicTypes.RewardChest_T1, "RewardChest_T1" },                                                          // Small Abandoned Cache
		{ RelicTypes.RewardChest_T2, "RewardChest_T2" },                                                          // Medium Abandoned Cache
		{ RelicTypes.RewardChest_T3, "RewardChest_T3" },                                                          // Large Abandoned Cache
		{ RelicTypes.Ruined_Advanced_Rain_Catcher, "Ruined Advanced Rain Catcher" },                              // Advanced Rain Collector
		{ RelicTypes.Ruined_Advanced_Rain_Catcher_no_Reward_, "Ruined Advanced Rain Catcher (no reward)" },       // Advanced Rain Collector
		{ RelicTypes.Ruined_Alchemist, "Ruined Alchemist" },                                                      // Alchemist's Hut
		{ RelicTypes.Ruined_Alchemist_no_Reward_, "Ruined Alchemist (no reward)" },                               // Alchemist's Hut
		{ RelicTypes.Ruined_Apothecary, "Ruined Apothecary" },                                                    // Apothecary
		{ RelicTypes.Ruined_Apothecary_no_Reward_, "Ruined Apothecary (no reward)" },                             // Apothecary
		{ RelicTypes.Ruined_Artisan, "Ruined Artisan" },                                                          // Artisan
		{ RelicTypes.Ruined_Artisan_no_Reward_, "Ruined Artisan (no reward)" },                                   // Artisan
		{ RelicTypes.Ruined_Bakery, "Ruined Bakery" },                                                            // Bakery
		{ RelicTypes.Ruined_Bakery_no_Reward_, "Ruined Bakery (no reward)" },                                     // Bakery
		{ RelicTypes.Ruined_Bath_House, "Ruined Bath House" },                                                    // Bath House
		{ RelicTypes.Ruined_Bath_House_no_Reward_, "Ruined Bath House (no reward)" },                             // Bath House
		{ RelicTypes.Ruined_Beanery, "Ruined Beanery" },                                                          // Beanery
		{ RelicTypes.Ruined_Beanery_no_Reward_, "Ruined Beanery (no reward)" },                                   // Beanery
		{ RelicTypes.Ruined_Beaver_House, "Ruined Beaver House" },                                                // Beaver House
		{ RelicTypes.Ruined_Beaver_House_no_Reward_, "Ruined Beaver House (no reward)" },                         // Beaver House
		{ RelicTypes.Ruined_Big_Shelter, "Ruined Big Shelter" },                                                  // Big Shelter
		{ RelicTypes.Ruined_Big_Shelter_no_Reward_, "Ruined Big Shelter (no reward)" },                           // Big Shelter
		{ RelicTypes.Ruined_Brewery, "Ruined Brewery" },                                                          // Brewery
		{ RelicTypes.Ruined_Brewery_no_Reward_, "Ruined Brewery (no reward)" },                                   // Brewery
		{ RelicTypes.Ruined_Brick_Oven, "Ruined Brick Oven" },                                                    // Brick Oven
		{ RelicTypes.Ruined_Brick_Oven_no_Reward_, "Ruined Brick Oven (no reward)" },                             // Brick Oven
		{ RelicTypes.Ruined_Brickyard, "Ruined Brickyard" },                                                      // Brickyard
		{ RelicTypes.Ruined_Brickyard_no_Reward_, "Ruined Brickyard (no reward)" },                               // Brickyard
		{ RelicTypes.Ruined_Butcher, "Ruined Butcher" },                                                          // Butcher
		{ RelicTypes.Ruined_Butcher_no_Reward_, "Ruined Butcher (no reward)" },                                   // Butcher
		{ RelicTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                      // Carpenter
		{ RelicTypes.Ruined_Carpenter_no_Reward_, "Ruined Carpenter (no reward)" },                               // Carpenter
		{ RelicTypes.Ruined_Cellar, "Ruined Cellar" },                                                            // Cellar
		{ RelicTypes.Ruined_Cellar_no_Reward_, "Ruined Cellar (no reward)" },                                     // Cellar
		{ RelicTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                      // Clan Hall
		{ RelicTypes.Ruined_Clan_Hall_no_Reward_, "Ruined Clan Hall (no reward)" },                               // Clan Hall
		{ RelicTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                        // Clay Pit
		{ RelicTypes.Ruined_Clay_Pit_no_Reward_, "Ruined Clay Pit (no reward)" },                                 // Clay Pit
		{ RelicTypes.Ruined_Cookhouse, "Ruined Cookhouse" },                                                      // Cookhouse
		{ RelicTypes.Ruined_Cookhouse_no_Reward_, "Ruined Cookhouse (no reward)" },                               // Cookhouse
		{ RelicTypes.Ruined_Cooperage, "Ruined Cooperage" },                                                      // Cooperage
		{ RelicTypes.Ruined_Cooperage_no_Reward_, "Ruined Cooperage (no reward)" },                               // Cooperage
		{ RelicTypes.Ruined_Crude_Workstation_no_Reward_, "Ruined Crude Workstation (no reward)" },               // Crude Workstation
		{ RelicTypes.Ruined_Distillery, "Ruined Distillery" },                                                    // Distillery
		{ RelicTypes.Ruined_Distillery_no_Reward_, "Ruined Distillery (no reward)" },                             // Distillery
		{ RelicTypes.Ruined_Druid, "Ruined Druid" },                                                              // Druid's Hut
		{ RelicTypes.Ruined_Druid_no_Reward_, "Ruined Druid (no reward)" },                                       // Druid's Hut
		{ RelicTypes.Ruined_Explorers_Lodge, "Ruined Explorers Lodge" },                                          // Explorers' Lodge
		{ RelicTypes.Ruined_Explorers_Lodge_no_Reward_, "Ruined Explorers Lodge (no reward)" },                   // Explorers' Lodge
		{ RelicTypes.Ruined_Farm, "Ruined Farm" },                                                                // Homestead
		{ RelicTypes.Ruined_Farm_no_Reward_, "Ruined Farm (no reward)" },                                         // Homestead
		{ RelicTypes.Ruined_Field_Kitchen_no_Reward_, "Ruined Field Kitchen (no reward)" },                       // Field Kitchen
		{ RelicTypes.Ruined_Finesmith, "Ruined Finesmith" },                                                      // Finesmith
		{ RelicTypes.Ruined_Finesmith_no_Reward_, "Ruined Finesmith (no reward)" },                               // Finesmith
		{ RelicTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                              // Foragers' Camp
		{ RelicTypes.Ruined_Foragers_Camp_no_Reward_, "Ruined Foragers Camp (no reward)" },                       // Foragers' Camp
		{ RelicTypes.Ruined_Foragers_Camp_Primitive_no_Reward_, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp
		{ RelicTypes.Ruined_Forum, "Ruined Forum" },                                                              // Forum
		{ RelicTypes.Ruined_Forum_no_Reward_, "Ruined Forum (no reward)" },                                       // Forum
		{ RelicTypes.Ruined_Fox_House, "Ruined Fox House" },                                                      // Fox House
		{ RelicTypes.Ruined_Fox_House_no_Reward_, "Ruined Fox House (no reward)" },                               // Fox House
		{ RelicTypes.Ruined_Furnace, "Ruined Furnace" },                                                          // Furnace
		{ RelicTypes.Ruined_Furnace_no_Reward_, "Ruined Furnace (no reward)" },                                   // Furnace
		{ RelicTypes.Ruined_Granary, "Ruined Granary" },                                                          // Granary
		{ RelicTypes.Ruined_Granary_no_Reward_, "Ruined Granary (no reward)" },                                   // Granary
		{ RelicTypes.Ruined_Greenhouse, "Ruined Greenhouse" },                                                    // Greenhouse
		{ RelicTypes.Ruined_Greenhouse_no_Reward_, "Ruined Greenhouse (no reward)" },                             // Greenhouse
		{ RelicTypes.Ruined_Grill, "Ruined Grill" },                                                              // Grill
		{ RelicTypes.Ruined_Grill_no_Reward_, "Ruined Grill (no reward)" },                                       // Grill
		{ RelicTypes.Ruined_Grove, "Ruined Grove" },                                                              // Forester's Hut
		{ RelicTypes.Ruined_Grove_no_Reward_, "Ruined Grove (no reward)" },                                       // Forester's Hut
		{ RelicTypes.Ruined_Guild_House, "Ruined Guild House" },                                                  // Guild House
		{ RelicTypes.Ruined_Guild_House_no_Reward_, "Ruined Guild House (no reward)" },                           // Guild House
		{ RelicTypes.Ruined_Harpy_House, "Ruined Harpy House" },                                                  // Harpy House
		{ RelicTypes.Ruined_Harpy_House_no_Reward_, "Ruined Harpy House (no reward)" },                           // Harpy House
		{ RelicTypes.Ruined_Harvester_Camp, "Ruined Harvester Camp" },                                            // Harvesters' Camp
		{ RelicTypes.Ruined_Harvester_Camp_no_Reward_, "Ruined Harvester Camp (no reward)" },                     // Harvesters' Camp
		{ RelicTypes.Ruined_Hearth, "Ruined Hearth" },                                                            // Ancient Hearth
		{ RelicTypes.Ruined_Hearth_no_Reward_, "Ruined Hearth (no reward)" },                                     // Ancient Hearth
		{ RelicTypes.Ruined_Herb_Garden, "Ruined Herb Garden" },                                                  // Herb Garden
		{ RelicTypes.Ruined_Herb_Garden_no_Reward_, "Ruined Herb Garden (no reward)" },                           // Herb Garden
		{ RelicTypes.Ruined_Herbalist_Camp, "Ruined Herbalist Camp" },                                            // Herbalists' Camp
		{ RelicTypes.Ruined_Herbalist_Camp_no_Reward_, "Ruined Herbalist Camp (no reward)" },                     // Herbalists' Camp
		{ RelicTypes.Ruined_Herbalist_Camp_Primitive_no_Reward_, "Ruined Herbalist Camp primitive (no reward)" }, // Herbalists' Camp
		{ RelicTypes.Ruined_Human_House, "Ruined Human House" },                                                  // Human House
		{ RelicTypes.Ruined_Human_House_no_Reward_, "Ruined Human House (no reward)" },                           // Human House
		{ RelicTypes.Ruined_Kiln, "Ruined Kiln" },                                                                // Kiln
		{ RelicTypes.Ruined_Kiln_no_Reward_, "Ruined Kiln (no reward)" },                                         // Kiln
		{ RelicTypes.Ruined_Leatherworks, "Ruined Leatherworks" },                                                // Leatherworker
		{ RelicTypes.Ruined_Leatherworks_no_Reward_, "Ruined Leatherworks (no reward)" },                         // Leatherworker
		{ RelicTypes.Ruined_Lizard_House, "Ruined Lizard House" },                                                // Lizard House
		{ RelicTypes.Ruined_Lizard_House_no_Reward_, "Ruined Lizard House (no reward)" },                         // Lizard House
		{ RelicTypes.Ruined_Lumbermill, "Ruined Lumbermill" },                                                    // Lumber Mill
		{ RelicTypes.Ruined_Lumbermill_no_Reward_, "Ruined Lumbermill (no reward)" },                             // Lumber Mill
		{ RelicTypes.Ruined_Makeshift_Post_no_Reward_, "Ruined Makeshift Post (no reward)" },                     // Makeshift Post
		{ RelicTypes.Ruined_Manufatory, "Ruined Manufatory" },                                                    // Manufactory
		{ RelicTypes.Ruined_Manufatory_no_Reward_, "Ruined Manufatory (no reward)" },                             // Manufactory
		{ RelicTypes.Ruined_Market, "Ruined Market" },                                                            // Market
		{ RelicTypes.Ruined_Market_no_Reward_, "Ruined Market (no reward)" },                                     // Market
		{ RelicTypes.Ruined_Mine_no_Reward_, "Ruined Mine (no reward)" },                                         // Mine
		{ RelicTypes.Ruined_Monastery, "Ruined Monastery" },                                                      // Monastery
		{ RelicTypes.Ruined_Monastery_no_Reward_, "Ruined Monastery (no reward)" },                               // Monastery
		{ RelicTypes.Ruined_Plantation, "Ruined Plantation" },                                                    // Plantation
		{ RelicTypes.Ruined_Plantation_no_Reward_, "Ruined Plantation (no reward)" },                             // Plantation
		{ RelicTypes.Ruined_Press, "Ruined Press" },                                                              // Press
		{ RelicTypes.Ruined_Press_no_Reward_, "Ruined Press (no reward)" },                                       // Press
		{ RelicTypes.Ruined_Provisioner, "Ruined Provisioner" },                                                  // Provisioner
		{ RelicTypes.Ruined_Provisioner_no_Reward_, "Ruined Provisioner (no reward)" },                           // Provisioner
		{ RelicTypes.Ruined_Rain_Catcher_no_Reward_, "Ruined Rain Catcher (no reward)" },                         // Rain Collector
		{ RelicTypes.Ruined_Rainmill, "Ruined Rainmill" },                                                        // Rain Mill
		{ RelicTypes.Ruined_Rainmill_no_Reward_, "Ruined Rainmill (no reward)" },                                 // Rain Mill
		{ RelicTypes.Ruined_Ranch, "Ruined Ranch" },                                                              // Ranch
		{ RelicTypes.Ruined_Ranch_no_Reward_, "Ruined Ranch (no reward)" },                                       // Ranch
		{ RelicTypes.Ruined_Scribe, "Ruined Scribe" },                                                            // Scribe
		{ RelicTypes.Ruined_Scribe_no_Reward_, "Ruined Scribe (no reward)" },                                     // Scribe
		{ RelicTypes.Ruined_Sewer, "Ruined Sewer" },                                                              // Clothier
		{ RelicTypes.Ruined_Sewer_no_Reward_, "Ruined Sewer (no reward)" },                                       // Clothier
		{ RelicTypes.Ruined_Shelter, "Ruined Shelter" },                                                          // Shelter
		{ RelicTypes.Ruined_Shelter_no_Reward_, "Ruined Shelter (no reward)" },                                   // Shelter
		{ RelicTypes.Ruined_SmallFarm, "Ruined SmallFarm" },                                                      // Small Farm
		{ RelicTypes.Ruined_SmallFarm_no_Reward_, "Ruined SmallFarm (no reward)" },                               // Small Farm
		{ RelicTypes.Ruined_Smelter, "Ruined Smelter" },                                                          // Smelter
		{ RelicTypes.Ruined_Smelter_no_Reward_, "Ruined Smelter (no reward)" },                                   // Smelter
		{ RelicTypes.Ruined_Smithy, "Ruined Smithy" },                                                            // Smithy
		{ RelicTypes.Ruined_Smithy_no_Reward_, "Ruined Smithy (no reward)" },                                     // Smithy
		{ RelicTypes.Ruined_Smokehouse, "Ruined Smokehouse" },                                                    // Smokehouse
		{ RelicTypes.Ruined_Smokehouse_no_Reward_, "Ruined Smokehouse (no reward)" },                             // Smokehouse
		{ RelicTypes.Ruined_Stamping_Mill, "Ruined Stamping Mill" },                                              // Stamping Mill
		{ RelicTypes.Ruined_Stamping_Mill_no_Reward_, "Ruined Stamping Mill (no reward)" },                       // Stamping Mill
		{ RelicTypes.Ruined_Stonecutter_Camp, "Ruined Stonecutter Camp" },                                        // Stonecutters' Camp
		{ RelicTypes.Ruined_Stonecutter_Camp_no_Reward_, "Ruined Stonecutter Camp (no reward)" },                 // Stonecutters' Camp
		{ RelicTypes.Ruined_Storage, "Ruined Storage" },                                                          // Small Warehouse
		{ RelicTypes.Ruined_Storage_no_Reward_, "Ruined Storage (no reward)" },                                   // Small Warehouse
		{ RelicTypes.Ruined_Supplier, "Ruined Supplier" },                                                        // Supplier
		{ RelicTypes.Ruined_Supplier_no_Reward_, "Ruined Supplier (no reward)" },                                 // Supplier
		{ RelicTypes.Ruined_Tavern, "Ruined Tavern" },                                                            // Tavern
		{ RelicTypes.Ruined_Tavern_no_Reward_, "Ruined Tavern (no reward)" },                                     // Tavern
		{ RelicTypes.Ruined_Tea_Doctor, "Ruined Tea Doctor" },                                                    // Tea Doctor
		{ RelicTypes.Ruined_Tea_Doctor_no_Reward_, "Ruined Tea Doctor (no reward)" },                             // Tea Doctor
		{ RelicTypes.Ruined_Tea_House, "Ruined Tea House" },                                                      // Teahouse
		{ RelicTypes.Ruined_Tea_House_no_Reward_, "Ruined Tea House (no reward)" },                               // Teahouse
		{ RelicTypes.Ruined_Temple, "Ruined Temple" },                                                            // Temple
		{ RelicTypes.Ruined_Temple_no_Reward_, "Ruined Temple (no reward)" },                                     // Temple
		{ RelicTypes.Ruined_Tinctury, "Ruined Tinctury" },                                                        // Tinctury
		{ RelicTypes.Ruined_Tinctury_no_Reward_, "Ruined Tinctury (no reward)" },                                 // Tinctury
		{ RelicTypes.Ruined_Tinkerer, "Ruined Tinkerer" },                                                        // Tinkerer
		{ RelicTypes.Ruined_Tinkerer_no_Reward_, "Ruined Tinkerer (no reward)" },                                 // Tinkerer
		{ RelicTypes.Ruined_Toolshop, "Ruined Toolshop" },                                                        // Toolshop
		{ RelicTypes.Ruined_Toolshop_no_Reward_, "Ruined Toolshop (no reward)" },                                 // Toolshop
		{ RelicTypes.Ruined_Trading_Post_no_Reward_, "Ruined Trading Post (no reward)" },                         // Trading Post
		{ RelicTypes.Ruined_Trappers_Camp, "Ruined Trappers Camp" },                                              // Trappers' Camp
		{ RelicTypes.Ruined_Trappers_Camp_no_Reward_, "Ruined Trappers Camp (no reward)" },                       // Trappers' Camp
		{ RelicTypes.Ruined_Trappers_Camp_Primitive_no_Reward_, "Ruined Trappers Camp Primitive (no reward)" },   // Trappers' Camp
		{ RelicTypes.Ruined_Weaver, "Ruined Weaver" },                                                            // Weaver
		{ RelicTypes.Ruined_Weaver_no_Reward_, "Ruined Weaver (no reward)" },                                     // Weaver
		{ RelicTypes.Ruined_Woodcutters_Camp, "Ruined Woodcutters Camp" },                                        // Woodcutters' Camp
		{ RelicTypes.Ruined_Woodcutters_Camp_no_Reward_, "Ruined Woodcutters Camp (no reward)" },                 // Woodcutters' Camp
		{ RelicTypes.Ruined_Workshop, "Ruined Workshop" },                                                        // Workshop
		{ RelicTypes.Ruined_Workshop_no_Reward_, "Ruined Workshop (no reward)" },                                 // Workshop
		{ RelicTypes.Sacrifice_Totem, "Sacrifice Totem" },                                                        // Totem of Denial
		{ RelicTypes.Scorpion_1, "Scorpion 1" },                                                                  // Archaeological Discovery
		{ RelicTypes.Scorpion_2, "Scorpion 2" },                                                                  // Archaeological Excavation
		{ RelicTypes.Scorpion_3, "Scorpion 3" },                                                                  // Archaeological Reconstruction
		{ RelicTypes.SealedTomb_T1, "SealedTomb_T1" },                                                            // Open Vault
		{ RelicTypes.Snake_1, "Snake 1" },                                                                        // Archaeological Discovery
		{ RelicTypes.Snake_2, "Snake 2" },                                                                        // Archaeological Excavation
		{ RelicTypes.Snake_3, "Snake 3" },                                                                        // Archaeological Reconstruction
		{ RelicTypes.Spider_1, "Spider 1" },                                                                      // Archaeological Discovery
		{ RelicTypes.Spider_2, "Spider 2" },                                                                      // Archaeological Excavation
		{ RelicTypes.Spider_3, "Spider 3" },                                                                      // Archaeological Reconstruction
		{ RelicTypes.Termite_Burrow, "Termite Burrow" },                                                          // Stonetooth Termite Burrow
		{ RelicTypes.TI_AncientShrine_T1, "TI AncientShrine_T1" },                                                // Ancient Shrine
		{ RelicTypes.Traders_Cemetery, "Traders Cemetery" },                                                      // Hidden Trader Cemetery
		{ RelicTypes.War_Beast_Cage, "War Beast Cage" },                                                          // Destroyed Cage of the Warbeast
		{ RelicTypes.White_Stag, "White Stag" },                                                                  // Royal Treasure Stag
		{ RelicTypes.White_Treasure_Stag, "White Treasure Stag" },                                                // Royal Treasure Stag
		{ RelicTypes.Wildfire, "Wildfire" },                                                                      // Wildfire
	};
}
