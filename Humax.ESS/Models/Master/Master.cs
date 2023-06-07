using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class MasterModel
    {
        /// <summary>
        /// Tên thông tin
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mô tả thông tin
        /// </summary>
        public string Desc { get; set; } = "";

        public object Tag { get; set; }

        public MasterModel(string Name, int Id, string Desc = "")
        {
            this.Name = Name;
            this.Id = Id;
            this.Desc = Desc;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
