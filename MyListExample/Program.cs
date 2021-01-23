using System;
using System.Collections.Generic;


namespace MyListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListGeneric<string> nameList = new MyListGeneric<string>(); 
            nameList.Add("Zeynep");
            nameList.Add("Ahmet");
            nameList.Add("Metin");

            nameList.GetAll();
        }
    }
}
