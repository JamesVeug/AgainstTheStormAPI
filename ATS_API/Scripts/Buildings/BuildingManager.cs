﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Biomes;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.MapTools;
using Eremite.Model;
using Eremite.View.Utils;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    public static IReadOnlyList<NewBuildingData> NewBuildings => new ReadOnlyCollection<NewBuildingData>(s_newBuildings);
    
    private static List<NewBuildingData> s_newBuildings = new List<NewBuildingData>();
    
    private static ArraySync<BuildingModel, NewBuildingData> s_buildings = new("New Buildings");

    private static GameObject s_prefabContainer;
    private static Dictionary<BuildingBehaviourTypes, GameObject> m_visualData = new();
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            SyncBuildings();
        }
    }
    
    public static NewBuildingData CreateBuilding<T>(string guid, string name, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        data.name = guid + "_" + name;
        
        return AddBuilding(guid, data.name, data, behaviour);
    }
    
    public static NewBuildingData AddBuilding<T>(string guid, string name, T model, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        s_dirty = true;

        NewBuildingData item = new NewBuildingData()
        {
            Guid = guid,
            Name = name,
            BuildingModel = model,
            VisualData = null,
            Behaviour = behaviour
        };
        s_newBuildings.Add(item);
        Plugin.Log.LogInfo($"Added new building {name} with guid {guid} name: {(model == null ? "null" : model.name)}");
        
        return item;
    }

    internal static GameObject GetDefaultVisualData(BuildingBehaviourTypes behaviourTypes, Sprite sprite)
    {
        if (!m_visualData.TryGetValue(behaviourTypes, out var data))
        {
            string prefabName = behaviourTypes.ToAssetBundlePrefabName();
            data = Plugin.ATS_API_Bundle.LoadAsset<GameObject>(prefabName);
            if (data == null)
            {
                Plugin.Log.LogError($"Could not find prefab {prefabName} for behaviour {behaviourTypes}");
                return null;
            }
            
            m_visualData.Add(behaviourTypes, data);
        }

        GameObject clone = GameObject.Instantiate(data, s_prefabContainer.transform);
        
        // Replace tiers
        
        return clone;
    }
    
    private static void SyncBuildings()
    {
        if (!s_instantiated)
        {
            return;
        }
        
        Plugin.Log.LogInfo($"Syncing {s_newBuildings.Count} new buildings");
        // foreach (NewBuildingData buildingData in s_newBuildings)
        // {
        //     Plugin.Log.LogInfo($"- {buildingData.BuildingModel} new buildings");
        // }


        Settings settings = SO.Settings;
        s_buildings.Sync(ref settings.Buildings, settings.buildingsCache, s_newBuildings, a=>a.BuildingModel);
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        
        s_prefabContainer = new GameObject("New Buildings");
        s_prefabContainer.transform.SetParent(Plugin.Instance.gameObject.transform);
        s_prefabContainer.SetActive(false);
    }
}

























