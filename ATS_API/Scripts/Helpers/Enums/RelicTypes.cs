using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
/// </summary>
public enum RelicTypes
{
    /// <summary>
    /// Placeholder for an unknown RelicTypes. Typically, seen if a method failed to find some data .
    /// </summary>
	Unknown = -1,
	
	/// <summary>
    /// Placeholder for no RelicTypes. Typically, seen if nothing is defined or failed to parse a string to a RelicTypes.
    /// </summary>
	None = 0,
	
	/// <summary>
	/// Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
	/// </summary>
	/// <name>AncientBurrialGrounds</name>
	AncientBurrialGrounds = 1,

	/// <summary>
	/// Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
	/// </summary>
	/// <name>AncientGate</name>
	AncientGate = 2,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>AncientShrine_T1</name>
	AncientShrine_T1 = 3,

	/// <summary>
	/// Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
	/// </summary>
	/// <name>AncientTemple</name>
	AncientTemple = 4,

	/// <summary>
	/// Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
	/// </summary>
	/// <name>Angry Ghost 1</name>
	Angry_Ghost_1 = 5,

	/// <summary>
	/// Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
	/// </summary>
	/// <name>Angry Ghost 10</name>
	Angry_Ghost_10 = 6,

	/// <summary>
	/// Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
	/// </summary>
	/// <name>Angry Ghost 14</name>
	Angry_Ghost_14 = 7,

	/// <summary>
	/// Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
	/// </summary>
	/// <name>Angry Ghost 15</name>
	Angry_Ghost_15 = 8,

	/// <summary>
	/// Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
	/// </summary>
	/// <name>Angry Ghost 16</name>
	Angry_Ghost_16 = 9,

	/// <summary>
	/// Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
	/// </summary>
	/// <name>Angry Ghost 17</name>
	Angry_Ghost_17 = 10,

	/// <summary>
	/// Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
	/// </summary>
	/// <name>Angry Ghost 18</name>
	Angry_Ghost_18 = 11,

	/// <summary>
	/// Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
	/// </summary>
	/// <name>Angry Ghost 19</name>
	Angry_Ghost_19 = 12,

	/// <summary>
	/// Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
	/// </summary>
	/// <name>Angry Ghost 2</name>
	Angry_Ghost_2 = 13,

	/// <summary>
	/// Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
	/// </summary>
	/// <name>Angry Ghost 20</name>
	Angry_Ghost_20 = 14,

	/// <summary>
	/// Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
	/// </summary>
	/// <name>Angry Ghost 21</name>
	Angry_Ghost_21 = 15,

	/// <summary>
	/// Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
	/// </summary>
	/// <name>Angry Ghost 24</name>
	Angry_Ghost_24 = 16,

	/// <summary>
	/// Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
	/// </summary>
	/// <name>Angry Ghost 31</name>
	Angry_Ghost_31 = 17,

	/// <summary>
	/// Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
	/// </summary>
	/// <name>Angry Ghost 32</name>
	Angry_Ghost_32 = 18,

	/// <summary>
	/// Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
	/// </summary>
	/// <name>Angry Ghost 34</name>
	Angry_Ghost_34 = 19,

	/// <summary>
	/// Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
	/// </summary>
	/// <name>Angry Ghost 4</name>
	Angry_Ghost_4 = 20,

	/// <summary>
	/// Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
	/// </summary>
	/// <name>Angry Ghost 41</name>
	Angry_Ghost_41 = 21,

	/// <summary>
	/// Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
	/// </summary>
	/// <name>Angry Ghost 5</name>
	Angry_Ghost_5 = 22,

	/// <summary>
	/// Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
	/// </summary>
	/// <name>Angry Ghost 6</name>
	Angry_Ghost_6 = 23,

	/// <summary>
	/// Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
	/// </summary>
	/// <name>Angry Ghost 9</name>
	Angry_Ghost_9 = 24,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>AngryGhostChest_T1</name>
	AngryGhostChest_T1 = 25,

	/// <summary>
	/// Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
	/// </summary>
	/// <name>BeaverBattleground_T1</name>
	BeaverBattleground_T1 = 26,

	/// <summary>
	/// Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Black Stag</name>
	Black_Stag = 27,

	/// <summary>
	/// Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Black Treasure Stag</name>
	Black_Treasure_Stag = 28,

	/// <summary>
	/// Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
	/// </summary>
	/// <name>Blightrot</name>
	Blightrot = 29,

	/// <summary>
	/// Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
	/// </summary>
	/// <name>Blightrot Cauldron</name>
	Blightrot_Cauldron = 30,

	/// <summary>
	/// Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
	/// </summary>
	/// <name>Blightrot - Clone</name>
	Blightrot_Clone = 31,

	/// <summary>
	/// Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
	/// </summary>
	/// <name>Calm Ghost 11</name>
	Calm_Ghost_11 = 32,

	/// <summary>
	/// Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
	/// </summary>
	/// <name>Calm Ghost 12</name>
	Calm_Ghost_12 = 33,

	/// <summary>
	/// Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
	/// </summary>
	/// <name>Calm Ghost 13</name>
	Calm_Ghost_13 = 34,

	/// <summary>
	/// Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
	/// </summary>
	/// <name>Calm Ghost 22</name>
	Calm_Ghost_22 = 35,

	/// <summary>
	/// Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
	/// </summary>
	/// <name>Calm Ghost 23</name>
	Calm_Ghost_23 = 36,

