using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels
{
    public class FoodItemPortion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FoodItemId { get; set; }
        
        [ForeignKey("FoodItemId")]
        public FoodItem? FoodItem { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; // e.g., "Full", "Half", "1kg", "Regular"

        public float Price { get; set; } // Selling Price
        
        public float Cost { get; set; } // Production Cost

        /// <summary>
        /// The base quantity this price refers to. 
        /// For Fixed: Usually 1.
        /// For Proportional: 1000 if price is per 1000g (1kg).
        /// </summary>
        public float BaseQuantity { get; set; } = 1;
    }
}
