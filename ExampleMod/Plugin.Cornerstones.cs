using ATS_API.Effects;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Effects.Hooked;
using TextArgType = Eremite.Model.Effects.Hooked.TextArgType;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateCornerstones()
    {
        HookedEffectBuilder builder2 =
            new HookedEffectBuilder(PluginInfo.PLUGIN_GUID, "Modders Unite", "TestCornerstone.png");
        builder2.SetObtainedAsCornerstone();
        builder2.SetAvailableInAllBiomesAndSeasons();
        builder2.SetDrawLimit(1);
        builder2.AddHook(HookFactory.AfterXNewVillagers(8));
        builder2.AddHookedEffect(EffectFactory.AddHookedEffect_IncreaseResolve(PluginInfo.PLUGIN_GUID, "UniteResolve",
            1, ResolveEffectType.Global));
 
        builder2.SetDisplayName("Modders Unite");
        builder2.SetDescription("Modders have united the kingdom and raised everyone's spirits. " +
                                "Every {0} new Villagers gain +{1} Global Resolve.");
        builder2.SetDescriptionArgs((SourceType.Hook, TextArgType.Amount), (SourceType.HookedEffect, TextArgType.Amount));
        builder2.SetPreviewDescription("+{0} Global Resolve");
        builder2.SetPreviewDescriptionArgs(HookedStateTextArg.HookedStateTextSource.TotalGainIntFromHooked);

        ATS_API.Plugin.Log.LogInfo(
            $"Cornerstone Modders Unite created {builder2.EffectModel.dynamicDescriptionArgs.Length}");
    }
}