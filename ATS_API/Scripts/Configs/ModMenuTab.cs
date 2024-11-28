using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ATS_API;
using ATS_API.Helpers;
using ATS_API.Localization;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Configuration;
using Eremite;
using Eremite.View;
using Eremite.View.HUD;
using Eremite.View.Popups.GameMenu;
using Eremite.View.UI;
using Eremite.View.Utils;
using HarmonyLib;
using Mono.Cecil;
using MonoMod.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using PluginInfo = BepInEx.PluginInfo;

[HarmonyPatch]
public static class ModMenuTab
{
    internal static Action OptionsMenuEnabled;
    
    [HarmonyPatch(typeof(OptionsPopup), nameof(OptionsPopup.Initialize))]
    [HarmonyPrefix]
    public static void Initialize(OptionsPopup __instance)
    {
        GameObject generalContent = __instance.FindChild("Content/GeneralContent");
        GameObject modMenuTab = GameObject.Instantiate(generalContent, generalContent.transform.parent);
        modMenuTab.AddComponent<ModPanel>();
        
        // Setup tab
        GameObject tabs = Util.FindChild(__instance, "Content/Tabs");
        Transform tab = Util.FindChild(tabs.transform, "GeneralButton");
        GameObject modMenuTabButton = GameObject.Instantiate(tab.gameObject, tabs.transform);
        TabsButton button = modMenuTabButton.SafeGetComponentInChildren<TabsButton>();
        button.content = modMenuTab;
        // GameObject.Destroy(button.FindChild<LocalizationText>("Text"));
        GameObject.Destroy(button.FindChild<TextFontFeaturesHelper>("Text"));

        IEnumerator MethodName()
        {
            yield return null;
            button.FindChild<LocalizationText>("Text").key = Keys.OptionsUI_ModsTab_Text_Key;
            button.FindChild<LocalizationText>("Text").SetText();
        }
        Plugin.Instance.StartCoroutine(MethodName());

        TabsPanel tabsPanel = __instance.SafeGetComponentInChildren<TabsPanel>();
        tabsPanel.buttons = tabsPanel.buttons.AddToArray(button);
        tabsPanel.GetComponent<HorizontalLayoutGroup>().childForceExpandWidth = true;
        tabsPanel.GetComponent<HorizontalLayoutGroup>().childControlWidth = true;


        ScrollRect scrollRect = modMenuTab.SafeGetComponentInChildren<ScrollRect>();
        GameObject content = scrollRect.content.gameObject;
        for (int i = 1; i < content.transform.childCount; i++)
        {
            GameObject.Destroy(content.transform.GetChild(i).gameObject);
        }
        
        GameObject section = content.transform.GetChild(0).gameObject;
        section.SetActive(false);
        
        GameObject sectionTemplate = GameObject.Instantiate(section,  section.transform.parent);
        for (int i = 2; i < sectionTemplate.transform.childCount; i++)
        {
            sectionTemplate.transform.GetChild(i).gameObject.SetActive(false);
        }
        
        GameObject labelTemplate = section.FindChild("GPU");
        GameObject dropdownTemplate = section.FindChild("Resolution");
        GameObject toggleTemplate = section.FindChild("FPSCounter");
        GameObject sliderTemplate = section.FindChild("UISize");
        GameObject inputFieldTemplate = __instance.FindChild("Content/TwitchContent").SafeGetComponentInChildren<TMP_InputField>(true).gameObject;
        Sprite textFieldBackground = dropdownTemplate.FindChild<Image>("Dropdown").sprite;
        
        // Get all types inheriting BaseUnityPlugin from all assemblies
        foreach (PluginInfo plugin in Chainloader.PluginInfos.Values.OrderBy(GetModName))
        {
            PluginInfoExtensions.PluginManifest manifest = plugin.Manifest();

            var modName = GetModName(plugin);
            Version modVersion = manifest != null && manifest.ManifestVersion() != null ? manifest.ManifestVersion() : plugin.Metadata.Version;
            string description;
            if (manifest != null && !string.IsNullOrEmpty(manifest.description))
                description = manifest.description + "\n\n";
            else
                description = "";


            GameObject modSection = GameObject.Instantiate(sectionTemplate, content.transform);
            GameObject header = modSection.FindChild("Header");
            GameObject.Destroy(header.SafeGetComponent<LocalizationText>());
            header.SafeGetComponent<TMP_Text>().text = modName + (modVersion != null && modVersion.ToString() != "0.0" ? " v" + modVersion : "");
            modSection.name = header.GetComponent<TMP_Text>().text;

            string guid = Keys.GUID.ToLocaText().GetText();
            string dependencies = Keys.Dependencies.ToLocaText().GetText();

            SimpleTooltipTrigger tooltipTrigger = header.GetOrAdd<SimpleTooltipTrigger>();
            tooltipTrigger.target = header.GetComponent<RectTransform>();
            tooltipTrigger.descKey = $"<align=\"left\">" +
                                     $"{description}" +
                                     $"<b>{guid}:</b> {plugin.Metadata.GUID}\n\n" +
                                     // $"<b>Version:</b> {plugin.Metadata.Version}\n\n" +
                                     $"<b>{dependencies}:</b>\n{GetDependencies(plugin, manifest)}" +
                                     "</align>";

            AddConfigsToModSection(plugin, dropdownTemplate, modSection, sliderTemplate, toggleTemplate, inputFieldTemplate, textFieldBackground, labelTemplate);

            modSection.SetActive(true);
        }
        
        OptionsMenuEnabled?.Invoke();
    }

