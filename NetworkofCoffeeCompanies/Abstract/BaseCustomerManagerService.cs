using NetworkofCoffeeCompanies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkofCoffeeCompanies.Abstract
{
    public abstract class BaseCustomerManagerService : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("\nSaved to Database : {0} {1} " , customer.CustomerName, customer.CustomerLastName);
        }
    }
}
