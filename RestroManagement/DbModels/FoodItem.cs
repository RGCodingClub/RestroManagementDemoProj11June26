using System.ComponentModel.DataAnnotations;

namespace RestroManagement.DbModels
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float PricePerUnity { get; set; }
        public bool IsNonVeg { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
