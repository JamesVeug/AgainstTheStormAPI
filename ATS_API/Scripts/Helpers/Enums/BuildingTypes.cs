using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Buildings;

namespace ATS_API.Helpers;

// Generated using Version 1.5.5R
public enum BuildingTypes
{
	Unknown = -1,
	None,
	
	/// <summary>
	/// Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
	/// </summary>
	/// <name>Advanced Rain Catcher</name>
	Advanced_Rain_Catcher,

	/// <summary>
	/// Garden - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Aestherics 2x2 - Garden</name>
	Aestherics_2x2_Garden,

	/// <summary>
	/// Makeshift Extractor - <color=#8AAFFD>Aesthetics.</color> A curious piece of improvised technology. It extracts moisture from the soil around it and converts it into 10 "[water] clearance water" Clearance Water per minute. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Aestherics 2x2 - Groundwater Extractor</name>
	Aestherics_2x2_Groundwater_Extractor,

	/// <summary>
	/// Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Alchemist Hut</name>
	Alchemist_Hut,

	/// <summary>
	/// Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
	/// </summary>
	/// <name>Altar</name>
	Altar,

	/// <summary>
	/// Ancient Tombstone - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Ancient Gravestone</name>
	Ancient_Gravestone,

	/// <summary>
	/// Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
	/// </summary>
	/// <name>AncientBurrialGrounds</name>
	AncientBurrialGrounds,

	/// <summary>
	/// Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
	/// </summary>
	/// <name>AncientGate</name>
	AncientGate,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>AncientShrine_T1</name>
	AncientShrine_T1,

	/// <summary>
	/// Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
	/// </summary>
	/// <name>AncientTemple</name>
	AncientTemple,

	/// <summary>
	/// Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
	/// </summary>
	/// <name>Angry Ghost 1</name>
	Angry_Ghost_1,

	/// <summary>
	/// Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
	/// </summary>
	/// <name>Angry Ghost 10</name>
	Angry_Ghost_10,

	/// <summary>
	/// Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
	/// </summary>
	/// <name>Angry Ghost 14</name>
	Angry_Ghost_14,

	/// <summary>
	/// Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
	/// </summary>
	/// <name>Angry Ghost 15</name>
	Angry_Ghost_15,

	/// <summary>
	/// Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
	/// </summary>
	/// <name>Angry Ghost 16</name>
	Angry_Ghost_16,

	/// <summary>
	/// Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
	/// </summary>
	/// <name>Angry Ghost 17</name>
	Angry_Ghost_17,

	/// <summary>
	/// Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
	/// </summary>
	/// <name>Angry Ghost 18</name>
	Angry_Ghost_18,

	/// <summary>
	/// Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
	/// </summary>
	/// <name>Angry Ghost 19</name>
	Angry_Ghost_19,

	/// <summary>
	/// Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
	/// </summary>
	/// <name>Angry Ghost 2</name>
	Angry_Ghost_2,

	/// <summary>
	/// Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
	/// </summary>
	/// <name>Angry Ghost 20</name>
	Angry_Ghost_20,

	/// <summary>
	/// Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
	/// </summary>
	/// <name>Angry Ghost 21</name>
	Angry_Ghost_21,

	/// <summary>
	/// Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
	/// </summary>
	/// <name>Angry Ghost 24</name>
	Angry_Ghost_24,

	/// <summary>
	/// Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
	/// </summary>
	/// <name>Angry Ghost 31</name>
	Angry_Ghost_31,

	/// <summary>
	/// Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
	/// </summary>
	/// <name>Angry Ghost 32</name>
	Angry_Ghost_32,

	/// <summary>
	/// Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
	/// </summary>
	/// <name>Angry Ghost 34</name>
	Angry_Ghost_34,

	/// <summary>
	/// Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
	/// </summary>
	/// <name>Angry Ghost 4</name>
	Angry_Ghost_4,

	/// <summary>
	/// Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
	/// </summary>
	/// <name>Angry Ghost 41</name>
	Angry_Ghost_41,

	/// <summary>
	/// Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
	/// </summary>
	/// <name>Angry Ghost 5</name>
	Angry_Ghost_5,

	/// <summary>
	/// Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
	/// </summary>
	/// <name>Angry Ghost 6</name>
	Angry_Ghost_6,

	/// <summary>
	/// Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
	/// </summary>
	/// <name>Angry Ghost 9</name>
	Angry_Ghost_9,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>AngryGhostChest_T1</name>
	AngryGhostChest_T1,

	/// <summary>
	/// Anvil - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Anvil</name>
	Anvil,

	/// <summary>
	/// Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Apothecary</name>
	Apothecary,

	/// <summary>
	/// Ancient Arch - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
	/// </summary>
	/// <name>Arch</name>
	Arch,

	/// <summary>
	/// Smoldering Scorpion - <color=#D6E54A>Harmony.</color> Legend has it that they once inhabited the top of the mountain on which the Smoldering City now stands. The Queen banished them, but it is said that some of them still hibernate somewhere on the outskirts of the kingdom.  Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Scorpion Positive</name>
	Archaeology_Scorpion_Positive,

	/// <summary>
	/// Sea Serpent - <color=#D6E54A>Harmony.</color> The anatomical features of this beast indicate an adaptation to life in water, as well as on land. Due to this, sea serpents are excellent hunters, preying on lonely caravans and lost settlers. The preserved remains show traces of Blightrot. Could it be that these creatures have brought this plague to the surface when emerging from the depths of the ocean? Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Snake Positive</name>
	Archaeology_Snake_Positive,

	/// <summary>
	/// Sealed Spider - <color=#D6E54A>Harmony.</color> It is said that these creatures were once the faithful servants of the Sealed Ones, and like their masters, they were trapped underground for eternity. But even to this day, miners tell tales of giant spiders crawling up from deep caverns, preying on unsuspecting victims. Legend has it that these vile beasts fear only one thing - the Holy Flame. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Archaeology Spider Positive</name>
	Archaeology_Spider_Positive,

	/// <summary>
	/// Archaeologist's Office - A building designed to help you study the past. Can be upgraded to locate archaeological discoveries or improve the settlement's exploration capabilities. 
	/// </summary>
	/// <name>Archeology office</name>
	Archeology_Office,

	/// <summary>
	/// Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Artisan</name>
	Artisan,

	/// <summary>
	/// Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Bakery</name>
	Bakery,

	/// <summary>
	/// Bench - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Bank</name>
	Bank,

	/// <summary>
	/// Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Barrels</name>
	Barrels,

	/// <summary>
	/// Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
	/// </summary>
	/// <name>Bath House</name>
	Bath_House,

	/// <summary>
	/// Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Beanery</name>
	Beanery,

	/// <summary>
	/// Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Beaver House</name>
	Beaver_House,

	/// <summary>
	/// Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
	/// </summary>
	/// <name>BeaverBattleground_T1</name>
	BeaverBattleground_T1,

	/// <summary>
	/// Big Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 6 residents.
	/// </summary>
	/// <name>Big Shelter</name>
	Big_Shelter,

	/// <summary>
	/// Cornerstone Forge - An ancient forge used by the Crown for generations to craft cornerstones from Thunderblight Shards. Now it stands abandoned, its fires long cold, but its legacy still felt in the region.
	/// </summary>
	/// <name>Biome Perk Crafter</name>
	Biome_Perk_Crafter,

	/// <summary>
	/// Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Black Stag</name>
	Black_Stag,

	/// <summary>
	/// Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Black Treasure Stag</name>
	Black_Treasure_Stag,

	/// <summary>
	/// Blight Post - A specialized building dedicated to fighting Blightrot. Blight Fighters will prepare "blight fuel" Purging Fire during drizzle and clearance seasons, and use it to burn Blightrot Cysts during the storm.
	/// </summary>
	/// <name>Blight Post</name>
	Blight_Post,

	/// <summary>
	/// Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
	/// </summary>
	/// <name>Blightrot</name>
	Blightrot,

	/// <summary>
	/// Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
	/// </summary>
	/// <name>Blightrot Cauldron</name>
	Blightrot_Cauldron,

	/// <summary>
	/// Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
	/// </summary>
	/// <name>Blightrot - Clone</name>
	Blightrot_Clone,

	/// <summary>
	/// Bonfire - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Bonfire</name>
	Bonfire,

	/// <summary>
	/// Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Brewery</name>
	Brewery,

	/// <summary>
	/// Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Brick Oven</name>
	Brick_Oven,

	/// <summary>
	/// Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Brickyard</name>
	Brickyard,

	/// <summary>
	/// Bush - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Bush</name>
	Bush,

	/// <summary>
	/// Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Butcher</name>
	Butcher,

	/// <summary>
	/// Cages - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Cages</name>
	Cages,

	/// <summary>
	/// Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
	/// </summary>
	/// <name>Calm Ghost 11</name>
	Calm_Ghost_11,

	/// <summary>
	/// Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
	/// </summary>
	/// <name>Calm Ghost 12</name>
	Calm_Ghost_12,

	/// <summary>
	/// Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
	/// </summary>
	/// <name>Calm Ghost 13</name>
	Calm_Ghost_13,

	/// <summary>
	/// Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
	/// </summary>
	/// <name>Calm Ghost 22</name>
	Calm_Ghost_22,

	/// <summary>
	/// Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
	/// </summary>
	/// <name>Calm Ghost 23</name>
	Calm_Ghost_23,

	/// <summary>
	/// Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
	/// </summary>
	/// <name>Calm Ghost 25</name>
	Calm_Ghost_25,

	/// <summary>
	/// Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
	/// </summary>
	/// <name>Calm Ghost 26</name>
	Calm_Ghost_26,

	/// <summary>
	/// Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
	/// </summary>
	/// <name>Calm Ghost 27</name>
	Calm_Ghost_27,

	/// <summary>
	/// Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
	/// </summary>
	/// <name>Calm Ghost 28</name>
	Calm_Ghost_28,

	/// <summary>
	/// Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
	/// </summary>
	/// <name>Calm Ghost 29</name>
	Calm_Ghost_29,

	/// <summary>
	/// Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
	/// </summary>
	/// <name>Calm Ghost 3</name>
	Calm_Ghost_3,

	/// <summary>
	/// Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
	/// </summary>
	/// <name>Calm Ghost 30</name>
	Calm_Ghost_30,

	/// <summary>
	/// Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
	/// </summary>
	/// <name>Calm Ghost 33</name>
	Calm_Ghost_33,

	/// <summary>
	/// Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
	/// </summary>
	/// <name>Calm Ghost 35</name>
	Calm_Ghost_35,

	/// <summary>
	/// Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
	/// </summary>
	/// <name>Calm Ghost 36</name>
	Calm_Ghost_36,

	/// <summary>
	/// Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
	/// </summary>
	/// <name>Calm Ghost 38</name>
	Calm_Ghost_38,

	/// <summary>
	/// Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
	/// </summary>
	/// <name>Calm Ghost 39</name>
	Calm_Ghost_39,

	/// <summary>
	/// Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
	/// </summary>
	/// <name>Calm Ghost 40</name>
	Calm_Ghost_40,

	/// <summary>
	/// Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
	/// </summary>
	/// <name>Calm Ghost 7</name>
	Calm_Ghost_7,

	/// <summary>
	/// Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
	/// </summary>
	/// <name>Calm Ghost 8</name>
	Calm_Ghost_8,

	/// <summary>
	/// Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
	/// </summary>
	/// <name>CalmGhostChest_T1</name>
	CalmGhostChest_T1,

	/// <summary>
	/// Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T1</name>
	Camp_T1,

	/// <summary>
	/// Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
	/// </summary>
	/// <name>Camp_T2</name>
	Camp_T2,

	/// <summary>
	/// Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Cannery</name>
	Cannery,

	/// <summary>
	/// Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T1</name>
	Caravan_T1,

	/// <summary>
	/// Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
	/// </summary>
	/// <name>Caravan_T2</name>
	Caravan_T2,

	/// <summary>
	/// Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Carpenter</name>
	Carpenter,

	/// <summary>
	/// Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Cellar</name>
	Cellar,

	/// <summary>
	/// Chest - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Chest</name>
	Chest,

	/// <summary>
	/// Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
	/// </summary>
	/// <name>Clan Hall</name>
	Clan_Hall,

	/// <summary>
	/// Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2)
	/// </summary>
	/// <name>Clay Pit Workshop</name>
	Clay_Pit_Workshop,

	/// <summary>
	/// Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Clothier</name>
	Clothier,

	/// <summary>
	/// Saltwater Pitcher Plant - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Coastal Grove Plant</name>
	Coastal_Grove_Plant,

	/// <summary>
	/// Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Cobbler</name>
	Cobbler,

	/// <summary>
	/// Park - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Comfort 2x2 - Park</name>
	Comfort_2x2_Park,

	/// <summary>
	/// Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Cookhouse</name>
	Cookhouse,

	/// <summary>
	/// Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Cooperage</name>
	Cooperage,

	/// <summary>
	/// Coral Growth - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Coral Decor</name>
	Coral_Decor,

	/// <summary>
	/// Fence Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>CornerFence</name>
	CornerFence,

	/// <summary>
	/// Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
	/// </summary>
	/// <name>Corrupted Caravan</name>
	Corrupted_Caravan,

	/// <summary>
	/// Crates - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Crates</name>
	Crates,

	/// <summary>
	/// Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Crude Workstation</name>
	Crude_Workstation,

	/// <summary>
	/// Clay Node (Large) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClayBig</name>
	DebugNode_ClayBig,

	/// <summary>
	/// Clay Node (Small) - Soil infused with the essence of the rain.
	/// </summary>
	/// <name>DebugNode_ClaySmall</name>
	DebugNode_ClaySmall,

	/// <summary>
	/// Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushBig</name>
	DebugNode_DewberryBushBig,

	/// <summary>
	/// Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
	/// </summary>
	/// <name>DebugNode_DewberryBushSmall</name>
	DebugNode_DewberryBushSmall,

	/// <summary>
	/// Flax Field (Large) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxBig</name>
	DebugNode_FlaxBig,

	/// <summary>
	/// Flax Field (Small) - Resilient plants that are perfect for cloth-making.
	/// </summary>
	/// <name>DebugNode_FlaxSmall</name>
	DebugNode_FlaxSmall,

	/// <summary>
	/// Herb Node (Large) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsBig</name>
	DebugNode_HerbsBig,

	/// <summary>
	/// Herb Node (Small) - A dense shrub, full of many useful plant species.
	/// </summary>
	/// <name>DebugNode_HerbsSmall</name>
	DebugNode_HerbsSmall,

	/// <summary>
	/// Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherBig</name>
	DebugNode_LeechBroodmotherBig,

	/// <summary>
	/// Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
	/// </summary>
	/// <name>DebugNode_LeechBroodmotherSmall</name>
	DebugNode_LeechBroodmotherSmall,

	/// <summary>
	/// Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteGrain</name>
	DebugNode_Marshlands_InfiniteGrain,

	/// <summary>
	/// Dead Leviathan - A giant, dead beast. How did it get here?
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMeat</name>
	DebugNode_Marshlands_InfiniteMeat,

	/// <summary>
	/// Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
	/// </summary>
	/// <name>DebugNode_Marshlands_InfiniteMushroom</name>
	DebugNode_Marshlands_InfiniteMushroom,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomBig</name>
	DebugNode_MarshlandsMushroomBig,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MarshlandsMushroomSmall</name>
	DebugNode_MarshlandsMushroomSmall,

	/// <summary>
	/// Moss Broccoli Patch (Large) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliBig</name>
	DebugNode_MossBroccoliBig,

	/// <summary>
	/// Moss Broccoli Patch (Small) - An edible and tasty type of moss.
	/// </summary>
	/// <name>DebugNode_MossBroccoliSmall</name>
	DebugNode_MossBroccoliSmall,

	/// <summary>
	/// Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomBig</name>
	DebugNode_MushroomBig,

	/// <summary>
	/// Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
	/// </summary>
	/// <name>DebugNode_MushroomSmall</name>
	DebugNode_MushroomSmall,

	/// <summary>
	/// Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedBig</name>
	DebugNode_ReedBig,

	/// <summary>
	/// Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
	/// </summary>
	/// <name>DebugNode_ReedSmall</name>
	DebugNode_ReedSmall,

	/// <summary>
	/// Root Node (Large) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsBig</name>
	DebugNode_RootsBig,

	/// <summary>
	/// Root Node (Small) - A tangled net of living vines.
	/// </summary>
	/// <name>DebugNode_RootsSmall</name>
	DebugNode_RootsSmall,

	/// <summary>
	/// Sea Marrow Node (Large) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowBig</name>
	DebugNode_SeaMarrowBig,

	/// <summary>
	/// Sea Marrow Node (Small) - Ancient fossils, rich in resources.
	/// </summary>
	/// <name>DebugNode_SeaMarrowSmall</name>
	DebugNode_SeaMarrowSmall,

	/// <summary>
	/// Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherBig</name>
	DebugNode_SnailBroodmotherBig,

	/// <summary>
	/// Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
	/// </summary>
	/// <name>DebugNode_SnailBroodmotherSmall</name>
	DebugNode_SnailBroodmotherSmall,

	/// <summary>
	/// Snake Nest (Large) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestBig</name>
	DebugNode_SnakeNestBig,

	/// <summary>
	/// Snake Nest (Small) - A dangerous, but rich source of food and leather.
	/// </summary>
	/// <name>DebugNode_SnakeNestSmall</name>
	DebugNode_SnakeNestSmall,

	/// <summary>
	/// Stone Node (Large) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneBig</name>
	DebugNode_StoneBig,

	/// <summary>
	/// Stone Node (Small) - Stones, weathered by the everlasting rain.
	/// </summary>
	/// <name>DebugNode_StoneSmall</name>
	DebugNode_StoneSmall,

	/// <summary>
	/// Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestBig</name>
	DebugNode_StormbirdNestBig,

	/// <summary>
	/// Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
	/// </summary>
	/// <name>DebugNode_StormbirdNestSmall</name>
	DebugNode_StormbirdNestSmall,

