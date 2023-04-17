using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class ChefDto
    {
        public ChefDto(Chef chef)
        {
            Id = chef.Id;
            FirstName = chef.FirstName;
            LastName = chef.LastName;
            Country = new CountryDto(chef.Country);
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CountryDto Country { get; set; }
    }
}
