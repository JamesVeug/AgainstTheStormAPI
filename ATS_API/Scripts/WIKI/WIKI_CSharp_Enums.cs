using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API;

public partial class WIKI
{
    public static void CreateEnumTypesCSharpScript<T>(string EnumName, string modelGetter, IEnumerable<T> list,
        Func<T, string> nameGetter, Func<T, string> comment, List<string> extraUsings = null,
        Func<string, string> enumParser = null, Func<T, string> groupEnumsBy = null)
    {
        // Quit if the directory does not exist
        if (!Directory.Exists(exportCSScriptsPath))
        {
            Directory.CreateDirectory(exportCSScriptsPath);
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
        foreach (KeyValuePair<string, List<T>> pair in groups)
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
            usings = string.Join("\n", extraUsings.Select(a => "using " + a + ";")) + "\n";
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

        File.WriteAllText(Path.Combine(exportCSScriptsPath, EnumName + ".cs"), cs);
    }

    public static void CreateAllEnumTypes(string csExportPath)
    {
        exportCSScriptsPath = csExportPath;
        Func<string, string> noStartingNumbersEnum = (a) => a.ToEnumString(true);
        
        CreateEnumTypesCSharpScript("BuildingCategoriesTypes", "SO.Settings.BuildingCategories", SO.Settings.BuildingCategories, a=>a.name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingTagTypes", "SO.Settings.buildingsTags", SO.Settings.buildingsTags, a=>a.Name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingTypes", "SO.Settings.Buildings", SO.Settings.Buildings, a=>a.Name, NameAndDescription, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("NeedTypes", "SO.Settings.Needs", SO.Settings.Needs, a=>a.Name, a=>a.DisplayName, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("GoodsTypes", "SO.Settings.Goods", SO.Settings.Goods, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("GoodsCategoriesTypes", "SO.Settings.GoodsCategories", SO.Settings.GoodsCategories, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
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
        CreateEnumTypesCSharpScript("MetaRewardTypes", "SO.Settings.metaRewards", SO.Settings.metaRewards, a=>a.Name, a=>a.GetType().Name + "-" + a.DisplayName, ["Eremite.Model.Meta"]);
        CreateEnumTypesCSharpScript("OreTypes", "SO.Settings.Ore", SO.Settings.Ore, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("VillagerPerkTypes", "SO.Settings.villagersPerks", SO.Settings.villagersPerks, a=>a.Name, NameAndDescription, ["Eremite.Characters.Villagers"]);
        CreateEnumTypesCSharpScript("BuildingPerkTypes", "SO.Settings.buildingsPerks", SO.Settings.buildingsPerks, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("MetaCurrencyTypes", "SO.Settings.metaCurrencies", SO.Settings.metaCurrencies, a=>a.Name, NameAndDescription, ["Eremite.Model"]);
    }

    private static string EffectGroup(EffectModel arg)
    {
        return arg.GetType().Name;
    }

    private static string NameAndDescription(object a)
    {

        static void Log(object o, string s)
        {
            // if (o is GoodModel effectModel)
            // {
            //     Plugin.Log.LogInfo("WIKI: " + effectModel.name + " " + s);
            // }
        }
        
        static string GetFieldResults(object instance, string[] properties, string[] fields)
        {
            Type type = instance.GetType();
            Log(instance, "Properties: " + string.Join(", ", properties));

            object result = null;
            List<PropertyInfo> propertiesInfos = Util.AllProperties(type, properties);
            foreach (string name in properties)
            { 
                Log(instance, "Checking property " + name);
                PropertyInfo propertyInfo = propertiesInfos.FirstOrDefault(a=>a.Name == name);
                if (propertyInfo != null)
                {
                    MethodInfo getMethod = propertyInfo.GetMethod;
                    if (getMethod != null)
                    {
                        Log(instance, "Property " + name + " has get method");
                        Log(instance, "... Test");
                        try
                        {
                            result = propertyInfo.GetValue(instance);
                            if (result != null)
                            {
                                Log(instance, "Property Result is not null!");
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Log(instance, "Property " + name + " failed to get value");
                        }
                        
                        Log(instance, "Property Result IS null...");
                    }
                    else
                    {
                        Log(instance, "Property " + name + " has no get method");
                    }
                }
                else
                {
                    Log(instance, "Property " + name + " not found");
                }
            }

            if (result == null)
            {
                List<FieldInfo> fieldInfos = Util.AllFields(type, fields);
                foreach (string name in fields)
                {
                    FieldInfo fieldInfo = fieldInfos.FirstOrDefault(a => a.Name == name);
                    if (fieldInfo != null)
                    {
                        Log(instance, "Field " + name + " found");
                        try
                        {
                            result = fieldInfo.GetValue(instance);
                            if (result != null)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Log(instance, "Field " + name + " failed to get value");
                        }
                    }
                    else
                    {
                        Log(instance, "Field " + name + " not found for type " + type.FullName);
                    }
                }
            }

            if (result != null)
            {
                if (result is LocaText locaText)
                {
                    Log(instance, "Found " + locaText.GetText());
                    return locaText.GetText();
                }
                else if (result is string s)
                {
                    Log(instance, "Found " + s);
                    return s;
                }
                
                Log(instance, "Something was found but unknown " + result.GetType().FullName);
            }
            else
            {
                Log(instance, "Nothing found");
            }

            return null;
        }


        // Display Name
        string displayName = GetFieldResults(a, ["DisplayName"], ["displayName"]);
        if(displayName == ">Missing key<")
        {
            Log(a, "DisplayName is missing key");
            displayName = "";
        }


        // Description
        string description = GetFieldResults(a, ["FormatedDescription", "Description"], ["description"]);
        if(description == ">Missing key<")
        {
            Log(a, "Description is missing key");
            description = "";
        }

        string result = "";
        if(!string.IsNullOrEmpty(displayName) && !string.IsNullOrEmpty(description))
            result = displayName + " - " + description;
        
        else if(string.IsNullOrEmpty(displayName) && string.IsNullOrEmpty(description))
            result = "";

        else if (string.IsNullOrEmpty(displayName))
            result = description;
        else
            result = displayName;
        
        Log(a, "Result: " + result + " from " + displayName + " - " + description);
        
        return result;
    }

    private static string DifficultyComment(DifficultyModel a)
    {
        string ascensionText = a.isAscension ? (a.ascensionIndex + 1) + " " : "";
        return a.displayName.GetText() + " " + ascensionText + "- " + ((a.modifiers.Length == 0)
            ? a.GetText("WorldUI_FieldPanel_Difficulty_NoModifiers")
            : a.modifiers.Last().shortDesc.Text);
    }
}