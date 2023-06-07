using Humax.ESS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Overtime
{
    public class OvertimeModel
    {
        public int Id { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public string CaLamViec { get; set; }
        public string KyHieuChamCongID { get; set; }
        public decimal? SoGioLamThemTruocCa { get; set; }
        public decimal? SoGioLamThemSauCa { get; set; }
        public string BDLamThemTruocCa { get; set; }
        public string KTLamThemTruocCa { get; set; }
        public string BDLamThemSauCa { get; set; }
        public string KTLamThemSauCa { get; set; }
        public string LyDoTangCa { get; set; }
        public int? XetDuyet { get; set; }
        public string Approver { get; set; }
        public string ApproveComment { get; set; }

        public string DayOfWeek
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayDangKy.ToString()))
                    return BusinessHelper.DayOfWeek(NgayDangKy.Value);
                else
                    return "";
            }
        }

        public string NgayDangKyDisplay
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayDangKy.ToString()))
                    return NgayDangKy.Value.ToString("dd/MM/yyyy");
                else
                    return "";
            }
        }

        public string ApproveStatusDisplay
        {
            get
            {
                return (
                    XetDuyet == 1 ? "<span class='group__btn btn dx-button-mode-contained dx-button-success p-t-3 p-b-3'>Đã duyệt</span>" : (
                        XetDuyet == -1 ? "<span class='group__btn btn dx-button-mode-contained dx-button-danger p-t-3 p-b-3'>Từ chối</span>" : (
                            XetDuyet == 2 ? "<span class='group__btn btn btn_yellow p-t-3 p-b-3'>Đang chờ hủy</span>" : (
                                XetDuyet == -2 ? "<span class='group__btn btn dx-button-mode-contained dx-button-danger p-t-3 p-b-3'>Đã xóa/hủy</span>" : (
                                    XetDuyet == 100 ? "<span class='group__btn btn dx-button-mode-contained dx-button-default p-t-3 p-b-3'>Đang duyệt</span>" : "<span class='group__btn btn btn_gray p-t-3 p-b-3 p-t-3 p-b-3'>Đợi duyệt</span>"
                                )
                            )
                        )
                    )
                );
            }
        }
    }

    public class OvertimePostModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Ngày đăng ký không để trống !")]
        public DateTime NgayDangKy { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Phải chọn Ca làm việc !")]
        [Range(1, int.MaxValue, ErrorMessage = "Phải chọn Ca làm việc !")]
        public int? CaLamViecID { get; set; }
        public int? KyHieuChamCongID { get; set; }
        public decimal? SoGioLamThemTruocCa { get; set; } = 0;
        public decimal? SoGioLamThemSauCa { get; set; } = 0;
        public string BDLamThemTruocCa { get; set; } = "00:00";
        public string KTLamThemTruocCa { get; set; } = "00:00";
        public string BDLamThemSauCa { get; set; } = "00:00";
        public string KTLamThemSauCa { get; set; } = "00:00";

        [Required(ErrorMessage = "Phải chọn lý do tăng ca !")]
        [Range(1, int.MaxValue, ErrorMessage = "Phải chọn lý do tăng ca !")]
        public int? LyDoTangCaID { get; set; }
        [Required(ErrorMessage = "Lý do đăng ký không để trống !")]
        public string LyDoTangCa { get; set; }
        public bool? AnTangCa { get; set; }
        public bool? IsMoiTruongDacBiet { get; set; }
    }

    public class OvertimeBakModel
    {
        public int Id { get; set; }
        public string Applicant { get; set; }
        public string EmployeeCode { get; set; }
        public string Department { get; set; }
        public string Reason { get; set; }
        public DateTime RegistrationDate { get; set; }        
        public string Shift { get; set; }
        public int HoursBeforeShift { get; set; }

        public DateTime BeginBeforeShift { get; set; }

        public DateTime EndBeforeShift { get; set; }

        public int HoursAfterShift { get; set; }

        public string BeginAfterShift { get; set; }

        public string EndAfterShift { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public string Approver { get; set; }

        public string StatusColor
        {
            get
            {
                switch (Status)
                {
                    case "Đã duyệt": return "green";
                    case "Chờ duyệt": return "orange";
                    case "Từ chối": return "red";
                    default: return "gray";
                }
            }
        }

        public string DateDisplay
        {
            get
            {
                return RegistrationDate.ToString("dd/MM/yyyy");
            }
        }

        public string BeginBeforeShiftDisplay
        {
            get
            {
                return BeginBeforeShift.ToString("HH:mm");
            }
        }

        public string EndBeforeShiftDisplay
        {
            get
            {
                return EndBeforeShift.ToString("HH:mm");
            }
        }
    }
}
