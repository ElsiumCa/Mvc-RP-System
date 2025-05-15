using Entities.RpItems;
using Entities.RpItems.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.RpItemServices;

namespace Elsiumc.Areas.Citizen.Controllers
{
    [Authorize(Roles = "President")]
    [Area("Citizen")]
    public class PresidentController : Controller
    {
        private readonly IConstitutionService _service;

        public PresidentController(IConstitutionService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageConstitutionAsync(int pageSize = 10, int page = 1)
        {
            var items = _service.GetAllArticlesAsync();
            var query = items.OrderByDescending(x => x.CreatedAt).AsQueryable();
            var model = await PaginatedList<Constitution>.CreateAsync(query, page, pageSize); // Sayfalama işlemi
            return View(model);
        }


        public IActionResult Create()
        {
            return View(new ConstitutionDtoForCreating());
        }

        [HttpPost]
        public IActionResult Create(ConstitutionDtoForCreating model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(ManageConstitutionAsync));
            }
            return View();
        }
    }
}