using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class OrgChartItemModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int HeadId { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        
    }
}