	/// <summary>
	/// Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatBig</name>
	DebugNode_SwampWheatBig,

	/// <summary>
	/// Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
	/// </summary>
	/// <name>DebugNode_SwampWheatSmall</name>
	DebugNode_SwampWheatSmall,

	/// <summary>
	/// Wormtongue Nest (Large) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestBig</name>
	DebugNode_WormtongueNestBig,

	/// <summary>
	/// Wormtongue Nest (Small) - A nest full of tasty wormtongues.
	/// </summary>
	/// <name>DebugNode_WormtongueNestSmall</name>
	DebugNode_WormtongueNestSmall,

	/// <summary>
	/// Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
	/// </summary>
	/// <name>Decay Altar</name>
	Decay_Altar,

	/// <summary>
	/// Converted Altar of Decay - <color=#D6E54A>Harmony.</color> Bloody sacrifices delight the evil presence. Forbidden rituals at the Altar of Decay reduce Hostility by 20 points every time a villager dies or leaves. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Decay Altar Positive</name>
	Decay_Altar_Positive,

	/// <summary>
	/// Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Distillery</name>
	Distillery,

	/// <summary>
	/// Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Druid</name>
	Druid,

	/// <summary>
	/// Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
	/// </summary>
	/// <name>Escaped Convicts</name>
	Escaped_Convicts,

	/// <summary>
	/// Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
	/// </summary>
	/// <name>Explorers Lodge</name>
	Explorers_Lodge,

	/// <summary>
	/// Farm Field - Can only be placed on fertile soil. Requires a Small Farm, Plantation, Herb Garden, Forester's Hut, or Homestead nearby to produce crops.
	/// </summary>
	/// <name>Farmfield</name>
	Farmfield,

	/// <summary>
	/// Fence - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fence</name>
	Fence,

	/// <summary>
	/// Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Field Kitchen</name>
	Field_Kitchen,

	/// <summary>
	/// Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Finesmith</name>
	Finesmith,

	/// <summary>
	/// Fire Shrine - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fire Shrine</name>
	Fire_Shrine,

	/// <summary>
	/// Fish Mount - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fish</name>
	Fish,

	/// <summary>
	/// Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
	/// </summary>
	/// <name>Fishing Hut</name>
	Fishing_Hut,

	/// <summary>
	/// Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
	/// </summary>
	/// <name>Fishmen Cave</name>
	Fishmen_Cave,

	/// <summary>
	/// Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
	/// </summary>
	/// <name>Fishmen Lighthouse</name>
	Fishmen_Lighthouse,

	/// <summary>
	/// Converted Fishmen Lighthouse - <color=#D6E54A>Harmony.</color> A tall bone structure built by the Fishmen. It has been repurposed and now provides 5 "[crafting] sea marrow" Sea Marrow per minute. Counts as 16 decorations of its type.
	/// </summary>
	/// <name>Fishmen Lighthouse Positive</name>
	Fishmen_Lighthouse_Positive,

	/// <summary>
	/// Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
	/// </summary>
	/// <name>Fishmen Outpost</name>
	Fishmen_Outpost,

	/// <summary>
	/// Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
	/// </summary>
	/// <name>Fishmen Soothsayer</name>
	Fishmen_Soothsayer,

	/// <summary>
	/// Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
	/// </summary>
	/// <name>Fishmen Totem</name>
	Fishmen_Totem,

	/// <summary>
	/// Flawless Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3). Has improved production.Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Flawless Brewery</name>
	Flawless_Brewery,

	/// <summary>
	/// Flawless Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3). Has improved production.Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Flawless Cellar</name>
	Flawless_Cellar,

	/// <summary>
	/// Flawless Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Flawless Cooperage</name>
	Flawless_Cooperage,

	/// <summary>
	/// Flawless Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Flawless Druid</name>
	Flawless_Druid,

	/// <summary>
	/// Flawless Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Flawless Leatherworks</name>
	Flawless_Leatherworks,

	/// <summary>
	/// Flawless Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Flawless Rain Mill</name>
	Flawless_Rain_Mill,

	/// <summary>
	/// Flawless Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Flawless Smelter</name>
	Flawless_Smelter,

	/// <summary>
	/// Flower Bed - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Flower Bed</name>
	Flower_Bed,

	/// <summary>
	/// Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
	/// </summary>
	/// <name>Forager's Camp</name>
	Foragers_Camp,

	/// <summary>
	/// Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
	/// </summary>
	/// <name>ForsakenCrypt</name>
	ForsakenCrypt,

	/// <summary>
	/// Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
	/// </summary>
	/// <name>Forum</name>
	Forum,

	/// <summary>
	/// Marble Fountain - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Fountain</name>
	Fountain,

	/// <summary>
	/// Overgrown Fence - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fox Fence</name>
	Fox_Fence,

	/// <summary>
	/// Overgrown Fence Corner - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Fox Fence Corner</name>
	Fox_Fence_Corner,

	/// <summary>
	/// Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Fox House</name>
	Fox_House,

	/// <summary>
	/// Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
	/// </summary>
	/// <name>FoxBattleground_T1</name>
	FoxBattleground_T1,

	/// <summary>
	/// Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Frog House</name>
	Frog_House,

	/// <summary>
	/// Evergreen Shrub - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Frog Tree</name>
	Frog_Tree,

	/// <summary>
	/// Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
	/// </summary>
	/// <name>FrogBattleground_T1</name>
	FrogBattleground_T1,

	/// <summary>
	/// Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
	/// </summary>
	/// <name>Fuming Machinery</name>
	Fuming_Machinery,

	/// <summary>
	/// Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Furnace</name>
	Furnace,

	/// <summary>
	/// Gate - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
	/// </summary>
	/// <name>Gate</name>
	Gate,

	/// <summary>
	/// Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
	/// </summary>
	/// <name>Giant Stormbird</name>
	Giant_Stormbird,

	/// <summary>
	/// Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
	/// </summary>
	/// <name>Glade Trader - The Hermit</name>
	Glade_Trader_The_Hermit,

	/// <summary>
	/// Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
	/// </summary>
	/// <name>Glade Trader - The Seer</name>
	Glade_Trader_The_Seer,

	/// <summary>
	/// Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
	/// </summary>
	/// <name>Glade Trader - The Shaman</name>
	Glade_Trader_The_Shaman,

	/// <summary>
	/// Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>Gold Stag</name>
	Gold_Stag,

	/// <summary>
	/// Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>Gold Treasure Stag</name>
	Gold_Treasure_Stag,

	/// <summary>
	/// Golden Leaf Plant - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Golden Leaf</name>
	Golden_Leaf,

	/// <summary>
	/// Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Granary</name>
	Granary,

	/// <summary>
	/// Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
	/// </summary>
	/// <name>Greenhouse Workshop</name>
	Greenhouse_Workshop,

	/// <summary>
	/// Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Grill</name>
	Grill,

	/// <summary>
	/// Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
	/// </summary>
	/// <name>Grove</name>
	Grove,

	/// <summary>
	/// Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
	/// </summary>
	/// <name>Guild House</name>
	Guild_House,

	/// <summary>
	/// Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed Herb Garden</name>
	Hallowed_Herb_Garden,

	/// <summary>
	/// Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
	/// </summary>
	/// <name>Hallowed SmallFarm</name>
	Hallowed_SmallFarm,

	/// <summary>
	/// Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
	/// </summary>
	/// <name>Harmony Spirit Altar</name>
	Harmony_Spirit_Altar,

	/// <summary>
	/// Converted Harmony Spirit Altar - <color=#D6E54A>Harmony.</color> When your villagers' needs are met, Harmony is fostered. Each unique service building adds 2 to Global Resolve. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Harmony Spirit Altar Positive</name>
	Harmony_Spirit_Altar_Positive,

	/// <summary>
	/// Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Harpy House</name>
	Harpy_House,

	/// <summary>
	/// Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
	/// </summary>
	/// <name>HarpyBattleground_T1</name>
	HarpyBattleground_T1,

	/// <summary>
	/// Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
	/// </summary>
	/// <name>Harvester Camp</name>
	Harvester_Camp,

	/// <summary>
	/// Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Beaver House</name>
	Haunted_Ruined_Beaver_House,

	/// <summary>
	/// Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Brewery</name>
	Haunted_Ruined_Brewery,

	/// <summary>
	/// Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cellar</name>
	Haunted_Ruined_Cellar,

	/// <summary>
	/// Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Cooperage</name>
	Haunted_Ruined_Cooperage,

	/// <summary>
	/// Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Druid</name>
	Haunted_Ruined_Druid,

	/// <summary>
	/// Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Fox House</name>
	Haunted_Ruined_Fox_House,

	/// <summary>
	/// Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Frog House</name>
	Haunted_Ruined_Frog_House,

	/// <summary>
	/// Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Guild House</name>
	Haunted_Ruined_Guild_House,

	/// <summary>
	/// Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Harpy House</name>
	Haunted_Ruined_Harpy_House,

	/// <summary>
	/// Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Herb Garden</name>
	Haunted_Ruined_Herb_Garden,

	/// <summary>
	/// Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Human House</name>
	Haunted_Ruined_Human_House,

	/// <summary>
	/// Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Leatherworks</name>
	Haunted_Ruined_Leatherworks,

	/// <summary>
	/// Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Lizard House</name>
	Haunted_Ruined_Lizard_House,

	/// <summary>
	/// Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Market</name>
	Haunted_Ruined_Market,

	/// <summary>
	/// Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Rainmill</name>
	Haunted_Ruined_Rainmill,

	/// <summary>
	/// Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined SmallFarm</name>
	Haunted_Ruined_SmallFarm,

	/// <summary>
	/// Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Smelter</name>
	Haunted_Ruined_Smelter,

	/// <summary>
	/// Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
	/// </summary>
	/// <name>Haunted Ruined Temple</name>
	Haunted_Ruined_Temple,

	/// <summary>
	/// Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
	/// </summary>
	/// <name>Herb Garden</name>
	Herb_Garden,

	/// <summary>
	/// Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Herbalist's Camp</name>
	Herbalists_Camp,

	/// <summary>
	/// Holy Guild House - A place where villagers can fulfill their need for:  Luxury,  Education. Has an additional effect. Passive effects: Guild House, The Guild's Welfare.
	/// </summary>
	/// <name>Holy Guild House</name>
	Holy_Guild_House,

	/// <summary>
	/// Holy Market - A place where villagers can fulfill their need for:  Leisure,  Treatment. Has an additional effect. Passive effects: Ale and Hearty, Market Carts.
	/// </summary>
	/// <name>Holy Market</name>
	Holy_Market,

	/// <summary>
	/// Holy Temple - A place where villagers can fulfill their need for:  Religion,  Education. Has an additional effect. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
	/// </summary>
	/// <name>Holy Temple</name>
	Holy_Temple,

	/// <summary>
	/// Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
	/// </summary>
	/// <name>Homestead</name>
	Homestead,

	/// <summary>
	/// Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Human House</name>
	Human_House,

	/// <summary>
	/// Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
	/// </summary>
	/// <name>HumanBattleground_T1</name>
	HumanBattleground_T1,

	/// <summary>
	/// Hydrant - A small storage for "blight fuel" Purging Fire. Blight Fighters will use it to restock their fuel when fighting Blightrot in the storm.
	/// </summary>
	/// <name>Hydrant</name>
	Hydrant,

	/// <summary>
	/// Industrial Chimney - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Industrial Chimney</name>
	Industrial_Chimney,

	/// <summary>
	/// Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
	/// </summary>
	/// <name>Infected Mole</name>
	Infected_Mole,

	/// <summary>
	/// Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
	/// </summary>
	/// <name>Infected Tree</name>
	Infected_Tree,

	/// <summary>
	/// River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
	/// </summary>
	/// <name>Kelpie</name>
	Kelpie,

	/// <summary>
	/// Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Kiln</name>
	Kiln,

	/// <summary>
	/// Lamp - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Lamp</name>
	Lamp,

	/// <summary>
	/// Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
	/// </summary>
	/// <name>Leaking Cauldron</name>
	Leaking_Cauldron,

	/// <summary>
	/// Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Leatherworks</name>
	Leatherworks,

	/// <summary>
	/// Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
	/// </summary>
	/// <name>Lightning Catcher</name>
	Lightning_Catcher,

	/// <summary>
	/// Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 2 inhabitants.
	/// </summary>
	/// <name>Lizard House</name>
	Lizard_House,

	/// <summary>
	/// Lizard Post - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Lizard Post</name>
	Lizard_Post,

	/// <summary>
	/// Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
	/// </summary>
	/// <name>LizardBattleground_T1</name>
	LizardBattleground_T1,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> Born in the Blightstorm, she will climb the Red Mountain. The fires beneath her feet shall hiss her name. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 1</name>
	Lore_Tablet_1,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> Though sealed beneath the muddy ground, their voices ring loud and clear. Maddening, alluring. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 2</name>
	Lore_Tablet_2,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> The true rulers of this world shall rise again and break the seals that bind them. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 3</name>
	Lore_Tablet_3,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> Envy the lesser species, for they do not yet know what lies beneath. But in time, they will understand. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 4</name>
	Lore_Tablet_4,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> It pours, yet it does not flood. As if the earth itself greedily drinks every last drop of this eternal curse. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 5</name>
	Lore_Tablet_5,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> Embrace the Eternal Rain, for it powers the engine of progress. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 6</name>
	Lore_Tablet_6,

	/// <summary>
	/// Inscribed Monolith - <color=#D6E54A>Harmony.</color> Don't let the pleasant sparking of the raindrops fool you. This is just the first sign of your flesh rotting. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Lore Tablet 7</name>
	Lore_Tablet_7,

	/// <summary>
	/// Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Lumbermill</name>
	Lumbermill,

	/// <summary>
	/// Main Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
	/// </summary>
	/// <name>Main Storage (not-buildable)</name>
	Main_Storage_not_buildable,

	/// <summary>
	/// Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Makeshift Post</name>
	Makeshift_Post,

	/// <summary>
	/// Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Manufactory</name>
	Manufactory,

	/// <summary>
	/// Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
	/// </summary>
	/// <name>Market</name>
	Market,

	/// <summary>
	/// Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
	/// </summary>
	/// <name>Merchant Ship Wreck</name>
	Merchant_Ship_Wreck,

	/// <summary>
	/// Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).
	/// </summary>
	/// <name>Mine</name>
	Mine,

	/// <summary>
	/// Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
	/// </summary>
	/// <name>Mistworm_T1</name>
	Mistworm_T1,

	/// <summary>
	/// Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
	/// </summary>
	/// <name>Mole</name>
	Mole,

	/// <summary>
	/// Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
	/// </summary>
	/// <name>Monastery</name>
	Monastery,

	/// <summary>
	/// Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
	/// </summary>
	/// <name>Monolith</name>
	Monolith,

	/// <summary>
	/// Obelisk - <color=#8AAFFD>Aesthetics.</color> The symbols carved into this monumental stone bear an eerie resemblance to the forest and corruption. Decreases Hostility by 10 points and increases the Ancient Hearth's resistance by 100.
	/// </summary>
	/// <name>Monolith Positive</name>
	Monolith_Positive,

	/// <summary>
	/// Monument of Greed - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Moument of Greed</name>
	Moument_Of_Greed,

	/// <summary>
	/// Decorative Fungus - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Mushroom Decor</name>
	Mushroom_Decor,

	/// <summary>
	/// Nightfern - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Nightfern</name>
	Nightfern,

	/// <summary>
	/// Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
	/// </summary>
	/// <name>Noxious Machinery</name>
	Noxious_Machinery,

	/// <summary>
	/// Ornate Column - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Ornate Column</name>
	Ornate_Column,

	/// <summary>
	/// Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Pantry</name>
	Pantry,

	/// <summary>
	/// Path - A simple path, doesn't cost any resources. Grants a 5% speed increase to villagers.
	/// </summary>
	/// <name>Path</name>
	Path,

	/// <summary>
	/// Paved Road - A road made out of stone. Grants a 15% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
	/// </summary>
	/// <name>Paved Road</name>
	Paved_Road,

	/// <summary>
	/// Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
	/// </summary>
	/// <name>PetrifiedTree_T1</name>
	PetrifiedTree_T1,

	/// <summary>
	/// Pipe - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe</name>
	Pipe,

	/// <summary>
	/// Pipe Cross - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Cross</name>
	Pipe_Cross,

	/// <summary>
	/// Pipe Elbow - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Elbow</name>
	Pipe_Elbow,

	/// <summary>
	/// Pipe Ending - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe End</name>
	Pipe_End,

	/// <summary>
	/// Pipe T-Connector - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe T Cross</name>
	Pipe_T_Cross,

	/// <summary>
	/// Valve - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Pipe Valve</name>
	Pipe_Valve,

	/// <summary>
	/// Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
	/// </summary>
	/// <name>Plantation</name>
	Plantation,

	/// <summary>
	/// Strider Port - From this ancient port, expeditions can be launched to search the nearby swamps for blueprints and treasure in the submerged ruins of former settlements.
	/// </summary>
	/// <name>Port</name>
	Port,

	/// <summary>
	/// Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Press</name>
	Press,

	/// <summary>
	/// Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).
	/// </summary>
	/// <name>Primitive Fishing Hut</name>
	Primitive_Fishing_Hut,

	/// <summary>
	/// Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
	/// </summary>
	/// <name>Primitive Forager's Camp</name>
	Primitive_Foragers_Camp,

	/// <summary>
	/// Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
	/// </summary>
	/// <name>Primitive Herbalist's Camp</name>
	Primitive_Herbalists_Camp,

	/// <summary>
	/// Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
	/// </summary>
	/// <name>Primitive Trapper's Camp</name>
	Primitive_Trappers_Camp,

	/// <summary>
	/// Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Provisioner</name>
	Provisioner,

	/// <summary>
	/// Purified Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Beaver House</name>
	Purged_Beaver_House,

	/// <summary>
	/// Purified Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Fox House</name>
	Purged_Fox_House,

	/// <summary>
	/// Purified Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Frog House</name>
	Purged_Frog_House,

	/// <summary>
	/// Purified Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Harpy House</name>
	Purged_Harpy_House,

