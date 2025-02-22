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
    
    public static string GetHierarchyPath(Transform t)
    {
        string hierarchyPath = t.name;
        while (t.parent != null)
        {
            t = t.parent;
            hierarchyPath = t.name + "/" + hierarchyPath;
        }

        return t.gameObject.scene.name + ":" + hierarchyPath;
    }
    
    public static T SafeGetComponent<T>(this GameObject go) where T : Component
    {
        if(go.TryGetComponent(out T component))
        {
            return component;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in {go.FullName()}!");
        return component;
    }
    
    public static T SafeGetComponent<T>(this Component go) where T : Component
    {
        if(go.TryGetComponent(out T component))
        {
            return component;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in {go.FullName()}!");
        return component;
    }
    
    public static T SafeGetComponentInChildren<T>(this Component go) where T : Component
    {
        T componentInChildren = go.GetComponentInChildren<T>();
        if(componentInChildren != null)
        {
            return componentInChildren;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in children of {go.FullName()}!");
        return componentInChildren;
    }
    
    public static T SafeGetComponentInChildren<T>(this Component go, bool includeInactive) where T : Component
    {
        T componentInChildren = go.GetComponentInChildren<T>(includeInactive);
        if(componentInChildren != null)
        {
            return componentInChildren;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in children of {go.FullName()}!");
        return componentInChildren;
    }
    
    public static T[] SafeGetComponentsInChildren<T>(this Component go, bool includeInactive=false) where T : Component
    {
        T[] componentInChildren = go.GetComponentsInChildren<T>(includeInactive);
        if(componentInChildren != null)
        {
            return componentInChildren;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in children of {go.FullName()}!");
        return null;
    }
    
    public static T SafeGetComponentInChildren<T>(this GameObject go, bool includeInactive=false) where T : Component
    {
        T componentInChildren = go.GetComponentInChildren<T>(includeInactive);
        if(componentInChildren != null)
        {
            return componentInChildren;
        }
        
        APILogger.LogError($"Could not find {typeof(T).FullName} component in children of {go.FullName()}!");
        return componentInChildren;
    }
    
    public static T FindChild<T>(this GameObject t, string name, bool errorIfNotFound=true) where T : Component
    {
        Transform found = t.transform.Find(name);
        if (found != null)
        {
            return SafeGetComponent<T>(found);
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    public static T FindChild<T>(this Component t, string name, bool errorIfNotFound=true) where T : Component
    {
        Transform found = t.transform.Find(name);
        if (found != null)
        {
            return SafeGetComponent<T>(found);
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    public static GameObject FindChild(this GameObject t, string name, bool errorIfNotFound=true)
    {
        Transform found = t.transform.Find(name);
        if (found != null)
        {
            return found.gameObject;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    public static GameObject FindChild(this Component t, string name, bool errorIfNotFound=true)
    {
        Transform found = t.transform.Find(name);
        if (found != null)
        {
            return found.gameObject;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    public static Transform FindChild(this Transform t, string name, bool errorIfNotFound=true)
    {
        Transform found = t.Find(name);
        if (found != null)
        {
            return found;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    
    public static Transform FindChildRecursive(this Transform t, string name, bool errorIfNotFound=true)
    {
        Transform found = FindRecursiveInternal(t, name);
        if (found != null)
        {
            return found;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} in {t.FullName()}!");
        }

        return null;
    }
    
    public static bool TryFindChildRecursive<T>(this Component t, string name, out T found, bool errorIfNotFound=true) where T : Component
    {
        found = default;
        
        Transform transform = FindRecursiveInternal(t.transform, name);
        if (transform != null)
        {
            if (transform.TryGetComponent(out T component))
            {
                found = component;
                return true;
            }
            
            if (errorIfNotFound)
            {
                APILogger.LogError($"Found child {name} but it does not have a {typeof(T).FullName} component!");
            }
            return false;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find child {name} in {t.FullName()} with component {typeof(T).FullName}!");
        }

        return false;
    }
    
    public static bool TryFindChild(this Component t, string name, out GameObject found, bool errorIfNotFound=true)
    {
        found = default;
        
        Transform transform = FindRecursiveInternal(t.transform, name);
        if (transform != null)
        {
            found = transform.gameObject;
            return true;
        }

        if (errorIfNotFound)
        {
            APILogger.LogError($"Could not find {name} gameobject in {t.FullName()}!");
        }

        return false;
    }
    
    private static Transform FindRecursiveInternal(this Transform t, string name)
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
            Transform found = FindRecursiveInternal(child, name);
            if (found != null)
            {
                return found;
            }
        }

        return null;
    }
    
    public static Transform FindChild(this Transform t, string name, string secondName)
    {
        Transform find = FindChildRecursive(t, name);
        if (find == null)
        {
            return null;
        }
        
        return find.Find(secondName);
    }
    
    public static T GetOrAdd<T>(this Transform go) where T : Component
    {
        T component = go.GetComponent<T>();
        if (component == null)
        {
            component = go.gameObject.AddComponent<T>();
        }

        return component;
    }
    
    public static T GetOrAdd<T>(this GameObject go) where T : Component
    {
        T component = go.GetComponent<T>();
        if (component == null)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }
    
    public static string FullName(this UnityEngine.Object obj)
    {
        if (obj == null)
        {
            return "null";
        }
        
        string hierarchyPath = "";

        GameObject go = null;
        if (obj is GameObject)
        {
            go = obj as GameObject;
            
            hierarchyPath = GetHierarchyPath(go.transform);
        }
        else if(obj is Component component)
        {
            go = component.gameObject;
            hierarchyPath = GetHierarchyPath(go.transform);
            hierarchyPath += $" {obj.GetType().FullName}";
        }
        else
        {
            hierarchyPath = $"{obj.GetType().FullName}";
        }
        
        return hierarchyPath;
    }
    
    public static void CompareUnityVersions(string major, string minor, string patch)
    {
        string expectedVersion = string.Format("{0}.{1}.{2}", major, minor, patch);
        string currentVersion = Application.unityVersion;
        if (currentVersion == expectedVersion)
        {
            APILogger.LogInfo($"Unity Version is {currentVersion}");
            return;
        }
        
        string[] split = currentVersion.Split('.');
        string currentMajor = split[0];
        string currentMinor = split[1];
        string currentPatch = split[2];
        if (currentMajor != major)
        {
            APILogger.LogError($"The major Unity version has changed from {expectedVersion} to {currentVersion}! This will likely have code breaking changes and also require rebuilding asset bundles with the new unity version.");
        }
        else if (currentMinor != minor)
        {
            APILogger.LogError($"The minor Unity version has changed from {expectedVersion} to {currentVersion}! This will likely have code breaking changes and also require rebuilding asset bundles with the new unity version.");
        }
        else if (currentPatch != patch)
        {
            APILogger.LogWarning($"The patch Unity version has changed from {expectedVersion} to {currentVersion}! This may have code breaking changes!");
        }
        else
        {
            APILogger.LogError($"The Unity Version has changed from {expectedVersion} to {currentVersion}!");
        }
    }
}
