using System;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{
    public T NewRemovalHook<T>() where T : HookLogic
    {
        T instance = Activator.CreateInstance<T>();
        AddRemovalHook(instance);
        return instance;
    }

    public void AddRemovalHook(HookLogic effect)
    {
        if (m_effectModel.removalHooks == null)
        {
            m_effectModel.removalHooks = [effect];
            m_effectModel.hasRemovalHooks = true;
            return;
        }

        int newSize = m_effectModel.removalHooks.Length + 1;
        Array.Resize(ref m_effectModel.removalHooks, newSize);
        m_effectModel.removalHooks[newSize - 1] = effect;
    }
}