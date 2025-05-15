using Elsiumc.Models;
using Entities.RpItems;
using Entities.RpItems.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet("Citizen/President/ManageConstitution")]
        public async Task<IActionResult> ManageConstitutionAsync(int pageSize = 20, int page = 1)
        {
            var query = _service.GetAllArticles(); // IQueryable<Constitution>
            var totalRecords = await query.CountAsync();
            var pagedItems = await query
                .OrderBy(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var model = new PagingViewModel<Constitution>
            {
                Items = pagedItems,
                PageNo = page,
                PageSize = pageSize,
                TotalRecords = totalRecords
            };

            // AJAX isteği ise:
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_ConsTablePartial", model);

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
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}