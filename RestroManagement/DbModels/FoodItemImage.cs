using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels
{
    public class FoodItemImage
    {
        [Key]
        public int Id { get; set; }

        public int FoodItemId { get; set; }
        
        [ForeignKey("FoodItemId")]
        public FoodItem? FoodItem { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public bool IsPrimary { get; set; }
    }
}
