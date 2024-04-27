using ATS_API.Goods;

namespace ExampleMod;

public partial class Plugin
{
    private static void CreateGoods()
    {
        GoodsBuilder builder = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Diamonds", "Diamonds.png");
        builder.SetDisplayName("Diamonds");
        builder.SetDescription("Shiny and worth a lot of money. but not strong enough to be used as Armor.");
        builder.CanBeSoldToAllTraders(40);
        builder.CanBeSoldToPlayer(10, 35);
        builder.AddRelicKeepRewardChance(10, 4);
        builder.AddRelicKeepRewardChance(5, 2);
    }
}