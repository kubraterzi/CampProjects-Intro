using GameCenter.Abstract;
using GameCenter.Adapters;
using GameCenter.Concrete;
using System;
using System.Collections.Generic;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Information Etries
            Console.WriteLine("Nationality ID :");
            string nationalityID = Console.ReadLine();

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Date of Birth:");
            DateTime dateofBirth = Convert.ToDateTime(Console.ReadLine());
            #endregion

            #region Customer Control Service

            Customer confirmedCustomer = new Customer
            {
                CustomerIdentityKey = nationalityID,
                CustomerName = name.ToUpper(),
                CustomerLastName = lastName.ToUpper(),
                DateofBirth = dateofBirth
            };

            // KPSWebService
            IPersonCheckService checkService = new MernisServiceAdapter();
            checkService.CheckIfRealPerson(confirmedCustomer);

            // Manual Control
            //ICustomerCheckService checkService = new CustomerCheckService();
            //checkService.CustomerCheck(confirmedCustomer);

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
            Customer customer1 = new Customer { CustomerID = 101, CustomerIdentityKey = "1111111", CustomerName = "Mehmet", CustomerLastName = "Akın", DateofBirth = new DateTime(2001,1,6)};
            Customer customer2 = new Customer { CustomerID = 102, CustomerIdentityKey = "2222222", CustomerName = "Zeynep", CustomerLastName = "Eren", DateofBirth = new DateTime(1997, 11, 26) };
            Customer customer3 = new Customer { CustomerID = 103, CustomerIdentityKey = "1111111", CustomerName = "Mehmet", CustomerLastName = "Akın", DateofBirth = new DateTime(1992, 5,17 )};
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
