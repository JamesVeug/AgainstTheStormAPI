using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum ResolveEffectTypes
{
    Unknown = -1,
    None,
	Acidic_Environment,                                     // Acidic Environment
	Acidic_Environment_Blightrot,                           // Acidic Environment
	Agriculture_Penalty,                                    // Industrialized Agriculture
	Ancient_Artifact___Weak,                                // Ancient Artifact
	Ancient_Artifact_1,                                     // Small Ancient Artifact
	Ancient_Artifact_2,                                     // Ancient Artifact
	Ancient_Artifact_3,                                     // Ancient Artifact
	Any_Housing_Effect,                                     // Basic Housing
	API_ExampleMod_Modding_Tools_resolve_effect_model,      // Modding Tools
	BattlegroundPenalty___Hard,                             // Fallen Brethren
	BattlegroundPenalty___Impossible,                       // Fallen Brethren
	BattlegroundPenalty___Normal,                           // Fallen Brethren
	BattlegroundPenalty___Very_Hard,                        // Fallen Brethren
	Beaver_Housing_Effect,                                  // Beaver Housing
	Beaver_Resolve_Wine,                                    // Vineyard Town
	Beavers_Faction_Support,                                // Beavers Clan Support
	Biscuits_Effect,                                        // Biscuits
	Biscuits_Equal_Prohibition_Penalty,                     // Rationing
	Biscuits_Unfair_Prohibition_Penalty,                    // Unfair Rationing
	Blazing_Fire_Coal_,                                     // Blazing Fire (Coal)
	Blazing_Fire_Oil_,                                      // Blazing Fire (Oil)
	Blazing_Fire_Sea_Marrow_,                               // Blazing Fire (Sea Marrow)
	Blazing_Fire_Wood_,                                     // Blazing Fire (Wood)
	Blightrot_Resolve,                                      // Blood Flower
	Blightrot_tier2,                                        // ResolveEffect_Blightrot_Name
	Blightrot_tier3,                                        // ResolveEffect_Blightrot_Name
	Bloodthirst_Effect,                                     // Brawling
	Bloodthirst_Equal_Prohibition_Penalty,                  // Rationing
	Bloodthirst_Unfair_Prohibition_Penalty,                 // Unfair Rationing
	Cauldron_Resolve,                                       // Foul Taste
	City_Renown,                                            // City Renown
	Clothes_Effect,                                         // Clothing
	Clothes_Equal_Prohibition_Penalty,                      // Rationing
	Clothes_Unfair_Prohibition_Penalty,                     // Unfair Rationing
	Comfortable_Job,                                        // Comfortable
	Convicts___Hard,                                        // Defenseless
	Convicts___Impossible,                                  // Defenseless
	Convicts___Normal,                                      // Defenseless
	Convicts___Very_Hard,                                   // Defenseless
	Dang_Glades_Reduces_Resolve_Effect,                     // Greater Threat
	DarkGatePenalty___Hard,                                 // Gate Presence
	DarkGatePenalty___Impossible,                           // Gate Presence
	DarkGatePenalty___Normal,                               // Gate Presence
	DarkGatePenalty___Very_Hard,                            // Gate Presence
	Education_Effect,                                       // Education
	Education_Equal_Prohibition_Penalty,                    // Rationing
	Education_Unfair_Prohibition_Penalty,                   // Unfair Rationing
	Explorer_Tales,                                         // Tales of Discovery
	Explorers_Boredom,                                      // Explorers' Boredom
	Exploring_Expedition___Resolve_Status,                  // Joy Of Discovery
	Extreme_Noise,                                          // Extreme Noise
	FallenViceroyCommemoration,                             // Fallen Viceroy Commemoration
	Favoring_Effect,                                        // Favoring
	Fear_Of_The_Wilds_T1___Hard,                            // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Impossible,                      // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Normal,                          // Fear of the Wilds
	Fear_Of_The_Wilds_T1___Very_Hard,                       // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Hard,                            // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Impossible,                      // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Normal,                          // Fear of the Wilds
	Fear_Of_The_Wilds_T2___Very_Hard,                       // Fear of the Wilds
	Fishmen_Resolve,                                        // Creeping Fishmen
	Forced_Improvisation,                                   // Forced Improvisation
	Forsaken_Crypt_Resolve_Effect___Hard,                   // Robbed Dead
	Forsaken_Crypt_Resolve_Effect___Impossible,             // Robbed Dead
	Forsaken_Crypt_Resolve_Effect___Normal,                 // Robbed Dead
	Forsaken_Crypt_Resolve_Effect___Very_Hard,              // Robbed Dead
	Fox_Housing_Effect,                                     // Fox Housing
	Foxes_Faction_Support,                                  // Fox Pack Support
	Frightening_Visions_Resolve_Effect,                     // Haunted
	Frustrated,                                             // Frustrated
	Furniture,                                              // Furniture
	Generous_Rations,                                       // Generous Rations
	Harmony_Altar,                                          // Harmony
	Harmony_Altar_Chaos_Resolve,                            // Chaos
	Harpy_Faction_Support,                                  // Harpy Clan Support
	Harpy_Housing_Effect,                                   // Harpy Housing
	Harpy_Resolve_Tea,                                      // Health Infusion
	Harpy_Stormbird_Resolve,                                // Unique Ally
	Homelessness_Penalty,                                   // Homelessness
	Houses_Bonus_Resolve,                                   // Stove
	Hub_Hub_Resolve_T1,                                     // Encampment (Level 1)
	Hub_Hub_Resolve_T2,                                     // Neighborhood (Level 2)
	Hub_Hub_Resolve_T3,                                     // District (Level 3)
	Human_Housing_Effect,                                   // Human Housing
	Human_Resolve_Incense,                                  // Sweet Aroma
	Humans_Faction_Support,                                 // Human Clan Support
	Hunger_Penalty,                                         // Hunger
	Institution_Global_Resolve,                             // Gleeman's Tales
	Jerky_Effect,                                           // Jerky
	Jerky_Equal_Prohibition_Penalty,                        // Rationing
	Jerky_Unfair_Prohibition_Penalty,                       // Unfair Rationing
	Leasiure_Effect,                                        // Leisure
	Leasiure_Equal_Prohibition_Penalty,                     // Rationing
	Leasiure_Unfair_Prohibition_Penalty,                    // Unfair Rationing
	Lizard_Housing_Effect,                                  // Lizard Housing
	Lizard_Resolve_Training_Gear,                           // Armed to the Teeth
	Lizards_Faction_Support,                                // Lizard Clan Support
	Long_Live_The_Queen,                                    // Long Live the Queen
	Luxury_Effect,                                          // Luxury
	Luxury_Equal_Prohibition_Penalty,                       // Rationing
	Luxury_Unfair_Prohibition_Penalty,                      // Unfair Rationing
	Map_Mod_Resolve,                                        // Forsaken Gods Temple
	MoleResolvePenalty___Hard,                              // Giant Beast
	MoleResolvePenalty___Impossible,                        // Giant Beast
	MoleResolvePenalty___Normal,                            // Giant Beast
	MoleResolvePenalty___Very_Hard,                         // Giant Beast
	Motivated,                                              // Motivated
	New_Year_Penalty,                                       // Hostility of the Forest
	No_Fire_Penalty,                                        // No Hope
	Picked_Goods_Effect,                                    // Pickled Goods
	Pickled_Goods_Equal_Prohibition_Penalty,                // Rationing
	Pickled_Goods_Unfair_Prohibition_Penalty,               // Unfair Rationing
	Pie_Effect,                                             // Pie
	Pie_Equal_Prohibition_Penalty,                          // Rationing
	Pie_Unfair_Prohibition_Penalty,                         // Unfair Rationing
	Porridge_Effect,                                        // Porridge
	Porridge_Equal_Prohibition_Penalty,                     // Rationing
	Porridge_Unfair_Prohibition_Penalty,                    // Unfair Rationing
	Rainpunk_Comfortable,                                   // Low Strain
	Rebelious_Spirit,                                       // Rebellious Spirit
	Religion_Effect,                                        // Religion
	Religion_Equal_Prohibition_Penalty,                     // Rationing
	Religion_Unfair_Prohibition_Penalty,                    // Unfair Rationing
	Resolve_Effect___Institution_Resolve_For_Ruins,         // The Crown Chronicles
	Resolve_Effect___Institution_Resolve_For_Sales,         // The Guild's Welfare
	Resolve_Effect___Resolve_For_Chests,                    // Prosperous Archaeology
	Resolve_Effect___Resolve_For_Sales,                     // Prosperous Settlement
	Resolve_Effect___Resolve_For_Standing,                  // Friendly Relations
	Resolve_For_Glade___Resolve_Status,                     // Inspiring Work
	ResolveEffect_HearthEffect_Lizard,                      // Sacred Pyre
	Royal_Guard_Training___Resolve_Effect,                  // Royal Guard Training
	SacrificeTotemPositive,                                 // Converted Totem of Denial
	SE_Creeping_Shadows___Resolve_Penalty_Status,           // Shadowy Figure
	SE_Devastating_Storms,                                  // Devastating Storms
	SE_Hot_Springs_Resolve_Status_,                         // Hot Springs
	SE_Mine_In_Storm_Resolve_Status_,                       // Horrors from Beneath
	SE_Resolve_For_Water___Resolve_Effect,                  // Saturated Air
	SE_Storm_Clothes___Resolve_Status,                      // Cloudburst
	Skewer_Effect,                                          // Skewers
	Skewers_Equal_Prohibition_Penalty,                      // Rationing
	Skewers_Unfair_Prohibition_Penalty,                     // Unfair Rationing
	Spiced_Ale,                                             // Spiced Ale
	Spices_From_The_Capital,                                // Spices from the Citadel
	Stag_Blessing,                                          // Stag's Blessing
	Storm_Homelessness_Penalty,                             // Soaked Clothes
	Storm_Penalty,                                          // Looming Darkness
	Stormbird_Egg___Resolve_Effect,                         // Stormbird's Cry
	Survivor_Bonding_Effect,                                // Survivor Bonding
	Survivor_Bonding_Effect___Altar,                        // Survivor Bonding
	T_Storm_Penalty,                                        // Looming Darkness
	Termites_Resolve___Normal,                              // Stonetooth Swarm
	TEST_Plague_Of_Snakes_Resolve,                          // Plague of Snakes
	Toxic_Fumes,                                            // Toxic Fumes
	Treatment_Effect,                                       // Treatment
	Treatment_Equal_Prohibition_Penalty,                    // Rationing
	Treatment_Unfair_Prohibition_Penalty,                   // Unfair Rationing
	TW_Global_Resolve,                                      // Tale
	Unfair_Treatment_Penalty,                               // Negligence
	VaultResolvePenalty___Normal,                           // Ominous Whispers
	Vitality,                                               // Vitality
	Wealth,                                                 // Wealth
	Worse_Storms_For_Hostility_Consequence_Resolve_Penalty, // Growing Darkness
	Worse_Storms_For_Hostility_Resolve_Penalty,             // Growing Darkness

    MAX = 164
}

