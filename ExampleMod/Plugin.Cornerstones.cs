using ATS_API.Effects;
using ATS_API.Helpers;
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
        CreateGoodEveryYearProductionCornerstone();
    }

    private void CreateModdingToolsCornerstone()
    {
        HookedEffectBuilder builder = new (PluginInfo.PLUGIN_GUID, "Modding Tools", "ModdingTools.png");
        builder.SetPositive(true);
        builder.SetRarity(EffectRarity.Rare);
        builder.SetObtainedAsCornerstone();
        builder.SetAvailableInAllBiomesAndSeasons();
        builder.SetDrawLimit(1);
        builder.SetLabel("API");
 
        builder.SetDisplayName("Modding Tools");
        builder.SetDescription("Modders have assembled new tools that bring in new talent. " +
                                "Every {0} new Villagers gain +{1} Global Resolve.");
        builder.SetDescriptionArgs((SourceType.Hook, TextArgType.Amount, 0), (SourceType.HookedEffect, TextArgType.Amount, 0));
        builder.SetPreviewDescription("+{0} Global Resolve");
        builder.SetPreviewDescriptionArgs((HookedStateTextArg.HookedStateTextSource.TotalGainIntFromHooked, 0));

        // Add last so if anything is missing it uses the main effects description/name/icon
        builder.AddHook(HookFactory.AfterXNewVillagers(8));
        builder.AddHookedEffect(EffectFactory.AddHookedEffect_IncreaseResolve(builder, 1, ResolveEffectType.Global));

        // Example if you had to rename something and it broke your save. This corrects your save data to use the right name. 
        GlobalResolveEffectEffectModel model = (GlobalResolveEffectEffectModel)builder.EffectModel.hookedEffects[builder.EffectModel.hookedEffects.Length - 1];
        EffectManager.AddPreviouslyNamedEffect("API_ExampleMod_UniteResolve_resolve_effect_model", model.effect.name);
    }
    
    private void CreateGoodsRawProductionCornerstone()
    {
        // TODO: Make this appear less... need to find out how the base game organzies legendary and sort accordingly.
        // {1} to {0} production. Gain additional {0} every yield (from gathering, farming, or production).
        var builder = new GoodsProductionEffectBuilder(PluginInfo.PLUGIN_GUID, "Omega Sewing Technique");
        builder.SetLabel("API");
        builder.SetPositive(true);
        builder.SetRarity(EffectRarity.Legendary);
        builder.SetObtainedAsCornerstone();
        builder.SetAvailableInAllBiomesAndSeasons();
 
        builder.SetDisplayName("Omega Sewing Technique");
        builder.SetGoodsPerYield(10, GoodsTypes.Needs_Coats);
        builder.SetTradingBuyValue(300);
    }
    
    private void CreateGoodEveryYearProductionCornerstone()
    {
        HookedEffectBuilder builder = new (PluginInfo.PLUGIN_GUID, "diamondHunter", "Diamonds.png");
        builder.SetPositive(true);
        builder.SetRarity(EffectRarity.Rare);
        builder.SetObtainedAsCornerstone();
        builder.SetAvailableInAllBiomesAndSeasons();
        builder.SetLabel("API");
 
        builder.SetDisplayName("Diamond Hunter");
        builder.SetDescription("You hire an obsessed miner that has a serious problem for hunting for diamonds. " +
                               "At the beginning of every {0} season gain +{1} {2}s");
        builder.SetDescriptionArgs((SourceType.Hook, TextArgType.Amount, 0), 
            (SourceType.HookedEffect, TextArgType.Amount, 0), 
            (SourceType.HookedEffect, TextArgType.DisplayName, 0));

        // Add last so if anything is missing it uses the main effects description/name/icon
        builder.AddHook(HookFactory.OnNewSeason(SeasonTypes.Drizzle, 1));
        
        GoodsEffectBuilder giveDiamondEffect = new GoodsEffectBuilder(PluginInfo.PLUGIN_GUID, "Diamonds");
        giveDiamondEffect.SetDisplayName("Diamonds");
        giveDiamondEffect.SetDescription("A shiny gem that is used for crafting and trading.");
        giveDiamondEffect.SetGood(1, diamonds.Name);
        builder.AddHookedEffect(giveDiamondEffect.EffectModel);
    }
}