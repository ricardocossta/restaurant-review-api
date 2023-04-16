namespace RestaurantReviewApp.Models
{
    public class RestaurantCategory
    {
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Category Category { get; set; }
    }
}
