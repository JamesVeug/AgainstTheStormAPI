using System.IO;
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
        Plugin.CoreGameLoaded = true;


        // Exports all enums so we cna have updated code for the API
        if (Configs.ExportEnumTypes )
        {
            WIKI.CreateAllEnumTypes(Path.Combine(Plugin.ExportPath, "Enums"));
        }

        // Exports all CSVs, so we can have updated data for the API
        if (Configs.ExportCSVs)
        {
            WIKI.ExportCSVs();
        }
    }
}