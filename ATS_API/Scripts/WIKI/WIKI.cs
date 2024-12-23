using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Trade;
using HarmonyLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API;

[HarmonyPatch]
public partial class WIKI
{
    private static string exportCSScriptsPath = "";

    class NameComparer : IEqualityComparer<(string name, string enu, string locale)>
    {
        public bool Equals((string name, string enu, string locale) x, (string name, string enu, string locale) y)
        {
            return x.name == y.name;
        }

        public int GetHashCode((string name, string enu, string locale) obj)
        {
            return obj.name.GetHashCode();
        }
    }

    public static void ExportEffectInfo()
    {
        Assembly assembly = typeof(HookLogic).Assembly;
        
        //
        // All EffectModel types
        //
        
        string effectsPath = Path.Combine(Plugin.ExportPath, "WIKI", "Effects.md");
        List<string> effectsKeys = new List<string>(){"Type", "Is Perk"};
        MDFileTableBuilder effectsBuilder = new MDFileTableBuilder(effectsPath, effectsKeys);
        foreach (Type type in assembly.GetTypes().Where(a => a.IsSubclassOf(typeof(EffectModel))).OrderBy(a=>a.Name))
        {
            if (type.IsAbstract) 
                continue;
            
            ScriptableObject scriptableObject = ScriptableObject.CreateInstance(type);
            PropertyInfo property = scriptableObject.GetType().GetProperty("IsPerk");
            bool isPerk = (bool)property.GetMethod.Invoke(scriptableObject, null);
            effectsBuilder.AddData(type.Name, isPerk.ToString());
        }
        effectsBuilder.ExportAsFile();
        
        
        //
        // All HookLogic types
        //
        
        string hooksPath = Path.Combine(Plugin.ExportPath, "WIKI", "HookLogic.md");
        List<string> hooksKeys = new List<string>(){"Type"};
        MDFileTableBuilder hooksBuilder = new MDFileTableBuilder(hooksPath, hooksKeys);
        foreach (Type type in assembly.GetTypes().Where(a => a.IsSubclassOf(typeof(HookLogic))).OrderBy(a=>a.Name))
        {
            if (type.IsAbstract) 
                continue;
            
            hooksBuilder.AddData(type.Name);
        }
        hooksBuilder.ExportAsFile();
    }
}