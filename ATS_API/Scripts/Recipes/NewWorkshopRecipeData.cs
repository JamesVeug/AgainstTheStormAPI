using Eremite.Buildings;

namespace ATS_API.Recipes;

public class NewWorkshopRecipeData : ASyncable<WorkshopRecipeModel>, INewRecipeData
{
    public string Guid { get; set; }
    public string Name { get; set; }
    public RecipeModel RecipeModel { get; set; }
}