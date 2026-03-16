using System.Collections.Generic;
using System.Linq;
using ShoeStoreLib.Interfaces;

namespace ShoeStoreLib.Services
{
    public class ProductService
    {
        private IProductRepository repository_;

        public ProductService(IProductRepository repository)
        {
            repository_ = repository;
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

        public bool HasArticle(string article)
        {
            return GetAllProducts().Any(p => p.Article == article);
        }

        public List<Product> SearchAndFilterProducts(List<Product> products, string search, string supplier)
        {
            string searchLower = search?.ToLower();

            return products
                .Where(p =>
                {
                    bool matchesSearch = string.IsNullOrEmpty(searchLower) ||
                        (p.Article?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Name?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Unit?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Supplier?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Producer?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Category?.ToLower().Contains(searchLower) ?? false) ||
                        (p.Description?.ToLower().Contains(searchLower) ?? false);

                    bool matchesSupplier = supplier == "Все поставщики" ||
                        p.Supplier == supplier;

                    return matchesSearch && matchesSupplier;
                })
                .ToList();
        }
    }
}
