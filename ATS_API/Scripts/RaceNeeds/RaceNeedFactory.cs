using System;
using ATS_API.Effects;
using ATS_API.Goods;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Needs;
using UnityEngine;

namespace ATS_API.Needs;

public static class RaceNeedFactory
{
    [Obsolete("Use HousingNeed(guid, building, displayName, description, icon, resolve, language) instead", true)]
    private static CustomRaceNeed HousingNeed(string guid, RaceTypes race, BuildingTypes building, string displayName, string description, Sprite icon, int resolve = 3)
    {
        return HousingNeed(guid, building, displayName, description, icon, resolve, SystemLanguage.English);
    }
    
    [Obsolete("Use HousingNeed(guid, building, displayName, description, icon, resolve, language) instead", true)]
    public static CustomRaceNeed HousingNeed(string guid, RaceTypes race, BuildingTypes building, string displayName, string description, Sprite icon, int resolve = 3, SystemLanguage language = SystemLanguage.English)
    {
        return HousingNeed(guid, building, displayName, description, icon, resolve, language);
    }
    
    public static CustomRaceNeed HousingNeed(string guid, BuildingTypes building, string displayName, string description, Sprite icon, int resolve = 3, SystemLanguage language = SystemLanguage.English)
    {
        string buildingName = building.ToName();
        string needName = buildingName + "_housingNeed";
        CustomRaceNeed need = RaceNeedManager.New(guid, needName);
        need.houseName = building;
        
        need.NeedModel.order = 1;
        need.NeedModel.isVisible = true;
        need.NeedModel.presentation = ScriptableObject.CreateInstance<HousePresentationModel>();
        need.NeedModel.presentation.overrideIcon = icon;
        need.NeedModel.canBeProhibited = false;
        need.NeedModel.requiresInstitution = false;

        var effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_resolveEffect");
        effect.Model.icon = icon;
        effect.Model.displayName = LocalizationManager.ToLocaText(guid, needName, "displayName", displayName, language);
        effect.Model.description = LocalizationManager.ToLocaText(guid, needName, "description", description, language);
        effect.Model.resolve = resolve;
        
        need.NeedModel.effect = effect.Model;
        
        return need;
    }
    
    public static CustomRaceNeed ComplexFoodNeed(string guid, GoodsTypes good, int resolve=4)
    {
        string goodName = good.ToName();
        string needName = goodName + "_complexFoodNeed";
        CustomRaceNeed need = RaceNeedManager.New(guid, needName);
        need.referenceGood = good;
        need.perk = VillagerPerkTypes.Need_Complex_Food_Extra_Production;
        
        need.NeedModel.presentation = ScriptableObject.CreateInstance<GoodPresentationModel>();
        need.NeedModel.canBeProhibited = true;
        need.NeedModel.order = 2;
        need.NeedModel.isVisible = true;
        need.NeedModel.requiresInstitution = false;

        // GoodModel goodModel = good.ToGoodModel();
        var effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_resolveEffect");
        effect.Model.label = "NeedCategory_Food_Name".ToLabelModel();
        // effect.Model.icon = goodModel.icon; NOTE: Synced in NewNeed
        // effect.Model.displayName = goodModel.displayName; NOTE: Synced in NewNeed
        effect.Model.resolve = resolve;
        need.NeedModel.effect = effect.Model;
        
        
        // Equal penalty
        var equalPenaltyEffect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_equalPenaltyResolveEffect");
        equalPenaltyEffect.Model.label = ScriptableObject.CreateInstance<LabelModel>();
        equalPenaltyEffect.Model.label.displayName = "NeedCategory_Food_Name".ToLocaText();
        // equalPenaltyEffect.Model.icon = goodModel.icon; NOTE: Synced in NewNeed
        equalPenaltyEffect.Model.displayName = "ResolveEffect_EqualProhibitionPenalty_Name".ToLocaText();
        equalPenaltyEffect.Model.description = "ResolveEffect_EqualProhibitionPenalty_Description".ToLocaText();
        equalPenaltyEffect.Model.resolve = -1;
        need.NeedModel.equalProhibitionPenalty = equalPenaltyEffect.Model;
        
        // Unfair penalty
        var unfairPenaltyEffect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_unfairPenaltyResolveEffect");
        unfairPenaltyEffect.Model.label = ScriptableObject.CreateInstance<LabelModel>();
        unfairPenaltyEffect.Model.label.displayName = "NeedCategory_Food_Name".ToLocaText();
        // unfairPenaltyEffect.Model.icon = goodModel.icon; NOTE: Synced in NewNeed
        unfairPenaltyEffect.Model.displayName = "ResolveEffect_UnfairProhibitionPenalty_Name".ToLocaText();
        unfairPenaltyEffect.Model.description = "ResolveEffect_UnfairProhibitionPenalty_Description".ToLocaText();
        unfairPenaltyEffect.Model.resolve = -2;
        need.NeedModel.unfairProhibitionPenalty = equalPenaltyEffect.Model;

        // TODO: Category in sync
        // TODO: Presentation in sync
        
        return need;
    }
    
