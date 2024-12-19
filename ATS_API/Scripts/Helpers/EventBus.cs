using System;

namespace ATS_API.Helpers;

public static class EventBus
{
    /// <summary>
    /// Invoked when Against the Storm starts and all the data has been initialized.
    /// </summary>
    public static readonly SafeAction OnInitReferences = new SafeAction();
    
    /// <summary>
    /// Invoked when the player enters a settlement.
    /// </summary>
    /// <Arg1>True if the player just started a new game</Arg1>
    public static readonly SafeAction<bool> OnStartGame = new SafeAction<bool>();

    /// <summary>
    /// Invoked when the cycle in the world map is ended.
    /// </summary>
    public static readonly SafeAction OnCycleEnded = new SafeAction();
}
