using Humax.ESS.Helpers;
using Humax.ESS.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public CategoryController(ILogger<ProfileController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        [HttpGet]
        public async Task<string> GetCategoryByTypeAsync(string type="")
        {
            var response = await _apiOosHelper.Get<List<CategoryModel>>(HttpContext.Session, "/api/category?Type=" + type);
            return JsonConvert.SerializeObject(response.Status == 1 ? response.Data : new List<CategoryModel>());
        }
    }
}
