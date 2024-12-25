using System;
using System.Linq;
using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;


namespace ATS_API.Relics;

public static class RelicManager
{
    // public static IReadOnlyList<OrderModel> NewEffects => new ReadOnlyCollection<OrderModel>(s_OrderModels);
    //
    // private static List<OrderModel> s_OrderModels = new List<OrderModel>();
    //
    // private static ArraySync<OrderModel, OrderModel> s_orders = new("New Goods");

    private static event Action m_postSyncActions;
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

        if (m_postSyncActions != null)
        {
            m_postSyncActions();
            m_postSyncActions = null;
        }
    }

    private static void Sync()
    {
        if (!s_instantiated)
        {
            return;
        }

        // Logger.LogInfo("OrdersManager.Sync: " + s_OrderModels.Count + " new orders");
        //
        //
        // Settings settings = SO.Settings;
        // s_orders.Sync(ref settings.orders, settings.ordersCache, s_OrderModels, a => a);
    }

    public static void PostSyncNewGood(NewGood model)
    {
        m_postSyncActions += ()=>SyncNewGood(model);
    }

    public static void SyncNewGood(NewGood model)
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
                // Logger.LogInfo($"Added {newRewards.Length} new rewards to {relicModel.Name} from {model.goodModel.name}");
            }
        }
    }
}