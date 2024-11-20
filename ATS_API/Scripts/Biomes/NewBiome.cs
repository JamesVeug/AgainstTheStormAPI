using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.NaturalResource;
using Eremite.Buildings;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.WorldMap;
using UnityEngine;

namespace ATS_API.Biomes;

public class NewBiome : ASyncable<BiomeModel>
{
    public class NaturalResourceData
    {
        public float horizontalTreshold = 0.2f;
        public float verticalTreshold = 0.2f;
        public float generationThreshold = 0f;
        public int minDistanceFromOrigin = 0;
        public NaturalResourceTypes resourceType;
    }

    public class InitialGood
    {
        public GoodsTypes goodType;
        public int amount;
    }
    
    public BiomeModel biomeModel;
    public BiomeTypes id;
    public string guid;
    public string rawName;

    public Texture2D worldMapTexture;
    public Texture2D terrainSeaBedTexture = Placeholders.BlackTexture;
    public Vector2 terrainSeaBedTextureUVSize = new Vector2(100, 100);
    public Texture2D terrainBlendTexture = null;
    public Texture2D terrainBaseTexture;
    public Vector2 terrainBaseTextureUVSize = new Vector2(100, 100);
    public Texture2D terrainOverlayTexture;
    public Vector2 terrainOverlayTextureUVSize = new Vector2(100, 100);
    public Texture2D terrainCliffsTexture;
    public Vector2 terrainCliffsTextureUVSize = new Vector2(100, 100);
    public Texture2D waterTexture;
    
    public MetaCurrencyTypes baseMetaCurrency = MetaCurrencyTypes.Food_Stockpiles;
    public int baseMetaCurrencyAmount = 2;
        
    public MetaCurrencyTypes nearbyMetaCurrency = MetaCurrencyTypes.Food_Stockpiles;
    public int nearbyMetaCurrencyAmount = 2;
    
    public BuildingTypes mainHearth = BuildingTypes.Small_Hearth;
    public BuildingTypes mainStorage = BuildingTypes.Main_Storage_not_buildable;
    
    public List<GoodsTypes> tradeRouteGoods = new List<GoodsTypes>();
    
    public List<EffectTypes> earlyEfects = new List<EffectTypes>();
    public List<EffectTypes> effects = new List<EffectTypes>();
    public List<OreTypes> ores = new List<OreTypes>();
    public List<InitialGood> initialGoods = new List<InitialGood>();
    public List<NaturalResourceData> naturalResources = new List<NaturalResourceData>();

