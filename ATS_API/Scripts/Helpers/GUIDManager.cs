﻿namespace ATS_API.Helpers;

public static class GUIDManager
{
    private static readonly int hashCode = -185329884; // Empty String: ""

    /// <summary>
    /// NOTE: This is experimental. We want a unique enum to assign for some data types and want to avoid the data clashing or mixing when multiple mods are added during gameplay.
    /// This makes a new enum value that custom data types can use with a hopefully minimal chance of clashing with other mods.
    ///
    /// TODO: Save into the current save file if a game is running to avoid it changing when someone changes the name of data. 
    /// </summary>
    public static T Get<T>(string guid, string name)
    {
        int guidHash = string.IsNullOrEmpty(guid) ? hashCode : guid.GetHashCode();
        int nameHash = string.IsNullOrEmpty(name) ? hashCode : name.GetHashCode();
    
        // XOR the two hashes. This is a simple way to combine them that 
        // should reduce the likelihood of collisions.
        int hash = (guidHash ^ nameHash) + 10_000; // min 10,000 to avoid clashing with existing values

        return (T)(object)hash;
    }
}