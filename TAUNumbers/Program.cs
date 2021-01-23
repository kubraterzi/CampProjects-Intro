using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAUNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // TAU sayısı kendisi dahil tüm bölenlerinin sayısına bölünebilen sayılardır.
            int input = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= input; i++)
            {
                if (i % input == 0)
                {
                    counter++;
                }
            }

            if (input % counter == 0)
            {
                Console.WriteLine("Tau Sayısıdır.");
            }
            else
            {
                Console.WriteLine("Tau Sayısı değldir.");
            }


            Console.ReadLine();

        }
    }
}
