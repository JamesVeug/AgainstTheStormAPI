using System.Collections.Generic;

namespace ATS_API.Helpers;

public static class ListExtensions
{
    public static bool NullOrEmpty<T>(this List<T> list)
    {
        return list == null || list.Count == 0;
    }
    
    public static List<T> Copy<T>(this List<T> list)
    {
        return new List<T>(list);
    }
}