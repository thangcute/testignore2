using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Profile.Experiences
{
    public class ExperienceListModel
    {
        public int KinhNghiemID { get; set; }
        public string NoiLamViec { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? ToiNgay { get; set; }
        public string ChucVu { get; set; }
        public decimal? MucLuong { get; set; }
        public string LyDoNghiViec { get; set; }
        public int? XetDuyet { get; set; }
        public string Approver { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproveComment { get; set; }

        // View
        public string FromDateDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(TuNgay.ToString()))
                    return "";
                else
                    return TuNgay.Value.ToString("dd/MM/yyyy");
            }
        }
        
        public string ToDateDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(ToiNgay.ToString()))
                    return "";
                else
                    return ToiNgay.Value.ToString("dd/MM/yyyy");
            }
        }

        public string IncomeDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(MucLuong.ToString()))
                    return "";
                else
                    return MucLuong.Value.ToString("n0");
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
}
