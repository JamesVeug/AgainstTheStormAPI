using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Orders;
using UnityEngine;


namespace ATS_API.Relics;

public static class RelicManager
{
    // public static IReadOnlyList<OrderModel> NewEffects => new ReadOnlyCollection<OrderModel>(s_OrderModels);
    //
    // private static List<OrderModel> s_OrderModels = new List<OrderModel>();
    //
    // private static ArraySync<OrderModel, OrderModel> s_orders = new("New Goods");

    private static bool s_instantiated = false;
    private static bool s_dirty = false;

    // public static OrderModel New(string guid, string name)
    // {
    //     OrderModel OrderModel = ScriptableObject.CreateInstance<OrderModel>();
    //     
    //
    //     return Add(guid, name, OrderModel);
    // }
    //
    // private static OrderModel Add(string guid, string name, OrderModel model)
    // {
    //     model.name = guid + "_" + name;
    //     s_OrderModels.Add(model);
    //     s_dirty = true;
    //
    //     return model;
    // }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        Sync();
    }

    public static void Tick()
    {
        if (s_dirty)
        {
            s_dirty = false;
            Sync();
        }
    }

    private static void Sync()
    {
        if (!s_instantiated)
        {
            return;
        }

        // Plugin.Log.LogInfo("OrdersManager.Sync: " + s_OrderModels.Count + " new orders");
        //
        //
        // Settings settings = SO.Settings;
        // s_orders.Sync(ref settings.orders, settings.ordersCache, s_OrderModels, a => a);
    }

    public static void SyncNewGood(GoodsManager.NewGood model)
    {
        if (model.RelicRewards.Count == 0)
            return;
        
        foreach (RelicModel relicModel in MB.Settings.Relics)
        {
            foreach (EffectsTable table in relicModel.decisionsRewards)
            {
                if (!table.Name.EndsWith("Keep")) 
                    continue;

                EffectsTableEntity[] newRewards = model.RelicRewards.Select(a => a.RelicGoodEffect).ToArray();
                ArrayExtensions.AddElements(ref table.effects, newRewards);
                // Plugin.Log.LogInfo($"Added {newRewards.Length} new rewards to {relicModel.Name} from {model.goodModel.name}");
            }
        }
    }
}