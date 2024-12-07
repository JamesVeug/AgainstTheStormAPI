using System.Collections.Generic;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Controller.Events;
using Eremite.Controller.Generator;
using Eremite.View.Cameras;
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
        Plugin.Log.LogInfo("Instantiating original terrain!");
        await enumerator;

        
        // Destroy the terrain from the model and put in our own

        Plugin.Log.LogInfo("Getting biome lookup!");
        BiomeTypes biomeTypes = __instance.conditions.biomeName.ToBiomeTypes();
        if(!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            Plugin.Log.LogError($"{__instance.conditions.biomeName} is not a custom biome with type: {biomeTypes} with custom biomes: {NewBiomeLookup.Count}");
            foreach (KeyValuePair<BiomeTypes,NewBiome> pair in NewBiomeLookup)
            {
                Plugin.Log.LogInfo($"{pair.Key} - {pair.Value.biomeModel.name}");
            }
            return;
        }

        Plugin.Log.LogInfo("Instantiating terrain!");
        GameObject prefab = Plugin.ATS_API_TerrainBundle.LoadAsset<GameObject>("TerrainPrefab");
        if(prefab == null)
        {
            Plugin.Log.LogError("TerrainPrefab not found!");
            return;
        }
        
        Plugin.Log.LogInfo("Getting ActiveTerrain!");
        Terrain terrain = GameMB.GameBlackboardService.ActiveTerrain.Value;
        if(terrain == null)
        {
            Plugin.Log.LogError("Terrain not found!");
            return;
        }
        
        Plugin.Log.LogInfo("Setting up terrain prefab! " + prefab);
        GameObject instantiate = GameObject.Instantiate((GameObject)prefab);
        instantiate.transform.SetParent(terrain.transform.parent);
        instantiate.transform.localPosition = new Vector3(340f, 0, 168.5f);
        instantiate.transform.localScale = new Vector3(100, 100, 100);
        
        Material material = instantiate.SafeGetComponent<MeshRenderer>().material;
        if(newBiome.terrainBaseTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainBaseTexture for {newBiome.biomeModel.name}");
            material.SetTexture("_RedTexture", newBiome.terrainBaseTexture);
            material.SetVector("_RedTextureUV", newBiome.terrainBaseTextureUVSize);
        }
        
        if(newBiome.terrainOverlayTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainOverlayTexture for {newBiome.biomeModel.name}");
            material.SetTexture("_GreenTexture", newBiome.terrainOverlayTexture);
            material.SetVector("_GreenTextureUV", newBiome.terrainOverlayTextureUVSize);
        }
        
        if(newBiome.terrainCliffsTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainCliffsTexture for {newBiome.biomeModel.name}");
            material.SetTexture("_BlueTexture", newBiome.terrainCliffsTexture);
            material.SetVector("_BlueTextureUV", newBiome.terrainCliffsTextureUVSize);
        }
        
        if(newBiome.terrainSeaBedTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainSeaBedTexture for {newBiome.biomeModel.name}");
            material.SetTexture("_BottomTexture", newBiome.terrainSeaBedTexture);
            material.SetVector("_BottomTexture2D", newBiome.terrainSeaBedTextureUVSize);
        }
        
        if(newBiome.terrainBlendTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainBlendTexture for {newBiome.biomeModel.name}");
            material.SetTexture("_BlendTexture", newBiome.terrainBlendTexture);
        }
        
        if(newBiome.waterTexture != null)
        {
            Plugin.Log.LogInfo($"Setting water texture for {newBiome.biomeModel.name}");
            MeshRenderer meshRenderer = terrain.transform.parent.SafeGetComponentInChildren<FloodController>(true).SafeGetComponent<MeshRenderer>();
            Material waterMaterial = new Material(meshRenderer.material);
            waterMaterial.SetTexture("Texture2D_10557134404e44b38e6556f3c2d3fddb", newBiome.waterTexture);
            meshRenderer.material = waterMaterial;
        }
        
        GameObject.Destroy(terrain.gameObject);
        Plugin.Log.LogInfo("Custom terrain instantiated!");
    }
}