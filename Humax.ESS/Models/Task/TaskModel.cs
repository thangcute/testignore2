using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Task
{
    public class DependentModel
    {
        public int Id { get; set; }
        public int NhanVienID { get; set; }
        public string HoTenNhanVien { get; set; }
        public string ChucVu { get; set; }
        public int Xoa { get; set; }
    }

    public class ProjectPersonModel
    {
        public int Id { get; set; }

        public List<DependentModel> Followers { get; set; }

        public List<DependentModel> Executors { get; set; }

        public int ModifyByID { get; set; }
    }
}
