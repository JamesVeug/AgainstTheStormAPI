using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewRainCatcherRecipeData : ASyncable<RainCatcherRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewRainCatcherRecipeData FromModel(RainCatcherRecipeModel model)
    {
        foreach (NewRainCatcherRecipeData recipe in RecipeManager.NewRainCatcherRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewRainCatcherRecipeData newGood = new NewRainCatcherRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}