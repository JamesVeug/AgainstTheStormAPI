using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.WorldMap;
using UnityEngine;

namespace ATS_API.Biomes;

public class NewBiome : ASyncable<BiomeModel>
{
    public BiomeModel biomeModel;
    public BiomeTypes id;
    public string guid;
    public string rawName;

    public Texture2D worldMapTexture;
    
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
    public List<GoodRef> initialGoods = new List<GoodRef>();

    public override void PostSync()
    {
        base.PostSync();
        
        BiomeModel templateModel = BiomeTypes.Cursed_Royal_Woodlands.ToBiomeModel();
        if(biomeModel.material == null)
        {
            biomeModel.material = Material.Instantiate(templateModel.material);
            if(worldMapTexture != null)
            {
                biomeModel.material.mainTexture = worldMapTexture;
            }
            else
            {
                biomeModel.material.mainTexture = null;
            }
        }
        
        if(biomeModel.fields == null)
        {
            biomeModel.fields = templateModel.fields;
        }
        
        if(biomeModel.maps == null)
        {
            biomeModel.maps = templateModel.maps;
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
            biomeModel.mapResources = templateModel.mapResources;
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
            biomeModel.initialGoods = initialGoods.ToArray();
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
    }
}