using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
  public  class ImageInfo
    {
        public Int32 Id { get; set; }
        public String Path { get; set; }
        public String ColorType { get; set; }
        public String Category { get; set; }
        public String Type { get; set; }
        public Int16 Width { get; set; }
        public Int16 Height { get; set; }
        public Int32 Sequence { get; set; }
        public String ObjectLabels { get; set; }
            
    }
}
