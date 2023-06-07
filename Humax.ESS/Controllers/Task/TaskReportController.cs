using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers.Task
{
    public class TaskReportController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        public TaskReportController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("/Views/Task/Report/Index.cshtml");
        }
    }
}
