using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace Humax.ESS.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!HttpContext.Session.HasLoggedIn())
                context.Result =  RedirectToAction("Login", "Account");


            base.OnActionExecuting(context);
        }
    }
}
