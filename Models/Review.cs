namespace RestaurantReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Restaurant Restaurant { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
