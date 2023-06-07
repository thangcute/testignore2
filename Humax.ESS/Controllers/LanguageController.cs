using System;
using Humax.ESS.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Humax.ESS.Controllers
{
    public class LanguageController : Controller
    {
        [HttpPost]
        public IActionResult SetLanguage(string language, string returnUrl)
        {
            Response.SetCurrentLanguage(language);

            return LocalRedirect(returnUrl);
        }
    }
}
