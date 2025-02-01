
using System.Collections.Generic;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Buildings;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Recipes.Builders;

public class GathererHutRecipeBuilder : RecipeBuilder<GathererHutRecipeModel>
{
    private string Good;
    private int Amount;
    private int ProductionTime;
    private LocaText GradeDesc;
    
    public GathererHutRecipeBuilder(string guid, string name) : base(guid, name)
    {
        
    }
    
    public GathererHutRecipeBuilder(GathererHutRecipeModel model)
    {
        m_newData = NewGathererHutRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public GathererHutRecipeBuilder(string guid, string name, GoodsTypes good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }

    public GathererHutRecipeBuilder(string guid, string name, string good, int amount, int productionTime, Grade grade) : base(guid, name, grade)
    {
        SetProducedGood(good, amount);
        SetProductionTime(productionTime);
    }
    
    public GathererHutRecipeBuilder SetProducedGood(GoodsTypes good, int amount)
    {
        Good = good.ToName();
        Amount = amount;
        return this;
    }
    
    public GathererHutRecipeBuilder SetProducedGood(string good, int amount)
    {
        Good = good;
        Amount = amount;
        return this;
    }
    
    public GathererHutRecipeBuilder SetProductionTime(int productionTime)
    {
        ProductionTime = productionTime;
        return this;
    }
    
    public GathererHutRecipeBuilder SetGradeDesc(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = RecipeModel.gradeDesc.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Grade.key)
        {
            // Create a new key for this field
            return SetGradeDesc(LocalizationManager.ToLocaText(guid, name, "gradeDesc", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }
    
    public GathererHutRecipeBuilder SetGradeDescKey(string key)
    {
        return SetGradeDesc(key.ToLocaText());
    }
    
    public GathererHutRecipeBuilder SetGradeDesc(LocaText text)
    {
        GradeDesc = text;
        return this;
    }

    public override GathererHutRecipeModel Build()
    {
        GathererHutRecipeModel model = base.Build();
        model.refGood = new GoodRef
        {
            good = Good.ToGoodModel(),
            amount = Amount
        };
        model.productionTime = ProductionTime;
        model.gradeDesc = GradeDesc;
        

        return model;
    }
}