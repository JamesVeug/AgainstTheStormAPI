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

    public GoodsTypes serviceResultGood = GoodsTypes.None;
    public VillagerPerkTypes perk = VillagerPerkTypes.None;
    public NeedTypes ID = NeedTypes.None;
    public GoodsTypes referenceGood = GoodsTypes.None;
    public BuildingTypes houseName = BuildingTypes.None;

    public override void PostSync()
    {
        if (perk != VillagerPerkTypes.None)
        {
            NeedModel.perk = perk.ToVillagerPerkModel();
        }

        if (serviceResultGood != GoodsTypes.None)
        {
            PostSyncServiceNeed();
        }
        else if (referenceGood != GoodsTypes.None)
        {
            PostSyncComplexFoodNeed();
        }
        else if (houseName != BuildingTypes.None)
        {
            PostSyncHouseNeed();
        }
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

    private void PostSyncComplexFoodNeed()
    {
        GoodModel good = referenceGood.ToGoodModel();
        if (good == null)
        {
            APILogger.LogError($"Failed to find good {referenceGood} for need {NeedModel.name}");
            return;
        }
        NeedModel.referenceGood = good;
        NeedModel.category = NeedTypes.Jerky.ToNeedModel().category;
        
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
    
    private void PostSyncServiceNeed()
    {
        GoodModel good = referenceGood.ToGoodModel();
        if (good == null)
        {
            APILogger.LogError($"Failed to find good {referenceGood} for need {NeedModel.name}");
            return;
        }
        NeedModel.referenceGood = good;
        NeedModel.category = NeedTypes.Leasiure.ToNeedModel().category;
        
        NeedModel.effect.icon = serviceResultGood.ToGoodModel().icon;
        NeedModel.effect.displayName = serviceResultGood.ToGoodModel().displayName;
        
        NeedModel.equalProhibitionPenalty.icon = NeedModel.effect.icon;
        NeedModel.unfairProhibitionPenalty.icon = NeedModel.effect.icon;
        
        // Presentation
        GoodPresentationModel presentation = (GoodPresentationModel)NeedModel.presentation;
        presentation.good = good;
        presentation.overrideIcon = NeedModel.effect.icon;
        if (presentation.description == null)
        {
            presentation.description = "Need_FormatedDescription_Generic".ToLocaText();
            presentation.formatDescription = true;
        }
        if (presentation.orderDescription == null)
        {
            presentation.orderDescription = "Orders_Logics_FunNeed_Description".ToLocaText();
        }
    }
}