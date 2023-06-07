using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IStringLocalizer<AccountController> _localizer;
        private readonly ApiOosHelper _apiOosHelper;

        public AccountController(ILogger<AccountController> logger,
            IStringLocalizer<AccountController> localizer,
            ApiOosHelper apiOosHelper)
        {
            _logger = logger;
            _localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
            _apiOosHelper = apiOosHelper;
        }

        public IActionResult Login(LoginModel model)
        {
            if (string.IsNullOrEmpty(model.Language))
                model.Language = Request.GetCurrentLanguage();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginModel model)
        {
            if (model.Language != Request.GetCurrentLanguage())
            {
                Response.SetCurrentLanguage(model.Language);
                return RedirectToAction("Login", model);
            }

            model = await _apiOosHelper.Login(HttpContext.Session, model);

            if (model.Status == 1)
                return RedirectToAction("Index", "Home");

            _logger.LogError("Login failed: " + model.Message);

            model.Message = _localizer["login.invalidAccount"];

            return View(model);
        }
    }
}
