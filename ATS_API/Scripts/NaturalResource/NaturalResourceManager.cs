using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ATS_API.NaturalResource;

public static class NaturalResourceManager
{
    public static IReadOnlyList<NewNaturalResource> NewNaturalResource => new ReadOnlyCollection<NewNaturalResource>(s_newNaturalResource);
    public static IReadOnlyDictionary<NaturalResourceTypes, NewNaturalResource> NewNaturalResourceLookup => new ReadOnlyDictionary<NaturalResourceTypes, NewNaturalResource>(s_newNaturalResourceLookup);
    
    private static List<NewNaturalResource> s_newNaturalResource = new List<NewNaturalResource>();
    private static Dictionary<NaturalResourceTypes, NewNaturalResource> s_newNaturalResourceLookup = new Dictionary<NaturalResourceTypes, NewNaturalResource>();
    
    private static ArraySync<NaturalResourceModel, NewNaturalResource> s_NaturalResource = new("New NaturalResource");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewNaturalResource New(string guid, string name)
    {
        NaturalResourceModel model = ScriptableObject.CreateInstance<NaturalResourceModel>();
        model.displayName = Placeholders.DisplayName;
        model.description = Placeholders.Description;
        model.label = Placeholders.Label; // Label_Resource
        
        model.production = new GoodRef();
        model.production.good = null;
        model.production.amount = 0;
        
        model.extraProduction = [];
        model.refGood = null; // Same as production.good

        model.isGenerated = true;
        model.charges = 2;
        model.order = 0;
        model.villagerAnimationFlag = "SwingAxe";
        
        model.prefabs = [];
        model.gatheringSound = null; // Woodlands_Trees
        model.finalSound = null; // Wood_STORING
        
        model.defaultTreesColor = new Color(0, 0, 0, 0);
        model.highlightedTreesColor = new Color(0.8313726f, 0.6392157f, 0.2f, 1f);
        model.defaultTreesColor = new Color(0.6392157f, 0.6588235f, 0.6705883f, 1f);
        model.editorColor = new Color(0f, 0.6981132f, 0.03333723f, 1f);
        model.editorShortcut = Key.Digit2;
        
        
        

        NewNaturalResource NaturalResource = Add(guid, name, model);
        return NaturalResource;
    }

    public static NewNaturalResource Add(string guid, string name, NaturalResourceModel NaturalResourceModel)
    {
        NaturalResourceModel.name = guid + "_" + name;
        
        NaturalResourceTypes id = GUIDManager.Get<NaturalResourceTypes>(guid, name);
        NaturalResourceTypesExtensions.TypeToInternalName[id] = NaturalResourceModel.name;
        NewNaturalResource newNaturalResource = new NewNaturalResource
        {
            Model = NaturalResourceModel,
            ID = id,
            Guid = guid,
            RawName = name
        };
        s_newNaturalResource.Add(newNaturalResource);
        s_newNaturalResourceLookup.Add(id, newNaturalResource);
        s_dirty = true;

        return newNaturalResource;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncNaturalResource();
    }
    
    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            SyncNaturalResource();
        }
    }

    private static void SyncNaturalResource()
    {
        if (!s_instantiated)
        {
            return;
        }

        Plugin.Log.LogInfo("NaturalResourceManager.Sync: " + s_newNaturalResource.Count + " new NaturalResource");

        
        Settings settings = SO.Settings;
        s_NaturalResource.Sync(ref settings.NaturalResources, settings.naturalResourcesCache, s_newNaturalResource, a => a.Model);
    }
}