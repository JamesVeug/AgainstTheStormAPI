using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ATS_API.Recipes;

public static partial class RecipeManager
{
    [Obsolete("Use NewRecipes instead")]
    public static IReadOnlyList<NewRecipeData> NewBuildings => s_newRecipes;

    [Obsolete("Use NewWorkshopRecipes instead")]
    public static IReadOnlyList<NewWorkshopRecipeData> NewWorkshopBuildings => s_newWorkshopRecipes;
}