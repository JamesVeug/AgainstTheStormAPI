using System.Collections.Generic;
using ATS_API;
using ATS_API.Traders;
using Eremite;
using Eremite.Model;

public static class EffectExtensions
{
    public static List<EffectDrop> ToEffectDrops(this IEnumerable<NameToAmount> collection)
    {
        List<EffectDrop> list = new List<EffectDrop>();
        foreach (NameToAmount effectName in collection)
        {
            if (SO.Settings.ContainsEffect(effectName.Name))
            {
                EffectModel effectModel = SO.Settings.GetEffect(effectName.Name);
                EffectDrop effectDrop = new EffectDrop();
                effectDrop.reward = effectModel;
                effectDrop.chance = effectName.Weight; // 0 - 100
                list.Add(effectDrop);
            }
            else
            {
                Plugin.Log.LogWarning("Can't find effect " + effectName.Name);
            }
        }
        
        return list;
    }
}