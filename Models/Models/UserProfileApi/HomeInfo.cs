using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public class HomeInfo
    {
        public Int32 HomeId { get; set; }
        public Int32 CommId { get; set; }
        public Int32 PlanId { get; set; }
        public Int32 ListingId { get; set; }
        public Boolean IsBasic { get; set; }
        public String CommName { get; set; }
        public String PlanName { get; set; }
        public Boolean IsSpec { get; set; }
        public Int32 MarketId { get; set; }
        public Int32 BuilderId { get; set; }
        public Int32 Br { get; set; }
        public Int32 Ba { get; set; }
        public Int32 HBa { get; set; }
        public Int32 St { get; set; }
        public Int32 Gr { get; set; }
        public Int32 Sft { get; set; }
        public Decimal Price { get; set; }
        public String Addr { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String State { get; set; }
        public String Thumb1 { get; set; }
        public String Thumb2 { get; set; }
        public String IntImage { get; set; }
        public String Zip { get; set; }
        public String Status { get; set; }
        public String BrandLogo { get; set; }
        public Brand Brand { get; set; }

    }
}
