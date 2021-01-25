using GameCenter.Concrete;
using System;
using System.Collections.Generic;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Customer Control Service            
            CustomerControlService controlService = new CustomerControlService(new Customer
            {
                CustomerIdentityKey = "123456",
                CustomerName = "Kübra",
                CustomerLastName = "Terzi",
                Date = "00.00.0000"
            });
            #endregion

            #region Added Entities
            // Products
            Product product1 = new Product { ProductID = 1, ProductName = "Football Manager 2021", ProductUnitPrice = 24 };
            Product product2 = new Product { ProductID = 2, ProductName = "FIFA 21", ProductUnitPrice = 44 };
            Product product3 = new Product { ProductID = 3, ProductName = "Raccoon City Edition", ProductUnitPrice = 34 };

            // Campaigns
            Campaign campaign1 = new Campaign { CampaignID = 10, CampaignName = "FIFA 21", LowerLimit = 0, DiscountRate = 0.3 };
            Campaign campaign2 = new Campaign { CampaignID = 11, CampaignName = "Raccoon City Edition", LowerLimit = 0, DiscountRate = 0.12 };
            Campaign campaign3 = new Campaign { CampaignID = 12, CampaignName = "November Discounts", LowerLimit = 200, DiscountRate = 0.3 };

            //Customers / Gamers
            Customer customer1 = new Customer { CustomerID = 101, CustomerIdentityKey = "1111111", CustomerName = "Mehmet", CustomerLastName = "Akın", Date = "01.01.2001" };
            Customer customer2 = new Customer { CustomerID = 102, CustomerIdentityKey = "2222222", CustomerName = "Zeynep", CustomerLastName = "Eren", Date = "02.02.2002" };
            Customer customer3 = new Customer { CustomerID = 103, CustomerIdentityKey = "1111111", CustomerName = "Mehmet", CustomerLastName = "Akın", Date = "03.03.2003" };
            #endregion

            #region Create Managers
            SalesManager salesManager = new SalesManager();
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            #endregion

            List<Product> productList = new List<Product> { product1, product2 ,product3};
            productManager.GetAll(productList);
            //salesManager.DiscountCalculate(product2, campaign3);
            //salesManager.DiscountCalculate(productList, campaign3);
            //customerManager.Add(customer3);
            //campaignManager.Update(campaign1);
            //productManager.Delete(product1);




        }
    }
}
