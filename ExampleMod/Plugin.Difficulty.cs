using ATS_API.Difficulties;
using ATS_API.Helpers;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateDifficulty()
    {
        DifficultyBuilder builder = new DifficultyBuilder(PluginInfo.PLUGIN_GUID, "Hard");
        builder.SetDisplayName("Mmm Pie");
        builder.SetPrestigeLevel(7);        
        builder.AddModifier(EffectTypes.Pie_5pm, shortDescription: "5 Pies per minute.");
    }
}