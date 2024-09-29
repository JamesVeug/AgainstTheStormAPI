using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Services;
using Eremite.View;
using Eremite.View.Popups.GameMenu;
using Eremite.View.Utils;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ATS_API;

public static partial class Hotkeys
{
    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.OnEnable))]
    [HarmonyPrefix]
    public static void KeyBindingsPanel_Start_Postfix(KeyBindingsPanel __instance)
    {
        ModdedKeyboardSlots[] allChildren = __instance.GetComponentsInChildren<ModdedKeyboardSlots>();


        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            if (!activeActionMaps.Contains(pair.Key))
            {
                continue;
            }
            
            InputActionMap actionMap = MasterInputAsset.FindActionMap(pair.Key);
            if (actionMap == null)
            {
                Plugin.Log.LogInfo($"Action map is null for modName {pair.Key}, skipping.");
                continue;
            }

            ModdedKeyboardSlots children = allChildren.FirstOrDefault(a => a.ModName == pair.Key);
            if (children == null)
            {
                Plugin.Log.LogInfo("Slots are null, creating new slots.");
                Transform parent = __instance.slots[0].transform.parent;
                Transform clone = GameObject.Instantiate(parent, parent.parent);
                clone.gameObject.name = "Modded";
                children = clone.gameObject.AddComponent<ModdedKeyboardSlots>();
                children.Initialize(pair.Key, clone);

                Transform header = clone.Find("Header");
                TMP_Text headerText = header.GetComponent<TMP_Text>();
                GameObject.Destroy(header.GetComponent<LocalizationText>());
                GameObject.Destroy(header.GetComponent<TextFontFeaturesHelper>());
                headerText.text = pair.Key;

                Plugin.Log.LogInfo($"Slots created for {pair.Key} with {actionMap.actions.Count} actions.");
            }
            else
            {
                Plugin.Log.LogInfo("Slots are already set up.");
            }
        }
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.SetUpSlots))]
    [HarmonyPostfix]
    public static void KeyBindingsPanel_SetUpSlots_Postfix(KeyBindingsPanel __instance)
    {
        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            InputActionMap actionMap = Hotkeys.MasterInputAsset.FindActionMap(pair.Key);
            if (actionMap == null)
            {
                Plugin.Log.LogInfo($"Action map is null for mod {pair.Key}, skipping.");
                continue;
            }

            ModdedKeyboardSlots moddedKeyboard = __instance.GetComponentInChildren<ModdedKeyboardSlots>();
            if (moddedKeyboard == null)
            {
                Plugin.Log.LogInfo($"Modded keyboard is null for {pair.Key}, returning.");
                return;
            }

            moddedKeyboard.SetupKeyboardSlots(actionMap, __instance);
        }
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.ResetCounter))]
    [HarmonyPostfix]
    private static void KeyBindingsPanel_ResetCounter(KeyBindingsPanel __instance)
    {
        Plugin.Log.LogInfo($"Reset counter.");
        ModdedKeyboardSlots keyboardSlots = __instance.GetComponentInChildren<ModdedKeyboardSlots>();
        if (keyboardSlots != null)
        {
            keyboardSlots.ResetCounter();
        }
    }

    [HarmonyPatch(typeof(InputConfig), MethodType.Constructor)]
    [HarmonyPostfix]
    private static void HookMainControllerSetup(InputConfig __instance)
    {
        Plugin.Log.LogInfo($"Setting up custom action map.");
        MasterInputAsset = __instance.asset;
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.EnableInput))]
    [HarmonyPostfix]
    private static void KeyBindingsPanel_EnableInput()
    {
        foreach (InputActionMap map in modNameToActionMaps.Values)
        {
            map.Enable();
        }
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.DisableInput))]
    [HarmonyPostfix]
    private static void KeyBindingsPanel_DisableInput()
    {
        foreach (InputActionMap map in modNameToActionMaps.Values)
        {
            map.Disable();
        }
    }

    [HarmonyPatch(typeof(InputService), nameof(InputService.GetShortcutLabel))]
    [HarmonyPrefix]
    private static bool InputService_GetShortcutLabel(InputAction action, ref string __result)
    {
        string uniqueName = action.actionMap.name + "_" + action.name;
        if (modNameActionNameToAddedHotkey.TryGetValue(uniqueName, out var hotkey))
        {
            __result = hotkey.displayName;
            return false;
        }

        return true;
    }
}