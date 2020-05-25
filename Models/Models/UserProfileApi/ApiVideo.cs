using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public class ApiVideo
    {
        public String NhsVideoId { get; set; }
        public String BcRefId { get; set; }
        public Int32 BuilderId { get; set; }
        public Int32 CommunityId { get; set; }
        public Int32 PlanId { get; set; }
        public Int32 Sort { get; set; }
        public String Title { get; set; }
        public String Caption { get; set; }
        public String Url { get; set; }
        public String Type { get; set; }
        public String SubType { get; set; }
        public String ThumbnailUrl { get; set; }
    }
}
