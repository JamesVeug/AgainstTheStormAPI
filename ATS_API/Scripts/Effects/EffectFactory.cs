using ATS_API.Effects;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

public static class EffectFactory
{
    public static T NewHookedEffect<T>(IEffectBuilder builder) where T : EffectModel
    {
        T instance = ScriptableObject.CreateInstance<T>();
        instance.description = builder.Model.description;
        instance.displayName = builder.Model.displayName;
        instance.label = builder.Model.label;
        return instance;
    }
    
    public static GlobalResolveEffectEffectModel AddHookedEffect_IncreaseResolve(IEffectBuilder builder, int resolveAmount = 1, ResolveEffectType type = ResolveEffectType.Global)
    {
        GlobalResolveEffectEffectModel effectModel = NewHookedEffect<GlobalResolveEffectEffectModel>(builder);
        effectModel.effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(builder.GUID, builder.Name + "_resolve_effect_model");
        effectModel.effect.resolve = resolveAmount;
        effectModel.effect.description = builder.Model.description;
        effectModel.effect.displayName = builder.Model.displayName;
        effectModel.effect.label = builder.Model.label;
        effectModel.effect.icon = builder.Model.GetIcon();
        effectModel.effect.stacks = true;
        effectModel.effect.removedByStack = false;
        effectModel.effect.displayAsInfinite = false;
        effectModel.effect.type = type;

        return effectModel;
    }
}