    public static CustomRaceNeed ServiceNeed(string guid, GoodsTypes requiredGood, string icon, string displayName, string description, int resolve=4)
    {
        string goodName = requiredGood.ToName();
        string needName = goodName + "_serviceNeed";
        CustomRaceNeed need = RaceNeedManager.New(guid, needName);
        need.serviceIcon = TextureHelper.GetImageAsSprite(icon, TextureHelper.SpriteType.GoodIcon);
        need.serviceDisplayNameKey = LocalizationManager.NewString(guid, needName, "displayName", displayName);
        need.referenceGood = requiredGood;
        need.perk = VillagerPerkTypes.Need_Service_Goods_Extra_Production;
        
        need.NeedModel.presentation = ScriptableObject.CreateInstance<GoodPresentationModel>();
        need.NeedModel.canBeProhibited = true;
        need.NeedModel.order = 2;
        need.NeedModel.isVisible = true;
        need.NeedModel.requiresInstitution = true;

        var effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_resolveEffect");
        effect.Model.label = "NeedCategory_Services_Name".ToLabelModel();
        // effect.Model.icon; NOTE: Synced in NewNeed
        // effect.Model.displayName; NOTE: Synced in NewNeed
        effect.Model.description = LocalizationManager.NewString(guid, needName, "description", description).ToLocaText();
        effect.Model.resolve = resolve;
        effect.Model.type = ResolveEffectType.Need;
        need.NeedModel.effect = effect.Model;
        
        
        // Equal penalty
        var equalPenaltyEffect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_equalPenaltyResolveEffect");
        equalPenaltyEffect.Model.label = ScriptableObject.CreateInstance<LabelModel>();
        equalPenaltyEffect.Model.label.displayName = "NeedCategory_Services_Name".ToLocaText();
        // equalPenaltyEffect.Model.icon = null;
        equalPenaltyEffect.Model.displayName = "ResolveEffect_EqualProhibitionPenalty_Name".ToLocaText();
        equalPenaltyEffect.Model.description = "ResolveEffect_EqualProhibitionPenalty_Description".ToLocaText();
        equalPenaltyEffect.Model.resolve = -1;
        equalPenaltyEffect.Model.type = ResolveEffectType.Race;
        need.NeedModel.equalProhibitionPenalty = equalPenaltyEffect.Model;
        
        // Unfair penalty
        var unfairPenaltyEffect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_unfairPenaltyResolveEffect");
        unfairPenaltyEffect.Model.label = ScriptableObject.CreateInstance<LabelModel>();
        unfairPenaltyEffect.Model.label.displayName = "NeedCategory_Services_Name".ToLocaText();
        // unfairPenaltyEffect.Model.icon = null;
        unfairPenaltyEffect.Model.displayName = "ResolveEffect_UnfairProhibitionPenalty_Name".ToLocaText();
        unfairPenaltyEffect.Model.description = "ResolveEffect_UnfairProhibitionPenalty_Description".ToLocaText();
        unfairPenaltyEffect.Model.resolve = -2;
        unfairPenaltyEffect.Model.type = ResolveEffectType.Race;
        need.NeedModel.unfairProhibitionPenalty = equalPenaltyEffect.Model;

        // TODO: Category in sync
        // TODO: Presentation in sync
        
        return need;
    }
}
