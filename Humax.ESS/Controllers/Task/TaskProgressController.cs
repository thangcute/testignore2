using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers.Task
{
    public class TaskProgressController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        public TaskProgressController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("/Views/Task/Progress/Index.cshtml");
        }
    }
}
