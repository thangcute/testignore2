using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Profile.Relationship
{
    public class RelationshipListModel
    {
        public int QTQuanHeGiaDinhID { get; set; }
        public string HoTen { get; set; }
        public string QuanHe { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GiamTru { get; set; }
        public DateTime? NgayBatDauGiamTru { get; set; }
        //
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DienThoaiLienHe { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string NgheNghiepHienNay { get; set; }
        public string MaSoThue { get; set; }
        public string GiayKhaiSinhSo { get; set; }
        public string NoiDangKyGiayKhaiSinh { get; set; }
        public string QuocTich { get; set; }
        public string QuanHe_ChuHo { get; set; }
        public int? LoaiGiayToID { get; set; }
        public string SoHoKhau { get; set; }
        public string QuyenSo { get; set; }
        public string MaSoBHXH { get; set; }
        public string GhiChu { get; set; }
        //
        public int? XetDuyet { get; set; }
        public string Approver { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproveComment { get; set; }

        public string DateOfBirthDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(NgaySinh.ToString()))
                    return "";
                else
                    return NgaySinh.Value.ToString("dd/MM/yyyy");
            }
        }

        public string DateReduceDisplay
        {
            get
            {
                if (string.IsNullOrEmpty(NgayBatDauGiamTru.ToString()))
                    return "";
                else
                    return NgayBatDauGiamTru.Value.ToString("dd/MM/yyyy");
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
