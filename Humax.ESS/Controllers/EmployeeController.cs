using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Humax.ESS.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public EmployeeController(ILogger<EmployeeController> logger, ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<EmployeeModel> model = new List<EmployeeModel>();

            SelectFilterModel filter = new SelectFilterModel {
                search = "",
                page = 1,
                size = 8,
                all = false
            };
            
            var response = await _apiOosHelper.Post<List<EmployeeModel>>(HttpContext.Session, "/api/Employee/Search", filter);
            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return View(model);
        }

        public async Task<IActionResult> Search(string inputSearch, int page = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<EmployeeModel> model = new List<EmployeeModel>();

            SelectFilterModel filter = new SelectFilterModel
            {
                search = inputSearch,
                page = page == 0 ? 1 : page,
                size = 8,
                all = false
            };

            var response = await _apiOosHelper.Post<List<EmployeeModel>>(HttpContext.Session, "/api/Employee/Search", filter);
            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return PartialView("~/Views/Employee/_SearchEmployee.cshtml", model);
        }

        public IActionResult NewEmployees()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}
