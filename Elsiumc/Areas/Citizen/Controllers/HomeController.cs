using Microsoft.AspNetCore.Mvc;

namespace Elsiumc.Areas.Citizen.Controllers
{
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
        public IActionResult Voting()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

    }
}