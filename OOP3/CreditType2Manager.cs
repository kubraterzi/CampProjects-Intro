using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class CreditType2Manager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated - CreditType2");
        }

        public void Information()
        {
            Console.WriteLine("Bank Rate : 1.3");
        }
    }
}
