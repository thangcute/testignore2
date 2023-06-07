using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace Humax.ESS.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILogger<LeaveController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public LeaveController(ILogger<LeaveController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");
            
            var user = HttpContext.Session.GetCurrentUser();

            var MM = await _apiOosHelper.Get<LeaveSummaryModel>(HttpContext.Session, "/api/leave/getleavesummary");
            
            if (MM.Data == null)
                return View(new LeaveSummaryModel());

            return View(MM.Data);
        }

        [HttpGet]
        public async Task<LoadResult> Get(DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<LeaveModel>>(HttpContext.Session, "/api/leave");

            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<LeaveModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            LeavePostModel model = new LeavePostModel();
            if (id > 0)
            {
                var response = await _apiOosHelper.Get<LeavePostModel>(HttpContext.Session, "/api/leave/" + id);
                model = response.Status == 1 ? response.Data : new LeavePostModel();
            }
            else
                model.Id = 0;

            ViewBag.SoPhepDaNghi = 0;
            ViewBag.SoPhepConLai = 0;
            var Summary = await _apiOosHelper.Get<LeaveSummaryModel>(HttpContext.Session, "/api/leave/getleavesummary");
            if(Summary != null && Summary.Data != null)
            {
                ViewBag.SoPhepDaNghi = Summary.Data.SoPhepDaNghi;
                ViewBag.SoPhepConLai = Summary.Data.SoPhepConLai;
            }

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/Leave/_Detail.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostAsync(LeavePostModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.Id > 0 ? "Thêm mới" : "Cập nhật"));

            // Check thoi gian cham cong
            if(!string.IsNullOrEmpty(model.NgayBatDau.ToString()) && !string.IsNullOrEmpty(model.NgayKetThuc.ToString()))
            {
                if(model.NgayBatDau >= model.NgayKetThuc)
                {
                    ModelState.Remove("Time");
                    ModelState.AddModelError("Time", "Ngày bắt đầu phải < kết thúc !");
                }
            }

            // Check ngay cham cong
            CheckHolidayModel checkModel = new CheckHolidayModel() { 
                QTNghiPhepID = model.Id,
                KyHieuChamCongID = model.KyHieuChamCongID,
                SoQuyetDinh = "",
                StartDateTime = model.NgayBatDau,
                EndDateTime = model.NgayKetThuc
            };
            var _response = await _apiOosHelper.Post<string>(HttpContext.Session, "/api/leave/CheckHoliday", checkModel);
            if (_response.Status == 0)
            {
                ModelState.Remove("Time");
                ModelState.AddModelError("Time", _response.Data);
            }

            // IsValid
            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<object>(HttpContext.Session, "/api/leave", model);
                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.Id > 0 ? "Thêm mới" : "Cập nhật"));
                }
                else if (response.Message == "Validation")
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
        public async Task<IActionResult> Insert(string values)
        {
            var newLeave = new LeaveModel();
            JsonConvert.PopulateObject(values, newLeave);

            var response = await _apiOosHelper.Post<List<LeaveModel>>(HttpContext.Session, "/api/leave", newLeave);
            if (response.Status == 1)
                return Ok();

            return BadRequest(response);
        }

        [HttpPut]
        [HttpPost]
        public async Task<IActionResult> Update(int key, string values)
        {
            var leave = new LeaveModel();
            JsonConvert.PopulateObject(values, leave);

            leave.Id = key;

            var response = await _apiOosHelper.Put<List<LeaveModel>>(HttpContext.Session, "/api/leave", leave);
            if (response.Status == 1)
                return Ok();

            return BadRequest(response);
        }

        [HttpDelete]
        public async void Delete(int id)
        {
            var response = await _apiOosHelper.Delete<List<string>>(HttpContext.Session, "/api/delete", id.ToString());
            if (response != null && response.Status != 1)
            {
                ViewData["ErrorMessage"] = response.Message;
            }
        }

        [HttpGet]
        public async Task<LoadResult> GetLyDoNghiViec (DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<MasterModel>>(HttpContext.Session, "/api/leave/GetLeaveReasonList");

            return DataSourceLoader.Load(response.Status == 1 ? response.Data : null, loadOptions);
        }

        [HttpPost]
        public async Task<JsonResult> CheckHoliday([FromBody] CheckHolidayModel model)
        {
            var _status = 0;
            var _message = "Holiday";
            decimal _number = 0;

            var response = await _apiOosHelper.Post<decimal>(HttpContext.Session, "/api/leave/Holiday", model);

            if (response.Status == 1)
            {
                _status = 1;
                _number = response.Data;
            }

            return Json(new
            {
                success = _status,
                message = _message,
                data = _number
            });
        }
    }
}
