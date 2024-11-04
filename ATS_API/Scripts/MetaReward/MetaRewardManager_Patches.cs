using System.Linq;
using Eremite.Model.Meta;
using Eremite.Model.State;
using Eremite.Services.Meta;
using HarmonyLib;

namespace ATS_API.MetaRewards;

[HarmonyPatch]
public partial class MetaRewardManager
{
    [HarmonyPatch(typeof(EmbarkBonusesGenerator), nameof(EmbarkBonusesGenerator.Generate))]
    [HarmonyPostfix]
    public static void AddCustomEmbarkBonuses(EmbarkBonusesGenerator __instance, ref EmbarkBonusesState __result)
    {
        __result.goodsOptions.AddRange(s_newMetaRewards
            .Where(a => a.Model is EmbarkGoodMetaRewardModel)
            .Select(a => __instance.CreatePickState(a.Model as EmbarkGoodMetaRewardModel)));
        
        __result.effectsOptions.AddRange(s_newMetaRewards
            .Where(a => a.Model is EmbarkEffectMetaRewardModel)
            .Select(a => __instance.CreatePickState(a.Model as EmbarkEffectMetaRewardModel)));
        
        // NOTE: Literally does nothing in the game code
        // NOTE: To add a reward to unlock a blueprint use EmbarkEffectMetaRewardModel with an effect of BuildingEffectModel
        // __result.buildingsOptions.AddRange(BuildingManager.NewBuildings
        //     .Where(a=>a.BuildingModel.canBePicked)
        //     .Select(a => __instance.CreateBuildingPickState(a.BuildingModel)));
    }
    
    [HarmonyPatch(typeof(RaceMetaRewardModel), nameof(MetaRewardModel.HasAccessTo))]
    [HarmonyPatch(typeof(EssentialBuildingMetaRewardModel), nameof(MetaRewardModel.HasAccessTo))]
    [HarmonyPatch(typeof(RaceMetaRewardModel), nameof(MetaRewardModel.HasAccessTo))]
    [HarmonyPatch(typeof(MetaRewardModel), nameof(MetaRewardModel.HasAccessTo))]
    [HarmonyPrefix]
    public static bool MetaRewardModel_Access(MetaRewardModel __instance, ref bool __result)
    {
        if (s_disabledMetaRewards.Contains(__instance))
        {
            Plugin.Log.LogInfo($"MetaReward {__instance.name} is disabled");
            __result = false;
            return false;
        }
        
        return true;
    }
}