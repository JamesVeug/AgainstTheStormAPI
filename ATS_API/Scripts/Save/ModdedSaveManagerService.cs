using System;
using System.Collections.Generic;
using System.IO;
using ATS_API.Localization;
using Cysharp.Threading.Tasks;
using Eremite;
using Eremite.Model.SaveSupport;
using Eremite.Services;
using Eremite.View.SaveSupport;
using HarmonyLib;
using Newtonsoft.Json;
using UniRx;
using UnityEngine;

namespace ATS_API.SaveLoading;

[HarmonyPatch]
internal class ModdedSaveManagerService : Service
{
    public static ModdedSaveManagerService Instance { get; private set; }
    
    public static Dictionary<string, SafeAction<ModSaveData, SaveFileState>> LoadedSaveDataListeners = new();
    
    public override UniTask OnLoading()
    {
        return LoadAllSaves();
    }

    private async UniTask LoadAllSaves()
    {
        foreach (KeyValuePair<string,SafeAction<ModSaveData,SaveFileState>> pair in LoadedSaveDataListeners)
        {
            string guid = pair.Key;
            var callback = pair.Value;
            string saveFilePath = Path.Combine(ModdedSaveManager.PathToSaveFile, $"{CleanGuid(pair.Key)}.moddedsave");
            if (File.Exists(saveFilePath))
            {
                try
                {
                    // Try loading the file
                    string json = File.ReadAllText(saveFilePath);
                    ModSaveData saveData = JsonConvert.DeserializeObject<ModSaveData>(json);
                    ModdedSaveManager.ModGuidToDataLookup[saveData.ModGuid] = saveData;
                    Plugin.Log.LogInfo($"Loaded save file {saveFilePath}");
                    
                    // Tell any listeners (the mod) that we loaded the data
                    // If the listener throws an exception handle that too
                    await Callback(guid, callback, saveData, SaveFileState.LoadedFile);
                    continue;
                }
                catch (Exception e)
                {
                    // Something went wrong when loading the file
                    // As the user what they want to do (Use backup, Delete, Go to the discord)
                    Plugin.Log.LogError($"Failed to load save file {saveFilePath}");
                    Plugin.Log.LogError(e);

                    string fileName = Path.GetFileName(saveFilePath);
                    ModSaveData handled = await HandleCorruptionTask<ModSaveData>(CreateSaveCorruptionTask(saveFilePath, fileName));
                    if (handled != null)
                    {
                        ModdedSaveManager.ModGuidToDataLookup[guid] = handled;
                        await Callback(guid, callback, handled, SaveFileState.LoadedFile);
                        continue;
                    }
                }
            }

            // If the file doesn't exist, create a new one
            // If the listener throws an exception handle that too
            Plugin.Log.LogInfo($"Creating new save file for {guid}");
            ModSaveData data = new ModSaveData(guid);
            ModdedSaveManager.ModGuidToDataLookup[guid] = data;
            await Callback(guid, callback, data, SaveFileState.NewFile);
        }
    }

    private static async UniTask Callback(string guid, SafeAction<ModSaveData, SaveFileState> callback, ModSaveData saveData, SaveFileState fileState)
    {
        await callback.Invoke(saveData, fileState, async (Exception e) =>
        {
            await GenericPopupTask.Exception(guid, "Tried invoking callback after loading a mods save data.", e)
                .WaitForDecision(new GenericPopupTask.ButtonInfo
                {
                    Key = APIKeys.Continue_Key,
                    OptionKey = APIKeys.GenericPopup_ContinueAtRisk_Key,
                    Type = GenericPopupTask.ButtonTypes.Normal,
                    OnPressed = () => { }
                },
                new GenericPopupTask.ButtonInfo
                {
                    Key = APIKeys.Quit_Key,
                    OptionKey = APIKeys.GenericPopup_QuitGameAndDisableMod_Key,
                    Type = GenericPopupTask.ButtonTypes.CTA,
                    OnPressed = Application.Quit
                }
                );
            return true;
        });
    }

