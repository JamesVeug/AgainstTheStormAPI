﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.MapTools;
using Eremite.View.Utils;
using UnityEngine;

namespace ATS_API.Buildings;

public partial class BuildingManager
{
    
    private static Dictionary<Vector2Int, BuildingTypes> SimpleConstructionAnimatorBuildings = new Dictionary<Vector2Int, BuildingTypes>
    {
        { new Vector2Int(1, 1), BuildingTypes.Bank },
        { new Vector2Int(2, 1), BuildingTypes.Lore_Tablet_1 },
        { new Vector2Int(1, 2), BuildingTypes.Lore_Tablet_1 },
        { new Vector2Int(2, 2), BuildingTypes.Rain_Totem_Positive },
        { new Vector2Int(1, 3), BuildingTypes.Gate },
        { new Vector2Int(3, 1), BuildingTypes.Gate },
        { new Vector2Int(3, 3), BuildingTypes.Archaeology_Scorpion_Positive },
        { new Vector2Int(4, 4), BuildingTypes.Fishmen_Lighthouse_Positive },
    };
    
    private static Dictionary<Vector2Int, BuildingTypes> ScaffoldingConstructionAnimatorBuildings = new Dictionary<Vector2Int, BuildingTypes>
    {
        { new Vector2Int(1, 1), BuildingTypes.Blightrot_Clone },
        { new Vector2Int(2, 1), BuildingTypes.RewardChest_T2 },
        { new Vector2Int(1, 2), BuildingTypes.RewardChest_T2 },
        { new Vector2Int(2, 2), BuildingTypes.Crude_Workstation },
        { new Vector2Int(2, 3), BuildingTypes.Haunted_Ruined_Cooperage },
        { new Vector2Int(3, 2), BuildingTypes.Haunted_Ruined_Cooperage },
        { new Vector2Int(3, 3), BuildingTypes.Archeology_Office },
        { new Vector2Int(3, 4), BuildingTypes.AncientTemple },
        { new Vector2Int(4, 3), BuildingTypes.AncientTemple },
        { new Vector2Int(4, 4), BuildingTypes.Biome_Perk_Crafter },
        { new Vector2Int(5, 5), BuildingTypes.DebugNode_Marshlands_InfiniteMeat },
        { new Vector2Int(6, 6), BuildingTypes.Seal_High_Diff },
    };
    
    private static BuildingConstructionAnimationData CopySimpleConstructionAnimator(BuildingTypes types)
    {
        SimpleConstructionAnimator template = types.ToBuildingModel().Prefab.SafeGetComponent<SimpleConstructionAnimator>();
        return new BuildingConstructionAnimationData
        {
            SimpleScaffolding = true,
            levels = 1,

            unconstructedPosition = template.unconstructedPosition,
            constructedPosition = template.constructedPosition,
            dustPrefab = template.dustPrefab,

            ScaffoldingPrefab = template.scaffoldingPrefab,
            // ScaffoldingParent
                
            buildingRising = template.buildingRising,
            scaffoldingDropping = template.scaffoldingDropping,
            dustRange = template.dustRange,
            scaffoldingPosition = template.scaffoldingPositon,
            scaffoldingDroppedPosition = template.scaffoldingDroppedPositon,

        };
    }
    
    private static BuildingConstructionAnimationData CopyScaffoldingConstructionAnimator(BuildingTypes types)
    {
        ScaffoldingConstructionAnimator template = types.ToBuildingModel().Prefab.GetComponent<ScaffoldingConstructionAnimator>();
        return new BuildingConstructionAnimationData
        {
            SimpleScaffolding = false,
            
            unconstructedPosition = template.unconstructedPosition,
            constructedPosition = template.constructedPosition,
            dustPrefab = template.dustPrefab,
            
            ScaffoldingPrefab = template.scaffoldingPrefab,
            // ScaffoldingParent
            levels = template.levels,

            scaffoldingRising = template.scaffoldingRising,
            buildingRising = template.buildingRising,
            scaffoldingDropping = template.scaffoldingDropping,
            dustRange = template.dustRange,
        };
    }

