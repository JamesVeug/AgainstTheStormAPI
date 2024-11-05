
namespace ATS_API.Localization;

public static class APIKeys
{
    // Common Against the storm keys
    public static readonly string SaveAndQuit_Key = "GameUI_GameMenu_Quit"; // Save & Quit
    public static readonly string Quit_Key = "MenuUI_Quit"; // Quit
    public static readonly string Continue_Key = "GameUI_GameMenu_Continue"; // Continue
    public static readonly string Ignore_Key = "WorldEvent_Ignore_Desc"; // Ignore
    
    // API defined keys
    public static readonly string GenericPopup_Header_Key = "API_GenericPopup_Header"; // Something went wrong!
    public static readonly string GenericPopup_Description_Key = "API_GenericPopup_Description"; // Check logs for more information
    public static readonly string GenericPopup_ExceptionDescription_Key = "API_GenericPopup_ExceptionDescription"; // {0}\n\nAn exception occurred:\n{1}
    public static readonly string GenericPopup_ContinueAtRisk_Key = "API_GenericPopup_ContinueAtRisk"; // Continue the game where some content may not work.
    public static readonly string GenericPopup_QuitGameAndDisableMod_Key = "API_GenericPopup_QuitGameAndDisableMod"; // Close the game and disable the affected mod.
    public static readonly string GenericPopup_YouHaveXOptions_Key = "API_GenericPopup_YouHaveXOptions"; // You have {0} options
}