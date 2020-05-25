using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{

    public class UserProfileShare
    {
        public UserProfile SourceUser { get; set; }
        public UserProfile SharedUser { get; set; }
        public String UserSharedEmail { get; set; }
        public String Status { get; set; }
        public DateTime Date { get; set; }

    }
    public enum UserProfileShareStatus
    {
        None = 0,
        InvitationSent = 1,
        Invited = 11,
        Accepted = 12,
        Rejected = 14,
        Deleted = 15
    }
}
    

