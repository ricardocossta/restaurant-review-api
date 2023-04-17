using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class ReviewByReviewerDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public RestaurantDto Restaurant { get; set; }

        public ReviewByReviewerDto(Review review)
        {
            Id = review.Id;
            Rating = review.Rating;
            Comment = review.Comment;
            Restaurant = new RestaurantDto(review.Restaurant);
        }
    }
}
