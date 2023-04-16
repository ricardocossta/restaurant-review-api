namespace RestaurantReviewApp.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public ICollection<RestaurantChef> RestaurantChefs { get; set; }
    }
}
