using Eremite.Model;
using UnityEngine;

namespace ATS_API.Localization;

public static partial class LocalizationManager
{
    public static LocaText ToLocaText(this string key)
    {
        return new LocaText() { key = key };
    }

    public static LocaText ToLocaText(string guid, string name, string keySuffix, string value,
        SystemLanguage language = SystemLanguage.English)
    {
        string key = NewString(guid, name, keySuffix, value, language);
        return new LocaText() { key = key };
    }

    public static LabelModel ToLabelModel(string guid, string name, string keySuffix, string value,
        SystemLanguage language = SystemLanguage.English)
    {
        LocaText key = ToLocaText(guid, name, keySuffix, value, language);
        LabelModel model = ScriptableObject.CreateInstance<LabelModel>();
        model.displayName = key;
        return model;
    }

    public static LabelModel ToLabelModel(this string keyNotText)
    {
        LabelModel model = ScriptableObject.CreateInstance<LabelModel>();
        model.displayName = new LocaText() { key = keyNotText };
        return model;
    }
}