	/// <summary>
	/// Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
	/// </summary>
	/// <name>Calm Ghost 25</name>
	Calm_Ghost_25 = 37,

	/// <summary>
	/// Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
	/// </summary>
	/// <name>Calm Ghost 26</name>
	Calm_Ghost_26 = 38,

	/// <summary>
	/// Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
	/// </summary>
	/// <name>Calm Ghost 27</name>
	Calm_Ghost_27 = 39,

	/// <summary>
	/// Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
	/// </summary>
	/// <name>Calm Ghost 28</name>
	Calm_Ghost_28 = 40,

	/// <summary>
	/// Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
	/// </summary>
	/// <name>Calm Ghost 29</name>
	Calm_Ghost_29 = 41,

	/// <summary>
	/// Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
	/// </summary>
	/// <name>Calm Ghost 3</name>
	Calm_Ghost_3 = 42,

	/// <summary>
	/// Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
	/// </summary>
	/// <name>Calm Ghost 30</name>
	Calm_Ghost_30 = 43,

	/// <summary>
	/// Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
	/// </summary>
	/// <name>Calm Ghost 33</name>
	Calm_Ghost_33 = 44,

	/// <summary>
	/// Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
	/// </summary>
	/// <name>Calm Ghost 35</name>
	Calm_Ghost_35 = 45,

	/// <summary>
	/// Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
	/// </summary>
	/// <name>Calm Ghost 36</name>
	Calm_Ghost_36 = 46,

	/// <summary>
	/// Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
	/// </summary>
	/// <name>Calm Ghost 38</name>
	Calm_Ghost_38 = 47,

	/// <summary>
	/// Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
	/// </summary>
	/// <name>Calm Ghost 39</name>
	Calm_Ghost_39 = 48,

	/// <summary>
	/// Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
	/// </summary>
	/// <name>Calm Ghost 40</name>
	Calm_Ghost_40 = 49,

	/// <summary>
	/// Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
	/// </summary>
	/// <name>Calm Ghost 7</name>
	Calm_Ghost_7 = 50,

	/// <summary>
	/// Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
	/// </summary>
	/// <name>Calm Ghost 8</name>
	Calm_Ghost_8 = 51,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>CalmGhostChest_T1</name>
	CalmGhostChest_T1 = 52,

	/// <summary>
	/// Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T1</name>
	Camp_T1 = 53,

	/// <summary>
	/// Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T2</name>
	Camp_T2 = 54,

	/// <summary>
	/// Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T1</name>
	Caravan_T1 = 55,

	/// <summary>
	/// Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T2</name>
	Caravan_T2 = 56,

	/// <summary>
	/// Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
	/// </summary>
	/// <name>Corrupted Caravan</name>
	Corrupted_Caravan = 57,

	/// <summary>
	/// Clay Node (Large) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClayBig</name>
	DebugNode_ClayBig = 58,

	/// <summary>
	/// Clay Node (Small) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClaySmall</name>
	DebugNode_ClaySmall = 59,

	/// <summary>
	/// Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushBig</name>
	DebugNode_DewberryBushBig = 60,

	/// <summary>
	/// Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushSmall</name>
	DebugNode_DewberryBushSmall = 61,

	/// <summary>
	/// Flax Field (Large) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxBig</name>
	DebugNode_FlaxBig = 62,

	/// <summary>
	/// Flax Field (Small) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxSmall</name>
	DebugNode_FlaxSmall = 63,

	/// <summary>
	/// Herb Node (Large) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsBig</name>
	DebugNode_HerbsBig = 64,

	/// <summary>
	/// Herb Node (Small) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsSmall</name>
	DebugNode_HerbsSmall = 65,

	/// <summary>
	/// Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherBig</name>
	DebugNode_LeechBroodmotherBig = 66,

	/// <summary>
	/// Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherSmall</name>
	DebugNode_LeechBroodmotherSmall = 67,

	/// <summary>
	/// Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteGrain</name>
	DebugNode_Marshlands_InfiniteGrain = 68,

	/// <summary>
	/// Dead Leviathan - A giant, dead beast. How did it get here?
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMeat</name>
	DebugNode_Marshlands_InfiniteMeat = 69,

	/// <summary>
	/// Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMushroom</name>
	DebugNode_Marshlands_InfiniteMushroom = 70,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomBig</name>
	DebugNode_MarshlandsMushroomBig = 71,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomSmall</name>
	DebugNode_MarshlandsMushroomSmall = 72,

	/// <summary>
	/// Moss Broccoli Patch (Large) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliBig</name>
	DebugNode_MossBroccoliBig = 73,

	/// <summary>
	/// Moss Broccoli Patch (Small) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliSmall</name>
	DebugNode_MossBroccoliSmall = 74,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomBig</name>
	DebugNode_MushroomBig = 75,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomSmall</name>
	DebugNode_MushroomSmall = 76,

	/// <summary>
	/// Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedBig</name>
	DebugNode_ReedBig = 77,

	/// <summary>
	/// Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedSmall</name>
	DebugNode_ReedSmall = 78,

	/// <summary>
	/// Root Node (Large) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsBig</name>
	DebugNode_RootsBig = 79,

	/// <summary>
	/// Root Node (Small) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsSmall</name>
	DebugNode_RootsSmall = 80,

	/// <summary>
	/// Sea Marrow Node (Large) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowBig</name>
	DebugNode_SeaMarrowBig = 81,

