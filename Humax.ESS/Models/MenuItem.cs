using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class MenuItem
    {
        public static string CurrentPath { get; set; }
        public string Text { get; set; }
        public string Path { get; set; }
        public string ImageIcon { get; set; }
        public string SvgIcon { get; set; }
        public string FaIcon { get; set; }
        public string Class { get; set; }
        public int Counter { get; set; }
        public bool IsActive
        {
            get
            {
                return Path == CurrentPath;
            }
        }

        public List<MenuItem> SubMenu { get; set; }
    }
}
