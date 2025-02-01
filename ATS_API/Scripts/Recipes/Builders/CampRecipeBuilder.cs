using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Recipes.Builders;

public class CampRecipeBuilder : RecipeBuilder<CampRecipeModel>
{
    private string Good;
    private int Amount;
    private int ProductionTime;
    
    public CampRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public CampRecipeBuilder(CampRecipeModel model)
    {
        m_newData = NewCampRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public CampRecipeBuilder(string guid, string name, GoodsTypes good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }

    public CampRecipeBuilder(string guid, string name, string good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }
    
    public CampRecipeBuilder SetProducedGood(GoodsTypes good, int amount)
    {
        Good = good.ToName();
        Amount = amount;
        return this;
    }
    
    public CampRecipeBuilder SetProducedGood(string good, int amount)
    {
        Good = good;
        Amount = amount;
        return this;
    }
    
    public CampRecipeBuilder SetProductionTime(int productionTime)
    {
        ProductionTime = productionTime;
        return this;
    }

    public override CampRecipeModel Build()
    {
        CampRecipeModel model = base.Build();
        model.refGood = new GoodRef
        {
            good = Good.ToGoodModel(),
            amount = Amount
        };
        model.productionTime = ProductionTime;

        return model;
    }
}