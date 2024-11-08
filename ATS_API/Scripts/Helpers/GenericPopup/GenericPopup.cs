using System.Collections;
using System.Collections.Generic;
using ATS_API.Localization;
using BepInEx.Bootstrap;
using Eremite.View;
using Eremite.View.Popups;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ATS_API.SaveLoading;

internal partial class GenericPopup : Popup
{
    private Button normalButtonTemplate;
    private Button ctaButtonTemplate;
    private TMP_Text headerText;
    private TMP_Text descriptionText;
    private TMP_Text options;
    private TMP_Text footerText;

    private List<Button> buttons = new List<Button>();
    
    private GenericPopupTask task;

    private float contentInitialHeight = 0;
    private float descriptionInitialHeight = 0;


    public void Setup()
    {
        PrepareForEvents();
        contentInitialHeight = content.GetComponent<RectTransform>().sizeDelta.y;
        descriptionInitialHeight = descriptionText.GetComponent<RectTransform>().sizeDelta.y;
    }

    private void PrepareForEvents()
    {
        GenericPopupTask.ExceptionTask.Where((GenericPopupTask t) => t != null).Subscribe(Show).AddTo(this);
    }

    private void Show(GenericPopupTask task)
    {
        this.task = task;
        SetUpTexts();
        SetUpButtons();
        AnimateShow();
        
        StartCoroutine(ResizeWindowToDescriptionCoroutine());
    }
    
    private IEnumerator ResizeWindowToDescriptionCoroutine()
    {
        yield return null;
        yield return null;
        float height = descriptionText.GetComponent<RectTransform>().sizeDelta.y;
        float diff = height - descriptionInitialHeight;
        Plugin.Log.LogInfo("Resizing window to " + height + " and diff " + diff);
        RectTransform rectTransform = content.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, contentInitialHeight + diff);
    }

    private void SetUpButtons()
    {
        foreach (Button button in buttons)
        {
            GameObject.Destroy(button.gameObject);
        }
        buttons.Clear();
        
        for (var index = 0; index < task.buttons.Count; index++)
        {
            var button = task.buttons[index];
            var t = button.Type == GenericPopupTask.ButtonTypes.Normal ? normalButtonTemplate : ctaButtonTemplate;
            Button newButton = Instantiate(t, normalButtonTemplate.transform.parent);
            newButton.gameObject.name = button.Key;
            newButton.GetComponentInChildren<LocalizationText>().key = button.Key;
            newButton.GetComponentInChildren<LocalizationText>().SetText();

            newButton.onClick.AddListener(() => OnButtonPressed(button));
            newButton.gameObject.SetActive(true);
            buttons.Add(newButton);
        }
        
        // Allign buttones
        Vector2 leftPosition = ctaButtonTemplate.transform.localPosition - new Vector3(ctaButtonTemplate.GetComponent<RectTransform>().sizeDelta.x / 2, 0);
        Vector2 rightPosition = normalButtonTemplate.transform.localPosition + new Vector3(normalButtonTemplate.GetComponent<RectTransform>().sizeDelta.x / 2, 0);
        
        float width = rightPosition.x - leftPosition.x;
        float padding = 10f;

        float buttonWidth = width / buttons.Count - (padding * buttons.Count - 1) / (buttons.Count + 1);
        for (var i = 0; i < buttons.Count; i++)
        {
            var button = buttons[i];
            RectTransform rectTransform = button.GetComponent<RectTransform>();

            // float x = leftPosition.x + buttonWidth / 2 + buttonWidth * i + padding * i;
            float x = leftPosition.x + buttonWidth / 2 + (buttonWidth + padding) * i;

            rectTransform.localPosition = new Vector2(x, rectTransform.localPosition.y);
            rectTransform.sizeDelta = new Vector2(buttonWidth, rectTransform.sizeDelta.y);
        }
    }

    private void SetUpTexts()
    {
        footerText.text = GetFooterText();
        
        // Header - High level note to the player (ModID)
        headerText.text = GetText(task.headerKey);
        
        // Description - Detailed error message
        string descTextText = GetText(task.descKey, task.descArgs);

        if (!string.IsNullOrEmpty(task.stackTrace))
        {
            descTextText += "\n\n<size=60%><align=\"left\">" + task.stackTrace + "</align></size>";   
        }
        
        if(descTextText.Length > 1000)
        {
            descTextText = descTextText.Substring(0, 1000) + "...";
        }

        // descTextText += "\n\n" + GetText(APIKeys.GenericPopup_YouHaveXOptions_Key, task.buttons.Count);
        
        descriptionText.text = descTextText;
        Plugin.Log.LogInfo("descriptionText size: " + descriptionText.fontSize);
        // descriptionText.alignment = TextAlignmentOptions.Left;
        
        
        string optionText = "<align=\"center\">" + GetText(APIKeys.GenericPopup_YouHaveXOptions_Key, task.buttons.Count) + "</align>\n";
        for (var i = 0; i < task.buttons.Count; i++)
        {
            var button = task.buttons[i];
            if (!string.IsNullOrEmpty(button.OptionKey))
            {
                optionText += "\n- " + GetText(button.OptionKey);
            }
            else
            {
                optionText += "\n- " + GetText(button.Key);
            }
        }
        
        options.text = optionText;
    }

    private string GetFooterText()
    {
        if(string.IsNullOrEmpty(task.modGUID)){
            return "";
        }
        
        if (Chainloader.PluginInfos.TryGetValue(task.modGUID, out var pluginInfo))
        {
            string guid = pluginInfo.Metadata.Name;
            if (!string.IsNullOrEmpty(pluginInfo.Metadata.Version.ToString()))
            {
                guid += " v" + pluginInfo.Metadata.Version;
            }

            return guid;
        }

        return task.modGUID;
    }

    private void OnButtonPressed(GenericPopupTask.ButtonInfo buttonInfoData)
    {
        buttonInfoData.OnPressed?.Invoke();
        task.completionSource.TrySetResult();
        task = null;
        Hide();
    }

    public override GameObject GetMainParent()
    {
        return content.gameObject;
    }
}

