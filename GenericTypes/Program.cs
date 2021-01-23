using System;
using System.Collections.Generic;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictList = new Dictionary<string, string>();
            SortedDictionary<string, string> sortedDictList = new SortedDictionary<string, string>();
            dictList.Add("AN", "Anaconda Navigator");
            dictList.Add("VS", "Visual Studio");
            dictList.Add("Ps", "PhotoShop");
            dictList.Add("CC", "Creative Cloud");
            dictList.Add("Id", "InDesign");

            sortedDictList.Add("AN", "Anaconda Navigator");
            sortedDictList.Add("VS", "Visual Studio");
            sortedDictList.Add("Ps", "PhotoShop");
            sortedDictList.Add("CC", "Creative Cloud");
            sortedDictList.Add("Id", "InDesign");


            // Dictionary 
            foreach (KeyValuePair<string, string> keyandValue in dictList)
            {
                Console.WriteLine("Key : {0}   |   Value : {1}", keyandValue.Key, keyandValue.Value);
            }

            Console.WriteLine("---------------------------------------------------------\n");


            // Sorted Dictionary
            foreach (KeyValuePair<string, string> keyandValue in sortedDictList)
            {
                Console.WriteLine("Key : {0}   |   Value : {1}", keyandValue.Key, keyandValue.Value);
            }


            Console.WriteLine("**************************************************************");


            string key = Console.ReadLine();
            string name = Console.ReadLine();
            string backupName = name; // TryGetValue değeri false dönmesi durumunda Value içeriğini null a eşitleyeceği için, null değeri almadan önce bir değişkene atadık ki ekleme 
                                      // işleminde kullanalım.

            // TryGetValue komutu, bir Dictionary Generic yapısı içerisinde tarama yapar. Girilen değerler sözlükte mevcutsa true, değilse false değerini döner.
            // True/false değeri döner.Eğer false değeri dönerse, yapısı gereki value değişkeninin içeriğini boşaltır ve null yapar. Bu sebeple yukarıda, kullanıcıdan gelen bilgiyi, bir
            // değişkene atayarak yeniledik. False değeri dönmesi durumunda, value değişkeninin boş kalmaması için bu yedeği kullanacağız.
            if (dictList.TryGetValue(key, out name))
            {
                
                Console.WriteLine("Search match available.");
                Console.WriteLine(dictList[key]);
            }
            else
            {
                Console.WriteLine("Search match does not exist.");
                dictList.Add(key, backupName); // Değişken false döndürdüğünde, value değerini null yapmıştı. Bu sebeple sözlüğe eşleşme eklerken value kısmı boş kalmasın diye yukarıda 
                                               // yedeklediğimiz veriyi çektik ve kullandık.
                Console.WriteLine("Added");
            }
            foreach (KeyValuePair<string, string> keyandValue in dictList)
            {
                Console.WriteLine("Key : {0}   |   Value : {1}", keyandValue.Key, keyandValue.Value);
            }

        }
    }
}
