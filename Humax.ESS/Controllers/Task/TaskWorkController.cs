using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Controllers.Task
{
    public class TaskWorkController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        public TaskWorkController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/cong-viec/danh-sach")]
        [Route("/cong-viec/danh-sach/{type?}")]
        public async Task<IActionResult> IndexAsync(int? type)
        {
            return View("/Views/Task/Work/Index.cshtml");
        }

        [Route("/cong-viec/kanban")]
        [Route("/cong-viec/kanban/{type?}")]
        public async Task<IActionResult> KanbanAsync(int? type)
        {
            return View("/Views/Task/Work/Kanban.cshtml");
        }

        [Route("/cong-viec/grantt")]
        [Route("/cong-viec/grantt/{type?}")]
        public async Task<IActionResult> GranttAsync(int? type)
        {
            return View("/Views/Task/Work/Grantt.cshtml");
        }

        // view nhanh
        public async Task<IActionResult> ViewAsync(int id = 0)
        {
            ViewBag.Id = id;
            return PartialView("/Views/Task/Work/Partial/_TaskView.cshtml");
        }

        // them moi - cong viec con
        public async Task<IActionResult> DetailAsync(int id=0)
        {
            ViewBag.Id = id;
            return PartialView("/Views/Task/Work/Partial/_TaskDetail.cshtml");
        }

        // sua
        public async Task<IActionResult> EditAsync(int id = 0)
        {
            ViewBag.Id = id;
            return PartialView("/Views/Task/Work/Partial/_TaskDetail.cshtml");
        }

        // them dau viec
        public async Task<IActionResult> TaskListAsync(int id)
        {
            ViewBag.Id = id;
            return PartialView("/Views/Task/Work/Partial/_TaskList.cshtml");
        }

        // nhan ban cong viec
        public async Task<IActionResult> TaskReplicaAsync(int id)
        {
            ViewBag.Id = id;
            return PartialView("/Views/Task/Work/Partial/_TaskReplica.cshtml");
        }

        // cap nhat trang thai
        [HttpPost]
        public async Task<JsonResult> PostStatusAsync(int id)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm mới");

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        // cap nhat tien do - progress
        [HttpPost]
        public async Task<JsonResult> PostProgressAsync(int id)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm mới");

            return Json(new
            {
                success = _status,
                message = _message
            });
        }
    }
}
