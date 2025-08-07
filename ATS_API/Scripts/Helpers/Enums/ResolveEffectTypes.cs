using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.9R
/// </summary>
public enum ResolveEffectTypes
{
	/// <summary>
	/// Placeholder for an unknown ResolveEffectTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no ResolveEffectTypes. Typically, seen if nothing is defined or failed to parse a string to a ResolveEffectTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Acidic Environment - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Acidic Environment</name>
	Acidic_Environment = 1,

	/// <summary>
	/// Acidic Environment - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Acidic Environment Blightrot</name>
	Acidic_Environment_Blightrot = 2,

	/// <summary>
	/// Industrialized Agriculture - New farming methods are very effective, but cause a lot of pollution.
	/// </summary>
	/// <name>Agriculture Penalty</name>
	Agriculture_Penalty = 3,

	/// <summary>
	/// Small Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 1</name>
	Ancient_Artifact_1 = 4,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 2</name>
	Ancient_Artifact_2 = 5,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 3</name>
	Ancient_Artifact_3 = 6,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact - weak</name>
	Ancient_Artifact_Weak = 7,

	/// <summary>
	/// Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
	/// </summary>
	/// <name>Any Housing Effect</name>
	Any_Housing_Effect = 8,

	/// <summary>
	/// Axolotl Housing - The axolotl is lentic, meaning it inhabits still-water lakes. Axolotl Houses are required to fulfill this need.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_resolveEffect</name>
	API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_resolveEffect = 185,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_equalPenaltyResolveEffect</name>
	API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_equalPenaltyResolveEffect = 186,

	/// <summary></summary>
	/// <name>API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_resolveEffect</name>
	API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_resolveEffect = 187,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_unfairPenaltyResolveEffect</name>
	API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_unfairPenaltyResolveEffect = 188,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_Fries_serviceNeed_equalPenaltyResolveEffect</name>
	API_ExampleMod_API_ExampleMod_Fries_serviceNeed_equalPenaltyResolveEffect = 189,

	/// <summary>
	/// It requires "API_ExampleMod_Fries" Fries. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_Fries_serviceNeed_resolveEffect</name>
	API_ExampleMod_API_ExampleMod_Fries_serviceNeed_resolveEffect = 190,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>API_ExampleMod_API_ExampleMod_Fries_serviceNeed_unfairPenaltyResolveEffect</name>
	API_ExampleMod_API_ExampleMod_Fries_serviceNeed_unfairPenaltyResolveEffect = 191,

	/// <summary>
	/// Modding Tools - Modders have assembled new tools that bring in new talent. Every {0} new Villagers gain +{1} Global Resolve.
	/// </summary>
	/// <name>API_ExampleMod_Modding Tools_resolve_effect_model</name>
	API_ExampleMod_Modding_Tools_resolve_effect_model = 192,

	/// <summary>
	/// Bat Clan Support - Bats have always been wary and somewhat hostile, but you've proven yourself worthy of their trust.
	/// </summary>
	/// <name>Bat Faction Support</name>
	Bat_Faction_Support = 193,

	/// <summary>
	/// Bat Housing - Bats prefer to live in spacious and dark homes. Bat Houses are required to fulfill this need.
	/// </summary>
	/// <name>Bat Housing Effect</name>
	Bat_Housing_Effect = 194,

	/// <summary>
	/// Festering Wounds - There’s a certain joy in a well-timed misfortune.
	/// </summary>
	/// <name>Bat Resolve For Frog Death - Resolve Effect</name>
	Bat_Resolve_For_Frog_Death_Resolve_Effect = 195,

	/// <summary>
	/// Dedication - Bats take pride in surviving what breaks other species.
	/// </summary>
	/// <name>Bats Dedication</name>
	Bats_Dedication = 196,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - hard</name>
	BattlegroundPenalty_Hard = 9,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - impossible</name>
	BattlegroundPenalty_Impossible = 10,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - normal</name>
	BattlegroundPenalty_Normal = 11,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - very hard</name>
	BattlegroundPenalty_Very_Hard = 12,

	/// <summary>
	/// Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
	/// </summary>
	/// <name>Beaver Housing Effect</name>
	Beaver_Housing_Effect = 13,

	/// <summary>
	/// Spirit of Cooperation - High spirits can be contagious.
	/// </summary>
	/// <name>Beaver Resolve For Harpies - Resolve Effect</name>
	Beaver_Resolve_For_Harpies_Resolve_Effect = 197,

	/// <summary>
	/// Vineyard Town - The settlement specializes in wine production, and Beavers love that.
	/// </summary>
	/// <name>Beaver Resolve Wine</name>
	Beaver_Resolve_Wine = 14,

	/// <summary>
	/// Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
	/// </summary>
	/// <name>Beavers Faction Support</name>
	Beavers_Faction_Support = 15,

	/// <summary>
	/// Village Mascot - Seeing this giant ball of fluff happy somehow makes the harsh reality surrounding the settlement a tiny bit easier to bear.
	/// </summary>
	/// <name>Biome Poro Resolve</name>
	Biome_Poro_Resolve = 198,

	/// <summary>
	/// Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Biscuits Effect</name>
	Biscuits_Effect = 16,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Biscuits Equal Prohibition Penalty</name>
	Biscuits_Equal_Prohibition_Penalty = 17,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Biscuits Unfair Prohibition Penalty</name>
	Biscuits_Unfair_Prohibition_Penalty = 18,

	/// <summary>
	/// Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Coal)</name>
	Blazing_Fire_Coal = 19,

	/// <summary>
	/// Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Oil)</name>
	Blazing_Fire_Oil = 20,

	/// <summary>
	/// Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Sea Marrow)</name>
	Blazing_Fire_Sea_Marrow = 21,

	/// <summary>
	/// Blazing Fire (Wood) - Darkness flees before the might of the fire.
	/// </summary>
	/// <name>Blazing Fire (Wood)</name>
	Blazing_Fire_Wood = 22,

	/// <summary>
	/// Blood Flower - The odor of Blood Flowers is making people feel sick.
	/// </summary>
	/// <name>Blightrot Resolve</name>
	Blightrot_Resolve = 23,

	/// <summary>
	/// ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	/// </summary>
	/// <name>Blightrot_tier2</name>
	Blightrot_tier2 = 24,

	/// <summary>
	/// ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	/// </summary>
	/// <name>Blightrot_tier3</name>
	Blightrot_tier3 = 25,

	/// <summary>
	/// Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Bloodthirst Effect</name>
	Bloodthirst_Effect = 26,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Bloodthirst Equal Prohibition Penalty</name>
	Bloodthirst_Equal_Prohibition_Penalty = 27,

	/// <summary>
	/// Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Bloodthirst Fallback Effect</name>
	Bloodthirst_Fallback_Effect = 199,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Bloodthirst Unfair Prohibition Penalty</name>
	Bloodthirst_Unfair_Prohibition_Penalty = 28,

	/// <summary>
	/// Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
	/// </summary>
	/// <name>Boots Effect</name>
	Boots_Effect = 29,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Boots Equal Prohibition Penalty</name>
	Boots_Equal_Prohibition_Penalty = 30,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Boots Unfair Prohibition Penalty</name>
	Boots_Unfair_Prohibition_Penalty = 31,

	/// <summary>
	/// Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
	/// </summary>
	/// <name>Cauldron Resolve</name>
	Cauldron_Resolve = 32,

	/// <summary>
	/// City Renown - The city is becoming known among folk as a great place to live.
	/// </summary>
	/// <name>City Renown</name>
	City_Renown = 33,

	/// <summary>
	/// Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
	/// </summary>
	/// <name>Clothes Effect</name>
	Clothes_Effect = 34,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Clothes Equal Prohibition Penalty</name>
	Clothes_Equal_Prohibition_Penalty = 35,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Clothes Unfair Prohibition Penalty</name>
	Clothes_Unfair_Prohibition_Penalty = 36,

