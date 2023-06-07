using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humax.ESS.Models
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }

        public string Token { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
        public int Total { get; set; }
    }
}