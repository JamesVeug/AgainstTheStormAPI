using ATS_API.Effects;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

public static class EffectFactory
{
    public static T NewHookedEffect<T>() where T : EffectModel
    {
        T instance = ScriptableObject.CreateInstance<T>();
        instance.description = Placeholders.Description;
        instance.displayName = Placeholders.DisplayName;
        instance.label = Placeholders.Label;
        return instance;
    }
    
    public static GlobalResolveEffectEffectModel AddHookedEffect_IncreaseResolve(string guid, string name, int resolveAmount = 1, ResolveEffectType type = ResolveEffectType.Global)
    {
        GlobalResolveEffectEffectModel effectModel = NewHookedEffect<GlobalResolveEffectEffectModel>();
        effectModel.effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, name + "_resolve_effect_model");
        effectModel.effect.resolve = resolveAmount;
        effectModel.effect.icon = Placeholders.EffectIcon;
        effectModel.effect.stacks = true;
        effectModel.effect.removedByStack = false;
        effectModel.effect.displayAsInfinite = false;
        effectModel.effect.type = type;

        return effectModel;
    }
}