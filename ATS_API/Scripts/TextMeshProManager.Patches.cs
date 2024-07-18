using HarmonyLib;

namespace ATS_API
{
    [HarmonyPatch]
    public static partial class TextMeshProManager
    {
        // [HarmonyPatch(typeof(EffectTooltip), nameof(EffectTooltip.SetUpTexts))]
        // [HarmonyPrefix]
        // private static bool PostLoadLocalisation(EffectTooltip __instance)
        // {
        //     TextMeshProManager.Sync(__instance.nameText);
        //     TextMeshProManager.Sync(__instance.descText);
        //     TextMeshProManager.Sync(__instance.labelText);
        //     return true;
        // }
    }
}