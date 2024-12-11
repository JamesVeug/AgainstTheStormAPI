using ATS_API.Helpers;
using Eremite;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.View.Cameras;
using Eremite.View.Utils;
using HarmonyLib;
using UnityEngine;

namespace ATS_API.Biomes;

public static partial class BiomeManager
{
    [HarmonyPatch(typeof(MapGenerator), nameof(MapGenerator.CreateFieldState))]
    [HarmonyPostfix]
    private static void _MapGeneratorCreateFieldState(MapGenerator __instance, int x, int y, ref FieldState __result)
    {
        Plugin.Log.LogInfo("MapGenerator_CreateFieldState_Postfix");
        
        // Code is
        // return new FieldState(new Vector2Int(x, y), mapModel.Map[x, y]);
        
        // If we want to remove soil then change fieldType to None
        
        BiomeTypes biomeTypes = __instance.conditions.biomeName.ToBiomeTypes();
        if (!NewBiomeLookup.TryGetValue(biomeTypes, out NewBiome newBiome))
        {
            return;
        }
        
        if (__result.type == FieldType.Grass && newBiome.soilAmount == 0)
        {
            Plugin.Log.LogInfo("Changing soil to None at " + x + ", " + y);
            __result.type = FieldType.None;
        }
    }
}