	/// <summary>
	/// Sea Marrow Node (Small) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowSmall</name>
	DebugNode_SeaMarrowSmall = 82,

	/// <summary>
	/// Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherBig</name>
	DebugNode_SnailBroodmotherBig = 83,

	/// <summary>
	/// Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherSmall</name>
	DebugNode_SnailBroodmotherSmall = 84,

	/// <summary>
	/// Snake Nest (Large) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestBig</name>
	DebugNode_SnakeNestBig = 85,

	/// <summary>
	/// Snake Nest (Small) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestSmall</name>
	DebugNode_SnakeNestSmall = 86,

	/// <summary>
	/// Stone Node (Large) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneBig</name>
	DebugNode_StoneBig = 87,

	/// <summary>
	/// Stone Node (Small) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneSmall</name>
	DebugNode_StoneSmall = 88,

	/// <summary>
	/// Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestBig</name>
	DebugNode_StormbirdNestBig = 89,

	/// <summary>
	/// Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestSmall</name>
	DebugNode_StormbirdNestSmall = 90,

	/// <summary>
	/// Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatBig</name>
	DebugNode_SwampWheatBig = 91,

	/// <summary>
	/// Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatSmall</name>
	DebugNode_SwampWheatSmall = 92,

	/// <summary>
	/// Wormtongue Nest (Large) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestBig</name>
	DebugNode_WormtongueNestBig = 93,

	/// <summary>
	/// Wormtongue Nest (Small) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestSmall</name>
	DebugNode_WormtongueNestSmall = 94,

	/// <summary>
	/// Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
	/// </summary>
	/// <name>Decay Altar</name>
	Decay_Altar = 95,

	/// <summary>
	/// Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
	/// </summary>
	/// <name>Escaped Convicts</name>
	Escaped_Convicts = 96,

	/// <summary>
	/// Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
	/// </summary>
	/// <name>Fishmen Cave</name>
	Fishmen_Cave = 97,

	/// <summary>
	/// Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
	/// </summary>
	/// <name>Fishmen Lighthouse</name>
	Fishmen_Lighthouse = 98,

	/// <summary>
	/// Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
	/// </summary>
	/// <name>Fishmen Outpost</name>
	Fishmen_Outpost = 99,

	/// <summary>
	/// Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
	/// </summary>
	/// <name>Fishmen Soothsayer</name>
	Fishmen_Soothsayer = 100,

	/// <summary>
	/// Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
	/// </summary>
	/// <name>Fishmen Totem</name>
	Fishmen_Totem = 101,

	/// <summary>
	/// Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
	/// </summary>
	/// <name>ForsakenCrypt</name>
	ForsakenCrypt = 102,

	/// <summary>
	/// Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
	/// </summary>
	/// <name>FoxBattleground_T1</name>
	FoxBattleground_T1 = 103,

	/// <summary>
	/// Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
	/// </summary>
	/// <name>FrogBattleground_T1</name>
	FrogBattleground_T1 = 104,

	/// <summary>
	/// Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
	/// </summary>
	/// <name>Fuming Machinery</name>
	Fuming_Machinery = 105,

	/// <summary>
	/// Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
	/// </summary>
	/// <name>Giant Stormbird</name>
	Giant_Stormbird = 106,

	/// <summary>
	/// Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
	/// </summary>
	/// <name>Glade Trader - The Hermit</name>
	Glade_Trader_The_Hermit = 107,

	/// <summary>
	/// Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
	/// </summary>
	/// <name>Glade Trader - The Seer</name>
	Glade_Trader_The_Seer = 108,

	/// <summary>
	/// Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
	/// </summary>
	/// <name>Glade Trader - The Shaman</name>
	Glade_Trader_The_Shaman = 109,

	/// <summary>
	/// Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Gold Stag</name>
	Gold_Stag = 110,

	/// <summary>
	/// Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Gold Treasure Stag</name>
	Gold_Treasure_Stag = 111,

	/// <summary>
	/// Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
	/// </summary>
	/// <name>Harmony Spirit Altar</name>
	Harmony_Spirit_Altar = 112,

	/// <summary>
	/// Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
	/// </summary>
	/// <name>HarpyBattleground_T1</name>
	HarpyBattleground_T1 = 113,

	/// <summary>
	/// Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Beaver House</name>
	Haunted_Ruined_Beaver_House = 114,

	/// <summary>
	/// Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Brewery</name>
	Haunted_Ruined_Brewery = 115,

	/// <summary>
	/// Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cellar</name>
	Haunted_Ruined_Cellar = 116,

	/// <summary>
	/// Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cooperage</name>
	Haunted_Ruined_Cooperage = 117,

	/// <summary>
	/// Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Druid</name>
	Haunted_Ruined_Druid = 118,

	/// <summary>
	/// Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Fox House</name>
	Haunted_Ruined_Fox_House = 119,

	/// <summary>
	/// Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Frog House</name>
	Haunted_Ruined_Frog_House = 120,

	/// <summary>
	/// Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Guild House</name>
	Haunted_Ruined_Guild_House = 121,

	/// <summary>
	/// Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Harpy House</name>
	Haunted_Ruined_Harpy_House = 122,

	/// <summary>
	/// Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Herb Garden</name>
	Haunted_Ruined_Herb_Garden = 123,

	/// <summary>
	/// Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Human House</name>
	Haunted_Ruined_Human_House = 124,

