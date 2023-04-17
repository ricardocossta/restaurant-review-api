using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CountryDto(Country country)
        {
            Id = country.Id;
            Name = country.Name;
        }
    }
}
