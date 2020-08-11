using Sports_Store.Data;
using Sports_Store.Models.Pages;
using System.Collections.Generic;

namespace Sports_Store.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext context;

        public CategoryRepository(AppDbContext ctx) => context = ctx;

        public IEnumerable<Category> Categories => context.Categories;

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public PagedList<Category> GetCategories(QueryOptions options)
        {
            if (options.CurrentPage == 0)
            {
                options.CurrentPage = 1;
            }
            var products = new PagedList<Category>(context.Categories, options);
            return products;
        }
    }
}