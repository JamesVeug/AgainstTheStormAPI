using System;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

/// <summary>
/// Factory that creates logic hooks that can be used in perks/effects
/// </summary>
public static class HookFactory
{
    private static T CreateHook<T>() where T : HookLogic
    {
        T instance = Activator.CreateInstance<T>();
        return instance;
    }
    
    public static VillagersAmountHook AfterXNewVillagers(int amount = 1, bool ignoreRemovedVillagers = true)
    {
        VillagersAmountHook hook = CreateHook<VillagersAmountHook>();
        hook.amount = amount;
        hook.ignoreRemovedVillagers = ignoreRemovedVillagers;
        return hook;
    }
}