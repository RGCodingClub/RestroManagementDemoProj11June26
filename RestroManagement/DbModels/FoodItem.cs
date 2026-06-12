using System.ComponentModel.DataAnnotations;

namespace RestroManagement.DbModels
{
    public enum PriceCalculationMethod
    {
        Fixed,        // Price is fixed per portion (e.g., Full/Half Noodles)
        Proportional  // Price is calculated based on quantity (e.g., 250g of Rabdi based on 1kg price)
    }

    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public DietaryPreference DietaryPreference { get; set; }
        public bool IsAvailable { get; set; }
        
        // Defines if price is fixed per portion or calculated proportionally
        public PriceCalculationMethod PriceCalculationMethod { get; set; } = PriceCalculationMethod.Fixed;

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }

        // Navigation properties
        public ICollection<FoodItemPortion>? Portions { get; set; }
        public ICollection<FoodItemCategory>? Categories { get; set; }
    }
}
