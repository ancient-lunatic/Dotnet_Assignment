using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.HomeDetailApi
{
    public class ApiBuilder
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Phone { get; set; }
        public Boolean AllowUTMTracking { get; set; }
        public String State { get; set; }
        public Int16? PreferredScore { get; set; }
        public Int32 ParentBuilderId { get; set; }
        public String CustomMortgageLink { get; set; }
    }
}
