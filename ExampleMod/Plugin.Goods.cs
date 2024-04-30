using ATS_API.Goods;

namespace ExampleMod;

public partial class Plugin
{
    private static void CreateGoods()
    {
        GoodsBuilder diamonds = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Diamonds", "Diamonds.png");
        diamonds.SetDisplayName("Diamonds");
        diamonds.SetDescription("Shiny and worth a lot of money. but not strong enough to be used as Armor.");
        diamonds.CanBeSoldToAllTraders(40);
        diamonds.CanBeSoldToPlayer(3, 35);
        diamonds.AddRelicKeepRewardChance(10, 4);
        diamonds.AddRelicKeepRewardChance(5, 2);
        
        GoodsBuilder lpg = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "LPG", "LPG.png");
        lpg.SetDisplayName("LPG");
        lpg.SetDescription("Liquefied Petroleum Gas, a clean and efficient fuel.");
        lpg.CanBeSoldToAllTraders(17f);
        lpg.CanBeSoldToPlayer(10, 29f);
        lpg.SetFuel(200f);
        
        GoodsBuilder kiwiFruit = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Kiwi Fruit", "KiwiFruit.png");
        kiwiFruit.SetDisplayName("Kiwi Fruit");
        kiwiFruit.SetDescription("Sour and sweet fruit that's great for a snack. Eat with a spoon.");
        kiwiFruit.CanBeSoldToAllTraders(2.5f);
        kiwiFruit.CanBeSoldToPlayer(30, 5.0f);
        kiwiFruit.AddRelicKeepRewardChance(10, 4);
        kiwiFruit.AddRelicKeepRewardChance(5, 2);
        kiwiFruit.SetEatable(1);
    }
}