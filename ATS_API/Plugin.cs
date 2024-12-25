using System;
using System.Collections.Generic;
using System.IO;
using ATS_API.Biomes;
using ATS_API.Buildings;
using ATS_API.Decorations;
using ATS_API.Difficulties;
using ATS_API.Effects;
using ATS_API.Goods;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.MetaRewards;
using ATS_API.NaturalResource;
using ATS_API.Needs;
using ATS_API.Orders;
using ATS_API.Races;
using ATS_API.Recipes;
using ATS_API.Scripts.DeveloperConsole;
using ATS_API.Traders;
using BepInEx;
using HarmonyLib;
using Eremite;
using Eremite.Buildings;
using Eremite.Controller;
using Eremite.Services;
using UnityEngine;

namespace ATS_API;

[HarmonyPatch]
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
internal class Plugin : BaseUnityPlugin
{
    public static event Action PostTick;
    public static string PluginDirectory;

    public static string ExportPath => Path.Combine(PluginDirectory, "Exports");
    
    public static bool CoreGameLoaded
    {
        get;
        internal set;
    }
        
    public static Plugin Instance;
    private Harmony harmony;
    
    internal static AssetBundle ATS_API_Bundle;
    internal static AssetBundle ATS_API_TerrainBundle;
    internal static Transform PrefabContainer;


    private void Awake()
    {
        APILogger.logger = Logger;
        Logger.LogInfo($"Against the Storm v{Application.version}");
        
        Instance = this;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);
        
        PluginDirectory = Info.Location.Replace("API.dll", "");

        string expectedUnityVersion = "2021.3.27f1";
        APILogger.IsEqual(Application.unityVersion, expectedUnityVersion, $"The Unity Version has changed! Expected: {expectedUnityVersion}, Got: {Application.unityVersion}");

        // Stops Unity from destroying it for some reason. Same as Setting the BepInEx config HideManagerGameObject to true.
        gameObject.hideFlags = HideFlags.HideAndDontSave;
        
        PrefabContainer = new GameObject("ATS_API_PrefabContainer").transform;
        PrefabContainer.SetParent(transform);
        PrefabContainer.SetActive(false);

        DeveloperConsole.Initialize();

        AssetBundleHelper.TryLoadAssetBundleFromFile("ats_api", out ATS_API_Bundle);
        AssetBundleHelper.TryLoadAssetBundleFromFile("customterrain", out ATS_API_TerrainBundle);
        
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void LateUpdate()
    {
        if (!CoreGameLoaded)
        {
            return;
        }

        Hotkeys.Update();
        
        DecorationManager.Tick();
        DifficultyManager.Tick();
        GoodsManager.Tick();
        EffectManager.Tick();
        TraderManager.Tick();
        OrdersManager.Tick();
        NaturalResourceManager.Tick();
        BiomeManager.Tick();
        TextMeshProManager.Tick();
        RecipeManager.Tick();
        RaceManager.Tick();
        BuildingManager.Tick();
        RaceNeedManager.Tick();
        MetaRewardManager.Tick();
        
        LocalizationManager.Tick();
        
        // PostTick to set up links objects between each other since we can't guarantee they will be loaded in order.
        if (PostTick != null)
        {
            PostTick.Invoke();
            PostTick = null;
        }
    }
        
    [HarmonyPatch(typeof(MainController), nameof(MainController.InitReferences))]
    [HarmonyPostfix]
    private static void PostSetupMainController()
    {
        LocalizationManager.Instantiate();
        
        DecorationManager.Instantiate();
        DifficultyManager.Instantiate();
        RecipeManager.Instantiate();
        GoodsManager.Instantiate();
        EffectManager.Instantiate();
        TraderManager.Instantiate();
        OrdersManager.Instantiate();
        NaturalResourceManager.Instantiate();
        BiomeManager.Instantiate();
        TextMeshProManager.Instantiate();
        BuildingManager.Instantiate();
        RaceManager.Instantiate();
        RaceNeedManager.Instantiate();
        MetaRewardManager.Instantiate();
            
        // Invoke events
        EventBus.OnInitReferences.Invoke();
    }
        
    [HarmonyPatch(typeof(MetaStateService), nameof(MetaStateService.CheckForInitialLevel))]
    [HarmonyPostfix]
    private static void MetaStateServiceSetup(MetaStateService __instance)
    { 
        // This method will run after game load (Roughly on entering the main menu)
        // At this point a lot of the game's data will be available.
        // Your main entry point to access this data will be `Serviceable.Settings` or `MainController.Instance.Settings`
        foreach (NewBuildingData BuildingModel in BuildingManager.NewBuildings)
        {
            if(!__instance.Content.buildings.Contains(BuildingModel.BuildingModel.name))
            {
                __instance.Content.buildings.Add(BuildingModel.BuildingModel.name);
            }
            
            if(!__instance.Content.essentialBuildings.Contains(BuildingModel.BuildingModel.name))
            {
                __instance.Content.essentialBuildings.Add(BuildingModel.BuildingModel.name);
            }
        }
    }

    [HarmonyPatch(typeof(GameController), nameof(GameController.StartGame))]
    [HarmonyPostfix]
    private static void HookEveryGameStart()
    {
        // Too difficult to predict when GameController will exist and I can hook observers to it
        // So just use Harmony and save us all some time. This method will run after every game start
        var isNewGame = MB.GameSaveService.IsNewGame();
        
        // Invoke events
        EventBus.OnStartGame.Invoke(isNewGame);
    }

    [HarmonyPatch(typeof(GameContentService), nameof(GameContentService.GetOptionalBuildings))]
    [HarmonyPostfix]
    private static void GetOptionalBuildings(GameContentService __instance, ref IEnumerable<BuildingModel> __result)
    {
        List<BuildingModel> list = new List<BuildingModel>(__result);
        foreach (NewBuildingData BuildingModel in BuildingManager.NewBuildings)
        {
            if(!list.Contains(BuildingModel.BuildingModel))
            {
                list.Add(BuildingModel.BuildingModel);
            }
        }
        __result = list;
    }
}