public static class ResolveEffectTypesExtensions
{
	public static string ToName(this ResolveEffectTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of ResolveEffectTypes: " + type);
		return TypeToInternalName[ResolveEffectTypes.Acidic_Environment];
	}
	
	public static ResolveEffectModel ToResolveEffectModel(this string name)
    {
        ResolveEffectModel model = SO.Settings.resolveEffects.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find ResolveEffectModel for ResolveEffectTypes with name: " + name);
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
            string elementName = element.ToName();
            array[i++] = SO.Settings.resolveEffects.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<ResolveEffectTypes, string> TypeToInternalName = new()
	{
		{ ResolveEffectTypes.Acidic_Environment, "Acidic Environment" },                                                                         // Acidic Environment
		{ ResolveEffectTypes.Acidic_Environment_Blightrot, "Acidic Environment Blightrot" },                                                     // Acidic Environment
		{ ResolveEffectTypes.Agriculture_Penalty, "Agriculture Penalty" },                                                                       // Industrialized Agriculture
		{ ResolveEffectTypes.Ancient_Artifact___Weak, "Ancient Artifact - weak" },                                                               // Ancient Artifact
		{ ResolveEffectTypes.Ancient_Artifact_1, "Ancient Artifact 1" },                                                                         // Small Ancient Artifact
		{ ResolveEffectTypes.Ancient_Artifact_2, "Ancient Artifact 2" },                                                                         // Ancient Artifact
		{ ResolveEffectTypes.Ancient_Artifact_3, "Ancient Artifact 3" },                                                                         // Ancient Artifact
		{ ResolveEffectTypes.Any_Housing_Effect, "Any Housing Effect" },                                                                         // Basic Housing
		{ ResolveEffectTypes.API_ExampleMod_Modding_Tools_resolve_effect_model, "API_ExampleMod_Modding Tools_resolve_effect_model" },           // Modding Tools
		{ ResolveEffectTypes.BattlegroundPenalty___Hard, "BattlegroundPenalty - hard" },                                                         // Fallen Brethren
		{ ResolveEffectTypes.BattlegroundPenalty___Impossible, "BattlegroundPenalty - impossible" },                                             // Fallen Brethren
		{ ResolveEffectTypes.BattlegroundPenalty___Normal, "BattlegroundPenalty - normal" },                                                     // Fallen Brethren
		{ ResolveEffectTypes.BattlegroundPenalty___Very_Hard, "BattlegroundPenalty - very hard" },                                               // Fallen Brethren
		{ ResolveEffectTypes.Beaver_Housing_Effect, "Beaver Housing Effect" },                                                                   // Beaver Housing
		{ ResolveEffectTypes.Beaver_Resolve_Wine, "Beaver Resolve Wine" },                                                                       // Vineyard Town
		{ ResolveEffectTypes.Beavers_Faction_Support, "Beavers Faction Support" },                                                               // Beavers Clan Support
		{ ResolveEffectTypes.Biscuits_Effect, "Biscuits Effect" },                                                                               // Biscuits
		{ ResolveEffectTypes.Biscuits_Equal_Prohibition_Penalty, "Biscuits Equal Prohibition Penalty" },                                         // Rationing
		{ ResolveEffectTypes.Biscuits_Unfair_Prohibition_Penalty, "Biscuits Unfair Prohibition Penalty" },                                       // Unfair Rationing
		{ ResolveEffectTypes.Blazing_Fire_Coal_, "Blazing Fire (Coal)" },                                                                        // Blazing Fire (Coal)
		{ ResolveEffectTypes.Blazing_Fire_Oil_, "Blazing Fire (Oil)" },                                                                          // Blazing Fire (Oil)
		{ ResolveEffectTypes.Blazing_Fire_Sea_Marrow_, "Blazing Fire (Sea Marrow)" },                                                            // Blazing Fire (Sea Marrow)
		{ ResolveEffectTypes.Blazing_Fire_Wood_, "Blazing Fire (Wood)" },                                                                        // Blazing Fire (Wood)
		{ ResolveEffectTypes.Blightrot_Resolve, "Blightrot Resolve" },                                                                           // Blood Flower
		{ ResolveEffectTypes.Blightrot_tier2, "Blightrot_tier2" },                                                                               // ResolveEffect_Blightrot_Name
		{ ResolveEffectTypes.Blightrot_tier3, "Blightrot_tier3" },                                                                               // ResolveEffect_Blightrot_Name
		{ ResolveEffectTypes.Bloodthirst_Effect, "Bloodthirst Effect" },                                                                         // Brawling
		{ ResolveEffectTypes.Bloodthirst_Equal_Prohibition_Penalty, "Bloodthirst Equal Prohibition Penalty" },                                   // Rationing
		{ ResolveEffectTypes.Bloodthirst_Unfair_Prohibition_Penalty, "Bloodthirst Unfair Prohibition Penalty" },                                 // Unfair Rationing
		{ ResolveEffectTypes.Cauldron_Resolve, "Cauldron Resolve" },                                                                             // Foul Taste
		{ ResolveEffectTypes.City_Renown, "City Renown" },                                                                                       // City Renown
		{ ResolveEffectTypes.Clothes_Effect, "Clothes Effect" },                                                                                 // Clothing
		{ ResolveEffectTypes.Clothes_Equal_Prohibition_Penalty, "Clothes Equal Prohibition Penalty" },                                           // Rationing
		{ ResolveEffectTypes.Clothes_Unfair_Prohibition_Penalty, "Clothes Unfair Prohibition Penalty" },                                         // Unfair Rationing
		{ ResolveEffectTypes.Comfortable_Job, "Comfortable Job" },                                                                               // Comfortable
		{ ResolveEffectTypes.Convicts___Hard, "Convicts - hard" },                                                                               // Defenseless
		{ ResolveEffectTypes.Convicts___Impossible, "Convicts - impossible" },                                                                   // Defenseless
		{ ResolveEffectTypes.Convicts___Normal, "Convicts - normal" },                                                                           // Defenseless
		{ ResolveEffectTypes.Convicts___Very_Hard, "Convicts - very hard" },                                                                     // Defenseless
		{ ResolveEffectTypes.Dang_Glades_Reduces_Resolve_Effect, "Dang Glades Reduces Resolve Effect" },                                         // Greater Threat
		{ ResolveEffectTypes.DarkGatePenalty___Hard, "DarkGatePenalty - hard" },                                                                 // Gate Presence
		{ ResolveEffectTypes.DarkGatePenalty___Impossible, "DarkGatePenalty - impossible" },                                                     // Gate Presence
		{ ResolveEffectTypes.DarkGatePenalty___Normal, "DarkGatePenalty - normal" },                                                             // Gate Presence
		{ ResolveEffectTypes.DarkGatePenalty___Very_Hard, "DarkGatePenalty - very hard" },                                                       // Gate Presence
		{ ResolveEffectTypes.Education_Effect, "Education Effect" },                                                                             // Education
		{ ResolveEffectTypes.Education_Equal_Prohibition_Penalty, "Education Equal Prohibition Penalty" },                                       // Rationing
		{ ResolveEffectTypes.Education_Unfair_Prohibition_Penalty, "Education Unfair Prohibition Penalty" },                                     // Unfair Rationing
		{ ResolveEffectTypes.Explorer_Tales, "Explorer Tales" },                                                                                 // Tales of Discovery
		{ ResolveEffectTypes.Explorers_Boredom, "Explorers Boredom" },                                                                           // Explorers' Boredom
		{ ResolveEffectTypes.Exploring_Expedition___Resolve_Status, "Exploring Expedition - Resolve Status" },                                   // Joy Of Discovery
		{ ResolveEffectTypes.Extreme_Noise, "Extreme Noise" },                                                                                   // Extreme Noise
		{ ResolveEffectTypes.FallenViceroyCommemoration, "FallenViceroyCommemoration" },                                                         // Fallen Viceroy Commemoration
		{ ResolveEffectTypes.Favoring_Effect, "Favoring Effect" },                                                                               // Favoring
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1___Hard, "Fear of the Wilds T1 - hard" },                                                       // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1___Impossible, "Fear of the Wilds T1 - impossible" },                                           // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1___Normal, "Fear of the Wilds T1 - normal" },                                                   // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T1___Very_Hard, "Fear of the Wilds T1 - very hard" },                                             // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2___Hard, "Fear of the Wilds T2 - hard" },                                                       // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2___Impossible, "Fear of the Wilds T2 - impossible" },                                           // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2___Normal, "Fear of the Wilds T2 - normal" },                                                   // Fear of the Wilds
		{ ResolveEffectTypes.Fear_Of_The_Wilds_T2___Very_Hard, "Fear of the Wilds T2 - very hard" },                                             // Fear of the Wilds
		{ ResolveEffectTypes.Fishmen_Resolve, "Fishmen Resolve" },                                                                               // Creeping Fishmen
		{ ResolveEffectTypes.Forced_Improvisation, "Forced improvisation" },                                                                     // Forced Improvisation
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect___Hard, "Forsaken Crypt Resolve Effect - hard" },                                     // Robbed Dead
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect___Impossible, "Forsaken Crypt Resolve Effect - impossible" },                         // Robbed Dead
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect___Normal, "Forsaken Crypt Resolve Effect - normal" },                                 // Robbed Dead
		{ ResolveEffectTypes.Forsaken_Crypt_Resolve_Effect___Very_Hard, "Forsaken Crypt Resolve Effect - very hard" },                           // Robbed Dead
		{ ResolveEffectTypes.Fox_Housing_Effect, "Fox Housing Effect" },                                                                         // Fox Housing
		{ ResolveEffectTypes.Foxes_Faction_Support, "Foxes Faction Support" },                                                                   // Fox Pack Support
		{ ResolveEffectTypes.Frightening_Visions_Resolve_Effect, "Frightening Visions Resolve Effect" },                                         // Haunted
		{ ResolveEffectTypes.Frustrated, "Frustrated" },                                                                                         // Frustrated
		{ ResolveEffectTypes.Furniture, "Furniture" },                                                                                           // Furniture
		{ ResolveEffectTypes.Generous_Rations, "Generous Rations" },                                                                             // Generous Rations
		{ ResolveEffectTypes.Harmony_Altar, "Harmony Altar" },                                                                                   // Harmony
		{ ResolveEffectTypes.Harmony_Altar_Chaos_Resolve, "Harmony Altar Chaos Resolve" },                                                       // Chaos
		{ ResolveEffectTypes.Harpy_Faction_Support, "Harpy Faction Support" },                                                                   // Harpy Clan Support
		{ ResolveEffectTypes.Harpy_Housing_Effect, "Harpy Housing Effect" },                                                                     // Harpy Housing
		{ ResolveEffectTypes.Harpy_Resolve_Tea, "Harpy Resolve Tea" },                                                                           // Health Infusion
		{ ResolveEffectTypes.Harpy_Stormbird_Resolve, "Harpy Stormbird Resolve" },                                                               // Unique Ally
		{ ResolveEffectTypes.Homelessness_Penalty, "Homelessness Penalty" },                                                                     // Homelessness
		{ ResolveEffectTypes.Houses_Bonus_Resolve, "Houses Bonus Resolve" },                                                                     // Stove
		{ ResolveEffectTypes.Hub_Hub_Resolve_T1, "[Hub] Hub Resolve T1" },                                                                       // Encampment (Level 1)
		{ ResolveEffectTypes.Hub_Hub_Resolve_T2, "[Hub] Hub Resolve T2" },                                                                       // Neighborhood (Level 2)
		{ ResolveEffectTypes.Hub_Hub_Resolve_T3, "[Hub] Hub Resolve T3" },                                                                       // District (Level 3)
		{ ResolveEffectTypes.Human_Housing_Effect, "Human Housing Effect" },                                                                     // Human Housing
		{ ResolveEffectTypes.Human_Resolve_Incense, "Human Resolve Incense" },                                                                   // Sweet Aroma
		{ ResolveEffectTypes.Humans_Faction_Support, "Humans Faction Support" },                                                                 // Human Clan Support
		{ ResolveEffectTypes.Hunger_Penalty, "Hunger Penalty" },                                                                                 // Hunger
		{ ResolveEffectTypes.Institution_Global_Resolve, "Institution Global Resolve" },                                                         // Gleeman's Tales
		{ ResolveEffectTypes.Jerky_Effect, "Jerky Effect" },                                                                                     // Jerky
		{ ResolveEffectTypes.Jerky_Equal_Prohibition_Penalty, "Jerky Equal Prohibition Penalty" },                                               // Rationing
		{ ResolveEffectTypes.Jerky_Unfair_Prohibition_Penalty, "Jerky Unfair Prohibition Penalty" },                                             // Unfair Rationing
		{ ResolveEffectTypes.Leasiure_Effect, "Leasiure Effect" },                                                                               // Leisure
		{ ResolveEffectTypes.Leasiure_Equal_Prohibition_Penalty, "Leasiure Equal Prohibition Penalty" },                                         // Rationing
		{ ResolveEffectTypes.Leasiure_Unfair_Prohibition_Penalty, "Leasiure Unfair Prohibition Penalty" },                                       // Unfair Rationing
		{ ResolveEffectTypes.Lizard_Housing_Effect, "Lizard Housing Effect" },                                                                   // Lizard Housing
		{ ResolveEffectTypes.Lizard_Resolve_Training_Gear, "Lizard Resolve Training Gear" },                                                     // Armed to the Teeth
		{ ResolveEffectTypes.Lizards_Faction_Support, "Lizards Faction Support" },                                                               // Lizard Clan Support
		{ ResolveEffectTypes.Long_Live_The_Queen, "Long Live the Queen" },                                                                       // Long Live the Queen
		{ ResolveEffectTypes.Luxury_Effect, "Luxury Effect" },                                                                                   // Luxury
		{ ResolveEffectTypes.Luxury_Equal_Prohibition_Penalty, "Luxury Equal Prohibition Penalty" },                                             // Rationing
		{ ResolveEffectTypes.Luxury_Unfair_Prohibition_Penalty, "Luxury Unfair Prohibition Penalty" },                                           // Unfair Rationing
		{ ResolveEffectTypes.Map_Mod_Resolve, "[Map Mod] Resolve" },                                                                             // Forsaken Gods Temple
		{ ResolveEffectTypes.MoleResolvePenalty___Hard, "MoleResolvePenalty - hard" },                                                           // Giant Beast
		{ ResolveEffectTypes.MoleResolvePenalty___Impossible, "MoleResolvePenalty - impossible" },                                               // Giant Beast
		{ ResolveEffectTypes.MoleResolvePenalty___Normal, "MoleResolvePenalty - normal" },                                                       // Giant Beast
		{ ResolveEffectTypes.MoleResolvePenalty___Very_Hard, "MoleResolvePenalty - very hard" },                                                 // Giant Beast
		{ ResolveEffectTypes.Motivated, "Motivated" },                                                                                           // Motivated
		{ ResolveEffectTypes.New_Year_Penalty, "New Year Penalty" },                                                                             // Hostility of the Forest
		{ ResolveEffectTypes.No_Fire_Penalty, "No Fire Penalty" },                                                                               // No Hope
		{ ResolveEffectTypes.Picked_Goods_Effect, "Picked Goods Effect" },                                                                       // Pickled Goods
		{ ResolveEffectTypes.Pickled_Goods_Equal_Prohibition_Penalty, "Pickled Goods Equal Prohibition Penalty" },                               // Rationing
		{ ResolveEffectTypes.Pickled_Goods_Unfair_Prohibition_Penalty, "Pickled Goods Unfair Prohibition Penalty" },                             // Unfair Rationing
		{ ResolveEffectTypes.Pie_Effect, "Pie Effect" },                                                                                         // Pie
		{ ResolveEffectTypes.Pie_Equal_Prohibition_Penalty, "Pie Equal Prohibition Penalty" },                                                   // Rationing
		{ ResolveEffectTypes.Pie_Unfair_Prohibition_Penalty, "Pie Unfair Prohibition Penalty" },                                                 // Unfair Rationing
		{ ResolveEffectTypes.Porridge_Effect, "Porridge Effect" },                                                                               // Porridge
		{ ResolveEffectTypes.Porridge_Equal_Prohibition_Penalty, "Porridge Equal Prohibition Penalty" },                                         // Rationing
		{ ResolveEffectTypes.Porridge_Unfair_Prohibition_Penalty, "Porridge Unfair Prohibition Penalty" },                                       // Unfair Rationing
		{ ResolveEffectTypes.Rainpunk_Comfortable, "Rainpunk Comfortable" },                                                                     // Low Strain
		{ ResolveEffectTypes.Rebelious_Spirit, "Rebelious Spirit" },                                                                             // Rebellious Spirit
		{ ResolveEffectTypes.Religion_Effect, "Religion Effect" },                                                                               // Religion
		{ ResolveEffectTypes.Religion_Equal_Prohibition_Penalty, "Religion Equal Prohibition Penalty" },                                         // Rationing
		{ ResolveEffectTypes.Religion_Unfair_Prohibition_Penalty, "Religion Unfair Prohibition Penalty" },                                       // Unfair Rationing
		{ ResolveEffectTypes.Resolve_Effect___Institution_Resolve_For_Ruins, "Resolve Effect - Institution Resolve for Ruins" },                 // The Crown Chronicles
		{ ResolveEffectTypes.Resolve_Effect___Institution_Resolve_For_Sales, "Resolve Effect - Institution Resolve for Sales" },                 // The Guild's Welfare
		{ ResolveEffectTypes.Resolve_Effect___Resolve_For_Chests, "Resolve Effect - Resolve for chests" },                                       // Prosperous Archaeology
		{ ResolveEffectTypes.Resolve_Effect___Resolve_For_Sales, "Resolve Effect - Resolve for sales" },                                         // Prosperous Settlement
		{ ResolveEffectTypes.Resolve_Effect___Resolve_For_Standing, "Resolve Effect - Resolve for Standing" },                                   // Friendly Relations
		{ ResolveEffectTypes.Resolve_For_Glade___Resolve_Status, "Resolve for Glade - Resolve Status" },                                         // Inspiring Work
		{ ResolveEffectTypes.ResolveEffect_HearthEffect_Lizard, "ResolveEffect_HearthEffect_Lizard" },                                           // Sacred Pyre
		{ ResolveEffectTypes.Royal_Guard_Training___Resolve_Effect, "Royal Guard Training - Resolve Effect" },                                   // Royal Guard Training
		{ ResolveEffectTypes.SacrificeTotemPositive, "SacrificeTotemPositive" },                                                                 // Converted Totem of Denial
		{ ResolveEffectTypes.SE_Creeping_Shadows___Resolve_Penalty_Status, "SE Creeping Shadows - Resolve Penalty Status" },                     // Shadowy Figure
		{ ResolveEffectTypes.SE_Devastating_Storms, "SE Devastating Storms" },                                                                   // Devastating Storms
		{ ResolveEffectTypes.SE_Hot_Springs_Resolve_Status_, "SE Hot Springs (Resolve Status)" },                                                // Hot Springs
		{ ResolveEffectTypes.SE_Mine_In_Storm_Resolve_Status_, "SE Mine in Storm (Resolve Status)" },                                            // Horrors from Beneath
		{ ResolveEffectTypes.SE_Resolve_For_Water___Resolve_Effect, "SE Resolve for Water - Resolve Effect" },                                   // Saturated Air
		{ ResolveEffectTypes.SE_Storm_Clothes___Resolve_Status, "SE Storm Clothes - Resolve Status" },                                           // Cloudburst
		{ ResolveEffectTypes.Skewer_Effect, "Skewer Effect" },                                                                                   // Skewers
		{ ResolveEffectTypes.Skewers_Equal_Prohibition_Penalty, "Skewers Equal Prohibition Penalty" },                                           // Rationing
		{ ResolveEffectTypes.Skewers_Unfair_Prohibition_Penalty, "Skewers Unfair Prohibition Penalty" },                                         // Unfair Rationing
		{ ResolveEffectTypes.Spiced_Ale, "Spiced Ale" },                                                                                         // Spiced Ale
		{ ResolveEffectTypes.Spices_From_The_Capital, "Spices from the Capital" },                                                               // Spices from the Citadel
		{ ResolveEffectTypes.Stag_Blessing, "Stag Blessing" },                                                                                   // Stag's Blessing
		{ ResolveEffectTypes.Storm_Homelessness_Penalty, "Storm Homelessness Penalty" },                                                         // Soaked Clothes
		{ ResolveEffectTypes.Storm_Penalty, "Storm Penalty" },                                                                                   // Looming Darkness
		{ ResolveEffectTypes.Stormbird_Egg___Resolve_Effect, "Stormbird Egg - Resolve Effect" },                                                 // Stormbird's Cry
		{ ResolveEffectTypes.Survivor_Bonding_Effect, "Survivor Bonding Effect" },                                                               // Survivor Bonding
		{ ResolveEffectTypes.Survivor_Bonding_Effect___Altar, "Survivor Bonding Effect - Altar" },                                               // Survivor Bonding
		{ ResolveEffectTypes.T_Storm_Penalty, "T Storm Penalty" },                                                                               // Looming Darkness
		{ ResolveEffectTypes.Termites_Resolve___Normal, "Termites Resolve - normal" },                                                           // Stonetooth Swarm
		{ ResolveEffectTypes.TEST_Plague_Of_Snakes_Resolve, "TEST Plague of Snakes Resolve" },                                                   // Plague of Snakes
		{ ResolveEffectTypes.Toxic_Fumes, "Toxic Fumes" },                                                                                       // Toxic Fumes
		{ ResolveEffectTypes.Treatment_Effect, "Treatment Effect" },                                                                             // Treatment
		{ ResolveEffectTypes.Treatment_Equal_Prohibition_Penalty, "Treatment Equal Prohibition Penalty" },                                       // Rationing
		{ ResolveEffectTypes.Treatment_Unfair_Prohibition_Penalty, "Treatment Unfair Prohibition Penalty" },                                     // Unfair Rationing
		{ ResolveEffectTypes.TW_Global_Resolve, "[TW] Global Resolve" },                                                                         // Tale
		{ ResolveEffectTypes.Unfair_Treatment_Penalty, "Unfair Treatment Penalty" },                                                             // Negligence
		{ ResolveEffectTypes.VaultResolvePenalty___Normal, "VaultResolvePenalty - normal" },                                                     // Ominous Whispers
		{ ResolveEffectTypes.Vitality, "Vitality" },                                                                                             // Vitality
		{ ResolveEffectTypes.Wealth, "Wealth" },                                                                                                 // Wealth
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Consequence_Resolve_Penalty, "Worse Storms for Hostility Consequence Resolve Penalty" }, // Growing Darkness
		{ ResolveEffectTypes.Worse_Storms_For_Hostility_Resolve_Penalty, "Worse Storms for Hostility Resolve Penalty" },                         // Growing Darkness
	};
}
