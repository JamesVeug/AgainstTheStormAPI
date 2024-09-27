using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum ResolveEffectTypes
{
	Unknown = -1,
	None,
	Acidic_Environment,                                     // Acidic Environment - Working in a loud environment is really taxing.
	Acidic_Environment_Blightrot,                           // Acidic Environment - Working in a loud environment is really taxing.
	Agriculture_Penalty,                                    // Industrialized Agriculture - New farming methods are very effective, but cause a lot of pollution.
	Ancient_Artifact_1,                                     // Small Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	Ancient_Artifact_2,                                     // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	Ancient_Artifact_3,                                     // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	Ancient_Artifact_Weak,                                  // Ancient Artifact - A strange device left behind by the Great Civilization. When soaked in rainwater, it radiates warm light and brings encouragement to those around it.
	Any_Housing_Effect,                                     // Basic Housing - All species require at least basic shelter from the constant rainfall and gusting winds.
	BattlegroundPenalty_Hard,                               // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	BattlegroundPenalty_Impossible,                         // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	BattlegroundPenalty_Normal,                             // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	BattlegroundPenalty_Very_Hard,                          // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
	Beaver_Housing_Effect,                                  // Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
	Beaver_Resolve_Wine,                                    // Vineyard Town - The settlement specializes in wine production, and Beavers love that.
	Beavers_Faction_Support,                                // Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
	Biscuits_Effect,                                        // Biscuits - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] biscuits"> biscuits. Satisfying this need increases the chance of producing double yields.
	Biscuits_Equal_Prohibition_Penalty,                     // Rationing - No one likes being denied the fruits of their own labor.
	Biscuits_Unfair_Prohibition_Penalty,                    // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Blazing_Fire_Coal,                                      // Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	Blazing_Fire_Oil,                                       // Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	Blazing_Fire_Sea_Marrow,                                // Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
	Blazing_Fire_Wood,                                      // Blazing Fire (Wood) - Darkness flees before the might of the fire.
	Blightrot_Resolve,                                      // Blood Flower - The odor of Blood Flowers is making people feel sick.
	Blightrot_tier2,                                        // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	Blightrot_tier3,                                        // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
	Bloodthirst_Effect,                                     // Brawling - Requires <sprite name="[needs] training gear"> training gear. Satisfying this need increases the chance of producing double yields.
	Bloodthirst_Equal_Prohibition_Penalty,                  // Rationing - No one likes being denied the fruits of their own labor.
	Bloodthirst_Unfair_Prohibition_Penalty,                 // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Boots_Effect,                                           // Boots - This need is fulfilled at the Hearth. It requires <sprite name="[needs] boots"> boots. Satisfying this need grants a movement speed bonus.
	Boots_Equal_Prohibition_Penalty,                        // Rationing - No one likes being denied the fruits of their own labor.
	Boots_Unfair_Prohibition_Penalty,                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Cauldron_Resolve,                                       // Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
	City_Renown,                                            // City Renown - The city is becoming known among folk as a great place to live.
	Clothes_Effect,                                         // Coats - This need is fulfilled at the Hearth. It requires <sprite name="[needs] coats"> coats. Satisfying this need grants a Resolve bonus during the storm.
	Clothes_Equal_Prohibition_Penalty,                      // Rationing - No one likes being denied the fruits of their own labor.
	Clothes_Unfair_Prohibition_Penalty,                     // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Comfortable_Job,                                        // Comfortable - This worker gains +5 to their Resolve.
	Convicts_Hard,                                          // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	Convicts_Impossible,                                    // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	Convicts_Normal,                                        // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	Convicts_Very_Hard,                                     // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
	Dang_Glades_Reduces_Resolve_Effect,                     // Greater Threat - Villagers don't approve of discovering Dangerous (<sprite name="dangerous">) and Forbidden Glades (<sprite name="forbidden">) during the storm.
	DarkGatePenalty_Hard,                                   // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	DarkGatePenalty_Impossible,                             // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	DarkGatePenalty_Normal,                                 // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	DarkGatePenalty_Very_Hard,                              // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
	Education_Effect,                                       // Education - It requires <sprite name="[needs] scrolls"> scrolls. Satisfying this need increases the chance of producing double yields.
	Education_Equal_Prohibition_Penalty,                    // Rationing - No one likes being denied the fruits of their own labor.
	Education_Unfair_Prohibition_Penalty,                   // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Explorer_Tales,                                         // Tales of Discovery - Tales of distant lands and brave explorers.
	Explorers_Boredom,                                      // Explorers' Boredom - Who would have thought that great explorers are not so great at planting mushrooms?
	Exploring_Expedition_Resolve_Status,                    // Joy Of Discovery - There’s something truly magical about setting one's foot in a place that’s been hidden for millennia.
	Extreme_Noise,                                          // Extreme Noise - Working in a loud environment is really taxing.
	FallenViceroyCommemoration,                             // Fallen Viceroy Commemoration - Villagers with their need for species-specific housing met will get an additional +2 to Resolve.
	Favoring_Effect,                                        // Favoring - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	Fear_Of_The_Wilds_T1_Hard,                              // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T1_Impossible,                        // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T1_Normal,                            // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T1_Very_Hard,                         // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T2_Hard,                              // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T2_Impossible,                        // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T2_Normal,                            // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fear_Of_The_Wilds_T2_Very_Hard,                         // Fear of the Wilds - People are afraid of whatever destroyed the caravan.
	Fishmen_Resolve,                                        // Creeping Fishmen - Something is observing the villagers from the edge of the woods.
	Forced_Improvisation,                                   // Forced Improvisation - Working in a loud environment is really taxing.
	Forsaken_Crypt_Resolve_Effect_Hard,                     // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	Forsaken_Crypt_Resolve_Effect_Impossible,               // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	Forsaken_Crypt_Resolve_Effect_Normal,                   // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	Forsaken_Crypt_Resolve_Effect_Very_Hard,                // Robbed Dead - The ghost from the Forsaken Crypt is threatening the villagers.
	Fox_Housing_Effect,                                     // Fox Housing - Foxes prefer to live in wooden, well camouflaged houses. Fox Houses are required to fulfill this need.
	Foxes_Faction_Support,                                  // Fox Pack Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Fox tribe remembers your help.
	Frightening_Visions_Resolve_Effect,                     // Haunted - Villagers are haunted by terrifying visions.
	Frog_Houses_Bonus_Resolve,                              // Indoor Pool - This seemingly extravagant luxury is something that Frogs need to survive.
	Frog_Housing_Effect,                                    // Frog Housing - Frogs are at home in water. Frog Houses are required to fulfill this need.
	Frogs_Faction_Support,                                  // Frog Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Frogs remember your help.
	Frustrated,                                             // Frustrated - Villagers with this effect have a -2 penalty to their Resolve.
	Furniture,                                              // Furniture - Adds an additional +1 to Resolve for villagers with a home.
	Generous_Rations,                                       // Generous Rations - A surplus of food makes the villagers happy.
	Harmony_Altar,                                          // Harmony - When your villagers' needs are met, Harmony is fostered.
	Harmony_Altar_Chaos_Resolve,                            // Chaos - Harmony has been disturbed.
	Harpy_Faction_Support,                                  // Harpy Clan Support - The Flock was neutral during the Great Civil War, but you've proven your worth to them now.
	Harpy_Housing_Effect,                                   // Harpy Housing - Harpies prefer to live in well-lit, spacious homes. Harpy Houses are required to fulfill this need.
	Harpy_Resolve_Tea,                                      // Health Infusion - High tea production is boosting Harpies' morale.
	Harpy_Stormbird_Resolve,                                // Unique Ally - An exceptionally strong bond has developed between the Harpies and the Stormbird. They look very pleased to be in its presence.
	Homelessness_Penalty,                                   // Homelessness - People need houses.
	Houses_Bonus_Resolve,                                   // Stove - A small reminder of the Holy Flame.
	Hub_Hub_Resolve_T1,                                     // Encampment (Level 1) - Gathered around the blazing fire, folks keep each other's spirits high.
	Hub_Hub_Resolve_T2,                                     // Neighborhood (Level 2) - Even in such a harsh environment, there is still room for beauty.
	Hub_Hub_Resolve_T3,                                     // District (Level 3) - The town is booming with activity, and industry thrives.
	Human_Housing_Effect,                                   // Human Housing - Humans prefer to live in solid, safe homes. Human Houses are required to fulfill this need.
	Human_Resolve_Incense,                                  // Sweet Aroma - A sweet aroma is spreading around the settlement. It seems to be making the Humans feel content.
	Humans_Faction_Support,                                 // Human Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Humans remember your help.
	Hunger_Penalty,                                         // Hunger - People are starving. This effect stacks every time a villager doesn't eat during a break.
	Institution_Global_Resolve,                             // Gleeman's Tales - Every evening, a Gleeman tells stories about past glories, and times before the Great Civil War.
	Jerky_Effect,                                           // Jerky - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] jerky"> jerky. Satisfying this need increases the chance of producing double yields.
	Jerky_Equal_Prohibition_Penalty,                        // Rationing - No one likes being denied the fruits of their own labor.
	Jerky_Unfair_Prohibition_Penalty,                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Leasiure_Effect,                                        // Leisure - It requires <sprite name="[needs] ale"> ale. Satisfying this need increases the chance of producing double yields.
	Leasiure_Equal_Prohibition_Penalty,                     // Rationing - No one likes being denied the fruits of their own labor.
	Leasiure_Unfair_Prohibition_Penalty,                    // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Lizard_Housing_Effect,                                  // Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
	Lizard_Resolve_Training_Gear,                           // Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
	Lizards_Faction_Support,                                // Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
	Long_Live_The_Queen,                                    // Long Live the Queen - Villagers admire the Queen's greatness.
	Luxury_Effect,                                          // Luxury - It requires <sprite name="[needs] wine"> wine. Satisfying this need increases the chance of producing double yields.
	Luxury_Equal_Prohibition_Penalty,                       // Rationing - No one likes being denied the fruits of their own labor.
	Luxury_Unfair_Prohibition_Penalty,                      // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Map_Mod_Resolve,                                        // Forsaken Gods Temple - ModifierEffect_TempleResolve_Desc
	MoleResolvePenalty_Hard,                                // Giant Beast - Villagers are afraid of going into the woods.
	MoleResolvePenalty_Impossible,                          // Giant Beast - Villagers are afraid of going into the woods.
	MoleResolvePenalty_Normal,                              // Giant Beast - Villagers are afraid of going into the woods.
	MoleResolvePenalty_Very_Hard,                           // Giant Beast - Villagers are afraid of going into the woods.
	Motivated,                                              // Motivated - Villagers with this effect have a +1 boost to their Resolve.
	New_Year_Penalty,                                       // Hostility of the Forest - The forest is becoming more dangerous with each passing year... the people are scared.
	No_Fire_Penalty,                                        // No Hope - The fire has gone out, and darkness is spreading around the town.
	Paste_Effect,                                           // Paste - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] paste"> paste. Satisfying this need increases the chance of producing double yields.
	Paste_Equal_Prohibition_Penalty,                        // Rationing - No one likes being denied the fruits of their own labor.
	Paste_Unfair_Prohibition_Penalty,                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Picked_Goods_Effect,                                    // Pickled Goods - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] pickled goods"> pickled goods. Satisfying this need increases the chance of producing double yields.
	Pickled_Goods_Equal_Prohibition_Penalty,                // Rationing - No one likes being denied the fruits of their own labor.
	Pickled_Goods_Unfair_Prohibition_Penalty,               // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Pie_Effect,                                             // Pie - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] pie"> pie. Satisfying this need increases the chance of producing double yields.
	Pie_Equal_Prohibition_Penalty,                          // Rationing - No one likes being denied the fruits of their own labor.
	Pie_Unfair_Prohibition_Penalty,                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Porridge_Effect,                                        // Porridge - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] porridge"> porridge. Satisfying this need increases the chance of producing double yields.
	Porridge_Equal_Prohibition_Penalty,                     // Rationing - No one likes being denied the fruits of their own labor.
	Porridge_Unfair_Prohibition_Penalty,                    // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Rainpunk_Comfortable,                                   // Low Strain - Work is much easier with Rain Engines on
	Rebelious_Spirit,                                       // Rebellious Spirit - The people are feeling oddly rebellious.
	Religion_Effect,                                        // Religion - It requires <sprite name="[needs] incense"> incense. Satisfying this need increases the chance of producing double yields.
	Religion_Equal_Prohibition_Penalty,                     // Rationing - No one likes being denied the fruits of their own labor.
	Religion_Unfair_Prohibition_Penalty,                    // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Resolve_Effect_Institution_Resolve_For_Ruins,           // The Crown Chronicles - The people are enjoying living in a prosperous settlement.
	Resolve_Effect_Institution_Resolve_For_Sales,           // The Guild's Welfare - The people are enjoying living in a prosperous settlement.
	Resolve_Effect_Resolve_For_Chests,                      // Prosperous Archaeology - The people are enjoying living in a prosperous settlement.
	Resolve_Effect_Resolve_For_Sales,                       // Prosperous Settlement - The people are enjoying living in a prosperous settlement.
	Resolve_Effect_Resolve_For_Standing,                    // Friendly Relations - The people are enjoying living in a prosperous settlement.
	Resolve_For_Glade_Resolve_Status,                       // Inspiring Work - The woodcutters' song lifts people's spirits.
	ResolveEffect_HearthEffect_Lizard,                      // Sacred Pyre - Lizard firekeepers are very adept at ancient rites.
	Royal_Guard_Training_Resolve_Effect,                    // Royal Guard Training - The Crown sends two Royal Guards to your village. Instead of simply brawling, villagers will now train under them. 
	SacrificeTotemPositive,                                 // Converted Totem of Denial - A Totem of Denial cleansed by the Holy Flame. Grants a Global Resolve bonus.
	SE_Creeping_Shadows_Resolve_Penalty_Status,             // Shadowy Figure - People fear the unknown during the storm.
	SE_Devastating_Storms,                                  // Devastating Storms - The rampaging storm stifles the spirit of all living creatures.
	SE_Hot_Springs_Resolve_Status,                          // Hot Springs - The warmth around the hot geyser improves the mood of the Pump Operators.
	SE_Mine_In_Storm_Resolve_Status,                        // Horrors from Beneath - A strange chant is frightening the villagers.
	SE_Resolve_For_Water_Resolve_Effect,                    // Saturated Air - A pleasant, earthy scent is in the air.
	SE_Storm_Clothes_Resolve_Status,                        // Cloudburst - The heavy rain is unbearable.
	Skewer_Effect,                                          // Skewers - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] skewers"> skewers. Satisfying this need increases the chance of producing double yields.
	Skewers_Equal_Prohibition_Penalty,                      // Rationing - No one likes being denied the fruits of their own labor.
	Skewers_Unfair_Prohibition_Penalty,                     // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	Spiced_Ale,                                             // Spiced Ale - Additional +5 to Resolve when under the effect of <sprite name="[needs] ale"> leisure.
	Spices_From_The_Capital,                                // Spices from the Citadel - Spices from the Smoldering City - a favorite of Humans and Lizardfolk.
	Stag_Blessing,                                          // Stag's Blessing - The forest god has blessed your villagers. This day will be remembered for generations.
	Storm_Homelessness_Penalty,                             // Drenched - Villagers with this effect have a -5 penalty to their Resolve.
	Storm_Penalty,                                          // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	Stormbird_Egg_Resolve_Effect,                           // Stormbird's Cry - Villagers report seeing a giant beast flying above the settlement during the storm.
	Survivor_Bonding_Effect,                                // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	Survivor_Bonding_Effect_Altar,                          // Survivor Bonding - The people in your settlement have survived many hardships, bringing them closer together.
	T_Storm_Penalty,                                        // Looming Darkness - The rampaging storm stifles the spirit of all living creatures. An additional stack of this effect is added for each Hostility level.
	Termites_Resolve_Normal,                                // Stonetooth Swarm - Agitated termites can be a real nuisance.
	TEST_Plague_Of_Snakes_Resolve,                          // Plague of Snakes - Villagers are horrified by the sight of venomous snakes on the roads.
	Toxic_Fumes,                                            // Toxic Fumes - A strange white mist is produced when using Rainpunk technology...
	Treatment_Effect,                                       // Treatment - It requires <sprite name="[needs] tea"> tea. Satisfying this need increases the chance of producing double yields.
	Treatment_Equal_Prohibition_Penalty,                    // Rationing - No one likes being denied the fruits of their own labor.
	Treatment_Unfair_Prohibition_Penalty,                   // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
	TW_Global_Resolve,                                      // Tale - Not as good as the Gleeman's Tale, but it did its job.
	Unfair_Treatment_Penalty,                               // Negligence - Favoritism can be beneficial in the short term, but it's not a viable solution to the village's problems.
	VaultResolvePenalty_Normal,                             // Ominous Whispers - Strange voices can be heard coming from the sealed vault.
	Vitality,                                               // Vitality - Well-nourished villagers enjoy their good health.
	Wealth,                                                 // Wealth - The people are enjoying living in a prosperous settlement.
	Worse_Storms_For_Hostility_Consequence_Resolve_Penalty, // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.
	Worse_Storms_For_Hostility_Resolve_Penalty,             // Growing Darkness - With its giant wings, the Stormbird can bring even more stormy clouds over the settlement.


	MAX = 172
}

