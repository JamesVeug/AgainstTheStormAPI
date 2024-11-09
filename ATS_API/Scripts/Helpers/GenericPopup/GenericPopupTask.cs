using System;
using System.Collections.Generic;
using ATS_API;
using ATS_API.Localization;
using Cysharp.Threading.Tasks;
using Eremite.Model;
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
        public LocaText Key;
        public LocaText OptionKey;
        public ButtonTypes Type;
        public Action OnPressed;
    }
    
    public static ReactiveProperty<GenericPopupTask> Task = new ReactiveProperty<GenericPopupTask>();

    public string headerKey = Keys.GenericPopup_Header_Key;
    public string descKey = Keys.GenericPopup_Description_Key;
    public object[] descArgs = new object[0];
    public string modGUID;
    public string stackTrace;

    public List<ButtonInfo> buttons = new List<ButtonInfo>();
    public ButtonInfo decisionButton;
    
    public UniTaskCompletionSource completionSource;
    
    
    public static GenericPopupTask ShowException(string modGUID, string description, Exception exception)
    {
        GenericPopupTask task = new GenericPopupTask();
        task.modGUID = modGUID;
        task.descKey = Keys.GenericPopup_ExceptionDescription_Key;
        task.descArgs = new object[] { description };
        task.stackTrace = exception.ToString();
        task.completionSource = new UniTaskCompletionSource();
        return task;
    }
    
    public static GenericPopupTask Show(string modGUID, LocaText header, LocaText description, params object[] descriptionArgs)
    {
        GenericPopupTask task = new GenericPopupTask();
        task.modGUID = modGUID;
        task.headerKey = header.key;
        task.descKey = description.key;
        task.descArgs = descriptionArgs;
        task.completionSource = new UniTaskCompletionSource();
        return task;
    }
    
    public void WaitForDecision(params ButtonInfo[] buttons)
    {
        WaitForDecisionAsync(buttons).Forget();
    }
    
    public async UniTask WaitForDecisionAsync(params ButtonInfo[] buttons)
    {
        Plugin.Log.LogInfo("Waiting for decision with " + buttons.Length + " buttons");
        this.buttons.Clear();
        this.buttons.AddRange(buttons);
        decisionButton = null;
        ReactiveProperty<GenericPopupTask> CorruptionTask = Task;
        CorruptionTask.Value = this;
        await completionSource.Task;
        CorruptionTask.Value = null;
    }
}