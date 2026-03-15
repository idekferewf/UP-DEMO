namespace ShoeStoreLib
{
    public class PickupLocation
    {
        private int _id;

        public int Id { get { return _id; } }

        public string Address { get; set; }

        public PickupLocation(int id)
        {
            _id = id;
        }
    }
}