	/// <summary>
	/// Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Leatherworks</name>
	Haunted_Ruined_Leatherworks = 125,

	/// <summary>
	/// Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Lizard House</name>
	Haunted_Ruined_Lizard_House = 126,

	/// <summary>
	/// Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Market</name>
	Haunted_Ruined_Market = 127,

	/// <summary>
	/// Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Rainmill</name>
	Haunted_Ruined_Rainmill = 128,

	/// <summary>
	/// Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined SmallFarm</name>
	Haunted_Ruined_SmallFarm = 129,

	/// <summary>
	/// Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Smelter</name>
	Haunted_Ruined_Smelter = 130,

	/// <summary>
	/// Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Temple</name>
	Haunted_Ruined_Temple = 131,

	/// <summary>
	/// Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
	/// </summary>
	/// <name>HumanBattleground_T1</name>
	HumanBattleground_T1 = 132,

	/// <summary>
	/// Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
	/// </summary>
	/// <name>Infected Mole</name>
	Infected_Mole = 133,

	/// <summary>
	/// Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
	/// </summary>
	/// <name>Infected Tree</name>
	Infected_Tree = 134,

	/// <summary>
	/// River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
	/// </summary>
	/// <name>Kelpie</name>
	Kelpie = 135,

	/// <summary>
	/// Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
	/// </summary>
	/// <name>Leaking Cauldron</name>
	Leaking_Cauldron = 136,

	/// <summary>
	/// Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
	/// </summary>
	/// <name>Lightning Catcher</name>
	Lightning_Catcher = 137,

	/// <summary>
	/// Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
	/// </summary>
	/// <name>LizardBattleground_T1</name>
	LizardBattleground_T1 = 138,

	/// <summary>
	/// Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
	/// </summary>
	/// <name>Merchant Ship Wreck</name>
	Merchant_Ship_Wreck = 139,

	/// <summary>
	/// Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
	/// </summary>
	/// <name>Mistworm_T1</name>
	Mistworm_T1 = 140,

	/// <summary>
	/// Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
	/// </summary>
	/// <name>Mole</name>
	Mole = 141,

	/// <summary>
	/// Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
	/// </summary>
	/// <name>Monolith</name>
	Monolith = 142,

	/// <summary>
	/// Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
	/// </summary>
	/// <name>Noxious Machinery</name>
	Noxious_Machinery = 143,

	/// <summary>
	/// Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
	/// </summary>
	/// <name>PetrifiedTree_T1</name>
	PetrifiedTree_T1 = 144,

	/// <summary>
	/// Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
	/// </summary>
	/// <name>Rain Totem</name>
	Rain_Totem = 145,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Coal</name>
	Rainpunk_Drill_Coal = 146,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Copper</name>
	Rainpunk_Drill_Copper = 147,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Salt</name>
	Rainpunk_Drill_Salt = 148,

	/// <summary>
	/// Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
	/// </summary>
	/// <name>RainpunkFactory</name>
	RainpunkFactory = 149,

	/// <summary>
	/// Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T1</name>
	RewardChest_T1 = 150,

	/// <summary>
	/// Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T2</name>
	RewardChest_T2 = 151,

	/// <summary>
	/// Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T3</name>
	RewardChest_T3 = 152,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher</name>
	Ruined_Advanced_Rain_Catcher = 153,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher (no reward)</name>
	Ruined_Advanced_Rain_Catcher_no_Reward = 154,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Alchemist</name>
	Ruined_Alchemist = 155,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Alchemist (no reward)</name>
	Ruined_Alchemist_no_Reward = 156,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Apothecary</name>
	Ruined_Apothecary = 157,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Apothecary (no reward)</name>
	Ruined_Apothecary_no_Reward = 158,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Artisan</name>
	Ruined_Artisan = 159,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Artisan (no reward)</name>
	Ruined_Artisan_no_Reward = 160,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bakery</name>
	Ruined_Bakery = 161,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bakery (no reward)</name>
	Ruined_Bakery_no_Reward = 162,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bath House</name>
	Ruined_Bath_House = 163,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bath House (no reward)</name>
	Ruined_Bath_House_no_Reward = 164,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Beanery</name>
	Ruined_Beanery = 165,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beanery (no reward)</name>
	Ruined_Beanery_no_Reward = 166,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House</name>
	Ruined_Beaver_House = 167,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House (no reward)</name>
	Ruined_Beaver_House_no_Reward = 168,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter</name>
	Ruined_Big_Shelter = 169,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter (no reward)</name>
	Ruined_Big_Shelter_no_Reward = 170,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brewery</name>
	Ruined_Brewery = 171,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brewery (no reward)</name>
	Ruined_Brewery_no_Reward = 172,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brick Oven</name>
	Ruined_Brick_Oven = 173,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brick Oven (no reward)</name>
	Ruined_Brick_Oven_no_Reward = 174,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brickyard</name>
	Ruined_Brickyard = 175,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brickyard (no reward)</name>
	Ruined_Brickyard_no_Reward = 176,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Butcher</name>
	Ruined_Butcher = 177,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Butcher (no reward)</name>
	Ruined_Butcher_no_Reward = 178,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cannery</name>
	Ruined_Cannery = 179,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cannery (no reward)</name>
	Ruined_Cannery_no_Reward = 180,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Carpenter</name>
	Ruined_Carpenter = 181,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Carpenter (no reward)</name>
	Ruined_Carpenter_no_Reward = 182,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cellar</name>
	Ruined_Cellar = 183,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cellar (no reward)</name>
	Ruined_Cellar_no_Reward = 184,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clan Hall</name>
	Ruined_Clan_Hall = 185,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clan Hall (no reward)</name>
	Ruined_Clan_Hall_no_Reward = 186,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clay Pit</name>
	Ruined_Clay_Pit = 187,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clay Pit (no reward)</name>
	Ruined_Clay_Pit_no_Reward = 188,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cobbler</name>
	Ruined_Cobbler = 189,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cobbler (no reward)</name>
	Ruined_Cobbler_no_Reward = 190,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cookhouse</name>
	Ruined_Cookhouse = 191,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cookhouse (no reward)</name>
	Ruined_Cookhouse_no_Reward = 192,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cooperage</name>
	Ruined_Cooperage = 193,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cooperage (no reward)</name>
	Ruined_Cooperage_no_Reward = 194,

