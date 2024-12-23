using ATS_API.Effects;
using ATS_API.Helpers;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Effects.Hooked;
using UnityEngine;
using HookedTextArgType = Eremite.Model.Effects.Hooked.TextArgType;
using CompositeTextArgType = Eremite.Model.Effects.TextArgType; // note: these two TextArgType are different!

namespace ExampleMod;

public partial class Plugin
{
    public HookedEffectBuilder ModdingToolsBuilder;
    public HookedEffectBuilder DiamondHunterBuilder;
    public CompositeEffectBuilder AggregateProductivityBuilder;

    private void CreateCornerstones()
    {
        CreateModdingToolsCornerstone();
        CreateGoodsRawProductionCornerstone();
        CreateGoodEveryYearProductionCornerstone();
        CreateAggregateProductivityBuilder();
    }

    private void CreateModdingToolsCornerstone()
    {
        ModdingToolsBuilder = new (PluginInfo.PLUGIN_GUID, "Modding Tools", "ModdingTools.png");
        ModdingToolsBuilder.SetPositive(true);
        ModdingToolsBuilder.SetRarity(EffectRarity.Rare);
        ModdingToolsBuilder.SetObtainedAsCornerstone();
        ModdingToolsBuilder.SetAvailableInAllBiomesAndSeasons();
        ModdingToolsBuilder.SetDrawLimit(1);
        ModdingToolsBuilder.SetLabel("API");
 
        ModdingToolsBuilder.SetDisplayName("Modding Tools");
        ModdingToolsBuilder.SetDescription("Modders have assembled new tools that bring in new talent. " +
                                "Every {0} new Villagers gain +{1} Global Resolve.");
        
        
        ModdingToolsBuilder.SetDescriptionArgs((SourceType.Hook, HookedTextArgType.Amount, 0), (SourceType.HookedEffect, HookedTextArgType.Amount, 0));
        ModdingToolsBuilder.SetPreviewDescription("+{0} Global Resolve");
        ModdingToolsBuilder.SetPreviewDescriptionArgs((HookedStateTextArg.HookedStateTextSource.TotalGainIntFromHooked, 0));

        // Add last so if anything is missing it uses the main effects description/name/icon
        ModdingToolsBuilder.AddHook(HookFactory.AfterXNewVillagers(8));
        ModdingToolsBuilder.AddHookedEffect(EffectFactory.AddHookedEffect_IncreaseResolve(ModdingToolsBuilder, 1, ResolveEffectType.Global));

        // Example if you had to rename something and it broke your save. This corrects your save data to use the right name. 
        GlobalResolveEffectEffectModel model = (GlobalResolveEffectEffectModel)ModdingToolsBuilder.EffectModel.hookedEffects[ModdingToolsBuilder.EffectModel.hookedEffects.Length - 1];
        EffectManager.AddPreviouslyNamedEffect("API_ExampleMod_UniteResolve_resolve_effect_model", model.effect.name);
        
        // Localization
        ModdingToolsBuilder.SetDisplayName("模组工具", SystemLanguage.ChineseSimplified);
        ModdingToolsBuilder.SetDescription("模组制作者已经组装了新的工具，吸引了新的人才。每到来 {0} 个新村民会获得 +{1} 满意度。", SystemLanguage.ChineseSimplified);
        
        ModdingToolsBuilder.SetDisplayName("Outils de modding", SystemLanguage.French);
        ModdingToolsBuilder.SetDescription("Les moddeurs ont assemblé de nouveaux outils qui attirent de nouveaux talents. Chaque {0} nouveaux villageois gagnent +{1} de résolution globale.", SystemLanguage.French);
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
        DiamondHunterBuilder = new (PluginInfo.PLUGIN_GUID, "diamondHunter", "DiamondHunter.png");
        DiamondHunterBuilder.SetPositive(true);
        DiamondHunterBuilder.SetRarity(EffectRarity.Rare);
        DiamondHunterBuilder.SetObtainedAsCornerstone();
        DiamondHunterBuilder.SetAvailableInAllBiomesAndSeasons();
        DiamondHunterBuilder.SetLabel("API");
 
        DiamondHunterBuilder.SetDisplayName("Diamond Hunter");
        DiamondHunterBuilder.SetDescription("You hire an obsessed miner that has a serious problem for hunting for diamonds. " +
                               "At the beginning of every {0} season gain +{1} {2}s");
        DiamondHunterBuilder.SetDescriptionArgs((SourceType.Hook, HookedTextArgType.Amount, 0), 
            (SourceType.HookedEffect, HookedTextArgType.Amount, 0), 
            (SourceType.HookedEffect, HookedTextArgType.DisplayName, 0));

        // The nested amount will show up on the icon
        // It is also a good way to provide necessary amount information to your composite cornerstone.
        DiamondHunterBuilder.SetNestedAmount(SourceType.HookedEffect, HookedTextArgType.Amount, 0);

        // Add last so if anything is missing it uses the main effects description/name/icon
        DiamondHunterBuilder.AddHook(HookFactory.OnNewSeason(SeasonTypes.Drizzle, 1));
        
        GoodsEffectBuilder giveDiamondEffect = new GoodsEffectBuilder(PluginInfo.PLUGIN_GUID, "Diamonds");
        giveDiamondEffect.SetDisplayName("Diamonds");
        giveDiamondEffect.SetDescription("A shiny gem that is used for crafting and trading.");
        giveDiamondEffect.SetGood(1, diamonds.Name);
        DiamondHunterBuilder.AddHookedEffect(giveDiamondEffect.EffectModel);
    }

    private void CreateAggregateProductivityBuilder()
    {
        AggregateProductivityBuilder = new CompositeEffectBuilder(PluginInfo.PLUGIN_GUID, "AggregateProductivity", "AggregateProductivity.png");
        AggregateProductivityBuilder.SetPositive(true);
        AggregateProductivityBuilder.SetRarity(EffectRarity.Legendary);
        AggregateProductivityBuilder.SetObtainedAsCornerstone();
        AggregateProductivityBuilder.SetAvailableInAllBiomesAndSeasons();
        AggregateProductivityBuilder.SetDrawLimit(1);
        AggregateProductivityBuilder.SetLabel("API");
        AggregateProductivityBuilder.SetAnyNestedToFit(true);
        AggregateProductivityBuilder.SetShowEffectAsPerks(false);

        // Add two effects
        AggregateProductivityBuilder.AddEffects([ModdingToolsBuilder.EffectModel, DiamondHunterBuilder.EffectModel]);

        AggregateProductivityBuilder.SetDisplayName("Aggregate Productivity");
        AggregateProductivityBuilder.SetDescription("Modders composite everything together. " +
                                "{0} And you will obtain {1} mystery good bonus sometimes.");
        // We use first effect's descrption for {0}, and second effect's GetAmount() for {1}.
        AggregateProductivityBuilder.SetDescriptionArgs((CompositeTextArgType.Description, 0), (CompositeTextArgType.Amount, 1));
        // Use the first effect's preview as preview text
        AggregateProductivityBuilder.SetNestedPreviewIndex(0);
    }
}