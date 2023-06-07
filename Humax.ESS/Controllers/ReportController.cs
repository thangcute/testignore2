using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers
{
    public class ReportController : Controller
    {
        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult OrgChart()
        {
            if (!HttpContext.Session.HasLoggedIn())
                return RedirectToAction("Login", "Account");

            List<OrgChartItemModel> model = new List<OrgChartItemModel> {
                new OrgChartItemModel{
                   Id = 1,
                   HeadId = 0,
                   FullName = "HOA LỆ",
                   Title = "Giám đốc",
                   Photo = "/img/ava-1.png"
                },
                new OrgChartItemModel{
                   Id = 2,
                   HeadId = 1,
                   FullName = "TUNG SHINU",
                   Title = "Phó giảm đốc kinh doanh",
                   Photo = "/img/ava-2.png"
                },
                new OrgChartItemModel{
                   Id = 3,
                   HeadId = 1,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 4,
                   HeadId = 1,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 5,
                   HeadId = 1,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 6,
                   HeadId = 1,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 7,
                   HeadId = 1,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },

                new OrgChartItemModel{
                   Id = 8,
                   HeadId = 2,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 9,
                   HeadId = 2,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 10,
                   HeadId = 2,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },

                new OrgChartItemModel{
                   Id = 11,
                   HeadId = 7,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 12,
                   HeadId = 7,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 13,
                   HeadId = 7,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },

                new OrgChartItemModel{
                   Id = 14,
                   HeadId = 13,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 15,
                   HeadId = 13,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
                new OrgChartItemModel{
                   Id = 17,
                   HeadId = 13,
                   FullName = "ĐINH VĂN TÒNG",
                   Title = "Phó giám đốc kỹ thuật",
                   Photo = "/img/ava-3.png"
                },
            };

            return View(model);
        }
    }
}
