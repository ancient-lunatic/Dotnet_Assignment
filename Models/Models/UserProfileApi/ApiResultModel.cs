using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   public class ApiResultModel<T>
    {
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Exception Error { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        
        public string Server { get; set; }
        
        public T Result { get; set; }
    
    }
}
