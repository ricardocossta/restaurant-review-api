using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantCategory> RestaurantCategories { get; set; }
        public DbSet<RestaurantChef> RestaurantChefs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantCategory>()
                .HasKey(rc => new { rc.RestaurantId, rc.CategoryId });
            modelBuilder.Entity<RestaurantCategory>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.RestaurantCategories)
                .HasForeignKey(rc => rc.RestaurantId);
            modelBuilder.Entity<RestaurantCategory>()
                .HasOne(rc => rc.Category)
                .WithMany(c => c.RestaurantCategories)
                .HasForeignKey(rc => rc.CategoryId);

            modelBuilder.Entity<RestaurantChef>()
                .HasKey(rc => new { rc.RestaurantId, rc.ChefId });
            modelBuilder.Entity<RestaurantChef>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.RestaurantChefs)
                .HasForeignKey(rc => rc.RestaurantId);
            modelBuilder.Entity<RestaurantChef>()
                .HasOne(rc => rc.Chef)
                .WithMany(c => c.RestaurantChefs)
                .HasForeignKey(rc => rc.ChefId);
        }
    }
}
