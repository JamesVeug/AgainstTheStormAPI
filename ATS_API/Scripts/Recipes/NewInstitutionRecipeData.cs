using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewInstitutionRecipeData : ASyncable<InstitutionRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }

    public static NewInstitutionRecipeData FromModel(InstitutionRecipeModel model)
    {
        foreach (NewInstitutionRecipeData recipe in RecipeManager.NewInstitutionRecipes)
        {
            if (recipe.RecipeModel == model)
            {
                return recipe;
            }
        }
        
        NewInstitutionRecipeData newGood = new NewInstitutionRecipeData();
        newGood.RecipeModel = model;
        newGood.Name = model.name;
        

        return newGood;
    }
}