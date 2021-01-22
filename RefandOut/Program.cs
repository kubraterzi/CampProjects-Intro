using System;

namespace RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] haylazlar = new int[] { 1, 2, 3, 4 };

            // out ve ref'i stackte değişiklik yapmak için kullanıyoruz.

            // Eğer burada out kullanmazsak fonksiyonun içerisinde kullanılan array fonksiyondan çıkılınca eski halini alır. Bu nedenle parametre ve parametre olarak verilecek değişkenler
            // birbirleriyle bağdaştırılmalıdır. Biri diğerinin üzerindeki tüm değişiklikleri kendi almalıdır. Out kullanmazsak çıktı 1,2,3,4 olur; kullanırsak da 100,200,300 olur.

            static void DiziDegeriDegistir(out int[] yaramazlar)
            {
                int[] sayilar = new int[] { 100, 200, 300 };
                yaramazlar = sayilar; // 102
                // yaramazlar[0] = 15; // eğer parametreler out olarak tanımlanmasaydı, tıpkı metot içerisindeki tüm işlemlerin fonksiyondan çıkınca etkilenmemiş olması gibi neticeyi
                // etkilemezdi. Ancak out olduğu için adresi üzerinde değişiklik yapıldığı için çıktı 15, 200,300 olurdu.
            }

            DiziDegeriDegistir(out haylazlar);

            foreach (var item in haylazlar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
