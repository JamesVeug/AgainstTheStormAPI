namespace ATS_API.Helpers;

public static class Assert
{
    public static void IsTrue(bool condition, string message)
    {
        if (!condition)
        {
            Plugin.Log.LogError(message);
        }
    }
    
    public static void IsEqual<T>(T expected, T actual, string message)
    {
        if (!expected.Equals(actual))
        {
            Plugin.Log.LogError($"{expected} != {actual}, {message}");
        }
    }
}