    private SaveCorruptionTask CreateSaveCorruptionTask(string path, string fileDisplayNameKey)
    {
        return new SaveCorruptionTask
        {
            filePath = path,
            fileDisplayNameKey = fileDisplayNameKey,
            backupExist = DoesBackupExist(path),
            backupDate = GetBackupDate(path),
            completionSource = new UniTaskCompletionSource()
        };
    }

    private DateTime GetBackupDate(string path)
    {
        return File.GetLastWriteTime(path + "_backup");
    }

    private bool DoesBackupExist(string path)
    {
        return File.Exists(path + "_backup");
    }

    private async UniTask<T> HandleCorruptionTask<T>(SaveCorruptionTask task)
    {
        await WaitForDecision(task);
        if (task.decision == SaveCorruptionDecision.Backup)
            return LoadBackup<T>(task);
        if (task.decision == SaveCorruptionDecision.Delete)
            return Delete<T>(task);
        
        throw new NotImplementedException(task.decision.ToString());
    }

    private async UniTask WaitForDecision(SaveCorruptionTask task)
    {
        ReactiveProperty<SaveCorruptionTask> CorruptionTask = SO.Services.SavesIOService.CorruptionTask;
        CorruptionTask.Value = task;
        await task.completionSource.Task;
        CorruptionTask.Value = null;
    }

    private T LoadBackup<T>(SaveCorruptionTask task)
    {
        return JsonConvert.DeserializeObject<T>(task.filePath + "_backup");
    }

    private T Delete<T>(SaveCorruptionTask task)
    {
        File.Delete(task.filePath);
        return default(T);
    }

    public override IService[] GetDependencies()
    {
        return new IService[] { SO.Services.SavesIOService, SO.Services.TextsService };
    }

    public void SaveAllModdedData()
    {
        foreach (KeyValuePair<string, ModSaveData> kvp in ModdedSaveManager.ModGuidToDataLookup)
        {
            string guid = kvp.Key;
            ModSaveData data = kvp.Value;

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            string fullFilePath = Path.Combine(ModdedSaveManager.PathToSaveFile, $"{CleanGuid(guid)}.moddedsave");
            SaveFile(fullFilePath, json);
            Plugin.Log.LogInfo($"Saved modded data for {guid}");
        }
    }
    
    private void SaveFile(string path, string json)
    {
        File.WriteAllText(path, json);
        File.WriteAllText(path+"_backup", json);
        
        File.WriteAllText(path, json);
    }

    /// <summary>
    /// Remove any characters that would upset a file path
    /// </summary>
    private string CleanGuid(string guid)
    {
        return guid.Replace("/", "").Replace("\\", "").Replace(":", "").Replace("*", "")
            .Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "")
            .Replace("|", "").Replace(".", "_");
    }
    
    [HarmonyPatch(typeof(AppServices), nameof(AppServices.CreateServices))]
    [HarmonyPostfix]
    private static void AddModdedSaveManagerAsService(AppServices __instance)
    {
        Instance = new ModdedSaveManagerService();
        __instance.allServices.Add(Instance);
    }
    
    [HarmonyPatch(typeof(SaveCorruptionPopup), nameof(SaveCorruptionPopup.Contact))]
    [HarmonyPrefix]
    private static bool ContactUsButtonPressed(SaveCorruptionPopup __instance)
    {
        if (__instance.task.filePath.Contains("moddedsave"))
        {
            Application.OpenURL("https://tinyurl.com/2hd5xvw3");
            return false;
        }

        return true;
    }

    public static void ListenForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        if (!LoadedSaveDataListeners.TryGetValue(guid, out SafeAction<ModSaveData, SaveFileState> listeners))
        {
            listeners = new SafeAction<ModSaveData, SaveFileState>();
            LoadedSaveDataListeners[guid] = listeners;
        }
        
        listeners.AddListener(callback);
    }
    
    public static void StopListeningForLoadedSaveData(string guid, Action<ModSaveData, SaveFileState> callback)
    {
        if (LoadedSaveDataListeners.TryGetValue(guid, out SafeAction<ModSaveData, SaveFileState> listeners))
        {
            listeners.RemoveListener(callback);
        }
    }
}