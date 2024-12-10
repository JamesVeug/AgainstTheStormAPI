using System;

namespace ATS_API.Helpers;

public static class EventBus
{
    public static event Action OnInitReferences;
    public static event Action<bool> OnStartGame;
    
    internal static void InvokeInitReferences()
    {
        if (OnInitReferences != null)
        {
            OnInitReferences?.Invoke();
        }
    }
    
    internal static void InvokeStartGame(bool isNewGame)
    {
        if (OnStartGame != null)
        {
            OnStartGame?.Invoke(isNewGame);
        }
    }
}