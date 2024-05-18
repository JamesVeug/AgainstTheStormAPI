using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

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
        
 
    private void Awake()
    {
        Instance = this; 
        Log = Logger;
        harmony = Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, PluginInfo.PLUGIN_GUID);

        PluginDirectory = Info.Location.Replace("API_ExampleMod.dll", "");

        CreateGoods();
        CreateCornerstones();
        CreateTrader();
        CreateBuildings();
        
        Log.LogInfo($"{PluginInfo.PLUGIN_NAME} v{PluginInfo.PLUGIN_VERSION} Plugin loaded");
    }
}