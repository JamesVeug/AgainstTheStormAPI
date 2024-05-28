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
        var house = new HouseBuildingBuilder(PluginInfo.PLUGIN_GUID, "House", "TestBuildingIcon.png", 8);
        house.SetDefaultVisualIcon("TestBuildingDisplayIcon.png");
        house.SetDisplayName("Sky Scraper");
        house.SetDescription("A tall building to house many people!");
        house.SetLabel("Housing");
        house.SetMoveCost(1, GoodsTypes.Food_Raw_Meat); // optional
        house.SetAllHousingRaces();
        house.AddServedNeeds(NeedTypes.Any_Housing);
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