using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository.Models.Profile
{
    public class Brand
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 BuilderId { get; set; }
        public String Logo { get; set; }
        public String LogoSmall { get; set; }
        public Int32 MarketId { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String SiteUrl { get; set; }
        public Int32 ShowCaseStatusId { get; set; }
        public Int32 IsBasic { get; set; }
        public Int32 HasShowCase { get; set; }
        public Int32 TotalHome { get; set; }
        public Int32 CommunityCount { get; set; }
        public Int32 BoylCount { get; set; }
        public Int32 ModularCount { get; set; }
        public Int32 CustomCount { get; set; }
        public Int32 CustomBuilderCount { get; set; }
        public Int32 PlanCount { get; set; }
        public Int32 SpecCount { get; set; }
        public Int32 UnderConstructionCount { get; set; }
        public Int32 GalleryCount { get; set; }
        public String ShowMortgageLink { get; set; }
        public String CustomMortgageLink { get; set; }
        public Int32 TestimonialCount { get; set; }
        public Int32 IsBoyl { get; set; }
        public Int32 IsModularBuilder { get; set; }
        public Int32 IsCustomBuilder { get; set; }
        public Int32 IsNewCustomBuilderLocation { get; set; }
        public String Overview { get; set; }
        public String Description { get; set; }
        public String RssFeed { get; set; }
        public String TwitterWidget { get; set; }
        public String FacebookWidget { get; set; }
        public String BrandUrl { get; set; }
        public String ContactEmail { get; set; }
        public Location Location { get; set; }

    }
}
