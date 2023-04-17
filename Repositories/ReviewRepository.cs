using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context)
        {
            _context = context;
        }
        public Review GetReviewById(int id)
        {
            return _context.Reviews.Where(r => r.Id == id).Include(r => r.Restaurant).Include(r => r.Reviewer).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.Include(r => r.Restaurant).Include(r => r.Reviewer).OrderBy(r => r.Id).ToList();
        }

        public ICollection<Review> GetReviewsOfRestaurant(int restaurantId)
        {
            return _context.Reviews.Where(r => r.Restaurant.Id == restaurantId).Include(r => r.Restaurant).Include(r => r.Reviewer).ToList();
        }

        public bool ReviewExists(int id)
        {
            return _context.Reviews.Any(r => r.Id == id);
        }
    }
}