    private static string GetModName(PluginInfo plugin)
    {
        PluginInfoExtensions.PluginManifest manifest = plugin.Manifest();
        string modName = manifest != null ? manifest.name : plugin.Metadata.Name;
        return modName;
    }

    private static string GetDependencies(PluginInfo plugin, PluginInfoExtensions.PluginManifest pluginManifest)
    {
        Dictionary<string, Version> dependencies = new Dictionary<string, Version>();
        
        dependencies.AddRange(plugin.Dependencies.ToDictionary(a=>a.DependencyGUID, a=>a.MinimumVersion));

        if (pluginManifest != null)
        {
            foreach (PluginInfoExtensions.PluginManifest.Dependency dependency in pluginManifest.Dependencies())
            {
                if(dependencies.TryGetValue(dependency.Name, out Version version))
                {
                    dependencies[dependency.Name] = dependency.Version == null || version > dependency.Version ? version : dependency.Version;
                }
                else
                {
                    dependencies[dependency.Name] = dependency.Version;
                }
            }
        }
        
        dependencies.Remove("BepInExPack");


        string wrongVersion = Keys.WrongVersion.ToLocaText().GetText();
        string missing = Keys.Missing.ToLocaText().GetText();
        
        string text = "";
        if (dependencies.Count > 0)
        {
            text = string.Join("\n", dependencies.Select(pair=>
            {
                string guid = pair.Key;
                Version version = pair.Value;
                
                string s = guid + (version != null && version.ToString() != "0.0" ? " v" + version : "");
                bool loaded = false;
                if (Chainloader.PluginInfos.TryGetValue(guid, out PluginInfo pluginInfo))
                {
                    s = pluginInfo.Metadata.Name + " v" + pluginInfo.Metadata.Version;
                    loaded = pluginInfo.Metadata.Version >= version;
                    if (!loaded)
                    {
                        s += $" ({wrongVersion})";
                    }
                }
                else
                {
                    s += $" ({missing})";
                }
                
                Color color = loaded ? Color.green : Color.red;
                string hex = ColorUtility.ToHtmlStringRGB(color);
                return $"<color=#{hex}>" + s + "</color>";
            }));
        }
        else
        {
            text = Keys.None.ToLocaText().GetText();
        }

        return text;
    }

