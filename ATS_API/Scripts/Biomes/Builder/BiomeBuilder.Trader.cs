using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public BiomeBuilder SetTraderForceArrivalCost(float amount, float multiplier = 2.0f)
    {
        newBiome.traderForceArrivalCost = amount;
        newBiome.traderForceArrivalCostMultiplier = multiplier;
        return this;
    }

    public BiomeBuilder SetTraderForceArrivalReputationPrompt(string text, SystemLanguage language = SystemLanguage.English)
    {
        newBiome.traderForceArrivalReputationPrompt =
            LocalizationManager.ToLocaText(guid, name, "forceArrivalRep", text, language);
        return this;
    }

    public BiomeBuilder SetTraderForceArrivalReputationPromptKey(string key)
    {
        newBiome.traderForceArrivalReputationPrompt = new LocaText() { key = key };
        return this;
    }

    public BiomeBuilder SetTraderVillagerKilledByTraderText(string text, SystemLanguage language = SystemLanguage.English)
    {
        newBiome.traderKillsVillagerText =
            LocalizationManager.ToLocaText(guid, name, "villageDeathReason", text, language);
        return this;
    }

    public BiomeBuilder SetTraderVillagerKilledByTraderTextKey(string key)
    {
        newBiome.traderKillsVillagerText = new LocaText() { key = key };
        return this;
    }

    public BiomeBuilder AddTraderWantedGood(GoodsTypes types)
    {
        newBiome.traderWantedGoods.Add(types);
        return this;
    }
}