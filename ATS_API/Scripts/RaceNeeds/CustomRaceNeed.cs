using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.Model.Needs;

namespace ATS_API.Needs;

public class CustomRaceNeed : ASyncable<NeedModel>
{
    public NeedModel NeedModel;
    public string guid;
    public string needName;
    
    public NeedTypes ID = NeedTypes.None;
    public GoodsTypes referenceGood = GoodsTypes.None;
    public BuildingTypes houseName = BuildingTypes.None;
    public RaceTypes raceName = RaceTypes.None;

    public override bool Sync()
    {
        if (referenceGood != GoodsTypes.None)
        {
            return SyncComplexFoodNeed();
        }
        else if (houseName != BuildingTypes.None)
        {
            return SyncHouseNeed();
        }
        
        return true;
    }

    public override void PostSync()
    {
        Plugin.Log.LogInfo($"PostSync for {NeedModel.name}");
        if (referenceGood != GoodsTypes.None)
        {
            PostSyncGoodNeed();
        }
        else if (houseName != BuildingTypes.None)
        {
            PostSyncHouseNeed();
        }
    }

    private bool SyncHouseNeed()
    {
        return true;
    }

    private void PostSyncHouseNeed()
    {
        NeedModel template = NeedTypes.Harpy_Housing.ToNeedModel();
        NeedModel.category = template.category;
        NeedModel.effect.label = template.effect.label;
        
        // Presentation
        HousePresentationModel presentation = (HousePresentationModel)NeedModel.presentation;
        HouseModel houseModel = (HouseModel)houseName.ToBuildingModel();
        presentation.houses = [houseModel];
        if (presentation.overrideIcon == null)
        {
            presentation.overrideIcon = presentation.houses[0].icon;
        }

        HearthModel hearth = (HearthModel)SO.Settings.GetBuilding("Small Hearth");
        hearth.tags = hearth.tags.ForceAdd(houseModel.tags[0]);
    }

    private bool SyncComplexFoodNeed()
    {
        // Category
        if (NeedModel.category == null)
        {
            NeedModel jerky = NeedTypes.Jerky.ToNeedModel();
            NeedModel.category = jerky.category;
        }

        return true;
    }

    private void PostSyncGoodNeed()
    {
        Plugin.Log.LogInfo($"PostSyncGoodNeed for {NeedModel.name}");
        GoodModel good = referenceGood.ToGoodModel();
        if (good == null)
        {
            Plugin.Log.LogError($"Failed to find good {referenceGood} for need {NeedModel.name}");
            return;
        }
        NeedModel.referenceGood = good;
        
        // "ResolveEffect_JerkyEffect_Description": "This need is fulfilled at the Hearth. It requires <sprite name=\"[food processed] jerky\"> jerky."
        var description = $"This need is fulfilled at the Hearth. It requires <sprite name=\"{good.name}\"> {good.displayName.GetText()}.";
        NeedModel.effect.description = LocalizationManager.ToLocaText(guid, needName, "description", description);
        
        NeedModel.equalProhibitionPenalty.icon = good.icon;
        NeedModel.unfairProhibitionPenalty.icon = good.icon;
        
        NeedModel.effect.icon = good.icon;
        NeedModel.effect.displayName = good.displayName; // "ResolveEffect_JerkyEffect_Name": "Jerky" 
        
        // Presentation
        GoodPresentationModel presentation = (GoodPresentationModel)NeedModel.presentation;
        presentation.good = good;
        Plugin.Log.LogInfo($"Need {needName} presentation good: {presentation.good}");
        if (presentation.description == null)
        {
            string text = $"This need is fulfilled at the Hearth. It requires <sprite name=\"{good.name}\"> {good.displayName.GetText()}.";
            presentation.description = LocalizationManager.ToLocaText(guid, needName, "description", text);
        }
        if (presentation.orderDescription == null)
        {
            string text = "Fulfill your villagers' need for eating " + good.displayName.GetText() + " {0} times.";
            presentation.orderDescription = LocalizationManager.ToLocaText(guid, needName, "orderDescription", text);
        }
    }
}