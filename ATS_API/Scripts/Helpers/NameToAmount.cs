using System.Collections.Generic;
using System.Linq;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Helpers;

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
    
    public static implicit operator NameToAmount((int, GoodsTypes) tuple)
    {
        return new NameToAmount(tuple.Item1, tuple.Item2.ToName());
    }
            
    public static implicit operator NameToAmount((int, GoodsTypes, int) tuple)
    {
        return new NameToAmount(tuple.Item1, tuple.Item2.ToName(), tuple.Item3);
    }
}

public static class NameToAmountExtension
{
    public static List<GoodRef> ToListOfGoodRefs(this List<NameToAmount> nameToAmounts, bool includeNullGoods = false)
    {
        return nameToAmounts.Select(x => new GoodRef
        {
            good = x.Name.ToGoodModel(),
            amount = x.Amount
        }).Where(a=>includeNullGoods || a.good != null).ToList();
    }
    
    public static GoodRef[] ToArrayOfGoodRefs(this List<NameToAmount> nameToAmounts, bool includeNullGoods = false)
    {
        return nameToAmounts.Select(x => new GoodRef
        {
            good = x.Name.ToGoodModel(),
            amount = x.Amount
        }).Where(a=>includeNullGoods || a.good != null).ToArray();
    }
}