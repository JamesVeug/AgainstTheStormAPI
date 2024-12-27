using System;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.Model;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API.Buildings;

public class NewBuildingData : GenericBuildingData<BuildingModel>
{
    public NewBuildingData(string guid, string name, BuildingTypes id, BuildingModel model, BuildingBehaviourTypes behaviour) : base(guid, name, id, model, behaviour)
    {
    }

    public override bool Sync()
    {
        // return base.Sync();
        return true;
    }

    public override void PostSync()
    {
        // base.PostSync();
    }
}

public interface IBuildingData
{
    bool Sync();
    void PostSync();
}

public class GenericBuildingData<T> : ASyncable<T>, IBuildingData where T : BuildingModel
{
    public string Guid;
    public string Name;
    public BuildingTypes ID;
    public BuildingTagTypes Tag;
    public T BuildingModel;
    public BuildingVisualData VisualData;
    public BuildingBehaviourTypes Behaviour;
    public object MetaData;
    public List<NameToAmount> RequiredGoods = new List<NameToAmount>();
    public NameToAmount MoveCost = (0, GoodsTypes.Mat_Raw_Wood.ToName());
    public ProfessionTypes Profession = ProfessionTypes.Unknown;
    public BuildingCategoriesTypes Category = BuildingCategoriesTypes.Unknown;
    public List<TagTypes> UsabilityTags = new List<TagTypes>();
    public List<BuildingTagTypes> Tags = new List<BuildingTagTypes>();
    public GameObject CustomPrefab;
    public BuildingConstructionAnimationData BuildingConstructionAnimationData;

    public GenericBuildingData(string guid, string name, BuildingTypes id, T model, BuildingBehaviourTypes behaviour)
    {
        Guid = guid;
        Name = name;
        ID = id;
        BuildingModel = model;
        VisualData = null;
        Behaviour = behaviour;
    }

    public override bool Sync()
    {
        APILogger.LogDebug($"Syncing building of type {typeof(T).Name}: {Name}");
        if (MoveCost != null)
        {
            BuildingModel.movingCost = new GoodRef()
            {
                good = MoveCost.Name.ToGoodModel(),
                amount = MoveCost.Amount
            };
        }
        
        if (RequiredGoods.Count > 0)
        {
            BuildingModel.requiredGoods = RequiredGoods.Select(a => new GoodRef()
            {
                good = a.Name.ToGoodModel(),
                amount = a.Amount
            }).ToArray();
        }
        
        if (UsabilityTags.Count > 0)
        {
            BuildingModel.usabilityTags = UsabilityTags.ToModelTagArrayNoNulls();
        }
        
        BuildingModel.tags = new List<BuildingTagTypes>(){Tag}.Concat(Tags).Distinct().ToBuildingTagModelArrayNoNulls();
        APILogger.LogDebug($"Building {Name} has tags: {string.Join(", ", BuildingModel.tags.Select(a=>a.name))}");

        if (Category != BuildingCategoriesTypes.Unknown)
        {
            BuildingModel.category = Category.ToBuildingCategoryModel();
        }

        try
        {
            return SetupPrefab();
        } 
        catch (Exception e)
        {
            Debug.LogError($"Error while setting up prefab for building {BuildingModel.name} and behaviour {Behaviour}");
            Debug.LogError(e);
            return false;
        }
    }

