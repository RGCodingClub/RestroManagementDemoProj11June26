using System.ComponentModel.DataAnnotations;

namespace RestroManagement.ViewModels
{
    public class MerchantRegistrationViewModel
    {
        // User Details
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "The phone number must be exactly 10 digits.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        // Merchant Details
        [Required(ErrorMessage = "Store Name is required")]
        [StringLength(100)]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Store Description")]
        public string? StoreDescription { get; set; }

        [Required(ErrorMessage = "Business License is required")]
        [StringLength(50)]
        [Display(Name = "Business License / Tax ID")]
        public string BusinessLicense { get; set; } = string.Empty;

        [Required(ErrorMessage = "Store Address is required")]
        [StringLength(200)]
        [Display(Name = "Store Address")]
        public string StoreAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "State is required")]
        [StringLength(100)]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Zip Code is required")]
        [StringLength(10)]

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } = string.Empty;

        [StringLength(200)]
        [Url(ErrorMessage = "Invalid Website URL")]
        public string? Website { get; set; }

        [Required(ErrorMessage = "Business Type is required")]
        [Display(Name = "Business Type")]
        public List<string> BusinessType { get; set; } = new List<string>();
       
    }
}
