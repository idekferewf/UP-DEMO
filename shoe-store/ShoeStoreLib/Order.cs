using System;

namespace ShoeStoreLib
{
    public class Order
    {
        private int _id;

        public string Article { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public Address Address { get; set; }

        public User User { get; set; }

        public int Code { get; set; }

        public string Status {  get; set; }

        public Order(int id)
        {
            _id = id;
        }
    }
}
