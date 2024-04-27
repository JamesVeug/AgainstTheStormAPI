using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

namespace ATS_API.Goods;

public class GoodsBuilder
{
    private readonly string guid;
    private readonly string name;
    
    private readonly GoodsManager.NewGood newModel;

    public GoodsBuilder(string guid, string name, string iconImage)
    {
        this.guid = guid;
        this.name = name;
        newModel = GoodsManager.New(guid, name, iconImage);
        TextMeshProManager.Add(newModel.goodModel.icon.texture, newModel.goodModel.name);
    }

    public GoodsBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        newModel.goodModel.displayName = LocalizationManager.ToLocaText(guid, name, "displayName", text, language);
        return this;
    }

    public GoodsBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        newModel.goodModel.description = LocalizationManager.ToLocaText(guid, name, "description", description, language);
        if (newModel.goodModel.shortDescription == null)
        {
            newModel.goodModel.shortDescription = newModel.goodModel.description;
        }

        return this;
    }
    
    public GoodsBuilder SetShortDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        newModel.goodModel.shortDescription = LocalizationManager.ToLocaText(guid, name, "shortDescription", description, language);
        if (newModel.goodModel.description == null)
        {
            newModel.goodModel.description = newModel.goodModel.shortDescription;
        }

        return this;
    }

    public GoodsBuilder SetEatable(float fullnessValue)
    {
        newModel.goodModel.eatable = true;
        newModel.goodModel.eatingFullness = fullnessValue;
        return this;
    }

    public GoodsBuilder SetFuel(float burnTime)
    {
        newModel.goodModel.canBeBurned = true;
        newModel.goodModel.burningTime = burnTime;
        return this;
    }

    /// <summary>
    /// Method to set whether the goods can be sold to traders and the value at which they are sold.
    /// </summary>
    /// <param name="sellAmount">The rate at which the goods are sold to traders.</param>
    public void CanBeSoldToAllTraders(float sellAmount)
    {
        newModel.SoldToTrader = true;
        newModel.goodModel.tradingSellValue = sellAmount;
    }

    /// <summary>
    /// Method to set the details for selling goods by traders to players.
    /// </summary>
    /// <param name="amount">How many are offered to the player</param>
    /// <param name="tradingBuyValue">How much this costs to buy</param>
    /// <param name="weight">Chance which this item is offered to the player. (0 = never, 100 = always)</param>
    public void CanBeSoldToPlayer(int amount, float tradingBuyValue = 1.5f, int weight = 100)
    {
        newModel.SoldByTrader = new GoodsManager.NewGood.TraderDetails();
        newModel.SoldByTrader.Amount = amount;
        newModel.SoldByTrader.Weight = weight;
        newModel.goodModel.tradingBuyValue = tradingBuyValue;
    }

    /// <summary>
    /// When discovering a glade sometimes it has Caches that allow you to Keep or Send them back to the queen.
    /// If you choose Keep it gives you resources or Send will give you Reputation and less impatience
    /// This method allows you to set the chance of getting the goods and the amount of goods you get.
    /// Supports multiple chances and amounts (eg: 10% of 5x, 5% chance of 20x)
    /// </summary>
    /// <param name="chance">1-100 chance of this being selected</param>
    /// <param name="amount">How much will be rewarded if kept</param>
    public void AddRelicKeepRewardChance(int chance, int amount)
    {
        Assert.IsTrue(chance >= 1 && chance <= 100, "Relic Chance Chance must be between 1 and 100!");
        string effectName = name + "_RelicKeepEffect_" + (newModel.RelicRewards.Count + 1);
        var effect = CreateGoodEffect<GoodsEffectModel>(guid, effectName, newModel.goodModel, amount, out _);
        
        EffectsTableEntity tableEntity = new EffectsTableEntity();
        tableEntity.effect = effect;
        tableEntity.chance = chance;
        newModel.RelicRewards.Add(new GoodsManager.NewGood.RelicDetails()
        {
            RelicGoodEffect = tableEntity,
        });
        Plugin.Log.LogInfo($"Effect {effectName} created");
    }

    public static T CreateGoodEffect<T>(string guid, string name, GoodModel goodModel, int gainAmount, out EffectManager.NewEffectData effect) where T : GoodsEffectModel
    {
        effect = EffectManager.CreateEffect<T>(guid, name);
        GoodsEffectModel goodsEffectModel = (GoodsEffectModel)effect.EffectModel;
        goodsEffectModel.good = new GoodRef()
        {
            good = goodModel,
            amount = gainAmount
        };

        goodsEffectModel.displayName = goodModel.displayName; // Diamonds
        goodsEffectModel.description = LocalizationManager.ToLocaText("Reward_GoodsGeneric_Desc"); // 50 <icon> Diamonds
        goodsEffectModel.label = LocalizationManager.ToLabelModel("Label_Reward_Goods"); // Goods

        return (T)goodsEffectModel;
    }
}