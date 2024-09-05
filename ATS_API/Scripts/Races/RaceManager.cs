using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Services;
using UnityEngine;

namespace ATS_API.Races;

public static class RaceManager
{
    public static IReadOnlyList<NewRaceData> NewRaces => new ReadOnlyCollection<NewRaceData>(s_newRaces);
    
    private static List<NewRaceData> s_newRaces = new List<NewRaceData>();
    private static Dictionary<RaceTypes, NewRaceData> s_newRaceLookup = new Dictionary<RaceTypes, NewRaceData>();

    private static ArraySync<RaceModel, NewRaceData> s_races = new("New Races");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewRaceData New(string guid, string name)
    {
        RaceModel RaceModel = ScriptableObject.CreateInstance<RaceModel>();
        RaceModel.isActive = true;
        RaceModel.isEssential = true;
        RaceModel.order = 6;
        RaceModel.tag = ScriptableObject.CreateInstance<ModelTag>();
        RaceModel.tag.name = $"[Tag] {guid}_{name}";
        RaceModel.displayName = Placeholders.DisplayName;
        RaceModel.pluralName = Placeholders.PluralDisplayName;
        RaceModel.description = Placeholders.Description;
        RaceModel.shortDescription = Placeholders.Description;
        RaceModel.passiveEffectDesc = Placeholders.PassiveEffectDesc;
        RaceModel.resilienceLabel = Placeholders.LabelLocaText;
        RaceModel.initialEffects = [];
        RaceModel.characteristics = [];
        RaceModel.deathEffects = [];
        RaceModel.maleNames = ["Aiden", "Bryce", "Caleb", "Dylan", "Ethan", "Finn", "Gavin", "Hayden", "Isaac", "James", "Kai", "Liam", "Mason", "Nolan", "Owen", "Parker", "Quinn", "Ryder", "Sebastian", "Tristan", "Uriel", "Vincent", "Wyatt", "Xander", "Yuri", "Zane"];
        RaceModel.femaleNames = ["Ava", "Bella", "Chloe", "Daisy", "Ella", "Fiona", "Grace", "Hannah", "Isabella", "Jasmine", "Kylie", "Lily", "Mia", "Nora", "Olivia", "Piper", "Quinn", "Riley", "Sophia", "Tessa", "Uma", "Violet", "Willow", "Xena", "Yara"];
        RaceModel.baseSpeed = 1.8f;
        RaceModel.hungerTolerance = 4;
        
        // Needs
        RaceModel.needs = [];
        RaceModel.needsInterval = 100f;
        
        // Resolve
        RaceModel.initialResolve = 5f;
        RaceModel.minResolve = 0f;
        RaceModel.maxResolve = 50f;
        RaceModel.reputationPerSec = 0.000195f;
        RaceModel.maxReputationFromResolvePerSec = 0.025f;
        RaceModel.resolveToReputationRatio = 0.1f;
        RaceModel.minPopulationToGainReputation = 1;
        RaceModel.resolvePositveChangePerSec = 0.15f;
        RaceModel.resolveNegativeChangePerSec = 0.12f;
        RaceModel.resolveNegativeChangeDiffFactor = 0.1f;
        RaceModel.resolveForReputationTreshold = new Vector2(15f, 50f);
        RaceModel.reputationTresholdIncreasePerReputation = 3f;
        RaceModel.populationToReputationRatio = 0.7f;
        
        // Audio
        RaceModel.avatarClickSound = Placeholders.RacialSound(RaceModel);
        RaceModel.ambientSounds = Placeholders.RacialSound(RaceModel);
        RaceModel.favoringStartSound = Placeholders.SoundRef;
        
        return Add(guid, name, RaceModel);
    }
    
    private static NewRaceData Add(string guid, string name, RaceModel model)
    {
        model.name = guid + "_" + name;
        RaceTypes id = GUIDManager.Get<RaceTypes>(guid, name);
        RaceTypesExtensions.TypeToInternalName[id] = name;
        NewRaceData newTrader = new NewRaceData()
        {
            ID = id,
            RaceModel = model
        };
        
        s_newRaces.Add(newTrader);
        s_newRaceLookup[id] = newTrader;
        s_dirty = true;
        return newTrader;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
    }

    internal static void Tick()
    {
        if (s_dirty)
        {
            s_dirty = false;
            SyncRaces();
        }
    }

    private static void SyncRaces()
    {
        if (!s_instantiated)
        {
            return;
        }

        Plugin.Log.LogInfo("RaceManager.SyncRaces: " + s_newRaces.Count + " new races");


        Settings settings = SO.Settings;
        var addedRaces = s_races.Sync(ref settings.Races, settings.racesCache, s_newRaces, a=>a.RaceModel);
        Plugin.Log.LogInfo("RaceManager.SyncedRaces");
        
        // MetaStateService val = (MetaStateService)SO.MetaStateService;
        // Plugin.Log.LogInfo("#a");
        // if (val == null)
        // {
        //     Plugin.Log.LogError("MetaStateService is null");
        //     return;
        // }
        //
        // Plugin.Log.LogInfo("#b");
        // if (val.Content == null)
        // {
        //     Plugin.Log.LogError("MetaStateService.Content is null");
        //     return;
        // }
        //
        // Plugin.Log.LogInfo("#c");
        // if (val.Content.races == null)
        // {
        //     Plugin.Log.LogError("MetaStateService.Content.races is null");
        //     return;
        // }
        //
        // Plugin.Log.LogInfo("#d");
        // if (addedRaces == null)
        // {
        //     Plugin.Log.LogError("addedRaces is null");
        //     return;
        // }
        //
        //
        // Plugin.Log.LogInfo("#e");
        // Plugin.Log.LogInfo("Adding races: " + addedRaces.Count);
        // Plugin.Log.LogInfo("#f");
        // foreach (NewRace race in addedRaces)
        // {
        //     Plugin.Log.LogInfo("#g");
        //     Plugin.Log.LogInfo("New race: " + race);
        //     val.Content.races.Add(race.RaceModel.name);
        // }
        // Plugin.Log.LogInfo("Done syncing races");
    }
}