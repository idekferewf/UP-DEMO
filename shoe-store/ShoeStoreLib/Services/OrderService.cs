using ShoeStoreLib.Interfaces;
using ShoeStoreLib.Models;
using ShoeStoreLib.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ShoeStoreLib.Services
{
    public class OrderService
    {
        private IOrderRepository repository_;

        public OrderService()
        {
            repository_ = new MySQLOrderRepository();
        }

        public List<Order> GetAllOrders()
        {
            return repository_.GetAllOrders();
        }

        public void AddOrder(Order order)
        {
            repository_.AddOrder(order);
        }

        public void EditOrder(Order order)
        {
            repository_.EditOrder(order);
        }

        public void DeleteOrder(Order order)
        {
            repository_.DeleteOrder(order);
        }

        public bool CheckArticle(Product product)
        {
            return GetAllOrders()
                .SelectMany(o => o.Products)
                .Any(op => op.Article.Contains(product.Article));
        }

        public int GenerateNextId()
        {
            List<Order> orders = GetAllOrders();
            return orders.Any() ? orders.Max(o => o.Id) + 1 : 1;
        }
    }
}
