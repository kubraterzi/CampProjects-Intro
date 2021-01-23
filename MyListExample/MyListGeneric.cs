using System;
using System.Collections.Generic;
using System.Text;

namespace MyListExample
{
    public class MyListGeneric<T>
    {
        T[] _items; // Neden başına _ koyarız? Genelde class içerisinde tanımlanan değişkenlerin başına _ konulur. Programcıya uygulamaya ilk baktığında, bu değişkeni nerede arayacağına dair
        // bir ipucu vermek adına tasarlanmış bir Best Practise' dir.

        public MyListGeneric()
        {
            _items = new T[0]; // Neden Constructor sınıfında new ledik? Program yazıldığında ve sistem çalıştırıldığında MyList class ı new lenmeyecek olsa dahi bu diziyi oluşturur. Bu
            // bellek açısıdan maliyetli bir durumdur. Yalnızca MyList class ı new lendiği zaman bu dizinin oluşturulmasını istediğimiz için, diziye boyutunu bu sınıfta veriyoruz.
            // Constructor sınıfı: bir class new lendiği ilk anda çalıştıracağı kod bloklarını bulunduran bir sınıftır.
        }

        public void Add(T item)
        {
            T[] tempArray = _items;
            _items = new T[_items.Length + 1]; // Dizinin sonuna bir eleman ekleyeceğimiz için, dizi sonunda 1 elemanlık bir alan açmalıyız. Ancak mevcut dizinin boyutunu değiştiremeyeceğimiz
            // için, mevcut dizi boyutumuzdan 1 eleman fazla olacak şekilde yeni bir dizi üretiyoruz. Ancak, her new lemede eski dizinin elemanları silineceği için, silinmeden önce yedeklemiş
            // olmak için yeni geçici bir dizi oluşturuyoruz.(tempArray[]) Ancak bu oluşturma işlemini, dizi üzerinden eleman arttırma işlemi yapılmadan önce tanımlamamız gerekiyor ki, program
            // yukarıdan aşağı derlenmeye başladığı için, arttırma işleminden önce yedekleme işlemini yaptırsın.

            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i]; // Burada bu for döngüsü, diziler arasında aktarımı sağlamak için tasarlanmıştır. tempArray[] içerisinde verilerin silinmeden önceki her hali saklanmaktadır.
                // _items[] dizisi artık +1 elemanlı olduğu için, tempArray[] _items[] dizisine tüm elemanlarını aktardıktan sonra, _items[] dizisinin sonunda 1 elemanlık bir boşluk oluşuyor.
            }

            _items[_items.Length - 1] = item; // bir dizinin elemanları 0' dan başladığı için, eleman sayısının 1 eksiği aslında o dizinin sonuncu index ini ifade eder. Biz de, _items[] dizisinin
            // son elemanına ulaşmak için, toplam eleman sayısının(_items.Length) 1 eksiğini alıyoruz. Bu bize 6 elemanlık olan dizinin 5. indisini veriyor. ([0]- [1]- [2]- [3]- [4]- [5])
        }

        public void GetAll()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
