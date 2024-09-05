using Eremite.View.HUD;
using HarmonyLib;

namespace ATS_API.Fixes;

[HarmonyPatch]
internal class RacesHUDSlots_Fixes
{
    [HarmonyPatch(typeof(RacesHUDSlot), nameof(RacesHUDSlot.ReadInput))]
    [HarmonyPrefix]
    public static bool ReadInput(RacesHUDSlot __instance)
    {
        if (__instance.race.assignAction == null)
        {
            return false;
        }

        return true;
    }
}