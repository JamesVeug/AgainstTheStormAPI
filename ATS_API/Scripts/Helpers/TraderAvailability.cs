using System.Collections.Generic;
using Eremite.Model.Trade;

namespace ATS_API.Helpers;

public class TraderAvailability
{
    // If null then available in all seasons
    public bool SoldByAllTraders;
    public List<string> TradersSellingItem = new List<string>();

    public void SetAllTraders()
    {
        SoldByAllTraders = true;
    }

    public void AddTrader(string traderName)
    {
        TradersSellingItem.Add(traderName);
    }

    public bool ContainsTrader(TraderModel traderModel)
    {
        if (SoldByAllTraders)
        {
            return true;
        }

        return TradersSellingItem.Contains(traderModel.name);
    }
}