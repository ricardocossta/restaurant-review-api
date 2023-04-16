namespace RestaurantReviewApp.Models
{
    public class RestaurantChef
    {
        public int RestaurantId { get; set; }
        public int ChefId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Chef Chef { get; set; }
    }
}
