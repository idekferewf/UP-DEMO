namespace ShoeStoreLib
{
    public class Address
    {
        private int _id;

        public string Destination { get; set; }

        public Address(int id)
        {
            _id = id;
        }
    }
}
