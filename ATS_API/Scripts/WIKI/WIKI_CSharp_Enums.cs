using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Meta;
using UnityEngine;

namespace ATS_API;

public partial class WIKI
{
    public static void CreateEnumTypesCSharpScript<T>(string EnumName, string modelGetter, IEnumerable<T> list,
        Func<T, string> nameGetter, Func<T, Dictionary<string, string>> comment, List<string> extraUsings = null,
        Func<string, string> enumParser = null, Func<T, string> groupEnumsBy = null, bool includeNamespaceInType=false, Func<T, int> orderBy = null)
    {
        APILogger.LogInfo("Creating Enum: " + EnumName);
        // Quit if the directory does not exist
        if (!Directory.Exists(exportCSScriptsPath))
        {
            Directory.CreateDirectory(exportCSScriptsPath);
        }

        APILogger.LogInfo("Grouping values...");
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
        else if(set.Count > 0)
        {
            groups["__default"] = set.ToList();
        }
        else if (set.Count == 0)
        {
            APILogger.LogWarning("No values found for " + EnumName);
        }
        
        APILogger.LogInfo("Sorting values...");
        Dictionary<string, List<(string name, string enu, Dictionary<string, string> locale)>> sorted = new();
        foreach (KeyValuePair<string, List<T>> pair in groups)
        {
            List<(string name, string enu, Dictionary<string, string> locale)> sortedList = pair.Value.Select(a =>
            {
                string getter = nameGetter(a);
                Dictionary<string, string> locale = new Dictionary<string, string>();
                if (comment != null)
                {
                    try
                    {
                        Dictionary<string, string> l = comment(a);
                        if (l != null)
                        {
                            foreach (KeyValuePair<string,string> pair in l)
                            {
                                if (pair.Value != ">Missing key<")
                                {
                                    if (pair.Key == "name")
                                    {
                                        locale[pair.Key] = pair.Value;
                                    }
                                    else
                                    {
                                        locale[pair.Key] = CleanComment(pair.Value);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // ignored
                        APILogger.LogError("Failed to get comment for " + getter + "\n" + e);
                    }
                }

                string enu = enumParser != null ? enumParser.Invoke(getter) : getter.ToEnumString();
                return (getter, enu, locale);
            }).ToList();

            // Sort them
            // NOTE: For some reason list.Sort sorts differently than list.OrderBy
            // so to avoid breaking existing mods only new enums will use that.
            if (orderBy != null)
            {
                sortedList.Sort((a, b) =>
                {
                    T ta = pair.Value.First(c => nameGetter(c) == a.name);
                    T tb = pair.Value.First(c => nameGetter(c) == b.name);
                    return orderBy(ta).CompareTo(orderBy(tb));
                });
            }
            else
            {
                sortedList = sortedList.OrderBy(a=>a.enu).ToList();
            }
            
            sorted[pair.Key] = sortedList;
        }

        APILogger.LogInfo("Sorting keys...");
        List<string> sortedGroups = groups.Keys.OrderBy(a => a).ToList();

        APILogger.LogInfo("Creating C# file...");
        string fullModelName = typeof(T).FullName;
        string modelName = typeof(T).Name;
        string version = Application.version;
        string header = "/// <summary>\n" +
                        "/// Generated using Version " + version + "\n" +
                        "/// </summary>";
        string firstEnum = "None";
        if (sortedGroups.Count > 0)
        {
            firstEnum = sorted[sortedGroups[0]][0].enu;
        }

        APILogger.LogInfo("Creating usings...");
        string usings = ""; // end with \n IF we have any usings
        if (extraUsings != null && extraUsings.Count > 0)
        {
            usings = string.Join("\n", extraUsings.Select(a => "using " + a + ";"));
        }

        APILogger.LogInfo("Calculating character count...");
        int EnumCharacterCount = 0;
        int DictionaryCharacterCount = 0;
        if(sorted.Count > 0)
        {
            EnumCharacterCount = sorted.Max(a => a.Value.Max(b => b.enu.Length));
            DictionaryCharacterCount = sorted.Max(a => a.Value.Max(b => b.enu.Length + b.name.Length));
        }

        string GetEnumLine((string name, string enu, Dictionary<string, string> locale) a, string group, int enumValue)
        {
            if (a.locale.Count == 0)
            {
                return "\t" + a.enu + " = " + enumValue + ",\n";
            }

            string text = "";
            if (a.locale.TryGetValue("summary", out string summary) && !string.IsNullOrEmpty(summary))
            {
                string cleanComment = CleanComment(summary);
                if (cleanComment.Contains("\n"))
                {
                    string sentence = "";
                    for (var i = 0; i < cleanComment.Split('\n').Length; i++)
                    {
                        string s = cleanComment.Split('\n')[i].Trim();
                        if (string.IsNullOrEmpty(s))
                        {
                            continue;
                        }

                        if (sentence.Length > 0)
                        {
                            sentence += "</p>\n";
                        }
                        
                        sentence += "\t/// <p>" + s;
                    }
                    cleanComment = sentence + "</p>";
                    // cleanComment = "<p>" + cleanComment.Replace("\n", "</p>\n\t/// <p>") + "</p>";
                }
                else
                {
                    cleanComment = "\t/// " + cleanComment;
                }
                text = "\t/// <summary>\n" +
                       cleanComment + "\n" +
                       "\t/// </summary>\n";
            }
            else
            {
                text = "\t/// <summary></summary>\n";
            }

            foreach (KeyValuePair<string,string> pair in a.locale)
            {
                if (pair.Key == "summary")
                {
                    continue;
                }

                text += $"\t/// <{pair.Key}>{pair.Value}</{pair.Key}>\n";
            }
            
            // if(group != "__default")
            //     text += $"\t/// <group>{group}</group>\n";

            return text + "\t" + a.enu + " = " + enumValue + ",\n";
        }

        string ToDictionaryRow((string name, string enu, Dictionary<string, string> locale) a)
        {
            int extraCharactersBeforeLocale = DictionaryCharacterCount - (a.enu.Length + a.name.Length);
            string s = "\t\t{ " + EnumName + "." + a.Item2 + ", \"" + a.Item1 + "\" }, ";
            if (a.locale.TryGetValue("summary", out string summary) && !string.IsNullOrEmpty(summary))
            {
                s += new string(' ', extraCharactersBeforeLocale) + "// " + CleanComment(summary).Replace("\n", " ");
            }

            return s;
        }

        APILogger.LogInfo("Creating enum and dictionary lines...");
        Dictionary<string, int> existingEnumValues = CalculateExistingEnumValues(EnumName, out int maxEnumValue);
        string enumLines = "";
        string dictionaryLines = "";
        int newEnumValue = existingEnumValues.Any() ? maxEnumValue + 1 : 1; // First custom enum starts at 1 or however we already have
        foreach (string group in sortedGroups)
        {
            List<(string name, string enu, Dictionary<string, string> locale)> groupList = sorted[group];
            if (group != "__default")
            {
                enumLines += $"\n\t//";
                enumLines += $"\n\t// {group}";
                enumLines += $"\n\t//\n\n";
                dictionaryLines += $"\n\t\t// {group}\n";
            }

            enumLines += string.Join("\n", groupList.Select(a=>
            {
                if (!existingEnumValues.TryGetValue(a.enu, out int currentEnumValue))
                {
                    APILogger.LogInfo("New enum: " + EnumName + "." + a.enu);
                    currentEnumValue = newEnumValue++;
                }
                return GetEnumLine(a, group, currentEnumValue);
            })) + "\n";
            dictionaryLines += string.Join("\n", groupList.Select(ToDictionaryRow)) + "\n";
        }

        APILogger.LogInfo("Creating template...");
        var template = Util.ReadEmbeddedResource(typeof(WIKI).Assembly, "EnumTemplate.txt");
        string cs = template
            .Replace("{USINGS}", usings)
            .Replace("{CLASS_HEADER}", header)
            .Replace("{CLASSNAME}", EnumName)
            .Replace("{ENUMS}", enumLines)
            .Replace("{TOTAL_ENUMS}", newEnumValue.ToString())
            .Replace("{FIRST_ENUM}", firstEnum)
            .Replace("{FULLMODELNAME}", fullModelName)
            .Replace("{MODELNAME}", modelName)
            .Replace("{COLLECTION}", modelGetter)
            .Replace("{ENUM_TO_NAME}", dictionaryLines);

        APILogger.LogInfo("Writing to file...");
        File.WriteAllText(Path.Combine(exportCSScriptsPath, EnumName + ".cs"), cs);
    }

    private static Dictionary<string,int> CalculateExistingEnumValues(string enumName, out int max)
    {
        Type type = Type.GetType("ATS_API.Helpers." + enumName);
        Dictionary<string, int> existingEnumValues = new();
        if (type == null)
        {
            APILogger.LogWarning("Could not find enum type: " + enumName);
            max = 0;
            return existingEnumValues;
        }

        max = 0;
        foreach (string name in Enum.GetNames(type))
        {
            int intValue = (int)Enum.Parse(type, name);
            if (intValue > 0 && name != "MAX")
            {
                existingEnumValues[name] = intValue;
                if (intValue > max)
                {
                    max = intValue;
                }
            }
        }

        // APILogger.LogInfo("Found enum " + enumName);
        // foreach (KeyValuePair<string,int> pair in existingEnumValues)
        // {
        //     APILogger.LogInfo(" " + pair.Key + " = " + pair.Value);
        // }
        return existingEnumValues;
    }

    private static string CleanComment(string text)
    {
        // TODO: Find all unclosed tags eg: <sprite name=X> and close them with <sprite name=X/>
        text = text.Replace(">Missing key<", "Missing key");
        
        int index = text.IndexOf("<");
        while (index != -1)
        {
            int end = text.IndexOf(">", index);
            if (end != -1 && text[end - 1] != '/')
            {
                string existingTag = text.Substring(index, end - index + 1);
                string replaceText = ParseTag(existingTag);
                
                text = text.Substring(0, index) + replaceText + text.Substring(end + 1);
            }

            index = text.IndexOf("<", index + 1);
        }
        
        return text;
    }

    private static string ParseTag(string s)
    {
        // <b> /b>
        // <sprite name=X>
        // <sprite name=X align=left>
        // <color=#FF0000> /color>
        
        int tagNameStartIndex = 1;
        if (s[1] == '/')
        {
            tagNameStartIndex++;
        }
        
        int tagNameEndIndex = s.IndexOf(" ");
        if (tagNameEndIndex == -1)
        {
            tagNameEndIndex = s.IndexOf(">");
        }
        
        string tagName = s.Substring(tagNameStartIndex, tagNameEndIndex - tagNameStartIndex);
        int tagEquals = tagName.IndexOf("=");
        if (tagEquals != -1)
        {
            tagName = tagName.Substring(0, tagEquals);
        }
        
        Dictionary<string, string> args = new();
        
        int nextSplit = s.IndexOf("=");
        while (nextSplit != -1)
        {
            int previousSpace = s.LastIndexOf(" ", nextSplit);
            int nextSpace = s.IndexOf(">", nextSplit); // Assuming 1 argument

            string key = s.Substring(previousSpace + 1, nextSplit - previousSpace - 1);
            string value = s.Substring(nextSplit + 1, nextSpace - nextSplit - 1);
            args[key] = value;
            
            nextSplit = s.IndexOf("=", nextSpace);
        }
        
        
        // Replace <sprite name=X> with X
        if (tagName == "sprite")
        {
            string spriteName = args["name"];
            return spriteName; // TODO: Find display name instead
        }
        else if (tagName == "color")
        {
            return ""; // Hex does not work so just remove it
        }
        else if (tagName == "b" || tagName == "i" || tagName == "u")
        {
            return s; // Don't change this tag!
        }
        else
        {
            string argString = string.Join(", ", args.Select(a => a.Key + "=" + a.Value));
            APILogger.LogInfo("Unhandled tag: '" + tagName + "' with args: '" + argString + "'");
        }
        
        return s;
    }

    public static void CreateAllEnumTypes(string csExportPath)
    {
        exportCSScriptsPath = csExportPath;
        Func<string, string> noStartingNumbersEnum = (a) => a.ToEnumString(true);
        
        CreateEnumTypesCSharpScript("BuildingTypes", "SO.Settings.Buildings", SO.Settings.Buildings, a=>a.Name, BuildingComment, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("WorkshopTypes", "SO.Settings.workshops", SO.Settings.workshops, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("CollectorTypes", "SO.Settings.Buildings.Where(a=>a is CollectorModel).Cast<CollectorModel>()", SO.Settings.Buildings.Where(a=>a is CollectorModel).Cast<CollectorModel>().ToArray(), a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("FarmTypes", "SO.Settings.Buildings.Where(a=>a is FarmModel).Cast<FarmModel>()", SO.Settings.Buildings.Where(a=>a is FarmModel).Cast<FarmModel>().ToArray(), a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("FishingHutTypes", "SO.Settings.Buildings.Where(a=>a is FishingHutModel).Cast<FishingHutModel>()", SO.Settings.Buildings.Where(a=>a is FishingHutModel).Cast<FishingHutModel>().ToArray(), a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("GathererHutTypes", "SO.Settings.Buildings.Where(a=>a is GathererHutModel).Cast<GathererHutModel>()", SO.Settings.Buildings.Where(a=>a is GathererHutModel).Cast<GathererHutModel>().ToArray(), a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("InstitutionTypes", "SO.Settings.Institutions", SO.Settings.Institutions, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("MineTypes", "SO.Settings.mines", SO.Settings.mines, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("RainCatcherTypes", "SO.Settings.Buildings.Where(a=>a is RainCatcherModel).Cast<RainCatcherModel>()", SO.Settings.Buildings.Where(a=>a is RainCatcherModel).Cast<RainCatcherModel>().ToArray(), a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingRainpunkModelTypes", "SO.Settings.Buildings.Where(a=> a is WorkshopModel w && w.rainpunk != null).Select(a=>((WorkshopModel)a).rainpunk)", SO.Settings.Buildings.Where(a=> a is WorkshopModel w && w.rainpunk != null).Select(a=>(a as WorkshopModel).rainpunk).Distinct(), a=>a.Name, RainpunkComment, ["Eremite.Buildings"]);
        
        CreateEnumTypesCSharpScript("BuildingCategoriesTypes", "SO.Settings.BuildingCategories", SO.Settings.BuildingCategories, a=>a.name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("BuildingTagTypes", "SO.Settings.buildingsTags", SO.Settings.buildingsTags, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("NeedTypes", "SO.Settings.Needs", SO.Settings.Needs, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("GoodsTypes", "SO.Settings.Goods", SO.Settings.Goods, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("GoodsCategoriesTypes", "SO.Settings.GoodsCategories", SO.Settings.GoodsCategories, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("ProfessionTypes", "SO.Settings.Professions", SO.Settings.Professions, a=>a.Name, ProfessionComment, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("RaceTypes", "SO.Settings.Races", SO.Settings.Races, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("TagTypes", "SO.Settings.tags", SO.Settings.tags, a=>a.Name, TagComment, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("TraderTypes", "SO.Settings.traders", SO.Settings.traders, a=>a.Name, NameDescriptionTags, ["Eremite.Model.Trade"]);

        CreateEnumTypesCSharpScript("DecorationTierTypes", "SO.Settings.decorationsTiers", SO.Settings.decorationsTiers, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"], GetPredefinedDecorationEnumNames);

        CreateEnumTypesCSharpScript("EffectTypes", "SO.Settings.effects", SO.Settings.effects, a=>a.Name, EffectComment, ["Eremite.Model"], groupEnumsBy:GroupByType);
        CreateEnumTypesCSharpScript("ResolveEffectTypes", "SO.Settings.resolveEffects", SO.Settings.resolveEffects, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("OrderTypes", "SO.Settings.orders", SO.Settings.orders, a=>a.Name, NameDescriptionTags, ["Eremite.Model.Orders"]);
        CreateEnumTypesCSharpScript("BiomeTypes", "SO.Settings.biomes", SO.Settings.biomes, a=>a.Name, NameDescriptionTags, ["Eremite.WorldMap"]);

        CreateEnumTypesCSharpScript("DifficultyTypes", "SO.Settings.difficulties", SO.Settings.difficulties, a=>a.Name, DifficultyComment, ["Eremite.Model"], noStartingNumbersEnum, orderBy: a=>a.index);
        CreateEnumTypesCSharpScript("GoalTypes", "SO.Settings.goals", SO.Settings.goals, a=>a.Name, NameDescriptionTags, ["Eremite.Model.Goals"]);
        CreateEnumTypesCSharpScript("RelicTypes", "SO.Settings.Relics", SO.Settings.Relics, a=>a.Name, NameDescriptionTags, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("MetaRewardTypes", "SO.Settings.metaRewards", SO.Settings.metaRewards, a=>a.Name, MetaRewardComment, ["Eremite.Model.Meta"]);
        CreateEnumTypesCSharpScript("OreTypes", "SO.Settings.Ore", SO.Settings.Ore, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("VillagerPerkTypes", "SO.Settings.villagersPerks", SO.Settings.villagersPerks, a=>a.Name, NameDescriptionTags, ["Eremite.Characters.Villagers"]);
        CreateEnumTypesCSharpScript("BuildingPerkTypes", "SO.Settings.buildingsPerks", SO.Settings.buildingsPerks, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("MetaCurrencyTypes", "SO.Settings.metaCurrencies", SO.Settings.metaCurrencies, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("AscensionModifierTypes", "SO.Settings.ascensionModifiers", SO.Settings.ascensionModifiers, a=>a.Name, (a)=>NameDescriptionTags(a.effect), ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("NaturalResourceTypes", "SO.Settings.NaturalResources", SO.Settings.NaturalResources, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("SimpleSeasonalEffectTypes", "SO.Settings.simpleSeasonalEffects", SO.Settings.simpleSeasonalEffects, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("ResourcesDepositsTypes", "SO.Settings.ResourcesDeposits", SO.Settings.ResourcesDeposits, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        CreateEnumTypesCSharpScript("WaterTypes", "SO.Settings.Waters", SO.Settings.Waters, a=>a.Name, NameDescriptionTags, ["Eremite.Model"]);
        
        CreateEnumTypesCSharpScript("RecipeTypes", "SO.Settings.recipes", SO.Settings.recipes, a=>a.Name, RecipeComments, ["Eremite.Buildings"], groupEnumsBy:GroupByType);
        CreateEnumTypesCSharpScript("WorkshopsRecipeTypes", "SO.Settings.workshopsRecipes", SO.Settings.workshopsRecipes, a=>a.Name, RecipeComments, ["Eremite.Buildings"]);
        CreateEnumTypesCSharpScript("InstitutionRecipeTypes", "SO.Settings.institutionRecipes", SO.Settings.institutionRecipes, a=>a.Name, RecipeComments, ["Eremite.Buildings"]);
    }

    private static Dictionary<string, string> TagComment(ModelTag arg)
    {
        Dictionary<string,string> nameAndDescription = NameDescriptionTags(arg);
        if (nameAndDescription == null)
        {
            return null;
        }

        return nameAndDescription;
    }

    private static Dictionary<string, string> ProfessionComment(ProfessionModel arg)
    {
        Dictionary<string,string> nameAndDescription = NameDescriptionTags(arg);
        if (nameAndDescription == null)
        {
            return null;
        }
        
        return nameAndDescription;
    }

    private static Dictionary<string, string> BuildingComment(BuildingModel arg)
    {
        Dictionary<string,string> nameAndDescription = NameDescriptionTags(arg);
        if (nameAndDescription == null)
        {
            return null;
        }

        if (arg.category != null)
        {
            nameAndDescription["category"] = arg.category.name;
        }

        return nameAndDescription;
    }

    private static Dictionary<string, string> RainpunkComment(BuildingRainpunkModel arg)
    {
        Dictionary<string,string> nameAndDescription = NameDescriptionTags(arg);
        if (nameAndDescription == null)
        {
            return null;
        }

        if (arg.water != null)
        {
            nameAndDescription["water"] = arg.water.name;
        }

        var buildings = SO.Settings.Buildings.Where(a => a is WorkshopModel w && w.rainpunk == arg).Select(a => a.name);
        if (buildings.Any())
        {
            var limitedBuildings = buildings.Take(5).ToList();
            nameAndDescription["buildings"] = string.Join(", ", limitedBuildings);
        }
        else
        {
            nameAndDescription["buildings"] = "No buildings using this rainpunk";
        }

        return nameAndDescription;
    }

    private static Dictionary<string, string> RecipeComments(RecipeModel arg)
    {
        Dictionary<string,string> nameAndDescription = NameDescriptionTags(arg);
        if (nameAndDescription == null)
        {
            return null;
        }
        
        Debug.Log("RecipeComments for " + arg.GetType().Name);
        
        if (arg.grade != null)
        {
            nameAndDescription["grade"] = arg.grade.level.ToString();
        }

        if (arg is WorkshopRecipeModel workshopsRecipeTypes)
        {
            if (workshopsRecipeTypes.producedGood != null && workshopsRecipeTypes.producedGood.good != null)
            {
                nameAndDescription["producedGood"] = workshopsRecipeTypes.producedGood.good.name;
            }
        }
        else if (arg is InstitutionRecipeModel institutionRecipeTypes)
        {
            if (institutionRecipeTypes.servedNeed != null)
            {
                nameAndDescription["servedNeed"] = institutionRecipeTypes.servedNeed.name;
            }
        }
        else if (arg is CollectorRecipeModel collectorRecipeTypes)
        {
            if (collectorRecipeTypes.producedGood != null && collectorRecipeTypes.producedGood.good != null)
            {
                nameAndDescription["producedGood"] = collectorRecipeTypes.producedGood.good.name;
            }
        }
        else if (arg is FarmRecipeModel farmRecipeTypes)
        {
            if (farmRecipeTypes.producedGood != null && farmRecipeTypes.producedGood.good != null)
            {
                nameAndDescription["producedGood"] = farmRecipeTypes.producedGood.good.name;
            }
        }
        else if (arg is FishingHutRecipeModel fishingHutRecipeTypes)
        {
            if (fishingHutRecipeTypes.refGood != null && fishingHutRecipeTypes.refGood.good != null)
            {
                nameAndDescription["producedGood"] = fishingHutRecipeTypes.refGood.good.name;
            }
        }
        else if (arg is GathererHutRecipeModel gathererHutRecipeTypes)
        {
            if (gathererHutRecipeTypes.refGood != null && gathererHutRecipeTypes.refGood.good != null)
            {
                nameAndDescription["producedGood"] = gathererHutRecipeTypes.refGood.good.name;
            }
        }
        else if (arg is RainCatcherRecipeModel rainCatcherRecipeTypes)
        {
            if (rainCatcherRecipeTypes.water != null && rainCatcherRecipeTypes.water.good != null)
            {
                nameAndDescription["producedGood"] = rainCatcherRecipeTypes.water.good.name;
            }
        }
        else if (arg is MineRecipeModel mineRecipeTypes)
        {
            if (mineRecipeTypes.producedGood != null && mineRecipeTypes.producedGood.good != null)
            {
                nameAndDescription["producedGood"] = mineRecipeTypes.producedGood.good.name;
            }
        }
        else if (arg is CampRecipeModel campRecipeTypes)
        {
            nameAndDescription["producedGood"] = campRecipeTypes.RefGood;
        }
        else
        {
            APILogger.LogError("Unhandled RecipeModel type: " + arg.GetType().Name);
        }
        
        return nameAndDescription;
    }

    private static string GetPredefinedDecorationEnumNames(string s)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary["DecorationTier 1"] = "Comfort";
        dictionary["DecorationTier 2"] = "Aesthetics";
        dictionary["DecorationTier 3"] = "Harmony";
        
        if (dictionary.TryGetValue(s, out string value))
        {
            return value;
        }
        return s.ToEnumString();
    }

    public static void CreateAllPrefabEnumTypes(string csExportPath)
    {
        exportCSScriptsPath = csExportPath;
        
        List<Eremite.MapObjects.NaturalResource> resources = SO.Settings.NaturalResources.Select(a=>a.prefabs).SelectMany(a=>a).Distinct().ToList();
        string resourceString = "SO.Settings.NaturalResources.Select(a=>a.prefabs).SelectMany(a=>a)";
        Func<Eremite.MapObjects.NaturalResource, Dictionary<string, string>> comment = a =>
        {
            var models = string.Join(", ", SO.Settings.NaturalResources.Where(m => m.prefabs.Contains(a)).Select(a=>a.displayName.GetText()));
            string summary = a.name + (string.IsNullOrEmpty(models) ? "" : " - " + models);
            Dictionary<string, string> comment = new();
            comment["summary"] = summary;
            TryAddName(a, comment);
            return comment;
        };
        CreateEnumTypesCSharpScript("NaturalResourcePrefabs", resourceString, resources, a=>a.name, comment, [], includeNamespaceInType:true);
    }

    private static string GroupByType(object arg)
    {
        return arg.GetType().Name;
    }

    private static Dictionary<string, string> NameDescriptionTags(object a)
    {
        if (a == null)
        {
            return null;
        }

        static void Log(object o, string s)
        {
            // if (o is GoodModel effectModel)
            // {
            //     Logger.LogInfo("WIKI: " + effectModel.name + " " + s);
            // }
        }
        
        static string GetFieldResults(object instance, string[] methods, string[] properties, string[] fields)
        {
            Type type = instance.GetType();
            object result = null;
            Log(instance, "Methods: " + string.Join(", ", methods));
            foreach (string name in methods)
            {
                Log(instance, "Checking method " + name);
                MethodInfo methodInfo = type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (methodInfo != null)
                {
                    Log(instance, "Method " + name + " found on type " + type.FullName);
                    try
                    {
                        result = methodInfo.Invoke(instance, null);
                        if (result != null)
                        {
                            Log(instance, "Method Result is not null!");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Log(instance, "Method " + name + " failed to get value\n" + e);
                    }

                    Log(instance, "Method Result IS null...");
                }
                else
                {
                    Log(instance, "Method " + name + " not found for type " + type.FullName);
                }
            }
            
            
            
            Log(instance, "Properties: " + string.Join(", ", properties));

            if (result == null)
            {
                List<PropertyInfo> propertiesInfos = Util.AllProperties(type, properties);
                foreach (string name in properties)
                {
                    Log(instance, "Checking property " + name);
                    PropertyInfo propertyInfo = propertiesInfos.FirstOrDefault(a => a.Name == name);
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
                            Log(instance, "Field " + name + " failed to get value " + e);
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
        string displayName = GetFieldResults(a, [], ["DisplayName"], ["displayName"]);
        if(displayName == ">Missing key<")
        {
            Log(a, "DisplayName is missing key");
            displayName = "";
        }


        // Description
        string description = GetFieldResults(a, [], ["FormatedDescription", "Description"], ["description"]);
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
        
        Dictionary<string, string> dictionary = new();
        dictionary["summary"] = result;
        TryAddName(a, dictionary);
        
        string tags = GetFieldResults(a, [], [], ["tags", "tag", "usabilityTags"]);
        if(!string.IsNullOrEmpty(tags))
        {
            dictionary["tags"] = tags;
        }
        
        
        return dictionary;
    }
    
    private static void TryAddName(object o, Dictionary<string, string> dictionary)
    {
        if (o is UnityEngine.Object model)
        {
            dictionary["name"] = model.name;
        }
    }

    private static Dictionary<string, string> DifficultyComment(DifficultyModel a)
    {
        string summary = "";
        if (a.displayName != null)
        {
            summary = a.displayName.GetText();
        }

        if (a.isAscension)
        {
            summary += " " + (a.ascensionIndex + 1);
        }
        
        
        if (a.modifiers.NullOrEmpty())
            summary += " - " + a.GetText("WorldUI_FieldPanel_Difficulty_NoModifiers");
        else
            summary += " - " + a.modifiers.Last().shortDesc.Text;

        Dictionary<string, string> dictionary = new();
        dictionary["summary"] = summary;
        TryAddName(a, dictionary);
        return dictionary;
    }

    private static Dictionary<string, string> MetaRewardComment(MetaRewardModel a)
    {
        string aDisplayName = "";
        try
        {
            aDisplayName = a.DisplayName;
        }
        catch (Exception)
        {
        }
        
        string summary = a.GetType().Name + (string.IsNullOrEmpty(aDisplayName) ? "" : "-" + aDisplayName);
        Dictionary<string, string> dictionary = new();
        dictionary["summary"] = summary;
        TryAddName(a, dictionary);
        return dictionary;
    }

    private static Dictionary<string, string> EffectComment(EffectModel arg)
    {
        Dictionary<string, string> dictionary = NameDescriptionTags(arg);
        dictionary["type"] = arg.GetType().Name;
        
        if (arg is HookedEffectModel hookedEffectModel)
        {
            if (hookedEffectModel.hooks != null)
            {
                for (var i = 0; i < hookedEffectModel.hooks.Length; i++)
                {
                    HookLogic hook = hookedEffectModel.hooks[i];
                    dictionary["hooks_" + (i+1)] = GetHookComment(hook);
                }
            }
            
            if (hookedEffectModel.instantEffects != null)
            {
                for (var i = 0; i < hookedEffectModel.instantEffects.Length; i++)
                {
                    EffectModel instantEffect = hookedEffectModel.instantEffects[i];
                    dictionary["instantEffect_" + (i+1)] = instantEffect.name + " (" + instantEffect.GetType().Name + ")";
                }
            }

            if (hookedEffectModel.hookedEffects != null)
            {
                for (var i = 0; i < hookedEffectModel.hookedEffects.Length; i++)
                {
                    EffectModel hookedEffect = hookedEffectModel.hookedEffects[i];
                    dictionary["hookedEffect_" + (i+1)] = hookedEffect.name + " (" + hookedEffect.GetType().Name + ")";
                }
            }

            if (hookedEffectModel.removalHooks != null)
            {
                for (var i = 0; i < hookedEffectModel.removalHooks.Length; i++)
                {
                    HookLogic removalHook = hookedEffectModel.removalHooks[i];
                    dictionary["removalHook_" + (i+1)] = GetHookComment(removalHook);
                }
            }
        }
        
        return dictionary;
    }
    
    private static string GetHookComment(HookLogic hook)
    {
        string description = hook.DescriptionPreview;
        if (string.IsNullOrEmpty(description))
        {
            return "(" + hook.GetType().Name + ")";
        }
        
        return description + " (" + hook.GetType().Name + ")";
    }
}