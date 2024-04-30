using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Biomes;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Trade;
using UnityEngine;

namespace ATS_API.Traders;

public static partial class TraderManager
{
    public static IReadOnlyList<CustomTrader> NewTraders => new ReadOnlyCollection<CustomTrader>(s_newTraders);
    
    private static List<CustomTrader> s_newTraders = new List<CustomTrader>();

    private static ArraySync<TraderModel, CustomTrader> s_traders = new("New Traders");

    private static bool s_instantiated = false;
    private static bool s_dirty = false;

    public static CustomTrader New(string guid, string name)
    {
        TraderModel TraderModel = ScriptableObject.CreateInstance<TraderModel>();
    
        return Add(guid, name, TraderModel);
    }
    
    private static CustomTrader Add(string guid, string name, TraderModel model)
    {
        model.name = guid + "_" + name;
        CustomTrader customTrader = new CustomTrader()
        {
            TraderModel = model
        };
        
        s_newTraders.Add(customTrader);
        s_dirty = true;
        return customTrader;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncTraders();
    }

    public static void Tick()
    {
        if (s_dirty)
        {
            s_dirty = false;
            SyncTraders();
        }
    }

    private static void SyncTraders()
    {
        if (!s_instantiated)
        {
            return;
        }

        Plugin.Log.LogInfo("TraderManager.SyncTrader: base effects, " + s_newTraders.Count + " new traders");


        Settings settings = SO.Settings;
        s_traders.Sync(ref settings.traders, settings.tradersCache, s_newTraders, a=>a.TraderModel);
        
        BiomeManager.SetDirty(); // Add trader to biomes
    }

    public static void SyncNewGood(NewGood newGood)
    {
        if (newGood.SoldByTraderDetails != null || newGood.TraderDesiredAvailability != null)
        {
            // TODO: Add filter by trader name
            foreach (TraderModel traderModel in MB.Settings.traders)
            {
                if (newGood.SoldByTraderDetails != null && newGood.SoldByTraderDetails.TraderAvailability.ContainsTrader(traderModel))
                {
                    if (newGood.SoldByTraderDetails.Weight >= 100)
                    {
                        GoodRef goodRef = new GoodRef()
                        {
                            good = newGood.goodModel,
                            amount = newGood.SoldByTraderDetails.Amount
                        };
                        ArrayExtensions.AddElement(ref traderModel.guaranteedOfferedGoods, goodRef);
                    }
                    else
                    {
                        GoodRefWeight goodRef = new GoodRefWeight()
                        {
                            good = newGood.goodModel,
                            amount = newGood.SoldByTraderDetails.Amount,
                            weight = newGood.SoldByTraderDetails.Weight
                        };
                        ArrayExtensions.AddElement(ref traderModel.offeredGoods, goodRef);
                    }

                    Plugin.Log.LogInfo($"{newGood.goodModel.name} is offered by {traderModel.name}!");
                }

                if (newGood.TraderDesiredAvailability != null)
                {
                    if (newGood.TraderDesiredAvailability.ContainsTrader(traderModel))
                    {
                        ArrayExtensions.AddElement(ref traderModel.desiredGoods, newGood.goodModel);
                        Plugin.Log.LogInfo($"{newGood.goodModel.name} is desired by {traderModel.name}!");
                    }
                }
            }
        }
    }
}