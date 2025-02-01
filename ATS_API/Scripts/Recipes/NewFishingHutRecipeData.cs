using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewFishingHutRecipeData : ASyncable<FishingHutRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewFishingHutRecipeData FromModel(FishingHutRecipeModel model)
    {
        foreach (NewFishingHutRecipeData recipe in RecipeManager.NewFishingHutRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewFishingHutRecipeData newGood = new NewFishingHutRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}