    private static void AddConfigsToModSection(PluginInfo pluginInfo, GameObject dropdownTemplate, GameObject modSection,
        GameObject sliderTemplate, GameObject toggleTemplate, GameObject inputFieldTemplate, Sprite textFieldBackground,
        GameObject labelTemplate)
    {
        
        ConfigFile file = pluginInfo.Instance.Config;
        if (file == null || file.Keys.Count == 0)
        {
            return;
        }
        
        // Go through all keys in the config file
        foreach (ConfigEntryBase entry in file.GetConfigEntries())
        {
            Type entrySettingType = entry.SettingType;
            AcceptableValueBase acceptableValues = entry.Description.AcceptableValues;
            if(acceptableValues != null)
            {
                if(acceptableValues.GetType().GetGenericTypeDefinition() == typeof(AcceptableValueList<>))
                {
                    var genericType = acceptableValues.GetType().GetGenericArguments()[0];
                    var arrayOfObjects = acceptableValues.GetType().GetProperty("AcceptableValues").GetGetMethod().Invoke(acceptableValues, null);
                        
                    // Dropdown of all possible choices
                    if (genericType == typeof(int))
                    {
                        Dictionary<int, int> values = new();
                        foreach (int value in (int[])arrayOfObjects)
                        {
                            values[value] = value;
                        }
                        Dropdown(entrySettingType, values, dropdownTemplate, modSection, entry);
                        continue;
                    }
                    else if (genericType == typeof(float))
                    {
                        Dictionary<float, float> values = new();
                        foreach (float value in (float[])arrayOfObjects)
                        {
                            values[value] = value;
                        }
                        Dropdown(entrySettingType, values, dropdownTemplate, modSection, entry);
                        continue;
                    }
                    else if (genericType == typeof(string))
                    {
                        Dictionary<string, string> values = new();
                        foreach (string value in (string[])arrayOfObjects)
                        {
                            values[value] = value;
                        }
                        Dropdown(entrySettingType, values, dropdownTemplate, modSection, entry);
                        continue;
                    }
                    else if (genericType.IsEnum)
                    {
                        Dictionary<string, string> values = new();
                        foreach (string value in (string[])arrayOfObjects)
                        {
                            values[value] = value;
                        }

                        Dropdown(entrySettingType, values, dropdownTemplate, modSection, entry);
                        continue;
                    }
                }
                else if (acceptableValues.GetType().GetGenericTypeDefinition() == typeof(AcceptableValueRange<>))
                {
                    // Slider
                    if (entrySettingType == typeof(int))
                    {
                        int min = (int)acceptableValues.GetType().GetProperty("MinValue").GetValue(acceptableValues);
                        int max = (int)acceptableValues.GetType().GetProperty("MaxValue").GetValue(acceptableValues);
                        AddIntSlider(sliderTemplate, modSection, entry, min, max);
                        continue;
                    }
                    else if (entrySettingType == typeof(float))
                    {
                        float min = (float)acceptableValues.GetType().GetProperty("MinValue").GetGetMethod().Invoke(acceptableValues, null);
                        float max = (float)acceptableValues.GetType().GetProperty("MaxValue").GetGetMethod().Invoke(acceptableValues, null);
                        AddFloatSlider(sliderTemplate, modSection, entry, min, max);
                        continue;
                    }
                }
                else
                {
                    Plugin.Log.LogError($"Unsupported acceptableValues type {acceptableValues.GetType().FullName} for {entry.Definition.Key}");
                }
            }
                
            if (entrySettingType == typeof(bool))
            {
                // Toggle
                AddToggle(toggleTemplate, modSection, entry);
            }
            else if (entrySettingType == typeof(int))
            {
                // Slider
                AddInputField<int>(inputFieldTemplate, modSection.transform, entry, textFieldBackground);
            }
            else if (entrySettingType == typeof(float))
            {
                // InputField
                AddInputField<float>(inputFieldTemplate, modSection.transform, entry, textFieldBackground);
            }
            else if (entrySettingType == typeof(string))
            {
                // InputField
                AddInputField<string>(inputFieldTemplate, modSection.transform, entry, textFieldBackground);
            }
            else if (entrySettingType.IsEnum)
            {
                // InputField
                EnumDropdown(entrySettingType, dropdownTemplate, modSection, entry);
            }
            else
            {
                // Label saying what the type is
                AddUnknownType(labelTemplate, modSection, entry);
            }
        }
    }

