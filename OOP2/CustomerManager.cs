using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added customer info  :  {0}" , customer.CustomerID);
        }
    }
}
