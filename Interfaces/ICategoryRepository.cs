using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategoryById(int id);
        ICollection<Restaurant> GetRestaurantsByCategory(int categoryId);
        bool CategoryExists(int id);
    }
}
