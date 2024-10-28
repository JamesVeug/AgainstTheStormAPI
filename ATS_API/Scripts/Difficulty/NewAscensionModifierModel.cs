using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Ascension;

public class NewAscensionModifierModel
{
    public string RawName;
    public AscensionModifierModel Model;
    public EffectTypes EffectTypes;
    public LocaText ShortDescription;

    public NewAscensionModifierModel(string rawName, AscensionModifierModel modifier, EffectTypes effect)
    {
        RawName = rawName;
        Model = modifier;
        EffectTypes = effect;
    }
    
    public NewAscensionModifierModel SetShortDescription(string description, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        ShortDescription = LocalizationManager.ToLocaText("", RawName, "shortDescription", description, systemLanguage);
        return this;
    }
}