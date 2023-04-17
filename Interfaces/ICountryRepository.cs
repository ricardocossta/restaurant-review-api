using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountryById(int id);
        Country GetCountryByChef(int chefId);
        ICollection<Chef> GetChefsByCountry(int countryId);
        bool CountryExists(int id);
    }
}
