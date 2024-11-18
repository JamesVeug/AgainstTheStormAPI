using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ATS_API.Difficulties;
using ATS_API.Effects;
using ATS_API.Helpers;
using ATS_API.Traders;
using Eremite;
using Eremite.Model;
using Eremite.Model.Configs;
using Eremite.WorldMap;
using Eremite.WorldMap.Model;
using UnityEngine;

namespace ATS_API.Biomes;

public static partial class BiomeManager
{
    public static IReadOnlyList<NewBiome> NewBiomes => s_newBiomes;
    public static IReadOnlyDictionary<BiomeTypes, NewBiome> NewBiomeLookup => s_newBiomesLookup;
    
    private static List<NewBiome> s_newBiomes = new List<NewBiome>();
    private static Dictionary<BiomeTypes, NewBiome> s_newBiomesLookup = new Dictionary<BiomeTypes, NewBiome>();
    
    private static ArraySync<BiomeModel, NewBiome> s_biomes = new("New Biomes");

    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewBiome New(string guid, string name)
    {
        BiomeModel model = ScriptableObject.CreateInstance<BiomeModel>();
        

        NewBiome newBiome = Add(guid, name, model);
        return newBiome;
    }

    public static NewBiome Add(string guid, string name, BiomeModel model)
    {
        model.name = guid + "_" + name;
        
        BiomeTypes id = GUIDManager.Get<BiomeTypes>(guid, name);
        BiomeTypesExtensions.TypeToInternalName[id] = model.name;
        NewBiome newBiome = new NewBiome
        {
            biomeModel = model,
            id = id,
            guid = guid,
            rawName = name
        };
        s_newBiomes.Add(newBiome);
        s_newBiomesLookup.Add(id, newBiome);
        s_dirty = true;

        Plugin.Log.LogInfo($"Added {newBiome.rawName}!");
        return newBiome;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;

        SyncBiomes();
    }

    public static void Tick()
    {
        if (s_dirty)
        {
            SyncBiomes();
        }
    }

    public static void SetDirty()
    {
        s_dirty = true;
    }

    public static void SyncBiomes()
    {
        if (!s_instantiated)
        {
            return;
        }

        s_dirty = false;
        
        
        Plugin.Log.LogInfo($"Syncing {s_newBiomes.Count} new biomes");
        Settings settings = SO.Settings;
        List<NewBiome> biomes = s_biomes.Sync(ref settings.biomes, settings.biomesCache, s_newBiomes, a => a.biomeModel);

        if (biomes.Count > 0)
        {
            foreach (NewBiome newBiome in biomes)
            {
                var biomeGenerationRule = new BiomeGenerationRule
                {
                    biome = newBiome.biomeModel,
                    minDistanceFromCapital = 2,
                    horizontalDistribution = 0.25f,
                    verticalDistribution = 0.27f,
                    generationTreshold = 0.585f,

                };
                
                foreach (WorldSealModel seal in settings.worldSeals)
                {
                    if(seal.worldGenerationModel.biomesRules.All(a => a.biome != newBiome.biomeModel))
                    {
                        Plugin.Log.LogInfo($"Adding {newBiome.biomeModel.name} to {seal.worldGenerationModel.name}");
                        ArrayExtensions.AddElement(ref seal.worldGenerationModel.biomesRules, biomeGenerationRule);
                    }
                }


                WorldGenerationModel model = settings.worldConfig.generationModel;
                if(model.biomesRules.All(a => a.biome != newBiome.biomeModel))
                {
                    Plugin.Log.LogInfo($"Adding {newBiome.biomeModel.name} to {model.name}");
                    ArrayExtensions.AddElement(ref model.biomesRules, biomeGenerationRule);
                }
            }
        }


        if (EffectManager.NewEffects.Count > 0)
        {
            foreach (BiomeModel biome in settings.biomes)
            {
                SyncTrader(biome);
                foreach (SeasonRewardModel seasonRewardModel in biome.seasons.SeasonRewards)
                {
                    SyncSeason(seasonRewardModel, biome);
                }
            }
        }
    }

    private static void SyncTrader(BiomeModel biome)
    {
        foreach (CustomTrader customTrader in TraderManager.NewTraders)
        {
            string modelName = customTrader.TraderModel.name;
            bool alreadyAdded = biome.trade.ranges.Any(a => a.weights.Any(b => b.trader.name == modelName));
            if (alreadyAdded)
            {
                continue;
            }
            
            foreach (TradersRange range in biome.trade.ranges)
            {
                TraderChance traderWeight = new TraderChance
                {
                    trader = customTrader.TraderModel,
                    weight = 100
                };
                ArrayExtensions.AddElement(ref range.weights, traderWeight);
                Plugin.Log.LogInfo($"{biome.trade.name} added {modelName}!");
            }
        }
    }

    private static void SyncSeason(SeasonRewardModel seasonRewardModel, BiomeModel biome)
    {
        EffectsTableEntity[] baseEffects = seasonRewardModel.effectsTable.effects;
        List<EffectsTableEntity> seasonEffects = new List<EffectsTableEntity>(baseEffects);
        foreach (NewEffectData effectData in EffectManager.NewEffects)
        {
            if (!effectData.IsCornerstone)
            {
                continue;
            }
                    
            if (effectData.Availability?.SeasonsAvailable == null ||
                !effectData.Availability.SeasonsAvailable.ContainsSeason(seasonRewardModel.season))
            {
                continue;
            }

            if (seasonEffects.Any(a => a.effect == effectData.EffectModel))
            {
                continue;
            }
                    
            EffectsTableEntity newEffect = new EffectsTableEntity
            {
                effect = effectData.EffectModel,
                chance = effectData.Chance
            };
            seasonEffects.Add(newEffect);
        }

        if (baseEffects.Length != seasonEffects.Count)
        {
            seasonRewardModel.effectsTable.effects = seasonEffects.ToArray();
            // string allRewards = string.Join(", ", seasonEffects.Select(e => $"{e.effect.name} {e.chance}%"));
            // Plugin.Log.LogInfo($"{biome.name}.{seasonRewardModel} rewards from {baseEffects.Length} to {seasonEffects.Count}");
        }
    }
}