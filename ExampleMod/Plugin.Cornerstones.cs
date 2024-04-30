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
        CreateModdingToolsCornerstone();
        CreateGoodsRawProductionCornerstone();
    }

    private void CreateModdingToolsCornerstone()
    {
        HookedEffectBuilder builder = new (PluginInfo.PLUGIN_GUID, "Modding Tools", "ModdingTools.png");
        builder.SetPositive(true);
        builder.SetRarity(EffectRarity.Rare);
        builder.SetObtainedAsCornerstone();
        builder.SetAvailableInAllBiomesAndSeasons();
        builder.SetDrawLimit(1);
        builder.AddHook(HookFactory.AfterXNewVillagers(8));
        builder.AddHookedEffect(EffectFactory.AddHookedEffect_IncreaseResolve(PluginInfo.PLUGIN_GUID, "UniteResolve",
            1, ResolveEffectType.Global));
 
        builder.SetDisplayName("Modding Tools");
        builder.SetDescription("Modders have assembled new tools that bring in new talent. " +
                                "Every {0} new Villagers gain +{1} Global Resolve.");
        builder.SetDescriptionArgs((SourceType.Hook, TextArgType.Amount, 0), (SourceType.HookedEffect, TextArgType.Amount, 0));
        builder.SetPreviewDescription("+{0} Global Resolve");
        builder.SetPreviewDescriptionArgs((HookedStateTextArg.HookedStateTextSource.TotalGainIntFromHooked, 0));

        ATS_API.Plugin.Log.LogInfo($"Cornerstone {builder.Name} created {builder.EffectModel.dynamicDescriptionArgs.Length}");
    }
    
    private void CreateGoodsRawProductionCornerstone()
    {
        // {1} to {0} production. Gain additional {0} every yield (from gathering, farming, or production).
        var builder = new GoodsProductionEffectBuilder(PluginInfo.PLUGIN_GUID, "Omega Sewing Technique");
        builder.SetPositive(true);
        builder.SetRarity(EffectRarity.Legendary);
        builder.SetObtainedAsCornerstone();
        builder.SetAvailableInAllBiomesAndSeasons();
 
        builder.SetDisplayName("Omega Sewing Technique");
        builder.SetGoodsPerYield(10, "[Needs] Coats");
        builder.SetTradingBuyValue(300);

        ATS_API.Plugin.Log.LogInfo($"Cornerstone {builder.Name} created");
    }
}