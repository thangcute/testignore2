using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Profile.Experiences
{
    public class ExperienceModel
    {
        public int KinhNghiemID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nơi làm việc không để trống")]
        public string NoiLamViec { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Từ ngày không để trống")]
        public DateTime? TuNgay { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tới ngày không để trống")]
        public DateTime? ToiNgay { get; set; }
        public string ChucVu { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Phải chọn Ngành nghề !")]
        public int? NganhNgheID { get; set; }
        public decimal? MucLuong { get; set; }
        public string LyDoNghiViec { get; set; }
    }
}
