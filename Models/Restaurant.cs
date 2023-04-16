namespace RestaurantReviewApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpeningDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<RestaurantChef> RestaurantChefs { get; set; }
        public ICollection<RestaurantCategory> RestaurantCategories { get; set; }
    }
}
