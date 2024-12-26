using System;
using Eremite.Controller.Effects;
using Eremite.Model.Effects;
using HarmonyLib;
using System.Collections.Generic;
using ATS_API.Helpers;

namespace ATS_API.Effects;

[HarmonyPatch]
public class CustomHookedEffectManager
{
    private static Dictionary<HookLogicType, NewHookLogicType> s_newHookLogics = new();
    
    public static NewHookLogicType NewHookLogic<H,M>(string guid, string name) 
        where H : HookLogic
        where M : IHookMonitor
    {
        HookLogicType id = GUIDManager.Get<HookLogicType>(guid, name);
        APILogger.IsFalse(s_newHookLogics.ContainsKey(id), $"Adding HookLogicType with guid {guid} and name {name} that already exists!");
        NewHookLogicType newHook = new NewHookLogicType()
        {
            ID = id,
            HookLogicType = typeof(H),
            Monitor = Activator.CreateInstance<M>()
        };
        s_newHookLogics[id] = newHook;

        return newHook;
    }

    public static NewHookLogicType NewHookLogic<T>(HookLogicType id, HookLogic hookLogic) where T : IHookMonitor, new()
    {
        APILogger.IsFalse(s_newHookLogics.ContainsKey(id), $"Adding HookLogicType with id {id} that already exists!");
        NewHookLogicType newHook = new NewHookLogicType()
        {
            ID = id,
            HookLogicType = hookLogic.GetType(),
            Monitor = Activator.CreateInstance<T>()
        };
        s_newHookLogics[id] = newHook;
        return newHook;
    }

    public static void NewHookLogic<T>(HookLogicType hookLogicType, IHookMonitor monitor) where T : HookLogic
    {
        APILogger.IsFalse(s_newHookLogics.ContainsKey(hookLogicType), $"Adding HookLogicType with id {hookLogicType} that already exists!");
        
        NewHookLogicType newHook = new NewHookLogicType()
        {
            ID = hookLogicType,
            HookLogicType = typeof(T),
            Monitor = monitor
        };
        s_newHookLogics[hookLogicType] = newHook;
        APILogger.LogInfo($"Reg enum {hookLogicType} = {monitor.GetType().Name}");
    }


    #region Patches

    // destory
    [HarmonyPatch(typeof(HookedEffectsController), nameof(HookedEffectsController.OnDestroy))]
    [HarmonyPostfix]
    private static void HookedEffectsController_OnDestroy_PostPatch(HookedEffectsController __instance)
    {
        foreach(var monitor in s_newHookLogics.Values )
        {
            monitor.Monitor?.Dispose();
        }
    }

    // HookLogicType -> IHookMonitor
    [HarmonyPatch(typeof(HookedEffectsController), nameof(HookedEffectsController.GetMonitorFor))]
    [HarmonyPrefix]
    private static bool HookedEffectsController_GetMonitorFor_PrePatch(HookLogicType type, ref IHookMonitor __result)
    {
        if(s_newHookLogics.TryGetValue(type,out NewHookLogicType newHookLogicType))
        {
            __result = newHookLogicType.Monitor;
            return false;
        }
        return true;
    }

    #endregion
}