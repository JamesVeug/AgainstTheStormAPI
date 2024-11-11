using ATS_API;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.SaveLoading;
using BepInEx;
using BepInEx.Logging;
using Eremite.Model;
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
    private Hotkeys.Hotkey showPopupHotkey;
 
    private void Awake()
    {
        Instance = this; 
        Log = Logger;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);
        PluginDirectory = System.IO.Path.GetDirectoryName(Info.Location);
        
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

    private void Start()
    {
        LocaText header = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Header", "Hello!");
        LocaText description = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Description", "This is an example popup");
            
        LocaText disableHotkey = LocalizationManager.ToLocaText(PluginInfo.PLUGIN_GUID, "showExamplePopup", "DisableButton", "Disable Hotkey");
        
        // Add a Key Binding that shows a popup when "." is pressed. Then add a button to disable the hotkey.
        showPopupHotkey = Hotkeys.New(PluginInfo.PLUGIN_GUID, "showExamplePopup", "Show Popup", [KeyCode.KeypadPeriod], () =>
        {
            Log.LogInfo("Showing popup");
            GenericPopupTask.Show(PluginInfo.PLUGIN_GUID, header, description).WaitForDecision(
                new GenericPopupTask.ButtonInfo() {
                    Key = Keys.Continue_Key.ToLocaText(),
                    Type = GenericPopupTask.ButtonTypes.Normal,
                    OnPressed = static () =>
                    {
                        Log.LogInfo("Okay button pressed");
                    } 
                },
                new GenericPopupTask.ButtonInfo() {
                    Key = disableHotkey,
                    Type = GenericPopupTask.ButtonTypes.CTA,
                    OnPressed = static () =>
                    {
                        Instance.showPopupHotkey.action.Disable();
                    } 
                }
                );
        });
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