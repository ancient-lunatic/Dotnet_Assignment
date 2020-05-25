using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.HomeDetailApi
{
    public class ApiHomeOption
    {
        public Int32 Id { get; set; }
        public String Type { get; set; }
        public String Desc { get; set; }
        public Int32 Size { get; set; }
        public String Price { get; set; }
        public String Code { get; set; }
    }
}
