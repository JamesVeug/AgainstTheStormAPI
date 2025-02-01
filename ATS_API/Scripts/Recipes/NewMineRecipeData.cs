using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewMineRecipeData : ASyncable<MineRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewMineRecipeData FromModel(MineRecipeModel model)
    {
        foreach (NewMineRecipeData recipe in RecipeManager.NewMineRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewMineRecipeData newGood = new NewMineRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}