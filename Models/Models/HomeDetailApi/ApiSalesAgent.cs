using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.HomeDetailApi
{
    public class ApiSalesAgent
    {
        public String Email { get; set; }
        public String Img { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String Phone { get; set; }
        public Int32 BuilderId { get; set; }
        public Broker Broker { get; set; }
    }
}
