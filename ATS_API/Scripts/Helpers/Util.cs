using System.IO;
using System.Linq;
using System.Reflection;
using ATS_API;
using UnityEngine;

namespace ATS_API.Helpers;

public static class Util
{
    public static string ReadEmbeddedResource(Assembly assembly, string name)
    {
        // Determine path
        string resourcePath = assembly.GetManifestResourceNames()
            .Single(str => str.EndsWith(name));

        using Stream stream = assembly.GetManifestResourceStream(resourcePath)!;
        using StreamReader reader = new(stream);
        return reader.ReadToEnd();
    }
    
    
    
    public static Transform Find(Transform t, string name, bool errorIfNotFound=true)
    {
        Transform found = FindInternal(t, name);
        if (found != null)
        {
            return found;
        }

        Plugin.Log.LogError($"Could not find {name} in {t.name}!");
        return null;
    }
    
    private static Transform FindInternal(Transform t, string name)
    {
        foreach (Transform child in t)
        {
            if(child.name == name)
            {
                return child;
            }
        }
        
        foreach (Transform child in t)
        {
            Transform found = FindInternal(child, name);
            if (found != null)
            {
                return found;
            }
        }

        return null;
    }
    
    public static Transform Find(Transform t, string name, string secondName)
    {
        Transform find = Find(t, name);
        if (find == null)
        {
            return null;
        }
        
        return find.Find(secondName);
    }
}