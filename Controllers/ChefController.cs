using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Repositories;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly IChefRepository _chefRepository;

        public ChefController(IChefRepository chefRepository)
        {
            _chefRepository = chefRepository;
        }

        [HttpGet("get-all-chefs")]
        public IActionResult GetCategories()
        {
            var chefs = _chefRepository.GetChefs();
            return Ok(chefs.Select(c => new ChefDto(c)));
        }

        [HttpGet("get-chef/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            if (!_chefRepository.ChefExists(id))
                return NotFound();

            var chef = _chefRepository.GetChefById(id);
            return Ok(new ChefDto(chef));
        }

        [HttpGet("get-chefs-by-restaurant/{restaurantId}")]
        public IActionResult GetChefsOfRestaurant(int restaurantId)
        {
            var chefs = _chefRepository.GetChefsOfRestaurant(restaurantId);
            if (chefs == null) return NotFound();
            return Ok(chefs.Select(c => new ChefDto(c)));
        }

        [HttpGet("get-restaurants-by-chef/{chefId}")]
        public IActionResult GetRestaurantsOfChef(int chefId)
        {
            var restaurants = _chefRepository.GetRestaurantsOfChef(chefId);
            if (restaurants == null) return NotFound();
            return Ok(restaurants.Select(r => new RestaurantDto(r)));
        }
    }
}
