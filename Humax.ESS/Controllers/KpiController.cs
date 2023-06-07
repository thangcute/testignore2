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
    public class KpiController : Controller
    {
        private readonly ILogger<KpiController> _logger;

        public KpiController(ILogger<KpiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult Registration()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult SelfAssessment()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }
        
    }
}
