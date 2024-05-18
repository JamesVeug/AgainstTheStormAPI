using System;
using System.Collections.Generic;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

public enum TagTypes
{
    Unknown = -1,
    None,
    Beaver,
    Fabric,
    Fuel,
    Food,
}

public static class TagTypesExtensions
{
    public static ModelTag[] ToTagArray(this List<TagTypes> tags)
    {
        ModelTag[] tagArray = new ModelTag[tags.Count];
        for (int i = 0; i < tags.Count; i++)
        {
            string tagName = tags[i].ToName();
            tagArray[i] = SO.Settings.GetTag(tagName);
        }

        return tagArray;
    }
    public static string ToName(this TagTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of BuildingBehaviour Eremite type: " + type);
        return "Fabric Tag";
    }

    internal static readonly Dictionary<TagTypes, string> TypeToInternalName = new()
        {
            { TagTypes.Beaver, "[Tag] Beaver" },
            { TagTypes.Fabric, "Fabric Tag" },
            { TagTypes.Fuel, "Fuel Tag" },
            { TagTypes.Food, "Food Tag" },
        };
}