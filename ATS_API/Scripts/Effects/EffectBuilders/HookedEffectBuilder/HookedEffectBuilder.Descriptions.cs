using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model.Effects;
using Eremite.Model.Effects.Hooked;
using UnityEngine;
using TextArgType = Eremite.Model.Effects.Hooked.TextArgType;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{
    /// <summary>
    /// Cornerstones show a basic description of what it does
    /// This shows the resulting effect when it's picked from the rewardPopup
    /// Set 'startWithCurrentValue' on the hookLogic to make it work retroactively. 
    /// </summary>
    public void SetRetroactiveDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        m_effectModel.retroactivePreviewText =
            LocalizationManager.ToLocaText(m_guid, m_name, "retroactive", description, language);
    }

    public void SetRetroactiveDescriptionArgs(params (HookedStateTextArg.HookedStateTextSource source, int sourceIndex)[] args)
    {
        m_effectModel.hasRetroactivePreview = true;
        m_effectModel.retroactivePreviewArgs = args.ToHookedStateTextArgArray();
    }

    public void SetRetroactiveDescriptionArgs(params HookedStateTextArg[] args)
    {
        m_effectModel.hasRetroactivePreview = true;
        m_effectModel.retroactivePreviewArgs = args;
    }

    /// <summary>
    /// This shows the current effect it has according to the effects. (eg: +10 global resolve)
    /// (Extra for cornerstone)
    /// </summary>
    public void SetPreviewDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        // Additional Tooltip in the bottom left icon of the game showing progress 
        m_effectModel.dynamicPreviewText = LocalizationManager.ToLocaText(m_guid, m_name, "preview", description, language);
    }

    public void SetPreviewDescriptionArgs(params (HookedStateTextArg.HookedStateTextSource source, int sourceIndex)[] args)
    {
        m_effectModel.hasDynamicStatePreview = true;
        m_effectModel.statePreviewArgs = args.ToHookedStateTextArgArray();
    }

    public void SetPreviewDescriptionArgs(params HookedStateTextArg[] args)
    {
        m_effectModel.hasDynamicStatePreview = true;
        m_effectModel.statePreviewArgs = args;
    }

    /// <summary>
    /// Source Index is the index of the hook/hookedEffect
    /// </summary>
    public void SetDescriptionArgs(params (SourceType source, TextArgType type, int sourceIndex)[] args)
    {
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args.ToHookedTextArgArray();
    }

    public void SetDescriptionArgs(params HookedTextArg[] args)
    {
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args;
    }
    
    public void SetRemovalPreviewDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        m_effectModel.removalDynamicPreviewText = LocalizationManager.ToLocaText(m_guid, m_name, "removalDescription", description, language);
    }

    public void SetRemovalPreviewDescriptionArgs(params (HookedStateTextArg.HookedStateTextSource source, int sourceIndex)[] args)
    {
        m_effectModel.hasRemovalDynamicStatePreview = true;
        m_effectModel.removalStatePreviewArgs = args.ToHookedStateTextArgArray();
    }

    public void SetRemovalPreviewDescriptionArgs(params HookedStateTextArg[] args)
    {
        m_effectModel.hasRemovalDynamicStatePreview = true;
        m_effectModel.removalStatePreviewArgs = args;
    }

    /// <summary>
    /// NOTE - when this is set, the amountText field is completely ignored, it doesn't matter what you put in there, it will not do anything.
    /// The system prefers the nestedAmount value first, for use as text in the bottom part of the effect's icon, and only uses amountText as a fallback.
    /// </summary>
    public void SetNestedAmount(SourceType source, TextArgType type, int sourceIndex)
    {
        m_effectModel.hasNestedAmount = true;
        m_effectModel.nestedAmount = new HookedTextArg()
        {
            source = source,
            sourceIndex = sourceIndex,
            type = type,
        };
    }
}