using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewCollectorRecipeData : ASyncable<CollectorRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewCollectorRecipeData FromModel(CollectorRecipeModel model)
    {
        foreach (NewCollectorRecipeData recipe in RecipeManager.NewCollectorRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewCollectorRecipeData newGood = new NewCollectorRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}