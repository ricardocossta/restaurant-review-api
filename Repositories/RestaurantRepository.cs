using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public DataContext _context;

        public RestaurantRepository(DataContext context)
        {
            _context = context;
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _context.Restaurants.Where(p => p.Id == id).FirstOrDefault();
        }

        public Restaurant GetRestaurantByName(string name)
        {
            return _context.Restaurants.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Restaurant> GetRestaurants()
        {
            return _context.Restaurants.ToList();
        }

        public decimal GetResturantRating(int id)
        {
            var reviews = _context.Reviews.Where(r => r.Restaurant.Id == id);
            if (reviews.Count() <= 0)
                return 0;

            decimal rating = ((decimal) reviews.Sum(r => r.Rating)) / reviews.Count();
            return Math.Round(rating, 2);
        }

        public bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(r => r.Id == id);
        }
    }
}
