using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        [HttpGet]
        public IActionResult GetRestaurants()
        {
            var restaurants = _restaurantRepository.GetRestaurants();
            return Ok(restaurants.Select(r => new RestaurantDto(r)));
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurantById(int id)
        {
            if (!_restaurantRepository.RestaurantExists(id))
                return NotFound();

            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return Ok(new RestaurantDto(restaurant));
        }

        [HttpGet("{id}/rating")]
        public IActionResult GetRestaurantRating(int id)
        {
            if (!_restaurantRepository.RestaurantExists(id))
                return NotFound();

            return Ok(_restaurantRepository.GetResturantRating(id));
        }
    }
}
