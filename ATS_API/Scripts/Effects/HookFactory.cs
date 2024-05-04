using System;
using Eremite.Model;
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
        instance.description = Placeholders.Description;
        return instance;
    }
    
    public static VillagersAmountHook AfterXNewVillagers(int amount = 1, bool ignoreRemovedVillagers = true)
    {
        VillagersAmountHook hook = CreateHook<VillagersAmountHook>();
        hook.amount = amount;
        hook.ignoreRemovedVillagers = ignoreRemovedVillagers;
        return hook;
    }
    
    public static SeasonChangeHook AfterSeasonChanges(Seasons seasons, int yearlyInterval = 1, bool removeAfterSeasonEnds = false)
    {
        SeasonChangeHook effectModel = CreateHook<SeasonChangeHook>();
        effectModel.season = seasons > Seasons.All ? seasons.ToSeason() : Season.Drizzle;
        if (seasons == Seasons.All)
        {
            effectModel.anySeason = true;
        }
        effectModel.yearsInterval = yearlyInterval;
        effectModel.removeAfterSeasonEnds = removeAfterSeasonEnds;
        return effectModel;
    }
}