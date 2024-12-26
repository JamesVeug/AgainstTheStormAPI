using System;
using ATS_API.Helpers;
using Eremite.Controller.Events;
using Eremite.Services;
using Eremite.View.Cameras;
using Eremite.WorldMap;
using HarmonyLib;
using UnityEngine;

namespace ATS_API.Biomes;

/// <summary>
/// Base class for custom Biomes to create their own terrain and texture it how they need
/// </summary>
public abstract class ACustomTerrain
{
    public readonly string GUID;
    public readonly string Name;

    public ACustomTerrain(string guid, string name)
    {
        GUID = guid;
        Name = name;
    }

    public abstract void Generate(BiomeModel biomeModel, Transform parent);

    public virtual Material GetFogMaterial(Material gladesFog)
    {
        return gladesFog;
    }
}

/// <summary>
/// Loads a custom terrain for the biome
/// The terrain uses a red/blue/green texture and blends textures over
/// </summary>
[HarmonyPatch]
public class MaskedTerrain : ACustomTerrain
{
    public Texture2D terrainBlendTexture = null;
    
    public Texture2D waterTexture;
    public Vector2? texture1Speed;
    public Vector2? texture2Speed;
    public float? noiseSpeed;
    public float? rippleSpeed;
    private bool dirtyWater;
    
    public Texture2D fogBottomTexture;
    public Texture2D fogTopTexture;
    
    public Texture2D terrainSeaBedTexture = Placeholders.BlackTexture;
    public Vector2 terrainSeaBedTextureUVSize = new Vector2(100, 100);
    
    public Texture2D terrainBaseTexture; // Red
    public Vector2 terrainBaseTextureUVSize = new Vector2(100, 100);
    
    public Texture2D terrainOverlayTexture; // Green
    public Vector2 terrainOverlayTextureUVSize = new Vector2(100, 100);
    
    public Texture2D terrainCliffsTexture; // Blue
    public Vector2 terrainCliffsTextureUVSize = new Vector2(100, 100);


    public GameObject prefab = null;

    public MaskedTerrain(string guid, string name) : base(guid, name)
    {
        prefab = Plugin.ATS_API_TerrainBundle.LoadAsset<GameObject>("TerrainPrefab");
        if(prefab == null)
        {
            APILogger.LogError("Could not get TerrainPrefab from API bundle for the MaskedTerrain!");
        }
    }

