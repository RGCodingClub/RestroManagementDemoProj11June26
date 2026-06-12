using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int FoodItemId { get; set; }
        [ForeignKey("FoodItemId")]
        public FoodItem? FoodItem { get; set; }

        public int? FoodItemPortionId { get; set; }
        [ForeignKey("FoodItemPortionId")]
        public FoodItemPortion? Portion { get; set; }

        public float Quantity { get; set; }

        public float Price { get; set; } // Stored price snapshot
    }
}
