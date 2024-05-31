using ATS_API.Buildings;
using ATS_API.Helpers;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateBuildings()
    {
        CreateWorkshop();
        CreateHouse();
    }

    private void CreateHouse()
    {
        var house = new HouseBuildingBuilder(PluginInfo.PLUGIN_GUID, "SkyScraper", "TestBuildingIcon.png", 9);
        house.SetDefaultVisualIcon("TestBuildingDisplayIcon.png");
        house.SetDisplayName("SkyScraper");
        house.SetDescription("A tall building to house many people that need to be close to their work. Has to be built near a Hearth. Can house 9 residents.");
        house.SetLabel("Housing");
        house.SetAllHousingRaces();
        house.AddServedNeeds(NeedTypes.Any_Housing);
        house.AddRequiredGoods((8, GoodsTypes.Mat_Processed_Planks));
    }

    private void CreateWorkshop()
    {
        var burgerJoint = new WorkshopBuildingBuilder(PluginInfo.PLUGIN_GUID, "BurgerJoint", "BurgerJoint.png");
        burgerJoint.SetCustomModel(AssetBundle.LoadAsset<GameObject>("BorgorKing"));
        burgerJoint.SetDisplayName("Borgor King");
        burgerJoint.SetDescription("The best Borgors in town!");
        burgerJoint.SetLabel("Fast Food");
        burgerJoint.SetMoveCost(1, GoodsTypes.Valuable_Amber); // optional
        burgerJoint.SetProfession(ProfessionTypes.Cook);
        burgerJoint.SetCategory(BuildingCategoriesTypes.Industry);
        burgerJoint.AddTags(BuildingTagTypes.Animals);
        burgerJoint.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Planks, 10), (3, GoodsTypes.Mat_Processed_Parts));
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        
        var burgerRecipes = burgerJoint.CreateRecipe(burger.Name, 2, 126, Grade.One);
        burgerRecipes.AddTags(TagTypes.Food_Tag);
        burgerRecipes.AddRequiredIngredients((2, GoodsTypes.Food_Processed_Jerky), (1, GoodsTypes.Food_Processed_Skewers), (4, GoodsTypes.Food_Raw_Insects));
        burgerRecipes.AddRequiredIngredients((1, GoodsTypes.Food_Raw_Vegetables), (1, GoodsTypes.Food_Raw_Mushrooms), (2, GoodsTypes.Food_Raw_Eggs));
        burgerRecipes.AddRequiredIngredients((5, GoodsTypes.Water_Clearance_Water), (5, GoodsTypes.Water_Drizzle_Water), (5, GoodsTypes.Water_Storm_Water));
        
        var friesRecipe = burgerJoint.CreateRecipe(fries.Name, 10, 60, Grade.One);
        friesRecipe.AddTags(TagTypes.Food_Tag);
        friesRecipe.AddRequiredIngredients((1, GoodsTypes.Packs_Pack_Of_Crops));
        
        var colaRecipe = burgerJoint.CreateRecipe(cola.Name, 1, 30, Grade.One);
        colaRecipe.AddTags(TagTypes.Food_Tag);
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.Water_Drizzle_Water));
        colaRecipe.AddRequiredIngredients((1, GoodsTypes.Water_Storm_Water));
    }
}