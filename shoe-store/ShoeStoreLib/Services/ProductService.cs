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
            return GetAllProducts()
                .Select(p => p.Supplier)
                .Distinct()
                .Prepend("Все поставщики")
                .ToList();
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

        public List<Product> SearchAndFilterProducts(List<Product> products, string search, string supplier)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    product.Article.ToLower().Contains(search.ToLower()) ||
                    product.Name.ToLower().Contains(search.ToLower()) ||
                    product.Unit.ToLower().Contains(search.ToLower()) ||
                    product.Supplier.ToLower().Contains(search.ToLower()) ||
                    product.Producer.ToLower().Contains(search.ToLower()) ||
                    product.Category.ToLower().Contains(search.ToLower()) ||
                    product.Description.ToLower().Contains(search.ToLower());

                bool matchesSupplier = supplier == "Все поставщики" ||
                      product.Supplier == supplier;

                if (matchesSearch && matchesSupplier)
                {
                    result.Add(product);
                }
            }

            return result;
        }
    }
}
