using System;
using System.Collections.Generic;
using System.IO;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
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

    public static bool ContainsSaveData(string guid)
    {
        return m_ModSaveData.ContainsKey(guid);
    }

    public static void SaveAllModdedData()
    {
        ModdedSaveManagerService.Instance.SaveAllModdedData();
    }

    public static void SaveModdedData(string guid)
    {
        ModdedSaveManagerService.Instance.SaveModdedData(guid);
    }

    public static void ListenForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        if (!ModdedSaveManagerService.LoadedSaveDataListeners.TryGetValue(guid, out SafeAction<ModSaveData, SaveFileState> listeners))
        {
            listeners = new SafeAction<ModSaveData, SaveFileState>();
            ModdedSaveManagerService.LoadedSaveDataListeners[guid] = listeners;
        }
        
        listeners.AddListener(callback);
    }
    
    public static void StopListeningForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        if (ModdedSaveManagerService.LoadedSaveDataListeners.TryGetValue(guid, out SafeAction<ModSaveData, SaveFileState> listeners))
        {
            listeners.RemoveListener(callback);
        }
    }

    public static void ListenForResetCycleSaveData(string guid, Action<ModSaveData> callback)
    {
        AddListener(guid, callback, ModdedSaveManagerService.ResetCycleSaveDataListeners);
    }

    public static void StopListeningForResetCycleSaveData(string guid, Action<ModSaveData> callback)
    {
        StopListener(guid, callback, ModdedSaveManagerService.ResetCycleSaveDataListeners);
    }

    public static void ListenForResetSettlementSaveData(string guid, Action<ModSaveData> callback)
    {
        AddListener(guid, callback, ModdedSaveManagerService.ResetSettlementSaveDataListeners);
    }

    public static void StopListeningForResetSettlementSaveData(string guid, Action<ModSaveData> callback)
    {
        StopListener(guid, callback, ModdedSaveManagerService.ResetSettlementSaveDataListeners);
    }

    public static void ListenForPreSaveSaveData(string guid, Action<ModSaveData> callback)
    {
        AddListener(guid, callback, ModdedSaveManagerService.PreSaveSaveDataListeners);
    }

    public static void StopListeningForPreSaveSaveData(string guid, Action<ModSaveData> callback)
    {
        StopListener(guid, callback, ModdedSaveManagerService.PreSaveSaveDataListeners);
    }

    public static void AddErrorHandler(string guid, Func<ErrorData, UniTask<ModSaveData>> handler)
    {
        if (!ModdedSaveManagerService.ErrorHandlers.TryGetValue(guid, out SafeFunc<ErrorData, UniTask<ModSaveData>> handlers))
        {
            handlers = new SafeFunc<ErrorData, UniTask<ModSaveData>>();
            ModdedSaveManagerService.ErrorHandlers[guid] = handlers;
        }
        
        handlers.AddListener(handler);
    }
    
    public static void RemoveErrorhandler(string guid, Func<ErrorData, UniTask<ModSaveData>> handler)
    {
        if (ModdedSaveManagerService.ErrorHandlers.TryGetValue(guid, out SafeFunc<ErrorData, UniTask<ModSaveData>> handlers))
        {
            handlers.RemoveListener(handler);
        }
    }

    private static void AddListener(string guid, Action<ModSaveData> callback, Dictionary<string, SafeAction<ModSaveData>> eventCallbacks)
    {
        if (!eventCallbacks.TryGetValue(guid, out SafeAction<ModSaveData> listeners))
        {
            listeners = new SafeAction<ModSaveData>();
            eventCallbacks[guid] = listeners;
        }

        listeners.AddListener(callback);
    }

    private static void StopListener(string guid, Action<ModSaveData> callback, Dictionary<string, SafeAction<ModSaveData>> eventCallbacks)
    {
        if (eventCallbacks.TryGetValue(guid, out SafeAction<ModSaveData> listeners))
        {
            listeners.RemoveListener(callback);
        }
    }
}