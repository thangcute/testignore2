using Humax.ESS.Helpers;
using Humax.ESS.Models;
using Humax.ESS.Models.Post;
using Humax.ESS.Models.Profile.TrainingProcess;
using Humax.ESS.Models.Social;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PostModel = Humax.ESS.Models.PostModel;

namespace Humax.ESS.Controllers.Social
{
    public class PostController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly ApiOosHelper _apiOosHelper;

        public PostController(IWebHostEnvironment environment,
            ApiOosHelper apiOosHelper)
        {
            _hostingEnvironment = environment;
            _apiOosHelper = apiOosHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult> Index(PostNewModel model)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm Media");

            if (Request.Method == HttpMethod.Post.Method)
            {
                List<string> _media = new List<string>();
                if (model.Media != null && model.Media.Any())
                {
                    string _directoryPath = Path.Combine(_hostingEnvironment.WebRootPath, "Medias/Posts");
                    _media = await FileHelper.save(model.Media, _directoryPath);
                }
            }

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        //IFormFile
        //FormCollection fc
        //IFormFile media
        [HttpPost]
        public async Task<JsonResult> PostAddMediaAsync()
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm Media");

            if (Request.Method == HttpMethod.Post.Method)
            {
                IFormFile media = Request.Form.Files["media"];

                try
                {
                    List<PostMediaModel> listMedia;
                    listMedia = SessionHelper.Get<List<PostMediaModel>>(HttpContext.Session, "postMedia");
                    if (listMedia == null || !listMedia.Any())
                        listMedia = new List<PostMediaModel>();

                    string _guid = Guid.NewGuid().ToString();
                    listMedia.Add(new PostMediaModel
                    {
                        code = _guid,
                        media = media
                    });
                    SessionHelper.Set(HttpContext.Session, "postMedia", listMedia);

                    _status = 1;
                    _message = _guid;
                }
                catch
                {

                }
            }
            else
                _message = "Phương thức không hợp lệ.";

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        [HttpPost]
        public async Task<JsonResult> PostDeleteMediaAsync(string guid)
        {
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Thêm Media");

            if (Request.Method == HttpMethod.Post.Method)
            {
                try
                {
                    List<PostMediaModel> listMedia;
                    listMedia = SessionHelper.Get<List<PostMediaModel>>(HttpContext.Session, "postMedia");
                    if (listMedia != null || listMedia.Any())
                    {
                        PostMediaModel item = new PostMediaModel();
                        foreach (var _item in listMedia)
                        {
                            if (_item.code == guid)
                            {
                                item = _item;
                                break;
                            }
                        }

                        if (item != null)
                        {
                            listMedia.Remove(item);
                            SessionHelper.Set(HttpContext.Session, "postMedia", listMedia);
                        }

                        _status = 1;
                        _message = guid;
                    }
                    else
                        _message = "Không tìm thấy thông tin Media";
                }
                catch
                {

                }
            }
            else
                _message = "Phương thức không hợp lệ.";

            return Json(new
            {
                success = _status,
                message = _message
            });
        }

        //like
        [HttpPost]
        
        public async Task<JsonResult> Likes(PostlikeModel model)
        {
            
            
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Like");
            if (ModelState.IsValid)
            {
                try
                {

                    
                    var response = await _apiOosHelper.Post<PostlikeModel>(HttpContext.Session, "/api/Post/Likes", model);
                    if (response.Status == 1)
                    {
                        _status = 1;
                        _message = "Like thành công!";

                    }

                    
                }catch(Exception ex)
                {
                    _status = 0;
                    _message = ex.Message;
                    
                }

                return Json(new
                {
                    success = _status,
                    message = _message
                });


            }
            else
            {
                return Json(new
                {
                    success = 99,
                    message = "Validation",
                    validation = ModelState.Keys.SelectMany(key => ModelState[key].Errors.Select(x => new ValidationMessage(key, x.ErrorMessage))).ToList(),
                });
            }
        }

        //comment
        public async Task<JsonResult> Comment(PostCommentModel model)
        {
            //PostCommentModel model = new PostCommentModel();
            //model.PostId = int.Parse(formCollection["PostId"]);
            //model.Content = formCollection["Content"];
            var _status = 0;
            var _message = string.Format("{0} không thành công", "Comment");
            if (ModelState.IsValid)
            {
                try
                {

                    var response = await _apiOosHelper.Post<PostCommentModel>(HttpContext.Session, "/api/Post/Comment", model);
                    if (response.Status == 1)
                    {
                        _status = 1;
                        _message = "Comment thành công!";
                    }
                }catch(Exception ex)
                {
                    _status = 0;
                    _message = ex.Message;
                }
                return Json(new
                {
                    success=_status,
                    message=_message
                });
            }
            else
            {
                return Json(new
                {
                    success=99,
                    message= "Validation",
                    validation = ModelState.Keys.SelectMany(key => ModelState[key].Errors.Select(x => new ValidationMessage(key, x.ErrorMessage))).ToList(),
                });
            }
        }
    }
}
