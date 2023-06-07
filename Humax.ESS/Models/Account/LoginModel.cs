using Humax.ESS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Humax.ESS.Models
{
    public class LoginModel
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Language { get; set; }
        public bool Remember { get; set; }

        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class LoginRequest
    {
        public string DeviceId { get; set; }
        public string FireBaseToken { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string lDAPAddress { get; set; }
    }

    public class UserInfo
    {
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Picture { get; set; }
        public List<string> Permissions { get; set; }

        public string AvatarUrl
        {
            get
            {
                if (string.IsNullOrEmpty(Picture))
                    return ApiHelper.defaultAvatar;
                return "data:image/jpg;base64, " + Picture;
            }
        }
    }
}