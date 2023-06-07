using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Helpers
{
    public class BusinessHelper
    {
        public static string DayOfWeek(DateTime dateTime, int type = 1)
        {
            string rs = "";
            if (!string.IsNullOrEmpty(dateTime.ToString()))
            {
                switch (dateTime.DayOfWeek)
                {
                    case System.DayOfWeek.Monday:
                        rs = type > 0 ? "Mon" : "T2";
                        break;
                    case System.DayOfWeek.Tuesday:
                        rs = type > 0 ? "Tue" : "T3";
                        break;
                    case System.DayOfWeek.Wednesday:
                        rs = type > 0 ? "Wed" : "T4";
                        break;
                    case System.DayOfWeek.Thursday:
                        rs = type > 0 ? "Thu" : "T5";
                        break;
                    case System.DayOfWeek.Friday:
                        rs = type > 0 ? "Fri" : "T6";
                        break;
                    case System.DayOfWeek.Saturday:
                        rs = type > 0 ? "Sat" : "T7";
                        break;
                    case System.DayOfWeek.Sunday:
                        rs = type > 0 ? "Sun" : "CN";
                        break;
                    default:
                        break;
                }
            }
            return rs;
        }
    }
}
