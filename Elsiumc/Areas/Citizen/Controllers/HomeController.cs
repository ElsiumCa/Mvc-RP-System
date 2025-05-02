using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elsiumc.Areas.Citizen.Controllers
{
    [Authorize(Roles = "Citizen")]
    [Area("Citizen")]

    public class HomeController : Controller
    {
        // GET: /Citizen/Home/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Constitution()
        {
            return View();
        }
        public IActionResult Laws()
        {
            return View();
        }
        public IActionResult Cases()
        {
            return View();
        }
    }
}