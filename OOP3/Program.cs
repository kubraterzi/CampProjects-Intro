using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // Http istekleri-> HttpGet(mevcut datayı getirir) , HttpPost(data oluşturmak için kullanılır), HttpPut(data güncellemek için kullanılır), HttpDelete(data silmek için kullanılır)
        // Restfull web api nedir ?
        static void Main(string[] args)
        {
            ICreditManager creditManager1 = new CreditType1Manager();
            ICreditManager creditManager2 = new CreditType2Manager();
            ICreditManager creditManager3 = new CreditType3Manager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(creditManager3, new FileLoggerService());
            Console.WriteLine();


            List<ICreditManager> creditList = new List<ICreditManager>() {creditManager1, creditManager3};
            applicationManager.PreliminaryInformation(creditList);

            //foreach (var item in creditList)
            //{
            //    item.Calculate();
            //    item.Information();
            //    Console.WriteLine();
            //}
        }

        

       
    }
}
