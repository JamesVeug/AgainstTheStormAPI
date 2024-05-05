using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;

namespace ATS_API.Goods;

public static class GoodsExtensions
{
    public static List<GoodModel> GetGoods(this IEnumerable<string> names)
    {
        List<GoodModel> list = new List<GoodModel>();
        foreach (string goodName in names)
        {
            if (SO.Settings.ContainsGood(goodName))
            {
                GoodModel goodModel = SO.Settings.GetGood(goodName);
                list.Add(goodModel);
            }
            else
            {
                // TODO: Find similar names goods to log out what they MIGHT want
                Plugin.Log.LogWarning("Can't find good " + goodName);
            }
        }
        return list;
    }
    
    public static GoodRef GetGoodRef(this NameToAmount goodName)
    {
        if (SO.Settings.ContainsGood(goodName.Name))
        {
            GoodModel goodModel = SO.Settings.GetGood(goodName.Name);
            GoodRef goodRef = new GoodRef();
            goodRef.good = goodModel;
            goodRef.amount = goodName.Amount;
            return goodRef;
        }

        // TODO: Find similar names goods to log out what they MIGHT want
        Plugin.Log.LogWarning("Can't find good " + goodName.Name);
        return null;
    }
    
    public static List<GoodRef> GetGoodRefs(this IEnumerable<NameToAmount> collection)
    {
        List<GoodRef> list = new List<GoodRef>();
        foreach (NameToAmount goodName in collection)
        {
            if (SO.Settings.ContainsGood(goodName.Name))
            {
                GoodModel goodModel = SO.Settings.GetGood(goodName.Name);
                GoodRef goodRef = new GoodRef();
                goodRef.good = goodModel;
                goodRef.amount = goodName.Amount;
                list.Add(goodRef);
            }
            else
            {
                // TODO: Find similar names goods to log out
                Plugin.Log.LogWarning("Can't find good " + goodName);
            }
        }
        return list;
    }
    
    public static List<GoodRefWeight> GetGoodRefWeights(this IEnumerable<NameToAmount> collection)
    {
        List<GoodRefWeight> list = new List<GoodRefWeight>();
        foreach (NameToAmount goodName in collection)
        {
            if (SO.Settings.ContainsGood(goodName.Name))
            {
                GoodModel goodModel = SO.Settings.GetGood(goodName.Name);
                GoodRefWeight goodRef = new GoodRefWeight();
                goodRef.good = goodModel;
                goodRef.amount = goodName.Amount;
                goodRef.weight = goodName.Weight;
                list.Add(goodRef);
            }
            else
            {
                // TODO: Find similar names goods to log out
                Plugin.Log.LogWarning("Can't find good " + goodName);
            }
        }
        return list;
    }
}