using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Recipes;

public static partial class RecipeManager
{
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    
    public static IReadOnlyList<NewRecipeData> NewRecipes => s_newRecipes;
    public static IReadOnlyList<NewWorkshopRecipeData> NewWorkshopRecipes => s_newWorkshopRecipes;
    
    
    private static List<NewRecipeData> s_newRecipes = new List<NewRecipeData>();
    private static List<NewWorkshopRecipeData> s_newWorkshopRecipes = new List<NewWorkshopRecipeData>();
    
    private static ArraySync<RecipeModel, NewRecipeData> s_recipes = new("New Recipes");
    private static ArraySync<WorkshopRecipeModel, NewWorkshopRecipeData> s_workshopRecipes = new("New Workshop Recipes");
    
    public static INewRecipeData CreateRecipe<T>(string guid, string name) where T : RecipeModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        data.name = guid + "_" + name;
        
        return AddRecipe(guid, data.name, data);
    }
    
    public static INewRecipeData AddRecipe<T>(string guid, string name, T model) where T : RecipeModel
    {
        s_dirty = true;


        INewRecipeData data = null;
        if (model is WorkshopRecipeModel workshopRecipeModel)
        {
            var item = new NewWorkshopRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = workshopRecipeModel,
            };
            s_newWorkshopRecipes.Add(item);
            
            // Workshops also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else
        {
            var item = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            data = item;
            s_newRecipes.Add(item);
        }

        APILogger.LogInfo($"Added new recipe {name} with guid {guid} name: {(model == null ? "null" : model.name)}");
        
        return data;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;

        SyncRecipes();
    }

    public static void Tick()
    {
        if (s_dirty)
        {
            SyncRecipes();
        }
    }

    public static void SetDirty()
    {
        s_dirty = true;
    }

    public static void SyncRecipes()
    {
        if (!s_instantiated)
        {
            return;
        }

        s_dirty = false;
        
        Settings settings = SO.Settings;
        s_recipes.Sync(ref settings.recipes, settings.recipesCache, s_newRecipes, a=>a.RecipeModel);
        s_workshopRecipes.Sync(ref settings.workshopsRecipes, settings.workshopsRecipesCache, s_newWorkshopRecipes, a=>a.RecipeModel as WorkshopRecipeModel);
    }
}