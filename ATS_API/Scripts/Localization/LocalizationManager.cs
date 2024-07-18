using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Services;
using UnityEngine;

namespace ATS_API.Localization;

public static partial class LocalizationManager
{
    private static readonly Dictionary<string, LanguageDictionary> s_pendingLanguageStrings = new();
    
    private static readonly Dictionary<SystemLanguage, LanguageDictionary> s_languageStrings = new();

    private static bool m_isDirty = false;
    private static bool m_coreGameLoaded = false;
    
    public static void Tick()
    {
        if (!m_isDirty || !m_coreGameLoaded)
        {
            return;
        }

        m_isDirty = false;
        Sync();
    }

    private static void Sync()
    {
        TextsService textsService = (TextsService)MB.TextsService;
        if (s_pendingLanguageStrings.TryGetValue(textsService.CurrentLocaCode, out LanguageDictionary dic))
        {
            foreach (KeyValuePair<string, string> pair in dic)
            {
                textsService.texts[pair.Key] = pair.Value;
            }
        }
        s_pendingLanguageStrings.Clear();
    }

    public static async UniTask LoadAllLanguageStrings()
    {
        Plugin.Log.LogInfo("Loading all language strings...");
        foreach (string languageCode in MB.TextsService.GetSupportedLanguages())
        {
            var dictionary = await ((TextsService)MB.TextsService).GetTextsFromFile(languageCode);
            
            SystemLanguage language = CodeToLanguage(languageCode);
            s_languageStrings[language] = new LanguageDictionary(dictionary);
        }
        Plugin.Log.LogInfo("All language strings loaded. (Count: " + s_languageStrings.Count + ")");
    }

    public static void AddString(string key, string value, SystemLanguage language = SystemLanguage.English)
    {
        string languageCode = LanguageToCode(language);
        if (!s_pendingLanguageStrings.TryGetValue(languageCode, out LanguageDictionary dic))
        {
            dic = new LanguageDictionary();
            s_pendingLanguageStrings[languageCode] = dic;
        }

        dic[key] = value;
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
    
    /// <summary>
    /// Requires LoadAllLanguageStrings to be called at least once
    /// </summary>
    public static Dictionary<SystemLanguage, string> GetAllTranslationsFromKey(string key)
    {
        Dictionary<SystemLanguage, string> translations = new Dictionary<SystemLanguage, string>(s_languageStrings.Count);
        foreach (KeyValuePair<SystemLanguage, LanguageDictionary> pair in s_languageStrings)
        {
            if(pair.Value.TryGetValue(key, out string value))
            {
                translations[pair.Key] = value;
            }
        }

        return translations;
    }

    public static string LanguageToCode(SystemLanguage language)
    {
        switch (language)
        {
            case SystemLanguage.English:
                return "en";
            case SystemLanguage.Afrikaans:
                return "af";
            case SystemLanguage.Arabic:
                return "ar";
            case SystemLanguage.Basque:
                return "eu";
            case SystemLanguage.Belarusian:
                return "be";
            case SystemLanguage.Bulgarian:
                return "bg";
            case SystemLanguage.Catalan:
                return "ca";
            case SystemLanguage.Chinese:
                return "zh";
            case SystemLanguage.Czech:
                return "cs";
            case SystemLanguage.Danish:
                return "da";
            case SystemLanguage.Dutch:
                return "nl";
            case SystemLanguage.Estonian:
                return "et";
            case SystemLanguage.Faroese:
                return "fo";
            case SystemLanguage.Finnish:
                return "fi";
            case SystemLanguage.French:
                return "fr";
            case SystemLanguage.German:
                return "de";
            case SystemLanguage.Greek:
                return "el";
            case SystemLanguage.Hebrew:
                return "he";
            case SystemLanguage.Icelandic:
                return "is";
            case SystemLanguage.Indonesian:
                return "id";
            case SystemLanguage.Italian:
                return "it";
            case SystemLanguage.Japanese:
                return "ja";
            case SystemLanguage.Korean:
                return "ko";
            case SystemLanguage.Latvian:
                return "lv";
            case SystemLanguage.Lithuanian:
                return "lt";
            case SystemLanguage.Norwegian:
                return "no";
            case SystemLanguage.Polish:
                return "pl";
            case SystemLanguage.Portuguese:
                return "pt";
            case SystemLanguage.Romanian:
                return "ro";
            case SystemLanguage.Russian:
                return "ru";
            case SystemLanguage.SerboCroatian:
                return "sh";
            case SystemLanguage.Slovak:
                return "sk";
            case SystemLanguage.Slovenian:
                return "sl";
            case SystemLanguage.Spanish:
                return "es";
            case SystemLanguage.Swedish:
                return "sv";
            case SystemLanguage.Thai:
                return "th";
            case SystemLanguage.Turkish:
                return "tr";
            case SystemLanguage.Ukrainian:
                return "uk";
            case SystemLanguage.Vietnamese:
                return "vi";
            default:
                return "en"; //Default to English if the language is not in the list
        }
    }

    public static SystemLanguage CodeToLanguage(string code)
    {
        switch (code)
        {
            case "en":
                return SystemLanguage.English;
            case "af":
                return SystemLanguage.Afrikaans;
            case "ar":
                return SystemLanguage.Arabic;
            case "eu":
                return SystemLanguage.Basque;
            case "be":
                return SystemLanguage.Belarusian;
            case "bg":
                return SystemLanguage.Bulgarian;
            case "ca":
                return SystemLanguage.Catalan;
            case "zh":
                return SystemLanguage.Chinese;
            case "cs":
                return SystemLanguage.Czech;
            case "da":
                return SystemLanguage.Danish;
            case "nl":
                return SystemLanguage.Dutch;
            case "et":
                return SystemLanguage.Estonian;
            case "fo":
                return SystemLanguage.Faroese;
            case "fi":
                return SystemLanguage.Finnish;
            case "fr":
                return SystemLanguage.French;
            case "de":
                return SystemLanguage.German;
            case "el":
                return SystemLanguage.Greek;
            case "he":
                return SystemLanguage.Hebrew;
            case "is":
                return SystemLanguage.Icelandic;
            case "id":
                return SystemLanguage.Indonesian;
            case "it":
                return SystemLanguage.Italian;
            case "ja":
                return SystemLanguage.Japanese;
            case "ko":
                return SystemLanguage.Korean;
            case "lv":
                return SystemLanguage.Latvian;
            case "lt":
                return SystemLanguage.Lithuanian;
            case "no":
                return SystemLanguage.Norwegian;
            case "pl":
                return SystemLanguage.Polish;
            case "pt":
                return SystemLanguage.Portuguese;
            case "ro":
                return SystemLanguage.Romanian;
            case "ru":
                return SystemLanguage.Russian;
            case "sh":
                return SystemLanguage.SerboCroatian;
            case "sk":
                return SystemLanguage.Slovak;
            case "sl":
                return SystemLanguage.Slovenian;
            case "es":
                return SystemLanguage.Spanish;
            case "sv":
                return SystemLanguage.Swedish;
            case "th":
                return SystemLanguage.Thai;
            case "tr":
                return SystemLanguage.Turkish;
            case "uk":
                return SystemLanguage.Ukrainian;
            case "vi":
                return SystemLanguage.Vietnamese;
            default:
                return SystemLanguage.English; //Default to English if the language is not in the list
        }
    }
}