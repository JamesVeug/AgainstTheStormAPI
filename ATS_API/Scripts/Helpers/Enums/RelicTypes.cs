using System;
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
	AncientBurrialGrounds,                     // Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
	AncientGate,                               // Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
	AncientShrine_T1,                          // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	AncientTemple,                             // Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
	Angry_Ghost_1,                             // Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
	Angry_Ghost_10,                            // Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
	Angry_Ghost_14,                            // Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
	Angry_Ghost_15,                            // Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
	Angry_Ghost_16,                            // Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
	Angry_Ghost_17,                            // Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
	Angry_Ghost_18,                            // Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
	Angry_Ghost_19,                            // Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
	Angry_Ghost_2,                             // Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
	Angry_Ghost_20,                            // Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
	Angry_Ghost_21,                            // Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
	Angry_Ghost_24,                            // Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
	Angry_Ghost_31,                            // Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
	Angry_Ghost_32,                            // Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
	Angry_Ghost_34,                            // Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
	Angry_Ghost_4,                             // Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
	Angry_Ghost_5,                             // Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
	Angry_Ghost_6,                             // Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
	Angry_Ghost_9,                             // Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
	AngryGhostChest_T1,                        // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	BeaverBattleground_T1,                     // Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
	Black_Stag,                                // Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
	Black_Treasure_Stag,                       // Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	Blightrot,                                 // Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
	Blightrot_Cauldron,                        // Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
	Blightrot_Clone,                           // Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
	Calm_Ghost_11,                             // Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
	Calm_Ghost_12,                             // Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
	Calm_Ghost_13,                             // Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
	Calm_Ghost_22,                             // Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
	Calm_Ghost_23,                             // Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
	Calm_Ghost_25,                             // Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
	Calm_Ghost_26,                             // Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
	Calm_Ghost_27,                             // Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
	Calm_Ghost_28,                             // Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
	Calm_Ghost_29,                             // Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
	Calm_Ghost_3,                              // Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
	Calm_Ghost_30,                             // Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
	Calm_Ghost_33,                             // Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
	Calm_Ghost_35,                             // Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
	Calm_Ghost_36,                             // Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
	Calm_Ghost_7,                              // Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
	Calm_Ghost_8,                              // Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
	CalmGhostChest_T1,                         // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	Camp_T1,                                   // Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	Camp_T2,                                   // Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	Caravan_T1,                                // Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	Caravan_T2,                                // Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	Corrupted_Caravan,                         // Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
	DebugNode_ClayBig,                         // Clay Deposit (Large) - Soil infused with the essence of the rain.
	DebugNode_ClaySmall,                       // Clay Deposit (Small) - Soil infused with the essence of the rain.
	DebugNode_DewberryBushBig,                 // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
	DebugNode_DewberryBushSmall,               // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
	DebugNode_FlaxBig,                         // Flax Field (Large) - Resilient plants that are perfect for cloth-making.
	DebugNode_FlaxSmall,                       // Flax Field (Small) - Resilient plants that are perfect for cloth-making.
	DebugNode_HerbsBig,                        // Herb Node (Large) - A dense shrub, full of many useful plant species.
	DebugNode_HerbsSmall,                      // Herb Node (Small) - A dense shrub, full of many useful plant species.
	DebugNode_LeechBroodmotherBig,             // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	DebugNode_LeechBroodmotherSmall,           // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	DebugNode_Marshlands_InfiniteGrain,        // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
	DebugNode_Marshlands_InfiniteMeat,         // Dead Leviathan - A giant, dead beast. How did it get here?
	DebugNode_Marshlands_InfiniteMushroom,     // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
	DebugNode_MarshlandsMushroomBig,           // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	DebugNode_MarshlandsMushroomSmall,         // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	DebugNode_MossBroccoliBig,                 // Moss Broccoli Patch (Large) - An edible and tasty type of moss.
	DebugNode_MossBroccoliSmall,               // Moss Broccoli Patch (Small) - An edible and tasty type of moss.
	DebugNode_MushroomBig,                     // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	DebugNode_MushroomSmall,                   // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	DebugNode_ReedBig,                         // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
	DebugNode_ReedSmall,                       // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
	DebugNode_RootsBig,                        // Root Deposit (Large) - A tangled net of living vines.
	DebugNode_RootsSmall,                      // Root Deposit (Small) - A tangled net of living vines.
	DebugNode_SeaMarrowBig,                    // Sea Marrow Deposit (Large) - Ancient fossils, rich in resources.
	DebugNode_SeaMarrowSmall,                  // Sea Marrow Deposit (Small) - Ancient fossils, rich in resources.
	DebugNode_SnailBroodmotherBig,             // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	DebugNode_SnailBroodmotherSmall,           // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	DebugNode_SnakeNestBig,                    // Snake Nest (Large) - A dangerous, but rich source of food and leather.
	DebugNode_SnakeNestSmall,                  // Snake Nest (Small) - A dangerous, but rich source of food and leather.
	DebugNode_StoneBig,                        // Stone Deposit (Large) - Stones, weathered by the everlasting rain.
	DebugNode_StoneSmall,                      // Stone Deposit (Small) - Stones, weathered by the everlasting rain.
	DebugNode_StormbirdNestBig,                // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	DebugNode_StormbirdNestSmall,              // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	DebugNode_SwampWheatBig,                   // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
	DebugNode_SwampWheatSmall,                 // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
	DebugNode_WormtongueNestBig,               // Wormtongue Nest (Large) - A nest full of tasty wormtongues.
	DebugNode_WormtongueNestSmall,             // Wormtongue Nest (Small) - A nest full of tasty wormtongues.
	Decay_Altar,                               // Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
	Escaped_Convicts,                          // Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
	Fishmen_Cave,                              // Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
	Fishmen_Lighthouse,                        // Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
	Fishmen_Outpost,                           // Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
	Fishmen_Soothsayer,                        // Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
	Fishmen_Totem,                             // Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
	ForsakenCrypt,                             // Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
	FoxBattleground_T1,                        // Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
	Fuming_Machinery,                          // Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
	Giant_Stormbird,                           // Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
	Glade_Trader_The_Hermit,                   // Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
	Glade_Trader_The_Seer,                     // Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
	Glade_Trader_The_Shaman,                   // Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
	Gold_Stag,                                 // Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
	Gold_Treasure_Stag,                        // Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	Harmony_Spirit_Altar,                      // Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
	HarpyBattleground_T1,                      // Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
	Haunted_Ruined_Beaver_House,               // Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Brewery,                    // Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Cellar,                     // Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Cooperage,                  // Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Druid,                      // Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Fox_House,                  // Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Harpy_House,                // Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Herb_Garden,                // Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Human_House,                // Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Leatherworks,               // Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Lizard_House,               // Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Market,                     // Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Rainmill,                   // Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_SmallFarm,                  // Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Smelter,                    // Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	Haunted_Ruined_Temple,                     // Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	HumanBattleground_T1,                      // Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
	Infected_Mole,                             // Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
	Infected_Tree,                             // Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
	Kelpie,                                    // River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
	Leaking_Cauldron,                          // Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
	Lightning_Catcher,                         // Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
	LizardBattleground_T1,                     // Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
	Merchant_Ship_Wreck,                       // Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
	Mistworm_T1,                               // Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
	Mole,                                      // Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
	Monolith,                                  // Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
	Noxious_Machinery,                         // Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
	PetrifiedTree_T1,                          // Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
	Rain_Totem,                                // Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
	Rainpunk_Drill_Coal,                       // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	Rainpunk_Drill_Copper,                     // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	RainpunkFactory,                           // Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
	RewardChest_T1,                            // Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	RewardChest_T2,                            // Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	RewardChest_T3,                            // Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	Ruined_Advanced_Rain_Catcher,              // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Advanced_Rain_Catcher_no_Reward,    // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Alchemist,                          // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Alchemist_no_Reward,                // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Apothecary,                         // Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Apothecary_no_Reward,               // Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Artisan,                            // Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Artisan_no_Reward,                  // Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Bakery,                             // Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Bakery_no_Reward,                   // Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Bath_House,                         // Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Bath_House_no_Reward,               // Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Beanery,                            // Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Beanery_no_Reward,                  // Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Beaver_House,                       // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Beaver_House_no_Reward,             // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Big_Shelter,                        // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Big_Shelter_no_Reward,              // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Brewery,                            // Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Brewery_no_Reward,                  // Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Brick_Oven,                         // Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Brick_Oven_no_Reward,               // Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Brickyard,                          // Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Brickyard_no_Reward,                // Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Butcher,                            // Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Butcher_no_Reward,                  // Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Carpenter,                          // Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Carpenter_no_Reward,                // Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Cellar,                             // Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Cellar_no_Reward,                   // Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Clan_Hall,                          // Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Clan_Hall_no_Reward,                // Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Clay_Pit,                           // Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Clay_Pit_no_Reward,                 // Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Cookhouse,                          // Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Cookhouse_no_Reward,                // Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Cooperage,                          // Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Cooperage_no_Reward,                // Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Crude_Workstation_no_Reward,        // Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Distillery,                         // Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Distillery_no_Reward,               // Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Druid,                              // Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Druid_no_Reward,                    // Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Explorers_Lodge,                    // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Explorers_Lodge_no_Reward,          // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Farm,                               // Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Farm_no_Reward,                     // Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Field_Kitchen_no_Reward,            // Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Finesmith,                          // Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Finesmith_no_Reward,                // Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Foragers_Camp,                      // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Foragers_Camp_no_Reward,            // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Foragers_Camp_Primitive_no_Reward,  // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Forum,                              // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Forum_no_Reward,                    // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Fox_House,                          // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Fox_House_no_Reward,                // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Furnace,                            // Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Furnace_no_Reward,                  // Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Granary,                            // Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Granary_no_Reward,                  // Granary - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Greenhouse,                         // Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Greenhouse_no_Reward,               // Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Grill,                              // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Grill_no_Reward,                    // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Grove,                              // Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Grove_no_Reward,                    // Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Guild_House,                        // Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Guild_House_no_Reward,              // Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Harpy_House,                        // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Harpy_House_no_Reward,              // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Harvester_Camp,                     // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Harvester_Camp_no_Reward,           // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Hearth,                             // Ancient Hearth - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Hearth_no_Reward,                   // Ancient Hearth - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Herb_Garden,                        // Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Herb_Garden_no_Reward,              // Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Herbalist_Camp,                     // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Herbalist_Camp_no_Reward,           // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Herbalist_Camp_Primitive_no_Reward, // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Human_House,                        // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Human_House_no_Reward,              // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Kiln,                               // Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Kiln_no_Reward,                     // Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Leatherworks,                       // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Leatherworks_no_Reward,             // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Lizard_House,                       // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Lizard_House_no_Reward,             // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Lumbermill,                         // Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Lumbermill_no_Reward,               // Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Makeshift_Post_no_Reward,           // Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Manufatory,                         // Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Manufatory_no_Reward,               // Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Market,                             // Market - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Market_no_Reward,                   // Market - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Mine_no_Reward,                     // Mine - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Monastery,                          // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Monastery_no_Reward,                // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Plantation,                         // Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Plantation_no_Reward,               // Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Press,                              // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Press_no_Reward,                    // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Provisioner,                        // Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Provisioner_no_Reward,              // Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Rain_Catcher_no_Reward,             // Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Rainmill,                           // Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Rainmill_no_Reward,                 // Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Ranch,                              // Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Ranch_no_Reward,                    // Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Scribe,                             // Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Scribe_no_Reward,                   // Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Sewer,                              // Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Sewer_no_Reward,                    // Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Shelter,                            // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Shelter_no_Reward,                  // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_SmallFarm,                          // Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_SmallFarm_no_Reward,                // Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Smelter,                            // Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Smelter_no_Reward,                  // Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Smithy,                             // Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Smithy_no_Reward,                   // Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Smokehouse,                         // Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Smokehouse_no_Reward,               // Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Stamping_Mill,                      // Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Stamping_Mill_no_Reward,            // Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Stonecutter_Camp,                   // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Stonecutter_Camp_no_Reward,         // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Storage,                            // Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Storage_no_Reward,                  // Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Supplier,                           // Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Supplier_no_Reward,                 // Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Tavern,                             // Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Tavern_no_Reward,                   // Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Tea_Doctor,                         // Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Tea_Doctor_no_Reward,               // Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Tea_House,                          // Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Tea_House_no_Reward,                // Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Temple,                             // Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Temple_no_Reward,                   // Temple - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Tinctury,                           // Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Tinctury_no_Reward,                 // Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Tinkerer,                           // Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Tinkerer_no_Reward,                 // Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Toolshop,                           // Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Toolshop_no_Reward,                 // Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Trading_Post_no_Reward,             // Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Trappers_Camp,                      // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Trappers_Camp_no_Reward,            // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Trappers_Camp_Primitive_no_Reward,  // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Weaver,                             // Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Weaver_no_Reward,                   // Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Woodcutters_Camp,                   // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Woodcutters_Camp_no_Reward,         // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	Ruined_Workshop,                           // Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	Ruined_Workshop_no_Reward,                 // Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
	Sacrifice_Totem,                           // Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
	Scorpion_1,                                // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	Scorpion_2,                                // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	Scorpion_3,                                // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	SealedTomb_T1,                             // Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
	Snake_1,                                   // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	Snake_2,                                   // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	Snake_3,                                   // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	Spider_1,                                  // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	Spider_2,                                  // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	Spider_3,                                  // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	Termite_Burrow,                            // Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
	TI_AncientShrine_T1,                       // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	Traders_Cemetery,                          // Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
	War_Beast_Cage,                            // Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
	White_Stag,                                // Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
	White_Treasure_Stag,                       // Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	Wildfire,                                  // Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.


	MAX = 317
}