    public override bool Sync()
    {
        base.Sync();
        
        BiomeModel templateModel = BiomeTypes.Royal_Woodlands.ToBiomeModel();
        if(biomeModel.material == null)
        {
            Plugin.Log.LogError($"Material is null for {biomeModel.name}");
            Material material = Material.Instantiate(templateModel.material);
            if(worldMapTexture != null)
            {
                Plugin.Log.LogInfo($"Setting worldMapTexture for {biomeModel.name}");
                material.SetTexture("Texture2D_17f52de1276c4a7ba20b64de1c1eddcd", worldMapTexture);
            }
            else
            {
                Plugin.Log.LogError($"worldMapTexture is null for {biomeModel.name}");
                material.SetTexture("Texture2D_17f52de1276c4a7ba20b64de1c1eddcd", null);
            }
            biomeModel.material = material;
        }
        else
        {
            Plugin.Log.LogError($"Material is NOT null for {biomeModel.name}");
        }
        
        if(biomeModel.fields == null)
        {
            biomeModel.fields = templateModel.fields;
        }
        
        if(biomeModel.maps == null)
        {
            // Add 1 map so we can apply changes to it when we instantiate it.
            // NOTE: Ideally we should have our own prefab of a map to randomize but this is a good start.
            biomeModel.maps = new MapData[]{templateModel.maps[1]};
        }
        
        if(biomeModel.Ore == null)
        {
            biomeModel.Ore = ores.Select(o => o.ToOreModel()).Where(a=>a != null).ToArray();
        }
        
        if(biomeModel.baseMetaCurrency == null)
        {
            biomeModel.baseMetaCurrency = new MetaCurrencyRef()
            {
                currency = baseMetaCurrency.ToMetaCurrencyModel(),
                amount = baseMetaCurrencyAmount
            };
        }
        
        if(biomeModel.nearbyMetaCurrency == null)
        {
            biomeModel.nearbyMetaCurrency = new MetaCurrencyRef()
            {
                currency = nearbyMetaCurrency.ToMetaCurrencyModel(),
                amount = nearbyMetaCurrencyAmount
            };
        }
        
        if(biomeModel.mainHearth == null)
        {
            BuildingModel biomeModelMainHearth = mainHearth.ToBuildingModel();
            if(biomeModelMainHearth is HearthModel hearthModel)
            {
                biomeModel.mainHearth = hearthModel;
            }
            else
            {
                biomeModel.mainHearth = templateModel.mainHearth;
                Plugin.Log.LogError($"Could not use {biomeModelMainHearth.name} as main hearth. Needs to be of type HearthModel");
            }
        }
        
        if(biomeModel.mainStorage == null)
        {
            BuildingModel biomeModelMainStorage = mainStorage.ToBuildingModel();
            if(biomeModelMainStorage is StorageModel storageModel)
            {
                biomeModel.mainStorage = storageModel;
            }
            else
            {
                biomeModel.mainStorage = templateModel.mainStorage;
                Plugin.Log.LogError($"Could not use {biomeModelMainStorage.name} as main storage. Needs to be of type StorageModel");
            }
        }
        
        if(biomeModel.wantedGoods == null)
        {
            if(tradeRouteGoods.Count > 0)
            {
                biomeModel.wantedGoods = tradeRouteGoods.Select(g => g.ToGoodModel()).Where(a=>a != null).ToArray();
            }
            else
            {
                biomeModel.wantedGoods = templateModel.wantedGoods.Copy();
            }
        }
        
        if(biomeModel.seasons == null)
        {
            biomeModel.seasons = templateModel.seasons.Copy();
        }
        
        if(biomeModel.newcomers == null)
        {
            biomeModel.newcomers = templateModel.newcomers.Copy();
        }
        
        if(biomeModel.music == null)
        {
            biomeModel.music = templateModel.music;
        }
        
        if(biomeModel.graphics == null)
        {
            biomeModel.graphics = templateModel.graphics;
        }
        
        if(biomeModel.trade == null)
        {
            biomeModel.trade = templateModel.trade;
        }
        
        if(biomeModel.difficulty == null)
        {
            biomeModel.difficulty = templateModel.difficulty.Copy();
        }
        
        if(biomeModel.hostility == null)
        {
            biomeModel.hostility = templateModel.hostility;
        }
        
        if(biomeModel.mapResources == null)
        {
            if(naturalResources != null)
            {
                NaturalResourcesContainer container = ScriptableObject.CreateInstance<NaturalResourcesContainer>();
                container.resourcesRules = naturalResources.Select(r => new NaturalResourceRule()
                {
                    horizontalDistribution = r.horizontalTreshold,
                    verticalDistribution = r.verticalTreshold,
                    generationTreshold = r.generationThreshold,
                    minDistanceFromOrigin = r.minDistanceFromOrigin,
                    resource = r.resourceType.ToNaturalResourceModel()
                }).ToArray();
                biomeModel.mapResources = container;
            }
            else
            {
                biomeModel.mapResources = templateModel.mapResources;
            }
        }
        
        if(biomeModel.gladesRewards == null)
        {
            biomeModel.gladesRewards = templateModel.gladesRewards.Copy();
        }
        
        if(biomeModel.gladesDeposits == null)
        {
            biomeModel.gladesDeposits = templateModel.gladesDeposits.Copy();
        }
        
        if(biomeModel.gladesSprings == null)
        {
            biomeModel.gladesSprings = templateModel.gladesSprings;
        }
        
        if(biomeModel.oreDeposits == null)
        {
            biomeModel.oreDeposits = templateModel.oreDeposits;
        }
        
        if(biomeModel.gladesBuildings == null)
        {
            biomeModel.gladesBuildings = templateModel.gladesBuildings;
        }
        
        if(biomeModel.gladesRelics == null)
        {
            biomeModel.gladesRelics = templateModel.gladesRelics;
        }
        
        if(biomeModel.landPatches == null)
        {
            biomeModel.landPatches = templateModel.landPatches;
        }
        
        if(biomeModel.earlyEffects == null)
        {
            biomeModel.earlyEffects = earlyEfects.Select(e => e.ToEffectModel()).Where(a=>a != null).ToArray();
        }
        
        if(biomeModel.effects == null)
        {
            biomeModel.effects = effects.Select(e => e.ToEffectModel()).Where(a=>a != null).ToArray();
        }
        
        if(biomeModel.initialGoods == null)
        {
            biomeModel.initialGoods = initialGoods.Select(a=>new GoodRef()
            {
                good = a.goodType.ToGoodModel(),
                amount = a.amount
            }).ToArray();
        }
        
        if(biomeModel.corsairDrizzleProfiles == null)
        {
            biomeModel.corsairDrizzleProfiles = templateModel.corsairDrizzleProfiles;
        }
        
        if(biomeModel.corsairClearanceProfiles == null)
        {
            biomeModel.corsairClearanceProfiles = templateModel.corsairClearanceProfiles;
        }
        
        if(biomeModel.corsairStormProfiles == null)
        {
            biomeModel.corsairStormProfiles = templateModel.corsairStormProfiles;
        }

        return true;
    }
}