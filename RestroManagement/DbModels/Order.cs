using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public List<OrderItem>? Items { get; set; } = null;
        public DateTime OrderDate { get; set; }
        [NotMapped]
        public float TotalPrice
        {
            get
            {
                if (Items == null) return 0;
                float total = 0;
                foreach (var item in Items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        [NotMapped]
        public float OrderTotal { get { return (TotalPrice + (TotalPrice * SGST) + (TotalPrice * CGST) + PackagingCharges); } }
        //-----------------------------------------------------------------------------------------

        [NotMapped]
        public float SGST { get { return (TotalPrice * .05f); } }
        [NotMapped]
        public float PriceAfterSGST { get { return TotalPrice + SGST; } }
        [NotMapped]
        public float CGST { get { return (TotalPrice * .05f); } }
        [NotMapped]
        public float PriceAfterCGST { get { return TotalPrice + CGST; } }
        public float PackagingCharges { get; set; }=0;
        [NotMapped]
        public float PriceAfterPackingCharges { get { return TotalPrice + PackagingCharges; } }
        public float Discount { get; set; } = 0;
        [NotMapped]
        public float PriceAfterDiscount { get { return TotalPrice + Discount; } }

    }
}
