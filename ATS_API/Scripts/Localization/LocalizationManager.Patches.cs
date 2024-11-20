using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using Eremite.Services;
using HarmonyLib;
using UnityEngine;


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
            WIKI.CreateAllPrefabEnumTypes(Path.Combine(Plugin.ExportPath, "EnumPrefabs"));
        }

        // Exports all CSVs, so we can have updated data for the API
        if (Configs.ExportCSVs)
        {
            WIKI.ExportCSVs();
        }
    }
    
    [HarmonyPatch(typeof(TextsService), nameof(TextsService.SetCulture))]
    [HarmonyPostfix]
    private static void PostChangeLanguage(string language)
    {
        Plugin.Log.LogMessage($"Changed language to {language}");
        SystemLanguage systemLanguage = CodeToLanguage(language);
        foreach (KeyValuePair<string,Dictionary<SystemLanguage,string>> pair in s_newStrings)
        {
            AddKeyToTextService(pair.Key, pair.Value, systemLanguage);
        }
    }
}