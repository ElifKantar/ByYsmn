using ByYsmn.Application.CompanyServices;
using ByYsmn.Application.CompanyServices.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ByYsmn.Web.UI.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _companyService.GetAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CompanyCreateInput model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                model.CreatorUserId = Guid.Parse(userId);
                var newCompany = await _companyService.Create(model);
                if (newCompany == null)
                {
                    return View(model);
                }
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}