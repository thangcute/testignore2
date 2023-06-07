using Humax.ESS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class UserInfoModel
    {
        /// <summary>
        /// Id người dùng
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Id nhân viên
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Họ tên
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Chức danh
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Ảnh avatar
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        public string Username { get; set; }

        public string AvatarUrl {
            get
            {
                if (string.IsNullOrEmpty(Picture))
                    return ApiHelper.defaultAvatar;
                return "data:image/jpg;base64, " + Picture;
            }
        }
    }
}
