using RestaurantReviewApp.Data;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            var r1 = new Reviewer() { Name = "João", Email = "joão@gmail.com" };
            var r2 = new Reviewer() { Name = "Ricardo", Email = "ricardo@gmail.com" };
            var r3 = new Reviewer() { Name = "Jorge", Email = "jorge@gmail.com" };
            if (!dataContext.RestaurantChefs.Any())
            {
                var restaurantChefs = new List<RestaurantChef>()
                {
                    new RestaurantChef()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Restaurante da Célia",
                            Address = "Rua XYZ",
                            OpeningDate = new DateTime(2022,12,05),
                            RestaurantCategories = new List<RestaurantCategory>()
                            {
                                new RestaurantCategory { Category = new Category() { Name = "Familiar"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review {Comment = "É um ótimo restaurante para ir com a familia", Rating = 5,
                                Reviewer = r1 },
                                new Review {Comment = "Legal para ir as vezes", Rating = 4,
                                Reviewer = r2 },
                                new Review {Comment = "Não gosto desse restaurante", Rating = 2,
                                Reviewer = r3 },
                            }
                        },
                        Chef = new Chef()
                        {
                            FirstName = "Célia",
                            LastName = "Silva",
                            Country = new Country()
                            {
                                Name = "Brasil"
                            }
                        }
                    },
                    new RestaurantChef()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Hamburgão da massa",
                            Address = "Rua das Laranjeiras",
                            OpeningDate = new DateTime(2020,07,22),
                            RestaurantCategories = new List<RestaurantCategory>()
                            {
                                new RestaurantCategory { Category = new Category() { Name = "Fast Food"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review {Comment = "Legal para um lanche rápido", Rating = 4,
                                Reviewer = r1 },
                                new Review {Comment = "Não gosto da localização", Rating = 2,
                                Reviewer = r2 },
                                new Review {Comment = "Excelente", Rating = 5,
                                Reviewer = r3 },
                            }
                        },
                        Chef = new Chef()
                        {
                            FirstName = "Henrique",
                            LastName = "Jesus",
                            Country = new Country()
                            {
                                Name = "Brasil"
                            }
                        }
                    },
                    new RestaurantChef()
                    {
                        Restaurant = new Restaurant()
                        {
                            Name = "Italian House",
                            Address = "Via de’ Tornabuoni",
                            OpeningDate = new DateTime(1980,05,12),
                            RestaurantCategories = new List<RestaurantCategory>()
                            {
                                new RestaurantCategory { Category = new Category() { Name = "Massas"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review {Comment = "Execelente lugar, muito aconchegante", Rating = 5,
                                Reviewer = r1 },
                                new Review {Comment = "Não gostei do atendimento, estava super lotado no dia que fui", Rating = 2,
                                Reviewer = r2 },
                                new Review {Comment = "Bacana, mas um pouco caro", Rating = 3,
                                Reviewer = r3 },
                            }
                        },
                        Chef = new Chef()
                        {
                            FirstName = "Francesco",
                            LastName = "Mattia",
                            Country = new Country()
                            {
                                Name = "Italia"
                            }
                        }
                    },
                };
                dataContext.RestaurantChefs.AddRange(restaurantChefs);
                dataContext.SaveChanges();
            }
        }
    }
}
