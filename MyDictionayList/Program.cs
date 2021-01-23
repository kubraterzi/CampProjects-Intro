using System;

namespace MyDictionayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<int, string> myDictionary = new MyDictionaryList<int, string>();
            myDictionary.Add(1, "Kübra");
            myDictionary.Add(2, "Merve");
            myDictionary.Add(3, "Ayşe");

            
            myDictionary.GetAll();

        }
    }
}
