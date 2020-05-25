using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   public class BookmarkAttribute
    {
        public Int32 Id { get; set; }
        public String UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Initials { get; set; }
        public Int16 ContentTypeId { get; set; }
        public String ContentTypeName { get; set; }
        public Int64 ContentId { get; set; }
        public String Title { get; set; }
        public String Url { get; set; }
        public BookmarkActionType Action { get; set; }
        public IList<UserProfile> SharedUsers { get; set; }
        public List<BookmarkData> BookmarkData { get; set; }
    }
    public class CreateBookmarkAttribute : BookmarkAttribute
    {
        public String Ownership { get; set; }
        public DateTime DateChanged { get; set; }
        public DateTime LastDataAdded { get; set; }
        public bool? Status { get; set; }
        public List<String> Notes { get; set; }
        public BookmarkData LastBookmarkAdded {get; set;}
    }
    public enum BookmarkActionType
    {
        Saved = 1,
        Like = 2,
        Dislike = 3,
        Board = 4,
        Lead = 5,
        Reco = 6,
        Neutral = 7
    }
}
