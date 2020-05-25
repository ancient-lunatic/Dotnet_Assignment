using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Bookmark
{
   public class UpdateBookmarkResponse
    {
        public Int32 BookmarkId { get; set; }
        public Int32 BookmarkDataId { get; set; }
        public string UserEmailInvited { get; set;}
        public string Message { get; set;}
        public bool Success { get; set;}
        public List<Int32> BookmarkIds  { get; set;}

    }

}
