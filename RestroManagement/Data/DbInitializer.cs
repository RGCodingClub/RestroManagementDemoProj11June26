using Microsoft.EntityFrameworkCore;
using RestroManagement.DbModels;
using System.Collections.Generic;
using System.Linq;

namespace RestroManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDBContext context)
        {
            context.Database.EnsureCreated();

            // Check if already seeded
            if (context.Fooditems.Any())
            {
                return; // DB has been seeded
            }

            // 1. Seed Categories
            var categories = new List<MenuCategory>
            {
                new MenuCategory { Name = "Starters", DisplayOrder = 1, ImageUrl = "https://images.unsplash.com/photo-1541529086526-db283c563270?auto=format&fit=crop&q=80&w=200" },
                new MenuCategory { Name = "Main Course", DisplayOrder = 2, ImageUrl = "https://images.unsplash.com/photo-1585937421612-70a008356fbe?auto=format&fit=crop&q=80&w=200" },
                new MenuCategory { Name = "South Indian", DisplayOrder = 3, ImageUrl = "https://images.unsplash.com/photo-1589301760014-d929f3979dbc?auto=format&fit=crop&q=80&w=200" },
                new MenuCategory { Name = "Chinese", DisplayOrder = 4, ImageUrl = "https://images.unsplash.com/photo-1525755662778-989d0524087e?auto=format&fit=crop&q=80&w=200" },
                new MenuCategory { Name = "Continental", DisplayOrder = 5, ImageUrl = "https://images.unsplash.com/photo-1551183053-bf91a1d81141?auto=format&fit=crop&q=80&w=200" },
                new MenuCategory { Name = "Desserts", DisplayOrder = 6, ImageUrl = "https://images.unsplash.com/photo-1551024506-0bccd828d307?auto=format&fit=crop&q=80&w=200" }
            };

            context.MenuCategories.AddRange(categories);
            context.SaveChanges();

            // 2. Seed Food Items
            var items = new List<FoodItem>
            {
                // Starters
                new FoodItem { 
                    Name = "Paneer Tikka", 
                    Description = "Soft cottage cheese chunks marinated in spices and grilled in tandoor (8 pcs).", 
                    DietaryPreference = DietaryPreference.Vegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                new FoodItem { 
                    Name = "Chicken Tikka", 
                    Description = "Boneless chicken marinated in yogurt and tandoori spices (8 pcs).", 
                    DietaryPreference = DietaryPreference.NonVegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                // Main Course
                new FoodItem { 
                    Name = "Dal Makhani", 
                    Description = "Slow-cooked black lentils with butter and cream - A house specialty.", 
                    DietaryPreference = DietaryPreference.Vegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                new FoodItem { 
                    Name = "Butter Chicken", 
                    Description = "Tender tandoori chicken cooked in a rich, creamy tomato-based gravy.", 
                    DietaryPreference = DietaryPreference.NonVegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                // South Indian
                new FoodItem { 
                    Name = "Masala Dosa", 
                    Description = "Crispy rice crepe filled with spiced potato mash, served with sambar and chutney.", 
                    DietaryPreference = DietaryPreference.Vegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                // Chinese
                new FoodItem { 
                    Name = "Veg Manchow Soup", 
                    Description = "Spicy and tangy soup topped with crispy noodles.", 
                    DietaryPreference = DietaryPreference.Vegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Fixed,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                },
                // Desserts
                new FoodItem { 
                    Name = "Rabdi", 
                    Description = "Thickened sweetened milk with layers of malai. (Sold by weight)", 
                    DietaryPreference = DietaryPreference.Vegetarian,
                    PriceCalculationMethod = PriceCalculationMethod.Proportional,
                    IsAvailable = true,
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now
                }
            };

            context.Fooditems.AddRange(items);
            context.SaveChanges();

            // 3. Seed Portions & Pricing
            var portions = new List<FoodItemPortion>
            {
                // Paneer Tikka
                new FoodItemPortion { FoodItemId = items[0].Id, Name = "Full", Price = 450, Cost = 200, BaseQuantity = 1 },
                // Chicken Tikka
                new FoodItemPortion { FoodItemId = items[1].Id, Name = "Full", Price = 530, Cost = 280, BaseQuantity = 1 },
                // Dal Makhani
                new FoodItemPortion { FoodItemId = items[2].Id, Name = "Full", Price = 350, Cost = 120, BaseQuantity = 1 },
                new FoodItemPortion { FoodItemId = items[2].Id, Name = "Half", Price = 200, Cost = 70, BaseQuantity = 1 },
                // Butter Chicken
                new FoodItemPortion { FoodItemId = items[3].Id, Name = "Full", Price = 580, Cost = 300, BaseQuantity = 1 },
                new FoodItemPortion { FoodItemId = items[3].Id, Name = "Half", Price = 320, Cost = 170, BaseQuantity = 1 },
                // Masala Dosa
                new FoodItemPortion { FoodItemId = items[4].Id, Name = "Regular", Price = 200, Cost = 80, BaseQuantity = 1 },
                // Veg Manchow Soup
                new FoodItemPortion { FoodItemId = items[5].Id, Name = "Bowl", Price = 180, Cost = 60, BaseQuantity = 1 },
                // Rabdi (Proportional)
                new FoodItemPortion { FoodItemId = items[6].Id, Name = "1kg", Price = 800, Cost = 400, BaseQuantity = 1000 }
            };

            context.FoodItemPortions.AddRange(portions);
            context.SaveChanges();

            // 4. Seed Images
            var images = new List<FoodItemImage>
            {
                new FoodItemImage { FoodItemId = items[0].Id, ImageUrl = "https://images.unsplash.com/photo-1567184109191-37a3ac0f012e?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[1].Id, ImageUrl = "https://images.unsplash.com/photo-1599481238640-4c1288750d7a?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[2].Id, ImageUrl = "https://images.unsplash.com/photo-1546833999-b9f581a1996d?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[3].Id, ImageUrl = "https://images.unsplash.com/photo-1603894584713-f484439d3b7c?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[4].Id, ImageUrl = "https://images.unsplash.com/photo-1589301760014-d929f3979dbc?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[5].Id, ImageUrl = "https://images.unsplash.com/photo-1512058564366-18510be2db19?auto=format&fit=crop&q=80&w=400", IsPrimary = true },
                new FoodItemImage { FoodItemId = items[6].Id, ImageUrl = "https://images.unsplash.com/photo-1589301760014-d929f3979dbc?auto=format&fit=crop&q=80&w=200", IsPrimary = true }
            };

            context.FoodItemImages.AddRange(images);
            context.SaveChanges();

            // 5. Map Items to Categories
            var mapping = new List<FoodItemCategory>
            {
                new FoodItemCategory { FoodItemId = items[0].Id, CategoryId = categories[0].Id }, // Paneer Tikka -> Starter
                new FoodItemCategory { FoodItemId = items[1].Id, CategoryId = categories[0].Id }, // Chicken Tikka -> Starter
                new FoodItemCategory { FoodItemId = items[2].Id, CategoryId = categories[1].Id }, // Dal Makhani -> Main
                new FoodItemCategory { FoodItemId = items[3].Id, CategoryId = categories[1].Id }, // Butter Chicken -> Main
                new FoodItemCategory { FoodItemId = items[4].Id, CategoryId = categories[2].Id }, // Masala Dosa -> South Indian
                new FoodItemCategory { FoodItemId = items[5].Id, CategoryId = categories[3].Id }, // Manchow Soup -> Chinese
                new FoodItemCategory { FoodItemId = items[6].Id, CategoryId = categories[5].Id }  // Rabdi -> Dessert
            };

            context.FoodItemCategories.AddRange(mapping);
            context.SaveChanges();
        }
    }
}
