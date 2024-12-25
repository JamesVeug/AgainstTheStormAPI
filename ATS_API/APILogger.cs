using System;
using System.Diagnostics;
using BepInEx.Logging;

namespace ATS_API;

/// <summary>
/// Custom logger to help provide more options figuring out why things do what they do
/// Technically you can already do this with BepInEx by chaning what logs to console. But I find that tedious.
/// If you want to use this in your mod then copy+paste this file into your mod and set logger on awake.
///
/// LogDebug can be used everywhere since its unlikely people will have their log level set to Debug.
/// </summary>
internal static class APILogger
{
    internal static ManualLogSource logger;
    
    public static APILogLevel LogLevel => Configs.APILogLevel;

    /// <summary>
    /// Level at which we will log info to the console
    /// Errors - Only log errors
    /// Warning - Log errors and warnings
    /// Info - Log errors, warnings and info
    /// Debug - Log everything
    /// </summary>
    public enum APILogLevel
    {
        Errors,
        Warning,
        Info,
        Debug,
    }
    
    public static void LogDebug(string message)
    {
        if (LogLevel >= APILogLevel.Debug)
        {
            logger.LogInfo(message);
        }
    }
    
    public static void LogDebug(string message, params object[] args)
    {
        if (LogLevel >= APILogLevel.Debug)
        {
            logger.LogInfo(string.Format(message, args));
        }
    }
    
    public static void LogInfo(string message)
    {
        if (LogLevel >= APILogLevel.Info)
        {
            logger.LogInfo(message);
        }
    }
    
    public static void LogInfo(string message, params object[] args)
    {
        if (LogLevel >= APILogLevel.Info)
        {
            logger.LogInfo(string.Format(message, args));
        }
    }
    
    public static void LogWarning(string message)
    {
        if (LogLevel >= APILogLevel.Warning)
        {
            logger.LogWarning(message);
        }
    }
    
    public static void LogWarning(string message, params object[] args)
    {
        if (LogLevel >= APILogLevel.Warning)
        {
            logger.LogWarning(string.Format(message, args));
        }
    }
    
    public static void LogError(string message)
    {
        logger.LogError(message + "\n" + GetStaceTraceIgnoreLogger());
    }

    public static void LogError(string message, params object[] args)
    {
        logger.LogError(string.Format(message, args) + "\n" + GetStaceTraceIgnoreLogger());
    }
    
    public static void LogError(Exception exception)
    {
        logger.LogError(exception + "\n" + GetStaceTraceIgnoreLogger());
    }
    
    public static void LogException(Exception exception)
    {
        logger.LogError(exception + "\n" + GetStaceTraceIgnoreLogger());
    }
    
    public static void Assert(bool condition, string message)
    {
        if (!condition)
        {
            logger.LogError("Assertion failed: " + message);
        }
    }
    
    public static void Assert(bool condition, string message, params object[] args)
    {
        if (!condition)
        {
            logger.LogError("Assertion failed: " + string.Format(message, args));
        }
    }

    public static void IsTrue(bool condition, string message)
    {
        Assert(condition, message);
    }

    public static void IsEqual<T>(T expected, T actual, string message)
    {
        string log = $"{expected} != {actual}, {message}";
        if((expected == null) != (actual == null))
        {
            logger.LogError(log);
            return;
        }
        
        Assert(expected.Equals(actual), log);
    }

    public static void IsNotEqual<T>(T expected, T actual, string message)
    {
        string log = $"{expected} == {actual}, {message}";
        if (expected == null)
        {
            if (actual == null)
            {
                logger.LogError(log);
            }
            return;
        }
        else if (actual == null)
        {
            // Not equal
            return;
        }
        
        Assert(expected.Equals(actual), log);
    }

    private static StackTrace GetStaceTraceIgnoreLogger()
    {
        // Get Stacktrace and skip this class from showing in the logs
        // https://stackoverflow.com/a/76528835/3555142
        return new StackTrace(1);
    }
}
