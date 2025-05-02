using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elsiumc.Areas.Citizen.Controllers
{
    [Authorize(Roles = "President")]
    [Area("Citizen")]
    public class PresidentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageConstitution()
        {
            return View();
        }
        
    }
}