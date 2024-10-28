using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ATS_API.SaveLoading;

[Serializable]
public class ModSaveData
{
    public SaveData General = new SaveData();
    public SaveData CurrentSettlement = new SaveData();
    public SaveData CurrentCycle = new SaveData();
}

[Serializable]
public class SaveData
{
    [JsonProperty]
    private Dictionary<string, object> Data = new Dictionary<string, object>();
    
    public T GetValueAsObject<T>(string key, T defaultValue = default)
    {
        if (!Data.ContainsKey(key))
            Data.Add(key, defaultValue);

        return (T)Data[key];
    }
    
    public object GetValue(string key, object defaultValue = null)
    {
        if (!Data.ContainsKey(key))
            Data.Add(key, defaultValue);

        return Data[key];
    }

    public void SetValue(string key, object value)
    {
        Data[key] = value;
    }
}
