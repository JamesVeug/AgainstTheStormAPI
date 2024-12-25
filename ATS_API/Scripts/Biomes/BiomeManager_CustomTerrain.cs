using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Controller.Generator;
using Eremite.View.Cameras;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ATS_API.Biomes;

[HarmonyPatch]
public static partial class BiomeManager
{
    [HarmonyPatch(typeof(MapGenerator), nameof(MapGenerator.SetTerrain), typeof(MapData))]
    [HarmonyPrefix]
    private static bool InstantiateCustomTerrain(MapData mapData, MapGenerator __instance, ref UniTask __result)
    {
        // __result = UniTask.CompletedTask;
        // return true;
        // return;
        // This creates the terrain for the entire map. 
        // Contains FX for seasons, terrain, water, strider path, fog... etc
        // NOTE: The API does not support creating your own mapData.terrain at this stage. Just the terrain itself
        
        // Destroy the terrain from the model and put in our own
        BiomeTypes biomeTypes = __instance.conditions.biomeName.ToBiomeTypes();
        if (!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            // Logger.LogError($"{__instance.conditions.biomeName} is not a custom biome with type: {biomeTypes} with custom biomes: {NewBiomeLookup.Count}");
            // await enumerator; // await mapData.terrain.InstantiateAsync();
            return true;
        }

        
        __result = InstantiateCustomTerrainAsync(mapData, __instance, newBiome);
        return false;
    }

    private static async UniTask InstantiateCustomTerrainAsync(MapData mapData, MapGenerator __instance, NewBiome newBiome)
    {
        GameObject map = null;
        var async = mapData.terrain.InstantiateAsync();
        async.Completed += (asyncOperation) =>
        {
            APILogger.LogInfo("Terrain instantiated!");
            APILogger.LogInfo("Terrain: " + asyncOperation.Result);
            map = asyncOperation.Result;
            CreateCustomTerrain(newBiome);
            // ChangeRaindrops(newBiome, map);
        };
        await async;
    }

    private static void CreateCustomTerrain(NewBiome newBiome)
    {
        if (newBiome.ACustomTerrain == null)
        {
            // No custom terrain for this biome. Will use default
            return;
        }
        
        
        Terrain terrain = GameMB.GameBlackboardService.ActiveTerrain.Value;
        if(terrain == null)
        {
            // NOTE: Not all biomes have GameTerrain component on them which is where active terrain comes from.
            // Without it we can't find it... at this stage so at this point everything is broken
            APILogger.LogError("Terrain not found to create custom terrain!");
            return;
        }
        
        // Create our custom terrain
        newBiome.ACustomTerrain.Generate(newBiome.biomeModel, terrain.transform.parent);
        
        // Destroy terrain from the biome
        GameObject.Destroy(terrain.gameObject);
        APILogger.LogInfo("Custom terrain instantiated!");
    }
}