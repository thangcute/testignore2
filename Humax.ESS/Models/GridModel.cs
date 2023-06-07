using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class GridModel
    {
        public object data { get; set; }
        public int page { get; set; } = 1;
        public int size { get; set; } = 20;
        public int total { get; set; }
    }

    public class PaginationModel
    {
        public int page { get; set; } = 1;
        public int size { get; set; } = 20;
        public int total { get; set; }
    }
}
