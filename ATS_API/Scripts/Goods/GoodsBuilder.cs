using ATS_API.Effects;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

namespace ATS_API.Goods;

public class GoodsBuilder
{
    public string Name => newModel.goodModel.name; // myguid_itemName
    public NewGood NewGood => newModel;
    
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    
    private readonly NewGood newModel;

    public GoodsBuilder(GoodModel model)
    {
        newModel = NewGood.FromModel(model);
        name = newModel.rawName;
        guid = newModel.guid;
    }
    
    public GoodsBuilder(string guid, string name, string iconImage)
    {
        this.guid = guid;
        this.name = name;
        newModel = GoodsManager.New(guid, name, iconImage);
        newModel.Category = "Modded";
        newModel.goodModel.displayName = Placeholders.DisplayName;
        newModel.goodModel.description = Placeholders.Description;
        newModel.goodModel.shortDescription = Placeholders.Description;
    }
    
    public void SetIcon(string iconImage)
    {
        SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.GoodIcon));
    }

    public void SetIcon(Texture2D texture2D)
    {
        SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.GoodIcon));
    }
    
    public void SetIcon(Sprite sprite)
    {
        newModel.goodModel.icon = sprite;
        TextMeshProManager.Add(newModel.goodModel.icon.texture, newModel.goodModel.name);
    }

    public GoodsBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.goodModel.displayName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.DisplayName.key)
        {
            // Create a new key for this field
            return SetDisplayName(LocalizationManager.ToLocaText(guid, name, "displayName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }
    
    public GoodsBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }
    
    public GoodsBuilder SetDisplayName(LocaText text)
    {
        newModel.goodModel.displayName = text;
        return this;
    }

    public GoodsBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.goodModel.description.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Description.key)
        {
            // Create a new key for this field
            return SetDescriptionKey(LocalizationManager.ToLocaText(guid, name, "description", description, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }

    public GoodsBuilder SetDescriptionKey(LocaText locaText)
    {
        newModel.goodModel.description = locaText;
        if (newModel.goodModel.shortDescription == null || newModel.goodModel.shortDescription.key == Placeholders.Description.key)
        {
            newModel.goodModel.shortDescription = newModel.goodModel.description;
        }

        return this;
    }

    public GoodsBuilder SetDescriptionKey(string key)
    {
        return SetDescriptionKey(key.ToLocaText());
    }
    
    public GoodsBuilder SetShortDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.goodModel.shortDescription.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Description.key)
        {
            // Create a new key for this field
            return SetShortDescription(LocalizationManager.ToLocaText(guid, name, "shortDescription", description, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }
    
    public GoodsBuilder SetShortDescriptionKey(string key)
    {
        return SetShortDescription(key.ToLocaText());
    }
    
    public GoodsBuilder SetShortDescription(LocaText locaText)
    {
        newModel.goodModel.shortDescription = locaText;
        if (newModel.goodModel.description == null || newModel.goodModel.description.key == Placeholders.Description.key)
        {
            newModel.goodModel.description = newModel.goodModel.shortDescription;
        }

        return this;
    }
    
    /// <summary>
    /// Sets the category of the Good. Used for filtering when searching in the trends menu
    /// example: Food, Building Materials, Consumable Items, Crafting, Fuel, Others, Trade Goods
    /// Default is Modded.
    /// </summary>
    public GoodsBuilder SetCategory(string category)
    {
        newModel.Category = category;
        return this;
    }

    /// <summary>
    /// Meat = 1
    /// Jerky = 2
    /// Kebab = 3
    /// </summary>
    public GoodsBuilder SetEatable(float fullnessValue=1.0f)
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
    /// <param name="sellValue">The rate at which the goods are sold to traders.</param>
    public void SetTraderSellValue(float sellValue)
    {
        newModel.goodModel.tradingSellValue = sellValue;
    }

    public void CanBeSoldToAllTraders()
    {
        newModel.TraderDesiredAvailability ??= new TraderAvailability();
        newModel.TraderDesiredAvailability.SetAllTraders();
    }
    
    public void SetCanBeSoldToTrader(string traderName)
    {
        newModel.TraderDesiredAvailability ??= new TraderAvailability();
        newModel.TraderDesiredAvailability.AddTrader(traderName);
    }
    
    public void SetCanBeSoldToTrader(TraderTypes traderType)
    {
        newModel.TraderDesiredAvailability ??= new TraderAvailability();
        newModel.TraderDesiredAvailability.AddTrader(traderType.ToName());
    }
    

    /// <summary>
    /// Method to set the details for selling goods by traders to players.
    /// </summary>
    /// <param name="amount">How many are offered to the player</param>
    /// <param name="tradingBuyValue">How much this costs to buy</param>
    /// <param name="weight">Chance which this item is offered to the player. (0 = never, 100 = always)</param>
    public void CanBeSoldToPlayer(int amount, float tradingBuyValue = 1.5f, int weight = 100)
    {
        newModel.SoldByTraderDetails ??= new NewGood.GoodSoldByTraderDetails();
        newModel.SoldByTraderDetails.Amount = amount;
        newModel.SoldByTraderDetails.Weight = weight;
        newModel.goodModel.tradingBuyValue = tradingBuyValue;
    }

    /// <summary>
    /// Makes the Good available at all traders to be purchased by player.
    /// Use CanBeSoldToPlayer() to define amount, chance for it to be solve and how much it costs.
    /// </summary>
    public void SetSoldByAllTraders()
    {
        newModel.SoldByTraderDetails ??= new NewGood.GoodSoldByTraderDetails();
        newModel.SoldByTraderDetails.TraderAvailability.SetAllTraders();
    }
    
    /// <summary>
    /// Makes the Good available at a specific trader to be purchased by player.
    /// Use CanBeSoldToPlayer() to define amount, chance for it to be solve and how much it costs.
    /// </summary>
    public void AddTraderSellingGood(string traderName)
    {
        newModel.SoldByTraderDetails ??= new NewGood.GoodSoldByTraderDetails();
        newModel.SoldByTraderDetails.TraderAvailability.AddTrader(traderName);
    }
    
    /// <summary>
    /// Makes the Good available at a specific trader to be purchased by player.
    /// Use CanBeSoldToPlayer() to define amount, chance for it to be solve and how much it costs.
    /// </summary>
    public void AddTraderSellingGood(TraderTypes traderType)
    {
        newModel.SoldByTraderDetails ??= new NewGood.GoodSoldByTraderDetails();
        newModel.SoldByTraderDetails.TraderAvailability.AddTrader(traderType.ToName());
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
        newModel.RelicRewards.Add(new NewGood.RelicDetails()
        {
            RelicGoodEffect = tableEntity,
        });
        Plugin.Log.LogInfo($"Effect {effectName} created");
    }

    public static T CreateGoodEffect<T>(string guid, string name, GoodModel goodModel, int gainAmount, out NewEffectData effect) where T : GoodsEffectModel
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