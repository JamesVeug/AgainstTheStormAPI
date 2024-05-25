using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.MapTools;
using Eremite.View.Utils;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    /// <summary>
    /// NOTE: Only works for Workshop types atm
    /// </summary>
    internal static void InitializePrefab<B, V, M>(GameObject prefab, M buildingModel, Sprite displayIcon, AnimHookType villagerAnimationType = AnimHookType.Construction)
        where B : Building
        where V : BuildingView
        where M : BuildingModel
    {
        Plugin.Log.LogInfo($"Initializing prefab {prefab.name}");
        BuildingModel buildingModelTemplate = BuildingTypes.Workshop.ToBuildingModel();
        Building buildingTemplate = buildingModelTemplate.Prefab;
        Workshop workshopTemplate = buildingModelTemplate.Prefab.GetComponent<Workshop>();
        BlightCyst blightCyst = workshopTemplate.blight.cysts[0];

        // Plugin.Log.LogInfo($"Starting Building");
        B building = prefab.AddComponent<B>();
        building.entrance = Util.Find(prefab.transform, "Entrance");

        // Plugin.Log.LogInfo($"Starting View");
        V view = prefab.AddComponent<V>();
        
        // Plugin.Log.LogInfo($"Starting Scaffolding");
        var constructionAnimator = prefab.AddComponent<ScaffoldingConstructionAnimator>();
        view.constructionAnimator = constructionAnimator;
        constructionAnimator.scaffoldingParent = Util.Find(prefab.transform, "ToRotate");
        constructionAnimator.buildingParent = constructionAnimator.scaffoldingParent.Find("BuildingContainer");
        constructionAnimator.unconstructedPosition = new Vector3(0, -3, 0);
        constructionAnimator.constructedPosition = new Vector3(0, 0, 0);
        constructionAnimator.dustPrefab = buildingTemplate.GetComponent<ScaffoldingConstructionAnimator>().dustPrefab;
        constructionAnimator.scaffoldingPrefab =
            buildingTemplate.GetComponent<ScaffoldingConstructionAnimator>().scaffoldingPrefab;
        constructionAnimator.levels = 3;
        constructionAnimator.scaffoldingRising = new Vector2(0, 0.3f);
        constructionAnimator.buildingRising = new Vector2(0.3f, 0.8f);
        constructionAnimator.scaffoldingRising = new Vector2(0.8f, 1.0f);
        constructionAnimator.scaffoldingRising = new Vector2(0.01f, 0.8f);

        // Plugin.Log.LogInfo($"Starting AnimationsHooks");
        Transform animationsHooks = Util.Find(prefab.transform, "AnimationsHooks");
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

        if (building is Camp camp)
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
                    cyst.animHook = Util.Find(transform, "Cyst Hook");
                    cyst.meshes = cyst.animator.GetComponentsInChildren<Renderer>();
                    cysts.Add(cyst);
                }
            }

            house.blight.cysts = cysts.ToArray();
        }
        else if (building is Workshop workshop)
        {
            // Plugin.Log.LogInfo($"Starting workshop");
            workshop.productionStorage = prefab.AddComponent<BuildingStorage>();
            workshop.ingredientsStorage = prefab.AddComponent<BuildingIngredientsStorage>();
            workshop.model = buildingModel as WorkshopModel;
            workshop.state = new WorkshopState();
            workshop.view = view as WorkshopView;
            workshop.blight = prefab.AddComponent<BuildingBlight>();

            List<BlightCyst> cysts = new List<BlightCyst>();
            int children = constructionAnimator.buildingParent.childCount;
            for (int j = 0; j < children; j++)
            {
                Transform transform = constructionAnimator.buildingParent.GetChild(j);
                if (transform.name.Contains("Blight Cyst"))
                {
                    BlightCyst clone = GameObject.Instantiate(blightCyst, constructionAnimator.buildingParent);
                    clone.transform.position = transform.position;
                    clone.transform.rotation = transform.rotation;
                    cysts.Add(clone);

                    GameObject.Destroy(transform.gameObject); // Shouldn't break during runtime
                }
            }

            workshop.blight.cysts = cysts.ToArray();
        }

        // Plugin.Log.LogInfo($"Starting SpritesLayout");
        view.rotationParent = constructionAnimator.scaffoldingParent;
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
        view.entranceIcon = Util.Find(view.rotationParent, "Entrance").gameObject;
        view.noBuildersIcon = Util.Find(view.uiParent, "NoBuildersIcon").gameObject;
        view.sleepingIcon = Util.Find(view.uiParent, "SleepingIcon").gameObject;
        view.noGoodsIcon = Util.Find(view.uiParent, "NoGoodsIcon").gameObject;
        view.iconsLayout = layout;

        // Plugin.Log.LogInfo($"Starting panelBackgroundSound");
        view.panelBackgroundSound = buildingTemplate.BuildingView.panelBackgroundSound; // TODO: Customize

        // Plugin.Log.LogInfo($"Starting upgradeParts");
        view.upgradeParts = new BuildingUpgradePart[2]; // TODO: Not everything will have tiers
        view.upgradeParts[0] = Util.Find(prefab.transform, "Tier 1").gameObject.AddComponent<BuildingUpgradePart>();
        view.upgradeParts[0].level = 1;
        view.upgradeParts[0].reverseActivation = false;
        view.upgradeParts[0].specificUpgrade = false;
        view.upgradeParts[0].upgradeIndex = 0;
        view.upgradeParts[0].gameObject.SetActive(false);
        
        view.upgradeParts[1] = Util.Find(prefab.transform, "Tier 2").gameObject.AddComponent<BuildingUpgradePart>();
        view.upgradeParts[1].level = 2;
        view.upgradeParts[1].reverseActivation = false;
        view.upgradeParts[1].specificUpgrade = false;
        view.upgradeParts[1].upgradeIndex = 0;
        view.upgradeParts[1].gameObject.SetActive(false);
        

        if (view is ProductionBuildingView productionView)
        {
            // Plugin.Log.LogInfo($"Starting productionView");
            productionView.productonLoopSound = null;
            productionView.noWorkersIcon = Util.Find(view.uiParent, "NoWorkersIcon").gameObject;
            productionView.idleIcon = Util.Find(view.uiParent, "IdleIcon").gameObject;
            productionView.animator = prefab.GetComponent<Animator>();
        }

        if (view is CampView campView)
        {
            campView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();

            Transform area = Util.Find(view.rotationParent, "Area");
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
            // TODO:
            // houseView.blight = prefab.AddComponent<BuildingBlight>();
            // houseView.blight.cysts = new BlightCyst[0];
        }
        
        if (view is WorkshopView workshopView)
        {
            // Plugin.Log.LogInfo($"Starting workshopView 1");
            workshopView.constructionAnimator = constructionAnimator;
            // Plugin.Log.LogInfo($"Starting workshopView 2");
            workshopView.productonLoopSound = workshopTemplate.view.productonLoopSound;
            // Plugin.Log.LogInfo($"Starting workshopView 3");
            workshopView.noWorkersIcon = Util.Find(view.uiParent, "NoWorkersIcon").gameObject;
            // Plugin.Log.LogInfo($"Starting workshopView 4");
            workshopView.idleIcon = Util.Find(view.uiParent, "IdleIcon").gameObject;
            // Plugin.Log.LogInfo($"Starting workshopView 5");
            workshopView.animator = prefab.GetComponent<Animator>();
            // Plugin.Log.LogInfo($"Starting workshopView 6");
            workshopView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();
            // Plugin.Log.LogInfo($"Starting workshopView 7");
            workshopView.pressureIcon = GameObject.Instantiate(workshopTemplate.view.pressureIcon, view.uiParent);
            // Plugin.Log.LogInfo($"Starting workshopView 8");
            workshopView.pressureIcon.transform.position = Vector3.zero;
            // Plugin.Log.LogInfo($"Starting workshopView 9");
            workshopView.pressureIcon.transform.rotation = Quaternion.identity;
            // Plugin.Log.LogInfo($"Starting workshopView 10");
        }


        Util.Find(prefab.transform, "BuildingDisplayIcon").GetComponent<SpriteRenderer>().sprite = displayIcon;
        
        Plugin.Log.LogInfo($"Done!");
    }
}






































