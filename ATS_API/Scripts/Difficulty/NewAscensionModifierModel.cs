using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Ascension;

public class NewAscensionModifierModel
{
    public AscensionModifierModel Model;
    public EffectTypes EffectTypes;
    public LocaText ShortDescription;

    public NewAscensionModifierModel(AscensionModifierModel modifier)
    {
        Model = modifier;
    }
}