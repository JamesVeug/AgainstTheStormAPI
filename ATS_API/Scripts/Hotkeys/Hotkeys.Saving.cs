using System;
using System.Collections.Generic;
using System.IO;
using Eremite.Services;
using HarmonyLib;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ATS_API;

public static partial class Hotkeys
{
    private static string CustomBindingsPath => Path.Combine(Application.persistentDataPath, "CustomBindings.save");
    
    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.Reset))]
    [HarmonyPrefix]
    private static void ClientPrefsService_Reset()
    {
        foreach (InputActionMap map in modNameToActionMaps.Values)
        {
            Plugin.Log.LogInfo($"Resetting input config for {map.name}");
            map.RemoveAllBindingOverrides();
        }
    }
    
    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.SaveInputConfig))]
    [HarmonyPostfix]
    private static void ClientPrefsService_SaveInputConfig()
    {
        SavedInputs savedInputs = new SavedInputs();
        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            string value = pair.Value.SaveBindingOverridesAsJson();
            Plugin.Log.LogInfo($"Saving input config for {pair.Key} with value {value}");
            savedInputs.configs.Add(new SavedInputConfig
            {
                modName = pair.Key,
                actionMap = pair.Value.ToJson(),
                bindings = value
            });
        }

        JsonIO.SaveToFile(savedInputs, CustomBindingsPath);
    }

    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.LoadInputConfig))]
    [HarmonyPostfix]
    private static void ClientPrefsService_LoadInputConfig()
    {
        if (!File.Exists(CustomBindingsPath))
        {
            Plugin.Log.LogInfo("No saved inputs found.");
            return;
        }

        SavedInputs savedInputs = JsonIO.GetFromFile<SavedInputs>(CustomBindingsPath);
        if (savedInputs == null)
        {
            Plugin.Log.LogInfo("Couldn't load custom input json.");
            return;
        }

        if (Serviceable.CommandLineArgsService.HasKey("-resetkeybinds"))
        {
            Plugin.Log.LogInfo("Clearing keybinds!");
            return;
        }

        MasterInputAsset.Disable();
        foreach (SavedInputConfig pair in savedInputs.configs)
        {
            Plugin.Log.LogInfo("Loading keybinds for " + pair.modName + " with value " + pair.bindings);

            string actionMapJSON = pair.actionMap;
            InputActionMap[] actionMap = InputActionMap.FromJson(actionMapJSON);
            if(actionMap.Length == 0)
            {
                Plugin.Log.LogError($"Failed to load {pair.modName} action map from json: " + actionMapJSON);
                continue;
            }
            else if (actionMap.Length > 1)
            {
                Plugin.Log.LogWarning($"Loaded {actionMap.Length} action maps for {pair.modName}, using the first one.");
            }

            InputActionMap map = actionMap[0];
            if(MasterInputAsset.FindActionMap(map.name) == null)
            {
                MasterInputAsset.AddActionMap(map);
                map.LoadBindingOverridesFromJson(pair.bindings);
            }
            else
            {
                Plugin.Log.LogWarning($"Action map {map.name} already exists. Likely another mod already loaded this so your hotkeys may differ!");
            }
            modNameToActionMaps[pair.modName] = map;
        }

        MasterInputAsset.Enable();
    }

    [Serializable]
    private class SavedInputs
    {
        public List<SavedInputConfig> configs = new List<SavedInputConfig>();
    }

    [Serializable]
    private class SavedInputConfig
    {
        public string modName;
        public string actionMap;
        public string bindings;
    }
}