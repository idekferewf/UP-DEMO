using System.Collections.Generic;
using System.Linq;
using ShoeStoreLib.Interfaces;
using ShoeStoreLib.Repositories;

namespace ShoeStoreLib.Services
{
    public class ProductService
    {
        private IProductRepository repository_;

        public ProductService()
        {
            repository_ = new MySQLProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return repository_.GetAllProducts();
        }

        public List<string> GetAllSuppliers()
        {
            List<Product> products = repository_.GetAllProducts();

            List<string> suppliers = products
                .Select(p => p.Supplier)
                .Distinct()
                .Prepend("Все поставщики")
                .ToList();

            return suppliers;
        }

        public void AddProduct(Product product)
        {
            repository_.AddProduct(product);
        }

        public void EditProduct(Product product)
        {
            repository_.EditProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            repository_.DeleteProduct(product);
        }
    }
}
