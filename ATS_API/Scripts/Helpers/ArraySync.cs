using System;
using System.Collections.Generic;
using System.Linq;
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
        
        List<API> elementsToAdd = new List<API>(); // TODO: Pool this
        foreach (API t in newElements)
        {
            if (!t.Sync())
            {
                continue;
            }
            Plugin.PostTick.AddListener(t.PostSync);
            
            ATS so = getter(t);
            if (Array.IndexOf(array, so, m_baseLength) == -1)
            {
                elementsToAdd.Add(t);
            }
        }
        
        if (elementsToAdd.Count == 0)
        {
            APILogger.LogDebug($"{m_Name} has no new elements!");
            return elementsToAdd;
        }
        
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + elementsToAdd.Count);
        for (int i = 0; i < elementsToAdd.Count; i++)
        {
            API syncable = elementsToAdd[i];
            ATS ats = getter(syncable);
            array[startingIndex + i] = ats;
            APILogger.LogDebug($"{m_Name} adding {ats.name}");
        }
        
        // APILogger.LogDebug($"{m_Name} now has {array.Length} elements: {string.Join(",", array.Select(a=>a.name))}");

        if (settingsEffectsCache != null)
        {
            settingsEffectsCache.cache = null;
        }

        return elementsToAdd;
    }
}