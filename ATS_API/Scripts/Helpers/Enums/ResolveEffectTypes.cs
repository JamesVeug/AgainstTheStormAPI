using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;
// ReSharper disable All

/// <summary>
/// Generated using Version 1.5.6R
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
	Acidic_Environment,

	/// <summary>
	/// Acidic Environment - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Acidic Environment Blightrot</name>
	Acidic_Environment_Blightrot,

	/// <summary>
	/// Industrialized Agriculture - New farming methods are very effective, but cause a lot of pollution.
	/// </summary>
	/// <name>Agriculture Penalty</name>
	Agriculture_Penalty,

	/// <summary>
	/// Small Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 1</name>
	Ancient_Artifact_1,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 2</name>
	Ancient_Artifact_2,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact 3</name>
	Ancient_Artifact_3,

	/// <summary>
	/// Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	/// </summary>
	/// <name>Ancient Artifact - weak</name>
	Ancient_Artifact_Weak,

	/// <summary>
	/// Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
	/// </summary>
	/// <name>Any Housing Effect</name>
	Any_Housing_Effect,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - hard</name>
	BattlegroundPenalty_Hard,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - impossible</name>
	BattlegroundPenalty_Impossible,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - normal</name>
	BattlegroundPenalty_Normal,

	/// <summary>
	/// Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	/// </summary>
	/// <name>BattlegroundPenalty - very hard</name>
	BattlegroundPenalty_Very_Hard,

	/// <summary>
	/// Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
	/// </summary>
	/// <name>Beaver Housing Effect</name>
	Beaver_Housing_Effect,

	/// <summary>
	/// Vineyard Town - The settlement specializes in wine production, and Beavers love that.
	/// </summary>
	/// <name>Beaver Resolve Wine</name>
	Beaver_Resolve_Wine,

	/// <summary>
	/// Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
	/// </summary>
	/// <name>Beavers Faction Support</name>
	Beavers_Faction_Support,

	/// <summary>
	/// Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Biscuits Effect</name>
	Biscuits_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Biscuits Equal Prohibition Penalty</name>
	Biscuits_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Biscuits Unfair Prohibition Penalty</name>
	Biscuits_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Coal)</name>
	Blazing_Fire_Coal,

	/// <summary>
	/// Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Oil)</name>
	Blazing_Fire_Oil,

	/// <summary>
	/// Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	/// </summary>
	/// <name>Blazing Fire (Sea Marrow)</name>
	Blazing_Fire_Sea_Marrow,

	/// <summary>
	/// Blazing Fire (Wood) - Darkness flees before the might of the fire.
	/// </summary>
	/// <name>Blazing Fire (Wood)</name>
	Blazing_Fire_Wood,

	/// <summary>
	/// Blood Flower - The odor of Blood Flowers is making people feel sick.
	/// </summary>
	/// <name>Blightrot Resolve</name>
	Blightrot_Resolve,

	/// <summary>
	/// ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	/// </summary>
	/// <name>Blightrot_tier2</name>
	Blightrot_tier2,

	/// <summary>
	/// ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	/// </summary>
	/// <name>Blightrot_tier3</name>
	Blightrot_tier3,

	/// <summary>
	/// Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Bloodthirst Effect</name>
	Bloodthirst_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Bloodthirst Equal Prohibition Penalty</name>
	Bloodthirst_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Bloodthirst Unfair Prohibition Penalty</name>
	Bloodthirst_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
	/// </summary>
	/// <name>Boots Effect</name>
	Boots_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Boots Equal Prohibition Penalty</name>
	Boots_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Boots Unfair Prohibition Penalty</name>
	Boots_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
	/// </summary>
	/// <name>Cauldron Resolve</name>
	Cauldron_Resolve,

	/// <summary>
	/// City Renown - The city is becoming known among folk as a great place to live.
	/// </summary>
	/// <name>City Renown</name>
	City_Renown,

	/// <summary>
	/// Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
	/// </summary>
	/// <name>Clothes Effect</name>
	Clothes_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Clothes Equal Prohibition Penalty</name>
	Clothes_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Clothes Unfair Prohibition Penalty</name>
	Clothes_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Comfortable - This worker gains +5 to their Resolve.
	/// </summary>
	/// <name>Comfortable Job</name>
	Comfortable_Job,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - hard</name>
	Convicts_Hard,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - impossible</name>
	Convicts_Impossible,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - normal</name>
	Convicts_Normal,

	/// <summary>
	/// Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	/// </summary>
	/// <name>Convicts - very hard</name>
	Convicts_Very_Hard,

	/// <summary>
	/// Greater Threat - Villagers don't approve of discovering Dangerous ("dangerous") and Forbidden Glades ("forbidden") during the storm.
	/// </summary>
	/// <name>Dang Glades Reduces Resolve Effect</name>
	Dang_Glades_Reduces_Resolve_Effect,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - hard</name>
	DarkGatePenalty_Hard,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - impossible</name>
	DarkGatePenalty_Impossible,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - normal</name>
	DarkGatePenalty_Normal,

	/// <summary>
	/// Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	/// </summary>
	/// <name>DarkGatePenalty - very hard</name>
	DarkGatePenalty_Very_Hard,

	/// <summary>
	/// Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Education Effect</name>
	Education_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Education Equal Prohibition Penalty</name>
	Education_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Education Unfair Prohibition Penalty</name>
	Education_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Tales of Discovery - Tales of distant lands and brave explorers.
	/// </summary>
	/// <name>Explorer Tales</name>
	Explorer_Tales,

	/// <summary>
	/// Explorers' Boredom - Who would have thought that great explorers are not so great at planting mushrooms?
	/// </summary>
	/// <name>Explorers Boredom</name>
	Explorers_Boredom,

	/// <summary>
	/// Joy Of Discovery - There’s something truly magical about setting one's foot in a place that’s been hidden for millennia.
	/// </summary>
	/// <name>Exploring Expedition - Resolve Status</name>
	Exploring_Expedition_Resolve_Status,

	/// <summary>
	/// Extreme Noise - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Extreme Noise</name>
	Extreme_Noise,

	/// <summary>
	/// Fallen Viceroy Commemoration - Villagers with their need for species-specific housing met will get an additional +2 to Resolve.
	/// </summary>
	/// <name>FallenViceroyCommemoration</name>
	FallenViceroyCommemoration,

	/// <summary>
	/// Favoring - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	/// </summary>
	/// <name>Favoring Effect</name>
	Favoring_Effect,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - hard</name>
	Fear_Of_The_Wilds_T1_Hard,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - impossible</name>
	Fear_Of_The_Wilds_T1_Impossible,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - normal</name>
	Fear_Of_The_Wilds_T1_Normal,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T1 - very hard</name>
	Fear_Of_The_Wilds_T1_Very_Hard,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - hard</name>
	Fear_Of_The_Wilds_T2_Hard,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - impossible</name>
	Fear_Of_The_Wilds_T2_Impossible,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - normal</name>
	Fear_Of_The_Wilds_T2_Normal,

	/// <summary>
	/// Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	/// </summary>
	/// <name>Fear of the Wilds T2 - very hard</name>
	Fear_Of_The_Wilds_T2_Very_Hard,

	/// <summary>
	/// Creeping Fishmen - Something is observing the villagers from the edge of the woods.
	/// </summary>
	/// <name>Fishmen Resolve</name>
	Fishmen_Resolve,

	/// <summary>
	/// Forced Improvisation - Working in a loud environment is really taxing.
	/// </summary>
	/// <name>Forced improvisation</name>
	Forced_Improvisation,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - hard</name>
	Forsaken_Crypt_Resolve_Effect_Hard,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - impossible</name>
	Forsaken_Crypt_Resolve_Effect_Impossible,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - normal</name>
	Forsaken_Crypt_Resolve_Effect_Normal,

	/// <summary>
	/// Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	/// </summary>
	/// <name>Forsaken Crypt Resolve Effect - very hard</name>
	Forsaken_Crypt_Resolve_Effect_Very_Hard,

	/// <summary>
	/// Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
	/// </summary>
	/// <name>Fox Housing Effect</name>
	Fox_Housing_Effect,

	/// <summary>
	/// Fox Pack Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Fox tribe remembers your help.
	/// </summary>
	/// <name>Foxes Faction Support</name>
	Foxes_Faction_Support,

	/// <summary>
	/// Haunted - Villagers are haunted by terrifying visions.
	/// </summary>
	/// <name>Frightening Visions Resolve Effect</name>
	Frightening_Visions_Resolve_Effect,

	/// <summary>
	/// Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive.
	/// </summary>
	/// <name>Frog Houses Bonus Resolve</name>
	Frog_Houses_Bonus_Resolve,

	/// <summary>
	/// Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
	/// </summary>
	/// <name>Frog Housing Effect</name>
	Frog_Housing_Effect,

	/// <summary>
	/// Frog Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Frogs remember your help.
	/// </summary>
	/// <name>Frogs Faction Support</name>
	Frogs_Faction_Support,

	/// <summary>
	/// Frustrated - Villagers with this effect have a -2 penalty to their Resolve.
	/// </summary>
	/// <name>Frustrated</name>
	Frustrated,

	/// <summary>
	/// Furniture - Adds an additional +1 to Resolve for villagers with a home.
	/// </summary>
	/// <name>Furniture</name>
	Furniture,

	/// <summary>
	/// Generous Rations - A surplus of food makes the villagers happy.
	/// </summary>
	/// <name>Generous Rations</name>
	Generous_Rations,

	/// <summary>
	/// Harmony - When your villagers' needs are met, Harmony is fostered.
	/// </summary>
	/// <name>Harmony Altar</name>
	Harmony_Altar,

	/// <summary>
	/// Chaos - Harmony has been disturbed.
	/// </summary>
	/// <name>Harmony Altar Chaos Resolve</name>
	Harmony_Altar_Chaos_Resolve,

	/// <summary>
	/// Harpy Clan Support - The Flock was neutral during the Great Civil War, but you've proven your worth to them now.
	/// </summary>
	/// <name>Harpy Faction Support</name>
	Harpy_Faction_Support,

	/// <summary>
	/// Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
	/// </summary>
	/// <name>Harpy Housing Effect</name>
	Harpy_Housing_Effect,

	/// <summary>
	/// Health Infusion - High tea production is boosting Harpies' morale.
	/// </summary>
	/// <name>Harpy Resolve Tea</name>
	Harpy_Resolve_Tea,

	/// <summary>
	/// Unique Ally - An exceptionally strong bond has developed between the Harpies and the Stormbird. They look very pleased to be in its presence.
	/// </summary>
	/// <name>Harpy Stormbird Resolve</name>
	Harpy_Stormbird_Resolve,

	/// <summary>
	/// Homelessness - People need houses.
	/// </summary>
	/// <name>Homelessness Penalty</name>
	Homelessness_Penalty,

	/// <summary>
	/// Stove - A small reminder of the Holy Flame.
	/// </summary>
	/// <name>Houses Bonus Resolve</name>
	Houses_Bonus_Resolve,

	/// <summary>
	/// Encampment (Level 1) - Gathered around the blazing fire, folks keep each other's spirits high.
	/// </summary>
	/// <name>[Hub] Hub Resolve T1</name>
	Hub_Hub_Resolve_T1,

	/// <summary>
	/// Neighborhood (Level 2) - Even in such a harsh environment, there is still room for beauty.
	/// </summary>
	/// <name>[Hub] Hub Resolve T2</name>
	Hub_Hub_Resolve_T2,

	/// <summary>
	/// District (Level 3) - The town is booming with activity, and industry thrives.
	/// </summary>
	/// <name>[Hub] Hub Resolve T3</name>
	Hub_Hub_Resolve_T3,

	/// <summary>
	/// Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
	/// </summary>
	/// <name>Human Housing Effect</name>
	Human_Housing_Effect,

	/// <summary>
	/// Sweet Aroma - A sweet aroma is spreading around the settlement. It seems to be making the Humans feel content.
	/// </summary>
	/// <name>Human Resolve Incense</name>
	Human_Resolve_Incense,

	/// <summary>
	/// Human Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Humans remember your help.
	/// </summary>
	/// <name>Humans Faction Support</name>
	Humans_Faction_Support,

	/// <summary>
	/// Hunger - People are starving. This effect stacks every time a villager doesn't eat during a break.
	/// </summary>
	/// <name>Hunger Penalty</name>
	Hunger_Penalty,

	/// <summary>
	/// Gleeman's Tales - Every evening, a Gleeman tells stories about past glories, and times before the Great Civil War.
	/// </summary>
	/// <name>Institution Global Resolve</name>
	Institution_Global_Resolve,

	/// <summary>
	/// Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Jerky Effect</name>
	Jerky_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Jerky Equal Prohibition Penalty</name>
	Jerky_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Jerky Unfair Prohibition Penalty</name>
	Jerky_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Leasiure Effect</name>
	Leasiure_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Leasiure Equal Prohibition Penalty</name>
	Leasiure_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Leasiure Unfair Prohibition Penalty</name>
	Leasiure_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
	/// </summary>
	/// <name>Lizard Housing Effect</name>
	Lizard_Housing_Effect,

	/// <summary>
	/// Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
	/// </summary>
	/// <name>Lizard Resolve Training Gear</name>
	Lizard_Resolve_Training_Gear,

	/// <summary>
	/// Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
	/// </summary>
	/// <name>Lizards Faction Support</name>
	Lizards_Faction_Support,

	/// <summary>
	/// Long Live the Queen - Villagers admire the Queen's greatness.
	/// </summary>
	/// <name>Long Live the Queen</name>
	Long_Live_The_Queen,

	/// <summary>
	/// Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Luxury Effect</name>
	Luxury_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Luxury Equal Prohibition Penalty</name>
	Luxury_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Luxury Unfair Prohibition Penalty</name>
	Luxury_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Forsaken Gods Temple - ModifierEffect_TempleResolve_Desc
	/// </summary>
	/// <name>[Map Mod] Resolve</name>
	Map_Mod_Resolve,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - hard</name>
	MoleResolvePenalty_Hard,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - impossible</name>
	MoleResolvePenalty_Impossible,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - normal</name>
	MoleResolvePenalty_Normal,

	/// <summary>
	/// Giant Beast - Villagers are afraid of going into the woods.
	/// </summary>
	/// <name>MoleResolvePenalty - very hard</name>
	MoleResolvePenalty_Very_Hard,

	/// <summary>
	/// Motivated - Villagers with this effect have a +1 boost to their Resolve.
	/// </summary>
	/// <name>Motivated</name>
	Motivated,

	/// <summary>
	/// Hostility of the Forest - The forest is becoming more dangerous with each passing year... the people are scared.
	/// </summary>
	/// <name>New Year Penalty</name>
	New_Year_Penalty,

	/// <summary>
	/// No Hope - The fire has gone out, and darkness is spreading around the town.
	/// </summary>
	/// <name>No Fire Penalty</name>
	No_Fire_Penalty,

	/// <summary>
	/// Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Paste Effect</name>
	Paste_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Paste Equal Prohibition Penalty</name>
	Paste_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Paste Unfair Prohibition Penalty</name>
	Paste_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 1.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +1</name>
	PerkCrafter_Resolve_Plus1,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 2.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +2</name>
	PerkCrafter_Resolve_Plus2,

	/// <summary>
	/// Experimental Cornerstone Resolve - Resolve is increased by 3.
	/// </summary>
	/// <name>[PerkCrafter] Resolve +3</name>
	PerkCrafter_Resolve_Plus3,

	/// <summary>
	/// Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Picked Goods Effect</name>
	Picked_Goods_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Pickled Goods Equal Prohibition Penalty</name>
	Pickled_Goods_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Pickled Goods Unfair Prohibition Penalty</name>
	Pickled_Goods_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Pie Effect</name>
	Pie_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Pie Equal Prohibition Penalty</name>
	Pie_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Pie Unfair Prohibition Penalty</name>
	Pie_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Porridge Effect</name>
	Porridge_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Porridge Equal Prohibition Penalty</name>
	Porridge_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Porridge Unfair Prohibition Penalty</name>
	Porridge_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Low Strain - Work is much easier with Rain Engines on
	/// </summary>
	/// <name>Rainpunk Comfortable</name>
	Rainpunk_Comfortable,

	/// <summary>
	/// Rebellious Spirit - The people are feeling oddly rebellious.
	/// </summary>
	/// <name>Rebelious Spirit</name>
	Rebelious_Spirit,

	/// <summary>
	/// Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Religion Effect</name>
	Religion_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Religion Equal Prohibition Penalty</name>
	Religion_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Religion Unfair Prohibition Penalty</name>
	Religion_Unfair_Prohibition_Penalty,

	/// <summary>
	/// The Crown Chronicles - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Institution Resolve for Ruins</name>
	Resolve_Effect_Institution_Resolve_For_Ruins,

	/// <summary>
	/// The Guild's Welfare - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Institution Resolve for Sales</name>
	Resolve_Effect_Institution_Resolve_For_Sales,

	/// <summary>
	/// Prosperous Archaeology - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for chests</name>
	Resolve_Effect_Resolve_For_Chests,

	/// <summary>
	/// Prosperous Settlement - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for sales</name>
	Resolve_Effect_Resolve_For_Sales,

	/// <summary>
	/// Friendly Relations - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Resolve Effect - Resolve for Standing</name>
	Resolve_Effect_Resolve_For_Standing,

	/// <summary>
	/// Inspiring Work - The woodcutters' song lifts people's spirits.
	/// </summary>
	/// <name>Resolve for Glade - Resolve Status</name>
	Resolve_For_Glade_Resolve_Status,

	/// <summary>
	/// Sacred Pyre - Lizard firekeepers are very adept at ancient rites.
	/// </summary>
	/// <name>ResolveEffect_HearthEffect_Lizard</name>
	ResolveEffect_HearthEffect_Lizard,

	/// <summary>
	/// Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them. 
	/// </summary>
	/// <name>Royal Guard Training - Resolve Effect</name>
	Royal_Guard_Training_Resolve_Effect,

	/// <summary>
	/// Converted Totem of Denial - A Totem of Denial cleansed by the Holy Flame. Grants a Global Resolve bonus.
	/// </summary>
	/// <name>SacrificeTotemPositive</name>
	SacrificeTotemPositive,

	/// <summary>
	/// Shadowy Figure - People fear the unknown during the storm.
	/// </summary>
	/// <name>SE Creeping Shadows - Resolve Penalty Status</name>
	SE_Creeping_Shadows_Resolve_Penalty_Status,

	/// <summary>
	/// Devastating Storms - The rampaging storm stifles the spirit of all living creatures.
	/// </summary>
	/// <name>SE Devastating Storms</name>
	SE_Devastating_Storms,

	/// <summary>
	/// Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators.
	/// </summary>
	/// <name>SE Hot Springs (Resolve Status)</name>
	SE_Hot_Springs_Resolve_Status,

	/// <summary>
	/// Horrors from Beneath - A strange chant is frightening the villagers.
	/// </summary>
	/// <name>SE Mine in Storm (Resolve Status)</name>
	SE_Mine_In_Storm_Resolve_Status,

	/// <summary>
	/// Saturated Air - A pleasant, earthy scent is in the air.
	/// </summary>
	/// <name>SE Resolve for Water - Resolve Effect</name>
	SE_Resolve_For_Water_Resolve_Effect,

	/// <summary>
	/// Cloudburst - The heavy rain is unbearable.
	/// </summary>
	/// <name>SE Storm Clothes - Resolve Status</name>
	SE_Storm_Clothes_Resolve_Status,

	/// <summary>
	/// Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Skewer Effect</name>
	Skewer_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Skewers Equal Prohibition Penalty</name>
	Skewers_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Skewers Unfair Prohibition Penalty</name>
	Skewers_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure.
	/// </summary>
	/// <name>Spiced Ale</name>
	Spiced_Ale,

	/// <summary>
	/// Spices from the Citadel - Spices from the Smoldering City - a favorite of Humans and Lizardfolk.
	/// </summary>
	/// <name>Spices from the Capital</name>
	Spices_From_The_Capital,

	/// <summary>
	/// Stag's Blessing - The forest god has blessed your villagers. This day will be remembered for generations.
	/// </summary>
	/// <name>Stag Blessing</name>
	Stag_Blessing,

	/// <summary>
	/// Drenched - Villagers with this effect have a -5 penalty to their Resolve.
	/// </summary>
	/// <name>Storm Homelessness Penalty</name>
	Storm_Homelessness_Penalty,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	/// </summary>
	/// <name>Storm Penalty</name>
	Storm_Penalty,

	/// <summary>
	/// Stormbird's Cry - Villagers report seeing a giant beast flying above the settlement during the storm.
	/// </summary>
	/// <name>Stormbird Egg - Resolve Effect</name>
	Stormbird_Egg_Resolve_Effect,

	/// <summary>
	/// Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	/// </summary>
	/// <name>Survivor Bonding Effect</name>
	Survivor_Bonding_Effect,

	/// <summary>
	/// Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	/// </summary>
	/// <name>Survivor Bonding Effect - Altar</name>
	Survivor_Bonding_Effect_Altar,

	/// <summary>
	/// Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	/// </summary>
	/// <name>T Storm Penalty</name>
	T_Storm_Penalty,

	/// <summary>
	/// Stonetooth Swarm - Agitated termites can be a real nuisance.
	/// </summary>
	/// <name>Termites Resolve - normal</name>
	Termites_Resolve_Normal,

	/// <summary>
	/// Plague of Snakes - Villagers are horrified by the sight of venomous snakes on the roads.
	/// </summary>
	/// <name>TEST Plague of Snakes Resolve</name>
	TEST_Plague_Of_Snakes_Resolve,

	/// <summary>
	/// Toxic Fumes - A strange white mist is produced when using Rainpunk technology...
	/// </summary>
	/// <name>Toxic Fumes</name>
	Toxic_Fumes,

	/// <summary>
	/// Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
	/// </summary>
	/// <name>Treatment Effect</name>
	Treatment_Effect,

	/// <summary>
	/// Rationing - No one likes being denied the fruits of their own labor.
	/// </summary>
	/// <name>Treatment Equal Prohibition Penalty</name>
	Treatment_Equal_Prohibition_Penalty,

	/// <summary>
	/// Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	/// </summary>
	/// <name>Treatment Unfair Prohibition Penalty</name>
	Treatment_Unfair_Prohibition_Penalty,

	/// <summary>
	/// Tale - Not as good as the Gleeman's Tale, but it did its job.
	/// </summary>
	/// <name>[TW] Global Resolve</name>
	TW_Global_Resolve,

	/// <summary>
	/// Negligence - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	/// </summary>
	/// <name>Unfair Treatment Penalty</name>
	Unfair_Treatment_Penalty,

	/// <summary>
	/// Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	/// </summary>
	/// <name>VaultResolvePenalty - normal</name>
	VaultResolvePenalty_Normal,

	/// <summary>
	/// Vitality - Well-nourished villagers enjoy their good health.
	/// </summary>
	/// <name>Vitality</name>
	Vitality,

	/// <summary>
	/// Wealth - The people are enjoying living in a prosperous settlement.
	/// </summary>
	/// <name>Wealth</name>
	Wealth,

	/// <summary>
	/// Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
	/// </summary>
	/// <name>Worse Storms for Hostility Consequence Resolve Penalty</name>
	Worse_Storms_For_Hostility_Consequence_Resolve_Penalty,

	/// <summary>
	/// Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
	/// </summary>
	/// <name>Worse Storms for Hostility Resolve Penalty</name>
	Worse_Storms_For_Hostility_Resolve_Penalty,


    /// <summary>
    /// The total number of vanilla ResolveEffectTypes in the game.
    /// </summary>
	MAX = 175
}

