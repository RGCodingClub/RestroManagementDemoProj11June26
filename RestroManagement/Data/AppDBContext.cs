using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using RestroManagement.DbModels;

namespace RestroManagement.Data
{
    public class AppDBContext : DbContext

    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<FoodItem> Fooditems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<FoodItemCategory> FoodItemCategories { get; set; }
        public DbSet<FoodItemPortion> FoodItemPortions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Many-to-Many relationship for FoodItem and MenuCategory
            modelBuilder.Entity<FoodItemCategory>()
                .HasKey(fc => new { fc.FoodItemId, fc.CategoryId });

            modelBuilder.Entity<FoodItemCategory>()
                .HasOne(fc => fc.FoodItem)
                .WithMany(f => f.Categories)
                .HasForeignKey(fc => fc.FoodItemId);

            modelBuilder.Entity<FoodItemCategory>()
                .HasOne(fc => fc.Category)
                .WithMany(c => c.FoodItemCategories)
                .HasForeignKey(fc => fc.CategoryId);
        }
    }
}
