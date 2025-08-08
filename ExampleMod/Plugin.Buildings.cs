using ATS_API.Buildings;
using ATS_API.Helpers;
using ATS_API.Needs;
using ATS_API.Recipes.Builders;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private CustomRaceNeed friesWorshiperNeed;
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
        burgerJoint.SetCategory(BuildingCategoriesTypes.Food_Production);
        burgerJoint.SetCustomModel(ExampleModAssetBundle.LoadAsset<GameObject>("BorgorKing"));
        burgerJoint.SetDisplayName("Borgor King");
        burgerJoint.SetMoveCost(1, GoodsTypes.Mat_Processed_Planks);
        burgerJoint.SetProfession(ProfessionTypes.Cook);
        burgerJoint.SetRainpunk(BuildingRainpunkModelTypes.Food_Rainpunk_Module);
        burgerJoint.AddTags(BuildingTagTypes.Animals);
        burgerJoint.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Planks), (3, GoodsTypes.Mat_Processed_Parts));
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.AddWorkPlaceWithAllRaces();
        burgerJoint.SetScaffoldingData(new BuildingConstructionAnimationData()
        {
            unconstructedPosition = new Vector3(0, -3, 0) // Move the model 3 units down then when built moves to the correct position
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

        burgerJoint.AddRecipe(WorkshopsRecipeTypes.Meat_workshop_T1);
    }

    private void CreateServiceBuilding()
    {
        var playPen = new InstitutionBuildingBuilder(PluginInfo.PLUGIN_GUID, "PlayPen", "TestBuildingIcon.png");
        playPen.SetDefaultVisualIcon("TestBuildingDisplayIcon.png");
        playPen.SetDisplayName("Play Pen");
        playPen.SetMoveCost(5, GoodsTypes.Mat_Raw_Wood);
        playPen.SetProfession(ProfessionTypes.Bath_House_Worker);
        playPen.AddTags(BuildingTagTypes.Rainwater);
        playPen.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Planks));
        playPen.AddRequiredGoods((3, GoodsTypes.Mat_Processed_Fabric));
        playPen.AddRequiredGoods((10, GoodsTypes.Mat_Processed_Bricks));
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddWorkPlaceWithAllRaces();
        playPen.AddActiveEffect(EffectTypes.Bigger_Storage, 1);

        playPen.AddRecipe(InstitutionRecipeTypes.Treatment);
        
        // Give me fries, and I'll give you a worshiping good in return.
        string description = $"It requires <sprite name=\"{fries.NewGood.goodModel.name}\"> Fries. Satisfying this need increases the chance of producing double yields.";
        friesWorshiperNeed = RaceNeedFactory.ServiceNeed(PluginInfo.PLUGIN_GUID, fries.NewGood.id, "TestBuildingIcon.png", "Fry Worship", description, 8);
        InstitutionRecipeBuilder friesRecipe = playPen.CreateRecipe(friesWorshiperNeed.ID);
        friesRecipe.AddRequiredIngredients((2, fries.NewGood.id));
    }
}