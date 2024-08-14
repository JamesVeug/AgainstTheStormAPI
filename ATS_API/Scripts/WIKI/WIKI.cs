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

    public static void ExportWikiInformation()
    {
        Assembly assembly = typeof(HookLogic).Assembly;

        // string effectTemplate =
        //     File.ReadAllText(
        //         "C:\\GitProjects\\ATS_API\\ATS_API\\Scripts\\Effects\\EffectFactory\\EffectFactory_Template.txt");
        
        string s = "|Effect Name|Is Perk";
        s += "\n|---|---|\n";
        foreach (Type type in assembly.GetTypes().Where(a => a.IsSubclassOf(typeof(EffectModel))).OrderBy(a=>a.Name))
        {
            if (type.IsAbstract) 
                continue;
            
            ScriptableObject scriptableObject = ScriptableObject.CreateInstance(type);
            PropertyInfo property = scriptableObject.GetType().GetProperty("IsPerk");
            bool isPerk = (bool)property.GetMethod.Invoke(scriptableObject, null);
            s += "|" + type.Name + "|" + isPerk + "|\n";
        }
        // Instance.Logger.LogInfo($"EffectModels: {s}");
        File.WriteAllText("C:\\GitProjects\\ATS_API\\ATS_API\\WIKI\\EFFECTS.md", s);
        
        s = "|Hook Name|";
        s += "\n|---|\n";
        foreach (Type type in assembly.GetTypes().Where(a => a.IsSubclassOf(typeof(HookLogic))).OrderBy(a=>a.Name))
        {
            s += "|" + type.Name + "|\n";
        }
        // Instance.Logger.LogInfo($"HookLogics: {s}");
        File.WriteAllText("C:\\GitProjects\\ATS_API\\ATS_API\\WIKI\\HOOKS.md", s);
    }
}