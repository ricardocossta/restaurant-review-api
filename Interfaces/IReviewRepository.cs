using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReviewById(int id);
        ICollection<Review> GetReviewsOfRestaurant(int restaurantId);
        bool ReviewExists(int id);

    }
}
