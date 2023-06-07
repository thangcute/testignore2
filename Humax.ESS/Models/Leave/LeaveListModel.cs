using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class LeaveSummaryModel {

        /// <summary>
        ///  Người nộp đơn (Tên nhân viên đang đăng nhập)
        /// </summary>
        public decimal SoPhepTheoQuyDinh { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public decimal SoPhepChuyenTuNamTruoc { get; set; }

        /// <summary>
        /// Đơn vị
        /// </summary>
        public decimal SoPhepDaNghi { get; set; }

        /// <summary>
        /// Phép năm
        /// </summary>
        public decimal SoPhepConLai { get; set; }

        public decimal CalSoPhepConLai
        {
            get
            {
                return SoPhepTheoQuyDinh + SoPhepChuyenTuNamTruoc - SoPhepDaNghi;
            }
        }

        /// <summary>
        /// Phép tồn năm trước
        /// </summary>
        public decimal NghiBuDuocHuong { get; set; }

        /// <summary>
        /// Số phép đã nghỉ
        /// </summary>
        public decimal NghiBuTonNamTruoc { get; set; }

        /// <summary>
        /// Số phép còn
        /// </summary>
        public decimal NghiBuDaSuDung { get; set; }

        /// <summary>
        /// Loại nghỉ phép / Lý do nghỉ phép
        /// </summary>
        public decimal NghiBuConLai { get; set; }

        public decimal CalNghiBuConLai
        {
            get
            {
                return NghiBuDuocHuong + NghiBuTonNamTruoc - NghiBuDaSuDung;
            }
        }
    }
}
