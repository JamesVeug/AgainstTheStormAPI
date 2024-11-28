using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.NaturalResource;
using Eremite.Buildings;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.Model.Configs;
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

    public class GoodsTypeAmount
    {
        public GoodsTypes goodType;
        public int amount;
    }
    
    public class WeightedEffectType
    {
        public EffectTypes effectType;
        public float weight; // 1 - 100
    }

    public class SeasonData
    {
        public SeasonTypes season;
        public int duration;
    }

    public class WeightedRace
    {
        public RaceTypes race;
        public float chance;  // 0 - 100
    }
    
    public class SeasonRewards
    {
        public int Year;
        public SeasonQuarter Quarter;
        public Season Season;
        
        public Vector2Int Amounts = new Vector2Int(2, 2);
        public List<EffectTypes> GuaranteedEffects = new List<EffectTypes>();
        public List<WeightedEffectType> Effects = new List<WeightedEffectType>();
    }

    public class StormFX
    {
        public Texture2D Raindrop1Texture;
        public Texture2D Raindrop2Texture;
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
    
    public StormFX stormFX = new StormFX();
    
    public MetaCurrencyTypes baseMetaCurrency = MetaCurrencyTypes.Food_Stockpiles;
    public int baseMetaCurrencyAmount = 2;
        
    public MetaCurrencyTypes nearbyMetaCurrency = MetaCurrencyTypes.Food_Stockpiles;
    public int nearbyMetaCurrencyAmount = 2;
    
    public BuildingTypes mainHearth = BuildingTypes.Small_Hearth;
    public BuildingTypes mainStorage = BuildingTypes.Main_Storage_not_buildable;
    
    public List<GoodsTypes> tradeRouteGoods = new List<GoodsTypes>();
    
    public List<EffectTypes> effects = new List<EffectTypes>();
    public List<OreTypes> ores = new List<OreTypes>();
    public List<GoodsTypeAmount> initialGoods = new List<GoodsTypeAmount>();
    public List<NaturalResourceData> naturalResources = new List<NaturalResourceData>();
    
    // Season Config
    public List<SeasonData> seasonData = new List<SeasonData>();
    public GoodsTypeAmount declineSeasonRewardsReward = new GoodsTypeAmount();
    public List<SeasonRewards> seasonRewards = new List<SeasonRewards>();
    public List<SimpleSeasonalEffectTypes> simpleStaticEffects = new List<SimpleSeasonalEffectTypes>();
    public List<SimpleSeasonalEffectTypes> simpleEffects = new List<SimpleSeasonalEffectTypes>();
    
    // newcomers Config
    public int newcomersInterval = 600;
    public Vector2Int newcomersBaseAmount = new Vector2Int(1, 2);
    public Vector2 newcomersExtraAmount = new Vector2(0.51f, 0.96f);
    public Vector2Int newcomerAmountOfGoods = new Vector2Int(1, 3);
    public List<WeightedRace> newcomersRaces = new List<WeightedRace>();
    // public bool newcomersIncludeCustomRaces = true;
    public List<GoodsTypeAmount> newcomersGoodsAmount = new List<GoodsTypeAmount>();
    
    // Trade Config
    public float traderForceArrivalCost = 0.5f;
    public float traderForceArrivalCostMultiplier = 2.0f;
    public LocaText traderForceArrivalReputationPrompt = null;
    public LocaText traderKillsVillagerText = null;
    public List<GoodsTypes> traderWantedGoods = new List<GoodsTypes>();


    public NewBiome()
    {
        seasonData.Add(new SeasonData()
        {
            season = SeasonTypes.Storm,
            duration = 120
        });
        seasonData.Add(new SeasonData()
        {
            season = SeasonTypes.Clearance,
            duration = 240
        });
        seasonData.Add(new SeasonData()
        {
            season = SeasonTypes.Drizzle,
            duration = 240
        });
        
        declineSeasonRewardsReward.goodType = GoodsTypes.Mat_Raw_Wood;
        declineSeasonRewardsReward.amount = 1;
    }

    public override bool Sync()
    {
        base.Sync();
        
        BiomeModel templateModel = BiomeTypes.Royal_Woodlands.ToBiomeModel();
        if(biomeModel.material == null)
        {
            Material material = Material.Instantiate(templateModel.material);
            if(worldMapTexture != null)
            {
                material.SetTexture("Texture2D_17f52de1276c4a7ba20b64de1c1eddcd", worldMapTexture);
            }
            else
            {
                material.SetTexture("Texture2D_17f52de1276c4a7ba20b64de1c1eddcd", null);
            }
            biomeModel.material = material;
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
            }
        }
        
        if(biomeModel.seasons == null)
        {
            SeasonsConfig config = templateModel.seasons.Copy();
            biomeModel.seasons = config;
            
            config.ClearanceTime = seasonData.FirstOrDefault(s => s.season == SeasonTypes.Clearance)?.duration ?? config.ClearanceTime;
            config.DrizzleTime = seasonData.FirstOrDefault(s => s.season == SeasonTypes.Drizzle)?.duration ?? config.DrizzleTime;
            config.StormTime = seasonData.FirstOrDefault(s => s.season == SeasonTypes.Storm)?.duration ?? config.StormTime;

            config.seasonRewardsDeclineGood = new GoodRef()
            {
                good = declineSeasonRewardsReward.goodType.ToGoodModel(),
                amount = declineSeasonRewardsReward.amount
            };
            
            BuildSeasonRewards(config, templateModel);
            BuildSimpleStaticRewards(config, templateModel);
        }
        
        if(biomeModel.newcomers == null)
        {
            biomeModel.newcomers = ScriptableObject.CreateInstance<NewcomersConfig>();
            biomeModel.newcomers.newComersInterval = newcomersInterval;
            biomeModel.newcomers.baseAmount = newcomersBaseAmount;
            biomeModel.newcomers.amountPerYear = newcomersExtraAmount;
            biomeModel.newcomers.goodsAmount = newcomerAmountOfGoods;
            if (newcomersRaces.Count > 0)
            {
                biomeModel.newcomers.races = newcomersRaces.Select(r => new RaceChance()
                {
                    weight = (int)Mathf.Clamp(r.chance, 0, 100),
                    race = r.race.ToRaceModel()

                }).Where(a=>a.race != null).ToArray();
            }
            else
            {
                biomeModel.newcomers.races = templateModel.newcomers.races.Copy();
            }
            
            if (newcomersGoodsAmount.Count > 0)
            {
                biomeModel.newcomers.goodsPerVillagers = newcomersGoodsAmount.Select(g => new GoodRef()
                {
                    good = g.goodType.ToGoodModel(),
                    amount = g.amount
                }).ToArray();
            }
            else
            {
                biomeModel.newcomers.goodsPerVillagers = templateModel.newcomers.goodsPerVillagers.Copy();
            }
        }
        
        if(biomeModel.music == null)
        {
            biomeModel.music = templateModel.music;
        }
        
        if(biomeModel.graphics == null)
        {
            biomeModel.graphics = templateModel.graphics;
        }
        
        if(biomeModel.wantedGoods == null)
        {
            if(traderWantedGoods.Count > 0)
            {
                biomeModel.wantedGoods = traderWantedGoods.ToGoodModelArrayNoNulls();
            }
            else
            {
                biomeModel.wantedGoods = templateModel.wantedGoods.Copy();
            }
        }
        
        if(biomeModel.trade == null)
        {
            biomeModel.trade = ScriptableObject.CreateInstance<TradeConfig>();
            biomeModel.trade.forceCost = traderForceArrivalCost;
            biomeModel.trade.forceCostMultiplayer = traderForceArrivalCostMultiplier;
            biomeModel.trade.villagerDeathReason = traderKillsVillagerText ?? templateModel.trade.villagerDeathReason;
            biomeModel.trade.forceArrivalReputationPrompt = traderForceArrivalReputationPrompt ?? templateModel.trade.forceArrivalReputationPrompt;
            biomeModel.trade.forceArrivalProgress = templateModel.trade.forceArrivalProgress;
            biomeModel.trade.ranges = templateModel.trade.ranges.Copy();
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
        
        if(biomeModel.effects == null)
        {
            biomeModel.effects = effects.ToEffectModelArrayNoNulls();
        }
        
        if(biomeModel.initialGoods == null)
        {
            biomeModel.initialGoods = initialGoods.Select(a=>new Eremite.Model.GoodRef()
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

    private void BuildSeasonRewards(SeasonsConfig config, BiomeModel template)
    {
        if (seasonRewards.Count == 0)
        {
            // Just keep the rewards from the template season
            config.SeasonRewards = template.seasons.SeasonRewards.Copy();
            return;
        }
        
        // Core game usually has 10 different years
        // Each year has its own set of rewards except 5+ which use the same set of rewards
        // Each year has 4 quarters but core game only uses Quarter.First except the first year which is Quarter.Second
        // Each quarter has 3 seasons but core game only uses Drizzle
        
        List<SeasonRewardModel> yearlyRewards = new List<SeasonRewardModel>();
        foreach (int year in seasonRewards.Select(a=>a.Year).Distinct().OrderBy(a=>a))
        {
            foreach (SeasonQuarter quarter in seasonRewards.Where(a=>a.Year == year).Select(a=>a.Quarter).Distinct().OrderBy(a=>a))
            {
                foreach (SeasonRewards season in seasonRewards.Where(a=>a.Year == year && a.Quarter == quarter).Distinct().OrderBy(a=>a.Season))
                {
                    EffectsTable effectsTable = ScriptableObject.CreateInstance<EffectsTable>();
                    effectsTable.amounts = season.Amounts;
                    effectsTable.guaranteedEffects = season.GuaranteedEffects.ToEffectModelArrayNoNulls();
                    effectsTable.effects = season.Effects.Select(a=>new EffectsTableEntity()
                    {
                        effect = a.effectType.ToEffectModel(),
                        chance = (int)Mathf.Clamp(a.weight, 1, 100)
                    }).Where(a=>a.effect != null).ToArray();
                    
                    SeasonRewardModel seasonConfig = new SeasonRewardModel()
                    {
                        year = year,
                        season = season.Season,
                        quarter = quarter,
                        effectsTable = effectsTable
                    };
                    yearlyRewards.Add(seasonConfig);
                }
            }
        }
        
        config.SeasonRewards = yearlyRewards;
    }
    
    private void BuildSimpleStaticRewards(SeasonsConfig config, BiomeModel template)
    {
        if (simpleStaticEffects.Count == 0)
        {
            // Just keep the rewards from the template season
            config.simpleEffects = template.seasons.simpleStaticEffects.Copy();
            return;
        }
        
        config.simpleEffects = simpleStaticEffects.ToSimpleSeasonalEffectModelArrayNoNulls();
    }
    
    private void BuildSimpleEffects(SeasonsConfig config, BiomeModel template)
    {
        if (simpleEffects.Count == 0)
        {
            // Just keep the rewards from the template season
            config.simpleEffects = template.seasons.simpleEffects.Copy();
            return;
        }
        
        config.simpleEffects = simpleEffects.ToSimpleSeasonalEffectModelArrayNoNulls();
    }
}