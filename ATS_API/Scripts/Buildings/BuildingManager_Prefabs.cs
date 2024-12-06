using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.MapTools;
using Eremite.View.Utils;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    private class ScaffoldingData
    {
        public GameObject ScaffoldingPrefab { get; set; }
        
        public int maxSize;
        public Vector3 unconstructedPosition;
        public Vector3 constructedPosition;
        
        public Vector2 buildingRising;
        public Vector2 scaffoldingDropping;
        public Vector2 dustRange;
        public Vector3 scaffoldingPosition;
        public Vector2 scaffoldingDroppedPosition;
        public int levels;
        public Vector2 scaffoldingRising;
    }
    
    private static ScaffoldingData TileSize1x1ScaffoldingData => new ScaffoldingData
    {
        maxSize = 1,
        levels = 1,
        
        unconstructedPosition = new Vector3(0, -1, 0),
        constructedPosition = new Vector3(0, 0, 0),
        
        buildingRising = new Vector2(0.3f, 0.8f),
        scaffoldingDropping = new Vector2(0.8f, 1f),
        dustRange = new Vector2(0.01f, 0.8f),
        scaffoldingPosition = new Vector3(0f, -0.1f, 0f),
        scaffoldingDroppedPosition = new Vector3(0f, -0.5f, 0f),
        scaffoldingRising = new Vector2(0, 0.3f),
        
        ScaffoldingPrefab = BuildingTypes.Pipe.ToBuildingModel().Prefab.GetComponent<SimpleConstructionAnimator>().scaffoldingPrefab
    };
    
    private static ScaffoldingData TileSize2x2ScaffoldingData => new ScaffoldingData
    {
        maxSize = 2,
        buildingRising = new Vector2(0.3f, 0.8f),
        
        unconstructedPosition = new Vector3(0, -3, 0),
        constructedPosition = new Vector3(0, 0, 0),
        levels = 3,
        scaffoldingRising = new Vector2(0, 0.3f),
        
        ScaffoldingPrefab = BuildingTypes.Workshop.ToBuildingModel().Prefab.GetComponent<ScaffoldingConstructionAnimator>().scaffoldingPrefab
    };

    private static ConstructionAnimator AddScaffoldingConstructionAnimator(GameObject prefab, BuildingView view, ScaffoldingData scaffoldingData)
    {
        BuildingModel buildingModelTemplate = BuildingTypes.Workshop.ToBuildingModel();
        Building buildingTemplate = buildingModelTemplate.Prefab;
        
        var constructionAnimator = prefab.AddComponent<ScaffoldingConstructionAnimator>();
        constructionAnimator.scaffoldingParent = Util.FindChildRecursive(prefab.transform, "ToRotate");
        view.constructionAnimator = constructionAnimator;
        
        constructionAnimator.buildingParent = constructionAnimator.scaffoldingParent.Find("BuildingContainer") ?? constructionAnimator.scaffoldingParent;
        constructionAnimator.unconstructedPosition = scaffoldingData.unconstructedPosition;
        constructionAnimator.constructedPosition = scaffoldingData.constructedPosition;
        constructionAnimator.dustPrefab = buildingTemplate.GetComponent<ScaffoldingConstructionAnimator>().dustPrefab;
        constructionAnimator.scaffoldingPrefab = scaffoldingData.ScaffoldingPrefab;
        constructionAnimator.levels = scaffoldingData.levels;
        constructionAnimator.scaffoldingRising = scaffoldingData.scaffoldingRising;
        constructionAnimator.buildingRising = scaffoldingData.buildingRising;
        constructionAnimator.scaffoldingDropping = scaffoldingData.scaffoldingDropping;
        constructionAnimator.dustRange = scaffoldingData.dustRange;
        
        return constructionAnimator;
    }
    
    private static ConstructionAnimator AddSimpleConstructionAnimator(GameObject prefab, BuildingView view, ScaffoldingData scaffoldingData)
    {
        BuildingModel buildingModelTemplate = BuildingTypes.Pipe.ToBuildingModel();
        Building buildingTemplate = buildingModelTemplate.Prefab;
        
        var constructionAnimator = prefab.AddComponent<SimpleConstructionAnimator>();
        constructionAnimator.scaffoldingParent = Util.FindChildRecursive(prefab.transform, "ToRotate");
        view.constructionAnimator = constructionAnimator;
        
        constructionAnimator.buildingParent = constructionAnimator.scaffoldingParent.Find("BuildingContainer") ?? constructionAnimator.scaffoldingParent;
        constructionAnimator.unconstructedPosition = scaffoldingData.unconstructedPosition;
        constructionAnimator.constructedPosition = scaffoldingData.constructedPosition;
        constructionAnimator.dustPrefab = buildingTemplate.GetComponent<SimpleConstructionAnimator>().dustPrefab;
        constructionAnimator.scaffoldingPrefab = scaffoldingData.ScaffoldingPrefab;
        constructionAnimator.buildingRising = scaffoldingData.buildingRising;
        constructionAnimator.scaffoldingDropping = scaffoldingData.scaffoldingDropping;
        constructionAnimator.dustRange = scaffoldingData.dustRange;
        constructionAnimator.scaffoldingPositon = scaffoldingData.scaffoldingPosition;
        constructionAnimator.scaffoldingDroppedPositon = scaffoldingData.scaffoldingDroppedPosition;
        
        return constructionAnimator;
    }  
    
    
    /// <summary>
    /// NOTE: Only works for Workshop types atm
    /// </summary>
    internal static void InitializePrefab<B, V, M>(GameObject prefab, M buildingModel, Sprite displayIcon, AnimHookType villagerAnimationType = AnimHookType.Construction)
        where B : Building
        where V : BuildingView
        where M : BuildingModel
    {
        // Plugin.Log.LogInfo($"Initializing prefab {prefab.name} as {typeof(B).Name} with {typeof(V).Name} and {typeof(M).Name}");
        BuildingModel buildingModelTemplate = BuildingTypes.Workshop.ToBuildingModel();
        Building buildingTemplate = buildingModelTemplate.Prefab;
        Workshop workshopTemplate = buildingModelTemplate.Prefab.GetComponent<Workshop>();
        BlightCyst blightCyst = workshopTemplate.blight.cysts[0];

        // Plugin.Log.LogInfo($"Starting Building");
        B building = prefab.AddComponent<B>();
        building.entrance = Util.FindChildRecursive(prefab.transform, "Entrance");

        // Plugin.Log.LogInfo($"Starting View");
        V view = prefab.AddComponent<V>();
        
        int maxTileSize = Mathf.Max(buildingModel.size.x, buildingModel.size.y);
        ScaffoldingData scaffoldingData = maxTileSize == 1 ? TileSize1x1ScaffoldingData : TileSize2x2ScaffoldingData;
        
        // Plugin.Log.LogInfo($"Starting Scaffolding");
        ConstructionAnimator constructionAnimator = null;
        if (maxTileSize == 1)
        {
            constructionAnimator = AddSimpleConstructionAnimator(prefab, view, scaffoldingData);
        }
        else
        {
            constructionAnimator = AddScaffoldingConstructionAnimator(prefab, view, scaffoldingData);
        }

        // Plugin.Log.LogInfo($"Starting AnimationsHooks");
        Transform animationsHooks = Util.FindChildRecursive(prefab.transform, "AnimationsHooks", false);
        if (animationsHooks != null)
        {
            // Plugin.Log.LogInfo($"Starting AnimationsHooks 2");
            building.villagersPositioner = animationsHooks.gameObject.AddComponent<VillagersPositioner>();

            // Plugin.Log.LogInfo($"Starting AnimationsHooks 3");
            foreach (Transform child in animationsHooks)
            {
                // Plugin.Log.LogInfo($"Starting AnimationsHooks 4");
                AnimationHook hook = child.gameObject.AddComponent<AnimationHook>();
                // Plugin.Log.LogInfo($"Starting AnimationsHooks 5");
                hook.type = villagerAnimationType;
            }
            
            // Plugin.Log.LogInfo($"Starting AnimationsHooks 6");
            building.villagersPositioner.hooks = animationsHooks.GetComponentsInChildren<AnimationHook>();
        }


        Transform toRotate = Util.FindChildRecursive(prefab.transform, "ToRotate");
        Transform buildingContent = toRotate.GetChild(0);
        if (building is Camp camp)
        {
            camp.productionStorage = prefab.AddComponent<BuildingStorage>();
            camp.state = new CampState();
            camp.model = null;
            camp.view = view as CampView;
        }
        else if (building is House house)
        {
            // Plugin.Log.LogInfo($"Start house");
            house.state = new HouseState();
            house.model = buildingModel as HouseModel;
            house.view = view as HouseView;
            house.blight = SetupBlight(prefab, buildingContent, blightCyst);
            house.model.cystsAmount = house.blight.cysts.Length;
        }
        else if (building is Workshop workshop)
        {
            // Plugin.Log.LogInfo($"Starting workshop");
            workshop.productionStorage = prefab.AddComponent<BuildingStorage>();
            workshop.ingredientsStorage = prefab.AddComponent<BuildingIngredientsStorage>();
            workshop.model = buildingModel as WorkshopModel;
            workshop.state = new WorkshopState();
            workshop.view = view as WorkshopView;
            workshop.blight = SetupBlight(prefab, buildingContent, blightCyst);
            workshop.model.cystsAmount = workshop.blight.cysts.Length;
        }
        else if (building is Decoration decoration)
        {
            // Plugin.Log.LogInfo($"Start house");
            decoration.state = new DecorationState();
            decoration.model = buildingModel as DecorationModel;
            decoration.view = view as DecorationView;
        }

        // Plugin.Log.LogInfo($"Starting SpritesLayout");
        view.rotationParent = toRotate;
        view.uiParent = GameObject.Instantiate(workshopTemplate.view.uiParent, prefab.transform).transform;
        SpritesLayout layout = view.uiParent.gameObject.GetComponent<SpritesLayout>();
        view.iconsLayout = layout;
        // layout.padding = 0.2f;
        // layout.iconSize = 0.7f;
        // layout.elements = new GameObject[view.uiParent.childCount];
        // int i = 0;
        // foreach (Transform child in view.uiParent)
        // {
        //     layout.elements[i++] = child.gameObject;
        // }

        // Plugin.Log.LogInfo($"Starting icons");
        view.entranceIcon = Util.FindChildRecursive(view.rotationParent, "Entrance").gameObject;
        view.noBuildersIcon = Util.FindChildRecursive(view.uiParent, "NoBuildersIcon").gameObject;
        view.sleepingIcon = Util.FindChildRecursive(view.uiParent, "SleepingIcon").gameObject;
        view.noGoodsIcon = Util.FindChildRecursive(view.uiParent, "NoGoodsIcon").gameObject;
        view.iconsLayout = layout;

        // Plugin.Log.LogInfo($"Starting panelBackgroundSound");
        view.panelBackgroundSound = buildingTemplate.BuildingView.panelBackgroundSound; // TODO: Customize

        // Plugin.Log.LogInfo($"Starting upgradeParts");
        List<BuildingUpgradePart> upgradeParts = new List<BuildingUpgradePart>();
        int tier = 1; // Start at 1 because 0 is always active
        while (Util.TryFindChild(prefab.transform, $"Tier {tier}", out GameObject tierGameObject, false))
        {
            BuildingUpgradePart upgradePart = tierGameObject.AddComponent<BuildingUpgradePart>();
            upgradePart.level = tier;
            upgradePart.reverseActivation = false;
            upgradePart.specificUpgrade = false;
            upgradePart.upgradeIndex = 0;
            upgradePart.gameObject.SetActive(false);
            upgradeParts.Add(upgradePart);
            tier++;
        }
        view.upgradeParts = upgradeParts.ToArray();
        

        if (view is ProductionBuildingView productionView)
        {
            // Plugin.Log.LogInfo($"Starting productionView");
            productionView.productonLoopSound = null;
            productionView.noWorkersIcon = Util.FindChildRecursive(view.uiParent, "NoWorkersIcon").gameObject;
            productionView.idleIcon = Util.FindChildRecursive(view.uiParent, "IdleIcon").gameObject;
            productionView.animator = prefab.GetComponent<Animator>();
        }

        if (view is CampView campView)
        {
            campView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();

            Transform area = Util.FindChildRecursive(view.rotationParent, "Area");
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

        if (view is HouseView houseView)
        {
            // Plugin.Log.LogInfo($"Starting houseView");
            BuildingModel templateHouse = BuildingTypes.Lizard_House.ToBuildingModel();
            HouseView templateHouseView = (HouseView)templateHouse.Prefab.BuildingView;
            
            houseView.constructionAnimator = constructionAnimator;
            houseView.animator = prefab.GetComponent<Animator>();
            houseView.planOverlay = prefab.AddComponent<HousePlanOverlay>();
            houseView.noHearthIcon = GameObject.Instantiate(templateHouseView.noHearthIcon, view.uiParent);
            houseView.noHearthIcon.transform.localPosition = new Vector3(0.25f, -1, 0.25f);
            
            houseView.noGoodsIcon = GameObject.Instantiate(templateHouseView.noGoodsIcon, view.uiParent);
            houseView.noGoodsIcon.transform.localPosition = new Vector3(0.25f, -1, 0.25f);
            
            houseView.noBuildersIcon = GameObject.Instantiate(templateHouseView.noBuildersIcon, view.uiParent);
            houseView.noBuildersIcon.transform.localPosition = new Vector3(0.25f, -1, 0.25f);
            // Plugin.Log.LogInfo($"Done houseView");
        }
        
        if (view is WorkshopView workshopView)
        {
            workshopView.constructionAnimator = constructionAnimator;
            workshopView.productonLoopSound = workshopTemplate.view.productonLoopSound;
            workshopView.noWorkersIcon = Util.FindChildRecursive(view.uiParent, "NoWorkersIcon").gameObject;
            workshopView.idleIcon = Util.FindChildRecursive(view.uiParent, "IdleIcon").gameObject;
            workshopView.animator = prefab.GetComponent<Animator>();
            workshopView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();
            workshopView.pressureIcon = GameObject.Instantiate(workshopTemplate.view.pressureIcon, view.uiParent);
            workshopView.pressureIcon.transform.position = Vector3.zero;
            workshopView.pressureIcon.transform.rotation = Quaternion.identity;
        }
        
        if (view is DecorationView decorationView)
        {
            // Plugin.Log.LogInfo($"Starting DecorationView");
            BuildingModel templateDecoration = BuildingTypes.Pipe.ToBuildingModel();
            DecorationView templateDecorationView = (DecorationView)templateDecoration.Prefab.BuildingView;
            
            decorationView.constructionAnimator = constructionAnimator;
            decorationView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();
            
            decorationView.noGoodsIcon = GameObject.Instantiate(templateDecorationView.noGoodsIcon, view.uiParent);
            decorationView.noGoodsIcon.transform.localPosition = new Vector3(0.25f, -1, 0.25f);
            
            decorationView.noBuildersIcon = GameObject.Instantiate(templateDecorationView.noBuildersIcon, view.uiParent);
            decorationView.noBuildersIcon.transform.localPosition = new Vector3(0.25f, -1, 0.25f);
            // Plugin.Log.LogInfo($"Done houseView");
        }

        if (Util.TryFindChildRecursive(prefab.transform, "BuildingDisplayIcon", out SpriteRenderer renderer, false))
        {
            renderer.sprite = displayIcon;
        }
    }

    private static BuildingBlight SetupBlight(GameObject prefab, Transform buildingParent, BlightCyst cystTemplate)
    {
        BuildingBlight blightCyst = prefab.AddComponent<BuildingBlight>();

        List<BlightCyst> cysts = new List<BlightCyst>();
        int children = buildingParent.childCount;
        for (int j = 0; j < children; j++)
        {
            Transform transform = buildingParent.GetChild(j);
            if (transform.name.Contains("Blight Cyst"))
            {
                BlightCyst clone = GameObject.Instantiate(cystTemplate, buildingParent);
                clone.transform.position = transform.position;
                clone.transform.rotation = transform.rotation;
                cysts.Add(clone);

                GameObject.Destroy(transform.gameObject); // Shouldn't break during runtime
            }
        }

        blightCyst.cysts = cysts.ToArray();
        return blightCyst;
    }
}






































