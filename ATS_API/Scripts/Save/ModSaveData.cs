using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ATS_API.SaveLoading;

/// <summary>
/// Manages the save data for a specific mod within a profile.
/// Each profile maintains its own distinct <see cref="ModSaveData"/> instance.
/// - When the player switches profiles, the API automatically loads the corresponding mod data.
/// - All mod data is saved whenever the game performs a save operation, including world saves, settlement saves, and automatic saves.
/// 
/// Note: Some data may be reset or cleared as part of the game's internal mechanisms.
/// </summary>
[Serializable]
public class ModSaveData
{
    /// <summary>
    /// The mod guid
    /// </summary>
    public string ModGuid;

    /// <summary>
    /// Stores metadata related to game history, meta upgrades, achievements, and story elements, 
    /// primarily concerning the game's information in the citadel (the Smoldering City).
    /// </summary>
    public SaveData General = new SaveData();

    /// <summary>
    /// Stores the current settlement data, including information such as buildings, villagers, and orders.
    /// - When starting a new settlement, the data is cleared.
    /// </summary>
    public SaveData CurrentSettlement = new SaveData();

    /// <summary>
    /// Stores data related to the current cycle, which includes:
    /// embark bonuses, established towns, map information, game years, and some game statistics.
    /// - When starting a new cycle, the data is cleared.
    /// </summary>
    public SaveData CurrentCycle = new SaveData();

    /// <summary>
    /// Create a ModSaveData
    /// </summary>
    /// <param name="guid"></param>
    public ModSaveData(string guid)
    {
        ModGuid = guid;
    }
}

/// <summary>
/// This stores the actual data, you can use it like a dictionary.
/// </summary>
[Serializable]
public class SaveData
{
    [JsonProperty]
    private Dictionary<string, object> Data = new Dictionary<string, object>();

    /// <summary>
    /// Get the object with the key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="defaultValue">If the not exists, return default value</param>
    /// <returns></returns>
    /// <exception cref="InvalidCastException"></exception>
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

    /// <summary>
    /// Get the object with the key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public object GetValue(string key, object defaultValue = null)
    {
        if (!Data.ContainsKey(key))
            Data.Add(key, defaultValue);

        return Data[key];
    }

    /// <summary>
    /// Store the object with the key
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public void SetValue(string key, object value)
    {
        Data[key] = value;
    }
}
