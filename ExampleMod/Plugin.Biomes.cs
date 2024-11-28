using ATS_API.Biomes;
using ATS_API.Helpers;
using ATS_API.NaturalResource;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateBiomes()
    {
        CreateExampleBiome();
    }

    private void CreateExampleBiome()
    {
        BiomeBuilder builder = new BiomeBuilder(PluginInfo.PLUGIN_GUID, "Sand Biome");
        builder.SetDisplayName("Dry Lands");
        builder.SetDescription("New land the Queen has discovered and wishes to claim as part of her new kingdom. " +
                               "Newcomers are rare, storms are rare but harsh when hit.");
        
        builder.SetTownName("Desert Town");
        builder.SetTownDescription("The Queen's new town in the Dry Lands.");
        
        // Icon that appears.... I actually have no idea where 
        builder.SetIcon("desertTownIcon.png");
        
        // Season
        builder.SetSeasonDuration(SeasonTypes.Storm, 30);
        builder.SetSeasonDuration(SeasonTypes.Clearance, 240);
        builder.SetSeasonDuration(SeasonTypes.Drizzle, 120);
        builder.SetDeclinedSeasonalRewardsReward(GoodsTypes.Valuable_Ancient_Tablet, 2);

        // newcomers
        builder.SetNewcomerInterval(300);
        builder.SetNewcomerAmountOfGoods(1, 4);
        builder.AddNewcomerRace(RaceTypes.Beaver, 50);
        builder.AddNewcomerRace(RaceTypes.Harpy, 50);
        builder.AddNewcomerRace(RaceTypes.Foxes, 50);
        builder.AddNewcomerRace(RaceTypes.Frog, 25);
        builder.AddNewcomerRace(RaceTypes.Human, 100);
        builder.AddNewcomerRace(RaceTypes.Lizard, 50);
        
        // Trade
        builder.SetTraderForceArrivalCost(1.0f, 2.5f); // Paying trader to arrive is expensive
        builder.SetTraderForceArrivalReputationPrompt("Send for trader to arrive");
        builder.SetTraderVillagerKilledByTraderText("dehydrated in the desert");
        
        // World Map texture to overlay the little hexagons
        builder.SetWorldMapTexture("dessertWorldMapTerrain.png");

        // Starting effect
        builder.AddEffect(DiamondHunterBuilder.EffectType);

        // Terrain
        builder.SetWaterTexture("desertWorldWater.png");

        // Trees / natural resources
        // builder.AddNaturalResource(NaturalResourceTypes.Bay_Tree_2,
        //     horizontalTreshold: 0.2f,
        //     verticalTreshold: 0.3f,
        //     generationThreshold: 0.0f,
        //     minDistanceFromOrigin: 10);
        
        NaturalResourceBuilder resourceBuilder = builder.NewNaturalResource("DryTree",
            horizontalTreshold: 0.2f,
            verticalTreshold: 0.3f,
            generationThreshold: 0.0f,
            minDistanceFromOrigin: 10);
        resourceBuilder.SetDisplayName("Dry Tree");
        resourceBuilder.SetDescription("A tree that grows in the Dry Lands.");
        resourceBuilder.SetCharges(1);
        resourceBuilder.SetProduction(GoodsTypes.Mat_Raw_Wood, 1);
        resourceBuilder.AddExtraProduction(GoodsTypes.Food_Raw_Insects, 1, 0.25f);
        resourceBuilder.AddExtraProduction(GoodsTypes.Crafting_Coal, 1, 0.01f);
        
        NaturalResourcePrefabBuilder dryTree1Prefab = new NaturalResourcePrefabBuilder(PluginInfo.PLUGIN_GUID, "DryTree1");
        dryTree1Prefab.SetPrefabTemplate(NaturalResourcePrefabs.Cursed_Tree_3);
        dryTree1Prefab.SetTexture("DryTreeTexture1.png");
        resourceBuilder.AddPrefab(dryTree1Prefab);
        
        NaturalResourcePrefabBuilder dryTree2Prefab = new NaturalResourcePrefabBuilder(PluginInfo.PLUGIN_GUID, "DryTree2");
        dryTree2Prefab.SetPrefabTemplate(NaturalResourcePrefabs.Cursed_Tree_3);
        dryTree2Prefab.SetTexture("DryTreeTexture2.png");
        resourceBuilder.AddPrefab(dryTree2Prefab);
        
        NaturalResourcePrefabBuilder dryTree3Prefab = new NaturalResourcePrefabBuilder(PluginInfo.PLUGIN_GUID, "DryTree3");
        dryTree3Prefab.SetPrefabTemplate(NaturalResourcePrefabs.Cursed_Tree_6);
        dryTree3Prefab.SetTexture("DryTreeTexture1.png");
        resourceBuilder.AddPrefab(dryTree3Prefab);
        
        NaturalResourcePrefabBuilder dryTree4Prefab = new NaturalResourcePrefabBuilder(PluginInfo.PLUGIN_GUID, "DryTree4");
        dryTree4Prefab.SetPrefabTemplate(NaturalResourcePrefabs.Cursed_Tree_6);
        dryTree4Prefab.SetTexture("DryTreeTexture2.png");
        resourceBuilder.AddPrefab(dryTree4Prefab);
    }
}
