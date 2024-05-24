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
        builder.AddGuaranteedOfferedGoods((40, GoodsTypes.Valuable_Amber));
        builder.AddOfferedGoods((2, GoodsTypes.Valuable_Ancient_Tablet, 50));
        builder.AddOfferedGoods((100, GoodsTypes.Mat_Raw_Wood, 100));
        builder.AddOfferedGoods((5, diamonds.Name, 100));
        builder.AddOfferedGoods((20, lpg.Name, 100));
        builder.AddOfferedGoods((50, kiwiFruit.Name, 100));
        builder.AddOfferedGoods((40, GoodsTypes.Food_Raw_Meat, 100));
        builder.AddOfferedGoods((30, GoodsTypes.Food_Raw_Eggs, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Mat_Raw_Stone, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Mat_Raw_Leather, 100));
        builder.AddOfferedGoods((40, GoodsTypes.Metal_Copper_Ore, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Food_Raw_Mushrooms, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Mat_Raw_Resin, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Crafting_Oil, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Crafting_Coal, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Vessel_Barrels, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Vessel_Waterskin, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Food_Raw_Grain, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Metal_Crystalized_Dew, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Metal_Copper_Bar, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Food_Processed_Biscuits, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Needs_Ale, 100));
        builder.AddOfferedGoods((50, GoodsTypes.Needs_Wine, 100));
    }
}