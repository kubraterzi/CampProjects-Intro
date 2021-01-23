using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionayList
{
    public class MyDictionaryList<TKey, TValue>
    {
        // GENERIC YAPILAR VE CONSTRUCTOR SINIFI HAKKINDAKİ DETAYLI BİLGİLER, MyListExample projesinde mevcuttur.

        TKey[] _keys; // Anahtar sözcükleri tutacağımız bir dizinin haberini veriyoruz.
        TValue[] _values; // Değerleri tutacağımız bir dizinin haberini veriyoruz.
        TKey[] tempKeyArray = new TKey[0]; // Anahtar sözcükleri yedekleyeceğimiz geçici dizimiz.(aktaraç)
        TValue[] tempValueArray = new TValue[0]; // Değerleri yedekleyeceğimiz geçici dizimiz.(aktaraç)
        public MyDictionaryList()
        {
            _keys = new TKey[0]; // MyDictionaryList class ımız new lendiği anda çalışan kod bloklarıdır. New leme anında, daha önce haberi verilen dizilerin boyutlarını belirler.
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKeyArray = _keys; // Anahtar sözcükleri,boyutu genişletilmiş yeni dizi üretilmeden önce mevcut verileri yedekliyoruz.
            _keys = new TKey[_keys.Length + 1]; // Mevcut dizinin boyutundan 1 eleman fazla eleman alabilecek yeni bir dizi ürettik.

            tempValueArray = _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++) // boyutu genişletilmiş diziyi yeniden asıl dizimize aktarmak için for döngüsü kullanıyoruz.
            {
                _keys[i] = tempKeyArray[i];
                _values[i] = tempValueArray[i];

            }

            _keys[_keys.Length - 1] = key; // Aktarma tamamlandıktan sonra, dizi sonunda oluşan 1 elemanlık boşluğa anahtar sözcüğümüzü ekliyoruz.
            _values[_values.Length - 1] = value; // Aktarma tamamlandıktan sonra, dizi sonunda oluşan 1 elemanlık boşluğa anahtar sözcüğümüzü ekliyoruz.

        }

        public void GetAll()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(" Key :  {0}  | Value :   {1}", _keys[i] , _values[i]);
            }
        }

    }
}
