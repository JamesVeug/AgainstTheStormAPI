using Eremite.Model.Trade;
using Eremite.Services;
using HarmonyLib;

namespace ATS_API.Traders;

[HarmonyPatch]
public static partial class TraderManager
{
    [HarmonyPatch(typeof(TradeService), nameof(TradeService.IsUnlocked), new []{typeof(TraderModel)})]
    [HarmonyPostfix]
    private static void TraderManager_Force_Unlock_Custom_Trader(TraderModel trader, ref bool __result)
    {
        if (__result)
        {
            return;
        }
        
        foreach (var customTrader in NewTraders)
        {
            if (customTrader.TraderModel.name == trader.name)
            {
                __result = true;
                return;
            }
        }
    }
    
    // [HarmonyPatch(typeof(TradeService), nameof(TradeService.GetRangeForCurrentScore))]
    // [HarmonyPostfix]
    // private static void TraderManager_GetRangeForCurrentScore(ref TradersRange __result)
    // {
    //     Logger.LogInfo($"Result: {__result.weights.Length}");
    //     foreach (TraderChance traderChance in __result.weights)
    //     {
    //         Logger.LogInfo($"    Trader: {traderChance.trader.name}");
    //     }
    // }
}