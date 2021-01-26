using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class Campaign : IEntity
    {
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public decimal LowerLimit { get; set; }
        public double DiscountRate { get; set; }
    }
}
