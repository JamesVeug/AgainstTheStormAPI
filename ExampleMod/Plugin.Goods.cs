using ATS_API.Goods;
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
        diamonds.SetCategory("Trade Goods");
        diamonds.SetTraderSellValue(40);
        diamonds.CanBeSoldToPlayer(3, 35);
        diamonds.CanBeSoldToAllTraders();
        diamonds.AddRelicKeepRewardChance(10, 4);
        diamonds.AddRelicKeepRewardChance(5, 2);
        
        lpg = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "LPG", "LPG.png");
        lpg.SetDisplayName("LPG");
        lpg.SetDisplayName("液化石油ガス", SystemLanguage.Japanese);
        lpg.SetDescription("A clean and efficient fuel.");
        lpg.SetDescription("クリーンで効率的な燃料。", SystemLanguage.Japanese);
        lpg.SetCategory("Fuel");
        lpg.SetTraderSellValue(17f);
        lpg.CanBeSoldToPlayer(10, 29f);
        lpg.CanBeSoldToAllTraders();
        lpg.SetFuel(200f);
        
        kiwiFruit = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Kiwi Fruit", "KiwiFruit.png");
        kiwiFruit.SetDisplayName("Kiwi Fruit");
        kiwiFruit.SetDisplayName("Киви", SystemLanguage.Russian);
        kiwiFruit.SetDescription("Sour and sweet fruit that's great for a snack. Eat with a spoon.");
        kiwiFruit.SetDescription("Кислые и сладкие фрукты, которые отлично подходят для перекуса. Ешьте ложкой.", SystemLanguage.Russian);
        kiwiFruit.SetCategory("Food");
        kiwiFruit.SetTraderSellValue(2.5f);
        kiwiFruit.CanBeSoldToPlayer(30, 5.0f);
        kiwiFruit.CanBeSoldToAllTraders();
        kiwiFruit.AddRelicKeepRewardChance(10, 4);
        kiwiFruit.AddRelicKeepRewardChance(5, 2);
        kiwiFruit.SetEatable(1);
        
        burger = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Borgor", "Burger.png");
        burger.SetDisplayName("Borgor");
        burger.SetDescription("Juicy and delicious.");
        burger.SetCategory("Food");
        burger.SetTraderSellValue(2.5f);
        burger.CanBeSoldToPlayer(30, 5.0f);
        burger.CanBeSoldToAllTraders();
        burger.SetEatable(3);
        
        fries = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Fries", "Fries.png");
        fries.SetDisplayName("Fries");
        fries.SetDescription("Hot and Crispy.");
        fries.SetCategory("Food");
        fries.SetTraderSellValue(0.5f);
        fries.CanBeSoldToPlayer(100, 1f);
        fries.CanBeSoldToAllTraders();
        fries.SetEatable(1);
        
        cola = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Cola", "Cola.png");
        cola.SetDisplayName("Cola");
        cola.SetDescription("Refreshing and bubbly.");
        cola.SetCategory("Food");
        cola.SetTraderSellValue(0.5f);
        cola.CanBeSoldToPlayer(100, 1f);
        cola.CanBeSoldToAllTraders();
        cola.SetEatable(2);
    }
}