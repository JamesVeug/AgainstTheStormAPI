using ATS_API.Ascension;
using ATS_API.Difficulties;
using ATS_API.Helpers;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateDifficulty()
    {
        DifficultyBuilder builder = new DifficultyBuilder(PluginInfo.PLUGIN_GUID, "Faster Corruption");
        builder.SetPrestigeLevel(21);
        builder.CopyModifiersFromPreviousDifficulties();
        
        NewAscensionModifierModel modifier = builder.AddModifier(EffectTypes.Hearth_Corruption_Rate_Plus50);
        modifier.SetShortDescription("Corruption in the Ancient Hearth grows 50% quicker.");
    }
}