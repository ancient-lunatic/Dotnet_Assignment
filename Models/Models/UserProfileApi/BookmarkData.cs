using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public class BookmarkData
    {
        public Int32 Id { get; set; }
        public BookmarkActionType Action { get; set; }
        public String UserId { get; set; }
        public String BoardOwnerUserId { get; set; }
        public String UserContent { get; set; }
        public BookmarkContentType ContentType { get; set; }
        public List<Int32> ContentIds { get; set; }
        public List<Int32> BookmarkIds { get; set; }
        public List<UserAction> UserActions { get; set; }
       public ImageInfo ImageInfo { get; set; }
        public HomeInfo HomeInfo { get; set; }

    }
    public enum BookmarkContentType
    {
        Market = 1,
        Builder = 2,
        Community = 3,
        Plan = 4,
        Spec = 5,
        Interior = 8,
        Exterior = 9,
        Board = 12,
        Image = 13
    }
}
