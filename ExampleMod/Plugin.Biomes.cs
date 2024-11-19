using ATS_API.Biomes;
using ATS_API.Helpers;
using ATS_API.NaturalResource;
using Eremite.Model;
using UnityEngine;

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
        
        // World Map texture to overlay the little hexagons
        builder.SetWorldMapTexture("dessertWorldMapTerrain.png");
        
        // Terrain
        builder.SetTerrainBaseTexture("terrainBase.png");
        builder.SetTerrainBlendTexture("terrainBlend.png");
        builder.SetTerrainCliffTexture("terrainCliff.png");
        builder.SetTerrainOverlayTexture("terrainOverlay.png");

        // Trees / natural resources
        builder.AddNaturalResource(NaturalResourceTypes.Bay_Tree_2,
            horizontalTreshold: 0.2f,
            verticalTreshold: 0.3f,
            generationThreshold: 0.0f,
            minDistanceFromOrigin: 10);
        builder.AddNaturalResource(NaturalResourceTypes.Cursed_Tree,
            horizontalTreshold: 0.2f,
            verticalTreshold: 0.8f,
            generationThreshold: 0.25f,
            minDistanceFromOrigin: 15);
        builder.AddNaturalResource(NaturalResourceTypes.CoralForest_Crimsonreach,
            horizontalTreshold: 0.2f,
            verticalTreshold: 0.2f,
            generationThreshold: 0.5f,
            minDistanceFromOrigin: 20);
        
        // NaturalResourceBuilder resourceBuilder = builder.NewNaturalResource("DryTree",
        //     horizontalTreshold: 0.2f,
        //     verticalTreshold: 0.3f,
        //     generationThreshold: 0.0f,
        //     minDistanceFromOrigin: 10);
        // resourceBuilder.SetDisplayName("Dry Tree");
        // resourceBuilder.SetDescription("A tree that grows in the Dry Lands.");
        // resourceBuilder.SetCharges(1);
        // resourceBuilder.SetProduction(GoodsTypes.Mat_Raw_Wood, 1);
        // resourceBuilder.AddExtraProduction(GoodsTypes.Food_Raw_Insects, 1, 0.25f);
        // resourceBuilder.AddExtraProduction(GoodsTypes.Crafting_Coal, 1, 0.01f);
        
    }
}