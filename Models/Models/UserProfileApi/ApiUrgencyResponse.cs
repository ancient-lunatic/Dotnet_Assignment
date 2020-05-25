using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
  public  class ApiUrgencyResponse
    {
        public Int32 CommunityId { get; set; }
       // public DictionaryOfStringAndDictionaryOfStringAndInt32 UrgencyData { get; set; }
       public Dictionary<string , Dictionary<string , int>> UrgencyData { get; set; }
    }
}
