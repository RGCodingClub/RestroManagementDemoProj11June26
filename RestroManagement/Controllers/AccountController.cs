using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using RestroManagement.DbModels;
using RestroManagement.DbModels.User;
using RestroManagement.Services;
using RestroManagement.ViewModels;

namespace RestroManagement.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDBContext _context;
        private readonly IAccountService _userService;
        private readonly ILogger<AccountController> _logger;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDBContext context, IAccountService userService, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _userService = userService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUser model)
        {
            model.UserRole = "GUEST";
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Attempting to register user with email: {Email}", model.Email);
                model.UserName = model.Email;
                // Hardcode role to User for standard registration
                var result = await _userService.AddUser(model, new List<string> { "GUEST" });
                if (result.Succeeded)
                {
                    _logger.LogInformation("User {Email} registered successfully.", model.Email);
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
                    return await ReDirectIfLoggedIn();
                }
                foreach (var error in result.Errors)
                {
                    _logger.LogWarning("User registration failed for {Email}: {Error}", model.Email, error.Description);
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult RegisterMerchant()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterMerchant(MerchantRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FName = model.FName,
                    LName = model.LName,
                    PhoneNumber = model.PhoneNumber,
                    Password = model.Password
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Restaurant");

                    var merchant = new Merchant
                    {
                        CompanyName = model.StoreName,
                        BusinessLicense = model.BusinessLicense,
                        Description = $"{model.StoreDescription} | Type: {model.BusinessType} | Website: {model.Website}",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        IsVerified = false
                    };

                    _context.Merchants.Add(merchant);
                    await _context.SaveChangesAsync();

                    var fullAddress = $"{model.StoreAddress}, {model.City}, {model.State} - {model.ZipCode}";

                    var store = new Store
                    {
                        MerchantId = merchant.UniqueId,
                        StoreName = model.StoreName,
                        StoreAddress = fullAddress,
                        StoreDescription = model.StoreDescription,
                        CreatedDate = DateTime.Now,
                        IsActive = true
                    };
                    _context.Stores.Add(store);

                    var staff = new MerchantStaff
                    {
                        MerchantId = merchant.UniqueId,
                        UserId = user.Id,
                        Role = MerchantStaffRole.POC,
                        Designation = "Owner/Registrar",
                        CreatedDate = DateTime.Now
                    };
                    _context.MerchantStaffs.Add(staff);

                    await _context.SaveChangesAsync();

                    await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, lockoutOnFailure: false);

                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
            //return await ReDirectIfLoggedIn();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Login attempt for user: {UserName}", model.LoginUserName);
                var result = await _signInManager.PasswordSignInAsync(model.LoginUserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User {UserName} logged in successfully.", model.LoginUserName);
                    return await ReDirectIfLoggedIn();
                }
                
                else
                {
                    _logger.LogWarning("Invalid login attempt for user: {UserName}", model.LoginUserName);
                    ModelState.AddModelError("", "Invalid Email Id or Password");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> ReDirectIfLoggedIn()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return View("Login");
                } ///Guest/Home/index
                var roles = await _userManager.GetRolesAsync(user);
                if (roles.Contains("Guest"))
                    return RedirectToAction("Index", "Home", new { area = "Guest" });

                else if (roles.Contains ("Restaurant"))
                    return RedirectToAction("Index", "Home", new { area = "Restaurant" });

                else if (roles.Contains("SuperAdmin"))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                else 
                    return RedirectToAction("Index", "Home");
            }
            else
                return View("Login");
        }

        public async Task<IActionResult> ChangePassword()
        {
            ViewBag.Layout = _userService.GetLayout();
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(UpdatePassword model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _userService.UpldateLoggedInUserPassword(model.NewEmail, model.OldPassword, model.NewPassword);
        //        if (result.Succeeded)
        //            return RedirectToAction(ViewBag.Layout);

        //        foreach (var error in result.Errors)
        //            ModelState.AddModelError(string.Empty, error.Description);
        //    }
        //    ViewBag.Layout = _userService.GetLayout();
        //    return View(model);
        //}
        //[HttpGet]
        //public async Task<IActionResult> ChangeEmail()
        //{
        //    var emailUpdate = new UpdateEmailVM() { };
        //    if (_signInManager.IsSignedIn(User))
        //    {
        //        var user = await _userManager.GetUserAsync(User);
        //        if (user != null)
        //        {
        //            emailUpdate.OldEmail = user.Email;
        //        }
        //    }
        //    ViewBag.Layout = _userService.GetLayout();
        //    return View(emailUpdate);
        //}
        //[HttpPost]
        //public async Task<IActionResult> ChangeEmail(UpdateEmailVM updateEmail)
        //{
        //    var result = await _userService.UpldateLoggedInUserEmail(updateEmail);
        //    ViewBag.Layout = _userService.GetLayout();
        //    return View(updateEmail);
        //}

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        //------------api ..........................


        public async Task<List<City>> GetCities() => await _context.Cities.ToListAsync();
        public async Task<List<City>> GetCitiesByStateId(int id) => await _context.Cities.Where(c => c.StateId == id).ToListAsync();
        public async Task<City> GetCity(int id) => await _context.Cities.FindAsync(id);

        // --- @ToDo : NOTE : Remove following methods while release.


        public async Task<string> CreateMasterUser()
        {
            var resultStr = string.Empty;
            try
            {
                // 1. Create the User
                AppUser appUser = new AppUser()
                {
                    FName = "Ankit",
                    LName = "Sahay",
                    UserName = "ankit@bpst.com",
                    Email = "ankit@bpst.com",
                    EmailConfirmed = true,
                    PhoneNumber = "9999999999",
                };

                var userExists = await _userManager.FindByEmailAsync(appUser.Email);
                if (userExists == null)
                {
                    var result = await _userManager.CreateAsync(appUser, "ankit@bpst.com");
                    if (result.Succeeded)
                    {
                        // 2. Assign Admin Role
                        await _userManager.AddToRoleAsync(appUser, "Admin");


                        // 4. Seed Expense Plans (Templates with Hierarchy)

                        await _context.SaveChangesAsync(); // Save to get kidsParent.UniqueId



                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            resultStr = "Some Error: " + error.Code;
                        }
                    }
                }
                else resultStr = "User already exists";
            }
            catch (Exception ex)
            {
                resultStr = "Exception: " + ex.Message;
            }
            return resultStr;
        }


        public async Task<IActionResult> AutoLogin()
        {
            var result = await _signInManager.PasswordSignInAsync("admin@bpst.com", "Admin@20", true, lockoutOnFailure: false);
            if (result.Succeeded)
                return await ReDirectIfLoggedIn();
            else
                return RedirectToAction("CreateMasterUser");
        }




    }
}
