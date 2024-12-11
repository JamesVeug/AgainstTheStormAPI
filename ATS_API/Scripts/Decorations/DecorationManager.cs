using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Decorations;

public static class DecorationManager
{
    public static IReadOnlyList<NewDecorationTier> NewDecorationTiers => s_NewDecorationTiers;
    public static IReadOnlyDictionary<DecorationTierTypes, NewDecorationTier> NewDecorationTiersLookup => s_NewDecorationTiersLookup;
    
    private static List<NewDecorationTier> s_NewDecorationTiers = new List<NewDecorationTier>();
    private static Dictionary<DecorationTierTypes, NewDecorationTier> s_NewDecorationTiersLookup = new Dictionary<DecorationTierTypes, NewDecorationTier>();
    
    private static ArraySync<DecorationTier, NewDecorationTier> s_tiers = new("New Decoration Tier");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewDecorationTier NewDecorationTier(string guid, string name)
    {
        DecorationTier DecorationTier = ScriptableObject.CreateInstance<DecorationTier>();

        NewDecorationTier good = AddDecorationTier(guid, name, DecorationTier);
        return good;
    }

    public static NewDecorationTier AddDecorationTier(string guid, string name, DecorationTier decorationTier)
    {
        decorationTier.name = guid + "_" + name;
        
        DecorationTierTypes id = GUIDManager.Get<DecorationTierTypes>(guid, name);
        DecorationTierTypesExtensions.TypeToInternalName[id] = decorationTier.name;
        NewDecorationTier NewDecorationTier = new NewDecorationTier
        {
            Model = decorationTier,
            ID = id,
            Guid = guid,
            RawName = name
        };
        s_NewDecorationTiers.Add(NewDecorationTier);
        s_NewDecorationTiersLookup.Add(id, NewDecorationTier);
        s_dirty = true;

        return NewDecorationTier;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        Sync();
    }
    
    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            Sync();
        }
    }

    private static void Sync()
    {
        if (!s_instantiated)
        {
            return;
        }

        Plugin.Log.LogInfo("DecorationManager.Sync: " + s_NewDecorationTiers.Count + " new decorationTiers");
        
        Settings settings = SO.Settings;
        s_tiers.Sync(ref settings.decorationsTiers, settings.decorationsTiersCache, s_NewDecorationTiers, a => a.Model);
    }
}