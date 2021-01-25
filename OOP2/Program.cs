using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new CorporateCustomer
            {
                CustomerID = 1,
                CustomerNumber = "44521565662",
                CompanyName = "Cocoon",
                TaxIDNumber = "55659898965"
            };

            Customer customer2 = new GeneralCustomer
            {
                CustomerID = 1,
                CustomerNumber = "2545512141",
                CustomerName = "Kübra",
                CustomerLastName = "Terzi"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);










        }
    }
}