	/// <summary>
	/// Comfortable - This worker gains +5 to their Resolve.
	/// </summary>
	/// <name>Comfortable Job</name>
	Comfortable_Job = 37,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - hard</name>
	Convicts_Hard = 38,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - impossible</name>
	Convicts_Impossible = 39,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - normal</name>
	Convicts_Normal = 40,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - very hard</name>
	Convicts_Very_Hard = 41,

	/// <summary>
	/// Greater Threat - Villagers don't approve of discovering Dangerous ("dangerous") and Forbidden Glades ("forbidden") during the storm.
	/// </summary>
	/// <name>Dang Glades Reduces Resolve Effect</name>
	Dang_Glades_Reduces_Resolve_Effect = 42,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - hard</name>
	DarkGatePenalty_Hard = 43,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - impossible</name>
	DarkGatePenalty_Impossible = 44,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - normal</name>
	DarkGatePenalty_Normal = 45,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - very hard</name>
	DarkGatePenalty_Very_Hard = 46,

	/// <summary>
	/// Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Education Effect</name>
	Education_Effect = 47,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Education Equal Prohibition Penalty</name>
	Education_Equal_Prohibition_Penalty = 48,

	/// <summary>
	/// Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Education Fallback Effect</name>
	Education_Fallback_Effect = 200,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Education Unfair Prohibition Penalty</name>
	Education_Unfair_Prohibition_Penalty = 49,

	/// <summary>
	/// Tales of Discovery - Tales of distant lands and brave explorers.
	/// </summary>
	/// <name>Explorer Tales</name>
	Explorer_Tales = 50,

	/// <summary>
	/// Explorers' Boredom - Who would have thought that great explorers are not so great at planting mushrooms?
	/// </summary>
	/// <name>Explorers Boredom</name>
	Explorers_Boredom = 51,

	/// <summary>
	/// Joy Of Discovery - There’s something truly magical about setting one's foot in a place that’s been hidden for millennia.
	/// </summary>
	/// <name>Exploring Expedition - Resolve Status</name>
	Exploring_Expedition_Resolve_Status = 52,

	/// <summary>
	/// Extreme Noise - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Extreme Noise</name>
	Extreme_Noise = 53,

	/// <summary>
	/// Favoring - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	/// </summary>
	/// <name>Favoring Effect</name>
	Favoring_Effect = 55,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - hard</name>
	Fear_Of_The_Wilds_T1_Hard = 56,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - impossible</name>
	Fear_Of_The_Wilds_T1_Impossible = 57,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - normal</name>
	Fear_Of_The_Wilds_T1_Normal = 58,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - very hard</name>
	Fear_Of_The_Wilds_T1_Very_Hard = 59,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - hard</name>
	Fear_Of_The_Wilds_T2_Hard = 60,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - impossible</name>
	Fear_Of_The_Wilds_T2_Impossible = 61,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - normal</name>
	Fear_Of_The_Wilds_T2_Normal = 62,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - very hard</name>
	Fear_Of_The_Wilds_T2_Very_Hard = 63,

	/// <summary>
	/// Creeping Fishmen - Something is observing the villagers from the edge of the woods.
	/// </summary>
	/// <name>Fishmen Resolve</name>
	Fishmen_Resolve = 64,

	/// <summary>
	/// Forced Improvisation - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Forced improvisation</name>
	Forced_Improvisation = 65,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - hard</name>
	Forsaken_Crypt_Resolve_Effect_Hard = 66,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - impossible</name>
	Forsaken_Crypt_Resolve_Effect_Impossible = 67,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - normal</name>
	Forsaken_Crypt_Resolve_Effect_Normal = 68,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - very hard</name>
	Forsaken_Crypt_Resolve_Effect_Very_Hard = 69,

	/// <summary>
	/// Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
	/// </summary>
	/// <name>Fox Housing Effect</name>
	Fox_Housing_Effect = 70,

	/// <summary>
	/// Fox Pack Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Fox tribe remembers your help.
	/// </summary>
	/// <name>Foxes Faction Support</name>
	Foxes_Faction_Support = 71,

	/// <summary>
	/// Haunted - Villagers are haunted by terrifying visions.
	/// </summary>
	/// <name>Frightening Visions Resolve Effect</name>
	Frightening_Visions_Resolve_Effect = 72,

	/// <summary>
	/// Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive.
	/// </summary>
	/// <name>Frog Houses Bonus Resolve</name>
	Frog_Houses_Bonus_Resolve = 73,

	/// <summary>
	/// Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
	/// </summary>
	/// <name>Frog Housing Effect</name>
	Frog_Housing_Effect = 74,

	/// <summary>
	/// Frog Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Frogs remember your help.
	/// </summary>
	/// <name>Frogs Faction Support</name>
	Frogs_Faction_Support = 75,

	/// <summary>
	/// Frustrated - Villagers with this effect have a -2 penalty to their Resolve.
	/// </summary>
	/// <name>Frustrated</name>
	Frustrated = 76,

	/// <summary>
	/// Furniture - Adds an additional +1 to Resolve for villagers with a home.
	/// </summary>
	/// <name>Furniture</name>
	Furniture = 77,

	/// <summary>
	/// Blood Moon - To the ancients, the Blood Moon foretold death and the fall of rulers. Fear spreads through the settlement.
	/// </summary>
	/// <name>Gargoyle Resolve Penalty - child</name>
	Gargoyle_Resolve_Penalty_Child = 201,

	/// <summary>
	/// Generous Rations - A surplus of food makes the villagers happy.
	/// </summary>
	/// <name>Generous Rations</name>
	Generous_Rations = 78,

	/// <summary>
	/// Harmony - When your villagers' needs are met, Harmony is fostered.
	/// </summary>
	/// <name>Harmony Altar</name>
	Harmony_Altar = 79,

	/// <summary>
	/// Chaos - Harmony has been disturbed.
	/// </summary>
	/// <name>Harmony Altar Chaos Resolve</name>
	Harmony_Altar_Chaos_Resolve = 80,

	/// <summary>
	/// Harpy Clan Support - The Flock was neutral during the Great Civil War, but you've proven your worth to them now.
	/// </summary>
	/// <name>Harpy Faction Support</name>
	Harpy_Faction_Support = 81,

	/// <summary>
	/// Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
	/// </summary>
	/// <name>Harpy Housing Effect</name>
	Harpy_Housing_Effect = 82,

	/// <summary>
	/// Health Infusion - High tea production is boosting Harpies' morale.
	/// </summary>
	/// <name>Harpy Resolve Tea</name>
	Harpy_Resolve_Tea = 83,

	/// <summary>
	/// Unique Ally - An exceptionally strong bond has developed between the Harpies and the Stormbird. They look very pleased to be in its presence.
	/// </summary>
	/// <name>Harpy Stormbird Resolve</name>
	Harpy_Stormbird_Resolve = 84,

	/// <summary>
	/// Homelessness - People need houses.
	/// </summary>
	/// <name>Homelessness Penalty</name>
	Homelessness_Penalty = 85,

	/// <summary>
	/// Stove - A small reminder of the Holy Flame.
	/// </summary>
	/// <name>Houses Bonus Resolve</name>
	Houses_Bonus_Resolve = 86,

	/// <summary>
	/// Encampment (Level 1) - Gathered around the blazing fire, folks keep each other's spirits high.
	/// </summary>
	/// <name>[Hub] Hub Resolve T1</name>
	Hub_Hub_Resolve_T1 = 87,

	/// <summary>
	/// Neighborhood (Level 2) - Even in such a harsh environment, there is still room for beauty.
	/// </summary>
	/// <name>[Hub] Hub Resolve T2</name>
	Hub_Hub_Resolve_T2 = 88,

	/// <summary>
	/// District (Level 3) - The town is booming with activity, and industry thrives.
	/// </summary>
	/// <name>[Hub] Hub Resolve T3</name>
	Hub_Hub_Resolve_T3 = 89,

