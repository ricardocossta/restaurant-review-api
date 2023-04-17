using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class ReviewerWithReviewsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<ReviewByReviewerDto> Reviews { get; set; }


        public ReviewerWithReviewsDto(Reviewer reviewer)
        {
            Id = reviewer.Id;
            Name = reviewer.Name;
            Email = reviewer.Email;
            Reviews = new List<ReviewByReviewerDto>();

            foreach (var review in reviewer.Reviews)
            {
                Reviews.Add(new ReviewByReviewerDto(review));
            }

        }
    }
}
