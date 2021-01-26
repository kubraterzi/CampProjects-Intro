using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter
{
    public class CostumerManager : IManagerService<Customer>
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("Added!");
            Get(entity);
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Deleted!");
            Get(entity);
        }
        public void Update(Customer entity)
        {
            Console.WriteLine("Updated!");
            Get(entity);
        }
        public void Get(Customer entity)
        {
            Console.WriteLine("CustomerID: {0}\nCustomerName: {1}\nCustomerLastName: {2}", entity.CustomerID, entity.CustomerName, entity.CustomerLastName);
        }

        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("CustomerID: {0}\nCustomerName: {1}\nCustomerLastName: {2}", item.CustomerID, item.CustomerName, item.CustomerLastName);
            }
        }

       
    }
}
