namespace RestaurantReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RestaurantCategory> RestaurantCategories { get; set; }
    }
}
