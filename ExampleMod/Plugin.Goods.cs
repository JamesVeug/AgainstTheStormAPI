using ATS_API.Goods;
using ATS_API.Helpers;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private GoodsBuilder diamonds;
    private GoodsBuilder lpg;
    private GoodsBuilder kiwiFruit;
    private GoodsBuilder burger;
    private GoodsBuilder fries;
    private GoodsBuilder cola;
    
    private void CreateGoods()
    {
        diamonds = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Diamonds", "Diamonds.png");
        diamonds.SetDisplayName("Diamonds");
        diamonds.SetDisplayName("钻石", SystemLanguage.Chinese);
        diamonds.SetDescription("Shiny and worth a lot of money. but not strong enough to be used as Armor.");
        diamonds.SetDescription("闪闪发亮，值很多钱。但强度不足以用作盔甲.", SystemLanguage.Chinese);
        diamonds.SetCategory(GoodsCategoriesTypes.Trade_Goods);
        diamonds.SetTraderSellValue(40);
        diamonds.CanBeSoldToPlayer(3, 35);
        diamonds.CanBeSoldToAllTraders();
        diamonds.AddRelicKeepRewardChance(10, 4);
        diamonds.AddRelicKeepRewardChance(5, 2);
        
        lpg = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "LPG", "LPG.png");
        lpg.SetDisplayName("LPG");
        lpg.SetDisplayName("液化石油ガス", SystemLanguage.Japanese);
        lpg.SetDescription("A clean and efficient fuel. \n\n <b>Obtained in:</b> {0}");
        lpg.SetDescription("クリーンで効率的な燃料。\n\n <b>入手場所:</b> {0}", SystemLanguage.Japanese);
        lpg.SetShortDescription("A clean and efficient fuel.");
        lpg.SetShortDescription("クリーンで効率的な燃料。", SystemLanguage.Japanese);
        lpg.SetCategory(GoodsCategoriesTypes.Fuel);
        lpg.SetTraderSellValue(17f);
        lpg.CanBeSoldToPlayer(10, 29f);
        lpg.CanBeSoldToAllTraders();
        lpg.SetFuel(200f);
        
        kiwiFruit = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Kiwi Fruit", "KiwiFruit.png");
        kiwiFruit.SetDisplayName("Kiwi Fruit");
        kiwiFruit.SetDisplayName("Киви", SystemLanguage.Russian);
        kiwiFruit.SetDescriptionKey("Good_GenericRawFood_Desc"); // Common food source.\n \n <b>Obtained in:</b> {0}
        kiwiFruit.SetShortDescriptionKey("Good_GenericRawFood_Desc_Short"); // Common food source.,
        kiwiFruit.SetCategory(GoodsCategoriesTypes.Food);
        kiwiFruit.SetTraderSellValue(2.5f);
        kiwiFruit.CanBeSoldToPlayer(30, 5.0f);
        kiwiFruit.CanBeSoldToAllTraders();
        kiwiFruit.AddRelicKeepRewardChance(10, 4);
        kiwiFruit.AddRelicKeepRewardChance(5, 2);
        kiwiFruit.SetEatable(1);
        
        burger = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Borgor", "Burger.png");
        burger.SetDisplayName("Borgor");
        burger.SetDescription("Juicy and delicious. " +
                              "Liked by: {2}. Villagers with a satisfied need for Borgor have an increased chance of producing double yields." +
                              "\n\n<b>Produced in:</b> {0}");
        burger.SetCategory(GoodsCategoriesTypes.Food);
        burger.SetTraderSellValue(2.5f);
        burger.CanBeSoldToPlayer(30, 5.0f);
        burger.CanBeSoldToAllTraders();
        burger.SetEatable(3);
        
        fries = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Fries", "Fries.png");
        fries.SetDisplayName("Fries");
        fries.SetDescription("Hot and Crispy. " +
                             "Used for Fry Worship at: {1}, by {2}. Villagers with a satisfied need for Fry Worship have a higher chance of producing double yields." +
                             "\n\n<b>Produced in:</b> {0}");
        fries.SetCategory(GoodsCategoriesTypes.Consumable_Items);
        fries.SetTraderSellValue(0.5f);
        fries.CanBeSoldToPlayer(100, 1f);
        fries.CanBeSoldToAllTraders();
        
        cola = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Cola", "Cola.png");
        cola.SetDisplayName("Cola");
        cola.SetDescription("Refreshing and bubbly. " +
                            "Liked by: {2}. " +
                            "\n\n<b>Produced in:</b> {0}");
        cola.SetCategory(GoodsCategoriesTypes.Food);
        cola.SetTraderSellValue(0.5f);
        cola.CanBeSoldToPlayer(100, 1f);
        cola.CanBeSoldToAllTraders();
        cola.SetEatable(2);
    }
}