using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            HomeModel model = new HomeModel();

            var response = await ApiHelper.Get<List<UserInfoModel>>(HttpContext.Session, "/api/Home/NewEmployees?count=5");
            if (response.Status == 1)
                model.NewEmployees = response.Data;

            return View(model);
        }

        public IActionResult PostSomething()
        {
            int type = -1;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
