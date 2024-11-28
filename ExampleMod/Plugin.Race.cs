using ATS_API.Helpers;
using ATS_API.Needs;
using ATS_API.Races;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateRaces()
    {
        CreateAxolotl();
    }

    private void CreateAxolotl()
    {
        RaceBuilder builder = new RaceBuilder(PluginInfo.PLUGIN_GUID, "Axolotl");
        builder.SetDisplayName("Axolotl");
        builder.SetPluralDisplayName("Axolotls");
        builder.SetDescription("Axolotls are a type of salamander that fully metamorphosed into land-dwelling creatures.");
        builder.SetIcon("Axolotl.png");
        builder.SetRoundIcon("AxolotlRound.png");
        builder.SetWideIcon("AxolotlWide.png");

        // Characteristic
        builder.AddCharacteristic(BuildingTagTypes.Rainwater, VillagerPerkTypes.Proficiency);
        builder.AddCharacteristic(BuildingTagTypes.Brewing, VillagerPerkTypes.Comfortable_Job);
        builder.AddGlobalCharacteristic(axolotlHouse.NewData.Tag, EffectTypes.Meat_Plus1);
        
        // Needs
        CustomRaceNeed houseNeed = RaceNeedFactory.HousingNeed(PluginInfo.PLUGIN_GUID, builder.NewRaceData.ID, axolotlHouse.NewData.ID, 
            "Axolotl Housing",
            "The axolotl is lentic, meaning it inhabits still-water lakes. Axolotl Houses are required to fulfill this need.",
            axolotlHouse.Model.icon,
            3);
        
        builder.AddNeed(NeedTypes.Any_Housing);
        builder.AddNeed(houseNeed.ID);
        builder.AddNeed(NeedTypes.Biscuits);
        
        CustomRaceNeed burgerNeed = RaceNeedFactory.ComplexFoodNeed(PluginInfo.PLUGIN_GUID, burger.NewGood.id, 7);
        builder.AddNeed(burgerNeed.ID);

        // Axolotls are the only ones that can sleep in this house
        axolotlHouse.AddHousingRace(builder.NewRaceData.ID);
        axolotlHouse.AddServedNeed(houseNeed.ID);
    }
}