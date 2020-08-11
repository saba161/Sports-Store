using Sports_Store.Models;
using Sports_Store.Models.Pages;
using System.Collections.Generic;

namespace Sports_Store.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        PagedList<Category> GetCategories(QueryOptions options);
    }
}