using System.Collections.Generic;
using System.Linq;
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
    public static IReadOnlyList<NewInstitutionRecipeData> NewInstitutionRecipes => s_newInstitutionRecipes;
    public static IReadOnlyList<NewCampRecipeData> NewCampRecipes => s_newCampRecipes;
    public static IReadOnlyList<NewFishingHutRecipeData> NewFishingHutRecipes => s_newFishingHutRecipes;
    public static IReadOnlyList<NewFarmRecipeData> NewFarmRecipes => s_newFarmRecipes;
    public static IReadOnlyList<NewGathererHutRecipeData> NewGathererHutRecipes => s_newGathererHutRecipes;
    public static IReadOnlyList<NewMineRecipeData> NewMineRecipes => s_newMineRecipes;
    public static IReadOnlyList<NewRainCatcherRecipeData> NewRainCatcherRecipes => s_newRainCatcherRecipes;
    public static IReadOnlyList<NewCollectorRecipeData> NewCollectorRecipes => s_newCollectorRecipes;
    
    
    
    
    private static List<NewRecipeData> s_newRecipes = new List<NewRecipeData>();
    private static List<NewWorkshopRecipeData> s_newWorkshopRecipes = new List<NewWorkshopRecipeData>();
    private static List<NewInstitutionRecipeData> s_newInstitutionRecipes = new List<NewInstitutionRecipeData>();
    private static List<NewCampRecipeData> s_newCampRecipes = new List<NewCampRecipeData>();
    private static List<NewFishingHutRecipeData> s_newFishingHutRecipes = new List<NewFishingHutRecipeData>();
    private static List<NewFarmRecipeData> s_newFarmRecipes = new List<NewFarmRecipeData>();
    private static List<NewGathererHutRecipeData> s_newGathererHutRecipes = new List<NewGathererHutRecipeData>();
    private static List<NewMineRecipeData> s_newMineRecipes = new List<NewMineRecipeData>();
    private static List<NewRainCatcherRecipeData> s_newRainCatcherRecipes = new List<NewRainCatcherRecipeData>();
    private static List<NewCollectorRecipeData> s_newCollectorRecipes = new List<NewCollectorRecipeData>();
    
    private static ArraySync<RecipeModel, NewRecipeData> s_recipes = new("New Recipes");
    private static ArraySync<WorkshopRecipeModel, NewWorkshopRecipeData> s_workshopRecipes = new("New Workshop Recipes");
    private static ArraySync<InstitutionRecipeModel, NewInstitutionRecipeData> s_institutionRecipes = new("New Institution Recipes");
    private static ArraySync<CampRecipeModel, NewCampRecipeData> s_campRecipes = new("New Camp Recipes");
    private static ArraySync<FishingHutRecipeModel, NewFishingHutRecipeData> s_fishingHutRecipes = new("New Fishing Hut Recipes");
    private static ArraySync<FarmRecipeModel, NewFarmRecipeData> s_farmRecipes = new("New Farm Recipes");
    private static ArraySync<GathererHutRecipeModel, NewGathererHutRecipeData> s_gathererHutRecipes = new("New Gathering Hut Recipes");
    private static ArraySync<MineRecipeModel, NewMineRecipeData> s_mineRecipes = new("New Mine Recipes");
    private static ArraySync<RainCatcherRecipeModel, NewRainCatcherRecipeData> s_rainCatcherRecipes = new("New Rain Catcher Recipes");
    private static ArraySync<CollectorRecipeModel, NewCollectorRecipeData> s_collectorRecipes = new("New Collector Recipes");
    
    public static INewRecipeData CreateRecipe<T>(string guid, string name) where T : RecipeModel
    {
        T data = ScriptableObject.CreateInstance<T>();
        return AddRecipe(guid, name, data);
    }
    
    public static INewRecipeData AddRecipe<T>(string guid, string name, T model) where T : RecipeModel
    {
        s_dirty = true;
        model.name = guid + "_" + name;

        INewRecipeData data = null;
        if (model is WorkshopRecipeModel workshopRecipeModel)
        {
            APILogger.IsFalse(s_newWorkshopRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding WorkshopRecipeModel with name {model.name} that already exists!");
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
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is InstitutionRecipeModel institutionRecipeModel)
        {
            APILogger.IsFalse(s_newInstitutionRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding InstitutionRecipeModel with name {model.name} that already exists!");
            var item = new NewInstitutionRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = institutionRecipeModel,
            };
            s_newInstitutionRecipes.Add(item);
            
            // Institution also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is CampRecipeModel campRecipeModel)
        {
            APILogger.IsFalse(s_newCampRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding CampRecipeModel with name {model.name} that already exists!");
            var item = new NewCampRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = campRecipeModel,
            };
            s_newCampRecipes.Add(item);
            
            // Camps also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is FishingHutRecipeModel fishingHutRecipeModel)
        {
            APILogger.IsFalse(s_newFishingHutRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding FishingHutRecipeModel with name {model.name} that already exists!");
            var item = new NewFishingHutRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = fishingHutRecipeModel,
            };
            s_newFishingHutRecipes.Add(item);
            
            // FishingHutRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is FarmRecipeModel farmRecipeModel)
        {
            APILogger.IsFalse(s_newFarmRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding FarmRecipeModel with name {model.name} that already exists!");
            var item = new NewFarmRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = farmRecipeModel,
            };
            s_newFarmRecipes.Add(item);
            
            // FarmRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is GathererHutRecipeModel gathererHutRecipeModel)
        {
            APILogger.IsFalse(s_newGathererHutRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding GathererHutRecipeModel with name {model.name} that already exists!");
            var item = new NewGathererHutRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = gathererHutRecipeModel,
            };
            s_newGathererHutRecipes.Add(item);
            
            // GathererHutRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is MineRecipeModel mineRecipeModel)
        {
            APILogger.IsFalse(s_newMineRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding MineRecipeModel with name {model.name} that already exists!");
            var item = new NewMineRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = mineRecipeModel,
            };
            s_newMineRecipes.Add(item);
            
            // MineRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is RainCatcherRecipeModel rainCatcherRecipeModel)
        {
            APILogger.IsFalse(s_newRainCatcherRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RainCatcherRecipeModel with name {model.name} that already exists!");
            var item = new NewRainCatcherRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = rainCatcherRecipeModel,
            };
            s_newRainCatcherRecipes.Add(item);
            
            // RainCatcherRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else if (model is CollectorRecipeModel collectorRecipeModel)
        {
            APILogger.IsFalse(s_newCollectorRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding CollectorRecipeModel with name {model.name} that already exists!");
            var item = new NewCollectorRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = collectorRecipeModel,
            };
            s_newCollectorRecipes.Add(item);
            
            // CollectorRecipeModel also need this... gross copy+paste but will refactor when more recipe types are added
            var basicItem = new NewRecipeData()
            {
                Guid = guid,
                Name = name,
                RecipeModel = model,
            };
            
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
            s_newRecipes.Add(basicItem);
            data = item;
        }
        else
        {
            APILogger.IsFalse(s_newRecipes.Any(a=>a.RecipeModel.name == model.name), $"Adding RecipeModel with name {model.name} that already exists!");
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
        s_institutionRecipes.Sync(ref settings.institutionRecipes, settings.institutionRecipesCache, s_newInstitutionRecipes, a=>a.RecipeModel as InstitutionRecipeModel);
        s_campRecipes.Sync(ref settings.campsRecipes, settings.campsRecipesCache, s_newCampRecipes, a=>a.RecipeModel as CampRecipeModel);
        s_fishingHutRecipes.Sync(ref settings.fishingHutsRecipes, settings.fishingHutsRecipesCache, s_newFishingHutRecipes, a=>a.RecipeModel as FishingHutRecipeModel);
        s_farmRecipes.Sync(ref settings.farmsRecipes, settings.farmsRecipesCache, s_newFarmRecipes, a=>a.RecipeModel as FarmRecipeModel);
        s_gathererHutRecipes.Sync(ref settings.gatherersHutsRecipes, settings.gatherersHutsRecipesCache, s_newGathererHutRecipes, a=>a.RecipeModel as GathererHutRecipeModel);
        s_mineRecipes.Sync(ref settings.minesRecipes, settings.minesRecipesCache, s_newMineRecipes, a=>a.RecipeModel as MineRecipeModel);
        s_rainCatcherRecipes.Sync(ref settings.rainCatchersRecipes, settings.rainCatchersRecipesCache, s_newRainCatcherRecipes, a=>a.RecipeModel as RainCatcherRecipeModel);
        s_collectorRecipes.Sync(ref settings.collectorsRecipes, settings.collectorsRecipesCache, s_newCollectorRecipes, a=>a.RecipeModel as CollectorRecipeModel);
    }
}