using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class CustomerControlService : Customer
    {
        public CustomerControlService(Customer customer)
        {
            CustomerControl(customer);
        }

        public bool CustomerControl(Customer customer)
        {
            if (customer.CustomerIdentityKey == "123456" && customer.CustomerName=="Kübra" && customer.CustomerLastName=="Terzi" && customer.Date == "00.00.0000")
            {
                Console.WriteLine("Login Successful!\n");
                return true;
            }
            Console.WriteLine("Login Failed!\n");

            return false;

        }

    }
}
