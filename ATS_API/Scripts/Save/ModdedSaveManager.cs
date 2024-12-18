using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using Cysharp.Threading.Tasks;
using Eremite;

namespace ATS_API.SaveLoading;

public static partial class ModdedSaveManager
{
    internal static Dictionary<string, ModSaveData> ModGuidToDataLookup => m_ModSaveData;

    /// <summary>
    /// The folder path where mod save data is stored. 
    /// The actual path varies based on the current profile being used.
    /// 
    /// By default, the path is: 
    /// <c>%userprofile%\AppData\LocalLow\Eremite Games\Against the Storm\</c>
    /// 
    /// If you are using the experimental version, the base path is: 
    /// <c>%userprofile%\AppData\LocalLow\Eremite Games\Against the Storm - Experimental\</c>
    /// 
    /// For the default profile, these paths represent the actual save folder locations. 
    /// For other profiles, the save data is stored in the corresponding profile folder. 
    /// In such cases, the folder path would look like: 
    /// <c>%userprofile%\AppData\LocalLow\Eremite Games\Against the Storm {- Experimental}\{profile_id}\</c>
    /// </summary>
    public static string PathToSaveFile => SO.ProfilesService.GetProfileFolderPath();

    private static readonly Dictionary<string, ModSaveData> m_ModSaveData = new Dictionary<string, ModSaveData>();

    /// <summary>
    /// Retrieves the mod save data based on the specified mod GUID.
    /// If the <see cref="ModdedSaveManager"/> is not initialized and load data, 
    /// this method will throw an exception.
    /// </summary>
    /// <param name="guid">The GUID of your mod.</param>
    /// <returns>The <see cref="ModSaveData"/> associated with the specified GUID.</returns>
    /// <exception cref="Exception">Thrown when <see cref="ModdedSaveManager"/> is not initialized.</exception>
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

    /// <summary>
    /// If the <see cref="ModdedSaveManager"/> has any corresponding mod data
    /// </summary>
    /// <param name="guid">mod guid</param>
    /// <returns></returns>
    public static bool ContainsSaveData(string guid)
    {
        return m_ModSaveData.ContainsKey(guid);
    }

    /// <summary>
    /// Save all data to the disk
    /// </summary>
    public static void SaveAllModdedData()
    {
        ModdedSaveManagerService.Instance.SaveAllModdedData();
    }

    /// <summary>
    /// Adds a listener that will be invoked when the corresponding mod data is loaded. 
    /// This typically occurs when the user switches profiles or launches the program for the first time.
    /// </summary>
    /// <param name="guid">The GUID of your mod.</param>
    /// <param name="callback">
    /// A callback function that receives the following parameters:
    /// <see cref="ModSaveData"/> - Contains all the data for the corresponding mod.
    /// <see cref="SaveFileState"/> - Indicates whether the save file is newly created or loaded from existing data.
    /// <list type="bullet">
    ///   <item>
    ///     <see cref="SaveFileState.NewFile"/> - Indicates a new save file was created by the API. 
    ///     Initialization operations may be required in this case.
    ///   </item>
    ///   <item>
    ///     <see cref="SaveFileState.LoadedFile"/> - Indicates the data was loaded from an existing save file.
    ///   </item>
    /// </list>
    /// </param>
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
}