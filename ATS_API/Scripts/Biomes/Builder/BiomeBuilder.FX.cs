using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public BiomeBuilder SetRainParticles(AssetBundle assetBundle, string assetName)
    {
        if (AssetBundleHelper.TryGet(assetBundle, assetName, out GameObject gameObject))
        {
            newBiome.rainPrefab = gameObject;
        }
        return this;
    }
}