using ATS_API.Biomes;

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
        
        builder.SetIcon("desertTownIcon.png");
        builder.SetWorldMapTexture("dessertWorldMapTerrain.png");
            
        builder.SetTerrainBaseTexture("terrainBase.png");
        builder.SetTerrainBlendTexture("terrainBlend.png");
        builder.SetTerrainCliffTexture("terrainCliff.png");
        builder.SetTerrainOverlayTexture("terrainOverlay.png");
    }
}