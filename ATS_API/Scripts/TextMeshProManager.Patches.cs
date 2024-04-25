using System.Collections.Generic;
using System.Linq;
using ATS_API;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite.Services;
using Eremite.View.HUD;
using HarmonyLib;
using TMPro;
using UnityEngine;

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