using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Social
{
    public class PostModel
    {

    }

    public class PostNewModel
    {
        /// <summary>
        /// Id bài viết
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tiêu đề bài viết
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Nội dung bài viết
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Danh sách file Media
        /// </summary>
        public List<IFormFile> Media { get; set; }
    }

    public class PostMediaModel
    {
        public string code { get; set; }
        public IFormFile media { get; set; }
    }
}
