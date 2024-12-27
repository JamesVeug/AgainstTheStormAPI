using System;
using ATS_API.Localization;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingBuilder<T,Y>
{
    [Obsolete("Use SetDescription(description,systemLanguage) instead", true)]
    protected virtual void SetDescription(string description)
    {
        SetDescription(description, SystemLanguage.English);
    }
    
    [Obsolete("Use SetLabel(label,systemLanguage) instead", true)]
    protected void SetLabel(string label)
    {
        m_buildingModel.displayLabel = LocalizationManager.ToLabelModel(m_guid, m_name, "displayLabel", label);
    }
}