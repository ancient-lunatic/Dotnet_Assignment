using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsRepository.Models.Profile
{

    public  class UserProfile
        {

        [Required]
        public String UserId { get; set; }
        [Required]
        public String LogonName { get; set; }
        [Required]
        public String PartnerId { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        public String MiddleName { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String RegMetro { get; set; }
        [Required]
        public String State { get; set; }
        [Required]
        public String PostalCode { get; set; }
        public String Initials { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
            public String Phone { get; set; }
            public String PhoneExt { get; set; }
       
            public String SsoId { get; set; }
            public String ImageUrl { get; set; }
            public Int32 MoveInDate { get; set; }
            public Int32 FinancePreference { get; set; }
            public Int32 Reason { get; set; }
            public Int32 AgeRange { get; set; }
            public Int32 HomePrefence { get; set; }
       
            public Byte AccountStatus { get; set; }
            public UserProfile LinkedUser { get; set; }
        public DateTime DateRegistered { get; set; }
        public String LeadOptIn { get; set; }
        public Boolean RegBOYLInterest { get; set; }
        public Boolean RegComingSoonInterest { get; set; }
        public Boolean RegActiveAdultInterest { get; set; }
        public Boolean WeeklyOptIn { get; set; }
        public Boolean WeeklyHomeOptIn { get; set; }
        public Boolean MarketOptIn { get; set; }
        public Boolean MailList { get; set; }
        public List<BookmarkAttribute> Bookmarks { get; set; }
        public List<UserProfileShare> SharedUserProfiles { get; set; }
        public List<BookmarkAttribute> Boards { get; set; }
        public UserProfileShareStatus InvitationStatus { get; set; }

    
}
}
