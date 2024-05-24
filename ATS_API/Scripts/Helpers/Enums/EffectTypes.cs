using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum EffectTypes
{
    Unknown = -1,
    None,
	_0_10_On_Roads,                                                    // Shovels
	_0_2_Reputation_Penalty, 
	_0_25_On_Roads, 
	_0_5_Reputation_Donation,                                          // Generous Donation
	_0_5_Reputation_Exploration,                                       // Queen's Grace
	_0_5_Reputation_Exploration___Seasonal_Effect,                     // Queen's Grace
	_0_5_Reputation_Penalty, 
	_0_5_Reputation_Penalty___Corrupted_Caravan,                       // Filthy Trick
	_0_5_Reputation_Penalty___Ghost,                                   // Disappointment
	_0_5_Reputation_Penalty___Merchant_Ship_Wreck,                     // Cowardice
	_0_5_Reputation_Penalty___Minus, 
	_0_75_Reputation_Donation,                                         // Generous Donation
	_0_75_Reputation_Exploration,                                      // Queen's Grace
	_1_Killed_For_Glade_Event,                                         // Sacrificial Rituals
	_1_Reputation_Exploration,                                         // Queen's Grace
	_1_Reputation_Exploration___Stormbird,                             // Queen's Grace
	_1_Reputation_Order,                                               // Queen's Grace
	_1_Reputation_Penalty, 
	_1_Reputation_Penalty___Caravan,                                   // Cleanup Duty
	_1_Reputation_Penalty___Convicts,                                  // Cleanup Duty
	_1_Reputation_Penalty___Corupted_Caravan,                          // Cleanup Duty
	_1_Reputation_Penalty___Decay_Altar,                               // Cleanup Duty
	_1_Reputation_Penalty___Fishmen_Cave,                              // Cleanup Duty
	_1_Reputation_Penalty___Fishmen_Lighthouse,                        // Cleanup Duty
	_1_Reputation_Penalty___Fishmen_Soothsyer,                         // Cleanup Duty
	_1_Reputation_Penalty___Forsaken_Crypt,                            // Cleanup Duty
	_1_Reputation_Penalty___Harmony_Spirit_Altar,                      // Cleanup Duty
	_1_Reputation_Penalty___Sealed_Tomb,                               // Irresponsible Archaeology
	_1_Reputation_Penalty___Stormbird,                                 // Cleanup Duty
	_1_Reputation_Penalty___Totem,                                     // Cleanup Duty
	_1_Reputation_Penalty___Trader_Cementary,                          // Cleanup Duty
	_1_Reputation_Penalty___Vassal_Tax,                                // Queen's Wrath (Vassal Tax)
	_1_Reputation_Penalty_Decision,                                    // Infamy
	_1_Reputation_Trade,                                               // Queen's Grace
	_2_Hauling_Carts_In_Main_Warehouse,                                // Dual Carriage System
	_2_Reputation_Penalty,                                             // Queen's Wrath
	_2_Reputation_Penalty_Decision,                                    // Queen's Wrath
	_20_Random_Goods, 
	_3_Reputation_Exploration,                                         // The Queen's Respect
	_3_Reputation_Penalty,                                             // Queen's Wrath
	_30_Random_Raw_Food, 
	_5_Random_Packs,                                                   // Finders Keepers
	Accidental_Barrels,                                                // Over-Diligent Woodworkers
	Accidental_Bricks,                                                 // Repurposed Clay
	Accidental_Crystalized_Dew,                                        // Accumulated Dew
	Accidental_Harpy,                                                  // Chicken or Egg?
	Accidental_Jerky,                                                  // Sahilda's Secret Cookbook
	Accidental_Lizard,                                                 // Surprise Child
	Accidental_Oil,                                                    // Small Press
	Accidental_Pigment,                                                // Dye Extractor
	Accidental_Provisions,                                             // Peasant Supplies
	Accidental_Skewers,                                                // Zhorg's Secret Ingredient
	Accidental_Wine,                                                   // Dual Brewing Tools
	Additional_Impatience_For_Death, 
	Advanced_Rain_Collector_Blueprint,                                 // Forsaken Altar
	Agriculture_Penalty,                                               // Industrialized Agriculture
	Alarm_Bells,                                                       // Alarm Bells
	Alchemist_Blueprint,                                               // Alchemist's Hut
	Ale_10,                                                            // Barrels of Ale
	Ale_15,                                                            // Barrels of Ale
	Ale_20,                                                            // Barrels of Ale
	Ale_30,                                                            // Barrels of Ale
	Ale_35,                                                            // Barrels of Ale
	Ale_3pm,                                                           // Ale Delivery Line
	Ale_40,                                                            // Barrels of Ale
	Ale_5,                                                             // Barrels of Ale
	Ale_50,                                                            // Barrels of Ale
	Ale_5pm,                                                           // Ale Delivery Line
	Ale_Plus1,                                                         // Bigger Barrels
	Ale_Plus2,                                                         // Bigger Barrels
	Ale_Plus3,                                                         // Bigger Barrels
	Ale_Plus5,                                                         // Bigger Barrels
	All_Camps_Unlock,                                                  // Master Blueprint
	All_Camps_Unlock___Slow_Gathering,                                 // Master Blueprint
	All_Camps_Unlock___Slow_Gathering___Holder,                        // Overwhelmed Gatherers
	All_Waters_Per_Min, 
	Altar_Accidental_Barrels,                                          // Over-Diligent Woodworkers (Stormforged)
	Altar_Accidental_Oil,                                              // Small Press (Stormforged)
	Altar_Accidental_Pigment,                                          // Dye Extractor (Stormforged)
	Altar_Activation, 
	Altar_Alarm_Bells,                                                 // Alarm Bells (Stormforged)
	Altar_Amber_For_Trade_Routes,                                      // Deep Pockets (Stormforged)
	Altar_AncientGate_Hardships,                                       // Survivor Bonding (Stormforged)
	Altar_Back_To_Nature,                                              // Back to Nature (Stormforged)
	Altar_Beaver_Resolve_For_Wine_Prod,                                // Vineyard Town (Stormforged)
	Altar_Blood_Price,                                                 // Blood Price Contract (Stormforged)
	Altar_Blueprint,                                                   // Forsaken Altar
	Altar_Cannibalism,                                                 // Cannibalism (Stormforged)
	Altar_Construction_Cost_For_Nodes,                                 // Cheap Construction (Stormforged)
	Altar_Copper_For_Each_Tree,                                        // Copper Extractor (Stormforged)
	Altar_Cornerstone_Reroll,                                          // >Missing key< (Stormforged)
	Altar_Cornerstone_Reroll_Each_Year,                                // Forsaken Seal (Stormforged)
	Altar_Crops_For_Grain,                                             // Leftover Crops (Stormforged)
	Altar_Fedora_Hat,                                                  // Old Fedora Hat (Stormforged)
	Altar_Forge_Trip_Hammer,                                           // Forge Trip Hammer (Stormforged)
	Altar_Fuel_Recipes_Rate,                                           // Advanced Fuel (Stormforged)
	Altar_FuelConsumption__25,                                         // Secret Techniques of the Firekeeper (Stormforged)
	Altar_Harpy_Resolve_For_Tea_Prod,                                  // Tea Specialization (Stormforged)
	Altar_Herb_Production_For_Biscuits,                                // Spices (Stormforged)
	Altar_Hidden_From_The_Queen,                                       // Hidden from the Queen (Stormforged)
	Altar_Houses_Plus1_For_Break_Time,                                 // Crowded Houses (Stormforged)
	Altar_HP_For_Impatience,                                           // Queen's Gift (Stormforged)
	Altar_Hubs_For_Newcomer_Goods,                                     // Generous Gifts (Stormforged)
	Altar_Human_Resolve_For_Incense_Prod,                              // Religious Settlement (Stormforged)
	Altar_HunterGatherers,                                             // Hunter-Gatherers (Stormforged)
	Altar_Insect_For_Tree,                                             // Woodpecker Technique (Stormforged)
	Altar_Insect_For_Tree___Child,                                     // Woodpecker Technique
	Altar_Killed_For_GladeInfo,                                        // Ancient Pact (Stormforged)
	Altar_LessHostilityPerWoodcutter,                                  // Flame Amulets (Stormforged)
	Altar_Lizard_Resolve_For_Training_Gear_Prod,                       // Training Grounds (Stormforged)
	Altar_Longer_Storm_For_Wood_Production,                            // Ancient Stabilizer (Stormforged)
	Altar_Lower_Hostility_For_Religion,                                // Firelink Ritual (Stormforged)
	Altar_Metal_Production_Speed_Boost,                                // Metallurgic Proficiency (Stormforged)
	Altar_Mists_Piercers,                                              // Mist Piercers (Stormforged)
	Altar_Mold_Grain,                                                  // Moldy Grain Seeds (Stormforged)
	Altar_More_Amber_From_Routes,                                      // Trade Negotiations (Stormforged)
	Altar_Mushrooms_In_Farms,                                          // Mushroom Seedlings (Stormforged)
	Altar_Newcomers_Faster_25,                                         // Secure Trail (Stormforged)
	Altar_Newcomers_Faster_25___Child,                                 // Secure Trail (Stormforged)
	Altar_NewNewcomersBonus_Random,                                    // Crowded Caravan (Stormforged)
	Altar_Of_Decay_Negative,                                           // Blight Incantation
	Altar_Overexploitation,                                            // Overexploitation (Stormforged)
	Altar_Packs_Of_Goods_Plus1,                                        // Export Specialization (Stormforged)
	Altar_PacksForResolveRep,                                          // Export Contract (Stormforged)
	Altar_Parts_For_Trade,                                             // Free Samples (Stormforged)
	Altar_Relic_Time_Reduction,                                        // Firekeeper's Prayer (Stormforged)
	Altar_Resolve_For_Consumption,                                     // Generous Rations (Stormforged)
	Altar_Resolve_For_Impatience,                                      // Rebellious Spirit (Stormforged)
	Altar_Route_Less_Travel_Time,                                      // Stormwalker Training (Stormforged)
	Altar_Storm_Water_For_Woodcutters,                                 // Force of Nature (Stormforged)
	Altar_Tablets_For_Events,                                          // Hidden Reward (Stormforged)
	Altar_Tools_For_Death,                                             // Bone Tools (Stormforged)
	Altar_Tools_For_Glade,                                             // Improvised Tools (Stormforged)
	Altar_Trade_Routes_Bonus_Fuel,                                     // Tightened Belt (Stormforged)
	Altar_Trade_Routes_For_Housing_Spots,                              // Urban Planning (Stormforged)
	Altar_Trading_Packs,                                               // Trade Logs (Stormforged)
	Altar_Villager_For_Glade,                                          // Lost in the Wilds (Stormforged)
	Altar_Wood_Plus2_For_Insects,                                      // No Quality Control (Stormforged)
	Altar_Working_Time_For_Firekeeper,                                 // Prayer Book (Stormforged)
	Amber_1,                                                           // Amber Pouch
	Amber_10,                                                          // Amber Pouch
	Amber_12,                                                          // Amber Pouch
	Amber_15,                                                          // Amber Pouch
	Amber_2,                                                           // Amber Pouch
	Amber_20,                                                          // Amber Pouch
	Amber_25,                                                          // Amber Pouch
	Amber_3,                                                           // Amber Pouch
	Amber_30,                                                          // Amber Pouch
	Amber_35,                                                          // Amber Pouch
	Amber_3pm,                                                         // Amber Tax
	Amber_3pm_Blight,                                                  // Amber Tax
	Amber_4,                                                           // Amber Pouch
	Amber_40,                                                          // Amber Pouch
	Amber_45,                                                          // Amber Pouch
	Amber_5,                                                           // Amber Pouch
	Amber_50,                                                          // Amber Pouch
	Amber_55,                                                          // Amber Pouch
	Amber_5pm,                                                         // Amber Tax
	Amber_60,                                                          // Amber Pouch
	Amber_7,                                                           // Amber Pouch
	Amber_70,                                                          // Amber Pouch
	Amber_8,                                                           // Amber Pouch
	Amber_80,                                                          // Amber Pouch
	Amber_Curse,                                                       // Amber Curse
	Amber_For_Archeology,                                              // Scientific Grant
	Amber_For_Newcomers,                                               // Stormwalker Tax
	Amber_For_Sea_Marrow,                                              // Golden Marrow
	Amber_For_Trade_Packs,                                             // Value Added Tax
	Amber_For_Trade_Routes,                                            // Deep Pockets
	Amber_For_Trader_Visit,                                            // Bed and Breakfast
	Amber_For_Water,                                                   // Counterfeit Amber
	Amber_For_Wood,                                                    // Lumber Tax
	Amber_Payment___Payment,                                           // Royal Tax
	Amber_Payment___Villagers_Leaving,                                 // Recall (Royal Tax)
	Amber_Worth_5_More, 
	Amber_Worth_Bit_More, 
	Amber_Worth_More,                                                  // Enriched Amber
	Amber_Worth_More_For_Relics,                                       // Respected Business Partner
	AmberForLuxury,                                                    // Luxury Tax
	Ancient_Artifact_1,                                                // Small Ancient Artifact
	Ancient_Artifact_2,                                                // Ancient Artifact
	Ancient_Artifact_3,                                                // Ancient Artifact
	Ancient_Artifact_3_Tutorial,                                       // Ancient Artifact
	Ancient_Tablet_1,                                                  // Chest of Ancient Tablets
	Ancient_Tablet_10,                                                 // Chest of Ancient Tablets
	Ancient_Tablet_2,                                                  // Chest of Ancient Tablets
	Ancient_Tablet_3,                                                  // Chest of Ancient Tablets
	Ancient_Tablet_5,                                                  // Chest of Ancient Tablets
	Ancient_Tablet_8,                                                  // Chest of Ancient Tablets
	AncientGate_Hardships,                                             // Survivor Bonding
	API_ExampleMod_diamondHunter,                                      // Diamond Hunter
	API_ExampleMod_diamondHunter_hookedEffect_1,                       // Diamonds
	API_ExampleMod_Diamonds_RelicKeepEffect_1,                         // Diamonds
	API_ExampleMod_Diamonds_RelicKeepEffect_2,                         // Diamonds
	API_ExampleMod_Kiwi_Fruit_RelicKeepEffect_1,                       // Kiwi Fruit
	API_ExampleMod_Kiwi_Fruit_RelicKeepEffect_2,                       // Kiwi Fruit
	API_ExampleMod_Modding_Tools,                                      // Modding Tools
	API_ExampleMod_Omega_Sewing_Technique,                             // Omega Sewing Technique
	Apothecary_Blueprint,                                              // Apothecary
	Apothecary_Plus50,                                                 // Reinforced Stoves
	Archeology_Extra_Blueprint,                                        // Scientific Council
	Archeology_Extra_Cornerstone,                                      // Scientific Award
	Archeology_Global_Extra_Production, 
	Artifact_For_Dangerous_Relic,                                      // From the Ashes
	Artifacts_1,                                                       // Artifacts
	Artifacts_10,                                                      // Artifacts
	Artifacts_2,                                                       // Artifacts
	Artifacts_3,                                                       // Artifacts
	Artifacts_4,                                                       // Artifacts
	Artifacts_5,                                                       // Artifacts
	Artisan_Blueprint,                                                 // Artisan
	Back_To_Nature,                                                    // Back to Nature
	Bakery_Blueprint,                                                  // Bakery
	Bakery_Plus50,                                                     // Reinforced Stoves
	Bakery_Speed_Plus50,                                               // Bread Peels
	Barrel_Recipes,                                                    // Barrel Schematics
	Barrels_1,                                                         // Barrels
	Barrels_15,                                                        // Barrels
	Barrels_2,                                                         // Barrels
	Barrels_20,                                                        // Barrels
	Barrels_25,                                                        // Barrels
	Barrels_3,                                                         // Barrels
	Barrels_30,                                                        // Barrels
	Barrels_35,                                                        // Barrels
	Barrels_3pm,                                                       // Barrel Delivery Line
	Barrels_4,                                                         // Barrels
	Barrels_40,                                                        // Barrels
	Barrels_5,                                                         // Barrels
	Barrels_50,                                                        // Barrels
	Barrels_5pm,                                                       // Barrel Delivery Line
	Barrels_In_Lumber_Mill,                                            // Barrel Schematics
	Barrels_In_Smithy,                                                 // Barrel Schematics
	Barrels_Plus1,                                                     // Advanced Coopering
	Barrels_Plus2,                                                     // Advanced Coopering
	Barrels_Plus3,                                                     // Advanced Coopering
	Barrels_Plus5,                                                     // Advanced Coopering
	Bath_House_Blueprint,                                              // Bath House
	Battleground_Beaver___Hard,                                        // Fallen Beavers
	Battleground_Beaver___Impossible,                                  // Fallen Beavers
	Battleground_Beaver___Normal,                                      // Fallen Beavers
	Battleground_Beaver___Very_Hard,                                   // Fallen Beavers
	Battleground_Fox___Hard,                                           // Fallen Foxes
	Battleground_Fox___Impossible,                                     // Fallen Foxes
	Battleground_Fox___Normal,                                         // Fallen Foxes
	Battleground_Fox___Very_Hard,                                      // Fallen Foxes
	Battleground_Harpy___Hard,                                         // Fallen Harpy Scientists
	Battleground_Harpy___Impossible,                                   // Fallen Harpy Scientists
	Battleground_Harpy___Normal,                                       // Fallen Harpy Scientists
	Battleground_Harpy___Very_Hard,                                    // Fallen Harpy Scientists
	Battleground_Human___Hard,                                         // Fallen Humans
	Battleground_Human___Impossible,                                   // Fallen Humans
	Battleground_Human___Normal,                                       // Fallen Humans
	Battleground_Human___Very_Hard,                                    // Fallen Humans
	Battleground_Lizard___Hard,                                        // Fallen Lizards
	Battleground_Lizard___Impossible,                                  // Fallen Lizards
	Battleground_Lizard___Normal,                                      // Fallen Lizards
	Battleground_Lizard___Very_Hard,                                   // Fallen Lizards
	Beanery_Blueprint,                                                 // Beanery
	Beaver_1,                                                          // Beaver
	Beaver_2,                                                          // Group of Beavers
	Beaver_3,                                                          // Group of Beavers
	Beaver_4,                                                          // Group of Beavers
	Beaver_5,                                                          // Group of Beavers
	Beaver_Faction_Support,                                            // Beaver Clan Support
	Beaver_House_Blueprint,                                            // Beaver House
	Beaver_Resolve_For_Wine_Prod,                                      // Vineyard Town
	Beavers_Killed_3___Missiles,                                       // Blood for Blood
	Berries_10,                                                        // Basket of Berries
	Berries_10pm,                                                      // Berry Delivery Line
	Berries_20,                                                        // Basket of Berries
	Berries_25,                                                        // Basket of Berries
	Berries_30,                                                        // Basket of Berries
	Berries_40,                                                        // Basket of Berries
	Berries_50,                                                        // Basket of Berries
	Berries_5pm,                                                       // Berry Delivery Line
	Berries_Plus1,                                                     // Large Berry Baskets
	Berries_Plus2,                                                     // Large Berry Baskets
	Berries_Plus3,                                                     // Large Berry Baskets
	Berries_Plus5,                                                     // Large Berry Baskets
	Bigger_Storage,                                                    // Orderly Storage
	BIOME_Big_Trees,                                                   // Overgrown Vegetation
	BIOME_Cursed_Glades,                                               // Cursed Battlefield
	BIOME_Diverse_Flora,                                               // Diverse Flora
	Biome_Gatherer_Production_Speed,                                   // Camps Speed
	Biome_Ghosts_In_Cursed_Woodlands,                                  // Restless Spirits
	BIOME_Giant_Organisms,                                             // Giant Organisms
	BIOME_HarvestingRate_Plus10,                                       // Gift of the Woodlands
	BIOME_Inspiring_Pressure,                                          // Inspiring Pressure
	BIOME_Inspiring_Pressure_Holder,                                   // Inspiring Pressure
	BIOME_Marshlands_Camps_Speed,                                      // Gathering Knowledge
	Biome_Moorlands___Archaeologist_Blueprint,                         // Royal Archaeologists
	Biome_Moorlands___Glades,                                          // Buried Mysteries
	Biome_Same_Size_Glades, 
	BIOME_Sealed_Biome,                                                // Beacon Tower
	BIOME_Storm_Penalty,                                               // Looming Darkness
	BIOME_Tree_Hostility,                                              // Abyssal Revenge
	BIOME_Tut_1_Storm_Penalty,                                         // Looming Darkness
	Biome_Wood_In_Woodlands,                                           // Gift of the Woodlands
	Biscuit_Recipes,                                                   // Biscuit Recipes
	Biscuits_10,                                                       // Basket of Biscuits
	Biscuits_15,                                                       // Basket of Biscuits
	Biscuits_20,                                                       // Basket of Biscuits
	Biscuits_25,                                                       // Basket of Biscuits
	Biscuits_30,                                                       // Basket of Biscuits
	Biscuits_3pm,                                                      // Biscuit Delivery Line
	Biscuits_40,                                                       // Basket of Biscuits
	Biscuits_5pm,                                                      // Biscuit Delivery Line
	Biscuits_60,                                                       // Basket of Biscuits
	Biscuits_In_Kiln,                                                  // Biscuit Recipes
	Biscuits_In_Rain_Mill,                                             // Biscuit Recipes
	Biscuits_In_Rain_Mill_Haunted,                                     // Biscuit Recipes
	Biscuits_Plus1,                                                    // Bigger Pans
	Biscuits_Plus2,                                                    // Bigger Pans
	Biscuits_Plus3,                                                    // Bigger Pans
	Biscuits_Plus5,                                                    // Bigger Pans
	Black_Stag_Reward_Catch,                                           // Cursed Treasure
	Black_Stag_Reward_Chase,                                           // Into the Mists
	Black_Stag_Reward_Release,                                         // Gift of Gratitude
	Blight_Fighter_Speed,                                              // The Sparkcaster
	Blight_Fuel_Plus1,                                                 // Fuel Mix
	Blight_Fuel_Plus2,                                                 // Fuel Mix
	Blight_Fuel_Plus3,                                                 // Fuel Mix
	Blight_Fuel_Plus5,                                                 // Fuel Mix
	Blight_Post_Blueprint,                                             // Forsaken Altar
	Blight_Post_Speed_Plus50, 
	Blight_Rate_For_Resolve_Reputation,                                // Blight Filter
	Blight_Rate_For_Resolve_Reputation___Blight_Rate__50,              // Engine Corrosion
	Blight_Rate_For_Resolve_Reputation___No_Rep_From_Resolve,          // Blight Filter
	Blight_Rate_For_Resolve_Reputation___No_Rep_From_Resolve___Holder, // Unbearable Smell
	Blightrot_Cloning,                                                 // Mitosis
	Blightrot_Outbreak,                                                // Blightrot Outbreak
	Blightrot_Over_Time___Rainpunk_Foundry___Hard,                     // Overcharged Rainpunk Technology
	Blightrot_Over_Time___Rainpunk_Foundry___Impossible,               // Overcharged Rainpunk Technology
	Blightrot_Over_Time___Rainpunk_Foundry___Normal,                   // Overcharged Rainpunk Technology
	Blightrot_Over_Time___Rainpunk_Foundry___Very_Hard,                // Overcharged Rainpunk Technology
	Blightrot_RemoveFoodOverTime___Hard,                               // Decaying Food
	Blightrot_RemoveFoodOverTime___Impossible,                         // Decaying Food
	Blightrot_RemoveFoodOverTime___Normal,                             // Decaying Food
	Blightrot_RemoveFoodOverTime___Very_Hard,                          // Decaying Food
	Blightrot_Resolve,                                                 // Blood Flower
	Blood_Price,                                                       // Blood Price Contract
	Bonus_Global_Reputation_Treshold_Increase_1,                       // TODO NAME
	Break_Time__3, 
	Break_Time__50, 
	Break_Time_Plus25, 
	Break_Time_Plus50, 
	Brewery_Blueprint,                                                 // Brewery
	Brewery_Haunted_Plus50,                                            // Efficient Brewing
	Brewery_Haunted_Plus60,                                            // Advanced Brewing
	Brewery_Plus50,                                                    // Efficient Brewing
	Brewery_Plus50_Composite_,                                         // Efficient Brewing
	Brewery_Plus60,                                                    // Advanced Brewing
	Brewery_Plus60_Composite_,                                         // Advanced Brewing
	Brewery_Speed_Haunted_Plus50,                                      // Rain Pumps
	Brewery_Speed_Plus50,                                              // Rain Pumps
	Brewery_Speed_Plus50_Composite_,                                   // Rain Pumps
	Brick_Oven_Blueprint,                                              // Brick Oven
	Bricks_10,                                                         // Crate of Bricks
	Bricks_15,                                                         // Crate of Bricks
	Bricks_2,                                                          // Crate of Bricks
	Bricks_20,                                                         // Crate of Bricks
	Bricks_25,                                                         // Crate of Bricks
	Bricks_30,                                                         // Crate of Bricks
	Bricks_4,                                                          // Crate of Bricks
	Bricks_5,                                                          // Crate of Bricks
	Bricks_8,                                                          // Crate of Bricks
	Bricks_Plus1,                                                      // Reinforced Brick Mold
	Bricks_Plus2,                                                      // Reinforced Brick Mold
	Bricks_Plus3,                                                      // Reinforced Brick Mold
	Bricks_Plus5,                                                      // Reinforced Brick Mold
	Brickyard_Blueprint,                                               // Brickyard
	BT_Global_Production_Rate,                                         // Song of Haste
	BT_Global_Production_Rate___Child,                                 // Song of Haste
	BT_Grain_40,                                                       // Box of Grain
	BT_Hearth_Bonus_HP_Plus250,                                        // Miracle of Strength
	BT_Hearth_Bonus_HP_Plus250___Child,                                // Miracle of Strength
	BT_Increased_Farm_Production,                                      // Chest of Farming Tools
	BT_Increased_Farm_Production___Child,                              // Chest of Farming Tools
	BT_Lower_Hostility,                                                // Miracle of Peace
	BT_Lower_Hostility___Child,                                        // Miracle of Peace
	BT_Moth_Larvae_Meat_30,                                            // Pack of Meat
	BT_Relic_Working_TIme,                                             // Miracle of Agility
	BT_Relic_Working_TIme___Child,                                     // Miracle of Agility
	BT_Slower_Leaving,                                                 // Song of Hope
	BT_Slower_Leaving___Child,                                         // Song of Hope
	BT_Trade_Routes_Bonus,                                             // Song of Prosperity
	BT_Trade_Routes_Bonus___Child,                                     // Song of Prosperity
	Builder_Plus1,                                                     // Builder's Pack
	Builder_Plus10,                                                    // Builder's Pack
	Builder_Plus15,                                                    // Builder's Pack
	Builder_Plus5,                                                     // Builder's Pack
	Building_Materials_For_Planks,                                     // Carpenter's Tools
	Butcher_Blueprint,                                                 // Butcher
	Butcher_Plus50,                                                    // Meat Cleavers
	Cache_Rewards_For_Nodes,                                           // Reckless Plunder
	Cannibalism,                                                       // Cannibalism
	CaptainCurse,                                                      // Captain's Curse
	Carpenter_Blueprint,                                               // Carpenter
	Cellar_Blueprint,                                                  // Cellar
	Chance_For_No_Consumption_10, 
	Chance_For_No_Production_Plague,                                   // Plague of Blindness
	Chaos,                                                             // Chaos
	Charm_Villagers,                                                   // Kelpie's Charm
	Charm_Villagers___Keep, 
	Charm_Villagers_Effect_Model, 
	Chest_Working_Time__30,                                            // Scout's Toolbox
	City_Renown,                                                       // City Renown
	City_Score___30,                                                   // Bad Reputation
	City_Score___50,                                                   // Bad Reputation
	City_Score___70,                                                   // Bad Reputation
	Clay_10,                                                           // Crate of Clay
	Clay_10pm,                                                         // Clay Delivery Line
	Clay_15,                                                           // Crate of Clay
	Clay_20,                                                           // Crate of Clay
	Clay_25,                                                           // Crate of Clay
	Clay_30,                                                           // Crate of Clay
	Clay_35,                                                           // Crate of Clay
	Clay_3pm,                                                          // Clay Delivery Line
	Clay_40,                                                           // Crate of Clay
	Clay_5,                                                            // Crate of Clay
	Clay_50,                                                           // Crate of Clay
	Clay_5pm,                                                          // Clay Delivery Line
	Clay_8,                                                            // Crate of Clay
	Clay_Pit__50,                                                      // Reinforced Tools
	Clay_Pit_Blueprint,                                                // Clay Pit
	Clay_Pit_Plus100, 
	Clay_Pit_Plus150, 
	Clay_Pit_Plus50,                                                   // Reinforced Tools
	Clay_Plus1,                                                        // Steel Shovels
	Clay_Plus2,                                                        // Steel Shovels
	Clay_Plus3,                                                        // Steel Shovels
	Clay_Plus5,                                                        // Steel Shovels
	Clearance_Water_5,                                                 // Clearance Water
	Clearence_Water_50_Pm, 
	Clothier_Plus50,                                                   // Reinforced Stoves
	Coal_10,                                                           // Chest of Coal
	Coal_10pm,                                                         // Coal Delivery Line
	Coal_15,                                                           // Chest of Coal
	Coal_20,                                                           // Chest of Coal
	Coal_25,                                                           // Chest of Coal
	Coal_30,                                                           // Chest of Coal
	Coal_3pm,                                                          // Coal Delivery Line
	Coal_40,                                                           // Chest of Coal
	Coal_50,                                                           // Chest of Coal
	Coal_5pm,                                                          // Coal Delivery Line
	Coal_For_Cysts,                                                    // Burnt to a Crisp
	Coal_Plus1,                                                        // Specialized Mining
	Coal_Plus2,                                                        // Specialized Mining
	Coal_Plus3,                                                        // Specialized Mining
	Coal_Plus5,                                                        // Specialized Mining
	Coats_10,                                                          // Bundle of Coats
	Coats_10pm,                                                        // Coat Delivery Line
	Coats_15,                                                          // Bundle of Coats
	Coats_20,                                                          // Bundle of Coats
	Coats_25,                                                          // Bundle of Coats
	Coats_35,                                                          // Bundle of Coats
	Coats_3pm,                                                         // Coat Delivery Line
	Coats_40,                                                          // Bundle of Coats
	Coats_5,                                                           // Bundle of Coats
	Coats_50,                                                          // Bundle of Coats
	Coats_50___Harpy_Passive,                                          // Bundle of Coats
	Coats_5pm,                                                         // Coat Delivery Line
	Coats_Plus1,                                                       // Ancient Sewing Technique
	Coats_Plus2,                                                       // Ancient Sewing Technique
	Coats_Plus3,                                                       // Ancient Sewing Technique
	Coats_Plus5,                                                       // Ancient Sewing Technique
	Common_Hall_Blueprint,                                             // Clan Hall
	Construction_Cost__33, 
	Construction_Cost__40, 
	Construction_Cost__50, 
	Construction_Cost_For_Nodes,                                       // Cheap Construction
	Construction_Speed_50,                                             // Enhanced Blueprints
	Construction_Speed_Slower_25, 
	Consumption_Control_Block___Without_Restrictions,                  // Without Restrictions
	Consumption_Control_For_Extra_Production,                          // Without Restrictions
	Converted_Altar_Of_Decay,                                          // Converted Altar of Decay
	Convicts___Hard,                                                   // Defenseless
	Convicts___Impossible,                                             // Defenseless
	Convicts___Normal,                                                 // Defenseless
	Convicts___Very_Hard,                                              // Defenseless
	Cookhouse_Blueprint,                                               // Cookhouse
	Cookhouse_Speed_Plus50, 
	Cooperage_Blueprint,                                               // Cooperage
	Copper_And_Wood_For_Chests,                                        // Salvaging Tools
	Copper_Bar_1,                                                      // Copper Bars
	Copper_Bar_10,                                                     // Copper Bars
	Copper_Bar_15,                                                     // Copper Bars
	Copper_Bar_20,                                                     // Copper Bars
	Copper_Bar_30,                                                     // Copper Bars
	Copper_Bar_Plus1,                                                  // Advanced Smelting
	Copper_Bar_Plus2,                                                  // Advanced Smelting
	Copper_Bar_Plus3,                                                  // Advanced Smelting
	Copper_Bar_Plus5,                                                  // Advanced Smelting
	Copper_Bars_2pm,                                                   // Metal Delivery Line
	Copper_Bars_3pm,                                                   // Metal Delivery Line
	Copper_Bars_4pm,                                                   // Metal Delivery Line
	Copper_Bars_5pm,                                                   // Metal Delivery Line
	Copper_For_Each_Tree,                                              // Copper Extractor
	Copper_For_Trees_Parent,                                           // Copper Extractor
	Copper_Ore_1,                                                      // Crate of Copper Ore
	Copper_Ore_10,                                                     // Crate of Copper Ore
	Copper_Ore_10pm,                                                   // Ore Delivery Line
	Copper_Ore_15,                                                     // Crate of Copper Ore
	Copper_Ore_20,                                                     // Crate of Copper Ore
	Copper_Ore_30,                                                     // Crate of Copper Ore
	Copper_Ore_40,                                                     // Crate of Copper Ore
	Copper_Ore_5,                                                      // Crate of Copper Ore
	Copper_Ore_5pm,                                                    // Ore Delivery Line
	Copper_Ore_Plus1,                                                  // Steel Drills
	Copper_Ore_Plus2,                                                  // Steel Drills
	Copper_Ore_Plus3,                                                  // Steel Drills
	Copper_Ore_Plus5,                                                  // Steel Drills
	Copper_Tools_Plus1,                                                // Advanced Smithing
	Copper_Tools_Plus1___In_Hook,                                      // Advanced Smithing
	Copper_Tools_Plus2,                                                // Advanced Smithing
	Copper_Tools_Plus3,                                                // Advanced Smithing
	Copper_Tools_Plus5,                                                // Advanced Smithing
	Cornerstone_Reroll___Trader,                                       // Lucky Charm
	Cornerstone_Reroll_Plus1,                                          // Royal Permit
	Corrupted_Sacrifice,                                               // Mark of the Sealed Ones
	Corruption_Per_Removed_Cyst__50,                                   // Firekeeper's Armor
	Crops_For_Grain,                                                   // Leftover Crops
	Crude_Workstation_Blueprint,                                       // Crude Workstation
	Crude_Workstation_Plus100,                                         // Workstation Upgrade
	Crude_Workstation_Plus50,                                          // Workstation Upgrade
	Crude_Workstation_Speed_Plus50,                                    // Carpenter's Tools
	Crystaline_Water,                                                  // Small Distillery
	Crystalized_Dew__1,                                                // Crystal Growth
	Crystalized_Dew_1,                                                 // Box of Crystalized Dew
	Crystalized_Dew_10,                                                // Box of Crystalized Dew
	Crystalized_Dew_15,                                                // Box of Crystalized Dew
	Crystalized_Dew_2,                                                 // Box of Crystalized Dew
	Crystalized_Dew_20,                                                // Box of Crystalized Dew
	Crystalized_Dew_25,                                                // Box of Crystalized Dew
	Crystalized_Dew_30,                                                // Box of Crystalized Dew
	Crystalized_Dew_4,                                                 // Box of Crystalized Dew
	Crystalized_Dew_40,                                                // Box of Crystalized Dew
	Crystalized_Dew_5,                                                 // Box of Crystalized Dew
	Crystalized_Dew_8,                                                 // Box of Crystalized Dew
	Crystalized_Dew_Plus1,                                             // Crystal Growth
	Crystalized_Dew_Plus2,                                             // Crystal Growth
	Crystalized_Dew_Plus3,                                             // Crystal Growth
	Crystalized_Dew_Plus5,                                             // Crystal Growth
	Cysts_Activation,                                                  // Awakening
	Cysts_Faster_Burning_5, 
	Cysts_For_Glades, 
	Cysts_For_Hostility, 
	Cysts_Longer_Burning_5,                                            // Effective Parasite
	Dangerous_Glades_Info_Block_Mistworm,                              // Heavy Fog
	Dangerous_Relic_Working_TIme__50, 
	Dangerous_Relic_Working_TIme_Plus50, 
	DarkGateResolve___Hard,                                            // Gate Presence
	DarkGateResolve___Impossible,                                      // Gate Presence
	DarkGateResolve___Normal,                                          // Gate Presence
	DarkGateResolve___Very_Hard,                                       // Gate Presence
	Destroy_All_Crops,                                                 // Toxic Ooze
	Diff_Altar,                                                        // Forsaken Altar
	Diff_Blightrot,                                                    // Blightrot & Corruption
	Diff_Hunger_Multiplier,                                            // Famine Outbreaks
	Diff_Lower_Food_Consumption,                                       // Settler's Luck
	Diff_No_Blightrot, 
	Distillery_Blueprint,                                              // Distillery
	Drizzle_Water_50_Pm, 
	Druid_Blueprint,                                                   // Druid's Hut
	Effect_CaravanTradeBlock,                                          // Unwelcoming Region
	Effect_DesertedCaravans,                                           // Deserted Caravans
	Eggs_10pm,                                                         // Egg Delivery Line
	Eggs_15pm,                                                         // Egg Delivery Line
	Eggs_20,                                                           // Basket of Eggs
	Eggs_25,                                                           // Basket of Eggs
	Eggs_30,                                                           // Basket of Eggs
	Eggs_3pm,                                                          // Egg Delivery Line
	Eggs_40,                                                           // Basket of Eggs
	Eggs_5,                                                            // Basket of Eggs
	Eggs_50,                                                           // Basket of Eggs
	Eggs_5pm_Stormbird,                                                // Nest Eggs
	Eggs_For_Cysts,                                                    // Blightrot Pruner
	Eggs_Plus1,                                                        // Egg Containers
	Eggs_Plus2,                                                        // Egg Containers
	Eggs_Plus3,                                                        // Egg Containers
	Eggs_Plus5,                                                        // Egg Containers
	Embark_Cornerstone_Reroll_Plus3,                                   // Royal Permit
	Engines_Blight_Rate_Plus20, 
	Engines_Blight_Rate_Plus25, 
	Engines_Blight_Rate_Plus50,                                        // Engine Corrosion
	Event_Time_Reduction_10,                                           // Lucky Talisman
	EventsRewardsForBloodthirst,                                       // Exploration Training
	Every_Sec_Global_Resolve___Hard,                                   // Frightening Visions
	Every_Sec_Global_Resolve___Impossible,                             // Frightening Visions
	Every_Sec_Global_Resolve___Normal,                                 // Frightening Visions
	Every_Sec_Global_Resolve___Very_Hard,                              // Frightening Visions
	Every_Sec_Hostility,                                               // Whispering Tombs
	Exploration_Contract,                                              // Exploration Contract
	Exploration_Tax___Villagers_Leaving,                               // Recall (Land Tax)
	Explorers_Boredom,                                                 // Explorers' Boredom
	Explorers_Lodge_Blueprint,                                         // Explorers' Lodge
	Exploring_Expedition,                                              // Exploration Expedition
	Exploring_Expedition___Resolve_Bonus_Effect,                       // Exploration Expedition
	Exploring_Expedition___Resolve_Bonus_Effect___Holder,              // Joy Of Discovery
	Exploring_Expedition___Slower_Woodcutting___Holder,                // Joy Of Discovery
	Extra_Beaver_Newcommers,                                           // Beaver Friendship
	Extra_Consumption_Plus100, 
	Extra_Consumption_Plus25, 
	Extra_Consumption_Plus50, 
	Extra_Fox_Newcommers,                                              // Fox Friendship
	Extra_Glade___Moorlands_Dangerous, 
	Extra_Glade___Moorlands_Forbidden, 
	Extra_Glade___Moorlands_Normal, 
	Extra_Glade___Seal,                                                // Hidden Seal
	Extra_Harpy_Newcommers,                                            // Harpy Friendship
	Extra_Human_Newcommers,                                            // Human Friendship
	Extra_Lizard_Newcommers,                                           // Lizard Friendship
	Extra_Prod_For_Consumption,                                        // Worker's Rations
	Extra_Production_For_Corruption_Points,                            // Forbidden Seal Shard (Stormforged)
	Extra_Production_For_Relics_Resolved,                              // Ancient Practices
	Extra_Trader_Merch,                                                // Guild Catalogue
	Extreme_Noise_In_Crude_Workstation, 
	Fabric_10,                                                         // Bundle of Fabric
	Fabric_15,                                                         // Bundle of Fabric
	Fabric_2,                                                          // Bundle of Fabric
	Fabric_20,                                                         // Bundle of Fabric
	Fabric_30,                                                         // Bundle of Fabric
	Fabric_4,                                                          // Bundle of Fabric
	Fabric_40,                                                         // Bundle of Fabric
	Fabric_5,                                                          // Bundle of Fabric
	Fabric_Or_Coat_Speed_Plus5, 
	Fabric_Plus1,                                                      // Reinforced Needles
	Fabric_Plus2,                                                      // Reinforced Needles
	Fabric_Plus3,                                                      // Reinforced Needles
	Fabric_Plus5,                                                      // Reinforced Needles
	FallenViceroyCommemoration_Beaver_Housing,                         // Fallen Viceroy Commemoration
	FallenViceroyCommemoration_Foxes_Housing,                          // Fallen Viceroy Commemoration
	FallenViceroyCommemoration_Harpy_Housing,                          // Fallen Viceroy Commemoration
	FallenViceroyCommemoration_Humans_Housing,                         // Fallen Viceroy Commemoration
	FallenViceroyCommemoration_Lizards_Housing,                        // Fallen Viceroy Commemoration
	Families_Gratitude,                                                // Family Gratitude
	Farm__50,                                                          // Reinforced Tools
	Farm_Blueprint,                                                    // Homestead
	Farm_Plus100,                                                      // Obsidian Tools
	Farm_Plus150,                                                      // Obsidian Tools
	Farm_Plus50,                                                       // Obsidian Tools
	Farmer_Plus10,                                                     // Farmer's Pack
	Farmer_Plus15,                                                     // Farmer's Pack
	Farmer_Plus5,                                                      // Farmer's Pack
	Farming__25_For_Wood_Plus1,                                        // Rooty Ground
	Faster_Event_Working_Time_For_Death,                               // Haste Makes Waste
	Faster_Woodcutters,                                                // Specialized Boots
	Fear_Of_The_Wilds_T1___Hard,                                       // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Impossible,                                 // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Normal,                                     // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Very_Hard,                                  // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Hard,                                       // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Impossible,                                 // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Normal,                                     // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Very_Hard,                                  // Fear of the Wilds
	Fedora_Hat,                                                        // Old Fedora Hat
	Fiber_10pm,                                                        // Fiber Delivery Line
	Fiber_15pm,                                                        // Fiber Delivery Line
	Fiber_3pm,                                                         // Fiber Delivery Line
	Fiber_5pm,                                                         // Fiber Delivery Line
	Fiber_For_Vegetables,                                              // Pocket Knives
	Finesmith_Blueprint,                                               // Finesmith
	Fishmen_Higher_Negative_Mysteries,                                 // Invoker
	Fishmen_Lower_Negative_Mysteries,                                  // Airbender
	Fishmen_Resolve,                                                   // Creeping Fishmen
	Fishmen_Soothsayer_Curse_BloodFlower,                              // Rain Sorcery
	Fishmen_Soothsayer_Curse_Hostility,                                // Blood Sorcery
	Fishmens_Traps,                                                    // Fishmen Traps
	Flooding_Remove_Roads,                                             // Flooding
	Flour_10,                                                          // Sacks of Flour
	Flour_20,                                                          // Sacks of Flour
	Flour_25,                                                          // Sacks of Flour
	Flour_30,                                                          // Sacks of Flour
	Flour_35,                                                          // Sacks of Flour
	Flour_3pm,                                                         // Flour Delivery Line
	Flour_40,                                                          // Sacks of Flour
	Flour_45,                                                          // Sacks of Flour
	Flour_50,                                                          // Sacks of Flour
	Flour_5pm,                                                         // Flour Delivery Line
	Flour_Plus1,                                                       // Heavy Millstone
	Flour_Plus2,                                                       // Heavy Millstone
	Flour_Plus3,                                                       // Heavy Millstone
	Flour_Plus5,                                                       // Heavy Millstone
	Food_Prod_Speed_Plus10,                                            // Cooking Steam
	Food_Production_For_Engines,                                       // Cooking Steam
	Food_Production_Speed__60,                                         // Contaminated Food
	Food_Production_Speed__70,                                         // Contaminated Food
	Food_Production_Speed__80,                                         // Contaminated Food
	Food_Production_Speed__90,                                         // Contaminated Food
	Food_Production_Speed_Plus20,                                      // Viceroy's Survival Guide
	Food_Production_Speed_Plus33,                                      // Viceroy's Survival Guide
	Food_Production_Speed_Plus50,                                      // Viceroy's Survival Guide
	Food_Stockpiles_1,                                                 // Food Stockpiles
	Food_Stockpiles_10,                                                // Food Stockpiles
	Food_Stockpiles_2,                                                 // Food Stockpiles
	Food_Stockpiles_3,                                                 // Food Stockpiles
	Food_Stockpiles_4,                                                 // Food Stockpiles
	Food_Stockpiles_5,                                                 // Food Stockpiles
	Foragers_Camp_Blueprint,                                           // Foragers' Camp
	Foragers_Camp_Plus100,                                             // Reinforced Tools
	Foragers_Camp_Plus50,                                              // Reinforced Tools
	Foragers_Camp_Plus50_Composite,                                    // Termite Infestation
	Foragers_Camp_Primitive_Plus50,                                    // Reinforced Tools
	Forbidden_For_Hostility,                                           // Secure Perimeter
	Forbidden_For_Hostility___Lower_Glades___Dangerous, 
	Forbidden_For_Hostility___Lower_Glades___Small, 
	Forbidden_For_Hostility_NEW,                                       // Secure Perimeter
	Forced_Improvisation, 
	Forge_Trip_Hammer,                                                 // Forge Trip Hammer
	Forsaken_Crypt_Resolve_Penalty___Hard,                             // Robbed Dead
	Forsaken_Crypt_Resolve_Penalty___Impossible,                       // Robbed Dead
	Forsaken_Crypt_Resolve_Penalty___Normal,                           // Robbed Dead
	Forsaken_Crypt_Resolve_Penalty___Very_Hard,                        // Robbed Dead
	Forum_Blueprint,                                                   // Forum
	Foul_Taste,                                                        // Foul Taste
	Fox_Faction_Support,                                               // Fox Pack Support
	Fox_Hostility_Hearth_Bonus,                                        // Forest Affinity
	Foxes_1,                                                           // Fox
	Foxes_2,                                                           // Group of Foxes
	Foxes_3,                                                           // Group of Foxes
	Foxes_4,                                                           // Group of Foxes
	Foxes_5,                                                           // Group of Foxes
	Foxes_Killed_3___Missiles,                                         // Blood for Blood
	Friend_Or_Foe,                                                     // Friend or Foe
	Frightening_Visions_Resolve_Penalty,                               // Frightening Visions
	Fuel_Recipes_Rate_33,                                              // Advanced Fuel
	Fuel_Recipes_Rate_50,                                              // Advanced Fuel
	Fuel_Recipes_Rate_66,                                              // Advanced Fuel
	FuelConsumption__20,                                               // Secret Techniques of the Firekeeper
	FuelConsumption__25,                                               // Secret Techniques of the Firekeeper
	FuelConsumption__33,                                               // Secret Techniques of the Firekeeper
	FuelConsumption_200, 
	FuelConsumption_HearthEffect_Beaver,                               // Pragmatic Frugality
	FuelConsumption_Plus150_Wildfire,                                  // Wildfire Presence
	FuelConsumption_Plus200_Wildfire,                                  // Wildfire Presence
	FuelConsumption_Plus250_Wildfire,                                  // Wildfire Presence
	FuelConsumption_Plus300_Wildfire,                                  // Wildfire Presence
	FuelConsumption_Plus33,                                            // Fickle Flame
	Furnace_Blueprint,                                                 // Furnace
	Gatherers_Prod_Plus50,                                             // Ancient Ways
	Gathering_Speed_Plus30, 
	Gathering_Speed_Plus5, 
	Generic_Glade_Info, 
	Generous_Rations,                                                  // Generous Rations
	Ghost_Amber_Tablets_Lost,                                          // Scarlet Tears
	Ghost_Complex_Food_Lost,                                           // Scarlet Tears
	Ghost_Fuel_Lost,                                                   // Scarlet Tears
	Ghost_Needs_Lost,                                                  // Scarlet Tears
	Ghost_Parts_Lost,                                                  // Scarlet Tears
	Ghost_Raw_Food_Lost,                                               // Scarlet Tears
	Ghost_Remove_Self,                                                 // Vanishing
	Ghost_Tools_Lost,                                                  // Scarlet Tears
	Global_Capacity_10, 
	Global_Capacity_3, 
	Global_Capacity_5, 
	Global_Chance_Of_Death,                                            // Overtime
	Global_Extra_Prod_Plus10, 
	Global_Extra_Prod_Plus15, 
	Global_Extra_Prod_Plus20, 
	Global_Extra_Prod_Plus25, 
	Global_Extra_Prod_Plus30, 
	Global_Extra_Prod_Plus33, 
	Global_Extra_Prod_Plus5, 
	Global_Prod_Speed__50_plague_,                                     // Plague of Mosquitoes
	Global_Production_Faster_10, 
	Global_Production_Faster_15, 
	Global_Production_Faster_20, 
	Global_Production_Faster_25, 
	Global_Production_Faster_30, 
	Global_Production_Faster_33, 
	Global_Production_Faster_40, 
	Global_Production_Faster_5, 
	Global_Production_Faster_50, 
	GlobalResolve_HearthEffect_Lizard,                                 // Sacred Pyre
	Glow_Oil_10,                                                       // Oil Vessels
	Glow_Oil_15,                                                       // Oil Vessels
	Glow_Oil_20,                                                       // Oil Vessels
	Glow_Oil_3,                                                        // Oil Vessels
	Glow_Oil_30,                                                       // Oil Vessels
	Glow_Oil_40,                                                       // Oil Vessels
	Gold_Stag_Reward_Catch,                                            // Cursed Treasure
	Gold_Stag_Reward_Chase,                                            // Into the Mists
	Gold_Stag_Reward_Release,                                          // Gift of Gratitude
	Grain_10pm,                                                        // Grain Delivery Line
	Grain_15,                                                          // Box of Grain
	Grain_15pm,                                                        // Grain Delivery Line
	Grain_20,                                                          // Box of Grain
	Grain_30,                                                          // Box of Grain
	Grain_3pm,                                                         // Grain Delivery Line
	Grain_40,                                                          // Box of Grain
	Grain_50,                                                          // Box of Grain
	Grain_5pm,                                                         // Grain Delivery Line
	Grain_60,                                                          // Box of Grain
	Grain_Plus1,                                                       // Mold Supply
	Grain_Plus2,                                                       // Mold Supply
	Grain_Plus3,                                                       // Mold Supply
	Grain_Plus5,                                                       // Mold Supply
	Grain_Specialization,                                              // Grain Bags
	Granary_Blueprint,                                                 // Granary
	Greenhouse__50,                                                    // Reinforced Tools
	Greenhouse_Blueprint,                                              // Greenhouse
	Greenhouse_Plus100, 
	Greenhouse_Plus150, 
	Greenhouse_Plus50,                                                 // Reinforced Tools
	Grill_Blueprint,                                                   // Grill
	Grove__50,                                                         // Reinforced Tools
	Grove_Blueprint,                                                   // Forester's Hut
	Grove_Plus100, 
	Grove_Plus150, 
	Grove_Plus50,                                                      // Industrialized Agriculture
	Growth_Medium_Cysts_For_Food_,                                     // Growth Medium
	Guild_House_Blueprint,                                             // Guild House
	Half_Reputation_From_Orders, 
	Harmony_Altar_Resolve,                                             // Harmony
	Harpies_Killed_3___Missiles,                                       // Blood for Blood
	Harpy_1,                                                           // Harpy
	Harpy_2,                                                           // Group of Harpies
	Harpy_3,                                                           // Group of Harpies
	Harpy_4,                                                           // Group of Harpies
	Harpy_5,                                                           // Group of Harpies
	Harpy_Faction_Support,                                             // Harpy Clan Support
	Harpy_Global_Capacity,                                             // Light as a Feather
	Harpy_Resolve_For_Tea_Prod,                                        // Tea Specialization
	Harpy_Stormbird_Resolve,                                           // Unique Ally
	Harvester_Camp_Plus100,                                            // Reinforced Tools
	Harvester_Camp_Plus50,                                             // Reinforced Tools
	HarvestingRate__25,                                                // Slow Harvest
	HarvestingRate__50,                                                // Slow Harvest
	HarvestingRate__60,                                                // Slow Harvest
	HarvestingRate__70,                                                // Slow Harvest
	HarvestingRate__80,                                                // Slow Harvest
	HarvestingRate_Plus100,                                            // Quick Harvest
	HarvestingRate_Plus25,                                             // Obsidian Sickles
	HarvestingRate_Plus30,                                             // Obsidian Sickles
	HarvestingRate_Plus5,                                              // Obsidian Sickles
	HarvestingRate_Plus50,                                             // Quick Harvest
	Hauler_Break_Interval,                                             // Travel Rations
	Hauler_Break_Interval___Main_Storage,                              // Travel Rations
	Hauler_Break_Interval___Small_Storage,                             // Travel Rations
	Hauler_Plus5,                                                      // Safety Ropes
	Hauler_Speed,                                                      // Specialized Workwear
	Hauler_Speed___Main_Storage,                                       // Specialized Workwear
	Hauler_Speed___Small_Storage,                                      // Specialized Workwear
	Hauling_Cart_In_All_Warehouses,                                    // Hauling Cart
	Hauling_Cart_In_All_Warehouses___Main,                             // Hauling Cart
	Hauling_Cart_In_All_Warehouses___Small,                            // Hauling Cart
	Hearth_Bonus_HP_Plus100,                                           // Ancient Stabilizer
	Hearth_Bonus_HP_Plus150, 
	Hearth_Bonus_HP_Plus250, 
	Hearth_Bonus_HP_Plus50, 
	Hearth_Corruption_Rate__10,                                        // Firekeeper's Armor
	Hearth_Corruption_Rate_Plus30, 
	Hearth_Corruption_Rate_Plus50,                                     // Straight to the Hearth
	Hearth_High_Hostility_Reduction,                                   // Sacrifice Coal
	Hearth_HP_500___HP_Bonus,                                          // Obsidian Runestone
	Hearth_Less_HP__100, 
	Hearth_Low_Hostility_Reduction,                                    // Sacrifice Wood
	Hearth_Parts_1,                                                    // Wildfire Essence
	Hearth_Parts_2,                                                    // Wildfire Essence
	Hearth_Parts_3,                                                    // Wildfire Essence
	Hearth_Parts_4,                                                    // Wildfire Essence
	Hearth_Parts_5,                                                    // Wildfire Essence
	Hearth_Parts_6,                                                    // Wildfire Essence
	Hearth_Production_Speed,                                           // Sacrifice Oil
	Hearth_Relic_Working_Time__20,                                     // Sacrifice Sea Marrow
	Hearth_Sacrifice_Block,                                            // Ritual of Denial
	Hearth_Sacrifice_Block___Baptism_Of_Fire,                          // Baptism of Fire
	Hearth_Sacrifice_Block___Plague_Of_Darkness,                       // Plague of Darkness
	Herb_Garden__50,                                                   // Reinforced Tools
	Herb_Garden__50_Haunted,                                           // Reinforced Tools
	Herb_Garden_Blueprint,                                             // Herb Garden
	Herb_Garden_Plus100, 
	Herb_Garden_Plus100_Haunted, 
	Herb_Garden_Plus150, 
	Herb_Garden_Plus150_Haunted, 
	Herb_Garden_Plus25,                                                // Advanced Herbalism
	Herb_Garden_Plus25_Composite_,                                     // Advanced Herbalism
	Herb_Garden_Plus25_Haunted,                                        // Advanced Herbalism
	Herb_Garden_Plus50,                                                // Advanced Herbalism
	Herb_Garden_Plus50_Composite_,                                     // Advanced Herbalism
	Herb_Garden_Plus50_Haunted,                                        // Advanced Herbalism
	Herb_Production_For_Biscuits,                                      // Spices
	Herbalist_Camp_Blueprint,                                          // Herbalists' Camp
	Herbalist_Camp_Plus100,                                            // Reinforced Tools
	Herbalist_Camp_Plus50,                                             // Reinforced Tools
	Herbs_10,                                                          // Bundle of Herbs
	Herbs_10pm,                                                        // Herb Delivery Line
	Herbs_15,                                                          // Bundle of Herbs
	Herbs_2pm,                                                         // Herb Delivery Line
	Herbs_30,                                                          // Bundle of Herbs
	Herbs_40,                                                          // Bundle of Herbs
	Herbs_5,                                                           // Bundle of Herbs
	Herbs_50,                                                          // Bundle of Herbs
	Herbs_5pm,                                                         // Herb Delivery Line
	Herbs_60,                                                          // Bundle of Herbs
	Herbs_70,                                                          // Bundle of Herbs
	Herbs_Plus1,                                                       // Sharp Sickles
	Herbs_Plus2,                                                       // Sharp Sickles
	Herbs_Plus3,                                                       // Sharp Sickles
	Herbs_Plus5,                                                       // Sharp Sickles
	Hidden_From_The_Queen,                                             // Hidden from the Queen
	Hidden_From_The_Queen___Impatience, 
	Higher_Hostility_Glades___Dangerous,                               // Dark Mist
	Higher_New_Year, 
	Higher_Villagers_Resilience_30, 
	Hostility__10, 
	Hostility__15, 
	Hostility__20, 
	Hostility__25, 
	Hostility__30, 
	Hostility__35, 
	Hostility__40, 
	Hostility__5, 
	Hostility__50, 
	Hostility_1, 
	Hostility_20, 
	Hostility_For_Active_Routes,                                       // Queen's Sailors
	Hostility_For_Caches,                                              // Silent Looting
	Hostility_For_Cysts, 
	Hostility_For_Dangerous_Relics,                                    // Calming the Forest
	Hostility_For_Death,                                               // Small Altar Box
	Hostility_For_Firekeeper___Lighthouse___Strong,                    // Cold Flame
	Hostility_For_Firekeeper___Lighthouse___Weak,                      // Lesser Cold Flame
	Hostility_For_Relics,                                              // Frequent Patrols
	Hostility_For_Removed_Cysts,                                       // Baptism of Fire
	Hostility_For_Sales,                                               // Protected Trade
	Hostility_For_Tablets,                                             // Decryption
	Hostility_For_Trees___DarkGate___Hard,                             // Disturbing the Dead
	Hostility_For_Trees___DarkGate___Impossible,                       // Disturbing the Dead
	Hostility_For_Trees___DarkGate___Normal,                           // Disturbing the Dead
	Hostility_For_Trees___DarkGate___Very_Hard,                        // Disturbing the Dead
	Hostility_For_Water,                                               // Calming Water
	Hostility_Lower_50,                                                // Ways of the Forest
	Hostility_Lower_75,                                                // Ways of the Forest
	Hostility_Penalty_For_Amber,                                       // Blazing Amber
	Hostility_Per_Cyst_Mole,                                           // Infestation
	Hostility_Plus1,                                                   // Rage of the Forest
	Hostility_Plus10, 
	Hostility_Plus10___Fishmen, 
	Hostility_Plus100, 
	Hostility_Plus110, 
	Hostility_Plus15, 
	Hostility_Plus2,                                                   // High Voltage
	Hostility_Plus20,                                                  // Fishmen Totem
	Hostility_Plus30, 
	Hostility_Plus5, 
	Hostility_Plus50,                                                  // Darkest Shadows
	Hostility_Plus50___Fishmen, 
	Hostility_Plus50___Glade_Trader,                                   // Enemy of the Forest
	Hostility_Tree,                                                    // Rage of the Forest
	HostilityEachYear, 
	Houses_Global_Capacity_Plus1,                                      // Crowded Houses
	Houses_Plus1___Break_Time, 
	Houses_Plus1_For_Break_Time,                                       // Crowded Houses
	HP_For_Impatience,                                                 // Queen's Gift
	Hub_Extra_Production_Chance,                                       // District (Level 3)
	Hub_Extra_Production_Chance___Composite,                           // District (Level 3)
	Hub_Production_Speed,                                              // Neighborhood (Level 2)
	Hub_Production_Speed___Composite,                                  // Neighborhood (Level 2)
	Hub_Resolve___Composite,                                           // Encampment (Level 1)
	Hub_Resolve_T1,                                                    // Encampment (Level 1)
	Hub_Resolve_T2,                                                    // Neighborhood (Level 2)
	Hub_Resolve_T3,                                                    // District (Level 3)
	Hubs_For_Hostility,                                                // Safe Haven
	Hubs_For_Newcomer_Goods,                                           // Generous Gifts
	Human_1,                                                           // Human
	Human_2,                                                           // Group of Humans
	Human_3,                                                           // Group of Humans
	Human_4,                                                           // Group of Humans
	Human_5,                                                           // Group of Humans
	Human_Faction_Support,                                             // Human Clan Support
	Human_House_Blueprint,                                             // Human House
	Human_Resolve_For_Incense_Prod,                                    // Religious Settlement
	Humans_Killed_3___Missiles,                                        // Blood for Blood
	HunterGatherers,                                                   // Hunter-Gatherers
	Hydrant_Blueprint,                                                 // Forsaken Altar
	Impatience_For_Glade,                                              // Badge of Courage
	Impatience_For_Glade___Child, 
	Incantation,                                                       // Blight Incantation
	Incantation_Cysts_Longer_Burning_10, 
	Incense_12,                                                        // Vessel of Incense
	Incense_15,                                                        // Vessel of Incense
	Incense_25,                                                        // Vessel of Incense
	Incense_3,                                                         // Vessel of Incense
	Incense_30,                                                        // Vessel of Incense
	Incense_3pm,                                                       // Incense Delivery Line
	Incense_40,                                                        // Vessel of Incense
	Incense_5,                                                         // Vessel of Incense
	Incense_5pm,                                                       // Incense Delivery Line
	Incense_8,                                                         // Vessel of Incense
	Incense_For_Roots,                                                 // Fragrant Roots
	Incense_Plus1,                                                     // Vessel of Incense
	Incense_Plus2,                                                     // Vessel of Incense
	Incense_Plus3,                                                     // Vessel of Incense
	Incense_Plus5,                                                     // Vessel of Incense
	Infected_Building_Production_For_Hostility,                        // Blight Extractor
	Ink_10,                                                            // Vials of Pigment
	Ink_16,                                                            // Vials of Pigment
	Ink_25,                                                            // Vials of Pigment
	Ink_35,                                                            // Vials of Pigment
	Ink_40,                                                            // Vials of Pigment
	Ink_5,                                                             // Vials of Pigment
	Ink_Plus1,                                                         // Big Phials
	Ink_Plus2,                                                         // Big Phials
	Ink_Plus3,                                                         // Big Phials
	Ink_Plus5,                                                         // Big Phials
	Insect_For_Tree,                                                   // Woodpecker Technique
	Insect_For_Tree___Child,                                           // Woodpecker Technique
	Insect_Traps,                                                      // Insect Traps
	Insects_1,                                                         // An Insect
	Insects_10,                                                        // An Insect
	Insects_150,                                                       // Basket of Insects
	Insects_2,                                                         // An Insect
	Insects_20,                                                        // An Insect
	Insects_30,                                                        // Basket of Insects
	Insects_3pm,                                                       // Termite Nest
	Insects_40,                                                        // Basket of Insects
	Insects_5,                                                         // An Insect
	Insects_50,                                                        // Basket of Insects
	Insects_5pm,                                                       // Insect Delivery Line
	Insects_5pm___Termite_Nest,                                        // Termite Nest
	Insects_Plus1,                                                     // Insect Lure
	Insects_Plus2,                                                     // Insect Lure
	Insects_Plus3,                                                     // Insect Lure
	Insects_Plus5,                                                     // Insect Lure
	Instant_Storm_Effect,                                              // Stormbird's Anger
	Institution_Camps_Production,                                      // Ancient Ways
	Institution_Global_Capacity,                                       // Market Carts
	Institution_Global_Extra_Production,                               // Public Lectures
	Institution_Global_Production_Rate,                                // Good Health
	Institution_Global_Resolve,                                        // Gleeman's Tales
	Institution_Lower_Hostility,                                       // The Green Brew
	Institution_Resolve_For_Ruins,                                     // The Crown Chronicles
	Institution_Resolve_For_Sales,                                     // The Guild's Welfare
	Institution_Slower_Burn_Rate, 
	Institution_Slower_Leaving,                                        // Regular Baths
	Institution_Slower_Sacrafice, 
	Institution_Temple_Burn_Rate,                                      // Sacrament of the Flame
	Institution_Temple_Hostility_For_Sacrifice,                        // Sacrament of the Flame
	Institution_Trader_Interval_Plus50,                                // Guild House
	Jerky_10,                                                          // Basket of Jerky
	Jerky_15,                                                          // Basket of Jerky
	Jerky_20,                                                          // Basket of Jerky
	Jerky_25,                                                          // Basket of Jerky
	Jerky_30,                                                          // Basket of Jerky
	Jerky_3pm,                                                         // Jerky Delivery Line
	Jerky_40,                                                          // Basket of Jerky
	Jerky_5,                                                           // Basket of Jerky
	Jerky_5pm,                                                         // Jerky Delivery Line
	Jerky_Plus1,                                                       // Salted Jerky
	Jerky_Plus2,                                                       // Salted Jerky
	Jerky_Plus3,                                                       // Salted Jerky
	Jerky_Plus5,                                                       // Salted Jerky
	Kelpie_Charm,                                                      // Kelpie's Charm
	Killed_For_GladeInfo,                                              // Ancient Pact
	Killed_For_Water,                                                  // Ancient Pact
	Killed_Scout, 
	Kiln_Blueprint,                                                    // Kiln
	Land_Of_Greed___ReputationPenaltyRateMinus20, 
	Land_Of_Greed___ReputationPenaltyRatePlus50, 
	Leather_10,                                                        // Bundle of Leather
	Leather_10pm,                                                      // Leather Delivery Line
	Leather_20,                                                        // Bundle of Leather
	Leather_30,                                                        // Bundle of Leather
	Leather_40,                                                        // Bundle of Leather
	Leather_5,                                                         // Bundle of Leather
	Leather_5pm,                                                       // Leather Delivery Line
	Leather_Plus1,                                                     // Tanning Racks
	Leather_Plus2,                                                     // Tanning Racks
	Leather_Plus3,                                                     // Tanning Racks
	Leather_Plus5,                                                     // Tanning Racks
	Leatherworks_Blueprint,                                            // Leatherworker
	Less_Resolve_From_Biscuits, 
	Less_Resolve_From_Jerky, 
	Less_Resolve_From_Pickled_Goods, 
	Less_Resolve_From_Pie, 
	Less_Resolve_From_Porridge, 
	Less_Resolve_From_Skewers, 
	Less_Trader_Merch, 
	LessHostilityPerMiner__Proficiency_1,                              // Flame Amulets
	LessHostilityPerWoodcutter,                                        // Flame Amulets
	LessHostilityPerWoodcutter___Proficiency,                          // Flame Amulets
	LessHostilityPerWoodcutter_8,                                      // Flame Amulets
	LessNewNewcomers_Random,                                           // Hunting Ground
	Library_Blueprint,                                                 // Library
	Lighthouse_Scouts_Curse,                                           // Mesmerizing Light
	Lizard_1,                                                          // Lizard
	Lizard_2,                                                          // Group of Lizards
	Lizard_3,                                                          // Group of Lizards
	Lizard_4,                                                          // Group of Lizards
	Lizard_5,                                                          // Group of Lizards
	Lizard_Faction_Support,                                            // Lizard Clan Support
	Lizard_House_Blueprint,                                            // Lizard House
	Lizard_Resolve_For_Training_Gear_Prod,                             // Training Grounds
	Lizards_Killed_3___Missiles,                                       // Blood for Blood
	Local_Taxes,                                                       // Local Taxes
	Locate_Springs,                                                    // Reveals a geyser
	Lock_Blightpost, 
	Lock_Crude_Workstation, 
	Lock_Hydrant, 
	Lock_Trading_Post, 
	Lock_Unlocked_Essentials___Tutorial_I, 
	Lock_Unlocked_Essentials___Tutorial_II, 
	Lock_Unlocked_Essentials___Tutorial_III, 
	Lock_Unlocked_Essentials___Tutorial_IV, 
	Long_Live_The_Queen,                                               // Long Live the Queen
	Longer_Clearance_Plus25,                                           // Clearance Totem
	Longer_Drizzle_Plus25,                                             // Drizzle Totem
	Longer_Storm_For_Wood_Production,                                  // Ancient Stabilizer
	Longer_Storm_Plus10, 
	Longer_Storm_Plus100, 
	Longer_Storm_Plus40, 
	Longer_Storm_Rain_Totem,                                           // Fishmen Rituals
	Lower_Glades, 
	Lower_Glades___Dangerous, 
	Lower_Glades_Fox___Dangerous, 
	Lower_Glades_Fox___Forbidden, 
	Lower_Glades_Fox___Small, 
	Lower_Hostility_For_Education,                                     // Consecrated Scrolls
	Lower_Hostility_For_People, 
	Lower_Hostility_For_Religion,                                      // Firelink Ritual
	Lumber_Speed__50, 
	Lumber_Speed_Plus10,                                               // Driving Water
	Lumber_Speed_Plus15,                                               // Reinforced Axes
	Lumber_Speed_Plus30,                                               // Reinforced Axes
	Lumber_Speed_Plus50,                                               // Reinforced Axes
	Lumbermill_Blueprint,                                              // Lumber Mill
	Machinery_1,                                                       // Machinery
	Machinery_10,                                                      // Machinery
	Machinery_2,                                                       // Machinery
	Machinery_3,                                                       // Machinery
	Machinery_4,                                                       // Machinery
	Machinery_5,                                                       // Machinery
	Makeshift_Extractor___Clearance_Water_Per_Minute,                  // Groundwater Extraction
	Makeshift_Extractor___Tank_Capacity, 
	Makeshift_Extractor___Water_Per_Minute_And_Tank,                   // Groundwater Extraction
	Makeshift_Post__Plus50,                                            // Worker Mobilization
	Manufactory_Blueprint,                                             // Manufactory
	Manuscripts_paper__3pm,                                            // Scroll Delivery Line
	Manuscripts_paper__5pm,                                            // Scroll Delivery Line
	Map_Mod_3_Order_Picks,                                             // Royal Outpost
	Map_Mod_Bonus_Timed_Orders,                                        // Forsaken Gods Temple
	Map_Mod_Consumption_Control_Block,                                 // Monastery of the Holy Flame
	Map_Mod_Dangerous_Lands,                                           // Dangerous Lands
	Map_Mod_Favoring_Block, 
	Map_Mod_Forbidden_Lands,                                           // Forbidden Lands
	Map_Mod_Hostility_People,                                          // Flooded Mines
	Map_Mod_Initial_Hostility,                                         // Ancient Battleground
	Map_Mod_Initial_Impatience,                                        // Sparkdew Crystals
	Map_Mod_Leaving_Block, 
	Map_Mod_Longer_Storm_5, 
	Map_Mod_More_Hostility_People, 
	Map_Mod_More_Hostility_Yearly, 
	Map_Mod_Move,                                                      // Levitating Monument
	Map_Mod_No_Control,                                                // Monastery of the Holy Flame
	Map_Mod_No_Glade_Info,                                             // Haunted Forest
	Map_Mod_No_Goods_Refund,                                           // Corrosive Torrent
	Map_Mod_No_Hostility,                                              // Watchtower
	Map_Mod_No_Hostility_Year, 
	Map_Mod_No_Leaving,                                                // Forsaken Gods Temple
	Map_Mod_No_Orders,                                                 // Fishmen Ritual Site
	Map_Mod_No_Reputation_From_Resolve, 
	Map_Mod_One_Perk,                                                  // Statue of the Forefathers
	Map_Mod_Overgrown_Library,                                         // Overgrown Library
	Map_Mod_Petrified_Necropolis,                                      // Petrified Necropolis
	Map_Mod_Resolve_Penalty,                                           // Forsaken Gods Temple
	Map_Mod_Ruins,                                                     // Ruins
	Map_Mod_Trader_Attack,                                             // Ruined Armory
	Map_Mod_Untamed_Wilds,                                             // Untamed Wilds
	Market_Blueprint,                                                  // Market
	Meat_10pm,                                                         // Meat Delivery Line
	Meat_5pm,                                                          // Meat Delivery Line
	Meat_And_Grain_For_Events,                                         // Lost Supplies
	Meat_Plus1,                                                        // Nets
	Meat_Plus2,                                                        // Nets
	Meat_Plus3,                                                        // Nets
	Meat_Plus5,                                                        // Nets
	Meat_Specialization,                                               // Meat Specialization
	Merchandise_Price_Reduction_Effect_Model, 
	Metal_Production_Speed_Boost_33, 
	Metal_Production_Speed_Boost_66,                                   // Metallurgic Proficiency
	Metal_Tools_10,                                                    // Box of Tools
	Metal_Tools_10___Lizard_Passive,                                   // Box of Tools
	Metal_Tools_12,                                                    // Box of Tools
	Metal_Tools_15,                                                    // Box of Tools
	Metal_Tools_20,                                                    // Box of Tools
	Metal_Tools_24,                                                    // Box of Tools
	Metal_Tools_3,                                                     // Box of Tools
	Metal_Tools_30,                                                    // Box of Tools
	Metal_Tools_34,                                                    // Box of Tools
	Metal_Tools_4,                                                     // Box of Tools
	Metal_Tools_40,                                                    // Box of Tools
	Metal_Tools_5,                                                     // Box of Tools
	Metal_Tools_6,                                                     // Box of Tools
	Metal_Tools_7,                                                     // Box of Tools
	Metal_Tools_8,                                                     // Box of Tools
	Metal_Tools_9,                                                     // Box of Tools
	Metalurgic_Proficiency_33,                                         // Metallurgic Proficiency
	Milk_cap_Mushroom_10,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_15,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_20,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_3,                                               // Pack of Mushrooms
	Milk_cap_Mushroom_30,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_40,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_5,                                               // Pack of Mushrooms
	Milk_cap_Mushroom_50,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_60,                                              // Pack of Mushrooms
	Milk_cap_Mushroom_8,                                               // Pack of Mushrooms
	Mill_Blueprint,                                                    // Rain Mill
	Mine_Plus100,                                                      // Rainpunk Drills
	Mine_Plus30,                                                       // Rainpunk Drills
	Mine_Speed_Plus100, 
	Mists_Piercers,                                                    // Mist Piercers
	Mistworm_All_Food_Lost,                                            // Mistworm Infestation
	Mistworm_RemoveFoodOverTime_Hard,                                  // Hungry Mistworm
	Mistworm_RemoveFoodOverTime_Impossible,                            // Hungry Mistworm
	Mistworm_RemoveFoodOverTime_Normal,                                // Hungry Mistworm
	Mistworm_RemoveFoodOverTime_VeryHard,                              // Hungry Mistworm
	Mod_3_Order_Picks,                                                 // The Generous Envoy
	Mod_Additional_Impatience_For_Death,                               // The Queen's People
	Mod_Advent_Of_Flame,                                               // Advent of Flame
	Mod_Amber_Payment,                                                 // Royal Tax
	Mod_Blightrot_Medium,                                              // Sinister Blight
	Mod_Calm_Lands,                                                    // Calm Lands
	Mod_Calm_Lands___Dangerous_Glades,                                 // Calm Lands
	Mod_Calm_Lands___Regular_Glades,                                   // Calm Lands
	Mod_Cysts_Spawn,                                                   // Blight Swarm
	Mod_Dangerous_Glades_Info_Block,                                   // Haunted Forest
	Mod_Disgrace,                                                      // Disgrace
	Mod_Exploration_Tax,                                               // Land Tax
	Mod_Exploration_Tax___Amber_Payment,                               // Land Tax (big glade)
	Mod_Exploration_Tax___Amber_Payment___Small,                       // Land Tax (small glade)
	Mod_Exploration_Tax___Composite,                                   // Land Tax
	Mod_Exploration_Tax___Small,                                       // Land Tax
	Mod_Faster_Fuel_Sacrafice,                                         // Hearth Defect
	Mod_Faster_Leaving,                                                // Higher Standards
	Mod_Fewer_Blueprints_Options,                                      // Less is More
	Mod_Fewer_Cornerstones_Options,                                    // Restrictions
	Mod_Fewer_Initial_Blueprints,                                      // Budget Cuts
	Mod_Fewer_Initial_Blueprints___Overgrown_Library,                  // Budget Cuts
	Mod_Gathering_Storm,                                               // Gathering Storm
	Mod_Global_Reputation_Treshold_Increase,                           // Malcontents
	Mod_Guilds_Disfavor,                                               // Guild's Disfavor
	Mod_Hard_Orders_Only,                                              // Hard Times
	Mod_Higher_Blueprints_Reroll_Cost,                                 // Expensive Lottery
	Mod_Higher_Needs_Consumption_Rate,                                 // Consumerism
	Mod_Higher_Traders_Prices,                                         // Guild of Traders, or Thieves?
	Mod_Human_Influx,                                                  // Human Influx
	Mod_Land_Of_Greed,                                                 // Land of Greed
	Mod_Less_Hearth_Range,                                             // Frosts
	Mod_Longer_Relics_Working_Time,                                    // Procrastination
	Mod_Longer_Storm,                                                  // Crumbling Seal
	Mod_Low_Food_Production_Speed,                                     // No Cooking Utensils
	Mod_Lower_Impatience_Reduction,                                    // Higher Expectations
	Mod_Memory_Of_The_Forest,                                          // Memory of the Forest
	Mod_Metal_Production_Speed_100,                                    // Metallurgic Experts
	Mod_No_Crude_Workstation,                                          // Missing Crude Workstation
	Mod_No_Order_Picks,                                                // Under the Queen's Gaze
	Mod_No_Positive_Seasonal_Effects,                                  // Unfavorable Weather
	Mod_Ominous_Presence,                                              // Ominous Presence
	Mod_Orders_Block,                                                  // Sabotage
	Mod_Parasites,                                                     // Parasites
	Mod_Petrified_Necropolis___Meat_For_Stone_And_Clay, 
	Mod_Petrified_Necropolis___Spawn_Deposit_On_Death, 
	Mod_Petrified_Necropolis___Stone_For_Death, 
	Mod_Politically_Outmaneuvered,                                     // Politically Outmaneuvered
	Mod_Queens_Support,                                                // Queen's Support
	Mod_RawDepositsCharges_10,                                         // Rich Wilderness
	Mod_Replace_Initial_Glade___Ruins,                                 // Abandoned Settlement
	Mod_Reputation_Changes,                                            // Prestigious Expedition
	Mod_Scavenging_Party,                                              // Scavenging Party
	Mod_Stingy_Archivist,                                              // Stingy Archivist
	Mod_The_Other_Settlement,                                          // The Other Settlement
	Mod_Third_Party,                                                   // Third Party
	Mod_VillagerDeathEffectBlock,                                      // Dark Secret
	Mod_Wet_Soil,                                                      // Wet Soil
	Mod_Wine_Shortage,                                                 // Wine Shortage
	ModifierEffect_AdditionalGrass,                                    // Fertile Grounds
	ModifierEffect_AncientGate,                                        // ModifierEffect_AncientGate_Name
	ModifierEffect_LongStorm,                                          // Weather Anomaly
	ModifierEffect_NoGrass,                                            // Barren Lands
	ModifierEffect_RuinedSettlement_Dangerous,                         // Ruins
	ModifierEffect_RuinedSettlement_Forbidden,                         // Ruins
	ModifierEffect_TradeBlock,                                         // Bandit Camp
	ModifierEffect_TradeBlock_Composite,                               // Bandit Camp
	ModifierEffect_TreeCuttingTime,                                    // Stonewood Infestation
	Mold_Grain,                                                        // Moldy Grain Seeds
	Mole_Earthquake,                                                   // Earthquake
	Mole_ForagersResolvePenalty_Hard, 
	Mole_ForagersResolvePenalty_Impossible, 
	Mole_ForagersResolvePenalty_Normal, 
	Mole_ForagersResolvePenalty_VeryHard, 
	Mole_HarvesterResolvePenalty_Hard, 
	Mole_HarvesterResolvePenalty_Impossible, 
	Mole_HarvesterResolvePenalty_Normal, 
	Mole_HarvesterResolvePenalty_VeryHard, 
	Mole_HerablistResolvePenalty_Hard, 
	Mole_HerablistResolvePenalty_Impossible, 
	Mole_HerablistResolvePenalty_Normal, 
	Mole_HerablistResolvePenalty_VeryHard, 
	Mole_Infestation_Composite,                                        // Infestation
	Mole_PimitiveTrapperPenalty_VeryHard, 
	Mole_PimitiveTrapperResolvePenalty_Hard, 
	Mole_PimitiveTrapperResolvePenalty_Impossible, 
	Mole_PimitiveTrapperResolvePenalty_Normal, 
	Mole_PrimitiveForagerResolvePenalty_Hard, 
	Mole_PrimitiveForagerResolvePenalty_Impossible, 
	Mole_PrimitiveForagerResolvePenalty_Normal, 
	Mole_PrimitiveForagerResolvePenalty_VeryHard, 
	Mole_PrimitiveHerbalistResolvePenalty_Hard, 
	Mole_PrimitiveHerbalistResolvePenalty_Impossible, 
	Mole_PrimitiveHerbalistResolvePenalty_Normal, 
	Mole_PrimitiveHerbalistResolvePenalty_VeryHard, 
	Mole_StonecuttersResolvePenalty_Hard, 
	Mole_StonecuttersResolvePenalty_Impossible, 
	Mole_StonecuttersResolvePenalty_Normal, 
	Mole_StonecuttersResolvePenalty_VeryHard, 
	Mole_TrappersResolvePenalty_Hard, 
	Mole_TrappersResolvePenalty_Impossible, 
	Mole_TrappersResolvePenalty_Normal, 
	Mole_TrappersResolvePenalty_VeryHard, 
	Mole_WoodcuttersResolvePenalty_Hard, 
	Mole_WoodcuttersResolvePenalty_Impossible, 
	Mole_WoodcuttersResolvePenalty_Normal, 
	Mole_WoodcuttersResolvePenalty_VeryHard, 
	MoleResolvePenalty___Hard,                                         // Giant Beast
	MoleResolvePenalty___Impossible,                                   // Giant Beast
	MoleResolvePenalty___Normal,                                       // Giant Beast
	MoleResolvePenalty___Very_Hard,                                    // Giant Beast
	Monastery_Blueprint,                                               // Monastery
	Monolith_Hostility,                                                // Obelisk
	More_Amber_From_Routes,                                            // Trade Negotiations
	More_Fuel_Produced, 
	More_Packs_Produced, 
	More_Packs_Produced_100, 
	More_Resolve_For_Comfortable,                                      // Long Term Contract
	More_Trade_Offers,                                                 // Market Shift Plan
	More_Trade_Offers___Extra_Trade_Routes, 
	More_Trade_Offers___Trader_Block,                                  // Market Shift Plan
	More_Trade_Offers___Trader_Block___Holder,                         // Adjustment Period
	MoreHostilityPerHearth,                                            // Cold Flame
	MoreHostilityPerHearth_Weak,                                       // Cold Flame
	Moth_Larvae_Meat_10,                                               // Pack of Meat
	Moth_Larvae_Meat_15,                                               // Pack of Meat
	Moth_Larvae_Meat_20,                                               // Pack of Meat
	Moth_Larvae_Meat_25,                                               // Pack of Meat
	Moth_Larvae_Meat_30,                                               // Pack of Meat
	Moth_Larvae_Meat_40,                                               // Pack of Meat
	Moth_Larvae_Meat_5,                                                // Pack of Meat
	Moth_Larvae_Meat_50,                                               // Pack of Meat
	Moth_Larvae_Meat_6,                                                // Pack of Meat
	Moth_Larvae_Meat_60,                                               // Pack of Meat
	Mushroom_Plus1,                                                    // Fungal Growth
	Mushroom_Plus2,                                                    // Fungal Growth
	Mushroom_Plus3,                                                    // Fungal Growth
	Mushroom_Plus5,                                                    // Fungal Growth
	Mushroom_Specialization,                                           // Fungal Guide
	Mushrooms_10pm,                                                    // Mushroom Delivery Line
	Mushrooms_5pm,                                                     // Mushroom Delivery Line
	Mushrooms_In_Farms,                                                // Mushroom Seedlings
	Mushrooms_In_Grove,                                                // Seasonal Crops
	Mushrooms_In_Grove___Altar,                                        // Seasonal Crops (Stormforged)
	Mushrooms_In_Herb_Garden,                                          // Seasonal Crops
	Mushrooms_In_Herb_Garden___Altar,                                  // Seasonal Crops (Stormforged)
	Mushrooms_In_Herb_Garden_Haunted,                                  // Seasonal Crops
	Mushrooms_In_Herb_Garden_Haunted___Altar,                          // Seasonal Crops (Stormforged)
	Mushrooms_In_Plantation,                                           // Seasonal Crops
	Mushrooms_In_Plantation___Altar,                                   // Seasonal Crops (Stormforged)
	Mushrooms_In_SmallFarm,                                            // Seasonal Crops
	Mushrooms_In_SmallFarm___Altar,                                    // Seasonal Crops (Stormforged)
	Mushrooms_In_SmallFarm_Haunted,                                    // Seasonal Crops
	Mushrooms_In_SmallFarm_Haunted___Altar,                            // Seasonal Crops (Stormforged)
	NeedPerk_Ale_Resolve,                                              // Spiced Ale
	NeedPerk_Biscuit_Farmers,                                          // Biscuit Diet
	NeedPerk_Coats_Breaks,                                             // Drying Boards
	NeedPerk_Education_Production,                                     // Working Hard and Smart
	NeedPerk_Housing_Resolve,                                          // Furniture
	NeedPerk_Leisure_Production,                                       // Well-Rested Workers
	New_Season_Change_Block_Effect_Model, 
	New_Season_Change_Effect_Model, 
	Newcomer_Goods_Plus10, 
	Newcomer_Goods_Plus20, 
	Newcomer_Goods_Plus25, 
	Newcomer_Goods_Plus40, 
	Newcomer_Goods_Plus50, 
	Newcomer_Goods_Plus75, 
	Newcomer_Rate_For_Trade_Routes,                                    // Economic Migration
	Newcomers_Faster_15, 
	Newcomers_Faster_20, 
	Newcomers_Faster_25,                                               // Secure Trail
	Newcomers_Slower_33,                                               // Shifting Paths
	NewNewcomersBonus_Random,                                          // Crowded Caravan
	NewNewcomersBonus_Random_3, 
	NewRandomVillagers, 
	NewRandomVillagers_10,                                             // Villagers
	NewRandomVillagers_2,                                              // Villagers
	NewRandomVillagers_3,                                              // Villagers
	NewRandomVillagers_4,                                              // Villagers
	NewRandomVillagers_5,                                              // Villagers
	NewRandomVillagers_6,                                              // Villagers
	Nights_Embrace,                                                    // The Night's Embrace
	Noria_Plant_And_Harvest,                                           // Rainpunk Noria
	Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Hard,            // Overflow
	Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Impossible,      // Overflow
	Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Normal,          // Overflow
	Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Very_Hard,       // Overflow
	NoxiousMachinery_RemoveWaterOverTime___Hard, 
	NoxiousMachinery_RemoveWaterOverTime___Impossible, 
	NoxiousMachinery_RemoveWaterOverTime___Normal, 
	NoxiousMachinery_RemoveWaterOverTime___Very_Hard, 
	Oil_10,                                                            // Oil Vessels
	Oil_10pm,                                                          // Oil Delivery Line
	Oil_15,                                                            // Oil Vessels
	Oil_2,                                                             // Oil Vessels
	Oil_20,                                                            // Oil Vessels
	Oil_3,                                                             // Oil Vessels
	Oil_30,                                                            // Oil Vessels
	Oil_40,                                                            // Oil Vessels
	Oil_5,                                                             // Oil Vessels
	Oil_50,                                                            // Oil Vessels
	Oil_5pm,                                                           // Oil Delivery Line
	Oil_6,                                                             // Oil Vessels
	Oil_Plus1,                                                         // Heavy Press
	Oil_Plus2,                                                         // Heavy Press
	Oil_Plus3,                                                         // Heavy Press
	Oil_Plus5,                                                         // Heavy Press
	Opened_Dang_Glades_Reduces_Resolve,                                // Greater Threat
	Ore_Production_Speed_Boost_33, 
	Ore_Production_Speed_Boost_66,                                     // Metallurgic Proficiency
	Outpost_RemoveFoodOverTime___Hard,                                 // Thieving Fishmen
	Outpost_RemoveFoodOverTime___Impossible,                           // Thieving Fishmen
	Outpost_RemoveFoodOverTime___Normal,                               // Thieving Fishmen
	Outpost_RemoveFoodOverTime___Very_Hard,                            // Thieving Fishmen
	Overexploitation,                                                  // Overexploitation
	Overexploitation___Cyst_For_Node, 
	Overflow,                                                          // Overflow
	Pack_Of_Building_Materials_1,                                      // Packs of Building Materials
	Pack_Of_Building_Materials_10,                                     // Packs of Building Materials
	Pack_Of_Building_Materials_12,                                     // Packs of Building Materials
	Pack_Of_Building_Materials_15,                                     // Packs of Building Materials
	Pack_Of_Building_Materials_5,                                      // Packs of Building Materials
	Pack_Of_Building_Materials_8,                                      // Packs of Building Materials
	Pack_Of_Building_Materials_Plus1, 
	Pack_Of_Building_Materials_Plus2, 
	Pack_Of_Building_Materials_Plus3, 
	Pack_Of_Building_Materials_Plus4, 
	Pack_Of_Building_Materials_Plus5, 
	Pack_Of_Building_Worth_More, 
	Pack_Of_Building_Worth_More_33, 
	Pack_Of_Crops_1,                                                   // Packs of Crops
	Pack_Of_Crops_10,                                                  // Packs of Crops
	Pack_Of_Crops_15,                                                  // Packs of Crops
	Pack_Of_Crops_5,                                                   // Packs of Crops
	Pack_Of_Crops_Plus1,                                               // Industrialized Farming
	Pack_Of_Crops_Plus2,                                               // Industrialized Farming
	Pack_Of_Crops_Plus3,                                               // Industrialized Farming
	Pack_Of_Crops_Plus4,                                               // Industrialized Farming
	Pack_Of_Crops_Plus5,                                               // Industrialized Farming
	Pack_Of_Crops_Worth_More,                                          // Tight Packaging
	Pack_Of_Crops_Worth_More_1, 
	Pack_Of_Crops_Worth_More_33, 
	Pack_Of_Luxury_Plus1, 
	Pack_Of_Luxury_Plus2, 
	Pack_Of_Luxury_Plus3, 
	Pack_Of_Luxury_Plus5, 
	Pack_Of_Luxury_Worth_More, 
	Pack_Of_Luxury_Worth_More_33, 
	Pack_Of_Provisions_1,                                              // Packs of Provisions
	Pack_Of_Provisions_10,                                             // Packs of Provisions
	Pack_Of_Provisions_15,                                             // Packs of Provisions
	Pack_Of_Provisions_2,                                              // Packs of Provisions
	Pack_Of_Provisions_3,                                              // Packs of Provisions
	Pack_Of_Provisions_5,                                              // Packs of Provisions
	Pack_Of_Provisions_6,                                              // Packs of Provisions
	Pack_Of_Provisions_Plus1, 
	Pack_Of_Provisions_Plus2, 
	Pack_Of_Provisions_Plus3, 
	Pack_Of_Provisions_Plus5, 
	Pack_Of_Provisions_Worth_More, 
	Pack_Of_Provisions_Worth_More_33, 
	Pack_Of_Trade_Good_10,                                             // Pack of Trade Goods
	Pack_Of_Trade_Good_15,                                             // Pack of Trade Goods
	Pack_Of_Trade_Good_6,                                              // Pack of Trade Goods
	Pack_Of_Trade_Goods_Plus1, 
	Pack_Of_Trade_Goods_Plus2, 
	Pack_Of_Trade_Goods_Plus3, 
	Pack_Of_Trade_Goods_Plus5, 
	Pack_Of_Trade_Goods_Worth_More,                                    // Value Added Tax
	Pack_Of_Trade_Goods_Worth_More_33, 
	Pack_Of_Valuables_10,                                              // Pack of Luxury Goods
	Pack_Of_Valuables_15,                                              // Pack of Luxury Goods
	Pack_Of_Valuables_5,                                               // Pack of Luxury Goods
	Packs_Of_Goods_Plus1,                                              // Export Specialization
	Packs_Of_Goods_Plus2,                                              // Export Specialization
	Packs_Production_Speed_Boost_33,                                   // Quick Deliveries
	Packs_Production_Speed_Boost_50, 
	Packs_Production_Speed_Boost_66,                                   // Quick Deliveries
	PacksForResolveRep,                                                // Export Contract
	Paper_10,                                                          // Bundle of Scrolls
	Paper_25,                                                          // Bundle of Scrolls
	Paper_30,                                                          // Bundle of Scrolls
	Paper_40,                                                          // Bundle of Scrolls
	Paper_Plus1,                                                       // Advanced Press
	Paper_Plus2,                                                       // Advanced Press
	Paper_Plus3,                                                       // Advanced Press
	Paper_Plus5,                                                       // Advanced Press
	Parts_1,                                                           // Parts
	Parts_10,                                                          // Parts
	Parts_12,                                                          // Parts
	Parts_14,                                                          // Parts
	Parts_15,                                                          // Parts
	Parts_2,                                                           // Parts
	Parts_20,                                                          // Parts
	Parts_3,                                                           // Parts
	Parts_4,                                                           // Parts
	Parts_5,                                                           // Parts
	Parts_8,                                                           // Parts
	Parts_For_Trade,                                                   // Free Samples
	Parts_In_Crude_Workshop,                                           // Forge Trip Hammer
	Parts_In_Smithy,                                                   // Forge Trip Hammer
	Pause_Block,                                                       // Shattered Obelisk
	Petrified_Tree___Houses_Global_Capacity__1,                        // Degradation
	Petrified_Tree_Cutting_Speed___Normal,                             // Petrification
	Pickled_Goods_15,                                                  // Pickled Goods
	Pickled_Goods_20,                                                  // Pickled Goods
	Pickled_Goods_30,                                                  // Pickled Goods
	Pickled_Goods_3pm,                                                 // Pickled Goods Delivery Line
	Pickled_Goods_40,                                                  // Pickled Goods
	Pickled_Goods_5pm,                                                 // Pickled Goods Delivery Line
	Pickled_Goods_60,                                                  // Pickled Goods
	Pickled_Goods_Plus1,                                               // Pickle Jars
	Pickled_Goods_Plus2,                                               // Pickle Jars
	Pickled_Goods_Plus3,                                               // Pickle Jars
	Pickled_Goods_Plus5,                                               // Pickle Jars
	Pie_20,                                                            // Basket of Pies
	Pie_25,                                                            // Basket of Pies
	Pie_30,                                                            // Basket of Pies
	Pie_3pm,                                                           // Pie Delivery Line
	Pie_40,                                                            // Basket of Pies
	Pie_5pm,                                                           // Pie Delivery Line
	Pie_Plus1,                                                         // Bigger Ovens
	Pie_Plus2,                                                         // Bigger Ovens
	Pie_Plus3,                                                         // Bigger Ovens
	Pie_Plus5,                                                         // Bigger Ovens
	Pipes_10,                                                          // Pipes
	Pipes_15,                                                          // Pipes
	Pipes_20,                                                          // Pipes
	Pipes_4,                                                           // Pipes
	Pipes_5,                                                           // Pipes
	Pipes_8,                                                           // Pipes
	Pipes_Plus1,                                                       // Stamping Die
	Planks_10,                                                         // Box of Planks
	Planks_15,                                                         // Box of Planks
	Planks_2,                                                          // Box of Planks
	Planks_20,                                                         // Box of Planks
	Planks_25,                                                         // Box of Planks
	Planks_3,                                                          // Box of Planks
	Planks_30,                                                         // Box of Planks
	Planks_5,                                                          // Box of Planks
	Planks_Plus1,                                                      // Reinforced Saw Blades
	Planks_Plus2,                                                      // Reinforced Saw Blades
	Planks_Plus3,                                                      // Reinforced Saw Blades
	Planks_Plus5,                                                      // Reinforced Saw Blades
	Plant_Fiber_10,                                                    // Bundle of Plant Fiber
	Plant_Fiber_15,                                                    // Bundle of Plant Fiber
	Plant_Fiber_20,                                                    // Bundle of Plant Fiber
	Plant_Fiber_25,                                                    // Bundle of Plant Fiber
	Plant_Fiber_30,                                                    // Bundle of Plant Fiber
	Plant_Fiber_35,                                                    // Bundle of Plant Fiber
	Plant_Fiber_4,                                                     // Bundle of Plant Fiber
	Plant_Fiber_40,                                                    // Bundle of Plant Fiber
	Plant_Fiber_50,                                                    // Bundle of Plant Fiber
	Plant_Fibre_Plus1,                                                 // Rich in Fiber
	Plant_Fibre_Plus2,                                                 // Rich in Fiber
	Plant_Fibre_Plus3,                                                 // Rich in Fiber
	Plant_Fibre_Plus5,                                                 // Rich in Fiber
	Plantation__50,                                                    // Reinforced Tools
	Plantation_Blueprint,                                              // Plantation
	Plantation_Plus100, 
	Plantation_Plus150, 
	Plantation_Plus25,                                                 // Large Baskets
	Plantation_Plus50,                                                 // Large Baskets
	PlantingRate__25,                                                  // Slow Planting
	PlantingRate__50,                                                  // Slow Planting
	PlantingRate__60,                                                  // Slow Planting
	PlantingRate__70,                                                  // Slow Planting
	PlantingRate__80,                                                  // Slow Planting
	PlantingRate_Plus10,                                               // Seed Pouch
	PlantingRate_Plus100,                                              // Fertilizer
	PlantingRate_Plus25,                                               // Seed Pouch
	PlantingRate_Plus30,                                               // Fertilizer
	PlantingRate_Plus5,                                                // Seed Pouch
	PlantingRate_Plus50,                                               // Quick Planting
	PlantingRate_Plus75,                                               // Fertilizer
	Porridge_10,                                                       // Box of Porridge
	Porridge_15,                                                       // Box of Porridge
	Porridge_20,                                                       // Box of Porridge
	Porridge_25,                                                       // Box of Porridge
	Porridge_30,                                                       // Box of Porridge
	Porridge_40,                                                       // Box of Porridge
	Porridge_50,                                                       // Box of Porridge
	Porridge_Plus1,                                                    // Puffed Grain
	Porridge_Plus2,                                                    // Puffed Grain
	Porridge_Plus3,                                                    // Puffed Grain
	Porridge_Plus4,                                                    // Puffed Grain
	Porridge_Plus5,                                                    // Puffed Grain
	Porridge_Prod_For_Water,                                           // Filling Dish
	Pottery_10,                                                        // Box of Pottery
	Pottery_20,                                                        // Box of Pottery
	Pottery_3,                                                         // Box of Pottery
	Pottery_30,                                                        // Box of Pottery
	Pottery_35,                                                        // Box of Pottery
	Pottery_40,                                                        // Box of Pottery
	Pottery_5,                                                         // Box of Pottery
	Pottery_5pm,                                                       // Pottery Delivery Line
	Pottery_6,                                                         // Box of Pottery
	Pottery_For_Glade,                                                 // Archaeological Tools
	Pottery_Plus1,                                                     // Rain-Powered Pottery Wheel
	Pottery_Plus2,                                                     // Rain-Powered Pottery Wheel
	Pottery_Plus3,                                                     // Rain-Powered Pottery Wheel
	Pottery_Plus5,                                                     // Rain-Powered Pottery Wheel
	Prayers,                                                           // Prayers
	Press_Blueprint,                                                   // Press
	ProdSpeedForEducation,                                             // Work Safety Guide
	Provisioner_Blueprint,                                             // Provisioner
	Provisioner_Plus50,                                                // Reinforced Stoves
	Provisions_For_Glade,                                              // Gathering Tools
	Queens_Gift_10,                                                    // Purging Fire
	Queens_Gift_15,                                                    // Purging Fire
	Queens_Gift_5,                                                     // Purging Fire
	Queens_Sailors,                                                    // Queen's Sailors
	Rain_Totem_Longer_Storm, 
	Rain_Totem_Lower_Hostility,                                        // Converted Rain Totem
	Rain_Totem_Shorter_Clearance, 
	Rain_Totem_Shorter_Drizzle, 
	Rain_Totem_Slow,                                                   // Curse of Weakness
	Rainpuink_Drill___Spawn_Ore_Around___Coal,                         // Geological Survey
	Rainpuink_Drill___Spawn_Ore_Around___Copper,                       // Geological Survey
	Rainpunk_Explosion___Big,                                          // Magical Explosion
	Rainpunk_Explosion___Noxious, 
	Rainpunk_Explosion___Small,                                        // Magical Explosion
	Rainpunk_Explosion___Smallest,                                     // Discharge
	Ranch_Blueprint,                                                   // Ranch
	Random_Goods_For_Dearth,                                           // Seized Inheritance
	Random_Killed_10,                                                  // Death from Beyond
	Random_Killed_2___Blood_Missiles, 
	Random_Killed_2___Kelpie_Missiles,                                 // Watery Grave
	Random_Killed_2___Missiles, 
	Random_Killed_3___Corruption,                                      // Voice of the Sealed Ones
	Random_Killed_3___Missiles,                                        // Curse of the Forefathers
	Random_Killed_5___Missiles,                                        // Curse of the Forefathers
	Raw_Deposit_Charges__15, 
	Raw_Deposit_Charges__5, 
	RawDepositsCharges_10,                                             // Rich Glades
	RawDepositsCharges_20, 
	Rebelious_Spirit,                                                  // Rebellious Spirit
	Reed_Plus1,                                                        // Leather Gloves
	Reed_Plus2,                                                        // Leather Gloves
	Reed_Plus3,                                                        // Leather Gloves
	Reed_Plus5,                                                        // Leather Gloves
	Reeds_10,                                                          // Bundle of Reeds
	Reeds_10pm,                                                        // Reed Delivery Line
	Reeds_15,                                                          // Bundle of Reeds
	Reeds_20,                                                          // Bundle of Reeds
	Reeds_25,                                                          // Bundle of Reeds
	Reeds_30,                                                          // Bundle of Reeds
	Reeds_35,                                                          // Bundle of Reeds
	Reeds_40,                                                          // Bundle of Reeds
	Reeds_5,                                                           // Bundle of Reeds
	Reeds_50,                                                          // Bundle of Reeds
	Reeds_5pm,                                                         // Reed Delivery Line
	Reeds_8,                                                           // Bundle of Reeds
	Relic_Ritual_1,                                                    // Forbidden Ritual
	Relic_Ritual_2,                                                    // Forbidden Ritual
	Relic_Time_Reduction,                                              // Firekeeper's Prayer
	Relic_Working_TIme__10, 
	Relic_Working_TIme__2, 
	Relic_Working_TIme__20, 
	Relic_Working_TIme__25, 
	Relic_Working_TIme__7, 
	Relic_Working_TIme_Plus10, 
	Relics_Chance_For_Extra_Reward_100, 
	Relics_Chance_For_Extra_Reward_20, 
	Remove_Amber, 
	Remove_Amber_And_Wine,                                             // Buried Riches
	Remove_Buildings_Thunder,                                          // Lightning Strike
	Remove_Chests_From_Glades,                                         // Plundering
	Remove_One_Cornerstone_Stag,                                       // Stag's Echo
	Replace_Angry_Ghost_Chest,                                         // Ghost Chest
	Replace_Blightrot,                                                 // Decay
	Replace_Building_Advanced_Rain_Catcher,                            // Advanced Rain Collector
	Replace_Building_Alchemist,                                        // Alchemist's Hut
	Replace_Building_Apotchecary,                                      // Apothecary
	Replace_Building_Artisan,                                          // Artisan
	Replace_Building_Bakery,                                           // Bakery
	Replace_Building_Bath_House,                                       // Bath House
	Replace_Building_Beanery,                                          // Beanery
	Replace_Building_Beaver_House,                                     // Beaver House
	Replace_Building_Big_Shelter,                                      // Big Shelter
	Replace_Building_Brewery,                                          // Brewery
	Replace_Building_Brick_Oven,                                       // Brick Oven
	Replace_Building_Brickyard,                                        // Brickyard
	Replace_Building_Butcher,                                          // Butcher
	Replace_Building_Carpenter,                                        // Carpenter
	Replace_Building_Cellar,                                           // Cellar
	Replace_Building_Clan_Hall,                                        // Clan Hall
	Replace_Building_Clay_Pit,                                         // Clay Pit
	Replace_Building_Cookhouse,                                        // Cookhouse
	Replace_Building_Cooperage,                                        // Cooperage
	Replace_Building_Crude_Workstation,                                // Crude Workstation
	Replace_Building_Distillery,                                       // Distillery
	Replace_Building_Druid,                                            // Druid's Hut
	Replace_Building_Explorers_Lodge,                                  // Explorers' Lodge
	Replace_Building_Farm,                                             // Homestead
	Replace_Building_Field_Kitchen,                                    // Field Kitchen
	Replace_Building_Finesmith,                                        // Finesmith
	Replace_Building_Foragers_Camp,                                    // Foragers' Camp
	Replace_Building_Foragers_Camp_Primitive,                          // Small Foragers' Camp
	Replace_Building_Forum,                                            // Forum
	Replace_Building_Fox_House,                                        // Fox House
	Replace_Building_Furnace,                                          // Furnace
	Replace_Building_Granary,                                          // Granary
	Replace_Building_Greenhouse,                                       // Greenhouse
	Replace_Building_Grill,                                            // Grill
	Replace_Building_Grove,                                            // Forester's Hut
	Replace_Building_Guild_House,                                      // Guild House
	Replace_Building_Harpy_House,                                      // Harpy House
	Replace_Building_Harvester_Camp,                                   // Harvesters' Camp
	Replace_Building_Haunted_Beaver_House,                             // Purified Beaver House
	Replace_Building_Haunted_Brewery,                                  // Flawless Brewery
	Replace_Building_Haunted_Cellar,                                   // Flawless Cellar
	Replace_Building_Haunted_Cooperage,                                // Flawless Cooperage
	Replace_Building_Haunted_Druid,                                    // Flawless Druid's Hut
	Replace_Building_Haunted_Fox_House,                                // Purified Fox House
	Replace_Building_Haunted_Harpy_House,                              // Purified Harpy House
	Replace_Building_Haunted_Herb_Garden,                              // Hallowed Herb Garden
	Replace_Building_Haunted_Human_House,                              // Purified Human House
	Replace_Building_Haunted_Leatherworks,                             // Flawless Leatherworker
	Replace_Building_Haunted_Lizard_House,                             // Purified Lizard House
	Replace_Building_Haunted_Market,                                   // Holy Market
	Replace_Building_Haunted_Rainmill,                                 // Flawless Rain Mill
	Replace_Building_Haunted_SmallFarm,                                // Hallowed Small Farm
	Replace_Building_Haunted_Smelter,                                  // Flawless Smelter
	Replace_Building_Haunted_Temple,                                   // Holy Temple
	Replace_Building_Hearth,                                           // Ancient Hearth
	Replace_Building_Herb_Garden,                                      // Herb Garden
	Replace_Building_Herbalist_Camp,                                   // Herbalists' Camp
	Replace_Building_Herbalist_Camp_Primitive,                         // Small Herbalists' Camp
	Replace_Building_Human_House,                                      // Human House
	Replace_Building_Kiln,                                             // Kiln
	Replace_Building_Leatherworks,                                     // Leatherworker
	Replace_Building_Library,                                          // Library
	Replace_Building_Lizard_House,                                     // Lizard House
	Replace_Building_Lumbermill,                                       // Lumber Mill
	Replace_Building_Makeshift_Post,                                   // Makeshift Post
	Replace_Building_Manufactory,                                      // Manufactory
	Replace_Building_Market,                                           // Market
	Replace_Building_Mine,                                             // Mine
	Replace_Building_Monastery,                                        // Monastery
	Replace_Building_Plantation,                                       // Plantation
	Replace_Building_Press,                                            // Press
	Replace_Building_Provisioner,                                      // Provisioner
	Replace_Building_Rain_Catcher,                                     // Rain Collector
	Replace_Building_Rainmill,                                         // Rain Mill
	Replace_Building_Rainpunk_Foundry,                                 // Rainpunk Foundry
	Replace_Building_Ranch,                                            // Ranch
	Replace_Building_Scribe,                                           // Scribe
	Replace_Building_Sewer,                                            // Clothier
	Replace_Building_Shelter,                                          // Shelter
	Replace_Building_SmallFarm,                                        // Small Farm
	Replace_Building_Smelter,                                          // Smelter
	Replace_Building_Smithy,                                           // Smithy
	Replace_Building_Smokehouse,                                       // Smokehouse
	Replace_Building_Stamping_Mill,                                    // Stamping Mill
	Replace_Building_Stonecutters_Camp,                                // Stonecutters' Camp
	Replace_Building_Storage,                                          // Small Warehouse
	Replace_Building_Supplier,                                         // Supplier
	Replace_Building_Tavern,                                           // Tavern
	Replace_Building_Tea_Doctor,                                       // Tea Doctor
	Replace_Building_Tea_House,                                        // Teahouse
	Replace_Building_Temple,                                           // Temple
	Replace_Building_Tinctury,                                         // Tinctury
	Replace_Building_Tinkerer,                                         // Tinkerer
	Replace_Building_Toolshop,                                         // Toolshop
	Replace_Building_TradingPost,                                      // Trading Post
	Replace_Building_Trappers_Camp,                                    // Trappers' Camp
	Replace_Building_Trappers_Camp_Primitive,                          // Small Trappers' Camp
	Replace_Building_Weaver,                                           // Weaver
	Replace_Building_Woodcutters_Camp,                                 // Woodcutters' Camp
	Replace_Building_Workshop,                                         // Workshop
	Replace_Calm_Ghost_Chest,                                          // Decay
	Replace_Decay_Altar,                                               // Converted Altar of Decay
	Replace_Fishmen_Lighthouse,                                        // Termite Nest
	Replace_Fuming_Machinery,                                          // Makeshift Extractor
	Replace_Harmony_Altar,                                             // Converted Harmony Spirit Altar
	Replace_Monolith,                                                  // Obelisk
	Replace_Noria,                                                     // Rainpunk Noria
	Replace_Rain_Totem,                                                // Converted Rain Totem
	Replace_Sacrifice_Totem,                                           // Converted Totem of Denial
	Replace_Stormbird,                                                 // Tamed Stormbird
	Replace_Termite_Burrow,                                            // Termite Nest
	Replace_With_Scorpion_2,                                           // Excavation 
	Replace_With_Scorpion_3,                                           // Conservation
	Replace_With_Scorpion_Positive,                                    // Reconstruction
	Replace_With_Snake_2,                                              // Excavation 
	Replace_With_Snake_3,                                              // Conservation
	Replace_With_Snake_Positive,                                       // Reconstruction
	Replace_With_Spider_2,                                             // Excavation 
	Replace_With_Spider_3,                                             // Conservation
	Replace_With_Spider_Positive,                                      // Reconstruction
	Reputation_From_Trade,                                             // Trade Hub
	ReputationForLuxury,                                               // Land of Luxury
	ReputationPenaltyRate_15, 
	ReputationPenaltyRate_4, 
	ReputationPenaltyRate_5, 
	ReputationPenaltyRate_HearthEffect_Human,                          // Beacon
	ReputationPenaltyRate_Vault_100,                                   // Irresponsible Archaeology
	ReputationPenaltyRate_Vault_125,                                   // Irresponsible Archaeology
	ReputationPenaltyRate_Vault_150,                                   // Irresponsible Archaeology
	ReputationPenaltyRate_Vault_175,                                   // Irresponsible Archaeology
	Resilience_Resolve_Drops_Faster,                                   // Sensitivity
	Resin_10,                                                          // Resin
	Resin_15,                                                          // Resin
	Resin_2,                                                           // Resin
	Resin_20,                                                          // Resin
	Resin_25,                                                          // Resin
	Resin_30,                                                          // Resin
	Resin_3pm,                                                         // Resin Delivery Line
	Resin_4,                                                           // Resin
	Resin_40,                                                          // Resin
	Resin_5pm,                                                         // Resin Delivery Line
	Resin_6,                                                           // Resin
	Resin_Plus1,                                                       // Bleeding Trees
	Resin_Plus2,                                                       // Bleeding Trees
	Resin_Plus3,                                                       // Bleeding Trees
	Resin_Plus5,                                                       // Bleeding Trees
	Resolve___Institution_Resolve_For_Ruins,                           // The Crown Chronicles
	Resolve___Institution_Resolve_For_Sales,                           // The Guild's Welfare
	Resolve___Resolve_For_Chests,                                      // Prosperous Archaeology
	Resolve___Resolve_For_Sales,                                       // Prosperous Settlement
	Resolve___Resolve_For_Standing,                                    // Friendly Relations
	Resolve_For_Chests,                                                // Prosperous Archaeology
	Resolve_For_Complex_Food,                                          // Vitality
	Resolve_For_Consumption,                                           // Generous Rations
	Resolve_For_Glade,                                                 // Woodcutter's Song
	Resolve_For_Glade___Resolve_Bonus_Effect,                          // Woodcutter's Song
	Resolve_For_Glade___Resolve_Bonus_Effect___Holder,                 // Inspiring Work
	Resolve_For_Impatience,                                            // Rebellious Spirit
	Resolve_For_Incense_Humans,                                        // Sweet Aroma
	Resolve_For_Reputation,                                            // Long Live the Queen
	Resolve_For_Sales,                                                 // Prosperous Settlement
	Resolve_For_Services,                                              // Converted Harmony Spirit Altar
	Resolve_For_Standing,                                              // Friendly Relations
	Resolve_For_Started_Route,                                         // Frequent Caravans
	Resolve_For_Started_Route___Impatience_Slower,                     // Frequent Caravans
	Resolve_For_Started_Route___Impatience_Slower___Holder,            // Bustling Town
	Resolve_For_Tea_Harpies,                                           // Health Infusion
	Resolve_For_Training_Gear_Lizards,                                 // Armed to the Teeth
	Resolve_For_Trees___Fishmen___Hard,                                // Creeping Fishmen
	Resolve_For_Trees___Fishmen___Impossible,                          // Creeping Fishmen
	Resolve_For_Trees___Fishmen___Normal,                              // Creeping Fishmen
	Resolve_For_Trees___Fishmen___Very_Hard,                           // Creeping Fishmen
	Resolve_For_Wine_Beavers,                                          // Vineyard Town
	Resolve_Penalty_For_Every_10_Amber___Hard,                         // Robbed Dead
	Resolve_Penalty_For_Every_10_Amber___Impossible,                   // Robbed Dead
	Resolve_Penalty_For_Every_10_Amber___Normal,                       // Robbed Dead
	Resolve_Penalty_For_Every_10_Amber___Very_Hard,                    // Robbed Dead
	Resolve_To_Reputation__50, 
	Resolve_To_Reputation__75, 
	Resolve_To_Reputation__80, 
	Resolve_To_Reputation_Plus20, 
	Resolve_To_Reputation_Plus5, 
	Resolve_To_Reputation_Plus50, 
	Rewards_Pack_Big,                                                  // Big Mystery Box
	Rewards_Pack_Big_1,                                                // Big Mystery Box
	Rewards_Pack_Medium,                                               // Medium Mystery Box
	Rewards_Pack_Medium_1,                                             // Medium Mystery Box
	Rewards_Pack_Small,                                                // Small Mystery Box
	Rewards_Pack_Small_1,                                              // Small Mystery Box
	Root_For_Every_Glade,                                              // Grubbing Tools
	Roots_10,                                                          // Pack of Roots
	Roots_10pm,                                                        // Root Delivery Line
	Roots_15,                                                          // Pack of Roots
	Roots_20,                                                          // Pack of Roots
	Roots_30,                                                          // Pack of Roots
	Roots_3pm,                                                         // Root Delivery Line
	Roots_40,                                                          // Pack of Roots
	Roots_50,                                                          // Pack of Roots
	Roots_5pm,                                                         // Root Delivery Line
	Roots_Plus1,                                                       // Steel Penknives
	Roots_Plus2,                                                       // Steel Penknives
	Roots_Plus3,                                                       // Steel Penknives
	Roots_Plus5,                                                       // Steel Penknives
	Rotting_Wood_Workplace,                                            // Rotting Wood
	Route_Less_Travel_Time,                                            // Stormwalker Training
	Route_Less_Travel_Time_33, 
	Route_Less_Travel_Time_5,                                          // Stormwalker Training
	Royal_Guard_Training,                                              // Royal Guard Training
	Royal_Guard_Training___NeedPerk, 
	Sacrifice_Block_During_Corruption,                                 // Baptism of Fire
	Sacrifice_Cost_20_Shorter, 
	Sacrifice_Cost_25_Longer, 
	Sacrifice_Cost_25_Shorter, 
	Sacrifice_Cost_3_Longer,                                           // Fiery Wrath
	Sacrifice_Cost_30_Longer, 
	Sacrifice_Cost_33_Longer, 
	Sacrifice_Cost_5_Longer,                                           // Fiery Wrath
	Sacrifice_Cost_50_Longer, 
	Sacrifice_Cost_For_Impatience,                                     // Fiery Wrath
	Sacrifice_Stack_For_Route,                                         // Firekeeper Letters
	Sacrifice_Stack_Plus1, 
	Sacrificed_1, 
	Sacrificed_1_Noxious_Machinery, 
	Sacrificed_3___Plague_Of_Death, 
	SacrificeTotemPositive,                                            // Converted Totem of Denial
	SaveVillagersForAncientTablets,                                    // Escaping the Shadows
	Scout_Plus10,                                                      // Scout's Pack
	Scout_Plus15,                                                      // Scout's Pack
	Scout_Plus3,                                                       // Scout's Pack
	Scout_Plus5,                                                       // Scout's Pack
	Scout_Speed_Plus5, 
	Scribe_Blueprint,                                                  // Scribe
	SE_Amber_For_Trade,                                                // Royal Funding
	SE_Berries_Plus3,                                                  // Berry New Year
	SE_Building_Materials_Prod_Penalty,                                // Acid Rain
	SE_Clearance_For_Drizzle,                                          // Golden Dust
	SE_Corruption_Favoring_Block,                                      // Unyielding Corruption
	SE_Creeping_Shadows,                                               // Creeping Shadows
	SE_Creeping_Shadows___Resolve_Penalty_Effect,                      // Creeping Shadows
	SE_Creeping_Shadows___Resolve_Penalty_Effect___Holder,             // Shadowy Figure
	SE_Cricket_Mating_Grounds,                                         // Cricket Mating Grounds
	SE_Cysts_Generate_Impatience_In_Storm,                             // Spreading Contamination
	SE_Dang_Glades_Reduces_Resolve_In_Storm,                           // Greater Threat
	SE_Death_Blightrot,                                                // Blightrot Infection
	SE_Destroy_Nodes,                                                  // Unnatural Erosion
	SE_Devastating_Storms,                                             // Devastating Storms
	SE_Drizzle_Water_Per_Minute,                                       // Drizzle Anomaly
	SE_Drizzle_Water_Plus3,                                            // Heavy Drops
	SE_Fast_Food,                                                      // Salty Breeze
	SE_Fertile_Nodes,                                                  // Soil Reclamation
	SE_Food_Consumption,                                               // Insatiable Hunger
	SE_Food_Production_Speed__15,                                      // Rot from the Sky
	SE_FuelRate,                                                       // Piercing Winds
	SE_FuelRateHostility,                                              // Humid Climate
	SE_Gatherer_Production_Speed__50,                                  // Quaking Bog
	SE_Gatherer_Production_Speed_Plus50,                               // Fruitful Season
	SE_Gatherers_Prod_Plus100,                                         // Rich Branches
	SE_Gift_For_Reputation,                                            // Forgiving Crown
	SE_Gift_From_The_Woods,                                            // Gift from the Woods
	SE_Glades_Resolve_In_Drizzle,                                      // Gentle Dawn
	SE_Global_Production_Speed__15,                                    // Overheating
	SE_Goods_For_Solved_Relics,                                        // Forest Offerings
	SE_Grain_In_Harvester,                                             // Soft Stems
	SE_Grass_Around_Removed_Deposits,                                  // TODO NAME
	SE_Grim_Fate,                                                      // Grim Fate
	SE_Hearth_Sacrifice_Block,                                         // Cursed Rain
	SE_Hot_Springs,                                                    // Hot Springs
	SE_Hunger_Storm,                                                   // Hunger Storm
	SE_Late_Newcomers,                                                 // Shifting Paths
	SE_Late_Newcomers___Child,                                         // Unyielding Corruption
	SE_Late_Newcomers___Holder,                                        // Lost Newcomers
	SE_Lightning,                                                      // Devastation
	SE_Living_Farmfield,                                               // Rotten Rain
	SE_Longer_Break_Interval,                                          // Inspiring View
	SE_Low_Engines_Blight_Rate,                                        // Natural Filtration
	SE_M0_60_Off_Roads_Muddy_Ground,                                   // Muddy Ground
	SE_Marrow_Mine,                                                    // Marrow Growth
	SE_Meat_Plus3,                                                     // Mating Season
	SE_Metal_Prod_Penalty,                                             // Corrosive Rainfall
	SE_Mine_In_Storm,                                                  // Horrors from Beneath
	SE_More_Event_Goods,                                               // Scavenging Season
	SE_More_Water_Consumption,                                         // Vanishing Water
	SE_Mushroom_Plus3,                                                 // Mushrooms After Rain
	SE_No_Impatience_Reduction,                                        // No contact
	SE_Nodes_Bonuses,                                                  // Untapped Wealth
	SE_Nodes_Bonuses_Forager_,                                         // Untapped Wealth
	SE_Nodes_Bonuses_Harvester_,                                       // Untapped Wealth
	SE_Nodes_Bonuses_Herbalist_,                                       // Untapped Wealth
	SE_Nodes_Bonuses_P_Forager_,                                       // Untapped Wealth
	SE_Nodes_Bonuses_P_Herbalist_,                                     // Untapped Wealth
	SE_Nodes_Bonuses_P_Trapper_,                                       // Untapped Wealth
	SE_Nodes_Bonuses_Stonecutter_,                                     // Untapped Wealth
	SE_Nodes_Bonuses_Trapper_,                                         // Untapped Wealth
	SE_Overheating___Sparkdew_Payment,                                 // Rotten Vapors
	SE_Overheating___Spawn_Cysts,                                      // Pestilence
	SE_Productive_Farms_In_Drizzle,                                    // Regrowth
	SE_Productive_Mine,                                                // Exposed Resources
	SE_RawDepositsCharges,                                             // Wild Growth
	SE_Remove_Buildings_3, 
	SE_Remove_Buildings3,                                              // Collapse
	SE_Remove_Nodes___Child,                                           // Sinkhole
	SE_ReputationPenaltyRate_100,                                      // Vassal Tax
	SE_ReputationPenaltyRate_25,                                       // Important Matters
	SE_Resin_For_Wood,                                                 // Bleeding Trees
	SE_Resistant_Cysts,                                                // Absorption
	SE_Resolve_Fast_Drop_In_Storm,                                     // Aura of Fear
	SE_Resolve_For_Water,                                              // Saturated Air
	SE_Resolve_For_Water___Global_Resolve_Effect,                      // Saturated Air
	SE_Resolve_To_Reputation_Plus100_Warm_Welcome,                     // Warm Welcome
	SE_Rotting_Wood,                                                   // Rotting Wood
	SE_Sacrifice_More_In_Storm,                                        // Faint Flame
	SE_Service_Waste,                                                  // Vanishing Goods
	SE_Slow_Woodcutting_For_Meat,                                      // Resisting Flora
	SE_Sparkdew_Plus5,                                                 // Heavy Drops
	SE_Spawn_Blightrot_On_Death,                                       // Death and Decay
	SE_Spawn_Cysts_2,                                                  // Blight from the Sky
	SE_Spawn_Cysts_2___Villagers, 
	SE_Spring_Events,                                                  // Aura of Peace
	SE_Spring_Routes,                                                  // Finders Keepers
	SE_Storm_Clothes,                                                  // Cloudburst
	SE_Storm_Clothes___Resolve_Penalty_Effect,                         // Cloudburst
	SE_Storm_Clothes___Resolve_Penalty_Effect___Holder,                // Soaked Clothes
	SE_Thunder,                                                        // Thunder
	SE_Trade_Routes_Costs_More_In_Storm,                               // Flooded Roads
	SE_Trader_Interval_Plus300_Clear_Skies,                            // Clear Skies
	SE_TreeCutting__90, 
	SE_Unearthly_Element,                                              // Unearthly Element
	SE_Vassal_Tax___Amber_Payment,                                     // Vassal Tax
	SE_Weakend_Ancient_Hearth,                                         // Leakage
	SE_Wood_For_Villagers___Payment,                                   // Sacred Flame Rituals
	SE_Wood_Payment___Villagers_Leaving,                               // Disappearance
	SE_Woodcuters_Plus10,                                              // Lightweight Wood
	SE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations,        // Intensive Mutations
	Sea_Marrow_10,                                                     // Crate of Sea Marrow
	Sea_Marrow_15,                                                     // Crate of Sea Marrow
	Sea_Marrow_20,                                                     // Crate of Sea Marrow
	Sea_Marrow_25,                                                     // Crate of Sea Marrow
	Sea_Marrow_30,                                                     // Crate of Sea Marrow
	Sea_Marrow_3pm,                                                    // Sea Marrow Delivery Line
	Sea_Marrow_40,                                                     // Crate of Sea Marrow
	Sea_Marrow_5,                                                      // Crate of Sea Marrow
	Sea_Marrow_50,                                                     // Crate of Sea Marrow
	Sea_Marrow_5pm,                                                    // Converted Fishmen Lighthouse
	Sea_Marrow_For_Copper,                                             // Sunken Bones
	Sea_Marrow_Plus1,                                                  // Fossil Leaching
	Sea_Marrow_Plus2,                                                  // Fossil Leaching
	Sea_Marrow_Plus3,                                                  // Fossil Leaching
	Sea_Marrow_Plus5,                                                  // Fossil Leaching
	Seal_Extra_Cornerstone,                                            // Gift of the Seal Keeper
	Sealed_Biome_Shrine_Blueprint,                                     // Beacon Tower
	Sealed_Vault_Explosion,                                            // Small Miasma Cloud
	SEC_Lumber_Speed_Plus50,                                           // Rotting Wood
	Sewer_Blueprint,                                                   // Clothier
	Shorter_Storm__15,                                                 // Storm Shield
	Shorter_Storm_25, 
	Shorter_Storm_33, 
	Shorter_Storm_50, 
	Skewers_10,                                                        // Pack of Skewers
	Skewers_20,                                                        // Pack of Skewers
	Skewers_25,                                                        // Pack of Skewers
	Skewers_30,                                                        // Pack of Skewers
	Skewers_3pm,                                                       // Skewers Delivery Line
	Skewers_40,                                                        // Pack of Skewers
	Skewers_5pm,                                                       // Skewers Delivery Line
	Skewers_Plus1,                                                     // Bigger Grill
	Skewers_Plus2,                                                     // Bigger Grill
	Skewers_Plus3,                                                     // Bigger Grill
	Skewers_Plus5,                                                     // Bigger Grill
	Slow_Farming_Termites___Normal,                                    // Termite Infestation
	SmallFarm__50,                                                     // Reinforced Tools
	SmallFarm__50_Haunted,                                             // Reinforced Tools
	SmallFarm_Blueprint,                                               // Small Farm
	SmallFarm_Plus100,                                                 // Reinforced Tools
	SmallFarm_Plus100_Haunted,                                         // Reinforced Tools
	SmallFarm_Plus150,                                                 // Reinforced Tools
	SmallFarm_Plus150_Haunted,                                         // Reinforced Tools
	SmallFarm_Plus25,                                                  // Old Ghran's Technique
	SmallFarm_Plus25_Composite_,                                       // Old Ghran's Technique
	SmallFarm_Plus25_Haunted,                                          // Old Ghran's Technique
	SmallFarm_Plus50,                                                  // Farming Tools
	SmallFarm_Plus50_Composite_,                                       // Farming Tools
	SmallFarm_Plus50_Haunted,                                          // Farming Tools
	Smelter_Blueprint,                                                 // Smelter
	Smithy_Blueprint,                                                  // Smithy
	Smithy_Plus100, 
	Smithy_Speed_Plus50, 
	Smokehouse_Blueprint,                                              // Smokehouse
	Smokehouse_Speed_Plus50,                                           // Flavour Enhancer
	Spawn_3_Fishmen_Totems___Fishmen_Cave,                             // Fishmen Witchcraft
	Spawn_Blightrot_Around___Battleground,                             // Decay
	Spawn_Blightrot_Around___Burial_Site,                              // Life from Beneath
	Spawn_Blightrot_Around___Fishmen,                                  // Decay
	Spawn_Blightrot_Around___Rainpunk_Foundry, 
	Spawn_Blightrot_Around___War_Beast,                                // Decay
	Spawn_Blood_Flower_Near_Hearth, 
	Spawn_Cysts_1___Hostility, 
	Spawn_Cysts_1___Overexploitation, 
	Spawn_Cysts_1___Tree, 
	Spawn_Cysts_10___Mole, 
	Spawn_Cysts_2___Cauldron, 
	Spawn_Cysts_2___Machinery, 
	Spawn_Cysts_5___Machinery, 
	Spawn_Cysts_5___Mod, 
	Spawn_Ferile_Soil_Around___Cauldron,                               // Recultivation
	Spawn_Fishmen_Totem___Fishmen_Cave,                                // Fishmen Totem
	Spawn_Living_Matter_On_Farmfield, 
	Spawn_Patch_Haunted_Ruins, 
	Spawn_Patch_Homestead_Ruin, 
	Spawn_Patch_Ruins, 
	Spawn_Random_Spring,                                               // Purified Spring
	Spawn_Small_Patch, 
	Spawn_Trader___The_Hermit, 
	Spawn_Trader___The_Seer, 
	Spawn_Trader___The_Shaman, 
	Spider_Tablets_For_Glades,                                         // Hidden Mystery
	Stag_Blessing,                                                     // Stag's Blessing
	Stamping_Mill_Blueprint,                                           // Stamping Mill
	Stone_10pm,                                                        // Stone Delivery Line
	Stone_3pm,                                                         // Stone Delivery Line
	Stone_5pm,                                                         // Stone Delivery Line
	Stone_In_Clay_Pit,                                                 // Steel Mattocks
	Stone_Plus1,                                                       // Steel Pickaxes
	Stone_Plus2,                                                       // Steel Pickaxes
	Stone_Plus3,                                                       // Steel Pickaxes
	Stone_Plus5,                                                       // Steel Pickaxes
	Stonecutters_Camp_Plus100,                                         // Reinforced Tools
	Stonecutters_Camp_Plus50,                                          // Reinforced Tools
	Storm_Water_50_Pm, 
	Storm_Water_For_Woodcutters,                                       // Force of Nature
	Storm_Water_Plus1,                                                 // Rainwater Condenser
	Storm_Water_Plus2,                                                 // Rainwater Condenser
	Storm_Water_Plus3,                                                 // Rainwater Condenser
	Storm_Water_Plus4,                                                 // Rainwater Condenser
	Storm_Water_Plus5,                                                 // Rainwater Condenser
	Stormbird_Egg___Additional_Resolve_In_Storm,                       // Stormbird's Cry
	Supplier_Blueprint,                                                // Supplier
	Supplier_Plus50,                                                   // Reinforced Stoves
	Survivor_Bonding,                                                  // Survivor Bonding
	Survivor_Bonding___Altar,                                          // Survivor Bonding
	T_Barrels_5pm,                                                     // Barrel Delivery Line
	Tablets_For_Events,                                                // Hidden Reward
	Tank_Capacity___Child,                                             // Makeshift Water Tank
	Tank_Capacity___Trader,                                            // Makeshift Water Tank
	Tavern_Blueprint,                                                  // Tavern
	Tea_10,                                                            // Crate of Tea
	Tea_20,                                                            // Crate of Tea
	Tea_25,                                                            // Crate of Tea
	Tea_30,                                                            // Crate of Tea
	Tea_3pm,                                                           // Tea Delivery Line
	Tea_40,                                                            // Crate of Tea
	Tea_5pm,                                                           // Tea Delivery Line
	Tea_House_Blueprint,                                               // Apothecary
	Tea_Plus1,                                                         // Tea Infuser
	Tea_Plus2,                                                         // Tea Infuser
	Tea_Plus3,                                                         // Tea Infuser
	Tea_Plus5,                                                         // Tea Infuser
	TEMP_Extend_Trade_Routes_Effect_Model,                             // More trade offers
	TEMP_Locate_Grass_Effect_Model,                                    // Reveals fertile soil
	Temple_All_Luxury_Lost,                                            // Forced Sacrifice
	Temple_Blueprint,                                                  // Temple
	Temple_Building_Production_Yield,                                  // Involuntary Sacrifice
	Temple_Packs_Production_Yield,                                     // Involuntary Sacrifice
	Termites_Materials_Lost,                                           // Agitated Swarm
	Termites_Resolve___Normal,                                         // Stonetooth Swarm
	TEST_Plague_Of_Blindness,                                          // Plague of Blindness
	TEST_Plague_Of_Corrupted_Water,                                    // Plague of Corrupted Water
	TEST_Plague_Of_Darkness,                                           // Plague of Darkness
	TEST_Plague_Of_Death,                                              // Plague of Death
	TEST_Plague_Of_Fire,                                               // Plague of Fire
	TEST_Plague_Of_Fishmen,                                            // Plague of Fishmen
	TEST_Plague_Of_Locusts,                                            // Plague of Locusts
	TEST_Plague_Of_Malady,                                             // Plague of Malady
	TEST_Plague_Of_Mosquito,                                           // Plague of Mosquitoes
	TEST_Plague_Of_Mysteries,                                          // Plague of Mysteries
	TEST_Plague_Of_Rats___Food,                                        // Plague of Rats
	TEST_Plague_Of_Snakes,                                             // Plague of Snakes
	TEST_Plague_Of_The_Forest,                                         // Plague of the Dark Forest
	TEST_Plague_Of_Thunderstorm,                                       // Plague of Thunderstorms
	Tinctury_Blueprint,                                                // Tinctury
	Tinkerer_Blueprint,                                                // Tinkerer
	Tools_2pm,                                                         // Tool Delivery Line
	Tools_4pm,                                                         // Tool Delivery Line
	Tools_For_Death,                                                   // Bone Tools
	Tools_For_Glade,                                                   // Improvised Tools
	Tools_For_Glade___Child, 
	Tools_For_Glade___Child___Altar, 
	Tools_For_Hostility,                                               // Forbidden Tools
	Toolshop_Blueprint,                                                // Toolshop
	Trade___Explorer_Tales,                                            // Tales of Discovery
	Trade___Spices_From_The_Capital,                                   // Spices from the Citadel
	Trade_Block_For_Production_Speed,                                  // Deserted Caravans
	Trade_Pack_In_Brickyard,                                           // Trade Pack Instructions
	Trade_Pack_In_Clothier,                                            // Trade Pack Instructions
	Trade_Pack_In_Makeshift_Post,                                      // Better Packaging
	Trade_Route_Speed_For_Packs,                                       // Full Stock
	Trade_Routes_Bonus_Fuel,                                           // Tightened Belt
	Trade_Routes_For_Housing_Spots,                                    // Urban Planning
	Trade_Routes_More_Expensive, 
	Trader_Assault___2_More_Impatience, 
	Trader_Interval__50,                                               // Infamous Viceroy
	Trader_Interval_Plus15,                                            // Beneficial Agreement
	Trader_Interval_Plus25,                                            // Trade Contract
	Trader_Interval_Plus33, 
	Trader_Prices_Lower__5, 
	TradeRoutePlus1, 
	TradeRoutePlus2, 
	Traders_Prices_Plus50,                                             // Tit for Tat
	Trading_Packs,                                                     // Trade Logs
	Training_Gear_20,                                                  // Training Gear
	Training_Gear_30,                                                  // Training Gear
	Training_Gear_3pm,                                                 // Training Gear Delivery Line
	Training_Gear_40,                                                  // Training Gear
	Training_Gear_5pm,                                                 // Training Gear Delivery Line
	Training_Gear_Plus1,                                               // Woodworking Tools
	Training_Gear_Plus2,                                               // Woodworking Tools
	Training_Gear_Plus3,                                               // Woodworking Tools
	Training_Gear_Plus5,                                               // Woodworking Tools
	Trappers_Camp_Blueprint,                                           // Trappers' Camp
	Trappers_Camp_Plus100,                                             // Reinforced Tools
	Trappers_Camp_Plus50,                                              // Reinforced Tools
	Treasure_Stag_Remove_Self,                                         // Escape
	Tree_Wood_Lost,                                                    // Petrified Wood
	TreeCutting__33,                                                   // Exploration Expedition
	TreeCutting_200, 
	Tut_III_Faster_Traders, 
	Tutorial_Death_Missile,                                            // Curse of the Forefathers
	TW_Global_Extra_Prod,                                              // Prayer
	TW_Global_Resolve,                                                 // Tale
	TW_Hostility,                                                      // Distant Howling
	TW_Longer_Relics_Working_Time,                                     // Ghastly Chant
	TW_RemoveFoodOverTime,                                             // Poisoned Wind
	TW_ReputationPenaltyRate,                                          // Effect_TW_ImpatienceRate_Name
	TW_Slower_Leaving,                                                 // Inspiring Speech
	UB_Beaver_Houses_Unique_Bonus,                                     // Writing Desk
	UB_Fox_Houses_Unique_Bonus,                                        // Lichen
	UB_Harpy_Houses_Unique_Bonus,                                      // Canopy
	UB_Human_Houses_Unique_Bonus,                                      // Toolshed
	UB_Lizard_Houses_Unique_Bonus,                                     // Cellar
	UB_Planting_And_Harvesting_Speed, 
	UBP_Cyst_Generation_Rate___Child,                                  // Manned Lookout
	UBP_Global___Cyst_Generation_Rate___Parent,                        // Manned Lookout
	Vault_ForagersResolvePenalty_normal, 
	Vault_HarvesterResolvePenalty_normal, 
	Vault_HerablistResolvePenalty_normal, 
	Vault_PrimitiveForagerResolvePenalty_normal, 
	Vault_PrimitiveHerbalistResolvePenalty_normal, 
	Vault_PrimitiveTrapperResolvePenalty_normal, 
	Vault_StonecuttersResolvePenalty_normal, 
	Vault_TrappersResolvePenalty_normal, 
	Vault_WoodcuttersResolvePenalty_normal, 
	VaultResolvePenalty___Normal,                                      // Ominous Whispers
	Vegetables_10pm,                                                   // Vegetable Delivery Line
	Vegetables_30,                                                     // Crate of Vegetables
	Vegetables_3pm,                                                    // Vegetable Delivery Line
	Vegetables_40,                                                     // Crate of Vegetables
	Vegetables_50,                                                     // Crate of Vegetables
	Vegetables_5pm,                                                    // Vegetable Delivery Line
	Vegetables_60,                                                     // Crate of Vegetables
	Vegetables_In_Greenhouse,                                          // Moss Broccoli Seeds
	Vegetables_Plus1,                                                  // Giant Vegetables
	Vegetables_Plus2,                                                  // Giant Vegetables
	Vegetables_Plus3,                                                  // Giant Vegetables
	Vegetables_Plus5,                                                  // Giant Vegetables
	Villager_Death_Reputation_Penalty, 
	Villager_For_Glade,                                                // Lost in the Wilds
	VillagerDeathEffectBlock,                                          // Hidden from the Queen
	VillagerFoodEffect_Poisoned_Food,                                  // Poisoned Food
	Villagers_For_Corruption,                                          // From the Shadows
	VillagerSpeed10,                                                   // Sturdy Boots
	VillagerSpeed15,                                                   // Sturdy Boots
	VillagerSpeed25, 
	VillagerSpeed30,                                                   // Sturdy Boots
	VillagersSlow20,                                                   // Curse of Weakness
	VillagersSlow30_Plague,                                            // Plague of Blindness
	Vitality,                                                          // Vitality
	Voice_Of_The_Forest,                                               // Voice of the Forest
	War_Beast_Hostility,                                               // Unleashed Beast
	Water_Lost, 
	Waterskins_10,                                                     // Crate of Waterskins
	Waterskins_15,                                                     // Crate of Waterskins
	Waterskins_20,                                                     // Crate of Waterskins
	Waterskins_30,                                                     // Crate of Waterskins
	Waterskins_3pm,                                                    // Waterskin Delivery Line
	Waterskins_40,                                                     // Crate of Waterskins
	Waterskins_5,                                                      // Crate of Waterskins
	Waterskins_50,                                                     // Crate of Waterskins
	Waterskins_5pm,                                                    // Waterskin Delivery Line
	Waterskins_For_Leather,                                            // Reward_WaterskinsForLeather_Name
	Waterskins_Plus1,                                                  // Advanced Leatherworking
	Waterskins_Plus2,                                                  // Advanced Leatherworking
	Waterskins_Plus3,                                                  // Advanced Leatherworking
	Waterskins_Plus5,                                                  // Advanced Leatherworking
	WE_Cloaked_Wanderer_Vengeance,                                     // Cloaked Wanderer's Vengeance
	WE_Crashed_Airship_Bonus,                                          // Guild's Sigil
	WE_Desecrator,                                                     // Desecrator
	WE_Desecrator_Villager_Death, 
	WE_Fallen_Viceroy_Commemoration_Composite,                         // Fallen Viceroy Commemoration
	WE_Glade_Info,                                                     // Guild's Logbook
	WE_Lower_Blueprints_Reroll_Cost,                                   // The Eremite's Way
	WE_Petrified_Egg,                                                  // Petrified Egg
	WE_Random_Killed___Cloaked_Wanderer,                               // Cloaked Wanderer's Vengeance
	WE_Remove_All_Food,                                                // Storm Ant Column
	WE_ReputationPenaltyRate_30,                                       // Irresponsible Gamble
	WE_ReputationPenaltyRate_50,                                       // Insane Gamble
	WE_Roaming_Shelled_Mosquitos,                                      // Roaming Swarm
	Wealth,                                                            // Wealth
	Weaver_Blueprint,                                                  // Weaver
	Wetstone_10,                                                       // Crate of Stone
	Wetstone_15,                                                       // Crate of Stone
	Wetstone_20,                                                       // Crate of Stone
	Wetstone_25,                                                       // Crate of Stone
	Wetstone_30,                                                       // Crate of Stone
	Wetstone_35,                                                       // Crate of Stone
	Wetstone_40,                                                       // Crate of Stone
	Wetstone_5,                                                        // Crate of Stone
	Wetstone_50,                                                       // Crate of Stone
	Wetstone_8,                                                        // Crate of Stone
	White_Stag_Reward_Catch,                                           // Cursed Treasure
	White_Stag_Reward_Chase,                                           // Into the Mists
	White_Stag_Reward_Release,                                         // Gift of Gratitude
	Wildcard_For_Death,                                                // Scientific Agreement
	Wildcard_Pick_Cornerstone,                                         // Smuggler's Visit
	Wildcard_Pick_Cursed,                                              // Summoned Smuggler (Stormforged)
	Wildcard_Pick_Trader,                                              // Contraband
	Wildfire_Fuel_Lost,                                                // Combustion
	Wildfire_RemoveFuelOverTime___Hard,                                // Wildfire Presence
	Wildfire_RemoveFuelOverTime___Impossible,                          // Wildfire Presence
	Wildfire_RemoveFuelOverTime___Normal,                              // Wildfire Presence
	Wildfire_RemoveFuelOverTime___Very_Hard,                           // Wildfire Presence
	Wine_10,                                                           // Barrels of Wine
	Wine_20,                                                           // Barrels of Wine
	Wine_3,                                                            // Barrels of Wine
	Wine_30,                                                           // Barrels of Wine
	Wine_3pm,                                                          // Wine Delivery Line
	Wine_40,                                                           // Barrels of Wine
	Wine_5pm,                                                          // Wine Delivery Line
	Wine_Plus1,                                                        // Advanced Filters
	Wine_Plus2,                                                        // Advanced Filters
	Wine_Plus3,                                                        // Advanced Filters
	Wine_Plus5,                                                        // Advanced Filters
	Wood_10,                                                           // Crate of Wood
	Wood_100,                                                          // Crate of Wood
	Wood_15,                                                           // Crate of Wood
	Wood_20,                                                           // Crate of Wood
	Wood_30,                                                           // Crate of Wood
	Wood_40,                                                           // Crate of Wood
	Wood_5,                                                            // Crate of Wood
	Wood_50,                                                           // Crate of Wood
	Wood_60,                                                           // Crate of Wood
	Wood_70,                                                           // Crate of Wood
	Wood_Plus1,                                                        // Steel Axes
	Wood_Plus2,                                                        // Steel Axes
	Wood_Plus2_For_Insects,                                            // No Quality Control
	Wood_Plus3,                                                        // Steel Axes
	Wood_Removed, 
	Woodcuters_Plus10,                                                 // Light Timber
	Woodcuters_Plus15,                                                 // Light Timber
	Woodcuters_Plus5,                                                  // Light Timber
	Woodcutters_Camp_Plus100,                                          // Woodcutter's Tools
	Woodcutters_Camp_Plus50,                                           // Reinforced Tools
	Woodcutters_Prayer,                                                // Woodcutter's Prayer
	Woodcutting_For_Fuel,                                              // Sloppy Woodcutting
	Woodcutting_Speed_For_Water,                                       // Driving Water
	Workers_Carry_More_For_Tablets,                                    // Ancient Strength
	Working_Speed_For_Small_Glade,                                     // Farsight
	Working_Speed_For_Small_Glade___Relic_Working_Speed,               // Farsight
	Working_Speed_For_Small_Glade___Relic_Working_Speed___Holder,      // Reconnaissance
	Working_Time_For_Firekeeper,                                       // Prayer Book
	Working_Time_For_Tablets,                                          // Carved in Stone
	Worse_Storms_For_Hostility,                                        // Growing Darkness
	Worse_Storms_For_Hostility___Permanent,                            // Violent Dusk
	Worse_Storms_For_Hostility_Consequence_Resolve,                    // Growing Darkness
	Worse_Storms_For_Hostility_Resolve,                                // Growing Darkness
	Worse_Storms_For_Hostility_Working,                                // Growing Darkness
	Worse_Storms_Hook___Permanent,                                     // Violent Dusk

    MAX = 2365
}

public static class EffectTypesExtensions
{
	public static string ToName(this EffectTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of EffectTypes: " + type);
		return TypeToInternalName[EffectTypes._0_10_On_Roads];
	}
	
	public static EffectModel ToEffectModel(this string name)
    {
        EffectModel model = SO.Settings.effects.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find EffectModel for EffectTypes with name: " + name);
        return null;
    }

	public static EffectModel ToEffectModel(this EffectTypes types)
	{
		return types.ToName().ToEffectModel();
	}
	
	public static EffectModel[] ToEffectModelArray(this IEnumerable<EffectTypes> collection)
    {
        int count = collection.Count();
        EffectModel[] array = new EffectModel[count];
        int i = 0;
        foreach (EffectTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.effects.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<EffectTypes, string> TypeToInternalName = new()
	{
		{ EffectTypes._0_10_On_Roads, "0_10 On Roads" },                                                                                                        // Shovels
		{ EffectTypes._0_2_Reputation_Penalty, "0_2 Reputation Penalty" }, 
		{ EffectTypes._0_25_On_Roads, "0_25 On Roads" }, 
		{ EffectTypes._0_5_Reputation_Donation, "0_5 Reputation Donation" },                                                                                    // Generous Donation
		{ EffectTypes._0_5_Reputation_Exploration, "0_5 Reputation Exploration" },                                                                              // Queen's Grace
		{ EffectTypes._0_5_Reputation_Exploration___Seasonal_Effect, "0_5 Reputation Exploration - Seasonal Effect" },                                          // Queen's Grace
		{ EffectTypes._0_5_Reputation_Penalty, "0_5 Reputation Penalty" }, 
		{ EffectTypes._0_5_Reputation_Penalty___Corrupted_Caravan, "0_5 Reputation Penalty - Corrupted Caravan" },                                              // Filthy Trick
		{ EffectTypes._0_5_Reputation_Penalty___Ghost, "0_5 Reputation Penalty - Ghost" },                                                                      // Disappointment
		{ EffectTypes._0_5_Reputation_Penalty___Merchant_Ship_Wreck, "0_5 Reputation Penalty - Merchant Ship Wreck" },                                          // Cowardice
		{ EffectTypes._0_5_Reputation_Penalty___Minus, "0_5 Reputation Penalty - Minus" }, 
		{ EffectTypes._0_75_Reputation_Donation, "0_75 Reputation Donation" },                                                                                  // Generous Donation
		{ EffectTypes._0_75_Reputation_Exploration, "0_75 Reputation Exploration" },                                                                            // Queen's Grace
		{ EffectTypes._1_Killed_For_Glade_Event, "1 Killed for Glade event" },                                                                                  // Sacrificial Rituals
		{ EffectTypes._1_Reputation_Exploration, "1 Reputation Exploration" },                                                                                  // Queen's Grace
		{ EffectTypes._1_Reputation_Exploration___Stormbird, "1 Reputation Exploration - Stormbird" },                                                          // Queen's Grace
		{ EffectTypes._1_Reputation_Order, "1 Reputation Order" },                                                                                              // Queen's Grace
		{ EffectTypes._1_Reputation_Penalty, "1 Reputation Penalty" }, 
		{ EffectTypes._1_Reputation_Penalty___Caravan, "1 Reputation Penalty - Caravan" },                                                                      // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Convicts, "1 Reputation Penalty - Convicts" },                                                                    // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Corupted_Caravan, "1 Reputation Penalty - Corupted Caravan" },                                                    // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Decay_Altar, "1 Reputation Penalty - Decay Altar" },                                                              // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Fishmen_Cave, "1 Reputation Penalty - Fishmen Cave" },                                                            // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Fishmen_Lighthouse, "1 Reputation Penalty - Fishmen Lighthouse" },                                                // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Fishmen_Soothsyer, "1 Reputation Penalty - Fishmen Soothsyer" },                                                  // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Forsaken_Crypt, "1 Reputation Penalty - Forsaken Crypt" },                                                        // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Harmony_Spirit_Altar, "1 Reputation Penalty - Harmony Spirit Altar" },                                            // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Sealed_Tomb, "1 Reputation Penalty - Sealed Tomb" },                                                              // Irresponsible Archaeology
		{ EffectTypes._1_Reputation_Penalty___Stormbird, "1 Reputation Penalty - Stormbird" },                                                                  // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Totem, "1 Reputation Penalty - Totem" },                                                                          // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Trader_Cementary, "1 Reputation Penalty - Trader Cementary" },                                                    // Cleanup Duty
		{ EffectTypes._1_Reputation_Penalty___Vassal_Tax, "1 Reputation Penalty - Vassal Tax" },                                                                // Queen's Wrath (Vassal Tax)
		{ EffectTypes._1_Reputation_Penalty_Decision, "1 Reputation Penalty Decision" },                                                                        // Infamy
		{ EffectTypes._1_Reputation_Trade, "1 Reputation Trade" },                                                                                              // Queen's Grace
		{ EffectTypes._2_Hauling_Carts_In_Main_Warehouse, "2 Hauling Carts in Main Warehouse" },                                                                // Dual Carriage System
		{ EffectTypes._2_Reputation_Penalty, "2 Reputation Penalty" },                                                                                          // Queen's Wrath
		{ EffectTypes._2_Reputation_Penalty_Decision, "2 Reputation Penalty Decision" },                                                                        // Queen's Wrath
		{ EffectTypes._20_Random_Goods, "20 Random Goods" }, 
		{ EffectTypes._3_Reputation_Exploration, "3 Reputation Exploration" },                                                                                  // The Queen's Respect
		{ EffectTypes._3_Reputation_Penalty, "3 Reputation Penalty" },                                                                                          // Queen's Wrath
		{ EffectTypes._30_Random_Raw_Food, "30 Random Raw Food" }, 
		{ EffectTypes._5_Random_Packs, "5 Random Packs" },                                                                                                      // Finders Keepers
		{ EffectTypes.Accidental_Barrels, "Accidental Barrels" },                                                                                               // Over-Diligent Woodworkers
		{ EffectTypes.Accidental_Bricks, "Accidental Bricks" },                                                                                                 // Repurposed Clay
		{ EffectTypes.Accidental_Crystalized_Dew, "Accidental Crystalized Dew" },                                                                               // Accumulated Dew
		{ EffectTypes.Accidental_Harpy, "Accidental Harpy" },                                                                                                   // Chicken or Egg?
		{ EffectTypes.Accidental_Jerky, "Accidental Jerky" },                                                                                                   // Sahilda's Secret Cookbook
		{ EffectTypes.Accidental_Lizard, "Accidental Lizard" },                                                                                                 // Surprise Child
		{ EffectTypes.Accidental_Oil, "Accidental Oil" },                                                                                                       // Small Press
		{ EffectTypes.Accidental_Pigment, "Accidental Pigment" },                                                                                               // Dye Extractor
		{ EffectTypes.Accidental_Provisions, "Accidental Provisions" },                                                                                         // Peasant Supplies
		{ EffectTypes.Accidental_Skewers, "Accidental Skewers" },                                                                                               // Zhorg's Secret Ingredient
		{ EffectTypes.Accidental_Wine, "Accidental Wine" },                                                                                                     // Dual Brewing Tools
		{ EffectTypes.Additional_Impatience_For_Death, "Additional Impatience for Death" }, 
		{ EffectTypes.Advanced_Rain_Collector_Blueprint, "Advanced Rain Collector Blueprint" },                                                                 // Forsaken Altar
		{ EffectTypes.Agriculture_Penalty, "Agriculture Penalty" },                                                                                             // Industrialized Agriculture
		{ EffectTypes.Alarm_Bells, "Alarm Bells" },                                                                                                             // Alarm Bells
		{ EffectTypes.Alchemist_Blueprint, "Alchemist Blueprint" },                                                                                             // Alchemist's Hut
		{ EffectTypes.Ale_10, "Ale 10" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_15, "Ale 15" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_20, "Ale 20" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_30, "Ale 30" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_35, "Ale 35" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_3pm, "Ale 3pm" },                                                                                                                     // Ale Delivery Line
		{ EffectTypes.Ale_40, "Ale 40" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_5, "Ale 5" },                                                                                                                         // Barrels of Ale
		{ EffectTypes.Ale_50, "Ale 50" },                                                                                                                       // Barrels of Ale
		{ EffectTypes.Ale_5pm, "Ale 5pm" },                                                                                                                     // Ale Delivery Line
		{ EffectTypes.Ale_Plus1, "Ale +1" },                                                                                                                    // Bigger Barrels
		{ EffectTypes.Ale_Plus2, "Ale +2" },                                                                                                                    // Bigger Barrels
		{ EffectTypes.Ale_Plus3, "Ale +3" },                                                                                                                    // Bigger Barrels
		{ EffectTypes.Ale_Plus5, "Ale +5" },                                                                                                                    // Bigger Barrels
		{ EffectTypes.All_Camps_Unlock, "All Camps Unlock" },                                                                                                   // Master Blueprint
		{ EffectTypes.All_Camps_Unlock___Slow_Gathering, "All Camps Unlock - Slow Gathering" },                                                                 // Master Blueprint
		{ EffectTypes.All_Camps_Unlock___Slow_Gathering___Holder, "All Camps Unlock - Slow Gathering - Holder" },                                               // Overwhelmed Gatherers
		{ EffectTypes.All_Waters_Per_Min, "All Waters Per Min" }, 
		{ EffectTypes.Altar_Accidental_Barrels, "[Altar] Accidental Barrels" },                                                                                 // Over-Diligent Woodworkers (Stormforged)
		{ EffectTypes.Altar_Accidental_Oil, "[Altar] Accidental Oil" },                                                                                         // Small Press (Stormforged)
		{ EffectTypes.Altar_Accidental_Pigment, "[Altar] Accidental Pigment" },                                                                                 // Dye Extractor (Stormforged)
		{ EffectTypes.Altar_Activation, "Altar Activation" }, 
		{ EffectTypes.Altar_Alarm_Bells, "[Altar] Alarm Bells" },                                                                                               // Alarm Bells (Stormforged)
		{ EffectTypes.Altar_Amber_For_Trade_Routes, "[Altar] Amber for Trade Routes" },                                                                         // Deep Pockets (Stormforged)
		{ EffectTypes.Altar_AncientGate_Hardships, "[Altar] AncientGate_Hardships" },                                                                           // Survivor Bonding (Stormforged)
		{ EffectTypes.Altar_Back_To_Nature, "[Altar] Back To Nature" },                                                                                         // Back to Nature (Stormforged)
		{ EffectTypes.Altar_Beaver_Resolve_For_Wine_Prod, "[Altar] Beaver Resolve for Wine Prod" },                                                             // Vineyard Town (Stormforged)
		{ EffectTypes.Altar_Blood_Price, "[Altar] Blood Price" },                                                                                               // Blood Price Contract (Stormforged)
		{ EffectTypes.Altar_Blueprint, "Altar Blueprint" },                                                                                                     // Forsaken Altar
		{ EffectTypes.Altar_Cannibalism, "[Altar] Cannibalism" },                                                                                               // Cannibalism (Stormforged)
		{ EffectTypes.Altar_Construction_Cost_For_Nodes, "[Altar] Construction cost for nodes" },                                                               // Cheap Construction (Stormforged)
		{ EffectTypes.Altar_Copper_For_Each_Tree, "[Altar] Copper for each tree" },                                                                             // Copper Extractor (Stormforged)
		{ EffectTypes.Altar_Cornerstone_Reroll, "[Altar] Cornerstone Reroll" },                                                                                 // >Missing key< (Stormforged)
		{ EffectTypes.Altar_Cornerstone_Reroll_Each_Year, "[Altar] Cornerstone Reroll each year" },                                                             // Forsaken Seal (Stormforged)
		{ EffectTypes.Altar_Crops_For_Grain, "[Altar] Crops for Grain" },                                                                                       // Leftover Crops (Stormforged)
		{ EffectTypes.Altar_Fedora_Hat, "[Altar] Fedora Hat" },                                                                                                 // Old Fedora Hat (Stormforged)
		{ EffectTypes.Altar_Forge_Trip_Hammer, "[Altar] Forge Trip Hammer" },                                                                                   // Forge Trip Hammer (Stormforged)
		{ EffectTypes.Altar_Fuel_Recipes_Rate, "[Altar] Fuel Recipes Rate" },                                                                                   // Advanced Fuel (Stormforged)
		{ EffectTypes.Altar_FuelConsumption__25, "[Altar] FuelConsumption -25" },                                                                               // Secret Techniques of the Firekeeper (Stormforged)
		{ EffectTypes.Altar_Harpy_Resolve_For_Tea_Prod, "[Altar] Harpy Resolve for Tea Prod" },                                                                 // Tea Specialization (Stormforged)
		{ EffectTypes.Altar_Herb_Production_For_Biscuits, "[Altar] Herb Production for Biscuits" },                                                             // Spices (Stormforged)
		{ EffectTypes.Altar_Hidden_From_The_Queen, "[Altar] Hidden From The Queen" },                                                                           // Hidden from the Queen (Stormforged)
		{ EffectTypes.Altar_Houses_Plus1_For_Break_Time, "[Altar] Houses +1 for Break Time" },                                                                  // Crowded Houses (Stormforged)
		{ EffectTypes.Altar_HP_For_Impatience, "[Altar] HP for Impatience" },                                                                                   // Queen's Gift (Stormforged)
		{ EffectTypes.Altar_Hubs_For_Newcomer_Goods, "[Altar] Hubs for newcomer goods" },                                                                       // Generous Gifts (Stormforged)
		{ EffectTypes.Altar_Human_Resolve_For_Incense_Prod, "[Altar] Human Resolve for Incense Prod" },                                                         // Religious Settlement (Stormforged)
		{ EffectTypes.Altar_HunterGatherers, "[Altar] HunterGatherers" },                                                                                       // Hunter-Gatherers (Stormforged)
		{ EffectTypes.Altar_Insect_For_Tree, "[Altar] Insect for tree" },                                                                                       // Woodpecker Technique (Stormforged)
		{ EffectTypes.Altar_Insect_For_Tree___Child, "[Altar] Insect for tree - child" },                                                                       // Woodpecker Technique
		{ EffectTypes.Altar_Killed_For_GladeInfo, "[Altar] Killed for GladeInfo" },                                                                             // Ancient Pact (Stormforged)
		{ EffectTypes.Altar_LessHostilityPerWoodcutter, "[Altar] LessHostilityPerWoodcutter" },                                                                 // Flame Amulets (Stormforged)
		{ EffectTypes.Altar_Lizard_Resolve_For_Training_Gear_Prod, "[Altar] Lizard Resolve for Training Gear Prod" },                                           // Training Grounds (Stormforged)
		{ EffectTypes.Altar_Longer_Storm_For_Wood_Production, "[Altar] Longer Storm for Wood Production" },                                                     // Ancient Stabilizer (Stormforged)
		{ EffectTypes.Altar_Lower_Hostility_For_Religion, "[Altar] Lower Hostility For Religion" },                                                             // Firelink Ritual (Stormforged)
		{ EffectTypes.Altar_Metal_Production_Speed_Boost, "[Altar] Metal Production Speed Boost" },                                                             // Metallurgic Proficiency (Stormforged)
		{ EffectTypes.Altar_Mists_Piercers, "[Altar] Mists Piercers" },                                                                                         // Mist Piercers (Stormforged)
		{ EffectTypes.Altar_Mold_Grain, "[Altar] Mold Grain" },                                                                                                 // Moldy Grain Seeds (Stormforged)
		{ EffectTypes.Altar_More_Amber_From_Routes, "[Altar] More Amber from Routes" },                                                                         // Trade Negotiations (Stormforged)
		{ EffectTypes.Altar_Mushrooms_In_Farms, "[Altar] Mushrooms in Farms" },                                                                                 // Mushroom Seedlings (Stormforged)
		{ EffectTypes.Altar_Newcomers_Faster_25, "[Altar] Newcomers Faster 25" },                                                                               // Secure Trail (Stormforged)
		{ EffectTypes.Altar_Newcomers_Faster_25___Child, "[Altar] Newcomers Faster 25 - child" },                                                               // Secure Trail (Stormforged)
		{ EffectTypes.Altar_NewNewcomersBonus_Random, "[Altar] NewNewcomersBonus_Random" },                                                                     // Crowded Caravan (Stormforged)
		{ EffectTypes.Altar_Of_Decay_Negative, "Altar of Decay Negative" },                                                                                     // Blight Incantation
		{ EffectTypes.Altar_Overexploitation, "[Altar] Overexploitation" },                                                                                     // Overexploitation (Stormforged)
		{ EffectTypes.Altar_Packs_Of_Goods_Plus1, "[Altar] Packs of Goods +1" },                                                                                // Export Specialization (Stormforged)
		{ EffectTypes.Altar_PacksForResolveRep, "[Altar] PacksForResolveRep" },                                                                                 // Export Contract (Stormforged)
		{ EffectTypes.Altar_Parts_For_Trade, "[Altar] Parts for Trade" },                                                                                       // Free Samples (Stormforged)
		{ EffectTypes.Altar_Relic_Time_Reduction, "[Altar] Relic time reduction" },                                                                             // Firekeeper's Prayer (Stormforged)
		{ EffectTypes.Altar_Resolve_For_Consumption, "[Altar] Resolve for consumption" },                                                                       // Generous Rations (Stormforged)
		{ EffectTypes.Altar_Resolve_For_Impatience, "[Altar] Resolve for Impatience" },                                                                         // Rebellious Spirit (Stormforged)
		{ EffectTypes.Altar_Route_Less_Travel_Time, "[Altar] Route Less Travel Time" },                                                                         // Stormwalker Training (Stormforged)
		{ EffectTypes.Altar_Storm_Water_For_Woodcutters, "[Altar] Storm Water for Woodcutters" },                                                               // Force of Nature (Stormforged)
		{ EffectTypes.Altar_Tablets_For_Events, "[Altar] Tablets for Events" },                                                                                 // Hidden Reward (Stormforged)
		{ EffectTypes.Altar_Tools_For_Death, "[Altar] Tools for death" },                                                                                       // Bone Tools (Stormforged)
		{ EffectTypes.Altar_Tools_For_Glade, "[Altar] Tools for glade" },                                                                                       // Improvised Tools (Stormforged)
		{ EffectTypes.Altar_Trade_Routes_Bonus_Fuel, "[Altar] Trade Routes Bonus Fuel" },                                                                       // Tightened Belt (Stormforged)
		{ EffectTypes.Altar_Trade_Routes_For_Housing_Spots, "[Altar] Trade Routes for housing spots" },                                                         // Urban Planning (Stormforged)
		{ EffectTypes.Altar_Trading_Packs, "[Altar] Trading Packs" },                                                                                           // Trade Logs (Stormforged)
		{ EffectTypes.Altar_Villager_For_Glade, "[Altar] Villager for glade" },                                                                                 // Lost in the Wilds (Stormforged)
		{ EffectTypes.Altar_Wood_Plus2_For_Insects, "[Altar] Wood +2 for insects" },                                                                            // No Quality Control (Stormforged)
		{ EffectTypes.Altar_Working_Time_For_Firekeeper, "[Altar] Working time for firekeeper" },                                                               // Prayer Book (Stormforged)
		{ EffectTypes.Amber_1, "Amber 1" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_10, "Amber 10" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_12, "Amber 12" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_15, "Amber 15" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_2, "Amber 2" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_20, "Amber 20" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_25, "Amber 25" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_3, "Amber 3" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_30, "Amber 30" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_35, "Amber 35" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_3pm, "Amber 3pm" },                                                                                                                 // Amber Tax
		{ EffectTypes.Amber_3pm_Blight, "Amber 3pm Blight" },                                                                                                   // Amber Tax
		{ EffectTypes.Amber_4, "Amber 4" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_40, "Amber 40" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_45, "Amber 45" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_5, "Amber 5" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_50, "Amber 50" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_55, "Amber 55" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_5pm, "Amber 5pm" },                                                                                                                 // Amber Tax
		{ EffectTypes.Amber_60, "Amber 60" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_7, "Amber 7" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_70, "Amber 70" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_8, "Amber 8" },                                                                                                                     // Amber Pouch
		{ EffectTypes.Amber_80, "Amber 80" },                                                                                                                   // Amber Pouch
		{ EffectTypes.Amber_Curse, "Amber Curse" },                                                                                                             // Amber Curse
		{ EffectTypes.Amber_For_Archeology, "Amber For Archeology" },                                                                                           // Scientific Grant
		{ EffectTypes.Amber_For_Newcomers, "Amber for Newcomers" },                                                                                             // Stormwalker Tax
		{ EffectTypes.Amber_For_Sea_Marrow, "Amber for Sea Marrow" },                                                                                           // Golden Marrow
		{ EffectTypes.Amber_For_Trade_Packs, "Amber for Trade Packs" },                                                                                         // Value Added Tax
		{ EffectTypes.Amber_For_Trade_Routes, "Amber for Trade Routes" },                                                                                       // Deep Pockets
		{ EffectTypes.Amber_For_Trader_Visit, "Amber for Trader Visit" },                                                                                       // Bed and Breakfast
		{ EffectTypes.Amber_For_Water, "Amber for Water" },                                                                                                     // Counterfeit Amber
		{ EffectTypes.Amber_For_Wood, "Amber for Wood" },                                                                                                       // Lumber Tax
		{ EffectTypes.Amber_Payment___Payment, "Amber Payment - Payment" },                                                                                     // Royal Tax
		{ EffectTypes.Amber_Payment___Villagers_Leaving, "Amber Payment - Villagers Leaving" },                                                                 // Recall (Royal Tax)
		{ EffectTypes.Amber_Worth_5_More, "Amber Worth 5 More" }, 
		{ EffectTypes.Amber_Worth_Bit_More, "Amber Worth Bit More" }, 
		{ EffectTypes.Amber_Worth_More, "Amber Worth More" },                                                                                                   // Enriched Amber
		{ EffectTypes.Amber_Worth_More_For_Relics, "Amber Worth More For Relics" },                                                                             // Respected Business Partner
		{ EffectTypes.AmberForLuxury, "AmberForLuxury" },                                                                                                       // Luxury Tax
		{ EffectTypes.Ancient_Artifact_1, "Ancient Artifact 1" },                                                                                               // Small Ancient Artifact
		{ EffectTypes.Ancient_Artifact_2, "Ancient Artifact 2" },                                                                                               // Ancient Artifact
		{ EffectTypes.Ancient_Artifact_3, "Ancient Artifact 3" },                                                                                               // Ancient Artifact
		{ EffectTypes.Ancient_Artifact_3_Tutorial, "Ancient Artifact 3 Tutorial" },                                                                             // Ancient Artifact
		{ EffectTypes.Ancient_Tablet_1, "Ancient Tablet 1" },                                                                                                   // Chest of Ancient Tablets
		{ EffectTypes.Ancient_Tablet_10, "Ancient Tablet 10" },                                                                                                 // Chest of Ancient Tablets
		{ EffectTypes.Ancient_Tablet_2, "Ancient Tablet 2" },                                                                                                   // Chest of Ancient Tablets
		{ EffectTypes.Ancient_Tablet_3, "Ancient Tablet 3" },                                                                                                   // Chest of Ancient Tablets
		{ EffectTypes.Ancient_Tablet_5, "Ancient Tablet 5" },                                                                                                   // Chest of Ancient Tablets
		{ EffectTypes.Ancient_Tablet_8, "Ancient Tablet 8" },                                                                                                   // Chest of Ancient Tablets
		{ EffectTypes.AncientGate_Hardships, "AncientGate_Hardships" },                                                                                         // Survivor Bonding
		{ EffectTypes.API_ExampleMod_diamondHunter, "API_ExampleMod_diamondHunter" },                                                                           // Diamond Hunter
		{ EffectTypes.API_ExampleMod_diamondHunter_hookedEffect_1, "API_ExampleMod_diamondHunter_hookedEffect_1" },                                             // Diamonds
		{ EffectTypes.API_ExampleMod_Diamonds_RelicKeepEffect_1, "API_ExampleMod_Diamonds_RelicKeepEffect_1" },                                                 // Diamonds
		{ EffectTypes.API_ExampleMod_Diamonds_RelicKeepEffect_2, "API_ExampleMod_Diamonds_RelicKeepEffect_2" },                                                 // Diamonds
		{ EffectTypes.API_ExampleMod_Kiwi_Fruit_RelicKeepEffect_1, "API_ExampleMod_Kiwi Fruit_RelicKeepEffect_1" },                                             // Kiwi Fruit
		{ EffectTypes.API_ExampleMod_Kiwi_Fruit_RelicKeepEffect_2, "API_ExampleMod_Kiwi Fruit_RelicKeepEffect_2" },                                             // Kiwi Fruit
		{ EffectTypes.API_ExampleMod_Modding_Tools, "API_ExampleMod_Modding Tools" },                                                                           // Modding Tools
		{ EffectTypes.API_ExampleMod_Omega_Sewing_Technique, "API_ExampleMod_Omega Sewing Technique" },                                                         // Omega Sewing Technique
		{ EffectTypes.Apothecary_Blueprint, "Apothecary Blueprint" },                                                                                           // Apothecary
		{ EffectTypes.Apothecary_Plus50, "Apothecary +50" },                                                                                                    // Reinforced Stoves
		{ EffectTypes.Archeology_Extra_Blueprint, "Archeology Extra Blueprint" },                                                                               // Scientific Council
		{ EffectTypes.Archeology_Extra_Cornerstone, "Archeology Extra Cornerstone" },                                                                           // Scientific Award
		{ EffectTypes.Archeology_Global_Extra_Production, "Archeology Global Extra Production" }, 
		{ EffectTypes.Artifact_For_Dangerous_Relic, "Artifact for Dangerous Relic" },                                                                           // From the Ashes
		{ EffectTypes.Artifacts_1, "Artifacts 1" },                                                                                                             // Artifacts
		{ EffectTypes.Artifacts_10, "Artifacts 10" },                                                                                                           // Artifacts
		{ EffectTypes.Artifacts_2, "Artifacts 2" },                                                                                                             // Artifacts
		{ EffectTypes.Artifacts_3, "Artifacts 3" },                                                                                                             // Artifacts
		{ EffectTypes.Artifacts_4, "Artifacts 4" },                                                                                                             // Artifacts
		{ EffectTypes.Artifacts_5, "Artifacts 5" },                                                                                                             // Artifacts
		{ EffectTypes.Artisan_Blueprint, "Artisan Blueprint" },                                                                                                 // Artisan
		{ EffectTypes.Back_To_Nature, "Back To Nature" },                                                                                                       // Back to Nature
		{ EffectTypes.Bakery_Blueprint, "Bakery Blueprint" },                                                                                                   // Bakery
		{ EffectTypes.Bakery_Plus50, "Bakery +50" },                                                                                                            // Reinforced Stoves
		{ EffectTypes.Bakery_Speed_Plus50, "Bakery Speed +50" },                                                                                                // Bread Peels
		{ EffectTypes.Barrel_Recipes, "Barrel Recipes" },                                                                                                       // Barrel Schematics
		{ EffectTypes.Barrels_1, "Barrels 1" },                                                                                                                 // Barrels
		{ EffectTypes.Barrels_15, "Barrels 15" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_2, "Barrels 2" },                                                                                                                 // Barrels
		{ EffectTypes.Barrels_20, "Barrels 20" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_25, "Barrels 25" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_3, "Barrels 3" },                                                                                                                 // Barrels
		{ EffectTypes.Barrels_30, "Barrels 30" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_35, "Barrels 35" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_3pm, "Barrels 3pm" },                                                                                                             // Barrel Delivery Line
		{ EffectTypes.Barrels_4, "Barrels 4" },                                                                                                                 // Barrels
		{ EffectTypes.Barrels_40, "Barrels 40" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_5, "Barrels 5" },                                                                                                                 // Barrels
		{ EffectTypes.Barrels_50, "Barrels 50" },                                                                                                               // Barrels
		{ EffectTypes.Barrels_5pm, "Barrels 5pm" },                                                                                                             // Barrel Delivery Line
		{ EffectTypes.Barrels_In_Lumber_Mill, "Barrels in Lumber Mill" },                                                                                       // Barrel Schematics
		{ EffectTypes.Barrels_In_Smithy, "Barrels in Smithy" },                                                                                                 // Barrel Schematics
		{ EffectTypes.Barrels_Plus1, "Barrels +1" },                                                                                                            // Advanced Coopering
		{ EffectTypes.Barrels_Plus2, "Barrels +2" },                                                                                                            // Advanced Coopering
		{ EffectTypes.Barrels_Plus3, "Barrels +3" },                                                                                                            // Advanced Coopering
		{ EffectTypes.Barrels_Plus5, "Barrels +5" },                                                                                                            // Advanced Coopering
		{ EffectTypes.Bath_House_Blueprint, "Bath House Blueprint" },                                                                                           // Bath House
		{ EffectTypes.Battleground_Beaver___Hard, "Battleground Beaver - hard" },                                                                               // Fallen Beavers
		{ EffectTypes.Battleground_Beaver___Impossible, "Battleground Beaver - impossible" },                                                                   // Fallen Beavers
		{ EffectTypes.Battleground_Beaver___Normal, "Battleground Beaver - normal" },                                                                           // Fallen Beavers
		{ EffectTypes.Battleground_Beaver___Very_Hard, "Battleground Beaver - very hard" },                                                                     // Fallen Beavers
		{ EffectTypes.Battleground_Fox___Hard, "Battleground Fox - hard" },                                                                                     // Fallen Foxes
		{ EffectTypes.Battleground_Fox___Impossible, "Battleground Fox - impossible" },                                                                         // Fallen Foxes
		{ EffectTypes.Battleground_Fox___Normal, "Battleground Fox - normal" },                                                                                 // Fallen Foxes
		{ EffectTypes.Battleground_Fox___Very_Hard, "Battleground Fox - very hard" },                                                                           // Fallen Foxes
		{ EffectTypes.Battleground_Harpy___Hard, "Battleground Harpy - hard" },                                                                                 // Fallen Harpy Scientists
		{ EffectTypes.Battleground_Harpy___Impossible, "Battleground Harpy - impossible" },                                                                     // Fallen Harpy Scientists
		{ EffectTypes.Battleground_Harpy___Normal, "Battleground Harpy - normal" },                                                                             // Fallen Harpy Scientists
		{ EffectTypes.Battleground_Harpy___Very_Hard, "Battleground Harpy - very hard" },                                                                       // Fallen Harpy Scientists
		{ EffectTypes.Battleground_Human___Hard, "Battleground Human - hard" },                                                                                 // Fallen Humans
		{ EffectTypes.Battleground_Human___Impossible, "Battleground Human - impossible" },                                                                     // Fallen Humans
		{ EffectTypes.Battleground_Human___Normal, "Battleground Human - normal" },                                                                             // Fallen Humans
		{ EffectTypes.Battleground_Human___Very_Hard, "Battleground Human - very hard" },                                                                       // Fallen Humans
		{ EffectTypes.Battleground_Lizard___Hard, "Battleground Lizard - hard" },                                                                               // Fallen Lizards
		{ EffectTypes.Battleground_Lizard___Impossible, "Battleground Lizard - impossible" },                                                                   // Fallen Lizards
		{ EffectTypes.Battleground_Lizard___Normal, "Battleground Lizard - normal" },                                                                           // Fallen Lizards
		{ EffectTypes.Battleground_Lizard___Very_Hard, "Battleground Lizard - very hard" },                                                                     // Fallen Lizards
		{ EffectTypes.Beanery_Blueprint, "Beanery Blueprint" },                                                                                                 // Beanery
		{ EffectTypes.Beaver_1, "Beaver 1" },                                                                                                                   // Beaver
		{ EffectTypes.Beaver_2, "Beaver 2" },                                                                                                                   // Group of Beavers
		{ EffectTypes.Beaver_3, "Beaver 3" },                                                                                                                   // Group of Beavers
		{ EffectTypes.Beaver_4, "Beaver 4" },                                                                                                                   // Group of Beavers
		{ EffectTypes.Beaver_5, "Beaver 5" },                                                                                                                   // Group of Beavers
		{ EffectTypes.Beaver_Faction_Support, "Beaver Faction Support" },                                                                                       // Beaver Clan Support
		{ EffectTypes.Beaver_House_Blueprint, "Beaver House Blueprint" },                                                                                       // Beaver House
		{ EffectTypes.Beaver_Resolve_For_Wine_Prod, "Beaver Resolve for Wine Prod" },                                                                           // Vineyard Town
		{ EffectTypes.Beavers_Killed_3___Missiles, "Beavers Killed 3 - Missiles" },                                                                             // Blood for Blood
		{ EffectTypes.Berries_10, "Berries 10" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_10pm, "Berries 10pm" },                                                                                                           // Berry Delivery Line
		{ EffectTypes.Berries_20, "Berries 20" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_25, "Berries 25" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_30, "Berries 30" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_40, "Berries 40" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_50, "Berries 50" },                                                                                                               // Basket of Berries
		{ EffectTypes.Berries_5pm, "Berries 5pm" },                                                                                                             // Berry Delivery Line
		{ EffectTypes.Berries_Plus1, "Berries +1" },                                                                                                            // Large Berry Baskets
		{ EffectTypes.Berries_Plus2, "Berries +2" },                                                                                                            // Large Berry Baskets
		{ EffectTypes.Berries_Plus3, "Berries +3" },                                                                                                            // Large Berry Baskets
		{ EffectTypes.Berries_Plus5, "Berries +5" },                                                                                                            // Large Berry Baskets
		{ EffectTypes.Bigger_Storage, "Bigger Storage" },                                                                                                       // Orderly Storage
		{ EffectTypes.BIOME_Big_Trees, "[BIOME] Big Trees" },                                                                                                   // Overgrown Vegetation
		{ EffectTypes.BIOME_Cursed_Glades, "[BIOME] Cursed Glades" },                                                                                           // Cursed Battlefield
		{ EffectTypes.BIOME_Diverse_Flora, "[BIOME] Diverse Flora" },                                                                                           // Diverse Flora
		{ EffectTypes.Biome_Gatherer_Production_Speed, "[Biome] Gatherer Production Speed" },                                                                   // Camps Speed
		{ EffectTypes.Biome_Ghosts_In_Cursed_Woodlands, "[Biome] Ghosts in Cursed Woodlands" },                                                                 // Restless Spirits
		{ EffectTypes.BIOME_Giant_Organisms, "[BIOME] Giant Organisms" },                                                                                       // Giant Organisms
		{ EffectTypes.BIOME_HarvestingRate_Plus10, "[BIOME] HarvestingRate +10" },                                                                              // Gift of the Woodlands
		{ EffectTypes.BIOME_Inspiring_Pressure, "[BIOME] Inspiring Pressure" },                                                                                 // Inspiring Pressure
		{ EffectTypes.BIOME_Inspiring_Pressure_Holder, "[BIOME] Inspiring Pressure Holder" },                                                                   // Inspiring Pressure
		{ EffectTypes.BIOME_Marshlands_Camps_Speed, "[BIOME] Marshlands Camps Speed" },                                                                         // Gathering Knowledge
		{ EffectTypes.Biome_Moorlands___Archaeologist_Blueprint, "[Biome] Moorlands - Archaeologist Blueprint" },                                               // Royal Archaeologists
		{ EffectTypes.Biome_Moorlands___Glades, "[Biome] Moorlands - glades" },                                                                                 // Buried Mysteries
		{ EffectTypes.Biome_Same_Size_Glades, "[Biome] Same Size Glades" }, 
		{ EffectTypes.BIOME_Sealed_Biome, "[BIOME] Sealed Biome" },                                                                                             // Beacon Tower
		{ EffectTypes.BIOME_Storm_Penalty, "[BIOME] Storm Penalty" },                                                                                           // Looming Darkness
		{ EffectTypes.BIOME_Tree_Hostility, "[BIOME] Tree Hostility" },                                                                                         // Abyssal Revenge
		{ EffectTypes.BIOME_Tut_1_Storm_Penalty, "[BIOME] Tut 1 Storm Penalty" },                                                                               // Looming Darkness
		{ EffectTypes.Biome_Wood_In_Woodlands, "[Biome] Wood in Woodlands" },                                                                                   // Gift of the Woodlands
		{ EffectTypes.Biscuit_Recipes, "Biscuit Recipes" },                                                                                                     // Biscuit Recipes
		{ EffectTypes.Biscuits_10, "Biscuits 10" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_15, "Biscuits 15" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_20, "Biscuits 20" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_25, "Biscuits 25" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_30, "Biscuits 30" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_3pm, "Biscuits 3pm" },                                                                                                           // Biscuit Delivery Line
		{ EffectTypes.Biscuits_40, "Biscuits 40" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_5pm, "Biscuits 5pm" },                                                                                                           // Biscuit Delivery Line
		{ EffectTypes.Biscuits_60, "Biscuits 60" },                                                                                                             // Basket of Biscuits
		{ EffectTypes.Biscuits_In_Kiln, "Biscuits in Kiln" },                                                                                                   // Biscuit Recipes
		{ EffectTypes.Biscuits_In_Rain_Mill, "Biscuits in Rain Mill" },                                                                                         // Biscuit Recipes
		{ EffectTypes.Biscuits_In_Rain_Mill_Haunted, "Biscuits in Rain Mill Haunted" },                                                                         // Biscuit Recipes
		{ EffectTypes.Biscuits_Plus1, "Biscuits +1" },                                                                                                          // Bigger Pans
		{ EffectTypes.Biscuits_Plus2, "Biscuits +2" },                                                                                                          // Bigger Pans
		{ EffectTypes.Biscuits_Plus3, "Biscuits +3" },                                                                                                          // Bigger Pans
		{ EffectTypes.Biscuits_Plus5, "Biscuits +5" },                                                                                                          // Bigger Pans
		{ EffectTypes.Black_Stag_Reward_Catch, "Black Stag Reward Catch" },                                                                                     // Cursed Treasure
		{ EffectTypes.Black_Stag_Reward_Chase, "Black Stag Reward Chase" },                                                                                     // Into the Mists
		{ EffectTypes.Black_Stag_Reward_Release, "Black Stag Reward Release" },                                                                                 // Gift of Gratitude
		{ EffectTypes.Blight_Fighter_Speed, "Blight Fighter Speed" },                                                                                           // The Sparkcaster
		{ EffectTypes.Blight_Fuel_Plus1, "Blight Fuel +1" },                                                                                                    // Fuel Mix
		{ EffectTypes.Blight_Fuel_Plus2, "Blight Fuel +2" },                                                                                                    // Fuel Mix
		{ EffectTypes.Blight_Fuel_Plus3, "Blight Fuel +3" },                                                                                                    // Fuel Mix
		{ EffectTypes.Blight_Fuel_Plus5, "Blight Fuel +5" },                                                                                                    // Fuel Mix
		{ EffectTypes.Blight_Post_Blueprint, "Blight Post Blueprint" },                                                                                         // Forsaken Altar
		{ EffectTypes.Blight_Post_Speed_Plus50, "Blight Post Speed +50" }, 
		{ EffectTypes.Blight_Rate_For_Resolve_Reputation, "Blight Rate for Resolve Reputation" },                                                               // Blight Filter
		{ EffectTypes.Blight_Rate_For_Resolve_Reputation___Blight_Rate__50, "Blight Rate for Resolve Reputation - Blight Rate -50" },                           // Engine Corrosion
		{ EffectTypes.Blight_Rate_For_Resolve_Reputation___No_Rep_From_Resolve, "Blight Rate for Resolve Reputation - No Rep From Resolve" },                   // Blight Filter
		{ EffectTypes.Blight_Rate_For_Resolve_Reputation___No_Rep_From_Resolve___Holder, "Blight Rate for Resolve Reputation - No Rep From Resolve - Holder" }, // Unbearable Smell
		{ EffectTypes.Blightrot_Cloning, "Blightrot Cloning" },                                                                                                 // Mitosis
		{ EffectTypes.Blightrot_Outbreak, "Blightrot Outbreak" },                                                                                               // Blightrot Outbreak
		{ EffectTypes.Blightrot_Over_Time___Rainpunk_Foundry___Hard, "Blightrot over Time - Rainpunk Foundry - hard" },                                         // Overcharged Rainpunk Technology
		{ EffectTypes.Blightrot_Over_Time___Rainpunk_Foundry___Impossible, "Blightrot over Time - Rainpunk Foundry - impossible" },                             // Overcharged Rainpunk Technology
		{ EffectTypes.Blightrot_Over_Time___Rainpunk_Foundry___Normal, "Blightrot over Time - Rainpunk Foundry - normal" },                                     // Overcharged Rainpunk Technology
		{ EffectTypes.Blightrot_Over_Time___Rainpunk_Foundry___Very_Hard, "Blightrot over Time - Rainpunk Foundry - very hard" },                               // Overcharged Rainpunk Technology
		{ EffectTypes.Blightrot_RemoveFoodOverTime___Hard, "Blightrot_RemoveFoodOverTime - hard" },                                                             // Decaying Food
		{ EffectTypes.Blightrot_RemoveFoodOverTime___Impossible, "Blightrot_RemoveFoodOverTime - impossible" },                                                 // Decaying Food
		{ EffectTypes.Blightrot_RemoveFoodOverTime___Normal, "Blightrot_RemoveFoodOverTime - normal" },                                                         // Decaying Food
		{ EffectTypes.Blightrot_RemoveFoodOverTime___Very_Hard, "Blightrot_RemoveFoodOverTime - very hard" },                                                   // Decaying Food
		{ EffectTypes.Blightrot_Resolve, "Blightrot Resolve" },                                                                                                 // Blood Flower
		{ EffectTypes.Blood_Price, "Blood Price" },                                                                                                             // Blood Price Contract
		{ EffectTypes.Bonus_Global_Reputation_Treshold_Increase_1, "Bonus Global Reputation Treshold Increase 1" },                                             // TODO NAME
		{ EffectTypes.Break_Time__3, "Break Time -3" }, 
		{ EffectTypes.Break_Time__50, "Break Time -50" }, 
		{ EffectTypes.Break_Time_Plus25, "Break Time +25" }, 
		{ EffectTypes.Break_Time_Plus50, "Break Time +50" }, 
		{ EffectTypes.Brewery_Blueprint, "Brewery Blueprint" },                                                                                                 // Brewery
		{ EffectTypes.Brewery_Haunted_Plus50, "Brewery Haunted +50" },                                                                                          // Efficient Brewing
		{ EffectTypes.Brewery_Haunted_Plus60, "Brewery Haunted +60" },                                                                                          // Advanced Brewing
		{ EffectTypes.Brewery_Plus50, "Brewery +50" },                                                                                                          // Efficient Brewing
		{ EffectTypes.Brewery_Plus50_Composite_, "Brewery +50 (Composite)" },                                                                                   // Efficient Brewing
		{ EffectTypes.Brewery_Plus60, "Brewery +60" },                                                                                                          // Advanced Brewing
		{ EffectTypes.Brewery_Plus60_Composite_, "Brewery +60 (Composite)" },                                                                                   // Advanced Brewing
		{ EffectTypes.Brewery_Speed_Haunted_Plus50, "Brewery Speed Haunted +50" },                                                                              // Rain Pumps
		{ EffectTypes.Brewery_Speed_Plus50, "Brewery Speed +50" },                                                                                              // Rain Pumps
		{ EffectTypes.Brewery_Speed_Plus50_Composite_, "Brewery Speed +50 (Composite)" },                                                                       // Rain Pumps
		{ EffectTypes.Brick_Oven_Blueprint, "Brick Oven Blueprint" },                                                                                           // Brick Oven
		{ EffectTypes.Bricks_10, "Bricks 10" },                                                                                                                 // Crate of Bricks
		{ EffectTypes.Bricks_15, "Bricks 15" },                                                                                                                 // Crate of Bricks
		{ EffectTypes.Bricks_2, "Bricks 2" },                                                                                                                   // Crate of Bricks
		{ EffectTypes.Bricks_20, "Bricks 20" },                                                                                                                 // Crate of Bricks
		{ EffectTypes.Bricks_25, "Bricks 25" },                                                                                                                 // Crate of Bricks
		{ EffectTypes.Bricks_30, "Bricks 30" },                                                                                                                 // Crate of Bricks
		{ EffectTypes.Bricks_4, "Bricks 4" },                                                                                                                   // Crate of Bricks
		{ EffectTypes.Bricks_5, "Bricks 5" },                                                                                                                   // Crate of Bricks
		{ EffectTypes.Bricks_8, "Bricks 8" },                                                                                                                   // Crate of Bricks
		{ EffectTypes.Bricks_Plus1, "Bricks +1" },                                                                                                              // Reinforced Brick Mold
		{ EffectTypes.Bricks_Plus2, "Bricks +2" },                                                                                                              // Reinforced Brick Mold
		{ EffectTypes.Bricks_Plus3, "Bricks +3" },                                                                                                              // Reinforced Brick Mold
		{ EffectTypes.Bricks_Plus5, "Bricks +5" },                                                                                                              // Reinforced Brick Mold
		{ EffectTypes.Brickyard_Blueprint, "Brickyard Blueprint" },                                                                                             // Brickyard
		{ EffectTypes.BT_Global_Production_Rate, "[BT] Global Production Rate" },                                                                               // Song of Haste
		{ EffectTypes.BT_Global_Production_Rate___Child, "[BT] Global Production Rate - child" },                                                               // Song of Haste
		{ EffectTypes.BT_Grain_40, "[BT] Grain 40" },                                                                                                           // Box of Grain
		{ EffectTypes.BT_Hearth_Bonus_HP_Plus250, "[BT] Hearth Bonus HP +250" },                                                                                // Miracle of Strength
		{ EffectTypes.BT_Hearth_Bonus_HP_Plus250___Child, "[BT] Hearth Bonus HP +250 - child" },                                                                // Miracle of Strength
		{ EffectTypes.BT_Increased_Farm_Production, "[BT] Increased farm production" },                                                                         // Chest of Farming Tools
		{ EffectTypes.BT_Increased_Farm_Production___Child, "[BT] Increased farm production - child" },                                                         // Chest of Farming Tools
		{ EffectTypes.BT_Lower_Hostility, "[BT] Lower Hostility" },                                                                                             // Miracle of Peace
		{ EffectTypes.BT_Lower_Hostility___Child, "[BT] Lower Hostility - child" },                                                                             // Miracle of Peace
		{ EffectTypes.BT_Moth_Larvae_Meat_30, "[BT] Moth Larvae Meat 30" },                                                                                     // Pack of Meat
		{ EffectTypes.BT_Relic_Working_TIme, "[BT] Relic Working TIme" },                                                                                       // Miracle of Agility
		{ EffectTypes.BT_Relic_Working_TIme___Child, "[BT] Relic Working TIme - child" },                                                                       // Miracle of Agility
		{ EffectTypes.BT_Slower_Leaving, "[BT] Slower Leaving" },                                                                                               // Song of Hope
		{ EffectTypes.BT_Slower_Leaving___Child, "[BT] Slower Leaving - child" },                                                                               // Song of Hope
		{ EffectTypes.BT_Trade_Routes_Bonus, "[BT] Trade Routes Bonus" },                                                                                       // Song of Prosperity
		{ EffectTypes.BT_Trade_Routes_Bonus___Child, "[BT] Trade Routes Bonus - child" },                                                                       // Song of Prosperity
		{ EffectTypes.Builder_Plus1, "Builder +1" },                                                                                                            // Builder's Pack
		{ EffectTypes.Builder_Plus10, "Builder +10" },                                                                                                          // Builder's Pack
		{ EffectTypes.Builder_Plus15, "Builder +15" },                                                                                                          // Builder's Pack
		{ EffectTypes.Builder_Plus5, "Builder +5" },                                                                                                            // Builder's Pack
		{ EffectTypes.Building_Materials_For_Planks, "Building Materials for Planks" },                                                                         // Carpenter's Tools
		{ EffectTypes.Butcher_Blueprint, "Butcher Blueprint" },                                                                                                 // Butcher
		{ EffectTypes.Butcher_Plus50, "Butcher +50" },                                                                                                          // Meat Cleavers
		{ EffectTypes.Cache_Rewards_For_Nodes, "Cache Rewards for Nodes" },                                                                                     // Reckless Plunder
		{ EffectTypes.Cannibalism, "Cannibalism" },                                                                                                             // Cannibalism
		{ EffectTypes.CaptainCurse, "CaptainCurse" },                                                                                                           // Captain's Curse
		{ EffectTypes.Carpenter_Blueprint, "Carpenter Blueprint" },                                                                                             // Carpenter
		{ EffectTypes.Cellar_Blueprint, "Cellar Blueprint" },                                                                                                   // Cellar
		{ EffectTypes.Chance_For_No_Consumption_10, "Chance for no consumption 10" }, 
		{ EffectTypes.Chance_For_No_Production_Plague, "Chance For No Production Plague" },                                                                     // Plague of Blindness
		{ EffectTypes.Chaos, "Chaos" },                                                                                                                         // Chaos
		{ EffectTypes.Charm_Villagers, "Charm Villagers" },                                                                                                     // Kelpie's Charm
		{ EffectTypes.Charm_Villagers___Keep, "Charm Villagers - Keep" }, 
		{ EffectTypes.Charm_Villagers_Effect_Model, "Charm Villagers Effect Model" }, 
		{ EffectTypes.Chest_Working_Time__30, "Chest Working Time -30" },                                                                                       // Scout's Toolbox
		{ EffectTypes.City_Renown, "City Renown" },                                                                                                             // City Renown
		{ EffectTypes.City_Score___30, "City Score - 30" },                                                                                                     // Bad Reputation
		{ EffectTypes.City_Score___50, "City Score - 50" },                                                                                                     // Bad Reputation
		{ EffectTypes.City_Score___70, "City Score - 70" },                                                                                                     // Bad Reputation
		{ EffectTypes.Clay_10, "Clay 10" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_10pm, "Clay 10pm" },                                                                                                                 // Clay Delivery Line
		{ EffectTypes.Clay_15, "Clay 15" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_20, "Clay 20" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_25, "Clay 25" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_30, "Clay 30" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_35, "Clay 35" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_3pm, "Clay 3pm" },                                                                                                                   // Clay Delivery Line
		{ EffectTypes.Clay_40, "Clay 40" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_5, "Clay 5" },                                                                                                                       // Crate of Clay
		{ EffectTypes.Clay_50, "Clay 50" },                                                                                                                     // Crate of Clay
		{ EffectTypes.Clay_5pm, "Clay 5pm" },                                                                                                                   // Clay Delivery Line
		{ EffectTypes.Clay_8, "Clay 8" },                                                                                                                       // Crate of Clay
		{ EffectTypes.Clay_Pit__50, "Clay Pit -50" },                                                                                                           // Reinforced Tools
		{ EffectTypes.Clay_Pit_Blueprint, "Clay Pit Blueprint" },                                                                                               // Clay Pit
		{ EffectTypes.Clay_Pit_Plus100, "Clay Pit +100" }, 
		{ EffectTypes.Clay_Pit_Plus150, "Clay Pit +150" }, 
		{ EffectTypes.Clay_Pit_Plus50, "Clay Pit +50" },                                                                                                        // Reinforced Tools
		{ EffectTypes.Clay_Plus1, "Clay +1" },                                                                                                                  // Steel Shovels
		{ EffectTypes.Clay_Plus2, "Clay +2" },                                                                                                                  // Steel Shovels
		{ EffectTypes.Clay_Plus3, "Clay +3" },                                                                                                                  // Steel Shovels
		{ EffectTypes.Clay_Plus5, "Clay +5" },                                                                                                                  // Steel Shovels
		{ EffectTypes.Clearance_Water_5, "Clearance Water 5" },                                                                                                 // Clearance Water
		{ EffectTypes.Clearence_Water_50_Pm, "Clearence water 50 pm" }, 
		{ EffectTypes.Clothier_Plus50, "Clothier +50" },                                                                                                        // Reinforced Stoves
		{ EffectTypes.Coal_10, "Coal 10" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_10pm, "Coal 10pm" },                                                                                                                 // Coal Delivery Line
		{ EffectTypes.Coal_15, "Coal 15" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_20, "Coal 20" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_25, "Coal 25" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_30, "Coal 30" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_3pm, "Coal 3pm" },                                                                                                                   // Coal Delivery Line
		{ EffectTypes.Coal_40, "Coal 40" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_50, "Coal 50" },                                                                                                                     // Chest of Coal
		{ EffectTypes.Coal_5pm, "Coal 5pm" },                                                                                                                   // Coal Delivery Line
		{ EffectTypes.Coal_For_Cysts, "Coal for Cysts" },                                                                                                       // Burnt to a Crisp
		{ EffectTypes.Coal_Plus1, "Coal +1" },                                                                                                                  // Specialized Mining
		{ EffectTypes.Coal_Plus2, "Coal +2" },                                                                                                                  // Specialized Mining
		{ EffectTypes.Coal_Plus3, "Coal +3" },                                                                                                                  // Specialized Mining
		{ EffectTypes.Coal_Plus5, "Coal +5" },                                                                                                                  // Specialized Mining
		{ EffectTypes.Coats_10, "Coats 10" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_10pm, "Coats 10pm" },                                                                                                               // Coat Delivery Line
		{ EffectTypes.Coats_15, "Coats 15" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_20, "Coats 20" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_25, "Coats 25" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_35, "Coats 35" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_3pm, "Coats 3pm" },                                                                                                                 // Coat Delivery Line
		{ EffectTypes.Coats_40, "Coats 40" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_5, "Coats 5" },                                                                                                                     // Bundle of Coats
		{ EffectTypes.Coats_50, "Coats 50" },                                                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_50___Harpy_Passive, "Coats 50 - Harpy Passive" },                                                                                   // Bundle of Coats
		{ EffectTypes.Coats_5pm, "Coats 5pm" },                                                                                                                 // Coat Delivery Line
		{ EffectTypes.Coats_Plus1, "Coats +1" },                                                                                                                // Ancient Sewing Technique
		{ EffectTypes.Coats_Plus2, "Coats +2" },                                                                                                                // Ancient Sewing Technique
		{ EffectTypes.Coats_Plus3, "Coats +3" },                                                                                                                // Ancient Sewing Technique
		{ EffectTypes.Coats_Plus5, "Coats +5" },                                                                                                                // Ancient Sewing Technique
		{ EffectTypes.Common_Hall_Blueprint, "Common Hall Blueprint" },                                                                                         // Clan Hall
		{ EffectTypes.Construction_Cost__33, "Construction Cost -33" }, 
		{ EffectTypes.Construction_Cost__40, "Construction Cost -40" }, 
		{ EffectTypes.Construction_Cost__50, "Construction Cost -50" }, 
		{ EffectTypes.Construction_Cost_For_Nodes, "Construction cost for nodes" },                                                                             // Cheap Construction
		{ EffectTypes.Construction_Speed_50, "Construction Speed 50" },                                                                                         // Enhanced Blueprints
		{ EffectTypes.Construction_Speed_Slower_25, "Construction Speed Slower 25" }, 
		{ EffectTypes.Consumption_Control_Block___Without_Restrictions, "Consumption Control Block - Without Restrictions" },                                   // Without Restrictions
		{ EffectTypes.Consumption_Control_For_Extra_Production, "Consumption Control for Extra Production" },                                                   // Without Restrictions
		{ EffectTypes.Converted_Altar_Of_Decay, "Converted Altar of Decay" },                                                                                   // Converted Altar of Decay
		{ EffectTypes.Convicts___Hard, "Convicts - hard" },                                                                                                     // Defenseless
		{ EffectTypes.Convicts___Impossible, "Convicts - impossible" },                                                                                         // Defenseless
		{ EffectTypes.Convicts___Normal, "Convicts - normal" },                                                                                                 // Defenseless
		{ EffectTypes.Convicts___Very_Hard, "Convicts - very hard" },                                                                                           // Defenseless
		{ EffectTypes.Cookhouse_Blueprint, "Cookhouse Blueprint" },                                                                                             // Cookhouse
		{ EffectTypes.Cookhouse_Speed_Plus50, "Cookhouse Speed +50" }, 
		{ EffectTypes.Cooperage_Blueprint, "Cooperage Blueprint" },                                                                                             // Cooperage
		{ EffectTypes.Copper_And_Wood_For_Chests, "Copper and Wood for Chests" },                                                                               // Salvaging Tools
		{ EffectTypes.Copper_Bar_1, "Copper Bar 1" },                                                                                                           // Copper Bars
		{ EffectTypes.Copper_Bar_10, "Copper Bar 10" },                                                                                                         // Copper Bars
		{ EffectTypes.Copper_Bar_15, "Copper Bar 15" },                                                                                                         // Copper Bars
		{ EffectTypes.Copper_Bar_20, "Copper Bar 20" },                                                                                                         // Copper Bars
		{ EffectTypes.Copper_Bar_30, "Copper Bar 30" },                                                                                                         // Copper Bars
		{ EffectTypes.Copper_Bar_Plus1, "Copper Bar +1" },                                                                                                      // Advanced Smelting
		{ EffectTypes.Copper_Bar_Plus2, "Copper Bar +2" },                                                                                                      // Advanced Smelting
		{ EffectTypes.Copper_Bar_Plus3, "Copper Bar +3" },                                                                                                      // Advanced Smelting
		{ EffectTypes.Copper_Bar_Plus5, "Copper Bar +5" },                                                                                                      // Advanced Smelting
		{ EffectTypes.Copper_Bars_2pm, "Copper Bars 2pm" },                                                                                                     // Metal Delivery Line
		{ EffectTypes.Copper_Bars_3pm, "Copper Bars 3pm" },                                                                                                     // Metal Delivery Line
		{ EffectTypes.Copper_Bars_4pm, "Copper Bars 4pm" },                                                                                                     // Metal Delivery Line
		{ EffectTypes.Copper_Bars_5pm, "Copper Bars 5pm" },                                                                                                     // Metal Delivery Line
		{ EffectTypes.Copper_For_Each_Tree, "Copper for each tree" },                                                                                           // Copper Extractor
		{ EffectTypes.Copper_For_Trees_Parent, "Copper For Trees [Parent]" },                                                                                   // Copper Extractor
		{ EffectTypes.Copper_Ore_1, "Copper Ore 1" },                                                                                                           // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_10, "Copper Ore 10" },                                                                                                         // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_10pm, "Copper Ore 10pm" },                                                                                                     // Ore Delivery Line
		{ EffectTypes.Copper_Ore_15, "Copper Ore 15" },                                                                                                         // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_20, "Copper Ore 20" },                                                                                                         // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_30, "Copper Ore 30" },                                                                                                         // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_40, "Copper Ore 40" },                                                                                                         // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_5, "Copper Ore 5" },                                                                                                           // Crate of Copper Ore
		{ EffectTypes.Copper_Ore_5pm, "Copper Ore 5pm" },                                                                                                       // Ore Delivery Line
		{ EffectTypes.Copper_Ore_Plus1, "Copper Ore +1" },                                                                                                      // Steel Drills
		{ EffectTypes.Copper_Ore_Plus2, "Copper Ore +2" },                                                                                                      // Steel Drills
		{ EffectTypes.Copper_Ore_Plus3, "Copper Ore +3" },                                                                                                      // Steel Drills
		{ EffectTypes.Copper_Ore_Plus5, "Copper Ore +5" },                                                                                                      // Steel Drills
		{ EffectTypes.Copper_Tools_Plus1, "Copper Tools +1" },                                                                                                  // Advanced Smithing
		{ EffectTypes.Copper_Tools_Plus1___In_Hook, "Copper Tools +1 - in hook" },                                                                              // Advanced Smithing
		{ EffectTypes.Copper_Tools_Plus2, "Copper Tools +2" },                                                                                                  // Advanced Smithing
		{ EffectTypes.Copper_Tools_Plus3, "Copper Tools +3" },                                                                                                  // Advanced Smithing
		{ EffectTypes.Copper_Tools_Plus5, "Copper Tools +5" },                                                                                                  // Advanced Smithing
		{ EffectTypes.Cornerstone_Reroll___Trader, "Cornerstone Reroll - Trader" },                                                                             // Lucky Charm
		{ EffectTypes.Cornerstone_Reroll_Plus1, "Cornerstone Reroll +1" },                                                                                      // Royal Permit
		{ EffectTypes.Corrupted_Sacrifice, "Corrupted Sacrifice" },                                                                                             // Mark of the Sealed Ones
		{ EffectTypes.Corruption_Per_Removed_Cyst__50, "Corruption Per Removed Cyst -50" },                                                                     // Firekeeper's Armor
		{ EffectTypes.Crops_For_Grain, "Crops for Grain" },                                                                                                     // Leftover Crops
		{ EffectTypes.Crude_Workstation_Blueprint, "Crude Workstation Blueprint" },                                                                             // Crude Workstation
		{ EffectTypes.Crude_Workstation_Plus100, "Crude Workstation +100" },                                                                                    // Workstation Upgrade
		{ EffectTypes.Crude_Workstation_Plus50, "Crude Workstation +50" },                                                                                      // Workstation Upgrade
		{ EffectTypes.Crude_Workstation_Speed_Plus50, "Crude Workstation Speed +50" },                                                                          // Carpenter's Tools
		{ EffectTypes.Crystaline_Water, "Crystaline Water" },                                                                                                   // Small Distillery
		{ EffectTypes.Crystalized_Dew__1, "Crystalized Dew -1" },                                                                                               // Crystal Growth
		{ EffectTypes.Crystalized_Dew_1, "Crystalized Dew 1" },                                                                                                 // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_10, "Crystalized Dew 10" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_15, "Crystalized Dew 15" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_2, "Crystalized Dew 2" },                                                                                                 // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_20, "Crystalized Dew 20" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_25, "Crystalized Dew 25" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_30, "Crystalized Dew 30" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_4, "Crystalized Dew 4" },                                                                                                 // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_40, "Crystalized Dew 40" },                                                                                               // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_5, "Crystalized Dew 5" },                                                                                                 // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_8, "Crystalized Dew 8" },                                                                                                 // Box of Crystalized Dew
		{ EffectTypes.Crystalized_Dew_Plus1, "Crystalized Dew +1" },                                                                                            // Crystal Growth
		{ EffectTypes.Crystalized_Dew_Plus2, "Crystalized Dew +2" },                                                                                            // Crystal Growth
		{ EffectTypes.Crystalized_Dew_Plus3, "Crystalized Dew +3" },                                                                                            // Crystal Growth
		{ EffectTypes.Crystalized_Dew_Plus5, "Crystalized Dew +5" },                                                                                            // Crystal Growth
		{ EffectTypes.Cysts_Activation, "Cysts Activation" },                                                                                                   // Awakening
		{ EffectTypes.Cysts_Faster_Burning_5, "Cysts Faster Burning 5" }, 
		{ EffectTypes.Cysts_For_Glades, "Cysts for Glades" }, 
		{ EffectTypes.Cysts_For_Hostility, "Cysts For Hostility" }, 
		{ EffectTypes.Cysts_Longer_Burning_5, "Cysts Longer Burning 5" },                                                                                       // Effective Parasite
		{ EffectTypes.Dangerous_Glades_Info_Block_Mistworm, "Dangerous Glades Info Block Mistworm" },                                                           // Heavy Fog
		{ EffectTypes.Dangerous_Relic_Working_TIme__50, "Dangerous Relic Working TIme -50" }, 
		{ EffectTypes.Dangerous_Relic_Working_TIme_Plus50, "Dangerous Relic Working TIme +50" }, 
		{ EffectTypes.DarkGateResolve___Hard, "DarkGateResolve - hard" },                                                                                       // Gate Presence
		{ EffectTypes.DarkGateResolve___Impossible, "DarkGateResolve - impossible" },                                                                           // Gate Presence
		{ EffectTypes.DarkGateResolve___Normal, "DarkGateResolve - normal" },                                                                                   // Gate Presence
		{ EffectTypes.DarkGateResolve___Very_Hard, "DarkGateResolve - very hard" },                                                                             // Gate Presence
		{ EffectTypes.Destroy_All_Crops, "Destroy All Crops" },                                                                                                 // Toxic Ooze
		{ EffectTypes.Diff_Altar, "[Diff] Altar" },                                                                                                             // Forsaken Altar
		{ EffectTypes.Diff_Blightrot, "[Diff] Blightrot" },                                                                                                     // Blightrot & Corruption
		{ EffectTypes.Diff_Hunger_Multiplier, "[Diff] Hunger Multiplier" },                                                                                     // Famine Outbreaks
		{ EffectTypes.Diff_Lower_Food_Consumption, "[Diff] Lower Food Consumption" },                                                                           // Settler's Luck
		{ EffectTypes.Diff_No_Blightrot, "[Diff] No Blightrot" }, 
		{ EffectTypes.Distillery_Blueprint, "Distillery Blueprint" },                                                                                           // Distillery
		{ EffectTypes.Drizzle_Water_50_Pm, "Drizzle water 50 pm" }, 
		{ EffectTypes.Druid_Blueprint, "Druid Blueprint" },                                                                                                     // Druid's Hut
		{ EffectTypes.Effect_CaravanTradeBlock, "Effect_CaravanTradeBlock" },                                                                                   // Unwelcoming Region
		{ EffectTypes.Effect_DesertedCaravans, "Effect_DesertedCaravans" },                                                                                     // Deserted Caravans
		{ EffectTypes.Eggs_10pm, "Eggs 10pm" },                                                                                                                 // Egg Delivery Line
		{ EffectTypes.Eggs_15pm, "Eggs 15pm" },                                                                                                                 // Egg Delivery Line
		{ EffectTypes.Eggs_20, "Eggs 20" },                                                                                                                     // Basket of Eggs
		{ EffectTypes.Eggs_25, "Eggs 25" },                                                                                                                     // Basket of Eggs
		{ EffectTypes.Eggs_30, "Eggs 30" },                                                                                                                     // Basket of Eggs
		{ EffectTypes.Eggs_3pm, "Eggs 3pm" },                                                                                                                   // Egg Delivery Line
		{ EffectTypes.Eggs_40, "Eggs 40" },                                                                                                                     // Basket of Eggs
		{ EffectTypes.Eggs_5, "Eggs 5" },                                                                                                                       // Basket of Eggs
		{ EffectTypes.Eggs_50, "Eggs 50" },                                                                                                                     // Basket of Eggs
		{ EffectTypes.Eggs_5pm_Stormbird, "Eggs 5pm Stormbird" },                                                                                               // Nest Eggs
		{ EffectTypes.Eggs_For_Cysts, "Eggs For Cysts" },                                                                                                       // Blightrot Pruner
		{ EffectTypes.Eggs_Plus1, "Eggs +1" },                                                                                                                  // Egg Containers
		{ EffectTypes.Eggs_Plus2, "Eggs +2" },                                                                                                                  // Egg Containers
		{ EffectTypes.Eggs_Plus3, "Eggs +3" },                                                                                                                  // Egg Containers
		{ EffectTypes.Eggs_Plus5, "Eggs +5" },                                                                                                                  // Egg Containers
		{ EffectTypes.Embark_Cornerstone_Reroll_Plus3, "[Embark] Cornerstone Reroll +3" },                                                                      // Royal Permit
		{ EffectTypes.Engines_Blight_Rate_Plus20, "Engines Blight Rate +20" }, 
		{ EffectTypes.Engines_Blight_Rate_Plus25, "Engines Blight Rate +25" }, 
		{ EffectTypes.Engines_Blight_Rate_Plus50, "Engines Blight Rate +50" },                                                                                  // Engine Corrosion
		{ EffectTypes.Event_Time_Reduction_10, "Event Time Reduction 10" },                                                                                     // Lucky Talisman
		{ EffectTypes.EventsRewardsForBloodthirst, "EventsRewardsForBloodthirst" },                                                                             // Exploration Training
		{ EffectTypes.Every_Sec_Global_Resolve___Hard, "Every Sec Global Resolve - hard" },                                                                     // Frightening Visions
		{ EffectTypes.Every_Sec_Global_Resolve___Impossible, "Every Sec Global Resolve - impossible" },                                                         // Frightening Visions
		{ EffectTypes.Every_Sec_Global_Resolve___Normal, "Every Sec Global Resolve - normal" },                                                                 // Frightening Visions
		{ EffectTypes.Every_Sec_Global_Resolve___Very_Hard, "Every Sec Global Resolve - very hard" },                                                           // Frightening Visions
		{ EffectTypes.Every_Sec_Hostility, "Every Sec Hostility" },                                                                                             // Whispering Tombs
		{ EffectTypes.Exploration_Contract, "Exploration Contract" },                                                                                           // Exploration Contract
		{ EffectTypes.Exploration_Tax___Villagers_Leaving, "Exploration Tax - Villagers Leaving" },                                                             // Recall (Land Tax)
		{ EffectTypes.Explorers_Boredom, "Explorers Boredom" },                                                                                                 // Explorers' Boredom
		{ EffectTypes.Explorers_Lodge_Blueprint, "Explorers Lodge Blueprint" },                                                                                 // Explorers' Lodge
		{ EffectTypes.Exploring_Expedition, "Exploring Expedition" },                                                                                           // Exploration Expedition
		{ EffectTypes.Exploring_Expedition___Resolve_Bonus_Effect, "Exploring Expedition - Resolve Bonus Effect" },                                             // Exploration Expedition
		{ EffectTypes.Exploring_Expedition___Resolve_Bonus_Effect___Holder, "Exploring Expedition - Resolve Bonus Effect - Holder" },                           // Joy Of Discovery
		{ EffectTypes.Exploring_Expedition___Slower_Woodcutting___Holder, "Exploring Expedition - Slower Woodcutting - Holder" },                               // Joy Of Discovery
		{ EffectTypes.Extra_Beaver_Newcommers, "Extra Beaver Newcommers" },                                                                                     // Beaver Friendship
		{ EffectTypes.Extra_Consumption_Plus100, "Extra Consumption +100" }, 
		{ EffectTypes.Extra_Consumption_Plus25, "Extra Consumption +25" }, 
		{ EffectTypes.Extra_Consumption_Plus50, "Extra Consumption +50" }, 
		{ EffectTypes.Extra_Fox_Newcommers, "Extra Fox Newcommers" },                                                                                           // Fox Friendship
		{ EffectTypes.Extra_Glade___Moorlands_Dangerous, "Extra Glade - Moorlands Dangerous" }, 
		{ EffectTypes.Extra_Glade___Moorlands_Forbidden, "Extra Glade - Moorlands Forbidden" }, 
		{ EffectTypes.Extra_Glade___Moorlands_Normal, "Extra Glade - Moorlands Normal" }, 
		{ EffectTypes.Extra_Glade___Seal, "Extra Glade - Seal" },                                                                                               // Hidden Seal
		{ EffectTypes.Extra_Harpy_Newcommers, "Extra Harpy Newcommers" },                                                                                       // Harpy Friendship
		{ EffectTypes.Extra_Human_Newcommers, "Extra Human Newcommers" },                                                                                       // Human Friendship
		{ EffectTypes.Extra_Lizard_Newcommers, "Extra Lizard Newcommers" },                                                                                     // Lizard Friendship
		{ EffectTypes.Extra_Prod_For_Consumption, "Extra Prod for consumption" },                                                                               // Worker's Rations
		{ EffectTypes.Extra_Production_For_Corruption_Points, "Extra Production For Corruption Points" },                                                       // Forbidden Seal Shard (Stormforged)
		{ EffectTypes.Extra_Production_For_Relics_Resolved, "Extra Production For Relics Resolved" },                                                           // Ancient Practices
		{ EffectTypes.Extra_Trader_Merch, "Extra Trader Merch" },                                                                                               // Guild Catalogue
		{ EffectTypes.Extreme_Noise_In_Crude_Workstation, "Extreme Noise in Crude Workstation" }, 
		{ EffectTypes.Fabric_10, "Fabric 10" },                                                                                                                 // Bundle of Fabric
		{ EffectTypes.Fabric_15, "Fabric 15" },                                                                                                                 // Bundle of Fabric
		{ EffectTypes.Fabric_2, "Fabric 2" },                                                                                                                   // Bundle of Fabric
		{ EffectTypes.Fabric_20, "Fabric 20" },                                                                                                                 // Bundle of Fabric
		{ EffectTypes.Fabric_30, "Fabric 30" },                                                                                                                 // Bundle of Fabric
		{ EffectTypes.Fabric_4, "Fabric 4" },                                                                                                                   // Bundle of Fabric
		{ EffectTypes.Fabric_40, "Fabric 40" },                                                                                                                 // Bundle of Fabric
		{ EffectTypes.Fabric_5, "Fabric 5" },                                                                                                                   // Bundle of Fabric
		{ EffectTypes.Fabric_Or_Coat_Speed_Plus5, "Fabric or Coat Speed +5" }, 
		{ EffectTypes.Fabric_Plus1, "Fabric +1" },                                                                                                              // Reinforced Needles
		{ EffectTypes.Fabric_Plus2, "Fabric +2" },                                                                                                              // Reinforced Needles
		{ EffectTypes.Fabric_Plus3, "Fabric +3" },                                                                                                              // Reinforced Needles
		{ EffectTypes.Fabric_Plus5, "Fabric +5" },                                                                                                              // Reinforced Needles
		{ EffectTypes.FallenViceroyCommemoration_Beaver_Housing, "FallenViceroyCommemoration Beaver Housing" },                                                 // Fallen Viceroy Commemoration
		{ EffectTypes.FallenViceroyCommemoration_Foxes_Housing, "FallenViceroyCommemoration Foxes Housing" },                                                   // Fallen Viceroy Commemoration
		{ EffectTypes.FallenViceroyCommemoration_Harpy_Housing, "FallenViceroyCommemoration Harpy Housing" },                                                   // Fallen Viceroy Commemoration
		{ EffectTypes.FallenViceroyCommemoration_Humans_Housing, "FallenViceroyCommemoration Humans Housing" },                                                 // Fallen Viceroy Commemoration
		{ EffectTypes.FallenViceroyCommemoration_Lizards_Housing, "FallenViceroyCommemoration Lizards Housing" },                                               // Fallen Viceroy Commemoration
		{ EffectTypes.Families_Gratitude, "Families Gratitude" },                                                                                               // Family Gratitude
		{ EffectTypes.Farm__50, "Farm -50" },                                                                                                                   // Reinforced Tools
		{ EffectTypes.Farm_Blueprint, "Farm Blueprint" },                                                                                                       // Homestead
		{ EffectTypes.Farm_Plus100, "Farm +100" },                                                                                                              // Obsidian Tools
		{ EffectTypes.Farm_Plus150, "Farm +150" },                                                                                                              // Obsidian Tools
		{ EffectTypes.Farm_Plus50, "Farm +50" },                                                                                                                // Obsidian Tools
		{ EffectTypes.Farmer_Plus10, "Farmer +10" },                                                                                                            // Farmer's Pack
		{ EffectTypes.Farmer_Plus15, "Farmer +15" },                                                                                                            // Farmer's Pack
		{ EffectTypes.Farmer_Plus5, "Farmer +5" },                                                                                                              // Farmer's Pack
		{ EffectTypes.Farming__25_For_Wood_Plus1, "Farming -25 for Wood +1" },                                                                                  // Rooty Ground
		{ EffectTypes.Faster_Event_Working_Time_For_Death, "Faster Event Working Time for death" },                                                             // Haste Makes Waste
		{ EffectTypes.Faster_Woodcutters, "Faster Woodcutters" },                                                                                               // Specialized Boots
		{ EffectTypes.Fear_Of_The_Wilds_T1___Hard, "Fear of the Wilds T1 - hard" },                                                                             // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T1___Impossible, "Fear of the Wilds T1 - impossible" },                                                                 // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T1___Normal, "Fear of the Wilds T1 - normal" },                                                                         // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T1___Very_Hard, "Fear of the Wilds T1 - very hard" },                                                                   // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T2___Hard, "Fear of the Wilds T2 - hard" },                                                                             // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T2___Impossible, "Fear of the Wilds T2 - impossible" },                                                                 // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T2___Normal, "Fear of the Wilds T2 - normal" },                                                                         // Fear of the Wilds
		{ EffectTypes.Fear_Of_The_Wilds_T2___Very_Hard, "Fear of the Wilds T2 - very hard" },                                                                   // Fear of the Wilds
		{ EffectTypes.Fedora_Hat, "Fedora Hat" },                                                                                                               // Old Fedora Hat
		{ EffectTypes.Fiber_10pm, "Fiber 10pm" },                                                                                                               // Fiber Delivery Line
		{ EffectTypes.Fiber_15pm, "Fiber 15pm" },                                                                                                               // Fiber Delivery Line
		{ EffectTypes.Fiber_3pm, "Fiber 3pm" },                                                                                                                 // Fiber Delivery Line
		{ EffectTypes.Fiber_5pm, "Fiber 5pm" },                                                                                                                 // Fiber Delivery Line
		{ EffectTypes.Fiber_For_Vegetables, "Fiber for Vegetables" },                                                                                           // Pocket Knives
		{ EffectTypes.Finesmith_Blueprint, "Finesmith Blueprint" },                                                                                             // Finesmith
		{ EffectTypes.Fishmen_Higher_Negative_Mysteries, "Fishmen Higher Negative Mysteries" },                                                                 // Invoker
		{ EffectTypes.Fishmen_Lower_Negative_Mysteries, "Fishmen Lower Negative Mysteries" },                                                                   // Airbender
		{ EffectTypes.Fishmen_Resolve, "Fishmen Resolve" },                                                                                                     // Creeping Fishmen
		{ EffectTypes.Fishmen_Soothsayer_Curse_BloodFlower, "Fishmen Soothsayer Curse BloodFlower" },                                                           // Rain Sorcery
		{ EffectTypes.Fishmen_Soothsayer_Curse_Hostility, "Fishmen Soothsayer Curse Hostility" },                                                               // Blood Sorcery
		{ EffectTypes.Fishmens_Traps, "Fishmen's Traps" },                                                                                                      // Fishmen Traps
		{ EffectTypes.Flooding_Remove_Roads, "Flooding Remove Roads" },                                                                                         // Flooding
		{ EffectTypes.Flour_10, "Flour 10" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_20, "Flour 20" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_25, "Flour 25" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_30, "Flour 30" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_35, "Flour 35" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_3pm, "Flour 3pm" },                                                                                                                 // Flour Delivery Line
		{ EffectTypes.Flour_40, "Flour 40" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_45, "Flour 45" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_50, "Flour 50" },                                                                                                                   // Sacks of Flour
		{ EffectTypes.Flour_5pm, "Flour 5pm" },                                                                                                                 // Flour Delivery Line
		{ EffectTypes.Flour_Plus1, "Flour +1" },                                                                                                                // Heavy Millstone
		{ EffectTypes.Flour_Plus2, "Flour +2" },                                                                                                                // Heavy Millstone
		{ EffectTypes.Flour_Plus3, "Flour +3" },                                                                                                                // Heavy Millstone
		{ EffectTypes.Flour_Plus5, "Flour +5" },                                                                                                                // Heavy Millstone
		{ EffectTypes.Food_Prod_Speed_Plus10, "Food prod speed +10" },                                                                                          // Cooking Steam
		{ EffectTypes.Food_Production_For_Engines, "Food Production For Engines" },                                                                             // Cooking Steam
		{ EffectTypes.Food_Production_Speed__60, "Food Production Speed -60" },                                                                                 // Contaminated Food
		{ EffectTypes.Food_Production_Speed__70, "Food Production Speed -70" },                                                                                 // Contaminated Food
		{ EffectTypes.Food_Production_Speed__80, "Food Production Speed -80" },                                                                                 // Contaminated Food
		{ EffectTypes.Food_Production_Speed__90, "Food Production Speed -90" },                                                                                 // Contaminated Food
		{ EffectTypes.Food_Production_Speed_Plus20, "Food Production Speed +20" },                                                                              // Viceroy's Survival Guide
		{ EffectTypes.Food_Production_Speed_Plus33, "Food Production Speed +33" },                                                                              // Viceroy's Survival Guide
		{ EffectTypes.Food_Production_Speed_Plus50, "Food Production Speed +50" },                                                                              // Viceroy's Survival Guide
		{ EffectTypes.Food_Stockpiles_1, "Food Stockpiles 1" },                                                                                                 // Food Stockpiles
		{ EffectTypes.Food_Stockpiles_10, "Food Stockpiles 10" },                                                                                               // Food Stockpiles
		{ EffectTypes.Food_Stockpiles_2, "Food Stockpiles 2" },                                                                                                 // Food Stockpiles
		{ EffectTypes.Food_Stockpiles_3, "Food Stockpiles 3" },                                                                                                 // Food Stockpiles
		{ EffectTypes.Food_Stockpiles_4, "Food Stockpiles 4" },                                                                                                 // Food Stockpiles
		{ EffectTypes.Food_Stockpiles_5, "Food Stockpiles 5" },                                                                                                 // Food Stockpiles
		{ EffectTypes.Foragers_Camp_Blueprint, "Forager's Camp Blueprint" },                                                                                    // Foragers' Camp
		{ EffectTypes.Foragers_Camp_Plus100, "Foragers Camp +100" },                                                                                            // Reinforced Tools
		{ EffectTypes.Foragers_Camp_Plus50, "Foragers Camp +50" },                                                                                              // Reinforced Tools
		{ EffectTypes.Foragers_Camp_Plus50_Composite, "Foragers Camp +50 Composite" },                                                                          // Termite Infestation
		{ EffectTypes.Foragers_Camp_Primitive_Plus50, "Foragers Camp Primitive +50" },                                                                          // Reinforced Tools
		{ EffectTypes.Forbidden_For_Hostility, "Forbidden for Hostility" },                                                                                     // Secure Perimeter
		{ EffectTypes.Forbidden_For_Hostility___Lower_Glades___Dangerous, "Forbidden for Hostility - Lower Glades - Dangerous" }, 
		{ EffectTypes.Forbidden_For_Hostility___Lower_Glades___Small, "Forbidden for Hostility - Lower Glades - Small" }, 
		{ EffectTypes.Forbidden_For_Hostility_NEW, "Forbidden for Hostility NEW" },                                                                             // Secure Perimeter
		{ EffectTypes.Forced_Improvisation, "Forced Improvisation" }, 
		{ EffectTypes.Forge_Trip_Hammer, "Forge Trip Hammer" },                                                                                                 // Forge Trip Hammer
		{ EffectTypes.Forsaken_Crypt_Resolve_Penalty___Hard, "Forsaken Crypt Resolve Penalty - hard" },                                                         // Robbed Dead
		{ EffectTypes.Forsaken_Crypt_Resolve_Penalty___Impossible, "Forsaken Crypt Resolve Penalty - impossible" },                                             // Robbed Dead
		{ EffectTypes.Forsaken_Crypt_Resolve_Penalty___Normal, "Forsaken Crypt Resolve Penalty - normal" },                                                     // Robbed Dead
		{ EffectTypes.Forsaken_Crypt_Resolve_Penalty___Very_Hard, "Forsaken Crypt Resolve Penalty - very hard" },                                               // Robbed Dead
		{ EffectTypes.Forum_Blueprint, "Forum Blueprint" },                                                                                                     // Forum
		{ EffectTypes.Foul_Taste, "Foul Taste" },                                                                                                               // Foul Taste
		{ EffectTypes.Fox_Faction_Support, "Fox Faction Support" },                                                                                             // Fox Pack Support
		{ EffectTypes.Fox_Hostility_Hearth_Bonus, "Fox Hostility Hearth Bonus" },                                                                               // Forest Affinity
		{ EffectTypes.Foxes_1, "Foxes 1" },                                                                                                                     // Fox
		{ EffectTypes.Foxes_2, "Foxes 2" },                                                                                                                     // Group of Foxes
		{ EffectTypes.Foxes_3, "Foxes 3" },                                                                                                                     // Group of Foxes
		{ EffectTypes.Foxes_4, "Foxes 4" },                                                                                                                     // Group of Foxes
		{ EffectTypes.Foxes_5, "Foxes 5" },                                                                                                                     // Group of Foxes
		{ EffectTypes.Foxes_Killed_3___Missiles, "Foxes Killed 3 - Missiles" },                                                                                 // Blood for Blood
		{ EffectTypes.Friend_Or_Foe, "Friend or Foe" },                                                                                                         // Friend or Foe
		{ EffectTypes.Frightening_Visions_Resolve_Penalty, "Frightening Visions Resolve Penalty" },                                                             // Frightening Visions
		{ EffectTypes.Fuel_Recipes_Rate_33, "Fuel Recipes Rate 33" },                                                                                           // Advanced Fuel
		{ EffectTypes.Fuel_Recipes_Rate_50, "Fuel Recipes Rate 50" },                                                                                           // Advanced Fuel
		{ EffectTypes.Fuel_Recipes_Rate_66, "Fuel Recipes Rate 66" },                                                                                           // Advanced Fuel
		{ EffectTypes.FuelConsumption__20, "FuelConsumption -20" },                                                                                             // Secret Techniques of the Firekeeper
		{ EffectTypes.FuelConsumption__25, "FuelConsumption -25" },                                                                                             // Secret Techniques of the Firekeeper
		{ EffectTypes.FuelConsumption__33, "FuelConsumption -33" },                                                                                             // Secret Techniques of the Firekeeper
		{ EffectTypes.FuelConsumption_200, "FuelConsumption 200" }, 
		{ EffectTypes.FuelConsumption_HearthEffect_Beaver, "FuelConsumption_HearthEffect_Beaver" },                                                             // Pragmatic Frugality
		{ EffectTypes.FuelConsumption_Plus150_Wildfire, "FuelConsumption +150 Wildfire" },                                                                      // Wildfire Presence
		{ EffectTypes.FuelConsumption_Plus200_Wildfire, "FuelConsumption +200 Wildfire" },                                                                      // Wildfire Presence
		{ EffectTypes.FuelConsumption_Plus250_Wildfire, "FuelConsumption +250 Wildfire" },                                                                      // Wildfire Presence
		{ EffectTypes.FuelConsumption_Plus300_Wildfire, "FuelConsumption +300 Wildfire" },                                                                      // Wildfire Presence
		{ EffectTypes.FuelConsumption_Plus33, "FuelConsumption +33" },                                                                                          // Fickle Flame
		{ EffectTypes.Furnace_Blueprint, "Furnace Blueprint" },                                                                                                 // Furnace
		{ EffectTypes.Gatherers_Prod_Plus50, "Gatherers Prod +50" },                                                                                            // Ancient Ways
		{ EffectTypes.Gathering_Speed_Plus30, "Gathering Speed +30" }, 
		{ EffectTypes.Gathering_Speed_Plus5, "Gathering Speed +5" }, 
		{ EffectTypes.Generic_Glade_Info, "Generic Glade Info" }, 
		{ EffectTypes.Generous_Rations, "Generous Rations" },                                                                                                   // Generous Rations
		{ EffectTypes.Ghost_Amber_Tablets_Lost, "Ghost Amber Tablets Lost" },                                                                                   // Scarlet Tears
		{ EffectTypes.Ghost_Complex_Food_Lost, "Ghost Complex Food Lost" },                                                                                     // Scarlet Tears
		{ EffectTypes.Ghost_Fuel_Lost, "Ghost Fuel Lost" },                                                                                                     // Scarlet Tears
		{ EffectTypes.Ghost_Needs_Lost, "Ghost Needs Lost" },                                                                                                   // Scarlet Tears
		{ EffectTypes.Ghost_Parts_Lost, "Ghost Parts Lost" },                                                                                                   // Scarlet Tears
		{ EffectTypes.Ghost_Raw_Food_Lost, "Ghost Raw Food Lost" },                                                                                             // Scarlet Tears
		{ EffectTypes.Ghost_Remove_Self, "Ghost Remove Self" },                                                                                                 // Vanishing
		{ EffectTypes.Ghost_Tools_Lost, "Ghost Tools Lost" },                                                                                                   // Scarlet Tears
		{ EffectTypes.Global_Capacity_10, "Global Capacity 10" }, 
		{ EffectTypes.Global_Capacity_3, "Global Capacity 3" }, 
		{ EffectTypes.Global_Capacity_5, "Global Capacity 5" }, 
		{ EffectTypes.Global_Chance_Of_Death, "Global Chance of Death" },                                                                                       // Overtime
		{ EffectTypes.Global_Extra_Prod_Plus10, "Global Extra Prod +10" }, 
		{ EffectTypes.Global_Extra_Prod_Plus15, "Global Extra Prod +15" }, 
		{ EffectTypes.Global_Extra_Prod_Plus20, "Global Extra Prod +20" }, 
		{ EffectTypes.Global_Extra_Prod_Plus25, "Global Extra Prod +25" }, 
		{ EffectTypes.Global_Extra_Prod_Plus30, "Global Extra Prod +30" }, 
		{ EffectTypes.Global_Extra_Prod_Plus33, "Global Extra Prod +33" }, 
		{ EffectTypes.Global_Extra_Prod_Plus5, "Global Extra Prod +5" }, 
		{ EffectTypes.Global_Prod_Speed__50_plague_, "Global Prod Speed -50 (plague)" },                                                                        // Plague of Mosquitoes
		{ EffectTypes.Global_Production_Faster_10, "Global Production Faster 10" }, 
		{ EffectTypes.Global_Production_Faster_15, "Global Production Faster 15" }, 
		{ EffectTypes.Global_Production_Faster_20, "Global Production Faster 20" }, 
		{ EffectTypes.Global_Production_Faster_25, "Global Production Faster 25" }, 
		{ EffectTypes.Global_Production_Faster_30, "Global Production Faster 30" }, 
		{ EffectTypes.Global_Production_Faster_33, "Global Production Faster 33" }, 
		{ EffectTypes.Global_Production_Faster_40, "Global Production Faster 40" }, 
		{ EffectTypes.Global_Production_Faster_5, "Global Production Faster 5" }, 
		{ EffectTypes.Global_Production_Faster_50, "Global Production Faster 50" }, 
		{ EffectTypes.GlobalResolve_HearthEffect_Lizard, "GlobalResolve_HearthEffect_Lizard" },                                                                 // Sacred Pyre
		{ EffectTypes.Glow_Oil_10, "Glow Oil 10" },                                                                                                             // Oil Vessels
		{ EffectTypes.Glow_Oil_15, "Glow Oil 15" },                                                                                                             // Oil Vessels
		{ EffectTypes.Glow_Oil_20, "Glow Oil 20" },                                                                                                             // Oil Vessels
		{ EffectTypes.Glow_Oil_3, "Glow Oil 3" },                                                                                                               // Oil Vessels
		{ EffectTypes.Glow_Oil_30, "Glow Oil 30" },                                                                                                             // Oil Vessels
		{ EffectTypes.Glow_Oil_40, "Glow Oil 40" },                                                                                                             // Oil Vessels
		{ EffectTypes.Gold_Stag_Reward_Catch, "Gold Stag Reward Catch" },                                                                                       // Cursed Treasure
		{ EffectTypes.Gold_Stag_Reward_Chase, "Gold Stag Reward Chase" },                                                                                       // Into the Mists
		{ EffectTypes.Gold_Stag_Reward_Release, "Gold Stag Reward Release" },                                                                                   // Gift of Gratitude
		{ EffectTypes.Grain_10pm, "Grain 10pm" },                                                                                                               // Grain Delivery Line
		{ EffectTypes.Grain_15, "Grain 15" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_15pm, "Grain 15pm" },                                                                                                               // Grain Delivery Line
		{ EffectTypes.Grain_20, "Grain 20" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_30, "Grain 30" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_3pm, "Grain 3pm" },                                                                                                                 // Grain Delivery Line
		{ EffectTypes.Grain_40, "Grain 40" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_50, "Grain 50" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_5pm, "Grain 5pm" },                                                                                                                 // Grain Delivery Line
		{ EffectTypes.Grain_60, "Grain 60" },                                                                                                                   // Box of Grain
		{ EffectTypes.Grain_Plus1, "Grain +1" },                                                                                                                // Mold Supply
		{ EffectTypes.Grain_Plus2, "Grain +2" },                                                                                                                // Mold Supply
		{ EffectTypes.Grain_Plus3, "Grain +3" },                                                                                                                // Mold Supply
		{ EffectTypes.Grain_Plus5, "Grain +5" },                                                                                                                // Mold Supply
		{ EffectTypes.Grain_Specialization, "Grain Specialization" },                                                                                           // Grain Bags
		{ EffectTypes.Granary_Blueprint, "Granary Blueprint" },                                                                                                 // Granary
		{ EffectTypes.Greenhouse__50, "Greenhouse -50" },                                                                                                       // Reinforced Tools
		{ EffectTypes.Greenhouse_Blueprint, "Greenhouse Blueprint" },                                                                                           // Greenhouse
		{ EffectTypes.Greenhouse_Plus100, "Greenhouse +100" }, 
		{ EffectTypes.Greenhouse_Plus150, "Greenhouse +150" }, 
		{ EffectTypes.Greenhouse_Plus50, "Greenhouse +50" },                                                                                                    // Reinforced Tools
		{ EffectTypes.Grill_Blueprint, "Grill Blueprint" },                                                                                                     // Grill
		{ EffectTypes.Grove__50, "Grove -50" },                                                                                                                 // Reinforced Tools
		{ EffectTypes.Grove_Blueprint, "Grove Blueprint" },                                                                                                     // Forester's Hut
		{ EffectTypes.Grove_Plus100, "Grove +100" }, 
		{ EffectTypes.Grove_Plus150, "Grove +150" }, 
		{ EffectTypes.Grove_Plus50, "Grove +50" },                                                                                                              // Industrialized Agriculture
		{ EffectTypes.Growth_Medium_Cysts_For_Food_, "Growth Medium (Cysts for Food)" },                                                                        // Growth Medium
		{ EffectTypes.Guild_House_Blueprint, "Guild House Blueprint" },                                                                                         // Guild House
		{ EffectTypes.Half_Reputation_From_Orders, "Half Reputation From Orders" }, 
		{ EffectTypes.Harmony_Altar_Resolve, "Harmony Altar Resolve" },                                                                                         // Harmony
		{ EffectTypes.Harpies_Killed_3___Missiles, "Harpies Killed 3 - Missiles" },                                                                             // Blood for Blood
		{ EffectTypes.Harpy_1, "Harpy 1" },                                                                                                                     // Harpy
		{ EffectTypes.Harpy_2, "Harpy 2" },                                                                                                                     // Group of Harpies
		{ EffectTypes.Harpy_3, "Harpy 3" },                                                                                                                     // Group of Harpies
		{ EffectTypes.Harpy_4, "Harpy 4" },                                                                                                                     // Group of Harpies
		{ EffectTypes.Harpy_5, "Harpy 5" },                                                                                                                     // Group of Harpies
		{ EffectTypes.Harpy_Faction_Support, "Harpy Faction Support" },                                                                                         // Harpy Clan Support
		{ EffectTypes.Harpy_Global_Capacity, "Harpy Global Capacity" },                                                                                         // Light as a Feather
		{ EffectTypes.Harpy_Resolve_For_Tea_Prod, "Harpy Resolve for Tea Prod" },                                                                               // Tea Specialization
		{ EffectTypes.Harpy_Stormbird_Resolve, "Harpy Stormbird Resolve" },                                                                                     // Unique Ally
		{ EffectTypes.Harvester_Camp_Plus100, "Harvester Camp +100" },                                                                                          // Reinforced Tools
		{ EffectTypes.Harvester_Camp_Plus50, "Harvester Camp +50" },                                                                                            // Reinforced Tools
		{ EffectTypes.HarvestingRate__25, "HarvestingRate -25" },                                                                                               // Slow Harvest
		{ EffectTypes.HarvestingRate__50, "HarvestingRate -50" },                                                                                               // Slow Harvest
		{ EffectTypes.HarvestingRate__60, "HarvestingRate -60" },                                                                                               // Slow Harvest
		{ EffectTypes.HarvestingRate__70, "HarvestingRate -70" },                                                                                               // Slow Harvest
		{ EffectTypes.HarvestingRate__80, "HarvestingRate -80" },                                                                                               // Slow Harvest
		{ EffectTypes.HarvestingRate_Plus100, "HarvestingRate +100" },                                                                                          // Quick Harvest
		{ EffectTypes.HarvestingRate_Plus25, "HarvestingRate +25" },                                                                                            // Obsidian Sickles
		{ EffectTypes.HarvestingRate_Plus30, "HarvestingRate +30" },                                                                                            // Obsidian Sickles
		{ EffectTypes.HarvestingRate_Plus5, "HarvestingRate +5" },                                                                                              // Obsidian Sickles
		{ EffectTypes.HarvestingRate_Plus50, "HarvestingRate +50" },                                                                                            // Quick Harvest
		{ EffectTypes.Hauler_Break_Interval, "Hauler Break Interval" },                                                                                         // Travel Rations
		{ EffectTypes.Hauler_Break_Interval___Main_Storage, "Hauler Break Interval - main storage" },                                                           // Travel Rations
		{ EffectTypes.Hauler_Break_Interval___Small_Storage, "Hauler Break Interval - small storage" },                                                         // Travel Rations
		{ EffectTypes.Hauler_Plus5, "Hauler +5" },                                                                                                              // Safety Ropes
		{ EffectTypes.Hauler_Speed, "Hauler Speed" },                                                                                                           // Specialized Workwear
		{ EffectTypes.Hauler_Speed___Main_Storage, "Hauler Speed - main storage" },                                                                             // Specialized Workwear
		{ EffectTypes.Hauler_Speed___Small_Storage, "Hauler Speed - small storage" },                                                                           // Specialized Workwear
		{ EffectTypes.Hauling_Cart_In_All_Warehouses, "Hauling Cart in All Warehouses" },                                                                       // Hauling Cart
		{ EffectTypes.Hauling_Cart_In_All_Warehouses___Main, "Hauling Cart in All Warehouses - main" },                                                         // Hauling Cart
		{ EffectTypes.Hauling_Cart_In_All_Warehouses___Small, "Hauling Cart in All Warehouses - small" },                                                       // Hauling Cart
		{ EffectTypes.Hearth_Bonus_HP_Plus100, "Hearth Bonus HP +100" },                                                                                        // Ancient Stabilizer
		{ EffectTypes.Hearth_Bonus_HP_Plus150, "Hearth Bonus HP +150" }, 
		{ EffectTypes.Hearth_Bonus_HP_Plus250, "Hearth Bonus HP +250" }, 
		{ EffectTypes.Hearth_Bonus_HP_Plus50, "Hearth Bonus HP +50" }, 
		{ EffectTypes.Hearth_Corruption_Rate__10, "Hearth Corruption Rate -10" },                                                                               // Firekeeper's Armor
		{ EffectTypes.Hearth_Corruption_Rate_Plus30, "Hearth Corruption Rate +30" }, 
		{ EffectTypes.Hearth_Corruption_Rate_Plus50, "Hearth Corruption Rate +50" },                                                                            // Straight to the Hearth
		{ EffectTypes.Hearth_High_Hostility_Reduction, "[Hearth] High Hostility Reduction" },                                                                   // Sacrifice Coal
		{ EffectTypes.Hearth_HP_500___HP_Bonus, "Hearth HP 500 - HP Bonus" },                                                                                   // Obsidian Runestone
		{ EffectTypes.Hearth_Less_HP__100, "Hearth Less HP -100" }, 
		{ EffectTypes.Hearth_Low_Hostility_Reduction, "[Hearth] Low Hostility Reduction" },                                                                     // Sacrifice Wood
		{ EffectTypes.Hearth_Parts_1, "Hearth Parts 1" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Parts_2, "Hearth Parts 2" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Parts_3, "Hearth Parts 3" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Parts_4, "Hearth Parts 4" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Parts_5, "Hearth Parts 5" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Parts_6, "Hearth Parts 6" },                                                                                                       // Wildfire Essence
		{ EffectTypes.Hearth_Production_Speed, "[Hearth] Production Speed" },                                                                                   // Sacrifice Oil
		{ EffectTypes.Hearth_Relic_Working_Time__20, "[Hearth] Relic Working Time -20" },                                                                       // Sacrifice Sea Marrow
		{ EffectTypes.Hearth_Sacrifice_Block, "Hearth Sacrifice Block" },                                                                                       // Ritual of Denial
		{ EffectTypes.Hearth_Sacrifice_Block___Baptism_Of_Fire, "Hearth Sacrifice Block - Baptism of Fire" },                                                   // Baptism of Fire
		{ EffectTypes.Hearth_Sacrifice_Block___Plague_Of_Darkness, "Hearth Sacrifice Block - Plague of Darkness" },                                             // Plague of Darkness
		{ EffectTypes.Herb_Garden__50, "Herb Garden -50" },                                                                                                     // Reinforced Tools
		{ EffectTypes.Herb_Garden__50_Haunted, "Herb Garden -50 Haunted" },                                                                                     // Reinforced Tools
		{ EffectTypes.Herb_Garden_Blueprint, "Herb Garden Blueprint" },                                                                                         // Herb Garden
		{ EffectTypes.Herb_Garden_Plus100, "Herb Garden +100" }, 
		{ EffectTypes.Herb_Garden_Plus100_Haunted, "Herb Garden +100 Haunted" }, 
		{ EffectTypes.Herb_Garden_Plus150, "Herb Garden +150" }, 
		{ EffectTypes.Herb_Garden_Plus150_Haunted, "Herb Garden +150 Haunted" }, 
		{ EffectTypes.Herb_Garden_Plus25, "Herb Garden +25" },                                                                                                  // Advanced Herbalism
		{ EffectTypes.Herb_Garden_Plus25_Composite_, "Herb Garden +25 (Composite)" },                                                                           // Advanced Herbalism
		{ EffectTypes.Herb_Garden_Plus25_Haunted, "Herb Garden +25 Haunted" },                                                                                  // Advanced Herbalism
		{ EffectTypes.Herb_Garden_Plus50, "Herb Garden +50" },                                                                                                  // Advanced Herbalism
		{ EffectTypes.Herb_Garden_Plus50_Composite_, "Herb Garden +50 (Composite)" },                                                                           // Advanced Herbalism
		{ EffectTypes.Herb_Garden_Plus50_Haunted, "Herb Garden +50 Haunted" },                                                                                  // Advanced Herbalism
		{ EffectTypes.Herb_Production_For_Biscuits, "Herb Production for Biscuits" },                                                                           // Spices
		{ EffectTypes.Herbalist_Camp_Blueprint, "Herbalist Camp Blueprint" },                                                                                   // Herbalists' Camp
		{ EffectTypes.Herbalist_Camp_Plus100, "Herbalist Camp +100" },                                                                                          // Reinforced Tools
		{ EffectTypes.Herbalist_Camp_Plus50, "Herbalist Camp +50" },                                                                                            // Reinforced Tools
		{ EffectTypes.Herbs_10, "Herbs 10" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_10pm, "Herbs 10pm" },                                                                                                               // Herb Delivery Line
		{ EffectTypes.Herbs_15, "Herbs 15" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_2pm, "Herbs 2pm" },                                                                                                                 // Herb Delivery Line
		{ EffectTypes.Herbs_30, "Herbs 30" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_40, "Herbs 40" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_5, "Herbs 5" },                                                                                                                     // Bundle of Herbs
		{ EffectTypes.Herbs_50, "Herbs 50" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_5pm, "Herbs 5pm" },                                                                                                                 // Herb Delivery Line
		{ EffectTypes.Herbs_60, "Herbs 60" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_70, "Herbs 70" },                                                                                                                   // Bundle of Herbs
		{ EffectTypes.Herbs_Plus1, "Herbs +1" },                                                                                                                // Sharp Sickles
		{ EffectTypes.Herbs_Plus2, "Herbs +2" },                                                                                                                // Sharp Sickles
		{ EffectTypes.Herbs_Plus3, "Herbs +3" },                                                                                                                // Sharp Sickles
		{ EffectTypes.Herbs_Plus5, "Herbs +5" },                                                                                                                // Sharp Sickles
		{ EffectTypes.Hidden_From_The_Queen, "Hidden From The Queen" },                                                                                         // Hidden from the Queen
		{ EffectTypes.Hidden_From_The_Queen___Impatience, "Hidden From The Queen - Impatience" }, 
		{ EffectTypes.Higher_Hostility_Glades___Dangerous, "Higher Hostility Glades - Dangerous" },                                                             // Dark Mist
		{ EffectTypes.Higher_New_Year, "Higher New Year" }, 
		{ EffectTypes.Higher_Villagers_Resilience_30, "Higher Villagers Resilience 30" }, 
		{ EffectTypes.Hostility__10, "Hostility -10" }, 
		{ EffectTypes.Hostility__15, "Hostility -15" }, 
		{ EffectTypes.Hostility__20, "Hostility -20" }, 
		{ EffectTypes.Hostility__25, "Hostility -25" }, 
		{ EffectTypes.Hostility__30, "Hostility -30" }, 
		{ EffectTypes.Hostility__35, "Hostility -35" }, 
		{ EffectTypes.Hostility__40, "Hostility -40" }, 
		{ EffectTypes.Hostility__5, "Hostility -5" }, 
		{ EffectTypes.Hostility__50, "Hostility -50" }, 
		{ EffectTypes.Hostility_1, "Hostility 1" }, 
		{ EffectTypes.Hostility_20, "Hostility 20" }, 
		{ EffectTypes.Hostility_For_Active_Routes, "Hostility for Active Routes" },                                                                             // Queen's Sailors
		{ EffectTypes.Hostility_For_Caches, "Hostility for Caches" },                                                                                           // Silent Looting
		{ EffectTypes.Hostility_For_Cysts, "Hostility for Cysts" }, 
		{ EffectTypes.Hostility_For_Dangerous_Relics, "Hostility for Dangerous Relics" },                                                                       // Calming the Forest
		{ EffectTypes.Hostility_For_Death, "Hostility for Death" },                                                                                             // Small Altar Box
		{ EffectTypes.Hostility_For_Firekeeper___Lighthouse___Strong, "Hostility for Firekeeper - Lighthouse - Strong" },                                       // Cold Flame
		{ EffectTypes.Hostility_For_Firekeeper___Lighthouse___Weak, "Hostility for Firekeeper - Lighthouse - Weak" },                                           // Lesser Cold Flame
		{ EffectTypes.Hostility_For_Relics, "Hostility for Relics" },                                                                                           // Frequent Patrols
		{ EffectTypes.Hostility_For_Removed_Cysts, "Hostility for Removed Cysts" },                                                                             // Baptism of Fire
		{ EffectTypes.Hostility_For_Sales, "Hostility for Sales" },                                                                                             // Protected Trade
		{ EffectTypes.Hostility_For_Tablets, "Hostility for Tablets" },                                                                                         // Decryption
		{ EffectTypes.Hostility_For_Trees___DarkGate___Hard, "Hostility for Trees - DarkGate - Hard" },                                                         // Disturbing the Dead
		{ EffectTypes.Hostility_For_Trees___DarkGate___Impossible, "Hostility for Trees - DarkGate - Impossible" },                                             // Disturbing the Dead
		{ EffectTypes.Hostility_For_Trees___DarkGate___Normal, "Hostility for Trees - DarkGate - Normal" },                                                     // Disturbing the Dead
		{ EffectTypes.Hostility_For_Trees___DarkGate___Very_Hard, "Hostility for Trees - DarkGate - Very Hard" },                                               // Disturbing the Dead
		{ EffectTypes.Hostility_For_Water, "Hostility for Water" },                                                                                             // Calming Water
		{ EffectTypes.Hostility_Lower_50, "Hostility Lower 50" },                                                                                               // Ways of the Forest
		{ EffectTypes.Hostility_Lower_75, "Hostility Lower 75" },                                                                                               // Ways of the Forest
		{ EffectTypes.Hostility_Penalty_For_Amber, "Hostility Penalty for Amber" },                                                                             // Blazing Amber
		{ EffectTypes.Hostility_Per_Cyst_Mole, "Hostility per Cyst Mole" },                                                                                     // Infestation
		{ EffectTypes.Hostility_Plus1, "Hostility +1" },                                                                                                        // Rage of the Forest
		{ EffectTypes.Hostility_Plus10, "Hostility +10" }, 
		{ EffectTypes.Hostility_Plus10___Fishmen, "Hostility +10 - Fishmen" }, 
		{ EffectTypes.Hostility_Plus100, "Hostility +100" }, 
		{ EffectTypes.Hostility_Plus110, "Hostility +110" }, 
		{ EffectTypes.Hostility_Plus15, "Hostility +15" }, 
		{ EffectTypes.Hostility_Plus2, "Hostility +2" },                                                                                                        // High Voltage
		{ EffectTypes.Hostility_Plus20, "Hostility +20" },                                                                                                      // Fishmen Totem
		{ EffectTypes.Hostility_Plus30, "Hostility +30" }, 
		{ EffectTypes.Hostility_Plus5, "Hostility +5" }, 
		{ EffectTypes.Hostility_Plus50, "Hostility +50" },                                                                                                      // Darkest Shadows
		{ EffectTypes.Hostility_Plus50___Fishmen, "Hostility +50 - Fishmen" }, 
		{ EffectTypes.Hostility_Plus50___Glade_Trader, "Hostility +50 - Glade Trader" },                                                                        // Enemy of the Forest
		{ EffectTypes.Hostility_Tree, "Hostility Tree" },                                                                                                       // Rage of the Forest
		{ EffectTypes.HostilityEachYear, "HostilityEachYear" }, 
		{ EffectTypes.Houses_Global_Capacity_Plus1, "Houses Global Capacity +1" },                                                                              // Crowded Houses
		{ EffectTypes.Houses_Plus1___Break_Time, "Houses +1 - break time" }, 
		{ EffectTypes.Houses_Plus1_For_Break_Time, "Houses +1 for Break Time" },                                                                                // Crowded Houses
		{ EffectTypes.HP_For_Impatience, "HP for Impatience" },                                                                                                 // Queen's Gift
		{ EffectTypes.Hub_Extra_Production_Chance, "[Hub] Extra Production Chance" },                                                                           // District (Level 3)
		{ EffectTypes.Hub_Extra_Production_Chance___Composite, "[Hub] Extra Production Chance - Composite" },                                                   // District (Level 3)
		{ EffectTypes.Hub_Production_Speed, "[Hub] Production Speed" },                                                                                         // Neighborhood (Level 2)
		{ EffectTypes.Hub_Production_Speed___Composite, "[Hub] Production Speed - Composite" },                                                                 // Neighborhood (Level 2)
		{ EffectTypes.Hub_Resolve___Composite, "[Hub] Resolve - Composite" },                                                                                   // Encampment (Level 1)
		{ EffectTypes.Hub_Resolve_T1, "[Hub] Resolve T1" },                                                                                                     // Encampment (Level 1)
		{ EffectTypes.Hub_Resolve_T2, "[Hub] Resolve T2" },                                                                                                     // Neighborhood (Level 2)
		{ EffectTypes.Hub_Resolve_T3, "[Hub] Resolve T3" },                                                                                                     // District (Level 3)
		{ EffectTypes.Hubs_For_Hostility, "Hubs for hostility" },                                                                                               // Safe Haven
		{ EffectTypes.Hubs_For_Newcomer_Goods, "Hubs for newcomer goods" },                                                                                     // Generous Gifts
		{ EffectTypes.Human_1, "Human 1" },                                                                                                                     // Human
		{ EffectTypes.Human_2, "Human 2" },                                                                                                                     // Group of Humans
		{ EffectTypes.Human_3, "Human 3" },                                                                                                                     // Group of Humans
		{ EffectTypes.Human_4, "Human 4" },                                                                                                                     // Group of Humans
		{ EffectTypes.Human_5, "Human 5" },                                                                                                                     // Group of Humans
		{ EffectTypes.Human_Faction_Support, "Human Faction Support" },                                                                                         // Human Clan Support
		{ EffectTypes.Human_House_Blueprint, "Human House Blueprint" },                                                                                         // Human House
		{ EffectTypes.Human_Resolve_For_Incense_Prod, "Human Resolve for Incense Prod" },                                                                       // Religious Settlement
		{ EffectTypes.Humans_Killed_3___Missiles, "Humans Killed 3 - Missiles" },                                                                               // Blood for Blood
		{ EffectTypes.HunterGatherers, "HunterGatherers" },                                                                                                     // Hunter-Gatherers
		{ EffectTypes.Hydrant_Blueprint, "Hydrant Blueprint" },                                                                                                 // Forsaken Altar
		{ EffectTypes.Impatience_For_Glade, "Impatience For Glade" },                                                                                           // Badge of Courage
		{ EffectTypes.Impatience_For_Glade___Child, "Impatience For Glade - child" }, 
		{ EffectTypes.Incantation, "Incantation" },                                                                                                             // Blight Incantation
		{ EffectTypes.Incantation_Cysts_Longer_Burning_10, "Incantation Cysts Longer Burning 10" }, 
		{ EffectTypes.Incense_12, "Incense 12" },                                                                                                               // Vessel of Incense
		{ EffectTypes.Incense_15, "Incense 15" },                                                                                                               // Vessel of Incense
		{ EffectTypes.Incense_25, "Incense 25" },                                                                                                               // Vessel of Incense
		{ EffectTypes.Incense_3, "Incense 3" },                                                                                                                 // Vessel of Incense
		{ EffectTypes.Incense_30, "Incense 30" },                                                                                                               // Vessel of Incense
		{ EffectTypes.Incense_3pm, "Incense 3pm" },                                                                                                             // Incense Delivery Line
		{ EffectTypes.Incense_40, "Incense 40" },                                                                                                               // Vessel of Incense
		{ EffectTypes.Incense_5, "Incense 5" },                                                                                                                 // Vessel of Incense
		{ EffectTypes.Incense_5pm, "Incense 5pm" },                                                                                                             // Incense Delivery Line
		{ EffectTypes.Incense_8, "Incense 8" },                                                                                                                 // Vessel of Incense
		{ EffectTypes.Incense_For_Roots, "Incense for Roots" },                                                                                                 // Fragrant Roots
		{ EffectTypes.Incense_Plus1, "Incense +1" },                                                                                                            // Vessel of Incense
		{ EffectTypes.Incense_Plus2, "Incense +2" },                                                                                                            // Vessel of Incense
		{ EffectTypes.Incense_Plus3, "Incense +3" },                                                                                                            // Vessel of Incense
		{ EffectTypes.Incense_Plus5, "Incense +5" },                                                                                                            // Vessel of Incense
		{ EffectTypes.Infected_Building_Production_For_Hostility, "Infected building production for hostility" },                                               // Blight Extractor
		{ EffectTypes.Ink_10, "Ink 10" },                                                                                                                       // Vials of Pigment
		{ EffectTypes.Ink_16, "Ink 16" },                                                                                                                       // Vials of Pigment
		{ EffectTypes.Ink_25, "Ink 25" },                                                                                                                       // Vials of Pigment
		{ EffectTypes.Ink_35, "Ink 35" },                                                                                                                       // Vials of Pigment
		{ EffectTypes.Ink_40, "Ink 40" },                                                                                                                       // Vials of Pigment
		{ EffectTypes.Ink_5, "Ink 5" },                                                                                                                         // Vials of Pigment
		{ EffectTypes.Ink_Plus1, "Ink +1" },                                                                                                                    // Big Phials
		{ EffectTypes.Ink_Plus2, "Ink +2" },                                                                                                                    // Big Phials
		{ EffectTypes.Ink_Plus3, "Ink +3" },                                                                                                                    // Big Phials
		{ EffectTypes.Ink_Plus5, "Ink +5" },                                                                                                                    // Big Phials
		{ EffectTypes.Insect_For_Tree, "Insect for tree" },                                                                                                     // Woodpecker Technique
		{ EffectTypes.Insect_For_Tree___Child, "Insect for tree - child" },                                                                                     // Woodpecker Technique
		{ EffectTypes.Insect_Traps, "Insect Traps" },                                                                                                           // Insect Traps
		{ EffectTypes.Insects_1, "Insects 1" },                                                                                                                 // An Insect
		{ EffectTypes.Insects_10, "Insects 10" },                                                                                                               // An Insect
		{ EffectTypes.Insects_150, "Insects 150" },                                                                                                             // Basket of Insects
		{ EffectTypes.Insects_2, "Insects 2" },                                                                                                                 // An Insect
		{ EffectTypes.Insects_20, "Insects 20" },                                                                                                               // An Insect
		{ EffectTypes.Insects_30, "Insects 30" },                                                                                                               // Basket of Insects
		{ EffectTypes.Insects_3pm, "Insects 3pm" },                                                                                                             // Termite Nest
		{ EffectTypes.Insects_40, "Insects 40" },                                                                                                               // Basket of Insects
		{ EffectTypes.Insects_5, "Insects 5" },                                                                                                                 // An Insect
		{ EffectTypes.Insects_50, "Insects 50" },                                                                                                               // Basket of Insects
		{ EffectTypes.Insects_5pm, "Insects 5pm" },                                                                                                             // Insect Delivery Line
		{ EffectTypes.Insects_5pm___Termite_Nest, "Insects 5pm - Termite Nest" },                                                                               // Termite Nest
		{ EffectTypes.Insects_Plus1, "Insects +1" },                                                                                                            // Insect Lure
		{ EffectTypes.Insects_Plus2, "Insects +2" },                                                                                                            // Insect Lure
		{ EffectTypes.Insects_Plus3, "Insects +3" },                                                                                                            // Insect Lure
		{ EffectTypes.Insects_Plus5, "Insects +5" },                                                                                                            // Insect Lure
		{ EffectTypes.Instant_Storm_Effect, "Instant Storm effect" },                                                                                           // Stormbird's Anger
		{ EffectTypes.Institution_Camps_Production, "Institution Camps Production" },                                                                           // Ancient Ways
		{ EffectTypes.Institution_Global_Capacity, "Institution Global Capacity" },                                                                             // Market Carts
		{ EffectTypes.Institution_Global_Extra_Production, "Institution Global Extra Production" },                                                             // Public Lectures
		{ EffectTypes.Institution_Global_Production_Rate, "Institution Global Production Rate" },                                                               // Good Health
		{ EffectTypes.Institution_Global_Resolve, "Institution Global Resolve" },                                                                               // Gleeman's Tales
		{ EffectTypes.Institution_Lower_Hostility, "Institution Lower Hostility" },                                                                             // The Green Brew
		{ EffectTypes.Institution_Resolve_For_Ruins, "Institution Resolve For Ruins" },                                                                         // The Crown Chronicles
		{ EffectTypes.Institution_Resolve_For_Sales, "Institution Resolve For Sales" },                                                                         // The Guild's Welfare
		{ EffectTypes.Institution_Slower_Burn_Rate, "Institution Slower Burn Rate" }, 
		{ EffectTypes.Institution_Slower_Leaving, "Institution Slower Leaving" },                                                                               // Regular Baths
		{ EffectTypes.Institution_Slower_Sacrafice, "Institution Slower Sacrafice" }, 
		{ EffectTypes.Institution_Temple_Burn_Rate, "Institution Temple Burn Rate" },                                                                           // Sacrament of the Flame
		{ EffectTypes.Institution_Temple_Hostility_For_Sacrifice, "Institution Temple Hostility for Sacrifice" },                                               // Sacrament of the Flame
		{ EffectTypes.Institution_Trader_Interval_Plus50, "Institution Trader Interval +50" },                                                                  // Guild House
		{ EffectTypes.Jerky_10, "Jerky 10" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_15, "Jerky 15" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_20, "Jerky 20" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_25, "Jerky 25" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_30, "Jerky 30" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_3pm, "Jerky 3pm" },                                                                                                                 // Jerky Delivery Line
		{ EffectTypes.Jerky_40, "Jerky 40" },                                                                                                                   // Basket of Jerky
		{ EffectTypes.Jerky_5, "Jerky 5" },                                                                                                                     // Basket of Jerky
		{ EffectTypes.Jerky_5pm, "Jerky 5pm" },                                                                                                                 // Jerky Delivery Line
		{ EffectTypes.Jerky_Plus1, "Jerky +1" },                                                                                                                // Salted Jerky
		{ EffectTypes.Jerky_Plus2, "Jerky +2" },                                                                                                                // Salted Jerky
		{ EffectTypes.Jerky_Plus3, "Jerky +3" },                                                                                                                // Salted Jerky
		{ EffectTypes.Jerky_Plus5, "Jerky +5" },                                                                                                                // Salted Jerky
		{ EffectTypes.Kelpie_Charm, "Kelpie Charm" },                                                                                                           // Kelpie's Charm
		{ EffectTypes.Killed_For_GladeInfo, "Killed for GladeInfo" },                                                                                           // Ancient Pact
		{ EffectTypes.Killed_For_Water, "Killed for Water" },                                                                                                   // Ancient Pact
		{ EffectTypes.Killed_Scout, "Killed Scout" }, 
		{ EffectTypes.Kiln_Blueprint, "Kiln Blueprint" },                                                                                                       // Kiln
		{ EffectTypes.Land_Of_Greed___ReputationPenaltyRateMinus20, "Land of Greed - ReputationPenaltyRateMinus20" }, 
		{ EffectTypes.Land_Of_Greed___ReputationPenaltyRatePlus50, "Land of Greed - ReputationPenaltyRatePlus50" }, 
		{ EffectTypes.Leather_10, "Leather 10" },                                                                                                               // Bundle of Leather
		{ EffectTypes.Leather_10pm, "Leather 10pm" },                                                                                                           // Leather Delivery Line
		{ EffectTypes.Leather_20, "Leather 20" },                                                                                                               // Bundle of Leather
		{ EffectTypes.Leather_30, "Leather 30" },                                                                                                               // Bundle of Leather
		{ EffectTypes.Leather_40, "Leather 40" },                                                                                                               // Bundle of Leather
		{ EffectTypes.Leather_5, "Leather 5" },                                                                                                                 // Bundle of Leather
		{ EffectTypes.Leather_5pm, "Leather 5pm" },                                                                                                             // Leather Delivery Line
		{ EffectTypes.Leather_Plus1, "Leather +1" },                                                                                                            // Tanning Racks
		{ EffectTypes.Leather_Plus2, "Leather +2" },                                                                                                            // Tanning Racks
		{ EffectTypes.Leather_Plus3, "Leather +3" },                                                                                                            // Tanning Racks
		{ EffectTypes.Leather_Plus5, "Leather +5" },                                                                                                            // Tanning Racks
		{ EffectTypes.Leatherworks_Blueprint, "Leatherworks Blueprint" },                                                                                       // Leatherworker
		{ EffectTypes.Less_Resolve_From_Biscuits, "Less Resolve from Biscuits" }, 
		{ EffectTypes.Less_Resolve_From_Jerky, "Less Resolve from Jerky" }, 
		{ EffectTypes.Less_Resolve_From_Pickled_Goods, "Less Resolve from Pickled Goods" }, 
		{ EffectTypes.Less_Resolve_From_Pie, "Less Resolve from Pie" }, 
		{ EffectTypes.Less_Resolve_From_Porridge, "Less Resolve from Porridge" }, 
		{ EffectTypes.Less_Resolve_From_Skewers, "Less Resolve from Skewers" }, 
		{ EffectTypes.Less_Trader_Merch, "Less Trader Merch" }, 
		{ EffectTypes.LessHostilityPerMiner__Proficiency_1, "LessHostilityPerMiner- Proficiency 1" },                                                           // Flame Amulets
		{ EffectTypes.LessHostilityPerWoodcutter, "LessHostilityPerWoodcutter" },                                                                               // Flame Amulets
		{ EffectTypes.LessHostilityPerWoodcutter___Proficiency, "LessHostilityPerWoodcutter - Proficiency" },                                                   // Flame Amulets
		{ EffectTypes.LessHostilityPerWoodcutter_8, "LessHostilityPerWoodcutter 8" },                                                                           // Flame Amulets
		{ EffectTypes.LessNewNewcomers_Random, "LessNewNewcomers_Random" },                                                                                     // Hunting Ground
		{ EffectTypes.Library_Blueprint, "Library Blueprint" },                                                                                                 // Library
		{ EffectTypes.Lighthouse_Scouts_Curse, "Lighthouse Scouts Curse" },                                                                                     // Mesmerizing Light
		{ EffectTypes.Lizard_1, "Lizard 1" },                                                                                                                   // Lizard
		{ EffectTypes.Lizard_2, "Lizard 2" },                                                                                                                   // Group of Lizards
		{ EffectTypes.Lizard_3, "Lizard 3" },                                                                                                                   // Group of Lizards
		{ EffectTypes.Lizard_4, "Lizard 4" },                                                                                                                   // Group of Lizards
		{ EffectTypes.Lizard_5, "Lizard 5" },                                                                                                                   // Group of Lizards
		{ EffectTypes.Lizard_Faction_Support, "Lizard Faction Support" },                                                                                       // Lizard Clan Support
		{ EffectTypes.Lizard_House_Blueprint, "Lizard House Blueprint" },                                                                                       // Lizard House
		{ EffectTypes.Lizard_Resolve_For_Training_Gear_Prod, "Lizard Resolve for Training Gear Prod" },                                                         // Training Grounds
		{ EffectTypes.Lizards_Killed_3___Missiles, "Lizards Killed 3 - Missiles" },                                                                             // Blood for Blood
		{ EffectTypes.Local_Taxes, "Local Taxes" },                                                                                                             // Local Taxes
		{ EffectTypes.Locate_Springs, "Locate Springs" },                                                                                                       // Reveals a geyser
		{ EffectTypes.Lock_Blightpost, "Lock Blightpost" }, 
		{ EffectTypes.Lock_Crude_Workstation, "Lock Crude Workstation" }, 
		{ EffectTypes.Lock_Hydrant, "Lock Hydrant" }, 
		{ EffectTypes.Lock_Trading_Post, "Lock Trading Post" }, 
		{ EffectTypes.Lock_Unlocked_Essentials___Tutorial_I, "Lock Unlocked Essentials - Tutorial I" }, 
		{ EffectTypes.Lock_Unlocked_Essentials___Tutorial_II, "Lock Unlocked Essentials - Tutorial II" }, 
		{ EffectTypes.Lock_Unlocked_Essentials___Tutorial_III, "Lock Unlocked Essentials - Tutorial III" }, 
		{ EffectTypes.Lock_Unlocked_Essentials___Tutorial_IV, "Lock Unlocked Essentials - Tutorial IV" }, 
		{ EffectTypes.Long_Live_The_Queen, "Long Live the Queen" },                                                                                             // Long Live the Queen
		{ EffectTypes.Longer_Clearance_Plus25, "Longer Clearance +25" },                                                                                        // Clearance Totem
		{ EffectTypes.Longer_Drizzle_Plus25, "Longer Drizzle +25" },                                                                                            // Drizzle Totem
		{ EffectTypes.Longer_Storm_For_Wood_Production, "Longer Storm for Wood Production" },                                                                   // Ancient Stabilizer
		{ EffectTypes.Longer_Storm_Plus10, "Longer Storm +10" }, 
		{ EffectTypes.Longer_Storm_Plus100, "Longer Storm +100" }, 
		{ EffectTypes.Longer_Storm_Plus40, "Longer Storm +40" }, 
		{ EffectTypes.Longer_Storm_Rain_Totem, "Longer Storm Rain Totem" },                                                                                     // Fishmen Rituals
		{ EffectTypes.Lower_Glades, "Lower Glades" }, 
		{ EffectTypes.Lower_Glades___Dangerous, "Lower Glades - Dangerous" }, 
		{ EffectTypes.Lower_Glades_Fox___Dangerous, "Lower Glades Fox - Dangerous" }, 
		{ EffectTypes.Lower_Glades_Fox___Forbidden, "Lower Glades Fox - Forbidden" }, 
		{ EffectTypes.Lower_Glades_Fox___Small, "Lower Glades Fox - Small" }, 
		{ EffectTypes.Lower_Hostility_For_Education, "Lower Hostility For Education" },                                                                         // Consecrated Scrolls
		{ EffectTypes.Lower_Hostility_For_People, "Lower Hostility for people" }, 
		{ EffectTypes.Lower_Hostility_For_Religion, "Lower Hostility For Religion" },                                                                           // Firelink Ritual
		{ EffectTypes.Lumber_Speed__50, "Lumber Speed -50" }, 
		{ EffectTypes.Lumber_Speed_Plus10, "Lumber Speed +10" },                                                                                                // Driving Water
		{ EffectTypes.Lumber_Speed_Plus15, "Lumber Speed +15" },                                                                                                // Reinforced Axes
		{ EffectTypes.Lumber_Speed_Plus30, "Lumber Speed +30" },                                                                                                // Reinforced Axes
		{ EffectTypes.Lumber_Speed_Plus50, "Lumber Speed +50" },                                                                                                // Reinforced Axes
		{ EffectTypes.Lumbermill_Blueprint, "Lumbermill Blueprint" },                                                                                           // Lumber Mill
		{ EffectTypes.Machinery_1, "Machinery 1" },                                                                                                             // Machinery
		{ EffectTypes.Machinery_10, "Machinery 10" },                                                                                                           // Machinery
		{ EffectTypes.Machinery_2, "Machinery 2" },                                                                                                             // Machinery
		{ EffectTypes.Machinery_3, "Machinery 3" },                                                                                                             // Machinery
		{ EffectTypes.Machinery_4, "Machinery 4" },                                                                                                             // Machinery
		{ EffectTypes.Machinery_5, "Machinery 5" },                                                                                                             // Machinery
		{ EffectTypes.Makeshift_Extractor___Clearance_Water_Per_Minute, "Makeshift Extractor - Clearance Water per minute" },                                   // Groundwater Extraction
		{ EffectTypes.Makeshift_Extractor___Tank_Capacity, "Makeshift Extractor - Tank Capacity" }, 
		{ EffectTypes.Makeshift_Extractor___Water_Per_Minute_And_Tank, "Makeshift Extractor - Water Per Minute And Tank" },                                     // Groundwater Extraction
		{ EffectTypes.Makeshift_Post__Plus50, "Makeshift Post  +50" },                                                                                          // Worker Mobilization
		{ EffectTypes.Manufactory_Blueprint, "Manufactory Blueprint" },                                                                                         // Manufactory
		{ EffectTypes.Manuscripts_paper__3pm, "Manuscripts (paper) 3pm" },                                                                                      // Scroll Delivery Line
		{ EffectTypes.Manuscripts_paper__5pm, "Manuscripts (paper) 5pm" },                                                                                      // Scroll Delivery Line
		{ EffectTypes.Map_Mod_3_Order_Picks, "[Map Mod] 3 Order Picks" },                                                                                       // Royal Outpost
		{ EffectTypes.Map_Mod_Bonus_Timed_Orders, "[Map Mod] Bonus Timed Orders" },                                                                             // Forsaken Gods Temple
		{ EffectTypes.Map_Mod_Consumption_Control_Block, "[Map Mod] Consumption Control Block" },                                                               // Monastery of the Holy Flame
		{ EffectTypes.Map_Mod_Dangerous_Lands, "[Map Mod] Dangerous Lands" },                                                                                   // Dangerous Lands
		{ EffectTypes.Map_Mod_Favoring_Block, "[Map Mod] Favoring Block" }, 
		{ EffectTypes.Map_Mod_Forbidden_Lands, "[Map Mod] Forbidden Lands" },                                                                                   // Forbidden Lands
		{ EffectTypes.Map_Mod_Hostility_People, "[Map Mod] Hostility People" },                                                                                 // Flooded Mines
		{ EffectTypes.Map_Mod_Initial_Hostility, "[Map Mod] Initial Hostility" },                                                                               // Ancient Battleground
		{ EffectTypes.Map_Mod_Initial_Impatience, "[Map Mod] Initial Impatience" },                                                                             // Sparkdew Crystals
		{ EffectTypes.Map_Mod_Leaving_Block, "[Map Mod] Leaving Block" }, 
		{ EffectTypes.Map_Mod_Longer_Storm_5, "[Map Mod] Longer Storm 5" }, 
		{ EffectTypes.Map_Mod_More_Hostility_People, "[Map Mod] More Hostility People" }, 
		{ EffectTypes.Map_Mod_More_Hostility_Yearly, "[Map Mod] More Hostility Yearly" }, 
		{ EffectTypes.Map_Mod_Move, "[Map Mod] Move" },                                                                                                         // Levitating Monument
		{ EffectTypes.Map_Mod_No_Control, "[Map Mod] No Control" },                                                                                             // Monastery of the Holy Flame
		{ EffectTypes.Map_Mod_No_Glade_Info, "[Map Mod] No Glade Info" },                                                                                       // Haunted Forest
		{ EffectTypes.Map_Mod_No_Goods_Refund, "[Map Mod] No Goods Refund" },                                                                                   // Corrosive Torrent
		{ EffectTypes.Map_Mod_No_Hostility, "[Map Mod] No Hostility" },                                                                                         // Watchtower
		{ EffectTypes.Map_Mod_No_Hostility_Year, "[Map Mod] No Hostility Year" }, 
		{ EffectTypes.Map_Mod_No_Leaving, "[Map Mod] No Leaving" },                                                                                             // Forsaken Gods Temple
		{ EffectTypes.Map_Mod_No_Orders, "[Map Mod] No Orders" },                                                                                               // Fishmen Ritual Site
		{ EffectTypes.Map_Mod_No_Reputation_From_Resolve, "[Map Mod] No Reputation from Resolve" }, 
		{ EffectTypes.Map_Mod_One_Perk, "[Map Mod] One Perk" },                                                                                                 // Statue of the Forefathers
		{ EffectTypes.Map_Mod_Overgrown_Library, "[Map Mod] Overgrown Library" },                                                                               // Overgrown Library
		{ EffectTypes.Map_Mod_Petrified_Necropolis, "[Map Mod] Petrified Necropolis" },                                                                         // Petrified Necropolis
		{ EffectTypes.Map_Mod_Resolve_Penalty, "[Map Mod] Resolve Penalty" },                                                                                   // Forsaken Gods Temple
		{ EffectTypes.Map_Mod_Ruins, "[Map Mod] Ruins" },                                                                                                       // Ruins
		{ EffectTypes.Map_Mod_Trader_Attack, "[Map Mod] Trader Attack" },                                                                                       // Ruined Armory
		{ EffectTypes.Map_Mod_Untamed_Wilds, "[Map Mod] Untamed Wilds" },                                                                                       // Untamed Wilds
		{ EffectTypes.Market_Blueprint, "Market Blueprint" },                                                                                                   // Market
		{ EffectTypes.Meat_10pm, "Meat 10pm" },                                                                                                                 // Meat Delivery Line
		{ EffectTypes.Meat_5pm, "Meat 5pm" },                                                                                                                   // Meat Delivery Line
		{ EffectTypes.Meat_And_Grain_For_Events, "Meat and Grain for Events" },                                                                                 // Lost Supplies
		{ EffectTypes.Meat_Plus1, "Meat +1" },                                                                                                                  // Nets
		{ EffectTypes.Meat_Plus2, "Meat +2" },                                                                                                                  // Nets
		{ EffectTypes.Meat_Plus3, "Meat +3" },                                                                                                                  // Nets
		{ EffectTypes.Meat_Plus5, "Meat +5" },                                                                                                                  // Nets
		{ EffectTypes.Meat_Specialization, "Meat Specialization" },                                                                                             // Meat Specialization
		{ EffectTypes.Merchandise_Price_Reduction_Effect_Model, "Merchandise Price Reduction Effect Model" }, 
		{ EffectTypes.Metal_Production_Speed_Boost_33, "Metal Production Speed Boost 33" }, 
		{ EffectTypes.Metal_Production_Speed_Boost_66, "Metal Production Speed Boost 66" },                                                                     // Metallurgic Proficiency
		{ EffectTypes.Metal_Tools_10, "Metal Tools 10" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_10___Lizard_Passive, "Metal Tools 10 - Lizard Passive" },                                                                     // Box of Tools
		{ EffectTypes.Metal_Tools_12, "Metal Tools 12" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_15, "Metal Tools 15" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_20, "Metal Tools 20" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_24, "Metal Tools 24" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_3, "Metal Tools 3" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_30, "Metal Tools 30" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_34, "Metal Tools 34" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_4, "Metal Tools 4" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_40, "Metal Tools 40" },                                                                                                       // Box of Tools
		{ EffectTypes.Metal_Tools_5, "Metal Tools 5" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_6, "Metal Tools 6" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_7, "Metal Tools 7" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_8, "Metal Tools 8" },                                                                                                         // Box of Tools
		{ EffectTypes.Metal_Tools_9, "Metal Tools 9" },                                                                                                         // Box of Tools
		{ EffectTypes.Metalurgic_Proficiency_33, "Metalurgic Proficiency 33" },                                                                                 // Metallurgic Proficiency
		{ EffectTypes.Milk_cap_Mushroom_10, "Milk-cap Mushroom 10" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_15, "Milk-cap Mushroom 15" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_20, "Milk-cap Mushroom 20" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_3, "Milk-cap Mushroom 3" },                                                                                             // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_30, "Milk-cap Mushroom 30" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_40, "Milk-cap Mushroom 40" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_5, "Milk-cap Mushroom 5" },                                                                                             // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_50, "Milk-cap Mushroom 50" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_60, "Milk-cap Mushroom 60" },                                                                                           // Pack of Mushrooms
		{ EffectTypes.Milk_cap_Mushroom_8, "Milk-cap Mushroom 8" },                                                                                             // Pack of Mushrooms
		{ EffectTypes.Mill_Blueprint, "Mill Blueprint" },                                                                                                       // Rain Mill
		{ EffectTypes.Mine_Plus100, "Mine +100" },                                                                                                              // Rainpunk Drills
		{ EffectTypes.Mine_Plus30, "Mine +30" },                                                                                                                // Rainpunk Drills
		{ EffectTypes.Mine_Speed_Plus100, "Mine Speed +100" }, 
		{ EffectTypes.Mists_Piercers, "Mists Piercers" },                                                                                                       // Mist Piercers
		{ EffectTypes.Mistworm_All_Food_Lost, "Mistworm All Food Lost" },                                                                                       // Mistworm Infestation
		{ EffectTypes.Mistworm_RemoveFoodOverTime_Hard, "Mistworm_RemoveFoodOverTime_Hard" },                                                                   // Hungry Mistworm
		{ EffectTypes.Mistworm_RemoveFoodOverTime_Impossible, "Mistworm_RemoveFoodOverTime_Impossible" },                                                       // Hungry Mistworm
		{ EffectTypes.Mistworm_RemoveFoodOverTime_Normal, "Mistworm_RemoveFoodOverTime_Normal" },                                                               // Hungry Mistworm
		{ EffectTypes.Mistworm_RemoveFoodOverTime_VeryHard, "Mistworm_RemoveFoodOverTime_VeryHard" },                                                           // Hungry Mistworm
		{ EffectTypes.Mod_3_Order_Picks, "[Mod] 3 Order Picks" },                                                                                               // The Generous Envoy
		{ EffectTypes.Mod_Additional_Impatience_For_Death, "[Mod] Additional Impatience for Death" },                                                           // The Queen's People
		{ EffectTypes.Mod_Advent_Of_Flame, "[Mod] Advent of Flame" },                                                                                           // Advent of Flame
		{ EffectTypes.Mod_Amber_Payment, "[Mod] Amber Payment" },                                                                                               // Royal Tax
		{ EffectTypes.Mod_Blightrot_Medium, "[Mod] Blightrot Medium" },                                                                                         // Sinister Blight
		{ EffectTypes.Mod_Calm_Lands, "[Mod] Calm Lands" },                                                                                                     // Calm Lands
		{ EffectTypes.Mod_Calm_Lands___Dangerous_Glades, "[Mod] Calm Lands - Dangerous Glades" },                                                               // Calm Lands
		{ EffectTypes.Mod_Calm_Lands___Regular_Glades, "[Mod] Calm Lands - Regular Glades" },                                                                   // Calm Lands
		{ EffectTypes.Mod_Cysts_Spawn, "[Mod] Cysts Spawn" },                                                                                                   // Blight Swarm
		{ EffectTypes.Mod_Dangerous_Glades_Info_Block, "[Mod] Dangerous Glades Info Block" },                                                                   // Haunted Forest
		{ EffectTypes.Mod_Disgrace, "[Mod] Disgrace" },                                                                                                         // Disgrace
		{ EffectTypes.Mod_Exploration_Tax, "[Mod] Exploration Tax" },                                                                                           // Land Tax
		{ EffectTypes.Mod_Exploration_Tax___Amber_Payment, "[Mod] Exploration Tax - Amber Payment" },                                                           // Land Tax (big glade)
		{ EffectTypes.Mod_Exploration_Tax___Amber_Payment___Small, "[Mod] Exploration Tax - Amber Payment - small" },                                           // Land Tax (small glade)
		{ EffectTypes.Mod_Exploration_Tax___Composite, "[Mod] Exploration Tax - Composite" },                                                                   // Land Tax
		{ EffectTypes.Mod_Exploration_Tax___Small, "[Mod] Exploration Tax - small" },                                                                           // Land Tax
		{ EffectTypes.Mod_Faster_Fuel_Sacrafice, "[Mod] Faster Fuel Sacrafice" },                                                                               // Hearth Defect
		{ EffectTypes.Mod_Faster_Leaving, "[Mod] Faster Leaving" },                                                                                             // Higher Standards
		{ EffectTypes.Mod_Fewer_Blueprints_Options, "[Mod] Fewer Blueprints Options" },                                                                         // Less is More
		{ EffectTypes.Mod_Fewer_Cornerstones_Options, "[Mod] Fewer Cornerstones Options" },                                                                     // Restrictions
		{ EffectTypes.Mod_Fewer_Initial_Blueprints, "[Mod] Fewer Initial Blueprints" },                                                                         // Budget Cuts
		{ EffectTypes.Mod_Fewer_Initial_Blueprints___Overgrown_Library, "[Mod] Fewer Initial Blueprints - Overgrown Library" },                                 // Budget Cuts
		{ EffectTypes.Mod_Gathering_Storm, "[Mod] Gathering Storm" },                                                                                           // Gathering Storm
		{ EffectTypes.Mod_Global_Reputation_Treshold_Increase, "[Mod] Global Reputation Treshold Increase" },                                                   // Malcontents
		{ EffectTypes.Mod_Guilds_Disfavor, "[Mod] Guilds Disfavor" },                                                                                           // Guild's Disfavor
		{ EffectTypes.Mod_Hard_Orders_Only, "[Mod] Hard Orders Only" },                                                                                         // Hard Times
		{ EffectTypes.Mod_Higher_Blueprints_Reroll_Cost, "[Mod] Higher Blueprints Reroll Cost" },                                                               // Expensive Lottery
		{ EffectTypes.Mod_Higher_Needs_Consumption_Rate, "[Mod] Higher Needs Consumption Rate" },                                                               // Consumerism
		{ EffectTypes.Mod_Higher_Traders_Prices, "[Mod] Higher Traders Prices" },                                                                               // Guild of Traders, or Thieves?
		{ EffectTypes.Mod_Human_Influx, "[Mod] Human Influx" },                                                                                                 // Human Influx
		{ EffectTypes.Mod_Land_Of_Greed, "[Mod] Land of Greed" },                                                                                               // Land of Greed
		{ EffectTypes.Mod_Less_Hearth_Range, "[Mod] Less Hearth Range" },                                                                                       // Frosts
		{ EffectTypes.Mod_Longer_Relics_Working_Time, "[Mod] Longer Relics Working Time" },                                                                     // Procrastination
		{ EffectTypes.Mod_Longer_Storm, "[Mod] Longer Storm" },                                                                                                 // Crumbling Seal
		{ EffectTypes.Mod_Low_Food_Production_Speed, "[Mod] Low Food Production Speed" },                                                                       // No Cooking Utensils
		{ EffectTypes.Mod_Lower_Impatience_Reduction, "[Mod] Lower Impatience Reduction" },                                                                     // Higher Expectations
		{ EffectTypes.Mod_Memory_Of_The_Forest, "[Mod] Memory of the Forest" },                                                                                 // Memory of the Forest
		{ EffectTypes.Mod_Metal_Production_Speed_100, "[Mod] Metal Production Speed 100" },                                                                     // Metallurgic Experts
		{ EffectTypes.Mod_No_Crude_Workstation, "[Mod] No Crude Workstation" },                                                                                 // Missing Crude Workstation
		{ EffectTypes.Mod_No_Order_Picks, "[Mod] No Order Picks" },                                                                                             // Under the Queen's Gaze
		{ EffectTypes.Mod_No_Positive_Seasonal_Effects, "[Mod] No Positive Seasonal Effects" },                                                                 // Unfavorable Weather
		{ EffectTypes.Mod_Ominous_Presence, "[Mod] Ominous Presence" },                                                                                         // Ominous Presence
		{ EffectTypes.Mod_Orders_Block, "[Mod] Orders Block" },                                                                                                 // Sabotage
		{ EffectTypes.Mod_Parasites, "[Mod] Parasites" },                                                                                                       // Parasites
		{ EffectTypes.Mod_Petrified_Necropolis___Meat_For_Stone_And_Clay, "[Mod] Petrified Necropolis - Meat for Stone and Clay" }, 
		{ EffectTypes.Mod_Petrified_Necropolis___Spawn_Deposit_On_Death, "[Mod] Petrified Necropolis - Spawn Deposit On Death" }, 
		{ EffectTypes.Mod_Petrified_Necropolis___Stone_For_Death, "[Mod] Petrified Necropolis - Stone for Death" }, 
		{ EffectTypes.Mod_Politically_Outmaneuvered, "[Mod] Politically Outmaneuvered" },                                                                       // Politically Outmaneuvered
		{ EffectTypes.Mod_Queens_Support, "[Mod] Queens Support" },                                                                                             // Queen's Support
		{ EffectTypes.Mod_RawDepositsCharges_10, "[Mod] RawDepositsCharges_10" },                                                                               // Rich Wilderness
		{ EffectTypes.Mod_Replace_Initial_Glade___Ruins, "[Mod] Replace Initial Glade - Ruins" },                                                               // Abandoned Settlement
		{ EffectTypes.Mod_Reputation_Changes, "[Mod] Reputation Changes" },                                                                                     // Prestigious Expedition
		{ EffectTypes.Mod_Scavenging_Party, "[Mod] Scavenging Party" },                                                                                         // Scavenging Party
		{ EffectTypes.Mod_Stingy_Archivist, "[Mod] Stingy Archivist" },                                                                                         // Stingy Archivist
		{ EffectTypes.Mod_The_Other_Settlement, "[Mod] The Other Settlement" },                                                                                 // The Other Settlement
		{ EffectTypes.Mod_Third_Party, "[Mod] Third Party" },                                                                                                   // Third Party
		{ EffectTypes.Mod_VillagerDeathEffectBlock, "[Mod] VillagerDeathEffectBlock" },                                                                         // Dark Secret
		{ EffectTypes.Mod_Wet_Soil, "[Mod] Wet Soil" },                                                                                                         // Wet Soil
		{ EffectTypes.Mod_Wine_Shortage, "[Mod] Wine Shortage" },                                                                                               // Wine Shortage
		{ EffectTypes.ModifierEffect_AdditionalGrass, "ModifierEffect_AdditionalGrass" },                                                                       // Fertile Grounds
		{ EffectTypes.ModifierEffect_AncientGate, "ModifierEffect_AncientGate" },                                                                               // ModifierEffect_AncientGate_Name
		{ EffectTypes.ModifierEffect_LongStorm, "ModifierEffect_LongStorm" },                                                                                   // Weather Anomaly
		{ EffectTypes.ModifierEffect_NoGrass, "ModifierEffect_NoGrass" },                                                                                       // Barren Lands
		{ EffectTypes.ModifierEffect_RuinedSettlement_Dangerous, "ModifierEffect_RuinedSettlement_Dangerous" },                                                 // Ruins
		{ EffectTypes.ModifierEffect_RuinedSettlement_Forbidden, "ModifierEffect_RuinedSettlement_Forbidden" },                                                 // Ruins
		{ EffectTypes.ModifierEffect_TradeBlock, "ModifierEffect_TradeBlock" },                                                                                 // Bandit Camp
		{ EffectTypes.ModifierEffect_TradeBlock_Composite, "ModifierEffect_TradeBlock_Composite" },                                                             // Bandit Camp
		{ EffectTypes.ModifierEffect_TreeCuttingTime, "ModifierEffect_TreeCuttingTime" },                                                                       // Stonewood Infestation
		{ EffectTypes.Mold_Grain, "Mold Grain" },                                                                                                               // Moldy Grain Seeds
		{ EffectTypes.Mole_Earthquake, "Mole Earthquake" },                                                                                                     // Earthquake
		{ EffectTypes.Mole_ForagersResolvePenalty_Hard, "Mole_ForagersResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_ForagersResolvePenalty_Impossible, "Mole_ForagersResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_ForagersResolvePenalty_Normal, "Mole_ForagersResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_ForagersResolvePenalty_VeryHard, "Mole_ForagersResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_HarvesterResolvePenalty_Hard, "Mole_HarvesterResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_HarvesterResolvePenalty_Impossible, "Mole_HarvesterResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_HarvesterResolvePenalty_Normal, "Mole_HarvesterResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_HarvesterResolvePenalty_VeryHard, "Mole_HarvesterResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_HerablistResolvePenalty_Hard, "Mole_HerablistResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_HerablistResolvePenalty_Impossible, "Mole_HerablistResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_HerablistResolvePenalty_Normal, "Mole_HerablistResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_HerablistResolvePenalty_VeryHard, "Mole_HerablistResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_Infestation_Composite, "Mole Infestation Composite" },                                                                               // Infestation
		{ EffectTypes.Mole_PimitiveTrapperPenalty_VeryHard, "Mole_PimitiveTrapperPenalty_VeryHard" }, 
		{ EffectTypes.Mole_PimitiveTrapperResolvePenalty_Hard, "Mole_PimitiveTrapperResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_PimitiveTrapperResolvePenalty_Impossible, "Mole_PimitiveTrapperResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_PimitiveTrapperResolvePenalty_Normal, "Mole_PimitiveTrapperResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_PrimitiveForagerResolvePenalty_Hard, "Mole_PrimitiveForagerResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_PrimitiveForagerResolvePenalty_Impossible, "Mole_PrimitiveForagerResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_PrimitiveForagerResolvePenalty_Normal, "Mole_PrimitiveForagerResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_PrimitiveForagerResolvePenalty_VeryHard, "Mole_PrimitiveForagerResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_PrimitiveHerbalistResolvePenalty_Hard, "Mole_PrimitiveHerbalistResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_PrimitiveHerbalistResolvePenalty_Impossible, "Mole_PrimitiveHerbalistResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_PrimitiveHerbalistResolvePenalty_Normal, "Mole_PrimitiveHerbalistResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_PrimitiveHerbalistResolvePenalty_VeryHard, "Mole_PrimitiveHerbalistResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_StonecuttersResolvePenalty_Hard, "Mole_StonecuttersResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_StonecuttersResolvePenalty_Impossible, "Mole_StonecuttersResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_StonecuttersResolvePenalty_Normal, "Mole_StonecuttersResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_StonecuttersResolvePenalty_VeryHard, "Mole_StonecuttersResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_TrappersResolvePenalty_Hard, "Mole_TrappersResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_TrappersResolvePenalty_Impossible, "Mole_TrappersResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_TrappersResolvePenalty_Normal, "Mole_TrappersResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_TrappersResolvePenalty_VeryHard, "Mole_TrappersResolvePenalty_VeryHard" }, 
		{ EffectTypes.Mole_WoodcuttersResolvePenalty_Hard, "Mole_WoodcuttersResolvePenalty_Hard" }, 
		{ EffectTypes.Mole_WoodcuttersResolvePenalty_Impossible, "Mole_WoodcuttersResolvePenalty_Impossible" }, 
		{ EffectTypes.Mole_WoodcuttersResolvePenalty_Normal, "Mole_WoodcuttersResolvePenalty_Normal" }, 
		{ EffectTypes.Mole_WoodcuttersResolvePenalty_VeryHard, "Mole_WoodcuttersResolvePenalty_VeryHard" }, 
		{ EffectTypes.MoleResolvePenalty___Hard, "MoleResolvePenalty - hard" },                                                                                 // Giant Beast
		{ EffectTypes.MoleResolvePenalty___Impossible, "MoleResolvePenalty - impossible" },                                                                     // Giant Beast
		{ EffectTypes.MoleResolvePenalty___Normal, "MoleResolvePenalty - normal" },                                                                             // Giant Beast
		{ EffectTypes.MoleResolvePenalty___Very_Hard, "MoleResolvePenalty - very hard" },                                                                       // Giant Beast
		{ EffectTypes.Monastery_Blueprint, "Monastery Blueprint" },                                                                                             // Monastery
		{ EffectTypes.Monolith_Hostility, "Monolith hostility" },                                                                                               // Obelisk
		{ EffectTypes.More_Amber_From_Routes, "More Amber from Routes" },                                                                                       // Trade Negotiations
		{ EffectTypes.More_Fuel_Produced, "More Fuel Produced" }, 
		{ EffectTypes.More_Packs_Produced, "More Packs Produced" }, 
		{ EffectTypes.More_Packs_Produced_100, "More Packs Produced 100" }, 
		{ EffectTypes.More_Resolve_For_Comfortable, "More Resolve for Comfortable" },                                                                           // Long Term Contract
		{ EffectTypes.More_Trade_Offers, "More Trade Offers" },                                                                                                 // Market Shift Plan
		{ EffectTypes.More_Trade_Offers___Extra_Trade_Routes, "More Trade Offers - Extra Trade Routes" }, 
		{ EffectTypes.More_Trade_Offers___Trader_Block, "More Trade Offers - Trader Block" },                                                                   // Market Shift Plan
		{ EffectTypes.More_Trade_Offers___Trader_Block___Holder, "More Trade Offers - Trader Block - Holder" },                                                 // Adjustment Period
		{ EffectTypes.MoreHostilityPerHearth, "MoreHostilityPerHearth" },                                                                                       // Cold Flame
		{ EffectTypes.MoreHostilityPerHearth_Weak, "MoreHostilityPerHearth_Weak" },                                                                             // Cold Flame
		{ EffectTypes.Moth_Larvae_Meat_10, "Moth Larvae Meat 10" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_15, "Moth Larvae Meat 15" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_20, "Moth Larvae Meat 20" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_25, "Moth Larvae Meat 25" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_30, "Moth Larvae Meat 30" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_40, "Moth Larvae Meat 40" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_5, "Moth Larvae Meat 5" },                                                                                               // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_50, "Moth Larvae Meat 50" },                                                                                             // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_6, "Moth Larvae Meat 6" },                                                                                               // Pack of Meat
		{ EffectTypes.Moth_Larvae_Meat_60, "Moth Larvae Meat 60" },                                                                                             // Pack of Meat
		{ EffectTypes.Mushroom_Plus1, "Mushroom +1" },                                                                                                          // Fungal Growth
		{ EffectTypes.Mushroom_Plus2, "Mushroom +2" },                                                                                                          // Fungal Growth
		{ EffectTypes.Mushroom_Plus3, "Mushroom +3" },                                                                                                          // Fungal Growth
		{ EffectTypes.Mushroom_Plus5, "Mushroom +5" },                                                                                                          // Fungal Growth
		{ EffectTypes.Mushroom_Specialization, "Mushroom Specialization" },                                                                                     // Fungal Guide
		{ EffectTypes.Mushrooms_10pm, "Mushrooms 10pm" },                                                                                                       // Mushroom Delivery Line
		{ EffectTypes.Mushrooms_5pm, "Mushrooms 5pm" },                                                                                                         // Mushroom Delivery Line
		{ EffectTypes.Mushrooms_In_Farms, "Mushrooms in Farms" },                                                                                               // Mushroom Seedlings
		{ EffectTypes.Mushrooms_In_Grove, "Mushrooms in Grove" },                                                                                               // Seasonal Crops
		{ EffectTypes.Mushrooms_In_Grove___Altar, "Mushrooms in Grove - Altar" },                                                                               // Seasonal Crops (Stormforged)
		{ EffectTypes.Mushrooms_In_Herb_Garden, "Mushrooms in Herb Garden" },                                                                                   // Seasonal Crops
		{ EffectTypes.Mushrooms_In_Herb_Garden___Altar, "Mushrooms in Herb Garden - Altar" },                                                                   // Seasonal Crops (Stormforged)
		{ EffectTypes.Mushrooms_In_Herb_Garden_Haunted, "Mushrooms in Herb Garden Haunted" },                                                                   // Seasonal Crops
		{ EffectTypes.Mushrooms_In_Herb_Garden_Haunted___Altar, "Mushrooms in Herb Garden Haunted - Altar" },                                                   // Seasonal Crops (Stormforged)
		{ EffectTypes.Mushrooms_In_Plantation, "Mushrooms in Plantation" },                                                                                     // Seasonal Crops
		{ EffectTypes.Mushrooms_In_Plantation___Altar, "Mushrooms in Plantation - Altar" },                                                                     // Seasonal Crops (Stormforged)
		{ EffectTypes.Mushrooms_In_SmallFarm, "Mushrooms in SmallFarm" },                                                                                       // Seasonal Crops
		{ EffectTypes.Mushrooms_In_SmallFarm___Altar, "Mushrooms in SmallFarm - Altar" },                                                                       // Seasonal Crops (Stormforged)
		{ EffectTypes.Mushrooms_In_SmallFarm_Haunted, "Mushrooms in SmallFarm Haunted" },                                                                       // Seasonal Crops
		{ EffectTypes.Mushrooms_In_SmallFarm_Haunted___Altar, "Mushrooms in SmallFarm Haunted - Altar" },                                                       // Seasonal Crops (Stormforged)
		{ EffectTypes.NeedPerk_Ale_Resolve, "NeedPerk Ale Resolve" },                                                                                           // Spiced Ale
		{ EffectTypes.NeedPerk_Biscuit_Farmers, "NeedPerk Biscuit Farmers" },                                                                                   // Biscuit Diet
		{ EffectTypes.NeedPerk_Coats_Breaks, "NeedPerk Coats Breaks" },                                                                                         // Drying Boards
		{ EffectTypes.NeedPerk_Education_Production, "NeedPerk Education Production" },                                                                         // Working Hard and Smart
		{ EffectTypes.NeedPerk_Housing_Resolve, "NeedPerk Housing Resolve" },                                                                                   // Furniture
		{ EffectTypes.NeedPerk_Leisure_Production, "NeedPerk Leisure Production" },                                                                             // Well-Rested Workers
		{ EffectTypes.New_Season_Change_Block_Effect_Model, "New Season Change Block Effect Model" }, 
		{ EffectTypes.New_Season_Change_Effect_Model, "New Season Change Effect Model" }, 
		{ EffectTypes.Newcomer_Goods_Plus10, "Newcomer Goods +10" }, 
		{ EffectTypes.Newcomer_Goods_Plus20, "Newcomer Goods +20" }, 
		{ EffectTypes.Newcomer_Goods_Plus25, "Newcomer Goods +25" }, 
		{ EffectTypes.Newcomer_Goods_Plus40, "Newcomer Goods +40" }, 
		{ EffectTypes.Newcomer_Goods_Plus50, "Newcomer Goods +50" }, 
		{ EffectTypes.Newcomer_Goods_Plus75, "Newcomer Goods +75" }, 
		{ EffectTypes.Newcomer_Rate_For_Trade_Routes, "Newcomer Rate for Trade Routes" },                                                                       // Economic Migration
		{ EffectTypes.Newcomers_Faster_15, "Newcomers Faster 15" }, 
		{ EffectTypes.Newcomers_Faster_20, "Newcomers Faster 20" }, 
		{ EffectTypes.Newcomers_Faster_25, "Newcomers Faster 25" },                                                                                             // Secure Trail
		{ EffectTypes.Newcomers_Slower_33, "Newcomers Slower 33" },                                                                                             // Shifting Paths
		{ EffectTypes.NewNewcomersBonus_Random, "NewNewcomersBonus_Random" },                                                                                   // Crowded Caravan
		{ EffectTypes.NewNewcomersBonus_Random_3, "NewNewcomersBonus_Random 3" }, 
		{ EffectTypes.NewRandomVillagers, "NewRandomVillagers" }, 
		{ EffectTypes.NewRandomVillagers_10, "NewRandomVillagers 10" },                                                                                         // Villagers
		{ EffectTypes.NewRandomVillagers_2, "NewRandomVillagers 2" },                                                                                           // Villagers
		{ EffectTypes.NewRandomVillagers_3, "NewRandomVillagers 3" },                                                                                           // Villagers
		{ EffectTypes.NewRandomVillagers_4, "NewRandomVillagers 4" },                                                                                           // Villagers
		{ EffectTypes.NewRandomVillagers_5, "NewRandomVillagers 5" },                                                                                           // Villagers
		{ EffectTypes.NewRandomVillagers_6, "NewRandomVillagers 6" },                                                                                           // Villagers
		{ EffectTypes.Nights_Embrace, "Night's Embrace" },                                                                                                      // The Night's Embrace
		{ EffectTypes.Noria_Plant_And_Harvest, "Noria plant and harvest" },                                                                                     // Rainpunk Noria
		{ EffectTypes.Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Hard, "Noxious Machinery - Water Remove and Spawn Cyst - hard" },                       // Overflow
		{ EffectTypes.Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Impossible, "Noxious Machinery - Water Remove and Spawn Cyst - impossible" },           // Overflow
		{ EffectTypes.Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Normal, "Noxious Machinery - Water Remove and Spawn Cyst - normal" },                   // Overflow
		{ EffectTypes.Noxious_Machinery___Water_Remove_And_Spawn_Cyst___Very_Hard, "Noxious Machinery - Water Remove and Spawn Cyst - very hard" },             // Overflow
		{ EffectTypes.NoxiousMachinery_RemoveWaterOverTime___Hard, "NoxiousMachinery_RemoveWaterOverTime - hard" }, 
		{ EffectTypes.NoxiousMachinery_RemoveWaterOverTime___Impossible, "NoxiousMachinery_RemoveWaterOverTime - impossible" }, 
		{ EffectTypes.NoxiousMachinery_RemoveWaterOverTime___Normal, "NoxiousMachinery_RemoveWaterOverTime - normal" }, 
		{ EffectTypes.NoxiousMachinery_RemoveWaterOverTime___Very_Hard, "NoxiousMachinery_RemoveWaterOverTime - very hard" }, 
		{ EffectTypes.Oil_10, "Oil 10" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_10pm, "Oil 10pm" },                                                                                                                   // Oil Delivery Line
		{ EffectTypes.Oil_15, "Oil 15" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_2, "Oil 2" },                                                                                                                         // Oil Vessels
		{ EffectTypes.Oil_20, "Oil 20" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_3, "Oil 3" },                                                                                                                         // Oil Vessels
		{ EffectTypes.Oil_30, "Oil 30" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_40, "Oil 40" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_5, "Oil 5" },                                                                                                                         // Oil Vessels
		{ EffectTypes.Oil_50, "Oil 50" },                                                                                                                       // Oil Vessels
		{ EffectTypes.Oil_5pm, "Oil 5pm" },                                                                                                                     // Oil Delivery Line
		{ EffectTypes.Oil_6, "Oil 6" },                                                                                                                         // Oil Vessels
		{ EffectTypes.Oil_Plus1, "Oil +1" },                                                                                                                    // Heavy Press
		{ EffectTypes.Oil_Plus2, "Oil +2" },                                                                                                                    // Heavy Press
		{ EffectTypes.Oil_Plus3, "Oil +3" },                                                                                                                    // Heavy Press
		{ EffectTypes.Oil_Plus5, "Oil +5" },                                                                                                                    // Heavy Press
		{ EffectTypes.Opened_Dang_Glades_Reduces_Resolve, "Opened Dang Glades reduces Resolve" },                                                               // Greater Threat
		{ EffectTypes.Ore_Production_Speed_Boost_33, "Ore Production Speed Boost 33" }, 
		{ EffectTypes.Ore_Production_Speed_Boost_66, "Ore Production Speed Boost 66" },                                                                         // Metallurgic Proficiency
		{ EffectTypes.Outpost_RemoveFoodOverTime___Hard, "Outpost_RemoveFoodOverTime - hard" },                                                                 // Thieving Fishmen
		{ EffectTypes.Outpost_RemoveFoodOverTime___Impossible, "Outpost_RemoveFoodOverTime - impossible" },                                                     // Thieving Fishmen
		{ EffectTypes.Outpost_RemoveFoodOverTime___Normal, "Outpost_RemoveFoodOverTime - normal" },                                                             // Thieving Fishmen
		{ EffectTypes.Outpost_RemoveFoodOverTime___Very_Hard, "Outpost_RemoveFoodOverTime - very hard" },                                                       // Thieving Fishmen
		{ EffectTypes.Overexploitation, "Overexploitation" },                                                                                                   // Overexploitation
		{ EffectTypes.Overexploitation___Cyst_For_Node, "Overexploitation - cyst for node" }, 
		{ EffectTypes.Overflow, "Overflow" },                                                                                                                   // Overflow
		{ EffectTypes.Pack_Of_Building_Materials_1, "Pack of Building Materials 1" },                                                                           // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_10, "Pack of Building Materials 10" },                                                                         // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_12, "Pack of Building Materials 12" },                                                                         // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_15, "Pack of Building Materials 15" },                                                                         // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_5, "Pack of Building Materials 5" },                                                                           // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_8, "Pack of Building Materials 8" },                                                                           // Packs of Building Materials
		{ EffectTypes.Pack_Of_Building_Materials_Plus1, "Pack of Building Materials +1" }, 
		{ EffectTypes.Pack_Of_Building_Materials_Plus2, "Pack of Building Materials +2" }, 
		{ EffectTypes.Pack_Of_Building_Materials_Plus3, "Pack of Building Materials +3" }, 
		{ EffectTypes.Pack_Of_Building_Materials_Plus4, "Pack of Building Materials +4" }, 
		{ EffectTypes.Pack_Of_Building_Materials_Plus5, "Pack of Building Materials +5" }, 
		{ EffectTypes.Pack_Of_Building_Worth_More, "Pack of Building Worth More" }, 
		{ EffectTypes.Pack_Of_Building_Worth_More_33, "Pack of Building Worth More 33" }, 
		{ EffectTypes.Pack_Of_Crops_1, "Pack of Crops 1" },                                                                                                     // Packs of Crops
		{ EffectTypes.Pack_Of_Crops_10, "Pack of Crops 10" },                                                                                                   // Packs of Crops
		{ EffectTypes.Pack_Of_Crops_15, "Pack of Crops 15" },                                                                                                   // Packs of Crops
		{ EffectTypes.Pack_Of_Crops_5, "Pack of Crops 5" },                                                                                                     // Packs of Crops
		{ EffectTypes.Pack_Of_Crops_Plus1, "Pack of Crops +1" },                                                                                                // Industrialized Farming
		{ EffectTypes.Pack_Of_Crops_Plus2, "Pack of Crops +2" },                                                                                                // Industrialized Farming
		{ EffectTypes.Pack_Of_Crops_Plus3, "Pack of Crops +3" },                                                                                                // Industrialized Farming
		{ EffectTypes.Pack_Of_Crops_Plus4, "Pack of Crops +4" },                                                                                                // Industrialized Farming
		{ EffectTypes.Pack_Of_Crops_Plus5, "Pack of Crops +5" },                                                                                                // Industrialized Farming
		{ EffectTypes.Pack_Of_Crops_Worth_More, "Pack of Crops Worth More" },                                                                                   // Tight Packaging
		{ EffectTypes.Pack_Of_Crops_Worth_More_1, "Pack of Crops Worth More 1" }, 
		{ EffectTypes.Pack_Of_Crops_Worth_More_33, "Pack of Crops Worth More 33" }, 
		{ EffectTypes.Pack_Of_Luxury_Plus1, "Pack of Luxury +1" }, 
		{ EffectTypes.Pack_Of_Luxury_Plus2, "Pack of Luxury +2" }, 
		{ EffectTypes.Pack_Of_Luxury_Plus3, "Pack of Luxury +3" }, 
		{ EffectTypes.Pack_Of_Luxury_Plus5, "Pack of Luxury +5" }, 
		{ EffectTypes.Pack_Of_Luxury_Worth_More, "Pack of Luxury Worth More" }, 
		{ EffectTypes.Pack_Of_Luxury_Worth_More_33, "Pack of Luxury Worth More 33" }, 
		{ EffectTypes.Pack_Of_Provisions_1, "Pack of Provisions 1" },                                                                                           // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_10, "Pack of Provisions 10" },                                                                                         // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_15, "Pack of Provisions 15" },                                                                                         // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_2, "Pack of Provisions 2" },                                                                                           // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_3, "Pack of Provisions 3" },                                                                                           // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_5, "Pack of Provisions 5" },                                                                                           // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_6, "Pack of Provisions 6" },                                                                                           // Packs of Provisions
		{ EffectTypes.Pack_Of_Provisions_Plus1, "Pack of Provisions +1" }, 
		{ EffectTypes.Pack_Of_Provisions_Plus2, "Pack of Provisions +2" }, 
		{ EffectTypes.Pack_Of_Provisions_Plus3, "Pack of Provisions +3" }, 
		{ EffectTypes.Pack_Of_Provisions_Plus5, "Pack of Provisions +5" }, 
		{ EffectTypes.Pack_Of_Provisions_Worth_More, "Pack of Provisions Worth More" }, 
		{ EffectTypes.Pack_Of_Provisions_Worth_More_33, "Pack of Provisions Worth More 33" }, 
		{ EffectTypes.Pack_Of_Trade_Good_10, "Pack of Trade Good 10" },                                                                                         // Pack of Trade Goods
		{ EffectTypes.Pack_Of_Trade_Good_15, "Pack of Trade Good 15" },                                                                                         // Pack of Trade Goods
		{ EffectTypes.Pack_Of_Trade_Good_6, "Pack of Trade Good 6" },                                                                                           // Pack of Trade Goods
		{ EffectTypes.Pack_Of_Trade_Goods_Plus1, "Pack of Trade Goods +1" }, 
		{ EffectTypes.Pack_Of_Trade_Goods_Plus2, "Pack of Trade Goods +2" }, 
		{ EffectTypes.Pack_Of_Trade_Goods_Plus3, "Pack of Trade Goods +3" }, 
		{ EffectTypes.Pack_Of_Trade_Goods_Plus5, "Pack of Trade Goods +5" }, 
		{ EffectTypes.Pack_Of_Trade_Goods_Worth_More, "Pack of Trade Goods Worth More" },                                                                       // Value Added Tax
		{ EffectTypes.Pack_Of_Trade_Goods_Worth_More_33, "Pack of Trade Goods Worth More 33" }, 
		{ EffectTypes.Pack_Of_Valuables_10, "Pack of Valuables 10" },                                                                                           // Pack of Luxury Goods
		{ EffectTypes.Pack_Of_Valuables_15, "Pack of Valuables 15" },                                                                                           // Pack of Luxury Goods
		{ EffectTypes.Pack_Of_Valuables_5, "Pack of Valuables 5" },                                                                                             // Pack of Luxury Goods
		{ EffectTypes.Packs_Of_Goods_Plus1, "Packs of Goods +1" },                                                                                              // Export Specialization
		{ EffectTypes.Packs_Of_Goods_Plus2, "Packs of Goods +2" },                                                                                              // Export Specialization
		{ EffectTypes.Packs_Production_Speed_Boost_33, "Packs Production Speed Boost 33" },                                                                     // Quick Deliveries
		{ EffectTypes.Packs_Production_Speed_Boost_50, "Packs Production Speed Boost 50" }, 
		{ EffectTypes.Packs_Production_Speed_Boost_66, "Packs Production Speed Boost 66" },                                                                     // Quick Deliveries
		{ EffectTypes.PacksForResolveRep, "PacksForResolveRep" },                                                                                               // Export Contract
		{ EffectTypes.Paper_10, "Paper 10" },                                                                                                                   // Bundle of Scrolls
		{ EffectTypes.Paper_25, "Paper 25" },                                                                                                                   // Bundle of Scrolls
		{ EffectTypes.Paper_30, "Paper 30" },                                                                                                                   // Bundle of Scrolls
		{ EffectTypes.Paper_40, "Paper 40" },                                                                                                                   // Bundle of Scrolls
		{ EffectTypes.Paper_Plus1, "Paper +1" },                                                                                                                // Advanced Press
		{ EffectTypes.Paper_Plus2, "Paper +2" },                                                                                                                // Advanced Press
		{ EffectTypes.Paper_Plus3, "Paper +3" },                                                                                                                // Advanced Press
		{ EffectTypes.Paper_Plus5, "Paper +5" },                                                                                                                // Advanced Press
		{ EffectTypes.Parts_1, "Parts 1" },                                                                                                                     // Parts
		{ EffectTypes.Parts_10, "Parts 10" },                                                                                                                   // Parts
		{ EffectTypes.Parts_12, "Parts 12" },                                                                                                                   // Parts
		{ EffectTypes.Parts_14, "Parts 14" },                                                                                                                   // Parts
		{ EffectTypes.Parts_15, "Parts 15" },                                                                                                                   // Parts
		{ EffectTypes.Parts_2, "Parts 2" },                                                                                                                     // Parts
		{ EffectTypes.Parts_20, "Parts 20" },                                                                                                                   // Parts
		{ EffectTypes.Parts_3, "Parts 3" },                                                                                                                     // Parts
		{ EffectTypes.Parts_4, "Parts 4" },                                                                                                                     // Parts
		{ EffectTypes.Parts_5, "Parts 5" },                                                                                                                     // Parts
		{ EffectTypes.Parts_8, "Parts 8" },                                                                                                                     // Parts
		{ EffectTypes.Parts_For_Trade, "Parts for Trade" },                                                                                                     // Free Samples
		{ EffectTypes.Parts_In_Crude_Workshop, "Parts in Crude Workshop" },                                                                                     // Forge Trip Hammer
		{ EffectTypes.Parts_In_Smithy, "Parts in Smithy" },                                                                                                     // Forge Trip Hammer
		{ EffectTypes.Pause_Block, "Pause Block" },                                                                                                             // Shattered Obelisk
		{ EffectTypes.Petrified_Tree___Houses_Global_Capacity__1, "Petrified Tree - Houses Global Capacity -1" },                                               // Degradation
		{ EffectTypes.Petrified_Tree_Cutting_Speed___Normal, "Petrified Tree Cutting Speed - normal" },                                                         // Petrification
		{ EffectTypes.Pickled_Goods_15, "Pickled Goods 15" },                                                                                                   // Pickled Goods
		{ EffectTypes.Pickled_Goods_20, "Pickled Goods 20" },                                                                                                   // Pickled Goods
		{ EffectTypes.Pickled_Goods_30, "Pickled Goods 30" },                                                                                                   // Pickled Goods
		{ EffectTypes.Pickled_Goods_3pm, "Pickled goods 3pm" },                                                                                                 // Pickled Goods Delivery Line
		{ EffectTypes.Pickled_Goods_40, "Pickled Goods 40" },                                                                                                   // Pickled Goods
		{ EffectTypes.Pickled_Goods_5pm, "Pickled goods 5pm" },                                                                                                 // Pickled Goods Delivery Line
		{ EffectTypes.Pickled_Goods_60, "Pickled Goods 60" },                                                                                                   // Pickled Goods
		{ EffectTypes.Pickled_Goods_Plus1, "Pickled Goods +1" },                                                                                                // Pickle Jars
		{ EffectTypes.Pickled_Goods_Plus2, "Pickled Goods +2" },                                                                                                // Pickle Jars
		{ EffectTypes.Pickled_Goods_Plus3, "Pickled Goods +3" },                                                                                                // Pickle Jars
		{ EffectTypes.Pickled_Goods_Plus5, "Pickled Goods +5" },                                                                                                // Pickle Jars
		{ EffectTypes.Pie_20, "Pie 20" },                                                                                                                       // Basket of Pies
		{ EffectTypes.Pie_25, "Pie 25" },                                                                                                                       // Basket of Pies
		{ EffectTypes.Pie_30, "Pie 30" },                                                                                                                       // Basket of Pies
		{ EffectTypes.Pie_3pm, "Pie 3pm" },                                                                                                                     // Pie Delivery Line
		{ EffectTypes.Pie_40, "Pie 40" },                                                                                                                       // Basket of Pies
		{ EffectTypes.Pie_5pm, "Pie 5pm" },                                                                                                                     // Pie Delivery Line
		{ EffectTypes.Pie_Plus1, "Pie +1" },                                                                                                                    // Bigger Ovens
		{ EffectTypes.Pie_Plus2, "Pie +2" },                                                                                                                    // Bigger Ovens
		{ EffectTypes.Pie_Plus3, "Pie +3" },                                                                                                                    // Bigger Ovens
		{ EffectTypes.Pie_Plus5, "Pie +5" },                                                                                                                    // Bigger Ovens
		{ EffectTypes.Pipes_10, "Pipes 10" },                                                                                                                   // Pipes
		{ EffectTypes.Pipes_15, "Pipes 15" },                                                                                                                   // Pipes
		{ EffectTypes.Pipes_20, "Pipes 20" },                                                                                                                   // Pipes
		{ EffectTypes.Pipes_4, "Pipes 4" },                                                                                                                     // Pipes
		{ EffectTypes.Pipes_5, "Pipes 5" },                                                                                                                     // Pipes
		{ EffectTypes.Pipes_8, "Pipes 8" },                                                                                                                     // Pipes
		{ EffectTypes.Pipes_Plus1, "Pipes +1" },                                                                                                                // Stamping Die
		{ EffectTypes.Planks_10, "Planks 10" },                                                                                                                 // Box of Planks
		{ EffectTypes.Planks_15, "Planks 15" },                                                                                                                 // Box of Planks
		{ EffectTypes.Planks_2, "Planks 2" },                                                                                                                   // Box of Planks
		{ EffectTypes.Planks_20, "Planks 20" },                                                                                                                 // Box of Planks
		{ EffectTypes.Planks_25, "Planks 25" },                                                                                                                 // Box of Planks
		{ EffectTypes.Planks_3, "Planks 3" },                                                                                                                   // Box of Planks
		{ EffectTypes.Planks_30, "Planks 30" },                                                                                                                 // Box of Planks
		{ EffectTypes.Planks_5, "Planks 5" },                                                                                                                   // Box of Planks
		{ EffectTypes.Planks_Plus1, "Planks +1" },                                                                                                              // Reinforced Saw Blades
		{ EffectTypes.Planks_Plus2, "Planks +2" },                                                                                                              // Reinforced Saw Blades
		{ EffectTypes.Planks_Plus3, "Planks +3" },                                                                                                              // Reinforced Saw Blades
		{ EffectTypes.Planks_Plus5, "Planks +5" },                                                                                                              // Reinforced Saw Blades
		{ EffectTypes.Plant_Fiber_10, "Plant Fiber 10" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_15, "Plant Fiber 15" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_20, "Plant Fiber 20" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_25, "Plant Fiber 25" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_30, "Plant Fiber 30" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_35, "Plant Fiber 35" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_4, "Plant Fiber 4" },                                                                                                         // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_40, "Plant Fiber 40" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fiber_50, "Plant Fiber 50" },                                                                                                       // Bundle of Plant Fiber
		{ EffectTypes.Plant_Fibre_Plus1, "Plant Fibre +1" },                                                                                                    // Rich in Fiber
		{ EffectTypes.Plant_Fibre_Plus2, "Plant Fibre +2" },                                                                                                    // Rich in Fiber
		{ EffectTypes.Plant_Fibre_Plus3, "Plant Fibre +3" },                                                                                                    // Rich in Fiber
		{ EffectTypes.Plant_Fibre_Plus5, "Plant Fibre +5" },                                                                                                    // Rich in Fiber
		{ EffectTypes.Plantation__50, "Plantation -50" },                                                                                                       // Reinforced Tools
		{ EffectTypes.Plantation_Blueprint, "Plantation Blueprint" },                                                                                           // Plantation
		{ EffectTypes.Plantation_Plus100, "Plantation +100" }, 
		{ EffectTypes.Plantation_Plus150, "Plantation +150" }, 
		{ EffectTypes.Plantation_Plus25, "Plantation +25" },                                                                                                    // Large Baskets
		{ EffectTypes.Plantation_Plus50, "Plantation +50" },                                                                                                    // Large Baskets
		{ EffectTypes.PlantingRate__25, "PlantingRate -25" },                                                                                                   // Slow Planting
		{ EffectTypes.PlantingRate__50, "PlantingRate -50" },                                                                                                   // Slow Planting
		{ EffectTypes.PlantingRate__60, "PlantingRate -60" },                                                                                                   // Slow Planting
		{ EffectTypes.PlantingRate__70, "PlantingRate -70" },                                                                                                   // Slow Planting
		{ EffectTypes.PlantingRate__80, "PlantingRate -80" },                                                                                                   // Slow Planting
		{ EffectTypes.PlantingRate_Plus10, "PlantingRate +10" },                                                                                                // Seed Pouch
		{ EffectTypes.PlantingRate_Plus100, "PlantingRate +100" },                                                                                              // Fertilizer
		{ EffectTypes.PlantingRate_Plus25, "PlantingRate +25" },                                                                                                // Seed Pouch
		{ EffectTypes.PlantingRate_Plus30, "PlantingRate +30" },                                                                                                // Fertilizer
		{ EffectTypes.PlantingRate_Plus5, "PlantingRate +5" },                                                                                                  // Seed Pouch
		{ EffectTypes.PlantingRate_Plus50, "PlantingRate +50" },                                                                                                // Quick Planting
		{ EffectTypes.PlantingRate_Plus75, "PlantingRate +75" },                                                                                                // Fertilizer
		{ EffectTypes.Porridge_10, "Porridge 10" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_15, "Porridge 15" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_20, "Porridge 20" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_25, "Porridge 25" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_30, "Porridge 30" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_40, "Porridge 40" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_50, "Porridge 50" },                                                                                                             // Box of Porridge
		{ EffectTypes.Porridge_Plus1, "Porridge +1" },                                                                                                          // Puffed Grain
		{ EffectTypes.Porridge_Plus2, "Porridge +2" },                                                                                                          // Puffed Grain
		{ EffectTypes.Porridge_Plus3, "Porridge +3" },                                                                                                          // Puffed Grain
		{ EffectTypes.Porridge_Plus4, "Porridge +4" },                                                                                                          // Puffed Grain
		{ EffectTypes.Porridge_Plus5, "Porridge +5" },                                                                                                          // Puffed Grain
		{ EffectTypes.Porridge_Prod_For_Water, "Porridge Prod for water" },                                                                                     // Filling Dish
		{ EffectTypes.Pottery_10, "Pottery 10" },                                                                                                               // Box of Pottery
		{ EffectTypes.Pottery_20, "Pottery 20" },                                                                                                               // Box of Pottery
		{ EffectTypes.Pottery_3, "Pottery 3" },                                                                                                                 // Box of Pottery
		{ EffectTypes.Pottery_30, "Pottery 30" },                                                                                                               // Box of Pottery
		{ EffectTypes.Pottery_35, "Pottery 35" },                                                                                                               // Box of Pottery
		{ EffectTypes.Pottery_40, "Pottery 40" },                                                                                                               // Box of Pottery
		{ EffectTypes.Pottery_5, "Pottery 5" },                                                                                                                 // Box of Pottery
		{ EffectTypes.Pottery_5pm, "Pottery 5pm" },                                                                                                             // Pottery Delivery Line
		{ EffectTypes.Pottery_6, "Pottery 6" },                                                                                                                 // Box of Pottery
		{ EffectTypes.Pottery_For_Glade, "Pottery for Glade" },                                                                                                 // Archaeological Tools
		{ EffectTypes.Pottery_Plus1, "Pottery +1" },                                                                                                            // Rain-Powered Pottery Wheel
		{ EffectTypes.Pottery_Plus2, "Pottery +2" },                                                                                                            // Rain-Powered Pottery Wheel
		{ EffectTypes.Pottery_Plus3, "Pottery +3" },                                                                                                            // Rain-Powered Pottery Wheel
		{ EffectTypes.Pottery_Plus5, "Pottery +5" },                                                                                                            // Rain-Powered Pottery Wheel
		{ EffectTypes.Prayers, "Prayers" },                                                                                                                     // Prayers
		{ EffectTypes.Press_Blueprint, "Press Blueprint" },                                                                                                     // Press
		{ EffectTypes.ProdSpeedForEducation, "ProdSpeedForEducation" },                                                                                         // Work Safety Guide
		{ EffectTypes.Provisioner_Blueprint, "Provisioner Blueprint" },                                                                                         // Provisioner
		{ EffectTypes.Provisioner_Plus50, "Provisioner +50" },                                                                                                  // Reinforced Stoves
		{ EffectTypes.Provisions_For_Glade, "Provisions for Glade" },                                                                                           // Gathering Tools
		{ EffectTypes.Queens_Gift_10, "Queens Gift 10" },                                                                                                       // Purging Fire
		{ EffectTypes.Queens_Gift_15, "Queens Gift 15" },                                                                                                       // Purging Fire
		{ EffectTypes.Queens_Gift_5, "Queens Gift 5" },                                                                                                         // Purging Fire
		{ EffectTypes.Queens_Sailors, "Queens Sailors" },                                                                                                       // Queen's Sailors
		{ EffectTypes.Rain_Totem_Longer_Storm, "Rain Totem Longer Storm" }, 
		{ EffectTypes.Rain_Totem_Lower_Hostility, "Rain Totem Lower Hostility" },                                                                               // Converted Rain Totem
		{ EffectTypes.Rain_Totem_Shorter_Clearance, "Rain Totem Shorter Clearance" }, 
		{ EffectTypes.Rain_Totem_Shorter_Drizzle, "Rain Totem Shorter Drizzle" }, 
		{ EffectTypes.Rain_Totem_Slow, "Rain Totem Slow" },                                                                                                     // Curse of Weakness
		{ EffectTypes.Rainpuink_Drill___Spawn_Ore_Around___Coal, "Rainpuink Drill - Spawn Ore Around - Coal" },                                                 // Geological Survey
		{ EffectTypes.Rainpuink_Drill___Spawn_Ore_Around___Copper, "Rainpuink Drill - Spawn Ore Around - Copper" },                                             // Geological Survey
		{ EffectTypes.Rainpunk_Explosion___Big, "Rainpunk Explosion - Big" },                                                                                   // Magical Explosion
		{ EffectTypes.Rainpunk_Explosion___Noxious, "Rainpunk Explosion - Noxious" }, 
		{ EffectTypes.Rainpunk_Explosion___Small, "Rainpunk Explosion - Small" },                                                                               // Magical Explosion
		{ EffectTypes.Rainpunk_Explosion___Smallest, "Rainpunk Explosion - Smallest" },                                                                         // Discharge
		{ EffectTypes.Ranch_Blueprint, "Ranch Blueprint" },                                                                                                     // Ranch
		{ EffectTypes.Random_Goods_For_Dearth, "Random Goods for Dearth" },                                                                                     // Seized Inheritance
		{ EffectTypes.Random_Killed_10, "Random Killed 10" },                                                                                                   // Death from Beyond
		{ EffectTypes.Random_Killed_2___Blood_Missiles, "Random Killed 2 - Blood Missiles" }, 
		{ EffectTypes.Random_Killed_2___Kelpie_Missiles, "Random Killed 2 - Kelpie Missiles" },                                                                 // Watery Grave
		{ EffectTypes.Random_Killed_2___Missiles, "Random Killed 2 - Missiles" }, 
		{ EffectTypes.Random_Killed_3___Corruption, "Random Killed 3 - Corruption" },                                                                           // Voice of the Sealed Ones
		{ EffectTypes.Random_Killed_3___Missiles, "Random Killed 3 - Missiles" },                                                                               // Curse of the Forefathers
		{ EffectTypes.Random_Killed_5___Missiles, "Random Killed 5 - Missiles" },                                                                               // Curse of the Forefathers
		{ EffectTypes.Raw_Deposit_Charges__15, "Raw Deposit Charges -15" }, 
		{ EffectTypes.Raw_Deposit_Charges__5, "Raw Deposit Charges -5" }, 
		{ EffectTypes.RawDepositsCharges_10, "RawDepositsCharges_10" },                                                                                         // Rich Glades
		{ EffectTypes.RawDepositsCharges_20, "RawDepositsCharges_20" }, 
		{ EffectTypes.Rebelious_Spirit, "Rebelious Spirit" },                                                                                                   // Rebellious Spirit
		{ EffectTypes.Reed_Plus1, "Reed +1" },                                                                                                                  // Leather Gloves
		{ EffectTypes.Reed_Plus2, "Reed +2" },                                                                                                                  // Leather Gloves
		{ EffectTypes.Reed_Plus3, "Reed +3" },                                                                                                                  // Leather Gloves
		{ EffectTypes.Reed_Plus5, "Reed +5" },                                                                                                                  // Leather Gloves
		{ EffectTypes.Reeds_10, "Reeds 10" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_10pm, "Reeds 10pm" },                                                                                                               // Reed Delivery Line
		{ EffectTypes.Reeds_15, "Reeds 15" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_20, "Reeds 20" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_25, "Reeds 25" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_30, "Reeds 30" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_35, "Reeds 35" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_40, "Reeds 40" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_5, "Reeds 5" },                                                                                                                     // Bundle of Reeds
		{ EffectTypes.Reeds_50, "Reeds 50" },                                                                                                                   // Bundle of Reeds
		{ EffectTypes.Reeds_5pm, "Reeds 5pm" },                                                                                                                 // Reed Delivery Line
		{ EffectTypes.Reeds_8, "Reeds 8" },                                                                                                                     // Bundle of Reeds
		{ EffectTypes.Relic_Ritual_1, "Relic Ritual 1" },                                                                                                       // Forbidden Ritual
		{ EffectTypes.Relic_Ritual_2, "Relic Ritual 2" },                                                                                                       // Forbidden Ritual
		{ EffectTypes.Relic_Time_Reduction, "Relic time reduction" },                                                                                           // Firekeeper's Prayer
		{ EffectTypes.Relic_Working_TIme__10, "Relic Working TIme -10" }, 
		{ EffectTypes.Relic_Working_TIme__2, "Relic Working TIme -2" }, 
		{ EffectTypes.Relic_Working_TIme__20, "Relic Working TIme -20" }, 
		{ EffectTypes.Relic_Working_TIme__25, "Relic Working TIme -25" }, 
		{ EffectTypes.Relic_Working_TIme__7, "Relic Working TIme -7" }, 
		{ EffectTypes.Relic_Working_TIme_Plus10, "Relic Working TIme +10" }, 
		{ EffectTypes.Relics_Chance_For_Extra_Reward_100, "Relics Chance for Extra Reward 100" }, 
		{ EffectTypes.Relics_Chance_For_Extra_Reward_20, "Relics Chance for Extra Reward 20" }, 
		{ EffectTypes.Remove_Amber, "Remove Amber" }, 
		{ EffectTypes.Remove_Amber_And_Wine, "Remove Amber and Wine" },                                                                                         // Buried Riches
		{ EffectTypes.Remove_Buildings_Thunder, "Remove Buildings Thunder" },                                                                                   // Lightning Strike
		{ EffectTypes.Remove_Chests_From_Glades, "Remove Chests From Glades" },                                                                                 // Plundering
		{ EffectTypes.Remove_One_Cornerstone_Stag, "Remove one cornerstone Stag" },                                                                             // Stag's Echo
		{ EffectTypes.Replace_Angry_Ghost_Chest, "Replace Angry Ghost Chest" },                                                                                 // Ghost Chest
		{ EffectTypes.Replace_Blightrot, "Replace Blightrot" },                                                                                                 // Decay
		{ EffectTypes.Replace_Building_Advanced_Rain_Catcher, "Replace Building Advanced Rain Catcher" },                                                       // Advanced Rain Collector
		{ EffectTypes.Replace_Building_Alchemist, "Replace Building Alchemist" },                                                                               // Alchemist's Hut
		{ EffectTypes.Replace_Building_Apotchecary, "Replace Building Apotchecary" },                                                                           // Apothecary
		{ EffectTypes.Replace_Building_Artisan, "Replace Building Artisan" },                                                                                   // Artisan
		{ EffectTypes.Replace_Building_Bakery, "Replace Building Bakery" },                                                                                     // Bakery
		{ EffectTypes.Replace_Building_Bath_House, "Replace Building Bath House" },                                                                             // Bath House
		{ EffectTypes.Replace_Building_Beanery, "Replace Building Beanery" },                                                                                   // Beanery
		{ EffectTypes.Replace_Building_Beaver_House, "Replace Building Beaver House" },                                                                         // Beaver House
		{ EffectTypes.Replace_Building_Big_Shelter, "Replace Building Big Shelter" },                                                                           // Big Shelter
		{ EffectTypes.Replace_Building_Brewery, "Replace Building Brewery" },                                                                                   // Brewery
		{ EffectTypes.Replace_Building_Brick_Oven, "Replace Building Brick Oven" },                                                                             // Brick Oven
		{ EffectTypes.Replace_Building_Brickyard, "Replace Building Brickyard" },                                                                               // Brickyard
		{ EffectTypes.Replace_Building_Butcher, "Replace Building Butcher" },                                                                                   // Butcher
		{ EffectTypes.Replace_Building_Carpenter, "Replace Building Carpenter" },                                                                               // Carpenter
		{ EffectTypes.Replace_Building_Cellar, "Replace Building Cellar" },                                                                                     // Cellar
		{ EffectTypes.Replace_Building_Clan_Hall, "Replace Building Clan Hall" },                                                                               // Clan Hall
		{ EffectTypes.Replace_Building_Clay_Pit, "Replace Building Clay Pit" },                                                                                 // Clay Pit
		{ EffectTypes.Replace_Building_Cookhouse, "Replace Building Cookhouse" },                                                                               // Cookhouse
		{ EffectTypes.Replace_Building_Cooperage, "Replace Building Cooperage" },                                                                               // Cooperage
		{ EffectTypes.Replace_Building_Crude_Workstation, "Replace Building Crude Workstation" },                                                               // Crude Workstation
		{ EffectTypes.Replace_Building_Distillery, "Replace Building Distillery" },                                                                             // Distillery
		{ EffectTypes.Replace_Building_Druid, "Replace Building Druid" },                                                                                       // Druid's Hut
		{ EffectTypes.Replace_Building_Explorers_Lodge, "Replace Building Explorers Lodge" },                                                                   // Explorers' Lodge
		{ EffectTypes.Replace_Building_Farm, "Replace Building Farm" },                                                                                         // Homestead
		{ EffectTypes.Replace_Building_Field_Kitchen, "Replace Building Field Kitchen" },                                                                       // Field Kitchen
		{ EffectTypes.Replace_Building_Finesmith, "Replace Building Finesmith" },                                                                               // Finesmith
		{ EffectTypes.Replace_Building_Foragers_Camp, "Replace Building Foragers Camp" },                                                                       // Foragers' Camp
		{ EffectTypes.Replace_Building_Foragers_Camp_Primitive, "Replace Building Foragers Camp Primitive" },                                                   // Small Foragers' Camp
		{ EffectTypes.Replace_Building_Forum, "Replace Building Forum" },                                                                                       // Forum
		{ EffectTypes.Replace_Building_Fox_House, "Replace Building Fox House" },                                                                               // Fox House
		{ EffectTypes.Replace_Building_Furnace, "Replace Building Furnace" },                                                                                   // Furnace
		{ EffectTypes.Replace_Building_Granary, "Replace Building Granary" },                                                                                   // Granary
		{ EffectTypes.Replace_Building_Greenhouse, "Replace Building Greenhouse" },                                                                             // Greenhouse
		{ EffectTypes.Replace_Building_Grill, "Replace Building Grill" },                                                                                       // Grill
		{ EffectTypes.Replace_Building_Grove, "Replace Building Grove" },                                                                                       // Forester's Hut
		{ EffectTypes.Replace_Building_Guild_House, "Replace Building Guild House" },                                                                           // Guild House
		{ EffectTypes.Replace_Building_Harpy_House, "Replace Building Harpy House" },                                                                           // Harpy House
		{ EffectTypes.Replace_Building_Harvester_Camp, "Replace Building Harvester Camp" },                                                                     // Harvesters' Camp
		{ EffectTypes.Replace_Building_Haunted_Beaver_House, "Replace Building Haunted Beaver House" },                                                         // Purified Beaver House
		{ EffectTypes.Replace_Building_Haunted_Brewery, "Replace Building Haunted Brewery" },                                                                   // Flawless Brewery
		{ EffectTypes.Replace_Building_Haunted_Cellar, "Replace Building Haunted Cellar" },                                                                     // Flawless Cellar
		{ EffectTypes.Replace_Building_Haunted_Cooperage, "Replace Building Haunted Cooperage" },                                                               // Flawless Cooperage
		{ EffectTypes.Replace_Building_Haunted_Druid, "Replace Building Haunted Druid" },                                                                       // Flawless Druid's Hut
		{ EffectTypes.Replace_Building_Haunted_Fox_House, "Replace Building Haunted Fox House" },                                                               // Purified Fox House
		{ EffectTypes.Replace_Building_Haunted_Harpy_House, "Replace Building Haunted Harpy House" },                                                           // Purified Harpy House
		{ EffectTypes.Replace_Building_Haunted_Herb_Garden, "Replace Building Haunted Herb Garden" },                                                           // Hallowed Herb Garden
		{ EffectTypes.Replace_Building_Haunted_Human_House, "Replace Building Haunted Human House" },                                                           // Purified Human House
		{ EffectTypes.Replace_Building_Haunted_Leatherworks, "Replace Building Haunted Leatherworks" },                                                         // Flawless Leatherworker
		{ EffectTypes.Replace_Building_Haunted_Lizard_House, "Replace Building Haunted Lizard House" },                                                         // Purified Lizard House
		{ EffectTypes.Replace_Building_Haunted_Market, "Replace Building Haunted Market" },                                                                     // Holy Market
		{ EffectTypes.Replace_Building_Haunted_Rainmill, "Replace Building Haunted Rainmill" },                                                                 // Flawless Rain Mill
		{ EffectTypes.Replace_Building_Haunted_SmallFarm, "Replace Building Haunted SmallFarm" },                                                               // Hallowed Small Farm
		{ EffectTypes.Replace_Building_Haunted_Smelter, "Replace Building Haunted Smelter" },                                                                   // Flawless Smelter
		{ EffectTypes.Replace_Building_Haunted_Temple, "Replace Building Haunted Temple" },                                                                     // Holy Temple
		{ EffectTypes.Replace_Building_Hearth, "Replace Building Hearth" },                                                                                     // Ancient Hearth
		{ EffectTypes.Replace_Building_Herb_Garden, "Replace Building Herb Garden" },                                                                           // Herb Garden
		{ EffectTypes.Replace_Building_Herbalist_Camp, "Replace Building Herbalist Camp" },                                                                     // Herbalists' Camp
		{ EffectTypes.Replace_Building_Herbalist_Camp_Primitive, "Replace Building Herbalist Camp Primitive" },                                                 // Small Herbalists' Camp
		{ EffectTypes.Replace_Building_Human_House, "Replace Building Human House" },                                                                           // Human House
		{ EffectTypes.Replace_Building_Kiln, "Replace Building Kiln" },                                                                                         // Kiln
		{ EffectTypes.Replace_Building_Leatherworks, "Replace Building Leatherworks" },                                                                         // Leatherworker
		{ EffectTypes.Replace_Building_Library, "Replace Building Library" },                                                                                   // Library
		{ EffectTypes.Replace_Building_Lizard_House, "Replace Building Lizard House" },                                                                         // Lizard House
		{ EffectTypes.Replace_Building_Lumbermill, "Replace Building Lumbermill" },                                                                             // Lumber Mill
		{ EffectTypes.Replace_Building_Makeshift_Post, "Replace Building Makeshift Post" },                                                                     // Makeshift Post
		{ EffectTypes.Replace_Building_Manufactory, "Replace Building Manufactory" },                                                                           // Manufactory
		{ EffectTypes.Replace_Building_Market, "Replace Building Market" },                                                                                     // Market
		{ EffectTypes.Replace_Building_Mine, "Replace Building Mine" },                                                                                         // Mine
		{ EffectTypes.Replace_Building_Monastery, "Replace Building Monastery" },                                                                               // Monastery
		{ EffectTypes.Replace_Building_Plantation, "Replace Building Plantation" },                                                                             // Plantation
		{ EffectTypes.Replace_Building_Press, "Replace Building Press" },                                                                                       // Press
		{ EffectTypes.Replace_Building_Provisioner, "Replace Building Provisioner" },                                                                           // Provisioner
		{ EffectTypes.Replace_Building_Rain_Catcher, "Replace Building Rain Catcher" },                                                                         // Rain Collector
		{ EffectTypes.Replace_Building_Rainmill, "Replace Building Rainmill" },                                                                                 // Rain Mill
		{ EffectTypes.Replace_Building_Rainpunk_Foundry, "Replace Building Rainpunk Foundry" },                                                                 // Rainpunk Foundry
		{ EffectTypes.Replace_Building_Ranch, "Replace Building Ranch" },                                                                                       // Ranch
		{ EffectTypes.Replace_Building_Scribe, "Replace Building Scribe" },                                                                                     // Scribe
		{ EffectTypes.Replace_Building_Sewer, "Replace Building Sewer" },                                                                                       // Clothier
		{ EffectTypes.Replace_Building_Shelter, "Replace Building Shelter" },                                                                                   // Shelter
		{ EffectTypes.Replace_Building_SmallFarm, "Replace Building SmallFarm" },                                                                               // Small Farm
		{ EffectTypes.Replace_Building_Smelter, "Replace Building Smelter" },                                                                                   // Smelter
		{ EffectTypes.Replace_Building_Smithy, "Replace Building Smithy" },                                                                                     // Smithy
		{ EffectTypes.Replace_Building_Smokehouse, "Replace Building Smokehouse" },                                                                             // Smokehouse
		{ EffectTypes.Replace_Building_Stamping_Mill, "Replace Building Stamping Mill" },                                                                       // Stamping Mill
		{ EffectTypes.Replace_Building_Stonecutters_Camp, "Replace Building Stonecutters Camp" },                                                               // Stonecutters' Camp
		{ EffectTypes.Replace_Building_Storage, "Replace Building Storage" },                                                                                   // Small Warehouse
		{ EffectTypes.Replace_Building_Supplier, "Replace Building Supplier" },                                                                                 // Supplier
		{ EffectTypes.Replace_Building_Tavern, "Replace Building Tavern" },                                                                                     // Tavern
		{ EffectTypes.Replace_Building_Tea_Doctor, "Replace Building Tea Doctor" },                                                                             // Tea Doctor
		{ EffectTypes.Replace_Building_Tea_House, "Replace Building Tea House" },                                                                               // Teahouse
		{ EffectTypes.Replace_Building_Temple, "Replace Building Temple" },                                                                                     // Temple
		{ EffectTypes.Replace_Building_Tinctury, "Replace Building Tinctury" },                                                                                 // Tinctury
		{ EffectTypes.Replace_Building_Tinkerer, "Replace Building Tinkerer" },                                                                                 // Tinkerer
		{ EffectTypes.Replace_Building_Toolshop, "Replace Building Toolshop" },                                                                                 // Toolshop
		{ EffectTypes.Replace_Building_TradingPost, "Replace Building TradingPost" },                                                                           // Trading Post
		{ EffectTypes.Replace_Building_Trappers_Camp, "Replace Building Trappers Camp" },                                                                       // Trappers' Camp
		{ EffectTypes.Replace_Building_Trappers_Camp_Primitive, "Replace Building Trappers Camp Primitive" },                                                   // Small Trappers' Camp
		{ EffectTypes.Replace_Building_Weaver, "Replace Building Weaver" },                                                                                     // Weaver
		{ EffectTypes.Replace_Building_Woodcutters_Camp, "Replace Building Woodcutters Camp" },                                                                 // Woodcutters' Camp
		{ EffectTypes.Replace_Building_Workshop, "Replace Building Workshop" },                                                                                 // Workshop
		{ EffectTypes.Replace_Calm_Ghost_Chest, "Replace Calm Ghost Chest" },                                                                                   // Decay
		{ EffectTypes.Replace_Decay_Altar, "Replace Decay Altar" },                                                                                             // Converted Altar of Decay
		{ EffectTypes.Replace_Fishmen_Lighthouse, "Replace Fishmen Lighthouse" },                                                                               // Termite Nest
		{ EffectTypes.Replace_Fuming_Machinery, "Replace Fuming Machinery" },                                                                                   // Makeshift Extractor
		{ EffectTypes.Replace_Harmony_Altar, "Replace Harmony Altar" },                                                                                         // Converted Harmony Spirit Altar
		{ EffectTypes.Replace_Monolith, "Replace Monolith" },                                                                                                   // Obelisk
		{ EffectTypes.Replace_Noria, "Replace Noria" },                                                                                                         // Rainpunk Noria
		{ EffectTypes.Replace_Rain_Totem, "Replace Rain Totem" },                                                                                               // Converted Rain Totem
		{ EffectTypes.Replace_Sacrifice_Totem, "Replace Sacrifice Totem" },                                                                                     // Converted Totem of Denial
		{ EffectTypes.Replace_Stormbird, "Replace Stormbird" },                                                                                                 // Tamed Stormbird
		{ EffectTypes.Replace_Termite_Burrow, "Replace Termite Burrow" },                                                                                       // Termite Nest
		{ EffectTypes.Replace_With_Scorpion_2, "Replace With Scorpion 2" },                                                                                     // Excavation 
		{ EffectTypes.Replace_With_Scorpion_3, "Replace With Scorpion 3" },                                                                                     // Conservation
		{ EffectTypes.Replace_With_Scorpion_Positive, "Replace With Scorpion Positive" },                                                                       // Reconstruction
		{ EffectTypes.Replace_With_Snake_2, "Replace With Snake 2" },                                                                                           // Excavation 
		{ EffectTypes.Replace_With_Snake_3, "Replace With Snake 3" },                                                                                           // Conservation
		{ EffectTypes.Replace_With_Snake_Positive, "Replace With Snake Positive" },                                                                             // Reconstruction
		{ EffectTypes.Replace_With_Spider_2, "Replace With Spider 2" },                                                                                         // Excavation 
		{ EffectTypes.Replace_With_Spider_3, "Replace With Spider 3" },                                                                                         // Conservation
		{ EffectTypes.Replace_With_Spider_Positive, "Replace With Spider Positive" },                                                                           // Reconstruction
		{ EffectTypes.Reputation_From_Trade, "Reputation from Trade" },                                                                                         // Trade Hub
		{ EffectTypes.ReputationForLuxury, "ReputationForLuxury" },                                                                                             // Land of Luxury
		{ EffectTypes.ReputationPenaltyRate_15, "ReputationPenaltyRate 15" }, 
		{ EffectTypes.ReputationPenaltyRate_4, "ReputationPenaltyRate 4" }, 
		{ EffectTypes.ReputationPenaltyRate_5, "ReputationPenaltyRate 5" }, 
		{ EffectTypes.ReputationPenaltyRate_HearthEffect_Human, "ReputationPenaltyRate_HearthEffect_Human" },                                                   // Beacon
		{ EffectTypes.ReputationPenaltyRate_Vault_100, "ReputationPenaltyRate Vault 100" },                                                                     // Irresponsible Archaeology
		{ EffectTypes.ReputationPenaltyRate_Vault_125, "ReputationPenaltyRate Vault 125" },                                                                     // Irresponsible Archaeology
		{ EffectTypes.ReputationPenaltyRate_Vault_150, "ReputationPenaltyRate Vault 150" },                                                                     // Irresponsible Archaeology
		{ EffectTypes.ReputationPenaltyRate_Vault_175, "ReputationPenaltyRate Vault 175" },                                                                     // Irresponsible Archaeology
		{ EffectTypes.Resilience_Resolve_Drops_Faster, "Resilience Resolve Drops Faster" },                                                                     // Sensitivity
		{ EffectTypes.Resin_10, "Resin 10" },                                                                                                                   // Resin
		{ EffectTypes.Resin_15, "Resin 15" },                                                                                                                   // Resin
		{ EffectTypes.Resin_2, "Resin 2" },                                                                                                                     // Resin
		{ EffectTypes.Resin_20, "Resin 20" },                                                                                                                   // Resin
		{ EffectTypes.Resin_25, "Resin 25" },                                                                                                                   // Resin
		{ EffectTypes.Resin_30, "Resin 30" },                                                                                                                   // Resin
		{ EffectTypes.Resin_3pm, "Resin 3pm" },                                                                                                                 // Resin Delivery Line
		{ EffectTypes.Resin_4, "Resin 4" },                                                                                                                     // Resin
		{ EffectTypes.Resin_40, "Resin 40" },                                                                                                                   // Resin
		{ EffectTypes.Resin_5pm, "Resin 5pm" },                                                                                                                 // Resin Delivery Line
		{ EffectTypes.Resin_6, "Resin 6" },                                                                                                                     // Resin
		{ EffectTypes.Resin_Plus1, "Resin +1" },                                                                                                                // Bleeding Trees
		{ EffectTypes.Resin_Plus2, "Resin +2" },                                                                                                                // Bleeding Trees
		{ EffectTypes.Resin_Plus3, "Resin +3" },                                                                                                                // Bleeding Trees
		{ EffectTypes.Resin_Plus5, "Resin +5" },                                                                                                                // Bleeding Trees
		{ EffectTypes.Resolve___Institution_Resolve_For_Ruins, "Resolve - Institution Resolve for Ruins" },                                                     // The Crown Chronicles
		{ EffectTypes.Resolve___Institution_Resolve_For_Sales, "Resolve - Institution Resolve for Sales" },                                                     // The Guild's Welfare
		{ EffectTypes.Resolve___Resolve_For_Chests, "Resolve - Resolve for chests" },                                                                           // Prosperous Archaeology
		{ EffectTypes.Resolve___Resolve_For_Sales, "Resolve - Resolve for sales" },                                                                             // Prosperous Settlement
		{ EffectTypes.Resolve___Resolve_For_Standing, "Resolve - Resolve for Standing" },                                                                       // Friendly Relations
		{ EffectTypes.Resolve_For_Chests, "Resolve for chests" },                                                                                               // Prosperous Archaeology
		{ EffectTypes.Resolve_For_Complex_Food, "Resolve for complex food" },                                                                                   // Vitality
		{ EffectTypes.Resolve_For_Consumption, "Resolve for consumption" },                                                                                     // Generous Rations
		{ EffectTypes.Resolve_For_Glade, "Resolve for Glade" },                                                                                                 // Woodcutter's Song
		{ EffectTypes.Resolve_For_Glade___Resolve_Bonus_Effect, "Resolve for Glade - Resolve Bonus Effect" },                                                   // Woodcutter's Song
		{ EffectTypes.Resolve_For_Glade___Resolve_Bonus_Effect___Holder, "Resolve for Glade - Resolve Bonus Effect - Holder" },                                 // Inspiring Work
		{ EffectTypes.Resolve_For_Impatience, "Resolve for Impatience" },                                                                                       // Rebellious Spirit
		{ EffectTypes.Resolve_For_Incense_Humans, "Resolve for Incense Humans" },                                                                               // Sweet Aroma
		{ EffectTypes.Resolve_For_Reputation, "Resolve for Reputation" },                                                                                       // Long Live the Queen
		{ EffectTypes.Resolve_For_Sales, "Resolve For Sales" },                                                                                                 // Prosperous Settlement
		{ EffectTypes.Resolve_For_Services, "Resolve for Services" },                                                                                           // Converted Harmony Spirit Altar
		{ EffectTypes.Resolve_For_Standing, "Resolve for Standing" },                                                                                           // Friendly Relations
		{ EffectTypes.Resolve_For_Started_Route, "Resolve for started Route" },                                                                                 // Frequent Caravans
		{ EffectTypes.Resolve_For_Started_Route___Impatience_Slower, "Resolve for started Route - impatience slower" },                                         // Frequent Caravans
		{ EffectTypes.Resolve_For_Started_Route___Impatience_Slower___Holder, "Resolve for started Route - impatience slower - Holder" },                       // Bustling Town
		{ EffectTypes.Resolve_For_Tea_Harpies, "Resolve for Tea Harpies" },                                                                                     // Health Infusion
		{ EffectTypes.Resolve_For_Training_Gear_Lizards, "Resolve for Training Gear Lizards" },                                                                 // Armed to the Teeth
		{ EffectTypes.Resolve_For_Trees___Fishmen___Hard, "Resolve for Trees - Fishmen - hard" },                                                               // Creeping Fishmen
		{ EffectTypes.Resolve_For_Trees___Fishmen___Impossible, "Resolve for Trees - Fishmen - impossible" },                                                   // Creeping Fishmen
		{ EffectTypes.Resolve_For_Trees___Fishmen___Normal, "Resolve for Trees - Fishmen - normal" },                                                           // Creeping Fishmen
		{ EffectTypes.Resolve_For_Trees___Fishmen___Very_Hard, "Resolve for Trees - Fishmen - very hard" },                                                     // Creeping Fishmen
		{ EffectTypes.Resolve_For_Wine_Beavers, "Resolve for Wine Beavers" },                                                                                   // Vineyard Town
		{ EffectTypes.Resolve_Penalty_For_Every_10_Amber___Hard, "Resolve Penalty for every 10 amber - hard" },                                                 // Robbed Dead
		{ EffectTypes.Resolve_Penalty_For_Every_10_Amber___Impossible, "Resolve Penalty for every 10 amber - impossible" },                                     // Robbed Dead
		{ EffectTypes.Resolve_Penalty_For_Every_10_Amber___Normal, "Resolve Penalty for every 10 amber - normal" },                                             // Robbed Dead
		{ EffectTypes.Resolve_Penalty_For_Every_10_Amber___Very_Hard, "Resolve Penalty for every 10 amber - very hard" },                                       // Robbed Dead
		{ EffectTypes.Resolve_To_Reputation__50, "Resolve To Reputation -50" }, 
		{ EffectTypes.Resolve_To_Reputation__75, "Resolve To Reputation -75" }, 
		{ EffectTypes.Resolve_To_Reputation__80, "Resolve To Reputation -80" }, 
		{ EffectTypes.Resolve_To_Reputation_Plus20, "Resolve To Reputation +20" }, 
		{ EffectTypes.Resolve_To_Reputation_Plus5, "Resolve To Reputation +5" }, 
		{ EffectTypes.Resolve_To_Reputation_Plus50, "Resolve To Reputation +50" }, 
		{ EffectTypes.Rewards_Pack_Big, "Rewards Pack Big" },                                                                                                   // Big Mystery Box
		{ EffectTypes.Rewards_Pack_Big_1, "Rewards Pack Big 1" },                                                                                               // Big Mystery Box
		{ EffectTypes.Rewards_Pack_Medium, "Rewards Pack Medium" },                                                                                             // Medium Mystery Box
		{ EffectTypes.Rewards_Pack_Medium_1, "Rewards Pack Medium 1" },                                                                                         // Medium Mystery Box
		{ EffectTypes.Rewards_Pack_Small, "Rewards Pack Small" },                                                                                               // Small Mystery Box
		{ EffectTypes.Rewards_Pack_Small_1, "Rewards Pack Small 1" },                                                                                           // Small Mystery Box
		{ EffectTypes.Root_For_Every_Glade, "Root for every glade" },                                                                                           // Grubbing Tools
		{ EffectTypes.Roots_10, "Roots 10" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_10pm, "Roots 10pm" },                                                                                                               // Root Delivery Line
		{ EffectTypes.Roots_15, "Roots 15" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_20, "Roots 20" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_30, "Roots 30" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_3pm, "Roots 3pm" },                                                                                                                 // Root Delivery Line
		{ EffectTypes.Roots_40, "Roots 40" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_50, "Roots 50" },                                                                                                                   // Pack of Roots
		{ EffectTypes.Roots_5pm, "Roots 5pm" },                                                                                                                 // Root Delivery Line
		{ EffectTypes.Roots_Plus1, "Roots +1" },                                                                                                                // Steel Penknives
		{ EffectTypes.Roots_Plus2, "Roots +2" },                                                                                                                // Steel Penknives
		{ EffectTypes.Roots_Plus3, "Roots +3" },                                                                                                                // Steel Penknives
		{ EffectTypes.Roots_Plus5, "Roots +5" },                                                                                                                // Steel Penknives
		{ EffectTypes.Rotting_Wood_Workplace, "Rotting Wood Workplace" },                                                                                       // Rotting Wood
		{ EffectTypes.Route_Less_Travel_Time, "Route Less Travel Time" },                                                                                       // Stormwalker Training
		{ EffectTypes.Route_Less_Travel_Time_33, "Route Less Travel Time 33" }, 
		{ EffectTypes.Route_Less_Travel_Time_5, "Route Less Travel Time 5" },                                                                                   // Stormwalker Training
		{ EffectTypes.Royal_Guard_Training, "Royal Guard Training" },                                                                                           // Royal Guard Training
		{ EffectTypes.Royal_Guard_Training___NeedPerk, "Royal Guard Training - NeedPerk" }, 
		{ EffectTypes.Sacrifice_Block_During_Corruption, "Sacrifice Block during Corruption" },                                                                 // Baptism of Fire
		{ EffectTypes.Sacrifice_Cost_20_Shorter, "Sacrifice Cost 20 Shorter" }, 
		{ EffectTypes.Sacrifice_Cost_25_Longer, "Sacrifice Cost 25 Longer" }, 
		{ EffectTypes.Sacrifice_Cost_25_Shorter, "Sacrifice Cost 25 Shorter" }, 
		{ EffectTypes.Sacrifice_Cost_3_Longer, "Sacrifice Cost 3 Longer" },                                                                                     // Fiery Wrath
		{ EffectTypes.Sacrifice_Cost_30_Longer, "Sacrifice Cost 30 Longer" }, 
		{ EffectTypes.Sacrifice_Cost_33_Longer, "Sacrifice Cost 33 Longer" }, 
		{ EffectTypes.Sacrifice_Cost_5_Longer, "Sacrifice Cost 5 Longer" },                                                                                     // Fiery Wrath
		{ EffectTypes.Sacrifice_Cost_50_Longer, "Sacrifice Cost 50 Longer" }, 
		{ EffectTypes.Sacrifice_Cost_For_Impatience, "Sacrifice Cost for Impatience" },                                                                         // Fiery Wrath
		{ EffectTypes.Sacrifice_Stack_For_Route, "Sacrifice Stack for Route" },                                                                                 // Firekeeper Letters
		{ EffectTypes.Sacrifice_Stack_Plus1, "Sacrifice Stack +1" }, 
		{ EffectTypes.Sacrificed_1, "Sacrificed 1" }, 
		{ EffectTypes.Sacrificed_1_Noxious_Machinery, "Sacrificed 1 Noxious Machinery" }, 
		{ EffectTypes.Sacrificed_3___Plague_Of_Death, "Sacrificed 3 - Plague of Death" }, 
		{ EffectTypes.SacrificeTotemPositive, "SacrificeTotemPositive" },                                                                                       // Converted Totem of Denial
		{ EffectTypes.SaveVillagersForAncientTablets, "SaveVillagersForAncientTablets" },                                                                       // Escaping the Shadows
		{ EffectTypes.Scout_Plus10, "Scout +10" },                                                                                                              // Scout's Pack
		{ EffectTypes.Scout_Plus15, "Scout +15" },                                                                                                              // Scout's Pack
		{ EffectTypes.Scout_Plus3, "Scout +3" },                                                                                                                // Scout's Pack
		{ EffectTypes.Scout_Plus5, "Scout +5" },                                                                                                                // Scout's Pack
		{ EffectTypes.Scout_Speed_Plus5, "Scout Speed +5" }, 
		{ EffectTypes.Scribe_Blueprint, "Scribe Blueprint" },                                                                                                   // Scribe
		{ EffectTypes.SE_Amber_For_Trade, "SE Amber for Trade" },                                                                                               // Royal Funding
		{ EffectTypes.SE_Berries_Plus3, "SE Berries +3" },                                                                                                      // Berry New Year
		{ EffectTypes.SE_Building_Materials_Prod_Penalty, "SE Building Materials Prod Penalty" },                                                               // Acid Rain
		{ EffectTypes.SE_Clearance_For_Drizzle, "SE Clearance for Drizzle" },                                                                                   // Golden Dust
		{ EffectTypes.SE_Corruption_Favoring_Block, "[SE] Corruption Favoring Block" },                                                                         // Unyielding Corruption
		{ EffectTypes.SE_Creeping_Shadows, "SE Creeping Shadows" },                                                                                             // Creeping Shadows
		{ EffectTypes.SE_Creeping_Shadows___Resolve_Penalty_Effect, "SE Creeping Shadows - Resolve Penalty Effect" },                                           // Creeping Shadows
		{ EffectTypes.SE_Creeping_Shadows___Resolve_Penalty_Effect___Holder, "SE Creeping Shadows - Resolve Penalty Effect - Holder" },                         // Shadowy Figure
		{ EffectTypes.SE_Cricket_Mating_Grounds, "SE Cricket Mating Grounds" },                                                                                 // Cricket Mating Grounds
		{ EffectTypes.SE_Cysts_Generate_Impatience_In_Storm, "SE Cysts generate Impatience in Storm" },                                                         // Spreading Contamination
		{ EffectTypes.SE_Dang_Glades_Reduces_Resolve_In_Storm, "SE Dang Glades reduces resolve in Storm" },                                                     // Greater Threat
		{ EffectTypes.SE_Death_Blightrot, "SE Death Blightrot" },                                                                                               // Blightrot Infection
		{ EffectTypes.SE_Destroy_Nodes, "SE Destroy Nodes" },                                                                                                   // Unnatural Erosion
		{ EffectTypes.SE_Devastating_Storms, "SE Devastating Storms" },                                                                                         // Devastating Storms
		{ EffectTypes.SE_Drizzle_Water_Per_Minute, "[SE] Drizzle Water per minute" },                                                                           // Drizzle Anomaly
		{ EffectTypes.SE_Drizzle_Water_Plus3, "SE Drizzle Water +3" },                                                                                          // Heavy Drops
		{ EffectTypes.SE_Fast_Food, "SE Fast Food" },                                                                                                           // Salty Breeze
		{ EffectTypes.SE_Fertile_Nodes, "SE Fertile Nodes" },                                                                                                   // Soil Reclamation
		{ EffectTypes.SE_Food_Consumption, "SE Food Consumption" },                                                                                             // Insatiable Hunger
		{ EffectTypes.SE_Food_Production_Speed__15, "SE Food Production Speed -15" },                                                                           // Rot from the Sky
		{ EffectTypes.SE_FuelRate, "SE FuelRate" },                                                                                                             // Piercing Winds
		{ EffectTypes.SE_FuelRateHostility, "SE FuelRateHostility" },                                                                                           // Humid Climate
		{ EffectTypes.SE_Gatherer_Production_Speed__50, "SE Gatherer Production Speed -50" },                                                                   // Quaking Bog
		{ EffectTypes.SE_Gatherer_Production_Speed_Plus50, "SE Gatherer Production Speed +50" },                                                                // Fruitful Season
		{ EffectTypes.SE_Gatherers_Prod_Plus100, "SE Gatherers Prod +100" },                                                                                    // Rich Branches
		{ EffectTypes.SE_Gift_For_Reputation, "SE Gift for Reputation" },                                                                                       // Forgiving Crown
		{ EffectTypes.SE_Gift_From_The_Woods, "SE Gift from the Woods" },                                                                                       // Gift from the Woods
		{ EffectTypes.SE_Glades_Resolve_In_Drizzle, "SE Glades Resolve in Drizzle" },                                                                           // Gentle Dawn
		{ EffectTypes.SE_Global_Production_Speed__15, "SE Global Production Speed -15" },                                                                       // Overheating
		{ EffectTypes.SE_Goods_For_Solved_Relics, "SE Goods for Solved Relics" },                                                                               // Forest Offerings
		{ EffectTypes.SE_Grain_In_Harvester, "SE Grain in Harvester" },                                                                                         // Soft Stems
		{ EffectTypes.SE_Grass_Around_Removed_Deposits, "SE Grass Around Removed Deposits" },                                                                   // TODO NAME
		{ EffectTypes.SE_Grim_Fate, "SE Grim Fate" },                                                                                                           // Grim Fate
		{ EffectTypes.SE_Hearth_Sacrifice_Block, "SE Hearth Sacrifice Block" },                                                                                 // Cursed Rain
		{ EffectTypes.SE_Hot_Springs, "SE Hot Springs" },                                                                                                       // Hot Springs
		{ EffectTypes.SE_Hunger_Storm, "SE Hunger Storm" },                                                                                                     // Hunger Storm
		{ EffectTypes.SE_Late_Newcomers, "SE Late Newcomers" },                                                                                                 // Shifting Paths
		{ EffectTypes.SE_Late_Newcomers___Child, "[SE] Late Newcomers - child" },                                                                               // Unyielding Corruption
		{ EffectTypes.SE_Late_Newcomers___Holder, "[SE] Late Newcomers - holder" },                                                                             // Lost Newcomers
		{ EffectTypes.SE_Lightning, "SE Lightning" },                                                                                                           // Devastation
		{ EffectTypes.SE_Living_Farmfield, "SE Living Farmfield" },                                                                                             // Rotten Rain
		{ EffectTypes.SE_Longer_Break_Interval, "SE Longer Break Interval" },                                                                                   // Inspiring View
		{ EffectTypes.SE_Low_Engines_Blight_Rate, "SE Low Engines Blight Rate" },                                                                               // Natural Filtration
		{ EffectTypes.SE_M0_60_Off_Roads_Muddy_Ground, "SE M0_60 Off Roads [Muddy Ground]" },                                                                   // Muddy Ground
		{ EffectTypes.SE_Marrow_Mine, "SE Marrow Mine" },                                                                                                       // Marrow Growth
		{ EffectTypes.SE_Meat_Plus3, "SE Meat +3" },                                                                                                            // Mating Season
		{ EffectTypes.SE_Metal_Prod_Penalty, "SE Metal Prod Penalty" },                                                                                         // Corrosive Rainfall
		{ EffectTypes.SE_Mine_In_Storm, "SE Mine in Storm" },                                                                                                   // Horrors from Beneath
		{ EffectTypes.SE_More_Event_Goods, "[SE] More event goods" },                                                                                           // Scavenging Season
		{ EffectTypes.SE_More_Water_Consumption, "SE More Water Consumption" },                                                                                 // Vanishing Water
		{ EffectTypes.SE_Mushroom_Plus3, "SE Mushroom +3" },                                                                                                    // Mushrooms After Rain
		{ EffectTypes.SE_No_Impatience_Reduction, "SE No Impatience Reduction" },                                                                               // No contact
		{ EffectTypes.SE_Nodes_Bonuses, "SE Nodes Bonuses" },                                                                                                   // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_Forager_, "SE Nodes Bonuses (Forager)" },                                                                                // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_Harvester_, "SE Nodes Bonuses (Harvester)" },                                                                            // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_Herbalist_, "SE Nodes Bonuses (Herbalist)" },                                                                            // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_P_Forager_, "SE Nodes Bonuses (P Forager)" },                                                                            // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_P_Herbalist_, "SE Nodes Bonuses (P Herbalist)" },                                                                        // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_P_Trapper_, "SE Nodes Bonuses (P Trapper)" },                                                                            // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_Stonecutter_, "SE Nodes Bonuses (Stonecutter)" },                                                                        // Untapped Wealth
		{ EffectTypes.SE_Nodes_Bonuses_Trapper_, "SE Nodes Bonuses (Trapper)" },                                                                                // Untapped Wealth
		{ EffectTypes.SE_Overheating___Sparkdew_Payment, "SE Overheating - Sparkdew Payment" },                                                                 // Rotten Vapors
		{ EffectTypes.SE_Overheating___Spawn_Cysts, "SE Overheating - Spawn Cysts" },                                                                           // Pestilence
		{ EffectTypes.SE_Productive_Farms_In_Drizzle, "SE Productive Farms in Drizzle" },                                                                       // Regrowth
		{ EffectTypes.SE_Productive_Mine, "SE Productive Mine" },                                                                                               // Exposed Resources
		{ EffectTypes.SE_RawDepositsCharges, "SE RawDepositsCharges" },                                                                                         // Wild Growth
		{ EffectTypes.SE_Remove_Buildings_3, "SE Remove Buildings 3" }, 
		{ EffectTypes.SE_Remove_Buildings3, "SE Remove Buildings3" },                                                                                           // Collapse
		{ EffectTypes.SE_Remove_Nodes___Child, "SE Remove Nodes - child" },                                                                                     // Sinkhole
		{ EffectTypes.SE_ReputationPenaltyRate_100, "SE ReputationPenaltyRate 100" },                                                                           // Vassal Tax
		{ EffectTypes.SE_ReputationPenaltyRate_25, "SE ReputationPenaltyRate 25" },                                                                             // Important Matters
		{ EffectTypes.SE_Resin_For_Wood, "SE Resin For Wood" },                                                                                                 // Bleeding Trees
		{ EffectTypes.SE_Resistant_Cysts, "SE Resistant Cysts" },                                                                                               // Absorption
		{ EffectTypes.SE_Resolve_Fast_Drop_In_Storm, "SE Resolve Fast Drop in Storm" },                                                                         // Aura of Fear
		{ EffectTypes.SE_Resolve_For_Water, "SE Resolve for Water" },                                                                                           // Saturated Air
		{ EffectTypes.SE_Resolve_For_Water___Global_Resolve_Effect, "SE Resolve for Water - Global Resolve Effect" },                                           // Saturated Air
		{ EffectTypes.SE_Resolve_To_Reputation_Plus100_Warm_Welcome, "SE Resolve To Reputation +100 [Warm Welcome]" },                                          // Warm Welcome
		{ EffectTypes.SE_Rotting_Wood, "SE Rotting Wood" },                                                                                                     // Rotting Wood
		{ EffectTypes.SE_Sacrifice_More_In_Storm, "SE Sacrifice more in Storm" },                                                                               // Faint Flame
		{ EffectTypes.SE_Service_Waste, "SE Service Waste" },                                                                                                   // Vanishing Goods
		{ EffectTypes.SE_Slow_Woodcutting_For_Meat, "SE Slow Woodcutting For Meat" },                                                                           // Resisting Flora
		{ EffectTypes.SE_Sparkdew_Plus5, "SE Sparkdew +5" },                                                                                                    // Heavy Drops
		{ EffectTypes.SE_Spawn_Blightrot_On_Death, "SE Spawn Blightrot on Death" },                                                                             // Death and Decay
		{ EffectTypes.SE_Spawn_Cysts_2, "SE Spawn Cysts 2" },                                                                                                   // Blight from the Sky
		{ EffectTypes.SE_Spawn_Cysts_2___Villagers, "SE Spawn Cysts 2 - Villagers" }, 
		{ EffectTypes.SE_Spring_Events, "SE Spring Events" },                                                                                                   // Aura of Peace
		{ EffectTypes.SE_Spring_Routes, "SE Spring Routes" },                                                                                                   // Finders Keepers
		{ EffectTypes.SE_Storm_Clothes, "SE Storm Clothes" },                                                                                                   // Cloudburst
		{ EffectTypes.SE_Storm_Clothes___Resolve_Penalty_Effect, "SE Storm Clothes - Resolve Penalty Effect" },                                                 // Cloudburst
		{ EffectTypes.SE_Storm_Clothes___Resolve_Penalty_Effect___Holder, "SE Storm Clothes - Resolve Penalty Effect - Holder" },                               // Soaked Clothes
		{ EffectTypes.SE_Thunder, "SE Thunder" },                                                                                                               // Thunder
		{ EffectTypes.SE_Trade_Routes_Costs_More_In_Storm, "SE Trade Routes Costs More in Storm" },                                                             // Flooded Roads
		{ EffectTypes.SE_Trader_Interval_Plus300_Clear_Skies, "SE Trader Interval +300 [Clear Skies]" },                                                        // Clear Skies
		{ EffectTypes.SE_TreeCutting__90, "SE TreeCutting -90" }, 
		{ EffectTypes.SE_Unearthly_Element, "SE Unearthly Element" },                                                                                           // Unearthly Element
		{ EffectTypes.SE_Vassal_Tax___Amber_Payment, "SE Vassal Tax - Amber Payment" },                                                                         // Vassal Tax
		{ EffectTypes.SE_Weakend_Ancient_Hearth, "SE Weakend Ancient Hearth" },                                                                                 // Leakage
		{ EffectTypes.SE_Wood_For_Villagers___Payment, "SE Wood for Villagers - Payment" },                                                                     // Sacred Flame Rituals
		{ EffectTypes.SE_Wood_Payment___Villagers_Leaving, "SE Wood Payment - Villagers Leaving" },                                                             // Disappearance
		{ EffectTypes.SE_Woodcuters_Plus10, "SE Woodcuters +10" },                                                                                              // Lightweight Wood
		{ EffectTypes.SE_Woodcutters_Camp_Extra_Only_Plus100_Intensive_Mutations, "SE Woodcutters Camp Extra Only +100 [Intensive Mutations]" },                // Intensive Mutations
		{ EffectTypes.Sea_Marrow_10, "Sea Marrow 10" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_15, "Sea Marrow 15" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_20, "Sea Marrow 20" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_25, "Sea Marrow 25" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_30, "Sea Marrow 30" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_3pm, "Sea Marrow 3pm" },                                                                                                       // Sea Marrow Delivery Line
		{ EffectTypes.Sea_Marrow_40, "Sea Marrow 40" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_5, "Sea Marrow 5" },                                                                                                           // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_50, "Sea Marrow 50" },                                                                                                         // Crate of Sea Marrow
		{ EffectTypes.Sea_Marrow_5pm, "Sea Marrow 5pm" },                                                                                                       // Converted Fishmen Lighthouse
		{ EffectTypes.Sea_Marrow_For_Copper, "Sea Marrow for Copper" },                                                                                         // Sunken Bones
		{ EffectTypes.Sea_Marrow_Plus1, "Sea Marrow +1" },                                                                                                      // Fossil Leaching
		{ EffectTypes.Sea_Marrow_Plus2, "Sea Marrow +2" },                                                                                                      // Fossil Leaching
		{ EffectTypes.Sea_Marrow_Plus3, "Sea Marrow +3" },                                                                                                      // Fossil Leaching
		{ EffectTypes.Sea_Marrow_Plus5, "Sea Marrow +5" },                                                                                                      // Fossil Leaching
		{ EffectTypes.Seal_Extra_Cornerstone, "Seal Extra Cornerstone" },                                                                                       // Gift of the Seal Keeper
		{ EffectTypes.Sealed_Biome_Shrine_Blueprint, "Sealed Biome Shrine Blueprint" },                                                                         // Beacon Tower
		{ EffectTypes.Sealed_Vault_Explosion, "Sealed Vault Explosion" },                                                                                       // Small Miasma Cloud
		{ EffectTypes.SEC_Lumber_Speed_Plus50, "SEC Lumber Speed +50" },                                                                                        // Rotting Wood
		{ EffectTypes.Sewer_Blueprint, "Sewer Blueprint" },                                                                                                     // Clothier
		{ EffectTypes.Shorter_Storm__15, "Shorter Storm -15" },                                                                                                 // Storm Shield
		{ EffectTypes.Shorter_Storm_25, "Shorter Storm 25" }, 
		{ EffectTypes.Shorter_Storm_33, "Shorter Storm 33" }, 
		{ EffectTypes.Shorter_Storm_50, "Shorter Storm 50" }, 
		{ EffectTypes.Skewers_10, "Skewers 10" },                                                                                                               // Pack of Skewers
		{ EffectTypes.Skewers_20, "Skewers 20" },                                                                                                               // Pack of Skewers
		{ EffectTypes.Skewers_25, "Skewers 25" },                                                                                                               // Pack of Skewers
		{ EffectTypes.Skewers_30, "Skewers 30" },                                                                                                               // Pack of Skewers
		{ EffectTypes.Skewers_3pm, "Skewers 3pm" },                                                                                                             // Skewers Delivery Line
		{ EffectTypes.Skewers_40, "Skewers 40" },                                                                                                               // Pack of Skewers
		{ EffectTypes.Skewers_5pm, "Skewers 5pm" },                                                                                                             // Skewers Delivery Line
		{ EffectTypes.Skewers_Plus1, "Skewers +1" },                                                                                                            // Bigger Grill
		{ EffectTypes.Skewers_Plus2, "Skewers +2" },                                                                                                            // Bigger Grill
		{ EffectTypes.Skewers_Plus3, "Skewers +3" },                                                                                                            // Bigger Grill
		{ EffectTypes.Skewers_Plus5, "Skewers +5" },                                                                                                            // Bigger Grill
		{ EffectTypes.Slow_Farming_Termites___Normal, "Slow Farming Termites - normal" },                                                                       // Termite Infestation
		{ EffectTypes.SmallFarm__50, "SmallFarm -50" },                                                                                                         // Reinforced Tools
		{ EffectTypes.SmallFarm__50_Haunted, "SmallFarm -50 Haunted" },                                                                                         // Reinforced Tools
		{ EffectTypes.SmallFarm_Blueprint, "SmallFarm Blueprint" },                                                                                             // Small Farm
		{ EffectTypes.SmallFarm_Plus100, "SmallFarm +100" },                                                                                                    // Reinforced Tools
		{ EffectTypes.SmallFarm_Plus100_Haunted, "SmallFarm +100 Haunted" },                                                                                    // Reinforced Tools
		{ EffectTypes.SmallFarm_Plus150, "SmallFarm +150" },                                                                                                    // Reinforced Tools
		{ EffectTypes.SmallFarm_Plus150_Haunted, "SmallFarm +150 Haunted" },                                                                                    // Reinforced Tools
		{ EffectTypes.SmallFarm_Plus25, "SmallFarm +25" },                                                                                                      // Old Ghran's Technique
		{ EffectTypes.SmallFarm_Plus25_Composite_, "SmallFarm +25 (Composite)" },                                                                               // Old Ghran's Technique
		{ EffectTypes.SmallFarm_Plus25_Haunted, "SmallFarm +25 Haunted" },                                                                                      // Old Ghran's Technique
		{ EffectTypes.SmallFarm_Plus50, "SmallFarm +50" },                                                                                                      // Farming Tools
		{ EffectTypes.SmallFarm_Plus50_Composite_, "SmallFarm +50 (Composite)" },                                                                               // Farming Tools
		{ EffectTypes.SmallFarm_Plus50_Haunted, "SmallFarm +50 Haunted" },                                                                                      // Farming Tools
		{ EffectTypes.Smelter_Blueprint, "Smelter Blueprint" },                                                                                                 // Smelter
		{ EffectTypes.Smithy_Blueprint, "Smithy Blueprint" },                                                                                                   // Smithy
		{ EffectTypes.Smithy_Plus100, "Smithy +100" }, 
		{ EffectTypes.Smithy_Speed_Plus50, "Smithy Speed +50" }, 
		{ EffectTypes.Smokehouse_Blueprint, "Smokehouse Blueprint" },                                                                                           // Smokehouse
		{ EffectTypes.Smokehouse_Speed_Plus50, "Smokehouse Speed +50" },                                                                                        // Flavour Enhancer
		{ EffectTypes.Spawn_3_Fishmen_Totems___Fishmen_Cave, "Spawn 3 Fishmen Totems - Fishmen Cave" },                                                         // Fishmen Witchcraft
		{ EffectTypes.Spawn_Blightrot_Around___Battleground, "Spawn Blightrot Around - Battleground" },                                                         // Decay
		{ EffectTypes.Spawn_Blightrot_Around___Burial_Site, "Spawn Blightrot Around - Burial Site" },                                                           // Life from Beneath
		{ EffectTypes.Spawn_Blightrot_Around___Fishmen, "Spawn Blightrot Around - Fishmen" },                                                                   // Decay
		{ EffectTypes.Spawn_Blightrot_Around___Rainpunk_Foundry, "Spawn Blightrot Around - Rainpunk Foundry" }, 
		{ EffectTypes.Spawn_Blightrot_Around___War_Beast, "Spawn Blightrot Around - War Beast" },                                                               // Decay
		{ EffectTypes.Spawn_Blood_Flower_Near_Hearth, "Spawn Blood Flower Near Hearth" }, 
		{ EffectTypes.Spawn_Cysts_1___Hostility, "Spawn Cysts 1 - hostility" }, 
		{ EffectTypes.Spawn_Cysts_1___Overexploitation, "Spawn Cysts 1 - overexploitation" }, 
		{ EffectTypes.Spawn_Cysts_1___Tree, "Spawn Cysts 1 - Tree" }, 
		{ EffectTypes.Spawn_Cysts_10___Mole, "Spawn Cysts 10 - mole" }, 
		{ EffectTypes.Spawn_Cysts_2___Cauldron, "Spawn Cysts 2 - cauldron" }, 
		{ EffectTypes.Spawn_Cysts_2___Machinery, "Spawn Cysts 2 - machinery" }, 
		{ EffectTypes.Spawn_Cysts_5___Machinery, "Spawn Cysts 5 - machinery" }, 
		{ EffectTypes.Spawn_Cysts_5___Mod, "Spawn Cysts 5 - mod" }, 
		{ EffectTypes.Spawn_Ferile_Soil_Around___Cauldron, "Spawn Ferile Soil Around - Cauldron" },                                                             // Recultivation
		{ EffectTypes.Spawn_Fishmen_Totem___Fishmen_Cave, "Spawn Fishmen Totem - Fishmen Cave" },                                                               // Fishmen Totem
		{ EffectTypes.Spawn_Living_Matter_On_Farmfield, "Spawn Living Matter On Farmfield" }, 
		{ EffectTypes.Spawn_Patch_Haunted_Ruins, "Spawn Patch Haunted Ruins" }, 
		{ EffectTypes.Spawn_Patch_Homestead_Ruin, "Spawn Patch Homestead Ruin" }, 
		{ EffectTypes.Spawn_Patch_Ruins, "Spawn Patch Ruins" }, 
		{ EffectTypes.Spawn_Random_Spring, "Spawn Random Spring" },                                                                                             // Purified Spring
		{ EffectTypes.Spawn_Small_Patch, "Spawn Small Patch" }, 
		{ EffectTypes.Spawn_Trader___The_Hermit, "Spawn Trader - The Hermit" }, 
		{ EffectTypes.Spawn_Trader___The_Seer, "Spawn Trader - The Seer" }, 
		{ EffectTypes.Spawn_Trader___The_Shaman, "Spawn Trader - The Shaman" }, 
		{ EffectTypes.Spider_Tablets_For_Glades, "Spider Tablets for Glades" },                                                                                 // Hidden Mystery
		{ EffectTypes.Stag_Blessing, "Stag Blessing" },                                                                                                         // Stag's Blessing
		{ EffectTypes.Stamping_Mill_Blueprint, "Stamping Mill Blueprint" },                                                                                     // Stamping Mill
		{ EffectTypes.Stone_10pm, "Stone 10pm" },                                                                                                               // Stone Delivery Line
		{ EffectTypes.Stone_3pm, "Stone 3pm" },                                                                                                                 // Stone Delivery Line
		{ EffectTypes.Stone_5pm, "Stone 5pm" },                                                                                                                 // Stone Delivery Line
		{ EffectTypes.Stone_In_Clay_Pit, "Stone in Clay Pit" },                                                                                                 // Steel Mattocks
		{ EffectTypes.Stone_Plus1, "Stone +1" },                                                                                                                // Steel Pickaxes
		{ EffectTypes.Stone_Plus2, "Stone +2" },                                                                                                                // Steel Pickaxes
		{ EffectTypes.Stone_Plus3, "Stone +3" },                                                                                                                // Steel Pickaxes
		{ EffectTypes.Stone_Plus5, "Stone +5" },                                                                                                                // Steel Pickaxes
		{ EffectTypes.Stonecutters_Camp_Plus100, "Stonecutters Camp +100" },                                                                                    // Reinforced Tools
		{ EffectTypes.Stonecutters_Camp_Plus50, "Stonecutters Camp +50" },                                                                                      // Reinforced Tools
		{ EffectTypes.Storm_Water_50_Pm, "Storm water 50 pm" }, 
		{ EffectTypes.Storm_Water_For_Woodcutters, "Storm Water for Woodcutters" },                                                                             // Force of Nature
		{ EffectTypes.Storm_Water_Plus1, "Storm Water +1" },                                                                                                    // Rainwater Condenser
		{ EffectTypes.Storm_Water_Plus2, "Storm Water +2" },                                                                                                    // Rainwater Condenser
		{ EffectTypes.Storm_Water_Plus3, "Storm Water +3" },                                                                                                    // Rainwater Condenser
		{ EffectTypes.Storm_Water_Plus4, "Storm Water +4" },                                                                                                    // Rainwater Condenser
		{ EffectTypes.Storm_Water_Plus5, "Storm Water +5" },                                                                                                    // Rainwater Condenser
		{ EffectTypes.Stormbird_Egg___Additional_Resolve_In_Storm, "Stormbird Egg - Additional Resolve in Storm" },                                             // Stormbird's Cry
		{ EffectTypes.Supplier_Blueprint, "Supplier Blueprint" },                                                                                               // Supplier
		{ EffectTypes.Supplier_Plus50, "Supplier +50" },                                                                                                        // Reinforced Stoves
		{ EffectTypes.Survivor_Bonding, "Survivor Bonding" },                                                                                                   // Survivor Bonding
		{ EffectTypes.Survivor_Bonding___Altar, "Survivor Bonding - Altar" },                                                                                   // Survivor Bonding
		{ EffectTypes.T_Barrels_5pm, "[T] Barrels 5pm" },                                                                                                       // Barrel Delivery Line
		{ EffectTypes.Tablets_For_Events, "Tablets for Events" },                                                                                               // Hidden Reward
		{ EffectTypes.Tank_Capacity___Child, "Tank Capacity - Child" },                                                                                         // Makeshift Water Tank
		{ EffectTypes.Tank_Capacity___Trader, "Tank Capacity - Trader" },                                                                                       // Makeshift Water Tank
		{ EffectTypes.Tavern_Blueprint, "Tavern Blueprint" },                                                                                                   // Tavern
		{ EffectTypes.Tea_10, "Tea 10" },                                                                                                                       // Crate of Tea
		{ EffectTypes.Tea_20, "Tea 20" },                                                                                                                       // Crate of Tea
		{ EffectTypes.Tea_25, "Tea 25" },                                                                                                                       // Crate of Tea
		{ EffectTypes.Tea_30, "Tea 30" },                                                                                                                       // Crate of Tea
		{ EffectTypes.Tea_3pm, "Tea 3pm" },                                                                                                                     // Tea Delivery Line
		{ EffectTypes.Tea_40, "Tea 40" },                                                                                                                       // Crate of Tea
		{ EffectTypes.Tea_5pm, "Tea 5pm" },                                                                                                                     // Tea Delivery Line
		{ EffectTypes.Tea_House_Blueprint, "Tea House Blueprint" },                                                                                             // Apothecary
		{ EffectTypes.Tea_Plus1, "Tea +1" },                                                                                                                    // Tea Infuser
		{ EffectTypes.Tea_Plus2, "Tea +2" },                                                                                                                    // Tea Infuser
		{ EffectTypes.Tea_Plus3, "Tea +3" },                                                                                                                    // Tea Infuser
		{ EffectTypes.Tea_Plus5, "Tea +5" },                                                                                                                    // Tea Infuser
		{ EffectTypes.TEMP_Extend_Trade_Routes_Effect_Model, "TEMP Extend Trade Routes Effect Model" },                                                         // More trade offers
		{ EffectTypes.TEMP_Locate_Grass_Effect_Model, "TEMP Locate Grass Effect Model" },                                                                       // Reveals fertile soil
		{ EffectTypes.Temple_All_Luxury_Lost, "Temple All Luxury Lost" },                                                                                       // Forced Sacrifice
		{ EffectTypes.Temple_Blueprint, "Temple Blueprint" },                                                                                                   // Temple
		{ EffectTypes.Temple_Building_Production_Yield, "Temple Building Production Yield" },                                                                   // Involuntary Sacrifice
		{ EffectTypes.Temple_Packs_Production_Yield, "Temple Packs Production Yield" },                                                                         // Involuntary Sacrifice
		{ EffectTypes.Termites_Materials_Lost, "Termites Materials Lost" },                                                                                     // Agitated Swarm
		{ EffectTypes.Termites_Resolve___Normal, "Termites Resolve - normal" },                                                                                 // Stonetooth Swarm
		{ EffectTypes.TEST_Plague_Of_Blindness, "TEST Plague of Blindness" },                                                                                   // Plague of Blindness
		{ EffectTypes.TEST_Plague_Of_Corrupted_Water, "TEST Plague of Corrupted Water" },                                                                       // Plague of Corrupted Water
		{ EffectTypes.TEST_Plague_Of_Darkness, "TEST Plague of Darkness" },                                                                                     // Plague of Darkness
		{ EffectTypes.TEST_Plague_Of_Death, "TEST Plague of Death" },                                                                                           // Plague of Death
		{ EffectTypes.TEST_Plague_Of_Fire, "TEST Plague of Fire" },                                                                                             // Plague of Fire
		{ EffectTypes.TEST_Plague_Of_Fishmen, "TEST Plague of Fishmen" },                                                                                       // Plague of Fishmen
		{ EffectTypes.TEST_Plague_Of_Locusts, "TEST Plague of Locusts" },                                                                                       // Plague of Locusts
		{ EffectTypes.TEST_Plague_Of_Malady, "TEST Plague of Malady" },                                                                                         // Plague of Malady
		{ EffectTypes.TEST_Plague_Of_Mosquito, "TEST Plague of Mosquito" },                                                                                     // Plague of Mosquitoes
		{ EffectTypes.TEST_Plague_Of_Mysteries, "TEST Plague of Mysteries" },                                                                                   // Plague of Mysteries
		{ EffectTypes.TEST_Plague_Of_Rats___Food, "TEST Plague of Rats - Food" },                                                                               // Plague of Rats
		{ EffectTypes.TEST_Plague_Of_Snakes, "TEST Plague of Snakes" },                                                                                         // Plague of Snakes
		{ EffectTypes.TEST_Plague_Of_The_Forest, "TEST Plague of the Forest" },                                                                                 // Plague of the Dark Forest
		{ EffectTypes.TEST_Plague_Of_Thunderstorm, "TEST Plague of Thunderstorm" },                                                                             // Plague of Thunderstorms
		{ EffectTypes.Tinctury_Blueprint, "Tinctury Blueprint" },                                                                                               // Tinctury
		{ EffectTypes.Tinkerer_Blueprint, "Tinkerer Blueprint" },                                                                                               // Tinkerer
		{ EffectTypes.Tools_2pm, "Tools 2pm" },                                                                                                                 // Tool Delivery Line
		{ EffectTypes.Tools_4pm, "Tools 4pm" },                                                                                                                 // Tool Delivery Line
		{ EffectTypes.Tools_For_Death, "Tools for death" },                                                                                                     // Bone Tools
		{ EffectTypes.Tools_For_Glade, "Tools for glade" },                                                                                                     // Improvised Tools
		{ EffectTypes.Tools_For_Glade___Child, "Tools for glade - child" }, 
		{ EffectTypes.Tools_For_Glade___Child___Altar, "Tools for glade - child - altar" }, 
		{ EffectTypes.Tools_For_Hostility, "Tools for Hostility" },                                                                                             // Forbidden Tools
		{ EffectTypes.Toolshop_Blueprint, "Toolshop Blueprint" },                                                                                               // Toolshop
		{ EffectTypes.Trade___Explorer_Tales, "Trade - Explorer Tales" },                                                                                       // Tales of Discovery
		{ EffectTypes.Trade___Spices_From_The_Capital, "Trade - Spices from the Capital" },                                                                     // Spices from the Citadel
		{ EffectTypes.Trade_Block_For_Production_Speed, "Trade Block for Production Speed" },                                                                   // Deserted Caravans
		{ EffectTypes.Trade_Pack_In_Brickyard, "Trade Pack in Brickyard" },                                                                                     // Trade Pack Instructions
		{ EffectTypes.Trade_Pack_In_Clothier, "Trade Pack in Clothier" },                                                                                       // Trade Pack Instructions
		{ EffectTypes.Trade_Pack_In_Makeshift_Post, "Trade Pack in Makeshift Post" },                                                                           // Better Packaging
		{ EffectTypes.Trade_Route_Speed_For_Packs, "Trade Route Speed for Packs" },                                                                             // Full Stock
		{ EffectTypes.Trade_Routes_Bonus_Fuel, "Trade Routes Bonus Fuel" },                                                                                     // Tightened Belt
		{ EffectTypes.Trade_Routes_For_Housing_Spots, "Trade routes for housing spots" },                                                                       // Urban Planning
		{ EffectTypes.Trade_Routes_More_Expensive, "Trade Routes More Expensive" }, 
		{ EffectTypes.Trader_Assault___2_More_Impatience, "Trader Assault - 2 more Impatience" }, 
		{ EffectTypes.Trader_Interval__50, "Trader Interval -50" },                                                                                             // Infamous Viceroy
		{ EffectTypes.Trader_Interval_Plus15, "Trader Interval +15" },                                                                                          // Beneficial Agreement
		{ EffectTypes.Trader_Interval_Plus25, "Trader Interval +25" },                                                                                          // Trade Contract
		{ EffectTypes.Trader_Interval_Plus33, "Trader Interval +33" }, 
		{ EffectTypes.Trader_Prices_Lower__5, "Trader Prices Lower -5" }, 
		{ EffectTypes.TradeRoutePlus1, "TradeRoutePlus1" }, 
		{ EffectTypes.TradeRoutePlus2, "TradeRoutePlus2" }, 
		{ EffectTypes.Traders_Prices_Plus50, "Traders Prices +50" },                                                                                            // Tit for Tat
		{ EffectTypes.Trading_Packs, "Trading Packs" },                                                                                                         // Trade Logs
		{ EffectTypes.Training_Gear_20, "Training Gear 20" },                                                                                                   // Training Gear
		{ EffectTypes.Training_Gear_30, "Training Gear 30" },                                                                                                   // Training Gear
		{ EffectTypes.Training_Gear_3pm, "Training Gear 3pm" },                                                                                                 // Training Gear Delivery Line
		{ EffectTypes.Training_Gear_40, "Training Gear 40" },                                                                                                   // Training Gear
		{ EffectTypes.Training_Gear_5pm, "Training Gear 5pm" },                                                                                                 // Training Gear Delivery Line
		{ EffectTypes.Training_Gear_Plus1, "Training Gear +1" },                                                                                                // Woodworking Tools
		{ EffectTypes.Training_Gear_Plus2, "Training Gear +2" },                                                                                                // Woodworking Tools
		{ EffectTypes.Training_Gear_Plus3, "Training Gear +3" },                                                                                                // Woodworking Tools
		{ EffectTypes.Training_Gear_Plus5, "Training Gear +5" },                                                                                                // Woodworking Tools
		{ EffectTypes.Trappers_Camp_Blueprint, "Trapper's Camp Blueprint" },                                                                                    // Trappers' Camp
		{ EffectTypes.Trappers_Camp_Plus100, "Trappers Camp +100" },                                                                                            // Reinforced Tools
		{ EffectTypes.Trappers_Camp_Plus50, "Trappers Camp +50" },                                                                                              // Reinforced Tools
		{ EffectTypes.Treasure_Stag_Remove_Self, "Treasure Stag Remove Self" },                                                                                 // Escape
		{ EffectTypes.Tree_Wood_Lost, "Tree Wood Lost" },                                                                                                       // Petrified Wood
		{ EffectTypes.TreeCutting__33, "TreeCutting -33" },                                                                                                     // Exploration Expedition
		{ EffectTypes.TreeCutting_200, "TreeCutting 200" }, 
		{ EffectTypes.Tut_III_Faster_Traders, "Tut III Faster Traders" }, 
		{ EffectTypes.Tutorial_Death_Missile, "Tutorial Death Missile" },                                                                                       // Curse of the Forefathers
		{ EffectTypes.TW_Global_Extra_Prod, "[TW] Global Extra Prod" },                                                                                         // Prayer
		{ EffectTypes.TW_Global_Resolve, "[TW] Global Resolve" },                                                                                               // Tale
		{ EffectTypes.TW_Hostility, "[TW] Hostility" },                                                                                                         // Distant Howling
		{ EffectTypes.TW_Longer_Relics_Working_Time, "[TW] Longer Relics Working Time" },                                                                       // Ghastly Chant
		{ EffectTypes.TW_RemoveFoodOverTime, "[TW] RemoveFoodOverTime" },                                                                                       // Poisoned Wind
		{ EffectTypes.TW_ReputationPenaltyRate, "[TW] ReputationPenaltyRate" },                                                                                 // Effect_TW_ImpatienceRate_Name
		{ EffectTypes.TW_Slower_Leaving, "[TW] Slower Leaving" },                                                                                               // Inspiring Speech
		{ EffectTypes.UB_Beaver_Houses_Unique_Bonus, "[U][B] Beaver Houses Unique Bonus" },                                                                     // Writing Desk
		{ EffectTypes.UB_Fox_Houses_Unique_Bonus, "[U][B] Fox Houses Unique Bonus" },                                                                           // Lichen
		{ EffectTypes.UB_Harpy_Houses_Unique_Bonus, "[U][B] Harpy Houses Unique Bonus" },                                                                       // Canopy
		{ EffectTypes.UB_Human_Houses_Unique_Bonus, "[U][B] Human Houses Unique Bonus" },                                                                       // Toolshed
		{ EffectTypes.UB_Lizard_Houses_Unique_Bonus, "[U][B] Lizard Houses Unique Bonus" },                                                                     // Cellar
		{ EffectTypes.UB_Planting_And_Harvesting_Speed, "[U][B] Planting And Harvesting Speed" }, 
		{ EffectTypes.UBP_Cyst_Generation_Rate___Child, "[U][BP] Cyst Generation Rate - child" },                                                               // Manned Lookout
		{ EffectTypes.UBP_Global___Cyst_Generation_Rate___Parent, "[U][BP] Global - Cyst Generation Rate - Parent" },                                           // Manned Lookout
		{ EffectTypes.Vault_ForagersResolvePenalty_normal, "Vault_ForagersResolvePenalty_normal" }, 
		{ EffectTypes.Vault_HarvesterResolvePenalty_normal, "Vault_HarvesterResolvePenalty_normal" }, 
		{ EffectTypes.Vault_HerablistResolvePenalty_normal, "Vault_HerablistResolvePenalty_normal" }, 
		{ EffectTypes.Vault_PrimitiveForagerResolvePenalty_normal, "Vault_PrimitiveForagerResolvePenalty_normal" }, 
		{ EffectTypes.Vault_PrimitiveHerbalistResolvePenalty_normal, "Vault_PrimitiveHerbalistResolvePenalty_normal" }, 
		{ EffectTypes.Vault_PrimitiveTrapperResolvePenalty_normal, "Vault_PrimitiveTrapperResolvePenalty_normal" }, 
		{ EffectTypes.Vault_StonecuttersResolvePenalty_normal, "Vault_StonecuttersResolvePenalty_normal" }, 
		{ EffectTypes.Vault_TrappersResolvePenalty_normal, "Vault_TrappersResolvePenalty_normal" }, 
		{ EffectTypes.Vault_WoodcuttersResolvePenalty_normal, "Vault_WoodcuttersResolvePenalty_normal" }, 
		{ EffectTypes.VaultResolvePenalty___Normal, "VaultResolvePenalty - normal" },                                                                           // Ominous Whispers
		{ EffectTypes.Vegetables_10pm, "Vegetables 10pm" },                                                                                                     // Vegetable Delivery Line
		{ EffectTypes.Vegetables_30, "Vegetables 30" },                                                                                                         // Crate of Vegetables
		{ EffectTypes.Vegetables_3pm, "Vegetables 3pm" },                                                                                                       // Vegetable Delivery Line
		{ EffectTypes.Vegetables_40, "Vegetables 40" },                                                                                                         // Crate of Vegetables
		{ EffectTypes.Vegetables_50, "Vegetables 50" },                                                                                                         // Crate of Vegetables
		{ EffectTypes.Vegetables_5pm, "Vegetables 5pm" },                                                                                                       // Vegetable Delivery Line
		{ EffectTypes.Vegetables_60, "Vegetables 60" },                                                                                                         // Crate of Vegetables
		{ EffectTypes.Vegetables_In_Greenhouse, "Vegetables in Greenhouse" },                                                                                   // Moss Broccoli Seeds
		{ EffectTypes.Vegetables_Plus1, "Vegetables +1" },                                                                                                      // Giant Vegetables
		{ EffectTypes.Vegetables_Plus2, "Vegetables +2" },                                                                                                      // Giant Vegetables
		{ EffectTypes.Vegetables_Plus3, "Vegetables +3" },                                                                                                      // Giant Vegetables
		{ EffectTypes.Vegetables_Plus5, "Vegetables +5" },                                                                                                      // Giant Vegetables
		{ EffectTypes.Villager_Death_Reputation_Penalty, "Villager Death Reputation Penalty" }, 
		{ EffectTypes.Villager_For_Glade, "Villager for glade" },                                                                                               // Lost in the Wilds
		{ EffectTypes.VillagerDeathEffectBlock, "VillagerDeathEffectBlock" },                                                                                   // Hidden from the Queen
		{ EffectTypes.VillagerFoodEffect_Poisoned_Food, "VillagerFoodEffect Poisoned Food" },                                                                   // Poisoned Food
		{ EffectTypes.Villagers_For_Corruption, "Villagers For Corruption" },                                                                                   // From the Shadows
		{ EffectTypes.VillagerSpeed10, "VillagerSpeed10" },                                                                                                     // Sturdy Boots
		{ EffectTypes.VillagerSpeed15, "VillagerSpeed15" },                                                                                                     // Sturdy Boots
		{ EffectTypes.VillagerSpeed25, "VillagerSpeed25" }, 
		{ EffectTypes.VillagerSpeed30, "VillagerSpeed30" },                                                                                                     // Sturdy Boots
		{ EffectTypes.VillagersSlow20, "VillagersSlow20" },                                                                                                     // Curse of Weakness
		{ EffectTypes.VillagersSlow30_Plague, "VillagersSlow30 Plague" },                                                                                       // Plague of Blindness
		{ EffectTypes.Vitality, "Vitality" },                                                                                                                   // Vitality
		{ EffectTypes.Voice_Of_The_Forest, "Voice of the Forest" },                                                                                             // Voice of the Forest
		{ EffectTypes.War_Beast_Hostility, "War Beast Hostility" },                                                                                             // Unleashed Beast
		{ EffectTypes.Water_Lost, "Water Lost" }, 
		{ EffectTypes.Waterskins_10, "Waterskins 10" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_15, "Waterskins 15" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_20, "Waterskins 20" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_30, "Waterskins 30" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_3pm, "Waterskins 3pm" },                                                                                                       // Waterskin Delivery Line
		{ EffectTypes.Waterskins_40, "Waterskins 40" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_5, "Waterskins 5" },                                                                                                           // Crate of Waterskins
		{ EffectTypes.Waterskins_50, "Waterskins 50" },                                                                                                         // Crate of Waterskins
		{ EffectTypes.Waterskins_5pm, "Waterskins 5pm" },                                                                                                       // Waterskin Delivery Line
		{ EffectTypes.Waterskins_For_Leather, "Waterskins for Leather" },                                                                                       // Reward_WaterskinsForLeather_Name
		{ EffectTypes.Waterskins_Plus1, "Waterskins +1" },                                                                                                      // Advanced Leatherworking
		{ EffectTypes.Waterskins_Plus2, "Waterskins +2" },                                                                                                      // Advanced Leatherworking
		{ EffectTypes.Waterskins_Plus3, "Waterskins +3" },                                                                                                      // Advanced Leatherworking
		{ EffectTypes.Waterskins_Plus5, "Waterskins +5" },                                                                                                      // Advanced Leatherworking
		{ EffectTypes.WE_Cloaked_Wanderer_Vengeance, "[WE] Cloaked Wanderer Vengeance" },                                                                       // Cloaked Wanderer's Vengeance
		{ EffectTypes.WE_Crashed_Airship_Bonus, "[WE] Crashed Airship Bonus" },                                                                                 // Guild's Sigil
		{ EffectTypes.WE_Desecrator, "[WE] Desecrator" },                                                                                                       // Desecrator
		{ EffectTypes.WE_Desecrator_Villager_Death, "[WE] Desecrator Villager Death" }, 
		{ EffectTypes.WE_Fallen_Viceroy_Commemoration_Composite, "[WE] Fallen Viceroy Commemoration Composite" },                                               // Fallen Viceroy Commemoration
		{ EffectTypes.WE_Glade_Info, "[WE] Glade Info" },                                                                                                       // Guild's Logbook
		{ EffectTypes.WE_Lower_Blueprints_Reroll_Cost, "[WE] Lower Blueprints Reroll Cost" },                                                                   // The Eremite's Way
		{ EffectTypes.WE_Petrified_Egg, "[WE] Petrified Egg" },                                                                                                 // Petrified Egg
		{ EffectTypes.WE_Random_Killed___Cloaked_Wanderer, "[WE] Random Killed - Cloaked Wanderer" },                                                           // Cloaked Wanderer's Vengeance
		{ EffectTypes.WE_Remove_All_Food, "[WE] Remove All Food" },                                                                                             // Storm Ant Column
		{ EffectTypes.WE_ReputationPenaltyRate_30, "[WE] ReputationPenaltyRate 30" },                                                                           // Irresponsible Gamble
		{ EffectTypes.WE_ReputationPenaltyRate_50, "[WE] ReputationPenaltyRate 50" },                                                                           // Insane Gamble
		{ EffectTypes.WE_Roaming_Shelled_Mosquitos, "[WE] Roaming Shelled Mosquitos" },                                                                         // Roaming Swarm
		{ EffectTypes.Wealth, "Wealth" },                                                                                                                       // Wealth
		{ EffectTypes.Weaver_Blueprint, "Weaver Blueprint" },                                                                                                   // Weaver
		{ EffectTypes.Wetstone_10, "Wetstone 10" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_15, "Wetstone 15" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_20, "Wetstone 20" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_25, "Wetstone 25" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_30, "Wetstone 30" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_35, "Wetstone 35" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_40, "Wetstone 40" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_5, "Wetstone 5" },                                                                                                               // Crate of Stone
		{ EffectTypes.Wetstone_50, "Wetstone 50" },                                                                                                             // Crate of Stone
		{ EffectTypes.Wetstone_8, "Wetstone 8" },                                                                                                               // Crate of Stone
		{ EffectTypes.White_Stag_Reward_Catch, "White Stag Reward Catch" },                                                                                     // Cursed Treasure
		{ EffectTypes.White_Stag_Reward_Chase, "White Stag Reward Chase" },                                                                                     // Into the Mists
		{ EffectTypes.White_Stag_Reward_Release, "White Stag Reward Release" },                                                                                 // Gift of Gratitude
		{ EffectTypes.Wildcard_For_Death, "Wildcard for Death" },                                                                                               // Scientific Agreement
		{ EffectTypes.Wildcard_Pick_Cornerstone, "Wildcard Pick Cornerstone" },                                                                                 // Smuggler's Visit
		{ EffectTypes.Wildcard_Pick_Cursed, "Wildcard Pick Cursed" },                                                                                           // Summoned Smuggler (Stormforged)
		{ EffectTypes.Wildcard_Pick_Trader, "Wildcard Pick Trader" },                                                                                           // Contraband
		{ EffectTypes.Wildfire_Fuel_Lost, "Wildfire Fuel Lost" },                                                                                               // Combustion
		{ EffectTypes.Wildfire_RemoveFuelOverTime___Hard, "Wildfire_RemoveFuelOverTime - hard" },                                                               // Wildfire Presence
		{ EffectTypes.Wildfire_RemoveFuelOverTime___Impossible, "Wildfire_RemoveFuelOverTime - impossible" },                                                   // Wildfire Presence
		{ EffectTypes.Wildfire_RemoveFuelOverTime___Normal, "Wildfire_RemoveFuelOverTime - normal" },                                                           // Wildfire Presence
		{ EffectTypes.Wildfire_RemoveFuelOverTime___Very_Hard, "Wildfire_RemoveFuelOverTime - very hard" },                                                     // Wildfire Presence
		{ EffectTypes.Wine_10, "Wine 10" },                                                                                                                     // Barrels of Wine
		{ EffectTypes.Wine_20, "Wine 20" },                                                                                                                     // Barrels of Wine
		{ EffectTypes.Wine_3, "Wine 3" },                                                                                                                       // Barrels of Wine
		{ EffectTypes.Wine_30, "Wine 30" },                                                                                                                     // Barrels of Wine
		{ EffectTypes.Wine_3pm, "Wine 3pm" },                                                                                                                   // Wine Delivery Line
		{ EffectTypes.Wine_40, "Wine 40" },                                                                                                                     // Barrels of Wine
		{ EffectTypes.Wine_5pm, "Wine 5pm" },                                                                                                                   // Wine Delivery Line
		{ EffectTypes.Wine_Plus1, "Wine +1" },                                                                                                                  // Advanced Filters
		{ EffectTypes.Wine_Plus2, "Wine +2" },                                                                                                                  // Advanced Filters
		{ EffectTypes.Wine_Plus3, "Wine +3" },                                                                                                                  // Advanced Filters
		{ EffectTypes.Wine_Plus5, "Wine +5" },                                                                                                                  // Advanced Filters
		{ EffectTypes.Wood_10, "Wood 10" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_100, "Wood 100" },                                                                                                                   // Crate of Wood
		{ EffectTypes.Wood_15, "Wood 15" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_20, "Wood 20" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_30, "Wood 30" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_40, "Wood 40" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_5, "Wood 5" },                                                                                                                       // Crate of Wood
		{ EffectTypes.Wood_50, "Wood 50" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_60, "Wood 60" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_70, "Wood 70" },                                                                                                                     // Crate of Wood
		{ EffectTypes.Wood_Plus1, "Wood +1" },                                                                                                                  // Steel Axes
		{ EffectTypes.Wood_Plus2, "Wood +2" },                                                                                                                  // Steel Axes
		{ EffectTypes.Wood_Plus2_For_Insects, "Wood +2 for insects" },                                                                                          // No Quality Control
		{ EffectTypes.Wood_Plus3, "Wood +3" },                                                                                                                  // Steel Axes
		{ EffectTypes.Wood_Removed, "Wood Removed" }, 
		{ EffectTypes.Woodcuters_Plus10, "Woodcuters +10" },                                                                                                    // Light Timber
		{ EffectTypes.Woodcuters_Plus15, "Woodcuters +15" },                                                                                                    // Light Timber
		{ EffectTypes.Woodcuters_Plus5, "Woodcuters +5" },                                                                                                      // Light Timber
		{ EffectTypes.Woodcutters_Camp_Plus100, "Woodcutters Camp +100" },                                                                                      // Woodcutter's Tools
		{ EffectTypes.Woodcutters_Camp_Plus50, "Woodcutters Camp +50" },                                                                                        // Reinforced Tools
		{ EffectTypes.Woodcutters_Prayer, "Woodcutters Prayer" },                                                                                               // Woodcutter's Prayer
		{ EffectTypes.Woodcutting_For_Fuel, "Woodcutting For Fuel" },                                                                                           // Sloppy Woodcutting
		{ EffectTypes.Woodcutting_Speed_For_Water, "Woodcutting speed for water" },                                                                             // Driving Water
		{ EffectTypes.Workers_Carry_More_For_Tablets, "Workers carry more for Tablets" },                                                                       // Ancient Strength
		{ EffectTypes.Working_Speed_For_Small_Glade, "Working Speed For Small Glade" },                                                                         // Farsight
		{ EffectTypes.Working_Speed_For_Small_Glade___Relic_Working_Speed, "Working Speed For Small Glade - Relic Working Speed" },                             // Farsight
		{ EffectTypes.Working_Speed_For_Small_Glade___Relic_Working_Speed___Holder, "Working Speed For Small Glade - Relic Working Speed - Holder" },           // Reconnaissance
		{ EffectTypes.Working_Time_For_Firekeeper, "Working time for firekeeper" },                                                                             // Prayer Book
		{ EffectTypes.Working_Time_For_Tablets, "Working Time for Tablets" },                                                                                   // Carved in Stone
		{ EffectTypes.Worse_Storms_For_Hostility, "Worse Storms for Hostility" },                                                                               // Growing Darkness
		{ EffectTypes.Worse_Storms_For_Hostility___Permanent, "Worse Storms for Hostility - Permanent" },                                                       // Violent Dusk
		{ EffectTypes.Worse_Storms_For_Hostility_Consequence_Resolve, "Worse Storms for Hostility Consequence Resolve" },                                       // Growing Darkness
		{ EffectTypes.Worse_Storms_For_Hostility_Resolve, "Worse Storms for Hostility Resolve" },                                                               // Growing Darkness
		{ EffectTypes.Worse_Storms_For_Hostility_Working, "Worse Storms for Hostility Working" },                                                               // Growing Darkness
		{ EffectTypes.Worse_Storms_Hook___Permanent, "Worse Storms Hook - Permanent" },                                                                         // Violent Dusk
	};
}
