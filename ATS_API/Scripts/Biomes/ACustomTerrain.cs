
using System;
using ATS_API.Helpers;
using Eremite.Controller.Events;
using Eremite.WorldMap;
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
}

/// <summary>
/// Loads a custom terrain for the biome
/// The terrain uses a red/blue/green texture and blends textures over
/// </summary>
public class MaskedTerrain : ACustomTerrain
{
    public Texture2D terrainBlendTexture = null;
    public Texture2D waterTexture;
    
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
            Plugin.Log.LogError("Could not get TerrainPrefab from API bundle for the MaskedTerrain!" + Environment.StackTrace);
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
            Plugin.Log.LogInfo($"Setting terrainBaseTexture for {biomeModel.name}");
            material.SetTexture("_RedTexture", terrainBaseTexture);
            material.SetVector("_RedTextureUV", terrainBaseTextureUVSize);
        }
        
        if(terrainOverlayTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainOverlayTexture for {biomeModel.name}");
            material.SetTexture("_GreenTexture", terrainOverlayTexture);
            material.SetVector("_GreenTextureUV", terrainOverlayTextureUVSize);
        }
        
        if(terrainCliffsTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainCliffsTexture for {biomeModel.name}");
            material.SetTexture("_BlueTexture", terrainCliffsTexture);
            material.SetVector("_BlueTextureUV", terrainCliffsTextureUVSize);
        }
        
        if(terrainSeaBedTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainSeaBedTexture for {biomeModel.name}");
            material.SetTexture("_BottomTexture", terrainSeaBedTexture);
            material.SetVector("_BottomTexture2D", terrainSeaBedTextureUVSize);
        }
        
        if(terrainBlendTexture != null)
        {
            Plugin.Log.LogInfo($"Setting terrainBlendTexture for {biomeModel.name}");
            material.SetTexture("_BlendTexture", terrainBlendTexture);
        }
        
        if(waterTexture != null)
        {
            Plugin.Log.LogInfo($"Setting water texture for {biomeModel.name}");
            MeshRenderer meshRenderer = parent.SafeGetComponentInChildren<FloodController>(true).SafeGetComponent<MeshRenderer>();
            Material waterMaterial = new Material(meshRenderer.material);
            waterMaterial.SetTexture("Texture2D_10557134404e44b38e6556f3c2d3fddb", waterTexture);
            meshRenderer.material = waterMaterial;
        }
    }
}