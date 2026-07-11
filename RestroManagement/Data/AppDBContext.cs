using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using RestroManagement.DbModels;
using RestroManagement.DbModels.User;
using RestroManagement.ViewModels;

namespace RestroManagement.Data
{
    public class AppDBContext : IdentityDbContext<AppUser, IdentityRole<int>, int>

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
        public DbSet<FoodItemImage> FoodItemImages { get; set; }
        public DbSet<StoreFoodItemAvailability> StoreFoodItemAvailabilities { get; set; }

        // Master Data
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        // Merchant Management
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<MerchantStaff> MerchantStaffs { get; set; }
        
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


            modelBuilder.Entity<AppUser>().ToTable("AppUser");
            modelBuilder.SeedRoles();
            modelBuilder.SeedCountry();
            modelBuilder.SeedState();
            modelBuilder.SeedCities();
        }
    }
}
