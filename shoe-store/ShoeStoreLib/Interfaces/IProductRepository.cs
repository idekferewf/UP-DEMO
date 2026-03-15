using System.Collections.Generic;

namespace ShoeStoreLib.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(Product product);
    }
}
