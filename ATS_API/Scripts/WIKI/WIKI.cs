using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

    public static void LogEnumForTypesCSScript<T>(IEnumerable<T> list, Func<T, string> nameGetter, string DictionaryPrefix, Func<T, string> localizedStuff)
    {
        List<Tuple<string, string, string>> sortedList = list.Select(a =>
        {
            string getter = nameGetter(a);
            return new Tuple<string, string, string>(getter, getter.ToEnumString(), localizedStuff(a));
        }).OrderBy((a)=>a.Item2).ToList();
        
        Debug.Log($"{typeof(T)}: " + string.Join("\n", sortedList.Select(a => a.Item2 + ", // " + a.Item3)));
        
        Debug.Log($"{typeof(T)}: " + string.Join("\n", sortedList.Select(a => "{ " + DictionaryPrefix + "." + a.Item2 + ", \"" + a.Item1 + "\" }, // " + a.Item3)));
    }

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
    
    public static void CreateEnumTypesCSharpScript<T>(string EnumName, string modelGetter, IEnumerable<T> list, Func<T, string> nameGetter, Func<T, string> comment, List<string> extraUsings = null, Func<string ,string> enumParser=null, Func<T, string> groupEnumsBy=null)
    {
        string pathToFile = "C:\\GitProjects\\ATS_API\\ATS_API\\Scripts\\Helpers\\Enums\\";
        // Quit if the directory does not exist
        if (!Directory.Exists(pathToFile))
        {
            Plugin.Log.LogError("Directory does not exist: " + pathToFile);
            return;
        }

        HashSet<T> set = new(list);
        Dictionary<string, List<T>> groups = new();
        if (groupEnumsBy != null)
        {
            foreach (T t in set)
            {
                string group = groupEnumsBy(t);
                if (!groups.ContainsKey(group))
                {
                    groups[group] = new List<T>();
                }
                groups[group].Add(t);
            }
        }
        else
        {
            groups["__default"] = set.ToList();
        }

        Dictionary<string, List<(string name, string enu, string locale)>> sorted = new();
        foreach (KeyValuePair<string,List<T>> pair in groups)
        {
            List<(string name, string enu, string locale)> sortedList = pair.Value.Select(a =>
            {
                string getter = nameGetter(a);
                string locale = null;
                if (comment != null)
                {
                    try
                    {
                        string l = comment(a);
                        if (!string.IsNullOrEmpty(l) && l != ">Missing key<")
                        {
                            locale = l.Replace("\n", "");
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            
                string enu = enumParser != null ? enumParser.Invoke(getter) : getter.ToEnumString();
                return (getter, enu, locale);
            }).OrderBy((a) => a.Item2).ToList();
            sorted[pair.Key] = sortedList;
        }

        List<string> sortedGroups = groups.Keys.OrderBy(a => a).ToList();

        string ModelName = typeof(T).Name;
        string version = Application.version;
        string header = "// Generated using Version " + version;
        string firstEnum = sorted[sortedGroups[0]][0].enu;
        
        string usings = ""; // end with \n IF we have any usings
        if (extraUsings != null && extraUsings.Count > 0)
        {
            usings = string.Join("\n", extraUsings.Select(a=>"using " + a + ";")) + "\n";
        }

        int EnumCharacterCount = sorted.Max(a => a.Value.Max(b => b.enu.Length));
        int DictionaryCharacterCount = sorted.Max(a => a.Value.Max(b => b.enu.Length + b.name.Length));

        string GetEnumLine((string name, string enu, string locale) a)
        {
            int extraCharactersBeforeLocale = EnumCharacterCount - a.enu.Length;
            string s = "\t" + a.enu + ", ";
            if (!string.IsNullOrEmpty(a.locale))
            {
                s += new string(' ', extraCharactersBeforeLocale) + "// " + a.locale;
            }
            return s;
        }

        string ToDictionaryRow((string name, string enu, string locale) a)
        {
            int extraCharactersBeforeLocale = DictionaryCharacterCount - (a.enu.Length + a.name.Length);
            string s = "\t\t{ " + EnumName + "." + a.Item2 + ", \"" + a.Item1 + "\" }, ";
            if (!string.IsNullOrEmpty(a.locale))
            {
                s += new string(' ', extraCharactersBeforeLocale) + "// " + a.Item3;
            }
            
            return s;
        }

        string enumLines = "";
        string dictionaryLines = "";
        foreach (string group in sortedGroups)
        {
            List<(string name, string enu, string locale)> groupList = sorted[group];
            if (group != "__default")
            {
                enumLines += $"\n\t// {group}\n";
                dictionaryLines += $"\n\t\t// {group}\n";
            }
            enumLines += string.Join("\n", groupList.Select(GetEnumLine)) + "\n";
            dictionaryLines += string.Join("\n", groupList.Select(ToDictionaryRow)) + "\n";
        }

        var template = Util.ReadEmbeddedResource(typeof(WIKI).Assembly, "EnumTemplate.txt");
        string cs = template
            .Replace("{USINGS}", usings)
            .Replace("{CLASS_HEADER}", header)
            .Replace("{CLASSNAME}", EnumName)
            .Replace("{ENUMS}", enumLines)
            .Replace("{TOTAL_ENUMS}", set.Count.ToString())
            .Replace("{FIRST_ENUM}", firstEnum)
            .Replace("{MODELNAME}", ModelName)
            .Replace("{COLLECTION}", modelGetter)
            .Replace("{ENUM_TO_NAME}", dictionaryLines);
        
        File.WriteAllText(pathToFile + EnumName + ".cs", cs);
    }

    public static void CreateAllEnumTypes()
    {
        Func<string, string> noStartingNumbersEnum = (a) => a.ToEnumString(true);
        
        CreateEnumTypesCSharpScript("BuildingCategoriesTypes", "SO.Settings.BuildingCategories", SO.Settings.BuildingCategories, a=>a.name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingTagTypes", "SO.Settings.buildingsTags", SO.Settings.buildingsTags, a=>a.Name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingTypes", "SO.Settings.Buildings", SO.Settings.Buildings, a=>a.Name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("NeedTypes", "SO.Settings.Needs", SO.Settings.Needs, a=>a.Name, a=>a.DisplayName, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("GoodsTypes", "SO.Settings.Goods", SO.Settings.Goods, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("ProfessionTypes", "SO.Settings.Professions", SO.Settings.Professions, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("RaceTypes", "SO.Settings.Races", SO.Settings.Races, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("TagTypes", "SO.Settings.tags", SO.Settings.tags, a=>a.Name, null, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("TraderTypes", "SO.Settings.traders", SO.Settings.traders, a=>a.Name, NameAndDescription, ["Eremite.Model.Trade"]);

        Func<EffectModel, string> effectGroup = EffectGroup;
        CreateEnumTypesCSharpScript("EffectTypes", "SO.Settings.effects", SO.Settings.effects, a=>a.Name, NameAndDescription, ["Eremite.Model"], groupEnumsBy:effectGroup);
        CreateEnumTypesCSharpScript("ResolveEffectTypes", "SO.Settings.resolveEffects", SO.Settings.resolveEffects, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("OrderTypes", "SO.Settings.orders", SO.Settings.orders, a=>a.Name, NameAndDescription, ["Eremite.Model.Orders"]);
        CreateEnumTypesCSharpScript("BiomeTypes", "SO.Settings.biomes", SO.Settings.biomes, a=>a.Name, NameAndDescription, ["Eremite.WorldMap"]);

        Func<DifficultyModel, string> difficultyComment = DifficultyComment;
        CreateEnumTypesCSharpScript("DifficultyTypes", "SO.Settings.difficulties", SO.Settings.difficulties, a=>a.Name, difficultyComment, ["Eremite.Model"], noStartingNumbersEnum);
        CreateEnumTypesCSharpScript("GoalTypes", "SO.Settings.goals", SO.Settings.goals, a=>a.Name, NameAndDescription, ["Eremite.Model.Goals"]);
        CreateEnumTypesCSharpScript("RelicTypes", "SO.Settings.Relics", SO.Settings.Relics, a=>a.Name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("MetaRewardTypes", "SO.Settings.metaRewards", SO.Settings.metaRewards, a=>a.Name, a=>a.DisplayName, ["Eremite.Model.Meta"]);
        CreateEnumTypesCSharpScript("OreTypes", "SO.Settings.Ore", SO.Settings.Ore, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
    }

    private static string EffectGroup(EffectModel arg)
    {
        return arg.GetType().Name;
    }

    private static string NameAndDescription(object a)
    {
        Type type = a.GetType();


        // Display Name
        string displayName = (string)type.GetProperty("DisplayName",
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty)
            ?.GetMethod
            ?.Invoke(a, null);

        if (string.IsNullOrEmpty(displayName))
        {
            var locaTextField = type.GetField("displayName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            object dnValue = locaTextField?.GetValue(a);
            displayName = (string)locaTextField?.FieldType.GetMethod("GetText", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                ?.Invoke(dnValue, null);
        }
        if(displayName == ">Missing key<")
            displayName = "";
        
        
        // Description
        string description = (string)type.GetProperty("Description",
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty)
            ?.GetMethod
            ?.Invoke(a, null);
        
        if (string.IsNullOrEmpty(description))
        {
            var desc = type.GetField("description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            object descValue = desc?.GetValue(a);
            description = (string)desc?.FieldType.GetMethod("GetText", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                ?.Invoke(descValue, null);
        }

        if(description == ">Missing key<")
            description = "";
        
        if(!string.IsNullOrEmpty(displayName) && !string.IsNullOrEmpty(description))
            return displayName + " - " + description;
        
        if(string.IsNullOrEmpty(displayName) && string.IsNullOrEmpty(description))
            return "";
        
        if(string.IsNullOrEmpty(displayName))
            return description;
        
        return displayName;
    }

    private static string DifficultyComment(DifficultyModel a)
    {
        string ascensionText = a.isAscension ? (a.ascensionIndex + 1) + " " : "";
        return a.displayName.GetText() + " " + ascensionText + "- " + ((a.modifiers.Length == 0)
            ? a.GetText("WorldUI_FieldPanel_Difficulty_NoModifiers")
            : a.modifiers.Last().shortDesc.Text);
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