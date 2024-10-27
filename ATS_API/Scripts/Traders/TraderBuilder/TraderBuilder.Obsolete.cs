using System;
using ATS_API.Localization;
using UnityEngine;

namespace ATS_API.Effects;

public partial class TraderBuilder
{
    [Obsolete("Use SetDescription(description, systemLanguage) instead", true)]
    protected void SetDescription(string description)
    {
        SetDescription(description, SystemLanguage.English);
    }

    [Obsolete("Use SetDialogue(description, systemLanguage) instead", true)]
    protected void SetDialogue(string description)
    {
        SetDialogue(description, SystemLanguage.English);
    }
    
    [Obsolete("Use SetLabel(label,systemLanguage) instead", true)]
    protected void SetLabel(string label)
    {
        m_traderModel.label = LocalizationManager.ToLabelModel(m_guid, m_name, "label", label);
    }
    
    [Obsolete("Use SetAssaultLockedText(description,systemLanguage) instead", true)]
    protected void SetAssaultLockedText(string description)
    {
        m_traderModel.assaultLockedTooltipText = LocalizationManager.ToLocaText(m_guid, m_name, "assaultLockedTooltipText", description);
    }
}