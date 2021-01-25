using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class SalesManager : Campaign
    {
        IManagerService<Product> manager = new ProductManager();
        public void DiscountCalculate(Product product, Campaign campaign)
        {
           
            double unitPrice = Convert.ToDouble(product.ProductUnitPrice);
            double discountedRate = Convert.ToDouble(campaign.DiscountRate);
            double lowerLimit = Convert.ToDouble(campaign.LowerLimit);


            if (unitPrice >= lowerLimit)
            {
                unitPrice = unitPrice - unitPrice * discountedRate;

                Console.WriteLine("Game : {0}  |  Unit Price: {1}\nCampaignName:  {2}  |  DiscountRate:  {3}  |  DiscountedPrice:  {4}\n",
                    product.ProductName, product.ProductUnitPrice, campaign.CampaignName, campaign.DiscountRate, unitPrice);

            }
           
        }

        
        public decimal DiscountCalculate(List<Product> productList, Campaign campaign)
        {
            
            double total = 0;
            double discountedAmount = 0;

            manager.GetAll(productList);

            for (int i = 0; i < productList.Count; i++)
            {
                total = total + (double)productList[i].ProductUnitPrice;
                if (total >= (double)campaign.LowerLimit)
                {
                    discountedAmount = total - total * (double)campaign.DiscountRate;
                }
                
            }
            if (!(total >= (double)campaign.LowerLimit))
            {
                Console.WriteLine("\nDid not reach the lower limit - No discount was applied");
            }
            Console.WriteLine("\nTotal Amount:  {0}\nDiscounted Amount:  {1:F}\n", total, discountedAmount);

            return (decimal)discountedAmount;

        }
    }
}
