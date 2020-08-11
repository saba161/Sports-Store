using Sports_Store.Models.Pages;
using System.Collections.Generic;

namespace Sports_Store.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }

        Product GetProduct(long key);

        PagedList<Product> GetProduct(QueryOptions options);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void UpdateAll(Product[] products);

        void Delete(Product product);
    }
}
