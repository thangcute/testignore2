using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class BusinessTripController : Controller
    {
        private readonly ILogger<BusinessTripController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public BusinessTripController(ILogger<BusinessTripController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            var user = HttpContext.Session.GetCurrentUser();

            BusinessTripListModel model = new BusinessTripListModel
            {
                Applicant = user.FullName,
                EmployeeCode = user.EmployeeCode,
                Department = "",
            };
            return View(model);
        }

        [HttpGet]
        public async Task<LoadResult> GetBusinessTrips(DataSourceLoadOptions loadOptions)
        {
            var response = await ApiHelper.Get<List<BusinessTripModel>>(HttpContext.Session, "/api/businesstrip");

            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<BusinessTripModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            BusinessTripPostModel model = new BusinessTripPostModel();
            if (id > 0)
            {
                var response = await _apiOosHelper.Get<BusinessTripPostModel>(HttpContext.Session, "/api/businesstrip/" + id);
                model = response.Status == 1 ? response.Data : new BusinessTripPostModel();
            }
            else
                model.QTCongTacID = 0;

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/BusinessTrip/_Detail.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostAsync(BusinessTripPostModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.QTCongTacID > 0 ? "Thêm mới" : "Cập nhật"));

            if(!string.IsNullOrEmpty(model.NgayBatDau.ToString()) && !string.IsNullOrEmpty(model.NgayKetThuc.ToString()))
            {
                if(model.NgayKetThuc < DateTime.Now)
                {
                    ModelState.Remove("Time");
                    ModelState.AddModelError("Time", "Thời gian kêt thúc quá khứ không được sửa !");
                } else if(model.NgayBatDau >= model.NgayKetThuc)
                {
                    ModelState.Remove("Time");
                    ModelState.AddModelError("Time", "Thời gian kêt thúc phải > bắt đầu !");
                }
            }

            if (ModelState.IsValid)
            {
                model.Id = model.QTCongTacID;
                var response = await _apiOosHelper.Post<BusinessTripPostModel>(HttpContext.Session, "/api/businesstrip", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.QTCongTacID > 0 ? "Thêm mới" : "Cập nhật"));
                }
                else if(response.Message == "Validation")
                {
                    return Json(new
                    {
                        success = 99,
                        message = "Validation",
                        validation = response.Data
                    });
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
        public async Task<JsonResult> DeleteAsync(int id)
        {
            var _status = 0;
            var _message = "Xóa Quá trình Đạo tạo không thành công";

            //var response = await _apiOosHelper.Delete<int>(HttpContext.Session, "/api/trainingprocess", id.ToString());
            //if (response.Status == 1)
            //{
            //    _status = 1;
            //    _message = "Xóa Quá trình Đạo tạo thành công";
            //}

            return Json(new
            {
                success = _status,
                message = _message
            });
        }
    }
}
