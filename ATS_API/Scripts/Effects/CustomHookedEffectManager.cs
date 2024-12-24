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
        if (s_newHookLogics.ContainsKey(hookLogicType))
        {
            Plugin.Log.LogError($"Already Registered HookLogicType {hookLogicType}! This will overwrite the previous reg!");
        }
        
        NewHookLogicType newHook = new NewHookLogicType()
        {
            ID = hookLogicType,
            HookLogicType = typeof(T),
            Monitor = monitor
        };
        s_newHookLogics[hookLogicType] = newHook;
        Plugin.Log.LogInfo($"Reg enum {hookLogicType} = {monitor.GetType().Name}");
    }


    #region Patches

    // destory
    [HarmonyPatch(typeof(HookedEffectsController), nameof(HookedEffectsController.OnDestroy))]
    [HarmonyPostfix]
    private static void HookedEffectsController_OnDestroy_PostPatch(HookedEffectsController __instance)
    {
        foreach(IHookMonitor monitor in s_newHookLogics.Values )
        {
            monitor.Dispose();
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