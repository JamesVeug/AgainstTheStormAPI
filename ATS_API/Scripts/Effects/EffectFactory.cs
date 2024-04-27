using ATS_API.Effects;
using Eremite.Model;
using Eremite.Model.Effects;
using UnityEngine;

public static class EffectFactory
{
    public static T NewHookedEffect<T>() where T : EffectModel
    {
        T instance = ScriptableObject.CreateInstance<T>();
        // AddHookedEffect(instance);
        // instance.name = m_effectModel.name + "_hookedEffect_" + m_effectModel.hookedEffects.Length;
        // Plugin.Log.LogInfo("HookedEffectBuilder.NewHookedEffect: " + m_effectModel.name + " hookedEffects.Length: " + m_effectModel.hookedEffects.Length);
        return instance;
    }
    
    public static GlobalResolveEffectEffectModel AddHookedEffect_IncreaseResolve(string guid, string name, int resolveAmount = 1, ResolveEffectType type = ResolveEffectType.Global)
    {
        GlobalResolveEffectEffectModel effectModel = NewHookedEffect<GlobalResolveEffectEffectModel>();
        effectModel.effect = EffectManager.CreateResolveEffect<ResolveEffectModel>(guid, name + "_resolve_effect_model");
        effectModel.effect.resolve = resolveAmount;
        // effectModel.effect.icon = TextureHelper.GetImageAsSprite(pathToIcon, TextureHelper.SpriteType.EffectIcon);
        // effectModel.effect.displayName = LocalizationManager.ToLocaText(guid, name, "Name", "GlobalResolveName");
        // effectModel.effect.description = LocalizationManager.ToLocaText(guid, name, "Desc", "GlobalResolveDescription");
        effectModel.effect.stacks = true;
        effectModel.effect.removedByStack = false;
        effectModel.effect.displayAsInfinite = false;
        effectModel.effect.type = type;

        return effectModel;
    }
}