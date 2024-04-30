using ATS_API.Goods;

namespace ExampleMod;

public partial class Plugin
{
    private GoodsBuilder diamonds;
    private GoodsBuilder lpg;
    private GoodsBuilder kiwiFruit;
    private void CreateGoods()
    {
        diamonds = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Diamonds", "Diamonds.png");
        diamonds.SetDisplayName("Diamonds");
        diamonds.SetDescription("Shiny and worth a lot of money. but not strong enough to be used as Armor.");
        diamonds.SetCategory("Trade Goods");
        diamonds.SetTraderSellValue(40);
        diamonds.CanBeSoldToPlayer(3, 35);
        diamonds.AddRelicKeepRewardChance(10, 4);
        diamonds.AddRelicKeepRewardChance(5, 2);
        
        lpg = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "LPG", "LPG.png");
        lpg.SetDisplayName("LPG");
        lpg.SetDescription("A clean and efficient fuel.");
        lpg.SetCategory("Fuel");
        lpg.SetTraderSellValue(17f);
        lpg.CanBeSoldToPlayer(10, 29f);
        lpg.SetFuel(200f);
        
        kiwiFruit = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Kiwi Fruit", "KiwiFruit.png");
        kiwiFruit.SetDisplayName("Kiwi Fruit");
        kiwiFruit.SetDescription("Sour and sweet fruit that's great for a snack. Eat with a spoon.");
        kiwiFruit.SetCategory("Food");
        kiwiFruit.SetTraderSellValue(2.5f);
        kiwiFruit.CanBeSoldToPlayer(30, 5.0f);
        kiwiFruit.AddRelicKeepRewardChance(10, 4);
        kiwiFruit.AddRelicKeepRewardChance(5, 2);
        kiwiFruit.SetEatable(1);
    }
}