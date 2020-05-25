using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public class ApiAmenity
    {
        public String Type { get; set; }
        public String TypeCode { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public Int32 Open { get; set; }
        public Int32 AmenityId { get; set; }
        public Int32 AmenityGroupId { get; set; }
        public Int32 Sequence { get; set; }
    }
}