    private bool SetupPrefab()
    {
        if (VisualData == null)
        {
            // No visuals to setup
            if (BuildingModel.Prefab == null)
            {
                APILogger.LogError($"Building {BuildingModel.name} has no prefab and no visuals to setup!");
                return false;
            }
            
            return true;
        }
        
        if (VisualData.Prefab != null)
        {
            // Already setup????
            return true;
        }
  
        APILogger.LogInfo($"Setting up prefab for building {BuildingModel.name} and behaviour {Behaviour}");
        GameObject prefab = CustomPrefab == null ? BuildingManager.GetDefaultVisualData(Behaviour, VisualData.Icon) : CustomPrefab;
        if (prefab == null)
        {
            APILogger.LogError($"Custom prefab for building {BuildingModel.name} is null! Has Custom prefab: {CustomPrefab != null}");
            return false;
        }
        
        GameObject root = Object.Instantiate(prefab, BuildingManager.PrefabContainer);
        if (Behaviour == BuildingBehaviourTypes.Workshop)
        {
            if (BuildingModel is not WorkshopModel workshopModel)
            {
                APILogger.LogError($"Building {BuildingModel.name} is not a WorkshopModel!");
                return false;
            }
            APILogger.LogInfo($"Setting up prefab for workshop {BuildingModel.name}");
            
            // Visuals
            try
            {
                APILogger.LogInfo($"Initializing prefab for workshop {BuildingModel.name}");
                BuildingManager.InitializePrefab<Workshop, WorkshopView, WorkshopModel>(root, workshopModel, VisualData.Icon, BuildingConstructionAnimationData, AnimHookType.Construction);
            } 
            catch (Exception e)
            {
                Debug.LogError($"Could not set up prefab for building {BuildingModel.name} and behaviour {Behaviour}");
                Debug.LogError(e);
                return false;
            }

            APILogger.LogInfo($"Prefab initialized for {BuildingModel.name} is root null? {root == null} is VisualData null? {VisualData == null} is MetaData null? {MetaData == null}");
            Workshop workshop = root.GetComponent<Workshop>();
            VisualData.Prefab = workshop;
        
            // Data
            APILogger.LogInfo($"Setting up prefab for workshop {BuildingModel.name}");
            workshopModel.prefab = workshop;
        }
        else if (Behaviour == BuildingBehaviourTypes.House)
        {
            HouseModel houseModel = BuildingModel as HouseModel;
            
            // Visuals
            try
            {
                BuildingManager.InitializePrefab<House, HouseView, HouseModel>(root, houseModel, VisualData.Icon, BuildingConstructionAnimationData, AnimHookType.Construction);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }

            House house = root.GetComponent<House>();
            VisualData.Prefab = house;
         
            // Data
            houseModel.prefab = house;
        }
        else if (Behaviour == BuildingBehaviourTypes.Decoration)
        {
            DecorationModel decorationModel = BuildingModel as DecorationModel;
            
            // Visuals
            try
            {
                BuildingManager.InitializePrefab<Decoration, DecorationView, DecorationModel>(root, decorationModel, VisualData.Icon, BuildingConstructionAnimationData, AnimHookType.Construction);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }

            Decoration decoration = root.GetComponent<Decoration>();
            VisualData.Prefab = decoration;
        
            // Data
            decorationModel.prefab = decoration;
            decoration.model = decorationModel;
        }
        else if (Behaviour == BuildingBehaviourTypes.Institution)
        {
            if (BuildingModel is not InstitutionModel institutionModel)
            {
                APILogger.LogError($"Building {BuildingModel.name} is not a InstitutionModel!");
                return false;
            }
            APILogger.LogInfo($"Setting up prefab for service {BuildingModel.name}");
            
            // Visuals
            try
            {
                APILogger.LogInfo($"Initializing prefab for service {BuildingModel.name}");
                BuildingManager.InitializePrefab<Institution, InstitutionView, InstitutionModel>(root, institutionModel, VisualData.Icon, BuildingConstructionAnimationData, AnimHookType.Construction);
            } 
            catch (Exception e)
            {
                Debug.LogError($"Could not set up prefab for building {BuildingModel.name} and behaviour {Behaviour}");
                Debug.LogError(e);
                return false;
            }

            APILogger.LogInfo($"Prefab initialized for {BuildingModel.name} is root null? {root == null} is VisualData null? {VisualData == null} is MetaData null? {MetaData == null}");
            Institution institution = root.GetComponent<Institution>();
            VisualData.Prefab = institution;
        
            // Data
            APILogger.LogInfo($"Setting up prefab for service {BuildingModel.name}");
            institutionModel.prefab = institution;
        }
        else
        { 
            APILogger.LogError($"Building type {Behaviour} for buildings not implemented yet!");
            return false;
        }

        return true;
    }
}