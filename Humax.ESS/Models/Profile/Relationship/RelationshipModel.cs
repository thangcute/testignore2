using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Profile.Relationship
{
    public class RelationshipModel
    {
        public int? QTQuanHeGiaDinhID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Quan hệ không để trống")]
        public string QuanHe { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Họ tên không để trống")]
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        [RegularExpression(@"^([0-9]{9}|[0-9]{12})$", ErrorMessage = "Số CMT/TCC gồm 9 hoặc 12 số")]
        public string CMND { get; set; }
        //[RegularExpression("^[0-9]*$", ErrorMessage = "Điện thoại phải là số")]
        [RegularExpression(@"^0[1-9]{1}[0-9]{8}$", ErrorMessage = "Điện thoại không đúng định dạng")]
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
        public bool? GiamTru { get; set; }
        public string FileAttachment { get; set; }
        //public IFormFile FileUpload { get; set; }
        public string FileName { get; set; } = "";
    }
}
