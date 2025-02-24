using System.Collections.Generic;
using ATS_API.Effects;
using ATS_API.Goods;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Characters.Villagers;
using Eremite.Controller.Generator;
using Eremite.Model;
using Eremite.Services;
using Eremite.WorldMap;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class ResolveService_Fixes
{
    [HarmonyPatch(typeof(ResolveService), nameof(ResolveService.GetReputationGainFor))]
    [HarmonyPrefix]
    public static bool ResolveService_GetReputationGainFor_Prefix(ResolveService __instance, string race, ref float __result)
    {
        // Trying to play a Villager sound that isn't added to the players list yet can cause this to break
        if (!Serviceable.StateService.Actors.racesReputationGains.ContainsKey(race))
        {
            __result = 0;
            return false;
        }

        return true;
    }
}