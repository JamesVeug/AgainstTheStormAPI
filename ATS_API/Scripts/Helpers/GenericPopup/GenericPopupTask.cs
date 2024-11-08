using System;
using System.Collections.Generic;
using ATS_API;
using ATS_API.Localization;
using Cysharp.Threading.Tasks;
using UniRx;

public class GenericPopupTask
{
    public enum Decision
    {
        QuitGame = 0,
        Continue = 1
    }
    
    public enum ButtonTypes
    {
        Normal = 0,
        CTA = 1
    }

    public class ButtonInfo
    {
        public string Key;
        public string OptionKey;
        public ButtonTypes Type;
        public Action OnPressed;
    }
    
    public static ReactiveProperty<GenericPopupTask> ExceptionTask = new ReactiveProperty<GenericPopupTask>();

    public string headerKey = APIKeys.GenericPopup_Header_Key;
    public string descKey = APIKeys.GenericPopup_Description_Key;
    public object[] descArgs = new object[0];
    public string modGUID;
    public string stackTrace;

    public List<ButtonInfo> buttons = new List<ButtonInfo>();
    
    public UniTaskCompletionSource completionSource;
    
    
    public static GenericPopupTask Exception(string modGUID, string description, Exception exception)
    {
        GenericPopupTask task = new GenericPopupTask();
        task.modGUID = modGUID;
        task.descKey = APIKeys.GenericPopup_ExceptionDescription_Key;
        task.descArgs = new object[] { description };
        task.stackTrace = exception.ToString();
        task.completionSource = new UniTaskCompletionSource();
        return task;
    }
    
    public async UniTask WaitForDecision(params ButtonInfo[] buttons)
    {
        Plugin.Log.LogInfo("Waiting for decision with " + buttons.Length + " buttons");
        this.buttons.AddRange(buttons);
        ReactiveProperty<GenericPopupTask> CorruptionTask = ExceptionTask;
        CorruptionTask.Value = this;
        await completionSource.Task;
        CorruptionTask.Value = null;
    }
}