/// <summary>
/// Extension methods for the ResolveEffectTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class ResolveEffectTypesExtensions
{
	private static ResolveEffectTypes[] s_All = null;
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

		Plugin.Log.LogError($"Cannot find name of ResolveEffectTypes: " + type + "\n" + Environment.StackTrace);
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

		Plugin.Log.LogWarning("Cannot find ResolveEffectTypes with name: " + name + "\n" + Environment.StackTrace);
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
	
		Plugin.Log.LogError("Cannot find ResolveEffectModel for ResolveEffectTypes with name: " + name + "\n" + Environment.StackTrace);
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
		{ ResolveEffectTypes.Acidic_Environment, "Acidic Environment" },                                                                         // Acidic Environment - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Acidic_Environment_Blightrot, "Acidic Environment Blightrot" },                                                     // Acidic Environment - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Agriculture_Penalty, "Agriculture Penalty" },                                                                       // Industrialized Agriculture - New farming methods are very effective, but cause a lot of pollution.
		{ ResolveEffectTypes.Ancient_Artifact_1, "Ancient Artifact 1" },                                                                         // Small Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_2, "Ancient Artifact 2" },                                                                         // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_3, "Ancient Artifact 3" },                                                                         // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Ancient_Artifact_Weak, "Ancient Artifact - weak" },                                                                 // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
		{ ResolveEffectTypes.Any_Housing_Effect, "Any Housing Effect" },                                                                         // Basic Housing - Most species require at least basic shelter from the constant rainfall and gusting winds.
		{ ResolveEffectTypes.BattlegroundPenalty_Hard, "BattlegroundPenalty - hard" },                                                           // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Impossible, "BattlegroundPenalty - impossible" },                                               // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Normal, "BattlegroundPenalty - normal" },                                                       // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Very_Hard, "BattlegroundPenalty - very hard" },                                                 // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.Beaver_Housing_Effect, "Beaver Housing Effect" },                                                                   // Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
		{ ResolveEffectTypes.Beaver_Resolve_Wine, "Beaver Resolve Wine" },                                                                       // Vineyard Town - The settlement specializes in wine production, and Beavers love that.
		{ ResolveEffectTypes.Beavers_Faction_Support, "Beavers Faction Support" },                                                               // Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
		{ ResolveEffectTypes.Biscuits_Effect, "Biscuits Effect" },                                                                               // Biscuits - This need is fulfilled at the Hearth. It requires "[food processed] biscuits" biscuits. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Biscuits_Equal_Prohibition_Penalty, "Biscuits Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Biscuits_Unfair_Prohibition_Penalty, "Biscuits Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Blazing_Fire_Coal, "Blazing Fire (Coal)" },                                                                         // Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Oil, "Blazing Fire (Oil)" },                                                                           // Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Sea_Marrow, "Blazing Fire (Sea Marrow)" },                                                             // Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Wood, "Blazing Fire (Wood)" },                                                                         // Blazing Fire (Wood) - Darkness flees before the might of the fire.
		{ ResolveEffectTypes.Blightrot_Resolve, "Blightrot Resolve" },                                                                           // Blood Flower - The odor of Blood Flowers is making people feel sick.
		{ ResolveEffectTypes.Blightrot_tier2, "Blightrot_tier2" },                                                                               // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Blightrot_tier3, "Blightrot_tier3" },                                                                               // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Bloodthirst_Effect, "Bloodthirst Effect" },                                                                         // Brawling - Requires "[needs] training gear" training gear. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Bloodthirst_Equal_Prohibition_Penalty, "Bloodthirst Equal Prohibition Penalty" },                                   // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Bloodthirst_Unfair_Prohibition_Penalty, "Bloodthirst Unfair Prohibition Penalty" },                                 // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Boots_Effect, "Boots Effect" },                                                                                     // Boots - This need is fulfilled at the Hearth. It requires "[needs] boots" boots. Satisfying this need grants a movement speed bonus.
		{ ResolveEffectTypes.Boots_Equal_Prohibition_Penalty, "Boots Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Boots_Unfair_Prohibition_Penalty, "Boots Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Cauldron_Resolve, "Cauldron Resolve" },                                                                             // Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
		{ ResolveEffectTypes.City_Renown, "City Renown" },                                                                                       // City Renown - The city is becoming known among folk as a great place to live.
		{ ResolveEffectTypes.Clothes_Effect, "Clothes Effect" },                                                                                 // Coats - This need is fulfilled at the Hearth. It requires "[needs] coats" coats. Satisfying this need grants a Resolve bonus during the storm.
		{ ResolveEffectTypes.Clothes_Equal_Prohibition_Penalty, "Clothes Equal Prohibition Penalty" },                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Clothes_Unfair_Prohibition_Penalty, "Clothes Unfair Prohibition Penalty" },                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Comfortable_Job, "Comfortable Job" },                                                                               // Comfortable - This worker gains +5 to their Resolve.
		{ ResolveEffectTypes.Convicts_Hard, "Convicts - hard" },                                                                                 // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Impossible, "Convicts - impossible" },                                                                     // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Normal, "Convicts - normal" },                                                                             // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Very_Hard, "Convicts - very hard" },                                                                       // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Dang_Glades_Reduces_Resolve_Effect, "Dang Glades Reduces Resolve Effect" },                                         // Greater Threat - Villagers don't approve of discovering Dangerous ("dangerous") and Forbidden Glades ("forbidden") during the storm.
		{ ResolveEffectTypes.DarkGatePenalty_Hard, "DarkGatePenalty - hard" },                                                                   // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Impossible, "DarkGatePenalty - impossible" },                                                       // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Normal, "DarkGatePenalty - normal" },                                                               // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Very_Hard, "DarkGatePenalty - very hard" },                                                         // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.Education_Effect, "Education Effect" },                                                                             // Education - It requires "[needs] scrolls" scrolls. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Education_Equal_Prohibition_Penalty, "Education Equal Prohibition Penalty" },                                       // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Education_Unfair_Prohibition_Penalty, "Education Unfair Prohibition Penalty" },                                     // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Explorer_Tales, "Explorer Tales" },                                                                                 // Tales of Discovery - Tales of distant lands and brave explorers.
		{ ResolveEffectTypes.Explorers_Boredom, "Explorers Boredom" },                                                                           // Explorers' Boredom - Who would have thought that great explorers are not so great at planting mushrooms?
		{ ResolveEffectTypes.Exploring_Expedition_Resolve_Status, "Exploring Expedition - Resolve Status" },                                     // Joy Of Discovery - There’s something truly magical about setting one's foot in a place that’s been hidden for millennia.
		{ ResolveEffectTypes.Extreme_Noise, "Extreme Noise" },                                                                                   // Extreme Noise - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.FallenViceroyCommemoration, "FallenViceroyCommemoration" },                                                         // Fallen Viceroy Commemoration - Villagers with their need for species-specific housing met will get an additional +2 to Resolve.
		{ ResolveEffectTypes.Favoring_Effect, "Favoring Effect" },                                                                               // Favoring - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Hard, "Fear of the Wilds T1 - hard" },                                                         // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Impossible, "Fear of the Wilds T1 - impossible" },                                             // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Normal, "Fear of the Wilds T1 - normal" },                                                     // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1_Very_Hard, "Fear of the Wilds T1 - very hard" },                                               // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Hard, "Fear of the Wilds T2 - hard" },                                                         // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Impossible, "Fear of the Wilds T2 - impossible" },                                             // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Normal, "Fear of the Wilds T2 - normal" },                                                     // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2_Very_Hard, "Fear of the Wilds T2 - very hard" },                                               // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
		{ ResolveEffectTypes.Fishmen_Resolve, "Fishmen Resolve" },                                                                               // Creeping Fishmen - Something is observing the villagers from the edge of the woods.
		{ ResolveEffectTypes.Forced_Improvisation, "Forced improvisation" },                                                                     // Forced Improvisation - Working in a loud environment is really taxing.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Hard, "Forsaken Crypt Resolve Effect - hard" },                                       // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Impossible, "Forsaken Crypt Resolve Effect - impossible" },                           // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Normal, "Forsaken Crypt Resolve Effect - normal" },                                   // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect_Very_Hard, "Forsaken Crypt Resolve Effect - very hard" },                             // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
		{ ResolveEffectTypes.Fox_Housing_Effect, "Fox Housing Effect" },                                                                         // Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
		{ ResolveEffectTypes.Foxes_Faction_Support, "Foxes Faction Support" },                                                                   // Fox Pack Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Fox tribe remembers your help.
		{ ResolveEffectTypes.Frightening_Visions_Resolve_Effect, "Frightening Visions Resolve Effect" },                                         // Haunted - Villagers are haunted by terrifying visions.
		{ ResolveEffectTypes.Frog_Houses_Bonus_Resolve, "Frog Houses Bonus Resolve" },                                                           // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive.
		{ ResolveEffectTypes.Frog_Housing_Effect, "Frog Housing Effect" },                                                                       // Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
		{ ResolveEffectTypes.Frogs_Faction_Support, "Frogs Faction Support" },                                                                   // Frog Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Frogs remember your help.
		{ ResolveEffectTypes.Frustrated, "Frustrated" },                                                                                         // Frustrated - Villagers with this effect have a -2 penalty to their Resolve.
		{ ResolveEffectTypes.Furniture, "Furniture" },                                                                                           // Furniture - Adds an additional +1 to Resolve for villagers with a home.
		{ ResolveEffectTypes.Generous_Rations, "Generous Rations" },                                                                             // Generous Rations - A surplus of food makes the villagers happy.
		{ ResolveEffectTypes.Harmony_Altar, "Harmony Altar" },                                                                                   // Harmony - When your villagers' needs are met, Harmony is fostered.
		{ ResolveEffectTypes.Harmony_Altar_Chaos_Resolve, "Harmony Altar Chaos Resolve" },                                                       // Chaos - Harmony has been disturbed.
		{ ResolveEffectTypes.Harpy_Faction_Support, "Harpy Faction Support" },                                                                   // Harpy Clan Support - The Flock was neutral during the Great Civil War, but you've proven your worth to them now.
		{ ResolveEffectTypes.Harpy_Housing_Effect, "Harpy Housing Effect" },                                                                     // Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
		{ ResolveEffectTypes.Harpy_Resolve_Tea, "Harpy Resolve Tea" },                                                                           // Health Infusion - High tea production is boosting Harpies' morale.
		{ ResolveEffectTypes.Harpy_Stormbird_Resolve, "Harpy Stormbird Resolve" },                                                               // Unique Ally - An exceptionally strong bond has developed between the Harpies and the Stormbird. They look very pleased to be in its presence.
		{ ResolveEffectTypes.Homelessness_Penalty, "Homelessness Penalty" },                                                                     // Homelessness - People need houses.
		{ ResolveEffectTypes.Houses_Bonus_Resolve, "Houses Bonus Resolve" },                                                                     // Stove - A small reminder of the Holy Flame.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T1, "[Hub] Hub Resolve T1" },                                                                       // Encampment (Level 1) - Gathered around the blazing fire, folks keep each other's spirits high.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T2, "[Hub] Hub Resolve T2" },                                                                       // Neighborhood (Level 2) - Even in such a harsh environment, there is still room for beauty.
		{ ResolveEffectTypes.Hub_Hub_Resolve_T3, "[Hub] Hub Resolve T3" },                                                                       // District (Level 3) - The town is booming with activity, and industry thrives.
		{ ResolveEffectTypes.Human_Housing_Effect, "Human Housing Effect" },                                                                     // Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
		{ ResolveEffectTypes.Human_Resolve_Incense, "Human Resolve Incense" },                                                                   // Sweet Aroma - A sweet aroma is spreading around the settlement. It seems to be making the Humans feel content.
		{ ResolveEffectTypes.Humans_Faction_Support, "Humans Faction Support" },                                                                 // Human Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Humans remember your help.
		{ ResolveEffectTypes.Hunger_Penalty, "Hunger Penalty" },                                                                                 // Hunger - People are starving. This effect stacks every time a villager doesn't eat during a break.
		{ ResolveEffectTypes.Institution_Global_Resolve, "Institution Global Resolve" },                                                         // Gleeman's Tales - Every evening, a Gleeman tells stories about past glories, and times before the Great Civil War.
		{ ResolveEffectTypes.Jerky_Effect, "Jerky Effect" },                                                                                     // Jerky - This need is fulfilled at the Hearth. It requires "[food processed] jerky" jerky. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Jerky_Equal_Prohibition_Penalty, "Jerky Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Jerky_Unfair_Prohibition_Penalty, "Jerky Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Leasiure_Effect, "Leasiure Effect" },                                                                               // Leisure - It requires "[needs] ale" ale. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Leasiure_Equal_Prohibition_Penalty, "Leasiure Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Leasiure_Unfair_Prohibition_Penalty, "Leasiure Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Lizard_Housing_Effect, "Lizard Housing Effect" },                                                                   // Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
		{ ResolveEffectTypes.Lizard_Resolve_Training_Gear, "Lizard Resolve Training Gear" },                                                     // Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
		{ ResolveEffectTypes.Lizards_Faction_Support, "Lizards Faction Support" },                                                               // Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
		{ ResolveEffectTypes.Long_Live_The_Queen, "Long Live the Queen" },                                                                       // Long Live the Queen - Villagers admire the Queen's greatness.
		{ ResolveEffectTypes.Luxury_Effect, "Luxury Effect" },                                                                                   // Luxury - It requires "[needs] wine" wine. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Luxury_Equal_Prohibition_Penalty, "Luxury Equal Prohibition Penalty" },                                             // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Luxury_Unfair_Prohibition_Penalty, "Luxury Unfair Prohibition Penalty" },                                           // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Map_Mod_Resolve, "[Map Mod] Resolve" },                                                                             // Forsaken Gods Temple - ModifierEffect_TempleResolve_Desc
		{ ResolveEffectTypes.MoleResolvePenalty_Hard, "MoleResolvePenalty - hard" },                                                             // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Impossible, "MoleResolvePenalty - impossible" },                                                 // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Normal, "MoleResolvePenalty - normal" },                                                         // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.MoleResolvePenalty_Very_Hard, "MoleResolvePenalty - very hard" },                                                   // Giant Beast - Villagers are afraid of going into the woods.
		{ ResolveEffectTypes.Motivated, "Motivated" },                                                                                           // Motivated - Villagers with this effect have a +1 boost to their Resolve.
		{ ResolveEffectTypes.New_Year_Penalty, "New Year Penalty" },                                                                             // Hostility of the Forest - The forest is becoming more dangerous with each passing year... the people are scared.
		{ ResolveEffectTypes.No_Fire_Penalty, "No Fire Penalty" },                                                                               // No Hope - The fire has gone out, and darkness is spreading around the town.
		{ ResolveEffectTypes.Paste_Effect, "Paste Effect" },                                                                                     // Paste - This need is fulfilled at the Hearth. It requires "[food processed] paste" paste. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Paste_Equal_Prohibition_Penalty, "Paste Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Paste_Unfair_Prohibition_Penalty, "Paste Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus1, "[PerkCrafter] Resolve +1" },                                                            // Experimental Cornerstone Resolve - Resolve is increased by 1.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus2, "[PerkCrafter] Resolve +2" },                                                            // Experimental Cornerstone Resolve - Resolve is increased by 2.
		{ ResolveEffectTypes.PerkCrafter_Resolve_Plus3, "[PerkCrafter] Resolve +3" },                                                            // Experimental Cornerstone Resolve - Resolve is increased by 3.
		{ ResolveEffectTypes.Picked_Goods_Effect, "Picked Goods Effect" },                                                                       // Pickled Goods - This need is fulfilled at the Hearth. It requires "[food processed] pickled goods" pickled goods. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pickled_Goods_Equal_Prohibition_Penalty, "Pickled Goods Equal Prohibition Penalty" },                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pickled_Goods_Unfair_Prohibition_Penalty, "Pickled Goods Unfair Prohibition Penalty" },                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Pie_Effect, "Pie Effect" },                                                                                         // Pie - This need is fulfilled at the Hearth. It requires "[food processed] pie" pie. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pie_Equal_Prohibition_Penalty, "Pie Equal Prohibition Penalty" },                                                   // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pie_Unfair_Prohibition_Penalty, "Pie Unfair Prohibition Penalty" },                                                 // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Porridge_Effect, "Porridge Effect" },                                                                               // Porridge - This need is fulfilled at the Hearth. It requires "[food processed] porridge" porridge. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Porridge_Equal_Prohibition_Penalty, "Porridge Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Porridge_Unfair_Prohibition_Penalty, "Porridge Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Rainpunk_Comfortable, "Rainpunk Comfortable" },                                                                     // Low Strain - Work is much easier with Rain Engines on
		{ ResolveEffectTypes.Rebelious_Spirit, "Rebelious Spirit" },                                                                             // Rebellious Spirit - The people are feeling oddly rebellious.
		{ ResolveEffectTypes.Religion_Effect, "Religion Effect" },                                                                               // Religion - It requires "[needs] incense" incense. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Religion_Equal_Prohibition_Penalty, "Religion Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Religion_Unfair_Prohibition_Penalty, "Religion Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Resolve_Effect_Institution_Resolve_For_Ruins, "Resolve Effect - Institution Resolve for Ruins" },                   // The Crown Chronicles - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Institution_Resolve_For_Sales, "Resolve Effect - Institution Resolve for Sales" },                   // The Guild's Welfare - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Chests, "Resolve Effect - Resolve for chests" },                                         // Prosperous Archaeology - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Sales, "Resolve Effect - Resolve for sales" },                                           // Prosperous Settlement - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_Effect_Resolve_For_Standing, "Resolve Effect - Resolve for Standing" },                                     // Friendly Relations - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Resolve_For_Glade_Resolve_Status, "Resolve for Glade - Resolve Status" },                                           // Inspiring Work - The woodcutters' song lifts people's spirits.
		{ ResolveEffectTypes.ResolveEffect_HearthEffect_Lizard, "ResolveEffect_HearthEffect_Lizard" },                                           // Sacred Pyre - Lizard firekeepers are very adept at ancient rites.
		{ ResolveEffectTypes.Royal_Guard_Training_Resolve_Effect, "Royal Guard Training - Resolve Effect" },                                     // Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them. 
		{ ResolveEffectTypes.SacrificeTotemPositive, "SacrificeTotemPositive" },                                                                 // Converted Totem of Denial - A Totem of Denial cleansed by the Holy Flame. Grants a Global Resolve bonus.
		{ ResolveEffectTypes.SE_Creeping_Shadows_Resolve_Penalty_Status, "SE Creeping Shadows - Resolve Penalty Status" },                       // Shadowy Figure - People fear the unknown during the storm.
		{ ResolveEffectTypes.SE_Devastating_Storms, "SE Devastating Storms" },                                                                   // Devastating Storms - The rampaging storm stifles the spirit of all living creatures.
		{ ResolveEffectTypes.SE_Hot_Springs_Resolve_Status, "SE Hot Springs (Resolve Status)" },                                                 // Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators.
		{ ResolveEffectTypes.SE_Mine_In_Storm_Resolve_Status, "SE Mine in Storm (Resolve Status)" },                                             // Horrors from Beneath - A strange chant is frightening the villagers.
		{ ResolveEffectTypes.SE_Resolve_For_Water_Resolve_Effect, "SE Resolve for Water - Resolve Effect" },                                     // Saturated Air - A pleasant, earthy scent is in the air.
		{ ResolveEffectTypes.SE_Storm_Clothes_Resolve_Status, "SE Storm Clothes - Resolve Status" },                                             // Cloudburst - The heavy rain is unbearable.
		{ ResolveEffectTypes.Skewer_Effect, "Skewer Effect" },                                                                                   // Skewers - This need is fulfilled at the Hearth. It requires "[food processed] skewers" skewers. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Skewers_Equal_Prohibition_Penalty, "Skewers Equal Prohibition Penalty" },                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Skewers_Unfair_Prohibition_Penalty, "Skewers Unfair Prohibition Penalty" },                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Spiced_Ale, "Spiced Ale" },                                                                                         // Spiced Ale - Additional +5 to Resolve when under the effect of "[needs] ale" leisure.
		{ ResolveEffectTypes.Spices_From_The_Capital, "Spices from the Capital" },                                                               // Spices from the Citadel - Spices from the Smoldering City - a favorite of Humans and Lizardfolk.
		{ ResolveEffectTypes.Stag_Blessing, "Stag Blessing" },                                                                                   // Stag's Blessing - The forest god has blessed your villagers. This day will be remembered for generations.
		{ ResolveEffectTypes.Storm_Homelessness_Penalty, "Storm Homelessness Penalty" },                                                         // Drenched - Villagers with this effect have a -5 penalty to their Resolve.
		{ ResolveEffectTypes.Storm_Penalty, "Storm Penalty" },                                                                                   // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
		{ ResolveEffectTypes.Stormbird_Egg_Resolve_Effect, "Stormbird Egg - Resolve Effect" },                                                   // Stormbird's Cry - Villagers report seeing a giant beast flying above the settlement during the storm.
		{ ResolveEffectTypes.Survivor_Bonding_Effect, "Survivor Bonding Effect" },                                                               // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
		{ ResolveEffectTypes.Survivor_Bonding_Effect_Altar, "Survivor Bonding Effect - Altar" },                                                 // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
		{ ResolveEffectTypes.T_Storm_Penalty, "T Storm Penalty" },                                                                               // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
		{ ResolveEffectTypes.Termites_Resolve_Normal, "Termites Resolve - normal" },                                                             // Stonetooth Swarm - Agitated termites can be a real nuisance.
		{ ResolveEffectTypes.TEST_Plague_Of_Snakes_Resolve, "TEST Plague of Snakes Resolve" },                                                   // Plague of Snakes - Villagers are horrified by the sight of venomous snakes on the roads.
		{ ResolveEffectTypes.Toxic_Fumes, "Toxic Fumes" },                                                                                       // Toxic Fumes - A strange white mist is produced when using Rainpunk technology...
		{ ResolveEffectTypes.Treatment_Effect, "Treatment Effect" },                                                                             // Treatment - It requires "[needs] tea" tea. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Treatment_Equal_Prohibition_Penalty, "Treatment Equal Prohibition Penalty" },                                       // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Treatment_Unfair_Prohibition_Penalty, "Treatment Unfair Prohibition Penalty" },                                     // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.TW_Global_Resolve, "[TW] Global Resolve" },                                                                         // Tale - Not as good as the Gleeman's Tale, but it did its job.
		{ ResolveEffectTypes.Unfair_Treatment_Penalty, "Unfair Treatment Penalty" },                                                             // Negligence - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
		{ ResolveEffectTypes.VaultResolvePenalty_Normal, "VaultResolvePenalty - normal" },                                                       // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
		{ ResolveEffectTypes.Vitality, "Vitality" },                                                                                             // Vitality - Well-nourished villagers enjoy their good health.
		{ ResolveEffectTypes.Wealth, "Wealth" },                                                                                                 // Wealth - The people are enjoying living in a prosperous settlement.
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Consequence_Resolve_Penalty, "Worse Storms for Hostility Consequence Resolve Penalty" }, // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Resolve_Penalty, "Worse Storms for Hostility Resolve Penalty" },                         // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.

	};
}
