using NetworkofCoffeeCompanies.Abstract;
using NetworkofCoffeeCompanies.Concrete;
using NetworkofCoffeeCompanies.Entities;
using System;

namespace NetworkofCoffeeCompanies
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
                CustomerNationalityID = nationalityID,
                CustomerName = name.ToUpper(),
                CustomerLastName = lastName.ToUpper(),
                DateofBirth = dateofBirth
            };
            #endregion

            // KPSWebService
            BaseCustomerManagerService baseCustomerManagerService = new StarbucksCustomerManager(new CustomerCheckManager());
            baseCustomerManagerService.Save(confirmedCustomer);


        }
    }
}
