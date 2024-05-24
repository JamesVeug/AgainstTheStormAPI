using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Meta;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum MetaRewardTypes
{
    Unknown = -1,
    None,
	Artifacts_10,                                                 // Artifacts
	Artifacts_15,                                                 // Artifacts
	Artifacts_20,                                                 // Artifacts
	Artifacts_5,                                                  // Artifacts
	Consumption_Control_Activation,                               // Consumption Control
	Custom_Game_Activation,                                       // Training Expedition
	Essential_Big_Shelter,                                        // Big Shelter
	Essential_Common_Hall,                                        // Clan Hall
	Essential_Crude_Workstation,                                  // Crude Workstation
	Essential_Decor_Ancient_Arch,                                 // Ancient Arch
	Essential_Decor_Ancient_Gravestone,                           // Ancient Tombstone
	Essential_Decor_Anvil,                                        // Anvil
	Essential_Decor_Barrels,                                      // Barrels
	Essential_Decor_Bonfire,                                      // Bonfire
	Essential_Decor_Cages,                                        // Cages
	Essential_Decor_Chest,                                        // Chest
	Essential_Decor_Coral,                                        // Coral Growth
	Essential_Decor_Crates,                                       // Crates
	Essential_Decor_Fence,                                        // Fence
	Essential_Decor_Fence_Corner,                                 // Fence Corner
	Essential_Decor_Fire_Shrine,                                  // Fire Shrine
	Essential_Decor_Flower_Bed,                                   // Flower Bed
	Essential_Decor_Fox_Fence,                                    // Overgrown Fence
	Essential_Decor_Fox_Fence_Corner,                             // Overgrown Fence Corner
	Essential_Decor_Gate,                                         // Gate
	Essential_Decor_Golden_Leaf,                                  // Golden Leaf Plant
	Essential_Decor_Lamp,                                         // Lamp
	Essential_Decor_Lizard_Post,                                  // Lizard Post
	Essential_Decor_Marbe_Fountain,                               // Marble Fountain
	Essential_Decor_Mushroom,                                     // Decorative Fungus
	Essential_Decor_Nightfern,                                    // Nightfern
	Essential_Decor_Pipe,                                         // Pipe
	Essential_Decor_Pipe_Cross,                                   // Pipe Cross
	Essential_Decor_Pipe_Elbow,                                   // Pipe Elbow
	Essential_Decor_Pipe_End,                                     // Pipe Ending
	Essential_Decor_Pipe_T_Cross,                                 // Pipe T-Connector
	Essential_Decor_Pipe_Valve,                                   // Valve
	Essential_Decor_Road_Sign,                                    // Road Sign
	Essential_Decor_Scarlet_Decor,                                // Thorny Reed
	Essential_Decor_Side_Barrels,                                 // Rainpunk Barrels
	Essential_Decor_Signboard,                                    // Signboard
	Essential_Decor_Tower,                                        // Wall Crossing
	Essential_Decor_Town_Board,                                   // Town Board
	Essential_Decor_Umbrella,                                     // Umbrella
	Essential_Decor_Wall,                                         // Wall
	Essential_Decor_Wall_Corner,                                  // Wall Corner
	Essential_Decor_Water_Barrels,                                // Water Barrels
	Essential_Decor_Well,                                         // Overgrown Well
	Essential_Farmfield,                                          // Farm Field
	Essential_Harvester,                                          // Harvesters' Camp
	Essential_Makeshift_Post,                                     // Makeshift Post
	Essential_Mine,                                               // Mine
	Essential_Paved_Road,                                         // Paved Road
	Essential_Primitive_Forager,                                  // Small Foragers' Camp
	Essential_Primitive_Herbalist,                                // Small Herbalists' Camp
	Essential_Primitive_Trapper,                                  // Small Trappers' Camp
	Essential_Reinforced_Road,                                    // Reinforced Road
	Essential_Shelter,                                            // Shelter
	Essential_Small_Hearth,                                       // Small Hearth
	Essential_Stonecutter,                                        // Stonecutters' Camp
	Essential_Storage,                                            // Small Warehouse
	Essential_Temporary_Hearth,                                   // Small Hearth
	Essential_Trading_Post,                                       // Trading Post
	Essential_Woodcutters_Camp,                                   // Woodcutters' Camp
	Food_Stockpiles_10,                                           // Food Stockpiles
	Food_Stockpiles_15,                                           // Food Stockpiles
	Food_Stockpiles_20,                                           // Food Stockpiles
	Food_Stockpiles_25,                                           // Food Stockpiles
	Food_Stockpiles_30,                                           // Food Stockpiles
	Food_Stockpiles_5,                                            // Food Stockpiles
	Goals_Exp_Reward___Regular,                                   // Honor Badge
	House_Upgrades_Unlock___Beavers,                              // House Upgrades - Beavers
	House_Upgrades_Unlock___Foxes,                                // House Upgrades - Foxes
	House_Upgrades_Unlock___Harpies,                              // House Upgrades - Harpies
	House_Upgrades_Unlock___Humans,                               // House Upgrades - Humans
	House_Upgrades_Unlock___Lizards,                              // House Upgrades - Lizards
	Ironman_Activation,                                           // Queen's Hand Trial
	Machinery_10,                                                 // Machinery
	Machinery_15,                                                 // Machinery
	Machinery_20,                                                 // Machinery
	Machinery_25,                                                 // Machinery
	Machinery_5,                                                  // Machinery
	Meta_Foxes_Unlock,                                            // Fox
	Meta_Harpies_Unlock,                                          // Harpy
	Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse,           // Dual Carriage System
	Meta_Perk_Unlock_Accidental_Barrels,                          // Over-Diligent Woodworkers
	Meta_Perk_Unlock_Alarm_Bells,                                 // Alarm Bells
	Meta_Perk_Unlock_Amber_For_Newcomers,                         // Stormwalker Tax
	Meta_Perk_Unlock_Amber_For_Trade_Routes,                      // Deep Pockets
	Meta_Perk_Unlock_Amber_For_Trader_Visit,                      // Bed and Breakfast
	Meta_Perk_Unlock_Amber_For_Water,                             // Counterfeit Amber
	Meta_Perk_Unlock_Amber_For_Wood,                              // Lumber Tax
	Meta_Perk_Unlock_Back_To_Nature,                              // Back to Nature
	Meta_Perk_Unlock_Cache_Rewards_For_Nodes,                     // Reckless Plunder
	Meta_Perk_Unlock_Coal_For_Cyst,                               // Burnt to a Crisp
	Meta_Perk_Unlock_Consumption_Control_For_Extra_Production,    // Without Restrictions
	Meta_Perk_Unlock_Copper_For_Each_Tree,                        // Copper Extractor
	Meta_Perk_Unlock_Corruption_Per_Removed_Cyst__50,             // Firekeeper's Armor
	Meta_Perk_Unlock_Crystaline_Water,                            // Small Distillery
	Meta_Perk_Unlock_Eggs_For_Cysts,                              // Blightrot Pruner
	Meta_Perk_Unlock_Exploring_Expedition,                        // Exploration Expedition
	Meta_Perk_Unlock_Extra_Prod_For_Consumption,                  // Worker's Rations
	Meta_Perk_Unlock_Extra_Trader_Merch,                          // Guild Catalogue
	Meta_Perk_Unlock_Fedora_Hat,                                  // Old Fedora Hat
	Meta_Perk_Unlock_Forge_Trip_Hammer,                           // Forge Trip Hammer
	Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses,              // Hauling Cart
	Meta_Perk_Unlock_Hostility_For_Relics,                        // Frequent Patrols
	Meta_Perk_Unlock_Hostility_For_Removed_Cysts,                 // Baptism of Fire
	Meta_Perk_Unlock_Hostility_For_Water,                         // Calming Water
	Meta_Perk_Unlock_Houses_Global_Capacity_Plus1,                // Crowded Houses
	Meta_Perk_Unlock_HP_For_Impatience,                           // Queen's Gift
	Meta_Perk_Unlock_Hubs_For_Hostility,                          // Safe Haven
	Meta_Perk_Unlock_Insect_For_Tree,                             // Woodpecker Technique
	Meta_Perk_Unlock_LessHostilityPerWoodcutter,                  // Flame Amulets
	Meta_Perk_Unlock_Lower_Hostility_For_Religion,                // Firelink Ritual
	Meta_Perk_Unlock_Mist_Piercers,                               // Mist Piercers
	Meta_Perk_Unlock_Mold_Grain,                                  // Moldy Grain Seeds
	Meta_Perk_Unlock_More_Amber_From_Routes,                      // Trade Negotiations
	Meta_Perk_Unlock_More_Node_Charges,                           // Rich Glades
	Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes,              // Economic Migration
	Meta_Perk_Unlock_Overexploitation,                            // Overexploitation
	Meta_Perk_Unlock_Parts_For_Trade,                             // Free Samples
	Meta_Perk_Unlock_Porridge_Prod_For_Water,                     // Filling Dish
	Meta_Perk_Unlock_Relic_Time_Reduction,                        // Firekeeper's Prayer
	Meta_Perk_Unlock_Reputation_From_Trade,                       // Trade Hub
	Meta_Perk_Unlock_Resolve_For_Chests,                          // Prosperous Archaeology
	Meta_Perk_Unlock_Resolve_For_Consumption,                     // Generous Rations
	Meta_Perk_Unlock_Resolve_For_Impatience,                      // Rebellious Spirit
	Meta_Perk_Unlock_Resolve_For_Sales,                           // Prosperous Settlement
	Meta_Perk_Unlock_Resolve_For_Standing,                        // Friendly Relations
	Meta_Perk_Unlock_Resolve_For_Started_Route,                   // Frequent Caravans
	Meta_Perk_Unlock_Route_Less_Travel_Time,                      // Stormwalker Training
	Meta_Perk_Unlock_Royal_Guard_Training,                        // Royal Guard Training
	Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience,               // Fiery Wrath
	Meta_Perk_Unlock_Tools_For_Death,                             // Bone Tools
	Meta_Perk_Unlock_Tools_For_Glade_For_Resolve,                 // Improvised Tools
	Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel,                     // Tightened Belt
	Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots,              // Urban Planning
	Meta_Perk_Unlock_Trading_Packs,                               // Trade Logs
	Meta_Perk_Unlock_VillagerDeathEffectBlock,                    // Hidden from the Queen
	Meta_Perk_Unlock_Villagers_For_Corruption,                    // From the Shadows
	Meta_Perk_Unlock_Wildcard,                                    // Smuggler's Visit
	Meta_Perk_Unlock_Wood_Plus2_For_Insects,                      // No Quality Control
	Meta_Perk_Unlock_Working_Time_For_Firekeeper,                 // Prayer Book
	Meta_Reward_Advanced_Rain_Collector,                          // Advanced Rain Collector
	Meta_Reward_Alchemist_Hut,                                    // Alchemist's Hut
	Meta_Reward_Apothecary,                                       // Apothecary
	Meta_Reward_Artisan,                                          // Artisan
	Meta_Reward_Bakery,                                           // Bakery
	Meta_Reward_Bath_House,                                       // Bath House
	Meta_Reward_Beanery,                                          // Beanery
	Meta_Reward_Beaver_House,                                     // Beaver House
	Meta_Reward_Big_Shelter,                                      // Big Shelter
	Meta_Reward_Blight_Post_Upgrades_Unlock,                      // Blight Post Upgrades
	Meta_Reward_Bonus_Yield,                                      // Unforeseen Riches
	Meta_Reward_Brewery,                                          // Brewery
	Meta_Reward_Brick_Oven,                                       // Brick Oven
	Meta_Reward_Brickyard,                                        // Brickyard
	Meta_Reward_Building_Storage,                                 // Larger Storage
	Meta_Reward_Burning_Duration,                                 // Everlasting Flames
	Meta_Reward_Butcher,                                          // Butcher
	Meta_Reward_Caravan_Goods,                                    // Stocked Caravans
	Meta_Reward_Caravan_Slot,                                     // Additional Caravan Choice
	Meta_Reward_Carpenter,                                        // Carpenter
	Meta_Reward_Cellar,                                           // Cellar
	Meta_Reward_Citadel_Home_Unlock,                              // Viceroy's Quarters
	Meta_Reward_Clan_Hall,                                        // Clan Hall
	Meta_Reward_Clay_Pit,                                         // Clay Pit
	Meta_Reward_Clothier,                                         // Clothier
	Meta_Reward_Cookhouse,                                        // Cookhouse
	Meta_Reward_Cooperage,                                        // Cooperage
	Meta_Reward_Cornerstone,                                      // Additional Cornerstone Choice
	Meta_Reward_Cornerstone_Reroll,                               // Cornerstone Reroll Charge
	Meta_Reward_Crude_Workstation,                                // Crude Workstation
	Meta_Reward_Daily_Challenge,                                  // Daily Expedition
	Meta_Reward_Decor_Ancient_Arch,                               // Ancient Arch
	Meta_Reward_Decor_Ancient_Gravestone,                         // Ancient Tombstone
	Meta_Reward_Decor_Bank,                                       // Bench
	Meta_Reward_Decor_Barrels,                                    // Barrels
	Meta_Reward_Decor_Bush,                                       // Bush
	Meta_Reward_Decor_Coral,                                      // Coral Growth
	Meta_Reward_Decor_Crates,                                     // Crates
	Meta_Reward_Decor_Fence,                                      // Fence
	Meta_Reward_Decor_Fence_Corner,                               // Fence Corner
	Meta_Reward_Decor_Fire_Shrine,                                // Fire Shrine
	Meta_Reward_Decor_Flower_Bed,                                 // Flower Bed
	Meta_Reward_Decor_Gate,                                       // Gate
	Meta_Reward_Decor_Golden_Leaf,                                // Golden Leaf Plant
	Meta_Reward_Decor_Lamp,                                       // Lamp
	Meta_Reward_Decor_Lizard_Post,                                // Lizard Post
	Meta_Reward_Decor_Mushroom,                                   // Decorative Fungus
	Meta_Reward_Decor_Nightfern,                                  // Nightfern
	Meta_Reward_Decor_Rainpunk_Barrels,                           // Water Barrels
	Meta_Reward_Decor_Road_Sign,                                  // Road Sign
	Meta_Reward_Decor_Side_Barrels,                               // Rainpunk Barrels
	Meta_Reward_Decor_Signboard,                                  // Signboard
	Meta_Reward_Decor_Tower,                                      // Wall Crossing
	Meta_Reward_Decor_Umbrella,                                   // Umbrella
	Meta_Reward_Decor_Wall,                                       // Wall
	Meta_Reward_Distillery,                                       // Distillery
	Meta_Reward_Druid,                                            // Druid's Hut
	Meta_Reward_Embark_Blueprint_Forager,                         // Embarkation Bonus: Foragers' Camp
	Meta_Reward_Embark_Blueprint_Herb_Garden,                     // Embarkation Bonus: Herb Garden
	Meta_Reward_Embark_Blueprint_Herbalist,                       // Embarkation Bonus: Herbalists' Camp
	Meta_Reward_Embark_Blueprint_Plantation,                      // Embarkation Bonus: Plantation
	Meta_Reward_Embark_Blueprint_Small_Farm,                      // Embarkation Bonus: Small Farm
	Meta_Reward_Embark_Blueprint_Trapper,                         // Embarkation Bonus: Trappers' Camp
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
	Meta_Reward_Embark_Perk_Ale_3pm,                              // Embarkation Bonus: Ale Delivery Line
	Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1,             // Embarkation Bonus: Royal Permit
	Meta_Reward_Embark_Perk_Cosmetics_3pm,                        // Embarkation Bonus: Tea Delivery Line
	Meta_Reward_Embark_Perk_Incense_3pm,                          // Embarkation Bonus: Incense Delivery Line
	Meta_Reward_Embark_Perk_Scrolls_3pm,                          // Embarkation Bonus: Scroll Delivery Line
	Meta_Reward_Embark_Perk_Training_Gear_3pm,                    // Embarkation Bonus: Training Gear Delivery Line
	Meta_Reward_Embark_Perk_Wine_3pm,                             // Embarkation Bonus: Wine Delivery Line
	Meta_Reward_Embark_Point,                                     // Embarkation Points
	Meta_Reward_Embark_Range,                                     // Greater Embarkation Range
	Meta_Reward_Embark_Villagers,                                 // Embarkation Bonus: Villagers
	Meta_Reward_Essential_Beaver_House,                           // Essential Blueprint: Beaver House
	Meta_Reward_Essential_Field_Kitchen,                          // Essential Blueprint: Field Kitchen
	Meta_Reward_Essential_Fox_House,                              // Essential Blueprint: Fox House
	Meta_Reward_Essential_Harpy_House,                            // Essential Blueprint: Harpy House
	Meta_Reward_Essential_Human_House,                            // Essential Blueprint: Human House
	Meta_Reward_Essential_Lizard_House,                           // Essential Blueprint: Lizard House
	Meta_Reward_Essential_Rain_Collector,                         // Rain Collector
	Meta_Reward_Explorers_Lodge,                                  // Explorers' Lodge
	Meta_Reward_Faction_Blue,                                     // Vanguard of the Stolen Keys
	Meta_Reward_Faction_Green,                                    // First Dawn Company
	Meta_Reward_Faction_Orange,                                   // Brass Order
	Meta_Reward_Farm_Range,                                       // Farm Range Increase
	Meta_Reward_Finesmith,                                        // Finesmith
	Meta_Reward_Foragers_Camp,                                    // Foragers' Camp
	Meta_Reward_Forum,                                            // Forum
	Meta_Reward_Fox_House,                                        // Fox House
	Meta_Reward_Furnace,                                          // Furnace
	Meta_Reward_Global_Capacity,                                  // Worker Capacity Increase
	Meta_Reward_Goals_Unlock,                                     // Obsidian Archive
	Meta_Reward_Grace_Period,                                     // Last Stand
	Meta_Reward_Granary,                                          // Granary
	Meta_Reward_Greenhouse,                                       // Greenhouse
	Meta_Reward_Grill,                                            // Grill
	Meta_Reward_Grove,                                            // Forester's Hut
	Meta_Reward_Guaranteed_Bricks, 
	Meta_Reward_Guaranteed_Fabric, 
	Meta_Reward_Guaranteed_Pipes, 
	Meta_Reward_Guaranteed_Planks, 
	Meta_Reward_Guild_House,                                      // Guild House
	Meta_Reward_Haulers___Main_Storage,                           // Haulers - Main Warehouse
	Meta_Reward_Haulers___Secondary_Storage,                      // Haulers - Small Warehouse
	Meta_Reward_Hearth,                                           // Small Hearth
	Meta_Reward_Herb_Garden,                                      // Herb Garden
	Meta_Reward_Herbalist_Camp,                                   // Herbalists' Camp
	Meta_Reward_Home_Decor___Ancient_Artifact,                    // Ancient Artifact
	Meta_Reward_Home_Decor___Domesticated_Sea_Tiger,              // Domesticated Sea Tiger
	Meta_Reward_Home_Decor___Dueling_Umbrella,                    // Dueling Umbrella
	Meta_Reward_Home_Decor___Fishman_Skull,                       // Fishman Skull
	Meta_Reward_Home_Decor___Ibex_Rug,                            // Ibex Rug
	Meta_Reward_Home_Decor___Inscribed_Slab,                      // Inscribed Slab
	Meta_Reward_Home_Decor___Landscape_Painting,                  // Landscape Painting
	Meta_Reward_Home_Decor___Marshglow_Fungite,                   // Marshglow Fungite
	Meta_Reward_Home_Decor___Mole_Trophy,                         // Mole Trophy
	Meta_Reward_Home_Decor___Painting_Of_The_Ancient_Hearth,      // Painting of the Ancient Hearth
	Meta_Reward_Home_Decor___Plate_Of_Food,                       // Plate of Food
	Meta_Reward_Home_Decor___Reefbloom,                           // Reefbloom
	Meta_Reward_Home_Decor___Rosevine,                            // Rosevine
	Meta_Reward_Home_Decor___Sparkdew_Crystal,                    // Sparkdew Crystal
	Meta_Reward_Home_Decor___Storm_Orb,                           // Storm Orb
	Meta_Reward_Home_Decor___The_Sparkcaster,                     // The Sparkcaster
	Meta_Reward_Home_Decor___Trade_Contract,                      // Trade Contract
	Meta_Reward_Home_Decor___Uniform_0___Standard_Uniform,        // Standard Uniform
	Meta_Reward_Home_Decor___Uniform_1___Settlers_Mask,           // Settler's Mask
	Meta_Reward_Home_Decor___Uniform_2___Pioneers_Mantle,         // Pioneer's Mantle
	Meta_Reward_Home_Decor___Uniform_3___Veterans_Shoulder_Guard, // Veteran's Shoulder Guard
	Meta_Reward_Home_Decor___Uniform_4___Viceroys_Cape,           // Viceroy's Cape
	Meta_Reward_Home_Decor___Uniform_5___Decorated_Belt,          // Decorated Belt
	Meta_Reward_Home_Decor___Uniform_6___Royal_Visage,            // Royal Visage
	Meta_Reward_Home_Decor___Uniform_7___Stormshroud_Attire,      // Stormshroud Attire
	Meta_Reward_Home_Decor___Uniform_8___Crimson_Cloak,           // Crimson Cloak
	Meta_Reward_Home_Decor___Uniform_9___Queens_Hand_Pauldron,    // Queen's Hand Pauldron
	Meta_Reward_Homestead,                                        // Homestead
	Meta_Reward_Hub_Tier_1,                                       // Hearth Upgrade - Neighborhood
	Meta_Reward_Hub_Tier_2,                                       // Hearth Upgrade - District
	Meta_Reward_Human_House,                                      // Human House
	Meta_Reward_Impatience,                                       // Queen's Patience
	Meta_Reward_Kiln,                                             // Kiln
	Meta_Reward_Lizard_House,                                     // Lizard House
	Meta_Reward_Lumbermill,                                       // Lumber Mill
	Meta_Reward_Manufactory,                                      // Manufactory
	Meta_Reward_Market,                                           // Market
	Meta_Reward_Meta_Resources,                                   // More Citadel Resources
	Meta_Reward_Mine,                                             // Mine
	Meta_Reward_Mine_Upgrade_Unlock,                              // Mine Upgrades
	Meta_Reward_Monastery,                                        // Monastery
	Meta_Reward_Newcomer_Goods,                                   // Newcomer Gifts
	Meta_Reward_Node_Charges,                                     // Gathering Technique
	Meta_Reward_Passive_Beavers,                                  // Starting Ability - Beavers
	Meta_Reward_Passive_Foxes,                                    // Starting Ability - Foxes
	Meta_Reward_Passive_Harpies,                                  // Starting Ability - Harpies
	Meta_Reward_Passive_Humans,                                   // Starting Ability - Humans
	Meta_Reward_Passive_Lizards,                                  // Starting Ability - Lizards
	Meta_Reward_Paved_Road,                                       // Paved Road
	Meta_Reward_Plantation,                                       // Plantation
	Meta_Reward_Press,                                            // Press
	Meta_Reward_Prod_Speed,                                       // Production Speed Increase
	Meta_Reward_Provisioner,                                      // Provisioner
	Meta_Reward_Rain_Mill,                                        // Rain Mill
	Meta_Reward_Rainpunk_Activation,                              // Rainpunk Engines
	Meta_Reward_Rainpunk_Foundry,                                 // Rainpunk Foundry
	Meta_Reward_Ranch,                                            // Ranch
	Meta_Reward_Reputation_Reward_Pick,                           // Additional Blueprint Choice
	Meta_Reward_Reshuffle,                                        // Blueprint Reroll
	Meta_Reward_Sacrifice_Cost,                                   // Sacrificial Flames
	Meta_Reward_Scribe,                                           // Scribe
	Meta_Reward_Sewer,                                            // Clothier
	Meta_Reward_Smelter,                                          // Smelter
	Meta_Reward_Smithy,                                           // Smithy
	Meta_Reward_Smokehouse,                                       // Smokehouse
	Meta_Reward_Stamping_Mill,                                    // Stamping Mill
	Meta_Reward_Storage,                                          // Main Warehouse
	Meta_Reward_Supplier,                                         // Supplier
	Meta_Reward_Tavern,                                           // Tavern
	Meta_Reward_Tea_Doctor,                                       // Tea Doctor
	Meta_Reward_Tea_House,                                        // Teahouse
	Meta_Reward_Temple,                                           // Temple
	Meta_Reward_Tinctury,                                         // Tinctury
	Meta_Reward_Tinkerer,                                         // Tinkerer
	Meta_Reward_Toolshop,                                         // Toolshop
	Meta_Reward_Town_Vision,                                      // Increased Town Vision Range
	Meta_Reward_Trade_Routes_Limit,                               // More Trade Routes
	Meta_Reward_Trader_Arrival,                                   // Quicker Trader Arrival
	Meta_Reward_Trader_Merch,                                     // Extra Merchandise
	Meta_Reward_Trader_Perk_Discount,                             // Special Discount
	Meta_Reward_Villager_Speed,                                   // Villager Speed Increase
	Meta_Reward_Weaver,                                           // Weaver
	Meta_Reward_Workshop,                                         // Workshop
	Meta_Trader_Unlock_A,                                         // Zhorg
	Meta_Trader_Unlock_B,                                         // Old Farluf
	Meta_Trader_Unlock_C,                                         // Sothur The Ancient
	Meta_Trader_Unlock_D,                                         // Vliss Greybone
	Meta_Trader_Unlock_E,                                         // Sir Renwald Redmane
	Meta_Trader_Unlock_F,                                         // Xiadani Stormfeather
	Meta_Trader_Unlock_G,                                         // Dullahan Warlander
	Timed_Orders_Activation,                                      // Timed Orders
	Trade_Routes_Activation,                                      // Trade Routes

    MAX = 360
}

