using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Orders;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum OrderTypes
{
    Unknown = -1,
    None,
	Amber_And_Luxury_LOW,                 // Essence of Wealth
	Amber_Transaction,                    // Crystal Feathers
	Amber_Transaction_LOW,                // Crystal Feathers
	Ancient_Tablets,                      // Forbidden Essence
	Ancient_Tablets_LOW,                  // Forbidden Essence
	Caches,                               // Heart of the Forest
	Caches_LOW,                           // Heart of the Forest
	CystsRemoved,                         // Magnate
	Deliver_Packs,                        // Heart of Amber
	Deliver_Packs_LOW,                    // Heart of Amber
	Deliver_Tools,                        // Metal Feathers
	Deliver_Tools_LOW,                    // Metal Feathers
	Discover_Forbidden_LOW,               // Stormbird Feathers
	Engines_Connected,                    // Mechanical Heart
	Events_Decisions,                     // Blood of the Stag
	Events_Decisions_LOW,                 // Blood of the Stag
	Heart_Parts_And_Sacrifice_LOW,        // Heart of the Ancient Flame
	I_Amber,                              // Amber Trade
	I_Blighfuel,                          // Call to Arms
	I_Blue_Metal,                         // Blue Metal
	I_Botanist,                           // Botanist
	I_Clearing_Glades,                    // Clearing Glades
	I_Clothing,                           // Rain Protection
	I_Cysts,                              // The Purge
	I_Cysts_Amount,                       // Cyst Cultivation
	I_Eggs,                               // Egg Collection
	I_Engines,                            // Start Your Engines
	I_Farm_Life,                          // Farm Life
	I_Foragers_Camp,                      // Foragers' Camp
	I_Funding_The_Expedition,             // Funding the Expedition
	I_Garden_Life,                        // Garden Life
	I_Herbalist,                          // Herbalist
	I_Houses,                             // No Place Like Home
	I_Houses_V2,                          // Safe Place
	I_Hunters,                            // Hunters
	I_Jerky,                              // Meat Lover
	I_Metal_Veins,                        // Metal Veins
	I_Multiply_Routes,                    // Raising the Stakes
	I_Pipes,                              // Hydraulics
	I_Porridge,                           // Healthy Breakfast
	I_Pump,                               // Beginner Engineer
	I_Ranch_Life,                         // Ranch Life
	I_Resolve_Beavers,                    // The Guild
	I_Resolve_Foxes,                      // The Pack
	I_Resolve_Harpies,                    // The Flock
	I_Resolve_Humans,                     // People's Resolve
	I_Resolve_Lizards,                    // The Clan
	I_Ruins,                              // Lost in the Woods
	I_Skewers,                            // Barbecue
	I_Solve_Any_Relic,                    // Problem Solver
	I_Solve_Dangerous_Relic,              // Tick Tock
	I_Storm_Water,                        // Basic Ingredient
	I_TO_Beaver_Resolve,                  // Joyful Beavers
	I_TO_Dangerous_Relics,                // Zealous Scouts
	I_TO_Fox_Resolve,                     // Joyful Foxes
	I_TO_Harpy_Resolve,                   // Joyful Harpies
	I_TO_HUB,                             // Speedy Real Estate
	I_TO_Human_Resolve,                   // Joyful Humans
	I_TO_Lizard_Resolve,                  // Joyful Lizards
	I_TO_Relic_Resolve,                   // Hurried Expedition
	I_TO_Ruins_And_Glades,                // Call of the Ruins
	I_TO_Sold_Amber,                      // Quick Transaction
	I_TO_Solve_Relics,                    // Impetuous Explorer
	I_Trade_Routes,                       // Businessman
	I_Trader_Value_Sold,                  // Booming Economy
	I_Upgrade_Pump,                       // Water Extraction
	I_Water,                              // Fill the Engines
	IA_Glades,                            // Exploration
	IA_Shelters,                          // Shelters
	IA_TO_Build_Shelters,                 // Housing Estate
	IA_TO_Discover_Glades,                // Distant Journey
	IA_Woodcutters_Camp,                  // Woodcutters
	IB_Beavers,                           // The Grove
	IB_Building_Packs,                    // Big Delivery
	IB_Camps,                             // Camps
	IB_Crops,                             // Rich Harvest
	IB_Foxes,                             // People of the Forest
	IB_Harpies,                           // The Nest
	IB_Humans,                            // Help From the Queen
	IB_Lizards,                           // Trappers
	IB_Paths,                             // Basic Logistics
	IB_Provisions_And_Crops,              // Delivery
	IB_Tablet,                            // Relics
	IB_Three_Packs,                       // Three Packs
	IB_TO_Three_Packs,                    // Quick Packaging
	IB_Trading_Post,                      // Trading Post
	IB_Wood,                              // Wood Delivery
	II_Advanced_Trading,                  // Advanced Trading
	II_Aid_For_The_Beaver_Faction,        // Aid For the Beaver Clan
	II_Aid_For_The_Fox_Faction,           // Aid for the Fox Pack
	II_Aid_For_The_Harpy_Faction,         // Aiding the Flock
	II_Aid_For_The_Human_Faction,         // Aid for the Human Clan
	II_Aid_For_The_Lizard_Faction,        // Aid for the Lizard Clan
	II_Artisan,                           // Pottery and Wine
	II_Beaver_Influx,                     // Beaver Influx
	II_Beaver_Population,                 // Beaver Population
	II_Blight_Post,                       // Fighting the Storm
	II_Brewery,                           // Happy Brewing
	II_Coats,                             // Clothing the People
	II_Convert,                           // Restoration
	II_Crops,                             // Advanced Farming
	II_Cysts,                             // Firestarter
	II_Dangerous_Glades,                  // Risky Expedition
	II_Engines,                           // Rain Engines
	II_Fox_Influx,                        // Fox Influx
	II_Fox_Population,                    // Fox Population
	II_Fuel_And_Building,                 // Important Delivery
	II_Glades,                            // Into the Wilds
	II_Glades_In_Time,                    // Into the Unknown
	II_Happy_Beavers,                     // Happy Beavers
	II_Happy_Foxes,                       // Happy Foxes
	II_Happy_Harpies,                     // Happy Harpies
	II_Happy_Humans,                      // Happy Humans
	II_Happy_Lizards,                     // Happy Lizards
	II_Harpy_Influx,                      // Harpy Influx
	II_Harpy_Population,                  // Harpy Population
	II_Human_Houses,                      // More Houses
	II_Human_Influx,                      // Human Influx
	II_Human_Population,                  // Human Population
	II_Jerky,                             // Meat Diet
	II_Jerky_For_Time,                    // Meat Treats
	II_Lizard_Influx,                     // Lizard Influx
	II_Lizard_Population,                 // Lizard Population
	II_Luxury_Packs,                      // Luxurious Delivery
	II_Means_Of_Production,               // Building Materials
	II_Multiply_Routes,                   // Stacking Amber
	II_Offering_Butcher,                  // Bloody Sacrifices
	II_Outpost,                           // Outposts
	II_Paths,                             // Infrastructure
	II_Population_Influx,                 // Population Influx
	II_Rainwater,                         // Water Delivery
	II_Route_Value,                       // Profit Margin
	II_Routes,                            // Seller
	II_Sacrifice,                         // Sacrificing
	II_Standing,                          // Making Connections
	II_Tablets,                           // Ancient Artifacts
	II_TO_Cut_NOTrees,                    // Work Break
	II_TO_Cut_Trees,                      // Need for Timber
	II_TO_Discover_Dangerous_Glades,      // Adventurous Viceroy
	II_TO_Forager_Trial___CRW,            // Forager's Trial
	II_TO_Forager_Trial___RW,             // Forager's Trial
	II_TO_Forager_Trial___SO,             // Forager's Trial
	II_TO_Gathering_Stone,                // Stonecutter's Trial
	II_TO_Glades_Discovery,               // Venturesome Leader
	II_TO_Herbalist_Trial___CRW,          // Herbalist's Trial
	II_TO_Herbalist_Trial___RW_SF,        // Herbalist's Trial
	II_TO_Herbalist_Trial___SO,           // Herbalist's Trial
	II_TO_Homes_For_Beavers,              // Beaver Colony
	II_TO_Homes_For_Foxes,                // Homes For Foxes
	II_TO_Homes_For_Harpies,              // Harpy Colony
	II_TO_Homes_For_Humans,               // Human Colony
	II_TO_Homes_For_Lizards,              // Lizard Colony
	II_TO_HUBs,                           // Outpost
	II_TO_Lumbermill,                     // Efficiency Test
	II_TO_Sacrificies,                    // Sacrificial Ceremony
	II_TO_Trappers_Trial___CF_SF,         // Trapper's Trial
	II_TO_Trappers_Trial___RW_M,          // Trapper's Trial
	II_Trade_Connections,                 // Trade Connections
	II_Use_Water,                         // Rainpunk Engineer
	II_Workshop,                          // Workshop
	III_Aesthethics,                      // Royal Gardens
	III_Ale_And_Tavern,                   // Cups and Glasses
	III_Amber_And_Market,                 // Charity Fair
	III_Ancient_Tablets,                  // Lost Knowledge
	III_Archaeology,                      // Archaeology
	III_Beaver_Relatives,                 // Beaver Relatives
	III_Building_Packs,                   // Building the Citadel
	III_Coats_NeedForTime,                // New Clothes
	III_Copper,                           // Industry
	III_Costly_Route,                     // Profitable Trade
	III_Cysts,                            // Pyromania
	III_Farmfields,                       // Agriculture
	III_Forum,                            // The Forum
	III_Fox_Relatives,                    // Fox Relatives
	III_Glades,                           // Trailblazing
	III_Glades_In_Time,                   // Hasty Explorer
	III_Harpy_Relatives,                  // Harpy Relatives
	III_Higene,                           // Cleanliness
	III_Hub,                              // Advanced District
	III_Human_Relatives,                  // Human Relatives
	III_Kiln,                             // Dirty Work
	III_Leisure_For_Time,                 // Basic Rights
	III_Lizard_Relatives,                 // Lizard Relatives
	III_Lost_Villagers,                   // Lost in the Woods
	III_Luxury,                           // Luxury
	III_Provisions_And_Crops,             // Rations for the Citadel
	III_Rain_Collector,                   // Advanced Logistics
	III_Religion,                         // Religion
	III_Resolve_Beavers,                  // Beaver Resolve
	III_Resolve_Foxes,                    // Fox Villagers
	III_Resolve_Harpies,                  // Harpy Villagers
	III_Resolve_Humans,                   // Human Villagers
	III_Resolve_Lizards,                  // Lizard Villagers
	III_Route_Value,                      // Fair Exchange
	III_Routes,                           // Export
	III_Routes_And_Amber,                 // Income Tax
	III_Royal_Gardens,                    // Aesthetics
	III_Ruins,                            // Ruins
	III_Scrolls_And_Temple,               // Brotherhood
	III_Send_To_Citadel,                  // Gifts for the Queen
	III_Service_Harpy,                    // Healing
	III_Service_Human,                    // Religious Rites
	III_Service_Lizard,                   // Arena
	III_Serving_Ale,                      // Serving Ale
	III_Solve_Chests,                     // Open or send caches
	III_Solve_Dangerous_Relic,            // Profitable Caution
	III_Standing,                         // Good Friends
	III_TO_Basic_Packs,                   // Basic Packages
	III_TO_Building_Packs,                // Building Rush
	III_TO_Chest_Chaser,                  // Chest Chaser
	III_TO_Dangerous_Stuff,               // Foolhardy Man
	III_TO_Digging_Coal,                  // Coal Fever
	III_TO_Digging_Ore,                   // Copper Fever
	III_TO_Engines_And_Water,             // Let It Rain
	III_TO_Explore_And_Deliver,           // Disturbing the Ancients
	III_TO_Forbidden_Glade,               // Devilish Curiosity
	III_TO_Glades_And_Tools,              // Forest Fascination
	III_TO_Rich_Trader,                   // Wealthy Trader
	III_TO_Ruins_And_Planks,              // Into the Ruins
	III_TO_Shiny,                         // Bling-Bling
	III_TO_Thirsty_Trader,                // Thirsty Trader
	III_TO_Water_Used,                    // The Source
	III_Trade_And_Spark,                  // Trade and Industry
	III_TradePacks,                       // Trading Goods
	III_Trader_Value_Sold,                // Booming Economy
	III_Use_Blue_Water,                   // Power of the Storm
	III_Use_Green_Water,                  // Power of the Drizzle
	III_Use_Yellow_Water,                 // Power of the Clearance
	III_Valuables,                        // Luxury Goods
	III_Varied_Delivery,                  // Varied Delivery
	III_Wine_And_Guild_House,             // Liquid Luck
	IV_2_Complex_Food_For_Time,           // Folks Gotta Eat!
	IV_Cysts,                             // Pyromancer
	IV_Dangerous_Glades,                  // Playing With Fire
	IV_Glades_In_Time,                    // All at Once
	IV_Peddler,                           // Peddler
	IV_Rainwater,                         // Infused Rainwater
	IV_Religion_For_Time,                 // The Cult of Fire
	IV_Route_Value,                       // Export Hub
	IV_Routes,                            // Trade Baron
	IV_TO_Fearless,                       // Fearless
	IV_TO_Forbidden_Glade,                // Ultimate Challenge
	IV_TO_Greedy_Merchant,                // Greedy Merchant
	IV_TO_Trading_Master,                 // Trading Master
	IV_Trade_And_Luxury_Packs,            // Trade and Luxury
	IV_Use_Water,                         // Rainpunk Enthusiast
	IVA_Building_And_Crops_Packs,         // Funding an Outpost
	IVA_Farmfields,                       // Focus on Farming
	IVA_Luxury_Goods,                     // Luxuries for the Citadel
	IVA_Master_Of_Exploration,            // Master of Exploration
	IVA_Outpost,                          // Advanced Outposts
	IVA_Pastries,                         // Pastries
	IVA_Serving_The_People,               // Serving the People
	IVA_Stone_Roads,                      // Stone Roads
	IVA_Tablets,                          // Deeper into the Wilds
	IVA_TO_Bonfire,                       // Great Expansion
	IVA_TO_Cooking,                       // Advanced Cuisine
	IVA_TO_Glades_Tablets_Relics,         // Time of Courage
	IVA_TO_Packing,                       // Large Parcel
	IVA_TO_Wood_And_Packs,                // Ravenous Axes
	IVA_Trade_Goods,                      // Goods for the Citadel
	IVA_Wood,                             // Wood and Provisions
	IVB_Beaver_Majority,                  // Beaver Majority
	IVB_Brawling,                         // Brawling
	IVB_Builders_Tools,                   // Builder's Tools
	IVB_Education,                        // Knowledge
	IVB_Fox_Majority,                     // Fox Majority
	IVB_Harpy_Majority,                   // Harpy Majority
	IVB_Human_Majority,                   // Human Majority
	IVB_Leisure,                          // Leisure
	IVB_Lizard_Majority,                  // Lizard Majority
	IVB_Rainproof_Coats,                  // Rainproof Coats
	IVB_Rich_Delivery,                    // Expensive Delivery
	IVB_TO_Building_Tools,                // Construction Work
	IVB_TO_Engines_Amount,                // Technological Progress
	IVB_TO_Food_Provision,                // Food Provision
	IVB_Travel_Rations,                   // Travel Rations
	IVB_Utopia,                           // Utopia
	Needs_Served,                         // Queen's Feathers
	Needs_Served_LOW,                     // Queen's Feathers
	R_Ghost_Assault_Trader, 
	R_Ghost_Cut_Trees, 
	R_Ghost_Decorations_Aesthetics, 
	R_Ghost_Decorations_Harmony, 
	R_Ghost_Discover_DangGlades, 
	R_Ghost_Discover_DangGlades_In_Time, 
	R_Ghost_Forbid_Needs_Beavers, 
	R_Ghost_Forbid_Needs_Foxes, 
	R_Ghost_Forbid_Needs_Harpies, 
	R_Ghost_Forbid_Needs_Humans, 
	R_Ghost_Forbid_Needs_Lizards, 
	R_Ghost_Generate_Cysts, 
	R_Ghost_Hostility_High, 
	R_Ghost_Hostility_Low, 
	R_Ghost_HUBs_Upgrade, 
	R_Ghost_Human_Houses, 
	R_Ghost_Keep_Goods, 
	R_Ghost_Keep_Villagers, 
	R_Ghost_Leisure, 
	R_Ghost_Luxury, 
	R_Ghost_Rebuild_Ruins, 
	R_Ghost_Religion, 
	R_Ghost_Remove_Cysts, 
	R_Ghost_Resolve_Foxes, 
	R_Ghost_Resolve_Harpies, 
	R_Ghost_Resolve_Lizards, 
	R_Ghost_Sacrifice_Goods, 
	R_Ghost_Salvage_Ruins, 
	R_Ghost_Send_Goods_To_Citadel, 
	R_Ghost_Solve_DangRelics, 
	R_Ghost_Starve_Beavers, 
	R_Ghost_Starve_Humans, 
	R_Ghost_Trade_Routes, 
	R_Ghost_Trade_Routes_With_Value, 
	R_Ghost_Trade_Routes_With_Value_Many, 
	R_Ghost_Use_Water, 
	Rep_From_Events,                      // Blood of the Stag
	Rep_From_Events_LOW,                  // Blood of the Stag
	Rep_From_Resolve,                     // Mortal Blood
	Rep_From_Resolve_LOW,                 // Mortal Blood
	Resolve,                              // Fire Essence
	Resolve_LOW,                          // Fire Essence
	Standing,                             // Golden Blood
	Standing_LOW,                         // Golden Blood
	T_II_Brewery,                         // Brewing Ale
	T_II_Farm,                            // Farming
	T_II_Provisions,                      // Provisions
	T_II_Resolve,                         // High Society
	T_II_Smokehouse,                      // Smokehouse
	T_II_Tavern,                          // A Place for Rest
	T_II_Trapper,                         // First Yield
	T_II_Woodcutters_Camp,                // Home & Hearth
	T_III_Amber,                          // Get Rich
	T_III_Beavers_Resolve,                // High Resolve
	T_III_Berries,                        // Collecting Berries
	T_III_Food,                           // Happy Meal
	T_III_Guild_House,                    // Fulfilling Needs
	T_III_Packs,                          // Buying & Selling
	T_III_Rain,                           // Catching Rainwater
	T_III_Sacrifice,                      // Surviving Requires Sacrifice
	T_III_Trading_Post,                   // Traders & Currency
	T_III_Wine,                           // Winemaking
	T_IV_Blightpost,                      // Blight Fighters
	T_IV_Caches,                          // Finders Keepers
	T_IV_Clan_Hall,                       // Stay in Shape
	T_IV_Engines,                         // Rainpunk Technology
	T_IV_Frobidden,                       // Forbidden Fruit
	T_IV_Metal,                           // Metallurgy
	T_IV_Mine,                            // Mining Basics
	T_IV_Pipes,                           // Pipe Manufacturing
	T_IV_Pump,                            // Water Extraction
	T_IV_Water_And_Cysts,                 // Effects of Technology
	TI_Building_Blocks,                   // Building Blocks
	TI_Deep_Exploration,                  // Ancient Tablets
	TI_Forager,                           // Food Supplies
	TI_Glades,                            // Exploring the Wilds
	TI_Scavenger,                         // Harvesters' Camp
	TI_Stonecutter,                       // Stonecutters' Camp
	TI_Woodcutters_Camp,                  // Woodcutters' Camps
	Trade_Packs_And_Perks_LOW,            // Golden Blood
	WaterUsed,                            // Essence of Corruption

    MAX = 361
}

