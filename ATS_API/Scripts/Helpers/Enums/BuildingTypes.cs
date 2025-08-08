using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum BuildingTypes
{
	/// <summary>
	/// Placeholder for an unknown BuildingTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no BuildingTypes. Typically, seen if nothing is defined or failed to parse a string to a BuildingTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
	/// </summary>
	/// <name>Advanced Rain Catcher</name>
	Advanced_Rain_Catcher = 1,

	/// <summary>
	/// Garden - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Aestherics 2x2 - Garden</name>
	Aestherics_2x2_Garden = 2,

	/// <summary>
	/// Makeshift Extractor - Aesthetics. A curious piece of improvised technology. It extracts moisture from the soil around it and converts it into 10 "[water] clearance water" Clearance Water per minute. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Aestherics 2x2 - Groundwater Extractor</name>
	Aestherics_2x2_Groundwater_Extractor = 3,

	/// <summary>
	/// <p>Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Alchemist Hut</name>
	Alchemist_Hut = 4,

	/// <summary>
	/// Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
	/// </summary>
	/// <name>Altar</name>
	Altar = 5,

	/// <summary>
	/// Ancient Tombstone - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Ancient Gravestone</name>
	Ancient_Gravestone = 6,

	/// <summary>
	/// Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
	/// </summary>
	/// <name>AncientBurrialGrounds</name>
	AncientBurrialGrounds = 7,

	/// <summary>
	/// Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
	/// </summary>
	/// <name>AncientGate</name>
	AncientGate = 8,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>AncientShrine_T1</name>
	AncientShrine_T1 = 9,

	/// <summary>
	/// Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
	/// </summary>
	/// <name>AncientTemple</name>
	AncientTemple = 10,

	/// <summary>
	/// Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
	/// </summary>
	/// <name>Angry Ghost 1</name>
	Angry_Ghost_1 = 11,

	/// <summary>
	/// Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
	/// </summary>
	/// <name>Angry Ghost 10</name>
	Angry_Ghost_10 = 12,

	/// <summary>
	/// Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
	/// </summary>
	/// <name>Angry Ghost 14</name>
	Angry_Ghost_14 = 13,

	/// <summary>
	/// Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
	/// </summary>
	/// <name>Angry Ghost 15</name>
	Angry_Ghost_15 = 14,

	/// <summary>
	/// Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
	/// </summary>
	/// <name>Angry Ghost 16</name>
	Angry_Ghost_16 = 15,

	/// <summary>
	/// Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
	/// </summary>
	/// <name>Angry Ghost 17</name>
	Angry_Ghost_17 = 16,

	/// <summary>
	/// Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
	/// </summary>
	/// <name>Angry Ghost 18</name>
	Angry_Ghost_18 = 17,

	/// <summary>
	/// Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
	/// </summary>
	/// <name>Angry Ghost 19</name>
	Angry_Ghost_19 = 18,

	/// <summary>
	/// Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
	/// </summary>
	/// <name>Angry Ghost 2</name>
	Angry_Ghost_2 = 19,

	/// <summary>
	/// Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
	/// </summary>
	/// <name>Angry Ghost 20</name>
	Angry_Ghost_20 = 20,

	/// <summary>
	/// Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
	/// </summary>
	/// <name>Angry Ghost 21</name>
	Angry_Ghost_21 = 21,

	/// <summary>
	/// Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
	/// </summary>
	/// <name>Angry Ghost 24</name>
	Angry_Ghost_24 = 22,

	/// <summary>
	/// Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
	/// </summary>
	/// <name>Angry Ghost 31</name>
	Angry_Ghost_31 = 23,

	/// <summary>
	/// Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
	/// </summary>
	/// <name>Angry Ghost 32</name>
	Angry_Ghost_32 = 24,

	/// <summary>
	/// Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
	/// </summary>
	/// <name>Angry Ghost 34</name>
	Angry_Ghost_34 = 25,

	/// <summary>
	/// Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
	/// </summary>
	/// <name>Angry Ghost 4</name>
	Angry_Ghost_4 = 26,

	/// <summary>
	/// Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
	/// </summary>
	/// <name>Angry Ghost 41</name>
	Angry_Ghost_41 = 27,

	/// <summary>
	/// Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
	/// </summary>
	/// <name>Angry Ghost 5</name>
	Angry_Ghost_5 = 28,

	/// <summary>
	/// Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
	/// </summary>
	/// <name>Angry Ghost 6</name>
	Angry_Ghost_6 = 29,

	/// <summary>
	/// Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
	/// </summary>
	/// <name>Angry Ghost 9</name>
	Angry_Ghost_9 = 30,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>AngryGhostChest_T1</name>
	AngryGhostChest_T1 = 31,

	/// <summary>
	/// Anvil - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Anvil</name>
	Anvil = 32,

	/// <summary>
	/// <p>Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Apothecary</name>
	Apothecary = 33,

	/// <summary>
	/// Ancient Arch - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
	/// </summary>
	/// <name>Arch</name>
	Arch = 34,

	/// <summary>
	/// Smoldering Scorpion - Harmony. Legend has it that they once inhabited the top of the mountain on which the Smoldering City now stands. The Queen banished them, but it is said that some of them still hibernate somewhere on the outskirts of the kingdom.  Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Scorpion Positive</name>
	Archaeology_Scorpion_Positive = 35,

	/// <summary>
	/// Sea Serpent - Harmony. The anatomical features of this beast indicate an adaptation to life in water, as well as on land. Due to this, sea serpents are excellent hunters, preying on lonely caravans and lost settlers. The preserved remains show traces of Blightrot. Could it be that these creatures have brought this plague to the surface when emerging from the depths of the ocean? Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Snake Positive</name>
	Archaeology_Snake_Positive = 36,

	/// <summary>
	/// Sealed Spider - Harmony. It is said that these creatures were once the faithful servants of the Sealed Ones, and like their masters, they were trapped underground for eternity. But even to this day, miners tell tales of giant spiders crawling up from deep caverns, preying on unsuspecting victims. Legend has it that these vile beasts fear only one thing - the Holy Flame. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Spider Positive</name>
	Archaeology_Spider_Positive = 37,

	/// <summary>
	/// Archaeologist's Office - A building designed to help you study the past. Can be upgraded to locate archaeological discoveries or improve the settlement's exploration capabilities. 
	/// </summary>
	/// <name>Archeology office</name>
	Archeology_Office = 38,

	/// <summary>
	/// <p>Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Artisan</name>
	Artisan = 39,

	/// <summary>
	/// <p>Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Bakery</name>
	Bakery = 40,

	/// <summary>
	/// Bench - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Bank</name>
	Bank = 41,

	/// <summary>
	/// Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Barrels</name>
	Barrels = 42,

	/// <summary>
	/// Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
	/// </summary>
	/// <name>Bath House</name>
	Bath_House = 43,

	/// <summary>
	/// <p>Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Beanery</name>
	Beanery = 44,

	/// <summary>
	/// Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Beaver House</name>
	Beaver_House = 45,

	/// <summary>
	/// Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
	/// </summary>
	/// <name>BeaverBattleground_T1</name>
	BeaverBattleground_T1 = 46,

	/// <summary>
	/// Big Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 6 residents.
	/// </summary>
	/// <name>Big Shelter</name>
	Big_Shelter = 47,

	/// <summary>
	/// Cornerstone Forge - An ancient forge used by the Crown for generations to craft cornerstones from Thunderblight Shards. Now it stands abandoned, its fires long cold, but its legacy still felt in the region.
	/// </summary>
	/// <name>Biome Perk Crafter</name>
	Biome_Perk_Crafter = 48,

	/// <summary>
	/// Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Black Stag</name>
	Black_Stag = 49,

	/// <summary>
	/// Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Black Treasure Stag</name>
	Black_Treasure_Stag = 50,

	/// <summary>
	/// Blight Post - A specialized building dedicated to fighting Blightrot. Blight Fighters will prepare "blight fuel" Purging Fire during drizzle and clearance seasons, and use it to burn Blightrot Cysts during the storm.
	/// </summary>
	/// <name>Blight Post</name>
	Blight_Post = 51,

	/// <summary>
	/// Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
	/// </summary>
	/// <name>Blightrot</name>
	Blightrot = 52,

	/// <summary>
	/// Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
	/// </summary>
	/// <name>Blightrot Cauldron</name>
	Blightrot_Cauldron = 53,

	/// <summary>
	/// Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
	/// </summary>
	/// <name>Blightrot - Clone</name>
	Blightrot_Clone = 54,

	/// <summary>
	/// Bonfire - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Bonfire</name>
	Bonfire = 55,

	/// <summary>
	/// <p>Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Brewery</name>
	Brewery = 56,

	/// <summary>
	/// <p>Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Brick Oven</name>
	Brick_Oven = 57,

	/// <summary>
	/// <p>Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Brickyard</name>
	Brickyard = 58,

	/// <summary>
	/// Bush - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Bush</name>
	Bush = 59,

	/// <summary>
	/// <p>Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Butcher</name>
	Butcher = 60,

	/// <summary>
	/// Cages - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Cages</name>
	Cages = 61,

	/// <summary>
	/// Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
	/// </summary>
	/// <name>Calm Ghost 11</name>
	Calm_Ghost_11 = 62,

	/// <summary>
	/// Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
	/// </summary>
	/// <name>Calm Ghost 12</name>
	Calm_Ghost_12 = 63,

	/// <summary>
	/// Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
	/// </summary>
	/// <name>Calm Ghost 13</name>
	Calm_Ghost_13 = 64,

	/// <summary>
	/// Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
	/// </summary>
	/// <name>Calm Ghost 22</name>
	Calm_Ghost_22 = 65,

	/// <summary>
	/// Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
	/// </summary>
	/// <name>Calm Ghost 23</name>
	Calm_Ghost_23 = 66,

	/// <summary>
	/// Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
	/// </summary>
	/// <name>Calm Ghost 25</name>
	Calm_Ghost_25 = 67,

	/// <summary>
	/// Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
	/// </summary>
	/// <name>Calm Ghost 26</name>
	Calm_Ghost_26 = 68,

	/// <summary>
	/// Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
	/// </summary>
	/// <name>Calm Ghost 27</name>
	Calm_Ghost_27 = 69,

	/// <summary>
	/// Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
	/// </summary>
	/// <name>Calm Ghost 28</name>
	Calm_Ghost_28 = 70,

	/// <summary>
	/// Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
	/// </summary>
	/// <name>Calm Ghost 29</name>
	Calm_Ghost_29 = 71,

	/// <summary>
	/// Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
	/// </summary>
	/// <name>Calm Ghost 3</name>
	Calm_Ghost_3 = 72,

	/// <summary>
	/// Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
	/// </summary>
	/// <name>Calm Ghost 30</name>
	Calm_Ghost_30 = 73,

	/// <summary>
	/// Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
	/// </summary>
	/// <name>Calm Ghost 33</name>
	Calm_Ghost_33 = 74,

	/// <summary>
	/// Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
	/// </summary>
	/// <name>Calm Ghost 35</name>
	Calm_Ghost_35 = 75,

	/// <summary>
	/// Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
	/// </summary>
	/// <name>Calm Ghost 36</name>
	Calm_Ghost_36 = 76,

	/// <summary>
	/// Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
	/// </summary>
	/// <name>Calm Ghost 38</name>
	Calm_Ghost_38 = 77,

	/// <summary>
	/// Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
	/// </summary>
	/// <name>Calm Ghost 39</name>
	Calm_Ghost_39 = 78,

	/// <summary>
	/// Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
	/// </summary>
	/// <name>Calm Ghost 40</name>
	Calm_Ghost_40 = 79,

	/// <summary>
	/// Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
	/// </summary>
	/// <name>Calm Ghost 7</name>
	Calm_Ghost_7 = 80,

	/// <summary>
	/// Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
	/// </summary>
	/// <name>Calm Ghost 8</name>
	Calm_Ghost_8 = 81,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>CalmGhostChest_T1</name>
	CalmGhostChest_T1 = 82,

	/// <summary>
	/// Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T1</name>
	Camp_T1 = 83,

	/// <summary>
	/// Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T2</name>
	Camp_T2 = 84,

	/// <summary>
	/// <p>Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cannery</name>
	Cannery = 85,

	/// <summary>
	/// Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T1</name>
	Caravan_T1 = 86,

	/// <summary>
	/// Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T2</name>
	Caravan_T2 = 87,

	/// <summary>
	/// <p>Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Carpenter</name>
	Carpenter = 88,

	/// <summary>
	/// <p>Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cellar</name>
	Cellar = 89,

	/// <summary>
	/// Chest - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Chest</name>
	Chest = 90,

	/// <summary>
	/// Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
	/// </summary>
	/// <name>Clan Hall</name>
	Clan_Hall = 91,

	/// <summary>
	/// <p>Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2)</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Clay Pit Workshop</name>
	Clay_Pit_Workshop = 92,

	/// <summary>
	/// <p>Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Clothier</name>
	Clothier = 93,

	/// <summary>
	/// Saltwater Pitcher Plant - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Coastal Grove Plant</name>
	Coastal_Grove_Plant = 94,

	/// <summary>
	/// <p>Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Cobbler</name>
	Cobbler = 95,

	/// <summary>
	/// Park - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Comfort 2x2 - Park</name>
	Comfort_2x2_Park = 96,

	/// <summary>
	/// <p>Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Cookhouse</name>
	Cookhouse = 97,

	/// <summary>
	/// <p>Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Cooperage</name>
	Cooperage = 98,

	/// <summary>
	/// Coral Growth - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Coral Decor</name>
	Coral_Decor = 99,

	/// <summary>
	/// Fence Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>CornerFence</name>
	CornerFence = 100,

	/// <summary>
	/// Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
	/// </summary>
	/// <name>Corrupted Caravan</name>
	Corrupted_Caravan = 101,

	/// <summary>
	/// Crates - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Crates</name>
	Crates = 102,

	/// <summary>
	/// <p>Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Crude Workstation</name>
	Crude_Workstation = 103,

	/// <summary>
	/// Clay Node (Large) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClayBig</name>
	DebugNode_ClayBig = 104,

	/// <summary>
	/// Clay Node (Small) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClaySmall</name>
	DebugNode_ClaySmall = 105,

	/// <summary>
	/// Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushBig</name>
	DebugNode_DewberryBushBig = 106,

	/// <summary>
	/// Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushSmall</name>
	DebugNode_DewberryBushSmall = 107,

	/// <summary>
	/// Flax Field (Large) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxBig</name>
	DebugNode_FlaxBig = 108,

	/// <summary>
	/// Flax Field (Small) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxSmall</name>
	DebugNode_FlaxSmall = 109,

	/// <summary>
	/// Herb Node (Large) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsBig</name>
	DebugNode_HerbsBig = 110,

	/// <summary>
	/// Herb Node (Small) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsSmall</name>
	DebugNode_HerbsSmall = 111,

	/// <summary>
	/// Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherBig</name>
	DebugNode_LeechBroodmotherBig = 112,

	/// <summary>
	/// Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherSmall</name>
	DebugNode_LeechBroodmotherSmall = 113,

	/// <summary>
	/// Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteGrain</name>
	DebugNode_Marshlands_InfiniteGrain = 114,

	/// <summary>
	/// Dead Leviathan - A giant, dead beast. How did it get here?
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMeat</name>
	DebugNode_Marshlands_InfiniteMeat = 115,

	/// <summary>
	/// Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMushroom</name>
	DebugNode_Marshlands_InfiniteMushroom = 116,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomBig</name>
	DebugNode_MarshlandsMushroomBig = 117,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomSmall</name>
	DebugNode_MarshlandsMushroomSmall = 118,

	/// <summary>
	/// Moss Broccoli Patch (Large) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliBig</name>
	DebugNode_MossBroccoliBig = 119,

	/// <summary>
	/// Moss Broccoli Patch (Small) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliSmall</name>
	DebugNode_MossBroccoliSmall = 120,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomBig</name>
	DebugNode_MushroomBig = 121,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomSmall</name>
	DebugNode_MushroomSmall = 122,

	/// <summary>
	/// Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedBig</name>
	DebugNode_ReedBig = 123,

	/// <summary>
	/// Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedSmall</name>
	DebugNode_ReedSmall = 124,

	/// <summary>
	/// Root Node (Large) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsBig</name>
	DebugNode_RootsBig = 125,

	/// <summary>
	/// Root Node (Small) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsSmall</name>
	DebugNode_RootsSmall = 126,

	/// <summary>
	/// Sea Marrow Node (Large) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowBig</name>
	DebugNode_SeaMarrowBig = 127,

	/// <summary>
	/// Sea Marrow Node (Small) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowSmall</name>
	DebugNode_SeaMarrowSmall = 128,

	/// <summary>
	/// Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherBig</name>
	DebugNode_SnailBroodmotherBig = 129,

	/// <summary>
	/// Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherSmall</name>
	DebugNode_SnailBroodmotherSmall = 130,

	/// <summary>
	/// Snake Nest (Large) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestBig</name>
	DebugNode_SnakeNestBig = 131,

	/// <summary>
	/// Snake Nest (Small) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestSmall</name>
	DebugNode_SnakeNestSmall = 132,

	/// <summary>
	/// Stone Node (Large) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneBig</name>
	DebugNode_StoneBig = 133,

	/// <summary>
	/// Stone Node (Small) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneSmall</name>
	DebugNode_StoneSmall = 134,

	/// <summary>
	/// Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestBig</name>
	DebugNode_StormbirdNestBig = 135,

	/// <summary>
	/// Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestSmall</name>
	DebugNode_StormbirdNestSmall = 136,

	/// <summary>
	/// Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatBig</name>
	DebugNode_SwampWheatBig = 137,

	/// <summary>
	/// Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatSmall</name>
	DebugNode_SwampWheatSmall = 138,

	/// <summary>
	/// Wormtongue Nest (Large) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestBig</name>
	DebugNode_WormtongueNestBig = 139,

	/// <summary>
	/// Wormtongue Nest (Small) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestSmall</name>
	DebugNode_WormtongueNestSmall = 140,

	/// <summary>
	/// Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
	/// </summary>
	/// <name>Decay Altar</name>
	Decay_Altar = 141,

	/// <summary>
	/// Converted Altar of Decay - Harmony. Bloody sacrifices delight the evil presence. Forbidden rituals at the Altar of Decay reduce Hostility by 20 points every time a villager dies or leaves. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Decay Altar Positive</name>
	Decay_Altar_Positive = 142,

	/// <summary>
	/// <p>Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Distillery</name>
	Distillery = 143,

	/// <summary>
	/// <p>Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Druid</name>
	Druid = 144,

	/// <summary>
	/// Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
	/// </summary>
	/// <name>Escaped Convicts</name>
	Escaped_Convicts = 145,

	/// <summary>
	/// Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
	/// </summary>
	/// <name>Explorers Lodge</name>
	Explorers_Lodge = 146,

	/// <summary>
	/// Farm Field - Can only be placed on fertile soil. Requires a Small Farm, Plantation, Herb Garden, Forester's Hut, or Homestead nearby to produce crops.
	/// </summary>
	/// <name>Farmfield</name>
	Farmfield = 147,

	/// <summary>
	/// Feast Hall - A place where villagers can fulfill their need for: Treatment,  Brawling. Passive effects: Festive Mood.
	/// </summary>
	/// <name>Feast Hall</name>
	Feast_Hall = 531,

	/// <summary>
	/// Feast Hall - The mourners gather in the Feast Hall as the Funerary Feast begins. Following tradition, the guests first partake in a meal, sharing stories and memories of their departed friend.
	/// </summary>
	/// <name>Feast Hall - Funeral Event 1</name>
	Feast_Hall_Funeral_Event_1 = 532,

	/// <summary>
	/// Feast Hall - After the meal, the funeral guests partake in a customary memorial rite, guiding the soul of the departed toward its journey to a new vessel.
	/// </summary>
	/// <name>Feast Hall - Funeral Event 2</name>
	Feast_Hall_Funeral_Event_2 = 533,

	/// <summary>
	/// Feast Hall - According to tradition, after the funeral feast, the family of the departed presents small gifts to the guests - tokens to help them remember the friend they have lost.
	/// </summary>
	/// <name>Feast Hall - Funeral Event 3</name>
	Feast_Hall_Funeral_Event_3 = 534,

	/// <summary>
	/// Fence - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fence</name>
	Fence = 148,

	/// <summary>
	/// <p>Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Field Kitchen</name>
	Field_Kitchen = 149,

	/// <summary>
	/// <p>Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Finesmith</name>
	Finesmith = 150,

	/// <summary>
	/// Fire Shrine - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fire Shrine</name>
	Fire_Shrine = 151,

	/// <summary>
	/// Fish Mount - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fish</name>
	Fish = 152,

	/// <summary>
	/// Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
	/// </summary>
	/// <name>Fishing Hut</name>
	Fishing_Hut = 153,

	/// <summary>
	/// Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
	/// </summary>
	/// <name>Fishmen Cave</name>
	Fishmen_Cave = 154,

	/// <summary>
	/// Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
	/// </summary>
	/// <name>Fishmen Lighthouse</name>
	Fishmen_Lighthouse = 155,

	/// <summary>
	/// Converted Fishmen Lighthouse - Harmony. A tall bone structure built by the Fishmen. It has been repurposed and now provides 5 "[crafting] sea marrow" Sea Marrow per minute. Counts as 16 decorations of its type.
	/// </summary>
	/// <name>Fishmen Lighthouse Positive</name>
	Fishmen_Lighthouse_Positive = 156,

	/// <summary>
	/// Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
	/// </summary>
	/// <name>Fishmen Outpost</name>
	Fishmen_Outpost = 157,

	/// <summary>
	/// Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
	/// </summary>
	/// <name>Fishmen Soothsayer</name>
	Fishmen_Soothsayer = 158,

	/// <summary>
	/// Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
	/// </summary>
	/// <name>Fishmen Totem</name>
	Fishmen_Totem = 159,

	/// <summary>
	/// Flame Altar - A strange, ancient altar, supposedly dedicated to the Holy Flame. Grants access to temporary support abilities.
	/// </summary>
	/// <name>Flame Altar</name>
	Flame_Altar = 535,

	/// <summary>
	/// <p>Flawless Brewery - An upgraded production building with all recipes at the highest grade. Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Flawless Brewery</name>
	Flawless_Brewery = 160,

	/// <summary>
	/// <p>Flawless Cellar - An upgraded production building with all recipes at the highest grade. Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Flawless Cellar</name>
	Flawless_Cellar = 161,

	/// <summary>
	/// <p>Flawless Cooperage - An upgraded production building with all recipes at the highest grade. Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Cooperage</name>
	Flawless_Cooperage = 162,

	/// <summary>
	/// <p>Flawless Druid's Hut - An upgraded production building with all recipes at the highest grade. Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Druid</name>
	Flawless_Druid = 163,

	/// <summary>
	/// <p>Flawless Leatherworker - An upgraded production building with all recipes at the highest grade. Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Leatherworks</name>
	Flawless_Leatherworks = 164,

	/// <summary>
	/// <p>Flawless Rain Mill - An upgraded production building with all recipes at the highest grade. Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Flawless Rain Mill</name>
	Flawless_Rain_Mill = 165,

	/// <summary>
	/// <p>Flawless Smelter - An upgraded production building with all recipes at the highest grade. Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Flawless Smelter</name>
	Flawless_Smelter = 166,

	/// <summary>
	/// Flower Bed - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Flower Bed</name>
	Flower_Bed = 167,

	/// <summary>
	/// Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
	/// </summary>
	/// <name>Forager's Camp</name>
	Foragers_Camp = 168,

	/// <summary>
	/// Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
	/// </summary>
	/// <name>ForsakenCrypt</name>
	ForsakenCrypt = 169,

	/// <summary>
	/// Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
	/// </summary>
	/// <name>Forum</name>
	Forum = 170,

	/// <summary>
	/// Marble Fountain - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Fountain</name>
	Fountain = 171,

	/// <summary>
	/// Overgrown Fence - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fox Fence</name>
	Fox_Fence = 172,

	/// <summary>
	/// Overgrown Fence Corner - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fox Fence Corner</name>
	Fox_Fence_Corner = 173,

	/// <summary>
	/// Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Fox House</name>
	Fox_House = 174,

	/// <summary>
	/// Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
	/// </summary>
	/// <name>FoxBattleground_T1</name>
	FoxBattleground_T1 = 175,

	/// <summary>
	/// Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Frog House</name>
	Frog_House = 176,

	/// <summary>
	/// Evergreen Shrub - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Frog Tree</name>
	Frog_Tree = 177,

	/// <summary>
	/// Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
	/// </summary>
	/// <name>FrogBattleground_T1</name>
	FrogBattleground_T1 = 178,

	/// <summary>
	/// Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
	/// </summary>
	/// <name>Fuming Machinery</name>
	Fuming_Machinery = 179,

	/// <summary>
	/// <p>Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Furnace</name>
	Furnace = 180,

	/// <summary>
	/// Gate - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
	/// </summary>
	/// <name>Gate</name>
	Gate = 181,

	/// <summary>
	/// Spectral Stag - A truly rare sight - a Spectral Treasure Stag, lured to this place by the lingering anguish of mortal souls. Those who manage to find it will be rewarded with a special treasure.
	/// </summary>
	/// <name>Ghost Treasure Stag</name>
	Ghost_Treasure_Stag = 536,

	/// <summary>
	/// Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
	/// </summary>
	/// <name>Giant Stormbird</name>
	Giant_Stormbird = 182,

	/// <summary>
	/// Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
	/// </summary>
	/// <name>Glade Trader - The Hermit</name>
	Glade_Trader_The_Hermit = 183,

	/// <summary>
	/// Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
	/// </summary>
	/// <name>Glade Trader - The Seer</name>
	Glade_Trader_The_Seer = 184,

	/// <summary>
	/// Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
	/// </summary>
	/// <name>Glade Trader - The Shaman</name>
	Glade_Trader_The_Shaman = 185,

	/// <summary>
	/// Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Gold Stag</name>
	Gold_Stag = 186,

	/// <summary>
	/// Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Gold Treasure Stag</name>
	Gold_Treasure_Stag = 187,

	/// <summary>
	/// Golden Leaf Plant - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Golden Leaf</name>
	Golden_Leaf = 188,

	/// <summary>
	/// <p>Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Granary</name>
	Granary = 189,

	/// <summary>
	/// Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
	/// </summary>
	/// <name>Greenhouse Workshop</name>
	Greenhouse_Workshop = 190,

	/// <summary>
	/// <p>Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Grill</name>
	Grill = 191,

	/// <summary>
	/// Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
	/// </summary>
	/// <name>Grove</name>
	Grove = 192,

	/// <summary>
	/// Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
	/// </summary>
	/// <name>Guild House</name>
	Guild_House = 193,

	/// <summary>
	/// Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed Herb Garden</name>
	Hallowed_Herb_Garden = 194,

	/// <summary>
	/// Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed SmallFarm</name>
	Hallowed_SmallFarm = 195,

	/// <summary>
	/// Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
	/// </summary>
	/// <name>Harmony Spirit Altar</name>
	Harmony_Spirit_Altar = 196,

	/// <summary>
	/// Converted Harmony Spirit Altar - Harmony. When your villagers' needs are met, Harmony is fostered. Each unique service building adds 2 to Global Resolve. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Harmony Spirit Altar Positive</name>
	Harmony_Spirit_Altar_Positive = 197,

	/// <summary>
	/// Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Harpy House</name>
	Harpy_House = 198,

	/// <summary>
	/// Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
	/// </summary>
	/// <name>HarpyBattleground_T1</name>
	HarpyBattleground_T1 = 199,

	/// <summary>
	/// Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
	/// </summary>
	/// <name>Harvester Camp</name>
	Harvester_Camp = 200,

	/// <summary>
	/// Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Beaver House</name>
	Haunted_Ruined_Beaver_House = 201,

	/// <summary>
	/// Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Brewery</name>
	Haunted_Ruined_Brewery = 202,

	/// <summary>
	/// Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cellar</name>
	Haunted_Ruined_Cellar = 203,

	/// <summary>
	/// Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cooperage</name>
	Haunted_Ruined_Cooperage = 204,

	/// <summary>
	/// Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Druid</name>
	Haunted_Ruined_Druid = 205,

	/// <summary>
	/// Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Fox House</name>
	Haunted_Ruined_Fox_House = 206,

	/// <summary>
	/// Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Frog House</name>
	Haunted_Ruined_Frog_House = 207,

	/// <summary>
	/// Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Guild House</name>
	Haunted_Ruined_Guild_House = 208,

	/// <summary>
	/// Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Harpy House</name>
	Haunted_Ruined_Harpy_House = 209,

	/// <summary>
	/// Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Herb Garden</name>
	Haunted_Ruined_Herb_Garden = 210,

	/// <summary>
	/// Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Human House</name>
	Haunted_Ruined_Human_House = 211,

	/// <summary>
	/// Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Leatherworks</name>
	Haunted_Ruined_Leatherworks = 212,

	/// <summary>
	/// Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Lizard House</name>
	Haunted_Ruined_Lizard_House = 213,

	/// <summary>
	/// Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Market</name>
	Haunted_Ruined_Market = 214,

	/// <summary>
	/// Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Rainmill</name>
	Haunted_Ruined_Rainmill = 215,

	/// <summary>
	/// Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined SmallFarm</name>
	Haunted_Ruined_SmallFarm = 216,

	/// <summary>
	/// Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Smelter</name>
	Haunted_Ruined_Smelter = 217,

	/// <summary>
	/// Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Temple</name>
	Haunted_Ruined_Temple = 218,

	/// <summary>
	/// Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
	/// </summary>
	/// <name>Herb Garden</name>
	Herb_Garden = 219,

	/// <summary>
	/// Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Herbalist's Camp</name>
	Herbalists_Camp = 220,

	/// <summary>
	/// Holy Guild House - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Luxury,  Education. Passive effects: Guild House, The Guild's Welfare.
	/// </summary>
	/// <name>Holy Guild House</name>
	Holy_Guild_House = 221,

	/// <summary>
	/// Holy Market - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Leisure,  Treatment. Passive effects: Ale and Hearty, Market Carts.
	/// </summary>
	/// <name>Holy Market</name>
	Holy_Market = 222,

	/// <summary>
	/// Holy Temple - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Religion,  Education. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
	/// </summary>
	/// <name>Holy Temple</name>
	Holy_Temple = 223,

	/// <summary>
	/// Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Homestead</name>
	Homestead = 224,

	/// <summary>
	/// Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Human House</name>
	Human_House = 225,

	/// <summary>
	/// Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
	/// </summary>
	/// <name>HumanBattleground_T1</name>
	HumanBattleground_T1 = 226,

	/// <summary>
	/// Hydrant - A small storage for "blight fuel" Purging Fire. Blight Fighters will use it to restock their fuel when fighting Blightrot in the storm.
	/// </summary>
	/// <name>Hydrant</name>
	Hydrant = 227,

	/// <summary>
	/// Industrial Chimney - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Industrial Chimney</name>
	Industrial_Chimney = 228,

	/// <summary>
	/// Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
	/// </summary>
	/// <name>Infected Mole</name>
	Infected_Mole = 229,

	/// <summary>
	/// Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
	/// </summary>
	/// <name>Infected Tree</name>
	Infected_Tree = 230,

	/// <summary>
	/// River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
	/// </summary>
	/// <name>Kelpie</name>
	Kelpie = 231,

	/// <summary>
	/// <p>Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Kiln</name>
	Kiln = 232,

	/// <summary>
	/// Lamp - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Lamp</name>
	Lamp = 233,

	/// <summary>
	/// Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
	/// </summary>
	/// <name>Leaking Cauldron</name>
	Leaking_Cauldron = 234,

	/// <summary>
	/// <p>Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Leatherworks</name>
	Leatherworks = 235,

	/// <summary>
	/// Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
	/// </summary>
	/// <name>Lightning Catcher</name>
	Lightning_Catcher = 236,

	/// <summary>
	/// Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Lizard House</name>
	Lizard_House = 237,

	/// <summary>
	/// Lizard Post - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Lizard Post</name>
	Lizard_Post = 238,

	/// <summary>
	/// Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
	/// </summary>
	/// <name>LizardBattleground_T1</name>
	LizardBattleground_T1 = 239,

	/// <summary>
	/// Inscribed Monolith - Harmony. Born in the Blightstorm, she will climb the Red Mountain. The fires beneath her feet shall hiss her name. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 1</name>
	Lore_Tablet_1 = 240,

	/// <summary>
	/// Inscribed Monolith - Harmony. Though sealed beneath the muddy ground, their voices ring loud and clear. Maddening, alluring. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 2</name>
	Lore_Tablet_2 = 241,

	/// <summary>
	/// Inscribed Monolith - Harmony. The true rulers of this world shall rise again and break the seals that bind them. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 3</name>
	Lore_Tablet_3 = 242,

	/// <summary>
	/// Inscribed Monolith - Harmony. Envy the lesser species, for they do not yet know what lies beneath. But in time, they will understand. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 4</name>
	Lore_Tablet_4 = 243,

	/// <summary>
	/// Inscribed Monolith - Harmony. It pours, yet it does not flood. As if the earth itself greedily drinks every last drop of this eternal curse. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 5</name>
	Lore_Tablet_5 = 244,

	/// <summary>
	/// Inscribed Monolith - Harmony. Embrace the Eternal Rain, for it powers the engine of progress. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 6</name>
	Lore_Tablet_6 = 245,

	/// <summary>
	/// Inscribed Monolith - Harmony. Don't let the pleasant sparking of the raindrops fool you. This is just the first sign of your flesh rotting. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 7</name>
	Lore_Tablet_7 = 246,

	/// <summary>
	/// <p>Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Lumbermill</name>
	Lumbermill = 247,

	/// <summary>
	/// Main Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
	/// </summary>
	/// <name>Main Storage (not-buildable)</name>
	Main_Storage_not_buildable = 248,

	/// <summary>
	/// <p>Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Makeshift Post</name>
	Makeshift_Post = 249,

	/// <summary>
	/// <p>Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Manufactory</name>
	Manufactory = 250,

	/// <summary>
	/// Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
	/// </summary>
	/// <name>Market</name>
	Market = 251,

	/// <summary>
	/// Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
	/// </summary>
	/// <name>Merchant Ship Wreck</name>
	Merchant_Ship_Wreck = 252,

	/// <summary>
	/// Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).
	/// </summary>
	/// <name>Mine</name>
	Mine = 253,

	/// <summary>
	/// Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
	/// </summary>
	/// <name>Mistworm_T1</name>
	Mistworm_T1 = 254,

	/// <summary>
	/// Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
	/// </summary>
	/// <name>Mole</name>
	Mole = 255,

	/// <summary>
	/// Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
	/// </summary>
	/// <name>Monastery</name>
	Monastery = 256,

	/// <summary>
	/// Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
	/// </summary>
	/// <name>Monolith</name>
	Monolith = 257,

	/// <summary>
	/// Obelisk - Aesthetics. The symbols carved into this monumental stone bear an eerie resemblance to the forest and corruption. Decreases Hostility by 10 points and increases the Ancient Hearth's resistance by 100.
	/// </summary>
	/// <name>Monolith Positive</name>
	Monolith_Positive = 258,

	/// <summary>
	/// Monument of Greed - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Moument of Greed</name>
	Moument_Of_Greed = 259,

	/// <summary>
	/// Decorative Fungus - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Mushroom Decor</name>
	Mushroom_Decor = 260,

	/// <summary>
	/// Nightfern - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Nightfern</name>
	Nightfern = 261,

	/// <summary>
	/// Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
	/// </summary>
	/// <name>Noxious Machinery</name>
	Noxious_Machinery = 262,

	/// <summary>
	/// Ornate Column - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Ornate Column</name>
	Ornate_Column = 263,

	/// <summary>
	/// <p>Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Pantry</name>
	Pantry = 264,

	/// <summary>
	/// Path - A simple path, doesn't cost any resources. Grants a 5% speed increase to villagers.
	/// </summary>
	/// <name>Path</name>
	Path = 265,

	/// <summary>
	/// Paved Road - A road made out of stone. Grants a 15% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
	/// </summary>
	/// <name>Paved Road</name>
	Paved_Road = 266,

	/// <summary>
	/// Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
	/// </summary>
	/// <name>PetrifiedTree_T1</name>
	PetrifiedTree_T1 = 267,

	/// <summary>
	/// Pipe - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe</name>
	Pipe = 268,

	/// <summary>
	/// Pipe Cross - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Cross</name>
	Pipe_Cross = 269,

	/// <summary>
	/// Pipe Elbow - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Elbow</name>
	Pipe_Elbow = 270,

	/// <summary>
	/// Pipe Ending - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe End</name>
	Pipe_End = 271,

	/// <summary>
	/// Pipe T-Connector - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe T Cross</name>
	Pipe_T_Cross = 272,

	/// <summary>
	/// Valve - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Valve</name>
	Pipe_Valve = 273,

	/// <summary>
	/// Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
	/// </summary>
	/// <name>Plantation</name>
	Plantation = 274,

	/// <summary>
	/// Strider Port - From this port, expeditions can be launched to search the nearby swamps for blueprints and treasure in the submerged ruins of former settlements.
	/// </summary>
	/// <name>Port</name>
	Port = 275,

	/// <summary>
	/// <p>Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Press</name>
	Press = 276,

	/// <summary>
	/// Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).
	/// </summary>
	/// <name>Primitive Fishing Hut</name>
	Primitive_Fishing_Hut = 277,

	/// <summary>
	/// Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
	/// </summary>
	/// <name>Primitive Forager's Camp</name>
	Primitive_Foragers_Camp = 278,

	/// <summary>
	/// Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
	/// </summary>
	/// <name>Primitive Herbalist's Camp</name>
	Primitive_Herbalists_Camp = 279,

	/// <summary>
	/// Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
	/// </summary>
	/// <name>Primitive Trapper's Camp</name>
	Primitive_Trappers_Camp = 280,

	/// <summary>
	/// <p>Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Provisioner</name>
	Provisioner = 281,

	/// <summary>
	/// Purified Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Beaver House</name>
	Purged_Beaver_House = 282,

	/// <summary>
	/// Purified Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Fox House</name>
	Purged_Fox_House = 283,

	/// <summary>
	/// Purified Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Frog House</name>
	Purged_Frog_House = 284,

	/// <summary>
	/// Purified Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Harpy House</name>
	Purged_Harpy_House = 285,

	/// <summary>
	/// Purified Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Human House</name>
	Purged_Human_House = 286,

	/// <summary>
	/// Purified Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Lizard House</name>
	Purged_Lizard_House = 287,

	/// <summary>
	/// Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.
	/// </summary>
	/// <name>Rain Catcher</name>
	Rain_Catcher = 288,

	/// <summary>
	/// <p>Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Rain Mill</name>
	Rain_Mill = 289,

	/// <summary>
	/// Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
	/// </summary>
	/// <name>Rain Totem</name>
	Rain_Totem = 290,

	/// <summary>
	/// Converted Rain Totem - Harmony. The ritual was completed, but a faint, rhythmic thumping can still be heard coming from the totem. Decreases Hostility by 50. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Rain Totem Positive</name>
	Rain_Totem_Positive = 291,

	/// <summary>
	/// Rainpunk Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Rainpunk Barrels</name>
	Rainpunk_Barrels = 292,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Coal</name>
	Rainpunk_Drill_Coal = 293,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Copper</name>
	Rainpunk_Drill_Copper = 294,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Salt</name>
	Rainpunk_Drill_Salt = 295,

	/// <summary>
	/// <p>Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Rainpunk Foundry</name>
	Rainpunk_Foundry = 296,

	/// <summary>
	/// Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
	/// </summary>
	/// <name>RainpunkFactory</name>
	RainpunkFactory = 297,

	/// <summary>
	/// <p>Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Ranch</name>
	Ranch = 298,

	/// <summary>
	/// Reinforced Road - A road reinforced with copper. Grants a 25% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
	/// </summary>
	/// <name>Reinforced Road</name>
	Reinforced_Road = 299,

	/// <summary>
	/// Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T1</name>
	RewardChest_T1 = 300,

	/// <summary>
	/// Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T2</name>
	RewardChest_T2 = 301,

	/// <summary>
	/// Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T3</name>
	RewardChest_T3 = 302,

	/// <summary>
	/// Road Sign - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Road Sign</name>
	Road_Sign = 303,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher</name>
	Ruined_Advanced_Rain_Catcher = 304,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher (no reward)</name>
	Ruined_Advanced_Rain_Catcher_no_Reward = 305,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Alchemist</name>
	Ruined_Alchemist = 306,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Alchemist (no reward)</name>
	Ruined_Alchemist_no_Reward = 307,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Apothecary</name>
	Ruined_Apothecary = 308,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Apothecary (no reward)</name>
	Ruined_Apothecary_no_Reward = 309,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Artisan</name>
	Ruined_Artisan = 310,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Artisan (no reward)</name>
	Ruined_Artisan_no_Reward = 311,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bakery</name>
	Ruined_Bakery = 312,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bakery (no reward)</name>
	Ruined_Bakery_no_Reward = 313,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bath House</name>
	Ruined_Bath_House = 314,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bath House (no reward)</name>
	Ruined_Bath_House_no_Reward = 315,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Beanery</name>
	Ruined_Beanery = 316,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beanery (no reward)</name>
	Ruined_Beanery_no_Reward = 317,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House</name>
	Ruined_Beaver_House = 318,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House (no reward)</name>
	Ruined_Beaver_House_no_Reward = 319,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter</name>
	Ruined_Big_Shelter = 320,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter (no reward)</name>
	Ruined_Big_Shelter_no_Reward = 321,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brewery</name>
	Ruined_Brewery = 322,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brewery (no reward)</name>
	Ruined_Brewery_no_Reward = 323,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brick Oven</name>
	Ruined_Brick_Oven = 324,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brick Oven (no reward)</name>
	Ruined_Brick_Oven_no_Reward = 325,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brickyard</name>
	Ruined_Brickyard = 326,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brickyard (no reward)</name>
	Ruined_Brickyard_no_Reward = 327,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Butcher</name>
	Ruined_Butcher = 328,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Butcher (no reward)</name>
	Ruined_Butcher_no_Reward = 329,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cannery</name>
	Ruined_Cannery = 330,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cannery (no reward)</name>
	Ruined_Cannery_no_Reward = 331,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Carpenter</name>
	Ruined_Carpenter = 332,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Carpenter (no reward)</name>
	Ruined_Carpenter_no_Reward = 333,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cellar</name>
	Ruined_Cellar = 334,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cellar (no reward)</name>
	Ruined_Cellar_no_Reward = 335,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clan Hall</name>
	Ruined_Clan_Hall = 336,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clan Hall (no reward)</name>
	Ruined_Clan_Hall_no_Reward = 337,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clay Pit</name>
	Ruined_Clay_Pit = 338,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clay Pit (no reward)</name>
	Ruined_Clay_Pit_no_Reward = 339,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cobbler</name>
	Ruined_Cobbler = 340,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cobbler (no reward)</name>
	Ruined_Cobbler_no_Reward = 341,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cookhouse</name>
	Ruined_Cookhouse = 342,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cookhouse (no reward)</name>
	Ruined_Cookhouse_no_Reward = 343,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cooperage</name>
	Ruined_Cooperage = 344,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cooperage (no reward)</name>
	Ruined_Cooperage_no_Reward = 345,

	/// <summary>
	/// Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Crude Workstation (no reward)</name>
	Ruined_Crude_Workstation_no_Reward = 346,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Distillery</name>
	Ruined_Distillery = 347,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Distillery (no reward)</name>
	Ruined_Distillery_no_Reward = 348,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Druid</name>
	Ruined_Druid = 349,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Druid (no reward)</name>
	Ruined_Druid_no_Reward = 350,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Explorers Lodge</name>
	Ruined_Explorers_Lodge = 351,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Explorers Lodge (no reward)</name>
	Ruined_Explorers_Lodge_no_Reward = 352,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Farm</name>
	Ruined_Farm = 353,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Farm (no reward)</name>
	Ruined_Farm_no_Reward = 354,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Feast Hall (no reward)</name>
	Ruined_Feast_Hall_no_Reward = 537,

	/// <summary>
	/// Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Field Kitchen (no reward)</name>
	Ruined_Field_Kitchen_no_Reward = 355,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Finesmith</name>
	Ruined_Finesmith = 356,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Finesmith (no reward)</name>
	Ruined_Finesmith_no_Reward = 357,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Fishing Hut</name>
	Ruined_Fishing_Hut = 358,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut (no reward)</name>
	Ruined_Fishing_Hut_no_Reward = 359,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut Primitive (no reward)</name>
	Ruined_Fishing_Hut_Primitive_no_Reward = 360,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Foragers Camp</name>
	Ruined_Foragers_Camp = 361,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp (no reward)</name>
	Ruined_Foragers_Camp_no_Reward = 362,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp Primitive (no reward)</name>
	Ruined_Foragers_Camp_Primitive_no_Reward = 363,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum</name>
	Ruined_Forum = 364,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum (no reward)</name>
	Ruined_Forum_no_Reward = 365,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House</name>
	Ruined_Fox_House = 366,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House (no reward)</name>
	Ruined_Fox_House_no_Reward = 367,

	/// <summary>
	/// Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Frog House (no reward)</name>
	Ruined_Frog_House_no_Reward = 368,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Furnace</name>
	Ruined_Furnace = 369,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Furnace (no reward)</name>
	Ruined_Furnace_no_Reward = 370,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Granary</name>
	Ruined_Granary = 371,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Granary (no reward)</name>
	Ruined_Granary_no_Reward = 372,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Greenhouse</name>
	Ruined_Greenhouse = 373,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Greenhouse (no reward)</name>
	Ruined_Greenhouse_no_Reward = 374,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill</name>
	Ruined_Grill = 375,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill (no reward)</name>
	Ruined_Grill_no_Reward = 376,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grove</name>
	Ruined_Grove = 377,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Grove (no reward)</name>
	Ruined_Grove_no_Reward = 378,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Guild House</name>
	Ruined_Guild_House = 379,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Guild House (no reward)</name>
	Ruined_Guild_House_no_Reward = 380,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House</name>
	Ruined_Harpy_House = 381,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House (no reward)</name>
	Ruined_Harpy_House_no_Reward = 382,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Harvester Camp</name>
	Ruined_Harvester_Camp = 383,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harvester Camp (no reward)</name>
	Ruined_Harvester_Camp_no_Reward = 384,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herb Garden</name>
	Ruined_Herb_Garden = 385,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herb Garden (no reward)</name>
	Ruined_Herb_Garden_no_Reward = 386,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herbalist Camp</name>
	Ruined_Herbalist_Camp = 387,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp (no reward)</name>
	Ruined_Herbalist_Camp_no_Reward = 388,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp primitive (no reward)</name>
	Ruined_Herbalist_Camp_Primitive_no_Reward = 389,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House</name>
	Ruined_Human_House = 390,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House (no reward)</name>
	Ruined_Human_House_no_Reward = 391,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Kiln</name>
	Ruined_Kiln = 392,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Kiln (no reward)</name>
	Ruined_Kiln_no_Reward = 393,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks</name>
	Ruined_Leatherworks = 394,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks (no reward)</name>
	Ruined_Leatherworks_no_Reward = 395,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House</name>
	Ruined_Lizard_House = 396,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House (no reward)</name>
	Ruined_Lizard_House_no_Reward = 397,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Lumbermill</name>
	Ruined_Lumbermill = 398,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lumbermill (no reward)</name>
	Ruined_Lumbermill_no_Reward = 399,

	/// <summary>
	/// Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Makeshift Post (no reward)</name>
	Ruined_Makeshift_Post_no_Reward = 400,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Manufatory</name>
	Ruined_Manufatory = 401,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Manufatory (no reward)</name>
	Ruined_Manufatory_no_Reward = 402,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Market</name>
	Ruined_Market = 403,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Market (no reward)</name>
	Ruined_Market_no_Reward = 404,

	/// <summary>
	/// Mine - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Mine (no reward)</name>
	Ruined_Mine_no_Reward = 405,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery</name>
	Ruined_Monastery = 406,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery (no reward)</name>
	Ruined_Monastery_no_Reward = 407,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Pantry</name>
	Ruined_Pantry = 408,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Pantry (no reward)</name>
	Ruined_Pantry_no_Reward = 409,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Plantation</name>
	Ruined_Plantation = 410,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Plantation (no reward)</name>
	Ruined_Plantation_no_Reward = 411,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press</name>
	Ruined_Press = 412,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press (no reward)</name>
	Ruined_Press_no_Reward = 413,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Provisioner</name>
	Ruined_Provisioner = 414,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Provisioner (no reward)</name>
	Ruined_Provisioner_no_Reward = 415,

	/// <summary>
	/// Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rain Catcher (no reward)</name>
	Ruined_Rain_Catcher_no_Reward = 416,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Rainmill</name>
	Ruined_Rainmill = 417,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rainmill (no reward)</name>
	Ruined_Rainmill_no_Reward = 418,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Ranch</name>
	Ruined_Ranch = 419,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Ranch (no reward)</name>
	Ruined_Ranch_no_Reward = 420,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Scribe</name>
	Ruined_Scribe = 421,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Scribe (no reward)</name>
	Ruined_Scribe_no_Reward = 422,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Sewer</name>
	Ruined_Sewer = 423,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Sewer (no reward)</name>
	Ruined_Sewer_no_Reward = 424,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter</name>
	Ruined_Shelter = 425,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter (no reward)</name>
	Ruined_Shelter_no_Reward = 426,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined SmallFarm</name>
	Ruined_SmallFarm = 427,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined SmallFarm (no reward)</name>
	Ruined_SmallFarm_no_Reward = 428,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smelter</name>
	Ruined_Smelter = 429,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smelter (no reward)</name>
	Ruined_Smelter_no_Reward = 430,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smithy</name>
	Ruined_Smithy = 431,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smithy (no reward)</name>
	Ruined_Smithy_no_Reward = 432,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smokehouse</name>
	Ruined_Smokehouse = 433,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smokehouse (no reward)</name>
	Ruined_Smokehouse_no_Reward = 434,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stamping Mill</name>
	Ruined_Stamping_Mill = 435,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stamping Mill (no reward)</name>
	Ruined_Stamping_Mill_no_Reward = 436,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stonecutter Camp</name>
	Ruined_Stonecutter_Camp = 437,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stonecutter Camp (no reward)</name>
	Ruined_Stonecutter_Camp_no_Reward = 438,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Storage</name>
	Ruined_Storage = 439,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Storage (no reward)</name>
	Ruined_Storage_no_Reward = 440,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Supplier</name>
	Ruined_Supplier = 441,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Supplier (no reward)</name>
	Ruined_Supplier_no_Reward = 442,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tavern</name>
	Ruined_Tavern = 443,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tavern (no reward)</name>
	Ruined_Tavern_no_Reward = 444,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea Doctor</name>
	Ruined_Tea_Doctor = 445,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea Doctor (no reward)</name>
	Ruined_Tea_Doctor_no_Reward = 446,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea House</name>
	Ruined_Tea_House = 447,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea House (no reward)</name>
	Ruined_Tea_House_no_Reward = 448,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Temple</name>
	Ruined_Temple = 449,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Temple (no reward)</name>
	Ruined_Temple_no_Reward = 450,

	/// <summary>
	/// Field Engineering Station - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Temporary Engineering Station (no reward)</name>
	Ruined_Temporary_Engineering_Station_no_Reward = 538,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinctury</name>
	Ruined_Tinctury = 451,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinctury (no reward)</name>
	Ruined_Tinctury_no_Reward = 452,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinkerer</name>
	Ruined_Tinkerer = 453,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinkerer (no reward)</name>
	Ruined_Tinkerer_no_Reward = 454,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Toolshop</name>
	Ruined_Toolshop = 455,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Toolshop (no reward)</name>
	Ruined_Toolshop_no_Reward = 456,

	/// <summary>
	/// Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trading Post (no reward)</name>
	Ruined_Trading_Post_no_Reward = 457,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Trappers Camp</name>
	Ruined_Trappers_Camp = 458,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp (no reward)</name>
	Ruined_Trappers_Camp_no_Reward = 459,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp Primitive (no reward)</name>
	Ruined_Trappers_Camp_Primitive_no_Reward = 460,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Weaver</name>
	Ruined_Weaver = 461,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Weaver (no reward)</name>
	Ruined_Weaver_no_Reward = 462,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Woodcutters Camp</name>
	Ruined_Woodcutters_Camp = 463,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Woodcutters Camp (no reward)</name>
	Ruined_Woodcutters_Camp_no_Reward = 464,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Workshop</name>
	Ruined_Workshop = 465,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Workshop (no reward)</name>
	Ruined_Workshop_no_Reward = 466,

	/// <summary>
	/// Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
	/// </summary>
	/// <name>Sacrifice Totem</name>
	Sacrifice_Totem = 467,

	/// <summary>
	/// Converted Totem of Denial - Harmony. Repurposed Fishmen magic can be very useful... but let's hope we don't suffer the same fate as the priestess Ysabelle. Increases Global Resolve by +3. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Sacrifice Totem Positive</name>
	Sacrifice_Totem_Positive = 468,

	/// <summary>
	/// Thorny Reed - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Scarlet Decor</name>
	Scarlet_Decor = 469,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Scorpion 1</name>
	Scorpion_1 = 470,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Scorpion 2</name>
	Scorpion_2 = 471,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Scorpion 3</name>
	Scorpion_3 = 472,

	/// <summary>
	/// <p>Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Scribe</name>
	Scribe = 473,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal</name>
	Seal = 474,

	/// <summary>
	/// Guidance Stone - It is not known where the guidance stones came from or what their original purpose was, but they are imbued with magic and always point in the direction of a nearby seal.
	/// </summary>
	/// <name>Seal Guidepost</name>
	Seal_Guidepost = 475,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal High Diff</name>
	Seal_High_Diff = 476,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal Low Diff</name>
	Seal_Low_Diff = 477,

	/// <summary>
	/// Beacon Tower - A powerful, ancient structure that allows you to summon aid directly from the Citadel. Grants access to three types of temporary support abilities.
	/// </summary>
	/// <name>Sealed Biome Shrine</name>
	Sealed_Biome_Shrine = 478,

	/// <summary>
	/// Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
	/// </summary>
	/// <name>SealedTomb_T1</name>
	SealedTomb_T1 = 479,

	/// <summary>
	/// Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 3 residents.
	/// </summary>
	/// <name>Shelter</name>
	Shelter = 480,

	/// <summary>
	/// Signboard - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Signboard</name>
	Signboard = 481,

	/// <summary>
	/// Ancient Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
	/// </summary>
	/// <name>Small Hearth</name>
	Small_Hearth = 482,

	/// <summary>
	/// Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).
	/// </summary>
	/// <name>SmallFarm</name>
	SmallFarm = 483,

	/// <summary>
	/// <p>Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Smelter</name>
	Smelter = 484,

	/// <summary>
	/// <p>Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Smithy</name>
	Smithy = 485,

	/// <summary>
	/// <p>Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Smokehouse</name>
	Smokehouse = 486,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Snake 1</name>
	Snake_1 = 487,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Snake 2</name>
	Snake_2 = 488,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Snake 3</name>
	Snake_3 = 489,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Spider 1</name>
	Spider_1 = 490,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Spider 2</name>
	Spider_2 = 491,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Spider 3</name>
	Spider_3 = 492,

	/// <summary>
	/// <p>Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Stamping Mill</name>
	Stamping_Mill = 493,

	/// <summary>
	/// Stone Fence - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Stone Fence</name>
	Stone_Fence = 494,

	/// <summary>
	/// Stone Fence Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Stone Fence Corner</name>
	Stone_Fence_Corner = 495,

	/// <summary>
	/// Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
	/// </summary>
	/// <name>Stonecutter's Camp</name>
	Stonecutters_Camp = 496,

	/// <summary>
	/// Small Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
	/// </summary>
	/// <name>Storage (buildable)</name>
	Storage_buildable = 497,

	/// <summary>
	/// Tamed Stormbird - Harmony. The nest of a tamed Stormbird. It provides 5 "[food raw] eggs" Eggs per minute and increases Harpy Resolve by +3. Counts as 16 decorations of its type.
	/// </summary>
	/// <name>Stormbird Positive</name>
	Stormbird_Positive = 498,

	/// <summary>
	/// <p>Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Supplier</name>
	Supplier = 499,

	/// <summary>
	/// Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
	/// </summary>
	/// <name>Tavern</name>
	Tavern = 500,

	/// <summary>
	/// Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
	/// </summary>
	/// <name>Tea Doctor</name>
	Tea_Doctor = 501,

	/// <summary>
	/// <p>Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Tea House</name>
	Tea_House = 502,

	/// <summary>
	/// Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.
	/// </summary>
	/// <name>Temple</name>
	Temple = 503,

	/// <summary>
	/// Field Engineering Station - A makeshift workstation designed by the Brass Order. It’s far simpler than their sophisticated machinery back in the Citadel, but it’ll get the job done. Can produce:  [we] fuel core Enriched Fuel (grade1)
	/// </summary>
	/// <name>Temporary Engineering Station</name>
	Temporary_Engineering_Station = 539,

	/// <summary>
	/// Small Hearth - Reduces Hostility and serves as a meeting place. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will use another Hearth instead. Can't be built too close to other Hearths.
	/// </summary>
	/// <name>Temporary Hearth (buildable)</name>
	Temporary_Hearth_buildable = 504,

	/// <summary>
	/// Small Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
	/// </summary>
	/// <name>Temporary Hearth (not-buildable)</name>
	Temporary_Hearth_not_buildable = 505,

	/// <summary>
	/// Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
	/// </summary>
	/// <name>Termite Burrow</name>
	Termite_Burrow = 506,

	/// <summary>
	/// Termite Nest - Harmony. A contained stonetooth termite burrow. Provides 5 "[food raw] insects" Insects per minute. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Termite Burrow Positive</name>
	Termite_Burrow_Positive = 507,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>TI AncientShrine_T1</name>
	TI_AncientShrine_T1 = 508,

	/// <summary>
	/// <p>Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1).</p>
	/// <p>Rain engine: "[water] drizzle water" Drizzle Water.</p>
	/// </summary>
	/// <name>Tinctury</name>
	Tinctury = 509,

	/// <summary>
	/// <p>Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Tinkerer</name>
	Tinkerer = 510,

	/// <summary>
	/// <p>Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Toolshop</name>
	Toolshop = 511,

	/// <summary>
	/// Wall Crossing - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Tower</name>
	Tower = 512,

	/// <summary>
	/// Town Board - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Town Board</name>
	Town_Board = 513,

	/// <summary>
	/// Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
	/// </summary>
	/// <name>Traders Cemetery</name>
	Traders_Cemetery = 514,

	/// <summary>
	/// Trading Post - Traders from the Smoldering City can station here and offer their wares.
	/// </summary>
	/// <name>Trading Post</name>
	Trading_Post = 515,

	/// <summary>
	/// Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).
	/// </summary>
	/// <name>Trapper's Camp</name>
	Trappers_Camp = 516,

	/// <summary>
	/// Umbrella - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Umbrella</name>
	Umbrella = 517,

	/// <summary>
	/// Wall - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Wall</name>
	Wall = 518,

	/// <summary>
	/// Wall Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Wall Corner</name>
	Wall_Corner = 519,

	/// <summary>
	/// Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
	/// </summary>
	/// <name>War Beast Cage</name>
	War_Beast_Cage = 520,

	/// <summary>
	/// Water Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Water Barrels</name>
	Water_Barrels = 521,

	/// <summary>
	/// Geyser Pump - Used to extract and pump infused rainwater through underground pipes to production buildings, where it can be used to increase productivity. Must be placed on an active geyser. Has a tank capacity of 50.
	/// </summary>
	/// <name>Water Extractor</name>
	Water_Extractor = 522,

	/// <summary>
	/// Water Shrine - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Water Shrine</name>
	Water_Shrine = 523,

	/// <summary>
	/// <p>Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1).</p>
	/// <p>Rain engine: "[water] clearance water" Clearance Water.</p>
	/// </summary>
	/// <name>Weaver</name>
	Weaver = 524,

	/// <summary>
	/// Overgrown Well - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Well</name>
	Well = 525,

	/// <summary>
	/// Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>White Stag</name>
	White_Stag = 526,

	/// <summary>
	/// Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>White Treasure Stag</name>
	White_Treasure_Stag = 527,

	/// <summary>
	/// Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.
	/// </summary>
	/// <name>Wildfire</name>
	Wildfire = 528,

	/// <summary>
	/// Woodcutters' Camp - Starting point for woodcutters going out into the wild to cut down trees.
	/// </summary>
	/// <name>Woodcutters Camp</name>
	Woodcutters_Camp = 529,

	/// <summary>
	/// <p>Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0).</p>
	/// <p>Rain engine: "[water] storm water" Storm Water.</p>
	/// </summary>
	/// <name>Workshop</name>
	Workshop = 530,



	/// <summary>
	/// The total number of vanilla BuildingTypes in the game.
	/// </summary>
	[Obsolete("Use BuildingTypesExtensions.Count(). BuildingTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 539
}

/// <summary>
/// Extension methods for the BuildingTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class BuildingTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in BuildingTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded BuildingTypes.
	/// </summary>
	public static BuildingTypes[] All()
	{
		BuildingTypes[] all = new BuildingTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every BuildingTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return BuildingTypes.Advanced_Rain_Catcher in the enum and log an error.
	/// </summary>
	public static string ToName(this BuildingTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of BuildingTypes: " + type);
		return TypeToInternalName[BuildingTypes.Advanced_Rain_Catcher];
	}
	
	/// <summary>
	/// Returns a BuildingTypes associated with the given name.
	/// Every BuildingTypes should have a unique name as to distinguish it from others.
	/// If no BuildingTypes is found, it will return BuildingTypes.Unknown and log a warning.
	/// </summary>
	public static BuildingTypes ToBuildingTypes(this string name)
	{
		foreach (KeyValuePair<BuildingTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find BuildingTypes with name: " + name + "\n" + Environment.StackTrace);
		return BuildingTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a BuildingModel associated with the given name.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If no BuildingModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingModel ToBuildingModel(this string name)
	{
		Eremite.Buildings.BuildingModel model = SO.Settings.Buildings.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find BuildingModel for BuildingTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a BuildingModel associated with the given BuildingTypes.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If no BuildingModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Buildings.BuildingModel ToBuildingModel(this BuildingTypes types)
	{
		return types.ToName().ToBuildingModel();
	}
	
	/// <summary>
	/// Returns an array of BuildingModel associated with the given BuildingTypes.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If a BuildingModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingModel[] ToBuildingModelArray(this IEnumerable<BuildingTypes> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingModel[] array = new Eremite.Buildings.BuildingModel[count];
		int i = 0;
		foreach (BuildingTypes element in collection)
		{
			array[i++] = element.ToBuildingModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingModel associated with the given BuildingTypes.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If a BuildingModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Buildings.BuildingModel[] ToBuildingModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Buildings.BuildingModel[] array = new Eremite.Buildings.BuildingModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToBuildingModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of BuildingModel associated with the given BuildingTypes.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If a BuildingModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingModel[] ToBuildingModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingModel>.Get(out List<Eremite.Buildings.BuildingModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Buildings.BuildingModel model = element.ToBuildingModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of BuildingModel associated with the given BuildingTypes.
	/// BuildingModel contain all the data that will be used in the game.
	/// Every BuildingModel should have a unique name as to distinguish it from others.
	/// If a BuildingModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Buildings.BuildingModel[] ToBuildingModelArrayNoNulls(this IEnumerable<BuildingTypes> collection)
	{
		using(ListPool<Eremite.Buildings.BuildingModel>.Get(out List<Eremite.Buildings.BuildingModel> list))
		{
			foreach (BuildingTypes element in collection)
			{
				Eremite.Buildings.BuildingModel model = element.ToBuildingModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<BuildingTypes, string> TypeToInternalName = new()
	{
		{ BuildingTypes.Advanced_Rain_Catcher, "Advanced Rain Catcher" },                                                     // Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
		{ BuildingTypes.Aestherics_2x2_Garden, "Aestherics 2x2 - Garden" },                                                   // Garden - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Aestherics_2x2_Groundwater_Extractor, "Aestherics 2x2 - Groundwater Extractor" },                     // Makeshift Extractor - Aesthetics. A curious piece of improvised technology. It extracts moisture from the soil around it and converts it into 10 "[water] clearance water" Clearance Water per minute. Counts as 4 decorations of its type.
		{ BuildingTypes.Alchemist_Hut, "Alchemist Hut" },                                                                     // Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Altar, "Altar" },                                                                                     // Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
		{ BuildingTypes.Ancient_Gravestone, "Ancient Gravestone" },                                                           // Ancient Tombstone - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                                     // Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
		{ BuildingTypes.AncientGate, "AncientGate" },                                                                         // Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
		{ BuildingTypes.AncientShrine_T1, "AncientShrine_T1" },                                                               // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ BuildingTypes.AncientTemple, "AncientTemple" },                                                                     // Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
		{ BuildingTypes.Angry_Ghost_1, "Angry Ghost 1" },                                                                     // Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
		{ BuildingTypes.Angry_Ghost_10, "Angry Ghost 10" },                                                                   // Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
		{ BuildingTypes.Angry_Ghost_14, "Angry Ghost 14" },                                                                   // Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
		{ BuildingTypes.Angry_Ghost_15, "Angry Ghost 15" },                                                                   // Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
		{ BuildingTypes.Angry_Ghost_16, "Angry Ghost 16" },                                                                   // Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
		{ BuildingTypes.Angry_Ghost_17, "Angry Ghost 17" },                                                                   // Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
		{ BuildingTypes.Angry_Ghost_18, "Angry Ghost 18" },                                                                   // Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
		{ BuildingTypes.Angry_Ghost_19, "Angry Ghost 19" },                                                                   // Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
		{ BuildingTypes.Angry_Ghost_2, "Angry Ghost 2" },                                                                     // Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
		{ BuildingTypes.Angry_Ghost_20, "Angry Ghost 20" },                                                                   // Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
		{ BuildingTypes.Angry_Ghost_21, "Angry Ghost 21" },                                                                   // Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
		{ BuildingTypes.Angry_Ghost_24, "Angry Ghost 24" },                                                                   // Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
		{ BuildingTypes.Angry_Ghost_31, "Angry Ghost 31" },                                                                   // Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
		{ BuildingTypes.Angry_Ghost_32, "Angry Ghost 32" },                                                                   // Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
		{ BuildingTypes.Angry_Ghost_34, "Angry Ghost 34" },                                                                   // Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
		{ BuildingTypes.Angry_Ghost_4, "Angry Ghost 4" },                                                                     // Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
		{ BuildingTypes.Angry_Ghost_41, "Angry Ghost 41" },                                                                   // Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
		{ BuildingTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                                     // Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
		{ BuildingTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                                     // Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
		{ BuildingTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                                     // Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
		{ BuildingTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                           // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ BuildingTypes.Anvil, "Anvil" },                                                                                     // Anvil - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Apothecary, "Apothecary" },                                                                           // Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Arch, "Arch" },                                                                                       // Ancient Arch - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
		{ BuildingTypes.Archaeology_Scorpion_Positive, "Archaeology Scorpion Positive" },                                     // Smoldering Scorpion - Harmony. Legend has it that they once inhabited the top of the mountain on which the Smoldering City now stands. The Queen banished them, but it is said that some of them still hibernate somewhere on the outskirts of the kingdom.  Counts as 9 decorations of its type.
		{ BuildingTypes.Archaeology_Snake_Positive, "Archaeology Snake Positive" },                                           // Sea Serpent - Harmony. The anatomical features of this beast indicate an adaptation to life in water, as well as on land. Due to this, sea serpents are excellent hunters, preying on lonely caravans and lost settlers. The preserved remains show traces of Blightrot. Could it be that these creatures have brought this plague to the surface when emerging from the depths of the ocean? Counts as 9 decorations of its type.
		{ BuildingTypes.Archaeology_Spider_Positive, "Archaeology Spider Positive" },                                         // Sealed Spider - Harmony. It is said that these creatures were once the faithful servants of the Sealed Ones, and like their masters, they were trapped underground for eternity. But even to this day, miners tell tales of giant spiders crawling up from deep caverns, preying on unsuspecting victims. Legend has it that these vile beasts fear only one thing - the Holy Flame. Counts as 9 decorations of its type.
		{ BuildingTypes.Archeology_Office, "Archeology office" },                                                             // Archaeologist's Office - A building designed to help you study the past. Can be upgraded to locate archaeological discoveries or improve the settlement's exploration capabilities. 
		{ BuildingTypes.Artisan, "Artisan" },                                                                                 // Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Bakery, "Bakery" },                                                                                   // Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Bank, "Bank" },                                                                                       // Bench - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Barrels, "Barrels" },                                                                                 // Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Bath_House, "Bath House" },                                                                           // Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
		{ BuildingTypes.Beanery, "Beanery" },                                                                                 // Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Beaver_House, "Beaver House" },                                                                       // Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 2 inhabitants.
		{ BuildingTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                                     // Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
		{ BuildingTypes.Big_Shelter, "Big Shelter" },                                                                         // Big Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 6 residents.
		{ BuildingTypes.Biome_Perk_Crafter, "Biome Perk Crafter" },                                                           // Cornerstone Forge - An ancient forge used by the Crown for generations to craft cornerstones from Thunderblight Shards. Now it stands abandoned, its fires long cold, but its legacy still felt in the region.
		{ BuildingTypes.Black_Stag, "Black Stag" },                                                                           // Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.Black_Treasure_Stag, "Black Treasure Stag" },                                                         // Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Blight_Post, "Blight Post" },                                                                         // Blight Post - A specialized building dedicated to fighting Blightrot. Blight Fighters will prepare "blight fuel" Purging Fire during drizzle and clearance seasons, and use it to burn Blightrot Cysts during the storm.
		{ BuildingTypes.Blightrot, "Blightrot" },                                                                             // Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
		{ BuildingTypes.Blightrot_Cauldron, "Blightrot Cauldron" },                                                           // Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
		{ BuildingTypes.Blightrot_Clone, "Blightrot - Clone" },                                                               // Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
		{ BuildingTypes.Bonfire, "Bonfire" },                                                                                 // Bonfire - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.Brewery, "Brewery" },                                                                                 // Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Brick_Oven, "Brick Oven" },                                                                           // Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Brickyard, "Brickyard" },                                                                             // Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Bush, "Bush" },                                                                                       // Bush - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Butcher, "Butcher" },                                                                                 // Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Cages, "Cages" },                                                                                     // Cages - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Calm_Ghost_11, "Calm Ghost 11" },                                                                     // Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
		{ BuildingTypes.Calm_Ghost_12, "Calm Ghost 12" },                                                                     // Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
		{ BuildingTypes.Calm_Ghost_13, "Calm Ghost 13" },                                                                     // Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
		{ BuildingTypes.Calm_Ghost_22, "Calm Ghost 22" },                                                                     // Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
		{ BuildingTypes.Calm_Ghost_23, "Calm Ghost 23" },                                                                     // Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
		{ BuildingTypes.Calm_Ghost_25, "Calm Ghost 25" },                                                                     // Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
		{ BuildingTypes.Calm_Ghost_26, "Calm Ghost 26" },                                                                     // Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
		{ BuildingTypes.Calm_Ghost_27, "Calm Ghost 27" },                                                                     // Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
		{ BuildingTypes.Calm_Ghost_28, "Calm Ghost 28" },                                                                     // Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
		{ BuildingTypes.Calm_Ghost_29, "Calm Ghost 29" },                                                                     // Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
		{ BuildingTypes.Calm_Ghost_3, "Calm Ghost 3" },                                                                       // Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
		{ BuildingTypes.Calm_Ghost_30, "Calm Ghost 30" },                                                                     // Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
		{ BuildingTypes.Calm_Ghost_33, "Calm Ghost 33" },                                                                     // Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
		{ BuildingTypes.Calm_Ghost_35, "Calm Ghost 35" },                                                                     // Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
		{ BuildingTypes.Calm_Ghost_36, "Calm Ghost 36" },                                                                     // Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
		{ BuildingTypes.Calm_Ghost_38, "Calm Ghost 38" },                                                                     // Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
		{ BuildingTypes.Calm_Ghost_39, "Calm Ghost 39" },                                                                     // Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
		{ BuildingTypes.Calm_Ghost_40, "Calm Ghost 40" },                                                                     // Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
		{ BuildingTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                                       // Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
		{ BuildingTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                                       // Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
		{ BuildingTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                             // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ BuildingTypes.Camp_T1, "Camp_T1" },                                                                                 // Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ BuildingTypes.Camp_T2, "Camp_T2" },                                                                                 // Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ BuildingTypes.Cannery, "Cannery" },                                                                                 // Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Caravan_T1, "Caravan_T1" },                                                                           // Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ BuildingTypes.Caravan_T2, "Caravan_T2" },                                                                           // Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ BuildingTypes.Carpenter, "Carpenter" },                                                                             // Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Cellar, "Cellar" },                                                                                   // Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Chest, "Chest" },                                                                                     // Chest - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Clan_Hall, "Clan Hall" },                                                                             // Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
		{ BuildingTypes.Clay_Pit_Workshop, "Clay Pit Workshop" },                                                             // Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2) Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Clothier, "Clothier" },                                                                               // Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Coastal_Grove_Plant, "Coastal Grove Plant" },                                                         // Saltwater Pitcher Plant - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Cobbler, "Cobbler" },                                                                                 // Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Comfort_2x2_Park, "Comfort 2x2 - Park" },                                                             // Park - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Cookhouse, "Cookhouse" },                                                                             // Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Cooperage, "Cooperage" },                                                                             // Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Coral_Decor, "Coral Decor" },                                                                         // Coral Growth - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.CornerFence, "CornerFence" },                                                                         // Fence Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                             // Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
		{ BuildingTypes.Crates, "Crates" },                                                                                   // Crates - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Crude_Workstation, "Crude Workstation" },                                                             // Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                             // Clay Node (Large) - Soil infused with the essence of the rain.
		{ BuildingTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                                         // Clay Node (Small) - Soil infused with the essence of the rain.
		{ BuildingTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                                             // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
		{ BuildingTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                                         // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
		{ BuildingTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                                             // Flax Field (Large) - Resilient plants that are perfect for cloth-making.
		{ BuildingTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                                         // Flax Field (Small) - Resilient plants that are perfect for cloth-making.
		{ BuildingTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                                           // Herb Node (Large) - A dense shrub, full of many useful plant species.
		{ BuildingTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                                       // Herb Node (Small) - A dense shrub, full of many useful plant species.
		{ BuildingTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                                     // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ BuildingTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                                 // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ BuildingTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },                           // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },                             // Dead Leviathan - A giant, dead beast. How did it get here?
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },                     // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
		{ BuildingTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                                 // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },                             // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                                             // Moss Broccoli Patch (Large) - An edible and tasty type of moss.
		{ BuildingTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                                         // Moss Broccoli Patch (Small) - An edible and tasty type of moss.
		{ BuildingTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                                     // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                                 // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                                             // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
		{ BuildingTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                                         // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
		{ BuildingTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                           // Root Node (Large) - A tangled net of living vines.
		{ BuildingTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                                       // Root Node (Small) - A tangled net of living vines.
		{ BuildingTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                                   // Sea Marrow Node (Large) - Ancient fossils, rich in resources.
		{ BuildingTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                               // Sea Marrow Node (Small) - Ancient fossils, rich in resources.
		{ BuildingTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                                     // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ BuildingTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                                 // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ BuildingTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                                   // Snake Nest (Large) - A dangerous, but rich source of food and leather.
		{ BuildingTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                               // Snake Nest (Small) - A dangerous, but rich source of food and leather.
		{ BuildingTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                           // Stone Node (Large) - Stones, weathered by the everlasting rain.
		{ BuildingTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                                       // Stone Node (Small) - Stones, weathered by the everlasting rain.
		{ BuildingTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                                           // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ BuildingTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                                       // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ BuildingTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                                 // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
		{ BuildingTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                                             // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
		{ BuildingTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                                         // Wormtongue Nest (Large) - A nest full of tasty wormtongues.
		{ BuildingTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                                     // Wormtongue Nest (Small) - A nest full of tasty wormtongues.
		{ BuildingTypes.Decay_Altar, "Decay Altar" },                                                                         // Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
		{ BuildingTypes.Decay_Altar_Positive, "Decay Altar Positive" },                                                       // Converted Altar of Decay - Harmony. Bloody sacrifices delight the evil presence. Forbidden rituals at the Altar of Decay reduce Hostility by 20 points every time a villager dies or leaves. Counts as 9 decorations of its type.
		{ BuildingTypes.Distillery, "Distillery" },                                                                           // Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Druid, "Druid" },                                                                                     // Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Escaped_Convicts, "Escaped Convicts" },                                                               // Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
		{ BuildingTypes.Explorers_Lodge, "Explorers Lodge" },                                                                 // Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
		{ BuildingTypes.Farmfield, "Farmfield" },                                                                             // Farm Field - Can only be placed on fertile soil. Requires a Small Farm, Plantation, Herb Garden, Forester's Hut, or Homestead nearby to produce crops.
		{ BuildingTypes.Feast_Hall, "Feast Hall" },                                                                           // Feast Hall - A place where villagers can fulfill their need for: Treatment,  Brawling. Passive effects: Festive Mood.
		{ BuildingTypes.Feast_Hall_Funeral_Event_1, "Feast Hall - Funeral Event 1" },                                         // Feast Hall - The mourners gather in the Feast Hall as the Funerary Feast begins. Following tradition, the guests first partake in a meal, sharing stories and memories of their departed friend.
		{ BuildingTypes.Feast_Hall_Funeral_Event_2, "Feast Hall - Funeral Event 2" },                                         // Feast Hall - After the meal, the funeral guests partake in a customary memorial rite, guiding the soul of the departed toward its journey to a new vessel.
		{ BuildingTypes.Feast_Hall_Funeral_Event_3, "Feast Hall - Funeral Event 3" },                                         // Feast Hall - According to tradition, after the funeral feast, the family of the departed presents small gifts to the guests - tokens to help them remember the friend they have lost.
		{ BuildingTypes.Fence, "Fence" },                                                                                     // Fence - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Field_Kitchen, "Field Kitchen" },                                                                     // Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Finesmith, "Finesmith" },                                                                             // Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Fire_Shrine, "Fire Shrine" },                                                                         // Fire Shrine - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Fish, "Fish" },                                                                                       // Fish Mount - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fishing_Hut, "Fishing Hut" },                                                                         // Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
		{ BuildingTypes.Fishmen_Cave, "Fishmen Cave" },                                                                       // Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
		{ BuildingTypes.Fishmen_Lighthouse, "Fishmen Lighthouse" },                                                           // Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
		{ BuildingTypes.Fishmen_Lighthouse_Positive, "Fishmen Lighthouse Positive" },                                         // Converted Fishmen Lighthouse - Harmony. A tall bone structure built by the Fishmen. It has been repurposed and now provides 5 "[crafting] sea marrow" Sea Marrow per minute. Counts as 16 decorations of its type.
		{ BuildingTypes.Fishmen_Outpost, "Fishmen Outpost" },                                                                 // Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
		{ BuildingTypes.Fishmen_Soothsayer, "Fishmen Soothsayer" },                                                           // Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
		{ BuildingTypes.Fishmen_Totem, "Fishmen Totem" },                                                                     // Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
		{ BuildingTypes.Flame_Altar, "Flame Altar" },                                                                         // Flame Altar - A strange, ancient altar, supposedly dedicated to the Holy Flame. Grants access to temporary support abilities.
		{ BuildingTypes.Flawless_Brewery, "Flawless Brewery" },                                                               // Flawless Brewery - An upgraded production building with all recipes at the highest grade. Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3). Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Flawless_Cellar, "Flawless Cellar" },                                                                 // Flawless Cellar - An upgraded production building with all recipes at the highest grade. Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3). Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Flawless_Cooperage, "Flawless Cooperage" },                                                           // Flawless Cooperage - An upgraded production building with all recipes at the highest grade. Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3). Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Druid, "Flawless Druid" },                                                                   // Flawless Druid's Hut - An upgraded production building with all recipes at the highest grade. Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3). Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Leatherworks, "Flawless Leatherworks" },                                                     // Flawless Leatherworker - An upgraded production building with all recipes at the highest grade. Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3). Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Rain_Mill, "Flawless Rain Mill" },                                                           // Flawless Rain Mill - An upgraded production building with all recipes at the highest grade. Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3). Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Smelter, "Flawless Smelter" },                                                               // Flawless Smelter - An upgraded production building with all recipes at the highest grade. Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3). Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Flower_Bed, "Flower Bed" },                                                                           // Flower Bed - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Foragers_Camp, "Forager's Camp" },                                                                    // Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
		{ BuildingTypes.ForsakenCrypt, "ForsakenCrypt" },                                                                     // Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
		{ BuildingTypes.Forum, "Forum" },                                                                                     // Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
		{ BuildingTypes.Fountain, "Fountain" },                                                                               // Marble Fountain - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Fox_Fence, "Fox Fence" },                                                                             // Overgrown Fence - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fox_Fence_Corner, "Fox Fence Corner" },                                                               // Overgrown Fence Corner - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fox_House, "Fox House" },                                                                             // Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 2 inhabitants.
		{ BuildingTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                                           // Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
		{ BuildingTypes.Frog_House, "Frog House" },                                                                           // Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 2 inhabitants.
		{ BuildingTypes.Frog_Tree, "Frog Tree" },                                                                             // Evergreen Shrub - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.FrogBattleground_T1, "FrogBattleground_T1" },                                                         // Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
		{ BuildingTypes.Fuming_Machinery, "Fuming Machinery" },                                                               // Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
		{ BuildingTypes.Furnace, "Furnace" },                                                                                 // Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Gate, "Gate" },                                                                                       // Gate - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
		{ BuildingTypes.Ghost_Treasure_Stag, "Ghost Treasure Stag" },                                                         // Spectral Stag - A truly rare sight - a Spectral Treasure Stag, lured to this place by the lingering anguish of mortal souls. Those who manage to find it will be rewarded with a special treasure.
		{ BuildingTypes.Giant_Stormbird, "Giant Stormbird" },                                                                 // Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
		{ BuildingTypes.Glade_Trader_The_Hermit, "Glade Trader - The Hermit" },                                               // Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
		{ BuildingTypes.Glade_Trader_The_Seer, "Glade Trader - The Seer" },                                                   // Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
		{ BuildingTypes.Glade_Trader_The_Shaman, "Glade Trader - The Shaman" },                                               // Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
		{ BuildingTypes.Gold_Stag, "Gold Stag" },                                                                             // Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                           // Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Golden_Leaf, "Golden Leaf" },                                                                         // Golden Leaf Plant - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Granary, "Granary" },                                                                                 // Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Greenhouse_Workshop, "Greenhouse Workshop" },                                                         // Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
		{ BuildingTypes.Grill, "Grill" },                                                                                     // Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Grove, "Grove" },                                                                                     // Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
		{ BuildingTypes.Guild_House, "Guild House" },                                                                         // Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
		{ BuildingTypes.Hallowed_Herb_Garden, "Hallowed Herb Garden" },                                                       // Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
		{ BuildingTypes.Hallowed_SmallFarm, "Hallowed SmallFarm" },                                                           // Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
		{ BuildingTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                                       // Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
		{ BuildingTypes.Harmony_Spirit_Altar_Positive, "Harmony Spirit Altar Positive" },                                     // Converted Harmony Spirit Altar - Harmony. When your villagers' needs are met, Harmony is fostered. Each unique service building adds 2 to Global Resolve. Counts as 9 decorations of its type.
		{ BuildingTypes.Harpy_House, "Harpy House" },                                                                         // Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 2 inhabitants.
		{ BuildingTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                                       // Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
		{ BuildingTypes.Harvester_Camp, "Harvester Camp" },                                                                   // Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
		{ BuildingTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                                         // Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                                   // Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                                     // Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                               // Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                                       // Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                               // Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Frog_House, "Haunted Ruined Frog House" },                                             // Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Guild_House, "Haunted Ruined Guild House" },                                           // Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Harpy_House, "Haunted Ruined Harpy House" },                                           // Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Herb_Garden, "Haunted Ruined Herb Garden" },                                           // Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Human_House, "Haunted Ruined Human House" },                                           // Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Leatherworks, "Haunted Ruined Leatherworks" },                                         // Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Lizard_House, "Haunted Ruined Lizard House" },                                         // Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Market, "Haunted Ruined Market" },                                                     // Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Rainmill, "Haunted Ruined Rainmill" },                                                 // Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_SmallFarm, "Haunted Ruined SmallFarm" },                                               // Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Smelter, "Haunted Ruined Smelter" },                                                   // Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Temple, "Haunted Ruined Temple" },                                                     // Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Herb_Garden, "Herb Garden" },                                                                         // Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
		{ BuildingTypes.Herbalists_Camp, "Herbalist's Camp" },                                                                // Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ BuildingTypes.Holy_Guild_House, "Holy Guild House" },                                                               // Holy Guild House - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Luxury,  Education. Passive effects: Guild House, The Guild's Welfare.
		{ BuildingTypes.Holy_Market, "Holy Market" },                                                                         // Holy Market - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Leisure,  Treatment. Passive effects: Ale and Hearty, Market Carts.
		{ BuildingTypes.Holy_Temple, "Holy Temple" },                                                                         // Holy Temple - An upgraded service building with an additional passive effect. Villagers can use it to fulfill their need for:  Religion,  Education. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
		{ BuildingTypes.Homestead, "Homestead" },                                                                             // Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ BuildingTypes.Human_House, "Human House" },                                                                         // Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 2 inhabitants.
		{ BuildingTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                                       // Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
		{ BuildingTypes.Hydrant, "Hydrant" },                                                                                 // Hydrant - A small storage for "blight fuel" Purging Fire. Blight Fighters will use it to restock their fuel when fighting Blightrot in the storm.
		{ BuildingTypes.Industrial_Chimney, "Industrial Chimney" },                                                           // Industrial Chimney - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Infected_Mole, "Infected Mole" },                                                                     // Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
		{ BuildingTypes.Infected_Tree, "Infected Tree" },                                                                     // Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
		{ BuildingTypes.Kelpie, "Kelpie" },                                                                                   // River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
		{ BuildingTypes.Kiln, "Kiln" },                                                                                       // Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Lamp, "Lamp" },                                                                                       // Lamp - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Leaking_Cauldron, "Leaking Cauldron" },                                                               // Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
		{ BuildingTypes.Leatherworks, "Leatherworks" },                                                                       // Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Lightning_Catcher, "Lightning Catcher" },                                                             // Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
		{ BuildingTypes.Lizard_House, "Lizard House" },                                                                       // Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 2 inhabitants.
		{ BuildingTypes.Lizard_Post, "Lizard Post" },                                                                         // Lizard Post - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                                     // Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
		{ BuildingTypes.Lore_Tablet_1, "Lore Tablet 1" },                                                                     // Inscribed Monolith - Harmony. Born in the Blightstorm, she will climb the Red Mountain. The fires beneath her feet shall hiss her name. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_2, "Lore Tablet 2" },                                                                     // Inscribed Monolith - Harmony. Though sealed beneath the muddy ground, their voices ring loud and clear. Maddening, alluring. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_3, "Lore Tablet 3" },                                                                     // Inscribed Monolith - Harmony. The true rulers of this world shall rise again and break the seals that bind them. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_4, "Lore Tablet 4" },                                                                     // Inscribed Monolith - Harmony. Envy the lesser species, for they do not yet know what lies beneath. But in time, they will understand. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_5, "Lore Tablet 5" },                                                                     // Inscribed Monolith - Harmony. It pours, yet it does not flood. As if the earth itself greedily drinks every last drop of this eternal curse. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_6, "Lore Tablet 6" },                                                                     // Inscribed Monolith - Harmony. Embrace the Eternal Rain, for it powers the engine of progress. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_7, "Lore Tablet 7" },                                                                     // Inscribed Monolith - Harmony. Don't let the pleasant sparking of the raindrops fool you. This is just the first sign of your flesh rotting. Counts as 2 decorations of its type.
		{ BuildingTypes.Lumbermill, "Lumbermill" },                                                                           // Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Main_Storage_not_buildable, "Main Storage (not-buildable)" },                                         // Main Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
		{ BuildingTypes.Makeshift_Post, "Makeshift Post" },                                                                   // Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Manufactory, "Manufactory" },                                                                         // Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Market, "Market" },                                                                                   // Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
		{ BuildingTypes.Merchant_Ship_Wreck, "Merchant Ship Wreck" },                                                         // Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
		{ BuildingTypes.Mine, "Mine" },                                                                                       // Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).
		{ BuildingTypes.Mistworm_T1, "Mistworm_T1" },                                                                         // Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
		{ BuildingTypes.Mole, "Mole" },                                                                                       // Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
		{ BuildingTypes.Monastery, "Monastery" },                                                                             // Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
		{ BuildingTypes.Monolith, "Monolith" },                                                                               // Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
		{ BuildingTypes.Monolith_Positive, "Monolith Positive" },                                                             // Obelisk - Aesthetics. The symbols carved into this monumental stone bear an eerie resemblance to the forest and corruption. Decreases Hostility by 10 points and increases the Ancient Hearth's resistance by 100.
		{ BuildingTypes.Moument_Of_Greed, "Moument of Greed" },                                                               // Monument of Greed - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Mushroom_Decor, "Mushroom Decor" },                                                                   // Decorative Fungus - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Nightfern, "Nightfern" },                                                                             // Nightfern - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Noxious_Machinery, "Noxious Machinery" },                                                             // Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
		{ BuildingTypes.Ornate_Column, "Ornate Column" },                                                                     // Ornate Column - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Pantry, "Pantry" },                                                                                   // Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Path, "Path" },                                                                                       // Path - A simple path, doesn't cost any resources. Grants a 5% speed increase to villagers.
		{ BuildingTypes.Paved_Road, "Paved Road" },                                                                           // Paved Road - A road made out of stone. Grants a 15% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
		{ BuildingTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                               // Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
		{ BuildingTypes.Pipe, "Pipe" },                                                                                       // Pipe - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Cross, "Pipe Cross" },                                                                           // Pipe Cross - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Elbow, "Pipe Elbow" },                                                                           // Pipe Elbow - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_End, "Pipe End" },                                                                               // Pipe Ending - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_T_Cross, "Pipe T Cross" },                                                                       // Pipe T-Connector - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Valve, "Pipe Valve" },                                                                           // Valve - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Plantation, "Plantation" },                                                                           // Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
		{ BuildingTypes.Port, "Port" },                                                                                       // Strider Port - From this port, expeditions can be launched to search the nearby swamps for blueprints and treasure in the submerged ruins of former settlements.
		{ BuildingTypes.Press, "Press" },                                                                                     // Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Primitive_Fishing_Hut, "Primitive Fishing Hut" },                                                     // Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).
		{ BuildingTypes.Primitive_Foragers_Camp, "Primitive Forager's Camp" },                                                // Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
		{ BuildingTypes.Primitive_Herbalists_Camp, "Primitive Herbalist's Camp" },                                            // Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
		{ BuildingTypes.Primitive_Trappers_Camp, "Primitive Trapper's Camp" },                                                // Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
		{ BuildingTypes.Provisioner, "Provisioner" },                                                                         // Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Purged_Beaver_House, "Purged Beaver House" },                                                         // Purified Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Fox_House, "Purged Fox House" },                                                               // Purified Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Frog_House, "Purged Frog House" },                                                             // Purified Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Harpy_House, "Purged Harpy House" },                                                           // Purified Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Human_House, "Purged Human House" },                                                           // Purified Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Lizard_House, "Purged Lizard House" },                                                         // Purified Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Rain_Catcher, "Rain Catcher" },                                                                       // Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.
		{ BuildingTypes.Rain_Mill, "Rain Mill" },                                                                             // Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Rain_Totem, "Rain Totem" },                                                                           // Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
		{ BuildingTypes.Rain_Totem_Positive, "Rain Totem Positive" },                                                         // Converted Rain Totem - Harmony. The ritual was completed, but a faint, rhythmic thumping can still be heard coming from the totem. Decreases Hostility by 50. Counts as 4 decorations of its type.
		{ BuildingTypes.Rainpunk_Barrels, "Rainpunk Barrels" },                                                               // Rainpunk Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Rainpunk_Drill_Coal, "Rainpunk Drill - Coal" },                                                       // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Drill_Copper, "Rainpunk Drill - Copper" },                                                   // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Drill_Salt, "Rainpunk Drill - Salt" },                                                       // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Foundry, "Rainpunk Foundry" },                                                               // Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3). Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.RainpunkFactory, "RainpunkFactory" },                                                                 // Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
		{ BuildingTypes.Ranch, "Ranch" },                                                                                     // Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Reinforced_Road, "Reinforced Road" },                                                                 // Reinforced Road - A road reinforced with copper. Grants a 25% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
		{ BuildingTypes.RewardChest_T1, "RewardChest_T1" },                                                                   // Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.RewardChest_T2, "RewardChest_T2" },                                                                   // Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.RewardChest_T3, "RewardChest_T3" },                                                                   // Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.Road_Sign, "Road Sign" },                                                                             // Road Sign - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher, "Ruined Advanced Rain Catcher" },                                       // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher_no_Reward, "Ruined Advanced Rain Catcher (no reward)" },                 // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Alchemist, "Ruined Alchemist" },                                                               // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Alchemist_no_Reward, "Ruined Alchemist (no reward)" },                                         // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Apothecary, "Ruined Apothecary" },                                                             // Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Apothecary_no_Reward, "Ruined Apothecary (no reward)" },                                       // Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Artisan, "Ruined Artisan" },                                                                   // Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Artisan_no_Reward, "Ruined Artisan (no reward)" },                                             // Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Bakery, "Ruined Bakery" },                                                                     // Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Bakery_no_Reward, "Ruined Bakery (no reward)" },                                               // Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Bath_House, "Ruined Bath House" },                                                             // Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Bath_House_no_Reward, "Ruined Bath House (no reward)" },                                       // Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beanery, "Ruined Beanery" },                                                                   // Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Beanery_no_Reward, "Ruined Beanery (no reward)" },                                             // Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beaver_House, "Ruined Beaver House" },                                                         // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beaver_House_no_Reward, "Ruined Beaver House (no reward)" },                                   // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Big_Shelter, "Ruined Big Shelter" },                                                           // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Big_Shelter_no_Reward, "Ruined Big Shelter (no reward)" },                                     // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brewery, "Ruined Brewery" },                                                                   // Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brewery_no_Reward, "Ruined Brewery (no reward)" },                                             // Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brick_Oven, "Ruined Brick Oven" },                                                             // Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brick_Oven_no_Reward, "Ruined Brick Oven (no reward)" },                                       // Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brickyard, "Ruined Brickyard" },                                                               // Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brickyard_no_Reward, "Ruined Brickyard (no reward)" },                                         // Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Butcher, "Ruined Butcher" },                                                                   // Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Butcher_no_Reward, "Ruined Butcher (no reward)" },                                             // Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cannery, "Ruined Cannery" },                                                                   // Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cannery_no_Reward, "Ruined Cannery (no reward)" },                                             // Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                               // Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Carpenter_no_Reward, "Ruined Carpenter (no reward)" },                                         // Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cellar, "Ruined Cellar" },                                                                     // Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cellar_no_Reward, "Ruined Cellar (no reward)" },                                               // Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                               // Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Clan_Hall_no_Reward, "Ruined Clan Hall (no reward)" },                                         // Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                                 // Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Clay_Pit_no_Reward, "Ruined Clay Pit (no reward)" },                                           // Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cobbler, "Ruined Cobbler" },                                                                   // Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cobbler_no_Reward, "Ruined Cobbler (no reward)" },                                             // Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cookhouse, "Ruined Cookhouse" },                                                               // Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cookhouse_no_Reward, "Ruined Cookhouse (no reward)" },                                         // Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cooperage, "Ruined Cooperage" },                                                               // Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cooperage_no_Reward, "Ruined Cooperage (no reward)" },                                         // Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Crude_Workstation_no_Reward, "Ruined Crude Workstation (no reward)" },                         // Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Distillery, "Ruined Distillery" },                                                             // Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Distillery_no_Reward, "Ruined Distillery (no reward)" },                                       // Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Druid, "Ruined Druid" },                                                                       // Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Druid_no_Reward, "Ruined Druid (no reward)" },                                                 // Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Explorers_Lodge, "Ruined Explorers Lodge" },                                                   // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Explorers_Lodge_no_Reward, "Ruined Explorers Lodge (no reward)" },                             // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Farm, "Ruined Farm" },                                                                         // Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Farm_no_Reward, "Ruined Farm (no reward)" },                                                   // Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Feast_Hall_no_Reward, "Ruined Feast Hall (no reward)" },                                       // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Field_Kitchen_no_Reward, "Ruined Field Kitchen (no reward)" },                                 // Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Finesmith, "Ruined Finesmith" },                                                               // Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Finesmith_no_Reward, "Ruined Finesmith (no reward)" },                                         // Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fishing_Hut, "Ruined Fishing Hut" },                                                           // Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Fishing_Hut_no_Reward, "Ruined Fishing Hut (no reward)" },                                     // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fishing_Hut_Primitive_no_Reward, "Ruined Fishing Hut Primitive (no reward)" },                 // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                                       // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Foragers_Camp_no_Reward, "Ruined Foragers Camp (no reward)" },                                 // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Foragers_Camp_Primitive_no_Reward, "Ruined Foragers Camp Primitive (no reward)" },             // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Forum, "Ruined Forum" },                                                                       // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Forum_no_Reward, "Ruined Forum (no reward)" },                                                 // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Fox_House, "Ruined Fox House" },                                                               // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fox_House_no_Reward, "Ruined Fox House (no reward)" },                                         // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Frog_House_no_Reward, "Ruined Frog House (no reward)" },                                       // Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Furnace, "Ruined Furnace" },                                                                   // Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Furnace_no_Reward, "Ruined Furnace (no reward)" },                                             // Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Granary, "Ruined Granary" },                                                                   // Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Granary_no_Reward, "Ruined Granary (no reward)" },                                             // Granary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Greenhouse, "Ruined Greenhouse" },                                                             // Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Greenhouse_no_Reward, "Ruined Greenhouse (no reward)" },                                       // Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Grill, "Ruined Grill" },                                                                       // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grill_no_Reward, "Ruined Grill (no reward)" },                                                 // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grove, "Ruined Grove" },                                                                       // Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grove_no_Reward, "Ruined Grove (no reward)" },                                                 // Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Guild_House, "Ruined Guild House" },                                                           // Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Guild_House_no_Reward, "Ruined Guild House (no reward)" },                                     // Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harpy_House, "Ruined Harpy House" },                                                           // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harpy_House_no_Reward, "Ruined Harpy House (no reward)" },                                     // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harvester_Camp, "Ruined Harvester Camp" },                                                     // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Harvester_Camp_no_Reward, "Ruined Harvester Camp (no reward)" },                               // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herb_Garden, "Ruined Herb Garden" },                                                           // Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Herb_Garden_no_Reward, "Ruined Herb Garden (no reward)" },                                     // Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herbalist_Camp, "Ruined Herbalist Camp" },                                                     // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Herbalist_Camp_no_Reward, "Ruined Herbalist Camp (no reward)" },                               // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herbalist_Camp_Primitive_no_Reward, "Ruined Herbalist Camp primitive (no reward)" },           // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Human_House, "Ruined Human House" },                                                           // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Human_House_no_Reward, "Ruined Human House (no reward)" },                                     // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Kiln, "Ruined Kiln" },                                                                         // Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Kiln_no_Reward, "Ruined Kiln (no reward)" },                                                   // Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Leatherworks, "Ruined Leatherworks" },                                                         // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Leatherworks_no_Reward, "Ruined Leatherworks (no reward)" },                                   // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Lizard_House, "Ruined Lizard House" },                                                         // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Lizard_House_no_Reward, "Ruined Lizard House (no reward)" },                                   // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Lumbermill, "Ruined Lumbermill" },                                                             // Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Lumbermill_no_Reward, "Ruined Lumbermill (no reward)" },                                       // Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Makeshift_Post_no_Reward, "Ruined Makeshift Post (no reward)" },                               // Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Manufatory, "Ruined Manufatory" },                                                             // Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Manufatory_no_Reward, "Ruined Manufatory (no reward)" },                                       // Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Market, "Ruined Market" },                                                                     // Market - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Market_no_Reward, "Ruined Market (no reward)" },                                               // Market - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Mine_no_Reward, "Ruined Mine (no reward)" },                                                   // Mine - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Monastery, "Ruined Monastery" },                                                               // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Monastery_no_Reward, "Ruined Monastery (no reward)" },                                         // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Pantry, "Ruined Pantry" },                                                                     // Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Pantry_no_Reward, "Ruined Pantry (no reward)" },                                               // Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Plantation, "Ruined Plantation" },                                                             // Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Plantation_no_Reward, "Ruined Plantation (no reward)" },                                       // Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Press, "Ruined Press" },                                                                       // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Press_no_Reward, "Ruined Press (no reward)" },                                                 // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Provisioner, "Ruined Provisioner" },                                                           // Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Provisioner_no_Reward, "Ruined Provisioner (no reward)" },                                     // Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Rain_Catcher_no_Reward, "Ruined Rain Catcher (no reward)" },                                   // Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Rainmill, "Ruined Rainmill" },                                                                 // Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Rainmill_no_Reward, "Ruined Rainmill (no reward)" },                                           // Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Ranch, "Ruined Ranch" },                                                                       // Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Ranch_no_Reward, "Ruined Ranch (no reward)" },                                                 // Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Scribe, "Ruined Scribe" },                                                                     // Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Scribe_no_Reward, "Ruined Scribe (no reward)" },                                               // Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Sewer, "Ruined Sewer" },                                                                       // Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Sewer_no_Reward, "Ruined Sewer (no reward)" },                                                 // Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Shelter, "Ruined Shelter" },                                                                   // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Shelter_no_Reward, "Ruined Shelter (no reward)" },                                             // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_SmallFarm, "Ruined SmallFarm" },                                                               // Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_SmallFarm_no_Reward, "Ruined SmallFarm (no reward)" },                                         // Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smelter, "Ruined Smelter" },                                                                   // Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smelter_no_Reward, "Ruined Smelter (no reward)" },                                             // Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smithy, "Ruined Smithy" },                                                                     // Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smithy_no_Reward, "Ruined Smithy (no reward)" },                                               // Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smokehouse, "Ruined Smokehouse" },                                                             // Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smokehouse_no_Reward, "Ruined Smokehouse (no reward)" },                                       // Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Stamping_Mill, "Ruined Stamping Mill" },                                                       // Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Stamping_Mill_no_Reward, "Ruined Stamping Mill (no reward)" },                                 // Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Stonecutter_Camp, "Ruined Stonecutter Camp" },                                                 // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Stonecutter_Camp_no_Reward, "Ruined Stonecutter Camp (no reward)" },                           // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Storage, "Ruined Storage" },                                                                   // Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Storage_no_Reward, "Ruined Storage (no reward)" },                                             // Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Supplier, "Ruined Supplier" },                                                                 // Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Supplier_no_Reward, "Ruined Supplier (no reward)" },                                           // Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tavern, "Ruined Tavern" },                                                                     // Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tavern_no_Reward, "Ruined Tavern (no reward)" },                                               // Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tea_Doctor, "Ruined Tea Doctor" },                                                             // Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tea_Doctor_no_Reward, "Ruined Tea Doctor (no reward)" },                                       // Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tea_House, "Ruined Tea House" },                                                               // Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tea_House_no_Reward, "Ruined Tea House (no reward)" },                                         // Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Temple, "Ruined Temple" },                                                                     // Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Temple_no_Reward, "Ruined Temple (no reward)" },                                               // Temple - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Temporary_Engineering_Station_no_Reward, "Ruined Temporary Engineering Station (no reward)" }, // Field Engineering Station - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tinctury, "Ruined Tinctury" },                                                                 // Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tinctury_no_Reward, "Ruined Tinctury (no reward)" },                                           // Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tinkerer, "Ruined Tinkerer" },                                                                 // Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tinkerer_no_Reward, "Ruined Tinkerer (no reward)" },                                           // Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Toolshop, "Ruined Toolshop" },                                                                 // Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Toolshop_no_Reward, "Ruined Toolshop (no reward)" },                                           // Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trading_Post_no_Reward, "Ruined Trading Post (no reward)" },                                   // Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trappers_Camp, "Ruined Trappers Camp" },                                                       // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Trappers_Camp_no_Reward, "Ruined Trappers Camp (no reward)" },                                 // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trappers_Camp_Primitive_no_Reward, "Ruined Trappers Camp Primitive (no reward)" },             // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Weaver, "Ruined Weaver" },                                                                     // Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Weaver_no_Reward, "Ruined Weaver (no reward)" },                                               // Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Woodcutters_Camp, "Ruined Woodcutters Camp" },                                                 // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Woodcutters_Camp_no_Reward, "Ruined Woodcutters Camp (no reward)" },                           // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Workshop, "Ruined Workshop" },                                                                 // Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Workshop_no_Reward, "Ruined Workshop (no reward)" },                                           // Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Sacrifice_Totem, "Sacrifice Totem" },                                                                 // Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
		{ BuildingTypes.Sacrifice_Totem_Positive, "Sacrifice Totem Positive" },                                               // Converted Totem of Denial - Harmony. Repurposed Fishmen magic can be very useful... but let's hope we don't suffer the same fate as the priestess Ysabelle. Increases Global Resolve by +3. Counts as 4 decorations of its type.
		{ BuildingTypes.Scarlet_Decor, "Scarlet Decor" },                                                                     // Thorny Reed - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Scorpion_1, "Scorpion 1" },                                                                           // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Scorpion_2, "Scorpion 2" },                                                                           // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Scorpion_3, "Scorpion 3" },                                                                           // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Scribe, "Scribe" },                                                                                   // Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Seal, "Seal" },                                                                                       // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Seal_Guidepost, "Seal Guidepost" },                                                                   // Guidance Stone - It is not known where the guidance stones came from or what their original purpose was, but they are imbued with magic and always point in the direction of a nearby seal.
		{ BuildingTypes.Seal_High_Diff, "Seal High Diff" },                                                                   // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Seal_Low_Diff, "Seal Low Diff" },                                                                     // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Sealed_Biome_Shrine, "Sealed Biome Shrine" },                                                         // Beacon Tower - A powerful, ancient structure that allows you to summon aid directly from the Citadel. Grants access to three types of temporary support abilities.
		{ BuildingTypes.SealedTomb_T1, "SealedTomb_T1" },                                                                     // Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
		{ BuildingTypes.Shelter, "Shelter" },                                                                                 // Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 3 residents.
		{ BuildingTypes.Signboard, "Signboard" },                                                                             // Signboard - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Small_Hearth, "Small Hearth" },                                                                       // Ancient Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
		{ BuildingTypes.SmallFarm, "SmallFarm" },                                                                             // Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).
		{ BuildingTypes.Smelter, "Smelter" },                                                                                 // Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Smithy, "Smithy" },                                                                                   // Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Smokehouse, "Smokehouse" },                                                                           // Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Snake_1, "Snake 1" },                                                                                 // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Snake_2, "Snake 2" },                                                                                 // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Snake_3, "Snake 3" },                                                                                 // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Spider_1, "Spider 1" },                                                                               // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Spider_2, "Spider 2" },                                                                               // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Spider_3, "Spider 3" },                                                                               // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Stamping_Mill, "Stamping Mill" },                                                                     // Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Stone_Fence, "Stone Fence" },                                                                         // Stone Fence - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Stone_Fence_Corner, "Stone Fence Corner" },                                                           // Stone Fence Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Stonecutters_Camp, "Stonecutter's Camp" },                                                            // Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
		{ BuildingTypes.Storage_buildable, "Storage (buildable)" },                                                           // Small Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
		{ BuildingTypes.Stormbird_Positive, "Stormbird Positive" },                                                           // Tamed Stormbird - Harmony. The nest of a tamed Stormbird. It provides 5 "[food raw] eggs" Eggs per minute and increases Harpy Resolve by +3. Counts as 16 decorations of its type.
		{ BuildingTypes.Supplier, "Supplier" },                                                                               // Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Tavern, "Tavern" },                                                                                   // Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
		{ BuildingTypes.Tea_Doctor, "Tea Doctor" },                                                                           // Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
		{ BuildingTypes.Tea_House, "Tea House" },                                                                             // Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Temple, "Temple" },                                                                                   // Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.
		{ BuildingTypes.Temporary_Engineering_Station, "Temporary Engineering Station" },                                     // Field Engineering Station - A makeshift workstation designed by the Brass Order. It’s far simpler than their sophisticated machinery back in the Citadel, but it’ll get the job done. Can produce:  [we] fuel core Enriched Fuel (grade1)
		{ BuildingTypes.Temporary_Hearth_buildable, "Temporary Hearth (buildable)" },                                         // Small Hearth - Reduces Hostility and serves as a meeting place. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will use another Hearth instead. Can't be built too close to other Hearths.
		{ BuildingTypes.Temporary_Hearth_not_buildable, "Temporary Hearth (not-buildable)" },                                 // Small Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
		{ BuildingTypes.Termite_Burrow, "Termite Burrow" },                                                                   // Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
		{ BuildingTypes.Termite_Burrow_Positive, "Termite Burrow Positive" },                                                 // Termite Nest - Harmony. A contained stonetooth termite burrow. Provides 5 "[food raw] insects" Insects per minute. Counts as 4 decorations of its type.
		{ BuildingTypes.TI_AncientShrine_T1, "TI AncientShrine_T1" },                                                         // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ BuildingTypes.Tinctury, "Tinctury" },                                                                               // Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1).  Rain engine: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Tinkerer, "Tinkerer" },                                                                               // Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Toolshop, "Toolshop" },                                                                               // Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2).  Rain engine: "[water] storm water" Storm Water.
		{ BuildingTypes.Tower, "Tower" },                                                                                     // Wall Crossing - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Town_Board, "Town Board" },                                                                           // Town Board - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.Traders_Cemetery, "Traders Cemetery" },                                                               // Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
		{ BuildingTypes.Trading_Post, "Trading Post" },                                                                       // Trading Post - Traders from the Smoldering City can station here and offer their wares.
		{ BuildingTypes.Trappers_Camp, "Trapper's Camp" },                                                                    // Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).
		{ BuildingTypes.Umbrella, "Umbrella" },                                                                               // Umbrella - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Wall, "Wall" },                                                                                       // Wall - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Wall_Corner, "Wall Corner" },                                                                         // Wall Corner - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.War_Beast_Cage, "War Beast Cage" },                                                                   // Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
		{ BuildingTypes.Water_Barrels, "Water Barrels" },                                                                     // Water Barrels - Comfort. Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Water_Extractor, "Water Extractor" },                                                                 // Geyser Pump - Used to extract and pump infused rainwater through underground pipes to production buildings, where it can be used to increase productivity. Must be placed on an active geyser. Has a tank capacity of 50.
		{ BuildingTypes.Water_Shrine, "Water Shrine" },                                                                       // Water Shrine - Aesthetics. The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 9 decorations of its type.
		{ BuildingTypes.Weaver, "Weaver" },                                                                                   // Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1).  Rain engine: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Well, "Well" },                                                                                       // Overgrown Well - Harmony. Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.White_Stag, "White Stag" },                                                                           // Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.White_Treasure_Stag, "White Treasure Stag" },                                                         // Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Wildfire, "Wildfire" },                                                                               // Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.
		{ BuildingTypes.Woodcutters_Camp, "Woodcutters Camp" },                                                               // Woodcutters' Camp - Starting point for woodcutters going out into the wild to cut down trees.
		{ BuildingTypes.Workshop, "Workshop" },                                                                               // Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0).  Rain engine: "[water] storm water" Storm Water.

	};
}
