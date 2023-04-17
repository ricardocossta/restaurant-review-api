using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Data;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;
        public CountryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);
        }
         
        public ICollection<Chef> GetChefsByCountry(int countryId)
        {
            return _context.Chefs.Where(c => c.Country.Id == countryId).Include(c => c.Country).ToList();
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountryByChef(int chefId)
        {
            return _context.Chefs.Where(c => c.Id == chefId).Select(c => c.Country).FirstOrDefault();
        }

        public Country GetCountryById(int id)
        {
            return _context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
