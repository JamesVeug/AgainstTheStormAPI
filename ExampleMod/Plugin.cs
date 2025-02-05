﻿using ATS_API;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.SaveLoading;
using BepInEx;
using BepInEx.Logging;
using Eremite;
using Eremite.Model;
using HarmonyLib;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleMod;

[HarmonyPatch]
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
[BepInDependency("API", BepInDependency.DependencyFlags.HardDependency)]
public partial class Plugin : BaseUnityPlugin
{
    public static string PluginDirectory;
        
    public static Plugin Instance;
    public static ManualLogSource Log;
    private Harmony harmony;
        
    public static AssetBundle ExampleModAssetBundle;
    public static AssetBundle TinyHearthAssetBundle;
    private Hotkeys.Hotkey showPopupHotkey;
 
    private void Awake()
    {
        Instance = this; 
        Log = Logger;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);
        PluginDirectory = System.IO.Path.GetDirectoryName(Info.Location);
        
        ModdedSaveManager.ListenForLoadedSaveData(PluginInfo.PLUGIN_GUID, PostLoadedSaveData);
        ModdedSaveManager.ListenForResetCycleSaveData(PluginInfo.PLUGIN_GUID, OnResetCycleData);
        ModdedSaveManager.ListenForResetSettlementSaveData(PluginInfo.PLUGIN_GUID, OnResetSettlementData);
        ModdedSaveManager.ListenForPreSaveSaveData(PluginInfo.PLUGIN_GUID, OnPreSaveData);
        EventBus.OnStartGame.AddListener(OnStartSettlement);
        EventBus.OnCycleEnded.AddListener(OnCycleEnded);
        
        CreateGoods();
        CreateCornerstones();
        CreateTrader();
        CreateDifficulty();
        
        if (AssetBundleHelper.TryLoadAssetBundleFromFile("ats_examplemod", out ExampleModAssetBundle))
        {
            CreateBuildings();
            CreateRaces();
        }

        CreateEmbarkRewards();
        
        if (AssetBundleHelper.TryLoadAssetBundleFromFile("tinyhearth", out TinyHearthAssetBundle))
        {
            CreateDecorations();
        }
        
        CreateBiomes();


        Log.LogInfo($"{PluginInfo.PLUGIN_NAME} v{PluginInfo.PLUGIN_VERSION} Plugin loaded");
    }

    private void Start()
    {
        LocaText header = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Header", "Hello!");
        LocaText description = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Description", "This is an example popup");
            
        LocaText disableHotkey = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "DisableButton", "Disable Hotkey");
        
        // Add a Key Binding that shows a popup when "." is pressed. Then add a button to disable the hotkey.
        // TODO: Uncomment this code to see the popup in action. Uncommented so its less annoying for players.
        // showPopupHotkey = Hotkeys.New(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Show Popup", [KeyCode.KeypadPeriod], () =>
        // {
        //     Log.LogInfo("Showing popup");
        //     GenericPopupTask.Show(PluginInfo.PLUGIN_GUID, header, description).WaitForDecision(
        //         new GenericPopupTask.ButtonInfo() {
        //             Key = Keys.Continue_Key.ToLocaText(),
        //             Type = GenericPopupTask.ButtonTypes.Normal,
        //             OnPressed = static () =>
        //             {
        //                 Log.LogInfo("Okay button pressed");
        //             } 
        //         },
        //         new GenericPopupTask.ButtonInfo() {
        //             Key = disableHotkey,
        //             Type = GenericPopupTask.ButtonTypes.CTA,
        //             OnPressed = static () =>
        //             {
        //                 Instance.showPopupHotkey.action.Disable();
        //             } 
        //         }
        //         );
        // });
    }

    private void PostLoadedSaveData(ModSaveData saveData, SaveFileState saveState)
    {
        if (saveState == SaveFileState.NewFile)
        {
            // invoked when first time load the game with this mod.
            Log.LogInfo($"New save file created for {PluginInfo.PLUGIN_NAME}");
            saveData.General.SetValue("TotalLoads", 0);
            saveData.CurrentCycle.SetValue("total_SL_town_count", 0);
            saveData.CurrentSettlement.SetValue("HasSL", false);
        }
        else
        {
            int value = saveData.General.GetValueAsObject<int>("TotalLoads") + 1;
            saveData.General.SetValue("TotalLoads", value);
            Log.LogInfo($"Loaded save file for {PluginInfo.PLUGIN_NAME} {value} times");
        }
    }

    private void OnResetSettlementData(ModSaveData data)
    {
        // note: the data.CurrentSettlement is already cleaned up, when this callback is invoked
        // You only need to initialize the data here
        data.CurrentSettlement.SetValue("HasSL", false);
        Log.LogInfo("start brand new SL detection");
        // Then API will save the data for you
    }

    private void OnResetCycleData(ModSaveData data)
    {
        // note: the data.CurrentCycle is already cleaned up, when this callback is invoked
        // You only need to initialize the data here
        data.CurrentCycle.SetValue("total_SL_town_count", 0);
        Log.LogInfo("Reset SL detection (end of the cycle)");
        // Then API will save the data for you
    }

    private void OnPreSaveData(ModSaveData data)
    {
        Log.LogInfo("Callback before saving the data!");
        // You can assign your special data here
        // Or just save your own data to a special file
        // This might be called inside or outside the settlement game.
    }

    private void OnCycleEnded()
    {
        // This callback is invoked after reset cycle data
        Log.LogInfo($"Reset Cycle!");
    }

    private void OnStartSettlement(bool isNew)
    {
        // This callback is invoked after OnResetSettlement
        Log.LogInfo($"This is new game? -> {isNew}");
        ModSaveData modSaveData = ModdedSaveManager.GetSaveData(PluginInfo.PLUGIN_GUID);
        if (!isNew)
        {
            bool hasSL = modSaveData.CurrentSettlement.GetValueAsObject("HasSL", false);
            if (!hasSL)
            {
                // add peanalty if last time the player Save & Load the game
                // GameMB.ReputationService.AddReputationPenalty(0.5f, Eremite.Services.ReputationChangeSource.Other, true);
                Log.LogInfo($"Detect S/L for the last settlement: {hasSL}");
                int slCount = modSaveData.CurrentCycle.GetValueAsObject("total_SL_town_count", 0) + 1;
                modSaveData.CurrentCycle.SetValue("total_SL_town_count", slCount);
            }
            modSaveData.CurrentSettlement.SetValue("HasSL", true);
            Log.LogInfo("SL detected!");
            // If you changes the mod data outside save callbacks, the changes may not be saved automatically
            // You may need to save them manually, if you want to save the change as soon as the mod change the data.
            ModdedSaveManager.SaveModdedData(PluginInfo.PLUGIN_GUID);
            //ModdedSaveManager.SaveAllModdedData();
        }
    }
}