    /// <summary>
    /// Build the construction animator for the building
    /// Assume ScaffoldData and all its fields are NOT null 
    /// </summary>
    [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
    private static ConstructionAnimator AddScaffoldingConstructionAnimator(GameObject prefab, BuildingView view, BuildingConstructionAnimationData animationData)
    {
        var constructionAnimator = prefab.AddComponent<ScaffoldingConstructionAnimator>();
        view.constructionAnimator = constructionAnimator;

        Transform toRotate = Util.FindChildRecursive(prefab.transform, "ToRotate");
        constructionAnimator.buildingParent = toRotate.GetChild(0);
        constructionAnimator.unconstructedPosition = animationData.unconstructedPosition.Value;
        constructionAnimator.constructedPosition = animationData.constructedPosition.Value;
        constructionAnimator.dustPrefab = animationData.dustPrefab;
        
        constructionAnimator.scaffoldingPrefab = animationData.ScaffoldingPrefab;
        constructionAnimator.scaffoldingParent = toRotate;
        constructionAnimator.levels = animationData.levels.Value;
        
        constructionAnimator.scaffoldingRising = animationData.scaffoldingRising.Value;
        constructionAnimator.buildingRising = animationData.buildingRising.Value;
        constructionAnimator.scaffoldingDropping = animationData.scaffoldingDropping.Value;
        constructionAnimator.dustRange = animationData.dustRange.Value;
        
        return constructionAnimator;
    }
    
    /// <summary>
    /// Build the construction animator for the building
    /// Assume ScaffoldData and all its fields are NOT null 
    /// </summary>
    [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
    private static ConstructionAnimator AddSimpleConstructionAnimator(GameObject prefab, BuildingView view, BuildingConstructionAnimationData animationData)
    {
        var constructionAnimator = prefab.AddComponent<SimpleConstructionAnimator>();
        view.constructionAnimator = constructionAnimator;
        
        Transform toRotate = Util.FindChildRecursive(prefab.transform, "ToRotate");
        constructionAnimator.buildingParent = toRotate.GetChild(0);
        constructionAnimator.unconstructedPosition = animationData.unconstructedPosition.Value;
        constructionAnimator.constructedPosition = animationData.constructedPosition.Value;
        constructionAnimator.dustPrefab = animationData.dustPrefab;
        
        constructionAnimator.scaffoldingPrefab = animationData.ScaffoldingPrefab;
        constructionAnimator.scaffoldingParent = toRotate;
        
        constructionAnimator.buildingRising = animationData.buildingRising.Value;
        constructionAnimator.scaffoldingDropping = animationData.scaffoldingDropping.Value;
        constructionAnimator.dustRange = animationData.dustRange.Value;
        constructionAnimator.scaffoldingPositon = animationData.scaffoldingPosition.Value;
        constructionAnimator.scaffoldingDroppedPositon = animationData.scaffoldingDroppedPosition.Value;
        
        return constructionAnimator;
    }  
    
    private static BuildingConstructionAnimationData GetScaffoldingData(int width, int height, bool simple)
    {
        Vector2Int size = new Vector2Int(width, height);
        if (simple)
        {
            if (!SimpleConstructionAnimatorBuildings.TryGetValue(size, out BuildingTypes building))
            {
                building = SimpleConstructionAnimatorBuildings[new Vector2Int(1, 1)];
            }
            return CopySimpleConstructionAnimator(building);
        }
        else
        {
            if (!ScaffoldingConstructionAnimatorBuildings.TryGetValue(size, out BuildingTypes building))
            {
                building = ScaffoldingConstructionAnimatorBuildings[new Vector2Int(2, 2)];
            }
            return CopyScaffoldingConstructionAnimator(building);
        }
    }
    
    
    /// <summary>
    /// NOTE: Only works for Workshop types atm
    /// </summary>
    internal static void InitializePrefab<B, V, M>(GameObject prefab, M buildingModel, Sprite displayIcon, BuildingConstructionAnimationData buildingConstructionAnimationData = null, AnimHookType villagerAnimationType = AnimHookType.Construction)
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
        
        // Plugin.Log.LogInfo($"Starting Scaffolding");
        ConstructionAnimator constructionAnimator = AddScaffolding(prefab, buildingModel, buildingConstructionAnimationData, view);

        Transform toRotate = Util.FindChildRecursive(prefab.transform, "ToRotate");
        
        // Plugin.Log.LogInfo($"Starting AnimationsHooks");
        Transform animationsHooks = Util.FindChildRecursive(prefab.transform, "AnimationsHooks", true);
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
            if (building.villagersPositioner.hooks.Length == 0)
            {
                Plugin.Log.LogWarning($"No AnimationHooks found for building {buildingModel.name} and prefab {prefab.name}! Adding temp");
                GameObject newAnimationHook = new GameObject("AnimationHook");
                newAnimationHook.transform.SetParent(animationsHooks.transform);
                newAnimationHook.transform.localPosition = Vector3.zero;
                newAnimationHook.transform.localRotation = Quaternion.identity;
                newAnimationHook.transform.localScale = Vector3.one;
                AnimationHook hook = newAnimationHook.AddComponent<AnimationHook>();
                hook.type = villagerAnimationType;
                
                building.villagersPositioner.hooks = newAnimationHook.GetComponentsInChildren<AnimationHook>();
            }
        }
        else
        {
            Plugin.Log.LogWarning($"No AnimationsHooks found for building {buildingModel.name} and prefab {prefab.name}! Adding temporary!");
            GameObject newAnimationsHooks = new GameObject("AnimationsHooks");
            newAnimationsHooks.transform.SetParent(toRotate.transform);
            
            GameObject newAnimationHook = new GameObject("AnimationHook");
            newAnimationHook.transform.SetParent(newAnimationsHooks.transform);
            newAnimationHook.transform.localPosition = Vector3.zero;
            newAnimationHook.transform.localRotation = Quaternion.identity;
            newAnimationHook.transform.localScale = Vector3.one;
            AnimationHook hook = newAnimationHook.AddComponent<AnimationHook>();
            hook.type = villagerAnimationType;
            
            building.villagersPositioner = newAnimationsHooks.AddComponent<VillagersPositioner>();
        }


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
            // Plugin.Log.LogInfo($"{buildingModel.name} Starting workshop");
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

    private static ConstructionAnimator AddScaffolding(GameObject prefab, BuildingModel buildingModel, BuildingConstructionAnimationData buildingConstructionAnimationData, BuildingView view)
    {
        int maxTileSize = Mathf.Max(buildingModel.size.x, buildingModel.size.y);

        // Get template data in case the data provdided is missing values
        BuildingConstructionAnimationData templateData = null;
        if (maxTileSize == 1)
        {
            if (!SimpleConstructionAnimatorBuildings.TryGetValue(buildingModel.size, out BuildingTypes building))
            {
                building = SimpleConstructionAnimatorBuildings[new Vector2Int(1, 1)];
            }
            templateData = CopySimpleConstructionAnimator(building);
        }
        else
        {
            if (!ScaffoldingConstructionAnimatorBuildings.TryGetValue(buildingModel.size, out BuildingTypes building))
            {
                building = ScaffoldingConstructionAnimatorBuildings[new Vector2Int(2, 2)];
            }
            templateData = CopyScaffoldingConstructionAnimator(building);
        }

        if (buildingConstructionAnimationData == null)
        {
            buildingConstructionAnimationData = templateData;
        }
        else
        {
            // Copy over nulls
            buildingConstructionAnimationData.ReplaceNulls(templateData);
        }

        if (templateData.SimpleScaffolding.HasValue && templateData.SimpleScaffolding.Value)
        {
            return AddSimpleConstructionAnimator(prefab, view, buildingConstructionAnimationData);
        }
        else
        {
            return AddScaffoldingConstructionAnimator(prefab, view, buildingConstructionAnimationData);
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






































