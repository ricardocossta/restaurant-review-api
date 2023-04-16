using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class RestaurantDto
    {
        public RestaurantDto(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Address = restaurant.Address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
