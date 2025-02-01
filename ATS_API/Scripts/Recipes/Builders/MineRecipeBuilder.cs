using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Recipes.Builders;

public class MineRecipeBuilder : RecipeBuilder<MineRecipeModel>
{
    public class ExtraProducedGood
    {
        public GoodsTypes ProductionGoodType;
        public int ProductionAmount;
        public float Chance; // 0 -> 1
    }
    
    private string Good;
    private int Amount;
    private int ProductionTime;
    private List<ExtraProducedGood> ExtraProduced = new List<ExtraProducedGood>();
    
    public MineRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public MineRecipeBuilder(MineRecipeModel model)
    {
        m_newData = NewMineRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public MineRecipeBuilder(string guid, string name, GoodsTypes good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }

    public MineRecipeBuilder(string guid, string name, string good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }
    
    public MineRecipeBuilder SetProducedGood(GoodsTypes good, int amount)
    {
        Good = good.ToName();
        Amount = amount;
        return this;
    }
    
    public MineRecipeBuilder SetProducedGood(string good, int amount)
    {
        Good = good;
        Amount = amount;
        return this;
    }
    
    public MineRecipeBuilder SetProductionTime(int productionTime)
    {
        ProductionTime = productionTime;
        return this;
    }
    
    public MineRecipeBuilder AddExtraProducedGood(GoodsTypes good, int amount, float chance)
    {
        ExtraProduced.Add(new ExtraProducedGood
        {
            ProductionGoodType = good,
            ProductionAmount = amount,
            Chance = chance
        });
        return this;
    }

    public override MineRecipeModel Build()
    {
        MineRecipeModel model = base.Build();
        model.producedGood = new GoodRef
        {
            good = Good.ToGoodModel(),
            amount = Amount
        };
        model.productionTime = ProductionTime;
        model.extraProduction = ExtraProduced.Select(data => new GoodRefChance
        {
            good = data.ProductionGoodType.ToGoodModel(),
            amount = data.ProductionAmount,
            chance = data.Chance
        }).ToArray();
        

        return model;
    }
}