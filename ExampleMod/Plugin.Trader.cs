using ATS_API.Effects;
using ATS_API.Helpers;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateTrader()
    {
        TraderBuilder builder = new TraderBuilder(PluginInfo.PLUGIN_GUID, "Wild Bill", "TraderIcon.png", "TraderIconSmall.png");
        builder.SetDisplayName("Wild Bill");
        builder.SetDescription("He sells common western goods, and a small number of basic blueprints and perks. Trade carefully!");
        builder.SetDialogue("Howdy, partner! I'm Wild Bill, the best trader in the west. I've got everything you need, and more!");
        builder.SetAssaultData(3,5,0.5f,0.4f, true);
        builder.SetAmountOfGoods(15,20);
        builder.AddDefaultMerchandise();
        builder.AddDefaultDesiredGoods();
        builder.AddGuaranteedOfferedGoods((40, GoodsTypes.Amber));
        builder.AddOfferedGoods((2, GoodsTypes.AncientTablet, 50));
        builder.AddOfferedGoods((100, GoodsTypes.Wood, 100));
        builder.AddOfferedGoods((5, diamonds.Name, 100));
        builder.AddOfferedGoods((20, lpg.Name, 100));
        builder.AddOfferedGoods((50, kiwiFruit.Name, 100));
        builder.AddOfferedGoods((40, GoodsTypes.Meat, 100));
        builder.AddOfferedGoods((30, GoodsTypes.Eggs, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Stone, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Leather, 100));
        builder.AddOfferedGoods((40, GoodsTypes.CopperOre, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Mushrooms, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Resin, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Oil, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Coal, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Barrels, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Waterskin, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Grain, 100));
        builder.AddOfferedGoods((50, GoodsTypes.CrystalizedDew, 100));
        builder.AddOfferedGoods((50, GoodsTypes.CopperBar, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Biscuits, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Ale, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Wine, 100));
    }
}