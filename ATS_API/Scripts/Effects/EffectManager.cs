using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Biomes;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Effects;

public static partial class EffectManager
{
    public static IReadOnlyList<NewEffectData> NewEffects => new ReadOnlyCollection<NewEffectData>(s_newEffects);
    public static IReadOnlyList<NewResolveEffectData> NewResolveEffects => new ReadOnlyCollection<NewResolveEffectData>(s_newResolveEffects);
    public static IReadOnlyDictionary<string, string> PreviouslyNamedAs => new ReadOnlyDictionary<string, string>(s_previouslyNamedAs);
    
    private static List<NewEffectData> s_newEffects = new List<NewEffectData>();
    private static List<NewResolveEffectData> s_newResolveEffects = new List<NewResolveEffectData>();
    private static Dictionary<string, string> s_previouslyNamedAs = new Dictionary<string, string>();
    
    private static ArraySync<EffectModel, NewEffectData> s_effects = new("New Effects");
    private static ArraySync<ResolveEffectModel, NewResolveEffectData> s_resolveEffects = new("new Resolve Effectgs");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;

    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            SyncEffect();
        }
    }

    public static NewEffectData CreateEffect<T>(string guid, string name) where T : EffectModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        data.name = guid + "_" + name;
        
        return AddEffect(guid, data.name, data, null);
    }

    public static bool GetOrCreateEffect<T>(string guid, string name, out NewEffectData effect) where T : EffectModel
    {
        effect = s_newEffects.Find(a => a.Guid == guid && a.Name == name);
        if (effect == null)
        {
            NewEffectData effectData = CreateEffect<T>(guid, name);
            effect = effectData;
            return false;
        }

        return true;
    }
    
    public static T CreateResolveEffect<T>(string guid, string name) where T : ResolveEffectModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        data.name = guid + "_" + name;
        AddResolveEffect(data);

        return data;
    }

    public static NewEffectData AddEffect<T>(string guid, string name, T model, Availability availability) where T : EffectModel
    {
        s_dirty = true;
        
        NewEffectData item = new NewEffectData()
        {
            Guid = guid,
            Name = name,
            EffectModel = model,
            Availability = availability ?? new Availability()
        };
        s_newEffects.Add(item);
        // Plugin.Log.LogInfo($"Added new effect {name} with guid {guid} name: {model.name}");
        
        return item;
    }

    public static void AddResolveEffect(ResolveEffectModel model)
    {
        s_dirty = true;
        s_newResolveEffects.Add(new NewResolveEffectData()
        {
            Model = model
        });
    }

    public static void AddPreviouslyNamedEffect(string oldName, string newName)
    {
        s_previouslyNamedAs[oldName] = newName;
    }

    private static void SyncEffect()
    {
        if (!s_instantiated)
        {
            return;
        }
        
        // Plugin.Log.LogInfo("EffectManager.SyncEffect: base effects, " + s_newEffects.Count + " new effects");


        Settings settings = SO.Settings;
        s_effects.Sync(ref settings.effects, settings.effectsCache, s_newEffects, a=>a.EffectModel);
        s_resolveEffects.Sync(ref SO.Settings.resolveEffects, settings.resolveEffectsCache, s_newResolveEffects, a=>a.Model);
        
        // s_allEffects = s_baseEffects.Concat(s_newEffects.Select(a=>a.EffectModel)).ToList();
        // settings.effects = s_allEffects.ToArray();
        // settings.effectsCache.cache = null; // Force refresh then next time it's accessed
        
        BiomeManager.SetDirty();
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncEffect();
    }
}