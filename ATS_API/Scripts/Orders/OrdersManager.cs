using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Orders;
using UnityEngine;


namespace ATS_API.Orders;

public static class OrdersManager
{
    public static IReadOnlyList<NewOrderData> NewEffects => new ReadOnlyCollection<NewOrderData>(s_OrderModels);

    private static List<NewOrderData> s_OrderModels = new List<NewOrderData>();

    private static ArraySync<OrderModel, NewOrderData> s_orders = new("New Goods");

    private static bool s_instantiated = false;
    private static bool s_dirty = false;

    public static NewOrderData New(string guid, string name)
    {
        OrderModel OrderModel = ScriptableObject.CreateInstance<OrderModel>();
        
    
        return Add(guid, name, OrderModel);
    }
    
    private static NewOrderData Add(string guid, string name, OrderModel model)
    {
        model.name = guid + "_" + name;
        NewOrderData newOrderData = new NewOrderData
        {
            Model = model,
        };
        s_OrderModels.Add(newOrderData);
        s_dirty = true;
    
        return newOrderData;
    }

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
        s_orders.Sync(ref settings.orders, settings.ordersCache, s_OrderModels, a => a.Model);
    }
}