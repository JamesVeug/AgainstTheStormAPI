using System;
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
    private static Dictionary<BuildingBehaviourTypes, BuildingVisualData> m_visualData = new();
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
        // Plugin.Log.LogInfo($"Added new effect {name} with guid {guid} name: {model.name}");
        
        return item;
    }

    internal static Building GetDefaultVisualData(BuildingBehaviourTypes behaviourTypes)
    {
        if (!m_visualData.TryGetValue(behaviourTypes, out var data))
        {
            string prefabName = behaviourTypes.ToEremitePrefabName();
            BuildingModel buildingModel = SO.Settings.GetBuilding(prefabName);
            Building modelPrefab = buildingModel.Prefab;

            BuildingVisualData visualData = new BuildingVisualData();
            visualData.prefab = modelPrefab;
            // InitializePrefab(prefab, behaviourTypes);
            // m_visualData[behaviourTypes] = visualData;

            data = visualData;
        }

        Building clone = GameObject.Instantiate(data.prefab, s_prefabContainer.transform);
        return clone;
    }
    
    private static void SyncBuildings()
    {
        if (!s_instantiated)
        {
            return;
        }
        
        Plugin.Log.LogInfo($"Syncing {s_newBuildings} new buildings");


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
        
        SyncBuildings();
    }

    private static void InitializePrefab(GameObject prefab, BuildingBehaviourTypes buildingBehaviourType)
    {
        
    }

    private static void InitializePrefab_LastResort<T,V>(GameObject prefab, AnimHookType villagerAnimationType = AnimHookType.Construction) 
        where T : Building
        where V : BuildingView
    {
        BuildingModel buildingModel = SO.Settings.GetBuilding("Beaver House");
        Building modelPrefab = buildingModel.Prefab;
        
        T building = prefab.AddComponent<T>();
        building.entrance = prefab.transform.Find("Entrance");
        
        V view = prefab.AddComponent<V>();
        var constructionAnimator = prefab.AddComponent<ScaffoldingConstructionAnimator>();
        view.constructionAnimator = constructionAnimator;
        constructionAnimator.scaffoldingParent = prefab.transform.Find("ToRotate");
        constructionAnimator.buildingParent = constructionAnimator.scaffoldingParent.Find("BuildingContainer");
        constructionAnimator.unconstructedPosition = new Vector3(0, -3, 0);
        constructionAnimator.constructedPosition = new Vector3(0, 0, 0);
        constructionAnimator.dustPrefab = modelPrefab.GetComponent<ScaffoldingConstructionAnimator>().dustPrefab;
        constructionAnimator.scaffoldingPrefab = modelPrefab.GetComponent<ScaffoldingConstructionAnimator>().scaffoldingPrefab;
        constructionAnimator.levels = 3;
        constructionAnimator.scaffoldingRising = new Vector2(0, 0.3f);
        constructionAnimator.buildingRising = new Vector2(0.3f, 0.8f);
        constructionAnimator.scaffoldingRising = new Vector2(0.8f, 1.0f);
        constructionAnimator.scaffoldingRising = new Vector2(0.01f, 0.8f);
        
        Transform animationsHooks = prefab.transform.Find("AnimationsHooks");
        building.villagersPositioner = animationsHooks.gameObject.AddComponent<VillagersPositioner>();
        foreach (Transform child in animationsHooks)
        {
            AnimationHook hook = child.gameObject.AddComponent<AnimationHook>();
            hook.type = villagerAnimationType;
        }
        building.villagersPositioner.hooks = animationsHooks.GetComponentsInChildren<AnimationHook>();
        
        if(building is Camp camp)
        {
            camp.productionStorage = prefab.AddComponent<BuildingStorage>();
            camp.state = new CampState();
            camp.model = null;
            camp.view = view as CampView;
        }
        else if (building is House house)
        {
            house.state = new HouseState();
            house.model = null;
            house.view = view as HouseView;
            house.blight = prefab.AddComponent<BuildingBlight>();
            
            List<BlightCyst> cysts = new List<BlightCyst>();
            foreach (Transform transform in constructionAnimator.buildingParent)
            {
                if (transform.name.Contains("Blight Cyst"))
                {
                    BlightCyst cyst = transform.gameObject.AddComponent<BlightCyst>();
                    cyst.animator = transform.GetComponentInChildren<Animator>();
                    cyst.animHook = transform.Find("Cyst Hook");
                    cyst.meshes = cyst.animator.GetComponentsInChildren<Renderer>();
                    cysts.Add(cyst);
                }
            }
            house.blight.cysts = cysts.ToArray();
        }
        
        view.rotationParent = constructionAnimator.scaffoldingParent;
        view.uiParent = view.rotationParent.Find("UI");
        SpritesLayout layout = view.iconsLayout.gameObject.AddComponent<SpritesLayout>();
        layout.padding = 0.2f;
        layout.iconSize = 0.7f;
        layout.elements = new GameObject[view.uiParent.childCount];
        int i = 0;
        foreach (Transform child in view.uiParent)
        {
            layout.elements[i++] = child.gameObject;
        }

        view.entranceIcon = view.rotationParent.Find("Entrance").Find("Icon").gameObject;
        view.noBuildersIcon = view.uiParent.Find("NoBuildersIcon").gameObject; 
        view.sleepingIcon = view.uiParent.Find("SleepingIcon").gameObject; 
        view.noGoodsIcon = view.uiParent.Find("NoGoodsIcon").gameObject;
        view.iconsLayout = layout;
        
        // view.panelBackgroundSound

        view.upgradeParts = [];
        
        if (view is ProductionBuildingView productionView)
        {
            productionView.productonLoopSound = null;
            productionView.noWorkersIcon = view.uiParent.Find("NoWorkersIcon").gameObject;
            productionView.idleIcon = view.uiParent.Find("IdleIcon").gameObject;
            productionView.animator = prefab.GetComponent<Animator>();
        }
        
        if (view is CampView campView)
        {
            campView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();

            Transform area = view.rotationParent.Find("Area");
            campView.area = area.gameObject.AddComponent<GridArea>();

            var mainGenerator = area.Find("MainArea").gameObject.AddComponent<MeshGridShapeWithEdgesGenerator>();
            mainGenerator.height = 0.02f;
            mainGenerator.sizeOffset = 0;
            mainGenerator.meshFilter = mainGenerator.GetComponent<MeshFilter>();
            mainGenerator.meshRenderer = mainGenerator.GetComponent<MeshRenderer>();
            mainGenerator.material = new Material(Shader.Find("Standard")); // TODO: Find correct shader
            mainGenerator.sheetWidth = 5;
            mainGenerator.sheetHeight = 3;
            mainGenerator.uvOffset = -0.005f;
            
            var overlayGenerator = area.Find("OverlayArea").gameObject.AddComponent<MeshGridShapeWithEdgesGenerator>();
            overlayGenerator.height = 0.02f;
            overlayGenerator.sizeOffset = 0;
            overlayGenerator.meshFilter = overlayGenerator.GetComponent<MeshFilter>();
            overlayGenerator.meshRenderer = overlayGenerator.GetComponent<MeshRenderer>();
            overlayGenerator.material = new Material(Shader.Find("Standard")); // TODO: Find correct shader
            overlayGenerator.sheetWidth = 5;
            overlayGenerator.sheetHeight = 3;
            overlayGenerator.uvOffset = -0.005f;
            
            campView.area.meshes = new MeshGridShapeWithEdgesGenerator[2];
            campView.area.meshes[0] = mainGenerator;
            campView.area.meshes[1] = overlayGenerator;
        }
        
        if(view is HouseView houseView)
        {
            // TODO:
            // houseView.blight = prefab.AddComponent<BuildingBlight>();
            // houseView.blight.cysts = new BlightCyst[0];
        }
    }
}


























