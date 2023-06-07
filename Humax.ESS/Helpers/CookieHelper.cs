using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace Humax.ESS.Helpers
{
    public static class CookieHelper
    {
        public static string GetCurrentLanguage(this HttpRequest request)
        {
            string cultureCookie = null;
            if (request.Cookies.TryGetValue(CookieRequestCultureProvider.DefaultCookieName, out cultureCookie))
            {
                //c=en|uic=en
                var culture = CookieRequestCultureProvider.ParseCookieValue(cultureCookie);
                if (culture != null && culture.Cultures != null && culture.Cultures.Count > 0)
                    return culture.Cultures[0].Value;
            }

            return "vi";
        }

        public static void SetCurrentLanguage(this HttpResponse response, string language)
        {
            response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
        }

        public static bool IsDarkMode(this HttpRequest request)
        {
            if (request.Cookies.TryGetValue("dark", out string darkModeCookie))
            {
                return darkModeCookie == "1";
            }

            return false;
        }
    }
}
