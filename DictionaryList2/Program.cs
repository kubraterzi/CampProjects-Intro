using System;

namespace DictionaryList2
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryList2<string, int> List = new DictionaryList2<string, int>();
            List.Add("Kübra", 26);
            List.Add("Ahmet", 13);
            List.Add("Mehmet", 20);

            List.GetAll();

        }
    }
}