    private static void Dropdown<K,V>(Type type, Dictionary<K,V> values, GameObject dropdownTemplate, GameObject modSection, ConfigEntryBase entry)
    {
        GameObject dropdown = GameObject.Instantiate(dropdownTemplate, modSection.transform);
        dropdown.name = entry.Definition.Key;
        PopulateToolTip(dropdown, entry);
        
        GameObject.Destroy(dropdown.FindChild<LocalizationText>("Label"));
        dropdown.FindChild("Label").SafeGetComponent<TMP_Text>().text = entry.Definition.Key;
        
        List<string> keys = values.Keys.Select(a=>a.ToString()).ToList();
        List<V> valuesList = values.Keys.Select(a=>values[a]).ToList();
        
        TMP_Dropdown dropdownComponent = dropdown.SafeGetComponentInChildren<TMP_Dropdown>();
        dropdownComponent.ClearOptions();
        dropdownComponent.AddOptions(keys);
        dropdownComponent.onValueChanged.AddListener((value) =>
        {
            int i = dropdownComponent.value;
            entry.BoxedValue = valuesList[i];
        });
        
        OptionsMenuEnabled += () =>
        {
            int i = valuesList.IndexOf((V)entry.BoxedValue);
            dropdownComponent.value = i;
        };
    }
    
    private static void EnumDropdown(Type type, GameObject dropdownTemplate, GameObject modSection, ConfigEntryBase entry)
    {
        Dictionary<string, Enum> values = new();
        foreach (Enum value in Enum.GetValues(type))
        {
            values[value.ToString()] = value;
        }
        Dropdown(type, values, dropdownTemplate, modSection, entry);
    }

    private static void AddUnknownType(GameObject labelTemplate, GameObject modSection, ConfigEntryBase entry)
    {
        string labelText = entry.Definition.Key + "(" + entry.SettingType.Name + ")";
        GameObject label = GameObject.Instantiate(labelTemplate, modSection.transform);
        label.name = labelText;
        PopulateToolTip(label, entry);
        
        GameObject.Destroy(label.FindChild<LocalizationText>("Label "));
        label.FindChild("Label ").SafeGetComponent<TMP_Text>().text = labelText;
        
        TMP_Text text = label.FindChild("Value").SafeGetComponent<TMP_Text>();
        OptionsMenuEnabled += () =>
        {
            text.text = entry.BoxedValue?.ToString();
        };
    }

    private static void AddInputField<T>(GameObject inputFieldTemplate, Transform parent, ConfigEntryBase entry, Sprite background)
    {
        TMP_InputField.ContentType contentType = TMP_InputField.ContentType.Standard;
        if(typeof(T) == typeof(int))
        {
            contentType = TMP_InputField.ContentType.IntegerNumber;
        }
        else if(typeof(T) == typeof(float))
        {
            contentType = TMP_InputField.ContentType.DecimalNumber;
        }
        else if(typeof(T) == typeof(string))
        {
            contentType = TMP_InputField.ContentType.Standard;
        }
        else
        {
            Plugin.Log.LogError($"Unsupported type {typeof(T).FullName} for input field!");
        }
        
        GameObject clone = GameObject.Instantiate(inputFieldTemplate.transform.parent.gameObject, parent);
        clone.name = entry.Definition.Key;
        PopulateToolTip(clone, entry);
        
        // GameObject.Destroy(clone.FindChild<TMP_Text>("Value"));
        GameObject.Destroy(clone.FindChild<LocalizationText>("Label "));
        clone.FindChild("Label ").SafeGetComponent<TMP_Text>().text = entry.Definition.Key;
        
                    
        TMP_InputField input = clone.SafeGetComponentInChildren<TMP_InputField>();
        input.GetRectTransform().sizeDelta = new Vector2(290, input.GetRectTransform().sizeDelta.y);
        input.FindChild("Text Area").AddComponent<RectMask2D>();
        input.contentType = contentType;
        if (typeof(T) == typeof(string))
        {
            TMP_Text tmpText = input.FindChild<TMP_Text>("Text Area/Text");
            tmpText.alignment = TextAlignmentOptions.Left;
        }
        input.onValueChanged.AddListener((value) =>
        {
            Plugin.Log.LogInfo($"Setting {entry.Definition.Key} to {value}");
            entry.BoxedValue = (T)Convert.ChangeType(value, typeof(T));
        });
        
        OptionsMenuEnabled += () =>
        {
            Plugin.Log.LogInfo($"Setting {entry.Definition.Key} to {entry.BoxedValue}");
            input.SetTextWithoutNotify(entry.BoxedValue?.ToString());
        };
    }

