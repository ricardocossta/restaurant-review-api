using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ReviewerDto(Reviewer reviewer)
        {
            Id = reviewer.Id;
            Name = reviewer.Name;
            Email = reviewer.Email;
        }
    }
}
