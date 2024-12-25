using System.Collections.Generic;
using System.IO;
using System.Linq;
using Eremite;
using Eremite.Tools.Runtime;
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
                APILogger.LogError("Developer console is disabled in the config");
                return;
            }
            
            if (!GameMB.IsGameActive)
            {
                APILogger.LogError("Game is not active to toggle the console");
                return;
            }

            QuantumConsole console = GetQuantumConsole();
            if (console == null)
            {
                APILogger.LogError("Unable to toggle the console");
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
            
            APILogger.LogInfo("Developer console toggled to " + (console.enabled ? "enabled" : "disabled"));
        }

        private static QuantumConsole s_cachedQuantumConsole = null;
        private static QuantumConsole GetQuantumConsole()
        {
            if (s_cachedQuantumConsole == null)
            {
                s_cachedQuantumConsole = GameObject.FindObjectOfType<QuantumConsole>(true);
                if(s_cachedQuantumConsole == null)
                {
                    APILogger.LogError("QuantumConsole not found, creating new one");
                    s_cachedQuantumConsole = new GameObject("QuantumConsole").AddComponent<QuantumConsole>();
                }
                else
                {
                    APILogger.LogInfo("QuantumConsole found");
                }

                s_ConsoleEnabled = false;
                s_cachedQuantumConsole.enabled = s_ConsoleEnabled;
            }

            return s_cachedQuantumConsole;
        }
        
        public static void ExportAllCommands()
        {
            // Find all methods with Command attribute
            var types = typeof(QuantumConsoleInputLocker).Assembly.GetTypes();
            var methods = types.SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typeof(CommandAttribute), false).Length > 0)
                .SelectMany(m => m.GetCustomAttributes(typeof(CommandAttribute), false))
                .Cast<CommandAttribute>()
                .OrderBy(a=>a.Alias)
                .ToArray();
            
            // Export all commands to a .table file
            string path = Path.Combine(Plugin.ExportPath, "WIKI", "QuantumConsoleCommands.md");
            List<string> keys = new List<string>() { "command", "description" };
            MDFileTableBuilder tableBuilder = new MDFileTableBuilder(path, keys);
            foreach (CommandAttribute commandAttribute in methods)
            {
                tableBuilder.AddData(commandAttribute.Alias, commandAttribute.Description);
            }
            tableBuilder.ExportAsFile();

        }
    }
}