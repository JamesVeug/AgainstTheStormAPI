using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;


namespace ATS_API.Buildings;

public class WorkshopBuildingBuilder : BuildingBuilder<WorkshopModel>
{
    public class MetaData
    {
        public List<WorkshopRecipeBuilder> Builders = new List<WorkshopRecipeBuilder>();
        public List<WorkshopRecipeModel> Recipes = new List<WorkshopRecipeModel>();
        public List<RaceTypes[]> WorkPlaces = new List<RaceTypes[]>();
    }

    private MetaData metaData;
    
    public WorkshopBuildingBuilder(string guid, string name, string iconPath) : base(guid, name, BuildingBehaviourTypes.Workshop, iconPath)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.Industry;
        
        // Set Category to Housing
        // Set label to Housing
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
    }
    
    public WorkshopRecipeBuilder CreateRecipe(GoodsTypes good, int amount, int productionTime, Grade grade)
    {
        return CreateRecipe(good.ToString(), amount, productionTime, grade);
    }
    
    public WorkshopRecipeBuilder CreateRecipe(string good, int amount, int productionTime, Grade grade)
    {
        WorkshopRecipeBuilder recipeBuilder = new WorkshopRecipeBuilder(GUID, Name + "_" + good, good, amount, productionTime, grade);
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }
    
    public WorkshopRecipeBuilder AddRecipe(WorkshopRecipeBuilder recipeBuilder)
    {
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }

    public void AddRecipe(WorkshopRecipeModel recipe)
    {
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

        metaData.WorkPlaces.Add(races);
    }
    
    public void AddWorkPlace(RaceTypes race)
    {
        metaData.WorkPlaces.Add([race]);
    }
    
    public void AddWorkPlace(params RaceTypes[] races)
    {
        metaData.WorkPlaces.Add(races);
    }
    
    public void SetProfession(ProfessionTypes profession)
    {
        m_newData.Profession = profession;
    }
}