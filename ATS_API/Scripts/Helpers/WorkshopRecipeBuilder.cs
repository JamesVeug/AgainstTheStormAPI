
using System.Collections.Generic;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Helpers;

public class WorkshopRecipeBuilder : RecipeBuilder<WorkshopRecipeModel>
{
    private readonly string Good;
    private readonly int Amount;
    private readonly List<List<NameToAmount>> RequiredGoods = new List<List<NameToAmount>>();
    private readonly int ProductionTime;
    
    public WorkshopRecipeBuilder(GoodsTypes good, int amount, int productionTime, Grade grade) : base(grade)
    {
        Good = good.ToName();
        Amount = amount;
        ProductionTime = productionTime;
    }

    public WorkshopRecipeBuilder(string good, int amount, int productionTime, Grade grade) : base(grade)
    {
        Good = good;
        Amount = amount;
        ProductionTime = productionTime;
    }
    
    /// <summary>
    /// Single choice of ingredients.
    /// Player has to choose from this list of ingredients to make the product. 
    /// </summary>
    public void AddRequiredIngredients(List<NameToAmount> requiredGoods)
    {
        RequiredGoods.Add(requiredGoods);
    }
    
    /// <summary>
    /// Single choice of ingredients.
    /// Player has to choose from this list of ingredients to make the product. 
    /// </summary>
    public void AddRequiredIngredients(params NameToAmount[] requiredGoods)
    {
        RequiredGoods.Add(new List<NameToAmount>(requiredGoods));
    }
    
    /// <summary>
    /// All possible ingredients and their choices to make the product. 
    /// </summary>
    public void SetAllRequiredGIngredients(List<List<NameToAmount>> requiredGoods)
    {
        RequiredGoods.Clear();
        RequiredGoods.AddRange(requiredGoods);
    }

    public override WorkshopRecipeModel Build()
    {
        WorkshopRecipeModel model = base.Build();
        model.producedGood = new GoodRef
        {
            good = Good.ToGoodsModel(),
            amount = Amount
        };
        model.productionTime = ProductionTime;
        model.requiredGoods = new GoodsSet[model.requiredGoods.Length];
        for (int i = 0; i < RequiredGoods.Count; i++)
        {
            GoodsSet goodsSet = new GoodsSet();
            model.requiredGoods[i] = goodsSet;
            goodsSet.goods = new GoodRef[RequiredGoods[i].Count];
            for (int j = 0; j < RequiredGoods[i].Count; j++)
            {
                goodsSet.goods[j] = new GoodRef
                {
                    good = RequiredGoods[i][j].Name.ToGoodsModel(),
                    amount = RequiredGoods[i][j].Amount
                };
            }
        }

        return model;
    }
}