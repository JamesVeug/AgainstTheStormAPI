
using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Recipes.Builders;

public class CollectorRecipeBuilder : RecipeBuilder<CollectorRecipeModel>
{
    private string Good;
    private int Amount;
    private int ProductionTime;
    private LocaText GradeDesc = Placeholders.Grade;
    
    public CollectorRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public CollectorRecipeBuilder(CollectorRecipeModel model)
    {
        m_newData = NewCollectorRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public CollectorRecipeBuilder(string guid, string name, GoodsTypes good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }

    public CollectorRecipeBuilder(string guid, string name, string good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }
    
    public CollectorRecipeBuilder SetProducedGood(GoodsTypes good, int amount)
    {
        Good = good.ToName();
        Amount = amount;
        return this;
    }
    
    public CollectorRecipeBuilder SetProducedGood(string good, int amount)
    {
        Good = good;
        Amount = amount;
        return this;
    }
    
    public CollectorRecipeBuilder SetProductionTime(int productionTime)
    {
        ProductionTime = productionTime;
        return this;
    }

    public override CollectorRecipeModel Build()
    {
        CollectorRecipeModel model = base.Build();
        model.producedGood = new GoodRef
        {
            good = Good.ToGoodModel(),
            amount = Amount
        };
        model.productionTime = ProductionTime;
        

        return model;
    }
}