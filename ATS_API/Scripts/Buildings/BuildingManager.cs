using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    public static IReadOnlyList<NewBuildingData> NewBuildings => new ReadOnlyCollection<NewBuildingData>(s_newBuildings);
    public static IReadOnlyList<NewInstitutionBuildingData> NewInstitutions => new ReadOnlyCollection<NewInstitutionBuildingData>(s_newInstitutions);
    public static IReadOnlyList<NewWorkshopBuildingData> NewWorkshops => new ReadOnlyCollection<NewWorkshopBuildingData>(s_newWorkshops);
    public static IReadOnlyList<NewDecorationBuildingData> NewDecorations => new ReadOnlyCollection<NewDecorationBuildingData>(s_newDecorations);
    public static IReadOnlyList<NewHouseBuildingData> NewHouses => new ReadOnlyCollection<NewHouseBuildingData>(s_newHouses);
    

    private static List<NewBuildingData> s_newBuildings = new List<NewBuildingData>();
    private static List<NewInstitutionBuildingData> s_newInstitutions = new List<NewInstitutionBuildingData>();
    private static List<NewWorkshopBuildingData> s_newWorkshops = new List<NewWorkshopBuildingData>();
    private static List<NewDecorationBuildingData> s_newDecorations = new List<NewDecorationBuildingData>();
    private static List<NewHouseBuildingData> s_newHouses = new List<NewHouseBuildingData>();
    
    private static List<NewBuildingTagModel> s_newBuildingTags = new List<NewBuildingTagModel>();
    internal static Transform PrefabContainer => s_prefabContainer;
    
    private static ArraySync<BuildingModel, NewBuildingData> s_buildings = new("New Buildings");
    private static ArraySync<InstitutionModel, NewInstitutionBuildingData> s_institutions = new("New Institutions");
    private static ArraySync<WorkshopModel, NewWorkshopBuildingData> s_workshops = new("New Workshops");
    private static ArraySync<HouseModel, NewHouseBuildingData> s_houses = new("New Houses");
    private static ArraySync<DecorationModel, NewDecorationBuildingData> s_decorations = new("New Decorations");
    
    private static ArraySync<BuildingTagModel, NewBuildingTagModel> s_buildingTags = new("New Buildings Tags");
    private static HashSet<IBuildingData> s_dirtyBuildings = new HashSet<IBuildingData>();
    
    // SO.Settings doesn't have every building type. so we need our own to sync the data
    private static HouseModel[] s_houseCache = new HouseModel[0];
    private static DecorationModel[] s_decorationCache = new DecorationModel[0];

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

    public static NewDecorationBuildingData CreateDecoration(string guid, string name)
    {
        CreateBuilding<DecorationModel>(guid, name, BuildingBehaviourTypes.Decoration);
        return s_newDecorations.Last();
    }
    
    public static NewInstitutionBuildingData CreateInstitution(string guid, string name)
    {
        CreateBuilding<InstitutionModel>(guid, name, BuildingBehaviourTypes.Institution);
        return s_newInstitutions.Last();
    }
    
    public static NewWorkshopBuildingData CreateWorkshop(string guid, string name)
    {
        CreateBuilding<WorkshopModel>(guid, name, BuildingBehaviourTypes.Workshop);
        return s_newWorkshops.Last();
    }
    
    public static NewHouseBuildingData CreateHouse(string guid, string name)
    {
        CreateBuilding<HouseModel>(guid, name, BuildingBehaviourTypes.House);
        return s_newHouses.Last();
    }
    
    public static NewBuildingData CreateBuilding<T>(string guid, string name, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        
        NewBuildingData newBuilding = AddBuilding(guid, name, data, behaviour);
        return newBuilding;
    }
    
    public static NewBuildingData AddBuilding<T>(string guid, string name, T model, BuildingBehaviourTypes behaviour) where T : BuildingModel
    {
        s_dirty = true;
        model.name = guid + "_" + name;
        APILogger.IsFalse(s_newBuildings.Any(a=>a.BuildingModel.name == model.name), $"Adding Building with name {model.name} that already exists!");

        BuildingTypes id = GUIDManager.Get<BuildingTypes>(guid, name);
        BuildingTypesExtensions.TypeToInternalName[id] = model.name;
        
        NewBuildingTagModel buildingTag = NewBuildingTagModel(guid, name);
        
        NewBuildingData buildingData = new NewBuildingData(guid, name, id, model, behaviour);
        s_newBuildings.Add(buildingData);
        
        if(model is InstitutionModel institutionModel)
        {
            var item = new NewInstitutionBuildingData(guid, name, id, institutionModel, behaviour);
            item.Tag = buildingTag.ID;
            s_newInstitutions.Add(item);
        }
        else if(model is WorkshopModel workshopModel)
        {
            var item = new NewWorkshopBuildingData(guid, name, id, workshopModel, behaviour);
            item.Tag = buildingTag.ID;
            s_newWorkshops.Add(item);
        }
        else if(model is DecorationModel decorationModel)
        {
            var item = new NewDecorationBuildingData(guid, name, id, decorationModel, behaviour);
            item.Tag = buildingTag.ID;
            s_newDecorations.Add(item);
        }
        else if(model is HouseModel houseModel)
        {
            var item = new NewHouseBuildingData(guid, name, id, houseModel, behaviour);
            item.Tag = buildingTag.ID;
            s_newHouses.Add(item);
        }
        else
        {
            throw new NotImplementedException($"Building type {typeof(T)} not implemented");
        }
        
        return buildingData;
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
        
        
        APILogger.IsFalse(s_newBuildingTags.Any(a=>a.Model.name == tag.name), $"Adding BuildingTag with name {tag.name} that already exists!");
        s_newBuildingTags.Add(newTag);
        
        s_dirty = true;
        APILogger.LogInfo($"Added new building tag {name} with guid {guid} name");
        
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
                APILogger.LogError($"Could not find prefab {prefabName} for behaviour {behaviourTypes}");
                return null;
            }

            m_visualData.Add(behaviourTypes, prefab);
        }

        
        // Replace tiers
        
        return prefab;
    }
    
    private static void SyncBuildings()
    {
        APILogger.LogInfo($"Syncing {s_newBuildings.Count} new buildings");

        Settings settings = SO.Settings;
        s_buildings.Sync(ref settings.Buildings, settings.buildingsCache, s_newBuildings, a=>a.BuildingModel);
        s_institutions.Sync(ref settings.Institutions, null, s_newInstitutions, a=>a.BuildingModel);
        s_workshops.Sync(ref settings.workshops, null, s_newWorkshops, a=>a.BuildingModel);
        s_houses.Sync(ref s_houseCache, null, s_newHouses, a=>a.BuildingModel);
        s_decorations.Sync(ref s_decorationCache, null, s_newDecorations, a=>a.BuildingModel);

        foreach (IBuildingData data in s_dirtyBuildings)
        {
            if (!data.Sync())
            {
                continue;
            }
            Plugin.PostTick.AddListener(data.PostSync);
        }
    }

    private static void SyncBuildingTags()
    {
        APILogger.LogInfo($"Syncing {s_newBuildingTags.Count} new building tags");
        
        Settings settings = SO.Settings;
        s_buildingTags.Sync(ref settings.buildingsTags, settings.buildingsTagsCache, s_newBuildingTags, a=>a.Model);
    }

    internal static void QueueSync(IBuildingData model)
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