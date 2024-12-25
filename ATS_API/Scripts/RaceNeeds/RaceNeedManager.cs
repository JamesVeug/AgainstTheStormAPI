using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Needs;

public static class RaceNeedManager
{
    public static IReadOnlyList<CustomRaceNeed> NewRaceNeeds => new ReadOnlyCollection<CustomRaceNeed>(s_NewRaceNeeds);
    
    private static List<CustomRaceNeed> s_NewRaceNeeds = new List<CustomRaceNeed>();
    private static Dictionary<NeedTypes, CustomRaceNeed> s_NewRaceNeedLookup = new Dictionary<NeedTypes, CustomRaceNeed>();

    private static ArraySync<NeedModel, CustomRaceNeed> s_raceNeeds = new("New Race Needs");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static CustomRaceNeed New(string guid, string name)
    {
        NeedModel NeedModel = ScriptableObject.CreateInstance<NeedModel>();
    
        return Add(guid, name, NeedModel);
    }
    
    private static CustomRaceNeed Add(string guid, string name, NeedModel model)
    {
        model.name = guid + "_" + name;
        NeedTypes id = GUIDManager.Get<NeedTypes>(guid, name);
        NeedTypesExtensions.TypeToInternalName[id] = model.name;
        CustomRaceNeed customRaceTrader = new CustomRaceNeed()
        {
            ID = id,
            guid = guid,
            needName = name,
            NeedModel = model
        };
        
        s_NewRaceNeeds.Add(customRaceTrader);
        s_NewRaceNeedLookup[id] = customRaceTrader;
        s_dirty = true;
        return customRaceTrader;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;

        SyncNeeds();
    }

    internal static void Tick()
    {
        if (s_dirty)
        {
            s_dirty = false;
            SyncNeeds();
        }
    }

    internal static void SyncNeeds()
    {
        if (!s_instantiated)
        {
            return;
        }

        APILogger.LogInfo("Syncing Needs: " + s_NewRaceNeeds.Count + " new needs");


        Settings settings = SO.Settings;
        s_raceNeeds.Sync(ref settings.Needs, null, s_NewRaceNeeds, a=>a.NeedModel);
    }
}