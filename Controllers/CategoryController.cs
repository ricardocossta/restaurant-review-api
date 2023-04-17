using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Repositories;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("get-all-categories")]
        public IActionResult GetCategories()
        {
            var categories = _categoryRepository.GetCategories();
            return Ok(categories.Select(c => new CategoryDto(c)));
        }

        [HttpGet("get-category/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            if (!_categoryRepository.CategoryExists(id))
                return NotFound();

            var category = _categoryRepository.GetCategoryById(id);
            return Ok(new CategoryDto(category));
        }

        [HttpGet("get-restaurants-by-category-id/{categoryId}")]
        public IActionResult GetRestaurantsByCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var restaurants = _categoryRepository.GetRestaurantsByCategory(categoryId);
            return Ok(restaurants.Select(r => new RestaurantDto(r)));
        }
    }
}
