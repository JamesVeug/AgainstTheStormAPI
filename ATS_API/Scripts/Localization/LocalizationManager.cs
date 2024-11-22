using System;
using System.Collections.Generic;
using System.IO;
using ATS_API.Helpers;
using Eremite;
using Eremite.Services;
using UnityEngine;

namespace ATS_API.Localization;

public static partial class LocalizationManager
{
    private class LanguageData
    {
        public SystemLanguage Language;
        public string Code;
        public string CultureCode;
    }

    private static readonly List<LanguageData> s_supportedlanguages = new List<LanguageData>()
    {
        new LanguageData() { Language = SystemLanguage.English,             Code = "en",        CultureCode = "en-US" },
        new LanguageData() { Language = SystemLanguage.Czech,               Code = "cs",        CultureCode = "cs-CS" },
        new LanguageData() { Language = SystemLanguage.German,              Code = "de",        CultureCode = "de-DE" },
        new LanguageData() { Language = SystemLanguage.Spanish,             Code = "es",        CultureCode = "es-ES" },
        new LanguageData() { Language = SystemLanguage.Spanish,             Code = "es-LATAM",  CultureCode = "es-MX" }, // Latin America
        new LanguageData() { Language = SystemLanguage.French,              Code = "fr",        CultureCode = "fr-FR" },
        new LanguageData() { Language = SystemLanguage.Hungarian,           Code = "hu",        CultureCode = "hu-HU" },
        new LanguageData() { Language = SystemLanguage.Italian,             Code = "it",        CultureCode = "it-IT" },
        new LanguageData() { Language = SystemLanguage.Japanese,            Code = "ja",        CultureCode = "ja-JP" },
        new LanguageData() { Language = SystemLanguage.Korean,              Code = "ko",        CultureCode = "ko-KR" },
        new LanguageData() { Language = SystemLanguage.Polish,              Code = "pl",        CultureCode = "pl-PL" },
        new LanguageData() { Language = SystemLanguage.Portuguese,          Code = "pt",        CultureCode = "pt-BR" },
        new LanguageData() { Language = SystemLanguage.Russian,             Code = "ru",        CultureCode = "ru-RU" },
        new LanguageData() { Language = SystemLanguage.Thai,                Code = "th",        CultureCode = "th-TH" },
        new LanguageData() { Language = SystemLanguage.Turkish,             Code = "tr",        CultureCode = "tr-TR" },
        new LanguageData() { Language = SystemLanguage.Ukrainian,           Code = "ua",        CultureCode = "uk-UA" },
        new LanguageData() { Language = SystemLanguage.Chinese,             Code = "zh-CN",     CultureCode = "zh-CN" },
        new LanguageData() { Language = SystemLanguage.ChineseSimplified,   Code = "zh-CN",     CultureCode = "zh-CN" },
        new LanguageData() { Language = SystemLanguage.ChineseTraditional,  Code = "zh-CT",     CultureCode = "zh-Hant" },
    };
    
    private static readonly Dictionary<string, Dictionary<SystemLanguage, string>> s_pendingLanguageStrings = new();
    
    private static readonly Dictionary<string, Dictionary<SystemLanguage, string>> s_newStrings = new();

    private static bool m_isDirty = false;

    public static void Instantiate()
    {
        // Look for localizedText.csv in the same path as PluginDirectory
        string[] files = Directory.GetFiles(Plugin.PluginDirectory, "localizedText.tsv", SearchOption.AllDirectories);
        if (files.Length == 0)
        {
            Debug.LogError($"Could not find localizedText.csv in: {Plugin.PluginDirectory}");
            return;
        }
        
        string path = files[0];
        LoadTSV(PluginInfo.PLUGIN_GUID, path);
    }

    public static void LoadCSV(string guid, string path)
    {
        LoadFile(guid, path, ',');
    }
    
    public static void LoadTSV(string guid, string path)
    {
        LoadFile(guid, path, '\t');
    }
    
    private static void LoadFile(string guid, string path, char separator)
    {
        string[] lines = null;

        try
        {
            lines = System.IO.File.ReadAllLines(path);
            if (lines.Length < 3)
            {
                Plugin.Log.LogError($"Read .csv but has less than 3 lines!. The file is likely corrupt.\n" + Environment.StackTrace);
                return;
            }
        }
        catch (Exception e)
        {
            Plugin.Log.LogError($"Could not read .csv from: {path}\n" + Environment.StackTrace);
            Plugin.Log.LogError(e);
            return;
        }

        string[] headers = lines[0].Split(separator);
        string[] cultureCodes = lines[1].Split(separator);
        for (int i = 2; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(separator);
            
            string key = values[0];
            if (!string.IsNullOrEmpty(guid))
            {
                key = guid + "_" + key;
            }
            
            for (int j = 1; j < values.Length; j++)
            {
                try
                {
                    string cultureCode = cultureCodes[j]; // en-UA or es-MX or uk-UA
                    SystemLanguage language = CultureCodeToLanguage(cultureCode);
                    if (language == SystemLanguage.Afrikaans)
                    {
                        continue;
                    }

                    string value = values[j];
                    AddString(key, value, language);
                }
                catch (Exception e)
                {
                    Plugin.Log.LogError($"Error parsing line {i} column {j} in {path}. Check there's no {separator.ToLiteral()} anywhere in your code!\n" + Environment.StackTrace);
                    Plugin.Log.LogError(e);
                    return;
                }
            }
        }
    }

