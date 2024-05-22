using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Trade;
using HarmonyLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API;

[HarmonyPatch]
public class WIKI
{
    [Serializable]
    public class GoodsExport
    {
        [Serializable]
        public class TraderDetails
        {
            public string Name;
            public int Amount;
            public int Weight;
        }
        public GoodModel Good;
        public List<TraderDetails> TradersAvailable = new List<TraderDetails>();
    }

    public static void LogEnumForTypesCSScript<T>(IEnumerable<T> list, Func<T, string> nameGetter, string DictionaryPrefix)
    {
        List<T> sortedList = list.OrderBy(a => nameGetter(a).ToEnumString()).ToList();
        Debug.Log($"{typeof(T)}: " + string.Join("\n", sortedList.Select(a => nameGetter(a).ToEnumString() + ",")));
        
        Debug.Log($"{typeof(T)}: " + string.Join(",\n", sortedList.Select(a => "{ " + DictionaryPrefix + "." + nameGetter(a).ToEnumString() + ", \"" + nameGetter(a) + "\" }")));
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
    
    public static void DumpGoodsToJSON(GoodModel[] effectModels, string key)
    {
        Plugin.Log.LogInfo($"Exporting {effectModels.Length} goods to JSON.");
        foreach (var model in effectModels)
        {
            try
            {
                GoodsExport goodsExport = new GoodsExport();
                goodsExport.Good = model;
                foreach (TraderModel trader in SO.Settings.traders)
                {
                    GoodRefWeight goodModel = trader.offeredGoods.FirstOrDefault((a)=>a.good.name == model.name);
                    if (goodModel != null)
                    {
                        goodsExport.TradersAvailable.Add(new GoodsExport.TraderDetails()
                        {
                            Name = trader.displayName.GetText(),
                            Amount = goodModel.amount,
                            Weight = goodModel.weight
                        });
                    }
                        
                        
                    GoodRef goodModel2 = trader.guaranteedOfferedGoods.FirstOrDefault((a)=>a.good.name == model.name);
                    if (goodModel2 != null)
                    {
                        goodsExport.TradersAvailable.Add(new GoodsExport.TraderDetails()
                        {
                            Name = trader.displayName.GetText(),
                            Amount = goodModel.amount,
                            Weight = 100
                        });
                    }
                }
                JSONSerializer.Result json = JSONSerializer.ToJson(goodsExport);
                string path = Path.Combine(Plugin.PluginDirectory, "Exports", key, model.Name) + ".json";

                // Create directory if it doesn't exist
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Write to file
                File.WriteAllText(path, json.JSON);
                    
                Plugin.Log.LogInfo($"Exported {model.Name}'s SubObjects {json.SubObjects.Count} to JSON.");
                foreach (JSONSerializer.UnityObjectConverter.SubObjects subObject in json.SubObjects)
                {
                    string subPath = Path.Combine(Plugin.PluginDirectory, "Exports", "Assets", model.name + "_" + subObject.Path);
                    Plugin.Log.LogInfo($"- {subPath}");
                        
                    // Create directory if it doesn't exist
                    string subDirectory = Path.GetDirectoryName(subPath);
                    if (!Directory.Exists(subDirectory))
                    {
                        Directory.CreateDirectory(subDirectory);
                    }
                        
                    if (!File.Exists(subPath))
                    {
                        File.WriteAllBytes(subPath, subObject.Bytes);
                    }
                }
            }
            catch (Exception e)
            {
                Plugin.Log.LogError("Failed to dump good to JSON: " + model.Name);
                Plugin.Log.LogError(e);
            }
        }
    }
    
    public static void DumpEffectsJSON<T>(T[] effectModels, string key, Func<T, string> nameGetter) where T : Object
    {
        Plugin.Log.LogInfo($"Exporting {effectModels.Length} goods to JSON.");
        foreach (var model in effectModels)
        {
            string modelName = nameGetter.Invoke(model);
            try
            {
                JSONSerializer.Result json = JSONSerializer.ToJson(model);
                string path = Path.Combine(Plugin.PluginDirectory, "Exports", key, modelName) + ".json";

                // Create directory if it doesn't exist
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Write to file
                File.WriteAllText(path, json.JSON);
                    
                Plugin.Log.LogInfo($"Exported {modelName}'s SubObjects {json.SubObjects.Count} to JSON.");
                foreach (JSONSerializer.UnityObjectConverter.SubObjects subObject in json.SubObjects)
                {
                    string subPath = Path.Combine(Plugin.PluginDirectory, "Exports", "Assets", modelName + "_" + subObject.Path);
                    Plugin.Log.LogInfo($"- {subPath}");
                        
                    // Create directory if it doesn't exist
                    string subDirectory = Path.GetDirectoryName(subPath);
                    if (!Directory.Exists(subDirectory))
                    {
                        Directory.CreateDirectory(subDirectory);
                    }
                        
                    if (!File.Exists(subPath))
                    {
                        File.WriteAllBytes(subPath, subObject.Bytes);
                    }
                }
            }
            catch (Exception e)
            {
                Plugin.Log.LogError("Failed to dump good to JSON: " + model.name + " " + modelName);
                Plugin.Log.LogError(e);
            }
        }
    }
    
    public static void DumpEffectsJSON()
    {
        DumpEffectsJSON(MB.Settings.effects, "Effects", a=>a.DisplayName);
        DumpEffectsJSON(MB.Settings.resolveEffects, "Effects", a=>a.displayName.GetText());
    }
}