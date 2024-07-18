using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Goods;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Characters.Villagers;
using Eremite.Controller.Generator;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class GameLoader_Fixes
{
    [HarmonyPatch(typeof(GameLoader), nameof(GameLoader.LoadState))]
    [HarmonyPostfix]
    public static async UniTask PostLoadGame(UniTask enumerator, GameLoader __instance)
    {
        await enumerator;
        
        // Add new fuel types if the player added a new mod when loading a save
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
        
        // Remove any resolve effects on villagers that may have been removed
        foreach (VillagerState state in __instance.state.actors.villagers)
        {
            var clone = new Dictionary<string, VillagerResolveEffectState>();
            foreach (KeyValuePair<string, VillagerResolveEffectState> pair in state.resolveEffects)
            {
                if(MB.Settings.resolveEffectsCache.Contains(MB.Settings.resolveEffects, pair.Key))
                {
                    clone.Add(pair.Key, pair.Value);
                }
                else if(EffectManager.PreviouslyNamedAs.TryGetValue(pair.Key, out string newKey))
                {
                    clone.Add(newKey, pair.Value);
                    Plugin.Log.LogError($"Found missing resolve effect: {pair.Key} when loading save! Replacing with {newKey}");
                }
                else
                {
                    Plugin.Log.LogError($"Found missing resolve effect: {pair.Key} when loading save! Removing from state.");
                }
            }
            
            state.resolveEffects = clone;
        }
    }
}