    public void SetTerrainSeabedTexture(string seabedTexture, int uvWidth = 100, int uvHeight = 100)
    {
        terrainSeaBedTexture = TextureHelper.GetImageAsTexture(seabedTexture);
        terrainSeaBedTexture.wrapMode = TextureWrapMode.Repeat;
        terrainSeaBedTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainBlendTexture(string blendTexture)
    {
        terrainBlendTexture = TextureHelper.GetImageAsTexture(blendTexture);
    }
    
    public void SetTerrainBaseTexture(string baseTexture, int uvWidth = 100, int uvHeight = 100)
    {
        terrainBaseTexture = TextureHelper.GetImageAsTexture(baseTexture);
        terrainBaseTexture.wrapMode = TextureWrapMode.Repeat;
        terrainBaseTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainOverlayTexture(string overlayTexture, int uvWidth = 100, int uvHeight = 100)
    {
        terrainOverlayTexture = TextureHelper.GetImageAsTexture(overlayTexture);
        terrainOverlayTexture.wrapMode = TextureWrapMode.Repeat;
        terrainOverlayTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetTerrainCliffTexture(string cliffsTexture, int uvWidth = 100, int uvHeight = 100)
    {
        terrainCliffsTexture = TextureHelper.GetImageAsTexture(cliffsTexture);
        terrainCliffsTexture.wrapMode = TextureWrapMode.Repeat;
        terrainCliffsTextureUVSize = new Vector2(uvWidth, uvHeight);
    }
    
    public void SetWaterTexture(string waterTexturePath)
    {
        waterTexture = TextureHelper.GetImageAsTexture(waterTexturePath);
        dirtyWater = true;
    }

    public void SetWaterSpeed(Vector2? texture1Speed=null, Vector2? texture2Speed=null, float? noiseSpeed=null, float? rippleSpeed=null)
    {
        this.texture1Speed = texture1Speed; 
        this.texture2Speed = texture2Speed; 
        this.noiseSpeed = noiseSpeed; 
        this.rippleSpeed = rippleSpeed;
        dirtyWater = true;
    }
    
    public void SetFogTexture(string bottomTexture, string topTexture)
    {
        fogBottomTexture = TextureHelper.GetImageAsTexture(bottomTexture);
        fogTopTexture = TextureHelper.GetImageAsTexture(topTexture);
    }
    
    public override void Generate(BiomeModel biomeModel, Transform parent)
    {
        GameObject instantiate = GameObject.Instantiate((GameObject)prefab);
        instantiate.transform.SetParent(parent);
        instantiate.transform.localPosition = new Vector3(340f, 0, 168.5f);
        instantiate.transform.localScale = new Vector3(100, 100, 100);
        
        Material material = instantiate.SafeGetComponent<MeshRenderer>().material;
        if(terrainBaseTexture != null)
        {
            material.SetTexture("_RedTexture", terrainBaseTexture);
            material.SetVector("_RedTextureUV", terrainBaseTextureUVSize);
        }
        
        if(terrainOverlayTexture != null)
        {
            material.SetTexture("_GreenTexture", terrainOverlayTexture);
            material.SetVector("_GreenTextureUV", terrainOverlayTextureUVSize);
        }
        
        if(terrainCliffsTexture != null)
        {
            material.SetTexture("_BlueTexture", terrainCliffsTexture);
            material.SetVector("_BlueTextureUV", terrainCliffsTextureUVSize);
        }
        
        if(terrainSeaBedTexture != null)
        {
            material.SetTexture("_BottomTexture", terrainSeaBedTexture);
            material.SetVector("_BottomTexture2D", terrainSeaBedTextureUVSize);
        }
        
        if(terrainBlendTexture != null)
        {
            material.SetTexture("_BlendTexture", terrainBlendTexture);
        }
        
        if(dirtyWater)
        {
            MeshRenderer meshRenderer = parent.SafeGetComponentInChildren<FloodController>(true).SafeGetComponent<MeshRenderer>();
            Material waterMaterial = new Material(meshRenderer.material);
            if (waterTexture != null)
            {
                waterMaterial.SetTexture("Texture2D_10557134404e44b38e6556f3c2d3fddb", waterTexture);
            }
            if (texture1Speed.HasValue)
            {
                waterMaterial.SetVector("Vector2_5f98e6e881f34829ae95d4c7a44671b9", texture1Speed.Value);
            }
            if (texture2Speed.HasValue)
            {
                waterMaterial.SetVector("Vector2_1", texture2Speed.Value);
            }
            if (noiseSpeed.HasValue)
            {
                waterMaterial.SetFloat("Vector1_df789418b15a49fca75f3a1795d5a046", noiseSpeed.Value);
            }
            if (rippleSpeed.HasValue)
            {
                waterMaterial.SetFloat("Vector1_3c3c63c5b95743d0bdcd385c02edb973", rippleSpeed.Value);
            }

            meshRenderer.material = waterMaterial;
        }
    }

    public override Material GetFogMaterial(Material gladesFog)
    {
        if (fogTopTexture == null && fogBottomTexture == null)
        {
            return gladesFog;
        }
        
        Material newFogMaterial = new Material(gladesFog);
        newFogMaterial.SetTexture("_Fog_Texture", fogBottomTexture == null ? gladesFog.GetTexture("_Fog_Texture") : fogBottomTexture);
        // newFogMaterial.SetTexture("_MainTex", fogTopTexture == null ? gladesFog.GetTexture("_MainTex") : fogTopTexture);
        return newFogMaterial;
    }

    [HarmonyPatch(typeof(FogAnimator), nameof(FogAnimator.CreateMaterials))]
    [HarmonyPostfix]
    private static void Test(FogAnimator __instance)
    {
        BiomeTypes biomeTypes = Serviceable.StateService.Conditions.biomeName.ToBiomeTypes();
        if (!BiomeManager.NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            return;
        }
        
        if (newBiome.ACustomTerrain == null)
        {
            return;
        }

        __instance.gladesFog = newBiome.ACustomTerrain.GetFogMaterial(__instance.gladesFog);
    }
}