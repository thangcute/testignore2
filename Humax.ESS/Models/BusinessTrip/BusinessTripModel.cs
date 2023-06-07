using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class BusinessTripModel
    {
        public int Id { get; set; } //": 5017,
        public DateTime? NgayBatDau { get; set; } //": "2021-09-28T12:09:00",
        public DateTime? NgayKetThuc { get; set; } //": "2021-09-30T12:09:00",
        public string LyDo { get; set; } //": "aaaa",
        public string NoiCongTac { get; set; } //": "grewg999",
        public string CongViecCuThe { get; set; } //": "ewrgweg890",
        public int? XetDuyet { get; set; } //": 1,
        public string Approver { get; set; } //": null,
        public string ApproveComment { get; set; } //": ""

        public string StartDateDisplay
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayBatDau.ToString()))
                    return NgayBatDau.Value.ToString("dd/MM/yyyy");
                else
                    return "";
            }
        }

        public string EndDateDisplay
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayKetThuc.ToString()))
                    return NgayKetThuc.Value.ToString("dd/MM/yyyy");
                else
                    return "";
            }
        }

        public string StartTimeDisplay
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayBatDau.ToString()))
                    return NgayBatDau.Value.ToString("dd/MM/yyyy HH:mm");
                else
                    return "";
            }
        }

        public string EndTimeDisplay
        {
            get
            {
                if (!string.IsNullOrEmpty(NgayKetThuc.ToString()))
                    return NgayKetThuc.Value.ToString("dd/MM/yyyy HH:mm");
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

    public class BusinessTripPostModel
    {
        public int? Id { get; set; } = 0;
        public int? QTCongTacID { get; set; } = 0;

        [Required(ErrorMessage = "Phải chọn ngày bắt đầu !")]
        public DateTime? NgayBatDau { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Phải chọn ngày kết thúc !")]
        public DateTime? NgayKetThuc { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Phải chọn lý do công tác !")]
        [Range(1, int.MaxValue, ErrorMessage = "Phải chọn lý do công tác !")]
        public int? LyDoCongTacID { get; set; }

        [Required(ErrorMessage = "Nơi công tác không để trống !")]
        public string NoiCongTac { get; set; }

        [Required(ErrorMessage = "Công việc củ thể không để trống !")]
        public string CongViecCuThe { get; set; }
    }

    public class BusinessTripBakModel
    {
        public int Id { get; set; }

        [Display(Name = "Từ ngày")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Đến ngày")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Địa điểm")]
        public string Place { get; set; }

        [Display(Name = "Công việc cụ thể")]
        public string Content { get; set; }

        [Display(Name = "Lý do công tác")]
        public int ReasonId { get; set; }

        public DateTime RegistrationDate { get; set; }
        public string Reason { get; set; }
        public string Approver { get; set; }
        public string Comment { get; set; }
        public int? ApprovalStatus { get; set; }

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
