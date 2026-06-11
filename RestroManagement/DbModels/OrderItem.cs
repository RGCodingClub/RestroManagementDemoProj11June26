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

        public float Quantity { get; set; }

        [NotMapped]
        public float Price { get { return FoodItem?.PricePerUnity ?? 0 * Quantity; } }
    }
}
