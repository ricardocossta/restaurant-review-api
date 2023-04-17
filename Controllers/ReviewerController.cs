using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewApp.Dtos;
using RestaurantReviewApp.Interfaces;

namespace RestaurantReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewerController : ControllerBase
    {
        private readonly IReviewerRepository _reviewerRepository;

        public ReviewerController(IReviewerRepository reviewerRepository)
        {
            _reviewerRepository = reviewerRepository;
        }

        [HttpGet("get-all-reviewers")]
        public IActionResult GetReviewers()
        {
            var reviewers = _reviewerRepository.GetReviewers();
            return Ok(reviewers.Select(r => new ReviewerDto(r)));
        }

        [HttpGet("get-reviewer-with-reviews/{id}")]
        public IActionResult GetReviewer(int id)
        {
            if (!_reviewerRepository.ReviewerExists(id)) return NotFound();
            var reviewer = _reviewerRepository.GetReviewerById(id);
            return Ok(new ReviewerWithReviewsDto(reviewer));
        }

        [HttpGet("get-reviews-by-reviewer/{reviewerId}")]
        public IActionResult GetReviewsByReviewer(int reviewerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviewerId)) return NotFound();
            var reviews = _reviewerRepository.GetReviewsByReviewer(reviewerId);
            return Ok(reviews.Select(r => new ReviewByReviewerDto(r)));
        }


    }
}
