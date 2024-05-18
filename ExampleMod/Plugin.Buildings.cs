using ATS_API.Buildings;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite.Buildings;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateBuildings()
    {
        var burgerJoint = new WorkshopBuildingBuilder(PluginInfo.PLUGIN_GUID, "BurgerJoint");
        burgerJoint.SetDisplayName("Borgor King");
        burgerJoint.SetDescription("The best Borgors in town!");
        
        var recipe = burgerJoint.AddRecipe(new WorkshopRecipeBuilder(burger.Name, 1, 126, Grade.One));
        recipe.AddTags(TagTypes.Food);
        recipe.AddRequiredIngredients((2, GoodsTypes.Jerky), (1, GoodsTypes.Skewers), (4, GoodsTypes.Insects));
        recipe.AddRequiredIngredients((1, GoodsTypes.Vegetables), (1, GoodsTypes.Mushrooms), (2, GoodsTypes.Eggs));
        recipe.AddRequiredIngredients((5, GoodsTypes.ClearanceWater), (5, GoodsTypes.DrizzleWater), (5, GoodsTypes.StormWater));
    }
}