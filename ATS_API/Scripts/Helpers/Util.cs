using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
    
    public static List<FieldInfo> AllFields(Type type, string[] fieldNames)
    {
        List<FieldInfo> fields = new();
        FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        fields.AddRange(fieldInfos.Where(a=>Array.IndexOf(fieldNames, a.Name) >= 0 && !fields.Exists(b=>b.Name == a.Name)));
        if(type.BaseType != null && fields.Count < fieldNames.Length)
        {
            fields.AddRange(AllFields(type.BaseType, fieldNames));
        }
        return fields;
    }
    
    
    public static List<PropertyInfo> AllProperties(Type type, string[] propertyNames)
    {
        List<PropertyInfo> properties = new();
        PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);
        properties.AddRange(propertyInfos.Where(a=>Array.IndexOf(propertyNames, a.Name) >= 0 && !properties.Exists(b=>b.Name == a.Name)));
        if(type.BaseType != null && properties.Count < propertyNames.Length)
        {
            properties.AddRange(AllProperties(type.BaseType, propertyNames));
        }
        return properties;
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