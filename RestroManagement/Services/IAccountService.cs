using Microsoft.AspNetCore.Identity;
using RestroManagement.DbModels.User;

namespace RestroManagement.Services
{
    public interface IAccountService
    {
        public string GetLoggedInUser();
        public string GetLoggedInUserId();
        public string GetLoggedInUserEmail();
        public List<string> GetLoggedInUserRoles();
        public string GetLayout();

        public Task<bool> IsUserExist(string email);
        public Task<IdentityResult> AddUser(AppUser user, List<string> role);
        public Task<IdentityResult> UpldateLoggedInUserPassword(string Email, string oldPassword, string newPassword);
        public Task<bool> SignInUser(string userName);

        // Period Management
        public (int Month, int Year) GetSelectedPeriod();
        public void SetSelectedPeriod(int month, int year);

        public int? GetLoggedInUserMerchantId();
    }
}
