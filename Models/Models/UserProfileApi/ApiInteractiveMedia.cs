using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   public class ApiInteractiveMedia
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Url { get; set; }
        public String Code { get; set; }
        public Boolean UseFlash { get; set; }
        public String Type { get; set; }
    }
}
