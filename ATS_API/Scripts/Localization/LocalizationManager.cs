using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Services;
using UnityEngine;

namespace ATS_API.Localization;

public static partial class LocalizationManager
{
    private static readonly Dictionary<string, Dictionary<SystemLanguage, string>> s_pendingLanguageStrings = new();
    
    private static readonly Dictionary<string, Dictionary<SystemLanguage, string>> s_newStrings = new();

    private static bool m_isDirty = false;

    public static void Instantiate()
    {
        AddString(Keys.GenericPopup_Header_Key, "Something went wrong!");
        AddString(Keys.GenericPopup_Description_Key, "Check logs for more information");
        AddString(Keys.GenericPopup_ExceptionDescription_Key, "{0}\n\nAn exception occurred:");
        AddString(Keys.GenericPopup_ContinueAtRisk_Key, "Continue the game where some content may not work.");
        AddString(Keys.GenericPopup_QuitGameAndDisableMod_Key, "Close the game and disable the affected mod.");
        AddString(Keys.GenericPopup_YouHaveXOptions_Key, "You have {0} options:");
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
            case SystemLanguage.ChineseSimplified:
                return "zh-CN";
            case SystemLanguage.ChineseTraditional:
                return "zh-CT"; // Normally this is TW but ATS uses CT for traditional
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
            case "zh-CN":
                return SystemLanguage.ChineseSimplified;
            case "zh-CT":
                return SystemLanguage.ChineseTraditional;
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