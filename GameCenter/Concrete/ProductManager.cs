using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Concrete
{
    public class ProductManager : IManagerService<Product>
    {
        public void Add(Product entity)
        {
            Console.WriteLine("Added!");
            Get(entity);
        }

        public void Delete(Product entity)
        {
            Console.WriteLine("Deleted!");
            Get(entity);
        }
        public void Update(Product entity)
        {
            Console.WriteLine("Updated!");
            Get(entity);
        }
        public void Get(Product entity)
        {
            Console.WriteLine("ProductID: {0}  |  ProductName: {1}  |  ProductUnitPrice: {2}\n", entity.ProductID, entity.ProductName, entity.ProductUnitPrice);
        }

        public void GetAll(List<Product> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("ProductID: {0}  |  ProductName: {1}  |  ProductUnitPrice: {2}", item.ProductID, item.ProductName, item.ProductUnitPrice);
            }
            Console.WriteLine();
        }
    }
}