	/// <summary>
	/// Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
	/// </summary>
	/// <name>Human Housing Effect</name>
	Human_Housing_Effect = 90,

	/// <summary>
	/// Sweet Aroma - A sweet aroma is spreading around the settlement. It seems to be making the Humans feel content.
	/// </summary>
	/// <name>Human Resolve Incense</name>
	Human_Resolve_Incense = 91,

	/// <summary>
	/// Human Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Humans remember your help.
	/// </summary>
	/// <name>Humans Faction Support</name>
	Humans_Faction_Support = 92,

	/// <summary>
	/// Hunger - People are starving. This effect stacks every time a villager doesn't eat during a break.
	/// </summary>
	/// <name>Hunger Penalty</name>
	Hunger_Penalty = 93,

	/// <summary>
	/// Gleeman's Tales - Every evening, a Gleeman tells stories about past glories, and times before the Great Civil War.
	/// </summary>
	/// <name>Institution Global Resolve</name>
	Institution_Global_Resolve = 94,

	/// <summary>
	/// Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Jerky Effect</name>
	Jerky_Effect = 95,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Jerky Equal Prohibition Penalty</name>
	Jerky_Equal_Prohibition_Penalty = 96,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Jerky Unfair Prohibition Penalty</name>
	Jerky_Unfair_Prohibition_Penalty = 97,

	/// <summary>
	/// Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Leasiure Effect</name>
	Leasiure_Effect = 98,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Leasiure Equal Prohibition Penalty</name>
	Leasiure_Equal_Prohibition_Penalty = 99,

	/// <summary>
	/// Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Leasiure Fallback Effect</name>
	Leasiure_Fallback_Effect = 202,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Leasiure Unfair Prohibition Penalty</name>
	Leasiure_Unfair_Prohibition_Penalty = 100,

	/// <summary>
	/// Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
	/// </summary>
	/// <name>Lizard Housing Effect</name>
	Lizard_Housing_Effect = 101,

	/// <summary>
	/// Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
	/// </summary>
	/// <name>Lizard Resolve Training Gear</name>
	Lizard_Resolve_Training_Gear = 102,

	/// <summary>
	/// Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
	/// </summary>
	/// <name>Lizards Faction Support</name>
	Lizards_Faction_Support = 103,

	/// <summary>
	/// Long Live the Queen - Villagers admire the Queen's greatness.
	/// </summary>
	/// <name>Long Live the Queen</name>
	Long_Live_The_Queen = 104,

	/// <summary>
	/// Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Luxury Effect</name>
	Luxury_Effect = 105,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Luxury Equal Prohibition Penalty</name>
	Luxury_Equal_Prohibition_Penalty = 106,

	/// <summary>
	/// Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Luxury Fallback Effect</name>
	Luxury_Fallback_Effect = 203,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Luxury Unfair Prohibition Penalty</name>
	Luxury_Unfair_Prohibition_Penalty = 107,

	/// <summary>
	/// Forsaken Gods Temple - ModifierEffect_TempleResolve_Desc
	/// </summary>
	/// <name>[Map Mod] Resolve</name>
	Map_Mod_Resolve = 108,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - hard</name>
	MoleResolvePenalty_Hard = 109,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - impossible</name>
	MoleResolvePenalty_Impossible = 110,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - normal</name>
	MoleResolvePenalty_Normal = 111,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - very hard</name>
	MoleResolvePenalty_Very_Hard = 112,

	/// <summary>
	/// Motivated - Villagers with this effect have a +1 boost to their Resolve.
	/// </summary>
	/// <name>Motivated</name>
	Motivated = 113,

	/// <summary>
	/// Hostility of the Forest - The forest is becoming more dangerous with each passing year... the people are scared.
	/// </summary>
	/// <name>New Year Penalty</name>
	New_Year_Penalty = 114,

	/// <summary>
	/// No Hope - The fire has gone out, and darkness is spreading around the town.
	/// </summary>
	/// <name>No Fire Penalty</name>
	No_Fire_Penalty = 115,

	/// <summary>
	/// Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Paste Effect</name>
	Paste_Effect = 116,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Paste Equal Prohibition Penalty</name>
	Paste_Equal_Prohibition_Penalty = 117,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Paste Unfair Prohibition Penalty</name>
	Paste_Unfair_Prohibition_Penalty = 118,

	/// <summary>
	/// Experimental Cornerstone Resolve - -2 to Global Resolve.
	/// </summary>
	/// <name>[PerkCrafter] Resolve - child</name>
	PerkCrafter_Resolve_Child = 176,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 1.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +1</name>
	PerkCrafter_Resolve_Plus1 = 119,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 2.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +2</name>
	PerkCrafter_Resolve_Plus2 = 120,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 3.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +3</name>
	PerkCrafter_Resolve_Plus3 = 121,

	/// <summary>
	/// Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Picked Goods Effect</name>
	Picked_Goods_Effect = 122,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Pickled Goods Equal Prohibition Penalty</name>
	Pickled_Goods_Equal_Prohibition_Penalty = 123,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Pickled Goods Unfair Prohibition Penalty</name>
	Pickled_Goods_Unfair_Prohibition_Penalty = 124,

	/// <summary>
	/// Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Pie Effect</name>
	Pie_Effect = 125,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Pie Equal Prohibition Penalty</name>
	Pie_Equal_Prohibition_Penalty = 126,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Pie Unfair Prohibition Penalty</name>
	Pie_Unfair_Prohibition_Penalty = 127,

	/// <summary>
	/// Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Porridge Effect</name>
	Porridge_Effect = 128,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Porridge Equal Prohibition Penalty</name>
	Porridge_Equal_Prohibition_Penalty = 129,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Porridge Unfair Prohibition Penalty</name>
	Porridge_Unfair_Prohibition_Penalty = 130,

	/// <summary>
	/// Low Strain - Work is much easier with Rain Engines on
	/// </summary>
	/// <name>Rainpunk Comfortable</name>
	Rainpunk_Comfortable = 131,

	/// <summary>
	/// Rebellious Spirit - The people are feeling oddly rebellious.
	/// </summary>
	/// <name>Rebelious Spirit</name>
	Rebelious_Spirit = 132,

	/// <summary>
	/// Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Religion Effect</name>
	Religion_Effect = 133,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Religion Equal Prohibition Penalty</name>
	Religion_Equal_Prohibition_Penalty = 134,

	/// <summary>
	/// Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Religion Fallback Effect</name>
	Religion_Fallback_Effect = 204,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Religion Unfair Prohibition Penalty</name>
	Religion_Unfair_Prohibition_Penalty = 135,

	/// <summary>
	/// The Crown Chronicles - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Institution Resolve for Ruins</name>
	Resolve_Effect_Institution_Resolve_For_Ruins = 136,

	/// <summary>
	/// The Guild's Welfare - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Institution Resolve for Sales</name>
	Resolve_Effect_Institution_Resolve_For_Sales = 137,

	/// <summary>
	/// Prosperous Archaeology - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for chests</name>
	Resolve_Effect_Resolve_For_Chests = 138,

	/// <summary>
	/// Prosperous Settlement - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for sales</name>
	Resolve_Effect_Resolve_For_Sales = 139,

	/// <summary>
	/// Friendly Relations - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for Standing</name>
	Resolve_Effect_Resolve_For_Standing = 140,

	/// <summary>
	/// Inspiring Work - The woodcutters' song lifts people's spirits.
	/// </summary>
	/// <name>Resolve for Glade - Resolve Status</name>
	Resolve_For_Glade_Resolve_Status = 141,

	/// <summary>
	/// Sacred Pyre - Lizard firekeepers are very adept at ancient rites.
	/// </summary>
	/// <name>ResolveEffect_HearthEffect_Lizard</name>
	ResolveEffect_HearthEffect_Lizard = 142,

	/// <summary>
	/// Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them. 
	/// </summary>
	/// <name>Royal Guard Training - Resolve Effect</name>
	Royal_Guard_Training_Resolve_Effect = 143,

