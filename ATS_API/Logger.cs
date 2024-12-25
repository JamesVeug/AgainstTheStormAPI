using System;
using BepInEx.Logging;

public class Logger
{
    private static ManualLogSource logger;

    public Logger(ManualLogSource logger)
    {
        Logger.logger = logger;
    }
    
    public static void LogInfo(string message)
    {
        logger.LogInfo(message);
    }
    
    public static void LogWarning(string message)
    {
        logger.LogWarning(message);
    }
    
    public static void LogError(string message)
    {
        logger.LogError(message + "\n" + Environment.StackTrace);
    }
    
    public static void Assert(bool condition, string message)
    {
        if (!condition)
        {
            logger.LogError("Assertion failed: " + message);
        }
    }
}