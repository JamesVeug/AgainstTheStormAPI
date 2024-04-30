using System;
using System.Collections.Generic;
using System.Linq;
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
        
    public GoodModel goodModel;
    public TraderAvailability TraderDesiredAvailability;
    public string Category = "Modded";
    public GoodSoldByTraderDetails SoldByTraderDetails;
    public List<RelicDetails> RelicRewards = new List<RelicDetails>();

    public override void Sync(GoodModel model)
    {
        Settings settings = SO.Settings;
        if (model.category == null && Category != null)
        {
            GoodCategoryModel modelCategory = settings.GoodsCategories.FirstOrDefault(x => x.name.Equals(Category, StringComparison.InvariantCultureIgnoreCase));
            if (modelCategory == null)
            {
                Plugin.Log.LogError($"Good Category {Category} not found for good {model.name}. Custom Good Categories not supported yet!");
                modelCategory = settings.Goods[0].category;
            }
            model.category = modelCategory;
            Plugin.Log.LogInfo($"Assigning new good {model.name} category {model.category.name}");
        }
    }
}