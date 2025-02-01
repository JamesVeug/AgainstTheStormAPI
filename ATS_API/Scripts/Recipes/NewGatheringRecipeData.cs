using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewGathererHutRecipeData : ASyncable<GathererHutRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewGathererHutRecipeData FromModel(GathererHutRecipeModel model)
    {
        foreach (NewGathererHutRecipeData recipe in RecipeManager.NewGathererHutRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewGathererHutRecipeData newGood = new NewGathererHutRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}