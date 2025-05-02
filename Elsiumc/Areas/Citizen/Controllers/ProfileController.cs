using System.Threading.Tasks;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Contrats;
[Authorize(Roles = "Citizen")]
[Area("Citizen")]
public class ProfileController : Controller
{

    private readonly IAuthManager _authManager;
    private readonly UserManager<IdentityCitizen> _userManager;

    public ProfileController(IAuthManager authManager, UserManager<IdentityCitizen> userManager)
    {
        _authManager = authManager;
        _userManager = userManager;
    }

    [Route("Profile/{id}")]
    public async Task<IActionResult> Profile(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is not null)
        {
            UserDtoForProfileList userDto = new UserDtoForProfileList
            {
                UserName = user.UserName,
                MainRole = user.MainRole,
                Occupation = user.Occupation,
                PenaltyPoints = user.PenaltyPoints,
                SubRoles = user.SubRoles,
                CriminalRecords = user.CriminalRecords
            };
            return View(userDto);
        }
        return Redirect("/");
    }
    public IActionResult Voting() // Vatandaşlar için oy kullanma sayfası
    {
        return View();
    }
}
