namespace RestroManagement.ViewModels
{
    public class profile
    { 
            public string FName { get; set; }
            public string LName { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Gender { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime? DateOfBirth { get; set; }
            public string Address { get; set; }
        

        public int TotalOrders { get; set; }
            public int RewardPoints { get; set; }
            public int Reservations { get; set; }
            public int FavoriteItems { get; set; }
        
    }
}
