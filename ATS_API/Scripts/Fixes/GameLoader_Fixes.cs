using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Goods;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Characters.Villagers;
using Eremite.Controller.Effects;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.State;
using Eremite.Services;
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
                    APILogger.LogError($"Found missing resolve effect: {pair.Key} when loading save! Replacing with {newKey}");
                }
                else
                {
                    APILogger.LogError($"Found missing resolve effect: {pair.Key} when loading save! Removing from state.");
                }
            }
            
            state.resolveEffects = clone;
        }
        
        // Add resolve for missing races
        foreach (RaceModel race in SO.Settings.Races)
        {
            if (!__instance.state.actors.currentRacesResolve.TryGetValue(race.name, out _))
            {
                APILogger.LogWarning($"New race {race.name} has been added to existing save. Setting resolve to 0.");
                __instance.state.actors.currentRacesResolve[race.name] = 0;
            }
        }
    }
    
    [HarmonyPatch(typeof(GameServices), nameof(GameServices.LoadingCompleted))]
    [HarmonyPrefix]
    public static bool HookedEffectsController_SetUp()
    {
        StateService __instance = GameMB.StateService as StateService;
        
        // Remove any perks that no longer exist
        foreach (string perkName in new List<string>(__instance.state.effects.perks.Keys))
        {
            if (!Serviceable.GameModelService.GetEffect(perkName))
            {
                APILogger.LogError($"Found missing perk: {perkName} when loading save! Removing from state.");
                __instance.state.effects.perks.Remove(perkName);
            }
        }

        // Remove all effects
        APILogger.LogInfo("Looking for missing effects to remove from state before we load...");
        for (var i = __instance.state.hookedEffects.activeEffects.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.activeEffects[i];
            if (GameMB.GameModelService.GetEffect(activeEffect.model) == null)
            {
                APILogger.LogError($"Found missing active effect: {activeEffect.model} when loading save! Removing from state.");
                __instance.state.hookedEffects.activeEffects.RemoveAt(i);
            }
        }
        for (var i = __instance.state.hookedEffects.toAdd.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.toAdd[i];
            if (GameMB.GameModelService.GetEffect(activeEffect.model) == null)
            {
                APILogger.LogError($"Found missing toAdd effect: {activeEffect.model} when loading save! Removing from state.");
                __instance.state.hookedEffects.toAdd.RemoveAt(i);
            }
        }
        for (var i = __instance.state.hookedEffects.toRemove.Count - 1; i >= 0; i--)
        {
            var activeEffect = __instance.state.hookedEffects.toRemove[i];
            if (GameMB.GameModelService.GetEffect(activeEffect.Key) == null)
            {
                APILogger.LogError($"Found missing toRemove effect: {activeEffect.Key} when loading save! Removing from state.");
                __instance.state.hookedEffects.toRemove.RemoveAt(i);
            }
        }
        
        return true;
    }
}