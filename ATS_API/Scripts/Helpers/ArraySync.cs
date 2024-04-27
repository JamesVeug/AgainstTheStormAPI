using System;
using System.Collections.Generic;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

public class ArraySync<ATS, API> where ATS : SO where API : ASyncable<ATS>
{
    private int m_baseLength = -1;
    private string m_Name;

    public ArraySync(string name)
    {
        m_Name = name;
    }

    public List<API> Sync(ref ATS[] array, ModelCache<ATS> settingsEffectsCache, IEnumerable<API> newElements, Func<API, ATS> getter)
    {
        if(m_baseLength < 0)
        {
            m_baseLength = array.Length;
        }
        
        List<API> pending = new List<API>(); // TODO: Pool this
        foreach (API t in newElements)
        {
            ATS so = getter(t);
            if (Array.IndexOf(array, so, m_baseLength) == -1)
            {
                pending.Add(t);
            }
        }
        
        if (pending.Count == 0)
        {
            Plugin.Log.LogInfo($"{m_Name} has all new elements!");
            return pending;
        }
        
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + pending.Count);
        for (int i = 0; i < pending.Count; i++)
        {
            API syncable = pending[i];
            ATS ats = getter(syncable);
            syncable.Sync(ats);
            array[startingIndex + i] = ats;
        }
        
        // string result = "";
        // foreach (ATS so in array)
        // {
        //     result += so.name + ", ";
        // }
        // Plugin.Log.LogInfo($"{m_Name} now has {array.Length} effects: {result}");

        settingsEffectsCache.cache = null;
        return pending;
    }
}