using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;

namespace ATS_API.Buildings;

public class NewWorkshopBuildingData : GenericBuildingData<WorkshopModel>
{
    public NewWorkshopBuildingData(string guid, string name, BuildingTypes id, WorkshopModel model, BuildingBehaviourTypes behaviour) : base(guid, name, id, model, behaviour)
    {
    }

    public override void PostSync()
    {
        APILogger.LogDebug($"PostSync for building {BuildingModel.name}");
        WorkshopBuildingBuilder.MetaData metaData = (WorkshopBuildingBuilder.MetaData) MetaData;
        if (metaData.Recipes != null || metaData.Builders != null || metaData.RecipeNames != null)
        {
            IEnumerable<WorkshopRecipeModel> recipes = metaData.Recipes ?? new List<WorkshopRecipeModel>();
            IEnumerable<WorkshopRecipeBuilder> builders = metaData.Builders ?? new List<WorkshopRecipeBuilder>();
            IEnumerable<string> recipeNames = metaData.RecipeNames ?? new List<string>();
            BuildingModel.recipes = recipes
                .Concat(recipeNames.Select(a=>a.ToWorkshopRecipeModel()))
                .Concat(builders.Select(a => a.Build()))
                .Where(a=>a != null)
                .ToArray();
        }
        else if (BuildingModel.recipes == null)
        {
            BuildingModel.recipes = new WorkshopRecipeModel[0];
        }

        if (Profession != ProfessionTypes.Unknown)
        {
            BuildingModel.profession = Profession.ToProfessionModel();
        }

        if (metaData.WorkPlaces != null)
        {
            BuildingModel.workplaces = new WorkplaceModel[metaData.WorkPlaces.Count];
            for (int i = 0; i < metaData.WorkPlaces.Count; i++)
            {
                var allowedRaces = metaData.WorkPlaces[i];
                WorkplaceModel workplace = allowedRaces.ToWorkplaceModel();
                BuildingModel.workplaces[i] = workplace;
            }
        }
        else if (BuildingModel.workplaces == null)
        {
            BuildingModel.workplaces = new WorkplaceModel[0];
        }

        if (metaData.RainpunkModelType > BuildingRainpunkModelTypes.None)
        {
            BuildingModel.rainpunk = metaData.RainpunkModelType.ToBuildingRainpunkModel();
        }
        
        if (BuildingModel.description == null || BuildingModel.description.key == Placeholders.Description.key)
        {
            if (BuildingModel.rainpunk == null)
            {
                BuildingModel.description = "Building_GenericWorkshop_NoWater_Desc".ToLocaText();
            }
            else
            {
                BuildingModel.description = "Building_GenericWorkshop_Desc".ToLocaText();
            }
        }
    }
    
    public static NewWorkshopBuildingData FromModel<T>(T model) where T : WorkshopModel
    {
        NewWorkshopBuildingData buildingData = BuildingManager.NewWorkshops.FirstOrDefault(a => a.BuildingModel == model);
        if (buildingData != null)
        {
            return buildingData;
        }
        
        buildingData = new NewWorkshopBuildingData("", model.name, model.name.ToBuildingTypes(), model, BuildingBehaviourTypes.Workshop);
        return buildingData;
    }
}