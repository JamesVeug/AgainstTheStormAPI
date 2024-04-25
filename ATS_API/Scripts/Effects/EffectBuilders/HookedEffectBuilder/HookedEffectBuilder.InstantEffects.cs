using System;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{

    public T NewInstantEffect<T>() where T : EffectModel
    {
        T instance = ScriptableObject.CreateInstance<T>();
        AddInstantEffect(instance);
        return instance;
    }

    public void AddInstantEffect(EffectModel effect)
    {
        effect.name = m_effectModel.name = "_instantEffect_" + (m_effectModel.instantEffects.Length + 1);
        if (m_effectModel.instantEffects == null)
        {
            m_effectModel.instantEffects = [effect];
            return;
        }

        int newSize = m_effectModel.instantEffects.Length + 1;
        Array.Resize(ref m_effectModel.instantEffects, newSize);
        m_effectModel.instantEffects[newSize - 1] = effect;
    }
    
    // public HostilityEffectModel AddInstantEffect_IncreaseHostility(int amount = 1)
    // {
    //     HostilityEffectModel effectModel = NewInstantEffect<HostilityEffectModel>();
    //     string name = effectModel.name;
    //     
    //     effectModel.amount = amount;
    //     effectModel.isPerk = false; // Shows in the list of effects on in the bottom left of the screen
    //     effectModel.isPositive = false;
    //     effectModel.displayName = LocalizationManager.ToLocaText(m_guid, name, "Name", "Impatience");
    //     effectModel.description = LocalizationManager.ToLocaText(m_guid, name, "Desc", "ImpatienceDescription");
    //
    //     return effectModel;
    // }
}