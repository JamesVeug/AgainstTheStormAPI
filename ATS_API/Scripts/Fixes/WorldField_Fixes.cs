using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Goods;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Characters.Villagers;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.WorldMap;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class WorldField_Fixes
{
    [HarmonyPatch(typeof(WorldField), nameof(WorldField.SetUp))]
    [HarmonyPrefix]
    public static bool WorldField_SetUp_Prefix(WorldFieldState state)
    {
        if(!MB.Settings.biomesCache.Contains(MB.Settings.biomes, state.biome))
        {
            APILogger.LogWarning($"Biome {state.biome} not found in BiomesCache. Replacing with Royal Woodlands.");
            state.biome = BiomeTypes.Royal_Woodlands.ToName();
        }

        return true;
    }
}