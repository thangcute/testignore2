using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Helpers
{
    public static class CommonHelper
    {
        public static string Base64Extension(string Base64String, bool data = false)
        {
            string Extension = string.Empty;
            if (!string.IsNullOrEmpty(Base64String) && Base64String.Length > 4)
            {
                var ExtensionType = Base64String.Substring(0, 5);
                switch (ExtensionType.ToUpper())
                {
                    case "IVBOR":
                        Extension = "png";
                        break;
                    case "/9J/4":
                        Extension = "jpg";
                        break;
                    case "AAAAF":
                        Extension = "mp4";
                        break;
                    case "JVBER":
                        Extension = "pdf";
                        break;
                    case "AAABA":
                        Extension = "ico";
                        break;
                    case "UMFYI":
                        Extension = "rar";
                        break;
                    case "E1XYD":
                        Extension = "rtf";
                        break;
                    case "U1PKC":
                        Extension = "txt";
                        break;
                    case "MQOWM":
                    case "77U/M":
                        Extension = "srt";
                        break;
                    default:
                        Extension = string.Empty;
                        break;
                }
            }

            if (data)
            {
                if (!string.IsNullOrEmpty(Extension))
                    return string.Format("data:image/{0};base64,{1}", Extension, Base64String);

                return ApiHelper.defaultAvatar;
            }
            else
                return Extension;

            //string rs = "";
            //Match match = Regex.Match(encoded, @"^data:([a-zA-Z0-9]+/[a-zA-Z0-9]+).*,.*$", RegexOptions.IgnoreCase);
            //if (match.Success)
            //    rs = match.Groups[1].Value;
            //return rs;
        }
    }
}
