using ModelsRepository.Models.Profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Bookmark
{
    public class ApiBoardData
    {
        public Int32? HomeCount { get; set; }
        public Int32? ImageCount { get; set; }
        public List<BookmarkData> BookmarkData { get; set; }
    }
}
