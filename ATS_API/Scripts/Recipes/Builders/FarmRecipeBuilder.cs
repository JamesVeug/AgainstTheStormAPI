
using System;
using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Recipes.Builders;

[Obsolete("Technically this works but you will have to set plant to be the model you want to grow out of the farm patch.")]
public class FarmRecipeBuilder : RecipeBuilder<FarmRecipeModel>
{
    private string Good;
    private int Amount;
    private float PlantingTime;
    private float HarvestTime;
    
    public FarmRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public FarmRecipeBuilder(FarmRecipeModel model)
    {
        m_newData = NewFarmRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public FarmRecipeBuilder(string guid, string name, GoodsTypes good, int amount, float plantingTime, float harvestTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetPlantingTime(plantingTime);
        SetHarvestTime(harvestTime);
    }

    public FarmRecipeBuilder(string guid, string name, string good, int amount, float plantingTime, float harvestTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetPlantingTime(plantingTime);
        SetHarvestTime(harvestTime);
    }
    
    public FarmRecipeBuilder SetProducedGood(GoodsTypes good, int amount)
    {
        Good = good.ToName();
        Amount = amount;
        return this;
    }
    
    public FarmRecipeBuilder SetProducedGood(string good, int amount)
    {
        Good = good;
        Amount = amount;
        return this;
    }
    
    public FarmRecipeBuilder SetPlantingTime(float time)
    {
        PlantingTime = time;
        return this;
    }
    
    public FarmRecipeBuilder SetHarvestTime(float time)
    {
        HarvestTime = time;
        return this;
    }

    public override FarmRecipeModel Build()
    {
        FarmRecipeModel model = base.Build();
        model.producedGood = new GoodRef
        {
            good = Good.ToGoodModel(),
            amount = Amount
        };
        model.plantingTime = PlantingTime;
        model.harvestTime = HarvestTime;

        return model;
    }
}