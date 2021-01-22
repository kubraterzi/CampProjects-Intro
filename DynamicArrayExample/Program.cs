using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int temporal;
            int[] numberList = new int[25];

            Random rnd = new Random();
            for (int i = 0; i < numberList.Length; i++)
            {
                numberList[i] = rnd.Next(1, 101);
            }


            Console.WriteLine("Dizinin İlk Hali;");
            foreach (int number in numberList)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            for (int i = 0; i < numberList.Length - 1; i++)
            {
                for (int j = i + 1; j < numberList.Length; j++)
                {
                    if (numberList[i] > numberList[j])
                    {
                        temporal = numberList[j];
                        numberList[j] = numberList[i];
                        numberList[i] = temporal;
                    }
                }
            }

            Console.WriteLine("\nDizinin Son Hali;");
            foreach (int sayi in numberList)
            {
                Console.Write("{0} ", sayi);
            }

            Console.ReadLine();
        }
    }
}
