using System;

namespace ATS_API.Helpers;

[Obsolete("Copy APILogger into your own mod. Provides MANY more helper methods like this.\nhttps://github.com/JamesVeug/AgainstTheStormAPI/blob/master/ATS_API/APILogger.cs")]
public static class Assert
{
    public static void IsTrue(bool condition, string message)
    {
        if (!condition)
        {
            APILogger.LogError(message);
        }
    }
    
    public static void IsEqual<T>(T expected, T actual, string message)
    {
        if (!expected.Equals(actual))
        {
            APILogger.LogError($"{expected} != {actual}, {message}");
        }
    }
}