	/// <summary>
	/// Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Crude Workstation (no reward)</name>
	Ruined_Crude_Workstation_no_Reward = 195,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Distillery</name>
	Ruined_Distillery = 196,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Distillery (no reward)</name>
	Ruined_Distillery_no_Reward = 197,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Druid</name>
	Ruined_Druid = 198,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Druid (no reward)</name>
	Ruined_Druid_no_Reward = 199,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Explorers Lodge</name>
	Ruined_Explorers_Lodge = 200,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Explorers Lodge (no reward)</name>
	Ruined_Explorers_Lodge_no_Reward = 201,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Farm</name>
	Ruined_Farm = 202,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Farm (no reward)</name>
	Ruined_Farm_no_Reward = 203,

	/// <summary>
	/// Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Field Kitchen (no reward)</name>
	Ruined_Field_Kitchen_no_Reward = 204,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Finesmith</name>
	Ruined_Finesmith = 205,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Finesmith (no reward)</name>
	Ruined_Finesmith_no_Reward = 206,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Fishing Hut</name>
	Ruined_Fishing_Hut = 207,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut (no reward)</name>
	Ruined_Fishing_Hut_no_Reward = 208,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut Primitive (no reward)</name>
	Ruined_Fishing_Hut_Primitive_no_Reward = 209,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Foragers Camp</name>
	Ruined_Foragers_Camp = 210,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp (no reward)</name>
	Ruined_Foragers_Camp_no_Reward = 211,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp Primitive (no reward)</name>
	Ruined_Foragers_Camp_Primitive_no_Reward = 212,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum</name>
	Ruined_Forum = 213,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum (no reward)</name>
	Ruined_Forum_no_Reward = 214,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House</name>
	Ruined_Fox_House = 215,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House (no reward)</name>
	Ruined_Fox_House_no_Reward = 216,

	/// <summary>
	/// Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Frog House (no reward)</name>
	Ruined_Frog_House_no_Reward = 217,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Furnace</name>
	Ruined_Furnace = 218,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Furnace (no reward)</name>
	Ruined_Furnace_no_Reward = 219,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Granary</name>
	Ruined_Granary = 220,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Granary (no reward)</name>
	Ruined_Granary_no_Reward = 221,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Greenhouse</name>
	Ruined_Greenhouse = 222,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Greenhouse (no reward)</name>
	Ruined_Greenhouse_no_Reward = 223,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill</name>
	Ruined_Grill = 224,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill (no reward)</name>
	Ruined_Grill_no_Reward = 225,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grove</name>
	Ruined_Grove = 226,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Grove (no reward)</name>
	Ruined_Grove_no_Reward = 227,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Guild House</name>
	Ruined_Guild_House = 228,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Guild House (no reward)</name>
	Ruined_Guild_House_no_Reward = 229,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House</name>
	Ruined_Harpy_House = 230,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House (no reward)</name>
	Ruined_Harpy_House_no_Reward = 231,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Harvester Camp</name>
	Ruined_Harvester_Camp = 232,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harvester Camp (no reward)</name>
	Ruined_Harvester_Camp_no_Reward = 233,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herb Garden</name>
	Ruined_Herb_Garden = 234,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herb Garden (no reward)</name>
	Ruined_Herb_Garden_no_Reward = 235,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herbalist Camp</name>
	Ruined_Herbalist_Camp = 236,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp (no reward)</name>
	Ruined_Herbalist_Camp_no_Reward = 237,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp primitive (no reward)</name>
	Ruined_Herbalist_Camp_Primitive_no_Reward = 238,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House</name>
	Ruined_Human_House = 239,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House (no reward)</name>
	Ruined_Human_House_no_Reward = 240,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Kiln</name>
	Ruined_Kiln = 241,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Kiln (no reward)</name>
	Ruined_Kiln_no_Reward = 242,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks</name>
	Ruined_Leatherworks = 243,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks (no reward)</name>
	Ruined_Leatherworks_no_Reward = 244,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House</name>
	Ruined_Lizard_House = 245,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House (no reward)</name>
	Ruined_Lizard_House_no_Reward = 246,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Lumbermill</name>
	Ruined_Lumbermill = 247,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lumbermill (no reward)</name>
	Ruined_Lumbermill_no_Reward = 248,

