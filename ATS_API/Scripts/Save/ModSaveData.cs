using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ATS_API.SaveLoading;

[Serializable]
public class ModSaveData
{
    public string ModGuid;
    
    public SaveData General = new SaveData();
    public SaveData CurrentSettlement = new SaveData();
    public SaveData CurrentCycle = new SaveData();

    public ModSaveData(string guid)
    {
        ModGuid = guid;
    }
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

        object o = Data[key];
        try
        {
            if (o is JObject jObject)
            {
                return jObject.ToObject<T>();
            }
            return (T)Convert.ChangeType(o, typeof(T));
        }
        catch (InvalidCastException e)
        {
            throw new InvalidCastException($"Failed to cast value of key {key} to type {typeof(T)} from type {(o == null ? null : o.GetType())}");
        }
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
