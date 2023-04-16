using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface IRestaurantRepository
    {
        ICollection<Restaurant> GetRestaurants();
        Restaurant GetRestaurantById(int id);
        Restaurant GetRestaurantByName(string name);
        decimal GetResturantRating(int id);
        bool RestaurantExists(int id);


    }
}
