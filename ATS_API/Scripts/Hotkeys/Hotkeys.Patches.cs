using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
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
        ModdedKeyboardSlots[] allChildren = __instance.GetComponentsInChildren<ModdedKeyboardSlots>(true);


        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            if (!activeActionMaps.Contains(pair.Key))
            {
                continue;
            }
            
            InputActionMap actionMap = MasterInputAsset.FindActionMap(pair.Key);
            if (actionMap == null || actionMap.actions.Count == 0)
            {
                continue;
            }

            ModdedKeyboardSlots children = allChildren.FirstOrDefault(a => a.ModName == pair.Key);
            if (children == null)
            {
                // LogInfo($"Slots are null for {actionMap.name}, creating new slots.");
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

                // LogInfo($"Slots created for {pair.Key} with {actionMap.actions.Count} actions.");
            }
        }
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.SetUpSlots))]
    [HarmonyPostfix]
    public static void KeyBindingsPanel_SetUpSlots_Postfix(KeyBindingsPanel __instance)
    {
        ModdedKeyboardSlots[] slots = __instance.SafeGetComponentsInChildren<ModdedKeyboardSlots>(true);
        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            InputActionMap actionMap = MasterInputAsset.FindActionMap(pair.Key);
            if (actionMap == null)
            {
                // LogInfo($"Action map is null for mod {pair.Key}, skipping.");
                continue;
            }

            ModdedKeyboardSlots moddedKeyboard = slots.FirstOrDefault(a=>a.ModName == pair.Key);
            if (moddedKeyboard == null)
            {
                // LogInfo($"Modded keyboard is null for {pair.Key}, returning.");
                continue;
            }

            moddedKeyboard.SetupKeyboardSlots(actionMap, __instance);
        }
    }

    [HarmonyPatch(typeof(KeyBindingsPanel), nameof(KeyBindingsPanel.ResetCounter))]
    [HarmonyPostfix]
    private static void KeyBindingsPanel_ResetCounter(KeyBindingsPanel __instance)
    {
        ModdedKeyboardSlots[] keyboardSlots = __instance.SafeGetComponentsInChildren<ModdedKeyboardSlots>(true);
        if (keyboardSlots != null)
        {
            foreach (ModdedKeyboardSlots keyboardSlot in keyboardSlots)
            {
                keyboardSlot.ResetCounter();
            }
        }
    }

    [HarmonyPatch(typeof(InputConfig), MethodType.Constructor)]
    [HarmonyPostfix]
    private static void HookMainControllerSetup(InputConfig __instance)
    {
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