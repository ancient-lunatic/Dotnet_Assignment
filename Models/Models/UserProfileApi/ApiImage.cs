using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public  class ApiImage
    {
        public Int32 Id { get; set; }
        public Int32 Sequence { get; set; }
        public Int32 BuilderId { get; set; }
        public Int32 CommId { get; set; }
        public Int32 SpecId { get; set; }
        public String Title { get; set; }
        public String Caption { get; set; }
        public String Path { get; set; }
        public String OriginalPath { get; set; }
        public String Type { get; set; }
        public Int32 Pos { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }
        public String ClickThruURL { get; set; }
        public String PrimaryFlag { get; set; }
        public Boolean Is360Image { get; set; }

    }
}
