using System;
using System.Collections.Generic;
using ShoeStoreLib.Models;

namespace ShoeStoreLib
{
    public class Order
    {
        private int _id;

        public int Id { get { return _id; } }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public PickupLocation PickupLocation { get; set; }

        public User User { get; set; }

        public int Code { get; set; }

        public string Status { get; set; }

        public List<OrderProductRecord> Products { get; set; }

        public string DisplayId { get { return $"{Id} / {OrderDate.Date.ToString("dd.MM.yyyy")}"; } }

        public Order(int id)
        {
            _id = id;
        }
    }
}
