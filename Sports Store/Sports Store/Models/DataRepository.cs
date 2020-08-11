using Microsoft.EntityFrameworkCore;
using Sports_Store.Data;
using Sports_Store.Models.Pages;
using System.Collections.Generic;
using System.Linq;

namespace Sports_Store.Models
{
    public class DataRepository : IRepository
    {
        private AppDbContext context;

        public DataRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> Products =>
            context.Products
            .Include(x => x.Category)
            .ToArray();

        public void AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public void Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public Product GetProduct(long key)
        {
            var product = context.Products
                .Include(x => x.Category)
                .First(x => x.Id == key);
            return product;
        }

        public PagedList<Product> GetProduct(QueryOptions options)
        {
            if (options.CurrentPage == 0)
            {
                options.CurrentPage = 1;
            }
            var product = new PagedList<Product>(context.Products
                .Include(p => p.Category), options);

            return product;
        }

        public void UpdateAll(Product[] products)
        {
            //Dictionary<long, Product> data = products.ToDictionary(x => x.Id);

            //IEnumerable<Product> baseline =
            //    context.Products
            //    .Where(x => data.Keys.Contains(x.Id));

            //foreach (var item in baseline)
            //{
            //    Product requestProduct = data[item.Id];

            //    item.Name = requestProduct.Name;
            //    item.Category = requestProduct.Category;
            //    item.PurchasePrice = requestProduct.PurchasePrice;
            //    item.RetailPrice = requestProduct.RetailPrice;
            //}

            foreach (var item in products)
            {
                var oldProducts = context.Products.Find(item.Id);

                oldProducts.Category = item.Category;
                oldProducts.Name = item.Name;
                oldProducts.PurchasePrice = item.PurchasePrice;
                oldProducts.RetailPrice = item.RetailPrice;
            }

            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            Product p = context.Products.Find(product.Id);

            p.Name = product.Name;
            p.PurchasePrice = product.PurchasePrice;
            p.RetailPrice = product.RetailPrice;
            p.CategoryId = product.CategoryId;

            context.SaveChanges();
        }
    }
}
