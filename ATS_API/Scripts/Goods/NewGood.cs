using System.Collections.Generic;
using Eremite;
using Eremite.Model;

namespace ATS_API.Goods;

public class NewGood : ASyncable<GoodModel>
{
    public class TraderDetails
    {
        public int Amount = 30;
        public int Weight = 100;
    }
        
    public class RelicDetails
    {
        public EffectsTableEntity RelicGoodEffect;
    }
        
    public GoodModel goodModel;
    public bool SoldToTrader;
    public TraderDetails SoldByTrader;
    public List<RelicDetails> RelicRewards = new List<RelicDetails>();

    public override void Sync(GoodModel model)
    {
        Settings settings = SO.Settings;
        if (model.category == null)
        {
            model.category = settings.Goods[0].category;
        }

        Plugin.Log.LogInfo($"Assigning new good {model.name} category {model.category.name}");
    }
}