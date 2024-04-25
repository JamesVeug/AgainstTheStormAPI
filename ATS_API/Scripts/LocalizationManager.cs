using System.Collections.Generic;
using UnityEngine;

namespace ATS_API.Localization;

public static partial class LocalizationManager
{
    private class LanguageDictionary : Dictionary<string, string>;

    private static readonly Dictionary<string, LanguageDictionary> s_pendingLanguageStrings = new();

    public static void AddString(string key, string value, SystemLanguage language = SystemLanguage.English)
    {
        string languageCode = LanguageToCode(language);
        if (!s_pendingLanguageStrings.TryGetValue(languageCode, out LanguageDictionary dic))
        {
            dic = new LanguageDictionary();
            s_pendingLanguageStrings[languageCode] = dic;
        }

        dic[key] = value;
    }

    public static string NewString(string guid, string name, string keySuffix, string value, SystemLanguage language = SystemLanguage.English)
    {
        string key = guid + "_" + name + "_" + keySuffix;
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
}