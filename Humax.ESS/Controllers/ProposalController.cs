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
    public class ProposalController : Controller
    {
        private readonly ILogger<ProposalController> _logger;

        public ProposalController(ILogger<ProposalController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}