    private static void PopulateToolTip(GameObject gameObject, ConfigEntryBase entry)
    {
        if (!gameObject.TryGetComponent(out SimpleTooltipTrigger tooltip))
        {
            tooltip = gameObject.AddComponent<SimpleTooltipTrigger>();
            tooltip.target = gameObject.GetComponent<RectTransform>();
        }
        tooltip.descKey = entry.Description.Description + "\nDefault: " + entry.DefaultValue;
    }

    private static void AddFloatSlider(GameObject sliderTemplate, GameObject modSection, ConfigEntryBase entry, float min, float max)
    {
        GameObject slider = GameObject.Instantiate(sliderTemplate, modSection.transform);
        slider.name = entry.Definition.Key;
        PopulateToolTip(slider, entry);
        
        GameObject.Destroy(slider.FindChild<LocalizationText>("Label"));
        TMP_Text label = slider.FindChild<TMP_Text>("Label");
        label.text = entry.Definition.Key;
        Slider sliderComponent = slider.SafeGetComponentInChildren<Slider>();
        sliderComponent.minValue = min;
        sliderComponent.maxValue = max;
        sliderComponent.onValueChanged.AddListener((value) =>
        {
            entry.BoxedValue = value;
            label.text = entry.Definition.Key + " (" + entry.BoxedValue + ")";
        });
        
        OptionsMenuEnabled += () =>
        {
            sliderComponent.value = (float)entry.BoxedValue;
            label.text = entry.Definition.Key + " (" + entry.BoxedValue + ")";
        };
    }

    private static void AddIntSlider(GameObject sliderTemplate, GameObject modSection, ConfigEntryBase entry, int min, int max)
    {
        GameObject slider = GameObject.Instantiate(sliderTemplate, modSection.transform);
        slider.name = entry.Definition.Key;
        PopulateToolTip(slider, entry);
        
        GameObject.Destroy(slider.FindChild<LocalizationText>("Label"));
        TMP_Text label = Util.FindChild(slider, "Label").SafeGetComponent<TMP_Text>();
        label.text = entry.Definition.Key;
        Slider sliderComponent = slider.SafeGetComponentInChildren<Slider>();
        sliderComponent.minValue = min;
        sliderComponent.maxValue = max;
        sliderComponent.onValueChanged.AddListener((value) =>
        {
            entry.BoxedValue = (int)value;
            label.text = entry.Definition.Key + " (" + entry.BoxedValue + ")";
        });
        
        OptionsMenuEnabled += () =>
        {
            sliderComponent.value = (int)entry.BoxedValue;
            label.text = entry.Definition.Key + " (" + entry.BoxedValue + ")";
        };
    }

    private static void AddToggle(GameObject toggleTemplate, GameObject modSection, ConfigEntryBase entry)
    {
        GameObject toggle = GameObject.Instantiate(toggleTemplate, modSection.transform);
        toggle.name = entry.Definition.Key;
        PopulateToolTip(toggle, entry);
        
        GameObject.Destroy(toggle.FindChild<TextFontFeaturesHelper>("Label "));
        GameObject.Destroy(toggle.FindChild<LocalizationText>("Label "));
        toggle.FindChild<TMP_Text>("Label ").text = entry.Definition.Key;
        
        Toggle toggleComponent = toggle.SafeGetComponentInChildren<Toggle>();
        toggleComponent.onValueChanged.AddListener((value) =>
        {
            entry.BoxedValue = value;
        });
        
        OptionsMenuEnabled += () =>
        {
            toggleComponent.isOn = entry.BoxedValue is bool b && b;
        };
    }

