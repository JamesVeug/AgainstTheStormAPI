using System.Collections.Generic;
using Eremite.Model;
using HarmonyLib;

namespace ATS_API.Effects;

[HarmonyPatch]
public static partial class EffectManager
{
    // [HarmonyPatch(typeof(EffectsTable), nameof(EffectsTable.GetRandomNames))]
    // [HarmonyPostfix]
    // private static void EffectsTable_GetRandomNames_Postfix(EffectsTable __instance, ref List<string> __result)
    // {
    //     Plugin.Log.LogInfo("Patching EffectsTable effects " + __instance.effects.Length);
    //     foreach (EffectsTableEntity e in __instance.effects)
    //     {
    //         Plugin.Log.LogInfo($"- {e.chance}% {e.effect.name}");
    //     }
    //     
    //     Plugin.Log.LogInfo("Patching EffectsTable result " + __result.Count);
    //     foreach (string s in __result)
    //     {
    //         Plugin.Log.LogInfo("- " + s);
    //     }
    // }
    
    // [HarmonyPatch(typeof(CornerstonesService), nameof(CornerstonesService.GenerateRewards))]
    // [HarmonyPostfix]
    // private static void PostLoadLocalisation(CornerstonesService __instance, ref List<string> __result)
    // {
    //     // __result.AddRange(s_newEffects.Select(a => a.Name));
    //     // __result.AddRange(s_newEffects.Select((a)=>a.EffectModel.name));
    //     // __result.AddRange(__result);
    //     // __result.AddRange(__result);
    //     Plugin.Log.LogInfo("Patching CornerstonesService GenerateRewards " + __result.Count);
    // }

    // [HarmonyPatch]
    // private class SettingsPatch
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         Plugin.Log.LogInfo("Patching EffectManager EnsureCache");
    //         Type type = typeof(ModelCache<EffectModel>);
    //         Plugin.Log.LogInfo("type - " + type);
    //         MethodInfo methodInfo = type.GetMethod("EnsureCache", BindingFlags.Instance | BindingFlags.NonPublic);
    //         Plugin.Log.LogInfo("methodInfo - " + methodInfo);
    //         // MethodInfo genericMethod = methodInfo.MakeGenericMethod(typeof(EffectModel));
    //         // Plugin.Log.LogInfo("genericMethod - " + genericMethod);
    //         return methodInfo;
    //     }
    //
    //     [HarmonyPrefix]
    //     private static void Prefix(ModelCache<EffectModel> __instance, ref EffectModel[] arr)
    //     {
    //         Plugin.Log.LogInfo("Patching EffectManager EnsureCache Prefix " + s_newEffectsDirty + " vanilla effects: " +
    //                            arr.Length + " new effects: " + s_newEffects.Count);
    //         // Insert our new data into their cachebecause it changed
    //         if (s_newEffects.Count > 0 && (s_newEffectsDirty || __instance.cache == null))
    //         {
    //             s_newEffectsDirty = false;
    //             __instance.cache = null;
    //             arr = s_newEffects.Concat(arr).ToArray();
    //         }
    //     }
    //
    //     [HarmonyPostfix]
    //     private static void Postfix(ModelCache<EffectModel> __instance, ref EffectModel[] arr)
    //     {
    //         Plugin.Log.LogInfo("Patching EffectManager EnsureCache Postfix " + s_newEffectsDirty + " All effects: " +
    //                            __instance.cache.Count);
    //     }
    // }
}