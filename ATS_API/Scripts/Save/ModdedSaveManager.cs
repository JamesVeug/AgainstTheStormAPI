using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace ATS_API.SaveLoading;

public static partial class ModdedSaveManager
{
    // %userprofile%\AppData\LocalLow\Eremite Games\Against the Storm\ATS_API.moddedsave
    private static readonly string saveFilePath = Path.Combine(Application.persistentDataPath);

    private static readonly Dictionary<string, ModSaveData> saveData = new Dictionary<string, ModSaveData>();
    
    static ModdedSaveManager()
    {
        LoadAllModdedFiles();
    }
    
    public static ModSaveData GetSaveData(string guid)
    {
        string cleanedGUID = CleanGuid(guid);
        if (saveData.TryGetValue(cleanedGUID, out var data))
        {
            return data;
        }
        
        saveData[cleanedGUID] = new ModSaveData();
        return saveData[cleanedGUID];
    }

    /// <summary>
    /// Remove any characters that would upset a file path
    /// </summary>
    private static string CleanGuid(string guid)
    {
        return guid.Replace("/", "").Replace("\\", "").Replace(":", "").Replace("*", "")
            .Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "")
            .Replace("|", "").Replace(".", "_");
    }

    private static void LoadAllModdedFiles()
    {
        foreach (string fullFilePath in Directory.GetFiles(saveFilePath, "*.moddedsave"))
        {
            try
            {
                string json = File.ReadAllText(fullFilePath);
                var saveData = JsonConvert.DeserializeObject<ModSaveData>(json);

                string guid = Path.GetFileNameWithoutExtension(fullFilePath);
                ModdedSaveManager.saveData[guid] = saveData;
            } catch (Exception e)
            {
                Plugin.Log.LogError($"Failed to load save file {fullFilePath}");
                Plugin.Log.LogError(e);
            }
        }
    }

    private static void SaveAllModdedData()
    {
        foreach (var kvp in saveData)
        {
            string guid = kvp.Key;
            ModSaveData data = kvp.Value;

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            string fullFilePath = Path.Combine(saveFilePath, $"{guid}.moddedsave");
            File.WriteAllText(fullFilePath, json);
            Plugin.Log.LogInfo($"Saved modded data for {guid}");
        }
    }
}