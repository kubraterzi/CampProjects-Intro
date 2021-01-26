using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class CustomerCheckService : ICustomerCheckService
    {
        public bool CustomerCheck(Customer customer)
        {
            if (customer.CustomerIdentityKey == "123456" && customer.CustomerName=="KÜBRA" && customer.CustomerLastName=="TERZİ" && customer.DateofBirth == new DateTime(2001,02,15))
            {
                Console.WriteLine("Login Successful!\n");
                return true;
            }
            Console.WriteLine("Login Failed!\n");

            return false;

        }

    }
}
