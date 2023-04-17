using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface IChefRepository
    {
        ICollection<Chef> GetChefs();
        Chef GetChefById(int id);
        ICollection<Chef> GetChefsOfRestaurant(int restaurantId);
        ICollection<Restaurant> GetRestaurantsOfChef(int chefId);
        bool ChefExists(int id);
    }
}
