using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Humax.ESS.Models.Employee;
using Humax.ESS.Models.Profile.Experiences;
using Humax.ESS.Models.Profile.Relationship;
using Humax.ESS.Models.Profile.TrainingProcess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public ProfileController(ILogger<ProfileController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");
            List<EmployeeModel> model = new List<EmployeeModel>();
            var response = await _apiOosHelper.Get<List<EmployeeModel>>(HttpContext.Session, "/api/User/Get");
            if (response.Status == 1)
                model = response.Data;


            return View(model);
        }

        /**
         * Qua Trinh Dao tao
         */
        public IActionResult TrainingProcess()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpGet]
        public async Task<LoadResult> GetTrainingProcessAsync(DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<TrainingProcessListModel>>(HttpContext.Session, "/api/trainingprocess");
            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<TrainingProcessListModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailTrainingProcessAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            TrainingProcessModel model = new TrainingProcessModel();
            if (id > 0)
            {
                var response = await _apiOosHelper.Get<TrainingProcessModel>(HttpContext.Session, "/api/trainingprocess/" + id);
                model = response.Status == 1 ? response.Data : new TrainingProcessModel();
            }

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/Profile/_DetailTrainingProcess.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostTrainingProcessAsync(TrainingProcessModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.QTDaoTaoID > 0 ? "Thêm mới" : "Cập nhật"));

            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<TrainingProcessModel>(HttpContext.Session, "/api/trainingprocess", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.QTDaoTaoID > 0 ? "Thêm mới" : "Cập nhật"));
                }

                return Json(new
                {
                    success = _status,
                    message = _message
                });
            }
            else
            {
                return Json(new
                {
                    success = 99,
                    message = "Validation",
                    validation = ModelState.Keys.SelectMany(key => ModelState[key].Errors.Select(x => new ValidationMessage(key, x.ErrorMessage))).ToList()
                });
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteTrainingProcessAsync(int id)
        {
            var _status = 0;
            var _message = "Xóa Quá trình Đạo tạo không thành công";

            var response = await _apiOosHelper.Delete<int>(HttpContext.Session, "/api/trainingprocess", id.ToString());
            if (response.Status == 1)
            {
                _status = 1;
                _message = "Xóa Quá trình Đạo tạo thành công";
            }

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        /**
         * Qua Trinh Kinh nghiem
         */
        public IActionResult WorkingExperiences()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpGet]
        public async Task<LoadResult> GetExperiencesAsync(DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<ExperienceListModel>>(HttpContext.Session, "/api/experience");

            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<ExperienceListModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailExperiencesAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            ExperienceModel model = new ExperienceModel();
            if (id > 0)
            {
                var response = await _apiOosHelper.Get<ExperienceModel>(HttpContext.Session, "/api/experience/" + id);
                model = response.Status == 1 ? response.Data : new ExperienceModel();
            }

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/Profile/_DetailExperiences.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostExperiencesAsync(ExperienceModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.KinhNghiemID > 0 ? "Thêm mới" : "Cập nhật"));

            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<ExperienceModel>(HttpContext.Session, "/api/experience", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.KinhNghiemID > 0 ? "Thêm mới" : "Cập nhật"));
                }

                return Json(new
                {
                    success = _status,
                    message = _message
                });
            }
            else
            {
                return Json(new
                {
                    success = 99,
                    message = "Validation",
                    validation = ModelState.Keys.SelectMany(key => ModelState[key].Errors.Select(x => new ValidationMessage(key, x.ErrorMessage))).ToList()
                });
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteExperiencesAsync(int id)
        {
            var _status = 0;
            var _message = "Xóa Quá trình Kinh nghiệm không thành công";

            var response = await _apiOosHelper.Delete<int>(HttpContext.Session, "/api/experience", id.ToString());
            if (response.Status == 1)
            {
                _status = 1;
                _message = "Xóa Quá trình Kinh nghiệm thành công";
            }

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        /**
         * Quan he Nhan than
         */
        public IActionResult Relationship()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpGet]
        public async Task<LoadResult> GetRelationshipAsync(DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<RelationshipListModel>>(HttpContext.Session, "/api/relationship");

            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<RelationshipListModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailRelationshipAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            RelationshipModel model = new RelationshipModel();
            if(id > 0)
            {
                var response = await _apiOosHelper.Get<RelationshipModel>(HttpContext.Session, "/api/relationship/" + id);
                model = response.Status == 1 ? response.Data : new RelationshipModel();
            }

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/Profile/_DetailRelationship.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostRelationshipAsync(RelationshipModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.QTQuanHeGiaDinhID > 0 ? "Thêm mới" : "Cập nhật"));
            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<RelationshipModel>(HttpContext.Session, "/api/relationship", model);

                if(response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.QTQuanHeGiaDinhID > 0 ? "Thêm mới" : "Cập nhật"));
                }

                return Json(new
                {
                    success = _status,
                    message = _message
                });
            }
            else
            {
                return Json(new { success = 99,
                    message = "Validation",
                    validation= ModelState.Keys.SelectMany(key => ModelState[key].Errors.Select(x => new ValidationMessage(key, x.ErrorMessage))).ToList() 
                });
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteRelationshipAsync(int id)
        {
            var _status = 0;
            var _message = "Xóa Quan hệ Nhân thân không thành công";

            var response = await _apiOosHelper.Delete<int>(HttpContext.Session, "/api/relationship", id.ToString());
            if (response.Status == 1)
            {
                _status = 1;
                _message = "Xóa Quá hệ Nhân thân thành công";
            }

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        public IActionResult RewardChildren()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}
