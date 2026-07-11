using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels
{
    public class StoreFoodItemAvailability
    {
        [Key]
        public int Id { get; set; }

        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store? Store { get; set; }

        public int FoodItemId { get; set; }
        [ForeignKey("FoodItemId")]
        public FoodItem? FoodItem { get; set; }

        public bool IsAvailable { get; set; }
    }
}
