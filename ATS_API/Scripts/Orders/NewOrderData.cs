using Eremite.Model.Orders;

namespace ATS_API.Orders;

public class NewOrderData : ASyncable<OrderModel>
{
    public OrderModel Model;

    public override void Sync(OrderModel model)
    {
        
    }
}