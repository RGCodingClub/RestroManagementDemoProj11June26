
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RestroManagement.Data;
using RestroManagement.DbModels.User;
using System.Security.Claims;

namespace RestroManagement.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDBContext _dbContext;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITempDataDictionaryFactory _tempDataDictionaryFactory;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<AccountService> _logger;

        public AccountService(AppDBContext dbContext,
            IHttpContextAccessor httpContextAccessor,
            ITempDataDictionaryFactory tempDataDictionaryFactory,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<AccountService> logger)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
            _tempDataDictionaryFactory = tempDataDictionaryFactory;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public string GetLoggedInUser()
        {
            return _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }
        public string GetLoggedInUserId()
        {
            return _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
        public string GetLoggedInUserEmail()
        {
            return _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty;
        }
        public List<string> GetLoggedInUserRoles()
        {
            var roles = _httpContextAccessor.HttpContext?.User.FindAll(ClaimTypes.Role).Select(roleClaim => roleClaim.Value).ToList();
            return roles ?? new List<string>();
        }
        public string GetLayout()
        {
            var _layout = string.Empty;
            var roles = GetLoggedInUserRoles();
            if (roles.Contains("SuperAdmin"))
            {
                _layout = "~/Views/Shared/_AdminLayout.cshtml";
            }
            else if (roles.Contains("Merchant"))
            {
                _layout = "~/Views/Shared/_MerchantLayout.cshtml";
            }
            else if (roles.Contains("User"))
            { 
                _layout = "~/Views/Shared/_UserLayout.cshtml";
            }
            return _layout;
        }
        public async Task<bool> IsUserExist(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user != null;
        }
        public async Task<IdentityResult> AddUser(AppUser user, List<string> role)
        {
            _logger.LogInformation("Creating new user: {Email} with roles: {Roles}", user.Email, string.Join(", ", role));
            var result = await _userManager.CreateAsync(user, user.Password);
            if (result.Succeeded && role != null && role.Any())
            {
                _logger.LogInformation("Successfully created user: {Email}. Assigning roles.", user.Email);
                await _userManager.AddToRolesAsync(user, role).ConfigureAwait(false);
            }
            else if (!result.Succeeded)
            {
                _logger.LogWarning("Failed to create user: {Email}. Errors: {Errors}", user.Email, string.Join(", ", result.Errors.Select(e => e.Description)));
            }
            return result;
        }

         public async Task<IdentityResult> UpldateLoggedInUserPassword(string newEmail, string oldPassword, string newPassword)
        {
            // Get the logged-in user
            var principal = _httpContextAccessor.HttpContext?.User;
            if (principal == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User context not found." });
            }

            var user = await _userManager.GetUserAsync(principal);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found." });
            }

            // Verify the old password
            var passwordCheck = await _signInManager.CheckPasswordSignInAsync(user, oldPassword, false);
            if (!passwordCheck.Succeeded)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Incorrect old password." });
            }

            // Update the user's email
            user.Email = newEmail;
            var emailUpdateResult = await _userManager.UpdateAsync(user);
            if (!emailUpdateResult.Succeeded)
            {
                return emailUpdateResult;
            }

            // Update the user's password
            var passwordUpdateResult = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
            if (!passwordUpdateResult.Succeeded)
            {
                return passwordUpdateResult;
            }

            // Re-sign in the user to refresh the authentication cookie
            await _signInManager.RefreshSignInAsync(user);

            return IdentityResult.Success;
        }

 
        public async Task<bool> SignInUser(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return true;
            }
            return false;
        }

        public (int Month, int Year) GetSelectedPeriod()
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            int month = session?.GetInt32("SelectedMonth") ?? DateTime.Now.Month;
            int year = session?.GetInt32("SelectedYear") ?? DateTime.Now.Year;
            return (month, year);
        }

        public void SetSelectedPeriod(int month, int year)
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            session?.SetInt32("SelectedMonth", month);
            session?.SetInt32("SelectedYear", year);
        }

        public int? GetLoggedInUserMerchantId()
        {
            var userIdStr = GetLoggedInUserId();
            if (int.TryParse(userIdStr, out int userId))
            {
                var staff = _dbContext.MerchantStaffs
                    .FirstOrDefault(ms => ms.UserId == userId);
                return staff?.MerchantId;
            }
            return null;
        }
    }
}
