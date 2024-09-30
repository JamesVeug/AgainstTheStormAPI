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
    private static string CustomBindingsPath => Path.Combine(Application.persistentDataPath, "API");
    
    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.Reset))]
    [HarmonyPrefix]
    private static void ClientPrefsService_Reset()
    {
        foreach (InputActionMap map in modNameToActionMaps.Values)
        {
            LogInfo($"Resetting input config for {map.name}");
            map.RemoveAllBindingOverrides();
        }
    }
    
    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.SaveInputConfig))]
    [HarmonyPostfix]
    private static void ClientPrefsService_SaveInputConfig()
    {
        if (!Directory.Exists(CustomBindingsPath))
        {
            Directory.CreateDirectory(CustomBindingsPath);
        }
        
        foreach (KeyValuePair<string, InputActionMap> pair in modNameToActionMaps)
        {
            string value = pair.Value.SaveBindingOverridesAsJson();
            LogInfo($"Saving input config for {pair.Key} with value {value}");
            SavedInputMap inputMap = new SavedInputMap
            {
                modName = pair.Key,
                actionMap = pair.Value.ToJson(),
                bindings = value
            };

            string path = Path.Combine(CustomBindingsPath, $"{pair.Key}.custombindings");
            LogInfo($"Saving keybinds for {pair.Key} to {path}");
            JsonIO.SaveToFile(inputMap, path);
        }
    }

    [HarmonyPatch(typeof(ClientPrefsService), nameof(ClientPrefsService.LoadInputConfig))]
    [HarmonyPostfix]
    private static void ClientPrefsService_LoadInputConfig()
    {
        if (Serviceable.CommandLineArgsService.HasKey("-resetkeybinds"))
        {
            LogError("Clearing keybinds!");
            return;
        }
        
        if (!Directory.Exists(CustomBindingsPath))
        {
            LogInfo("No custombindings folder found.");
            return;
        }
        
        string[] files = Directory.GetFiles(CustomBindingsPath, "*.custombindings");
        if(files.Length == 0)
        {
            LogInfo("No saved custombindings files found.");
            return;
        }
        
        MasterInputAsset.Disable();
        foreach (string path in files)
        {
            if (!File.Exists(path))
            {
                LogError("No saved inputs found.");
                continue;
            }

            SavedInputMap modInput = JsonIO.GetFromFile<SavedInputMap>(path);
            if (modInput == null)
            {
                LogError("Couldn't load custom input json at path " + path);
                continue;
            }

            LogInfo("Loading keybinds for " + modInput.modName + " with value " + modInput.bindings);

            string actionMapJSON = modInput.actionMap;
            InputActionMap[] actionMap = InputActionMap.FromJson(actionMapJSON);
            if (actionMap.Length == 0)
            {
                LogError($"Failed to load {modInput.modName} action map from json: " + actionMapJSON);
                continue;
            }
            else if (actionMap.Length > 1)
            {
                LogWarning(
                    $"Loaded {actionMap.Length} action maps for {modInput.modName}, using the first one.");
            }

            InputActionMap map = actionMap[0];
            if (MasterInputAsset.FindActionMap(map.name) == null)
            {
                LogInfo($"Added action map {map.name}");
                MasterInputAsset.AddActionMap(map);

                foreach (InputAction action in map.actions)
                {
                    LogInfo($"\tAdded action {action.name}");
                }
                
                map.LoadBindingOverridesFromJson(modInput.bindings);
                // log overrides
                foreach (InputBinding binding in map.bindings)
                {
                    LogInfo($"\tAdded binding {binding.path}");
                }
            }
            else
            {
                LogWarning($"Action map {map.name} already exists. Likely another mod already loaded this so your hotkeys may differ!");
            }

            modNameToActionMaps[modInput.modName] = map;
        }
        MasterInputAsset.Enable();
    }

    [Serializable]
    private class SavedInputMap
    {
        public string modName;
        public string actionMap;
        public string bindings;
    }
}