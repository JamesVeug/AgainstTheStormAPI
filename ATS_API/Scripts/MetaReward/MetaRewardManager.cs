using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Meta;
using UnityEngine;

namespace ATS_API.MetaRewards;

public partial class MetaRewardManager
{
    public static IReadOnlyList<NewMetaRewardData> NewMetaRewards => new ReadOnlyCollection<NewMetaRewardData>(s_newMetaRewards);
    public static IReadOnlyDictionary<MetaRewardTypes, NewMetaRewardData> NewMetaRewardsLookup => new ReadOnlyDictionary<MetaRewardTypes, NewMetaRewardData>(s_newMetaRewardsLookup);
    
    private static List<NewMetaRewardData> s_newMetaRewards = new List<NewMetaRewardData>();
    private static Dictionary<MetaRewardTypes, NewMetaRewardData> s_newMetaRewardsLookup = new Dictionary<MetaRewardTypes, NewMetaRewardData>();
    
    private static ArraySync<MetaRewardModel, NewMetaRewardData> s_metaRewards = new("New Meta Reward");
    private static HashSet<MetaRewardModel> s_disabledMetaRewards = new HashSet<MetaRewardModel>();
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static NewMetaRewardData New<T>(string guid, string name) where T : MetaRewardModel
    {
        T model = ScriptableObject.CreateInstance<T>();
        return Add(guid, name, model);
    }
    
    public static NewMetaRewardData Add(string guid, string name, MetaRewardModel model)
    {
        model.name = guid + "_" + name;
        
        MetaRewardTypes id = GUIDManager.Get<MetaRewardTypes>(guid, name);
        MetaRewardTypesExtensions.TypeToInternalName[id] = model.name;
        NewMetaRewardData newMetaReward = new NewMetaRewardData(guid, name, model);
        s_newMetaRewards.Add(newMetaReward);
        s_dirty = true;
        return newMetaReward;
    }
    
    public static void Tick()
    {
        if(s_dirty)
        {
            if (!s_instantiated)
            {
                return;
            }
            
            s_dirty = false;
            SyncMetaRewards();
        }
    }
    
    private static void SyncMetaRewards()
    {
        APILogger.LogInfo($"Syncing {s_newMetaRewards.Count} new meta rewards");

        Settings settings = SO.Settings;
        s_metaRewards.Sync(ref settings.metaRewards, settings.metaRewardsCache, s_newMetaRewards, a=>a.Model);
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
    }
    
    public void DisableMetaReward(MetaRewardTypes type)
    {
        s_disabledMetaRewards.Add(NewMetaRewardsLookup[type].Model);
    }
}