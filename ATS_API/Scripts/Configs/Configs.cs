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
    
    public static bool ExportCSVs
    {
        get => m_ExportCSVs.Value;
        set
        {
            m_ExportCSVs.Value = value;
            Plugin.Instance.Config.Save();
        }
    }

    private static ConfigEntry<bool> m_ExportEnumTypes = Bind("Exporting", "Export Enum classes", false, 
        "When set to true the API will export all types of data as .cs files when the game opens for the API to use in the project.\n" +
        "The files will be exported to 'BepInEx/plugins/ATS_API_Devs-API/Exports'");

    private static ConfigEntry<bool> m_ExportCSVs = Bind("Exporting", "Export CSVs", false,
        "When set to true the API will export various kinds of data when the game opens as .csv files for anyone to browse.\n" +
        "The files will be exported to 'BepInEx/plugins/ATS_API_Devs-API/Exports'");
    
    private static ConfigEntry<T> Bind<T>(string section, string key, T defaultValue, string description)
	{
		return Plugin.Instance.Config.Bind(section, key, defaultValue, new ConfigDescription(description, null, Array.Empty<object>()));
	}
}