using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewWorkshopRecipeData : ASyncable<WorkshopRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewWorkshopRecipeData FromModel(WorkshopRecipeModel model)
    {
        foreach (NewWorkshopRecipeData recipe in RecipeManager.NewWorkshopRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewWorkshopRecipeData newGood = new NewWorkshopRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}