	/// <summary>
	/// Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Makeshift Post (no reward)</name>
	Ruined_Makeshift_Post_no_Reward = 249,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Manufatory</name>
	Ruined_Manufatory = 250,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Manufatory (no reward)</name>
	Ruined_Manufatory_no_Reward = 251,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Market</name>
	Ruined_Market = 252,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Market (no reward)</name>
	Ruined_Market_no_Reward = 253,

	/// <summary>
	/// Mine - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Mine (no reward)</name>
	Ruined_Mine_no_Reward = 254,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery</name>
	Ruined_Monastery = 255,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery (no reward)</name>
	Ruined_Monastery_no_Reward = 256,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Pantry</name>
	Ruined_Pantry = 257,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Pantry (no reward)</name>
	Ruined_Pantry_no_Reward = 258,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Plantation</name>
	Ruined_Plantation = 259,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Plantation (no reward)</name>
	Ruined_Plantation_no_Reward = 260,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press</name>
	Ruined_Press = 261,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press (no reward)</name>
	Ruined_Press_no_Reward = 262,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Provisioner</name>
	Ruined_Provisioner = 263,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Provisioner (no reward)</name>
	Ruined_Provisioner_no_Reward = 264,

	/// <summary>
	/// Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rain Catcher (no reward)</name>
	Ruined_Rain_Catcher_no_Reward = 265,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Rainmill</name>
	Ruined_Rainmill = 266,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rainmill (no reward)</name>
	Ruined_Rainmill_no_Reward = 267,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Ranch</name>
	Ruined_Ranch = 268,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Ranch (no reward)</name>
	Ruined_Ranch_no_Reward = 269,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Scribe</name>
	Ruined_Scribe = 270,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Scribe (no reward)</name>
	Ruined_Scribe_no_Reward = 271,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Sewer</name>
	Ruined_Sewer = 272,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Sewer (no reward)</name>
	Ruined_Sewer_no_Reward = 273,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter</name>
	Ruined_Shelter = 274,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter (no reward)</name>
	Ruined_Shelter_no_Reward = 275,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined SmallFarm</name>
	Ruined_SmallFarm = 276,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined SmallFarm (no reward)</name>
	Ruined_SmallFarm_no_Reward = 277,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smelter</name>
	Ruined_Smelter = 278,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smelter (no reward)</name>
	Ruined_Smelter_no_Reward = 279,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smithy</name>
	Ruined_Smithy = 280,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smithy (no reward)</name>
	Ruined_Smithy_no_Reward = 281,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smokehouse</name>
	Ruined_Smokehouse = 282,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smokehouse (no reward)</name>
	Ruined_Smokehouse_no_Reward = 283,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stamping Mill</name>
	Ruined_Stamping_Mill = 284,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stamping Mill (no reward)</name>
	Ruined_Stamping_Mill_no_Reward = 285,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stonecutter Camp</name>
	Ruined_Stonecutter_Camp = 286,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stonecutter Camp (no reward)</name>
	Ruined_Stonecutter_Camp_no_Reward = 287,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Storage</name>
	Ruined_Storage = 288,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Storage (no reward)</name>
	Ruined_Storage_no_Reward = 289,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Supplier</name>
	Ruined_Supplier = 290,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Supplier (no reward)</name>
	Ruined_Supplier_no_Reward = 291,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tavern</name>
	Ruined_Tavern = 292,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tavern (no reward)</name>
	Ruined_Tavern_no_Reward = 293,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea Doctor</name>
	Ruined_Tea_Doctor = 294,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea Doctor (no reward)</name>
	Ruined_Tea_Doctor_no_Reward = 295,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea House</name>
	Ruined_Tea_House = 296,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea House (no reward)</name>
	Ruined_Tea_House_no_Reward = 297,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Temple</name>
	Ruined_Temple = 298,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Temple (no reward)</name>
	Ruined_Temple_no_Reward = 299,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinctury</name>
	Ruined_Tinctury = 300,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinctury (no reward)</name>
	Ruined_Tinctury_no_Reward = 301,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinkerer</name>
	Ruined_Tinkerer = 302,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinkerer (no reward)</name>
	Ruined_Tinkerer_no_Reward = 303,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Toolshop</name>
	Ruined_Toolshop = 304,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Toolshop (no reward)</name>
	Ruined_Toolshop_no_Reward = 305,

	/// <summary>
	/// Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trading Post (no reward)</name>
	Ruined_Trading_Post_no_Reward = 306,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Trappers Camp</name>
	Ruined_Trappers_Camp = 307,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp (no reward)</name>
	Ruined_Trappers_Camp_no_Reward = 308,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp Primitive (no reward)</name>
	Ruined_Trappers_Camp_Primitive_no_Reward = 309,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Weaver</name>
	Ruined_Weaver = 310,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Weaver (no reward)</name>
	Ruined_Weaver_no_Reward = 311,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Woodcutters Camp</name>
	Ruined_Woodcutters_Camp = 312,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Woodcutters Camp (no reward)</name>
	Ruined_Woodcutters_Camp_no_Reward = 313,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Workshop</name>
	Ruined_Workshop = 314,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Workshop (no reward)</name>
	Ruined_Workshop_no_Reward = 315,

