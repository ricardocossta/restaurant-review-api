using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Repositories;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet("get-all-countries")]
        public IActionResult GetCountries()
        {
            var restaurants = _countryRepository.GetCountries();
            return Ok(restaurants.Select(c => new CountryDto(c)));
        }

        [HttpGet("get-country/{id}")]
        public IActionResult GetCountryById(int id)
        {
            if (!_countryRepository.CountryExists(id))
                return NotFound();

            var country = _countryRepository.GetCountryById(id);
            return Ok(new CountryDto(country));
        }

        [HttpGet("get-country-by-chef/{chefId}")]
        public IActionResult GetCountryByChef(int chefId)
        {

            var country = _countryRepository.GetCountryByChef(chefId);
            if (country == null) return NotFound(); 
            return Ok(new CountryDto(country));
        }

        [HttpGet("get-chefs-by-country-id/{countryId}")]
        public IActionResult GetChefsByCountry(int countryId)
        {

            var chefs = _countryRepository.GetChefsByCountry(countryId);
            return Ok(chefs.Select(c => new ChefDto(c)));
        }


    }
}
