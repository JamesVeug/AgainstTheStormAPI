using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Orders;


namespace ATS_API.Orders;

public static class OrdersManager
{
    public static IReadOnlyList<OrderModel> NewEffects => new ReadOnlyCollection<OrderModel>(s_OrderModels);

    private static List<OrderModel> s_OrderModels = new List<OrderModel>();

    private static ArraySync<OrderModel, OrderModel> s_orders = new("New Goods");

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

        Plugin.Log.LogInfo("OrdersManager.Sync: " + s_OrderModels.Count + " new orders");


        Settings settings = SO.Settings;
        s_orders.Sync(ref settings.orders, settings.ordersCache, s_OrderModels, a => a);
    }
}