using System;
using UnityEngine;

namespace ATS_API.Effects;

public partial class EffectBuilder<T>
{
    [Obsolete("Use SetDescription(description,systemLanguage) instead", true)]
    protected virtual void SetDescription(string description)
    {
        SetDescription(description, SystemLanguage.English);
    }
}