using ATS_API.Helpers;

namespace ATS_API.NaturalResource;

public partial class NaturalResourceBuilder
{
    public string Name => newModel.Model.name; // myguid_itemName
    public NewNaturalResource NewNaturalResource => newModel;
    
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    private readonly NewNaturalResource newModel;
    
    public NaturalResourceBuilder(string guid, string name)
    {
        this.guid = guid;
        this.name = name;
        newModel = NaturalResourceManager.New(guid, name);
    }
    
    public NaturalResourceBuilder SetCharges(int charges)
    {
        newModel.Model.charges = charges;
        return this;
    }
    
    public NaturalResourceBuilder SetProduction(GoodsTypes goodsTypes, int amount)
    {
        newModel.ProductionGoodType = goodsTypes;
        newModel.ProductionAmount = amount;
        return this;
    }
    
    /// <summary>
    /// Add extra production to the natural resource
    /// </summary>
    /// <param name="goodsTypes">Type of goods to produce</param>
    /// <param name="amount">How much to get</param>
    /// <param name="chance">Between 0 and 1. 1 for 100%</param>
    /// <returns></returns>
    public NaturalResourceBuilder AddExtraProduction(GoodsTypes goodsTypes, int amount, float chance)
    {
        newModel.ExtraProducedGoods.Add(new NewNaturalResource.ExtraProducedGood()
        {
            ProductionGoodType = goodsTypes,
            ProductionAmount = amount,
            Chance = chance,
        });
        return this;
    }
}