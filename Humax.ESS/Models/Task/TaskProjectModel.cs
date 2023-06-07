using Humax.ESS.Models.Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Task
{
    public class TaskProjectModel : TSK_DuAn
	{
        // ngay thang view
        public string V_NgayBatDau { get; set; }
        public string V_NgayKetThuc { get; set; }

        public int NgayQuaHan { get; set; }

        public string TenTrangThai { get; set; }
        public string TenNguoiQuanTri { get; set; }
        public string HoNguoiQuanTri { get; set; }

        // theo doi & thuc hien
        public List<DependentModel> Followers { get; set; }

        public List<DependentModel> Executors { get; set; }
    }
}
