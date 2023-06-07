using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Profile.TrainingProcess
{
    public class TrainingProcessModel
    {
        public int? QTDaoTaoID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Lớp Đào tạo không để trống")]
        public string LopDaoTao { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nội dung Đào tạo không để trống")]
        public string NoiDungDaoTao { get; set; }
        public int? KhoaDaoTaoID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Từ ngày không để trống")]
        public DateTime? TuNgay { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tới ngày không để trống")]
        public DateTime? ToiNgay { get; set; }
        public string NoiDaoTao { get; set; }
        public int? HeDaoTaoID { get; set; }
        public int? NganhHocID { get; set; }
        public int? ChuyenNganhID { get; set; }
        public int? VanBangID { get; set; }
        public int? ChungChiID { get; set; }
        public int? KetQuaDaoTaoID { get; set; }
        public decimal? DiemSo { get; set; } = 0;
        public string FileAttachment { get; set; }
        public string FileName { get; set; } = "";
    }
}
