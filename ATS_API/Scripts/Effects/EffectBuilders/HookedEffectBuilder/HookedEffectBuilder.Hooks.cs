using System;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

public partial class HookedEffectBuilder
{
    public T NewHook<T>() where T : HookLogic
    {
        T instance = Activator.CreateInstance<T>();
        AddHook(instance);
        return instance;
    }

    public void AddHook(HookLogic hook)
    {
        if (m_effectModel.hooks == null)
        {
            m_effectModel.hooks = [hook];
            return;
        }

        int newSize = m_effectModel.hooks.Length + 1;
        Array.Resize(ref m_effectModel.hooks, newSize);
        m_effectModel.hooks[m_effectModel.hooks.Length - 1] = hook;
    }
}