	/// <summary>
	/// Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
	/// </summary>
	/// <name>Sacrifice Totem</name>
	Sacrifice_Totem = 316,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Scorpion 1</name>
	Scorpion_1 = 317,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Scorpion 2</name>
	Scorpion_2 = 318,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Scorpion 3</name>
	Scorpion_3 = 319,

	/// <summary>
	/// Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
	/// </summary>
	/// <name>SealedTomb_T1</name>
	SealedTomb_T1 = 320,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Snake 1</name>
	Snake_1 = 321,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Snake 2</name>
	Snake_2 = 322,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Snake 3</name>
	Snake_3 = 323,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Spider 1</name>
	Spider_1 = 324,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Spider 2</name>
	Spider_2 = 325,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Spider 3</name>
	Spider_3 = 326,

	/// <summary>
	/// Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
	/// </summary>
	/// <name>Termite Burrow</name>
	Termite_Burrow = 327,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>TI AncientShrine_T1</name>
	TI_AncientShrine_T1 = 328,

	/// <summary>
	/// Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
	/// </summary>
	/// <name>Traders Cemetery</name>
	Traders_Cemetery = 329,

	/// <summary>
	/// Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
	/// </summary>
	/// <name>War Beast Cage</name>
	War_Beast_Cage = 330,

	/// <summary>
	/// Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>White Stag</name>
	White_Stag = 331,

	/// <summary>
	/// Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>White Treasure Stag</name>
	White_Treasure_Stag = 332,

	/// <summary>
	/// Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.
	/// </summary>
	/// <name>Wildfire</name>
	Wildfire = 333,



    /// <summary>
    /// The total number of vanilla RelicTypes in the game.
    /// </summary>
	MAX = 333
}

