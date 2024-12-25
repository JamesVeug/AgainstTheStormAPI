using System.Collections.Generic;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite.Controller.Generator;
using Eremite.Services;
using Eremite.Services.World;
using HarmonyLib;

namespace ATS_API.SaveLoading;

[HarmonyPatch]
public static partial class ModdedSaveManager
{
    //
    // Auto saving patches
    //
    [HarmonyPatch(typeof(WorldStateService), nameof(WorldStateService.SaveState))]
    [HarmonyPostfix]
    private static void Post_WorldState_Save()
    {
        APILogger.LogInfo("WorldStateService changed so Saving all modded data");
        // Save Cycle state
        ModdedSaveManager.SaveAllModdedData();
    }

    [HarmonyPatch(typeof(GameSaveService), nameof(GameSaveService.SaveState))]
    [HarmonyPostfix]
    private static async UniTask Post_GameSaveService_Save(UniTask enumerator)
    {
        await enumerator;
        APILogger.LogInfo("GameSaveService changed so Saving all modded data");

        // Save Settlement state
        ModdedSaveManager.SaveAllModdedData();
    }

    [HarmonyPatch(typeof(MetaStateService), nameof(MetaStateService.SaveState))]
    [HarmonyPostfix]
    private static void Post_MetaStateService_Save()
    {
        APILogger.LogInfo("MetaStateService changed so Saving all modded data");
        
        // Save Settlement state
        ModdedSaveManager.SaveAllModdedData();
    }
    
    //
    // Clearing data patches
    //
    
    [HarmonyPatch(typeof(WorldCalendarService), nameof(WorldCalendarService.OnCycleEnded))]
    [HarmonyPostfix]
    private static void OnCycleEnded()
    {
        APILogger.LogInfo("OnCycleEnded. Clearing cycle data from all mods");

        foreach (KeyValuePair<string,ModSaveData> data in ModdedSaveManager.ModGuidToDataLookup)
        {
            data.Value.CurrentCycle = new SaveData();
        }
        EventBus.OnCycleEnded.Invoke();
        ModdedSaveManagerService.InvokeModSaveDataListeners(
            ModdedSaveManagerService.ResetCycleSaveDataListeners
            );
    }
    
    [HarmonyPatch(typeof(GameLoader), nameof(GameLoader.StartNewGame))]
    [HarmonyPostfix]
    private static void StartNewGame()
    {
        APILogger.LogInfo("StartNewGame. Clearing settlement data from all mods");

        foreach (KeyValuePair<string,ModSaveData> data in ModdedSaveManager.ModGuidToDataLookup)
        {
            data.Value.CurrentSettlement = new SaveData();
        }
        ModdedSaveManagerService.InvokeModSaveDataListeners(
            ModdedSaveManagerService.ResetSettlementSaveDataListeners
            );
        ModdedSaveManager.SaveAllModdedData(); //GameSaveService.SaveState is invoked before this method being invoked, so we need to save mod data again here.
    }
}