public static class MetaRewardTypesExtensions
{
	public static string ToName(this MetaRewardTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of MetaRewardTypes: " + type);
		return TypeToInternalName[MetaRewardTypes.Artifacts_10];
	}
	
	public static MetaRewardModel ToMetaRewardModel(this string name)
    {
        MetaRewardModel model = SO.Settings.metaRewards.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find MetaRewardModel for MetaRewardTypes with name: " + name);
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
            string elementName = element.ToName();
            array[i++] = SO.Settings.metaRewards.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<MetaRewardTypes, string> TypeToInternalName = new()
	{
		{ MetaRewardTypes.Artifacts_10, "Artifacts 10" },                                                                                                  // Artifacts
		{ MetaRewardTypes.Artifacts_15, "Artifacts 15" },                                                                                                  // Artifacts
		{ MetaRewardTypes.Artifacts_20, "Artifacts 20" },                                                                                                  // Artifacts
		{ MetaRewardTypes.Artifacts_5, "Artifacts 5" },                                                                                                    // Artifacts
		{ MetaRewardTypes.Consumption_Control_Activation, "Consumption Control Activation" },                                                              // Consumption Control
		{ MetaRewardTypes.Custom_Game_Activation, "Custom Game Activation" },                                                                              // Training Expedition
		{ MetaRewardTypes.Essential_Big_Shelter, "Essential Big Shelter" },                                                                                // Big Shelter
		{ MetaRewardTypes.Essential_Common_Hall, "Essential Common Hall" },                                                                                // Clan Hall
		{ MetaRewardTypes.Essential_Crude_Workstation, "Essential Crude Workstation" },                                                                    // Crude Workstation
		{ MetaRewardTypes.Essential_Decor_Ancient_Arch, "Essential Decor Ancient Arch" },                                                                  // Ancient Arch
		{ MetaRewardTypes.Essential_Decor_Ancient_Gravestone, "Essential Decor Ancient Gravestone" },                                                      // Ancient Tombstone
		{ MetaRewardTypes.Essential_Decor_Anvil, "Essential Decor Anvil" },                                                                                // Anvil
		{ MetaRewardTypes.Essential_Decor_Barrels, "Essential Decor Barrels" },                                                                            // Barrels
		{ MetaRewardTypes.Essential_Decor_Bonfire, "Essential Decor Bonfire" },                                                                            // Bonfire
		{ MetaRewardTypes.Essential_Decor_Cages, "Essential Decor Cages" },                                                                                // Cages
		{ MetaRewardTypes.Essential_Decor_Chest, "Essential Decor Chest" },                                                                                // Chest
		{ MetaRewardTypes.Essential_Decor_Coral, "Essential Decor Coral" },                                                                                // Coral Growth
		{ MetaRewardTypes.Essential_Decor_Crates, "Essential Decor Crates" },                                                                              // Crates
		{ MetaRewardTypes.Essential_Decor_Fence, "Essential Decor Fence" },                                                                                // Fence
		{ MetaRewardTypes.Essential_Decor_Fence_Corner, "Essential Decor Fence Corner" },                                                                  // Fence Corner
		{ MetaRewardTypes.Essential_Decor_Fire_Shrine, "Essential Decor Fire Shrine" },                                                                    // Fire Shrine
		{ MetaRewardTypes.Essential_Decor_Flower_Bed, "Essential Decor Flower Bed" },                                                                      // Flower Bed
		{ MetaRewardTypes.Essential_Decor_Fox_Fence, "Essential Decor Fox Fence" },                                                                        // Overgrown Fence
		{ MetaRewardTypes.Essential_Decor_Fox_Fence_Corner, "Essential Decor Fox Fence Corner" },                                                          // Overgrown Fence Corner
		{ MetaRewardTypes.Essential_Decor_Gate, "Essential Decor Gate" },                                                                                  // Gate
		{ MetaRewardTypes.Essential_Decor_Golden_Leaf, "Essential Decor Golden Leaf" },                                                                    // Golden Leaf Plant
		{ MetaRewardTypes.Essential_Decor_Lamp, "Essential Decor Lamp" },                                                                                  // Lamp
		{ MetaRewardTypes.Essential_Decor_Lizard_Post, "Essential Decor Lizard Post" },                                                                    // Lizard Post
		{ MetaRewardTypes.Essential_Decor_Marbe_Fountain, "Essential Decor Marbe Fountain" },                                                              // Marble Fountain
		{ MetaRewardTypes.Essential_Decor_Mushroom, "Essential Decor Mushroom" },                                                                          // Decorative Fungus
		{ MetaRewardTypes.Essential_Decor_Nightfern, "Essential Decor Nightfern" },                                                                        // Nightfern
		{ MetaRewardTypes.Essential_Decor_Pipe, "Essential Decor Pipe" },                                                                                  // Pipe
		{ MetaRewardTypes.Essential_Decor_Pipe_Cross, "Essential Decor Pipe Cross" },                                                                      // Pipe Cross
		{ MetaRewardTypes.Essential_Decor_Pipe_Elbow, "Essential Decor Pipe Elbow" },                                                                      // Pipe Elbow
		{ MetaRewardTypes.Essential_Decor_Pipe_End, "Essential Decor Pipe End" },                                                                          // Pipe Ending
		{ MetaRewardTypes.Essential_Decor_Pipe_T_Cross, "Essential Decor Pipe T Cross" },                                                                  // Pipe T-Connector
		{ MetaRewardTypes.Essential_Decor_Pipe_Valve, "Essential Decor Pipe Valve" },                                                                      // Valve
		{ MetaRewardTypes.Essential_Decor_Road_Sign, "Essential Decor Road Sign" },                                                                        // Road Sign
		{ MetaRewardTypes.Essential_Decor_Scarlet_Decor, "Essential Decor Scarlet Decor" },                                                                // Thorny Reed
		{ MetaRewardTypes.Essential_Decor_Side_Barrels, "Essential Decor Side Barrels" },                                                                  // Rainpunk Barrels
		{ MetaRewardTypes.Essential_Decor_Signboard, "Essential Decor Signboard" },                                                                        // Signboard
		{ MetaRewardTypes.Essential_Decor_Tower, "Essential Decor Tower" },                                                                                // Wall Crossing
		{ MetaRewardTypes.Essential_Decor_Town_Board, "Essential Decor Town Board" },                                                                      // Town Board
		{ MetaRewardTypes.Essential_Decor_Umbrella, "Essential Decor Umbrella" },                                                                          // Umbrella
		{ MetaRewardTypes.Essential_Decor_Wall, "Essential Decor Wall" },                                                                                  // Wall
		{ MetaRewardTypes.Essential_Decor_Wall_Corner, "Essential Decor Wall Corner" },                                                                    // Wall Corner
		{ MetaRewardTypes.Essential_Decor_Water_Barrels, "Essential Decor Water Barrels" },                                                                // Water Barrels
		{ MetaRewardTypes.Essential_Decor_Well, "Essential Decor Well" },                                                                                  // Overgrown Well
		{ MetaRewardTypes.Essential_Farmfield, "Essential Farmfield" },                                                                                    // Farm Field
		{ MetaRewardTypes.Essential_Harvester, "Essential Harvester" },                                                                                    // Harvesters' Camp
		{ MetaRewardTypes.Essential_Makeshift_Post, "Essential Makeshift Post" },                                                                          // Makeshift Post
		{ MetaRewardTypes.Essential_Mine, "Essential Mine" },                                                                                              // Mine
		{ MetaRewardTypes.Essential_Paved_Road, "Essential Paved Road" },                                                                                  // Paved Road
		{ MetaRewardTypes.Essential_Primitive_Forager, "Essential Primitive Forager" },                                                                    // Small Foragers' Camp
		{ MetaRewardTypes.Essential_Primitive_Herbalist, "Essential Primitive Herbalist" },                                                                // Small Herbalists' Camp
		{ MetaRewardTypes.Essential_Primitive_Trapper, "Essential Primitive Trapper" },                                                                    // Small Trappers' Camp
		{ MetaRewardTypes.Essential_Reinforced_Road, "Essential Reinforced Road" },                                                                        // Reinforced Road
		{ MetaRewardTypes.Essential_Shelter, "Essential Shelter" },                                                                                        // Shelter
		{ MetaRewardTypes.Essential_Small_Hearth, "Essential Small Hearth" },                                                                              // Small Hearth
		{ MetaRewardTypes.Essential_Stonecutter, "Essential Stonecutter" },                                                                                // Stonecutters' Camp
		{ MetaRewardTypes.Essential_Storage, "Essential Storage" },                                                                                        // Small Warehouse
		{ MetaRewardTypes.Essential_Temporary_Hearth, "Essential Temporary Hearth" },                                                                      // Small Hearth
		{ MetaRewardTypes.Essential_Trading_Post, "Essential Trading Post" },                                                                              // Trading Post
		{ MetaRewardTypes.Essential_Woodcutters_Camp, "Essential Woodcutters Camp" },                                                                      // Woodcutters' Camp
		{ MetaRewardTypes.Food_Stockpiles_10, "Food Stockpiles 10" },                                                                                      // Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_15, "Food Stockpiles 15" },                                                                                      // Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_20, "Food Stockpiles 20" },                                                                                      // Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_25, "Food Stockpiles 25" },                                                                                      // Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_30, "Food Stockpiles 30" },                                                                                      // Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_5, "Food Stockpiles 5" },                                                                                        // Food Stockpiles
		{ MetaRewardTypes.Goals_Exp_Reward___Regular, "Goals Exp Reward - Regular" },                                                                      // Honor Badge
		{ MetaRewardTypes.House_Upgrades_Unlock___Beavers, "House Upgrades Unlock - Beavers" },                                                            // House Upgrades - Beavers
		{ MetaRewardTypes.House_Upgrades_Unlock___Foxes, "House Upgrades Unlock - Foxes" },                                                                // House Upgrades - Foxes
		{ MetaRewardTypes.House_Upgrades_Unlock___Harpies, "House Upgrades Unlock - Harpies" },                                                            // House Upgrades - Harpies
		{ MetaRewardTypes.House_Upgrades_Unlock___Humans, "House Upgrades Unlock - Humans" },                                                              // House Upgrades - Humans
		{ MetaRewardTypes.House_Upgrades_Unlock___Lizards, "House Upgrades Unlock - Lizards" },                                                            // House Upgrades - Lizards
		{ MetaRewardTypes.Ironman_Activation, "Ironman Activation" },                                                                                      // Queen's Hand Trial
		{ MetaRewardTypes.Machinery_10, "Machinery 10" },                                                                                                  // Machinery
		{ MetaRewardTypes.Machinery_15, "Machinery 15" },                                                                                                  // Machinery
		{ MetaRewardTypes.Machinery_20, "Machinery 20" },                                                                                                  // Machinery
		{ MetaRewardTypes.Machinery_25, "Machinery 25" },                                                                                                  // Machinery
		{ MetaRewardTypes.Machinery_5, "Machinery 5" },                                                                                                    // Machinery
		{ MetaRewardTypes.Meta_Foxes_Unlock, "Meta Foxes Unlock" },                                                                                        // Fox
		{ MetaRewardTypes.Meta_Harpies_Unlock, "Meta Harpies Unlock" },                                                                                    // Harpy
		{ MetaRewardTypes.Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse, "Meta Perk Unlock 2 Hauling Carts in Main Warehouse" },                      // Dual Carriage System
		{ MetaRewardTypes.Meta_Perk_Unlock_Accidental_Barrels, "Meta Perk Unlock Accidental Barrels" },                                                    // Over-Diligent Woodworkers
		{ MetaRewardTypes.Meta_Perk_Unlock_Alarm_Bells, "Meta Perk Unlock Alarm Bells" },                                                                  // Alarm Bells
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Newcomers, "Meta Perk Unlock Amber for Newcomers" },                                                  // Stormwalker Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trade_Routes, "Meta Perk Unlock Amber for Trade Routes" },                                            // Deep Pockets
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trader_Visit, "Meta Perk Unlock Amber for Trader Visit" },                                            // Bed and Breakfast
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Water, "Meta Perk Unlock Amber for Water" },                                                          // Counterfeit Amber
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Wood, "Meta Perk Unlock Amber for Wood" },                                                            // Lumber Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Back_To_Nature, "Meta Perk Unlock Back to Nature" },                                                            // Back to Nature
		{ MetaRewardTypes.Meta_Perk_Unlock_Cache_Rewards_For_Nodes, "Meta Perk Unlock Cache Rewards for Nodes" },                                          // Reckless Plunder
		{ MetaRewardTypes.Meta_Perk_Unlock_Coal_For_Cyst, "Meta Perk Unlock Coal for Cyst" },                                                              // Burnt to a Crisp
		{ MetaRewardTypes.Meta_Perk_Unlock_Consumption_Control_For_Extra_Production, "Meta Perk Unlock Consumption Control for Extra Production" },        // Without Restrictions
		{ MetaRewardTypes.Meta_Perk_Unlock_Copper_For_Each_Tree, "Meta Perk Unlock Copper for each tree" },                                                // Copper Extractor
		{ MetaRewardTypes.Meta_Perk_Unlock_Corruption_Per_Removed_Cyst__50, "Meta Perk Unlock Corruption Per Removed Cyst -50" },                          // Firekeeper's Armor
		{ MetaRewardTypes.Meta_Perk_Unlock_Crystaline_Water, "Meta Perk Unlock Crystaline Water" },                                                        // Small Distillery
		{ MetaRewardTypes.Meta_Perk_Unlock_Eggs_For_Cysts, "Meta Perk Unlock Eggs For Cysts" },                                                            // Blightrot Pruner
		{ MetaRewardTypes.Meta_Perk_Unlock_Exploring_Expedition, "Meta Perk Unlock Exploring Expedition" },                                                // Exploration Expedition
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Prod_For_Consumption, "Meta Perk Unlock Extra Prod for consumption" },                                    // Worker's Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Trader_Merch, "Meta Perk Unlock Extra Trader Merch" },                                                    // Guild Catalogue
		{ MetaRewardTypes.Meta_Perk_Unlock_Fedora_Hat, "Meta Perk Unlock Fedora Hat" },                                                                    // Old Fedora Hat
		{ MetaRewardTypes.Meta_Perk_Unlock_Forge_Trip_Hammer, "Meta Perk Unlock Forge Trip Hammer" },                                                      // Forge Trip Hammer
		{ MetaRewardTypes.Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses, "Meta Perk Unlock Hauling Cart in All Warehouses" },                            // Hauling Cart
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Relics, "Meta Perk Unlock Hostility for Relics" },                                                // Frequent Patrols
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Removed_Cysts, "Meta Perk Unlock Hostility for Removed Cysts" },                                  // Baptism of Fire
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Water, "Meta Perk Unlock Hostility for Water" },                                                  // Calming Water
		{ MetaRewardTypes.Meta_Perk_Unlock_Houses_Global_Capacity_Plus1, "Meta Perk Unlock Houses Global Capacity +1" },                                   // Crowded Houses
		{ MetaRewardTypes.Meta_Perk_Unlock_HP_For_Impatience, "Meta Perk Unlock HP for Impatience" },                                                      // Queen's Gift
		{ MetaRewardTypes.Meta_Perk_Unlock_Hubs_For_Hostility, "Meta Perk Unlock Hubs for hostility" },                                                    // Safe Haven
		{ MetaRewardTypes.Meta_Perk_Unlock_Insect_For_Tree, "Meta Perk Unlock Insect for tree" },                                                          // Woodpecker Technique
		{ MetaRewardTypes.Meta_Perk_Unlock_LessHostilityPerWoodcutter, "Meta Perk Unlock LessHostilityPerWoodcutter" },                                    // Flame Amulets
		{ MetaRewardTypes.Meta_Perk_Unlock_Lower_Hostility_For_Religion, "Meta Perk Unlock Lower Hostility For Religion" },                                // Firelink Ritual
		{ MetaRewardTypes.Meta_Perk_Unlock_Mist_Piercers, "Meta Perk Unlock Mist Piercers" },                                                              // Mist Piercers
		{ MetaRewardTypes.Meta_Perk_Unlock_Mold_Grain, "Meta Perk Unlock Mold Grain" },                                                                    // Moldy Grain Seeds
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Amber_From_Routes, "Meta Perk Unlock More Amber from Routes" },                                            // Trade Negotiations
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Node_Charges, "Meta Perk Unlock More Node Charges" },                                                      // Rich Glades
		{ MetaRewardTypes.Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes, "Meta Perk Unlock Newcomer Rate for Trade Routes" },                            // Economic Migration
		{ MetaRewardTypes.Meta_Perk_Unlock_Overexploitation, "Meta Perk Unlock Overexploitation" },                                                        // Overexploitation
		{ MetaRewardTypes.Meta_Perk_Unlock_Parts_For_Trade, "Meta Perk Unlock Parts for Trade" },                                                          // Free Samples
		{ MetaRewardTypes.Meta_Perk_Unlock_Porridge_Prod_For_Water, "Meta Perk Unlock Porridge Prod for water" },                                          // Filling Dish
		{ MetaRewardTypes.Meta_Perk_Unlock_Relic_Time_Reduction, "Meta Perk Unlock Relic time reduction" },                                                // Firekeeper's Prayer
		{ MetaRewardTypes.Meta_Perk_Unlock_Reputation_From_Trade, "Meta Perk Unlock Reputation from Trade" },                                              // Trade Hub
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Chests, "Meta Perk Unlock Resolve for Chests" },                                                    // Prosperous Archaeology
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Consumption, "Meta Perk Unlock Resolve for consumption" },                                          // Generous Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Impatience, "Meta Perk Unlock Resolve for Impatience" },                                            // Rebellious Spirit
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Sales, "Meta Perk Unlock Resolve for Sales" },                                                      // Prosperous Settlement
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Standing, "Meta Perk Unlock Resolve for Standing" },                                                // Friendly Relations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Started_Route, "Meta Perk Unlock Resolve for started Route" },                                      // Frequent Caravans
		{ MetaRewardTypes.Meta_Perk_Unlock_Route_Less_Travel_Time, "Meta Perk Unlock Route Less Travel Time" },                                            // Stormwalker Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Royal_Guard_Training, "Meta Perk Unlock Royal Guard Training" },                                                // Royal Guard Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience, "Meta Perk Unlock Sacrifice Cost for Impatience" },                              // Fiery Wrath
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Death, "Meta Perk Unlock Tools for death" },                                                          // Bone Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Glade_For_Resolve, "Meta Perk Unlock Tools for Glade for Resolve" },                                  // Improvised Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel, "Meta Perk Unlock Trade Routes Bonus Fuel" },                                          // Tightened Belt
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots, "Meta Perk Unlock Trade routes for housing spots" },                            // Urban Planning
		{ MetaRewardTypes.Meta_Perk_Unlock_Trading_Packs, "Meta Perk Unlock Trading Packs" },                                                              // Trade Logs
		{ MetaRewardTypes.Meta_Perk_Unlock_VillagerDeathEffectBlock, "Meta Perk Unlock VillagerDeathEffectBlock" },                                        // Hidden from the Queen
		{ MetaRewardTypes.Meta_Perk_Unlock_Villagers_For_Corruption, "Meta Perk Unlock Villagers For Corruption" },                                        // From the Shadows
		{ MetaRewardTypes.Meta_Perk_Unlock_Wildcard, "Meta Perk Unlock Wildcard" },                                                                        // Smuggler's Visit
		{ MetaRewardTypes.Meta_Perk_Unlock_Wood_Plus2_For_Insects, "Meta Perk Unlock Wood +2 for insects" },                                               // No Quality Control
		{ MetaRewardTypes.Meta_Perk_Unlock_Working_Time_For_Firekeeper, "Meta Perk Unlock Working time for firekeeper" },                                  // Prayer Book
		{ MetaRewardTypes.Meta_Reward_Advanced_Rain_Collector, "Meta Reward Advanced Rain Collector" },                                                    // Advanced Rain Collector
		{ MetaRewardTypes.Meta_Reward_Alchemist_Hut, "Meta Reward Alchemist Hut" },                                                                        // Alchemist's Hut
		{ MetaRewardTypes.Meta_Reward_Apothecary, "Meta Reward Apothecary" },                                                                              // Apothecary
		{ MetaRewardTypes.Meta_Reward_Artisan, "Meta Reward Artisan" },                                                                                    // Artisan
		{ MetaRewardTypes.Meta_Reward_Bakery, "Meta Reward Bakery" },                                                                                      // Bakery
		{ MetaRewardTypes.Meta_Reward_Bath_House, "Meta Reward Bath House" },                                                                              // Bath House
		{ MetaRewardTypes.Meta_Reward_Beanery, "Meta Reward Beanery" },                                                                                    // Beanery
		{ MetaRewardTypes.Meta_Reward_Beaver_House, "Meta Reward Beaver House" },                                                                          // Beaver House
		{ MetaRewardTypes.Meta_Reward_Big_Shelter, "Meta Reward Big Shelter" },                                                                            // Big Shelter
		{ MetaRewardTypes.Meta_Reward_Blight_Post_Upgrades_Unlock, "Meta Reward Blight Post Upgrades Unlock" },                                            // Blight Post Upgrades
		{ MetaRewardTypes.Meta_Reward_Bonus_Yield, "Meta Reward Bonus Yield" },                                                                            // Unforeseen Riches
		{ MetaRewardTypes.Meta_Reward_Brewery, "Meta Reward Brewery" },                                                                                    // Brewery
		{ MetaRewardTypes.Meta_Reward_Brick_Oven, "Meta Reward Brick Oven" },                                                                              // Brick Oven
		{ MetaRewardTypes.Meta_Reward_Brickyard, "Meta Reward Brickyard" },                                                                                // Brickyard
		{ MetaRewardTypes.Meta_Reward_Building_Storage, "Meta Reward Building Storage" },                                                                  // Larger Storage
		{ MetaRewardTypes.Meta_Reward_Burning_Duration, "Meta Reward Burning Duration" },                                                                  // Everlasting Flames
		{ MetaRewardTypes.Meta_Reward_Butcher, "Meta Reward Butcher" },                                                                                    // Butcher
		{ MetaRewardTypes.Meta_Reward_Caravan_Goods, "Meta Reward Caravan Goods" },                                                                        // Stocked Caravans
		{ MetaRewardTypes.Meta_Reward_Caravan_Slot, "Meta Reward Caravan Slot" },                                                                          // Additional Caravan Choice
		{ MetaRewardTypes.Meta_Reward_Carpenter, "Meta Reward Carpenter" },                                                                                // Carpenter
		{ MetaRewardTypes.Meta_Reward_Cellar, "Meta Reward Cellar" },                                                                                      // Cellar
		{ MetaRewardTypes.Meta_Reward_Citadel_Home_Unlock, "Meta Reward Citadel Home Unlock" },                                                            // Viceroy's Quarters
		{ MetaRewardTypes.Meta_Reward_Clan_Hall, "Meta Reward Clan Hall" },                                                                                // Clan Hall
		{ MetaRewardTypes.Meta_Reward_Clay_Pit, "Meta Reward Clay Pit" },                                                                                  // Clay Pit
		{ MetaRewardTypes.Meta_Reward_Clothier, "Meta Reward Clothier" },                                                                                  // Clothier
		{ MetaRewardTypes.Meta_Reward_Cookhouse, "Meta Reward Cookhouse" },                                                                                // Cookhouse
		{ MetaRewardTypes.Meta_Reward_Cooperage, "Meta Reward Cooperage" },                                                                                // Cooperage
		{ MetaRewardTypes.Meta_Reward_Cornerstone, "Meta Reward Cornerstone" },                                                                            // Additional Cornerstone Choice
		{ MetaRewardTypes.Meta_Reward_Cornerstone_Reroll, "Meta Reward Cornerstone Reroll" },                                                              // Cornerstone Reroll Charge
		{ MetaRewardTypes.Meta_Reward_Crude_Workstation, "Meta Reward Crude Workstation" },                                                                // Crude Workstation
		{ MetaRewardTypes.Meta_Reward_Daily_Challenge, "Meta Reward Daily Challenge" },                                                                    // Daily Expedition
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Arch, "Meta Reward Decor Ancient Arch" },                                                              // Ancient Arch
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Gravestone, "Meta Reward Decor Ancient Gravestone" },                                                  // Ancient Tombstone
		{ MetaRewardTypes.Meta_Reward_Decor_Bank, "Meta Reward Decor Bank" },                                                                              // Bench
		{ MetaRewardTypes.Meta_Reward_Decor_Barrels, "Meta Reward Decor Barrels" },                                                                        // Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Bush, "Meta Reward Decor Bush" },                                                                              // Bush
		{ MetaRewardTypes.Meta_Reward_Decor_Coral, "Meta Reward Decor Coral" },                                                                            // Coral Growth
		{ MetaRewardTypes.Meta_Reward_Decor_Crates, "Meta Reward Decor Crates" },                                                                          // Crates
		{ MetaRewardTypes.Meta_Reward_Decor_Fence, "Meta Reward Decor Fence" },                                                                            // Fence
		{ MetaRewardTypes.Meta_Reward_Decor_Fence_Corner, "Meta Reward Decor Fence Corner" },                                                              // Fence Corner
		{ MetaRewardTypes.Meta_Reward_Decor_Fire_Shrine, "Meta Reward Decor Fire Shrine" },                                                                // Fire Shrine
		{ MetaRewardTypes.Meta_Reward_Decor_Flower_Bed, "Meta Reward Decor Flower Bed" },                                                                  // Flower Bed
		{ MetaRewardTypes.Meta_Reward_Decor_Gate, "Meta Reward Decor Gate" },                                                                              // Gate
		{ MetaRewardTypes.Meta_Reward_Decor_Golden_Leaf, "Meta Reward Decor Golden Leaf" },                                                                // Golden Leaf Plant
		{ MetaRewardTypes.Meta_Reward_Decor_Lamp, "Meta Reward Decor Lamp" },                                                                              // Lamp
		{ MetaRewardTypes.Meta_Reward_Decor_Lizard_Post, "Meta Reward Decor Lizard Post" },                                                                // Lizard Post
		{ MetaRewardTypes.Meta_Reward_Decor_Mushroom, "Meta Reward Decor Mushroom" },                                                                      // Decorative Fungus
		{ MetaRewardTypes.Meta_Reward_Decor_Nightfern, "Meta Reward Decor Nightfern" },                                                                    // Nightfern
		{ MetaRewardTypes.Meta_Reward_Decor_Rainpunk_Barrels, "Meta Reward Decor Rainpunk Barrels" },                                                      // Water Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Road_Sign, "Meta Reward Decor Road Sign" },                                                                    // Road Sign
		{ MetaRewardTypes.Meta_Reward_Decor_Side_Barrels, "Meta Reward Decor Side Barrels" },                                                              // Rainpunk Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Signboard, "Meta Reward Decor Signboard" },                                                                    // Signboard
		{ MetaRewardTypes.Meta_Reward_Decor_Tower, "Meta Reward Decor Tower" },                                                                            // Wall Crossing
		{ MetaRewardTypes.Meta_Reward_Decor_Umbrella, "Meta Reward Decor Umbrella" },                                                                      // Umbrella
		{ MetaRewardTypes.Meta_Reward_Decor_Wall, "Meta Reward Decor Wall" },                                                                              // Wall
		{ MetaRewardTypes.Meta_Reward_Distillery, "Meta Reward Distillery" },                                                                              // Distillery
		{ MetaRewardTypes.Meta_Reward_Druid, "Meta Reward Druid" },                                                                                        // Druid's Hut
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Forager, "Meta Reward Embark Blueprint Forager" },                                                  // Embarkation Bonus: Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herb_Garden, "Meta Reward Embark Blueprint Herb Garden" },                                          // Embarkation Bonus: Herb Garden
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herbalist, "Meta Reward Embark Blueprint Herbalist" },                                              // Embarkation Bonus: Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Plantation, "Meta Reward Embark Blueprint Plantation" },                                            // Embarkation Bonus: Plantation
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Small_Farm, "Meta Reward Embark Blueprint Small Farm" },                                            // Embarkation Bonus: Small Farm
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Trapper, "Meta Reward Embark Blueprint Trapper" },                                                  // Embarkation Bonus: Trappers' Camp
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
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Ale_3pm, "Meta Reward Embark Perk Ale 3pm" },                                                            // Embarkation Bonus: Ale Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1, "Meta Reward Embark Perk Cornerstone Reroll +1" },                             // Embarkation Bonus: Royal Permit
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cosmetics_3pm, "Meta Reward Embark Perk Cosmetics 3pm" },                                                // Embarkation Bonus: Tea Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Incense_3pm, "Meta Reward Embark Perk Incense 3pm" },                                                    // Embarkation Bonus: Incense Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Scrolls_3pm, "Meta Reward Embark Perk Scrolls 3pm" },                                                    // Embarkation Bonus: Scroll Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Training_Gear_3pm, "Meta Reward Embark Perk Training Gear 3pm" },                                        // Embarkation Bonus: Training Gear Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Wine_3pm, "Meta Reward Embark Perk Wine 3pm" },                                                          // Embarkation Bonus: Wine Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Point, "Meta Reward Embark Point" },                                                                          // Embarkation Points
		{ MetaRewardTypes.Meta_Reward_Embark_Range, "Meta Reward Embark Range" },                                                                          // Greater Embarkation Range
		{ MetaRewardTypes.Meta_Reward_Embark_Villagers, "Meta Reward Embark Villagers" },                                                                  // Embarkation Bonus: Villagers
		{ MetaRewardTypes.Meta_Reward_Essential_Beaver_House, "Meta Reward Essential Beaver House" },                                                      // Essential Blueprint: Beaver House
		{ MetaRewardTypes.Meta_Reward_Essential_Field_Kitchen, "Meta Reward Essential Field Kitchen" },                                                    // Essential Blueprint: Field Kitchen
		{ MetaRewardTypes.Meta_Reward_Essential_Fox_House, "Meta Reward Essential Fox House" },                                                            // Essential Blueprint: Fox House
		{ MetaRewardTypes.Meta_Reward_Essential_Harpy_House, "Meta Reward Essential Harpy House" },                                                        // Essential Blueprint: Harpy House
		{ MetaRewardTypes.Meta_Reward_Essential_Human_House, "Meta Reward Essential Human House" },                                                        // Essential Blueprint: Human House
		{ MetaRewardTypes.Meta_Reward_Essential_Lizard_House, "Meta Reward Essential Lizard House" },                                                      // Essential Blueprint: Lizard House
		{ MetaRewardTypes.Meta_Reward_Essential_Rain_Collector, "Meta Reward Essential Rain Collector" },                                                  // Rain Collector
		{ MetaRewardTypes.Meta_Reward_Explorers_Lodge, "Meta Reward Explorers Lodge" },                                                                    // Explorers' Lodge
		{ MetaRewardTypes.Meta_Reward_Faction_Blue, "Meta Reward Faction Blue" },                                                                          // Vanguard of the Stolen Keys
		{ MetaRewardTypes.Meta_Reward_Faction_Green, "Meta Reward Faction Green" },                                                                        // First Dawn Company
		{ MetaRewardTypes.Meta_Reward_Faction_Orange, "Meta Reward Faction Orange" },                                                                      // Brass Order
		{ MetaRewardTypes.Meta_Reward_Farm_Range, "Meta Reward Farm Range" },                                                                              // Farm Range Increase
		{ MetaRewardTypes.Meta_Reward_Finesmith, "Meta Reward Finesmith" },                                                                                // Finesmith
		{ MetaRewardTypes.Meta_Reward_Foragers_Camp, "Meta Reward Forager's Camp" },                                                                       // Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Forum, "Meta Reward Forum" },                                                                                        // Forum
		{ MetaRewardTypes.Meta_Reward_Fox_House, "Meta Reward Fox House" },                                                                                // Fox House
		{ MetaRewardTypes.Meta_Reward_Furnace, "Meta Reward Furnace" },                                                                                    // Furnace
		{ MetaRewardTypes.Meta_Reward_Global_Capacity, "Meta Reward Global Capacity" },                                                                    // Worker Capacity Increase
		{ MetaRewardTypes.Meta_Reward_Goals_Unlock, "Meta Reward Goals Unlock" },                                                                          // Obsidian Archive
		{ MetaRewardTypes.Meta_Reward_Grace_Period, "Meta Reward Grace Period" },                                                                          // Last Stand
		{ MetaRewardTypes.Meta_Reward_Granary, "Meta Reward Granary" },                                                                                    // Granary
		{ MetaRewardTypes.Meta_Reward_Greenhouse, "Meta Reward Greenhouse" },                                                                              // Greenhouse
		{ MetaRewardTypes.Meta_Reward_Grill, "Meta Reward Grill" },                                                                                        // Grill
		{ MetaRewardTypes.Meta_Reward_Grove, "Meta Reward Grove" },                                                                                        // Forester's Hut
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Bricks, "Meta Reward Guaranteed Bricks" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Fabric, "Meta Reward Guaranteed Fabric" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Pipes, "Meta Reward Guaranteed Pipes" }, 
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Planks, "Meta Reward Guaranteed Planks" }, 
		{ MetaRewardTypes.Meta_Reward_Guild_House, "Meta Reward Guild House" },                                                                            // Guild House
		{ MetaRewardTypes.Meta_Reward_Haulers___Main_Storage, "Meta Reward Haulers - Main Storage" },                                                      // Haulers - Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Haulers___Secondary_Storage, "Meta Reward Haulers - Secondary Storage" },                                            // Haulers - Small Warehouse
		{ MetaRewardTypes.Meta_Reward_Hearth, "Meta Reward Hearth" },                                                                                      // Small Hearth
		{ MetaRewardTypes.Meta_Reward_Herb_Garden, "Meta Reward Herb Garden" },                                                                            // Herb Garden
		{ MetaRewardTypes.Meta_Reward_Herbalist_Camp, "Meta Reward Herbalist Camp" },                                                                      // Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Ancient_Artifact, "Meta Reward Home Decor - Ancient Artifact" },                                        // Ancient Artifact
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Domesticated_Sea_Tiger, "Meta Reward Home Decor - Domesticated Sea Tiger" },                            // Domesticated Sea Tiger
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Dueling_Umbrella, "Meta Reward Home Decor - Dueling Umbrella" },                                        // Dueling Umbrella
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Fishman_Skull, "Meta Reward Home Decor - Fishman Skull" },                                              // Fishman Skull
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Ibex_Rug, "Meta Reward Home Decor - Ibex Rug" },                                                        // Ibex Rug
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Inscribed_Slab, "Meta Reward Home Decor - Inscribed Slab" },                                            // Inscribed Slab
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Landscape_Painting, "Meta Reward Home Decor - Landscape Painting" },                                    // Landscape Painting
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Marshglow_Fungite, "Meta Reward Home Decor - Marshglow Fungite" },                                      // Marshglow Fungite
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Mole_Trophy, "Meta Reward Home Decor - Mole Trophy" },                                                  // Mole Trophy
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Painting_Of_The_Ancient_Hearth, "Meta Reward Home Decor - Painting of the Ancient Hearth" },            // Painting of the Ancient Hearth
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Plate_Of_Food, "Meta Reward Home Decor - Plate of Food" },                                              // Plate of Food
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Reefbloom, "Meta Reward Home Decor - Reefbloom" },                                                      // Reefbloom
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Rosevine, "Meta Reward Home Decor - Rosevine" },                                                        // Rosevine
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Sparkdew_Crystal, "Meta Reward Home Decor - Sparkdew Crystal" },                                        // Sparkdew Crystal
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Storm_Orb, "Meta Reward Home Decor - Storm Orb" },                                                      // Storm Orb
		{ MetaRewardTypes.Meta_Reward_Home_Decor___The_Sparkcaster, "Meta Reward Home Decor - The Sparkcaster" },                                          // The Sparkcaster
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Trade_Contract, "Meta Reward Home Decor - Trade Contract" },                                            // Trade Contract
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_0___Standard_Uniform, "Meta Reward Home Decor - Uniform 0 - Standard Uniform" },                // Standard Uniform
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_1___Settlers_Mask, "Meta Reward Home Decor - Uniform 1 - Settler's Mask" },                     // Settler's Mask
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_2___Pioneers_Mantle, "Meta Reward Home Decor - Uniform 2 - Pioneer's Mantle" },                 // Pioneer's Mantle
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_3___Veterans_Shoulder_Guard, "Meta Reward Home Decor - Uniform 3 - Veteran's Shoulder Guard" }, // Veteran's Shoulder Guard
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_4___Viceroys_Cape, "Meta Reward Home Decor - Uniform 4 - Viceroy's Cape" },                     // Viceroy's Cape
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_5___Decorated_Belt, "Meta Reward Home Decor - Uniform 5 - Decorated Belt" },                    // Decorated Belt
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_6___Royal_Visage, "Meta Reward Home Decor - Uniform 6 - Royal Visage" },                        // Royal Visage
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_7___Stormshroud_Attire, "Meta Reward Home Decor - Uniform 7 - Stormshroud Attire" },            // Stormshroud Attire
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_8___Crimson_Cloak, "Meta Reward Home Decor - Uniform 8 - Crimson Cloak" },                      // Crimson Cloak
		{ MetaRewardTypes.Meta_Reward_Home_Decor___Uniform_9___Queens_Hand_Pauldron, "Meta Reward Home Decor - Uniform 9 - Queen's Hand Pauldron" },       // Queen's Hand Pauldron
		{ MetaRewardTypes.Meta_Reward_Homestead, "Meta Reward Homestead" },                                                                                // Homestead
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_1, "Meta Reward Hub Tier 1" },                                                                              // Hearth Upgrade - Neighborhood
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_2, "Meta Reward Hub Tier 2" },                                                                              // Hearth Upgrade - District
		{ MetaRewardTypes.Meta_Reward_Human_House, "Meta Reward Human House" },                                                                            // Human House
		{ MetaRewardTypes.Meta_Reward_Impatience, "Meta Reward Impatience" },                                                                              // Queen's Patience
		{ MetaRewardTypes.Meta_Reward_Kiln, "Meta Reward Kiln" },                                                                                          // Kiln
		{ MetaRewardTypes.Meta_Reward_Lizard_House, "Meta Reward Lizard House" },                                                                          // Lizard House
		{ MetaRewardTypes.Meta_Reward_Lumbermill, "Meta Reward Lumbermill" },                                                                              // Lumber Mill
		{ MetaRewardTypes.Meta_Reward_Manufactory, "Meta Reward Manufactory" },                                                                            // Manufactory
		{ MetaRewardTypes.Meta_Reward_Market, "Meta Reward Market" },                                                                                      // Market
		{ MetaRewardTypes.Meta_Reward_Meta_Resources, "Meta Reward Meta Resources" },                                                                      // More Citadel Resources
		{ MetaRewardTypes.Meta_Reward_Mine, "Meta Reward Mine" },                                                                                          // Mine
		{ MetaRewardTypes.Meta_Reward_Mine_Upgrade_Unlock, "Meta Reward Mine Upgrade Unlock" },                                                            // Mine Upgrades
		{ MetaRewardTypes.Meta_Reward_Monastery, "Meta Reward Monastery" },                                                                                // Monastery
		{ MetaRewardTypes.Meta_Reward_Newcomer_Goods, "Meta Reward Newcomer Goods" },                                                                      // Newcomer Gifts
		{ MetaRewardTypes.Meta_Reward_Node_Charges, "Meta Reward Node Charges" },                                                                          // Gathering Technique
		{ MetaRewardTypes.Meta_Reward_Passive_Beavers, "Meta Reward Passive Beavers" },                                                                    // Starting Ability - Beavers
		{ MetaRewardTypes.Meta_Reward_Passive_Foxes, "Meta Reward Passive Foxes" },                                                                        // Starting Ability - Foxes
		{ MetaRewardTypes.Meta_Reward_Passive_Harpies, "Meta Reward Passive Harpies" },                                                                    // Starting Ability - Harpies
		{ MetaRewardTypes.Meta_Reward_Passive_Humans, "Meta Reward Passive Humans" },                                                                      // Starting Ability - Humans
		{ MetaRewardTypes.Meta_Reward_Passive_Lizards, "Meta Reward Passive Lizards" },                                                                    // Starting Ability - Lizards
		{ MetaRewardTypes.Meta_Reward_Paved_Road, "Meta Reward Paved Road" },                                                                              // Paved Road
		{ MetaRewardTypes.Meta_Reward_Plantation, "Meta Reward Plantation" },                                                                              // Plantation
		{ MetaRewardTypes.Meta_Reward_Press, "Meta Reward Press" },                                                                                        // Press
		{ MetaRewardTypes.Meta_Reward_Prod_Speed, "Meta Reward Prod Speed" },                                                                              // Production Speed Increase
		{ MetaRewardTypes.Meta_Reward_Provisioner, "Meta Reward Provisioner" },                                                                            // Provisioner
		{ MetaRewardTypes.Meta_Reward_Rain_Mill, "Meta Reward Rain Mill" },                                                                                // Rain Mill
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Activation, "Meta Reward Rainpunk Activation" },                                                            // Rainpunk Engines
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Foundry, "Meta Reward Rainpunk Foundry" },                                                                  // Rainpunk Foundry
		{ MetaRewardTypes.Meta_Reward_Ranch, "Meta Reward Ranch" },                                                                                        // Ranch
		{ MetaRewardTypes.Meta_Reward_Reputation_Reward_Pick, "Meta Reward Reputation Reward Pick" },                                                      // Additional Blueprint Choice
		{ MetaRewardTypes.Meta_Reward_Reshuffle, "Meta Reward Reshuffle" },                                                                                // Blueprint Reroll
		{ MetaRewardTypes.Meta_Reward_Sacrifice_Cost, "Meta Reward Sacrifice Cost" },                                                                      // Sacrificial Flames
		{ MetaRewardTypes.Meta_Reward_Scribe, "Meta Reward Scribe" },                                                                                      // Scribe
		{ MetaRewardTypes.Meta_Reward_Sewer, "Meta Reward Sewer" },                                                                                        // Clothier
		{ MetaRewardTypes.Meta_Reward_Smelter, "Meta Reward Smelter" },                                                                                    // Smelter
		{ MetaRewardTypes.Meta_Reward_Smithy, "Meta Reward Smithy" },                                                                                      // Smithy
		{ MetaRewardTypes.Meta_Reward_Smokehouse, "Meta Reward Smokehouse" },                                                                              // Smokehouse
		{ MetaRewardTypes.Meta_Reward_Stamping_Mill, "Meta Reward Stamping Mill" },                                                                        // Stamping Mill
		{ MetaRewardTypes.Meta_Reward_Storage, "Meta Reward Storage" },                                                                                    // Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Supplier, "Meta Reward Supplier" },                                                                                  // Supplier
		{ MetaRewardTypes.Meta_Reward_Tavern, "Meta Reward Tavern" },                                                                                      // Tavern
		{ MetaRewardTypes.Meta_Reward_Tea_Doctor, "Meta Reward Tea Doctor" },                                                                              // Tea Doctor
		{ MetaRewardTypes.Meta_Reward_Tea_House, "Meta Reward Tea House" },                                                                                // Teahouse
		{ MetaRewardTypes.Meta_Reward_Temple, "Meta Reward Temple" },                                                                                      // Temple
		{ MetaRewardTypes.Meta_Reward_Tinctury, "Meta Reward Tinctury" },                                                                                  // Tinctury
		{ MetaRewardTypes.Meta_Reward_Tinkerer, "Meta Reward Tinkerer" },                                                                                  // Tinkerer
		{ MetaRewardTypes.Meta_Reward_Toolshop, "Meta Reward Toolshop" },                                                                                  // Toolshop
		{ MetaRewardTypes.Meta_Reward_Town_Vision, "Meta Reward Town Vision" },                                                                            // Increased Town Vision Range
		{ MetaRewardTypes.Meta_Reward_Trade_Routes_Limit, "Meta Reward Trade Routes Limit" },                                                              // More Trade Routes
		{ MetaRewardTypes.Meta_Reward_Trader_Arrival, "Meta Reward Trader Arrival" },                                                                      // Quicker Trader Arrival
		{ MetaRewardTypes.Meta_Reward_Trader_Merch, "Meta Reward Trader Merch" },                                                                          // Extra Merchandise
		{ MetaRewardTypes.Meta_Reward_Trader_Perk_Discount, "Meta Reward Trader Perk Discount" },                                                          // Special Discount
		{ MetaRewardTypes.Meta_Reward_Villager_Speed, "Meta Reward Villager Speed" },                                                                      // Villager Speed Increase
		{ MetaRewardTypes.Meta_Reward_Weaver, "Meta Reward Weaver" },                                                                                      // Weaver
		{ MetaRewardTypes.Meta_Reward_Workshop, "Meta Reward Workshop" },                                                                                  // Workshop
		{ MetaRewardTypes.Meta_Trader_Unlock_A, "Meta Trader Unlock A" },                                                                                  // Zhorg
		{ MetaRewardTypes.Meta_Trader_Unlock_B, "Meta Trader Unlock B" },                                                                                  // Old Farluf
		{ MetaRewardTypes.Meta_Trader_Unlock_C, "Meta Trader Unlock C" },                                                                                  // Sothur The Ancient
		{ MetaRewardTypes.Meta_Trader_Unlock_D, "Meta Trader Unlock D" },                                                                                  // Vliss Greybone
		{ MetaRewardTypes.Meta_Trader_Unlock_E, "Meta Trader Unlock E" },                                                                                  // Sir Renwald Redmane
		{ MetaRewardTypes.Meta_Trader_Unlock_F, "Meta Trader Unlock F" },                                                                                  // Xiadani Stormfeather
		{ MetaRewardTypes.Meta_Trader_Unlock_G, "Meta Trader Unlock G" },                                                                                  // Dullahan Warlander
		{ MetaRewardTypes.Timed_Orders_Activation, "Timed Orders Activation" },                                                                            // Timed Orders
		{ MetaRewardTypes.Trade_Routes_Activation, "Trade Routes Activation" },                                                                            // Trade Routes
	};
}
