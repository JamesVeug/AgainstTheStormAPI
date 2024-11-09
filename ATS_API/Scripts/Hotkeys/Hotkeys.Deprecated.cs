using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ATS_API;

public static partial class Hotkeys
{
    [Obsolete("Use Hotkeys.New() instead")]
    public static void RegisterKey(string modName, string keyName, string displayName, List<KeyCode> codes, Action<InputAction.CallbackContext> callback = null)
    {
        New(modName, keyName, displayName, codes, callback);
    }
    
    [Obsolete("Use Hotkeys.New() instead")]
    public static void RegisterKey(string modName, string keyName, string displayName, List<KeyCode> codes,
        Action onPress = null, Action onRelease = null)
    {
        New(modName, keyName, displayName, codes, onPress, onRelease);
    }
    
    [Obsolete("Use Hotkeys.New() instead")]
    public static void RegisterKey(string modName, Hotkey hotkey)
    {
        Add(modName, hotkey);
    }
}