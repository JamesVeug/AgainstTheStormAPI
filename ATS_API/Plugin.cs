using System.Collections.Generic;
using System.Linq;
using ATS_API.Biomes;
using ATS_API.Buildings;
using ATS_API.Effects;
using ATS_API.Goods;
using ATS_API.Helpers;
using ATS_API.Orders;
using ATS_API.Recipes;
using ATS_API.Traders;
using BepInEx;
using BepInEx.Logging;
using Cysharp.Threading.Tasks;
using HarmonyLib;
using Eremite;
using Eremite.Buildings;
using Eremite.Controller;
using Eremite.Model.Trade;
using Eremite.Services;
using Eremite.View.HUD.Construction;
using UnityEngine;

namespace ATS_API;

[HarmonyPatch]
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    public static string PluginDirectory;
        
    public static Plugin Instance;
    public static ManualLogSource Log;
    private Harmony harmony;
    
    internal static AssetBundle ATS_API_Bundle;
        

    private void Awake()
    {
        Instance = this;
        Log = Logger;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);

        PluginDirectory = Info.Location.Replace("API.dll", "");

        string expectedUnityVersion = "2021.3.27f1";
        Assert.IsEqual(Application.unityVersion, expectedUnityVersion, $"The Unity Version has changed!");

        // Stops Unity from destroying it for some reason. Same as Setting the BepInEx config HideManagerGameObject to true.
        gameObject.hideFlags = HideFlags.HideAndDontSave;
        
        // Hotkeys.RegisterKey("Reset Tradder", KeyCode.F1, () =>
        // {
        //     Logger.LogInfo($"Resetting trader!");
        //     TradeService tradeService = (TradeService)GameMB.TradeService;
        //     tradeService.Leave();
        // });
        
        ATS_API_Bundle = AssetBundleHelper.LoadAssetBundle("ats_api", typeof(Plugin).Assembly);
        
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void LateUpdate()
    {
        GoodsManager.Tick();
        EffectManager.Tick();
        TraderManager.Tick();
        OrdersManager.Tick();
        BiomeManager.Tick();
        TextMeshProManager.Tick();
        RecipeManager.Tick();
        BuildingManager.Tick();
        
        // TODO: PostTick to set up links between objects since we can't guarantee they will be loaded in roder.
    }
        
    [HarmonyPatch(typeof(MainController), nameof(MainController.InitReferences))]
    [HarmonyPostfix]
    private static void PostSetupMainController()
    {
        Log.LogInfo($"PostSetupMainController");
        
        
        // Debug.Log("Tags: " + string.Join("\n", SO.Settings.tags.Select(a => a.Name.ToEnumString() + ",")));
        // Debug.Log("Tags: " + string.Join("\n", SO.Settings.tags.Select(a => a.Name.ToEnumString() + ",\"" + a.Name + "\"")));
        WIKI.LogEnumForTypesCSScript(SO.Settings.buildingsTags, a=>a.Name, "BuildingTagTypes");
        
        RecipeManager.Instantiate();
        GoodsManager.Instantiate();
        EffectManager.Instantiate();
        TraderManager.Instantiate();
        OrdersManager.Instantiate();
        BiomeManager.Instantiate();
        TextMeshProManager.Instantiate();
        BuildingManager.Instantiate();
            
        // DumpPerksToJSON(MB.Settings.Relics, "Relics");
        // DumpPerksToJSON(MB.Settings.orders, "Orders");
        // DumpGoodsToJSON(MB.Settings.Goods, "Goods");
    }

        
    [HarmonyPatch(typeof(MainController), nameof(MainController.OnServicesReady))]
    [HarmonyPostfix]
    private static void HookMainControllerSetup()
    { 
        // This method will run after game load (Roughly on entering the main menu)
        // At this point a lot of the game's data will be available.
        // Your main entry point to access this data will be `Serviceable.Settings` or `MainController.Instance.Settings`
        Instance.Logger.LogInfo($"Performing game initialization on behalf of {PluginInfo.PLUGIN_GUID}.");
        Instance.Logger.LogInfo($"The game has loaded {MainController.Instance.Settings.effects.Length} effects.");

        // ExportWikiInformation();
    }

        
    [HarmonyPatch(typeof(MetaStateService), nameof(MetaStateService.CheckForInitialLevel))]
    [HarmonyPostfix]
    private static void MetaStateServiceSetup(MetaStateService __instance)
    { 
        // This method will run after game load (Roughly on entering the main menu)
        // At this point a lot of the game's data will be available.
        // Your main entry point to access this data will be `Serviceable.Settings` or `MainController.Instance.Settings`
        Instance.Logger.LogInfo($"MetaStateService.CheckForInitialLevel");

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

            // if (!GameMB.GameContentService.Buildings.Value.Contains(BuildingModel.BuildingModel))
            // {
            //     GameMB.GameContentService.Buildings.Value.Add(BuildingModel.BuildingModel);
            // }
        }
        
        
        // string b = string.Join(",", Serviceable.MetaStateService.Content.essentialBuildings.Select(a => a));
        // Log.LogInfo($"MetaStateService.essentialBuildings: {b}");
        //
        // string s = string.Join(",", Serviceable.Settings.Buildings.Select(a => a.name));
        // Log.LogInfo($"Settings.Buildings: {s}");
    }

    [HarmonyPatch(typeof(GameController), nameof(GameController.StartGame))]
    [HarmonyPostfix]
    private static void HookEveryGameStart()
    {
        // Too difficult to predict when GameController will exist and I can hook observers to it
        // So just use Harmony and save us all some time. This method will run after every game start
        var isNewGame = MB.GameSaveService.IsNewGame();
        Instance.Logger.LogInfo($"Entered a game. Is this a new game: {isNewGame}.");
        // TextMeshProManager.Instantiate();
        // WIKI.DumpEffectsJSON();
    }

    [HarmonyPatch(typeof(BuildingsSmallListTooltip), nameof(BuildingsSmallListTooltip.SetUpBuildingsSlots))]
    [HarmonyPostfix]
    private static void SetUpBuildingsSlots(BuildingsSmallListTooltip __instance)
    {
        Log.LogInfo($"BuildingsSmallListTooltip.SetUpBuildingsSlots.");
        
        string e = string.Join(",", Serviceable.MetaStateService.Content.essentialBuildings.Select(a => a));
        Log.LogInfo($"MetaStateService.essentialBuildings: {e}");
        
        string sb = string.Join(",", Serviceable.Settings.Buildings.Select(a => a.name));
        Log.LogInfo($"Settings.Buildings: {sb}");
        
        string b = string.Join(",", GameMB.GameContentService.Buildings.Value.Select(a => a.Name));
        Log.LogInfo($"GameContentService.Buildings: {b}");
        
        string s = string.Join(",", __instance.slots.Select(a => a.model != null ? a.model.name : "null"));
        Log.LogInfo($"Slots: {s}");
    }

    [HarmonyPatch(typeof(GameContentService), nameof(GameContentService.GetOptionalBuildings))]
    [HarmonyPostfix]
    private static void GetOptionalBuildings(GameContentService __instance, ref IEnumerable<BuildingModel> __result)
    {
        Log.LogInfo($"GameContentService.GetOptionalBuildings.");
        
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

    [HarmonyPatch(typeof(GameContentService), nameof(GameContentService.EnsureBuildings))]
    [HarmonyPostfix]
    private static void EnsureBuildings(GameContentService __instance)
    {
        Log.LogInfo($"GameContentService.GameContentServiceEnsureBuildings.");
        
        string b = string.Join(",", Serviceable.MetaStateService.Content.essentialBuildings.Select(a => a));
        Log.LogInfo($"essentialBuildings: {b}");
        
        string s = string.Join(",", Serviceable.Settings.Buildings.Select(a => a.name));
        Log.LogInfo($"Buildings: {s}");
    }
}