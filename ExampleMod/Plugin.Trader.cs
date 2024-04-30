using ATS_API.Effects;

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
        builder.SetDesiredGoods();
        builder.AddGuaranteedOfferedGoods((40, "[Valuable] Amber"));
        builder.AddOfferedGoods((2, "[Valuable] Ancient Tablet", 50));
        builder.AddOfferedGoods((100, "[Mat Raw] Wood", 100));
        builder.AddOfferedGoods((5, diamonds.Name, 100));
        builder.AddOfferedGoods((20, lpg.Name, 100));
        builder.AddOfferedGoods((50, kiwiFruit.Name, 100));
        builder.AddOfferedGoods((40, "[Food Raw] Meat", 100));
        builder.AddOfferedGoods((30, "[Food Raw] Eggs", 100));
        builder.AddOfferedGoods((50, "[Mat Raw] Stone", 100));
        builder.AddOfferedGoods((50, "[Mat Raw] Leather", 100));
        builder.AddOfferedGoods((40, "[Metal] Copper Ore", 100));
        builder.AddOfferedGoods((50, "[Food Raw] Mushrooms", 100));
        builder.AddOfferedGoods((50, "[Mat Raw] Resin", 100));
        builder.AddOfferedGoods((50, "[Crafting] Oil", 100));
        builder.AddOfferedGoods((50, "[Crafting] Coal", 100));
        builder.AddOfferedGoods((50, "[Vessel] Barrels", 100));
        builder.AddOfferedGoods((50, "[Vessel] Waterskin", 100));
        builder.AddOfferedGoods((50, "[Food Raw] Grain", 100));
        builder.AddOfferedGoods((50, "[Metal] Crystalized Dew", 100));
        builder.AddOfferedGoods((50, "[Metal] Copper Bar", 100));
        builder.AddOfferedGoods((50, "[Food Processed] Biscuits", 100));
        builder.AddOfferedGoods((50, "[Needs] Ale", 100));
        builder.AddOfferedGoods((50, "[Needs] Wine", 100));
    }
}