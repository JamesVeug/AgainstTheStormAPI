using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;

namespace ATS_API.Goods;

public class NewGood : ASyncable<GoodModel>
{
    public class GoodSoldByTraderDetails
    {
        public int Amount = 30;
        public int Weight = 100;
        public TraderAvailability TraderAvailability = new TraderAvailability();
    }
        
    public class RelicDetails
    {
        public EffectsTableEntity RelicGoodEffect;
    }
        
    public GoodsTypes id;
    public string guid;
    public string rawName;
    public GoodModel goodModel;
    public TraderAvailability TraderDesiredAvailability;
    public string Category = "Modded";
    public GoodSoldByTraderDetails SoldByTraderDetails;
    public List<RelicDetails> RelicRewards = new List<RelicDetails>();

    public override bool Sync()
    {
        Settings settings = SO.Settings;
        if (goodModel.category == null && Category != null)
        {
            GoodCategoryModel modelCategory = Category.ToGoodCategoryModel();
            if (modelCategory == null)
            {
                Plugin.Log.LogError($"Good Category {Category} not found for good {goodModel.name}. Custom Good Categories not supported yet!");
                modelCategory = settings.Goods[0].category;
            }
            goodModel.category = modelCategory;
            // Plugin.Log.LogInfo($"Assigning new good {model.name} category {model.category.name}");
        }
        
        return true;
    }
    
    public static NewGood FromModel(GoodModel model)
    {
        foreach (NewGood good in GoodsManager.NewGoods)
        {
            if (good.goodModel == model)
            {
                return good;
            }
        }
        
        NewGood newGood = new NewGood();
        newGood.id = model.name.ToGoodsTypes();
        newGood.goodModel = model;
        // TODO: populate with everything else maybe maybe??
        

        return newGood;
    }
}