	/// <summary>
	/// Purified Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Human House</name>
	Purged_Human_House,

	/// <summary>
	/// Purified Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 6 inhabitants.
	/// </summary>
	/// <name>Purged Lizard House</name>
	Purged_Lizard_House,

	/// <summary>
	/// Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.
	/// </summary>
	/// <name>Rain Catcher</name>
	Rain_Catcher,

	/// <summary>
	/// Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Rain Mill</name>
	Rain_Mill,

	/// <summary>
	/// Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
	/// </summary>
	/// <name>Rain Totem</name>
	Rain_Totem,

	/// <summary>
	/// Converted Rain Totem - <color=#D6E54A>Harmony.</color> The ritual was completed, but a faint, rhythmic thumping can still be heard coming from the totem. Decreases Hostility by 50. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Rain Totem Positive</name>
	Rain_Totem_Positive,

	/// <summary>
	/// Rainpunk Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Rainpunk Barrels</name>
	Rainpunk_Barrels,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Coal</name>
	Rainpunk_Drill_Coal,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Copper</name>
	Rainpunk_Drill_Copper,

	/// <summary>
	/// Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
	/// </summary>
	/// <name>Rainpunk Drill - Salt</name>
	Rainpunk_Drill_Salt,

	/// <summary>
	/// Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Rainpunk Foundry</name>
	Rainpunk_Foundry,

	/// <summary>
	/// Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
	/// </summary>
	/// <name>RainpunkFactory</name>
	RainpunkFactory,

	/// <summary>
	/// Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Ranch</name>
	Ranch,

	/// <summary>
	/// Reinforced Road - A road reinforced with copper. Grants a 25% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
	/// </summary>
	/// <name>Reinforced Road</name>
	Reinforced_Road,

	/// <summary>
	/// Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T1</name>
	RewardChest_T1,

	/// <summary>
	/// Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T2</name>
	RewardChest_T2,

	/// <summary>
	/// Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
	/// </summary>
	/// <name>RewardChest_T3</name>
	RewardChest_T3,

	/// <summary>
	/// Road Sign - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Road Sign</name>
	Road_Sign,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher</name>
	Ruined_Advanced_Rain_Catcher,

	/// <summary>
	/// Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Advanced Rain Catcher (no reward)</name>
	Ruined_Advanced_Rain_Catcher_no_Reward,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Alchemist</name>
	Ruined_Alchemist,

	/// <summary>
	/// Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Alchemist (no reward)</name>
	Ruined_Alchemist_no_Reward,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Apothecary</name>
	Ruined_Apothecary,

	/// <summary>
	/// Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Apothecary (no reward)</name>
	Ruined_Apothecary_no_Reward,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Artisan</name>
	Ruined_Artisan,

	/// <summary>
	/// Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Artisan (no reward)</name>
	Ruined_Artisan_no_Reward,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bakery</name>
	Ruined_Bakery,

	/// <summary>
	/// Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bakery (no reward)</name>
	Ruined_Bakery_no_Reward,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Bath House</name>
	Ruined_Bath_House,

	/// <summary>
	/// Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Bath House (no reward)</name>
	Ruined_Bath_House_no_Reward,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Beanery</name>
	Ruined_Beanery,

	/// <summary>
	/// Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beanery (no reward)</name>
	Ruined_Beanery_no_Reward,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House</name>
	Ruined_Beaver_House,

	/// <summary>
	/// Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Beaver House (no reward)</name>
	Ruined_Beaver_House_no_Reward,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter</name>
	Ruined_Big_Shelter,

	/// <summary>
	/// Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Big Shelter (no reward)</name>
	Ruined_Big_Shelter_no_Reward,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brewery</name>
	Ruined_Brewery,

	/// <summary>
	/// Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brewery (no reward)</name>
	Ruined_Brewery_no_Reward,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brick Oven</name>
	Ruined_Brick_Oven,

	/// <summary>
	/// Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brick Oven (no reward)</name>
	Ruined_Brick_Oven_no_Reward,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Brickyard</name>
	Ruined_Brickyard,

	/// <summary>
	/// Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Brickyard (no reward)</name>
	Ruined_Brickyard_no_Reward,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Butcher</name>
	Ruined_Butcher,

	/// <summary>
	/// Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Butcher (no reward)</name>
	Ruined_Butcher_no_Reward,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cannery</name>
	Ruined_Cannery,

	/// <summary>
	/// Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cannery (no reward)</name>
	Ruined_Cannery_no_Reward,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Carpenter</name>
	Ruined_Carpenter,

	/// <summary>
	/// Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Carpenter (no reward)</name>
	Ruined_Carpenter_no_Reward,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cellar</name>
	Ruined_Cellar,

	/// <summary>
	/// Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cellar (no reward)</name>
	Ruined_Cellar_no_Reward,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clan Hall</name>
	Ruined_Clan_Hall,

	/// <summary>
	/// Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clan Hall (no reward)</name>
	Ruined_Clan_Hall_no_Reward,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Clay Pit</name>
	Ruined_Clay_Pit,

	/// <summary>
	/// Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Clay Pit (no reward)</name>
	Ruined_Clay_Pit_no_Reward,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cobbler</name>
	Ruined_Cobbler,

	/// <summary>
	/// Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cobbler (no reward)</name>
	Ruined_Cobbler_no_Reward,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cookhouse</name>
	Ruined_Cookhouse,

	/// <summary>
	/// Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cookhouse (no reward)</name>
	Ruined_Cookhouse_no_Reward,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Cooperage</name>
	Ruined_Cooperage,

	/// <summary>
	/// Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Cooperage (no reward)</name>
	Ruined_Cooperage_no_Reward,

	/// <summary>
	/// Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Crude Workstation (no reward)</name>
	Ruined_Crude_Workstation_no_Reward,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Distillery</name>
	Ruined_Distillery,

	/// <summary>
	/// Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Distillery (no reward)</name>
	Ruined_Distillery_no_Reward,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Druid</name>
	Ruined_Druid,

	/// <summary>
	/// Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Druid (no reward)</name>
	Ruined_Druid_no_Reward,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Explorers Lodge</name>
	Ruined_Explorers_Lodge,

	/// <summary>
	/// Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Explorers Lodge (no reward)</name>
	Ruined_Explorers_Lodge_no_Reward,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Farm</name>
	Ruined_Farm,

	/// <summary>
	/// Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Farm (no reward)</name>
	Ruined_Farm_no_Reward,

	/// <summary>
	/// Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Field Kitchen (no reward)</name>
	Ruined_Field_Kitchen_no_Reward,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Finesmith</name>
	Ruined_Finesmith,

	/// <summary>
	/// Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Finesmith (no reward)</name>
	Ruined_Finesmith_no_Reward,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Fishing Hut</name>
	Ruined_Fishing_Hut,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut (no reward)</name>
	Ruined_Fishing_Hut_no_Reward,

	/// <summary>
	/// Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fishing Hut Primitive (no reward)</name>
	Ruined_Fishing_Hut_Primitive_no_Reward,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Foragers Camp</name>
	Ruined_Foragers_Camp,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp (no reward)</name>
	Ruined_Foragers_Camp_no_Reward,

	/// <summary>
	/// Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Foragers Camp Primitive (no reward)</name>
	Ruined_Foragers_Camp_Primitive_no_Reward,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum</name>
	Ruined_Forum,

	/// <summary>
	/// Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Forum (no reward)</name>
	Ruined_Forum_no_Reward,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House</name>
	Ruined_Fox_House,

	/// <summary>
	/// Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Fox House (no reward)</name>
	Ruined_Fox_House_no_Reward,

	/// <summary>
	/// Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Frog House (no reward)</name>
	Ruined_Frog_House_no_Reward,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Furnace</name>
	Ruined_Furnace,

	/// <summary>
	/// Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Furnace (no reward)</name>
	Ruined_Furnace_no_Reward,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Granary</name>
	Ruined_Granary,

	/// <summary>
	/// Granary - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Granary (no reward)</name>
	Ruined_Granary_no_Reward,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Greenhouse</name>
	Ruined_Greenhouse,

	/// <summary>
	/// Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Greenhouse (no reward)</name>
	Ruined_Greenhouse_no_Reward,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill</name>
	Ruined_Grill,

	/// <summary>
	/// Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grill (no reward)</name>
	Ruined_Grill_no_Reward,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Grove</name>
	Ruined_Grove,

	/// <summary>
	/// Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Grove (no reward)</name>
	Ruined_Grove_no_Reward,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Guild House</name>
	Ruined_Guild_House,

	/// <summary>
	/// Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Guild House (no reward)</name>
	Ruined_Guild_House_no_Reward,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House</name>
	Ruined_Harpy_House,

	/// <summary>
	/// Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harpy House (no reward)</name>
	Ruined_Harpy_House_no_Reward,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Harvester Camp</name>
	Ruined_Harvester_Camp,

	/// <summary>
	/// Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Harvester Camp (no reward)</name>
	Ruined_Harvester_Camp_no_Reward,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herb Garden</name>
	Ruined_Herb_Garden,

	/// <summary>
	/// Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herb Garden (no reward)</name>
	Ruined_Herb_Garden_no_Reward,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Herbalist Camp</name>
	Ruined_Herbalist_Camp,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp (no reward)</name>
	Ruined_Herbalist_Camp_no_Reward,

	/// <summary>
	/// Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Herbalist Camp primitive (no reward)</name>
	Ruined_Herbalist_Camp_Primitive_no_Reward,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House</name>
	Ruined_Human_House,

	/// <summary>
	/// Human House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Human House (no reward)</name>
	Ruined_Human_House_no_Reward,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Kiln</name>
	Ruined_Kiln,

	/// <summary>
	/// Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Kiln (no reward)</name>
	Ruined_Kiln_no_Reward,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks</name>
	Ruined_Leatherworks,

	/// <summary>
	/// Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Leatherworks (no reward)</name>
	Ruined_Leatherworks_no_Reward,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House</name>
	Ruined_Lizard_House,

	/// <summary>
	/// Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lizard House (no reward)</name>
	Ruined_Lizard_House_no_Reward,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Lumbermill</name>
	Ruined_Lumbermill,

	/// <summary>
	/// Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Lumbermill (no reward)</name>
	Ruined_Lumbermill_no_Reward,

	/// <summary>
	/// Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Makeshift Post (no reward)</name>
	Ruined_Makeshift_Post_no_Reward,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Manufatory</name>
	Ruined_Manufatory,

	/// <summary>
	/// Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Manufatory (no reward)</name>
	Ruined_Manufatory_no_Reward,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Market</name>
	Ruined_Market,

	/// <summary>
	/// Market - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Market (no reward)</name>
	Ruined_Market_no_Reward,

	/// <summary>
	/// Mine - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Mine (no reward)</name>
	Ruined_Mine_no_Reward,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery</name>
	Ruined_Monastery,

	/// <summary>
	/// Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Monastery (no reward)</name>
	Ruined_Monastery_no_Reward,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Pantry</name>
	Ruined_Pantry,

	/// <summary>
	/// Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Pantry (no reward)</name>
	Ruined_Pantry_no_Reward,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Plantation</name>
	Ruined_Plantation,

	/// <summary>
	/// Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Plantation (no reward)</name>
	Ruined_Plantation_no_Reward,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press</name>
	Ruined_Press,

	/// <summary>
	/// Press - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Press (no reward)</name>
	Ruined_Press_no_Reward,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Provisioner</name>
	Ruined_Provisioner,

	/// <summary>
	/// Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Provisioner (no reward)</name>
	Ruined_Provisioner_no_Reward,

	/// <summary>
	/// Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rain Catcher (no reward)</name>
	Ruined_Rain_Catcher_no_Reward,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Rainmill</name>
	Ruined_Rainmill,

	/// <summary>
	/// Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Rainmill (no reward)</name>
	Ruined_Rainmill_no_Reward,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Ranch</name>
	Ruined_Ranch,

	/// <summary>
	/// Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Ranch (no reward)</name>
	Ruined_Ranch_no_Reward,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Scribe</name>
	Ruined_Scribe,

	/// <summary>
	/// Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Scribe (no reward)</name>
	Ruined_Scribe_no_Reward,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Sewer</name>
	Ruined_Sewer,

	/// <summary>
	/// Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Sewer (no reward)</name>
	Ruined_Sewer_no_Reward,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter</name>
	Ruined_Shelter,

	/// <summary>
	/// Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Shelter (no reward)</name>
	Ruined_Shelter_no_Reward,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined SmallFarm</name>
	Ruined_SmallFarm,

	/// <summary>
	/// Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined SmallFarm (no reward)</name>
	Ruined_SmallFarm_no_Reward,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smelter</name>
	Ruined_Smelter,

	/// <summary>
	/// Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smelter (no reward)</name>
	Ruined_Smelter_no_Reward,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smithy</name>
	Ruined_Smithy,

	/// <summary>
	/// Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smithy (no reward)</name>
	Ruined_Smithy_no_Reward,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Smokehouse</name>
	Ruined_Smokehouse,

	/// <summary>
	/// Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Smokehouse (no reward)</name>
	Ruined_Smokehouse_no_Reward,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stamping Mill</name>
	Ruined_Stamping_Mill,

	/// <summary>
	/// Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stamping Mill (no reward)</name>
	Ruined_Stamping_Mill_no_Reward,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Stonecutter Camp</name>
	Ruined_Stonecutter_Camp,

	/// <summary>
	/// Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Stonecutter Camp (no reward)</name>
	Ruined_Stonecutter_Camp_no_Reward,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Storage</name>
	Ruined_Storage,

	/// <summary>
	/// Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Storage (no reward)</name>
	Ruined_Storage_no_Reward,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Supplier</name>
	Ruined_Supplier,

	/// <summary>
	/// Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Supplier (no reward)</name>
	Ruined_Supplier_no_Reward,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tavern</name>
	Ruined_Tavern,

	/// <summary>
	/// Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tavern (no reward)</name>
	Ruined_Tavern_no_Reward,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea Doctor</name>
	Ruined_Tea_Doctor,

	/// <summary>
	/// Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea Doctor (no reward)</name>
	Ruined_Tea_Doctor_no_Reward,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tea House</name>
	Ruined_Tea_House,

	/// <summary>
	/// Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tea House (no reward)</name>
	Ruined_Tea_House_no_Reward,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Temple</name>
	Ruined_Temple,

	/// <summary>
	/// Temple - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Temple (no reward)</name>
	Ruined_Temple_no_Reward,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinctury</name>
	Ruined_Tinctury,

	/// <summary>
	/// Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinctury (no reward)</name>
	Ruined_Tinctury_no_Reward,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Tinkerer</name>
	Ruined_Tinkerer,

	/// <summary>
	/// Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Tinkerer (no reward)</name>
	Ruined_Tinkerer_no_Reward,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Toolshop</name>
	Ruined_Toolshop,

	/// <summary>
	/// Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Toolshop (no reward)</name>
	Ruined_Toolshop_no_Reward,

	/// <summary>
	/// Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trading Post (no reward)</name>
	Ruined_Trading_Post_no_Reward,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Trappers Camp</name>
	Ruined_Trappers_Camp,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp (no reward)</name>
	Ruined_Trappers_Camp_no_Reward,

	/// <summary>
	/// Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Trappers Camp Primitive (no reward)</name>
	Ruined_Trappers_Camp_Primitive_no_Reward,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Weaver</name>
	Ruined_Weaver,

	/// <summary>
	/// Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Weaver (no reward)</name>
	Ruined_Weaver_no_Reward,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Woodcutters Camp</name>
	Ruined_Woodcutters_Camp,

	/// <summary>
	/// Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Woodcutters Camp (no reward)</name>
	Ruined_Woodcutters_Camp_no_Reward,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
	/// </summary>
	/// <name>Ruined Workshop</name>
	Ruined_Workshop,

	/// <summary>
	/// Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
	/// </summary>
	/// <name>Ruined Workshop (no reward)</name>
	Ruined_Workshop_no_Reward,

	/// <summary>
	/// Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
	/// </summary>
	/// <name>Sacrifice Totem</name>
	Sacrifice_Totem,

	/// <summary>
	/// Converted Totem of Denial - <color=#D6E54A>Harmony.</color> Repurposed Fishmen magic can be very useful... but let's hope we don't suffer the same fate as the priestess Ysabelle. Increases Global Resolve by +3. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Sacrifice Totem Positive</name>
	Sacrifice_Totem_Positive,

	/// <summary>
	/// Thorny Reed - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Scarlet Decor</name>
	Scarlet_Decor,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Scorpion 1</name>
	Scorpion_1,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Scorpion 2</name>
	Scorpion_2,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Scorpion 3</name>
	Scorpion_3,

	/// <summary>
	/// Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Scribe</name>
	Scribe,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal</name>
	Seal,

	/// <summary>
	/// Guidance Stone - It is not known where the guidance stones came from or what their original purpose was, but they are imbued with magic and always point in the direction of a nearby seal.
	/// </summary>
	/// <name>Seal Guidepost</name>
	Seal_Guidepost,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal High Diff</name>
	Seal_High_Diff,

	/// <summary>
	/// Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
	/// </summary>
	/// <name>Seal Low Diff</name>
	Seal_Low_Diff,

	/// <summary>
	/// Beacon Tower - A powerful, ancient structure that allows you to summon aid directly from the Citadel. Grants access to three types of temporary support abilities.
	/// </summary>
	/// <name>Sealed Biome Shrine</name>
	Sealed_Biome_Shrine,

	/// <summary>
	/// Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
	/// </summary>
	/// <name>SealedTomb_T1</name>
	SealedTomb_T1,

	/// <summary>
	/// Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 3 residents.
	/// </summary>
	/// <name>Shelter</name>
	Shelter,

	/// <summary>
	/// Signboard - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Signboard</name>
	Signboard,

	/// <summary>
	/// Ancient Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
	/// </summary>
	/// <name>Small Hearth</name>
	Small_Hearth,

	/// <summary>
	/// Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).
	/// </summary>
	/// <name>SmallFarm</name>
	SmallFarm,

