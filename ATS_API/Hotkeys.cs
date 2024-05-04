using System;
using System.Collections.Generic;
using ATS_API;
using Eremite;
using HarmonyLib;
using UnityEngine;
using UnityEngine.InputSystem;

[HarmonyPatch]
public class Hotkeys
{
    private class PendingHotkey
    {
        public string keyName;
        public KeyCode code;
        public Action onRelease;
    }
    
    public static InputActionAsset InputAsset;
    private static InputActionMap actionMap;
    private static List<PendingHotkey> pendingHotkeys = new List<PendingHotkey>();
    
    [HarmonyPatch(typeof(InputConfig), MethodType.Constructor)]
    [HarmonyPostfix]
    private static void HookMainControllerSetup(InputConfig __instance)
    {
        InputAsset = __instance.asset;
        
        // Create an action map containing a single action with a gamepad binding.
        InputActionMap map = InputAsset.FindActionMap("API");
        if (map != null)
        {
            InputAsset.RemoveActionMap(map);
        }

        actionMap = new InputActionMap("API");
        InputAsset.AddActionMap(actionMap);
        
        // Let's assume we have two gamepads connected. If we enable the
        // action map now, the 'Fire' action will bind to both.
        actionMap.Enable();
        
        foreach (var pendingHotkey in pendingHotkeys)
        {
            RegisterKey(pendingHotkey.keyName, pendingHotkey.code, pendingHotkey.onRelease);
        }
    }
    
    public static void RegisterKey(string keyName, KeyCode code, Action onRelease = null)
    {
        Plugin.Log.LogInfo($"Registering key {keyName} with code {code}");
        if(actionMap == null)
        {
            Plugin.Log.LogInfo($"Action map is null, adding to pending hotkeys.");
            pendingHotkeys.Add(new PendingHotkey()
            {
                keyName = keyName,
                code = code,
                onRelease = onRelease
            });
            return;
        }
        
        InputAction fireAction = actionMap.AddAction(keyName, binding: $"<Keyboard>/{code}");
        fireAction.canceled += ctx =>
        {
            Plugin.Log.LogInfo($"{keyName} action canceled!");
            onRelease?.Invoke();
        };
    }
}