
using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Buildings;
using Eremite.Model;
using TMPro.SpriteAssetUtilities;

namespace ATS_API.Recipes.Builders;

public class InstitutionRecipeBuilder : RecipeBuilder<InstitutionRecipeModel>
{
    private string servedNeed;
    private List<NameToAmount> requiredGoods = new List<NameToAmount>();
    
    public InstitutionRecipeBuilder(string guid, string name, string servedNeed) : base(guid, name)
    {
        this.servedNeed = servedNeed;
        this.Grade = Grade.One;
        RecipeModel.isGoodConsumed = false;
    }
    
    public InstitutionRecipeBuilder(string guid, string name, NeedTypes servedNeed) : base(guid, name)
    {
        this.servedNeed = servedNeed.ToName();
        this.Grade = Grade.One;
        RecipeModel.isGoodConsumed = false;
    }
    
    public InstitutionRecipeBuilder(InstitutionRecipeModel model)
    {
        m_newData = NewInstitutionRecipeData.FromModel(model);
        RecipeModel = model;
    }
    
    public InstitutionRecipeBuilder SetIsGoodConsumed(bool isGoodConsumed)
    {
        RecipeModel.isGoodConsumed = isGoodConsumed;
        return this;
    }
    
    public void AddRequiredIngredients(NameToAmount requiredGoods)
    {
        this.requiredGoods.Add(requiredGoods);
    }
    
    public void AddRequiredIngredients(params NameToAmount[] requiredGoods)
    {
        this.requiredGoods.AddRange(requiredGoods);
    }

    public override InstitutionRecipeModel Build()
    {
        APILogger.IsNotNull(RecipeModel, $"RecipeModel can not be null for InstitutionRecipeModel!");
        APILogger.IsNotNull(servedNeed, $"ServedNeed can not be null for InstitutionRecipeModel {RecipeModel.name}");
        
        InstitutionRecipeModel model = base.Build();
        APILogger.IsNotNull(model, $"model can not be null for InstitutionRecipeModel!");
        model.servedNeed = servedNeed.ToNeedModel();
        model.requiredGoods = new GoodsSet();
        model.requiredGoods.goods = requiredGoods.ToArrayOfGoodRefs(false);

        return model;
    }
}