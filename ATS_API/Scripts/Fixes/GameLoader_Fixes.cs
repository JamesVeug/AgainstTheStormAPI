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

        PostLoadGame(__instance);
    }

    private static void PostLoadGame(GameLoader __instance)
    {
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
        
        // Remove any perks that no longer exist
        foreach (string perkName in new List<string>(__instance.state.effects.perks.Keys))
        {
            if (!MB.Settings.effectsCache.Contains(MB.Settings.effects, perkName))
            {
                Plugin.Log.LogError($"Found missing perk: {perkName} when loading save! Removing from state.");
                __instance.state.effects.perks.Remove(perkName);
            }
        }

        // Remove all effects
        Plugin.Log.LogInfo("Removing all effects from state.");
        for (var i = __instance.state.hookedEffects.activeEffects.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.activeEffects[i];
            if (!MB.Settings.effectsCache.Contains(MB.Settings.effects, activeEffect.model))
            {
                Plugin.Log.LogError($"Found missing active effect: {activeEffect.model} when loading save! Removing from state.");
                __instance.state.hookedEffects.activeEffects.RemoveAt(i);
            }
        }
        for (var i = __instance.state.hookedEffects.toAdd.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.toAdd[i];
            if (!MB.Settings.effectsCache.Contains(MB.Settings.effects, activeEffect.model))
            {
                Plugin.Log.LogError($"Found missing toAdd effect: {activeEffect.model} when loading save! Removing from state.");
                __instance.state.hookedEffects.toAdd.RemoveAt(i);
            }
        }
        for (var i = __instance.state.hookedEffects.toRemove.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.toRemove[i];
            if (!MB.Settings.effectsCache.Contains(MB.Settings.effects, activeEffect.Key))
            {
                Plugin.Log.LogError($"Found missing toRemove effect: {activeEffect.Key} when loading save! Removing from state.");
                __instance.state.hookedEffects.toRemove.RemoveAt(i);
            }
        }
        
        
    }
}