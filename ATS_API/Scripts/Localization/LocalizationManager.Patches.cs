using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using Eremite.Model.Configs;
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

        ValidateAllLanguagesAreCorrect(__instance);

        // Exports all enums so we cna have updated code for the API
        if (Configs.ExportEnumTypes )
        {
            string csExportPath = Plugin.ExportPath;
            Plugin.Log.LogMessage($"Exporting enums to {csExportPath}");
            
            WIKI.CreateAllEnumTypes(Path.Combine(csExportPath, "EnumPrefabs"));
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

    private static void ValidateAllLanguagesAreCorrect(TextsService __instance)
    {
        foreach (LanguageConfig configLanguage in __instance.Config.languages)
        {
            string configLanguageCode = configLanguage.code;
            if (!IsLanguageCodeSupported(configLanguage.code))
            {
                Plugin.Log.LogWarning($"Language {configLanguageCode} is not supported by the API");
            }

            string culture = configLanguage.culture;
            if (!IsCultureCodeSupported(culture))
            {
                Plugin.Log.LogWarning($"Culture {culture} is not supported by the API");
            }
        }

        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (!__instance.Config.languages.Any(x => x.code == languageData.Code))
            {
                Plugin.Log.LogWarning($"Language with culture code {languageData.CultureCode} is not present in the game with its code");
            }

            if (!__instance.Config.languages.Any(x => x.culture == languageData.CultureCode))
            {
                Plugin.Log.LogWarning($"Language with CultureCode {languageData.CultureCode} is not present in the game with its culture code");
            }
        }
    }
}