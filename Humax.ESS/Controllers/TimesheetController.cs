using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models.Timesheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class TimesheetController : Controller
    {
        private readonly ILogger<TimesheetController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public TimesheetController(ILogger<TimesheetController> logger,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _apiOosHelper = apiOosHelper;
        }

        public async Task<IActionResult> IndexAsync()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            //var postData = new List<KeyValuePair<string, string>>();
            //postData.Add(new KeyValuePair<string, string>("token", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NDg1MDAxMTgxOTIyNTA4ODAiLCJlbWFpbCI6ImhpZXV0dEBnLWdyb3VwLnZuIiwiY2xpZW50X2lkIjoiN2ZiNWYxNGYyNWYwNjdlY2U0NWQwMGQwYmUyMmRhOTMiLCJ0eXBlIjoiYXV0aG9yaXphdGlvbl9jb2RlIiwiaWF0IjoxNjMyMzY2NTk1LCJleHAiOjE2NjM5MDI1OTV9.eBn0EBnZqFXEkRhrN1jd31fxV8TYQCtcAt5Kb3rHehY"));
            //using (var httpClient = new System.Net.Http.HttpClient())
            //{
            //    using (var content = new System.Net.Http.FormUrlEncodedContent(postData))
            //    {
            //        content.Headers.Clear();
            //        content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            //        System.Net.Http.HttpResponseMessage response = await httpClient.PostAsync("https://partner.hanet.ai/device/get-list-device", content);

            //        var a = response.Content.ReadAsStringAsync().Result;
            //    }
            //}

            return View();
        }

        [HttpGet]
        public async Task<LoadResult> GetAsync(string MonthTimeSheet, DataSourceLoadOptions loadOptions)
        {
            string _MonthTimeSheet = DateTime.Now.ToString("yyyy-MM");
            if (!string.IsNullOrEmpty(MonthTimeSheet))
                _MonthTimeSheet = MonthTimeSheet;

            var response = await _apiOosHelper.Get<List<TimesheetModel>>(HttpContext.Session, "/api/timesheet?MonthYear=" + _MonthTimeSheet);
            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<TimesheetModel>(), loadOptions);
        }

        [HttpGet]
        public async Task<LoadResult> GetSummaryAsync(DataSourceLoadOptions loadOptions, string MonthTimeSheet = "")
        {
            string _MonthTimeSheet = DateTime.Now.ToString("yyyy-MM");
            if (!string.IsNullOrEmpty(MonthTimeSheet))
                _MonthTimeSheet = MonthTimeSheet;

            var response = await _apiOosHelper.Get<List<TimeSheetSummaryModel>>(HttpContext.Session, "/api/timesheet/summary?MonthYear=" + _MonthTimeSheet);

            return DataSourceLoader.Load(response.Status == 1 ? response.Data : new List<TimeSheetSummaryModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailExplainAsync(string date, bool isDimuon = true)
        {
            ExplainModel model = new ExplainModel();
            if (!string.IsNullOrEmpty(date))
            {
                model = new ExplainModel()
                {
                    NgayThang = DateTime.Parse(date),
                    IsDimuon = isDimuon,
                    LyDo = ""
                };
            }
            return PartialView("~/Views/Timesheet/DetailExplain.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostExplainAsync(ExplainModel model)
        {
            var _status = 0;
            var _message = "";
            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<ExplainModel>(HttpContext.Session, "/api/timesheet/explain", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("Đã lưu thông tin Giải trình {0} !", model.IsDimuon ? "đi muộn" : "về sớm");
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

        public async Task<IActionResult> DetailLostFingerAsync(string date)
        {
            LostFingerModel model = new LostFingerModel();
            if (!string.IsNullOrEmpty(date))
            {
                model = new LostFingerModel()
                {
                    NgayThang = DateTime.Parse(date)
                };
            }
            
            return PartialView("~/Views/Timesheet/DetailLostFinger.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostLostFingerAsync(LostFingerModel model)
        {
            var _status = 0;
            var _message = "";
            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<LostFingerModel>(HttpContext.Session, "/api/timesheet/lostfinger", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = "Đã lưu thông tin Giải trình thêm giờ !";
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
    }
}
