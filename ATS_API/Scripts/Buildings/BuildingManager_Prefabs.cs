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
        // Plugin.Log.LogInfo($"Initializing prefab {prefab.name} as {typeof(B).Name} with {typeof(V).Name} and {typeof(M).Name}");
        BuildingModel buildingModelTemplate = BuildingTypes.Workshop.ToBuildingModel();
        Building buildingTemplate = buildingModelTemplate.Prefab;
        Workshop workshopTemplate = buildingModelTemplate.Prefab.GetComponent<Workshop>();
        BlightCyst blightCyst = workshopTemplate.blight.cysts[0];

        // Plugin.Log.LogInfo($"Starting Building");
        B building = prefab.AddComponent<B>();
        building.entrance = Util.FindChild(prefab.transform, "Entrance");

        // Plugin.Log.LogInfo($"Starting View");
        V view = prefab.AddComponent<V>();
        
        // Plugin.Log.LogInfo($"Starting Scaffolding");
        var constructionAnimator = prefab.AddComponent<ScaffoldingConstructionAnimator>();
        view.constructionAnimator = constructionAnimator;
        constructionAnimator.scaffoldingParent = Util.FindChild(prefab.transform, "ToRotate");
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
        Transform animationsHooks = Util.FindChild(prefab.transform, "AnimationsHooks");
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
            // Plugin.Log.LogInfo($"Start house");
            house.state = new HouseState();
            house.model = buildingModel as HouseModel;
            house.view = view as HouseView;
            house.blight = SetupBlight(prefab, constructionAnimator, blightCyst);
            house.model.cystsAmount = house.blight.cysts.Length;
            Plugin.Log.LogInfo($"Done house");
        }
        else if (building is Workshop workshop)
        {
            // Plugin.Log.LogInfo($"Starting workshop");
            workshop.productionStorage = prefab.AddComponent<BuildingStorage>();
            workshop.ingredientsStorage = prefab.AddComponent<BuildingIngredientsStorage>();
            workshop.model = buildingModel as WorkshopModel;
            workshop.state = new WorkshopState();
            workshop.view = view as WorkshopView;
            workshop.blight = SetupBlight(prefab, constructionAnimator, blightCyst);
            workshop.model.cystsAmount = workshop.blight.cysts.Length;
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
        view.entranceIcon = Util.FindChild(view.rotationParent, "Entrance").gameObject;
        view.noBuildersIcon = Util.FindChild(view.uiParent, "NoBuildersIcon").gameObject;
        view.sleepingIcon = Util.FindChild(view.uiParent, "SleepingIcon").gameObject;
        view.noGoodsIcon = Util.FindChild(view.uiParent, "NoGoodsIcon").gameObject;
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
            productionView.noWorkersIcon = Util.FindChild(view.uiParent, "NoWorkersIcon").gameObject;
            productionView.idleIcon = Util.FindChild(view.uiParent, "IdleIcon").gameObject;
            productionView.animator = prefab.GetComponent<Animator>();
        }

        if (view is CampView campView)
        {
            campView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();

            Transform area = Util.FindChild(view.rotationParent, "Area");
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
            houseView.constructionAnimator = constructionAnimator;
            houseView.animator = prefab.GetComponent<Animator>();
            houseView.planOverlay = prefab.AddComponent<HousePlanOverlay>();
            // Plugin.Log.LogInfo($"Done houseView");
        }
        
        if (view is WorkshopView workshopView)
        {
            workshopView.constructionAnimator = constructionAnimator;
            workshopView.productonLoopSound = workshopTemplate.view.productonLoopSound;
            workshopView.noWorkersIcon = Util.FindChild(view.uiParent, "NoWorkersIcon").gameObject;
            workshopView.idleIcon = Util.FindChild(view.uiParent, "IdleIcon").gameObject;
            workshopView.animator = prefab.GetComponent<Animator>();
            workshopView.planOverlay = prefab.AddComponent<SimplePlanOverlay>();
            workshopView.pressureIcon = GameObject.Instantiate(workshopTemplate.view.pressureIcon, view.uiParent);
            workshopView.pressureIcon.transform.position = Vector3.zero;
            workshopView.pressureIcon.transform.rotation = Quaternion.identity;
        }

        if (Util.TryFindChild(prefab.transform, "BuildingDisplayIcon", out SpriteRenderer renderer, false))
        {
            renderer.sprite = displayIcon;
        }
        
        Plugin.Log.LogInfo($"Done!");
    }

    private static BuildingBlight SetupBlight(GameObject prefab, ScaffoldingConstructionAnimator constructionAnimator, BlightCyst cystTemplate)
    {
        BuildingBlight blightCyst = prefab.AddComponent<BuildingBlight>();

        List<BlightCyst> cysts = new List<BlightCyst>();
        int children = constructionAnimator.buildingParent.childCount;
        for (int j = 0; j < children; j++)
        {
            Transform transform = constructionAnimator.buildingParent.GetChild(j);
            if (transform.name.Contains("Blight Cyst"))
            {
                BlightCyst clone = GameObject.Instantiate(cystTemplate, constructionAnimator.buildingParent);
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






































