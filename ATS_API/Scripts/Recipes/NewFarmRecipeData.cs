using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewFarmRecipeData : ASyncable<FarmRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewFarmRecipeData FromModel(FarmRecipeModel model)
    {
        foreach (NewFarmRecipeData recipe in RecipeManager.NewFarmRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewFarmRecipeData newGood = new NewFarmRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}