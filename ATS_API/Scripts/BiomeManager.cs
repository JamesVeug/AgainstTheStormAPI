using System.Collections.Generic;
using System.Linq;
using ATS_API.Effects;
using ATS_API.Helpers;
using ATS_API.Traders;
using Eremite;
using Eremite.Model;
using Eremite.Model.Configs;
using Eremite.WorldMap;

namespace ATS_API.Biomes;

public static partial class BiomeManager
{
    private class SeasonRewardLookup : Dictionary<SeasonsConfig, List<SeasonRewardModel>>;

    private static bool s_instantiated = false;
    private static bool s_dirty = false;

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
        if (EffectManager.NewEffects.Count == 0)
        {
            return;
        }
        
        Plugin.Log.LogInfo($"Syncing biomes");
        foreach (BiomeModel biome in SO.Settings.biomes)
        {
            SyncTrader(biome);
            foreach (SeasonRewardModel seasonRewardModel in biome.seasons.SeasonRewards)
            {
                SyncSeason(seasonRewardModel, biome);
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