	/// <summary>
	/// Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Smelter</name>
	Smelter,

	/// <summary>
	/// Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Smithy</name>
	Smithy,

	/// <summary>
	/// Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Smokehouse</name>
	Smokehouse,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Snake 1</name>
	Snake_1,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Snake 2</name>
	Snake_2,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Snake 3</name>
	Snake_3,

	/// <summary>
	/// Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
	/// </summary>
	/// <name>Spider 1</name>
	Spider_1,

	/// <summary>
	/// Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
	/// </summary>
	/// <name>Spider 2</name>
	Spider_2,

	/// <summary>
	/// Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
	/// </summary>
	/// <name>Spider 3</name>
	Spider_3,

	/// <summary>
	/// Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Stamping Mill</name>
	Stamping_Mill,

	/// <summary>
	/// Stone Fence - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Stone Fence</name>
	Stone_Fence,

	/// <summary>
	/// Stone Fence Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Stone Fence Corner</name>
	Stone_Fence_Corner,

	/// <summary>
	/// Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
	/// </summary>
	/// <name>Stonecutter's Camp</name>
	Stonecutters_Camp,

	/// <summary>
	/// Small Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
	/// </summary>
	/// <name>Storage (buildable)</name>
	Storage_buildable,

	/// <summary>
	/// Tamed Stormbird - <color=#D6E54A>Harmony.</color> The nest of a tamed Stormbird. It provides 5 "[food raw] eggs" Eggs per minute and increases Harpy Resolve by +3. Counts as 16 decorations of its type.
	/// </summary>
	/// <name>Stormbird Positive</name>
	Stormbird_Positive,

	/// <summary>
	/// Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Supplier</name>
	Supplier,

	/// <summary>
	/// Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
	/// </summary>
	/// <name>Tavern</name>
	Tavern,

	/// <summary>
	/// Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
	/// </summary>
	/// <name>Tea Doctor</name>
	Tea_Doctor,

	/// <summary>
	/// Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Tea House</name>
	Tea_House,

	/// <summary>
	/// Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.
	/// </summary>
	/// <name>Temple</name>
	Temple,

	/// <summary>
	/// Small Hearth - Reduces Hostility and serves as a meeting place. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will use another Hearth instead. Can't be built too close to other Hearths.
	/// </summary>
	/// <name>Temporary Hearth (buildable)</name>
	Temporary_Hearth_buildable,

	/// <summary>
	/// Small Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
	/// </summary>
	/// <name>Temporary Hearth (not-buildable)</name>
	Temporary_Hearth_not_buildable,

	/// <summary>
	/// Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
	/// </summary>
	/// <name>Termite Burrow</name>
	Termite_Burrow,

	/// <summary>
	/// Termite Nest - <color=#D6E54A>Harmony.</color> A contained stonetooth termite burrow. Provides 5 "[food raw] insects" Insects per minute. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Termite Burrow Positive</name>
	Termite_Burrow_Positive,

	/// <summary>
	/// Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
	/// </summary>
	/// <name>TI AncientShrine_T1</name>
	TI_AncientShrine_T1,

	/// <summary>
	/// Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1). Can use: "[water] drizzle water" Drizzle Water.
	/// </summary>
	/// <name>Tinctury</name>
	Tinctury,

	/// <summary>
	/// Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Tinkerer</name>
	Tinkerer,

	/// <summary>
	/// Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Toolshop</name>
	Toolshop,

	/// <summary>
	/// Wall Crossing - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Tower</name>
	Tower,

	/// <summary>
	/// Town Board - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
	/// </summary>
	/// <name>Town Board</name>
	Town_Board,

	/// <summary>
	/// Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
	/// </summary>
	/// <name>Traders Cemetery</name>
	Traders_Cemetery,

	/// <summary>
	/// Trading Post - Traders from the Smoldering City can station here and offer their wares.
	/// </summary>
	/// <name>Trading Post</name>
	Trading_Post,

	/// <summary>
	/// Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).
	/// </summary>
	/// <name>Trapper's Camp</name>
	Trappers_Camp,

	/// <summary>
	/// Umbrella - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Umbrella</name>
	Umbrella,

	/// <summary>
	/// Wall - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Wall</name>
	Wall,

	/// <summary>
	/// Wall Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Wall Corner</name>
	Wall_Corner,

	/// <summary>
	/// Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
	/// </summary>
	/// <name>War Beast Cage</name>
	War_Beast_Cage,

	/// <summary>
	/// Water Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
	/// </summary>
	/// <name>Water Barrels</name>
	Water_Barrels,

	/// <summary>
	/// Geyser Pump - Used to extract and pump infused rainwater through underground pipes to production buildings, where it can be used to increase productivity. Must be placed on an active geyser. Has a tank capacity of 50.
	/// </summary>
	/// <name>Water Extractor</name>
	Water_Extractor,

	/// <summary>
	/// Water Shrine - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 9 decorations of its type.
	/// </summary>
	/// <name>Water Shrine</name>
	Water_Shrine,

	/// <summary>
	/// Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1). Can use: "[water] clearance water" Clearance Water.
	/// </summary>
	/// <name>Weaver</name>
	Weaver,

	/// <summary>
	/// Overgrown Well - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
	/// </summary>
	/// <name>Well</name>
	Well,

	/// <summary>
	/// Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
	/// </summary>
	/// <name>White Stag</name>
	White_Stag,

	/// <summary>
	/// Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
	/// </summary>
	/// <name>White Treasure Stag</name>
	White_Treasure_Stag,

	/// <summary>
	/// Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.
	/// </summary>
	/// <name>Wildfire</name>
	Wildfire,

	/// <summary>
	/// Woodcutters' Camp - Starting point for woodcutters going out into the wild to cut down trees.
	/// </summary>
	/// <name>Woodcutters Camp</name>
	Woodcutters_Camp,

	/// <summary>
	/// Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0). Can use: "[water] storm water" Storm Water.
	/// </summary>
	/// <name>Workshop</name>
	Workshop,



	MAX = 530
}

