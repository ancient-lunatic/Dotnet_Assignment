using ModelsRepository.Models.Profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Bookmark
{
    public class ApiCreateBookmark
    {
        public Int32 Id { get; set; }
        public BookmarkActionType Action { get; set; }
        public String UserId { get; set; }
        public String BoardOwnerUserId { get; set; }
        public String UserContent { get; set; }
        public BookmarkContentType ContentType { get; set; }
        public List<Int32> ContentIds { get; set; }
        public Int32 TemplateId { get; set; }
        public Int32 BookmarkId { get; set; }
        public List<Int32> BookmarkIds { get; set; }
        public Int32 Likes { get; set; }
        public Int32 Dislikes { get; set; }
        public string Comment { get; set; }
        public List<string> Notes { get; set; }
        public List<UserAction> UserActions { get; set; }
        public ImageInfo ImageInfo { get; set; }
        public HomeInfo HomeInfo { get; set; }
        public DateTime DateChanged { get; set; }
    }
   

}
