using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models.Overtime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class OvertimeController : Controller
    {
        private readonly ILogger<OvertimeController> _logger;
        private readonly ApiOosHelper _apiOosHelper;

        public OvertimeController(ILogger<OvertimeController> logger,
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

            //OvertimeModel model = new OvertimeModel
            //{
            //    Applicant = user.FullName,
            //    EmployeeCode = user.EmployeeCode,
            //    Department = "",
            //};
            //return View(model);
            return View();
        }

        [HttpGet]
        public async Task<LoadResult> GetOvertimes(DataSourceLoadOptions loadOptions)
        {
            var response = await _apiOosHelper.Get<List<OvertimeModel>>(HttpContext.Session, "/api/overtime");

            return DataSourceLoader.Load(response.Status == 1 && response.Data != null ? response.Data : new List<OvertimeModel>(), loadOptions);
        }

        public async Task<IActionResult> DetailAsync(int id, int approve = 0)
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            OvertimePostModel model = new OvertimePostModel();
            if (id > 0)
            {
                var response = await _apiOosHelper.Get<OvertimePostModel>(HttpContext.Session, "/api/overtime/" + id);
                model = response.Status == 1 ? response.Data : new OvertimePostModel();
            }
            else
                model.Id = 0;

            if (approve == 0)
                return PartialView(model);
            else
                return PartialView("~/Views/Overtime/_Detail.cshtml", model);
        }

        [HttpPost]
        public async Task<JsonResult> PostAsync(OvertimePostModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", (model.Id > 0 ? "Thêm mới" : "Cập nhật"));

            string strDateNow = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime dateNow = DateTime.Parse(strDateNow);

            DateTime _BDLamThemTruocCa = dateNow;
            if (!string.IsNullOrEmpty(model.BDLamThemTruocCa))
                _BDLamThemTruocCa = DateTime.Parse(string.Format("{0} {1}", strDateNow, model.BDLamThemTruocCa));

            DateTime _KTLamThemTruocCa = dateNow;
            if (!string.IsNullOrEmpty(model.KTLamThemTruocCa))
                _KTLamThemTruocCa = DateTime.Parse(string.Format("{0} {1}", strDateNow, model.KTLamThemTruocCa));

            DateTime _BDLamThemSauCa = dateNow;
            if (!string.IsNullOrEmpty(model.BDLamThemSauCa))
                _BDLamThemSauCa = DateTime.Parse(string.Format("{0} {1}", strDateNow, model.BDLamThemSauCa));

            DateTime _KTLamThemSauCa = dateNow;
            if (!string.IsNullOrEmpty(model.KTLamThemSauCa))
                _KTLamThemSauCa = DateTime.Parse(string.Format("{0} {1}", strDateNow, model.KTLamThemSauCa));

            // Check All
            if(model.SoGioLamThemTruocCa == 0 && model.SoGioLamThemSauCa == 0 && _BDLamThemTruocCa == dateNow && _KTLamThemTruocCa == dateNow && _BDLamThemSauCa == dateNow && _KTLamThemSauCa == dateNow)
            {
                ModelState.Remove("LamThem");
                ModelState.AddModelError("LamThem", "Phải chọn thời gian làm thêm !");
            }
            else
            {
                // Check giờ trước ca
                if (model.SoGioLamThemTruocCa > 0)
                {
                    if (_BDLamThemTruocCa > dateNow || _KTLamThemTruocCa > dateNow)
                    {
                        ModelState.Remove("LamThemTruocCa");
                        ModelState.AddModelError("LamThemTruocCa", "Trước ca: Bạn chọn số giờ hoặc thời gian làm !");
                    }
                }
                else
                {
                    if ((_BDLamThemTruocCa > dateNow || _KTLamThemTruocCa > dateNow) && _BDLamThemTruocCa >= _KTLamThemTruocCa)
                    {
                        ModelState.Remove("LamThemTruocCa");
                        ModelState.AddModelError("LamThemTruocCa", "Trước ca: Giờ bắt đầu < giờ kết thúc !");
                    }
                }

                // check giờ sau ca
                if (model.SoGioLamThemSauCa > 0)
                {
                    if (_BDLamThemSauCa > dateNow || _KTLamThemSauCa > dateNow)
                    {
                        ModelState.Remove("LamThemSauCa");
                        ModelState.AddModelError("LamThemSauCa", "Sau ca: Bạn chọn số giờ hoặc thời gian làm !");
                    }
                }
                else
                {
                    if ((_BDLamThemSauCa > dateNow || _KTLamThemSauCa > dateNow) && _BDLamThemSauCa >= _KTLamThemSauCa)
                    {
                        ModelState.Remove("LamThemSauCa");
                        ModelState.AddModelError("LamThemSauCa", "Sau ca: Giờ bắt đầu < giờ kết thúc !");
                    }
                }

                if (model.SoGioLamThemTruocCa <= 0)
                {
                    if (string.IsNullOrEmpty(model.BDLamThemTruocCa) || string.IsNullOrEmpty(model.KTLamThemTruocCa))
                    {
                        ModelState.Remove("LamThemTruocCa");
                        ModelState.AddModelError("Date", "Ngày Giải trình phải nhỏ hơn ngày hiện tại");
                    }
                }
            }

            if (ModelState.IsValid)
            {
                var response = await _apiOosHelper.Post<OvertimePostModel>(HttpContext.Session, "/api/overtime", model);

                if (response.Status == 1)
                {
                    _status = 1;
                    _message = string.Format("{0} thành công", (model.Id > 0 ? "Thêm mới" : "Cập nhật"));
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