	/// <summary>
	/// Converted Totem of Denial - A Totem of Denial cleansed by the Holy Flame. Grants a Global Resolve bonus.
	/// </summary>
	/// <name>SacrificeTotemPositive</name>
	SacrificeTotemPositive = 144,

	/// <summary>
	/// Shadowy Figure - People fear the unknown during the storm.
	/// </summary>
	/// <name>SE Creeping Shadows - Resolve Penalty Status</name>
	SE_Creeping_Shadows_Resolve_Penalty_Status = 145,

	/// <summary>
	/// Devastating Storms - The rampaging storm stifles the spirit of all living creatures.
	/// </summary>
	/// <name>SE Devastating Storms</name>
	SE_Devastating_Storms = 146,

	/// <summary>
	/// Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators.
	/// </summary>
	/// <name>SE Hot Springs (Resolve Status)</name>
	SE_Hot_Springs_Resolve_Status = 147,

	/// <summary>
	/// Horrors from Beneath - A strange chant is frightening the villagers.
	/// </summary>
	/// <name>SE Mine in Storm (Resolve Status)</name>
	SE_Mine_In_Storm_Resolve_Status = 148,

	/// <summary>
	/// Saturated Air - A pleasant, earthy scent is in the air.
	/// </summary>
	/// <name>SE Resolve for Water - Resolve Effect</name>
	SE_Resolve_For_Water_Resolve_Effect = 149,

	/// <summary>
	/// Cloudburst - The heavy rain is unbearable.
	/// </summary>
	/// <name>SE Storm Clothes - Resolve Status</name>
	SE_Storm_Clothes_Resolve_Status = 150,

	/// <summary>
	/// Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Skewer Effect</name>
	Skewer_Effect = 151,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Skewers Equal Prohibition Penalty</name>
	Skewers_Equal_Prohibition_Penalty = 152,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Skewers Unfair Prohibition Penalty</name>
	Skewers_Unfair_Prohibition_Penalty = 153,

	/// <summary>
	/// Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure.
	/// </summary>
	/// <name>Spiced Ale</name>
	Spiced_Ale = 154,

	/// <summary>
	/// Spices from the Citadel - Spices from the Smoldering City - a favorite of Humans and Lizardfolk.
	/// </summary>
	/// <name>Spices from the Capital</name>
	Spices_From_The_Capital = 155,

	/// <summary>
	/// Stag's Blessing - The forest god has blessed your villagers. This day will be remembered for generations.
	/// </summary>
	/// <name>Stag Blessing</name>
	Stag_Blessing = 156,

	/// <summary>
	/// Drenched - Villagers with this effect have a -5 penalty to their Resolve.
	/// </summary>
	/// <name>Storm Homelessness Penalty</name>
	Storm_Homelessness_Penalty = 157,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	/// </summary>
	/// <name>Storm Penalty</name>
	Storm_Penalty = 158,

	/// <summary>
	/// Stormbird's Cry - Villagers report seeing a giant beast flying above the settlement during the storm.
	/// </summary>
	/// <name>Stormbird Egg - Resolve Effect</name>
	Stormbird_Egg_Resolve_Effect = 159,

	/// <summary>
	/// Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	/// </summary>
	/// <name>Survivor Bonding Effect</name>
	Survivor_Bonding_Effect = 160,

	/// <summary>
	/// Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	/// </summary>
	/// <name>Survivor Bonding Effect - Altar</name>
	Survivor_Bonding_Effect_Altar = 161,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	/// </summary>
	/// <name>T Storm Penalty</name>
	T_Storm_Penalty = 162,

	/// <summary>
	/// Stonetooth Swarm - Agitated termites can be a real nuisance.
	/// </summary>
	/// <name>Termites Resolve - normal</name>
	Termites_Resolve_Normal = 163,

	/// <summary>
	/// Plague of Snakes - Villagers are horrified by the sight of venomous snakes on the roads.
	/// </summary>
	/// <name>TEST Plague of Snakes Resolve</name>
	TEST_Plague_Of_Snakes_Resolve = 164,

	/// <summary>
	/// Toxic Fumes - A strange white mist is produced when using Rainpunk technology...
	/// </summary>
	/// <name>Toxic Fumes</name>
	Toxic_Fumes = 165,

	/// <summary>
	/// Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Treatment Effect</name>
	Treatment_Effect = 166,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Treatment Equal Prohibition Penalty</name>
	Treatment_Equal_Prohibition_Penalty = 167,

	/// <summary>
	/// Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Treatment Fallback Effect</name>
	Treatment_Fallback_Effect = 205,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Treatment Unfair Prohibition Penalty</name>
	Treatment_Unfair_Prohibition_Penalty = 168,

	/// <summary>
	/// Tale - Not as good as the Gleeman's Tale, but it did its job.
	/// </summary>
	/// <name>[TW] Global Resolve</name>
	TW_Global_Resolve = 169,

	/// <summary>
	/// Negligence - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	/// </summary>
	/// <name>Unfair Treatment Penalty</name>
	Unfair_Treatment_Penalty = 170,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	/// </summary>
	/// <name>VaultResolvePenalty - hard</name>
	VaultResolvePenalty_Hard = 177,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	/// </summary>
	/// <name>VaultResolvePenalty - impossible</name>
	VaultResolvePenalty_Impossible = 178,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	/// </summary>
	/// <name>VaultResolvePenalty - normal</name>
	VaultResolvePenalty_Normal = 171,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	/// </summary>
	/// <name>VaultResolvePenalty - very hard</name>
	VaultResolvePenalty_Very_Hard = 179,

	/// <summary>
	/// Vitality - Well-nourished villagers enjoy their good health.
	/// </summary>
	/// <name>Vitality</name>
	Vitality = 172,

	/// <summary>
	/// Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
	/// </summary>
	/// <name>[WE] Feast Hall - Funeral - Resolve Effect - 0 - normal</name>
	WE_Feast_Hall_Funeral_Resolve_Effect_0_Normal = 180,

	/// <summary>
	/// Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
	/// </summary>
	/// <name>[WE] Feast Hall - Funeral - Resolve Effect - 1 - hard</name>
	WE_Feast_Hall_Funeral_Resolve_Effect_1_Hard = 181,

	/// <summary>
	/// Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
	/// </summary>
	/// <name>[WE] Feast Hall - Funeral - Resolve Effect - 2 - very hard</name>
	WE_Feast_Hall_Funeral_Resolve_Effect_2_Very_Hard = 182,

	/// <summary>
	/// Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
	/// </summary>
	/// <name>[WE] Feast Hall - Funeral - Resolve Effect - 3 - impossible</name>
	WE_Feast_Hall_Funeral_Resolve_Effect_3_Impossible = 183,

	/// <summary>
	/// The Elder's Cat - From time to time, a weary villager stops to pet the cat, finding comfort in the reminder of their true home on the slopes of Red Mountain.
	/// </summary>
	/// <name>[WE] First Elder Cat Resolve Effect</name>
	WE_First_Elder_Cat_Resolve_Effect = 184,

	/// <summary>
	/// Wealth - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Wealth</name>
	Wealth = 173,

	/// <summary>
	/// Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
	/// </summary>
	/// <name>Worse Storms for Hostility Consequence Resolve Penalty</name>
	Worse_Storms_For_Hostility_Consequence_Resolve_Penalty = 174,

	/// <summary>
	/// Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
	/// </summary>
	/// <name>Worse Storms for Hostility Resolve Penalty</name>
	Worse_Storms_For_Hostility_Resolve_Penalty = 175,



