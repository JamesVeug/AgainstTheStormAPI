using ATS_API.Effects;

namespace ExampleMod;

public partial class Plugin
{
    private static void CreateTrader()
    {
        TraderBuilder builder = new TraderBuilder(PluginInfo.PLUGIN_GUID, "ExampleTrader", "TraderIcon.png", "TraderIconSmall.png");
        builder.SetDisplayName("Example Trader");
        builder.SetDescription("This is an example trader.");
        builder.SetDialogue("Hello, I am an example trader.");
        builder.SetStayingTime(10);
        builder.SetArrivalTime(10);
        builder.SetAssaultData(3,5,0.5f,0.4f, true);
        builder.AddGuaranteedOfferedGoods((2, "[Valuable] Ancient Tablet"));
        builder.AddDesiredGoods("[Mat Raw] Wood");
        builder.SetAmountOfGoods(20,30);
        builder.SetAvailableInAllBiomes();
    }
}