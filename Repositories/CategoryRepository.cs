using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Restaurant> GetRestaurantsByCategory(int categoryId)
        {
            var restaurants = _context.RestaurantCategories.Where(rc => rc.CategoryId == categoryId).Select(rc => rc.Restaurant);
            return restaurants.ToList();
        }
    }
}
