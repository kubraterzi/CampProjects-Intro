using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO NOT REPEAT YOURSELF!
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun <dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Düşüş Butonu");
            }
            else
            {
                Console.WriteLine("Sabit Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap.");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
