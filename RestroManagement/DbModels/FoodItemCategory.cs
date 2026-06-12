namespace RestroManagement.DbModels
{
    public class FoodItemCategory
    {
        public int FoodItemId { get; set; }
        public FoodItem? FoodItem { get; set; }

        public int CategoryId { get; set; }
        public MenuCategory? Category { get; set; }
    }
}
