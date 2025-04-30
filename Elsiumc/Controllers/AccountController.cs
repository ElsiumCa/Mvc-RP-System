using ElsiumC.Models;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services;
using Services.Contrats;

namespace ElsiumC.Controllers
{
    public class AccountController : Controller
    {
        readonly IAuthManager _userManager;
        readonly SignInManager<IdentityCitizen> _signInManager;

        public AccountController(IAuthManager userManager, SignInManager<IdentityCitizen> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcıyı bul
                var user = await _userManager.GetUserByUsername(model.Username);
                if (user != null)
                {
                    // Şifreyi kontrol et
                    var result = await _userManager.CheckPasswordForUser(user, model.Password);
                    if (result)
                    {
                        // Giriş yap ve kimlik doğrulama çerezini oluştur
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        // Başarılı giriş sonrası yönlendirme
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("Error", "Username or Password is invalid");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View(new UserDtoForCreation());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDtoForCreation model)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result;

                result = await _userManager.CreateUser(model); // Adjusted to use CreateUser

                if (result.Succeeded)
                {
                    // Assign roles if provided
                    if (model.Roles != null && model.Roles.Count > 0)
                    {
                        foreach (var role in model.Roles)
                        {
                            await _userManager.AssignRole(model.UserName, role);
                        }
                    }

                    // Redirect to the login page after successful registration
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    // Add errors to ModelState if user creation fails
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Error", error.Description);
                    }
                }
            }
            else
            {

                
                    foreach (var modelState in ModelState)
                    {
                        foreach (var error in modelState.Value.Errors)
                        {
                            Console.WriteLine($"Key: {modelState.Key}, Error: {error.ErrorMessage}");
                        }
                    }
                

            }
            return View(model);
        }

    }
}
