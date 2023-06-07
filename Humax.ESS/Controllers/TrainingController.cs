using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Humax.ESS.Models.Trainning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ILogger<TrainingController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public TrainingController(ILogger<TrainingController> logger, ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<TrainningOpenningModel> model = new List<TrainningOpenningModel>();

            var response = await _apiOosHelper.Get<List<TrainningOpenningModel>>(HttpContext.Session, "/api/Trainning/Open");
            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return View(model);
        }

        public async Task<IActionResult> Joinning()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<TrainningJoinningModel> model = new List<TrainningJoinningModel>();

            var response = await _apiOosHelper.Get<List<TrainningJoinningModel>>(HttpContext.Session, "/api/Trainning/Joinning");
            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return PartialView("~/Views/Training/_Joinning.cshtml", model);
        }

        public async Task<IActionResult> Finished()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<TrainningFinishedModel> model = new List<TrainningFinishedModel>();

            var response = await _apiOosHelper.Get<List<TrainningFinishedModel>>(HttpContext.Session, "/api/Trainning/Finished");
            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return PartialView("~/Views/Training/_Finished.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> Register(int id)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Đăng ký khóa học");

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        [HttpPost]
        public async Task<JsonResult> Reject(int id)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Từ chối");

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        public async Task<IActionResult> Evaluate(int id)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<TrainingEvaluateModel> model = new List<TrainingEvaluateModel>();
            var response = await _apiOosHelper.Get<List<TrainingEvaluateModel>>(HttpContext.Session, "/api/Trainning/ListEvaluate?id=" + id);

            if (response.Status == 1 && response.Data != null)
                model = response.Data;

            return PartialView("~/Views/Training/_Evaluate.cshtml", model);
        }
    }
}
