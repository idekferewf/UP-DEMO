using System.Collections.Generic;

namespace ShoeStoreLib.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        void AddOrder(Order order);
        void EditOrder(Order order);
        void DeleteOrder(Order order);
    }
}
