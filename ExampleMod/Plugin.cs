using ATS_API.Helpers;
using ATS_API.SaveLoading;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
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
        
    public static AssetBundle AssetBundle;
 
    private void Awake()
    {
        Instance = this; 
        Log = Logger;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);
        PluginDirectory = Info.Location.Replace("API_ExampleMod.dll", "");
        
        ModdedSaveManager.ListenForLoadedSaveData(PluginInfo.PLUGIN_GUID, PostLoadedSaveData);
        
        CreateGoods();
        CreateCornerstones();
        CreateTrader();
        CreateDifficulty();
        
        if (AssetBundleHelper.TryLoadAssetBundleFromFile("ats_examplemod", out AssetBundle))
        {
            CreateBuildings();
            CreateRaces();
        }

        CreateEmbarkRewards();


        Log.LogInfo($"{PluginInfo.PLUGIN_NAME} v{PluginInfo.PLUGIN_VERSION} Plugin loaded");
    }

    private void PostLoadedSaveData(ModSaveData saveData, SaveFileState saveState)
    {
        if (saveState == SaveFileState.NewFile)
        {
            Log.LogInfo($"New save file created for {PluginInfo.PLUGIN_NAME}");
            saveData.General.SetValue("TotalLoads", 0);
        }
        else
        {
            int value = saveData.General.GetValueAsObject<int>("TotalLoads") + 1;
            saveData.General.SetValue("TotalLoads", value);
            Log.LogInfo($"Loaded save file for {PluginInfo.PLUGIN_NAME} {value} times");
        }
    }
}