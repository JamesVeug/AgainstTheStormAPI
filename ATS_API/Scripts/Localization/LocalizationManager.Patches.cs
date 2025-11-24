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
    [HarmonyPatch(typeof(TextsService), nameof(TextsService.GetTextsFromFile))]
    [HarmonyPostfix]
    private static async UniTask<Dictionary<string, string>> PostGetTextsFromFile(UniTask<Dictionary<string, string>> enumerator, TextsService __instance, string language)
    {
        Dictionary<string, string> result = await enumerator;
        SystemLanguage systemLanguage = CodeToLanguage(language);
        foreach (KeyValuePair<string, Dictionary<SystemLanguage, string>> keyToTranslations in s_newStrings)
        {
            if(keyToTranslations.Value.TryGetValue(systemLanguage, out string translation))
            {
                result[keyToTranslations.Key] = translation;
            }
        }
        
        return result;
    }

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
            APILogger.LogInfo($"Exporting enums to {csExportPath}");
            
            WIKI.CreateAllEnumTypes(Path.Combine(csExportPath, "Enums"));
            WIKI.CreateAllPrefabEnumTypes(Path.Combine(csExportPath, "Enums"));
        }

        // Exports all CSVs, so we can have updated data for the API
        if (Configs.ExportCSVs)
        {
            WIKI.ExportCSVs();
            WIKI.ExportMDs();
        }
    }

    [HarmonyPatch(typeof(TextsService), nameof(TextsService.SetCulture))]
    [HarmonyPostfix]
    private static void PostChangeLanguage(string language)
    {
        APILogger.LogInfo($"Changed language to {language}");
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
                APILogger.LogWarning($"Language {configLanguageCode} is not supported by the API");
            }

            string culture = configLanguage.culture;
            if (!IsCultureCodeSupported(culture))
            {
                APILogger.LogWarning($"Culture {culture} is not supported by the API");
            }
        }

        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (!__instance.Config.languages.Any(x => x.code == languageData.Code))
            {
                APILogger.LogWarning($"Language with culture code {languageData.CultureCode} is not present in the game with its code");
            }

            if (!__instance.Config.languages.Any(x => x.culture == languageData.CultureCode))
            {
                APILogger.LogWarning($"Language with CultureCode {languageData.CultureCode} is not present in the game with its culture code");
            }
        }
    }
}