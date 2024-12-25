
namespace ATS_API.Localization;

public static class Keys
{
    // Common Against the storm keys
    public static readonly string SaveAndQuit_Key = "GameUI_GameMenu_Quit"; // Save & Quit
    public static readonly string Quit_Key = "MenuUI_Quit"; // Quit
    public static readonly string Continue_Key = "GameUI_GameMenu_Continue"; // Continue
    public static readonly string Ignore_Key = "WorldEvent_Ignore_Desc"; // Ignore
    public static readonly string OK_Key = "Common_Ok"; // OK
    public static readonly string Cancel_Key = "Common_Cancel"; // Cancel
    public static readonly string Close_Key = "Common_Close"; // Close
    public static readonly string Yes_Key = "Common_Close"; // Yes
    
    // Other Against the storm keys
    public static readonly string BiomeEffect = "Label_BiomeEffect"; // Biome Effect
    public static readonly string Decoration = "Label_BuildingDisplayLabel_Decoration"; // Decoration
    public static readonly string House = "Label_BuildingDisplayLabel_House"; // House
    public static readonly string ProductionBuilding = "Label_BuildingDisplayLabel_ProductionBuilding"; // Production Building
    public static readonly string WorldMapModifier = "Label_MapModifier"; // World Map Modifier
    public static readonly string Perk = "Label_Reward_Perk"; // Perk
    
    // API constants
    public static readonly string GUID = "API_GUID"; // GUID
    public static readonly string Dependencies = "API_Dependencies"; // Dependencies
    public static readonly string WrongVersion = "API_WrongVersion"; // WrongVersion
    public static readonly string Missing = "API_Missing"; // Missing
    public static readonly string None = "API_None"; // None
    
    
    // API defined keys
    public static readonly string GenericPopup_Header_Key = "API_GenericPopup_Header"; // Something went wrong!
    public static readonly string GenericPopup_Description_Key = "API_GenericPopup_Description"; // Check logs for more information
    public static readonly string GenericPopup_ExceptionDescription_Key = "API_GenericPopup_ExceptionDescription"; // {0}\n\nAn exception occurred:\n{1}
    public static readonly string GenericPopup_ContinueAtRisk_Key = "API_GenericPopup_ContinueAtRisk"; // Continue the game where some content may not work.
    public static readonly string GenericPopup_QuitGameAndDisableMod_Key = "API_GenericPopup_QuitGameAndDisableMod"; // Close the game and disable the affected mod.
    public static readonly string GenericPopup_YouHaveXOptions_Key = "API_GenericPopup_YouHaveXOptions"; // You have {0} options
    
    public static readonly string OptionsUI_ModsTab_Text_Key = "API_OptionsUI_ModsTab_Text"; // Mods
}