public static class BuildingTypesExtensions
{
	private static BuildingTypes[] s_All = null;
	public static BuildingTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new BuildingTypes[530];
			for (int i = 0; i < 530; i++)
			{
				s_All[i] = (BuildingTypes)(i+1);
			}
		}
		return s_All;
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

		Plugin.Log.LogError($"Cannot find name of BuildingTypes: " + type + "\n" + Environment.StackTrace);
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

		Plugin.Log.LogWarning("Cannot find BuildingTypes with name: " + name + "\n" + Environment.StackTrace);
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
	
		Plugin.Log.LogError("Cannot find BuildingModel for BuildingTypes with name: " + name + "\n" + Environment.StackTrace);
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
		{ BuildingTypes.Advanced_Rain_Catcher, "Advanced Rain Catcher" },                                           // Advanced Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 100.
		{ BuildingTypes.Aestherics_2x2_Garden, "Aestherics 2x2 - Garden" },                                         // Garden - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Aestherics_2x2_Groundwater_Extractor, "Aestherics 2x2 - Groundwater Extractor" },           // Makeshift Extractor - <color=#8AAFFD>Aesthetics.</color> A curious piece of improvised technology. It extracts moisture from the soil around it and converts it into 10 "[water] clearance water" Clearance Water per minute. Counts as 4 decorations of its type.
		{ BuildingTypes.Alchemist_Hut, "Alchemist Hut" },                                                           // Alchemist's Hut - Can produce:  [metal] crystalized dew Crystalized Dew (grade2), [needs] tea Tea (grade2), [needs] wine Wine (grade2). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Altar, "Altar" },                                                                           // Forsaken Altar - An ancient altar to the Forsaken Gods. In the midst of the raging storm, you can make sacrifices here to gain unimaginable powers.
		{ BuildingTypes.Ancient_Gravestone, "Ancient Gravestone" },                                                 // Ancient Tombstone - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.AncientBurrialGrounds, "AncientBurrialGrounds" },                                           // Ancient Burial Site - A strange place filled with gravestones inscribed in an ancient, long forgotten language.
		{ BuildingTypes.AncientGate, "AncientGate" },                                                               // Dark Gate - A strange monument of cyclopean proportions. Heavy storm clouds seem to be gathering around the settlement.
		{ BuildingTypes.AncientShrine_T1, "AncientShrine_T1" },                                                     // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ BuildingTypes.AncientTemple, "AncientTemple" },                                                           // Forgotten Temple of the Sun - Who would worship the sun in a world with so little sunlight?
		{ BuildingTypes.Angry_Ghost_1, "Angry Ghost 1" },                                                           // Ghost of a Blight Fighter Captain - I let us down and was defeated by the Blightrot... but you can avenge me! Kill it with fire!!!
		{ BuildingTypes.Angry_Ghost_10, "Angry Ghost 10" },                                                         // Ghost of a Suppressed Rebel - I was leading a rebellion against the Queen's tyrannical rule, but the Royal Guard found us. Carry on my legacy!
		{ BuildingTypes.Angry_Ghost_14, "Angry Ghost 14" },                                                         // Ghost of a Resentful Human - Humans deserve to be treated better than the others! Without us, you’d never achieve anything. If you don’t meet our basic needs, we’ll take our revenge!
		{ BuildingTypes.Angry_Ghost_15, "Angry Ghost 15" },                                                         // Ghost of the Queen's Lickspittle - I challenge you, viceroy! Do you consider yourself worthy of the Queen's glance? Prove it. Time is ticking.
		{ BuildingTypes.Angry_Ghost_16, "Angry Ghost 16" },                                                         // Ghost of a Lizard Leader - I'm so sick of these Beavers! They’re the bane of this kingdom! They deserve nothing but condemnation for what they did to us. I order you to torment them - or I'll do it myself!
		{ BuildingTypes.Angry_Ghost_17, "Angry Ghost 17" },                                                         // Ghost of a Tortured Harpy - They took our homes and our crops. They desecrated our culture, and in the end, they took our lives. The time of contempt has come.
		{ BuildingTypes.Angry_Ghost_18, "Angry Ghost 18" },                                                         // Ghost of a Beaver Engineer - These fanatics should pay for their heresies! They are dangerous, wild, and unpredictable creatures. Teach these savages, once and for all.
		{ BuildingTypes.Angry_Ghost_19, "Angry Ghost 19" },                                                         // Ghost of a Poisoned Human - We will no longer tolerate those upturned beaks roaming the settlement freely. Everyone must learn the truth about how the Harpy alchemists poisoned us to seize power!
		{ BuildingTypes.Angry_Ghost_2, "Angry Ghost 2" },                                                           // Ghost of a Mad Alchemist - I have studied the Blightrot all my life. Nobody believes me, but the cysts are essential for the ecosystem! Grow them and find out yourself!
		{ BuildingTypes.Angry_Ghost_20, "Angry Ghost 20" },                                                         // Ghost of a Lizard Worker - Self-righteous Beavers only want to bask in the luxuries we’ve worked so hard for. Time to end this injustice!
		{ BuildingTypes.Angry_Ghost_21, "Angry Ghost 21" },                                                         // Ghost of a Starved Harpy - Greedy Human farmers always want to keep all the crops for themselves. Those traitors hid everything from us, and pretended the crops were rotten!
		{ BuildingTypes.Angry_Ghost_24, "Angry Ghost 24" },                                                         // Ghost of an Innkeeper - We worked so hard, and put our lives in danger every day. If you don't let your villagers rest, I will make sure your soul never finds peace.
		{ BuildingTypes.Angry_Ghost_31, "Angry Ghost 31" },                                                         // Ghost of a Lizard Elder - It was them! I'm sure of it! I remember their blank, blight-tainted gaze! They ambushed me in the forest! Please, avenge me!
		{ BuildingTypes.Angry_Ghost_32, "Angry Ghost 32" },                                                         // Ghost of a Lost Scout - How could I have gotten lost!? Something's not right here... You! You have to help me!
		{ BuildingTypes.Angry_Ghost_34, "Angry Ghost 34" },                                                         // Ghost of a Murdered Trader - Hey, you! You're a viceroy, ain't you? Your bastard friends attacked me and left me to die in the woods! Prove to me you're not like them!
		{ BuildingTypes.Angry_Ghost_4, "Angry Ghost 4" },                                                           // Ghost of a Deranged Scout - You hear it? This ominous forest is calling to us... Withstand its fury, and I will spare your settlement.
		{ BuildingTypes.Angry_Ghost_41, "Angry Ghost 41" },                                                         // Ghost of Crazed Engineer - Madness, they said, but genius knows no bounds! Embrace my volatile creations and make these fools tremble at the mere sight of your power!
		{ BuildingTypes.Angry_Ghost_5, "Angry Ghost 5" },                                                           // Ghost of a Furious Villager - Those filthy little thieves are heartless! We were starving, and they just watched and laughed in our faces. It has to stop. Teach them a lesson.
		{ BuildingTypes.Angry_Ghost_6, "Angry Ghost 6" },                                                           // Ghost of a Scared Firekeeper - We cherished the Flame - it enveloped us with its warmth. But suddenly... It went out. I can't remember what happened. Please - you can’t let this happen again! Let the sound of axes echo through the forest.
		{ BuildingTypes.Angry_Ghost_9, "Angry Ghost 9" },                                                           // Ghost of a Loyal Servant - Nothing matters except the Queen. It is an honor to serve her. Show how loyal you are. Otherwise, I will have to punish you.
		{ BuildingTypes.AngryGhostChest_T1, "AngryGhostChest_T1" },                                                 // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ BuildingTypes.Anvil, "Anvil" },                                                                           // Anvil - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Apothecary, "Apothecary" },                                                                 // Apothecary - Can produce:  [needs] tea Tea (grade2), [crafting] dye Dye (grade2), [food processed] jerky Jerky (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Arch, "Arch" },                                                                             // Ancient Arch - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
		{ BuildingTypes.Archaeology_Scorpion_Positive, "Archaeology Scorpion Positive" },                           // Smoldering Scorpion - <color=#D6E54A>Harmony.</color> Legend has it that they once inhabited the top of the mountain on which the Smoldering City now stands. The Queen banished them, but it is said that some of them still hibernate somewhere on the outskirts of the kingdom.  Counts as 9 decorations of its type.
		{ BuildingTypes.Archaeology_Snake_Positive, "Archaeology Snake Positive" },                                 // Sea Serpent - <color=#D6E54A>Harmony.</color> The anatomical features of this beast indicate an adaptation to life in water, as well as on land. Due to this, sea serpents are excellent hunters, preying on lonely caravans and lost settlers. The preserved remains show traces of Blightrot. Could it be that these creatures have brought this plague to the surface when emerging from the depths of the ocean? Counts as 9 decorations of its type.
		{ BuildingTypes.Archaeology_Spider_Positive, "Archaeology Spider Positive" },                               // Sealed Spider - <color=#D6E54A>Harmony.</color> It is said that these creatures were once the faithful servants of the Sealed Ones, and like their masters, they were trapped underground for eternity. But even to this day, miners tell tales of giant spiders crawling up from deep caverns, preying on unsuspecting victims. Legend has it that these vile beasts fear only one thing - the Holy Flame. Counts as 9 decorations of its type.
		{ BuildingTypes.Archeology_Office, "Archeology office" },                                                   // Archaeologist's Office - A building designed to help you study the past. Can be upgraded to locate archaeological discoveries or improve the settlement's exploration capabilities. 
		{ BuildingTypes.Artisan, "Artisan" },                                                                       // Artisan - Can produce:  [vessel] barrels Barrels (grade2), [needs] coats Coats (grade2), [needs] scrolls Scrolls (grade2). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Bakery, "Bakery" },                                                                         // Bakery - Can produce:  [food processed] biscuits Biscuits (grade2), [food processed] pie Pie (grade2), [vessel] pottery Pottery (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Bank, "Bank" },                                                                             // Bench - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Barrels, "Barrels" },                                                                       // Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Bath_House, "Bath House" },                                                                 // Bath House - A place where villagers can fulfill their need for: Treatment. Passive effects: Regular Baths, Good Health.
		{ BuildingTypes.Beanery, "Beanery" },                                                                       // Beanery - Can produce:  [food processed] porridge Porridge (grade3), [food processed] pickled goods Pickled Goods (grade1), [metal] crystalized dew Crystalized Dew (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Beaver_House, "Beaver House" },                                                             // Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 2 inhabitants.
		{ BuildingTypes.BeaverBattleground_T1, "BeaverBattleground_T1" },                                           // Fallen Beaver Traders - A group of fallen Beaver traders. They were probably assaulted by Fishmen. Or worse... The sight causes anxiety amongst the Beaver population.
		{ BuildingTypes.Big_Shelter, "Big Shelter" },                                                               // Big Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 6 residents.
		{ BuildingTypes.Biome_Perk_Crafter, "Biome Perk Crafter" },                                                 // Cornerstone Forge - An ancient forge used by the Crown for generations to craft cornerstones from Thunderblight Shards. Now it stands abandoned, its fires long cold, but its legacy still felt in the region.
		{ BuildingTypes.Black_Stag, "Black Stag" },                                                                 // Black Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.Black_Treasure_Stag, "Black Treasure Stag" },                                               // Black Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Blight_Post, "Blight Post" },                                                               // Blight Post - A specialized building dedicated to fighting Blightrot. Blight Fighters will prepare "blight fuel" Purging Fire during drizzle and clearance seasons, and use it to burn Blightrot Cysts during the storm.
		{ BuildingTypes.Blightrot, "Blightrot" },                                                                   // Blood Flower - A deadly carrion organism that feeds on decaying matter. It spreads through contaminated rainwater and multiplies with time, becoming more and more dangerous. Blood Flowers are a source of extremely rare resources.
		{ BuildingTypes.Blightrot_Cauldron, "Blightrot Cauldron" },                                                 // Blightrot Cauldron - A Rainpunk Cauldron filled with a Blightrot-contaminated liquid. A moving, living fluid spreads around.
		{ BuildingTypes.Blightrot_Clone, "Blightrot - Clone" },                                                     // Blood Flower (Clone) - (Completing a cloned event does not count as completing a Glade Event, and so does not contribute towards perks, deeds, and score).
		{ BuildingTypes.Bonfire, "Bonfire" },                                                                       // Bonfire - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.Brewery, "Brewery" },                                                                       // Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade2), [packs] pack of crops Pack of Crops (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Brick_Oven, "Brick Oven" },                                                                 // Brick Oven - Can produce:  [food processed] biscuits Biscuits (grade3), [needs] incense Incense (grade2), [crafting] coal Coal (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Brickyard, "Brickyard" },                                                                   // Brickyard - Can produce:  [mat processed] bricks Bricks (grade3), [vessel] pottery Pottery (grade2), [metal] crystalized dew Crystalized Dew (grade1). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Bush, "Bush" },                                                                             // Bush - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Butcher, "Butcher" },                                                                       // Butcher - Can produce:  [food processed] skewers Skewers (grade2), [food processed] jerky Jerky (grade2), [crafting] oil Oil (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Cages, "Cages" },                                                                           // Cages - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Calm_Ghost_11, "Calm Ghost 11" },                                                           // Ghost of a Defeated Viceroy - A long time ago, I founded a prosperous settlement. Everything was fine, until one of our scouts discovered something terrifying in the forest. Please, help restore at least a scrap of my legacy.
		{ BuildingTypes.Calm_Ghost_12, "Calm Ghost 12" },                                                           // Ghost of a Druid - Many viceroys disregard nature. Don't make the same mistake. Be a good example to your people.
		{ BuildingTypes.Calm_Ghost_13, "Calm Ghost 13" },                                                           // Ghost of a Royal Gardener - In these difficult times, beauty helps us forget our troubles. Decorate your village, and your villagers will thank you.
		{ BuildingTypes.Calm_Ghost_22, "Calm Ghost 22" },                                                           // Ghost of a Hooded Knight - I promised my Queen that I would cleanse this forest of all the horrors that lived here. One night, my mount got frightened by the storm, and we fell into the Fishmen's nets. My mission must be completed!
		{ BuildingTypes.Calm_Ghost_23, "Calm Ghost 23" },                                                           // Ghost of a Fire Priest - Spread the word about the power of the Holy Fire! Only it can save us from the storm's wrath. Gather the villagers in the chapel and pray!
		{ BuildingTypes.Calm_Ghost_25, "Calm Ghost 25" },                                                           // Ghost of a Treasure Hunter - If your eyes sparkle at the sight of gold, I have an offer for you. All you have to do is prove that you are one of us, and I will give you my treasure.
		{ BuildingTypes.Calm_Ghost_26, "Calm Ghost 26" },                                                           // Ghost of a Royal Architect - The foundation of success is a thriving settlement. Without solid walls, you won't survive here. Create something you can be proud of.
		{ BuildingTypes.Calm_Ghost_27, "Calm Ghost 27" },                                                           // Ghost of a Worried Carter - The last thing I remember is lightning hitting my caravan. The settlements are still waiting for the goods they ordered. If you deliver them, I’ll see that you’re rewarded.
		{ BuildingTypes.Calm_Ghost_28, "Calm Ghost 28" },                                                           // Ghost of a Storm Victim - Let the fire burn in the Hearth and grow in all its strength. Sacrifice your goods, and help the villagers weather the storm!
		{ BuildingTypes.Calm_Ghost_29, "Calm Ghost 29" },                                                           // Ghost of a Mourning Harpy - Our flock has been in mourning for many years. We will never forget the war. Please, rekindle the hope in the Harpies' hearts.
		{ BuildingTypes.Calm_Ghost_3, "Calm Ghost 3" },                                                             // Ghost of a Terrified Woodcutter - I lived in a very prosperous settlement, but our viceroy was greedy and didn't care about the forest at all! In the end, it brought doom upon us. Refrain from greed, and calm the forest.
		{ BuildingTypes.Calm_Ghost_30, "Calm Ghost 30" },                                                           // Ghost of a Lizard General - My army fought bravely against all odds. Many of us paid the ultimate price. Please, show your respect to those who survived. I'll take care of the fallen.
		{ BuildingTypes.Calm_Ghost_33, "Calm Ghost 33" },                                                           // Ghost of an Old Merchant - I've lived a long and prosperous life, and I've never let a business opportunity pass me by. Good deals have a nasty habit of vanishing very quickly, so seize them!
		{ BuildingTypes.Calm_Ghost_35, "Calm Ghost 35" },                                                           // Ghost of a Fox Elder - The everlasting rain is a as much a gift as it is a curse. And yet it made us stronger, more resilient. Embrace it.
		{ BuildingTypes.Calm_Ghost_36, "Calm Ghost 36" },                                                           // Ghost of a Teadoctor - I was a Teadoctor for years, helping my kind endure the effects of our strange illness. In the end, the disease took me. Take care of my people for me, please.
		{ BuildingTypes.Calm_Ghost_38, "Calm Ghost 38" },                                                           // Ghost of an Old Stonemason - These hands once built sturdy homes from raw stone; now I call upon you to restore and improve them so that they may stand the test of time.
		{ BuildingTypes.Calm_Ghost_39, "Calm Ghost 39" },                                                           // Ghost of a Philosopher - In life I was a philosopher and a teacher. Now, in death, I long for those days. So let me teach you - lift the spirits of your people. Nourish their minds and bodies.
		{ BuildingTypes.Calm_Ghost_40, "Calm Ghost 40" },                                                           // Ghost of a Homeless Man - In life I wandered without aim; in death I beg you to spare others the same fate. Build a sanctuary for those who have no roof over their heads.
		{ BuildingTypes.Calm_Ghost_7, "Calm Ghost 7" },                                                             // Ghost of a Troublemaker - I've had enough of all these uptight do-gooders, with their pristine morals and boring attitudes. It's time to start some trouble!
		{ BuildingTypes.Calm_Ghost_8, "Calm Ghost 8" },                                                             // Ghost of a Fallen Newcomer - I wish I’d stayed with my loved ones in the Citadel. Now, all I'm left with is regret. Don't follow in my footsteps. Be kind to those around you.
		{ BuildingTypes.CalmGhostChest_T1, "CalmGhostChest_T1" },                                                   // Ghost Chest - A mysterious chest filled with treasure. It was left behind by a restless spirit as a token of appreciation.
		{ BuildingTypes.Camp_T1, "Camp_T1" },                                                                       // Small Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ BuildingTypes.Camp_T2, "Camp_T2" },                                                                       // Large Encampment - A destroyed camp in the wilderness. There are still survivors in the area.
		{ BuildingTypes.Cannery, "Cannery" },                                                                       // Cannery - Can produce:  [food processed] paste Paste (grade3), [needs] wine Wine (grade2), [food processed] biscuits Biscuits (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Caravan_T1, "Caravan_T1" },                                                                 // Small Destroyed Caravan - A destroyed caravan was found in the newly discovered glade. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ BuildingTypes.Caravan_T2, "Caravan_T2" },                                                                 // Large Destroyed Caravan - A destroyed caravan, stranded in the wilderness. There are drag marks leading deeper into the forest... What could have caused such mayhem?
		{ BuildingTypes.Carpenter, "Carpenter" },                                                                   // Carpenter - Can produce:  [mat processed] planks Planks (grade2), [tools] simple tools Tools (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Cellar, "Cellar" },                                                                         // Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade2), [packs] pack of provisions Pack of Provisions (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Chest, "Chest" },                                                                           // Chest - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Clan_Hall, "Clan Hall" },                                                                   // Clan Hall - A place where villagers can fulfill their need for: Brawling. Passive effects: Carnivorous Tradition, Ancient Ways.
		{ BuildingTypes.Clay_Pit_Workshop, "Clay Pit Workshop" },                                                   // Clay Pit - Uses Clearance Water to produce goods regardless of the season. Must be placed on fertile soil. Can produce:  [mat raw] clay Clay (grade2), [mat raw] reeds Reed (grade2), [mat raw] resin Resin (grade2)
		{ BuildingTypes.Clothier, "Clothier" },                                                                     // Clothier - Can produce:  [needs] coats Coats (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [vessel] waterskin Waterskins (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Coastal_Grove_Plant, "Coastal Grove Plant" },                                               // Saltwater Pitcher Plant - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Cobbler, "Cobbler" },                                                                       // Cobbler - Can produce:  [needs] boots Boots (grade3), [packs] pack of building materials Pack of Building Materials (grade2), [crafting] dye Dye (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Comfort_2x2_Park, "Comfort 2x2 - Park" },                                                   // Park - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Cookhouse, "Cookhouse" },                                                                   // Cookhouse - Can produce:  [food processed] skewers Skewers (grade2), [food processed] biscuits Biscuits (grade2), [food processed] porridge Porridge (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Cooperage, "Cooperage" },                                                                   // Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Coral_Decor, "Coral Decor" },                                                               // Coral Growth - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.CornerFence, "CornerFence" },                                                               // Fence Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Corrupted_Caravan, "Corrupted Caravan" },                                                   // Corrupted Caravan - A large caravan abandoned in the woods, overgrown with Blightrot Cysts. They must have fed on the transported goods... or people.
		{ BuildingTypes.Crates, "Crates" },                                                                         // Crates - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Crude_Workstation, "Crude Workstation" },                                                   // Crude Workstation - Can produce:  [mat processed] planks Planks (grade0), [mat processed] fabric Fabric (grade0), [mat processed] bricks Bricks (grade0), [mat processed] pipe Pipes (grade0). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.DebugNode_ClayBig, "DebugNode_ClayBig" },                                                   // Clay Node (Large) - Soil infused with the essence of the rain.
		{ BuildingTypes.DebugNode_ClaySmall, "DebugNode_ClaySmall" },                                               // Clay Node (Small) - Soil infused with the essence of the rain.
		{ BuildingTypes.DebugNode_DewberryBushBig, "DebugNode_DewberryBushBig" },                                   // Dewberry Bush (Large) - Fresh and sweet berries, infused by the rain.
		{ BuildingTypes.DebugNode_DewberryBushSmall, "DebugNode_DewberryBushSmall" },                               // Dewberry Bush (Small) - Fresh and sweet berries, infused by the rain.
		{ BuildingTypes.DebugNode_FlaxBig, "DebugNode_FlaxBig" },                                                   // Flax Field (Large) - Resilient plants that are perfect for cloth-making.
		{ BuildingTypes.DebugNode_FlaxSmall, "DebugNode_FlaxSmall" },                                               // Flax Field (Small) - Resilient plants that are perfect for cloth-making.
		{ BuildingTypes.DebugNode_HerbsBig, "DebugNode_HerbsBig" },                                                 // Herb Node (Large) - A dense shrub, full of many useful plant species.
		{ BuildingTypes.DebugNode_HerbsSmall, "DebugNode_HerbsSmall" },                                             // Herb Node (Small) - A dense shrub, full of many useful plant species.
		{ BuildingTypes.DebugNode_LeechBroodmotherBig, "DebugNode_LeechBroodmotherBig" },                           // Leech Broodmother (Large) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ BuildingTypes.DebugNode_LeechBroodmotherSmall, "DebugNode_LeechBroodmotherSmall" },                       // Leech Broodmother (Small) - A dead leech broodmother. It has a strong, and somewhat sweet smell.
		{ BuildingTypes.DebugNode_Marshlands_InfiniteGrain, "DebugNode_Marshlands_InfiniteGrain" },                 // Ancient Proto Wheat - A wild type of grain, mutated by an invasive species of fungi.
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMeat, "DebugNode_Marshlands_InfiniteMeat" },                   // Dead Leviathan - A giant, dead beast. How did it get here?
		{ BuildingTypes.DebugNode_Marshlands_InfiniteMushroom, "DebugNode_Marshlands_InfiniteMushroom" },           // Giant Proto Fungus - An ancient and mysterious organism. Proto fungi are sometimes referred to as the living and breathing hearts of the Marshlands.
		{ BuildingTypes.DebugNode_MarshlandsMushroomBig, "DebugNode_MarshlandsMushroomBig" },                       // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MarshlandsMushroomSmall, "DebugNode_MarshlandsMushroomSmall" },                   // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MossBroccoliBig, "DebugNode_MossBroccoliBig" },                                   // Moss Broccoli Patch (Large) - An edible and tasty type of moss.
		{ BuildingTypes.DebugNode_MossBroccoliSmall, "DebugNode_MossBroccoliSmall" },                               // Moss Broccoli Patch (Small) - An edible and tasty type of moss.
		{ BuildingTypes.DebugNode_MushroomBig, "DebugNode_MushroomBig" },                                           // Grasscap Mushrooms (Large) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_MushroomSmall, "DebugNode_MushroomSmall" },                                       // Grasscap Mushrooms (Small) - A resilient species that grows on marshy soil.
		{ BuildingTypes.DebugNode_ReedBig, "DebugNode_ReedBig" },                                                   // Reed Field (Large) - A very common plant, it thrives thanks to the magical rain.
		{ BuildingTypes.DebugNode_ReedSmall, "DebugNode_ReedSmall" },                                               // Reed Field (Small) - A very common plant, it thrives thanks to the magical rain.
		{ BuildingTypes.DebugNode_RootsBig, "DebugNode_RootsBig" },                                                 // Root Node (Large) - A tangled net of living vines.
		{ BuildingTypes.DebugNode_RootsSmall, "DebugNode_RootsSmall" },                                             // Root Node (Small) - A tangled net of living vines.
		{ BuildingTypes.DebugNode_SeaMarrowBig, "DebugNode_SeaMarrowBig" },                                         // Sea Marrow Node (Large) - Ancient fossils, rich in resources.
		{ BuildingTypes.DebugNode_SeaMarrowSmall, "DebugNode_SeaMarrowSmall" },                                     // Sea Marrow Node (Small) - Ancient fossils, rich in resources.
		{ BuildingTypes.DebugNode_SnailBroodmotherBig, "DebugNode_SnailBroodmotherBig" },                           // Slickshell Broodmother (Large) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ BuildingTypes.DebugNode_SnailBroodmotherSmall, "DebugNode_SnailBroodmotherSmall" },                       // Slickshell Broodmother (Small) - Small slickshells are crawling out of the openings in the broodmother's shell. It's easy to collect them.
		{ BuildingTypes.DebugNode_SnakeNestBig, "DebugNode_SnakeNestBig" },                                         // Snake Nest (Large) - A dangerous, but rich source of food and leather.
		{ BuildingTypes.DebugNode_SnakeNestSmall, "DebugNode_SnakeNestSmall" },                                     // Snake Nest (Small) - A dangerous, but rich source of food and leather.
		{ BuildingTypes.DebugNode_StoneBig, "DebugNode_StoneBig" },                                                 // Stone Node (Large) - Stones, weathered by the everlasting rain.
		{ BuildingTypes.DebugNode_StoneSmall, "DebugNode_StoneSmall" },                                             // Stone Node (Small) - Stones, weathered by the everlasting rain.
		{ BuildingTypes.DebugNode_StormbirdNestBig, "DebugNode_StormbirdNestBig" },                                 // Drizzlewing Nest (Large) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ BuildingTypes.DebugNode_StormbirdNestSmall, "DebugNode_StormbirdNestSmall" },                             // Drizzlewing Nest (Small) - An abandoned Drizzlewing nest. These small, flightless birds run away as soon as they spot another living creature nearby.
		{ BuildingTypes.DebugNode_SwampWheatBig, "DebugNode_SwampWheatBig" },                                       // Swamp Wheat Field (Large) - A plant species that’s right at home in the swamp.
		{ BuildingTypes.DebugNode_SwampWheatSmall, "DebugNode_SwampWheatSmall" },                                   // Swamp Wheat Field (Small) - A plant species that’s right at home in the swamp.
		{ BuildingTypes.DebugNode_WormtongueNestBig, "DebugNode_WormtongueNestBig" },                               // Wormtongue Nest (Large) - A nest full of tasty wormtongues.
		{ BuildingTypes.DebugNode_WormtongueNestSmall, "DebugNode_WormtongueNestSmall" },                           // Wormtongue Nest (Small) - A nest full of tasty wormtongues.
		{ BuildingTypes.Decay_Altar, "Decay Altar" },                                                               // Altar of Decay - A sinister stone structure created to worship the Blightrot. Cultists have engraved the inscription: "Nothing escapes death".
		{ BuildingTypes.Decay_Altar_Positive, "Decay Altar Positive" },                                             // Converted Altar of Decay - <color=#D6E54A>Harmony.</color> Bloody sacrifices delight the evil presence. Forbidden rituals at the Altar of Decay reduce Hostility by 20 points every time a villager dies or leaves. Counts as 9 decorations of its type.
		{ BuildingTypes.Distillery, "Distillery" },                                                                 // Distillery - Can produce:  [needs] ale Ale (grade2), [needs] incense Incense (grade2), [food processed] pickled goods Pickled Goods (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Druid, "Druid" },                                                                           // Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade2), [needs] coats Coats (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Escaped_Convicts, "Escaped Convicts" },                                                     // Escaped Convicts - Dangerous convicts from the Smoldering City are hiding in the forest. They somehow managed to free themselves during transport. You can decide their fate - welcome them and employ them in your settlement, or send them back to the Citadel where they will be punished.
		{ BuildingTypes.Explorers_Lodge, "Explorers Lodge" },                                                       // Explorers' Lodge - A place where villagers can fulfill their need for: Brawling,  Education. Passive effects: The Crown Chronicles.
		{ BuildingTypes.Farmfield, "Farmfield" },                                                                   // Farm Field - Can only be placed on fertile soil. Requires a Small Farm, Plantation, Herb Garden, Forester's Hut, or Homestead nearby to produce crops.
		{ BuildingTypes.Fence, "Fence" },                                                                           // Fence - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Field_Kitchen, "Field Kitchen" },                                                           // Field Kitchen - Can produce:  [food processed] skewers Skewers (grade0), [food processed] paste Paste (grade0), [food processed] biscuits Biscuits (grade0), [food processed] pickled goods Pickled Goods (grade0). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Finesmith, "Finesmith" },                                                                   // Finesmith - Can produce:  [valuable] amber Amber (grade3), [tools] simple tools Tools (grade3). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Fire_Shrine, "Fire Shrine" },                                                               // Fire Shrine - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Fish, "Fish" },                                                                             // Fish Mount - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fishing_Hut, "Fishing Hut" },                                                               // Fishing Hut - An advanced fishing hut. Can fish in large fishing ponds in addition to small ones. Can catch:  [food raw] fish Fish (grade2), [mat raw] scales Scales (grade2), [mat raw] algae Algae (grade2).
		{ BuildingTypes.Fishmen_Cave, "Fishmen Cave" },                                                             // Fishmen Cave - It looks abandoned, but what if it's not? A terrible fishy smell comes from within.
		{ BuildingTypes.Fishmen_Lighthouse, "Fishmen Lighthouse" },                                                 // Fishmen Lighthouse - Once upon a time, there must have been a coast and a harbor here. Now this place is haunted by Fishmen and the waters have withdrawn. An ominous light is coming from the top of the lighthouse.
		{ BuildingTypes.Fishmen_Lighthouse_Positive, "Fishmen Lighthouse Positive" },                               // Converted Fishmen Lighthouse - <color=#D6E54A>Harmony.</color> A tall bone structure built by the Fishmen. It has been repurposed and now provides 5 "[crafting] sea marrow" Sea Marrow per minute. Counts as 16 decorations of its type.
		{ BuildingTypes.Fishmen_Outpost, "Fishmen Outpost" },                                                       // Fishmen Outpost - Fishmen aren't usually a threat, but they can be a real nuisance after a while.
		{ BuildingTypes.Fishmen_Soothsayer, "Fishmen Soothsayer" },                                                 // Fishman Soothsayer - An old wandering soothsayer, teeming with magic. He does not speak, though you can hear his voice. His eyes are blank, yet you can feel his gaze. He is not afraid of death, he stands by its side.
		{ BuildingTypes.Fishmen_Totem, "Fishmen Totem" },                                                           // Fishmen Totem - A sinister structure made out of bones. Smells like Fishmen magic.
		{ BuildingTypes.Flawless_Brewery, "Flawless Brewery" },                                                     // Flawless Brewery - Can produce:  [needs] ale Ale (grade3), [food processed] porridge Porridge (grade3), [packs] pack of crops Pack of Crops (grade3). Has improved production.Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Flawless_Cellar, "Flawless Cellar" },                                                       // Flawless Cellar - Can produce:  [needs] wine Wine (grade3), [food processed] pickled goods Pickled Goods (grade3), [packs] pack of provisions Pack of Provisions (grade3). Has improved production.Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Flawless_Cooperage, "Flawless Cooperage" },                                                 // Flawless Cooperage - Can produce:  [vessel] barrels Barrels (grade3), [needs] coats Coats (grade3), [packs] pack of luxury goods Pack of Luxury Goods (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Druid, "Flawless Druid" },                                                         // Flawless Druid's Hut - Can produce:  [crafting] oil Oil (grade3), [needs] tea Tea (grade3), [needs] coats Coats (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Leatherworks, "Flawless Leatherworks" },                                           // Flawless Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade3), [needs] training gear Training Gear (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Rain_Mill, "Flawless Rain Mill" },                                                 // Flawless Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade3), [food processed] paste Paste (grade3). Has improved production.Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Flawless_Smelter, "Flawless Smelter" },                                                     // Flawless Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade3), [food processed] pie Pie (grade3). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Flower_Bed, "Flower Bed" },                                                                 // Flower Bed - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Foragers_Camp, "Forager's Camp" },                                                          // Foragers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] grain Grain (grade2), [food raw] roots Roots (grade2), [food raw] vegetables Vegetables (grade2).
		{ BuildingTypes.ForsakenCrypt, "ForsakenCrypt" },                                                           // Forsaken Crypt - The Forsaken Crypt hides a frustrated, poor spirit. This place seems to have been plundered a long time ago.
		{ BuildingTypes.Forum, "Forum" },                                                                           // Forum - A place where villagers can fulfill their need for: Brawling,  Luxury. Passive effects: Public Performances.
		{ BuildingTypes.Fountain, "Fountain" },                                                                     // Marble Fountain - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.Fox_Fence, "Fox Fence" },                                                                   // Overgrown Fence - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fox_Fence_Corner, "Fox Fence Corner" },                                                     // Overgrown Fence Corner - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Fox_House, "Fox House" },                                                                   // Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 2 inhabitants.
		{ BuildingTypes.FoxBattleground_T1, "FoxBattleground_T1" },                                                 // Fallen Fox Scouts - A group of fallen Fox scouts. They must have been sent to search the area to make sure it was safe... Apparently, something stood in their way. This find is causing grief among the Fox population.
		{ BuildingTypes.Frog_House, "Frog House" },                                                                 // Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 2 inhabitants.
		{ BuildingTypes.Frog_Tree, "Frog Tree" },                                                                   // Evergreen Shrub - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.FrogBattleground_T1, "FrogBattleground_T1" },                                               // Fallen Frog Architects - A group of fallen Frog architects. It seems they were in the middle of building some sort of monument. The mere sight of these bodies causes unrest among the Frog population.
		{ BuildingTypes.Fuming_Machinery, "Fuming Machinery" },                                                     // Fuming Machinery - Old Rainpunk machinery left unsupervised. Unstable rainwater fumes fill the area.
		{ BuildingTypes.Furnace, "Furnace" },                                                                       // Furnace - Can produce:  [food processed] pie Pie (grade2), [food processed] skewers Skewers (grade2), [metal] copper bar Copper Bars (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Gate, "Gate" },                                                                             // Gate - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths. Counts as 3 decorations of its type.
		{ BuildingTypes.Giant_Stormbird, "Giant Stormbird" },                                                       // Giant Stormbird's Nest - A never-before encountered Stormbird subspecies. She is fiercely guarding her nest. The clouds around the settlement have begun to darken...
		{ BuildingTypes.Glade_Trader_The_Hermit, "Glade Trader - The Hermit" },                                     // Wandering Merchant - Hermit - The Hermit rarely visits royal settlements, and actively avoids the Crown's officials. But he seems eager to trade with you.
		{ BuildingTypes.Glade_Trader_The_Seer, "Glade Trader - The Seer" },                                         // Wandering Merchant - Seer - A strange woman is observing the settlement from afar.
		{ BuildingTypes.Glade_Trader_The_Shaman, "Glade Trader - The Shaman" },                                     // Wandering Merchant - Shaman - A mysterious and imposing figure has been spotted near the settlement. He is pulling a wagon full of herbs and ointments.
		{ BuildingTypes.Gold_Stag, "Gold Stag" },                                                                   // Golden Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.Gold_Treasure_Stag, "Gold Treasure Stag" },                                                 // Golden Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Golden_Leaf, "Golden Leaf" },                                                               // Golden Leaf Plant - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Granary, "Granary" },                                                                       // Granary - Can produce:  [food processed] pickled goods Pickled Goods (grade2), [mat processed] fabric Fabric (grade2), [packs] pack of crops Pack of Crops (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Greenhouse_Workshop, "Greenhouse Workshop" },                                               // Greenhouse - Uses Drizzle Water to grow crops regardless of the season. Must be placed on fertile soil. Can produce:  [food raw] mushrooms Mushrooms (grade2), [food raw] herbs Herbs (grade2)
		{ BuildingTypes.Grill, "Grill" },                                                                           // Grill - Can produce:  [food processed] skewers Skewers (grade3), [food processed] paste Paste (grade2), [metal] copper bar Copper Bars (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Grove, "Grove" },                                                                           // Forester's Hut - Uses nearby farm fields to grow  [mat raw] resin Resin (grade2), [metal] crystalized dew Crystalized Dew (grade2).
		{ BuildingTypes.Guild_House, "Guild House" },                                                               // Guild House - A place where villagers can fulfill their need for: Luxury,  Education. Passive effects: The Guild's Welfare.
		{ BuildingTypes.Hallowed_Herb_Garden, "Hallowed Herb Garden" },                                             // Hallowed Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade3), [food raw] herbs Herbs (grade3). Has improved efficiency and more worker slots.
		{ BuildingTypes.Hallowed_SmallFarm, "Hallowed SmallFarm" },                                                 // Hallowed Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade3), [food raw] grain Grain (grade3). Has improved efficiency and more worker slots.
		{ BuildingTypes.Harmony_Spirit_Altar, "Harmony Spirit Altar" },                                             // Harmony Spirit Altar - An old altar found in the wilds. The ancient language carved into the stone proclaims: "Light a fire at the altar to gain the blessing of the Spirit of Harmony".
		{ BuildingTypes.Harmony_Spirit_Altar_Positive, "Harmony Spirit Altar Positive" },                           // Converted Harmony Spirit Altar - <color=#D6E54A>Harmony.</color> When your villagers' needs are met, Harmony is fostered. Each unique service building adds 2 to Global Resolve. Counts as 9 decorations of its type.
		{ BuildingTypes.Harpy_House, "Harpy House" },                                                               // Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 2 inhabitants.
		{ BuildingTypes.HarpyBattleground_T1, "HarpyBattleground_T1" },                                             // Fallen Harpy Scientists - A group of fallen Harpy scientists... The sight causes unrest amongst the Harpy population.
		{ BuildingTypes.Harvester_Camp, "Harvester Camp" },                                                         // Harvesters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] plant fibre Plant Fiber (grade2), [mat raw] reeds Reed (grade2), [mat raw] leather Leather (grade2).
		{ BuildingTypes.Haunted_Ruined_Beaver_House, "Haunted Ruined Beaver House" },                               // Haunted Beaver House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Brewery, "Haunted Ruined Brewery" },                                         // Haunted Brewery - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Cellar, "Haunted Ruined Cellar" },                                           // Haunted Cellar - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Cooperage, "Haunted Ruined Cooperage" },                                     // Haunted Cooperage - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Druid, "Haunted Ruined Druid" },                                             // Haunted Druid's Hut - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Fox_House, "Haunted Ruined Fox House" },                                     // Haunted Fox House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Frog_House, "Haunted Ruined Frog House" },                                   // Haunted Frog House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Guild_House, "Haunted Ruined Guild House" },                                 // Haunted Guild House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Harpy_House, "Haunted Ruined Harpy House" },                                 // Haunted Harpy House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Herb_Garden, "Haunted Ruined Herb Garden" },                                 // Haunted Herb Garden - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Human_House, "Haunted Ruined Human House" },                                 // Haunted Human House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Leatherworks, "Haunted Ruined Leatherworks" },                               // Haunted Leatherworker - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Lizard_House, "Haunted Ruined Lizard House" },                               // Haunted Lizard House - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Market, "Haunted Ruined Market" },                                           // Haunted Market - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Rainmill, "Haunted Ruined Rainmill" },                                       // Haunted Rain Mill - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_SmallFarm, "Haunted Ruined SmallFarm" },                                     // Haunted Small Farm - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Smelter, "Haunted Ruined Smelter" },                                         // Haunted Smelter - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Haunted_Ruined_Temple, "Haunted Ruined Temple" },                                           // Haunted Temple - This building is haunted by evil spirits. They are protecting it because it's one of a kind. It can be rebuilt or destroyed.
		{ BuildingTypes.Herb_Garden, "Herb Garden" },                                                               // Herb Garden - Uses nearby farm fields to grow  [food raw] roots Roots (grade1), [food raw] herbs Herbs (grade2).
		{ BuildingTypes.Herbalists_Camp, "Herbalist's Camp" },                                                      // Herbalists' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] herbs Herbs (grade2), [food raw] berries Berries (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ BuildingTypes.Holy_Guild_House, "Holy Guild House" },                                                     // Holy Guild House - A place where villagers can fulfill their need for:  Luxury,  Education. Has an additional effect. Passive effects: Guild House, The Guild's Welfare.
		{ BuildingTypes.Holy_Market, "Holy Market" },                                                               // Holy Market - A place where villagers can fulfill their need for:  Leisure,  Treatment. Has an additional effect. Passive effects: Ale and Hearty, Market Carts.
		{ BuildingTypes.Holy_Temple, "Holy Temple" },                                                               // Holy Temple - A place where villagers can fulfill their need for:  Religion,  Education. Has an additional effect. Passive effects: Sacrament of the Flame, Consecrated Scrolls.
		{ BuildingTypes.Homestead, "Homestead" },                                                                   // Homestead - Uses a large area of nearby farm fields to grow  [food raw] grain Grain (grade3), [mat raw] plant fibre Plant Fiber (grade3), [food raw] vegetables Vegetables (grade2), [food raw] mushrooms Mushrooms (grade2).
		{ BuildingTypes.Human_House, "Human House" },                                                               // Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 2 inhabitants.
		{ BuildingTypes.HumanBattleground_T1, "HumanBattleground_T1" },                                             // Fallen Human Explorers - A group of fallen Human explorers. They were probably looking for a place to settle, far from the Queen's watchful eyes... The sight causes uneasiness amongst the Human population.
		{ BuildingTypes.Hydrant, "Hydrant" },                                                                       // Hydrant - A small storage for "blight fuel" Purging Fire. Blight Fighters will use it to restock their fuel when fighting Blightrot in the storm.
		{ BuildingTypes.Industrial_Chimney, "Industrial Chimney" },                                                 // Industrial Chimney - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Infected_Mole, "Infected Mole" },                                                           // Infected Drainage Mole - One of the mythical guardians of the forest - still alive, but plagued by a mysterious disease. The Blightrot has taken over his mind, causing an unstoppable rage. You can try to heal him... or whisper prayers to its new masters.
		{ BuildingTypes.Infected_Tree, "Infected Tree" },                                                           // Withered Tree - The once mighty tree has been deformed by the Blightrot living in its root system. The Blightrot poisons the tree's tissues, leading to its long-lasting degradation.
		{ BuildingTypes.Kelpie, "Kelpie" },                                                                         // River Kelpie - A legendary, shape-shifting aquatic spirit that lurks near water and mesmerizes travelers. It is said that whoever acquires the kelpie's bridle will be able to control it.
		{ BuildingTypes.Kiln, "Kiln" },                                                                             // Kiln - Can produce:  [crafting] coal Coal (grade3), [mat processed] bricks Bricks (grade1), [food processed] jerky Jerky (grade1). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Lamp, "Lamp" },                                                                             // Lamp - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Leaking_Cauldron, "Leaking Cauldron" },                                                     // Leaking Cauldron - An old, broken piece of Rainpunk technology. It's contaminating the soil around it.
		{ BuildingTypes.Leatherworks, "Leatherworks" },                                                             // Leatherworker - Can produce:  [vessel] waterskin Waterskins (grade3), [needs] boots Boots (grade2), [needs] training gear Training Gear (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Lightning_Catcher, "Lightning Catcher" },                                                   // Lightning Catcher - A weird contraption that attracts lightning. Its proximity to the settlement might have grave consequences.
		{ BuildingTypes.Lizard_House, "Lizard House" },                                                             // Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 2 inhabitants.
		{ BuildingTypes.Lizard_Post, "Lizard Post" },                                                               // Lizard Post - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.LizardBattleground_T1, "LizardBattleground_T1" },                                           // Fallen Lizard Hunters - A group of fallen Lizard hunters... The sight causes unrest amongst the Lizard population.
		{ BuildingTypes.Lore_Tablet_1, "Lore Tablet 1" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> Born in the Blightstorm, she will climb the Red Mountain. The fires beneath her feet shall hiss her name. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_2, "Lore Tablet 2" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> Though sealed beneath the muddy ground, their voices ring loud and clear. Maddening, alluring. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_3, "Lore Tablet 3" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> The true rulers of this world shall rise again and break the seals that bind them. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_4, "Lore Tablet 4" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> Envy the lesser species, for they do not yet know what lies beneath. But in time, they will understand. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_5, "Lore Tablet 5" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> It pours, yet it does not flood. As if the earth itself greedily drinks every last drop of this eternal curse. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_6, "Lore Tablet 6" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> Embrace the Eternal Rain, for it powers the engine of progress. Counts as 2 decorations of its type.
		{ BuildingTypes.Lore_Tablet_7, "Lore Tablet 7" },                                                           // Inscribed Monolith - <color=#D6E54A>Harmony.</color> Don't let the pleasant sparking of the raindrops fool you. This is just the first sign of your flesh rotting. Counts as 2 decorations of its type.
		{ BuildingTypes.Lumbermill, "Lumbermill" },                                                                 // Lumber Mill - Can produce:  [mat processed] planks Planks (grade3), [needs] scrolls Scrolls (grade1), [packs] pack of trade goods Pack of Trade Goods (grade1). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Main_Storage_not_buildable, "Main Storage (not-buildable)" },                               // Main Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
		{ BuildingTypes.Makeshift_Post, "Makeshift Post" },                                                         // Makeshift Post - Can produce:  [packs] pack of crops Pack of Crops (grade0), [packs] pack of provisions Pack of Provisions (grade0), [packs] pack of building materials Pack of Building Materials (grade0). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Manufactory, "Manufactory" },                                                               // Manufactory - Can produce:  [mat processed] fabric Fabric (grade2), [vessel] barrels Barrels (grade2), [crafting] dye Dye (grade2). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Market, "Market" },                                                                         // Market - A place where villagers can fulfill their need for: Leisure,  Treatment. Passive effects: Market Carts.
		{ BuildingTypes.Merchant_Ship_Wreck, "Merchant Ship Wreck" },                                               // Merchant Shipwreck - How powerful must the storm surge have been to carry this shattered wreck all the way here? Perhaps in the distant past, there was a sea here? It looks as if it’s been lying here for centuries. Strange voices can be heard coming from below deck...
		{ BuildingTypes.Mine, "Mine" },                                                                             // Mine - Can only be placed on coal, copper, or salt veins. Can produce:  [crafting] coal Coal (grade2), [metal] copper ore Copper Ore (grade2), [crafting] salt Salt (grade2).
		{ BuildingTypes.Mistworm_T1, "Mistworm_T1" },                                                               // Hungry Mistworm - A small, yet dangerous creature. It normally lives underground or hides in the mist, but this one seems to be more courageous than its kin.
		{ BuildingTypes.Mole, "Mole" },                                                                             // Drainage Mole - A wild beast that usually lives underground. It was forced to the surface for some reason.
		{ BuildingTypes.Monastery, "Monastery" },                                                                   // Monastery - A place where villagers can fulfill their need for: Religion,  Leisure. Passive effects: The Green Brew.
		{ BuildingTypes.Monolith, "Monolith" },                                                                     // Obelisk - A mystical stone monument. Unknown runes are carved all over its surface.
		{ BuildingTypes.Monolith_Positive, "Monolith Positive" },                                                   // Obelisk - <color=#8AAFFD>Aesthetics.</color> The symbols carved into this monumental stone bear an eerie resemblance to the forest and corruption. Decreases Hostility by 10 points and increases the Ancient Hearth's resistance by 100.
		{ BuildingTypes.Moument_Of_Greed, "Moument of Greed" },                                                     // Monument of Greed - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Mushroom_Decor, "Mushroom Decor" },                                                         // Decorative Fungus - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Nightfern, "Nightfern" },                                                                   // Nightfern - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Noxious_Machinery, "Noxious Machinery" },                                                   // Noxious Machinery - A damaged and abandoned rainpunk contraption. The area was probably deserted because of a significant explosion risk. The machine's valves emit a distinct Blightrot odor.
		{ BuildingTypes.Ornate_Column, "Ornate Column" },                                                           // Ornate Column - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Pantry, "Pantry" },                                                                         // Pantry - Can produce:  [food processed] porridge Porridge (grade2), [food processed] pie Pie (grade2), [packs] pack of luxury goods Pack of Luxury Goods (grade2). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Path, "Path" },                                                                             // Path - A simple path, doesn't cost any resources. Grants a 5% speed increase to villagers.
		{ BuildingTypes.Paved_Road, "Paved Road" },                                                                 // Paved Road - A road made out of stone. Grants a 15% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
		{ BuildingTypes.PetrifiedTree_T1, "PetrifiedTree_T1" },                                                     // Petrified Tree - A strange tree that’s been turned to stone by the rain. It's radiating its sickness to the other trees around it.
		{ BuildingTypes.Pipe, "Pipe" },                                                                             // Pipe - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Cross, "Pipe Cross" },                                                                 // Pipe Cross - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Elbow, "Pipe Elbow" },                                                                 // Pipe Elbow - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_End, "Pipe End" },                                                                     // Pipe Ending - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_T_Cross, "Pipe T Cross" },                                                             // Pipe T-Connector - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Pipe_Valve, "Pipe Valve" },                                                                 // Valve - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Plantation, "Plantation" },                                                                 // Plantation - Uses nearby farm fields to grow  [food raw] berries Berries (grade2), [mat raw] plant fibre Plant Fiber (grade2).
		{ BuildingTypes.Port, "Port" },                                                                             // Strider Port - From this ancient port, expeditions can be launched to search the nearby swamps for blueprints and treasure in the submerged ruins of former settlements.
		{ BuildingTypes.Press, "Press" },                                                                           // Press - Can produce:  [crafting] oil Oil (grade3), [crafting] flour Flour (grade1), [food processed] paste Paste (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Primitive_Fishing_Hut, "Primitive Fishing Hut" },                                           // Small Fishing Hut - A crude version of a normal fishing hut. It's slower, and can only fish in small fishing ponds. Can catch:  [food raw] fish Fish (grade1), [mat raw] scales Scales (grade1), [mat raw] algae Algae (grade1).
		{ BuildingTypes.Primitive_Foragers_Camp, "Primitive Forager's Camp" },                                      // Small Foragers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] grain Grain (grade1), [food raw] roots Roots (grade1), [food raw] vegetables Vegetables (grade1).
		{ BuildingTypes.Primitive_Herbalists_Camp, "Primitive Herbalist's Camp" },                                  // Small Herbalists' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] herbs Herbs (grade1), [food raw] berries Berries (grade1), [food raw] mushrooms Mushrooms (grade1).
		{ BuildingTypes.Primitive_Trappers_Camp, "Primitive Trapper's Camp" },                                      // Small Trappers' Camp - A small, crude version of a specialized gathering camp. It's slower, and can only collect resources from small gathering nodes. Can collect:  [food raw] meat Meat (grade1), [food raw] insects Insects (grade1), [food raw] eggs Eggs (grade1).
		{ BuildingTypes.Provisioner, "Provisioner" },                                                               // Provisioner - Can produce:  [crafting] flour Flour (grade2), [vessel] barrels Barrels (grade2), [packs] pack of provisions Pack of Provisions (grade2). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Purged_Beaver_House, "Purged Beaver House" },                                               // Purified Beaver House - A building specially designed for Beavers. Must be built near a Hearth. Fulfills the need for Beaver housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Fox_House, "Purged Fox House" },                                                     // Purified Fox House - A building specially designed for Foxes. Must be built near a Hearth. Fulfills the need for Fox housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Frog_House, "Purged Frog House" },                                                   // Purified Frog House - A building specially designed for Frogs. Must be built near a Hearth. Fulfills the need for Frog housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Harpy_House, "Purged Harpy House" },                                                 // Purified Harpy House - A building specially designed for Harpies. Must be built near a Hearth. Fulfills the need for Harpy housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Human_House, "Purged Human House" },                                                 // Purified Human House - A building specially designed for Humans. Must be built near a Hearth. Fulfills the need for Human housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Purged_Lizard_House, "Purged Lizard House" },                                               // Purified Lizard House - A building specially designed for Lizards. Must be built near a Hearth. Fulfills the need for Lizard housing and can accommodate 6 inhabitants.
		{ BuildingTypes.Rain_Catcher, "Rain Catcher" },                                                             // Rain Collector - Can collect rainwater used for crafting and powering Rain Engines in production buildings. The type of collected rainwater depends on the season. Has a tank capacity of 50.
		{ BuildingTypes.Rain_Mill, "Rain Mill" },                                                                   // Rain Mill - Can produce:  [crafting] flour Flour (grade3), [needs] scrolls Scrolls (grade1), [food processed] paste Paste (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Rain_Totem, "Rain Totem" },                                                                 // Rain Spirit Totem - A totem built by the Fishmen. It seems to have affected the weather, making the rain heavier.
		{ BuildingTypes.Rain_Totem_Positive, "Rain Totem Positive" },                                               // Converted Rain Totem - <color=#D6E54A>Harmony.</color> The ritual was completed, but a faint, rhythmic thumping can still be heard coming from the totem. Decreases Hostility by 50. Counts as 4 decorations of its type.
		{ BuildingTypes.Rainpunk_Barrels, "Rainpunk Barrels" },                                                     // Rainpunk Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Rainpunk_Drill_Coal, "Rainpunk Drill - Coal" },                                             // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Drill_Copper, "Rainpunk Drill - Copper" },                                         // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Drill_Salt, "Rainpunk Drill - Salt" },                                             // Rainpunk Drill - One of the Brass Order's curious little inventions. It appears to be broken.
		{ BuildingTypes.Rainpunk_Foundry, "Rainpunk Foundry" },                                                     // Rainpunk Foundry - A very advanced piece of technology. Can produce  [mat processed] parts Parts (grade3), hearth parts Wildfire Essence (grade3). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.RainpunkFactory, "RainpunkFactory" },                                                       // Destroyed Rainpunk Foundry - An old, abandoned piece of advanced Rainpunk technology. It seems extremely unstable - but maybe it can be rebuilt...
		{ BuildingTypes.Ranch, "Ranch" },                                                                           // Ranch - Can produce:  [food raw] meat Meat (grade1), [mat raw] leather Leather (grade1), [food raw] eggs Eggs (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Reinforced_Road, "Reinforced Road" },                                                       // Reinforced Road - A road reinforced with copper. Grants a 25% speed increase to villagers. Road construction cost is not affected by effects, modifiers, or perks.
		{ BuildingTypes.RewardChest_T1, "RewardChest_T1" },                                                         // Small Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.RewardChest_T2, "RewardChest_T2" },                                                         // Medium Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.RewardChest_T3, "RewardChest_T3" },                                                         // Large Abandoned Cache - An abandoned cache of goods. This could be a lost shipment - or something much more valuable.
		{ BuildingTypes.Road_Sign, "Road Sign" },                                                                   // Road Sign - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher, "Ruined Advanced Rain Catcher" },                             // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Advanced_Rain_Catcher_no_Reward, "Ruined Advanced Rain Catcher (no reward)" },       // Advanced Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Alchemist, "Ruined Alchemist" },                                                     // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Alchemist_no_Reward, "Ruined Alchemist (no reward)" },                               // Alchemist's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Apothecary, "Ruined Apothecary" },                                                   // Apothecary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Apothecary_no_Reward, "Ruined Apothecary (no reward)" },                             // Apothecary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Artisan, "Ruined Artisan" },                                                         // Artisan - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Artisan_no_Reward, "Ruined Artisan (no reward)" },                                   // Artisan - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Bakery, "Ruined Bakery" },                                                           // Bakery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Bakery_no_Reward, "Ruined Bakery (no reward)" },                                     // Bakery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Bath_House, "Ruined Bath House" },                                                   // Bath House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Bath_House_no_Reward, "Ruined Bath House (no reward)" },                             // Bath House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beanery, "Ruined Beanery" },                                                         // Beanery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Beanery_no_Reward, "Ruined Beanery (no reward)" },                                   // Beanery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beaver_House, "Ruined Beaver House" },                                               // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Beaver_House_no_Reward, "Ruined Beaver House (no reward)" },                         // Beaver House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Big_Shelter, "Ruined Big Shelter" },                                                 // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Big_Shelter_no_Reward, "Ruined Big Shelter (no reward)" },                           // Big Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brewery, "Ruined Brewery" },                                                         // Brewery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brewery_no_Reward, "Ruined Brewery (no reward)" },                                   // Brewery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brick_Oven, "Ruined Brick Oven" },                                                   // Brick Oven - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brick_Oven_no_Reward, "Ruined Brick Oven (no reward)" },                             // Brick Oven - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Brickyard, "Ruined Brickyard" },                                                     // Brickyard - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Brickyard_no_Reward, "Ruined Brickyard (no reward)" },                               // Brickyard - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Butcher, "Ruined Butcher" },                                                         // Butcher - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Butcher_no_Reward, "Ruined Butcher (no reward)" },                                   // Butcher - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cannery, "Ruined Cannery" },                                                         // Cannery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cannery_no_Reward, "Ruined Cannery (no reward)" },                                   // Cannery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Carpenter, "Ruined Carpenter" },                                                     // Carpenter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Carpenter_no_Reward, "Ruined Carpenter (no reward)" },                               // Carpenter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cellar, "Ruined Cellar" },                                                           // Cellar - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cellar_no_Reward, "Ruined Cellar (no reward)" },                                     // Cellar - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Clan_Hall, "Ruined Clan Hall" },                                                     // Clan Hall - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Clan_Hall_no_Reward, "Ruined Clan Hall (no reward)" },                               // Clan Hall - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Clay_Pit, "Ruined Clay Pit" },                                                       // Clay Pit - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Clay_Pit_no_Reward, "Ruined Clay Pit (no reward)" },                                 // Clay Pit - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cobbler, "Ruined Cobbler" },                                                         // Cobbler - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cobbler_no_Reward, "Ruined Cobbler (no reward)" },                                   // Cobbler - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cookhouse, "Ruined Cookhouse" },                                                     // Cookhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cookhouse_no_Reward, "Ruined Cookhouse (no reward)" },                               // Cookhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Cooperage, "Ruined Cooperage" },                                                     // Cooperage - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Cooperage_no_Reward, "Ruined Cooperage (no reward)" },                               // Cooperage - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Crude_Workstation_no_Reward, "Ruined Crude Workstation (no reward)" },               // Crude Workstation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Distillery, "Ruined Distillery" },                                                   // Distillery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Distillery_no_Reward, "Ruined Distillery (no reward)" },                             // Distillery - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Druid, "Ruined Druid" },                                                             // Druid's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Druid_no_Reward, "Ruined Druid (no reward)" },                                       // Druid's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Explorers_Lodge, "Ruined Explorers Lodge" },                                         // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Explorers_Lodge_no_Reward, "Ruined Explorers Lodge (no reward)" },                   // Explorers' Lodge - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Farm, "Ruined Farm" },                                                               // Homestead - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Farm_no_Reward, "Ruined Farm (no reward)" },                                         // Homestead - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Field_Kitchen_no_Reward, "Ruined Field Kitchen (no reward)" },                       // Field Kitchen - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Finesmith, "Ruined Finesmith" },                                                     // Finesmith - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Finesmith_no_Reward, "Ruined Finesmith (no reward)" },                               // Finesmith - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fishing_Hut, "Ruined Fishing Hut" },                                                 // Fishing Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Fishing_Hut_no_Reward, "Ruined Fishing Hut (no reward)" },                           // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fishing_Hut_Primitive_no_Reward, "Ruined Fishing Hut Primitive (no reward)" },       // Fishing Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Foragers_Camp, "Ruined Foragers Camp" },                                             // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Foragers_Camp_no_Reward, "Ruined Foragers Camp (no reward)" },                       // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Foragers_Camp_Primitive_no_Reward, "Ruined Foragers Camp Primitive (no reward)" },   // Foragers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Forum, "Ruined Forum" },                                                             // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Forum_no_Reward, "Ruined Forum (no reward)" },                                       // Forum - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Fox_House, "Ruined Fox House" },                                                     // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Fox_House_no_Reward, "Ruined Fox House (no reward)" },                               // Fox House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Frog_House_no_Reward, "Ruined Frog House (no reward)" },                             // Frog House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Furnace, "Ruined Furnace" },                                                         // Furnace - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Furnace_no_Reward, "Ruined Furnace (no reward)" },                                   // Furnace - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Granary, "Ruined Granary" },                                                         // Granary - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Granary_no_Reward, "Ruined Granary (no reward)" },                                   // Granary - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Greenhouse, "Ruined Greenhouse" },                                                   // Greenhouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Greenhouse_no_Reward, "Ruined Greenhouse (no reward)" },                             // Greenhouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Grill, "Ruined Grill" },                                                             // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grill_no_Reward, "Ruined Grill (no reward)" },                                       // Grill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grove, "Ruined Grove" },                                                             // Forester's Hut - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Grove_no_Reward, "Ruined Grove (no reward)" },                                       // Forester's Hut - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Guild_House, "Ruined Guild House" },                                                 // Guild House - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Guild_House_no_Reward, "Ruined Guild House (no reward)" },                           // Guild House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harpy_House, "Ruined Harpy House" },                                                 // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harpy_House_no_Reward, "Ruined Harpy House (no reward)" },                           // Harpy House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Harvester_Camp, "Ruined Harvester Camp" },                                           // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Harvester_Camp_no_Reward, "Ruined Harvester Camp (no reward)" },                     // Harvesters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herb_Garden, "Ruined Herb Garden" },                                                 // Herb Garden - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Herb_Garden_no_Reward, "Ruined Herb Garden (no reward)" },                           // Herb Garden - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herbalist_Camp, "Ruined Herbalist Camp" },                                           // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Herbalist_Camp_no_Reward, "Ruined Herbalist Camp (no reward)" },                     // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Herbalist_Camp_Primitive_no_Reward, "Ruined Herbalist Camp primitive (no reward)" }, // Herbalists' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Human_House, "Ruined Human House" },                                                 // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Human_House_no_Reward, "Ruined Human House (no reward)" },                           // Human House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Kiln, "Ruined Kiln" },                                                               // Kiln - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Kiln_no_Reward, "Ruined Kiln (no reward)" },                                         // Kiln - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Leatherworks, "Ruined Leatherworks" },                                               // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Leatherworks_no_Reward, "Ruined Leatherworks (no reward)" },                         // Leatherworker - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Lizard_House, "Ruined Lizard House" },                                               // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Lizard_House_no_Reward, "Ruined Lizard House (no reward)" },                         // Lizard House - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Lumbermill, "Ruined Lumbermill" },                                                   // Lumber Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Lumbermill_no_Reward, "Ruined Lumbermill (no reward)" },                             // Lumber Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Makeshift_Post_no_Reward, "Ruined Makeshift Post (no reward)" },                     // Makeshift Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Manufatory, "Ruined Manufatory" },                                                   // Manufactory - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Manufatory_no_Reward, "Ruined Manufatory (no reward)" },                             // Manufactory - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Market, "Ruined Market" },                                                           // Market - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Market_no_Reward, "Ruined Market (no reward)" },                                     // Market - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Mine_no_Reward, "Ruined Mine (no reward)" },                                         // Mine - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Monastery, "Ruined Monastery" },                                                     // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Monastery_no_Reward, "Ruined Monastery (no reward)" },                               // Monastery - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Pantry, "Ruined Pantry" },                                                           // Pantry - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Pantry_no_Reward, "Ruined Pantry (no reward)" },                                     // Pantry - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Plantation, "Ruined Plantation" },                                                   // Plantation - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Plantation_no_Reward, "Ruined Plantation (no reward)" },                             // Plantation - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Press, "Ruined Press" },                                                             // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Press_no_Reward, "Ruined Press (no reward)" },                                       // Press - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Provisioner, "Ruined Provisioner" },                                                 // Provisioner - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Provisioner_no_Reward, "Ruined Provisioner (no reward)" },                           // Provisioner - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Rain_Catcher_no_Reward, "Ruined Rain Catcher (no reward)" },                         // Rain Collector - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Rainmill, "Ruined Rainmill" },                                                       // Rain Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Rainmill_no_Reward, "Ruined Rainmill (no reward)" },                                 // Rain Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Ranch, "Ruined Ranch" },                                                             // Ranch - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Ranch_no_Reward, "Ruined Ranch (no reward)" },                                       // Ranch - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Scribe, "Ruined Scribe" },                                                           // Scribe - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Scribe_no_Reward, "Ruined Scribe (no reward)" },                                     // Scribe - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Sewer, "Ruined Sewer" },                                                             // Clothier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Sewer_no_Reward, "Ruined Sewer (no reward)" },                                       // Clothier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Shelter, "Ruined Shelter" },                                                         // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Shelter_no_Reward, "Ruined Shelter (no reward)" },                                   // Shelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_SmallFarm, "Ruined SmallFarm" },                                                     // Small Farm - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_SmallFarm_no_Reward, "Ruined SmallFarm (no reward)" },                               // Small Farm - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smelter, "Ruined Smelter" },                                                         // Smelter - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smelter_no_Reward, "Ruined Smelter (no reward)" },                                   // Smelter - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smithy, "Ruined Smithy" },                                                           // Smithy - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smithy_no_Reward, "Ruined Smithy (no reward)" },                                     // Smithy - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Smokehouse, "Ruined Smokehouse" },                                                   // Smokehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Smokehouse_no_Reward, "Ruined Smokehouse (no reward)" },                             // Smokehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Stamping_Mill, "Ruined Stamping Mill" },                                             // Stamping Mill - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Stamping_Mill_no_Reward, "Ruined Stamping Mill (no reward)" },                       // Stamping Mill - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Stonecutter_Camp, "Ruined Stonecutter Camp" },                                       // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Stonecutter_Camp_no_Reward, "Ruined Stonecutter Camp (no reward)" },                 // Stonecutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Storage, "Ruined Storage" },                                                         // Small Warehouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Storage_no_Reward, "Ruined Storage (no reward)" },                                   // Small Warehouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Supplier, "Ruined Supplier" },                                                       // Supplier - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Supplier_no_Reward, "Ruined Supplier (no reward)" },                                 // Supplier - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tavern, "Ruined Tavern" },                                                           // Tavern - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tavern_no_Reward, "Ruined Tavern (no reward)" },                                     // Tavern - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tea_Doctor, "Ruined Tea Doctor" },                                                   // Tea Doctor - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tea_Doctor_no_Reward, "Ruined Tea Doctor (no reward)" },                             // Tea Doctor - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tea_House, "Ruined Tea House" },                                                     // Teahouse - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tea_House_no_Reward, "Ruined Tea House (no reward)" },                               // Teahouse - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Temple, "Ruined Temple" },                                                           // Temple - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Temple_no_Reward, "Ruined Temple (no reward)" },                                     // Temple - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tinctury, "Ruined Tinctury" },                                                       // Tinctury - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tinctury_no_Reward, "Ruined Tinctury (no reward)" },                                 // Tinctury - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Tinkerer, "Ruined Tinkerer" },                                                       // Tinkerer - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Tinkerer_no_Reward, "Ruined Tinkerer (no reward)" },                                 // Tinkerer - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Toolshop, "Ruined Toolshop" },                                                       // Toolshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Toolshop_no_Reward, "Ruined Toolshop (no reward)" },                                 // Toolshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trading_Post_no_Reward, "Ruined Trading Post (no reward)" },                         // Trading Post - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trappers_Camp, "Ruined Trappers Camp" },                                             // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Trappers_Camp_no_Reward, "Ruined Trappers Camp (no reward)" },                       // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Trappers_Camp_Primitive_no_Reward, "Ruined Trappers Camp Primitive (no reward)" },   // Trappers' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Weaver, "Ruined Weaver" },                                                           // Weaver - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Weaver_no_Reward, "Ruined Weaver (no reward)" },                                     // Weaver - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Woodcutters_Camp, "Ruined Woodcutters Camp" },                                       // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Woodcutters_Camp_no_Reward, "Ruined Woodcutters Camp (no reward)" },                 // Woodcutters' Camp - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Ruined_Workshop, "Ruined Workshop" },                                                       // Workshop - A building destroyed by the storm. It can be rebuilt or salvaged.
		{ BuildingTypes.Ruined_Workshop_no_Reward, "Ruined Workshop (no reward)" },                                 // Workshop - A building destroyed by the storm. It can be rebuilt or demolished.
		{ BuildingTypes.Sacrifice_Totem, "Sacrifice Totem" },                                                       // Totem of Denial - A religious structure built by the Fishmen. It interferes with the Hearth in the center of the settlement.
		{ BuildingTypes.Sacrifice_Totem_Positive, "Sacrifice Totem Positive" },                                     // Converted Totem of Denial - <color=#D6E54A>Harmony.</color> Repurposed Fishmen magic can be very useful... but let's hope we don't suffer the same fate as the priestess Ysabelle. Increases Global Resolve by +3. Counts as 4 decorations of its type.
		{ BuildingTypes.Scarlet_Decor, "Scarlet Decor" },                                                           // Thorny Reed - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Scorpion_1, "Scorpion 1" },                                                                 // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Scorpion_2, "Scorpion 2" },                                                                 // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Scorpion_3, "Scorpion 3" },                                                                 // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Scribe, "Scribe" },                                                                         // Scribe - Can produce:  [needs] scrolls Scrolls (grade3), [packs] pack of trade goods Pack of Trade Goods (grade2), [needs] ale Ale (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Seal, "Seal" },                                                                             // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Seal_Guidepost, "Seal Guidepost" },                                                         // Guidance Stone - It is not known where the guidance stones came from or what their original purpose was, but they are imbued with magic and always point in the direction of a nearby seal.
		{ BuildingTypes.Seal_High_Diff, "Seal High Diff" },                                                         // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Seal_Low_Diff, "Seal Low Diff" },                                                           // Ancient Seal - Evil has survived. The Sealed Ones enter our realm through this broken seal. Terrible plagues are sent to destroy us. Collect the lost fragments of the Ancient Guardian to summon it and close the seal.
		{ BuildingTypes.Sealed_Biome_Shrine, "Sealed Biome Shrine" },                                               // Beacon Tower - A powerful, ancient structure that allows you to summon aid directly from the Citadel. Grants access to three types of temporary support abilities.
		{ BuildingTypes.SealedTomb_T1, "SealedTomb_T1" },                                                           // Open Vault - An open entrance to an ancient dungeon. Strange sounds can be heard coming from inside.
		{ BuildingTypes.Shelter, "Shelter" },                                                                       // Shelter - Can accommodate most villagers, but won't satisfy the need for species-specific housing. Has to be built near a Hearth. Can house 3 residents.
		{ BuildingTypes.Signboard, "Signboard" },                                                                   // Signboard - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths.
		{ BuildingTypes.Small_Hearth, "Small Hearth" },                                                             // Ancient Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
		{ BuildingTypes.SmallFarm, "SmallFarm" },                                                                   // Small Farm - Uses nearby farm fields to grow  [food raw] vegetables Vegetables (grade1), [food raw] grain Grain (grade2).
		{ BuildingTypes.Smelter, "Smelter" },                                                                       // Smelter - Can produce:  [metal] copper bar Copper Bars (grade3), [needs] training gear Training Gear (grade2), [food processed] pie Pie (grade1). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Smithy, "Smithy" },                                                                         // Smithy - Can produce:  [tools] simple tools Tools (grade2), [mat processed] pipe Pipes (grade2), [packs] pack of trade goods Pack of Trade Goods (grade2). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Smokehouse, "Smokehouse" },                                                                 // Smokehouse - Can produce:  [food processed] jerky Jerky (grade3), [vessel] pottery Pottery (grade1), [needs] incense Incense (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Snake_1, "Snake 1" },                                                                       // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Snake_2, "Snake 2" },                                                                       // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Snake_3, "Snake 3" },                                                                       // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Spider_1, "Spider 1" },                                                                     // Archaeological Discovery - Royal archaeologists are certain that a phenomenal discovery is hidden here. The Queen offers a generous reward for unearthing this ancient skeleton. This event is multi-stage and includes excavation, conservation, and reconstruction of the skeleton.
		{ BuildingTypes.Spider_2, "Spider 2" },                                                                     // Archaeological Excavation - After successfully excavating most of the ancient bones, they now need to be carefully conserved before proceeding to the reconstruction stage. However, the creature has not yet been identified.
		{ BuildingTypes.Spider_3, "Spider 3" },                                                                     // Archaeological Reconstruction - Archaeologists are ready to begin the final stage - reconstruction. A mythical creature is finally being unearthed. Huge bones are put together, revealing the full form of the monster that once inhabited this land.
		{ BuildingTypes.Stamping_Mill, "Stamping Mill" },                                                           // Stamping Mill - Can produce:  [mat processed] bricks Bricks (grade2), [crafting] flour Flour (grade2), [metal] copper bar Copper Bars (grade2). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Stone_Fence, "Stone Fence" },                                                               // Stone Fence - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Stone_Fence_Corner, "Stone Fence Corner" },                                                 // Stone Fence Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Stonecutters_Camp, "Stonecutter's Camp" },                                                  // Stonecutters' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [mat raw] stone Stone (grade2), [mat raw] clay Clay (grade2), [crafting] sea marrow Sea Marrow (grade2).
		{ BuildingTypes.Storage_buildable, "Storage (buildable)" },                                                 // Small Warehouse - Stores a large amount of goods and protects them from the rain. Workers always deliver and take goods from the Warehouse nearest to them.
		{ BuildingTypes.Stormbird_Positive, "Stormbird Positive" },                                                 // Tamed Stormbird - <color=#D6E54A>Harmony.</color> The nest of a tamed Stormbird. It provides 5 "[food raw] eggs" Eggs per minute and increases Harpy Resolve by +3. Counts as 16 decorations of its type.
		{ BuildingTypes.Supplier, "Supplier" },                                                                     // Supplier - Can produce:  [crafting] flour Flour (grade2), [mat processed] planks Planks (grade2), [vessel] waterskin Waterskins (grade2). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Tavern, "Tavern" },                                                                         // Tavern - A place where villagers can fulfill their need for: Leisure,  Luxury. Passive effects: Gleeman's Tales.
		{ BuildingTypes.Tea_Doctor, "Tea Doctor" },                                                                 // Tea Doctor - A place where villagers can fulfill their need for: Treatment,  Religion. Passive effects: Vitality.
		{ BuildingTypes.Tea_House, "Tea House" },                                                                   // Teahouse - Can produce:  [needs] tea Tea (grade3), [needs] incense Incense (grade2), [vessel] waterskin Waterskins (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Temple, "Temple" },                                                                         // Temple - A place where villagers can fulfill their need for: Religion,  Education. Passive effects: Sacrament of the Flame.
		{ BuildingTypes.Temporary_Hearth_buildable, "Temporary Hearth (buildable)" },                               // Small Hearth - Reduces Hostility and serves as a meeting place. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will use another Hearth instead. Can't be built too close to other Hearths.
		{ BuildingTypes.Temporary_Hearth_not_buildable, "Temporary Hearth (not-buildable)" },                       // Small Hearth - The heart of the colony is protected by the Holy Flame. Villagers gather here to rest, eat, and receive clothing. If the fire goes out, people will lose hope.
		{ BuildingTypes.Termite_Burrow, "Termite Burrow" },                                                         // Stonetooth Termite Burrow - An aggressive, parasitic species, able to eat and digest even the hardest materials.
		{ BuildingTypes.Termite_Burrow_Positive, "Termite Burrow Positive" },                                       // Termite Nest - <color=#D6E54A>Harmony.</color> A contained stonetooth termite burrow. Provides 5 "[food raw] insects" Insects per minute. Counts as 4 decorations of its type.
		{ BuildingTypes.TI_AncientShrine_T1, "TI AncientShrine_T1" },                                               // Ancient Shrine - An ominous shrine from a long forgotten era. It's dangerous, but it might hold some ancient knowledge useful to the crown.
		{ BuildingTypes.Tinctury, "Tinctury" },                                                                     // Tinctury - Can produce:  [crafting] dye Dye (grade3), [needs] ale Ale (grade2), [needs] wine Wine (grade1). Can use: "[water] drizzle water" Drizzle Water.
		{ BuildingTypes.Tinkerer, "Tinkerer" },                                                                     // Tinkerer - Can produce:  [tools] simple tools Tools (grade2), [needs] training gear Training Gear (grade2), [vessel] pottery Pottery (grade2). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Toolshop, "Toolshop" },                                                                     // Toolshop - Can produce:  [tools] simple tools Tools (grade3), [mat processed] pipe Pipes (grade2), [needs] boots Boots (grade2). Can use: "[water] storm water" Storm Water.
		{ BuildingTypes.Tower, "Tower" },                                                                           // Wall Crossing - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Town_Board, "Town Board" },                                                                 // Town Board - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 2 decorations of its type.
		{ BuildingTypes.Traders_Cemetery, "Traders Cemetery" },                                                     // Hidden Trader Cemetery - A cemetery full of traders killed by desperate viceroys. What drove them to commit such heinous crimes? Was it out of greed, or necessity?
		{ BuildingTypes.Trading_Post, "Trading Post" },                                                             // Trading Post - Traders from the Smoldering City can station here and offer their wares.
		{ BuildingTypes.Trappers_Camp, "Trapper's Camp" },                                                          // Trappers' Camp - An advanced gathering camp. Can collect resources from large and giant gathering nodes in addition to small ones. Can collect:  [food raw] meat Meat (grade2), [food raw] insects Insects (grade2), [food raw] eggs Eggs (grade2).
		{ BuildingTypes.Umbrella, "Umbrella" },                                                                     // Umbrella - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths.
		{ BuildingTypes.Wall, "Wall" },                                                                             // Wall - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Wall_Corner, "Wall Corner" },                                                               // Wall Corner - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.War_Beast_Cage, "War Beast Cage" },                                                         // Destroyed Cage of the Warbeast - A destroyed royal guard camp. It looks as if one of their warbeasts got out and razed the entire encampment to the ground. The beast, usually obedient to its masters, must have been provoked by something.
		{ BuildingTypes.Water_Barrels, "Water Barrels" },                                                           // Water Barrels - <color=#49E058>Comfort.</color> Even the most rudimentary encampment needs distractions. Decorations are used to level up Hearths.
		{ BuildingTypes.Water_Extractor, "Water Extractor" },                                                       // Geyser Pump - Used to extract and pump infused rainwater through underground pipes to production buildings, where it can be used to increase productivity. Must be placed on an active geyser. Has a tank capacity of 50.
		{ BuildingTypes.Water_Shrine, "Water Shrine" },                                                             // Water Shrine - <color=#8AAFFD>Aesthetics.</color> The more a settlement grows, the more demand there is for beauty. Decorations are used to level up Hearths. Counts as 9 decorations of its type.
		{ BuildingTypes.Weaver, "Weaver" },                                                                         // Weaver - Can produce:  [mat processed] fabric Fabric (grade3), [needs] boots Boots (grade1), [needs] training gear Training Gear (grade1). Can use: "[water] clearance water" Clearance Water.
		{ BuildingTypes.Well, "Well" },                                                                             // Overgrown Well - <color=#D6E54A>Harmony.</color> Peace of mind can be as important as shelter and food in these harsh lands. Decorations are used to level up Hearths. Counts as 4 decorations of its type.
		{ BuildingTypes.White_Stag, "White Stag" },                                                                 // Royal Treasure Stag - A patron of the spirit world. Once discovered, it flees to a nearby Dangerous ("dangerous") or Forbidden Glade ("forbidden"). It is said that a special treasure awaits the one who captures it.
		{ BuildingTypes.White_Treasure_Stag, "White Treasure Stag" },                                               // Royal Treasure Stag - Its elusive nature allows it to move like a ghost through the foggy thicket. It is believed that the beast is tied to the spirit world and the Ancestors. A special treasure awaits the one who finds it.
		{ BuildingTypes.Wildfire, "Wildfire" },                                                                     // Wildfire - A wildfire spirit. It will wreak havoc on the settlement if it's not contained.
		{ BuildingTypes.Woodcutters_Camp, "Woodcutters Camp" },                                                     // Woodcutters' Camp - Starting point for woodcutters going out into the wild to cut down trees.
		{ BuildingTypes.Workshop, "Workshop" },                                                                     // Workshop - Can produce:  [mat processed] planks Planks (grade2), [mat processed] fabric Fabric (grade2), [mat processed] bricks Bricks (grade2), [mat processed] pipe Pipes (grade0). Can use: "[water] storm water" Storm Water.

	};
}
