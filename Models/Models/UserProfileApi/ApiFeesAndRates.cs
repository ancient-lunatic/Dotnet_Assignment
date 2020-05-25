using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   public class ApiFeesAndRates
    {
        public String Description { get; set; }
        public String TypeCode { get; set; }
        public Decimal MonthlyFee { get; set; }
        public Decimal YearlyFee { get; set; }
        public Int32 CommunityId { get; set; }
    }
}
