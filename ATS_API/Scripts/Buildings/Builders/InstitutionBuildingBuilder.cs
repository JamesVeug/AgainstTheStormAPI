using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using ATS_API.Recipes.Builders;
using Eremite.Buildings;


namespace ATS_API.Buildings;

public class InstitutionBuildingBuilder : BuildingBuilder<InstitutionModel, NewInstitutionBuildingData>
{
    public class MetaData
    {
        public class ActiveEffect
        {
            public string Name;
            public int MinWorkers;
        }
        
        public List<RaceTypes[]> WorkPlaces = null;
        public List<InstitutionRecipeBuilder> Builders = null;
        public List<InstitutionRecipeModel> Recipes;
        public List<string> RecipeNames;
        public List<ActiveEffect> ActiveEffects;
    }

    private MetaData metaData;

    
    protected override NewInstitutionBuildingData CreateNewData(string guid, string name)
    {
        return BuildingManager.CreateInstitution(guid, name);
    }

    protected override NewInstitutionBuildingData GetNewData(InstitutionModel model)
    {
        return NewInstitutionBuildingData.FromModel(model);
    }

    public InstitutionBuildingBuilder(InstitutionModel model) : base(model)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Behaviour = BuildingBehaviourTypes.Institution;
        m_newData.BuildingModel.description = Keys.Building_GenericInstitution_Desc.ToLocaText();
    }

    public InstitutionBuildingBuilder(string guid, string name, string iconPath) : base(guid, name, iconPath)
    {
        metaData = new MetaData();
        m_newData.MetaData = metaData;
        m_newData.Category = BuildingCategoriesTypes.City_Buildings;
        m_newData.BuildingModel.description = Keys.Building_GenericInstitution_Desc.ToLocaText();

        m_buildingModel.displayLabel = Keys.ServiceBuilding.ToLabelModel();
        m_buildingModel.levels = [];
        m_buildingModel.cystsAmount = 3;
        m_buildingModel.maxSpacePerIngredient = 10;
    }

    public void SetProfession(ProfessionTypes profession)
    {
        m_newData.Profession = profession;
    }

    public InstitutionRecipeBuilder CreateRecipe(NeedTypes need)
    {
        return CreateRecipe(need.ToName());
    }

    public InstitutionRecipeBuilder CreateRecipe(string need)
    {
        InstitutionRecipeBuilder recipeBuilder = new InstitutionRecipeBuilder(GUID, Name + "_" + need, need);
        metaData.Builders ??= new List<InstitutionRecipeBuilder>();
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }

    public InstitutionRecipeBuilder AddRecipe(InstitutionRecipeBuilder recipeBuilder)
    {
        metaData.Builders ??= new List<InstitutionRecipeBuilder>();
        metaData.Builders.Add(recipeBuilder);
        return recipeBuilder;
    }

    public InstitutionBuildingBuilder AddRecipe(InstitutionRecipeModel recipe)
    {
        metaData.Recipes ??= new List<InstitutionRecipeModel>();
        metaData.Recipes.Add(recipe);
        return this;
    }
    
    public InstitutionBuildingBuilder AddRecipe(string recipe)
    {
        metaData.RecipeNames ??= new List<string>();
        metaData.RecipeNames.Add(recipe);
        return this;
    }
    
    public InstitutionBuildingBuilder AddRecipe(InstitutionRecipeTypes recipeType)
    {
        metaData.RecipeNames ??= new List<string>();
        metaData.RecipeNames.Add(recipeType.ToName());
        return this;
    }

    public InstitutionBuildingBuilder AddWorkPlaceWithAllRaces()
    {
        RaceTypes[] races = new RaceTypes[(int)RaceTypes.MAX - 1];
        int j = 0;
        for (int i = (int)RaceTypes.None + 1; i < (int)RaceTypes.MAX; i++)
        {
            races[j++] = (RaceTypes)i;
        }

        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add(races);
        return this;
    }

    public InstitutionBuildingBuilder AddWorkPlace(RaceTypes race)
    {
        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add([race]);
        return this;
    }

    public InstitutionBuildingBuilder AddWorkPlace(params RaceTypes[] races)
    {
        metaData.WorkPlaces ??= new List<RaceTypes[]>();
        metaData.WorkPlaces.Add(races);
        return this;
    }

    public InstitutionBuildingBuilder AddActiveEffect(EffectTypes types, int minWorkers)
    {
        metaData.ActiveEffects ??= new List<MetaData.ActiveEffect>();
        metaData.ActiveEffects.Add(new MetaData.ActiveEffect()
        {
            Name = types.ToName(),
            MinWorkers = minWorkers
        });
        return this;
    }
    
    public InstitutionBuildingBuilder AddActiveEffect(string types)
    {
        metaData.ActiveEffects ??= new List<MetaData.ActiveEffect>();
        metaData.ActiveEffects.Add(new MetaData.ActiveEffect()
        {
            Name = types,
            MinWorkers = 1
        });
        return this;
    }
    
    
}