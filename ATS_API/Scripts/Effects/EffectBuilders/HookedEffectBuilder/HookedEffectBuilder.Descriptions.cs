using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model.Effects;
using Eremite.Model.Effects.Hooked;
using TextArgType = Eremite.Model.Effects.Hooked.TextArgType;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{
    /// <summary>
    /// Cornerstones show a basic description of what it does
    /// This shows the resulting effect when its picked from the rewardPopup
    /// (Extra for cornerstone)
    /// </summary>
    /// <param name="description"></param>
    public void SetRetroactiveDescription(string description)
    {
        m_effectModel.retroactivePreviewText =
            LocalizationManager.ToLocaText(m_guid, m_name, "retroactive", description);
    }

    public void SetRetroactiveDescriptionArgs(params HookedStateTextArg.HookedStateTextSource[] args)
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
    /// <param name="description"></param>
    public void SetPreviewDescription(string description)
    {
        // Additional Tooltip in the bottom left icon of the game showing progress 
        m_effectModel.dynamicPreviewText = LocalizationManager.ToLocaText(m_guid, m_name, "preview", description);
    }

    public void SetPreviewDescriptionArgs(params HookedStateTextArg.HookedStateTextSource[] args)
    {
        m_effectModel.hasDynamicStatePreview = true;
        m_effectModel.statePreviewArgs = args.ToHookedStateTextArgArray();
    }

    public void SetPreviewDescriptionArgs(params HookedStateTextArg[] args)
    {
        m_effectModel.hasDynamicStatePreview = true;
        m_effectModel.statePreviewArgs = args;
    }

    public void SetDescriptionArgs(params (SourceType source, TextArgType type)[] args)
    {
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args.ToHookedTextArgArray();
    }

    public void SetDescriptionArgs(params HookedTextArg[] args)
    {
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args;
    }
}