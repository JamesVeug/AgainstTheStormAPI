using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Difficulties;

public static class DifficultyManager
{
    public static IReadOnlyList<NewDifficulty> NewDifficulties => new ReadOnlyCollection<NewDifficulty>(s_newDifficulties);
    public static IReadOnlyDictionary<DifficultyTypes, NewDifficulty> NewDifficultiesLookup => new ReadOnlyDictionary<DifficultyTypes, NewDifficulty>(s_newDifficultiesLookup);
    
    private static List<NewDifficulty> s_newDifficulties = new List<NewDifficulty>();
    private static Dictionary<DifficultyTypes, NewDifficulty> s_newDifficultiesLookup = new Dictionary<DifficultyTypes, NewDifficulty>();
    
    private static ArraySync<DifficultyModel, NewDifficulty> s_difficulties = new("New Difficulties");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewDifficulty New(string guid, string name)
    {
        DifficultyModel difficultyModel = ScriptableObject.CreateInstance<DifficultyModel>();
        

        NewDifficulty difficulty = Add(guid, name, difficultyModel);
        return difficulty;
    }

    public static NewDifficulty Add(string guid, string name, DifficultyModel model)
    {
        model.name = guid + "_" + name;
        
        DifficultyTypes id = GUIDManager.Get<DifficultyTypes>(guid, name);
        DifficultyTypesExtensions.TypeToInternalName[id] = model.name;
        NewDifficulty newGood = new NewDifficulty
        {
            difficultyModel = model,
            id = id,
            guid = guid,
            rawName = name
        };
        s_newDifficulties.Add(newGood);
        s_newDifficultiesLookup.Add(id, newGood);
        s_dirty = true;

        return newGood;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncGoods();
    }
    
    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            SyncGoods();
        }
    }

    private static void SyncGoods()
    {
        if (!s_instantiated)
        {
            return;
        }

        APILogger.LogInfo("DifficultyManager.Sync: " + s_newDifficulties.Count + " new difficulties");

        
        Settings settings = SO.Settings;
        s_difficulties.Sync(ref settings.difficulties, settings.difficultiesCache, s_newDifficulties, a => a.difficultyModel);
    }
}