    private static TMP_InputField CreateInputField(Transform parent, Sprite background)
    {
        GameObject inputField = new GameObject("InputField (Created)");
        inputField.transform.SetParent(parent);
        inputField.layer = LayerMask.NameToLayer("UI");
        RectTransform rectTransform = inputField.AddComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(1, 1);
        rectTransform.anchoredPosition = new Vector2(0, 0);
        rectTransform.offsetMin = new Vector2(0, 0);
        rectTransform.offsetMax = new Vector2(0, 0);
        rectTransform.localPosition = Vector3.zero;
        rectTransform.localRotation = Quaternion.identity;
        rectTransform.localScale = Vector3.one;
        
        inputField.AddComponent<CanvasRenderer>();
        Image inputFieldImage = inputField.AddComponent<Image>();
        inputFieldImage.sprite = background;
        TMP_InputField field = inputField.AddComponent<TMP_InputField>();
        field.targetGraphic = inputFieldImage;
        
        
        
        GameObject textArea = new GameObject("Text Area");
        textArea.transform.SetParent(inputField.transform);
        textArea.layer = LayerMask.NameToLayer("UI");
        RectTransform textAreaRectTransform = textArea.AddComponent<RectTransform>();
        textAreaRectTransform.anchorMin = new Vector2(0, 0);
        textAreaRectTransform.anchorMax = new Vector2(1, 1);
        textAreaRectTransform.anchoredPosition = new Vector2(0, 0);
        textAreaRectTransform.offsetMin = new Vector2(10, 6);
        textAreaRectTransform.offsetMax = new Vector2(-10, -7);
        textAreaRectTransform.localPosition = Vector3.zero;
        textAreaRectTransform.localRotation = Quaternion.identity;
        textAreaRectTransform.localScale = Vector3.one;
        textArea.AddComponent<RectMask2D>();
        
        GameObject placeholder = new GameObject("Placeholder");
        placeholder.transform.SetParent(textArea.transform);
        placeholder.layer = LayerMask.NameToLayer("UI");
        RectTransform placeholderRectTransform = placeholder.AddComponent<RectTransform>();
        placeholderRectTransform.anchorMin = new Vector2(0, 0);
        placeholderRectTransform.anchorMax = new Vector2(1, 1);
        placeholderRectTransform.anchoredPosition = new Vector2(0, 0);
        placeholderRectTransform.offsetMin = new Vector2(0, 0);
        placeholderRectTransform.offsetMax = new Vector2(0, 0);
        placeholderRectTransform.localPosition = Vector3.zero;
        placeholderRectTransform.localRotation = Quaternion.identity;
        placeholderRectTransform.localScale = Vector3.one;
        placeholder.AddComponent<CanvasRenderer>();
        TextMeshProUGUI placeHolderText = placeholder.AddComponent<TextMeshProUGUI>();
        placeHolderText.color = new Color(1,1,1, 0.5f);
        placeHolderText.fontSize = 14;
        placeHolderText.text = "Enter text...";
        placeHolderText.fontStyle = FontStyles.Italic;
        LayoutElement placeHolderElement = placeholder.AddComponent<LayoutElement>();
        placeHolderElement.ignoreLayout = true;
        
        GameObject text = new GameObject("Text");
        text.transform.SetParent(textArea.transform);
        text.layer = LayerMask.NameToLayer("UI");
        RectTransform textRectTransform = text.AddComponent<RectTransform>();
        textRectTransform.anchorMin = new Vector2(0, 0);
        textRectTransform.anchorMax = new Vector2(1, 1);
        textRectTransform.anchoredPosition = new Vector2(0, 0);
        textRectTransform.offsetMin = new Vector2(0, 0);
        textRectTransform.offsetMax = new Vector2(0, 0);
        textRectTransform.localPosition = Vector3.zero;
        textRectTransform.localRotation = Quaternion.identity;
        textRectTransform.localScale = Vector3.one;
        text.AddComponent<CanvasRenderer>();
        TextMeshProUGUI typedText = text.AddComponent<TextMeshProUGUI>();
        typedText.color = new Color(1,1,1, 1);
        typedText.fontSize = 14;
        typedText.extraPadding = true;
        
        
        field.textViewport = textAreaRectTransform;
        field.textComponent = text.GetComponent<TMP_Text>();
        field.placeholder = placeholder.GetComponent<TMP_Text>();
        field.textViewport = textAreaRectTransform;
        
        return field;
    }
}

public class ModPanel : MonoBehaviour
{
    private void OnEnable()
    {
        ModMenuTab.OptionsMenuEnabled?.Invoke();
    }
}