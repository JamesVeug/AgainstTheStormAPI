using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.NaturalResource;

public class NewNaturalResource : ASyncable<NaturalResourceModel>
{
    public class ExtraProducedGood
    {
        public GoodsTypes ProductionGoodType;
        public int ProductionAmount;
        public float Chance; // 0 -> 1
    }
    
    public NaturalResourceModel Model;
    public NaturalResourceTypes ID;
    public string Guid;
    public string RawName;

    public GoodsTypes ProductionGoodType = GoodsTypes.Mat_Raw_Wood;
    public int ProductionAmount = 1;
    
    public List<ExtraProducedGood> ExtraProducedGoods = new List<ExtraProducedGood>();
    
    public List<Eremite.MapObjects.NaturalResource> Prefabs = new();

    public override void PostSync()
    {
        base.PostSync();

        Model.production = new GoodRef()
        {
            good = ProductionGoodType.ToGoodModel(),
            amount = ProductionAmount,
        };
        Model.refGood = Model.production.good;
        
        Model.extraProduction = new GoodRefChance[ExtraProducedGoods.Count];
        for (int i = 0; i < ExtraProducedGoods.Count; i++)
        {
            Model.extraProduction[i] = new GoodRefChance()
            {
                good = ExtraProducedGoods[i].ProductionGoodType.ToGoodModel(),
                amount = ExtraProducedGoods[i].ProductionAmount,
                chance = ExtraProducedGoods[i].Chance,
            };
        }
        
        Model.prefabs = Prefabs.ToArray();


        NaturalResourceModel template = NaturalResourceTypes.Woodlands_Tree.ToNaturalResourceModel();
        Model.label = template.label;
        Model.gatheringSound = template.gatheringSound;
        Model.finalSound = template.finalSound;
    }
}