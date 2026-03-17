namespace ShoeStoreLib
{
    public class Product
    {
        private string _article;

        public string Article { get { return _article; } }

        public string Name { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }

        public string Supplier { get; set; }

        public string Producer { get; set; }

        public string Category { get; set; }

        public int Discount { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string PhotoPath { get; set; }

        public string DisplayName { get {  return $"{Article} / {Name}"; } }

        public Product(string article)
        {
            _article = article;
        }
    }
}
