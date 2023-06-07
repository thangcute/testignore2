using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    public class QTQuaTrinhBase
    {
        public bool IsAllowModify { get; set; } = true;

        public bool IsAllowDelete { get; set; } = true;

        public bool IsAllowNew { get; set; } = true;

        public bool ShowCommandButton { get; set; } = true;

        public string PermissionCode { get; set; } = "";

        public int NhanVienID { get; set; }

        public QTQuaTrinhBase(string permissioncode)
        {
            ApplyPermission(permissioncode);
        }

        public bool IsUseDigitalSignature { get; set; }

        /// <summary>
        /// Kiểm tra Option xem có Available cho sử dụng chữ ký số
        /// </summary>
        public bool IsiSignAvailable { get; set; }

        public void LoadiSignInfo()
        {
            //IsUseDigitalSignature = ConfigClass.ISIGN_APPLY;
            //IsiSignAvailable = iSignService.IsCAAvailable(NhanVienID);
        }

        /// <summary>
        /// Có sẵn sảng sử dụng chữ ký số không ?
        /// </summary>
        public bool IsOKUseiSign
        {
            get
            {
                return IsUseDigitalSignature && IsiSignAvailable;
            }
        }

        /// <summary>
        /// Check phân quyền chức năng
        /// </summary>
        /// <param name="code"></param>
        public void ApplyPermission(string code)
        {
            this.PermissionCode = code;
            if (!string.IsNullOrEmpty(code))
            {
                //IsAllowDelete = DatabaseCache.IsOKPermission(code + "_D", true);
                //IsAllowModify = DatabaseCache.IsOKPermission(code + "_M", true);
                //IsAllowNew = DatabaseCache.IsOKPermission(code + "_N", true);
            }
        }

        /// <summary>
        /// Kiểm tra quyền: Thêm mới - Sửa
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string CheckPermission(int ID)
        {
            if (ID > 0 && !IsAllowModify)
                return Translate("Bạn không có quyền chỉnh sửa thông tin !");

            if (ID <= 0 && !IsAllowNew)
                return Translate("Bạn không có quyền thêm mới thông tin !");

            return "";
        }

        public string Translate(string text)
        {
            return text;
        }
    }
}
