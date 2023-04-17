using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repositories
{
    public class ChefRepository : IChefRepository
    {
        private readonly DataContext _context;
        public ChefRepository(DataContext context)
        {
            _context = context;
        }

        public bool ChefExists(int id)
        {
            return _context.Chefs.Any(c => c.Id == id);
        }

        public Chef GetChefById(int id)
        {
            return _context.Chefs.Where(c => c.Id == id).Include(c => c.Country).FirstOrDefault();
        }

        public ICollection<Chef> GetChefs()
        {
            return _context.Chefs.Include(c => c.Country).ToList();
        }

        public ICollection<Chef> GetChefsOfRestaurant(int restaurantId)
        {
            return _context.RestaurantChefs.Include(rc => rc.Chef.Country).Where(rc => rc.Restaurant.Id == restaurantId).Select(rc => rc.Chef).ToList();
        }

        public ICollection<Restaurant> GetRestaurantsOfChef(int chefId)
        {
            return _context.RestaurantChefs.Where(rc => rc.Chef.Id == chefId).Select(rc => rc.Restaurant).ToList();
        }
    }
}
