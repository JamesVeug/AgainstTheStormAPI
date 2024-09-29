using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ATS_API;

[HarmonyPatch]
public static partial class Input
{
    public class Hotkey
    {
        public string keyName;
        public string displayName;
        public List<string> codes;
        public Action<InputAction.CallbackContext> onCallback;
    }

    public static InputActionAsset MasterInputAsset;
    
    private static Dictionary<string, List<Hotkey>> pendingHotkeys = new Dictionary<string, List<Hotkey>>();
    private static Dictionary<string, InputActionMap> modNameToActionMaps = new Dictionary<string, InputActionMap>();
    private static Dictionary<string, Hotkey> modNameActionNameToAddedHotkey = new Dictionary<string, Hotkey>();
    private static HashSet<InputAction> activeActions = new HashSet<InputAction>();
    private static HashSet<string> activeActionMaps = new HashSet<string>();

    public static void Update()
    {
        if (MasterInputAsset == null || pendingHotkeys.Count == 0)
        {
            return;
        }
        
        MasterInputAsset.Disable();
        foreach (KeyValuePair<string, List<Hotkey>> pair in pendingHotkeys)
        {
            activeActionMaps.Add(pair.Key);
            InputActionMap map = MasterInputAsset.FindActionMap(pair.Key);
            if (map == null)
            {
                map = new InputActionMap(pair.Key);
                MasterInputAsset.AddActionMap(map);
            }
            modNameToActionMaps[pair.Key] = map;
            
            foreach (Hotkey hotkey in pair.Value)
            {
                AddHotkey(pair.Key, map, hotkey);
            }
        }
        pendingHotkeys.Clear();
        MasterInputAsset.Enable();
    }
    
    public static void RegisterKey(string modName, Hotkey hotkey)
    {
        Plugin.Log.LogInfo($"Registering key {hotkey.keyName} with code {string.Join(",", hotkey.codes)}");
        if(!pendingHotkeys.TryGetValue(modName, out var hotkeys))
        {
            hotkeys = new List<Hotkey>();
            pendingHotkeys.Add(modName, hotkeys);
        }
            
        hotkeys.Add(hotkey);
    }

    public static void RegisterKey(string modName, string keyName, string displayName, List<KeyCode> codes, Action onPress = null, Action onRelease = null)
    {
        Action<InputAction.CallbackContext> callback = null;
        if (onPress != null || onRelease != null)
        {
            callback = ctx =>
            {
                if (ctx.performed)
                {
                    onPress?.Invoke();
                }
                else if (ctx.canceled)
                {
                    onRelease?.Invoke();
                }
            };
        }
        
        var item = new Hotkey();
        item.keyName = keyName;
        item.displayName = displayName;
        item.codes = KeyCodesToString(codes);
        item.onCallback = callback;
        RegisterKey(modName, item);
    }

    public static void RegisterKey(string modName, string keyName, string displayName, List<KeyCode> codes, Action<InputAction.CallbackContext> callback = null)
    {
        var item = new Hotkey();
        item.keyName = keyName;
        item.displayName = displayName;
        item.codes = KeyCodesToString(codes);
        item.onCallback = callback;
        RegisterKey(modName, item);
    }

    private static void AddHotkey(string modName, InputActionMap actionMap, Hotkey hotkey)
    {
        Plugin.Log.LogInfo($"Adding hotkey {hotkey.keyName} with code {string.Join(",", hotkey.codes)}");
        List<string> codes = hotkey.codes;
        string keyName = hotkey.keyName;
        Action<InputAction.CallbackContext> callback = hotkey.onCallback;
        
        string uniqueName = modName + "_" + keyName;
        modNameActionNameToAddedHotkey[uniqueName] = hotkey;
        
        InputAction action = actionMap.actions.FirstOrDefault(a=>a.name == keyName);
        if (action == null)
        {
            if (codes.Count == 1)
            {
                // Single key binding
                action = actionMap.AddAction(keyName, binding:$"{codes[0]}");
            }
            else if (codes.Count == 2)
            {
                // Composite binding for one modifier and one key
                action = actionMap.AddAction(keyName);
                action.AddCompositeBinding("OneModifier")
                    .With("Modifier", $"{codes[0]}")  // First key as modifier
                    .With("Binding", $"{codes[1]}");  // Second key as main binding
            }
            else if (codes.Count == 3)
            {
                // Composite binding for two modifiers and one key
                action = actionMap.AddAction(keyName);
                action.AddCompositeBinding("TwoModifiers")
                    .With("Modifier1", $"{codes[0]}")  // First modifier
                    .With("Modifier2", $"{codes[1]}")  // Second modifier
                    .With("Binding", $"{codes[2]}");   // Main key
            }
            else
            {
                Plugin.Log.LogError("More than 3 key codes are not supported.");
                return;
            }
        }

        // Set up callbacks for performed (pressed) and canceled (released)
        if (callback != null)
        {
            // Move into a method so if anything goes wrong the stacktrace will tell us
            CallbackAction(action, keyName, callback);
        }
        
        activeActions.Add(action);
    }

