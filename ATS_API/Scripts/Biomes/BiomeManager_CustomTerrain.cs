using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Controller.Generator;
using HarmonyLib;
using UnityEngine;

namespace ATS_API.Biomes;

[HarmonyPatch]
public static partial class BiomeManager
{
    [HarmonyPatch(typeof(MapGenerator), nameof(MapGenerator.SetTerrain))]
    [HarmonyPostfix]
    private static async UniTask InstantiateCustomTerrain(UniTask enumerator, MapGenerator __instance) 
    {
        // This creates the terrain for the entire map. 
        // Contains FX for seasons, terrain, water, strider path, fog... etc
        // NOTE: The API does not support creating your own mapData.terrain at this stage. Just the terrain itself
        await enumerator; // await mapData.terrain.InstantiateAsync();

        
        // Destroy the terrain from the model and put in our own
        BiomeTypes biomeTypes = __instance.conditions.biomeName.ToBiomeTypes();
        if (!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            // Plugin.Log.LogError($"{__instance.conditions.biomeName} is not a custom biome with type: {biomeTypes} with custom biomes: {NewBiomeLookup.Count}");
            return;
        }

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
            Plugin.Log.LogError("Terrain not found!");
            return;
        }
        
        // Create our custom terrain
        newBiome.ACustomTerrain.Generate(newBiome.biomeModel, terrain.transform.parent);
        
        // Destroy terrain from the biome
        GameObject.Destroy(terrain.gameObject);
        Plugin.Log.LogInfo("Custom terrain instantiated!");
    }
}