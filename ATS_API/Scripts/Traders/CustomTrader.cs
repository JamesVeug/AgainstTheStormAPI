using System.Collections.Generic;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite.Model.Trade;

namespace ATS_API.Traders;

public class CustomTrader : ASyncable<TraderModel>
{
    public TraderTypes id;
    public TraderModel TraderModel;
    public List<string> DesiredGoods = new List<string>();
    public List<NameToAmount> GuaranteedOfferedGoods = new List<NameToAmount>();
    public List<NameToAmount> OfferedGoods = new List<NameToAmount>();
    public List<NameToAmount> Merchandise = new List<NameToAmount>();
    public Availability Availability = new Availability();

    public override bool Sync()
    {
        TraderModel.desiredGoods = DesiredGoods.GetGoods().ToArray();
        TraderModel.guaranteedOfferedGoods = GuaranteedOfferedGoods.GetGoodRefs().ToArray();
        TraderModel.offeredGoods = OfferedGoods.GetGoodRefWeights().ToArray();
        TraderModel.merchandise = Merchandise.ToEffectDrops().ToArray();
        
        return true;
    }
}