public static class RelicTypesExtensions
{
	private static RelicTypes[] s_All = null;
	public static RelicTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new RelicTypes[317];
			for (int i = 0; i < 317; i++)
			{
				s_All[i] = (RelicTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this RelicTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of RelicTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[RelicTypes.AncientBurrialGrounds];
	}
	
	public static RelicTypes ToRelicTypes(this string name)
	{
		foreach (KeyValuePair<RelicTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find RelicTypes with name: " + name + "\n" + Environment.StackTrace);
		return RelicTypes.Unknown;
	}
	
	public static RelicModel ToRelicModel(this string name)
	{
		RelicModel model = SO.Settings.Relics.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find RelicModel for RelicTypes with name: " + name + "\n" + Environment.StackTrace);
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
		{ RelicTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                           // Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
		{ RelicTypes.AncientGate, "AncientGate" },                                                               // Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
		{ RelicTypes.AncientShrine_T1, "AncientShrine_T1" },                                                     // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ RelicTypes.AncientTemple, "AncientTemple" },                                                           // Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
		{ RelicTypes.Angry_Ghost_1, "Angry Ghost 1" },                                                           // Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
		{ RelicTypes.Angry_Ghost_10, "Angry Ghost 10" },                                                         // Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
		{ RelicTypes.Angry_Ghost_14, "Angry Ghost 14" },                                                         // Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
		{ RelicTypes.Angry_Ghost_15, "Angry Ghost 15" },                                                         // Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
		{ RelicTypes.Angry_Ghost_16, "Angry Ghost 16" },                                                         // Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
		{ RelicTypes.Angry_Ghost_17, "Angry Ghost 17" },                                                         // Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
		{ RelicTypes.Angry_Ghost_18, "Angry Ghost 18" },                                                         // Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
		{ RelicTypes.Angry_Ghost_19, "Angry Ghost 19" },                                                         // Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
		{ RelicTypes.Angry_Ghost_2, "Angry Ghost 2" },                                                           // Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
		{ RelicTypes.Angry_Ghost_20, "Angry Ghost 20" },                                                         // Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
		{ RelicTypes.Angry_Ghost_21, "Angry Ghost 21" },                                                         // Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
		{ RelicTypes.Angry_Ghost_24, "Angry Ghost 24" },                                                         // Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
		{ RelicTypes.Angry_Ghost_31, "Angry Ghost 31" },                                                         // Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
		{ RelicTypes.Angry_Ghost_32, "Angry Ghost 32" },                                                         // Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
		{ RelicTypes.Angry_Ghost_34, "Angry Ghost 34" },                                                         // Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
		{ RelicTypes.Angry_Ghost_4, "Angry Ghost 4" },                                                           // Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
		{ RelicTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                           // Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
		{ RelicTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                           // Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
		{ RelicTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                           // Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
		{ RelicTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                 // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ RelicTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                           // Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
		{ RelicTypes.Black_Stag, "Black Stag" },                                                                 // Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
		{ RelicTypes.Black_Treasure_Stag, "Black Treasure Stag" },                                               // Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ RelicTypes.Blightrot, "Blightrot" },                                                                   // Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
		{ RelicTypes.Blightrot_Cauldron, "Blightrot Cauldron" },                                                 // Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
		{ RelicTypes.Blightrot_Clone, "Blightrot - Clone" },                                                     // Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
		{ RelicTypes.Calm_Ghost_11, "Calm Ghost 11" },                                                           // Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
		{ RelicTypes.Calm_Ghost_12, "Calm Ghost 12" },                                                           // Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
		{ RelicTypes.Calm_Ghost_13, "Calm Ghost 13" },                                                           // Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
		{ RelicTypes.Calm_Ghost_22, "Calm Ghost 22" },                                                           // Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
		{ RelicTypes.Calm_Ghost_23, "Calm Ghost 23" },                                                           // Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
		{ RelicTypes.Calm_Ghost_25, "Calm Ghost 25" },                                                           // Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
		{ RelicTypes.Calm_Ghost_26, "Calm Ghost 26" },                                                           // Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
		{ RelicTypes.Calm_Ghost_27, "Calm Ghost 27" },                                                           // Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
		{ RelicTypes.Calm_Ghost_28, "Calm Ghost 28" },                                                           // Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
		{ RelicTypes.Calm_Ghost_29, "Calm Ghost 29" },                                                           // Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
		{ RelicTypes.Calm_Ghost_3, "Calm Ghost 3" },                                                             // Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
		{ RelicTypes.Calm_Ghost_30, "Calm Ghost 30" },                                                           // Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
		{ RelicTypes.Calm_Ghost_33, "Calm Ghost 33" },                                                           // Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
		{ RelicTypes.Calm_Ghost_35, "Calm Ghost 35" },                                                           // Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
		{ RelicTypes.Calm_Ghost_36, "Calm Ghost 36" },                                                           // Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
		{ RelicTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                             // Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
		{ RelicTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                             // Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
		{ RelicTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                   // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ RelicTypes.Camp_T1, "Camp_T1" },                                                                       // Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ RelicTypes.Camp_T2, "Camp_T2" },                                                                       // Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ RelicTypes.Caravan_T1, "Caravan_T1" },                                                                 // Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ RelicTypes.Caravan_T2, "Caravan_T2" },                                                                 // Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ RelicTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                   // Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
		{ RelicTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                   // Clay Deposit (Large) - Soil infused with the essence of the rain.
		{ RelicTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                               // Clay Deposit (Small) - Soil infused with the essence of the rain.
		{ RelicTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                                   // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
		{ RelicTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                               // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
		{ RelicTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                                   // Flax Field (Large) - Resilient plants that are perfect for cloth-making.
		{ RelicTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                               // Flax Field (Small) - Resilient plants that are perfect for cloth-making.
		{ RelicTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                                 // Herb Node (Large) - A dense shrub, full of many useful plant species.
		{ RelicTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                             // Herb Node (Small) - A dense shrub, full of many useful plant species.
		{ RelicTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                           // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ RelicTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                       // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ RelicTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },                 // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
		{ RelicTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },                   // Dead Leviathan - A giant, dead beast. How did it get here?
		{ RelicTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },           // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
		{ RelicTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                       // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ RelicTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },                   // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ RelicTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                                   // Moss Broccoli Patch (Large) - An edible and tasty type of moss.
		{ RelicTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                               // Moss Broccoli Patch (Small) - An edible and tasty type of moss.
		{ RelicTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                           // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ RelicTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                       // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ RelicTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                                   // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
		{ RelicTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                               // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
		{ RelicTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                 // Root Deposit (Large) - A tangled net of living vines.
		{ RelicTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                             // Root Deposit (Small) - A tangled net of living vines.
		{ RelicTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                         // Sea Marrow Deposit (Large) - Ancient fossils, rich in resources.
		{ RelicTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                     // Sea Marrow Deposit (Small) - Ancient fossils, rich in resources.
		{ RelicTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                           // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ RelicTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                       // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ RelicTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                         // Snake Nest (Large) - A dangerous, but rich source of food and leather.
		{ RelicTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                     // Snake Nest (Small) - A dangerous, but rich source of food and leather.
		{ RelicTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                 // Stone Deposit (Large) - Stones, weathered by the everlasting rain.
		{ RelicTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                             // Stone Deposit (Small) - Stones, weathered by the everlasting rain.
		{ RelicTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                                 // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ RelicTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                             // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ RelicTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                       // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
		{ RelicTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                                   // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
		{ RelicTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                               // Wormtongue Nest (Large) - A nest full of tasty wormtongues.
		{ RelicTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                           // Wormtongue Nest (Small) - A nest full of tasty wormtongues.
		{ RelicTypes.Decay_Altar, "Decay Altar" },                                                               // Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
		{ RelicTypes.Escaped_Convicts, "Escaped Convicts" },                                                     // Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
		{ RelicTypes.Fishmen_Cave, "Fishmen Cave" },                                                             // Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
		{ RelicTypes.Fishmen_Lighthouse, "Fishmen Lighthouse" },                                                 // Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
		{ RelicTypes.Fishmen_Outpost, "Fishmen Outpost" },                                                       // Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
		{ RelicTypes.Fishmen_Soothsayer, "Fishmen Soothsayer" },                                                 // Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
		{ RelicTypes.Fishmen_Totem, "Fishmen Totem" },                                                           // Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
		{ RelicTypes.ForsakenCrypt, "ForsakenCrypt" },                                                           // Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
		{ RelicTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                                 // Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
		{ RelicTypes.Fuming_Machinery, "Fuming Machinery" },                                                     // Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
		{ RelicTypes.Giant_Stormbird, "Giant Stormbird" },                                                       // Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
		{ RelicTypes.Glade_Trader_The_Hermit, "Glade Trader - The Hermit" },                                     // Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
		{ RelicTypes.Glade_Trader_The_Seer, "Glade Trader - The Seer" },                                         // Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
		{ RelicTypes.Glade_Trader_The_Shaman, "Glade Trader - The Shaman" },                                     // Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
		{ RelicTypes.Gold_Stag, "Gold Stag" },                                                                   // Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
		{ RelicTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                 // Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ RelicTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                             // Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
		{ RelicTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                             // Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
		{ RelicTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                               // Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                         // Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                           // Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                     // Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                             // Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                     // Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Harpy_House, "Haunted Ruined Harpy House" },                                 // Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Herb_Garden, "Haunted Ruined Herb Garden" },                                 // Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Human_House, "Haunted Ruined Human House" },                                 // Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Leatherworks, "Haunted Ruined Leatherworks" },                               // Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Lizard_House, "Haunted Ruined Lizard House" },                               // Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Market, "Haunted Ruined Market" },                                           // Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Rainmill, "Haunted Ruined Rainmill" },                                       // Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_SmallFarm, "Haunted Ruined SmallFarm" },                                     // Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Smelter, "Haunted Ruined Smelter" },                                         // Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Temple, "Haunted Ruined Temple" },                                           // Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                             // Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
		{ RelicTypes.Infected_Mole, "Infected Mole" },                                                           // Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
		{ RelicTypes.Infected_Tree, "Infected Tree" },                                                           // Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
		{ RelicTypes.Kelpie, "Kelpie" },                                                                         // River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
		{ RelicTypes.Leaking_Cauldron, "Leaking Cauldron" },                                                     // Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
		{ RelicTypes.Lightning_Catcher, "Lightning Catcher" },                                                   // Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
		{ RelicTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                           // Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
		{ RelicTypes.Merchant_Ship_Wreck, "Merchant Ship Wreck" },                                               // Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
		{ RelicTypes.Mistworm_T1, "Mistworm_T1" },                                                               // Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
		{ RelicTypes.Mole, "Mole" },                                                                             // Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
		{ RelicTypes.Monolith, "Monolith" },                                                                     // Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
		{ RelicTypes.Noxious_Machinery, "Noxious Machinery" },                                                   // Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
		{ RelicTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                     // Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
		{ RelicTypes.Rain_Totem, "Rain Totem" },                                                                 // Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
		{ RelicTypes.Rainpunk_Drill_Coal, "Rainpunk Drill - Coal" },                                             // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ RelicTypes.Rainpunk_Drill_Copper, "Rainpunk Drill - Copper" },                                         // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ RelicTypes.RainpunkFactory, "RainpunkFactory" },                                                       // Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
		{ RelicTypes.RewardChest_T1, "RewardChest_T1" },                                                         // Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ RelicTypes.RewardChest_T2, "RewardChest_T2" },                                                         // Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ RelicTypes.RewardChest_T3, "RewardChest_T3" },                                                         // Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ RelicTypes.Ruined_Advanced_Rain_Catcher, "Ruined Advanced Rain Catcher" },                             // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Advanced_Rain_Catcher_no_Reward, "Ruined Advanced Rain Catcher (no reward)" },       // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Alchemist, "Ruined Alchemist" },                                                     // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Alchemist_no_Reward, "Ruined Alchemist (no reward)" },                               // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Apothecary, "Ruined Apothecary" },                                                   // Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Apothecary_no_Reward, "Ruined Apothecary (no reward)" },                             // Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Artisan, "Ruined Artisan" },                                                         // Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Artisan_no_Reward, "Ruined Artisan (no reward)" },                                   // Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Bakery, "Ruined Bakery" },                                                           // Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Bakery_no_Reward, "Ruined Bakery (no reward)" },                                     // Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Bath_House, "Ruined Bath House" },                                                   // Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Bath_House_no_Reward, "Ruined Bath House (no reward)" },                             // Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Beanery, "Ruined Beanery" },                                                         // Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Beanery_no_Reward, "Ruined Beanery (no reward)" },                                   // Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Beaver_House, "Ruined Beaver House" },                                               // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Beaver_House_no_Reward, "Ruined Beaver House (no reward)" },                         // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Big_Shelter, "Ruined Big Shelter" },                                                 // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Big_Shelter_no_Reward, "Ruined Big Shelter (no reward)" },                           // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Brewery, "Ruined Brewery" },                                                         // Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Brewery_no_Reward, "Ruined Brewery (no reward)" },                                   // Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Brick_Oven, "Ruined Brick Oven" },                                                   // Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Brick_Oven_no_Reward, "Ruined Brick Oven (no reward)" },                             // Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Brickyard, "Ruined Brickyard" },                                                     // Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Brickyard_no_Reward, "Ruined Brickyard (no reward)" },                               // Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Butcher, "Ruined Butcher" },                                                         // Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Butcher_no_Reward, "Ruined Butcher (no reward)" },                                   // Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                     // Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Carpenter_no_Reward, "Ruined Carpenter (no reward)" },                               // Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Cellar, "Ruined Cellar" },                                                           // Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cellar_no_Reward, "Ruined Cellar (no reward)" },                                     // Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                     // Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Clan_Hall_no_Reward, "Ruined Clan Hall (no reward)" },                               // Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                       // Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Clay_Pit_no_Reward, "Ruined Clay Pit (no reward)" },                                 // Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Cookhouse, "Ruined Cookhouse" },                                                     // Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cookhouse_no_Reward, "Ruined Cookhouse (no reward)" },                               // Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Cooperage, "Ruined Cooperage" },                                                     // Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cooperage_no_Reward, "Ruined Cooperage (no reward)" },                               // Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Crude_Workstation_no_Reward, "Ruined Crude Workstation (no reward)" },               // Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Distillery, "Ruined Distillery" },                                                   // Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Distillery_no_Reward, "Ruined Distillery (no reward)" },                             // Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Druid, "Ruined Druid" },                                                             // Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Druid_no_Reward, "Ruined Druid (no reward)" },                                       // Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Explorers_Lodge, "Ruined Explorers Lodge" },                                         // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Explorers_Lodge_no_Reward, "Ruined Explorers Lodge (no reward)" },                   // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Farm, "Ruined Farm" },                                                               // Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Farm_no_Reward, "Ruined Farm (no reward)" },                                         // Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Field_Kitchen_no_Reward, "Ruined Field Kitchen (no reward)" },                       // Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Finesmith, "Ruined Finesmith" },                                                     // Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Finesmith_no_Reward, "Ruined Finesmith (no reward)" },                               // Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                             // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Foragers_Camp_no_Reward, "Ruined Foragers Camp (no reward)" },                       // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Foragers_Camp_Primitive_no_Reward, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Forum, "Ruined Forum" },                                                             // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Forum_no_Reward, "Ruined Forum (no reward)" },                                       // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Fox_House, "Ruined Fox House" },                                                     // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Fox_House_no_Reward, "Ruined Fox House (no reward)" },                               // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Furnace, "Ruined Furnace" },                                                         // Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Furnace_no_Reward, "Ruined Furnace (no reward)" },                                   // Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Granary, "Ruined Granary" },                                                         // Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Granary_no_Reward, "Ruined Granary (no reward)" },                                   // Granary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Greenhouse, "Ruined Greenhouse" },                                                   // Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Greenhouse_no_Reward, "Ruined Greenhouse (no reward)" },                             // Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Grill, "Ruined Grill" },                                                             // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Grill_no_Reward, "Ruined Grill (no reward)" },                                       // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Grove, "Ruined Grove" },                                                             // Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Grove_no_Reward, "Ruined Grove (no reward)" },                                       // Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Guild_House, "Ruined Guild House" },                                                 // Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Guild_House_no_Reward, "Ruined Guild House (no reward)" },                           // Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Harpy_House, "Ruined Harpy House" },                                                 // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Harpy_House_no_Reward, "Ruined Harpy House (no reward)" },                           // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Harvester_Camp, "Ruined Harvester Camp" },                                           // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Harvester_Camp_no_Reward, "Ruined Harvester Camp (no reward)" },                     // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Hearth, "Ruined Hearth" },                                                           // Ancient Hearth - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Hearth_no_Reward, "Ruined Hearth (no reward)" },                                     // Ancient Hearth - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Herb_Garden, "Ruined Herb Garden" },                                                 // Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Herb_Garden_no_Reward, "Ruined Herb Garden (no reward)" },                           // Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Herbalist_Camp, "Ruined Herbalist Camp" },                                           // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Herbalist_Camp_no_Reward, "Ruined Herbalist Camp (no reward)" },                     // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Herbalist_Camp_Primitive_no_Reward, "Ruined Herbalist Camp primitive (no reward)" }, // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Human_House, "Ruined Human House" },                                                 // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Human_House_no_Reward, "Ruined Human House (no reward)" },                           // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Kiln, "Ruined Kiln" },                                                               // Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Kiln_no_Reward, "Ruined Kiln (no reward)" },                                         // Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Leatherworks, "Ruined Leatherworks" },                                               // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Leatherworks_no_Reward, "Ruined Leatherworks (no reward)" },                         // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Lizard_House, "Ruined Lizard House" },                                               // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Lizard_House_no_Reward, "Ruined Lizard House (no reward)" },                         // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Lumbermill, "Ruined Lumbermill" },                                                   // Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Lumbermill_no_Reward, "Ruined Lumbermill (no reward)" },                             // Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Makeshift_Post_no_Reward, "Ruined Makeshift Post (no reward)" },                     // Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Manufatory, "Ruined Manufatory" },                                                   // Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Manufatory_no_Reward, "Ruined Manufatory (no reward)" },                             // Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Market, "Ruined Market" },                                                           // Market - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Market_no_Reward, "Ruined Market (no reward)" },                                     // Market - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Mine_no_Reward, "Ruined Mine (no reward)" },                                         // Mine - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Monastery, "Ruined Monastery" },                                                     // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Monastery_no_Reward, "Ruined Monastery (no reward)" },                               // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Plantation, "Ruined Plantation" },                                                   // Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Plantation_no_Reward, "Ruined Plantation (no reward)" },                             // Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Press, "Ruined Press" },                                                             // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Press_no_Reward, "Ruined Press (no reward)" },                                       // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Provisioner, "Ruined Provisioner" },                                                 // Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Provisioner_no_Reward, "Ruined Provisioner (no reward)" },                           // Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Rain_Catcher_no_Reward, "Ruined Rain Catcher (no reward)" },                         // Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Rainmill, "Ruined Rainmill" },                                                       // Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Rainmill_no_Reward, "Ruined Rainmill (no reward)" },                                 // Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Ranch, "Ruined Ranch" },                                                             // Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Ranch_no_Reward, "Ruined Ranch (no reward)" },                                       // Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Scribe, "Ruined Scribe" },                                                           // Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Scribe_no_Reward, "Ruined Scribe (no reward)" },                                     // Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Sewer, "Ruined Sewer" },                                                             // Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Sewer_no_Reward, "Ruined Sewer (no reward)" },                                       // Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Shelter, "Ruined Shelter" },                                                         // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Shelter_no_Reward, "Ruined Shelter (no reward)" },                                   // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_SmallFarm, "Ruined SmallFarm" },                                                     // Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_SmallFarm_no_Reward, "Ruined SmallFarm (no reward)" },                               // Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Smelter, "Ruined Smelter" },                                                         // Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Smelter_no_Reward, "Ruined Smelter (no reward)" },                                   // Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Smithy, "Ruined Smithy" },                                                           // Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Smithy_no_Reward, "Ruined Smithy (no reward)" },                                     // Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Smokehouse, "Ruined Smokehouse" },                                                   // Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Smokehouse_no_Reward, "Ruined Smokehouse (no reward)" },                             // Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Stamping_Mill, "Ruined Stamping Mill" },                                             // Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Stamping_Mill_no_Reward, "Ruined Stamping Mill (no reward)" },                       // Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Stonecutter_Camp, "Ruined Stonecutter Camp" },                                       // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Stonecutter_Camp_no_Reward, "Ruined Stonecutter Camp (no reward)" },                 // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Storage, "Ruined Storage" },                                                         // Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Storage_no_Reward, "Ruined Storage (no reward)" },                                   // Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Supplier, "Ruined Supplier" },                                                       // Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Supplier_no_Reward, "Ruined Supplier (no reward)" },                                 // Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Tavern, "Ruined Tavern" },                                                           // Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Tavern_no_Reward, "Ruined Tavern (no reward)" },                                     // Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Tea_Doctor, "Ruined Tea Doctor" },                                                   // Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Tea_Doctor_no_Reward, "Ruined Tea Doctor (no reward)" },                             // Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Tea_House, "Ruined Tea House" },                                                     // Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Tea_House_no_Reward, "Ruined Tea House (no reward)" },                               // Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Temple, "Ruined Temple" },                                                           // Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Temple_no_Reward, "Ruined Temple (no reward)" },                                     // Temple - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Tinctury, "Ruined Tinctury" },                                                       // Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Tinctury_no_Reward, "Ruined Tinctury (no reward)" },                                 // Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Tinkerer, "Ruined Tinkerer" },                                                       // Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Tinkerer_no_Reward, "Ruined Tinkerer (no reward)" },                                 // Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Toolshop, "Ruined Toolshop" },                                                       // Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Toolshop_no_Reward, "Ruined Toolshop (no reward)" },                                 // Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Trading_Post_no_Reward, "Ruined Trading Post (no reward)" },                         // Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Trappers_Camp, "Ruined Trappers Camp" },                                             // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Trappers_Camp_no_Reward, "Ruined Trappers Camp (no reward)" },                       // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Trappers_Camp_Primitive_no_Reward, "Ruined Trappers Camp Primitive (no reward)" },   // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Weaver, "Ruined Weaver" },                                                           // Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Weaver_no_Reward, "Ruined Weaver (no reward)" },                                     // Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Woodcutters_Camp, "Ruined Woodcutters Camp" },                                       // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Woodcutters_Camp_no_Reward, "Ruined Woodcutters Camp (no reward)" },                 // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Workshop, "Ruined Workshop" },                                                       // Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Workshop_no_Reward, "Ruined Workshop (no reward)" },                                 // Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Sacrifice_Totem, "Sacrifice Totem" },                                                       // Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
		{ RelicTypes.Scorpion_1, "Scorpion 1" },                                                                 // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ RelicTypes.Scorpion_2, "Scorpion 2" },                                                                 // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ RelicTypes.Scorpion_3, "Scorpion 3" },                                                                 // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ RelicTypes.SealedTomb_T1, "SealedTomb_T1" },                                                           // Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
		{ RelicTypes.Snake_1, "Snake 1" },                                                                       // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ RelicTypes.Snake_2, "Snake 2" },                                                                       // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ RelicTypes.Snake_3, "Snake 3" },                                                                       // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ RelicTypes.Spider_1, "Spider 1" },                                                                     // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ RelicTypes.Spider_2, "Spider 2" },                                                                     // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ RelicTypes.Spider_3, "Spider 3" },                                                                     // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ RelicTypes.Termite_Burrow, "Termite Burrow" },                                                         // Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
		{ RelicTypes.TI_AncientShrine_T1, "TI AncientShrine_T1" },                                               // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ RelicTypes.Traders_Cemetery, "Traders Cemetery" },                                                     // Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
		{ RelicTypes.War_Beast_Cage, "War Beast Cage" },                                                         // Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
		{ RelicTypes.White_Stag, "White Stag" },                                                                 // Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous (<sprite name="dangerous">) or Forbidden Glade (<sprite name="forbidden">). It is said that a special treasure awaits the one who captures it.
		{ RelicTypes.White_Treasure_Stag, "White Treasure Stag" },                                               // Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ RelicTypes.Wildfire, "Wildfire" },                                                                     // Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.

	};
}
