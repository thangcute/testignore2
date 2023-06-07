using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Humax.ESS.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class InformationController : BaseController
    {
        private readonly ILogger<InformationController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public InformationController(ILogger<InformationController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> Employee(SelectFilterModel model) //FormCollection collection
        {
            int _total_count = 0;
            List<SelectModel> _data = new List<SelectModel>();

            if (Request.Method == HttpMethod.Get.Method)
            {
                var response = await _apiOosHelper.Post<List<CategoryModel>>(HttpContext.Session, "/api/Employee/Search", model);
                if(response.Status == 1)
                {
                    int.TryParse(response.Message, out _total_count);
                    _data = response.Data.Select(x => new SelectModel() { 
                            id = x.Id,
                            name = x.Name,
                            code = x.Des
                    }).ToList();
                }
            }

            return Json(new
            {
                total_count = _total_count,
                incomplete_results = false,
                items = _data
            });
        }
    }
}
