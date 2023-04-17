using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;
using RestaurantReviewApp.Repositories;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpGet("get-all-reviews")]
        public IActionResult GetReviews()
        {
            var reviews = _reviewRepository.GetReviews();
            return Ok(reviews.Select(r => new ReviewDto(r)));
        }

        [HttpGet("get-review/{id}")]
        public IActionResult GetReviews(int id)
        {
            if (!_reviewRepository.ReviewExists(id)) return NotFound();

            var review = _reviewRepository.GetReviewById(id);
            return Ok(new ReviewDto(review));
        }

        [HttpGet("get-reviews-of-restaurant/{restaurantId}")]
        public IActionResult GetReviewsOfRestaurant(int restaurantId)
        {
            var reviews = _reviewRepository.GetReviewsOfRestaurant(restaurantId);
            return Ok(reviews.Select(r => new ReviewDto(r)));
        }
    }
}
