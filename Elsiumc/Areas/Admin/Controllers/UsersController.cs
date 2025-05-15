using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Contrats;
using Entities.Dtos;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Elsiumc.Models;

namespace Elsiumc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Users/[action]")]
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAuthManager _AuthManager;
        private readonly UserManager<IdentityCitizen> _UserManager;

        public UsersController(IAuthManager authManager, UserManager<IdentityCitizen> userManager, RoleManager<IdentityRole> roleManager)
        {
            _AuthManager = authManager;
            _UserManager = userManager;
            _roleManager = roleManager;
        }

        // List all users
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            var users = _AuthManager.GetAllCitizens();
            var userWithRolesList = new List<UserDtoForList>();

            foreach (var user in users)
            {
                var roles = await _UserManager.GetRolesAsync(user);
                userWithRolesList.Add(new UserDtoForList
                {
                    ID = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    Roles = new HashSet<string>(roles)
                });
            }

            var totalRecords = userWithRolesList.Count;
            var pagedItems = userWithRolesList
                .OrderBy(u => u.UserName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var model = new PagingViewModel<UserDtoForList>
            {
                Items = pagedItems,
                PageNo = page,
                PageSize = pageSize,
                TotalRecords = totalRecords
            };

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_UserListPartial", model);

            return View(model);
        }

        // Update user (GET)
        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var AllRoles = _roleManager.Roles;
            var roles = await _UserManager.GetRolesAsync(user);
            var userDto = new UserDtoForUpdate
            {
                ID = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Roles = new HashSet<string>(roles),
                AllRoles = new List<string>(AllRoles.Select(role => role.Name))

            };

            return View(userDto);
        }

        // Update user (POST)
        [HttpPost("{id}")]
        public async Task<IActionResult> Edit(string id, UserDto updatedUser)
        {
            var user = await _UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = updatedUser.UserName;
            user.Email = updatedUser.Email;
            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.PhoneNumber = updatedUser.PhoneNumber;

            var result = await _UserManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(updatedUser);
            }

            // Update roles
            var currentRoles = await _UserManager.GetRolesAsync(user);
            var rolesToAdd = updatedUser.Roles.Except(currentRoles);
            var rolesToRemove = currentRoles.Except(updatedUser.Roles);

            await _UserManager.AddToRolesAsync(user, rolesToAdd);
            await _UserManager.RemoveFromRolesAsync(user, rolesToRemove);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserDtoForCreation());
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDtoForCreation model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage); // Log validation errors
                }
                return View(model);
            }

            // Create a new IdentityMember
            var user = new IdentityCitizen
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            };

            // Create the user with the provided password
            var result = await _UserManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.Description); // Log identity errors
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            // Assign roles if provided
            if (model.Roles != null && model.Roles.Any())
            {
                var roleResult = await _UserManager.AddToRolesAsync(user, model.Roles);
                if (!roleResult.Succeeded)
                {
                    foreach (var error in roleResult.Errors)
                    {
                        Console.WriteLine(error.Description); // Log role assignment errors
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }

            return RedirectToAction("Index");
        }


        // Delete user
        [HttpPost("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _UserManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}