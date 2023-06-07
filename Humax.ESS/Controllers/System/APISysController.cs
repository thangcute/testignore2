using Humax.ESS.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class APISysController : BaseController
    {
        [HttpGet]
        public async Task<JsonResult> GetValue(string Code, string Parameters)
        {
            if (Code != "" && Code != null && Parameters != null)
            {
                switch (Code.ToLower())
                {
                    //Tính toán số ngày nghỉ phép: Từ ngày - Tới ngày: NhanVienID;TuNgay;ToiNgay;LoaiNghiID
                    case "cal_holiday":
                        string[] strParams = Parameters.Split(';');
                        if (Parameters.Length >= 3)
                        {
                            dynamic model = new DynamicDictionary();
                            model.NgayBatDau = new DateTime();
                            model.NgayKetThuc = DateTime.Now;
                            model.SoNgayNghi = 0;
              
                            var x = await ApiHelper.Post<DynamicDictionary>(HttpContext.Session, "/api/leave/notify", model);

                            return Json(new { songay = model.SoNgayNghi, notify = model.Notify, allowsave = model.AllowSave });
                        }
                        break;
                }
            }
            return Json(new { });
        }

        /*
        [HttpPost]
        public JsonResult DoFunction(string Code, string Parameters)
        {
            if (Code != "")
            {
                switch (Code.ToLower())
                {
                    case "get_email_content":
                        int EmailContentID = int.Parse(Parameters);
                        if (EmailContentID > 0)
                        {
                            EmailContent ec = EmailContent.GetEmailContent(EmailContentID);

                            return Json(new { html = ec.Content, subject = ec.Subject }, JsonRequestBehavior.AllowGet);
                        }
                        break;

                    case "get_huyen_tinh_id":
                        int XaPhuongID = int.Parse(Parameters);
                        if (XaPhuongID > 0)
                        {
                            return Json(new { HuyenID = NS_DsXaPhuong.GetQuanHuyenIDByID(XaPhuongID), TinhID = NS_DsXaPhuong.GetTinhIDByID(XaPhuongID) }, JsonRequestBehavior.AllowGet);
                        }
                        else
                            return Json(new { HuyenID = 0, TinhID = 0 }, JsonRequestBehavior.AllowGet);

                    case "update_size":
                        string[] param = Parameters.Split(';');
                        OOS.GHR.Core.DisplayInfo.ScreenWidth = int.Parse(param[0]);
                        OOS.GHR.Core.DisplayInfo.ScreenHeight = int.Parse(param[1]);
                        break;

                    case "sendemail":
                        #region SendEmail
                        string emailTo = EditorExtension.GetValue<string>("EmailTo");
                        if (emailTo == null || emailTo.Length < 0)
                            return ReturnErrorMessage("Bạn phải nhập EMAIL TO !", 1);
                        emailTo = emailTo.Replace("\"", "");

                        string Subject = EditorExtension.GetValue<string>("Subject");
                        if (Subject == null || Subject.Length < 0)
                            return ReturnErrorMessage("Bạn phải nhập Tiêu Đề !", 1);
                        Subject = Subject.Replace("\"", "");

                        string Content = EditorExtension.GetValue<string>("Content");
                        if (Content == null || Content.Length < 0)
                            return ReturnErrorMessage("Bạn phải nhập Nội Dung !", 1);
                        Content = Content.Replace("\"", "");

                        bool IsHTMLFormat = EditorExtension.GetValue<bool>("IsHTMLFormat");

                        if (emailTo != null && emailTo.Length > 0 && Content != null && Content.Length > 0)
                        {
                            string str = OOS.GHR.BusinessAdapter.Global.Email.SendEmail
                            (Subject, emailTo, "", Content, IsHTMLFormat, null, DatabaseCache.NhanVien.Email,
                             DatabaseCache.NhanVien.ToString());

                            if (str == "")
                                return ReturnErrorMessage("Gửi email thành công !", 0);
                            else
                            {
                                return ReturnErrorMessage("Có lỗi xảy ra khi gửi email: " + str, 1);
                            }
                        }
                        else
                            return ReturnErrorMessage("Bạn phải nhập các thông tin !", 1);
                        #endregion
                }
            }
            return ReturnJSValue("");
        }
        */
    }
}
