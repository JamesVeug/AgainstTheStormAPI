using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Eremite.Services;
using HarmonyLib;


namespace ATS_API.Localization;

[HarmonyPatch]
public static partial class LocalizationManager
{
    [HarmonyPatch(typeof(TextsService), nameof(TextsService.OnLoading))]
    [HarmonyPostfix]
    private static async UniTask PostLoadLocalisation(UniTask enumerator, TextsService __instance)
    {
        await enumerator;
        if (s_pendingLanguageStrings.TryGetValue(__instance.CurrentLocaCode, out LanguageDictionary dic))
        {
            foreach (KeyValuePair<string, string> pair in dic)
            {
                __instance.texts[pair.Key] = pair.Value;
            }
        }
        else
        {
            Plugin.Log.LogInfo($"No localisation found for {__instance.CurrentLocaCode}");
        }



        // foreach (TraderModel trader in MB.Settings.traders)
        // {
        //     Plugin.Log.LogInfo("Trader: " + trader.name + ": " + trader.displayName.Text);
        // }
    }
}