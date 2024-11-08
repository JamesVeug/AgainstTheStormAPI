using ATS_API.Helpers;
using Eremite;
using Eremite.View;
using Eremite.View.SaveSupport;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ATS_API.SaveLoading;

[HarmonyPatch]
internal partial class GenericPopup
{
    [HarmonyPatch]
    internal static class CreateGenericPopup
    {
        private static bool m_Created = false;
    
        [HarmonyPatch(typeof(SaveCorruptionPopup), nameof(SaveCorruptionPopup.Start))]
        [HarmonyPostfix]
        public static void SaveCorruptionPopup_Start(SaveCorruptionPopup __instance)
        {
            if (m_Created)
            {
                return;
            }
        
            m_Created = true;
            SaveCorruptionPopup clone = Instantiate(__instance, __instance.transform.parent);
            clone.gameObject.name = "API Generic Popup";
            clone.backupButton.gameObject.SetActive(false);
            clone.deleteButton.gameObject.SetActive(false);
            clone.contactButton.gameObject.SetActive(false);
            
            
            GenericPopup popup = clone.gameObject.AddComponent<GenericPopup>();
            popup.ctaButtonTemplate = clone.backupButton;
            popup.normalButtonTemplate = clone.contactButton;
            popup.headerText = popup.FindChild<TMP_Text>("Content/Header");
            popup.headerText.GetRectTransform().anchorMin = Vector2.one - popup.ctaButtonTemplate.GetRectTransform().anchorMin;
            popup.headerText.GetRectTransform().anchorMax = Vector2.one - popup.ctaButtonTemplate.GetRectTransform().anchorMax;
            popup.headerText.GetRectTransform().anchoredPosition = new Vector2(0, -popup.headerText.GetRectTransform().sizeDelta.y);
            popup.footerText = clone.backupDateText;
            popup.footerText.transform.SetParent(clone.content);
            popup.footerText.GetRectTransform().anchorMin = Vector2.zero;
            popup.footerText.GetRectTransform().anchorMax = Vector2.zero;
            popup.footerText.GetRectTransform().sizeDelta = new Vector2(400, 50);
            popup.footerText.GetRectTransform().anchoredPosition = new Vector2(300, 50);
            popup.footerText.alignment = TextAlignmentOptions.BottomLeft;
            popup.options = clone.FindChild<TMP_Text>("Content/Options");
            popup.options.GetRectTransform().anchorMin = popup.ctaButtonTemplate.GetRectTransform().anchorMin;
            popup.options.GetRectTransform().anchorMax = popup.ctaButtonTemplate.GetRectTransform().anchorMax;
            popup.options.GetRectTransform().anchoredPosition = new Vector2(0, popup.ctaButtonTemplate.GetRectTransform().anchoredPosition.y + popup.ctaButtonTemplate.GetRectTransform().sizeDelta.y + 40);
            Destroy(popup.options.GetComponent<LocalizationText>());
            
            LocalizationText localizationText = popup.headerText.GetComponent<LocalizationText>();
            Destroy(localizationText);
            
            popup.descriptionText = clone.descText;

            Vector2 offset = new Vector2(50, 0);
            popup.descriptionText.GetRectTransform().sizeDelta += offset;
            popup.descriptionText.GetRectTransform().anchoredPosition -= offset / 2;
            ContentSizeFitter fitter = popup.descriptionText.gameObject.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            // popup.descriptionText.GetRectTransform().anchoredPosition += new UnityEngine.Vector2(0, -26);
            // clone.FindChild("Content/Options").SetActive(false);
            
            popup.autoPause = clone.autoPause;
            popup.blendClickable = clone.blendClickable;
            popup.blendButton = clone.blendButton;
            popup.content = clone.content;
            popup.requestSpace = clone.requestSpace;
            popup.noAnimation = clone.noAnimation;
            popup.posAnimDelay = clone.posAnimDelay;
            popup.posAnimDuration = clone.posAnimDuration;
            popup.posAnimEase = clone.posAnimEase;
            popup.blend = clone.blend;
            popup.blendAnimEase = clone.blendAnimEase;
            popup.blendAnimSpeed = clone.blendAnimSpeed;
            
            clone.backupButton.onClick.RemoveAllListeners();
            clone.deleteButton.onClick.RemoveAllListeners();
            clone.contactButton.onClick.RemoveAllListeners();
            Destroy(clone);

            popup.Setup();
        }
    }
}