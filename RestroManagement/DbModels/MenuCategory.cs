using System.ComponentModel.DataAnnotations;

namespace RestroManagement.DbModels
{
    public class MenuCategory
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public string? ImageUrl { get; set; }
        
        public int DisplayOrder { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<FoodItemCategory>? FoodItemCategories { get; set; }
    }
}
