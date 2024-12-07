using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API.Helpers;

public static class AssetBundleHelper
{
    public static AssetBundle LoadAssetBundle(string filename, Assembly target)
    {
        string lowerKey = $".{filename.ToLowerInvariant()}";
        string resourceName = target.GetManifestResourceNames().FirstOrDefault(r => r.ToLowerInvariant().EndsWith(lowerKey));

        if (string.IsNullOrEmpty(resourceName))
        {
            string allResources = string.Join(", ", target.GetManifestResourceNames());
            throw new KeyNotFoundException($"Could not find resource matching {filename} in assembly {target}. Resources: {allResources}");
        }

        using (Stream resourceStream = target.GetManifestResourceStream(resourceName))
        {
            using (MemoryStream memStream = new())
            {
                resourceStream.CopyTo(memStream);
                byte[] array = memStream.ToArray();
                
                AssetBundle bundle = AssetBundle.LoadFromMemory(array);
                if (bundle == null)
                {
                    Plugin.Log.LogError($"Tried getting asset bundle from bytes but failed! Is the path wrong?");
                    return null;
                }
                
                return bundle;
            }
        }
    }
    
    public static bool TryLoadAssetBundleFromFile(string pathToAssetBundle, out AssetBundle AssetBundle)
    {
        string fullPath = pathToAssetBundle;
        if (!Path.IsPathRooted(pathToAssetBundle))
        {
            var files = Directory.GetFiles(Paths.PluginPath, pathToAssetBundle, SearchOption.AllDirectories);
            if (files.Length < 1)
                throw new FileNotFoundException($"Could not find relative artwork file!\nFile name: {pathToAssetBundle}\n" + Environment.StackTrace, pathToAssetBundle);

            fullPath = files[0];
        }

        if (!File.Exists(fullPath))
            throw new FileNotFoundException($"Absolute path to artwork file does not exist!\nFile name: {pathToAssetBundle}\n" + Environment.StackTrace, fullPath);
        
        AssetBundle = AssetBundle.LoadFromFile(fullPath);
        if (AssetBundle == null)
        {
            Plugin.Log.LogError($"Tried getting asset bundle at path: '{fullPath}' but failed! Is the path wrong?\n" + Environment.StackTrace);
            return false;
        }

        return true;
    }
    
    public static bool TryGet<T>(AssetBundle bundle, string prefabName, out T prefab) where T : Object
    {
        if (bundle == null)
        {
            Plugin.Log.LogError($"Tried getting prefab from {prefabName} but the assetbundle is null!\n" + Environment.StackTrace);
            prefab = default(T);
            return false;
        }

        // Get object from bundle
        prefab = bundle.LoadAsset<T>(prefabName);

        // Unload bundle but don't unload the assets
        // bundle.Unload(false);

        if (prefab == null)
        {
            Plugin.Log.LogError($"Tried getting prefab '{prefabName}' from asset bundle but failed! Is the prefab name or type wrong?\n" + Environment.StackTrace);
            return false;
        }

        return true;
    }

    public static bool TryGet<T>(string pathToAssetBundle, string prefabName, out T prefab) where T : Object
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(pathToAssetBundle);
        if (bundle == null)
        {
            Plugin.Log.LogError($"Tried getting asset bundle at path: '{pathToAssetBundle}' but failed! Is the path wrong?\n" + Environment.StackTrace);
            prefab = default(T);
            return false;
        }

        // Get object from bundle
        prefab = bundle.LoadAsset<T>(prefabName);

        // Unload bundle but don't unload the assets
        // bundle.Unload(false);

        if (prefab == null)
        {
            Plugin.Log.LogError($"Tried getting prefab '{prefabName}' from asset bundle at path: '{pathToAssetBundle}' but failed! Is the prefab name or type wrong?\n" + Environment.StackTrace);
            return false;
        }

        return true;
    }

    public static bool TryGet<T>(byte[] resources, string prefabName, out T prefab) where T : Object
    {
        AssetBundle bundle = AssetBundle.LoadFromMemory(resources);
        if (bundle == null)
        {
            Plugin.Log.LogError($"Tried getting asset bundle from bytes but failed! Is the path wrong?\n" + Environment.StackTrace);
            prefab = default(T);
            return false;
        }

        // Get object from bundle
        prefab = bundle.LoadAsset<T>(prefabName);

        // Unload bundle but don't unload the assets
        // bundle.Unload(false);

        if (prefab == null)
        {
            Plugin.Log.LogError($"Tried getting prefab '{prefabName}' from asset bundle from bytes' but failed! Is the prefab name or type wrong?\n" + Environment.StackTrace);
            return false;
        }

        return true;
    }
}
