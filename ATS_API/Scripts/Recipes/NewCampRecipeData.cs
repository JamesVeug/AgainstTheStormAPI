using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewCampRecipeData : ASyncable<CampRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewCampRecipeData FromModel(CampRecipeModel model)
    {
        foreach (NewCampRecipeData recipe in RecipeManager.NewCampRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewCampRecipeData newGood = new NewCampRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}