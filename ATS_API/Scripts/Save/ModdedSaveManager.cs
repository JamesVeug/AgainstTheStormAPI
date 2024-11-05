using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ATS_API.SaveLoading;

public static partial class ModdedSaveManager
{
    internal static Dictionary<string, ModSaveData> ModGuidToDataLookup => m_ModSaveData;
    
    // %userprofile%\AppData\LocalLow\Eremite Games\Against the Storm\
    public static readonly string PathToSaveFile = Path.Combine(Application.persistentDataPath);

    private static readonly Dictionary<string, ModSaveData> m_ModSaveData = new Dictionary<string, ModSaveData>();

    public static ModSaveData GetSaveData(string guid)
    {
        if (ModdedSaveManagerService.Instance == null || !ModdedSaveManagerService.Instance.Loaded)
        {
            throw new Exception("ModdedSaveManagerService not loaded yet. Use ModdedSaveManager.ListenForLoadedSaveData to wait for it to load instead!");
        }
        
        if (m_ModSaveData.TryGetValue(guid, out var data))
        {
            return data;
        }
        
        m_ModSaveData[guid] = new ModSaveData(guid);
        return m_ModSaveData[guid];
    }

    public static void SaveAllModdedData()
    {
        ModdedSaveManagerService.Instance.SaveAllModdedData();
    }
    
    public static void ListenForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        ModdedSaveManagerService.ListenForLoadedSaveData(guid, callback);
    }
    
    public static void StopListeningForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        ModdedSaveManagerService.StopListeningForLoadedSaveData(guid, callback);
    }

    public static bool ContainsSaveData(string guid)
    {
        return m_ModSaveData.ContainsKey(guid);
    }
}