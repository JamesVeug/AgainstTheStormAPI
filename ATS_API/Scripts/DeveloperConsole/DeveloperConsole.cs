using Eremite;
using QFSW.QC;
using UnityEngine;

namespace ATS_API.Scripts.DeveloperConsole
{
    internal static class DeveloperConsole
    {
        private static bool s_ConsoleEnabled = false;
        
        public static void Initialize()
        {
            Hotkeys.New(PluginInfo.PLUGIN_GUID, "toggleDevConsole", "Toggle Developer Console", [KeyCode.F1], ToggleConsole);
        }

        private static void ToggleConsole()
        {
            if (!Configs.DeveloperConsoleEnabled)
            {
                Plugin.Log.LogError("Developer console is disabled in the config");
                return;
            }
            
            if (!GameMB.IsGameActive)
            {
                Plugin.Log.LogError("Game is not active to toggle the console");
                return;
            }

            QuantumConsole console = GetQuantumConsole();
            if (console == null)
            {
                Plugin.Log.LogError("Unable to toggle the console");
                return;
            }
            
            s_ConsoleEnabled = !s_ConsoleEnabled;
            
            console.enabled = s_ConsoleEnabled;
            console.GetComponent<Canvas>().enabled = s_ConsoleEnabled;
            console.Toggle();
            console.FocusConsoleInput();
            if (s_ConsoleEnabled)
            {
                GameMB.TimeScaleService.Pause(false);
                MB.InputService.LockInput(console);
            }
            else
            {
                GameMB.TimeScaleService.Unpause(false);
                MB.InputService.ReleaseInput(console);
            }
            
            Plugin.Log.LogMessage("Developer console toggled to " + (console.enabled ? "enabled" : "disabled"));
        }

        private static QuantumConsole s_cachedQuantumConsole = null;
        private static QuantumConsole GetQuantumConsole()
        {
            if (s_cachedQuantumConsole == null)
            {
                s_cachedQuantumConsole = GameObject.FindObjectOfType<QuantumConsole>(true);
                if(s_cachedQuantumConsole == null)
                {
                    Plugin.Log.LogError("QuantumConsole not found, creating new one");
                    s_cachedQuantumConsole = new GameObject("QuantumConsole").AddComponent<QuantumConsole>();
                }
                else
                {
                    Plugin.Log.LogMessage("QuantumConsole found");
                }

                s_ConsoleEnabled = false;
                s_cachedQuantumConsole.enabled = s_ConsoleEnabled;
            }

            return s_cachedQuantumConsole;
        }
    }
}