public static class OrderTypesExtensions
{
	public static string ToName(this OrderTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of OrderTypes: " + type);
		return TypeToInternalName[OrderTypes.Amber_And_Luxury_LOW];
	}
	
	public static OrderModel ToOrderModel(this string name)
    {
        OrderModel model = SO.Settings.orders.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find OrderModel for OrderTypes with name: " + name);
        return null;
    }

	public static OrderModel ToOrderModel(this OrderTypes types)
	{
		return types.ToName().ToOrderModel();
	}
	
	public static OrderModel[] ToOrderModelArray(this IEnumerable<OrderTypes> collection)
    {
        int count = collection.Count();
        OrderModel[] array = new OrderModel[count];
        int i = 0;
        foreach (OrderTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.orders.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<OrderTypes, string> TypeToInternalName = new()
	{
		{ OrderTypes.Amber_And_Luxury_LOW, "Amber and Luxury LOW" },                                   // Essence of Wealth
		{ OrderTypes.Amber_Transaction, "Amber Transaction" },                                         // Crystal Feathers
		{ OrderTypes.Amber_Transaction_LOW, "Amber Transaction LOW" },                                 // Crystal Feathers
		{ OrderTypes.Ancient_Tablets, "Ancient Tablets" },                                             // Forbidden Essence
		{ OrderTypes.Ancient_Tablets_LOW, "Ancient Tablets LOW" },                                     // Forbidden Essence
		{ OrderTypes.Caches, "Caches" },                                                               // Heart of the Forest
		{ OrderTypes.Caches_LOW, "Caches LOW" },                                                       // Heart of the Forest
		{ OrderTypes.CystsRemoved, "CystsRemoved" },                                                   // Magnate
		{ OrderTypes.Deliver_Packs, "Deliver Packs" },                                                 // Heart of Amber
		{ OrderTypes.Deliver_Packs_LOW, "Deliver Packs LOW" },                                         // Heart of Amber
		{ OrderTypes.Deliver_Tools, "Deliver Tools" },                                                 // Metal Feathers
		{ OrderTypes.Deliver_Tools_LOW, "Deliver Tools LOW" },                                         // Metal Feathers
		{ OrderTypes.Discover_Forbidden_LOW, "Discover Forbidden LOW" },                               // Stormbird Feathers
		{ OrderTypes.Engines_Connected, "Engines Connected" },                                         // Mechanical Heart
		{ OrderTypes.Events_Decisions, "Events Decisions" },                                           // Blood of the Stag
		{ OrderTypes.Events_Decisions_LOW, "Events Decisions LOW" },                                   // Blood of the Stag
		{ OrderTypes.Heart_Parts_And_Sacrifice_LOW, "Heart Parts and Sacrifice LOW" },                 // Heart of the Ancient Flame
		{ OrderTypes.I_Amber, "I Amber" },                                                             // Amber Trade
		{ OrderTypes.I_Blighfuel, "I Blighfuel" },                                                     // Call to Arms
		{ OrderTypes.I_Blue_Metal, "I Blue Metal" },                                                   // Blue Metal
		{ OrderTypes.I_Botanist, "I Botanist" },                                                       // Botanist
		{ OrderTypes.I_Clearing_Glades, "I Clearing Glades" },                                         // Clearing Glades
		{ OrderTypes.I_Clothing, "I Clothing" },                                                       // Rain Protection
		{ OrderTypes.I_Cysts, "I Cysts" },                                                             // The Purge
		{ OrderTypes.I_Cysts_Amount, "I Cysts amount" },                                               // Cyst Cultivation
		{ OrderTypes.I_Eggs, "I Eggs" },                                                               // Egg Collection
		{ OrderTypes.I_Engines, "I Engines" },                                                         // Start Your Engines
		{ OrderTypes.I_Farm_Life, "I Farm Life" },                                                     // Farm Life
		{ OrderTypes.I_Foragers_Camp, "I Foragers Camp" },                                             // Foragers' Camp
		{ OrderTypes.I_Funding_The_Expedition, "I Funding the Expedition" },                           // Funding the Expedition
		{ OrderTypes.I_Garden_Life, "I Garden Life" },                                                 // Garden Life
		{ OrderTypes.I_Herbalist, "I Herbalist" },                                                     // Herbalist
		{ OrderTypes.I_Houses, "I Houses" },                                                           // No Place Like Home
		{ OrderTypes.I_Houses_V2, "I Houses v2" },                                                     // Safe Place
		{ OrderTypes.I_Hunters, "I Hunters" },                                                         // Hunters
		{ OrderTypes.I_Jerky, "I Jerky" },                                                             // Meat Lover
		{ OrderTypes.I_Metal_Veins, "I Metal Veins" },                                                 // Metal Veins
		{ OrderTypes.I_Multiply_Routes, "I Multiply Routes" },                                         // Raising the Stakes
		{ OrderTypes.I_Pipes, "I Pipes" },                                                             // Hydraulics
		{ OrderTypes.I_Porridge, "I Porridge" },                                                       // Healthy Breakfast
		{ OrderTypes.I_Pump, "I Pump" },                                                               // Beginner Engineer
		{ OrderTypes.I_Ranch_Life, "I Ranch Life" },                                                   // Ranch Life
		{ OrderTypes.I_Resolve_Beavers, "I Resolve Beavers" },                                         // The Guild
		{ OrderTypes.I_Resolve_Foxes, "I Resolve Foxes" },                                             // The Pack
		{ OrderTypes.I_Resolve_Harpies, "I Resolve Harpies" },                                         // The Flock
		{ OrderTypes.I_Resolve_Humans, "I Resolve Humans" },                                           // People's Resolve
		{ OrderTypes.I_Resolve_Lizards, "I Resolve Lizards" },                                         // The Clan
		{ OrderTypes.I_Ruins, "I Ruins" },                                                             // Lost in the Woods
		{ OrderTypes.I_Skewers, "I Skewers" },                                                         // Barbecue
		{ OrderTypes.I_Solve_Any_Relic, "I Solve Any Relic" },                                         // Problem Solver
		{ OrderTypes.I_Solve_Dangerous_Relic, "I Solve Dangerous Relic" },                             // Tick Tock
		{ OrderTypes.I_Storm_Water, "I Storm Water" },                                                 // Basic Ingredient
		{ OrderTypes.I_TO_Beaver_Resolve, "I TO Beaver Resolve" },                                     // Joyful Beavers
		{ OrderTypes.I_TO_Dangerous_Relics, "I TO Dangerous Relics" },                                 // Zealous Scouts
		{ OrderTypes.I_TO_Fox_Resolve, "I TO Fox Resolve" },                                           // Joyful Foxes
		{ OrderTypes.I_TO_Harpy_Resolve, "I TO Harpy Resolve" },                                       // Joyful Harpies
		{ OrderTypes.I_TO_HUB, "I TO HUB" },                                                           // Speedy Real Estate
		{ OrderTypes.I_TO_Human_Resolve, "I TO Human Resolve" },                                       // Joyful Humans
		{ OrderTypes.I_TO_Lizard_Resolve, "I TO Lizard Resolve" },                                     // Joyful Lizards
		{ OrderTypes.I_TO_Relic_Resolve, "I TO Relic Resolve" },                                       // Hurried Expedition
		{ OrderTypes.I_TO_Ruins_And_Glades, "I TO Ruins and Glades" },                                 // Call of the Ruins
		{ OrderTypes.I_TO_Sold_Amber, "I TO Sold Amber" },                                             // Quick Transaction
		{ OrderTypes.I_TO_Solve_Relics, "I TO Solve Relics" },                                         // Impetuous Explorer
		{ OrderTypes.I_Trade_Routes, "I Trade Routes" },                                               // Businessman
		{ OrderTypes.I_Trader_Value_Sold, "I Trader Value Sold" },                                     // Booming Economy
		{ OrderTypes.I_Upgrade_Pump, "I Upgrade Pump" },                                               // Water Extraction
		{ OrderTypes.I_Water, "I Water" },                                                             // Fill the Engines
		{ OrderTypes.IA_Glades, "IA Glades" },                                                         // Exploration
		{ OrderTypes.IA_Shelters, "IA Shelters" },                                                     // Shelters
		{ OrderTypes.IA_TO_Build_Shelters, "IA TO Build Shelters" },                                   // Housing Estate
		{ OrderTypes.IA_TO_Discover_Glades, "IA TO Discover Glades" },                                 // Distant Journey
		{ OrderTypes.IA_Woodcutters_Camp, "IA Woodcutters Camp" },                                     // Woodcutters
		{ OrderTypes.IB_Beavers, "IB Beavers" },                                                       // The Grove
		{ OrderTypes.IB_Building_Packs, "IB Building Packs" },                                         // Big Delivery
		{ OrderTypes.IB_Camps, "IB Camps" },                                                           // Camps
		{ OrderTypes.IB_Crops, "IB Crops" },                                                           // Rich Harvest
		{ OrderTypes.IB_Foxes, "IB Foxes" },                                                           // People of the Forest
		{ OrderTypes.IB_Harpies, "IB Harpies" },                                                       // The Nest
		{ OrderTypes.IB_Humans, "IB Humans" },                                                         // Help From the Queen
		{ OrderTypes.IB_Lizards, "IB Lizards" },                                                       // Trappers
		{ OrderTypes.IB_Paths, "IB Paths" },                                                           // Basic Logistics
		{ OrderTypes.IB_Provisions_And_Crops, "IB Provisions and Crops" },                             // Delivery
		{ OrderTypes.IB_Tablet, "IB Tablet" },                                                         // Relics
		{ OrderTypes.IB_Three_Packs, "IB Three Packs" },                                               // Three Packs
		{ OrderTypes.IB_TO_Three_Packs, "IB TO Three Packs" },                                         // Quick Packaging
		{ OrderTypes.IB_Trading_Post, "IB Trading Post" },                                             // Trading Post
		{ OrderTypes.IB_Wood, "IB Wood" },                                                             // Wood Delivery
		{ OrderTypes.II_Advanced_Trading, "II Advanced Trading" },                                     // Advanced Trading
		{ OrderTypes.II_Aid_For_The_Beaver_Faction, "II Aid for the Beaver Faction" },                 // Aid For the Beaver Clan
		{ OrderTypes.II_Aid_For_The_Fox_Faction, "II Aid for the Fox Faction" },                       // Aid for the Fox Pack
		{ OrderTypes.II_Aid_For_The_Harpy_Faction, "II Aid for the Harpy Faction" },                   // Aiding the Flock
		{ OrderTypes.II_Aid_For_The_Human_Faction, "II Aid for the Human Faction" },                   // Aid for the Human Clan
		{ OrderTypes.II_Aid_For_The_Lizard_Faction, "II Aid for the Lizard Faction" },                 // Aid for the Lizard Clan
		{ OrderTypes.II_Artisan, "II Artisan" },                                                       // Pottery and Wine
		{ OrderTypes.II_Beaver_Influx, "II Beaver Influx" },                                           // Beaver Influx
		{ OrderTypes.II_Beaver_Population, "II Beaver Population" },                                   // Beaver Population
		{ OrderTypes.II_Blight_Post, "II Blight Post" },                                               // Fighting the Storm
		{ OrderTypes.II_Brewery, "II Brewery" },                                                       // Happy Brewing
		{ OrderTypes.II_Coats, "II Coats" },                                                           // Clothing the People
		{ OrderTypes.II_Convert, "II Convert" },                                                       // Restoration
		{ OrderTypes.II_Crops, "II Crops" },                                                           // Advanced Farming
		{ OrderTypes.II_Cysts, "II Cysts" },                                                           // Firestarter
		{ OrderTypes.II_Dangerous_Glades, "II Dangerous Glades" },                                     // Risky Expedition
		{ OrderTypes.II_Engines, "II Engines" },                                                       // Rain Engines
		{ OrderTypes.II_Fox_Influx, "II Fox Influx" },                                                 // Fox Influx
		{ OrderTypes.II_Fox_Population, "II Fox Population" },                                         // Fox Population
		{ OrderTypes.II_Fuel_And_Building, "II Fuel and Building" },                                   // Important Delivery
		{ OrderTypes.II_Glades, "II Glades" },                                                         // Into the Wilds
		{ OrderTypes.II_Glades_In_Time, "II Glades in Time" },                                         // Into the Unknown
		{ OrderTypes.II_Happy_Beavers, "II Happy Beavers" },                                           // Happy Beavers
		{ OrderTypes.II_Happy_Foxes, "II Happy Foxes" },                                               // Happy Foxes
		{ OrderTypes.II_Happy_Harpies, "II Happy Harpies" },                                           // Happy Harpies
		{ OrderTypes.II_Happy_Humans, "II Happy Humans" },                                             // Happy Humans
		{ OrderTypes.II_Happy_Lizards, "II Happy Lizards" },                                           // Happy Lizards
		{ OrderTypes.II_Harpy_Influx, "II Harpy Influx" },                                             // Harpy Influx
		{ OrderTypes.II_Harpy_Population, "II Harpy Population" },                                     // Harpy Population
		{ OrderTypes.II_Human_Houses, "II Human Houses" },                                             // More Houses
		{ OrderTypes.II_Human_Influx, "II Human Influx" },                                             // Human Influx
		{ OrderTypes.II_Human_Population, "II Human Population" },                                     // Human Population
		{ OrderTypes.II_Jerky, "II Jerky" },                                                           // Meat Diet
		{ OrderTypes.II_Jerky_For_Time, "II Jerky For Time" },                                         // Meat Treats
		{ OrderTypes.II_Lizard_Influx, "II Lizard Influx" },                                           // Lizard Influx
		{ OrderTypes.II_Lizard_Population, "II Lizard Population" },                                   // Lizard Population
		{ OrderTypes.II_Luxury_Packs, "II Luxury Packs" },                                             // Luxurious Delivery
		{ OrderTypes.II_Means_Of_Production, "II Means of Production" },                               // Building Materials
		{ OrderTypes.II_Multiply_Routes, "II Multiply Routes" },                                       // Stacking Amber
		{ OrderTypes.II_Offering_Butcher, "II Offering Butcher" },                                     // Bloody Sacrifices
		{ OrderTypes.II_Outpost, "II Outpost" },                                                       // Outposts
		{ OrderTypes.II_Paths, "II Paths" },                                                           // Infrastructure
		{ OrderTypes.II_Population_Influx, "II Population Influx" },                                   // Population Influx
		{ OrderTypes.II_Rainwater, "II Rainwater" },                                                   // Water Delivery
		{ OrderTypes.II_Route_Value, "II Route Value" },                                               // Profit Margin
		{ OrderTypes.II_Routes, "II Routes" },                                                         // Seller
		{ OrderTypes.II_Sacrifice, "II Sacrifice" },                                                   // Sacrificing
		{ OrderTypes.II_Standing, "II Standing" },                                                     // Making Connections
		{ OrderTypes.II_Tablets, "II Tablets" },                                                       // Ancient Artifacts
		{ OrderTypes.II_TO_Cut_NOTrees, "II TO Cut NOTrees" },                                         // Work Break
		{ OrderTypes.II_TO_Cut_Trees, "II TO Cut Trees" },                                             // Need for Timber
		{ OrderTypes.II_TO_Discover_Dangerous_Glades, "II TO Discover Dangerous Glades" },             // Adventurous Viceroy
		{ OrderTypes.II_TO_Forager_Trial___CRW, "II TO Forager Trial - CRW" },                         // Forager's Trial
		{ OrderTypes.II_TO_Forager_Trial___RW, "II TO Forager Trial - RW" },                           // Forager's Trial
		{ OrderTypes.II_TO_Forager_Trial___SO, "II TO Forager Trial - SO" },                           // Forager's Trial
		{ OrderTypes.II_TO_Gathering_Stone, "II TO Gathering Stone" },                                 // Stonecutter's Trial
		{ OrderTypes.II_TO_Glades_Discovery, "II TO Glades Discovery" },                               // Venturesome Leader
		{ OrderTypes.II_TO_Herbalist_Trial___CRW, "II TO Herbalist Trial - CRW" },                     // Herbalist's Trial
		{ OrderTypes.II_TO_Herbalist_Trial___RW_SF, "II TO Herbalist Trial - RW SF" },                 // Herbalist's Trial
		{ OrderTypes.II_TO_Herbalist_Trial___SO, "II TO Herbalist Trial - SO" },                       // Herbalist's Trial
		{ OrderTypes.II_TO_Homes_For_Beavers, "II TO Homes for Beavers" },                             // Beaver Colony
		{ OrderTypes.II_TO_Homes_For_Foxes, "II TO Homes for Foxes" },                                 // Homes For Foxes
		{ OrderTypes.II_TO_Homes_For_Harpies, "II TO Homes for Harpies" },                             // Harpy Colony
		{ OrderTypes.II_TO_Homes_For_Humans, "II TO Homes for Humans" },                               // Human Colony
		{ OrderTypes.II_TO_Homes_For_Lizards, "II TO Homes for Lizards" },                             // Lizard Colony
		{ OrderTypes.II_TO_HUBs, "II TO HUBs" },                                                       // Outpost
		{ OrderTypes.II_TO_Lumbermill, "II TO Lumbermill" },                                           // Efficiency Test
		{ OrderTypes.II_TO_Sacrificies, "II TO Sacrificies" },                                         // Sacrificial Ceremony
		{ OrderTypes.II_TO_Trappers_Trial___CF_SF, "II TO Trappers Trial - CF SF" },                   // Trapper's Trial
		{ OrderTypes.II_TO_Trappers_Trial___RW_M, "II TO Trappers Trial - RW M" },                     // Trapper's Trial
		{ OrderTypes.II_Trade_Connections, "II Trade Connections" },                                   // Trade Connections
		{ OrderTypes.II_Use_Water, "II Use Water" },                                                   // Rainpunk Engineer
		{ OrderTypes.II_Workshop, "II Workshop" },                                                     // Workshop
		{ OrderTypes.III_Aesthethics, "III Aesthethics" },                                             // Royal Gardens
		{ OrderTypes.III_Ale_And_Tavern, "III Ale and Tavern" },                                       // Cups and Glasses
		{ OrderTypes.III_Amber_And_Market, "III Amber and Market" },                                   // Charity Fair
		{ OrderTypes.III_Ancient_Tablets, "III Ancient Tablets" },                                     // Lost Knowledge
		{ OrderTypes.III_Archaeology, "III Archaeology" },                                             // Archaeology
		{ OrderTypes.III_Beaver_Relatives, "III Beaver Relatives" },                                   // Beaver Relatives
		{ OrderTypes.III_Building_Packs, "III Building Packs" },                                       // Building the Citadel
		{ OrderTypes.III_Coats_NeedForTime, "III Coats NeedForTime" },                                 // New Clothes
		{ OrderTypes.III_Copper, "III Copper" },                                                       // Industry
		{ OrderTypes.III_Costly_Route, "III Costly Route" },                                           // Profitable Trade
		{ OrderTypes.III_Cysts, "III Cysts" },                                                         // Pyromania
		{ OrderTypes.III_Farmfields, "III Farmfields" },                                               // Agriculture
		{ OrderTypes.III_Forum, "III Forum" },                                                         // The Forum
		{ OrderTypes.III_Fox_Relatives, "III Fox Relatives" },                                         // Fox Relatives
		{ OrderTypes.III_Glades, "III Glades" },                                                       // Trailblazing
		{ OrderTypes.III_Glades_In_Time, "III Glades in Time" },                                       // Hasty Explorer
		{ OrderTypes.III_Harpy_Relatives, "III Harpy Relatives" },                                     // Harpy Relatives
		{ OrderTypes.III_Higene, "III Higene" },                                                       // Cleanliness
		{ OrderTypes.III_Hub, "III Hub" },                                                             // Advanced District
		{ OrderTypes.III_Human_Relatives, "III Human Relatives" },                                     // Human Relatives
		{ OrderTypes.III_Kiln, "III Kiln" },                                                           // Dirty Work
		{ OrderTypes.III_Leisure_For_Time, "III Leisure for Time" },                                   // Basic Rights
		{ OrderTypes.III_Lizard_Relatives, "III Lizard Relatives" },                                   // Lizard Relatives
		{ OrderTypes.III_Lost_Villagers, "III Lost Villagers" },                                       // Lost in the Woods
		{ OrderTypes.III_Luxury, "III Luxury" },                                                       // Luxury
		{ OrderTypes.III_Provisions_And_Crops, "III Provisions and Crops" },                           // Rations for the Citadel
		{ OrderTypes.III_Rain_Collector, "III Rain Collector" },                                       // Advanced Logistics
		{ OrderTypes.III_Religion, "III Religion" },                                                   // Religion
		{ OrderTypes.III_Resolve_Beavers, "III Resolve Beavers" },                                     // Beaver Resolve
		{ OrderTypes.III_Resolve_Foxes, "III Resolve Foxes" },                                         // Fox Villagers
		{ OrderTypes.III_Resolve_Harpies, "III Resolve Harpies" },                                     // Harpy Villagers
		{ OrderTypes.III_Resolve_Humans, "III Resolve Humans" },                                       // Human Villagers
		{ OrderTypes.III_Resolve_Lizards, "III Resolve Lizards" },                                     // Lizard Villagers
		{ OrderTypes.III_Route_Value, "III Route Value" },                                             // Fair Exchange
		{ OrderTypes.III_Routes, "III Routes" },                                                       // Export
		{ OrderTypes.III_Routes_And_Amber, "III Routes And Amber" },                                   // Income Tax
		{ OrderTypes.III_Royal_Gardens, "III Royal Gardens" },                                         // Aesthetics
		{ OrderTypes.III_Ruins, "III Ruins" },                                                         // Ruins
		{ OrderTypes.III_Scrolls_And_Temple, "III Scrolls and Temple" },                               // Brotherhood
		{ OrderTypes.III_Send_To_Citadel, "III Send to Citadel" },                                     // Gifts for the Queen
		{ OrderTypes.III_Service_Harpy, "III Service Harpy" },                                         // Healing
		{ OrderTypes.III_Service_Human, "III Service Human" },                                         // Religious Rites
		{ OrderTypes.III_Service_Lizard, "III Service Lizard" },                                       // Arena
		{ OrderTypes.III_Serving_Ale, "III Serving Ale" },                                             // Serving Ale
		{ OrderTypes.III_Solve_Chests, "III Solve Chests" },                                           // Open or send caches
		{ OrderTypes.III_Solve_Dangerous_Relic, "III Solve Dangerous Relic" },                         // Profitable Caution
		{ OrderTypes.III_Standing, "III Standing" },                                                   // Good Friends
		{ OrderTypes.III_TO_Basic_Packs, "III TO Basic Packs" },                                       // Basic Packages
		{ OrderTypes.III_TO_Building_Packs, "III TO Building Packs" },                                 // Building Rush
		{ OrderTypes.III_TO_Chest_Chaser, "III TO Chest Chaser" },                                     // Chest Chaser
		{ OrderTypes.III_TO_Dangerous_Stuff, "III TO Dangerous Stuff" },                               // Foolhardy Man
		{ OrderTypes.III_TO_Digging_Coal, "III TO Digging Coal" },                                     // Coal Fever
		{ OrderTypes.III_TO_Digging_Ore, "III TO Digging Ore" },                                       // Copper Fever
		{ OrderTypes.III_TO_Engines_And_Water, "III TO Engines and Water" },                           // Let It Rain
		{ OrderTypes.III_TO_Explore_And_Deliver, "III TO Explore and Deliver" },                       // Disturbing the Ancients
		{ OrderTypes.III_TO_Forbidden_Glade, "III TO Forbidden Glade" },                               // Devilish Curiosity
		{ OrderTypes.III_TO_Glades_And_Tools, "III TO Glades and Tools" },                             // Forest Fascination
		{ OrderTypes.III_TO_Rich_Trader, "III TO Rich Trader" },                                       // Wealthy Trader
		{ OrderTypes.III_TO_Ruins_And_Planks, "III TO Ruins and Planks" },                             // Into the Ruins
		{ OrderTypes.III_TO_Shiny, "III TO Shiny" },                                                   // Bling-Bling
		{ OrderTypes.III_TO_Thirsty_Trader, "III TO Thirsty Trader" },                                 // Thirsty Trader
		{ OrderTypes.III_TO_Water_Used, "III TO Water Used" },                                         // The Source
		{ OrderTypes.III_Trade_And_Spark, "III Trade and Spark" },                                     // Trade and Industry
		{ OrderTypes.III_TradePacks, "III TradePacks" },                                               // Trading Goods
		{ OrderTypes.III_Trader_Value_Sold, "III Trader Value Sold" },                                 // Booming Economy
		{ OrderTypes.III_Use_Blue_Water, "III Use Blue Water" },                                       // Power of the Storm
		{ OrderTypes.III_Use_Green_Water, "III Use Green Water" },                                     // Power of the Drizzle
		{ OrderTypes.III_Use_Yellow_Water, "III Use Yellow Water" },                                   // Power of the Clearance
		{ OrderTypes.III_Valuables, "III Valuables" },                                                 // Luxury Goods
		{ OrderTypes.III_Varied_Delivery, "III Varied Delivery" },                                     // Varied Delivery
		{ OrderTypes.III_Wine_And_Guild_House, "III Wine and Guild House" },                           // Liquid Luck
		{ OrderTypes.IV_2_Complex_Food_For_Time, "IV 2 Complex Food for Time" },                       // Folks Gotta Eat!
		{ OrderTypes.IV_Cysts, "IV Cysts" },                                                           // Pyromancer
		{ OrderTypes.IV_Dangerous_Glades, "IV Dangerous Glades" },                                     // Playing With Fire
		{ OrderTypes.IV_Glades_In_Time, "IV Glades in Time" },                                         // All at Once
		{ OrderTypes.IV_Peddler, "IV Peddler" },                                                       // Peddler
		{ OrderTypes.IV_Rainwater, "IV Rainwater" },                                                   // Infused Rainwater
		{ OrderTypes.IV_Religion_For_Time, "IV Religion for Time" },                                   // The Cult of Fire
		{ OrderTypes.IV_Route_Value, "IV Route Value" },                                               // Export Hub
		{ OrderTypes.IV_Routes, "IV Routes" },                                                         // Trade Baron
		{ OrderTypes.IV_TO_Fearless, "IV TO Fearless" },                                               // Fearless
		{ OrderTypes.IV_TO_Forbidden_Glade, "IV TO Forbidden Glade" },                                 // Ultimate Challenge
		{ OrderTypes.IV_TO_Greedy_Merchant, "IV TO Greedy Merchant" },                                 // Greedy Merchant
		{ OrderTypes.IV_TO_Trading_Master, "IV TO Trading Master" },                                   // Trading Master
		{ OrderTypes.IV_Trade_And_Luxury_Packs, "IV Trade and Luxury Packs" },                         // Trade and Luxury
		{ OrderTypes.IV_Use_Water, "IV Use Water" },                                                   // Rainpunk Enthusiast
		{ OrderTypes.IVA_Building_And_Crops_Packs, "IVA Building and Crops Packs" },                   // Funding an Outpost
		{ OrderTypes.IVA_Farmfields, "IVA Farmfields" },                                               // Focus on Farming
		{ OrderTypes.IVA_Luxury_Goods, "IVA Luxury Goods" },                                           // Luxuries for the Citadel
		{ OrderTypes.IVA_Master_Of_Exploration, "IVA Master of Exploration" },                         // Master of Exploration
		{ OrderTypes.IVA_Outpost, "IVA Outpost" },                                                     // Advanced Outposts
		{ OrderTypes.IVA_Pastries, "IVA Pastries" },                                                   // Pastries
		{ OrderTypes.IVA_Serving_The_People, "IVA Serving the People" },                               // Serving the People
		{ OrderTypes.IVA_Stone_Roads, "IVA Stone Roads" },                                             // Stone Roads
		{ OrderTypes.IVA_Tablets, "IVA Tablets" },                                                     // Deeper into the Wilds
		{ OrderTypes.IVA_TO_Bonfire, "IVA TO Bonfire" },                                               // Great Expansion
		{ OrderTypes.IVA_TO_Cooking, "IVA TO Cooking" },                                               // Advanced Cuisine
		{ OrderTypes.IVA_TO_Glades_Tablets_Relics, "IVA TO Glades Tablets Relics" },                   // Time of Courage
		{ OrderTypes.IVA_TO_Packing, "IVA TO Packing" },                                               // Large Parcel
		{ OrderTypes.IVA_TO_Wood_And_Packs, "IVA TO Wood and Packs" },                                 // Ravenous Axes
		{ OrderTypes.IVA_Trade_Goods, "IVA Trade Goods" },                                             // Goods for the Citadel
		{ OrderTypes.IVA_Wood, "IVA Wood" },                                                           // Wood and Provisions
		{ OrderTypes.IVB_Beaver_Majority, "IVB Beaver Majority" },                                     // Beaver Majority
		{ OrderTypes.IVB_Brawling, "IVB Brawling" },                                                   // Brawling
		{ OrderTypes.IVB_Builders_Tools, "IVB Builders Tools" },                                       // Builder's Tools
		{ OrderTypes.IVB_Education, "IVB Education" },                                                 // Knowledge
		{ OrderTypes.IVB_Fox_Majority, "IVB Fox Majority" },                                           // Fox Majority
		{ OrderTypes.IVB_Harpy_Majority, "IVB Harpy Majority" },                                       // Harpy Majority
		{ OrderTypes.IVB_Human_Majority, "IVB Human Majority" },                                       // Human Majority
		{ OrderTypes.IVB_Leisure, "IVB Leisure" },                                                     // Leisure
		{ OrderTypes.IVB_Lizard_Majority, "IVB Lizard Majority" },                                     // Lizard Majority
		{ OrderTypes.IVB_Rainproof_Coats, "IVB Rainproof Coats" },                                     // Rainproof Coats
		{ OrderTypes.IVB_Rich_Delivery, "IVB Rich Delivery" },                                         // Expensive Delivery
		{ OrderTypes.IVB_TO_Building_Tools, "IVB TO Building Tools" },                                 // Construction Work
		{ OrderTypes.IVB_TO_Engines_Amount, "IVB TO Engines Amount" },                                 // Technological Progress
		{ OrderTypes.IVB_TO_Food_Provision, "IVB TO Food Provision" },                                 // Food Provision
		{ OrderTypes.IVB_Travel_Rations, "IVB Travel Rations" },                                       // Travel Rations
		{ OrderTypes.IVB_Utopia, "IVB Utopia" },                                                       // Utopia
		{ OrderTypes.Needs_Served, "Needs Served" },                                                   // Queen's Feathers
		{ OrderTypes.Needs_Served_LOW, "Needs Served LOW" },                                           // Queen's Feathers
		{ OrderTypes.R_Ghost_Assault_Trader, "[R] Ghost Assault Trader" }, 
		{ OrderTypes.R_Ghost_Cut_Trees, "[R] Ghost Cut Trees" }, 
		{ OrderTypes.R_Ghost_Decorations_Aesthetics, "[R] Ghost Decorations Aesthetics" }, 
		{ OrderTypes.R_Ghost_Decorations_Harmony, "[R] Ghost Decorations Harmony" }, 
		{ OrderTypes.R_Ghost_Discover_DangGlades, "[R] Ghost Discover DangGlades" }, 
		{ OrderTypes.R_Ghost_Discover_DangGlades_In_Time, "[R] Ghost Discover DangGlades in Time" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Beavers, "[R] Ghost Forbid Needs Beavers" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Foxes, "[R] Ghost Forbid Needs Foxes" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Harpies, "[R] Ghost Forbid Needs Harpies" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Humans, "[R] Ghost Forbid Needs Humans" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Lizards, "[R] Ghost Forbid Needs Lizards" }, 
		{ OrderTypes.R_Ghost_Generate_Cysts, "[R] Ghost Generate Cysts" }, 
		{ OrderTypes.R_Ghost_Hostility_High, "[R] Ghost Hostility High" }, 
		{ OrderTypes.R_Ghost_Hostility_Low, "[R] Ghost Hostility Low" }, 
		{ OrderTypes.R_Ghost_HUBs_Upgrade, "[R] Ghost HUBs upgrade" }, 
		{ OrderTypes.R_Ghost_Human_Houses, "[R] Ghost Human Houses" }, 
		{ OrderTypes.R_Ghost_Keep_Goods, "[R] Ghost Keep Goods" }, 
		{ OrderTypes.R_Ghost_Keep_Villagers, "[R] Ghost Keep Villagers" }, 
		{ OrderTypes.R_Ghost_Leisure, "[R] Ghost Leisure" }, 
		{ OrderTypes.R_Ghost_Luxury, "[R] Ghost Luxury" }, 
		{ OrderTypes.R_Ghost_Rebuild_Ruins, "[R] Ghost Rebuild Ruins" }, 
		{ OrderTypes.R_Ghost_Religion, "[R] Ghost Religion" }, 
		{ OrderTypes.R_Ghost_Remove_Cysts, "[R] Ghost Remove Cysts" }, 
		{ OrderTypes.R_Ghost_Resolve_Foxes, "[R] Ghost Resolve Foxes" }, 
		{ OrderTypes.R_Ghost_Resolve_Harpies, "[R] Ghost Resolve Harpies" }, 
		{ OrderTypes.R_Ghost_Resolve_Lizards, "[R] Ghost Resolve Lizards" }, 
		{ OrderTypes.R_Ghost_Sacrifice_Goods, "[R] Ghost Sacrifice Goods" }, 
		{ OrderTypes.R_Ghost_Salvage_Ruins, "[R] Ghost Salvage Ruins" }, 
		{ OrderTypes.R_Ghost_Send_Goods_To_Citadel, "[R] Ghost Send Goods to Citadel" }, 
		{ OrderTypes.R_Ghost_Solve_DangRelics, "[R] Ghost Solve DangRelics" }, 
		{ OrderTypes.R_Ghost_Starve_Beavers, "[R] Ghost Starve Beavers" }, 
		{ OrderTypes.R_Ghost_Starve_Humans, "[R] Ghost Starve Humans" }, 
		{ OrderTypes.R_Ghost_Trade_Routes, "[R] Ghost Trade Routes" }, 
		{ OrderTypes.R_Ghost_Trade_Routes_With_Value, "[R] Ghost Trade Routes with Value" }, 
		{ OrderTypes.R_Ghost_Trade_Routes_With_Value_Many, "[R] Ghost Trade Routes with Value Many" }, 
		{ OrderTypes.R_Ghost_Use_Water, "[R] Ghost Use Water" }, 
		{ OrderTypes.Rep_From_Events, "Rep from Events" },                                             // Blood of the Stag
		{ OrderTypes.Rep_From_Events_LOW, "Rep from Events LOW" },                                     // Blood of the Stag
		{ OrderTypes.Rep_From_Resolve, "Rep from Resolve" },                                           // Mortal Blood
		{ OrderTypes.Rep_From_Resolve_LOW, "Rep from Resolve LOW" },                                   // Mortal Blood
		{ OrderTypes.Resolve, "Resolve" },                                                             // Fire Essence
		{ OrderTypes.Resolve_LOW, "Resolve LOW" },                                                     // Fire Essence
		{ OrderTypes.Standing, "Standing" },                                                           // Golden Blood
		{ OrderTypes.Standing_LOW, "Standing LOW" },                                                   // Golden Blood
		{ OrderTypes.T_II_Brewery, "T II Brewery" },                                                   // Brewing Ale
		{ OrderTypes.T_II_Farm, "T II Farm" },                                                         // Farming
		{ OrderTypes.T_II_Provisions, "T II Provisions" },                                             // Provisions
		{ OrderTypes.T_II_Resolve, "T II Resolve" },                                                   // High Society
		{ OrderTypes.T_II_Smokehouse, "T II Smokehouse" },                                             // Smokehouse
		{ OrderTypes.T_II_Tavern, "T II Tavern" },                                                     // A Place for Rest
		{ OrderTypes.T_II_Trapper, "T II Trapper" },                                                   // First Yield
		{ OrderTypes.T_II_Woodcutters_Camp, "T II Woodcutters Camp" },                                 // Home & Hearth
		{ OrderTypes.T_III_Amber, "T III Amber" },                                                     // Get Rich
		{ OrderTypes.T_III_Beavers_Resolve, "T III Beavers Resolve" },                                 // High Resolve
		{ OrderTypes.T_III_Berries, "T III Berries" },                                                 // Collecting Berries
		{ OrderTypes.T_III_Food, "T III Food" },                                                       // Happy Meal
		{ OrderTypes.T_III_Guild_House, "T III Guild House" },                                         // Fulfilling Needs
		{ OrderTypes.T_III_Packs, "T III Packs" },                                                     // Buying & Selling
		{ OrderTypes.T_III_Rain, "T III Rain" },                                                       // Catching Rainwater
		{ OrderTypes.T_III_Sacrifice, "T III Sacrifice" },                                             // Surviving Requires Sacrifice
		{ OrderTypes.T_III_Trading_Post, "T III Trading Post" },                                       // Traders & Currency
		{ OrderTypes.T_III_Wine, "T III Wine" },                                                       // Winemaking
		{ OrderTypes.T_IV_Blightpost, "T IV Blightpost" },                                             // Blight Fighters
		{ OrderTypes.T_IV_Caches, "T IV Caches" },                                                     // Finders Keepers
		{ OrderTypes.T_IV_Clan_Hall, "T IV Clan Hall" },                                               // Stay in Shape
		{ OrderTypes.T_IV_Engines, "T IV Engines" },                                                   // Rainpunk Technology
		{ OrderTypes.T_IV_Frobidden, "T IV Frobidden" },                                               // Forbidden Fruit
		{ OrderTypes.T_IV_Metal, "T IV Metal" },                                                       // Metallurgy
		{ OrderTypes.T_IV_Mine, "T IV Mine" },                                                         // Mining Basics
		{ OrderTypes.T_IV_Pipes, "T IV Pipes" },                                                       // Pipe Manufacturing
		{ OrderTypes.T_IV_Pump, "T IV Pump" },                                                         // Water Extraction
		{ OrderTypes.T_IV_Water_And_Cysts, "T IV Water & Cysts" },                                     // Effects of Technology
		{ OrderTypes.TI_Building_Blocks, "TI Building Blocks" },                                       // Building Blocks
		{ OrderTypes.TI_Deep_Exploration, "TI Deep Exploration" },                                     // Ancient Tablets
		{ OrderTypes.TI_Forager, "TI Forager" },                                                       // Food Supplies
		{ OrderTypes.TI_Glades, "TI Glades" },                                                         // Exploring the Wilds
		{ OrderTypes.TI_Scavenger, "TI Scavenger" },                                                   // Harvesters' Camp
		{ OrderTypes.TI_Stonecutter, "TI Stonecutter" },                                               // Stonecutters' Camp
		{ OrderTypes.TI_Woodcutters_Camp, "TI Woodcutters Camp" },                                     // Woodcutters' Camps
		{ OrderTypes.Trade_Packs_And_Perks_LOW, "Trade Packs and Perks LOW" },                         // Golden Blood
		{ OrderTypes.WaterUsed, "WaterUsed" },                                                         // Essence of Corruption
	};
}
