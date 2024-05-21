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
        burgerJoint.SetMoveCost(1, GoodsTypes.Amber); // optional
        burgerJoint.SetProfession(ProfessionTypes.Cook);
        burgerJoint.SetCategory(BuildingCategoriesTypes.Industry);
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        
        var burgerRecipes = burgerJoint.CreateRecipe(burger.Name, 2, 126, Grade.One);
        burgerRecipes.AddTags(TagTypes.Food);
        burgerRecipes.AddRequiredIngredients((2, GoodsTypes.Jerky), (1, GoodsTypes.Skewers), (4, GoodsTypes.Insects));
        burgerRecipes.AddRequiredIngredients((1, GoodsTypes.Vegetables), (1, GoodsTypes.Mushrooms), (2, GoodsTypes.Eggs));
        burgerRecipes.AddRequiredIngredients((5, GoodsTypes.ClearanceWater), (5, GoodsTypes.DrizzleWater), (5, GoodsTypes.StormWater));
        
        var friesRecipe = burgerJoint.CreateRecipe(fries.Name, 10, 60, Grade.One);
        friesRecipe.AddTags(TagTypes.Food);
        friesRecipe.AddRequiredIngredients((1, GoodsTypes.PackOfCrops));
        
        var colaRecipe = burgerJoint.CreateRecipe(cola.Name, 1, 30, Grade.One);
        colaRecipe.AddTags(TagTypes.Food);
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.DrizzleWater));
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.StormWater));
    }
}