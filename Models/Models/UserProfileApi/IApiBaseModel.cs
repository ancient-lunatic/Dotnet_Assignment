using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   
        public interface IApiBaseModel
        {
           
            string Time { get; set; }
           
            string Server { get; set; }
            
            Exception Error { get; set; }
        }
    }

