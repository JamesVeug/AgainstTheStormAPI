using ATS_API.Buildings;
using ATS_API.Helpers;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateBuildings()
    {
        var burgerJoint = new WorkshopBuildingBuilder(PluginInfo.PLUGIN_GUID, "BurgerJoint", "BurgerJoint.png");
        burgerJoint.SetDefaultVisualIcon("BurgerJointDisplayIcon.png");
        burgerJoint.SetDisplayName("Borgor King");
        burgerJoint.SetDescription("The best Borgors in town!");
        burgerJoint.SetLabel("Fast Food");
        burgerJoint.SetMoveCost(1, GoodsTypes.Valuable_Amber); // optional
        burgerJoint.SetProfession(ProfessionTypes.Cook);
        burgerJoint.SetCategory(BuildingCategoriesTypes.Industry);
        burgerJoint.AddTags(BuildingTagTypes.Animals);
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        
        var burgerRecipes = burgerJoint.CreateRecipe(burger.Name, 2, 126, Grade.One);
        burgerRecipes.AddTags(TagTypes.FoodTag);
        burgerRecipes.AddRequiredIngredients((2, GoodsTypes.FoodProcessed_Jerky), (1, GoodsTypes.FoodProcessed_Skewers), (4, GoodsTypes.FoodRaw_Insects));
        burgerRecipes.AddRequiredIngredients((1, GoodsTypes.FoodRaw_Vegetables), (1, GoodsTypes.FoodRaw_Mushrooms), (2, GoodsTypes.FoodRaw_Eggs));
        burgerRecipes.AddRequiredIngredients((5, GoodsTypes.Water_ClearanceWater), (5, GoodsTypes.Water_DrizzleWater), (5, GoodsTypes.Water_StormWater));
        
        var friesRecipe = burgerJoint.CreateRecipe(fries.Name, 10, 60, Grade.One);
        friesRecipe.AddTags(TagTypes.FoodTag);
        friesRecipe.AddRequiredIngredients((1, GoodsTypes.Packs_PackOfCrops));
        
        var colaRecipe = burgerJoint.CreateRecipe(cola.Name, 1, 30, Grade.One);
        colaRecipe.AddTags(TagTypes.FoodTag);
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.Water_DrizzleWater));
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.Water_StormWater));
    }
}