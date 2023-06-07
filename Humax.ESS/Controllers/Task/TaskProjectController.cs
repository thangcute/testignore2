using Humax.ESS.Helpers;
using Humax.ESS.Models.Category;
using Humax.ESS.Models.Task;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers.Task
{
    public class TaskProjectController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public TaskProjectController(ILogger<HomeController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _apiOosHelper.Get<List<CategoryModel>>(HttpContext.Session, "/api/ProjectStatus/Status");
            ViewBag.ProjectStatus = JsonConvert.SerializeObject(response.Status == 1 ? response.Data : new List<CategoryModel>(), Formatting.None);

            List<TaskProjectModel> model = new List<TaskProjectModel>();
            var response_list = await _apiOosHelper.Get<List<TaskProjectModel>>(HttpContext.Session, "/api/Project/GetAll");
            if (response_list.Status == 1)
                model = response_list.Data;
            
            return View("/Views/Task/Project/Index.cshtml", model);
        }

        // them moi du an
        public async Task<IActionResult> Add(int? id)
        {
            TaskProjectModel model = new TaskProjectModel();
            model.DuAnID = 0;
            model.DuAnChaID = id.HasValue ? id.Value : 0;

            return PartialView("/Views/Task/Project/Partial/_ProjectDetail.cshtml", model);
        }

        // them moi du an
        [HttpPost]
        public async Task<JsonResult> Post(TaskProjectModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm mới");

            try
            {
                if (!string.IsNullOrEmpty(model.V_NgayBatDau))
                {
                    model.NgayBatDau = DateTime.ParseExact(model.V_NgayBatDau, "d/M/yyyy", CultureInfo.InvariantCulture);
                }

                if (!string.IsNullOrEmpty(model.V_NgayKetThuc))
                {
                    model.NgayKetThuc = DateTime.ParseExact(model.V_NgayKetThuc, "d/M/yyyy", CultureInfo.InvariantCulture);
                }

                var response = await _apiOosHelper.Post<object>(HttpContext.Session, "/api/Project", model);
                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.DuAnID > 0 ? "Cập nhật" : "Thêm mới"));
                }
            }
            catch(Exception ex)
            {
                _message = string.Format("{0}", ex.Message);
            }

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        // nguoi thuc hien 
        public IActionResult ChangePersons(int id)
        {
            ProjectPersonModel model = new ProjectPersonModel();
            model.Id = id;

            return PartialView("/Views/Task/Project/Partial/_ChangePersons.cshtml", model);
        }
    }
}
