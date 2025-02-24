using System;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;
using Eremite.MapObjects;
using Eremite.Model;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ATS_API.Buildings;

public class NewInstitutionBuildingData : GenericBuildingData<InstitutionModel>
{
    public NewInstitutionBuildingData(string guid, string name, BuildingTypes id, InstitutionModel model, BuildingBehaviourTypes behaviour) : base(guid, name, id, model, behaviour)
    {
    }

    public override void PostSync()
    {
        APILogger.LogDebug($"PostSync for building {BuildingModel.name}");
        
        InstitutionBuildingBuilder.MetaData metaData = (InstitutionBuildingBuilder.MetaData) MetaData;
        if (metaData.Recipes != null || metaData.Builders != null || metaData.RecipeNames != null)
        {
            IEnumerable<InstitutionRecipeModel> recipes = metaData.Recipes ?? new List<InstitutionRecipeModel>();
            IEnumerable<InstitutionRecipeBuilder> builders = metaData.Builders ?? new List<InstitutionRecipeBuilder>();
            IEnumerable<string> recipeNames = metaData.RecipeNames ?? new List<string>();
            BuildingModel.recipes = recipes
                .Concat(recipeNames.Select(a=>a.ToInstitutionRecipeModel()))
                .Concat(builders.Select(a => a.Build()))
                .Where(a=>a != null)
                .ToArray();
        }
        else if (BuildingModel.recipes == null)
        {
            BuildingModel.recipes = new InstitutionRecipeModel[0];
        }

        APILogger.LogDebug($"Setting up workplaces");
        if (metaData.WorkPlaces != null)
        {
            BuildingModel.workplaces = new WorkplaceModel[metaData.WorkPlaces.Count];
            for (int i = 0; i < metaData.WorkPlaces.Count; i++)
            {
                var allowedRaces = metaData.WorkPlaces[i];

                WorkplaceModel workplace = new WorkplaceModel();
                workplace.allowedRaces = new RaceModel[allowedRaces.Length];
                for (int j = 0; j < allowedRaces.Length; j++)
                {
                    workplace.allowedRaces[j] = allowedRaces[j].ToRaceModel();
                }

                BuildingModel.workplaces[i] = workplace;
            }
        }
        else if (BuildingModel.workplaces == null)
        {
            BuildingModel.workplaces = new WorkplaceModel[0];
        }
        
        if (Profession != ProfessionTypes.Unknown)
        {
            BuildingModel.profession = Profession.ToProfessionModel();
        }
        
        APILogger.LogDebug("Setting up activeEffects");
        if (metaData.ActiveEffects != null)
        {
            BuildingModel.activeEffects = metaData.ActiveEffects.Select(effectName=>new InstitutionEffectModel()
            {
                minWorkers = effectName.MinWorkers,
                effect = effectName.Name.ToEffectModel()
            }).Where(a=>a.effect != null).ToArray();
        }
        else if (BuildingModel.activeEffects == null)
        {
            BuildingModel.activeEffects = new InstitutionEffectModel[0];
        }
    }
    
    public static NewInstitutionBuildingData FromModel<T>(T model) where T : InstitutionModel
    {
        NewInstitutionBuildingData buildingData = BuildingManager.NewInstitutions.FirstOrDefault(a => a.BuildingModel == model);
        if (buildingData != null)
        {
            return buildingData;
        }
        
        buildingData = new NewInstitutionBuildingData("", model.name, model.name.ToBuildingTypes(), model, BuildingBehaviourTypes.Institution);
        return buildingData;
    }
}