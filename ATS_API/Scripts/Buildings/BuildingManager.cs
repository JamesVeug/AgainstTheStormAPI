using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    public static IReadOnlyList<NewBuildingData> NewBuildings => new ReadOnlyCollection<NewBuildingData>(s_newBuildings);

    private static List<NewBuildingData> s_newBuildings = new List<NewBuildingData>();
    private static List<NewBuildingTagModel> s_newBuildingTags = new List<NewBuildingTagModel>();
    internal static Transform PrefabContainer => s_prefabContainer;
    
    private static ArraySync<BuildingModel, NewBuildingData> s_buildings = new("New Buildings");
    private static ArraySync<BuildingTagModel, NewBuildingTagModel> s_buildingTags = new("New Buildings Tags");
    private static HashSet<NewBuildingData> s_dirtyBuildings = new HashSet<NewBuildingData>();

    private static Transform s_prefabContainer;
    private static Dictionary<BuildingBehaviourTypes, GameObject> m_visualData = new();
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static void Tick()
    {
        if(s_dirty)
        {
            if (!s_instantiated)
            {
                return;
            }
            
            s_dirty = false;
            SyncBuildingTags();
            SyncBuildings();
        }
    }

    public static NewBuildingData CreateBuilding<T>(string guid, string name, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        data.name = guid + "_" + name;
        
        NewBuildingData newBuilding = AddBuilding(guid, name, data, behaviour);
        
        NewBuildingTagModel housingTag = NewBuildingTagModel(guid, name);
        newBuilding.Tag = housingTag.ID;
        data.tags = [housingTag.Model];

        return newBuilding;
    }
    
    public static NewBuildingData AddBuilding<T>(string guid, string name, T model, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        s_dirty = true;

        BuildingTypes id = GUIDManager.Get<BuildingTypes>(guid, name);
        BuildingTypesExtensions.TypeToInternalName[id] = model.name;
        NewBuildingData item = new NewBuildingData()
        {
            Guid = guid,
            Name = name,
            ID = id,
            BuildingModel = model,
            VisualData = null,
            Behaviour = behaviour
        };
        s_newBuildings.Add(item);
        Plugin.Log.LogInfo($"Added new building {name} with guid {guid} name: {(model == null ? "null" : model.name)}");
        
        return item;
    }

    public static NewBuildingTagModel NewBuildingTagModel(string guid, string name)
    {
        BuildingTagModel tag = ScriptableObject.CreateInstance<BuildingTagModel>();
        tag.workerSlotAnim = "Pulsate Orange";
        tag.visible = false;
        tag.workerSlotPositon = BuildingTagIconPosition.None;
        tag.name = guid + "_" + name;
        tag.logic = new AlwaysActiveTagLogic();
        // tag.icon = TODO: Add temp icon 

        BuildingTagTypes id = GUIDManager.Get<BuildingTagTypes>(guid, name);
        BuildingTagTypesExtensions.TypeToInternalName[id] = tag.name;
        NewBuildingTagModel newTag = new NewBuildingTagModel(id, tag);
        s_newBuildingTags.Add(newTag);
        
        s_dirty = true;
        Plugin.Log.LogInfo($"Added new building tag {name} with guid {guid} name");
        
        return newTag;
    }

    internal static GameObject GetDefaultVisualData(BuildingBehaviourTypes behaviourTypes, Sprite sprite)
    {
        if (!m_visualData.TryGetValue(behaviourTypes, out var prefab))
        {
            string prefabName = behaviourTypes.ToAssetBundlePrefabName();
            prefab = Plugin.ATS_API_Bundle.LoadAsset<GameObject>(prefabName);
            if (prefab == null)
            {
                Plugin.Log.LogError($"Could not find prefab {prefabName} for behaviour {behaviourTypes}");
                return null;
            }

            m_visualData.Add(behaviourTypes, prefab);
        }

        
        // Replace tiers
        
        return prefab;
    }
    
    private static void SyncBuildings()
    {
        Plugin.Log.LogInfo($"Syncing {s_newBuildings.Count} new buildings");

        Settings settings = SO.Settings;
        s_buildings.Sync(ref settings.Buildings, settings.buildingsCache, s_newBuildings, a=>a.BuildingModel);

        foreach (NewBuildingData data in s_dirtyBuildings)
        {
            if (!data.Sync())
            {
                continue;
            }
            Plugin.PostTick += data.PostSync;
        }
    }

    private static void SyncBuildingTags()
    {
        Plugin.Log.LogInfo($"Syncing {s_newBuildingTags.Count} new building tags");
        
        Settings settings = SO.Settings;
        s_buildingTags.Sync(ref settings.buildingsTags, settings.buildingsTagsCache, s_newBuildingTags, a=>a.Model);
    }

    internal static void QueueSync(NewBuildingData model)
    {
        s_dirtyBuildings.Add(model);
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        
        s_prefabContainer = new GameObject("New Buildings").transform;
        s_prefabContainer.SetParent(Plugin.Instance.gameObject.transform);
        s_prefabContainer.SetActive(false);
    }
}