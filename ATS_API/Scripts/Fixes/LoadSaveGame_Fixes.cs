using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using ATS_API.Effects;
using ATS_API.Goods;
using Cysharp.Threading.Tasks;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.Services;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class LoadSaveGame_Fixes
{
    [HarmonyPatch(typeof(GameLoader), nameof(GameLoader.LoadState))]
    [HarmonyPostfix]
    public static async UniTask PostLoadGame(UniTask enumerator, GameLoader __instance)
    {
        await enumerator;
        foreach (NewGood effect in GoodsManager.NewGoods)
        {
            if (effect.goodModel.canBeBurned)
            {
                if (!__instance.state.prefs.fuelsPriority.ContainsKey(effect.goodModel.name))
                {
                    // Loaded a game that has new fuel types
                    __instance.state.prefs.fuelsPriority.Add(effect.goodModel.name, 0); // ATS uses 0 as default
                }
            }
        }
    }
}