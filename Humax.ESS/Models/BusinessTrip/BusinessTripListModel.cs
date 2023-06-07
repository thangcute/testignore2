using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class BusinessTripListModel
    {
        /// <summary>
        ///  Người nộp đơn (Tên nhân viên đang đăng nhập)
        /// </summary>
        public string Applicant { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Đơn vị
        /// </summary>
        public string Department { get; set; }

    }
}
