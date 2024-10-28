using System.Collections.Generic;
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
        Plugin.Log.LogInfo("WorldStateService changed so Saving all modded data");
        // Save Cycle state
        SaveAllModdedData();
    }

    [HarmonyPatch(typeof(GameSaveService), nameof(GameSaveService.SaveState))]
    [HarmonyPostfix]
    private static async UniTask Post_GameSaveService_Save(UniTask enumerator)
    {
        await enumerator;
        Plugin.Log.LogInfo("GameSaveService changed so Saving all modded data");

        // Save Settlement state
        SaveAllModdedData();
    }

    [HarmonyPatch(typeof(MetaStateService), nameof(MetaStateService.SaveState))]
    [HarmonyPostfix]
    private static void Post_MetaStateService_Save()
    {
        Plugin.Log.LogInfo("MetaStateService changed so Saving all modded data");
        
        // Save Settlement state
        SaveAllModdedData();
    }
    
    //
    // Clearing data patches
    //
    
    [HarmonyPatch(typeof(WorldCalendarService), nameof(WorldCalendarService.OnCycleEnded))]
    [HarmonyPostfix]
    private static void OnCycleEnded()
    {
        Plugin.Log.LogInfo("OnCycleEnded. Clearing cycle data from all mods");

        foreach (KeyValuePair<string,ModSaveData> data in saveData)
        {
            data.Value.CurrentCycle = new SaveData();
        }
    }
    
    [HarmonyPatch(typeof(GameLoader), nameof(GameLoader.StartNewGame))]
    [HarmonyPostfix]
    private static void StartNewGame()
    {
        Plugin.Log.LogInfo("StartNewGame. Clearing settlement data from all mods");

        foreach (KeyValuePair<string,ModSaveData> data in saveData)
        {
            data.Value.CurrentSettlement = new SaveData();
        }
    }
}