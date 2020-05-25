using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
   public class UserAction
    {
        public String UserId { get; set; }
        public String Name { get; set; }
        public String Comment { get; set; }
        public Boolean ByOwner { get; set; }
        public Boolean Like { get; set; }

    }
}
