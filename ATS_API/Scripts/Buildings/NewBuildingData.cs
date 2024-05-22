using System;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Buildings;

public class NewBuildingData : ASyncable<BuildingModel>
{
    public string Guid;
    public string Name;
    public BuildingModel BuildingModel;
    public BuildingVisualData VisualData;
    public BuildingBehaviourTypes Behaviour;
    public object MetaData;
    public List<NameToAmount> RequiredGoods = new List<NameToAmount>();
    public NameToAmount MoveCost;
    public ProfessionTypes Profession;
    public BuildingCategoriesTypes Category = BuildingCategoriesTypes.Industry;
    public List<TagTypes> UsabilityTags = new List<TagTypes>();
    public List<BuildingTagTypes> Tags = new List<BuildingTagTypes>();

    public override void Sync(BuildingModel model)
    {
        base.Sync(model);

        SetupPrefab();
    }

    private void SetupPrefab()
    {
        if (VisualData.Prefab != null)
        {
            return;
        }

        if (MoveCost != null)
        {
            BuildingModel.movingCost = new GoodRef()
            {
                good = MoveCost.Name.ToGoodsModel(),
                amount = MoveCost.Amount
            };
        }
        
        if (RequiredGoods.Count > 0)
        {
            BuildingModel.requiredGoods = RequiredGoods.Select(a => new GoodRef()
            {
                good = a.Name.ToGoodsModel(),
                amount = a.Amount
            }).ToArray();
        }
        
        if (UsabilityTags.Count > 0)
        {
            BuildingModel.usabilityTags = UsabilityTags.Select(a => a.ToTagModel()).ToArray();
        }
        
        if (Tags.Count > 0)
        {
            BuildingModel.tags = Tags.Select(a => a.ToBuildingTagModel()).ToArray();
        }
        
        BuildingModel.category = Category.ToBuildingCategoryModel();
  
        if (Behaviour == BuildingBehaviourTypes.Workshop)
        {
            WorkshopBuildingBuilder.MetaData metaData = (WorkshopBuildingBuilder.MetaData) MetaData;
            
            // Visuals
            GameObject prefab = BuildingManager.GetDefaultVisualData(Behaviour, VisualData.Icon);
            try
            {
                BuildingManager.InitializePrefab<Workshop, WorkshopView, WorkshopModel>(prefab, BuildingModel as WorkshopModel, VisualData.Icon, AnimHookType.Construction);
            }catch (Exception e)
            {
                Debug.LogError(e);
            }

            Workshop workshop = prefab.GetComponent<Workshop>();
            VisualData.Prefab = workshop;
        
            // Data
            WorkshopModel workshopModel = BuildingModel as WorkshopModel;
            workshopModel.prefab = workshop;
            workshopModel.recipes = metaData.Recipes.Concat(metaData.Builders.Select(a=>a.Build())).ToArray();
            workshopModel.profession = Profession.ToProfessionModel();

            workshopModel.workplaces = new WorkplaceModel[metaData.WorkPlaces.Count];
            for (int i = 0; i < metaData.WorkPlaces.Count; i++)
            {
                var allowedRaces = metaData.WorkPlaces[i];
                
                WorkplaceModel workplace = new WorkplaceModel();
                workplace.allowedRaces = new RaceModel[allowedRaces.Length];
                for (int j = 0; j < allowedRaces.Length; j++)
                {
                    workplace.allowedRaces[j] = allowedRaces[j].ToRaceModel();
                }
                workshopModel.workplaces[i] = workplace;
            }
        }
        else
        {
            throw new NotImplementedException($"Building type {Behaviour} not implemented yet!");
        }
    }
}