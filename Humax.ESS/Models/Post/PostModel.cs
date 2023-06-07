using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models
{
    /// <summary>
    /// Bài viết
    /// </summary>
    public class PostModel
    {
        /// <summary>
        /// Id bài viết
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id của nhóm
        /// </summary>
        public int? PostId { get; set; }

        /// <summary>
        /// Id của tk
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Loại bài viết
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// Id bài viết được chia sẻ bởi bài viết này
        /// </summary>
        public int? SharedPostId { get; set; }

        #region HeaderInfo
        /// <summary>
        /// Thông tin người đăng
        /// </summary>
        public UserInfoModel User { get; set; }

        /// <summary>
        /// Ngày đăng
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Phạm vi xuất bản
        /// </summary>
        public Scope Scope { get; set; }
        #endregion

        #region Content (Nội dung)
        /// <summary>
        /// Tiêu đề bài viết
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Nội dung bài viết
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Danh sách ảnh
        /// </summary>
        public List<string> Photos { get; set; }

        /// <summary>
        /// Danh sách tài liệu đính kèm
        /// </summary>
        public List<string> Files { get; set; }

        /// <summary>
        /// Danh sách người dùng được tag vào bài viết
        /// </summary>
        public List<UserInfoModel> Tags { get; set; }


        /// <summary>
        /// Thông tin để hiển thị liên kết đầu tiên trong nội dung bài viết (nếu có)
        /// </summary>
        public LinkPreviewModel LinkPreview { get; set; }
        #endregion

        #region Statitics (Thống kê)
        /// <summary>
        /// Tổng lượt xem
        /// </summary>
        public int? ViewCount { get; set; }

        /// <summary>
        /// Tổng số tương tác (bằng biểu tượng cảm xúc)
        /// </summary>
        public int? ReactionCount { get; set; }

        /// <summary>
        /// 3 tương tác gần nhất (hoặc nhiều nhất)
        /// </summary>
        public List<Reaction> TopReactions { get; set; }

        /// <summary>
        /// Tổng lượt chia sẻ
        /// </summary>
        public int? ShareCount { get; set; }

        /// <summary>
        /// Tổng số bình luận (gồm cả trả lời bình luận)
        /// </summary>
        public int? CommentCount { get; set; }

        /// <summary>
        /// Tương tác của người dùng hiện tại 
        /// </summary>
        public Reaction Reacted { get; set; }
        #endregion

        public string PostDate
        {
            get
            {
                if (CreatedDate.HasValue)
                    return CreatedDate.Value.ToShortDateString();
                return "";
            }
        }
    }
}
