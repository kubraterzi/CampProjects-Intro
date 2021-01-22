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
            int girdi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for (int i = 0; i <= girdi; i++)
            {
                if (i % girdi == 0)
                {
                    sayac++;
                }
            }

            if (girdi % sayac == 0)
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