	/// <summary>
	/// The total number of vanilla ResolveEffectTypes in the game.
	/// </summary>
	[Obsolete("Use ResolveEffectTypesExtensions.Count(). ResolveEffectTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 206
}

/// <summary>
/// Extension methods for the ResolveEffectTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class ResolveEffectTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in ResolveEffectTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded ResolveEffectTypes.
	/// </summary>
	public static ResolveEffectTypes[] All()
	{
		ResolveEffectTypes[] all = new ResolveEffectTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every ResolveEffectTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return ResolveEffectTypes.Acidic_Environment in the enum and log an error.
	/// </summary>
	public static string ToName(this ResolveEffectTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of ResolveEffectTypes: " + type);
		return TypeToInternalName[ResolveEffectTypes.Acidic_Environment];
	}
	
	/// <summary>
	/// Returns a ResolveEffectTypes associated with the given name.
	/// Every ResolveEffectTypes should have a unique name as to distinguish it from others.
	/// If no ResolveEffectTypes is found, it will return ResolveEffectTypes.Unknown and log a warning.
	/// </summary>
	public static ResolveEffectTypes ToResolveEffectTypes(this string name)
	{
		foreach (KeyValuePair<ResolveEffectTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find ResolveEffectTypes with name: " + name + "\n" + Environment.StackTrace);
		return ResolveEffectTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a ResolveEffectModel associated with the given name.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If no ResolveEffectModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel ToResolveEffectModel(this string name)
	{
		Eremite.Model.ResolveEffectModel model = SO.Settings.resolveEffects.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find ResolveEffectModel for ResolveEffectTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a ResolveEffectModel associated with the given ResolveEffectTypes.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If no ResolveEffectModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel ToResolveEffectModel(this ResolveEffectTypes types)
	{
		return types.ToName().ToResolveEffectModel();
	}
	
	/// <summary>
	/// Returns an array of ResolveEffectModel associated with the given ResolveEffectTypes.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If a ResolveEffectModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel[] ToResolveEffectModelArray(this IEnumerable<ResolveEffectTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.ResolveEffectModel[] array = new Eremite.Model.ResolveEffectModel[count];
		int i = 0;
		foreach (ResolveEffectTypes element in collection)
		{
			array[i++] = element.ToResolveEffectModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ResolveEffectModel associated with the given ResolveEffectTypes.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If a ResolveEffectModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel[] ToResolveEffectModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.ResolveEffectModel[] array = new Eremite.Model.ResolveEffectModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToResolveEffectModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ResolveEffectModel associated with the given ResolveEffectTypes.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If a ResolveEffectModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel[] ToResolveEffectModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.ResolveEffectModel>.Get(out List<Eremite.Model.ResolveEffectModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.ResolveEffectModel model = element.ToResolveEffectModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of ResolveEffectModel associated with the given ResolveEffectTypes.
	/// ResolveEffectModel contain all the data that will be used in the game.
	/// Every ResolveEffectModel should have a unique name as to distinguish it from others.
	/// If a ResolveEffectModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ResolveEffectModel[] ToResolveEffectModelArrayNoNulls(this IEnumerable<ResolveEffectTypes> collection)
	{
		using(ListPool<Eremite.Model.ResolveEffectModel>.Get(out List<Eremite.Model.ResolveEffectModel> list))
		{
			foreach (ResolveEffectTypes element in collection)
			{
				Eremite.Model.ResolveEffectModel model = element.ToResolveEffectModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<ResolveEffectTypes, string> TypeToInternalName = new()
	{
		{ ResolveEffectTypes.Acidic_Environment, "Acidic Environment" },                                                                                                                           // Acidic Environment - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Acidic_Environment_Blightrot, "Acidic Environment Blightrot" },                                                                                                       // Acidic Environment - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Agriculture_Penalty, "Agriculture Penalty" },                                                                                                                         // Industrialized Agriculture - New farming methods are very effective, but cause a lot of pollution.
		{ ResolveEffectTypes.Ancient_Artifact_1, "Ancient Artifact 1" },                                                                                                                           // Small Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_2, "Ancient Artifact 2" },                                                                                                                           // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_3, "Ancient Artifact 3" },                                                                                                                           // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_Weak, "Ancient Artifact - weak" },                                                                                                                   // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Any_Housing_Effect, "Any Housing Effect" },                                                                                                                           // Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_resolveEffect, "API_ExampleMod_API_ExampleMod_AxolotlHouse_housingNeed_resolveEffect" },                       // Axolotl Housing - The axolotl is lentic, meaning it inhabits still-water lakes. Axolotl Houses are required to fulfill this need.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_equalPenaltyResolveEffect, "API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_equalPenaltyResolveEffect" },   // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_resolveEffect, "API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_resolveEffect" }, 
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_unfairPenaltyResolveEffect, "API_ExampleMod_API_ExampleMod_Borgor_complexFoodNeed_unfairPenaltyResolveEffect" }, // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Fries_serviceNeed_equalPenaltyResolveEffect, "API_ExampleMod_API_ExampleMod_Fries_serviceNeed_equalPenaltyResolveEffect" },             // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Fries_serviceNeed_resolveEffect, "API_ExampleMod_API_ExampleMod_Fries_serviceNeed_resolveEffect" },                                     // It requires "API_ExampleMod_Fries" Fries. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.API_ExampleMod_API_ExampleMod_Fries_serviceNeed_unfairPenaltyResolveEffect, "API_ExampleMod_API_ExampleMod_Fries_serviceNeed_unfairPenaltyResolveEffect" },           // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.API_ExampleMod_Modding_Tools_resolve_effect_model, "API_ExampleMod_Modding Tools_resolve_effect_model" },                                                             // Modding Tools - Modders have assembled new tools that bring in new talent. Every {0} new Villagers gain +{1} Global Resolve.
		{ ResolveEffectTypes.Bat_Faction_Support, "Bat Faction Support" },                                                                                                                         // Bat Clan Support - Bats have always been wary and somewhat hostile, but you've proven yourself worthy of their trust.
		{ ResolveEffectTypes.Bat_Housing_Effect, "Bat Housing Effect" },                                                                                                                           // Bat Housing - Bats prefer to live in spacious and dark homes. Bat Houses are required to fulfill this need.
		{ ResolveEffectTypes.Bat_Resolve_For_Frog_Death_Resolve_Effect, "Bat Resolve For Frog Death - Resolve Effect" },                                                                           // Festering Wounds - There’s a certain joy in a well-timed misfortune.
		{ ResolveEffectTypes.Bats_Dedication, "Bats Dedication" },                                                                                                                                 // Dedication - Bats take pride in surviving what breaks other species.
		{ ResolveEffectTypes.BattlegroundPenalty_Hard, "BattlegroundPenalty - hard" },                                                                                                             // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Impossible, "BattlegroundPenalty - impossible" },                                                                                                 // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Normal, "BattlegroundPenalty - normal" },                                                                                                         // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Very_Hard, "BattlegroundPenalty - very hard" },                                                                                                   // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.Beaver_Housing_Effect, "Beaver Housing Effect" },                                                                                                                     // Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
		{ ResolveEffectTypes.Beaver_Resolve_For_Harpies_Resolve_Effect, "Beaver Resolve For Harpies - Resolve Effect" },                                                                           // Spirit of Cooperation - High spirits can be contagious.
		{ ResolveEffectTypes.Beaver_Resolve_Wine, "Beaver Resolve Wine" },                                                                                                                         // Vineyard Town - The settlement specializes in wine production, and Beavers love that.
		{ ResolveEffectTypes.Beavers_Faction_Support, "Beavers Faction Support" },                                                                                                                 // Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
		{ ResolveEffectTypes.Biome_Poro_Resolve, "Biome Poro Resolve" },                                                                                                                           // Village Mascot - Seeing this giant ball of fluff happy somehow makes the harsh reality surrounding the settlement a tiny bit easier to bear.
		{ ResolveEffectTypes.Biscuits_Effect, "Biscuits Effect" },                                                                                                                                 // Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Biscuits_Equal_Prohibition_Penalty, "Biscuits Equal Prohibition Penalty" },                                                                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Biscuits_Unfair_Prohibition_Penalty, "Biscuits Unfair Prohibition Penalty" },                                                                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Blazing_Fire_Coal, "Blazing Fire (Coal)" },                                                                                                                           // Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Oil, "Blazing Fire (Oil)" },                                                                                                                             // Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Sea_Marrow, "Blazing Fire (Sea Marrow)" },                                                                                                               // Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Wood, "Blazing Fire (Wood)" },                                                                                                                           // Blazing Fire (Wood) - Darkness flees before the might of the fire.
		{ ResolveEffectTypes.Blightrot_Resolve, "Blightrot Resolve" },                                                                                                                             // Blood Flower - The odor of Blood Flowers is making people feel sick.
		{ ResolveEffectTypes.Blightrot_tier2, "Blightrot_tier2" },                                                                                                                                 // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Blightrot_tier3, "Blightrot_tier3" },                                                                                                                                 // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Bloodthirst_Effect, "Bloodthirst Effect" },                                                                                                                           // Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Bloodthirst_Equal_Prohibition_Penalty, "Bloodthirst Equal Prohibition Penalty" },                                                                                     // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Bloodthirst_Fallback_Effect, "Bloodthirst Fallback Effect" },                                                                                                         // Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Bloodthirst_Unfair_Prohibition_Penalty, "Bloodthirst Unfair Prohibition Penalty" },                                                                                   // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Boots_Effect, "Boots Effect" },                                                                                                                                       // Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
		{ ResolveEffectTypes.Boots_Equal_Prohibition_Penalty, "Boots Equal Prohibition Penalty" },                                                                                                 // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Boots_Unfair_Prohibition_Penalty, "Boots Unfair Prohibition Penalty" },                                                                                               // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Cauldron_Resolve, "Cauldron Resolve" },                                                                                                                               // Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
		{ ResolveEffectTypes.City_Renown, "City Renown" },                                                                                                                                         // City Renown - The city is becoming known among folk as a great place to live.
		{ ResolveEffectTypes.Clothes_Effect, "Clothes Effect" },                                                                                                                                   // Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
		{ ResolveEffectTypes.Clothes_Equal_Prohibition_Penalty, "Clothes Equal Prohibition Penalty" },                                                                                             // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Clothes_Unfair_Prohibition_Penalty, "Clothes Unfair Prohibition Penalty" },                                                                                           // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Comfortable_Job, "Comfortable Job" },                                                                                                                                 // Comfortable - This worker gains +5 to their Resolve.
		{ ResolveEffectTypes.Convicts_Hard, "Convicts - hard" },                                                                                                                                   // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Impossible, "Convicts - impossible" },                                                                                                                       // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Normal, "Convicts - normal" },                                                                                                                               // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Very_Hard, "Convicts - very hard" },                                                                                                                         // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Dang_Glades_Reduces_Resolve_Effect, "Dang Glades Reduces Resolve Effect" },                                                                                           // Greater Threat - Villagers don't approve of discovering Dangerous ("dangerous") and Forbidden Glades ("forbidden") during the storm.
		{ ResolveEffectTypes.DarkGatePenalty_Hard, "DarkGatePenalty - hard" },                                                                                                                     // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Impossible, "DarkGatePenalty - impossible" },                                                                                                         // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Normal, "DarkGatePenalty - normal" },                                                                                                                 // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Very_Hard, "DarkGatePenalty - very hard" },                                                                                                           // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.Education_Effect, "Education Effect" },                                                                                                                               // Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Education_Equal_Prohibition_Penalty, "Education Equal Prohibition Penalty" },                                                                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Education_Fallback_Effect, "Education Fallback Effect" },                                                                                                             // Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Education_Unfair_Prohibition_Penalty, "Education Unfair Prohibition Penalty" },                                                                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Explorer_Tales, "Explorer Tales" },                                                                                                                                   // Tales of Discovery - Tales of distant lands and brave explorers.
		{ ResolveEffectTypes.Explorers_Boredom, "Explorers Boredom" },                                                                                                                             // Explorers' Boredom - Who would have thought that great explorers are not so great at planting mushrooms?
		{ ResolveEffectTypes.Exploring_Expedition_Resolve_Status, "Exploring Expedition - Resolve Status" },                                                                                       // Joy Of Discovery - There’s something truly magical about setting one's foot in a place that’s been hidden for millennia.
		{ ResolveEffectTypes.Extreme_Noise, "Extreme Noise" },                                                                                                                                     // Extreme Noise - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Favoring_Effect, "Favoring Effect" },                                                                                                                                 // Favoring - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Hard, "Fear of the Wilds T1 - hard" },                                                                                                           // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Impossible, "Fear of the Wilds T1 - impossible" },                                                                                               // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Normal, "Fear of the Wilds T1 - normal" },                                                                                                       // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Very_Hard, "Fear of the Wilds T1 - very hard" },                                                                                                 // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Hard, "Fear of the Wilds T2 - hard" },                                                                                                           // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Impossible, "Fear of the Wilds T2 - impossible" },                                                                                               // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Normal, "Fear of the Wilds T2 - normal" },                                                                                                       // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Very_Hard, "Fear of the Wilds T2 - very hard" },                                                                                                 // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fishmen_Resolve, "Fishmen Resolve" },                                                                                                                                 // Creeping Fishmen - Something is observing the villagers from the edge of the woods.
		{ ResolveEffectTypes.Forced_Improvisation, "Forced improvisation" },                                                                                                                       // Forced Improvisation - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Hard, "Forsaken Crypt Resolve Effect - hard" },                                                                                         // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Impossible, "Forsaken Crypt Resolve Effect - impossible" },                                                                             // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Normal, "Forsaken Crypt Resolve Effect - normal" },                                                                                     // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Very_Hard, "Forsaken Crypt Resolve Effect - very hard" },                                                                               // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Fox_Housing_Effect, "Fox Housing Effect" },                                                                                                                           // Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
		{ ResolveEffectTypes.Foxes_Faction_Support, "Foxes Faction Support" },                                                                                                                     // Fox Pack Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Fox tribe remembers your help.
		{ ResolveEffectTypes.Frightening_Visions_Resolve_Effect, "Frightening Visions Resolve Effect" },                                                                                           // Haunted - Villagers are haunted by terrifying visions.
		{ ResolveEffectTypes.Frog_Houses_Bonus_Resolve, "Frog Houses Bonus Resolve" },                                                                                                             // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive.
		{ ResolveEffectTypes.Frog_Housing_Effect, "Frog Housing Effect" },                                                                                                                         // Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
		{ ResolveEffectTypes.Frogs_Faction_Support, "Frogs Faction Support" },                                                                                                                     // Frog Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Frogs remember your help.
		{ ResolveEffectTypes.Frustrated, "Frustrated" },                                                                                                                                           // Frustrated - Villagers with this effect have a -2 penalty to their Resolve.
		{ ResolveEffectTypes.Furniture, "Furniture" },                                                                                                                                             // Furniture - Adds an additional +1 to Resolve for villagers with a home.
		{ ResolveEffectTypes.Gargoyle_Resolve_Penalty_Child, "Gargoyle Resolve Penalty - child" },                                                                                                 // Blood Moon - To the ancients, the Blood Moon foretold death and the fall of rulers. Fear spreads through the settlement.
		{ ResolveEffectTypes.Generous_Rations, "Generous Rations" },                                                                                                                               // Generous Rations - A surplus of food makes the villagers happy.
		{ ResolveEffectTypes.Harmony_Altar, "Harmony Altar" },                                                                                                                                     // Harmony - When your villagers' needs are met, Harmony is fostered.
		{ ResolveEffectTypes.Harmony_Altar_Chaos_Resolve, "Harmony Altar Chaos Resolve" },                                                                                                         // Chaos - Harmony has been disturbed.
		{ ResolveEffectTypes.Harpy_Faction_Support, "Harpy Faction Support" },                                                                                                                     // Harpy Clan Support - The Flock was neutral during the Great Civil War, but you've proven your worth to them now.
		{ ResolveEffectTypes.Harpy_Housing_Effect, "Harpy Housing Effect" },                                                                                                                       // Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
		{ ResolveEffectTypes.Harpy_Resolve_Tea, "Harpy Resolve Tea" },                                                                                                                             // Health Infusion - High tea production is boosting Harpies' morale.
		{ ResolveEffectTypes.Harpy_Stormbird_Resolve, "Harpy Stormbird Resolve" },                                                                                                                 // Unique Ally - An exceptionally strong bond has developed between the Harpies and the Stormbird. They look very pleased to be in its presence.
		{ ResolveEffectTypes.Homelessness_Penalty, "Homelessness Penalty" },                                                                                                                       // Homelessness - People need houses.
		{ ResolveEffectTypes.Houses_Bonus_Resolve, "Houses Bonus Resolve" },                                                                                                                       // Stove - A small reminder of the Holy Flame.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T1, "[Hub] Hub Resolve T1" },                                                                                                                         // Encampment (Level 1) - Gathered around the blazing fire, folks keep each other's spirits high.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T2, "[Hub] Hub Resolve T2" },                                                                                                                         // Neighborhood (Level 2) - Even in such a harsh environment, there is still room for beauty.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T3, "[Hub] Hub Resolve T3" },                                                                                                                         // District (Level 3) - The town is booming with activity, and industry thrives.
		{ ResolveEffectTypes.Human_Housing_Effect, "Human Housing Effect" },                                                                                                                       // Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
		{ ResolveEffectTypes.Human_Resolve_Incense, "Human Resolve Incense" },                                                                                                                     // Sweet Aroma - A sweet aroma is spreading around the settlement. It seems to be making the Humans feel content.
		{ ResolveEffectTypes.Humans_Faction_Support, "Humans Faction Support" },                                                                                                                   // Human Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Humans remember your help.
		{ ResolveEffectTypes.Hunger_Penalty, "Hunger Penalty" },                                                                                                                                   // Hunger - People are starving. This effect stacks every time a villager doesn't eat during a break.
		{ ResolveEffectTypes.Institution_Global_Resolve, "Institution Global Resolve" },                                                                                                           // Gleeman's Tales - Every evening, a Gleeman tells stories about past glories, and times before the Great Civil War.
		{ ResolveEffectTypes.Jerky_Effect, "Jerky Effect" },                                                                                                                                       // Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Jerky_Equal_Prohibition_Penalty, "Jerky Equal Prohibition Penalty" },                                                                                                 // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Jerky_Unfair_Prohibition_Penalty, "Jerky Unfair Prohibition Penalty" },                                                                                               // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Leasiure_Effect, "Leasiure Effect" },                                                                                                                                 // Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Leasiure_Equal_Prohibition_Penalty, "Leasiure Equal Prohibition Penalty" },                                                                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Leasiure_Fallback_Effect, "Leasiure Fallback Effect" },                                                                                                               // Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Leasiure_Unfair_Prohibition_Penalty, "Leasiure Unfair Prohibition Penalty" },                                                                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Lizard_Housing_Effect, "Lizard Housing Effect" },                                                                                                                     // Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
		{ ResolveEffectTypes.Lizard_Resolve_Training_Gear, "Lizard Resolve Training Gear" },                                                                                                       // Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
		{ ResolveEffectTypes.Lizards_Faction_Support, "Lizards Faction Support" },                                                                                                                 // Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
		{ ResolveEffectTypes.Long_Live_The_Queen, "Long Live the Queen" },                                                                                                                         // Long Live the Queen - Villagers admire the Queen's greatness.
		{ ResolveEffectTypes.Luxury_Effect, "Luxury Effect" },                                                                                                                                     // Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Luxury_Equal_Prohibition_Penalty, "Luxury Equal Prohibition Penalty" },                                                                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Luxury_Fallback_Effect, "Luxury Fallback Effect" },                                                                                                                   // Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Luxury_Unfair_Prohibition_Penalty, "Luxury Unfair Prohibition Penalty" },                                                                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Map_Mod_Resolve, "[Map Mod] Resolve" },                                                                                                                               // Forsaken Gods Temple - ModifierEffect_TempleResolve_Desc
		{ ResolveEffectTypes.MoleResolvePenalty_Hard, "MoleResolvePenalty - hard" },                                                                                                               // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Impossible, "MoleResolvePenalty - impossible" },                                                                                                   // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Normal, "MoleResolvePenalty - normal" },                                                                                                           // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Very_Hard, "MoleResolvePenalty - very hard" },                                                                                                     // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.Motivated, "Motivated" },                                                                                                                                             // Motivated - Villagers with this effect have a +1 boost to their Resolve.
		{ ResolveEffectTypes.New_Year_Penalty, "New Year Penalty" },                                                                                                                               // Hostility of the Forest - The forest is becoming more dangerous with each passing year... the people are scared.
		{ ResolveEffectTypes.No_Fire_Penalty, "No Fire Penalty" },                                                                                                                                 // No Hope - The fire has gone out, and darkness is spreading around the town.
		{ ResolveEffectTypes.Paste_Effect, "Paste Effect" },                                                                                                                                       // Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Paste_Equal_Prohibition_Penalty, "Paste Equal Prohibition Penalty" },                                                                                                 // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Paste_Unfair_Prohibition_Penalty, "Paste Unfair Prohibition Penalty" },                                                                                               // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Child, "[PerkCrafter] Resolve - child" },                                                                                                         // Experimental Cornerstone Resolve - -2 to Global Resolve.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus1, "[PerkCrafter] Resolve +1" },                                                                                                              // Experimental Cornerstone Resolve - Resolve is increased by 1.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus2, "[PerkCrafter] Resolve +2" },                                                                                                              // Experimental Cornerstone Resolve - Resolve is increased by 2.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus3, "[PerkCrafter] Resolve +3" },                                                                                                              // Experimental Cornerstone Resolve - Resolve is increased by 3.
		{ ResolveEffectTypes.Picked_Goods_Effect, "Picked Goods Effect" },                                                                                                                         // Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pickled_Goods_Equal_Prohibition_Penalty, "Pickled Goods Equal Prohibition Penalty" },                                                                                 // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pickled_Goods_Unfair_Prohibition_Penalty, "Pickled Goods Unfair Prohibition Penalty" },                                                                               // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Pie_Effect, "Pie Effect" },                                                                                                                                           // Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pie_Equal_Prohibition_Penalty, "Pie Equal Prohibition Penalty" },                                                                                                     // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pie_Unfair_Prohibition_Penalty, "Pie Unfair Prohibition Penalty" },                                                                                                   // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Porridge_Effect, "Porridge Effect" },                                                                                                                                 // Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Porridge_Equal_Prohibition_Penalty, "Porridge Equal Prohibition Penalty" },                                                                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Porridge_Unfair_Prohibition_Penalty, "Porridge Unfair Prohibition Penalty" },                                                                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Rainpunk_Comfortable, "Rainpunk Comfortable" },                                                                                                                       // Low Strain - Work is much easier with Rain Engines on
		{ ResolveEffectTypes.Rebelious_Spirit, "Rebelious Spirit" },                                                                                                                               // Rebellious Spirit - The people are feeling oddly rebellious.
		{ ResolveEffectTypes.Religion_Effect, "Religion Effect" },                                                                                                                                 // Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Religion_Equal_Prohibition_Penalty, "Religion Equal Prohibition Penalty" },                                                                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Religion_Fallback_Effect, "Religion Fallback Effect" },                                                                                                               // Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Religion_Unfair_Prohibition_Penalty, "Religion Unfair Prohibition Penalty" },                                                                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Resolve_Effect_Institution_Resolve_For_Ruins, "Resolve Effect - Institution Resolve for Ruins" },                                                                     // The Crown Chronicles - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Institution_Resolve_For_Sales, "Resolve Effect - Institution Resolve for Sales" },                                                                     // The Guild's Welfare - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Chests, "Resolve Effect - Resolve for chests" },                                                                                           // Prosperous Archaeology - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Sales, "Resolve Effect - Resolve for sales" },                                                                                             // Prosperous Settlement - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Standing, "Resolve Effect - Resolve for Standing" },                                                                                       // Friendly Relations - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_For_Glade_Resolve_Status, "Resolve for Glade - Resolve Status" },                                                                                             // Inspiring Work - The woodcutters' song lifts people's spirits.
		{ ResolveEffectTypes.ResolveEffect_HearthEffect_Lizard, "ResolveEffect_HearthEffect_Lizard" },                                                                                             // Sacred Pyre - Lizard firekeepers are very adept at ancient rites.
		{ ResolveEffectTypes.Royal_Guard_Training_Resolve_Effect, "Royal Guard Training - Resolve Effect" },                                                                                       // Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them. 
		{ ResolveEffectTypes.SacrificeTotemPositive, "SacrificeTotemPositive" },                                                                                                                   // Converted Totem of Denial - A Totem of Denial cleansed by the Holy Flame. Grants a Global Resolve bonus.
		{ ResolveEffectTypes.SE_Creeping_Shadows_Resolve_Penalty_Status, "SE Creeping Shadows - Resolve Penalty Status" },                                                                         // Shadowy Figure - People fear the unknown during the storm.
		{ ResolveEffectTypes.SE_Devastating_Storms, "SE Devastating Storms" },                                                                                                                     // Devastating Storms - The rampaging storm stifles the spirit of all living creatures.
		{ ResolveEffectTypes.SE_Hot_Springs_Resolve_Status, "SE Hot Springs (Resolve Status)" },                                                                                                   // Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators.
		{ ResolveEffectTypes.SE_Mine_In_Storm_Resolve_Status, "SE Mine in Storm (Resolve Status)" },                                                                                               // Horrors from Beneath - A strange chant is frightening the villagers.
		{ ResolveEffectTypes.SE_Resolve_For_Water_Resolve_Effect, "SE Resolve for Water - Resolve Effect" },                                                                                       // Saturated Air - A pleasant, earthy scent is in the air.
		{ ResolveEffectTypes.SE_Storm_Clothes_Resolve_Status, "SE Storm Clothes - Resolve Status" },                                                                                               // Cloudburst - The heavy rain is unbearable.
		{ ResolveEffectTypes.Skewer_Effect, "Skewer Effect" },                                                                                                                                     // Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Skewers_Equal_Prohibition_Penalty, "Skewers Equal Prohibition Penalty" },                                                                                             // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Skewers_Unfair_Prohibition_Penalty, "Skewers Unfair Prohibition Penalty" },                                                                                           // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Spiced_Ale, "Spiced Ale" },                                                                                                                                           // Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure.
		{ ResolveEffectTypes.Spices_From_The_Capital, "Spices from the Capital" },                                                                                                                 // Spices from the Citadel - Spices from the Smoldering City - a favorite of Humans and Lizardfolk.
		{ ResolveEffectTypes.Stag_Blessing, "Stag Blessing" },                                                                                                                                     // Stag's Blessing - The forest god has blessed your villagers. This day will be remembered for generations.
		{ ResolveEffectTypes.Storm_Homelessness_Penalty, "Storm Homelessness Penalty" },                                                                                                           // Drenched - Villagers with this effect have a -5 penalty to their Resolve.
		{ ResolveEffectTypes.Storm_Penalty, "Storm Penalty" },                                                                                                                                     // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
		{ ResolveEffectTypes.Stormbird_Egg_Resolve_Effect, "Stormbird Egg - Resolve Effect" },                                                                                                     // Stormbird's Cry - Villagers report seeing a giant beast flying above the settlement during the storm.
		{ ResolveEffectTypes.Survivor_Bonding_Effect, "Survivor Bonding Effect" },                                                                                                                 // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
		{ ResolveEffectTypes.Survivor_Bonding_Effect_Altar, "Survivor Bonding Effect - Altar" },                                                                                                   // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
		{ ResolveEffectTypes.T_Storm_Penalty, "T Storm Penalty" },                                                                                                                                 // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
		{ ResolveEffectTypes.Termites_Resolve_Normal, "Termites Resolve - normal" },                                                                                                               // Stonetooth Swarm - Agitated termites can be a real nuisance.
		{ ResolveEffectTypes.TEST_Plague_Of_Snakes_Resolve, "TEST Plague of Snakes Resolve" },                                                                                                     // Plague of Snakes - Villagers are horrified by the sight of venomous snakes on the roads.
		{ ResolveEffectTypes.Toxic_Fumes, "Toxic Fumes" },                                                                                                                                         // Toxic Fumes - A strange white mist is produced when using Rainpunk technology...
		{ ResolveEffectTypes.Treatment_Effect, "Treatment Effect" },                                                                                                                               // Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Treatment_Equal_Prohibition_Penalty, "Treatment Equal Prohibition Penalty" },                                                                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Treatment_Fallback_Effect, "Treatment Fallback Effect" },                                                                                                             // Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Treatment_Unfair_Prohibition_Penalty, "Treatment Unfair Prohibition Penalty" },                                                                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.TW_Global_Resolve, "[TW] Global Resolve" },                                                                                                                           // Tale - Not as good as the Gleeman's Tale, but it did its job.
		{ ResolveEffectTypes.Unfair_Treatment_Penalty, "Unfair Treatment Penalty" },                                                                                                               // Negligence - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
		{ ResolveEffectTypes.VaultResolvePenalty_Hard, "VaultResolvePenalty - hard" },                                                                                                             // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
		{ ResolveEffectTypes.VaultResolvePenalty_Impossible, "VaultResolvePenalty - impossible" },                                                                                                 // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
		{ ResolveEffectTypes.VaultResolvePenalty_Normal, "VaultResolvePenalty - normal" },                                                                                                         // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
		{ ResolveEffectTypes.VaultResolvePenalty_Very_Hard, "VaultResolvePenalty - very hard" },                                                                                                   // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
		{ ResolveEffectTypes.Vitality, "Vitality" },                                                                                                                                               // Vitality - Well-nourished villagers enjoy their good health.
		{ ResolveEffectTypes.WE_Feast_Hall_Funeral_Resolve_Effect_0_Normal, "[WE] Feast Hall - Funeral - Resolve Effect - 0 - normal" },                                                           // Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
		{ ResolveEffectTypes.WE_Feast_Hall_Funeral_Resolve_Effect_1_Hard, "[WE] Feast Hall - Funeral - Resolve Effect - 1 - hard" },                                                               // Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
		{ ResolveEffectTypes.WE_Feast_Hall_Funeral_Resolve_Effect_2_Very_Hard, "[WE] Feast Hall - Funeral - Resolve Effect - 2 - very hard" },                                                     // Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
		{ ResolveEffectTypes.WE_Feast_Hall_Funeral_Resolve_Effect_3_Impossible, "[WE] Feast Hall - Funeral - Resolve Effect - 3 - impossible" },                                                   // Memorial Rite - An aura of sorrow has befallen the town, with somber chants echoing from the Feast Hall.
		{ ResolveEffectTypes.WE_First_Elder_Cat_Resolve_Effect, "[WE] First Elder Cat Resolve Effect" },                                                                                           // The Elder's Cat - From time to time, a weary villager stops to pet the cat, finding comfort in the reminder of their true home on the slopes of Red Mountain.
		{ ResolveEffectTypes.Wealth, "Wealth" },                                                                                                                                                   // Wealth - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Consequence_Resolve_Penalty, "Worse Storms for Hostility Consequence Resolve Penalty" },                                                   // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Resolve_Penalty, "Worse Storms for Hostility Resolve Penalty" },                                                                           // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.

	};
}
