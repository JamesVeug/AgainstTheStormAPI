using System.Collections.Generic;
using System.Linq;
using ATS_API.Effects;
using Eremite;
using Eremite.Model;
using Eremite.Model.Configs;
using Eremite.WorldMap;

namespace ATS_API.Biomes;

public static partial class BiomeManager
{
    private class SeasonRewardLookup : Dictionary<SeasonsConfig, List<SeasonRewardModel>>;

    private static bool s_instantiated = false;

    internal static void Instantiate()
    {
        s_instantiated = true;

        SyncBiomes();
    }

    public static void SyncBiomes()
    {
        if (!s_instantiated)
        {
            return;
        }

        if (EffectManager.NewEffects.Count == 0)
        {
            return;
        }
        
        Plugin.Log.LogInfo($"Syncing biomes");
        foreach (BiomeModel biome in SO.Settings.biomes)
        {
            foreach (SeasonRewardModel seasonRewardModel in biome.seasons.SeasonRewards)
            {
                EffectsTableEntity[] baseEffects = seasonRewardModel.effectsTable.effects;
                List<EffectsTableEntity> seasonEffects = new List<EffectsTableEntity>(baseEffects);
                foreach (EffectManager.NewEffectData effectData in EffectManager.NewEffects)
                {
                    if (!effectData.IsCornerstone)
                    {
                        continue;
                    }
                    
                    if (effectData.Availability?.SeasonsAvailable == null ||
                        !effectData.Availability.SeasonsAvailable.Contains(seasonRewardModel.season))
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
                    Plugin.Log.LogInfo($"{biome.name}.{seasonRewardModel} rewards from {baseEffects.Length} to {seasonEffects.Count}");
                }
                else
                {
                    Plugin.Log.LogInfo($"{biome.name}.{seasonRewardModel} rewards unchanged");
                }
            }
        }
    }
}