public static class ResolveEffectTypesExtensions
{
	private static ResolveEffectTypes[] s_All = null;
	public static ResolveEffectTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new ResolveEffectTypes[172];
			for (int i = 0; i < 172; i++)
			{
				s_All[i] = (ResolveEffectTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this ResolveEffectTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of ResolveEffectTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[ResolveEffectTypes.Acidic_Environment];
	}
	
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
	
	public static ResolveEffectModel ToResolveEffectModel(this string name)
	{
		ResolveEffectModel model = SO.Settings.resolveEffects.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find ResolveEffectModel for ResolveEffectTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static ResolveEffectModel ToResolveEffectModel(this ResolveEffectTypes types)
	{
		return types.ToName().ToResolveEffectModel();
	}
	
	public static ResolveEffectModel[] ToResolveEffectModelArray(this IEnumerable<ResolveEffectTypes> collection)
	{
		int count = collection.Count();
		ResolveEffectModel[] array = new ResolveEffectModel[count];
		int i = 0;
		foreach (ResolveEffectTypes element in collection)
		{
			array[i++] = element.ToResolveEffectModel();
		}

		return array;
	}
	
	public static ResolveEffectModel[] ToResolveEffectModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		ResolveEffectModel[] array = new ResolveEffectModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToResolveEffectModel();
		}

		return array;
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
		{ ResolveEffectTypes.Any_Housing_Effect, "Any Housing Effect" },                                                                         // Basic Housing - All species require at least basic shelter from the constant rainfall and gusting winds.
		{ ResolveEffectTypes.BattlegroundPenalty_Hard, "BattlegroundPenalty - hard" },                                                           // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Impossible, "BattlegroundPenalty - impossible" },                                               // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Normal, "BattlegroundPenalty - normal" },                                                       // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.BattlegroundPenalty_Very_Hard, "BattlegroundPenalty - very hard" },                                                 // Fallen Brethren - Seeing their fallen kin has taken its toll on the villagers.
		{ ResolveEffectTypes.Beaver_Housing_Effect, "Beaver Housing Effect" },                                                                   // Beaver Housing - Beavers prefer to live in cozy, wooden homes. Beaver Houses are required to fulfill this need.
		{ ResolveEffectTypes.Beaver_Resolve_Wine, "Beaver Resolve Wine" },                                                                       // Vineyard Town - The settlement specializes in wine production, and Beavers love that.
		{ ResolveEffectTypes.Beavers_Faction_Support, "Beavers Faction Support" },                                                               // Beavers Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Beaver clan remembers your help.
		{ ResolveEffectTypes.Biscuits_Effect, "Biscuits Effect" },                                                                               // Biscuits - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] biscuits"> biscuits. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Biscuits_Equal_Prohibition_Penalty, "Biscuits Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Biscuits_Unfair_Prohibition_Penalty, "Biscuits Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Blazing_Fire_Coal, "Blazing Fire (Coal)" },                                                                         // Blazing Fire (Coal) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Oil, "Blazing Fire (Oil)" },                                                                           // Blazing Fire (Oil) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Sea_Marrow, "Blazing Fire (Sea Marrow)" },                                                             // Blazing Fire (Sea Marrow) - A roaring magical fire purifies the forest, making the ancient hearth glow like a beacon in the darkness.
		{ ResolveEffectTypes.Blazing_Fire_Wood, "Blazing Fire (Wood)" },                                                                         // Blazing Fire (Wood) - Darkness flees before the might of the fire.
		{ ResolveEffectTypes.Blightrot_Resolve, "Blightrot Resolve" },                                                                           // Blood Flower - The odor of Blood Flowers is making people feel sick.
		{ ResolveEffectTypes.Blightrot_tier2, "Blightrot_tier2" },                                                                               // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Blightrot_tier3, "Blightrot_tier3" },                                                                               // ResolveEffect_Blightrot_Name - ResolveEffect_Blightrot_Desc
		{ ResolveEffectTypes.Bloodthirst_Effect, "Bloodthirst Effect" },                                                                         // Brawling - Requires <sprite name="[needs] training gear"> training gear. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Bloodthirst_Equal_Prohibition_Penalty, "Bloodthirst Equal Prohibition Penalty" },                                   // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Bloodthirst_Unfair_Prohibition_Penalty, "Bloodthirst Unfair Prohibition Penalty" },                                 // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Boots_Effect, "Boots Effect" },                                                                                     // Boots - This need is fulfilled at the Hearth. It requires <sprite name="[needs] boots"> boots. Satisfying this need grants a movement speed bonus.
		{ ResolveEffectTypes.Boots_Equal_Prohibition_Penalty, "Boots Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Boots_Unfair_Prohibition_Penalty, "Boots Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Cauldron_Resolve, "Cauldron Resolve" },                                                                             // Foul Taste - Food tastes terrible due to contaminants from a leaking cauldron.
		{ ResolveEffectTypes.City_Renown, "City Renown" },                                                                                       // City Renown - The city is becoming known among folk as a great place to live.
		{ ResolveEffectTypes.Clothes_Effect, "Clothes Effect" },                                                                                 // Coats - This need is fulfilled at the Hearth. It requires <sprite name="[needs] coats"> coats. Satisfying this need grants a Resolve bonus during the storm.
		{ ResolveEffectTypes.Clothes_Equal_Prohibition_Penalty, "Clothes Equal Prohibition Penalty" },                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Clothes_Unfair_Prohibition_Penalty, "Clothes Unfair Prohibition Penalty" },                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Comfortable_Job, "Comfortable Job" },                                                                               // Comfortable - This worker gains +5 to their Resolve.
		{ ResolveEffectTypes.Convicts_Hard, "Convicts - hard" },                                                                                 // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Impossible, "Convicts - impossible" },                                                                     // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Normal, "Convicts - normal" },                                                                             // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Convicts_Very_Hard, "Convicts - very hard" },                                                                       // Defenseless - Villagers have heard rumors of dangerous fugitives in the area. They are worried that desperate criminals might attack them.
		{ ResolveEffectTypes.Dang_Glades_Reduces_Resolve_Effect, "Dang Glades Reduces Resolve Effect" },                                         // Greater Threat - Villagers don't approve of discovering Dangerous (<sprite name="dangerous">) and Forbidden Glades (<sprite name="forbidden">) during the storm.
		{ ResolveEffectTypes.DarkGatePenalty_Hard, "DarkGatePenalty - hard" },                                                                   // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Impossible, "DarkGatePenalty - impossible" },                                                       // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Normal, "DarkGatePenalty - normal" },                                                               // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.DarkGatePenalty_Very_Hard, "DarkGatePenalty - very hard" },                                                         // Gate Presence - The mere presence of a Dark Gate makes the villagers fear for their lives.
		{ ResolveEffectTypes.Education_Effect, "Education Effect" },                                                                             // Education - It requires <sprite name="[needs] scrolls"> scrolls. Satisfying this need increases the chance of producing double yields.
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
		{ ResolveEffectTypes.Jerky_Effect, "Jerky Effect" },                                                                                     // Jerky - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] jerky"> jerky. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Jerky_Equal_Prohibition_Penalty, "Jerky Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Jerky_Unfair_Prohibition_Penalty, "Jerky Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Leasiure_Effect, "Leasiure Effect" },                                                                               // Leisure - It requires <sprite name="[needs] ale"> ale. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Leasiure_Equal_Prohibition_Penalty, "Leasiure Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Leasiure_Unfair_Prohibition_Penalty, "Leasiure Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Lizard_Housing_Effect, "Lizard Housing Effect" },                                                                   // Lizard Housing - Lizards prefer to live in warm, dry homes. Lizard Houses are required to fulfill this need.
		{ ResolveEffectTypes.Lizard_Resolve_Training_Gear, "Lizard Resolve Training Gear" },                                                     // Armed to the Teeth - A settlement specialized in training gear production makes Lizards feel safe.
		{ ResolveEffectTypes.Lizards_Faction_Support, "Lizards Faction Support" },                                                               // Lizard Clan Support - Ever since the Great Civil War, all species have been locked in a constant struggle to gain the Queen's favor. The Lizard elders remember your help.
		{ ResolveEffectTypes.Long_Live_The_Queen, "Long Live the Queen" },                                                                       // Long Live the Queen - Villagers admire the Queen's greatness.
		{ ResolveEffectTypes.Luxury_Effect, "Luxury Effect" },                                                                                   // Luxury - It requires <sprite name="[needs] wine"> wine. Satisfying this need increases the chance of producing double yields.
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
		{ ResolveEffectTypes.Paste_Effect, "Paste Effect" },                                                                                     // Paste - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] paste"> paste. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Paste_Equal_Prohibition_Penalty, "Paste Equal Prohibition Penalty" },                                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Paste_Unfair_Prohibition_Penalty, "Paste Unfair Prohibition Penalty" },                                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Picked_Goods_Effect, "Picked Goods Effect" },                                                                       // Pickled Goods - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] pickled goods"> pickled goods. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pickled_Goods_Equal_Prohibition_Penalty, "Pickled Goods Equal Prohibition Penalty" },                               // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pickled_Goods_Unfair_Prohibition_Penalty, "Pickled Goods Unfair Prohibition Penalty" },                             // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Pie_Effect, "Pie Effect" },                                                                                         // Pie - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] pie"> pie. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Pie_Equal_Prohibition_Penalty, "Pie Equal Prohibition Penalty" },                                                   // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Pie_Unfair_Prohibition_Penalty, "Pie Unfair Prohibition Penalty" },                                                 // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Porridge_Effect, "Porridge Effect" },                                                                               // Porridge - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] porridge"> porridge. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Porridge_Equal_Prohibition_Penalty, "Porridge Equal Prohibition Penalty" },                                         // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Porridge_Unfair_Prohibition_Penalty, "Porridge Unfair Prohibition Penalty" },                                       // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Rainpunk_Comfortable, "Rainpunk Comfortable" },                                                                     // Low Strain - Work is much easier with Rain Engines on
		{ ResolveEffectTypes.Rebelious_Spirit, "Rebelious Spirit" },                                                                             // Rebellious Spirit - The people are feeling oddly rebellious.
		{ ResolveEffectTypes.Religion_Effect, "Religion Effect" },                                                                               // Religion - It requires <sprite name="[needs] incense"> incense. Satisfying this need increases the chance of producing double yields.
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
		{ ResolveEffectTypes.Skewer_Effect, "Skewer Effect" },                                                                                   // Skewers - This need is fulfilled at the Hearth. It requires <sprite name="[food processed] skewers"> skewers. Satisfying this need increases the chance of producing double yields.
		{ ResolveEffectTypes.Skewers_Equal_Prohibition_Penalty, "Skewers Equal Prohibition Penalty" },                                           // Rationing - No one likes being denied the fruits of their own labor.
		{ ResolveEffectTypes.Skewers_Unfair_Prohibition_Penalty, "Skewers Unfair Prohibition Penalty" },                                         // Unfair Rationing - Villagers get very upset if they are denied things their neighbors can still consume.
		{ ResolveEffectTypes.Spiced_Ale, "Spiced Ale" },                                                                                         // Spiced Ale - Additional +5 to Resolve when under the effect of <sprite name="[needs] ale"> leisure.
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
		{ ResolveEffectTypes.Treatment_Effect, "Treatment Effect" },                                                                             // Treatment - It requires <sprite name="[needs] tea"> tea. Satisfying this need increases the chance of producing double yields.
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
