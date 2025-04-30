using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elsiumc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]

    public class HomeController : Controller
    {
        // GET: /Admin/Admin
        public IActionResult Index()
        {
            return View();
        }

    }
}