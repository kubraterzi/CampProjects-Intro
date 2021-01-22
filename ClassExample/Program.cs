using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            Product product1 = new Product { ProductID = 1, ProductName = "Computer", UnitPrice = 7000, StockAmount = 10 };           
            Product product2 = new Product { ProductID = 2, ProductName = "GSM", UnitPrice = 4000, StockAmount = 30 };
            Product product3 = new Product { ProductID = 3, ProductName = "Printer", UnitPrice = 1600, StockAmount = 25 };

            Product[] productList = { product1, product2, product3 };

            // Foreach 
            foreach (var product in productList)
            {
                // Aşağıda {} işaretleri, bahsi geçen yerlere veri geleceğini bildirir. Ve bu veriler sırasıyla, aralarına virgül koyularak, string ifadesinin sonrasında gönderilir.
                Console.WriteLine("Product Name: {0} \nProduct Stock Amount: {1} \nProduct Unit Price : {2} \n\n", product.ProductName, product.StockAmount, product.UnitPrice);
            }

            // For
            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine("Product Name: {0} \nProduct Stock Amount: {1} \nProduct Unit Price : {2} \n\n", productList[i].ProductName, productList[i].StockAmount, productList[i].UnitPrice);
            }

            //While
            int item = 0;
            while (item < productList.Length)
            {
                Console.WriteLine("Product Name: {0} \nProduct Stock Amount: {1} \nProduct Unit Price : {2} \n\n", productList[item].ProductName, productList[item].StockAmount, productList[item].UnitPrice);
                item++;
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
