using System;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{

    public T NewHookedEffect<T>() where T : EffectModel
    {
        T instance = ScriptableObject.CreateInstance<T>();
        AddHookedEffect(instance);
        Plugin.Log.LogInfo("HookedEffectBuilder.NewHookedEffect: " + m_effectModel.name + " hookedEffects.Length: " + m_effectModel.hookedEffects.Length);
        return instance;
    }

    public void AddHookedEffect(EffectModel effect)
    {
        effect.name = m_effectModel.name + "_hookedEffect_" + (m_effectModel.instantEffects.Length + 1);
        SetMissingFields(effect);
        
        if (m_effectModel.hookedEffects == null)
        {
            m_effectModel.hookedEffects = [effect];
            return;
        }

        int newSize = m_effectModel.hookedEffects.Length + 1;
        Array.Resize(ref m_effectModel.hookedEffects, newSize);
        m_effectModel.hookedEffects[newSize - 1] = effect;
    }
    
    // public GlobalResolveEffectEffectModel AddHookedEffect_IncreaseResolve(string pathToIcon, int resolveAmount = 1, ResolveEffectType type = ResolveEffectType.Global)
    // {
    //     GlobalResolveEffectEffectModel effectModel = NewHookedEffect<GlobalResolveEffectEffectModel>();
    //     string name = effectModel.name;
    //     effectModel.effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(m_guid, name + "_resolve_effect_model");
    //     effectModel.effect.resolve = resolveAmount;
    //     effectModel.effect.icon = TextureHelper.GetImageAsSprite(pathToIcon, TextureHelper.SpriteType.EffectIcon);
    //     effectModel.effect.displayName = LocalizationManager.ToLocaText(m_guid, name, "Name", "GlobalResolveName");
    //     effectModel.effect.description = LocalizationManager.ToLocaText(m_guid, name, "Desc", "GlobalResolveDescription");
    //     effectModel.effect.stacks = true;
    //     effectModel.effect.removedByStack = false;
    //     effectModel.effect.displayAsInfinite = false;
    //     effectModel.effect.type = type;
    //
    //     return effectModel;
    // }
}