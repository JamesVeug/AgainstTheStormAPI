using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Eremite.Model;
using Eremite.Services;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class CornerstoneService_Fixes
{
    [HarmonyPatch(typeof(CornerstonesService), nameof(CornerstonesService.Reroll))]
    [HarmonyTranspiler]
    public static IEnumerable<CodeInstruction> Fix_SecondCornerstoneRerollNullRewards(IEnumerable<CodeInstruction> instructions)
    {
        // We want to change
        //
        // GetCurrentPick().options = GenerateRewards(FindRewardsFor(currentPick.date, currentPick.isExtra), currentPick.seed, GetAllCurrentOptions());
        //
        // To
        //
        // var model = FindRewardsFor(currentPick.date, currentPick.isExtra), currentPick.seed, GetAllCurrentOptions()
        // model = FillEmptyList(model)
        // GetCurrentPick().options = GenerateRewards(model, currentPick.seed, GetAllCurrentOptions());
        //
        
        MethodInfo fillEmptyList = AccessTools.Method(typeof(CornerstoneService_Fixes), nameof(ReplaceNullReward));
        MethodInfo FindRewardsFor = AccessTools.Method(typeof(CornerstonesService), nameof(CornerstonesService.FindRewardsFor));
        
        List<CodeInstruction> codes = new(instructions);
        for (int i = 0; i < codes.Count; i++)
        {
            CodeInstruction code = codes[i];
            if (code.opcode == OpCodes.Call && code.operand == FindRewardsFor)
            {
                codes.Insert(++i, new CodeInstruction(OpCodes.Call, fillEmptyList));
                break;
            }
        }
    
        return codes;
    }

    private static SeasonRewardModel ReplaceNullReward(SeasonRewardModel model)
    {
        if (model != null)
        {
            APILogger.LogInfo($"??? SeasonRewardModel is not null: {model}");
            return model;
        }

        var rewards = new List<SeasonRewardModel>(Serviceable.Biome.seasons.SeasonRewards);
        rewards.Sort((a, b) =>
        {
            if (a.Date > b.Date)
            {
                return 1;
            }

            if (a.Date < b.Date)
            {
                return -1;
            }

            return 0;
        });

        // TODO: Be more clever about how we get the reward. This is only an issue on the first cornerstones of the game
        SeasonRewardModel seasonRewardModel = rewards[0];
        APILogger.LogInfo($"\"??? Replaced null SeasonRewardModel with null?: {seasonRewardModel == null}");
        return seasonRewardModel;
    }
}