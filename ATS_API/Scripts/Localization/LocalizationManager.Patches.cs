using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DebugMenu;
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
        m_coreGameLoaded = true;


        // Exports all enums so we cna have updated code for the API
        if (Configs.ExportEnumTypes && !string.IsNullOrEmpty(Configs.ExportEnumsPath))
        {
            WIKI.CreateAllEnumTypes(Configs.ExportEnumsPath);
        }

        // Exports all CSVs, so we can have updated data for the API
        if (Configs.ExportCSVs && !string.IsNullOrEmpty(Configs.ExportCSVPath))
        {
            WIKI.ExportCSVs();
        }
    }
}