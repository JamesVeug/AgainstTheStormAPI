using System.Collections.Generic;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite.Model.Trade;
using UnityEngine;

namespace ATS_API.Traders;

public class CustomTrader : ASyncable<TraderModel>
{
    public TraderModel TraderModel;
    public List<string> DesiredGoods = new List<string>();
    public List<NameToAmount> GuaranteedOfferedGoods = new List<NameToAmount>();
    public List<NameToAmount> OfferedGoods = new List<NameToAmount>();
    public List<NameToAmount> Merchandise = new List<NameToAmount>();
    public Availability Availability = new Availability();

    public override void Sync(TraderModel traderModel)
    {
        traderModel.desiredGoods = DesiredGoods.GetGoods().ToArray();
        traderModel.guaranteedOfferedGoods = GuaranteedOfferedGoods.GetGoodRefs().ToArray();
        traderModel.offeredGoods = OfferedGoods.GetGoodRefWeights().ToArray();
        traderModel.merchandise = Merchandise.ToEffectDrops().ToArray();
    }
}

public class NameToAmount
{
    public string Name;
    public int Amount;
            
    [Range(0,100)]
    public int Weight;

    public NameToAmount(int amount, string name, int weight=0)
    {
        Name = name;
        Amount = amount;
        Weight = weight;
    }
            
    public static implicit operator NameToAmount((int, string) tuple)
    {
        return new NameToAmount(tuple.Item1, tuple.Item2);
    }
            
    public static implicit operator NameToAmount((int, string, int) tuple)
    {
        return new NameToAmount(tuple.Item1, tuple.Item2, tuple.Item3);
    }
}