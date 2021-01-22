using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun canta1 = new Urun();
            canta1.Marka = "Dolce&Gabbana";
            canta1.Renk = "Siyah";
            canta1.Fiyat = 22;

            Urun canta2 = new Urun();
            canta2.Marka = "Fendi";
            canta2.Renk = "Beyaz";
            canta2.Fiyat = 22;

            Urun canta3 = new Urun();
            canta3.Renk = "Sarı";
            canta3.Fiyat = 27;

            Urun[] urunler = { canta1, canta2, canta3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Marka : {0} \nRenk : {1} \nFiyat: {2}", urun.Marka, urun.Renk, urun.Fiyat);
            }


            Console.ReadLine();
        }
    }
    class Urun
    {
        public string Marka { get; set; }
        public string Renk { get; set; }
        public int Fiyat { get; set; }
    }
}
