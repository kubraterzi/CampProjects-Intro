using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter
{
    public class CustomerManager : IManagerService<Customer>
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
            Console.WriteLine("CustomerID: {0}  |  CustomerName: {1}  |  CustomerLastName: {2}\n", entity.CustomerID, entity.CustomerName, entity.CustomerLastName);
        }

        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("CustomerID: {0}  |  CustomerName: {1}  |  CustomerLastName: {2}", item.CustomerID, item.CustomerName, item.CustomerLastName);
            }
            Console.WriteLine();
        }

       
    }
}
