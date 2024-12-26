using ATS_API.Buildings;
using ATS_API.Helpers;
using ATS_API.Needs;
using Eremite.Buildings;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private HouseBuildingBuilder axolotlHouse;

    private void CreateBuildings()
    {
        CreateWorkshop();
        CreateSkyScraperHouse();
        CreateAxolotlHouse();
        CreateServiceBuilding();
    }

    private void CreateSkyScraperHouse()
    {
        var house = new HouseBuildingBuilder(PluginInfo.PLUGIN_GUID, "SkyScraper", "TestBuildingIcon.png", 9);
        house.SetDefaultVisualIcon("TestBuildingDisplayIcon.png");
        house.SetDisplayName("SkyScraper");
        house.SetDescription("A tall building to house many people that need to be close to their work. Has to be built near a Hearth. Can house 9 residents.");
        house.SetAllHousingRaces();
        house.AddServedNeeds(NeedTypes.Any_Housing);
        house.AddRequiredGoods((8, GoodsTypes.Mat_Processed_Planks));
    }
    
    private void CreateAxolotlHouse()
    {
        axolotlHouse = new HouseBuildingBuilder(PluginInfo.PLUGIN_GUID, "AxolotlHouse", "TestBuildingIcon.png", 2);
        axolotlHouse.SetDefaultVisualIcon("AxolotlHouseDisplayIcon.png");
        axolotlHouse.SetDisplayName("Axolotl House");
        axolotlHouse.SetDescription("Building specifically made for Axolotls. Has to be built near a Hearth. Can house 2 residents.");
        axolotlHouse.AddServedNeeds(NeedTypes.Any_Housing);
        axolotlHouse.AddRequiredGoods((2, GoodsTypes.Mat_Processed_Fabric), (2, GoodsTypes.Mat_Raw_Stone));
    }

    private void CreateWorkshop()
    {
        var burgerJoint = new WorkshopBuildingBuilder(PluginInfo.PLUGIN_GUID, "BurgerJoint", "BurgerJoint.png");
        burgerJoint.SetCustomModel(ExampleModAssetBundle.LoadAsset<GameObject>("BorgorKing"));
        burgerJoint.SetDisplayName("Borgor King");
        burgerJoint.SetDescription("The best Borgors in town!");
        burgerJoint.SetMoveCost(1, GoodsTypes.Valuable_Amber); // optional
        burgerJoint.SetProfession(ProfessionTypes.Cook);
        burgerJoint.SetCategory(BuildingCategoriesTypes.Industry);
        burgerJoint.AddTags(BuildingTagTypes.Animals);
        burgerJoint.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Planks), (3, GoodsTypes.Mat_Processed_Parts));
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.SetScaffoldingData(new BuildingConstructionAnimationData()
        {
            unconstructedPosition = new Vector3(0, -3, 0)
        });
        
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

        burgerJoint.AddRecipe(WorkshopsRecipeTypes.Coal_T1);
    }

    private void CreateServiceBuilding()
    {
        var playPen = new InstitutionBuildingBuilder(PluginInfo.PLUGIN_GUID, "PlayPen", "TestBuildingIcon.png");
        playPen.SetDefaultVisualIcon("TestBuildingDisplayIcon.png");
        playPen.SetDisplayName("Play Pen");
        playPen.SetMoveCost(5, GoodsTypes.Mat_Raw_Wood); // optional
        playPen.SetProfession(ProfessionTypes.Bath_House_Worker);
        playPen.AddTags(BuildingTagTypes.Rainwater, BuildingTagTypes.Cysts);
        playPen.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Planks));
        playPen.AddRequiredGoods((3, GoodsTypes.Mat_Processed_Fabric));
        playPen.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Bricks));
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddActiveEffect(EffectTypes.Bigger_Storage, 1);

        playPen.AddRecipe(InstitutionRecipeTypes.Treatment);
        CustomRaceNeed friesNeed = RaceNeedFactory.ComplexFoodNeed(PluginInfo.PLUGIN_GUID, fries.NewGood.id, 4);
        var friesRecipe = playPen.CreateRecipe(friesNeed.ID);
        friesRecipe.AddTags(TagTypes.Food_Tag);
        friesRecipe.AddRequiredIngredients((1, fries.NewGood.id));
    }
}