using Eremite.Buildings;

namespace ATS_API.Recipes;

public interface INewRecipeData
{
    public string Guid { get; }
    public string Name { get; }
    public RecipeModel RecipeModel { get; }
}