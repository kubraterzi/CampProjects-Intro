using NetworkofCoffeeCompanies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkofCoffeeCompanies.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