/// <summary>
/// Extension methods for the RelicTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class RelicTypesExtensions
{
	/// <summary>
	/// Returns an array of all vanilla and modded RelicTypes.
	/// </summary>
	public static RelicTypes[] All()
	{
		RelicTypes[] all = new RelicTypes[TypeToInternalName.Count];
        TypeToInternalName.Keys.CopyTo(all, 0);
        return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every RelicTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return RelicTypes.AncientBurrialGrounds in the enum and log an error.
	/// </summary>
	public static string ToName(this RelicTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of RelicTypes: " + type);
		return TypeToInternalName[RelicTypes.AncientBurrialGrounds];
	}
	
	/// <summary>
	/// Returns a RelicTypes associated with the given name.
	/// Every RelicTypes should have a unique name as to distinguish it from others.
	/// If no RelicTypes is found, it will return RelicTypes.Unknown and log a warning.
	/// </summary>
	public static RelicTypes ToRelicTypes(this string name)
	{
		foreach (KeyValuePair<RelicTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find RelicTypes with name: " + name + "\n" + Environment.StackTrace);
		return RelicTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a RelicModel associated with the given name.
	/// RelicModel contain all the data that will be used in the game.
	/// Every RelicModel should have a unique name as to distinguish it from others.
	/// If no RelicModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.RelicModel ToRelicModel(this string name)
	{
		Eremite.Buildings.RelicModel model = SO.Settings.Relics.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find RelicModel for RelicTypes with name: " + name);
		return null;
	}

    /// <summary>
    /// Returns a RelicModel associated with the given RelicTypes.
    /// RelicModel contain all the data that will be used in the game.
    /// Every RelicModel should have a unique name as to distinguish it from others.
    /// If no RelicModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Buildings.RelicModel ToRelicModel(this RelicTypes types)
	{
		return types.ToName().ToRelicModel();
	}
	
	/// <summary>
	/// Returns an array of RelicModel associated with the given RelicTypes.
	/// RelicModel contain all the data that will be used in the game.
	/// Every RelicModel should have a unique name as to distinguish it from others.
	/// If a RelicModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RelicModel[] ToRelicModelArray(this IEnumerable<RelicTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RelicModel[] array = new Eremite.Buildings.RelicModel[count];
		int i = 0;
		foreach (RelicTypes element in collection)
		{
			array[i++] = element.ToRelicModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RelicModel associated with the given RelicTypes.
	/// RelicModel contain all the data that will be used in the game.
	/// Every RelicModel should have a unique name as to distinguish it from others.
	/// If a RelicModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.RelicModel[] ToRelicModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.RelicModel[] array = new Eremite.Buildings.RelicModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToRelicModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of RelicModel associated with the given RelicTypes.
	/// RelicModel contain all the data that will be used in the game.
	/// Every RelicModel should have a unique name as to distinguish it from others.
	/// If a RelicModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RelicModel[] ToRelicModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.RelicModel>.Get(out List<Eremite.Buildings.RelicModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.RelicModel model = element.ToRelicModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of RelicModel associated with the given RelicTypes.
	/// RelicModel contain all the data that will be used in the game.
	/// Every RelicModel should have a unique name as to distinguish it from others.
	/// If a RelicModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.RelicModel[] ToRelicModelArrayNoNulls(this IEnumerable<RelicTypes> collection)
	{
		using(ListPool<Eremite.Buildings.RelicModel>.Get(out List<Eremite.Buildings.RelicModel> list))
		{
			foreach (RelicTypes element in collection)
			{
				Eremite.Buildings.RelicModel model = element.ToRelicModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
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
		{ RelicTypes.Angry_Ghost_41, "Angry Ghost 41" },                                                         // Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
		{ RelicTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                           // Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
		{ RelicTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                           // Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
		{ RelicTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                           // Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
		{ RelicTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                 // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ RelicTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                           // Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
		{ RelicTypes.Black_Stag, "Black Stag" },                                                                 // Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
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
		{ RelicTypes.Calm_Ghost_38, "Calm Ghost 38" },                                                           // Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
		{ RelicTypes.Calm_Ghost_39, "Calm Ghost 39" },                                                           // Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
		{ RelicTypes.Calm_Ghost_40, "Calm Ghost 40" },                                                           // Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
		{ RelicTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                             // Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
		{ RelicTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                             // Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
		{ RelicTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                   // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ RelicTypes.Camp_T1, "Camp_T1" },                                                                       // Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ RelicTypes.Camp_T2, "Camp_T2" },                                                                       // Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ RelicTypes.Caravan_T1, "Caravan_T1" },                                                                 // Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ RelicTypes.Caravan_T2, "Caravan_T2" },                                                                 // Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ RelicTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                   // Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
		{ RelicTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                   // Clay Node (Large) - Soil infused with the essence of the rain.
		{ RelicTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                               // Clay Node (Small) - Soil infused with the essence of the rain.
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
		{ RelicTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                 // Root Node (Large) - A tangled net of living vines.
		{ RelicTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                             // Root Node (Small) - A tangled net of living vines.
		{ RelicTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                         // Sea Marrow Node (Large) - Ancient fossils, rich in resources.
		{ RelicTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                     // Sea Marrow Node (Small) - Ancient fossils, rich in resources.
		{ RelicTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                           // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ RelicTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                       // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ RelicTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                         // Snake Nest (Large) - A dangerous, but rich source of food and leather.
		{ RelicTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                     // Snake Nest (Small) - A dangerous, but rich source of food and leather.
		{ RelicTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                 // Stone Node (Large) - Stones, weathered by the everlasting rain.
		{ RelicTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                             // Stone Node (Small) - Stones, weathered by the everlasting rain.
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
		{ RelicTypes.FrogBattleground_T1, "FrogBattleground_T1" },                                               // Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
		{ RelicTypes.Fuming_Machinery, "Fuming Machinery" },                                                     // Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
		{ RelicTypes.Giant_Stormbird, "Giant Stormbird" },                                                       // Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
		{ RelicTypes.Glade_Trader_The_Hermit, "Glade Trader - The Hermit" },                                     // Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
		{ RelicTypes.Glade_Trader_The_Seer, "Glade Trader - The Seer" },                                         // Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
		{ RelicTypes.Glade_Trader_The_Shaman, "Glade Trader - The Shaman" },                                     // Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
		{ RelicTypes.Gold_Stag, "Gold Stag" },                                                                   // Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ RelicTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                 // Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ RelicTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                             // Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
		{ RelicTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                             // Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
		{ RelicTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                               // Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                         // Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                           // Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                     // Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                             // Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                     // Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Frog_House, "Haunted Ruined Frog House" },                                   // Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ RelicTypes.Haunted_Ruined_Guild_House, "Haunted Ruined Guild House" },                                 // Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
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
		{ RelicTypes.Rainpunk_Drill_Salt, "Rainpunk Drill - Salt" },                                             // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
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
		{ RelicTypes.Ruined_Cannery, "Ruined Cannery" },                                                         // Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cannery_no_Reward, "Ruined Cannery (no reward)" },                                   // Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                     // Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Carpenter_no_Reward, "Ruined Carpenter (no reward)" },                               // Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Cellar, "Ruined Cellar" },                                                           // Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cellar_no_Reward, "Ruined Cellar (no reward)" },                                     // Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                     // Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Clan_Hall_no_Reward, "Ruined Clan Hall (no reward)" },                               // Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                       // Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Clay_Pit_no_Reward, "Ruined Clay Pit (no reward)" },                                 // Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Cobbler, "Ruined Cobbler" },                                                         // Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Cobbler_no_Reward, "Ruined Cobbler (no reward)" },                                   // Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
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
		{ RelicTypes.Ruined_Fishing_Hut, "Ruined Fishing Hut" },                                                 // Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Fishing_Hut_no_Reward, "Ruined Fishing Hut (no reward)" },                           // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Fishing_Hut_Primitive_no_Reward, "Ruined Fishing Hut Primitive (no reward)" },       // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                             // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Foragers_Camp_no_Reward, "Ruined Foragers Camp (no reward)" },                       // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Foragers_Camp_Primitive_no_Reward, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Forum, "Ruined Forum" },                                                             // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Forum_no_Reward, "Ruined Forum (no reward)" },                                       // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Fox_House, "Ruined Fox House" },                                                     // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Fox_House_no_Reward, "Ruined Fox House (no reward)" },                               // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ RelicTypes.Ruined_Frog_House_no_Reward, "Ruined Frog House (no reward)" },                             // Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
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
		{ RelicTypes.Ruined_Pantry, "Ruined Pantry" },                                                           // Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ RelicTypes.Ruined_Pantry_no_Reward, "Ruined Pantry (no reward)" },                                     // Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
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
		{ RelicTypes.White_Stag, "White Stag" },                                                                 // Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ RelicTypes.White_Treasure_Stag, "White Treasure Stag" },                                               // Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ RelicTypes.Wildfire, "Wildfire" },                                                                     // Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.

	};
}
