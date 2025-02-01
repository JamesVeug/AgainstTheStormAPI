using ATS_API.Helpers;
using Eremite.Buildings;

namespace ATS_API.Recipes.Builders;

public class RainCatcherRecipeBuilder : RecipeBuilder<RainCatcherRecipeModel>
{
    private string WaterProduced;
    private int Amount;
    private int ProductionTime;
    
    public RainCatcherRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public RainCatcherRecipeBuilder(RainCatcherRecipeModel model)
    {
        m_newData = NewRainCatcherRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public RainCatcherRecipeBuilder(string guid, string name, WaterTypes water, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetWaterProduced(water, amount);
        SetProductionTime(productionTime);
    }

    public RainCatcherRecipeBuilder(string guid, string name, string water, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetWaterProduced(water, amount);
        SetProductionTime(productionTime);
    }
    
    public RainCatcherRecipeBuilder SetWaterProduced(WaterTypes water, int amount)
    {
        WaterProduced = water.ToName();
        Amount = amount;
        return this;
    }
    
    public RainCatcherRecipeBuilder SetWaterProduced(string water, int amount)
    {
        WaterProduced = water;
        Amount = amount;
        return this;
    }
    
    public RainCatcherRecipeBuilder SetProductionTime(int productionTime)
    {
        ProductionTime = productionTime;
        return this;
    }

    public override RainCatcherRecipeModel Build()
    {
        RainCatcherRecipeModel model = base.Build();
        model.water = WaterProduced.ToWaterModel();
        model.amount = Amount;
        

        return model;
    }
}