    public static void Tick()
    {
        if (!m_isDirty)
        {
            return;
        }

        m_isDirty = false;
        Sync();
    }

    private static void Sync()
    {
        SystemLanguage language = CodeToLanguage(MB.TextsService.CurrentLocaCode);
        foreach (KeyValuePair<string,Dictionary<SystemLanguage,string>> pair in s_pendingLanguageStrings)
        {
            AddKeyToTextService(pair.Key, pair.Value, language);
        }
        s_pendingLanguageStrings.Clear();
    }

    private static void AddKeyToTextService(string key, Dictionary<SystemLanguage,string> translations, SystemLanguage language)
    {
        TextsService textsService = (TextsService)MB.TextsService;
        
        if (!translations.TryGetValue(language, out string value))
        {
            // Don't have a translation for the current language
            // See if we can show something else instead
            if (!TryGetFallbackValue(translations, language, out value))
            {
                return;
            }
        }
        
        // Add key to the game so it can be displayed
        textsService.texts[key] = value;
    }
    
    private static bool TryGetFallbackValue(Dictionary<SystemLanguage, string> translations, SystemLanguage language, out string value)
    {
        if (translations.Count == 0)
        {
            value = null;
            return false;
        }
        
        // Specified language does not exist
        if (language == SystemLanguage.ChineseTraditional && translations.TryGetValue(SystemLanguage.ChineseSimplified, out value))
        {
            // ChineseTraditional Fallback to ChineseSimplified
            return true;
        }
        
        // Specified language does not exist
        if (language == SystemLanguage.ChineseSimplified && translations.TryGetValue(SystemLanguage.ChineseTraditional, out value))
        {
            // ChineseSimplified Fallback to ChineseTraditional
            return true;
        }
        
        // No fallbacks - try and use english for consistency
        if (language != SystemLanguage.English && translations.TryGetValue(SystemLanguage.English, out value))
        {
            // Fallback to English
            return true;
        }
        
        // No english. Try anything
        value = translations.Values.GetEnumerator().Current;
        return true;
    }

    public static void AddString(string key, string value, SystemLanguage language = SystemLanguage.English)
    {
        string languageCode = LanguageToCode(language);
        SystemLanguage internalLanguage = CodeToLanguage(languageCode); // Some languages shared LanguageCode so this keeps it consistent
        
        // Queue string to sync later
        if (!s_pendingLanguageStrings.TryGetValue(key, out Dictionary<SystemLanguage, string> pendingDictionary))
        {
            pendingDictionary = new Dictionary<SystemLanguage, string>();
            s_pendingLanguageStrings[key] = pendingDictionary;
        }
        
        // Record all new strings for when the language is changed
        if(!s_newStrings.TryGetValue(key, out Dictionary<SystemLanguage, string> newStringsDictionary))
        {
            newStringsDictionary = new Dictionary<SystemLanguage, string>();
            s_newStrings[key] = newStringsDictionary;
        }

        newStringsDictionary[internalLanguage] = value;
        pendingDictionary[internalLanguage] = value;
        m_isDirty = true;
    }

    public static string NewString(string guid, string name, string keySuffix, string value,
        SystemLanguage language = SystemLanguage.English)
    {
        string guidPrefix = !string.IsNullOrEmpty(guid) ? guid + "_" : "";
        string key = guidPrefix + name + "_" + keySuffix;
        AddString(key, value, language);
        return key;
    }

    public static string LanguageToCode(SystemLanguage language)
    {
        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (languageData.Language == language)
            {
                return languageData.Code;
            }
        }

        Plugin.Log.LogError($"Could not find language code for {language}\n" + Environment.StackTrace);
        return "en";
    }

    public static SystemLanguage CodeToLanguage(string code)
    {
        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (languageData.Code == code)
            {
                return languageData.Language;
            }
        }

        Plugin.Log.LogError($"Could not find language for code {code}\n" + Environment.StackTrace);
        return SystemLanguage.English;
    }
    
    public static SystemLanguage CultureCodeToLanguage(string code)
    {
        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (languageData.CultureCode == code)
            {
                return languageData.Language;
            }
        }

        Plugin.Log.LogError($"Could not find language for culture code {code}\n" + Environment.StackTrace);
        return SystemLanguage.English;
    }
    
    public static bool IsLanguageCodeSupported(string code)
    {
        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (languageData.Code == code)
            {
                return true;
            }
        }

        return false;
    }
    
    public static bool IsCultureCodeSupported(string code)
    {
        foreach (LanguageData languageData in s_supportedlanguages)
        {
            if (languageData.CultureCode == code)
            {
                return true;
            }
        }

        return false;
    }
}