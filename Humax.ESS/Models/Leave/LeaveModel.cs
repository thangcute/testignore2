using Humax.ESS.Localization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class CheckHolidayModel
    {
        public int? QTNghiPhepID { get; set; } = 0;
        public string SoQuyetDinh { get; set; }
        public int? KyHieuChamCongID { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }

    public class LeaveModel
    {
        public int Id { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string LoaiNghi { get; set; }
        public int? KyHieuChamCongID { get; set; }
        public decimal? SoNgayNghi { get; set; }
        /// <summary>
        /// Lý do nghỉ: LyDoNghi
        /// </summary>
        public string DienGiai { get; set; } = "";
        public string DiaDiem { get; set; } = "";
        public string Notify { get; set; }
        public int? XetDuyet { get; set; }
        public string Approver { get; set; }
        public string ApprovedDate { get; set; }
        public string ApproverComment { get; set; }

        public string DateStartDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(NgayBatDau.ToString()))
                    return "";
                else
                    return NgayBatDau.Value.ToString("dd/MM/yyyy");
            }
        }

        public string DateEndDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(NgayKetThuc.ToString()))
                    return "";
                else
                    return NgayKetThuc.Value.ToString("dd/MM/yyyy");
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

    public class LeavePostModel
    {
        public int? Id { get; set; } = 0;

        [Required(ErrorMessage = "Phải chọn ngày bắt đầu !")]
        public DateTime? NgayBatDau { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Phải chọn ngày kết thúc !")]
        public DateTime? NgayKetThuc { get; set; } = DateTime.Now;
        public string LoaiNghi { get; set; }

        [Required(ErrorMessage = "Phải chọn lý do nghỉ phép !")]
        [Range(1, int.MaxValue, ErrorMessage = "Phải chọn lý do nghỉ phép !")]
        public int? KyHieuChamCongID { get; set; }
        public decimal? SoNgayNghi { get; set; } = 0;

        [Required(ErrorMessage = "Diễn giải không để trống !")]
        public string DienGiai { get; set; }

        //[Required(ErrorMessage = "Địa điểm không để trống !")]
        public string DiaDiem { get; set; }
        public string Notify { get; set; }
        public string FileAttachment { get; set; }
    }

    public class LeaveBankModel
    {
        public int Id { get; set; }

        [Display(Name = "Ngày bắt đầu")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Tổng ngày nghỉ")]
        public decimal TotalDays { get; set; }

        /// <summary>
        /// KyHieuChamCong.MoTa
        /// </summary>
        [Display(Name = "Loại nghỉ")]
        public string LeaveType { get; set; }

        [Display(Name = "Loại nghỉ")]
        [Required(ErrorMessage ="Bạn phải chọn loại nghỉ")]
        public int ReasonId { get; set; }

        [Display(Name = "Địa điểm nghỉ")]
        public string Place { get; set; }

        /// <summary>
        /// Lý do nghỉ: LyDoNghi
        /// </summary>
        [Display(Name = "Lý do nghỉ")]
        public string Description { get; set; }

        public decimal LeaveDays { get; set; }

        /// <summary>
        /// Trạng thái phê duyệt
        /// </summary>
        public int? ApprovalStatus { get; set; }

        /// <summary>
        /// Người phê duyệt
        /// </summary>
        public string Approver { get; set; }

        /// <summary>
        /// Ý kiến phê duyệt
        /// </summary>
        public string Comment { get; set; }

        public string LeaveDaysDisplay
        {
            get
            {
                return LeaveDays.ToString("n2");
            }
        }

        public string Status
        {
            get
            {
                switch (ApprovalStatus)
                {
                    case 0: return "Chờ duyệt";
                    case 1: return "Đã duyệt";
                    case 2: return "Từ chối";
                    default: return "Chờ duyệt";
                }
            }
        }

        public string StatusColor
        {
            get
            {
                switch (ApprovalStatus)
                {
                    case 0: return "orange";
                    case 1: return "green";
                    case 2: return "red";
                    default: return "gray";
                }
            }
        }

        public string StartDateDisplay
        {
            get
            {
                return StartDate.ToString("dd/MM/yyyy hh:mm");
            }
        }

        public string EndDateDisplay
        {
            get
            {
                return EndDate.ToString("dd/MM/yyyy hh:mm");
            }
        }
    }
}
