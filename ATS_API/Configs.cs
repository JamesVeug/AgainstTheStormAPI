using System;
using ATS_API;
using BepInEx.Configuration;

namespace ATS_API;

internal static class Configs
{
    public static bool ExportEnumTypes
    {
        get => m_ExportEnumTypes.Value;
        set
        {
            m_ExportEnumTypes.Value = value;
            Plugin.Instance.Config.Save();
        }
    }
    
    public static string ExportEnumsPath
    {
        get => m_ExportEnumsPath.Value;
        set
        {
            m_ExportEnumsPath.Value = value;
            Plugin.Instance.Config.Save();
        }
    }
    
    public static bool ExportCSVs
    {
        get => m_ExportCSVs.Value;
        set
        {
            m_ExportCSVs.Value = value;
            Plugin.Instance.Config.Save();
        }
    }
    
    public static string ExportCSVPath
    {
        get => m_ExportCSVsPath.Value;
        set
        {
            m_ExportCSVsPath.Value = value;
            Plugin.Instance.Config.Save();
        }
    }

    private static ConfigEntry<bool> m_ExportEnumTypes = Bind("Exporting", "Export Enum classes", false, "When set to true and the Export Enums path is set, the plugin will export all types of data as .cs files for the API to use or anyone to browse.");
    private static ConfigEntry<string> m_ExportEnumsPath = Bind("Exporting", "Export Enum class path", "", "When set to true this is the path the enums will export to");

    private static ConfigEntry<bool> m_ExportCSVs = Bind("Exporting", "Export CSVs", false, "When set to true and the Export CSVs path is set, the plugin will export all types of data as .csv files for anyone to browse.");
    private static ConfigEntry<string> m_ExportCSVsPath = Bind("Exporting", "Export CSVs path", "", "When set to true");

    private static ConfigEntry<T> Bind<T>(string section, string key, T defaultValue, string description)
	{
		return Plugin.Instance.Config.Bind(section, key, defaultValue, new ConfigDescription(description, null, Array.Empty<object>()));
	}
}