using ATS_API.Effects;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Needs;
using UnityEngine;

namespace ATS_API.Needs;

public static class RaceNeedFactory
{
    public static CustomRaceNeed HousingNeed(string guid, RaceTypes race, BuildingTypes building, string displayName, string description, Sprite icon, int resolve = 3)
    {
        string buildingName = building.ToName();
        string needName = buildingName + "_housingNeed";
        CustomRaceNeed need = RaceNeedManager.New(guid, needName);
        need.houseName = building;
        need.raceName = race;
        
        need.NeedModel.order = 1;
        need.NeedModel.isVisible = true;
        need.NeedModel.presentation = ScriptableObject.CreateInstance<HousePresentationModel>();
        need.NeedModel.presentation.overrideIcon = icon;
        need.NeedModel.canBeProhibited = false;
        need.NeedModel.requiresInstitution = false;

        var effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_resolveEffect");
        effect.Model.icon = icon;
        effect.Model.displayName = LocalizationManager.ToLocaText(guid, needName, "displayName", displayName);
        effect.Model.description = LocalizationManager.ToLocaText(guid, needName, "description", description);
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
        
        need.NeedModel.presentation = ScriptableObject.CreateInstance<GoodPresentationModel>();
        need.NeedModel.canBeProhibited = true;
        need.NeedModel.order = 2;
        need.NeedModel.isVisible = true;
        need.NeedModel.requiresInstitution = false;

        // GoodModel goodModel = good.ToGoodModel();
        var effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, needName + "_resolveEffect");
        effect.Model.label = ScriptableObject.CreateInstance<LabelModel>();
        effect.Model.label.displayName = "NeedCategory_Food_Name".ToLocaText();
        // effect.Model.icon = goodModel.icon; NOTE: Synced in NewNeed
        // effect.Model.displayName = goodModel.displayName; NOTE: Synced in NewNeed
        effect.Model.resolve = resolve;
        need.NeedModel.effect = effect.Model;
        
        // "ResolveEffect_JerkyEffect_Description": "This need is fulfilled at the Hearth. It requires <sprite name=\"[food processed] jerky\"> jerky."
        // var description = $"This need is fulfilled at the Hearth. It requires <sprite name=\"{goodModel.name}\"> {goodModel.displayName.GetText()}.";
        // effect.Model.description = LocalizationManager.ToLocaText(guid, needName, "description", description);
        
        
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
}
