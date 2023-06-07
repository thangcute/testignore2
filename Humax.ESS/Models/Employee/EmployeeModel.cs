using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Employee
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Des { get; set; }

        public string Department { get; set; }

        public string JobTitle { get; set; } // chuc danh

        public string JobPosition { get; set; } // chuc vu

        public string Picture { get; set; }
    }
}
