using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class CampaignManager : IManagerService<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Added!");
            Get(entity);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Deleted!");
            Get(entity);
        }
        public void Update(Campaign entity)
        {
            Console.WriteLine("Updated!");
            Get(entity);
        }
        public void Get(Campaign entity)
        {
            Console.WriteLine("CampaignID: {0}  |  CampaignName: {1}  |  LowerLimit: {2}  |  DiscountRate: {3}\n", entity.CampaignID, 
                entity.CampaignName, entity.LowerLimit, entity.DiscountRate);
        }

        public void GetAll(List<Campaign> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("CampaignID: {0}  |  CampaignName: {1}  |  LowerLimit: {2}  |  DiscountRate: {3}", item.CampaignID, 
                    item.CampaignName, item.LowerLimit, item.DiscountRate);
            }
            Console.WriteLine();
        }
    }
}