    private static void CallbackAction(InputAction action, string keyName, Action<InputAction.CallbackContext> callback)
    {
        action.performed += ctx =>
        {
            Plugin.Log.LogInfo($"{keyName} action performed!");
            callback.Invoke(ctx);
        };
        action.canceled += ctx =>
        {
            Plugin.Log.LogInfo($"{keyName} action canceled!");
            callback.Invoke(ctx);
        };
        action.started += ctx =>
        {
            Plugin.Log.LogInfo($"{keyName} action started!");
            callback.Invoke(ctx);
        };
    }
    
    private static List<string> KeyCodesToString(List<KeyCode> codes)
    {
        List<string> paths = new List<string>();
        foreach (KeyCode code in codes)
        {
            if (KeyCodeToPathMap.TryGetValue(code, out string path))
            {
                paths.Add(path);
            }
            else
            {
                paths.Add(code.ToString());
            }
        }

        return paths;
    }
    
    public static bool IsActionActive(InputAction action)
    {
        return activeActions.Contains(action);
    }

    private static readonly Dictionary<KeyCode, string> KeyCodeToPathMap = new Dictionary<KeyCode, string>
    {
        { KeyCode.Space, "<Keyboard>/space" },
        { KeyCode.LeftControl, "<Keyboard>/leftCtrl" },
        { KeyCode.RightControl, "<Keyboard>/rightCtrl" },
        { KeyCode.LeftShift, "<Keyboard>/leftShift" },
        { KeyCode.RightShift, "<Keyboard>/rightShift" },
        { KeyCode.A, "<Keyboard>/a" },
        { KeyCode.B, "<Keyboard>/b" },
        { KeyCode.C, "<Keyboard>/c" },
        { KeyCode.D, "<Keyboard>/d" },
        { KeyCode.E, "<Keyboard>/e" },
        { KeyCode.F, "<Keyboard>/f" },
        { KeyCode.G, "<Keyboard>/g" },
        { KeyCode.H, "<Keyboard>/h" },
        { KeyCode.I, "<Keyboard>/i" },
        { KeyCode.J, "<Keyboard>/j" },
        { KeyCode.K, "<Keyboard>/k" },
        { KeyCode.L, "<Keyboard>/l" },
        { KeyCode.M, "<Keyboard>/m" },
        { KeyCode.N, "<Keyboard>/n" },
        { KeyCode.O, "<Keyboard>/o" },
        { KeyCode.P, "<Keyboard>/p" },
        { KeyCode.Q, "<Keyboard>/q" },
        { KeyCode.R, "<Keyboard>/r" },
        { KeyCode.S, "<Keyboard>/s" },
        { KeyCode.T, "<Keyboard>/t" },
        { KeyCode.U, "<Keyboard>/u" },
        { KeyCode.V, "<Keyboard>/v" },
        { KeyCode.W, "<Keyboard>/w" },
        { KeyCode.X, "<Keyboard>/x" },
        { KeyCode.Y, "<Keyboard>/y" },
        { KeyCode.Z, "<Keyboard>/z" },
        { KeyCode.Escape, "<Keyboard>/escape" },
        { KeyCode.Return, "<Keyboard>/enter" },
        { KeyCode.Backspace, "<Keyboard>/backspace" },
        { KeyCode.Tab, "<Keyboard>/tab" },
        { KeyCode.Delete, "<Keyboard>/delete" },
        { KeyCode.UpArrow, "<Keyboard>/upArrow" },
        { KeyCode.DownArrow, "<Keyboard>/downArrow" },
        { KeyCode.LeftArrow, "<Keyboard>/leftArrow" },
        { KeyCode.RightArrow, "<Keyboard>/rightArrow" },
        { KeyCode.LeftAlt, "<Keyboard>/leftAlt" },
        { KeyCode.RightAlt, "<Keyboard>/rightAlt" },
        { KeyCode.Insert, "<Keyboard>/insert" },
        { KeyCode.Home, "<Keyboard>/home" },
        { KeyCode.End, "<Keyboard>/end" },
        { KeyCode.PageUp, "<Keyboard>/pageUp" },
        { KeyCode.PageDown, "<Keyboard>/pageDown" },
        { KeyCode.Numlock, "<Keyboard>/numLock" },
        { KeyCode.CapsLock, "<Keyboard>/capsLock" },
        { KeyCode.ScrollLock, "<Keyboard>/scrollLock" },
        { KeyCode.F1, "<Keyboard>/f1" },
        { KeyCode.F2, "<Keyboard>/f2" },
        { KeyCode.F3, "<Keyboard>/f3" },
        { KeyCode.F4, "<Keyboard>/f4" },
        { KeyCode.F5, "<Keyboard>/f5" },
        { KeyCode.F6, "<Keyboard>/f6" },
        { KeyCode.F7, "<Keyboard>/f7" },
        { KeyCode.F8, "<Keyboard>/f8" },
        { KeyCode.F9, "<Keyboard>/f9" },
        { KeyCode.F10, "<Keyboard>/f10" },
        { KeyCode.F11, "<Keyboard>/f11" },
        { KeyCode.F12, "<Keyboard>/f12" },
        { KeyCode.Pause, "<Keyboard>/pause" },
        { KeyCode.Print, "<Keyboard>/printScreen" },
        { KeyCode.Keypad0, "<Keyboard>/numpad0" },
        { KeyCode.Keypad1, "<Keyboard>/numpad1" },
        { KeyCode.Keypad2, "<Keyboard>/numpad2" },
        { KeyCode.Keypad3, "<Keyboard>/numpad3" },
        { KeyCode.Keypad4, "<Keyboard>/numpad4" },
        { KeyCode.Keypad5, "<Keyboard>/numpad5" },
        { KeyCode.Keypad6, "<Keyboard>/numpad6" },
        { KeyCode.Keypad7, "<Keyboard>/numpad7" },
        { KeyCode.Keypad8, "<Keyboard>/numpad8" },
        { KeyCode.Keypad9, "<Keyboard>/numpad9" },
        { KeyCode.KeypadEnter, "<Keyboard>/numpadEnter" },
        { KeyCode.KeypadPlus, "<Keyboard>/numpadPlus" },
        { KeyCode.KeypadMinus, "<Keyboard>/numpadMinus" },
        { KeyCode.KeypadMultiply, "<Keyboard>/numpadMultiply" },
        { KeyCode.KeypadDivide, "<Keyboard>/numpadDivide" },
        { KeyCode.KeypadPeriod, "<Keyboard>/numpadPeriod" },
        { KeyCode.KeypadEquals, "<Keyboard>/numpadEquals" },
        { KeyCode.Tilde, "<Keyboard>/backquote" },
        { KeyCode.Minus, "<Keyboard>/minus" },
        { KeyCode.Equals, "<Keyboard>/equals" },
        { KeyCode.LeftBracket, "<Keyboard>/leftBracket" },
        { KeyCode.RightBracket, "<Keyboard>/rightBracket" },
        { KeyCode.Semicolon, "<Keyboard>/semicolon" },
        { KeyCode.Quote, "<Keyboard>/quote" },
        { KeyCode.Comma, "<Keyboard>/comma" },
        { KeyCode.Period, "<Keyboard>/period" },
        { KeyCode.Slash, "<Keyboard>/slash" },
        { KeyCode.Backslash, "<Keyboard>/backslash" },
        { KeyCode.Alpha1, "<Keyboard>/1" },
        { KeyCode.Alpha2, "<Keyboard>/2" },
        { KeyCode.Alpha3, "<Keyboard>/3" },
        { KeyCode.Alpha4, "<Keyboard>/4" },
        { KeyCode.Alpha5, "<Keyboard>/5" },
        { KeyCode.Alpha6, "<Keyboard>/6" },
        { KeyCode.Alpha7, "<Keyboard>/7" },
        { KeyCode.Alpha8, "<Keyboard>/8" },
        { KeyCode.Alpha9, "<Keyboard>/9" },
        { KeyCode.Alpha0, "<Keyboard>/0" }
    };
}
