using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewRecipeData : ASyncable<RecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }
}