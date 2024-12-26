using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;


namespace ATS_API.Buildings;

public class WorkshopBuildingBuilder : BuildingBuilder<WorkshopModel>
{
    public class MetaData
    {
        public List<WorkshopRecipeBuilder> Builders = null;
        public List<WorkshopRecipeModel> Recipes = null;
        public List<string> RecipeNames = null;
        public List<RaceTypes[]> WorkPlaces = null;
    }

    private MetaData metaData;
    
    
    public WorkshopBuildingBuilder(WorkshopModel model) : base(model)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Behaviour = BuildingBehaviourTypes.Workshop;
    }
    
    public WorkshopBuildingBuilder(string guid, string name, string iconPath) : base(guid, name, BuildingBehaviourTypes.Workshop, iconPath)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Industry;
        
        m_buildingModel.displayLabel = Keys.ProductionBuilding.ToLabelModel();
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
    }
    
    public WorkshopRecipeBuilder CreateRecipe(GoodsTypes good, int amount, int productionTime, Grade grade)
    {
        return CreateRecipe(good.ToName(), amount, productionTime, grade);
    }
    
    public WorkshopRecipeBuilder CreateRecipe(string good, int amount, int productionTime, Grade grade)
    {
        WorkshopRecipeBuilder recipeBuilder = new WorkshopRecipeBuilder(GUID, Name + "_" + good, good, amount, productionTime, grade);
        metaData.Builders ??= new List<WorkshopRecipeBuilder>();
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }
    
    public WorkshopRecipeBuilder AddRecipe(WorkshopRecipeBuilder recipeBuilder)
    {
        metaData.Builders ??= new List<WorkshopRecipeBuilder>();
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }
    
    public WorkshopBuildingBuilder AddRecipe(string recipeName)
    {
        metaData.RecipeNames ??= new List<string>();
        metaData.RecipeNames.Add(recipeName);
        return this;
    }
    
    public WorkshopBuildingBuilder AddRecipe(WorkshopsRecipeTypes recipeType)
    {
        metaData.RecipeNames ??= new List<string>();
        metaData.RecipeNames.Add(recipeType.ToName());
        return this;
    }

    public void AddRecipe(WorkshopRecipeModel recipe)
    {
        metaData.Recipes ??= new List<WorkshopRecipeModel>();
        metaData.Recipes.Add(recipe);
    }
    
    public void AddWorkPlaceWithAllRaces()
    {
        RaceTypes[] races = new RaceTypes[(int)RaceTypes.MAX - 1];
        int j = 0;
        for (int i = (int)RaceTypes.None + 1; i < (int)RaceTypes.MAX; i++)
        {
            races[j++] = (RaceTypes)i;
        }

        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add(races);
    }
    
    public void AddWorkPlace(RaceTypes race)
    {
        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add([race]);
    }
    
    public void AddWorkPlace(params RaceTypes[] races)
    {
        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add(races);
    }
    
    public void SetProfession(ProfessionTypes profession)
    {
        m_newData.Profession = profession;
    }
}