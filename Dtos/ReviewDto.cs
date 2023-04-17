using RestaurantReviewApp.Models;
using System.Text.Json.Serialization;

namespace RestaurantReviewApp.Dtos
{
    internal class ReviewDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public RestaurantDto Restaurant { get; set; }
        public ReviewerDto Reviewer { get; set; }

        public ReviewDto(Review review)
        {
            Id = review.Id;
            Rating = review.Rating;
            Comment = review.Comment;
            Restaurant = new RestaurantDto(review.Restaurant);
            Reviewer = new ReviewerDto(review.Reviewer);
        }
    }
}