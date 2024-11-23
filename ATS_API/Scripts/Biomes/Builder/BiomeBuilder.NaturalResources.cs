using ATS_API.Helpers;
using ATS_API.NaturalResource;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public NaturalResourceBuilder NewNaturalResource(string resourceName,
        float horizontalTreshold = 0.2f,
        float verticalTreshold = 0.2f,
        float generationThreshold = 0.0f,
        int minDistanceFromOrigin = 0)
    {
        NaturalResourceBuilder builder = new NaturalResourceBuilder(guid, resourceName);
        AddNaturalResource(builder.NewNaturalResource.ID, horizontalTreshold, verticalTreshold, generationThreshold,
            minDistanceFromOrigin);
        return builder;
    }

    /// <summary>
    /// Add a tree/natural resource to the biome for when its auto generated
    /// Uses perlin noise to distrubute the resources around the map.
    /// The first resource added will be fallback if no other resources can be selected to fill the empty spots.
    /// </summary>
    /// <param name="resourceType">The type of natural resource</param>
    /// <param name="horizontalTreshold">0-1 Control the respective distribution of the clumps. Common: 0.2</param>
    /// <param name="verticalTreshold">0-1 Control the respective distribution of the clumps. Common: 0.3</param>
    /// <param name="generationThreshold">0-1 How dense the amount of clumps (0 very dense, 1 small clumps)</param>
    /// <param name="minDistanceFromOrigin">Minimum distance from the starting glade before it starts being shown.</param>
    /// <returns></returns>
    public BiomeBuilder AddNaturalResource(NaturalResourceTypes resourceType,
        float horizontalTreshold = 0.2f,
        float verticalTreshold = 0.3f,
        float generationThreshold = 0.0f,
        int minDistanceFromOrigin = 0)
    {
        NewBiome.NaturalResourceData naturalResourceData = new NewBiome.NaturalResourceData
        {
            horizontalTreshold = horizontalTreshold,
            verticalTreshold = verticalTreshold,
            generationThreshold = generationThreshold,
            minDistanceFromOrigin = minDistanceFromOrigin,
            resourceType = resourceType,
        };
        newBiome.naturalResources.Add(naturalResourceData);
        return this;
    }
}